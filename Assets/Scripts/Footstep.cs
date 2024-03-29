using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footstep : MonoBehaviour
{
    public AudioSource footstepSound, sprintstepSound;
    void Update()
    {
        if((Input.GetKey(KeyCode.W)) || (Input.GetKey(KeyCode.A)) || (Input.GetKey(KeyCode.S)) || (Input.GetKey(KeyCode.D)))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                footstepSound.enabled = false;
                sprintstepSound.enabled = true;
            }
            else
            {
                footstepSound.enabled = true;
                sprintstepSound.enabled = false;
            }
        }
        else
        {
            footstepSound.enabled =false;
            sprintstepSound.enabled = false;
        }
    }
}
