using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliothèque_de_classe.DAO
{
    public class ClasseDAO
    {
        public static List<Classe> charger(List<Etablissement_Scolaire> desEtablissementScolaires)
        {
            try
            {
                List<Classe> listeRetour = new List<Classe>();
                Connexion uneConnexion = new Connexion();
                MySqlCommand maCommande;
                MySqlDataReader mesResultats;
                Etablissement_Scolaire lEtablissement_Scolaire;


                uneConnexion.getConnexion().Open();
                maCommande = new MySqlCommand("SELECT * FROM classe;", uneConnexion.getConnexion());
                mesResultats = maCommande.ExecuteReader();
                while (mesResultats.Read())
                {
                    lEtablissement_Scolaire = desEtablissementScolaires.Find(m => m.getID() == mesResultats.GetInt32("id_etablissement_scolaire"));
                    listeRetour.Add(new Classe(mesResultats.GetInt32("id"), mesResultats.GetString("intitule"), lEtablissement_Scolaire));
                }
                uneConnexion.getConnexion().Close();

                return listeRetour;
            }
            catch (MySqlException erreur)
            {
                throw erreur;
            }
        }


        public static void ajout(Classe uneClasse)
        {
            try
            {

                Connexion uneConnexion = new Connexion();
                MySqlCommand maCommande;

                uneConnexion.getConnexion().Open();

                maCommande = new MySqlCommand("INSERT INTO classe (id, intitule, id_etablissement_scolaire) VALUES (" + uneClasse.getID() + ", '" + uneClasse.getlibelle() + "', '" + uneClasse.getEtablissement_Scolaire().getID() + ");", uneConnexion.getConnexion());
                maCommande.ExecuteReader();
                uneConnexion.getConnexion().Close();
            }
            catch (MySqlException erreur)
            {
                throw erreur;
            }
        }


        public static void supprimer(Classe uneClasse)
        {
            try
            {

                Connexion uneConnexion = new Connexion();
                MySqlCommand maCommande;

                uneConnexion.getConnexion().Open();
                maCommande = new MySqlCommand("DELETE FROM classe WHERE id = " + uneClasse.getID() + ";", uneConnexion.getConnexion());
                maCommande.ExecuteReader();
                uneConnexion.getConnexion().Close();
            }
            catch (MySqlException erreur)
            {
                throw erreur;
            }
        }


        public static void modifier(Classe uneClasse)
        {
            try
            {

                Connexion uneConnexion = new Connexion();
                MySqlCommand maCommande;

                uneConnexion.getConnexion().Open();

                maCommande = new MySqlCommand("UPDATE classe SET intitule = '" + uneClasse.getlibelle() + ", '" + uneClasse.getEtablissement_Scolaire().getID() + "WHERE id = " + uneClasse.getID() + ";", uneConnexion.getConnexion());
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
