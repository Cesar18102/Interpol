using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Interpol
{
    public partial class CriminalConstructor : Form
    {
        public static readonly int NotEditID = -1;

        private CriminalBase crimeBase;
        private int editingId;

        private Color HairColorChoosed = new Color();
        private Color EyeColorChoosed = new Color();

        private const int ADULT = 5844;
        private Regex NameEngRegex = new Regex("^[A-Za-z]+(\\-[A-Za-z]+)?$");
        private Regex NameRusRegex = new Regex("^[А-Яа-я]+(\\-[А-Яа-я]+)?$");
        private Regex AddressEnumaration = new Regex("^([A-Za-zА-Яа-я0-9\\.]+,)*[A-Za-zА-Яа-я0-9\\.]+$");
        private Regex NamesEnumaration = new Regex("^([A-Za-zА-Яа-я]+,)*[A-Za-zА-Яа-я]+$");

        public CriminalConstructor(CriminalBase CrimeBase, int EditId)
        {
            crimeBase = CrimeBase;
            editingId = EditId;
            InitializeComponent();
        }

        private void AddCriminal_Click(object sender, EventArgs e)
        {
            if (!RegexCheck(CriminalNameLabel.Text, CriminalName.Text, NameRusRegex, NameEngRegex) ||
                !RegexCheck(SurnameLabel.Text, Surname.Text, NameRusRegex, NameEngRegex) ||
                !RegexCheck(NicknameLabel.Text, Nickname.Text, NameRusRegex, NameEngRegex))
                return;

            if (HairColorChoosed.IsEmpty)
            {
                MessageBox.Show("Не указано значение цвета волос!");
                return;
            }

            if (EyeColorChoosed.IsEmpty)
            {
                MessageBox.Show("Не указано значение цвета глаз!");
                return;
            }

            if (!RegexCheck(MotherlandLabel.Text, Motherland.Text, NameRusRegex, NameEngRegex))
                return;

            if ((DateTime.Now - BirthDate.Value).TotalDays < ADULT)
            {
                MessageBox.Show("Неверная дата рождения!");
                return;
            }

            if (!RegexCheck(CitizenshipLabel.Text, Citizenship.Text, NameRusRegex, NameEngRegex) || 
                !RegexCheck(LastHomeLabel.Text, LastHome.Text, AddressEnumaration) ||
                !RegexCheck(LanguagesLabel.Text, Langueges.Text, NamesEnumaration) ||
                !RegexCheck(CriminalWorkLabel.Text, CriminalWork.Text, NameRusRegex, NameEngRegex) ||
                !RegexCheck(LastDealLabel.Text, LastDeal.Text, NamesEnumaration))
                return;

            if (editingId == NotEditID)
            {
                crimeBase.AddCriminal(CriminalName.Text, Surname.Text, Nickname.Text,
                                      Convert.ToInt32(CriminalHeight.Value), HairColorChoosed,
                                      EyeColorChoosed, Description.Text, Motherland.Text,
                                      BirthDate.Value, Citizenship.Text, LastHome.Text,
                                      Langueges.Text.Split(',').ToList(),
                                      CriminalWork.Text, LastDeal.Text);

                MessageBox.Show("Запись успешно создана!");
            }
            else
            {
                if (editingId < 0 || editingId >= crimeBase.CountOfCriminals)
                {
                    MessageBox.Show("Не существует записи с таким ID");
                    return;
                }

                crimeBase[editingId] = new Criminal(
                    CriminalName.Text, Surname.Text, Nickname.Text,
                    new PhotoModel(Convert.ToInt32(CriminalHeight.Value),
                        HairColorChoosed, EyeColorChoosed, Description.Text,
                        Motherland.Text, BirthDate.Value),
                    Citizenship.Text, LastHome.Text,
                    Langueges.Text.Split(',').ToList(),
                    CriminalWork.Text, LastDeal.Text, editingId);

                MessageBox.Show("Запись успешно изменена!");
            }

            this.Close();
        }

        private bool RegexCheck(string labelText, string inputText, params Regex[] validator)
        {
            string realText = inputText.Replace(" ", "");
            foreach (Regex i in validator)
                if (i.IsMatch(realText))
                    return true;
            MessageBox.Show("В поле " + labelText.Substring(0, labelText.Length - 1) + " значение " + inputText + " имело неверный формат!");
            return false;
        }

        private void HairColor_Click(object sender, EventArgs e)
        {
            ColorChooser.ShowDialog();
            HairColorChoosed = ColorChooser.Color;
            (sender as Control).Text = HairColorChoosed.Name;
            (sender as Control).BackColor = HairColorChoosed;
        }

        private void EyeColor_Click(object sender, EventArgs e)
        {
            ColorChooser.ShowDialog();
            EyeColorChoosed = ColorChooser.Color;
            (sender as Control).Text = EyeColorChoosed.Name;
            (sender as Control).BackColor = EyeColorChoosed;
        }

        private void CriminalConstructor_Load(object sender, EventArgs e)
        {
            if (editingId == NotEditID)
                return;

            if (editingId < 0 || editingId >= crimeBase.CountOfCriminals)
            {
                MessageBox.Show("Не существует записи с таким ID");
                this.Close();
            }

            CriminalName.Text = crimeBase[editingId].Name;
            Surname.Text = crimeBase[editingId].Surname;
            Nickname.Text = crimeBase[editingId].Nickname;
            CriminalHeight.Value = crimeBase[editingId].Portrait.Height;

            HairColorChoosed = crimeBase[editingId].Portrait.HairColor;
            HairColor.BackColor = crimeBase[editingId].Portrait.HairColor;
            HairColor.Text = crimeBase[editingId].Portrait.HairColor.Name;

            EyeColorChoosed = crimeBase[editingId].Portrait.EyeColor;
            EyeColor.BackColor = crimeBase[editingId].Portrait.EyeColor;
            EyeColor.Text = crimeBase[editingId].Portrait.EyeColor.Name;

            Description.Text = crimeBase[editingId].Portrait.Description;
            Motherland.Text = crimeBase[editingId].Portrait.Motherland;
            BirthDate.Value = new DateTime(crimeBase[editingId].Portrait.Birth.Year,
                                           crimeBase[editingId].Portrait.Birth.Month,
                                           crimeBase[editingId].Portrait.Birth.Day);

            Citizenship.Text = crimeBase[editingId].Citizenship;
            LastHome.Text = crimeBase[editingId].LastHome;
            Langueges.Text = String.Join(",", crimeBase[editingId].Languages);
            CriminalWork.Text = crimeBase[editingId].CriminalWork;
            LastDeal.Text = crimeBase[editingId].LastDeal;
        }
    }
}
