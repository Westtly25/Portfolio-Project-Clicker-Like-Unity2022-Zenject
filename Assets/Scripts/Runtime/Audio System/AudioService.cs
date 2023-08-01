using Zenject;
using UnityEngine;
using UnityEngine.Audio;
using System.Collections.Generic;
using Assets.Code.Scripts.Runtime.Asset_Management;

namespace Assets.Code.Scripts.Runtime.Audio_System
{
    public class AudioService : IAudioService, IInitializable
    {
        [Header("Components")]
        private AudioMixer mainAudioMixer;

        [Header("Cached Data")]
        private Dictionary<SoundType, AudioClip> cachedAudio;

        [Header("Injected Data")]
        private readonly IAssetProvider assetProvider;

        [Inject]
        public AudioService(IAssetProvider assetProvider)
        {
            this.assetProvider = assetProvider;
        }

        public async void Initialize()
        {
            mainAudioMixer = await assetProvider.Load<AudioMixer>(AssetAddress.MainAudioMixer);

#if UNITY_EDITOR
            if (mainAudioMixer == null)
                Debug.LogError($"Audio mixer by adress {AssetAddress.MainAudioMixer} is empty");
#endif
        }

        public void PlayOneShotSound(SoundType soundType)
        {
        }

        public void PlayLoopSound(SoundType soundType)
        {
        }
    }
}
