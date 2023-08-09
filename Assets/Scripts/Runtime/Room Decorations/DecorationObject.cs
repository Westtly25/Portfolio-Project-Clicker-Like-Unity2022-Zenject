﻿using UnityEngine;

namespace Assets.Scripts.Runtime.Room_Decorations
{
    [RequireComponent (typeof (SpriteRenderer))]
    public class DecorationObject : MonoBehaviour
    {
        [SerializeField]
        private Sprite sprite;

        [SerializeField]
        private SpriteRenderer spriteRenderer;

        private void Awake() =>
            spriteRenderer = GetComponent<SpriteRenderer>();
    }
}