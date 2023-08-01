using System;
using UnityEngine;

namespace Assets.Code.Scripts.Runtime.Data
{
    [Serializable]
    public sealed class PlayerScore
    {
        [SerializeField, Min(0)]
        private int score = 0;

        public int Score => score;

        public void Increase(int value)
        {
            if (value > 0)
                score += value;
        }
    }
}