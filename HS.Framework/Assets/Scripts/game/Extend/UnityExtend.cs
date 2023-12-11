using UnityEngine;

namespace Game.Extend
{
    public static class UnityExtend
    {
        public static void ActiveObj(this GameObject self, bool bActive)
        {
            if (self.activeSelf == bActive)
            {
                return;
            }
            self.SetActive(bActive);
        }
    }
}