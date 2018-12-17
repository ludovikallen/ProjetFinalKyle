using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionnaireJeu : MonoBehaviour
{
    int nombreDemonstre = 0;
    // Start is called before the first frame update
    void Start()
    {
        GenererMonstre();
        GenererMap();

    }
    public void GenererMonstre()
    {
        Joueur joueur = new Joueur();
        nombreDemonstre = joueur.niveau;
        for (int i = 0; i < 5; i++)
        {
            Instantiate(Resources.Load("MonstreRose"), new Vector3(Random.Range(-40, +40), 0, Random.Range(-40, 40)), Quaternion.identity);
        }
    }
    public void GenererMap()
    {
        GameObject[] enfant = Resources.LoadAll<GameObject>("objet") as GameObject[];
        for (int i = 0; i < enfant.Length; i++)
        {

            Instantiate(enfant[i], new Vector3(Random.Range(-40, +40), 0, Random.Range(-40, 40)), Quaternion.identity);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
