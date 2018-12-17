using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GestionnaireOptions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Volume_SLDR").GetComponent<Slider>().onValueChanged.AddListener((value) => {
            GameObject.FindGameObjectWithTag("Music").GetComponent<AudioSource>().volume = value;
            StatistiquesJeu.volumeMusique = value;
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
