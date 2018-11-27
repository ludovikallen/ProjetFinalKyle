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

        Destroy(gameObject, 1f);
    }
}
