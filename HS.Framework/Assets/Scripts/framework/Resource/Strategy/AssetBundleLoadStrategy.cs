using System;
using System.Linq;
using System.Text;

namespace framework
{
    public class AssetBundleLoadStrategy : BaseLoadStrategy
    {
        private StringBuilder _stringBuilder = new StringBuilder(20);
        private AssetBundleManager mAssetBundleManager => AssetBundleManager.Instance;
        private const string _abextend = ".unity3d";
            
        public AssetBundleLoadStrategy()
        {
            AssetBundleManager.CreateInstance();
            mAssetBundleManager.Init();
        }

        public override LoaderHandler LoadSync<T>(string path)
        {
            var bundleName = ParsePath(path);
            BundleEntity bundleEntity = mAssetBundleManager.LoadBundleEntitySync(bundleName);
            var asset = bundleEntity.AbBundle.LoadAsset<T>(path);
            return new LoaderHandler()
            {
                loadStrategy = this,
                bundleEntity = bundleEntity,
                asset = asset
            };
        }

        public override LoaderHandler LoadAync<T>(string path, Action<UnityEngine.Object> onComplete)
        {
            var bundleName = ParsePath(path);
            LoaderHandler loaderHandler = new LoaderHandler();
            loaderHandler.loadStrategy = this;
            mAssetBundleManager.LoadBundleEntityAsync(bundleName, entity =>
            {
                loaderHandler.bundleEntity = entity;
                loaderHandler.asset = entity.AbBundle.LoadAsset<T>(path);
                onComplete?.Invoke(loaderHandler.asset);
            });
            return loaderHandler;
        }

        /// <summary>
        /// 根据path解析，返回bundleName
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private string ParsePath(string path)
        {
            path = path.ToLower();
            int targetIndex = 0;
            for (int i = path.Length - 1; i >= 0; i--)
            {
                if (path[i] == '/')
                {
                    targetIndex = i;
                    break;
                }
            }

            _stringBuilder.Clear();
            if (path.Contains("allinone"))
            {
                return path.Substring(0, targetIndex) + ".unity3d";
            }
            else
            {
                var newPath = path.Substring(0, path.LastIndexOf('.'));
                _stringBuilder.Append(newPath);
                _stringBuilder.Append(_abextend);
                return _stringBuilder.ToString();
            }
        }
        
        public override void Unload(string bundleName)
        {
            mAssetBundleManager.Unload(bundleName);
        }

        public override void Dispose()
        {
            mAssetBundleManager.Dispose();
        }
    }
}