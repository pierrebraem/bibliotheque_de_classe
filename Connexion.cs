using MySql.Data.MySqlClient;


namespace Bibliothèque_de_classe.DAO
{
    /// <summary>
    /// Gestion de la connexion entre l'application et la base de données grâce à sa propriété maConnexion.
    /// Elle possède un constructeur <c> Connexion </c> sans paramètre
    /// et un accesseur <c> getConnexion </c>
    /// </summary>
    public class Connexion
    {
        /// <summary>
        /// Propriété privée classe qui permet de mémoriser la connexion entre la base de données et l'application
        /// </summary>
        private MySqlConnection maConnexion;

        /// <summary>
        /// Constructeur par défaut sans paramètre qui réalise la connction entre la base de données et l'application
        /// la base de données est sur l'ordinateur local, l'utilisateur est root sans mot de passe et la base de données se nomme "ecole_musique"
        /// </summary>
        public Connexion()
        {
            try
            {
                //Instancie la propriété en indiquant le server, l'utilisateur, le mot de passe et le nom de la base de données à utiliser
                maConnexion = new MySqlConnection("server = " + DeclarationsDAO.leServeur + "; user = " + DeclarationsDAO.lUtilisateur + "; password = " + DeclarationsDAO.leMotDePasse + ";database = " + DeclarationsDAO.laBaseDeDonnees);
            }
            catch (MySqlException erreur)
            {
                throw erreur;
            }
        }

        /// <summary>
        /// Accesseur de la connexion
        /// </summary>
        /// <returns> renvoie la connexion à la base de données </returns>
        public MySqlConnection getConnexion()
        {
            return maConnexion;
        }
    }
}
