using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interpol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public CriminalConstructor CriminalConstructor
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public SearchCriminal SearchCriminal
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public EditCriminal EditCriminal1
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public RemoveCriminal RemoveCriminal1
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        private CriminalBase InterpolCrimeBase = Saver.Load(Environment.CurrentDirectory + "/Data/saved.txt");

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Saver.Save(InterpolCrimeBase, Environment.CurrentDirectory + "/Data/saved.txt");
        }

        private void AddCriminal_Click(object sender, EventArgs e)
        {
            CriminalConstructor CrimeConstructor = new CriminalConstructor(InterpolCrimeBase, CriminalConstructor.NotEditID);
            CrimeConstructor.ShowDialog();
        }

        private void RemoveCriminal_Click(object sender, EventArgs e)
        {
            RemoveCriminal CrimeRemover = new RemoveCriminal(InterpolCrimeBase);
            CrimeRemover.ShowDialog();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            SearchCriminal searchCrime = new SearchCriminal(InterpolCrimeBase);
            searchCrime.ShowDialog();
        }

        private void EditCriminal_Click(object sender, EventArgs e)
        {
            EditCriminal editCrime = new EditCriminal(InterpolCrimeBase);
            editCrime.ShowDialog();
        }
    }
}
