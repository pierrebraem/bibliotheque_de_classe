using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace Bibliothèque_de_classe.DAO
{
    class ParentDAO
    {
        public static List<Parent> charger()
        {
            try
            {
                List<Parent> listeRetour = new List<Parent>();
                Connexion uneConnexion = new Connexion();
                MySqlCommand maCommande;
                MySqlDataReader mesResultats;

                uneConnexion.getConnexion().Open();
                maCommande = new MySqlCommand("SELECT * FROM parent;", uneConnexion.getConnexion());
                mesResultats = maCommande.ExecuteReader();
                while (mesResultats.Read())
                {
                    listeRetour.Add(new Parent(mesResultats.GetInt32("id"), mesResultats.GetString("nom"), mesResultats.GetString("prenom") + mesResultats.GetString("adresse"), mesResultats.GetString("tel_portable"), mesResultats.GetString("tel_domicile"), mesResultats.GetString("tel_travail"), mesResultats.GetString("courriel")));
                }
                uneConnexion.getConnexion().Close();

                return listeRetour;
            }
            catch (MySqlException erreur)
            {
                throw erreur;
            }
        }

        public static void ajout(Parent unParent)
        {
            try
            {
                Connexion uneConnexion = new Connexion();
                MySqlCommand maCommande;

                uneConnexion.getConnexion().Open();
                maCommande = new MySqlCommand("INSERT INTO parent (id, nom, prenom, adresse, tel_portble, tel_docimile, tel_travail, courriel) VALUES (" + unParent.getID() + ", '" + unParent.getlibelle() + "', '" + unParent.getAdresse() +"', '" +unParent.getPrenom() + "', '" + unParent.getTel_Portable() + "', '" + unParent.getTel_Domicile() + "', '" + unParent.getTel_Travail() + "', '" + unParent.getCourriel() + ");", uneConnexion.getConnexion());
                maCommande.ExecuteReader();
                uneConnexion.getConnexion().Close();
            }
            catch  (MySqlException erreur)
            {
                throw erreur;
            }
        }

        public static void modifier(Parent unParent)
        {
            try
            {
                Connexion uneConnexion = new Connexion();
                MySqlCommand maCommande;

                uneConnexion.getConnexion().Open();
                maCommande = new MySqlCommand("UPDATE parent SET nom = '" + unParent.getlibelle() + "', prenom = '" + unParent.getPrenom() + "', adresse = " + unParent.getAdresse() + "', tel_portable = '" + unParent.getTel_Portable() + "', tel_domicile = '" + unParent.getTel_Domicile() + "', tel_travail = '" + unParent.getTel_Travail() + "' courriel = '" + unParent.getCourriel() + " WHERE id = " + unParent.getID() + ";", uneConnexion.getConnexion());
                maCommande.ExecuteReader();
                uneConnexion.getConnexion().Close();
            }
            catch (MySqlException erreur)
            {
                throw erreur;
            }
        }

        public static void supprimer(Parent unParent)
        {
            try
            {
                Connexion uneConnexion = new Connexion();
                MySqlCommand maCommande;

                uneConnexion.getConnexion().Open();
                maCommande = new MySqlCommand("DELETE FROM parent WHERE id = " + unParent.getID() + ";", uneConnexion.getConnexion());
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
