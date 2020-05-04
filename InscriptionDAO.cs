using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliothèque_de_classe.DAO
{
    class InscriptionDAO
    {
        public static List<Inscription> charger(List<Parent> desParents, List<Ville> desVilles, List<Hopital> desHopitaux, List<Enfant> desEnfants ,List<Situation_Famille> desSituationFamille, List<Autorite_Parentale> desAutoritesParentales, List<Ecole> desSignaturesEtEcoles)
        {
            try
            {
                List<Ecole> listeRetour = new List<Ecole>();
                Connexion uneConnexion = new Connexion();
                MySqlCommand maCommande;
                MySqlDataReader mesResultats;
                Parent leParent, leResponsable, leResponsablePaiement1, leResponsablePaiement2;
                Ville laVille;
                List<Enfant> lEnfant;
                Hopital lHopital;
                Situation_Famille laSituationFamille;
                Autorite_Parentale lAutoriteParentale;
                List<Ecole> laSignatureEtEcole;

                uneConnexion.getConnexion().Open();
                maCommande = new MySqlCommand("SELECT * FROM inscription;", uneConnexion.getConnexion());
                mesResultats = maCommande.ExecuteReader();
                while (mesResultats.Read())
                {
                    leParent = desParents.Find(m => m.getID() == mesResultats.GetInt32("id_parent"));
                    leResponsable = desParents.Find(a => a.getID() == mesResultats.GetInt32("id_responsable"));
                    leResponsablePaiement1 = desParents.Find(b => b.getID() == mesResultats.GetInt32("id_paiement1"));
                    leResponsablePaiement2 = desParents.Find(c => c.getID() == mesResultats.GetInt32("id_paiement2"));
                    laVille = desVilles.Find(d => d.getID() == mesResultats.GetInt32("id_ville"));
                    lEnfant = desEnfants.Find(e => e.getID() == mesResultats.GetInt32("id_enfant"));
                    lHopital = desHopitaux.Find(z => z.getID() == mesResultats.GetInt32("id_hopital"));
                    laSituationFamille = desSituationFamille.Find(f => f.getID() == mesResultats.GetInt32("id_situation_famille"));
                    lAutoriteParentale = desAutoritesParentales.Find(g => g.getID() == mesResultats.GetInt32("id_autorite_parentale"));
                    laSignatureEtEcole = desSignaturesEtEcoles.Find(w => w.getID() == mesResultats.GetInt32("id_signature_ecole"));
                    listeRetour.Add(new Inscription(mesResultats.GetInt32("id"), mesResultats.GetString("adresse"), mesResultats.GetString("CAF"), mesResultats.GetString("portable_prioritaire"), mesResultats.GetString("date_inscription"), mesResultats.GetBool("photo_O/N"), mesResultats.GetBool("cle_wallonnienne_O/N"), mesResultats.GetInt32("nb_enfant_charge"), leParent, leResponsable, leResponsablePaiement1, leResponsablePaiement2, laVille, lHopital, lEnfant, laSituationFamille, lAutoriteParentale, laSignatureEtEcole));
                }
                uneConnexion.getConnexion().Close();

                return listeRetour;
            }
            catch (MySqlException erreur)
            {
                throw erreur;
            }
        }

        public static void ajout(Inscription uneInscription)
        {
            try
            {
                Connexion uneConnexion = new Connexion();
                MySqlCommand maCommande;

                uneConnexion.getConnexion().Open();
                maCommande = new MySqlCommand("INSERT INTO inscription (id, adresse, CAF, portable_prioritaire, date_inscription, photo_O/N, cle_wallonnienne_O/N, nb_enfant_charge, id_parent, id_responsable, id_paiement1, id_paiement2, id_ville, id_enfant, id_hopital, id_situation_famille, id_autorite_parentale, id_signature_ecole) VALUES (" + uneInscription.getId() + ", '" + uneInscription.getAdresse() + "', '" + uneInscription.getCAF() + "', '" + uneInscription.getPortable_Prioritaire() + "', '" + uneInscription.getDate_Inscrption() + "', '" + uneInscription.getPhoto_YN() + "', '" + uneInscription.getCle_Wallonnienne_YN() + "', '" + uneInscription.getNb_Enfant_Charge() + "', '" + uneInscription.getParent() + "', '" + uneInscription.getResponsable() + "', '" + uneInscription.getResponsablePaiement1() + "', '" + uneInscription.getResponsablePaiement2() + "', '" + uneInscription.getVille() + "', '" + uneInscription.getHopital() + "', '" + uneInscription.getEnfant() + "', '" + uneInscription.GetSituastion_Famille() + "', '" + uneInscription.GetAutorite_Parentale() + "', '" + uneInscription.GetEcoles() + ");", uneConnexion.getConnexion());
                maCommande.ExecuteReader();
                uneConnexion.getConnexion().Close();
            }
            catch (MySqlException erreur)
            {
                throw erreur;
            }
        }

        public static void modifier(Inscription uneInscription)
        {
            try
            {
                Connexion uneConnexion = new Connexion();
                MySqlCommand maCommande;

                uneConnexion.getConnexion().Open();
                maCommande = new MySqlCommand("UPDATE inscription SET adresse = '" + uneInscription.getAdresse() + "', CAF = '" + uneInscription.getCAF() + "', portable_prioritaire = " + uneInscription.getPortable_Prioritaire() + "', date_inscription = '" + uneInscription.getDate_Inscrption() + "', photo_O/N = '" + uneInscription.getPhoto_YN() + "', cle_wallonnaine_O/N = '" + uneInscription.getCle_Wallonnienne_YN() + "' nb_enfant_charge = '" + uneInscription.getNb_Enfant_Charge() + "', id_parent = '" + uneInscription.getParent() + "', id_responsable = '" + uneInscription.getResponsable() + "', id_paiement1 = '" + uneInscription.getResponsablePaiement1() + "', id_paiement2 = '" + uneInscription.getResponsablePaiement2() + ", id_ville = '" + uneInscription.getVille() + "', id_hopital = '" + uneInscription.getHopital() + "', id_enfant = '" + uneInscription.getEnfant() + "',  id_situation_famille = '" + uneInscription.GetSituastion_Famille() + "', id_autorite_parentale = '" + uneInscription.GetAutorite_Parentale() + "', id_signature_ecole " + uneInscription.GetEcoles() + ";", uneConnexion.getConnexion());
                maCommande.ExecuteReader();
                uneConnexion.getConnexion().Close();
            }
            catch (MySqlException erreur)
            {
                throw erreur;
            }
        }

        public static void supprimer(Inscription uneInscription)
        {
            try
            {
                Connexion uneConnexion = new Connexion();
                MySqlCommand maCommande;

                uneConnexion.getConnexion().Open();
                maCommande = new MySqlCommand("DELETE FROM inscription WHERE id = " + uneInscription.getId() + ";", uneConnexion.getConnexion());
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
