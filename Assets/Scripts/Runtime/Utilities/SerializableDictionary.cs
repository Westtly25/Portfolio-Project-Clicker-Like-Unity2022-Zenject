using System;
using System.Linq;
using UnityEngine;
using System.Collections.Generic;

namespace Assets.Code.Scripts.Runtime.Utilities
{
    [Serializable]
    public abstract class SerializableDictionary<TKey, TValue> : ISerializationCallbackReceiver
    {
        public Dictionary<TKey, TValue> Dictionary = new();

        [SerializeField]
        private TKey[] _keys;
        [SerializeField]
        private TValue[] _values;

        public void OnBeforeSerialize()
        {
            _keys = Dictionary.Keys.ToArray();
            _values = Dictionary.Values.ToArray();
        }

        public void OnAfterDeserialize()
        {
            for (int i = 0; i < _keys.Length; i++)
                Dictionary.Add(_keys[i], _values[i]);
        }
    }
}
