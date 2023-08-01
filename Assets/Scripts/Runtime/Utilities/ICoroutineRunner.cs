using UnityEngine;
using System.Collections;

namespace Assets.Code.Scripts.Runtime.Utilities
{
    public interface ICoroutineRunner
    {
        Coroutine StartCoroutine(IEnumerator coroutine);
    }
}
