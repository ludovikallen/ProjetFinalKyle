﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

public class Joueur
{

        public event EventHandler OnModifiée;
        public event EventHandler OnDimensionXModifiée;
        public event EventHandler OnDimensionYModifiée;
        [JsonProperty]
        public string Nom { get; set; }

        [JsonProperty]
        public int pointsVie { get; set; }
        [JsonProperty]
        public int pointsAttaque { get; set; }

        [JsonProperty]
        public int vitesseAttaque { get;  set; }

        public Joueur()
        {
            
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
