using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PriseDeDommage : MonoBehaviour
{
    void Start()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag =="Joueur")
        {
            gameObject.transform.parent.transform.parent.GetComponent<AttaqueMonstreRose>().nombreDeVie -= 1;
            if (gameObject.transform.parent.transform.parent.GetComponent<AttaqueMonstreRose>().nombreDeVie <= 0)
            {
                Destroy(gameObject.transform.parent.transform.parent.gameObject);
            }
        }
    }
}
