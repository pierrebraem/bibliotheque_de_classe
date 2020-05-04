using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliothèque_de_classe.DAO
{
    public class InstrumentDAO
    {
        public static List<Instrument> charger()
        {
            try                             
            {
                List<Instrument> listeRetour = new List<Instrument>();    
                Connexion uneConnexion = new Connexion();
                MySqlCommand maCommande;        
                MySqlDataReader mesResultats;   
                              

                uneConnexion.getConnexion().Open();                                                               
                maCommande = new MySqlCommand("SELECT * FROM instrument;", uneConnexion.getConnexion());               
                mesResultats = maCommande.ExecuteReader();                                                          
                while (mesResultats.Read())                                                                         
                {
                                
                    listeRetour.Add(new Instrument(mesResultats.GetInt32("id"), mesResultats.GetString("intitule")));
                }
                uneConnexion.getConnexion().Close();                                                        

                return listeRetour;
            }
            catch (MySqlException erreur)                                                                   
            {
                throw erreur;                                                                                      
            }
        }

        
        public static void ajout(Instrument unInstrument)
        {
            try                                 
            {
                
                Connexion uneConnexion = new Connexion();
                MySqlCommand maCommande;            

                uneConnexion.getConnexion().Open();                                                                                               
                
                maCommande = new MySqlCommand("INSERT INTO instrument (id, intitule) VALUES (" + unInstrument.getID() + ", '" + unInstrument.getlibelle());
                maCommande.ExecuteReader();                                                                                                         
                uneConnexion.getConnexion().Close();                                                                                              
            }
            catch (MySqlException erreur)                                                                                                           
            {
                throw erreur;
            }
        }

        
        public static void supprimer(Instrument unInstrument)
        {
            try                                 
            {
                
                Connexion uneConnexion = new Connexion();
                MySqlCommand maCommande;            

                uneConnexion.getConnexion().Open();                                                                                               
                maCommande = new MySqlCommand("DELETE FROM instrument WHERE id = " + unInstrument.getID() + ";", uneConnexion.getConnexion());              
                maCommande.ExecuteReader();                                                                                                         
                uneConnexion.getConnexion().Close();                                                                                              
            }
            catch (MySqlException erreur)                                                                                                           
            {
                throw erreur;
            }
        }

        
        public static void modifier(Instrument unInstrument)
        {
            try
            {
                
                Connexion uneConnexion = new Connexion();
                MySqlCommand maCommande;           

                uneConnexion.getConnexion().Open();                                                                                               
               
                maCommande = new MySqlCommand("UPDATE instrument SET intitule = '" + unInstrument.getlibelle() + ";", uneConnexion.getConnexion());
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
