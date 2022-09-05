using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AAClone.Abstracts.Utilities;


namespace AAClone.Manager
{
    public class SoundManager : Singleton<SoundManager>
    {
        [SerializeField] AudioSource[] audioSources;
        [SerializeField] AudioClip audioClip;

        private void Awake()
        {
            SingletonThisGameObject(this);
            audioSources = GetComponentsInChildren<AudioSource>();
        }

        public void PlaySound(int index)
        {
           
                if (!audioSources[index].isPlaying)
                {
                    audioSources[index].Play();
                }
            
           
           
        }

        public void StopSound(int index)
        {
            if (audioSources[index].isPlaying)
            {
                audioSources[index].Stop();

            }
        }

        public void HitSound()
        {
            audioSources[1].PlayOneShot(audioClip);
        }



    }

}

