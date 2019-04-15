using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bouteille
{
    
    public class Bouteille
    {
        private bool ouvert;
        private double tauxDeRemplissage;
        private double prix;

        public Bouteille()
        {
            ouvert = false;
            tauxDeRemplissage = 0;
            prix = 0;
        }

        public Bouteille(bool _ouvert, double _tauxDeRemplissage, double _prix)
        {
            ouvert = _ouvert;
            if (_tauxDeRemplissage > 100)
            {
                tauxDeRemplissage = 100;
            }
            else if(_tauxDeRemplissage < 0)
            {
                tauxDeRemplissage = 0;
            }
            else
            {
                tauxDeRemplissage = _tauxDeRemplissage;
            }
            
            prix = _prix;
        }

        public bool Remplir()
        {

            if (!ouvert)
            {
                return false;
            }
            else
            {
                tauxDeRemplissage = 100;
                return true;
            }
           
            
        }

        public bool Remplir(double _taux)
        {
            if (!ouvert)
            {
                return false;
            }
            if (_taux < 0)
            {
                return false;
            }
            if(tauxDeRemplissage + _taux > 100 || !ouvert)
            {
                return false;
            }
            else
            {
                tauxDeRemplissage += _taux;
                return true;
            }
            
        }

        public bool Vider()
        {
            if (!ouvert)
            {
                return false;
            }
            else
            {
                tauxDeRemplissage = 0;
                return true;
            }
            
        }

        public bool Vider(double _taux)
        {
            if (!ouvert)
            {
                return false;
            }
            if (_taux < 0)
            {
                return false;
            }
            if (tauxDeRemplissage - _taux < 0)
            {
                return false;
            }
            else
            {
                tauxDeRemplissage -= _taux;
                return true;
            }
        }

        public bool Ouvrir()
        {
            if(ouvert == true)
            {
                return false;
            }
            else
            {
                ouvert = true;
                return true;
            }
            
        }

        public bool Fermer()
        {
            if (ouvert == false)
            {
                return false;
            }
            else
            {
                ouvert = false;
                return true;
            }
        }

        public bool GetEstOuvert()
        {
            return ouvert;
        }

        public double GetTauxDeRemplissage()
        {
            return tauxDeRemplissage;
        }

        public double GetPrix()
        {
            return prix;
        }
    }
}