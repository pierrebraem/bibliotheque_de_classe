using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliothèque_de_classe.DAO
{
    class HopitalDAO
    {
        public static List<Hopital> charger()
        {
            try
            {
                List<Hopital> listeRetour = new List<Hopital>();
                Connexion uneConnexion = new Connexion();
                MySqlCommand maCommande;
                MySqlDataReader mesResultats;

                uneConnexion.getConnexion().Open();
                maCommande = new MySqlCommand("SELECT * FROM hopital;", uneConnexion.getConnexion());
                mesResultats = maCommande.ExecuteReader();
                while (mesResultats.Read())
                {
                    listeRetour.Add(new Hopital(mesResultats.GetInt32("id"), mesResultats.GetString("nom"), mesResultats.GetString("adresse"), mesResultats.GetString("tel")));
                }
                uneConnexion.getConnexion().Close();

                return listeRetour;
            }
            catch (MySqlException erreur)
            {
                throw erreur;
            }
        }

        public static void ajout(Hopital unHopital)
        {
            try
            {
                Connexion uneConnexion = new Connexion();
                MySqlCommand maCommande;

                uneConnexion.getConnexion().Open();
                maCommande = new MySqlCommand("INSERT INTO autorite_parentale (id, nom, adresse, tel) VALUES (" + unHopital.getID() + ", '" + unHopital.getlibelle() + "', '" + unHopital.getAdresse() + "', '"  + unHopital.getTel() + ");", uneConnexion.getConnexion());
                maCommande.ExecuteReader();
                uneConnexion.getConnexion().Close();
            }
            catch (MySqlException erreur)
            {
                throw erreur;
            }
        }

        public static void modifier(Hopital unHopital)
        {
            try
            {
                Connexion uneConnexion = new Connexion();
                MySqlCommand maCommande;

                uneConnexion.getConnexion().Open();
                maCommande = new MySqlCommand("UPDATE parent SET nom = '" + unHopital.getlibelle() + "', adresse = '" + unHopital.getAdresse() + "', adresse = '" + unHopital.getTel() + " WHERE id = " + unHopital.getID() + ";", uneConnexion.getConnexion());
                maCommande.ExecuteReader();
                uneConnexion.getConnexion().Close();
            }
            catch (MySqlException erreur)
            {
                throw erreur;
            }
        }

        public static void supprimer(Hopital unHopital)
        {
            try
            {
                Connexion uneConnexion = new Connexion();
                MySqlCommand maCommande;

                uneConnexion.getConnexion().Open();
                maCommande = new MySqlCommand("DELETE FROM parent WHERE id = " + unHopital.getID() + ";", uneConnexion.getConnexion());
                maCommande.ExecuteReader();
                uneConnexion.getConnexion().Close();
            }
            catch (MySqlException erreur)
            {
                throw erreur;
            }
        }
    }
}
