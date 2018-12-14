using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GestionnaireMenu : MonoBehaviour
{
    Button[] buttons;
    GameObject mainCanevas;
    // Use this for initialization

    // Start is called before the first frame update
    void Awake()
    {
        buttons = GetComponentsInChildren<Button>();
        buttons[0].onClick.AddListener(() => { SceneManager.LoadScene(2); });
        buttons[1].onClick.AddListener(() => {
            //LOADER
            SceneManager.LoadScene(2); });
        buttons[2].onClick.AddListener(() => { SceneManager.LoadScene(3); });
        buttons[3].onClick.AddListener(() => { SceneManager.LoadScene(4); });
        buttons[4].onClick.AddListener(() => { Application.Quit(); });


        if (System.IO.File.Exists("save1.json"))
            if (System.IO.File.Exists("save2.json"))
                if (System.IO.File.Exists("save3.json"))
                    buttons[0].interactable = false;

        if (!System.IO.File.Exists("save1.json"))
            if (!System.IO.File.Exists("save2.json"))
                if (!System.IO.File.Exists("save3.json"))
                    buttons[1].interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
