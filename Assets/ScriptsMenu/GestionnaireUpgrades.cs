using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;
public class GestionnaireUpgrades : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("CompteurPoints_TXT").GetComponent<TextMeshProUGUI>().text = StatistiquesJeu.joueurPrincipal.points + " points";

        GameObject.Find("ContinueGame_BTN").GetComponent<Button>().onClick.AddListener(() => { 
            //LOAD NEXT LEVEL 
        });
        GameObject.Find("SaveAndQuitGame_BTN").GetComponent<Button>().onClick.AddListener(() => {
            StatistiquesJeu.joueurPrincipal.SérialiserVersSortie(new StreamWriter(StatistiquesJeu.nomSauvegarde));
            Application.Quit();
        });
        GameObject.Find("").GetComponent<Button>().onClick.AddListener(() => {
            GameObject.Find("CompteurPoints_TXT").GetComponent<TextMeshProUGUI>().text = StatistiquesJeu.joueurPrincipal.points + " points";
        });
    
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}