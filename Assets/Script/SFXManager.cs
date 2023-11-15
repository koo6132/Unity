using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine;


public class SFXManager : MonoBehaviour
{
    public AudioMixer mixer;
    public AudioSource SFX;
    public AudioClip[] bglist;

    public static SFXManager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void SFXSoundPlay(AudioClip clip)
    {
        SFX.outputAudioMixerGroup = mixer.FindMatchingGroups("SFX")[0];
        SFX.clip = clip;
        SFX.Play();
    }
}