using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
/*Créer une classe Cercle qui hérite de Forme et décrite par : une valeur entière représentant le rayon 
(variable membre et propriété), une propriété calculée Diamètre en lecture seule, un constructeur 
d’initialisation, un constructeur par défaut, la surcharge de la méthode ToString()*/
namespace MyShapeLibrary
{
    public class Cercle : Forme
    {
        private int _rayon;

        // Constructeur par défaut
        public Cercle() : base()
        {
            _rayon = 0;
        }

        // Constructeur d'initialisation
        public Cercle(int x, int y, int rayon) : base(x, y)
        {
            _rayon = rayon;
        }

        // getter & setter
        public int Rayon
        {
            get { return _rayon; }
            set { _rayon = value; }
        }

        // Propriété calculée pour le diamètre du cercle
        public double Diametre
        {
            get { return _rayon * 2; }
        }

        // Surcharge de la méthode ToString()
        public override string ToString()
        {
            return "Cercle: PointAccroche=" + PointAccroche + "," + "Rayon=" + _rayon + "Diametre="+ Diametre;
        }
    }
}
