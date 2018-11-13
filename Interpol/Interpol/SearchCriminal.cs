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
    public partial class SearchCriminal : Form
    {
        private CriminalBase crimeBase;

        private Color ChoosedHairColor = new Color();
        private Color ChoosedEyeColor = new Color();

        private CriminalBase.Predicate[] AllCheck = new CriminalBase.Predicate[] { (criminal) => true };

        private List<CriminalBase.Predicate> conditions = new List<CriminalBase.Predicate>();

        public SearchCriminal(CriminalBase CrimeBase)
        {
            crimeBase = CrimeBase;
            InitializeComponent();
        }

        private void UpdateDataGrid()
        {
            CriminalsData.Rows.Clear();

            if (!CheckAll.Checked && (conditions == null || conditions.Count == 0))
                return;

            List<Criminal> Found = crimeBase.Search(CheckAll.Checked ? AllCheck : conditions.ToArray());
            for (int i = 0; i < Found.Count; i++)
            {
                CriminalsData.Rows.Add();
                CriminalsData.Rows[i].Cells[0].Value = Found[i].Id;
                CriminalsData.Rows[i].Cells[1].Value = Found[i].Name;
                CriminalsData.Rows[i].Cells[2].Value = Found[i].Surname;
                CriminalsData.Rows[i].Cells[3].Value = Found[i].Nickname;
                CriminalsData.Rows[i].Cells[4].Value = Found[i].Portrait.Height;

                CriminalsData.Rows[i].Cells[5].Style.BackColor = Found[i].Portrait.HairColor;
                CriminalsData.Rows[i].Cells[5].Value = Found[i].Portrait.HairColor.Name;

                CriminalsData.Rows[i].Cells[6].Style.BackColor = Found[i].Portrait.EyeColor;
                CriminalsData.Rows[i].Cells[6].Value = Found[i].Portrait.EyeColor.Name;

                CriminalsData.Rows[i].Cells[7].Value = Found[i].Portrait.Description;
                CriminalsData.Rows[i].Cells[8].Value = Found[i].Portrait.Motherland;
                CriminalsData.Rows[i].Cells[9].Value = Found[i].Portrait.Birth.ToShortDateString();
                CriminalsData.Rows[i].Cells[10].Value = Found[i].Citizenship;
                CriminalsData.Rows[i].Cells[11].Value = Found[i].LastHome;
                CriminalsData.Rows[i].Cells[12].Value = String.Join(",", Found[i].Languages);
                CriminalsData.Rows[i].Cells[13].Value = Found[i].CriminalWork;
                CriminalsData.Rows[i].Cells[14].Value = Found[i].LastDeal;
            }
        }

        private void CheckCrime_CheckedChanged(object sender, EventArgs e)
        {
            conditions.Clear();

            if (CheckCrimeName.Checked)
                conditions.Add((criminal) => criminal.Name.ToLower().Replace(" ", "") == CrimeName.Text.ToLower().Replace(" ", ""));

            if(CheckCrimeSurname.Checked)
                conditions.Add((criminal) => criminal.Surname.ToLower().Replace(" ", "") == CrimeSurname.Text.ToLower().Replace(" ", ""));

            if(CheckCrimeNickname.Checked)
                conditions.Add((criminal) => criminal.Nickname.ToLower().Replace(" ", "") == CrimeNickname.Text.ToLower().Replace(" ", ""));

            if (CheckCrimeHeight.Checked)
                conditions.Add((criminal) => (criminal.Portrait.Height <= Convert.ToInt32(CrimeTopHeight.Value) &&
                                             criminal.Portrait.Height >= Convert.ToInt32(CrimeBotHeight.Value)));

            if (CheckCrimeHairColor.Checked)
                conditions.Add((criminal) => (Math.Abs(criminal.Portrait.HairColor.R - ChoosedHairColor.R) < 5 && 
                                              Math.Abs(criminal.Portrait.HairColor.G - ChoosedHairColor.G) < 5 &&
                                              Math.Abs(criminal.Portrait.HairColor.B - ChoosedHairColor.B) < 5));

            if (CheckCrimeEyeColor.Checked)
                conditions.Add((criminal) => (Math.Abs(criminal.Portrait.EyeColor.R - ChoosedEyeColor.R) < 5 &&
                                              Math.Abs(criminal.Portrait.EyeColor.G - ChoosedEyeColor.G) < 5 &&
                                              Math.Abs(criminal.Portrait.EyeColor.B - ChoosedEyeColor.B) < 5));

            if (CheckCrimeDescription.Checked)
                conditions.Add((criminal) => new Regex(CrimeDescription.Text.ToLower().Replace(" ", ""))
                                                 .IsMatch(criminal.Portrait.Description.ToLower().Replace(" ", "")));

            if (CheckCrimeMotherland.Checked)
                conditions.Add((criminal) => criminal.Portrait.Motherland.ToLower().Replace(" ", "") == CrimeMotherland.Text.ToLower().Replace(" ", ""));

            if (CheckCrimeBirth.Checked)
                conditions.Add((criminal) => criminal.Portrait.Birth.Date.Equals(CrimeBirthDate.Value.Date));

            if (CheckCrimeCitizenship.Checked)
                conditions.Add((criminal) => criminal.Citizenship.ToLower().Replace(" ", "") == CrimeCitizenship.Text.ToLower().Replace(" ", ""));

            if (CheckCrimeLastHome.Checked)
                conditions.Add((criminal) => new Regex(CrimeLastHome.Text.ToLower().Replace(" ", ""))
                                                 .IsMatch(criminal.LastHome.ToLower().Replace(" ", "")));

            if (CheckCrimeLanguage.Checked)
                conditions.Add((criminal) => new Regex(CrimeLanguages.Text.ToLower().Replace(" ", ""))
                                                 .IsMatch(String.Join(",", criminal.Languages).ToLower().Replace(" ", "")));

            if (CheckCrimeWork.Checked)
                conditions.Add((criminal) => new Regex(CrimeWork.Text.ToLower().Replace(" ", ""))
                                                 .IsMatch(criminal.CriminalWork.ToLower().Replace(" ", "")));

            if (CheckCrimeLastDeal.Checked)
                conditions.Add((criminal) => new Regex(CrimeLastDeal.Text.ToLower().Replace(" ", ""))
                                                 .IsMatch(criminal.LastDeal.ToLower().Replace(" ", "")));
        }

        private void CrimeHairColor_Click(object sender, EventArgs e)
        {
            ColorChooser.ShowDialog();
            ChoosedHairColor = ColorChooser.Color;
            (sender as Control).BackColor = ChoosedHairColor;
            (sender as Control).Text = ChoosedHairColor.Name;
        }

        private void CrimeEyeColor_Click(object sender, EventArgs e)
        {
            ColorChooser.ShowDialog();
            ChoosedEyeColor = ColorChooser.Color;
            (sender as Control).BackColor = ChoosedEyeColor;
            (sender as Control).Text = ChoosedEyeColor.Name;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }
    }
}
