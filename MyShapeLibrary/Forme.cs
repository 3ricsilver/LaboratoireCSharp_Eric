using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
/*Créer une classe abstraite Forme qui décrit toute forme géométrique. Elle doit contenir une variable 
membre et sa propriété associée de type Coordonnee qui représente le point d’accroche de la forme 
ainsi qu'un constructeur par défaut qui pourra être appelé par les classe filles grâce au mot clé 'base'.*/

//en gros variable coordonnee
//constructeur par défaut et d'initiation


//qui pourra être appelé par les classe filles grâce au mot clé 'base' aucune idée de comment faire ca
namespace MyShapeLibrary
{
    public abstract class Forme
    {
        private Coordonee _pointAccroche;

        // Constructeur par défaut
        protected Forme()
        {
            _pointAccroche = new Coordonee(); 
        }

        // Constructeur avec initialisation
        protected Forme(int x, int y)
        {
            _pointAccroche = new Coordonee(x, y);
        }
        //getter & setter
        public Coordonee PointAccroche
        {
            get { return _pointAccroche; }
            set { _pointAccroche = value; }
        }
    }
}
