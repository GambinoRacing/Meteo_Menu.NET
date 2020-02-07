using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meteo_Menu
{
    public partial class unArchiveSynop : Form
    {
        public unArchiveSynop()
        {
            InitializeComponent();
        }

        private void unArchiveSynop_Load(object sender, EventArgs e)
        {
            string[] lineOfContents = File.ReadAllLines(@"D:\dosfiles\station.txt");
            foreach (var line in lineOfContents)
            {
                string[] tokens = line.Split(',');
                comboBox1.Items.Add(tokens[0]);
            }


            comboBox2.Items.Add("01");
            comboBox2.Items.Add("02");
            comboBox2.Items.Add("03");
            comboBox2.Items.Add("04");
            comboBox2.Items.Add("05");
            comboBox2.Items.Add("06");
            comboBox2.Items.Add("07");
            comboBox2.Items.Add("08");
            comboBox2.Items.Add("09");
            comboBox2.Items.Add("10");
            comboBox2.Items.Add("11");
            comboBox2.Items.Add("12");

            comboBox3.Items.Add("2014");
            comboBox3.Items.Add("2015");
            comboBox3.Items.Add("2016");
            comboBox3.Items.Add("2017");
            comboBox3.Items.Add("2018");
            comboBox3.Items.Add("2019");
            comboBox3.Items.Add("2020");
            comboBox3.Items.Add("2021");
            comboBox3.Items.Add("2022");
            comboBox3.Items.Add("2023");
            comboBox3.Items.Add("2024");
            comboBox3.Items.Add("2025");
            comboBox3.Items.Add("2026");
            comboBox3.Items.Add("2027");
            comboBox3.Items.Add("2028");
            comboBox3.Items.Add("2029");
            comboBox3.Items.Add("2030");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string Info = "";


            string extractPath = @"D:\dosfiles\SYNOPD\SYNOPD$$.PD\" + comboBox3.SelectedItem.ToString() + @"\" + comboBox2.SelectedItem.ToString();
            string zipPath = @"D:\dosfiles\" + comboBox1.SelectedItem.ToString() + "_" + comboBox2.SelectedItem.ToString() + "_" + comboBox3.SelectedItem.ToString() + "S" + ".zip";

            if (!Directory.Exists(extractPath))
            {
                Info += "Не съществува папка в D:\\dosfiles\\SYNOPD\\SYNOPD$$.PD\\" + comboBox3.SelectedItem.ToString() + @"\" + comboBox2.SelectedItem.ToString() + Environment.NewLine + "Моля създайте, папката ръчно и опитайте отново !";
            }
             
            if(Directory.Exists(extractPath))
            {                
                    Directory.Delete(extractPath, true);
                    ZipFile.ExtractToDirectory(zipPath, @"D:\dosfiles\SYNOPD\SYNOPD$$.PD\");
                    Info += "Вашият синоптичен дневник е разархивиран успешно в папка D:\\dosfiles\\SYNOPD\\SYNOPD$$.PD\\" + comboBox3.SelectedItem.ToString() + @"\" + comboBox2.SelectedItem.ToString() + @"\" + comboBox1.SelectedItem.ToString() + Environment.NewLine;  
            }
           
            if (Info != "")
            {
                MessageBox.Show(Info);
                Application.Exit();
            }
        }
    }
}
