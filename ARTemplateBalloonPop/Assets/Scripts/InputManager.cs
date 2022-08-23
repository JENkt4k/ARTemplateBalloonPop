using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class InputManager : MonoBehaviour
{
    private TouchControls touchControls;

    //public Camera arCamera;

    //public GameObject popSoundObject;
    //public AudioClip popSoundClip;

    //public AudioSource audioSource;

    public ShootScript shooter;

    //public static int score;

    //public Text scoreText;

    private void Awake()
    {
        touchControls = new TouchControls();
    }

    private void OnEnable()
    {
        touchControls.Enable();
    }

    private void OnDisable()
    {
        touchControls.Disable();
    }
    //// Start is called before the first frame update
    void Start()
    {
        touchControls.Touch.TouchPress.started += ctx => StartTouch(ctx);
        touchControls.Touch.TouchPress.started += ctx => EndTouch(ctx);
    }

    private void StartTouch(InputAction.CallbackContext context)
    {

        Debug.Log("Test start " + touchControls.Touch.TouchPosition.ReadValue<Vector2>());
        Debug.Log("Test start " + touchControls.Touch.TouchStartPosition.ReadValue<Vector2>());
        shooter.TouchShoot(touchControls.Touch.TouchStartPosition.ReadValue<Vector2>());
        //Shoot();
    }

    private void EndTouch(InputAction.CallbackContext context)
    {
        Debug.Log("Test end " + touchControls.Touch.TouchPosition.ReadValue<Vector2>());
    }

    //public void Shoot()
    //{
    //    RaycastHit hit;
    //    Vector2 position = touchControls.Touch.TouchPosition.ReadValue<Vector2>();
    //    Vector3 realWorldPosition = new Vector3(position.x, position.y, arCamera.nearClipPlane);
    //    Ray r = arCamera.ScreenPointToRay(position);
    //    Vector3 screenToWorld = r.origin; //arCamera.ScreenToWorldPoint(realWorldPosition);
        
    //    screenToWorld.z = 0;

    //    Debug.Log("Testing Shoot2 " + position.ToString());
    //    Debug.Log("Testing Shoot2 rwp " + realWorldPosition.ToString());
    //    Debug.Log("Testing Shoot2 screenToWorld " + screenToWorld.ToString());

    //    if (Physics.Raycast(r, out hit)) //realWorldPosition //screenToWorld , arCamera.transform.forward, 
    //    {
    //        Debug.Log("Testing Shoot2 hit " + hit.transform.position.ToString());
    //        Debug.Log("Testing Shoot2 screenToWorld " + screenToWorld.ToString());
    //        if (hit.transform.name.Contains("balloon"))
    //        {
    //            Destroy(hit.transform.gameObject);

    //            //Instantiate(popSoundObject);
    //            if (audioSource != null)
    //            {
    //                //GetComponent<AudioSource>().PlayOneShot(popSoundClip);
    //                audioSource.Play();
    //            }


    //            score += 1;

    //            //scoreText.text = score + "";
    //        }
    //    }
    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}
}
