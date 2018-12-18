using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetruireBalleSurHit : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        var particule = gameObject.GetComponent<ParticleSystem>();
        if(particule != null)
        {
            particule.Play();
            Destroy(gameObject, particule.main.duration - 0.10f);
        }
        else
        {
            Destroy(gameObject);
        }
        //Destroy this gameobject
    }
}