using System;
using UnityEngine;

namespace Assets.Code.Scripts.Runtime.Data
{
    [Serializable]
    public sealed class ShipData
    {
        [SerializeField, Range(0.1f, 10f)]
        private float width;
        [SerializeField, Range(0.1f, 10f)]
        private float height;
    }
}