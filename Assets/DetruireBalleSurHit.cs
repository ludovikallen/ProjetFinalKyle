using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetruireBalleSurHit : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        var particule = gameObject.GetComponent<ParticleSystem>();
        particule.Play();
        //Destroy this gameobject
        Destroy(gameObject, particule.main.duration - 0.10f);
    }
}