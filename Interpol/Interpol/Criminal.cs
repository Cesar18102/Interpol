using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpol
{
    public class Criminal
    {
        private string name;
        private string surname;
        private string nickname;
        private PhotoModel portrait;
        private string citizenship;
        private string lastHome;
        private List<string> languages;
        private string criminalWork;
        private string lastDeal;
        private int id;

        public Criminal(
            string Name, string Surname, string Nickname,
            PhotoModel Portrait, string Citizenship, string LastHome, 
            List<string> Languages, string CriminalWork, string LastDeal, int Id)
        {
            surname = Surname;
            name = Name;
            nickname = Nickname;
            portrait = Portrait;
            citizenship = Citizenship;
            lastHome = LastHome;
            languages = Languages;
            criminalWork = CriminalWork;
            lastDeal = LastDeal;
            id = Id;
        }

        public Criminal(Criminal copyCriminal) : this(
            copyCriminal.name, copyCriminal.surname,
            copyCriminal.nickname, copyCriminal.portrait,
            copyCriminal.citizenship, copyCriminal.lastHome,
            copyCriminal.languages, copyCriminal.criminalWork,
            copyCriminal.lastDeal, copyCriminal.id)
        {

        }

        public string Surname {get {return surname;} }
        public string Name {get {return name;}}
        public string Nickname { get { return nickname; } }
        public PhotoModel Portrait { get { return new PhotoModel(portrait); } }
        public string Citizenship { get { return citizenship; } }
        public string LastHome { get { return lastHome; } }
        public List<string> Languages { get { return languages; } }
        public string CriminalWork { get { return criminalWork; } }
        public string LastDeal { get { return lastDeal; } }
        public int Id { get { return id; } }

        public PhotoModel PhotoModel
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public override string ToString()
        {
            return Name + ";" + Surname + ";" +
                   Nickname + ";" + Portrait.ToString() + ";" + 
                   Citizenship + ";" + LastHome + ";" +
                   String.Join(",", Languages) + ";" + 
                   CriminalWork + ";" + LastDeal;
        }
    }
}
