using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace Bibliothèque_de_classe.DAO
{
    class Situation_FamilleDAO
    {
        public static List<Situation_Famille> charger()
        {
            try
            {
                List<Situation_Famille> listeRetour = new List<Situation_Famille>();
                Connexion uneConnexion = new Connexion();
                MySqlCommand maCommande;
                MySqlDataReader mesResultats;

                uneConnexion.getConnexion().Open();
                maCommande = new MySqlCommand("SELECT * FROM situation_famille;", uneConnexion.getConnexion());
                mesResultats = maCommande.ExecuteReader();
                while (mesResultats.Read())
                {
                    listeRetour.Add(new Situation_Famille(mesResultats.GetInt32("id"), mesResultats.GetString("intitule")));
                }
                uneConnexion.getConnexion().Close();

                return listeRetour;
            }
            catch (MySqlException erreur)
            {
                throw erreur;
            }
        }

        public static void ajout(Situation_Famille uneSituationFamille)
        {
            try
            {
                Connexion uneConnexion = new Connexion();
                MySqlCommand maCommande;

                uneConnexion.getConnexion().Open();
                maCommande = new MySqlCommand("INSERT INTO situation_famille (id, intitule) VALUES (" + uneSituationFamille.getID() + ", '" + uneSituationFamille.getlibelle() + ");", uneConnexion.getConnexion());
                maCommande.ExecuteReader();
                uneConnexion.getConnexion().Close();
            }
            catch (MySqlException erreur)
            {
                throw erreur;
            }
        }

        public static void modifier(Situation_Famille uneSituationFamille)
        {
            try
            {
                Connexion uneConnexion = new Connexion();
                MySqlCommand maCommande;

                uneConnexion.getConnexion().Open();
                maCommande = new MySqlCommand("UPDATE parent SET intitule = '" + uneSituationFamille.getlibelle() + " WHERE id = " + uneSituationFamille.getID() + ";", uneConnexion.getConnexion());
                maCommande.ExecuteReader();
                uneConnexion.getConnexion().Close();
            }
            catch (MySqlException erreur)
            {
                throw erreur;
            }
        }

        public static void supprimer(Situation_Famille uneSituation_Famille)
        {
            try
            {
                Connexion uneConnexion = new Connexion();
                MySqlCommand maCommande;

                uneConnexion.getConnexion().Open();
                maCommande = new MySqlCommand("DELETE FROM parent WHERE id = " + uneSituation_Famille.getID() + ";", uneConnexion.getConnexion());
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
