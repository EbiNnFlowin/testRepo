﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioSource WallSound;
    public AudioSource PaddleSound;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name =="RacketPlayer1" || collision.gameObject.name == "RacketPlayer2")
        {
            this.PaddleSound.Play();
        } else
        {
            this.WallSound.Play();
        }
    }
}
