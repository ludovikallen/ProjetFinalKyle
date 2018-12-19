using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GestionnaireJeu : MonoBehaviour
{

    int MontresaSpawn;
    // Start is called before the first frame update
    void Start()
    {
        GenererMonstre();
        GenererMap();

    }
    public void GenererMonstre()
    {
        GameObject monstre;
        StatistiquesJeu.monstresRestants = StatistiquesJeu.joueurPrincipal.niveau + 1;
        for (int i = 0; i < StatistiquesJeu.monstresRestants; i++)
        {
              ////MontresaSpawn = Random.Range(1, 3);
             //if (MontresaSpawn == 1)
            //{
                monstre = Instantiate(Resources.Load("Prefabs/MonstreRose"), new Vector3(Random.Range(-40, +40), 0, Random.Range(-40, 40)), Quaternion.identity) as GameObject;
                monstre.GetComponent<AttaqueMonstreRose>().Dommage = StatistiquesJeu.joueurPrincipal.niveau / 2;
                monstre.GetComponent<AttaqueMonstreRose>().nombreDeVieMax = StatistiquesJeu.joueurPrincipal.niveau + 1;
                monstre.GetComponent<AttaqueMonstreRose>().nombreDeVie = StatistiquesJeu.joueurPrincipal.niveau + 1;
                monstre.GetComponent<AttaqueMonstreRose>().speed = StatistiquesJeu.joueurPrincipal.niveau + 35;
                monstre.GetComponent<AttaqueMonstreRose>().timeBetweenAttacks = 5F - ((float)StatistiquesJeu.joueurPrincipal.niveau / 5f);
            //}
         
            //  if (MontresaSpawn == 2)
            //{
            //    monstre = Instantiate(Resources.Load("Prefabs/MonstreBlue"), new Vector3(Random.Range(-40, +40), 0, Random.Range(-40, 40)), Quaternion.identity) as GameObject;
            //   monstre.GetComponent<AttaqueMonstreRose>().Dommage = StatistiquesJeu.joueurPrincipal.niveau / 2;
            // monstre.GetComponent<AttaqueMonstreRose>().nombreDeVieMax = StatistiquesJeu.joueurPrincipal.niveau + 1;
            //    monstre.GetComponent<AttaqueMonstreRose>().nombreDeVie = StatistiquesJeu.joueurPrincipal.niveau + 1;
            //   monstre.GetComponent<AttaqueMonstreRose>().speed = StatistiquesJeu.joueurPrincipal.niveau + 35;
            // monstre.GetComponent<AttaqueMonstreRose>().timeBetweenAttacks = 5F - ((float)StatistiquesJeu.joueurPrincipal.niveau / 5f);
            //}
            

        }
    }
    public void GenererMap()
    {
        GameObject[] enfant = Resources.LoadAll<GameObject>("objet") as GameObject[];
        for (int i = 0; i < enfant.Length; i++)
        {
            var range = new Vector3(Random.Range(-40, +40), 0, Random.Range(-40, 40));
            while((range.x < 6 && range.x > -6) || (range.z < 6 && range.z > -6)) 
            {
                range = new Vector3(Random.Range(-40, +40), 0, Random.Range(-40, 40));
            }
            Instantiate(enfant[i], range, Quaternion.identity);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (StatistiquesJeu.monstresRestants <= 0)
        {
            StatistiquesJeu.joueurPrincipal.niveau++;
            SceneManager.LoadScene(6);
        }

    }
}
