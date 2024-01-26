using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Shoot : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;
    public AudioClip bulletSound;
    public Animator Shooting;

    private void Awake()
    {
        Shooting = GetComponentInChildren<Animator>();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Shooting.SetTrigger("Shoot");
            SoundManagerSC.audioSource.PlayOneShot(bulletSound);
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
        }
    }
}
