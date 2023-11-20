using System.Collections.Generic;

namespace framework
{
    public class TimerManager : Singleton<TimerManager>, IManager, IGameUpdate, IGameFixUpdate
    {
        private int _updateIndex = -1;
        private List<GameTimer> _updateTimers = new List<GameTimer>();
        private List<GameTimer> _fixedUpdateTimers = new List<GameTimer>();
        private List<int> _removeCache = new List<int>();
        public void Init()
        {
            _updateIndex = -1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="time">间隔时间</param>
        /// <param name="timerFunction">回调函数</param>
        /// <param name="loopTimes">执行次数，默认参数为-1，表示无限循环</param>
        /// <returns></returns>
        public int AddTimer(float time, TimerFunction timerFunction, int loopTimes = -1)
        {
            if (loopTimes <= 0)
            {
                GameLog.Error("AddTimer Error");
                return -1;
            }
            _updateTimers.Add(new GameTimer(++_updateIndex, time, timerFunction, loopTimes));
            return _updateIndex;
        }

        public void Dispose()
        {
            _updateTimers.Clear();
            _fixedUpdateTimers.Clear();
            _updateIndex = -1;
        }

        public void Update(float deltaTime)
        {
            if (_updateTimers.Count == 0)
            {
                return;
            }
            _removeCache.Clear();
            foreach (var timer in _updateTimers)
            {
                timer.AddTime(deltaTime);
                //计时器到时间了
                if (timer.IsDone)
                {
                    //执行回调，循环次数-1
                    timer.Invoke();
                    //如果无限循环
                    if (timer.IsInfinite)
                    {
                        timer.Reset();
                    }
                    else
                    {
                        //如果循环次数为0，需要移除
                        if (timer.LoopTimes <= 0)
                        {
                            _removeCache.Add(timer.Id);
                        }
                        else
                        {
                            timer.Reset();
                        }
                    }
                }
            }

            foreach (var index in _removeCache)
            {
                _updateTimers.RemoveAt(index);
            }
        }

        public void FixedUpdate()
        {
            
        }
    }
}