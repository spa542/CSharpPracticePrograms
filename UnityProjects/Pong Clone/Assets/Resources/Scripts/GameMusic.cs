using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMusic : MonoBehaviour
{
    public AudioSource gameMusic;

    public void PlayMusic()
    {
        gameMusic.Play();
    }
}
