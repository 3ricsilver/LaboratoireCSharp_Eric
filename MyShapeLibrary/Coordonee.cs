using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

using System;

namespace MyShapeLibrary
{
    /* Créer une classe Coordonnee décrite par : 
    * deux coordonnées de type entier X et Y(variable membre et propriété(en gros set et get), done
    * un constructeur d'initialisation, un constructeur par défaut (qui utilise le constructeur done 
d'initialisation). 
   La surcharge de la méthode ToString() en utilisant le format : (X,Y)  done*/
    public class Coordonee
    {
        #region Variable Membre
        //variable membre //

        private int _x;
        private int _y;

        #endregion  

        #region Constructeur
        //constructeur//
        public Coordonee()
        {
            _x =  0;
            _y =  0;
        }
         

        public Coordonee(int XValue, int YValue)
        {
            _x = XValue;
            _y = YValue;
        }
        #endregion

        #region Propriétés
        //propriétés//
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }
        #endregion  

        #region Surcharge
        //Surcharge //  
        public override string ToString()
        {
            return "(" + _x + "," + _y + ")";
        }
        #endregion  
    }
}