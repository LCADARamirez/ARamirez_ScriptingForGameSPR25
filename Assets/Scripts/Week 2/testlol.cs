using UnityEngine;
using UnityEngine.Audio;

public class testlol : MonoBehaviour
{
    public AudioSource musicSource;

    public AudioClip music1;
    public AudioClip music2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayMusicTrack1();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlayMusicTrack1()
    {
        musicSource.Stop();
        musicSource.clip = music1;
        musicSource.Play();
    }

    void PlayMusicTrack2()
    {
        musicSource.Stop();
        musicSource.clip = music2;
        musicSource.Play();
    }
}
