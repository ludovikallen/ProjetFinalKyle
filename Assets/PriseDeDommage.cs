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
            Destroy(gameObject.transform.parent.transform.parent.gameObject);
        }
    }
}
