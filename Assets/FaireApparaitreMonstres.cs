using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaireApparaitreMonstres : MonoBehaviour
{
    public GameObject monster;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(monster, new Vector3(5, 0, 5), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
