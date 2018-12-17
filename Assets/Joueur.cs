using Newtonsoft.Json;
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

        public Joueur()
        {
            pointsVie = 10;
            pointsAttaque = 1;
            vitesseAttaque = 0.5f;
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
