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
    public partial class RemoveCriminal : Form
    {
        private CriminalBase crimeBase;

        public RemoveCriminal(CriminalBase CrimeBase)
        {
            crimeBase = CrimeBase;
            InitializeComponent();
        }

        private void CriminalRemove_Click(object sender, EventArgs e)
        {
            if (crimeBase.RemoveCriminal(Convert.ToInt32(RemovingID.Value)))
            {
                MessageBox.Show("Запись успешно удалена!");
                this.Close();
            }
            else
                MessageBox.Show("Не существует записи с таким ID");
        }
    }
}
