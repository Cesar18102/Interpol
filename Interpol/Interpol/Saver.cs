using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace Interpol
{
    public static class Saver
    {
        public static void Save(CriminalBase InterpolBase, string filename)
        {
            StreamWriter strw = File.CreateText(filename);
            for (int i = 0; i < InterpolBase.CountOfCriminals; i++)
                strw.WriteLine(InterpolBase[i].ToString());
            strw.Close();
        }

        public static CriminalBase Load(string filename)
        {
            CriminalBase ConstructedBase = new CriminalBase();

            try
            {
                StreamReader str = new StreamReader(filename);

                string line;
                while ((line = str.ReadLine()) != null)
                {
                    string[] data = line.Split(';');
                    ConstructedBase.AddCriminal(data[0], data[1], data[2], Convert.ToInt32(data[3]),
                        Color.FromArgb(Convert.ToInt32(data[4]), Convert.ToInt32(data[5]), Convert.ToInt32(data[6])),
                        Color.FromArgb(Convert.ToInt32(data[7]), Convert.ToInt32(data[8]), Convert.ToInt32(data[9])),
                        data[10], data[11],
                        new DateTime(Convert.ToInt32(data[12]), Convert.ToInt32(data[13]), Convert.ToInt32(data[14])),
                        data[15], data[16], data[17].Split(',').ToList(), data[18], data[19]);
                }
                str.Close();
            }
            catch 
            {
                MessageBox.Show("Не удалось загрузить сохраненные данные");
            }

            return ConstructedBase;
        }
    }
}
