using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMusicTrigger : MonoBehaviour
{
    public AudioClip newTrack;
    private AudioManager theAM;

    void Start()
    {
        theAM = FindObjectOfType<AudioManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (newTrack != null)
                theAM.ChangeBGM(newTrack);
        }
    }
}
