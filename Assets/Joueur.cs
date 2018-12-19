using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

public class Joueur
{
        [JsonProperty]
        public float pointsVie { get; set; }

        [JsonProperty]
        public int pointsAttaque { get; set; }

        [JsonProperty]
        public float vitesseAttaque { get;  set; }

        [JsonProperty]
        public int niveau { get; set; }

        [JsonProperty]
        public int points { get; set; }

        [JsonProperty]
        public string arme { get; set; }

    public Joueur()
        {
            pointsVie = 10;
            pointsAttaque = 2;
            vitesseAttaque = 0.5f;
            niveau = 1;
            points = 3000;
            arme = "Normal gun";
    }

        public void SérialiserVersSortie(TextWriter sortie)
        {
            using (sortie)
            {
                new JsonSerializer().Serialize(sortie, this);
            }
        }

        public static Joueur DésérialiserFichier(string nomFichier)
        {
            Joueur nouveauJoueur;
            using (StreamReader sr = new StreamReader(nomFichier))
            {
                nouveauJoueur = JsonConvert.DeserializeObject<Joueur>(sr.ReadToEnd());
            }
            return nouveauJoueur;
        }
}
