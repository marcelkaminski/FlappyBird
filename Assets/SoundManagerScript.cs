using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip explosion, hurt, jump, score, marios_way;
    static AudioSource audioSrc;
    void Start()
    {
        explosion = Resources.Load<AudioClip> ("Sounds/explosion");
        hurt = Resources.Load<AudioClip> ("Sounds/hurt");
        jump = Resources.Load<AudioClip> ("Sounds/jump");
        score = Resources.Load<AudioClip> ("Sounds/score");
        marios_way = Resources.Load<AudioClip> ("Sounds/marios_way");

        audioSrc = GetComponent<AudioSource> ();
    }



    public static void PlaySound (string clip)
    {
        switch(clip)
        {
            case "explosion":
                audioSrc.PlayOneShot (explosion);
                break;
            case "hurt":
                audioSrc.PlayOneShot (hurt);
                break;
            case "jump":
                audioSrc.PlayOneShot (jump);
                break;
            case "score":
                audioSrc.PlayOneShot (score);
                break;
            case "marios_way":
                audioSrc.PlayOneShot (marios_way);
                break;           
        }
    }
}
