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
    public partial class EditCriminal : Form
    {
        private CriminalBase crimeBase;

        public EditCriminal(CriminalBase CrimeBase)
        {
            crimeBase = CrimeBase;
            InitializeComponent();
        }

        private void CriminalEdit_Click(object sender, EventArgs e)
        {
            CriminalConstructor crimeConstructor = new CriminalConstructor(crimeBase, Convert.ToInt32(EditingID.Value));
            crimeConstructor.ShowDialog();
            this.Close();
        }
    }
}
