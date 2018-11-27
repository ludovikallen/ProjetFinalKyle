using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetruireBalleSurHit : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        //Destroy this gameobject
        Destroy(gameObject);
    }
}
