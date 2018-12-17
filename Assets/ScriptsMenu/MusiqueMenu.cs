using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusiqueMenu : MonoBehaviour
{
    private AudioSource _audioSource;

    private static MusiqueMenu instance = null;
    public static MusiqueMenu Instance
    {
        get { return instance; }
    }
    void Awake()
    {
        if (instance != null && instance != this) {
            Destroy(gameObject);
            return;
        } else {
            instance = this;
            DontDestroyOnLoad(gameObject);
            _audioSource = GetComponent<AudioSource>();
        }  
    }

    public void PlayMusic()
    {
        if (_audioSource == null) return;
        if (_audioSource.isPlaying) return;
        _audioSource.Play();
    }

    public void StopMusic()
    {
        _audioSource.Stop();
    }
}
