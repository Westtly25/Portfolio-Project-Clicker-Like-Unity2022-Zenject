using UnityEngine;

namespace Assets.Scripts.Runtime.Core
{
    public class ClicksManager
    {
        [SerializeField]
        private Clicks clicks;

        private void OnClick(int amount)
        {
            if (amount > 0)
                clicks.Increase(amount);
        }
    }
}