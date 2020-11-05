using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fase2 : MonoBehaviour
{

    public GameObject porta;
    public GameObject player;
    public AudioSource winSound;
    Boolean tokoh = false;

    void Update()
    {
        if (player.transform.position.x > porta.transform.position.x && tokoh == false)
        {
            PlayEndSound();
            tokoh = true;
            StartCoroutine("EndLevel");
        }
    }

    void PlayEndSound()
    {
        winSound.Play();
    }
    IEnumerator EndLevel()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
