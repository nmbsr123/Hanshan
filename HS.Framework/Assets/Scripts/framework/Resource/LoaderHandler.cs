using UnityEngine;

namespace Framework
{
    public class LoaderHandler
    {
        public BaseLoadStrategy loadStrategy = null;
        public BundleEntity bundleEntity = null;
        public UnityEngine.Object asset = null;

        public void Unload()
        {
            if (loadStrategy != null && bundleEntity != null)
            {
                loadStrategy.Unload(bundleEntity.BundleName);
            }

            bundleEntity = null;
            asset = null;
        }
    }
}