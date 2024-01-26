using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public AudioClip trapClip;
    private void OnTriggerEnter(Collider collision) {
        if(collision.transform.tag == "Player"){
            SoundManagerSC.audioSource.PlayOneShot(trapClip);
            karakterstats.health -= 50;
        }
        
    }
    
}
