using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            StartCoroutine(cooldown());
            return;
        }
    }
    IEnumerator cooldown()
    {
        yield return new WaitForSeconds(1);
        karakterstats.health -= 50;
        
    }

}
    
