using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bouteille
{

    public class PackDeBouteille
    {
        private List<Bouteille> listeDeBouteilles;
        private string matiereEmballageString;
        private MatiereEmballage matiereEmballage;

        public PackDeBouteille()
        {
            listeDeBouteilles = new List<Bouteille>();
        }

        public bool Ajouter(Bouteille bouteille)
        {
            try
            {
                listeDeBouteilles.Add(bouteille);
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool Retirer(Bouteille bouteille)
        {
            try 
            {
                listeDeBouteilles.Remove(bouteille);
                return true;
            }
            catch
            {
                return false;
            }


        }

        public double CalculerPrixPack()
        {
            double prix = 0;
            foreach (Bouteille b in listeDeBouteilles)
            {
                prix += b.GetPrix();
            }
            return prix;
        }

        public string GetString()
        {
            string temp = "Recapitulatif du pack :\n";
            int i = 0;

            foreach (Bouteille b in listeDeBouteilles)
            {
                i++;
                if (b.GetEstOuvert())
                {
                    temp += ("bouteille numero : " + i + "\tEtat : ouverte\tPrix : " + b.GetPrix() + "euros  remplissage : " + b.GetTauxDeRemplissage() + "% \n");
                }
                else
                {
                    temp += ("bouteille numero : " + i + "\tEtat : fermer\tPrix : " + b.GetPrix() + "euros  remplissage : " + b.GetTauxDeRemplissage() + "% \n");
                }

            }
            return temp;
        }

        public Bouteille GetBouteille(int n)
        {
            return listeDeBouteilles[n];
        }

        public bool ResolveMatiereEmballage(string str)
        {
            bool ok;
            switch (str)
            {
                case ("carton"):
                    matiereEmballage = MatiereEmballage.carton;
                    ok = true;
                    break;

                case ("plastique"):
                    matiereEmballage = MatiereEmballage.plastique;
                    ok = true;
                    break;
                case ("filet"):
                    matiereEmballage = MatiereEmballage.filet;
                    ok = true;
                    break;
                default:
                    ok = false;
                    break;
            }
            if (ok)
            {
                matiereEmballageString = matiereEmballage.ToString();
            }

            return ok;

        }

        public List<Bouteille> GetListBouteille()
        {
            return listeDeBouteilles;
        }

        public string GetMatiereEmballageToString()
        {
            return matiereEmballageString;
        }
        

    }
}