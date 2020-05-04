using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliothèque_de_classe.DAO
{
    class InscrireDAO
    {
        public static List<Inscrire> charger(List<Inscription> desInscriptions, List<Ecole> desEcoles)
        {
            try
            {
                List<Inscrire> listeRetour = new List<Inscrire>();
                Connexion uneConnexion = new Connexion();
                MySqlCommand maCommande;
                MySqlDataReader mesResultats;
                Inscription unInscrit;
                string uneDateSignature;
                Ecole uneEcole;


                uneConnexion.getConnexion().Open();
                maCommande = new MySqlCommand("SELECT * FROM inscrire;", uneConnexion.getConnexion());
                mesResultats = maCommande.ExecuteReader();
                while (mesResultats.Read())
                {
                    unInscrit = desInscriptions.Find(a => a.getId() == mesResultats.GetInt32("id_inscription"));
                    uneEcole = desEcoles.Find(b => b.getID() == mesResultats.GetInt32("id_ecole"));
                    uneDateSignature = desInscriptions.Find(c => c.getDate_Inscrption() == mesResultats.GetString("date_signature"));
                    unInscrit.GetEcoles().Add(uneEcole);
                    uneEcole.getInscriptions().Add(unInscrit);
                    listeRetour.Add(new Inscrire(uneDateSignature));

                }
                uneConnexion.getConnexion().Close();
                return listeRetour;
            }
                        
            catch (MySqlException erreur)
            {
                throw erreur;
            }
        }


        public static void ajout(Int32 lInscrit, Int32 lEcole, Inscrire uneInscrit)
        {
            try
            {

                Connexion uneConnexion = new Connexion();
                MySqlCommand maCommande;

                uneConnexion.getConnexion().Open();

                maCommande = new MySqlCommand("INSERT INTO inscrire (id_inscription, id_ecole, date_signature) VALUES (" + lInscrit + ", '" + lEcole + "', '" + uneInscrit.getDateSignature() + ");", uneConnexion.getConnexion());
                maCommande.ExecuteReader();
                uneConnexion.getConnexion().Close();
            }
            catch (MySqlException erreur)
            {
                throw erreur;
            }
        }


        public static void supprimer(Int32 lEnfant, Int32 lEcole)
        {
            try
            {

                Connexion uneConnexion = new Connexion();
                MySqlCommand maCommande;

                uneConnexion.getConnexion().Open();
                maCommande = new MySqlCommand("DELETE FROM inscrit WHERE id_inscrit = " + lEnfant + "AND id_ecole = " + lEcole + ";", uneConnexion.getConnexion());
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
