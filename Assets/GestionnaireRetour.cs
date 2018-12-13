using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GestionnaireRetour : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        GetComponent<Button>().onClick.AddListener(() => { SceneManager.LoadScene(0); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
