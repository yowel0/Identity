
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    public AudioClip background;
    public AudioClip SFX;

    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();

        SFXSource.clip = SFX;
        SFXSource.Play();

        
    }

    public void PlaySFX(AudioClip clip) 
    { 
        SFXSource.PlayOneShot(clip);

    }
}

