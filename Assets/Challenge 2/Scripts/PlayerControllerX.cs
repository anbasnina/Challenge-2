using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private bool pressed = true;
    private float delayShoot = 1.0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && pressed)
        {
            pressed = false;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            Invoke("waitingShooting", delayShoot);
        }
    }

    void waitingShooting()
    {
        pressed = true;
    }
}