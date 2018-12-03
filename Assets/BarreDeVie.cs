using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarreDeVie : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = (gameObject.transform.parent.transform.parent.GetComponent<AttaqueMonstreRose>().nombreDeVie / gameObject.transform.parent.transform.parent.GetComponent<AttaqueMonstreRose>().nombreDeVieMax) * 5f;
        gameObject.transform.localScale = new Vector3(x, 0.5f, 1f);
    }
}
