using UnityEngine;
using System.Collections;

namespace Assets.Code.Scripts.Runtime.Utilities
{
    public class CoroutineRunner : MonoBehaviour, ICoroutineRunner
    {
        public new Coroutine StartCoroutine(IEnumerator coroutine) =>
             base.StartCoroutine(coroutine);

        public new void StopCoroutine(IEnumerator coroutine)
        {
            if (WasDisposed())
                return;

            base.StopCoroutine(coroutine);
        }

        private bool WasDisposed() =>
            this == null;

    }
}