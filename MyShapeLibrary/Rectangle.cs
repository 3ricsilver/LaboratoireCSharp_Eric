using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShapeLibrary
{
    public class Rectangle : Forme
    {
        private int _longueur;
        private int _largeur;

        // Constructeur par défaut
        public Rectangle() : base()
        {
            _longueur = 0;
            _largeur = 0;
        }

        // Constructeur d'initialisation
        public Rectangle(int x, int y, int longueur, int largeur) : base(x, y)
        {
            _longueur = longueur;
            _largeur = largeur;
        }

        // get et set bon j'arete de mettre des commentaires ca me saoule
        public int Longueur
        {
            get { return _longueur; }
            set { _longueur = value; }
        }

        public int Largeur
        {
            get { return _largeur; }
            set { _largeur = value; }
        }

        public override string ToString()
        {
            return "Rectangle: PointAccroche=" + PointAccroche + "," + "Longueur=" + _longueur + "Largeur=" + _largeur;
        }

        //interface
        public bool CoordonneeEstDans(Coordonee p)
        {
            // en haut gauche 

            int xMin = PointAccroche.X;
            int yMin = PointAccroche.Y;
            int xMax = xMin + Longueur;
            int yMax = yMin + Largeur;

            return p.X >= xMin && p.X <= xMax && p.Y >= yMin && p.Y <= yMax;
        }
    }
}

