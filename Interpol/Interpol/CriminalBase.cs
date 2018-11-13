using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Interpol
{
    public class CriminalBase
    {
        private List<Criminal> Criminals = new List<Criminal>();
        public int CountOfCriminals { get { return Criminals.Count; } }

        public Criminal this[int i]
        {
            get { return (i < 0 || i >= Criminals.Count) ? null : Criminals[i]; }
            set
            {
                if (i < 0 || i >= Criminals.Count || value == null)
                    return;
                Criminals[i] = value;
            }
        }

        public Criminal Criminal
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void AddCriminal(
            string Name, string Surname, string Nickname,
            int Height, Color HairColor, Color EyeColor,
            string Description, string Motherland,
            DateTime Birth, string Citizenship, 
            string LastHome, List<string> Languages,
            string CriminalWork, string LastDeal)
        {
            Criminals.Add(new Criminal(
                Name, Surname, Nickname, 
                new PhotoModel(Height, HairColor, EyeColor, 
                               Description, Motherland, Birth),
                Citizenship, LastHome, Languages,
                CriminalWork, LastDeal, Criminals.Count));
        }

        public bool RemoveCriminal(int idOfCriminal)
        {
            if (idOfCriminal < 0 || idOfCriminal >= Criminals.Count)
                return false;

            Criminals.RemoveAt(idOfCriminal);
            return true;
        }

        public List<Criminal> Search(params Predicate[] pred)
        {
            List<Criminal> criminalSelection = new List<Criminal>();
            foreach (Criminal i in Criminals)
            {
                bool ToAdd = true;
                foreach (Predicate P in pred)
                    if (!P(i))
                    {
                        ToAdd = false;
                        break;
                    }

                if (ToAdd)
                    criminalSelection.Add(i);
            }
            return criminalSelection;
        }

        public delegate bool Predicate(Criminal criminal);
    }
}
