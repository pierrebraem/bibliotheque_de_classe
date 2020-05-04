using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace Bibliothèque_de_classe.DAO
{
    public class Etablissement_ScolaireDAO
    {
        public static List<Etablissement_Scolaire> charger()
        {
            try
            {
                List<Etablissement_Scolaire> listeRetour = new List<Etablissement_Scolaire>();
                Connexion uneConnexion = new Connexion();
                MySqlCommand maCommande;
                MySqlDataReader mesResultats;


                uneConnexion.getConnexion().Open();
                maCommande = new MySqlCommand("SELECT * FROM etablissement_scolaire;", uneConnexion.getConnexion());
                mesResultats = maCommande.ExecuteReader();
                while (mesResultats.Read())
                {

                    listeRetour.Add(new Etablissement_Scolaire(mesResultats.GetInt32("id"), mesResultats.GetString("nom"), mesResultats.GetString("adresse")));
                }
                uneConnexion.getConnexion().Close();

                return listeRetour;
            }
            catch (MySqlException erreur)
            {
                throw erreur;
            }
        }


        public static void ajout(Etablissement_Scolaire unEtablissement_Scolaire)
        {
            try
            {

                Connexion uneConnexion = new Connexion();
                MySqlCommand maCommande;

                uneConnexion.getConnexion().Open();

                maCommande = new MySqlCommand("INSERT INTO etablissement_scolaire (id, nom, adresse) VALUES (" + unEtablissement_Scolaire.getID() + ", '" + unEtablissement_Scolaire.getlibelle() +"', '" + unEtablissement_Scolaire.getAdresse() +");", uneConnexion.getConnexion());
                maCommande.ExecuteReader();
                uneConnexion.getConnexion().Close();
            }
            catch (MySqlException erreur)
            {
                throw erreur;
            }
        }


        public static void supprimer(Etablissement_Scolaire unEtablissement_Scolaire)
        {
            try
            {

                Connexion uneConnexion = new Connexion();
                MySqlCommand maCommande;

                uneConnexion.getConnexion().Open();
                maCommande = new MySqlCommand("DELETE FROM etablissement_scolaire WHERE id = " + unEtablissement_Scolaire.getID() + ";", uneConnexion.getConnexion());
                maCommande.ExecuteReader();
                uneConnexion.getConnexion().Close();
            }
            catch (MySqlException erreur)
            {
                throw erreur;
            }
        }


        public static void modifier(Etablissement_Scolaire unEtablissement_Scolaire)
        {
            try
            {

                Connexion uneConnexion = new Connexion();
                MySqlCommand maCommande;

                uneConnexion.getConnexion().Open();

                maCommande = new MySqlCommand("UPDATE etablissement_scolaire SET nom = '" + unEtablissement_Scolaire.getlibelle() + "', adresse = " + unEtablissement_Scolaire.getAdresse() + "WHERE id = " + unEtablissement_Scolaire.getID() +";", uneConnexion.getConnexion());
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
