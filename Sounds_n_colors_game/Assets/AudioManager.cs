using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource BGM;

    public void ChangeBGM(AudioClip music)
    {
        BGM.Stop();
        BGM.clip = music;
        BGM.Play();
    }
}
