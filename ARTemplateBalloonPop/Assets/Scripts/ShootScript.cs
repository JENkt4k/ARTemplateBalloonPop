using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootScript : MonoBehaviour
{
    public Camera arCamera;

    public GameObject popSoundObject;

    public static int score;

    public Text scoreText;

    public void Shoot()
    {
        RaycastHit hit;

        if (Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
        {
            if (hit.transform.name.Contains("balloon"))
            {
                Destroy(hit.transform.gameObject);

                Instantiate(popSoundObject);

                score += 1;

                scoreText.text = score + "";
            }
        }
    }
}
