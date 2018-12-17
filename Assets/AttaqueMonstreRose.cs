using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttaqueMonstreRose : MonoBehaviour
{
    GameObject Joueur;
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float speed;
    public float timeBetweenAttacks = 0.5f;
    public float nombreDeVie = 10;
    public float nombreDeVieMax = 10;
    public float Dommage = 5f;
    float timer;
    float TempsDerniereAttaque;
    void Start()
    {
        Joueur = GameObject.Find("Joueur");
        transform.LookAt(Joueur.transform.GetChild(0).transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if(Joueur != null)
        {
            transform.LookAt(Joueur.transform.GetChild(0).transform.position);
            timer += Time.deltaTime;
            transform.position += transform.forward * Time.deltaTime;
            if (TempsDerniereAttaque + timeBetweenAttacks <= timer)
            {
                TempsDerniereAttaque = timer;
                Fire();
            }
        }
    }
    void Fire()
    {
        // Create the Bullet from the Bullet Prefab
        var bullet = (GameObject)Instantiate(
            bulletPrefab,
            bulletSpawn.position,
            bulletSpawn.rotation);

        // Add velocity to the bullet
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * speed;
        bullet.GetComponent<DommageDuTireur>().Dommage = Dommage;
        // Destroy the bullet after 2 seconds
        Destroy(bullet, 1.0f);
    }
}
