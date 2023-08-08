using System;
using UnityEngine;

namespace Assets.Scripts.Runtime.Core
{
    [Serializable]
    public class Clicks
    {
        [SerializeField]
        private int count;

        public int Count => count;

        public void Increase(int amount)
        {
            if (amount > 0)
                count += amount;
        }
    }
}