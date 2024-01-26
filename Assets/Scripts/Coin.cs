using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public AudioClip coinClip;
    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player")
        {
            SoundManagerSC.audioSource.PlayOneShot(coinClip);
            Cointext.coinsayisi += 1;
            Destroy(gameObject);
        }
    }
}
