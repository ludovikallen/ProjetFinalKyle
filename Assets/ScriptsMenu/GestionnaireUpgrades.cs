using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;
using UnityEngine.SceneManagement;
public class GestionnaireUpgrades : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // StatistiquesJeu.joueurPrincipal.niveau++;
        GameObject.FindGameObjectWithTag("Music").GetComponent<MusiqueMenu>().PlayMusic();
        AfficherVariables();
        VerifierCouts();
        GameObject.Find("arme_DDOWN").GetComponent<Dropdown>().value = GameObject.Find("arme_DDOWN").GetComponent<Dropdown>().options.FindIndex((i) => { return i.text.Equals(StatistiquesJeu.joueurPrincipal.arme); });
        GameObject.Find("ContinueGame_BTN").GetComponent<Button>().onClick.AddListener(() => {
            StatistiquesJeu.joueurPrincipal.SérialiserVersSortie(new StreamWriter(StatistiquesJeu.nomSauvegarde));
            SceneManager.LoadScene(1);
            GameObject.FindGameObjectWithTag("Music").GetComponent<MusiqueMenu>().StopMusic();
        });
        GameObject.Find("SaveAndQuitGame_BTN").GetComponent<Button>().onClick.AddListener(() => {
            StatistiquesJeu.joueurPrincipal.SérialiserVersSortie(new StreamWriter(StatistiquesJeu.nomSauvegarde));
            SceneManager.LoadScene(0);
        });
        GameObject.Find("UpgradeHP_BTN").GetComponent<Button>().onClick.AddListener(() => {
            StatistiquesJeu.joueurPrincipal.points -= 100;
            StatistiquesJeu.joueurPrincipal.pointsVie++;
            AfficherVariables();
            VerifierCouts();
        });
        GameObject.Find("arme_DDOWN").GetComponent<Dropdown>().onValueChanged.AddListener((value) => {
            if (value == 0)
            {
                StatistiquesJeu.joueurPrincipal.arme = "Normal gun";
                StatistiquesJeu.joueurPrincipal.pointsAttaque = 2;
                StatistiquesJeu.joueurPrincipal.vitesseAttaque = 0.5f;
            }
            else if (value == 1)
            {
                StatistiquesJeu.joueurPrincipal.arme = "Machine gun";
                StatistiquesJeu.joueurPrincipal.pointsAttaque = 1;
                StatistiquesJeu.joueurPrincipal.vitesseAttaque = 0.25f;
            }
            else if (value == 2)
            {
                StatistiquesJeu.joueurPrincipal.arme = "Bazooka";
                StatistiquesJeu.joueurPrincipal.pointsAttaque = 3;
                StatistiquesJeu.joueurPrincipal.vitesseAttaque = 0.75f;
            }
            AfficherVariables();
        });
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void AfficherVariables()
    {
        GameObject.Find("CompteurPoints_TXT").GetComponent<TextMeshProUGUI>().text = StatistiquesJeu.joueurPrincipal.points + " points";
        GameObject.Find("pointsVie_TXT").GetComponent<TextMeshProUGUI>().text = StatistiquesJeu.joueurPrincipal.pointsVie + " points";
        GameObject.Find("pointsDegats_TXT").GetComponent<TextMeshProUGUI>().text = StatistiquesJeu.joueurPrincipal.pointsAttaque + " points";
        GameObject.Find("vitesseAttaque_TXT").GetComponent<TextMeshProUGUI>().text = 1/StatistiquesJeu.joueurPrincipal.vitesseAttaque + " attaques par seconde";
    }

    void VerifierCouts()
    {
        if (StatistiquesJeu.joueurPrincipal.points < 100)
            GameObject.Find("UpgradeHP_BTN").GetComponent<Button>().interactable = false;
        else
            GameObject.Find("UpgradeHP_BTN").GetComponent<Button>().interactable = true;
    }
}