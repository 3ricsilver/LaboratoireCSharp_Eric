﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

/*Créer une classe Carre qui hérite de Forme et décrite par : une valeur entière représentant la
longueur du coté (variable membre et propriété), un constructeur d’initialisation utilisant le 
constructeur de la classe mère, un constructeur par défaut, la surcharge de la méthode ToString()*/


namespace MyShapeLibrary
{
    public class Carre : Forme
    {
        private int _cote;

        // Constructeur par défaut et base() eric du futur c'est la méthode pour appeler le truc  du mere
        public Carre() : base()
        {
            _cote = 0;
        }

        // Constructeur d'initialisation
        public Carre(int x, int y, int cote) : base(x, y)
        {
            _cote = cote;
        }

        // getter & setter
        public int Cote
        {
            get { return _cote; }
            set { _cote = value; }
        }

        // Surcharge de la méthode ToString()
        public override string ToString()
        {
            return "PointAccroche=" + PointAccroche + "," + "Cote=" + _cote;
        }

        //Interface
        public bool CoordonneeEstDans(Coordonee p)
        {
            //En gros point d'accroche sera le coin gauche en haut

            //En gros je determine les points du carré puis la condition va check si c'est dedans  //coucou mika si tu passes par la 
            int xMin = PointAccroche.X;
            int yMin = PointAccroche.Y;
            int xMax = xMin + Cote;
            int yMax = yMin + Cote;

            return p.X >= xMin && p.X <= xMax && p.Y >= yMin && p.Y <= yMax;
        }
    }
}
