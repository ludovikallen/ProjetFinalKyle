using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;
public class GestionnaireSauvegardes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (System.IO.File.Exists("save1.json"))
        {
            GameObject.Find("newSave1_BTN").SetActive(false);
            GameObject.Find("save1_PNL").SetActive(true);
            GameObject.Find("deleteSave1_BTN").GetComponent<Button>().onClick.AddListener(() =>
            {
                File.Delete("save1.json");
                SceneManager.LoadScene(2);
            });
        }
        else
        {
            GameObject.Find("save1_PNL").SetActive(false);
            GameObject.Find("deleteSave1_BTN").SetActive(false);
            GameObject.Find("newSave1_BTN").GetComponent<Button>().onClick.AddListener(() =>
            {
                Joueur nouveauJoueur = new Joueur();
                nouveauJoueur.SérialiserVersSortie(new StreamWriter("save1.json"));
                SceneManager.LoadScene(1);
            });
        }
        if (System.IO.File.Exists("save2.json"))
        {
            GameObject.Find("newSave2_BTN").SetActive(false);
            GameObject.Find("save2_PNL").SetActive(true);
            GameObject.Find("deleteSave2_BTN").GetComponent<Button>().onClick.AddListener(() =>
            {
                File.Delete("save2.json");
                SceneManager.LoadScene(2);
            });
        }
        else
        {
            GameObject.Find("save2_PNL").SetActive(false);
            GameObject.Find("deleteSave2_BTN").SetActive(false);
            GameObject.Find("newSave2_BTN").GetComponent<Button>().onClick.AddListener(() =>
            {
                Joueur nouveauJoueur = new Joueur();
                nouveauJoueur.SérialiserVersSortie(new StreamWriter("save2.json"));
                SceneManager.LoadScene(1);
            });
        }
        if (System.IO.File.Exists("save3.json"))
        {
            GameObject.Find("newSave3_BTN").SetActive(false);
            GameObject.Find("save3_PNL").SetActive(true);
            GameObject.Find("deleteSave3_BTN").GetComponent<Button>().onClick.AddListener(() =>
            {
                File.Delete("save3.json");
                SceneManager.LoadScene(2);
            });
        }
        else
        {
            GameObject.Find("save3_PNL").SetActive(false);
            GameObject.Find("deleteSave3_BTN").SetActive(false);
            GameObject.Find("newSave3_BTN").GetComponent<Button>().onClick.AddListener(() =>
            {
                Joueur nouveauJoueur = new Joueur();
                nouveauJoueur.SérialiserVersSortie(new StreamWriter("save3.json"));
                SceneManager.LoadScene(1);
            });
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
