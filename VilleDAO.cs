using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace Bibliothèque_de_classe.DAO
{
    class VilleDAO
    {
        public static List<Ville> charger()
        {
            try
            {
                List<Ville> listeRetour = new List<Ville>();
                Connexion uneConnexion = new Connexion();
                MySqlCommand maCommande;
                MySqlDataReader mesResultats;

                uneConnexion.getConnexion().Open();
                maCommande = new MySqlCommand("SELECT * FROM ville;", uneConnexion.getConnexion());
                mesResultats = maCommande.ExecuteReader();
                while (mesResultats.Read())
                {
                    listeRetour.Add(new Ville(mesResultats.GetInt32("id"), mesResultats.GetString("nom"), mesResultats.GetString("code_postal")));
                }
                uneConnexion.getConnexion().Close();

                return listeRetour;
            }
            catch (MySqlException erreur)
            {
                throw erreur;
            }
        }

        public static void ajout(Ville uneVille)
        {
            try
            {
                Connexion uneConnexion = new Connexion();
                MySqlCommand maCommande;

                uneConnexion.getConnexion().Open();
                maCommande = new MySqlCommand("INSERT INTO ville (id, nom, code_postal) VALUES (" + uneVille.getID() + ", '" + uneVille.getlibelle() + "', '" + uneVille.getCodePostal() + ");", uneConnexion.getConnexion());
                maCommande.ExecuteReader();
                uneConnexion.getConnexion().Close();
            }
            catch (MySqlException erreur)
            {
                throw erreur;
            }
        }

        public static void modifier(Ville uneVille)
        {
            try
            {
                Connexion uneConnexion = new Connexion();
                MySqlCommand maCommande;

                uneConnexion.getConnexion().Open();
                maCommande = new MySqlCommand("UPDATE parent SET nom = '" + uneVille.getlibelle() + "', code_postal = '" + uneVille.getCodePostal() + " WHERE id = " + uneVille.getID() + ";", uneConnexion.getConnexion());
                maCommande.ExecuteReader();
                uneConnexion.getConnexion().Close();
            }
            catch (MySqlException erreur)
            {
                throw erreur;
            }
        }

        public static void supprimer(Ville uneVille)
        {
            try
            {
                Connexion uneConnexion = new Connexion();
                MySqlCommand maCommande;

                uneConnexion.getConnexion().Open();
                maCommande = new MySqlCommand("DELETE FROM parent WHERE id = " + uneVille.getID() + ";", uneConnexion.getConnexion());
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
