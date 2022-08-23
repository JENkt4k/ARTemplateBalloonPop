using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class ShootScript : MonoBehaviour
{
    public Camera arCamera;

    public GameObject popSoundObject;
    public AudioClip popSoundClip;

    public AudioSource audioSource;

    public static int score;

    public Text scoreText;

    public void Shoot()
    {
        RaycastHit hit;
        Debug.Log("Testing 1 2 3 in shoot method ");

        if (Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
        {
            Debug.Log("Testing Shoot origin hit " + hit.transform.position.ToString());
            if (hit.transform.name.Contains("balloon"))
            {
                Destroy(hit.transform.gameObject);

                //Instantiate(popSoundObject);
                if(audioSource != null)
                {
                    //GetComponent<AudioSource>().PlayOneShot(popSoundClip);
                    audioSource.Play();
                }
                

                score += 1;

                scoreText.text = score + "";
            }
        }
    }
}
