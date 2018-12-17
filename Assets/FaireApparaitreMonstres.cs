using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaireApparaitreMonstres : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Resources.Load("MonstreRose"), new Vector3(5, 0, 5), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
