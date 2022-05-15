using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AudioEffects { jump, gameOver, levelCompleted, drops }

public class AudioManager : MonoBehaviour
{
    [Header("Audio effects")]
    [SerializeField] AudioEffect jump = null;
    [SerializeField] AudioEffect gameOver = null;
    [SerializeField] AudioEffect levelCompleted = null;
    [SerializeField] AudioEffect drops = null;

    [Header("Audio Sources")]
    [SerializeField] AudioSource effectsAudioSource = null;
    public static AudioManager instance= null;

    private void PlayEffect(AudioEffects effect)
    {
        switch (effect)
        {
            case AudioEffects.jump: jump.Play(effectsAudioSource); break;
            case AudioEffects.gameOver: gameOver.Play(effectsAudioSource); break;
            case AudioEffects.levelCompleted: levelCompleted.Play(effectsAudioSource); break;
            case AudioEffects.drops: drops.Play(effectsAudioSource); break;
        }
    }
    // function to make the singelton static
    private void Awake() {
        AudioManager[] objs = FindObjectsOfType<AudioManager>();
        if(objs.Length >1){
            Destroy(this.gameObject);
        }
        else{
            DontDestroyOnLoad(this.gameObject);
            instance = this;
        }
    }

    public static void Play(AudioEffects effect){
        if(instance == null) return;
        instance.PlayEffect(effect);
    }
}
