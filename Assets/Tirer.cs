using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tirer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public AudioSource balle;
    public float speed;
    public Joueur joueur;
    float NombreDeVie;
    float timer;
    float TempsDerniereAttaque;
    Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
        joueur = new Joueur();
        NombreDeVie = joueur.pointsVie;
    }

    void Update()
    {

        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
        timer += Time.deltaTime;

        if (Input.GetMouseButtonDown(0))
        {
            if (TempsDerniereAttaque + joueur.vitesseAttaque <= timer)
            {
                var feu = GetComponentInChildren<ParticleSystem>();
                feu.Play();
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
        balle.Play();
        // Add velocity to the bullet
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * speed;

        // Destroy the bullet after 2 seconds
        Destroy(bullet, 4.0f);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ennemi")
        {
            joueur.pointsVie -= other.GetComponent<DommageDuTireur>().Dommage;
            float valeurX = joueur.pointsVie / NombreDeVie * 2.5f;
            gameObject.transform.Find("Quad").transform.localScale = new Vector3(valeurX, 0.25f, 0.5f);
            if (joueur.pointsVie <= 0)
            {
                animator.SetBool("Mort",true);
                Destroy(GetComponent<MouvementPersonnage>());
                Destroy(GetComponent<RotationDepuisSouris>());
                Destroy(GetComponent<Tirer>());
                Destroy(GetComponent<Rigidbody>());
                Destroy(transform.parent.gameObject, 3f);
                while(!animator.isActiveAndEnabled)
                {

                }
                SceneManager.LoadScene(5);
            }

        }
    }
}



