using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace Bibliothèque_de_classe.DAO
{
    public class MedecinDAO
    {
        public static List<Medecin> charger()
        {
            try
            {
                List<Medecin> listeRetour = new List<Medecin>();
                Connexion uneConnexion = new Connexion();
                MySqlCommand maCommande;
                MySqlDataReader mesResultats;


                uneConnexion.getConnexion().Open();
                maCommande = new MySqlCommand("SELECT * FROM medecin;", uneConnexion.getConnexion());
                mesResultats = maCommande.ExecuteReader();
                while (mesResultats.Read())
                {

                    listeRetour.Add(new Medecin(mesResultats.GetInt32("id"), mesResultats.GetString("nom"), mesResultats.GetString("prenom"), mesResultats.GetString("adresse"), mesResultats.GetString("tel")));
                }
                uneConnexion.getConnexion().Close();

                return listeRetour;
            }
            catch (MySqlException erreur)
            {
                throw erreur;
            }
        }


        public static void ajout(Medecin unMedecin)
        {
            try
            {

                Connexion uneConnexion = new Connexion();
                MySqlCommand maCommande;

                uneConnexion.getConnexion().Open();

                maCommande = new MySqlCommand("INSERT INTO medecin (id, nom, prenom, adresse, tel) VALUES (" + unMedecin.getID() + ", '" + unMedecin.getlibelle() + "', '" + unMedecin.getPrenom() + "', '" + unMedecin.getAdresse() + "', '" + unMedecin.getTel() + "');", uneConnexion.getConnexion());
                maCommande.ExecuteReader();
                uneConnexion.getConnexion().Close();
            }
            catch (MySqlException erreur)
            {
                throw erreur;
            }
        }


        public static void supprimer(Medecin unMedecin)
        {
            try
            {

                Connexion uneConnexion = new Connexion();
                MySqlCommand maCommande;

                uneConnexion.getConnexion().Open();
                maCommande = new MySqlCommand("DELETE FROM medecin WHERE id = " + unMedecin.getID() + ";", uneConnexion.getConnexion());
                maCommande.ExecuteReader();
                uneConnexion.getConnexion().Close();
            }
            catch (MySqlException erreur)
            {
                throw erreur;
            }
        }


        public static void modifier(Medecin unMedecin)
        {
            try
            {

                Connexion uneConnexion = new Connexion();
                MySqlCommand maCommande;

                uneConnexion.getConnexion().Open();

                maCommande = new MySqlCommand("UPDATE medecin SET nom = '" + unMedecin.getlibelle() + "', prenom = '" + unMedecin.getPrenom() + "', adresse = " + unMedecin.getAdresse() + "' tel = '" + unMedecin.getTel() + " WHERE id = " + unMedecin.getID() + ";", uneConnexion.getConnexion());
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
