using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliothèque_de_classe
{
    class UtilisationDAO
    {
        public static List<Utilisation> charger(List<Enfant> desEnfants, List<Instrument> desInstruments, List<Cours> desCours)
        {
            try
            {
                List<Utilisation> listeRetour = new List<Utilisation>();
                Connexion uneConnexion = new Connexion();
                MySqlCommand maCommande;
                MySqlDataReader mesResultats;
                Enfant unEnfant;
                Instrument unInstrument;
                Cours unCours;

                uneConnexion.getConnexion().Open();
                maCommande = new MySqlCommand("SELECT * FROM utilisation;", uneConnexion.getConnexion());
                mesResultats = maCommande.ExecuteReader();
                while (mesResultats.Read())
                {
                    listeRetour.Add(new Utilisation(mesResultats.GetBool("louer")));
                    unEnfant = desEnfants.Find(e => e.getID() == mesResultats.GetInt32("id_enfant"));
                    unInstrument = desInstruments.Find(c => c.getID() == mesResultats.GetInt32("id_instrument"));
                    unCours = desCours.Find(a => a.getID() == mesResultats.GetInt32("id_cours"));
                    unEnfant.getInstruments().Add(unInstrument);
                    unEnfant.getCours().Add(unCours);
                    unCours.getEnfants().Add(unEnfant);
                }
                uneConnexion.getConnexion().Close();

                return listeRetour;
            }
            catch (MySqlException erreur)
            {
                throw erreur;
            }
        }

        public static void ajout(Utilisation uneUtilisation)
        {
            try
            {
                Connexion uneConnexion = new Connexion();
                MySqlCommand maCommande;

                uneConnexion.getConnexion().Open();
                maCommande = new MySqlCommand("INSERT INTO utilisation (louer, id_enfant, id_instrument, id_cours) VALUES (" + uneUtilisation.getLouer() + ", '" + uneUtilisation.getEnfant() + "', '" + uneUtilisation.getInstrument() + "', '" + uneUtilisation.getCours() + ");", uneConnexion.getConnexion());
                maCommande.ExecuteReader();
                uneConnexion.getConnexion().Close();
            }
            catch (MySqlException erreur)
            {
                throw erreur;
            }
        }

        public static void supprimer(Int32 lIdEnfant, Int32 lIdInstrument, Int32 lIdCours)
        {
            try
            {
                Connexion uneConnexion = new Connexion();
                MySqlCommand maCommande;

                uneConnexion.getConnexion().Open();
                maCommande = new MySqlCommand("DELETE FROM parent WHERE id_enfant = " + lIdEnfant + " AND id_instrument = " + lIdInstrument + " AND id_cours = " + lIdCours + ";", uneConnexion.getConnexion());
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
