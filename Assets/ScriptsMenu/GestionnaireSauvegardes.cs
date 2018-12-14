using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;
public class GestionnaireSauvegardes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        VerifierEtatSauvegarde("1");
        VerifierEtatSauvegarde("2");
        VerifierEtatSauvegarde("3");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void VerifierEtatSauvegarde(string numSauvegarde)
    {
        if (System.IO.File.Exists("save" + numSauvegarde + ".json"))
        {
            GameObject.Find("newSave"+numSauvegarde+"_BTN").SetActive(false);
            GameObject.Find("save" + numSauvegarde + "_PNL").SetActive(true);
            GameObject.Find("deleteSave" + numSauvegarde + "_BTN").GetComponent<Button>().onClick.AddListener(() =>
            {
                File.Delete("save" + numSauvegarde + ".json");
                SceneManager.LoadScene(2);
            });
            Joueur joueur = Joueur.DésérialiserFichier("save" + numSauvegarde + ".json");
            GameObject.Find("pointsVie" + numSauvegarde + "_TXT").GetComponent<Text>().text = joueur.pointsVie.ToString();
            GameObject.Find("pointsAttaque" + numSauvegarde + "_TXT").GetComponent<Text>().text = joueur.pointsAttaque.ToString();
            GameObject.Find("save" + numSauvegarde + "_PNL").GetComponent<Button>().onClick.AddListener(() =>
            {
                StatistiquesJeu.joueurPrincipal = Joueur.DésérialiserFichier("save1.json");
                StatistiquesJeu.niveauCourant = StatistiquesJeu.joueurPrincipal.niveauMax;
                SceneManager.LoadScene(1);
            });
        }
        else
        {
            GameObject.Find("save" + numSauvegarde + "_PNL").SetActive(false);
            GameObject.Find("deleteSave" + numSauvegarde + "_BTN").SetActive(false);
            GameObject.Find("newSave" + numSauvegarde + "_BTN").GetComponent<Button>().onClick.AddListener(() =>
            {
                Joueur nouveauJoueur = new Joueur();
                nouveauJoueur.SérialiserVersSortie(new StreamWriter("save" + numSauvegarde + ".json"));
                SceneManager.LoadScene(1);
            });
        }
    }
}
