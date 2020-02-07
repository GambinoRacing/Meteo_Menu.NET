using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;

namespace Meteo_Menu
{
    public partial class unArchive : Form
    {
        public unArchive()
        {
            InitializeComponent();
        }

        private void unArchive_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("01");
            comboBox1.Items.Add("02");
            comboBox1.Items.Add("03");
            comboBox1.Items.Add("04");
            comboBox1.Items.Add("05");
            comboBox1.Items.Add("06");
            comboBox1.Items.Add("07");
            comboBox1.Items.Add("08");
            comboBox1.Items.Add("09");
            comboBox1.Items.Add("10");
            comboBox1.Items.Add("11");
            comboBox1.Items.Add("12");

            comboBox2.Items.Add("2014");
            comboBox2.Items.Add("2015");
            comboBox2.Items.Add("2016");
            comboBox2.Items.Add("2017");
            comboBox2.Items.Add("2018");
            comboBox2.Items.Add("2019");
            comboBox2.Items.Add("2020");
            comboBox2.Items.Add("2021");
            comboBox2.Items.Add("2022");
            comboBox2.Items.Add("2023");
            comboBox2.Items.Add("2024");
            comboBox2.Items.Add("2025");
            comboBox2.Items.Add("2026");
            comboBox2.Items.Add("2027");
            comboBox2.Items.Add("2028");
            comboBox2.Items.Add("2029");
            comboBox2.Items.Add("2030");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Info = "";
            string startPath = @"D:\dosfiles\ValPoch\" + comboBox1.SelectedItem.ToString() + "_" + comboBox2.SelectedItem.ToString() + ".SVD";
            string zipPath = @"D:\dosfiles\" + comboBox1.SelectedItem.ToString() + "_" + comboBox2.SelectedItem.ToString() + ".SVR.zip";

            string startPath1 = @"D:\dosfiles\SVK\" + comboBox1.SelectedItem.ToString() + "_" + comboBox2.SelectedItem.ToString() + ".SVD";
            string zipPath1 = @"D:\dosfiles\" + comboBox1.SelectedItem.ToString() + "_" + comboBox2.SelectedItem.ToString() + ".SVK.zip";

            if (!File.Exists(zipPath1))
            {
                MessageBox.Show("Архивът - " + comboBox1.SelectedItem.ToString() + "_" + comboBox2.SelectedItem.ToString() + ".SVK.zip" + " не съществува в папка D:\\dosfiles\\" + Environment.NewLine);
                Application.Exit();              
                
            }

            if (!File.Exists(zipPath))
            {
                MessageBox.Show("Архивът - " + comboBox1.SelectedItem.ToString() + "_" + comboBox2.SelectedItem.ToString() + ".SVR.zip" + " не съществува в папка D:\\dosfiles\\" + Environment.NewLine + "Моля, архивирайте отново и след това разархивирайте !" + Environment.NewLine + "Така, ще получите и втория архив, който е нужен за да бъдат разархивирани останалите дневници !");
                Application.Exit();
            }


            if (Directory.Exists(startPath))
            {
                Directory.Delete(startPath, true);
                ZipFile.ExtractToDirectory(zipPath, startPath);
                Info += "Вашият архив е разархивиран в папка D:\\dosfiles\\ValPoch\\" + comboBox1.SelectedItem.ToString() + "_" + comboBox2.SelectedItem.ToString() + ".SVD" + Environment.NewLine;
            }
            else
            {
                ZipFile.ExtractToDirectory(zipPath, startPath);
                Info += "Вашият архив е разархивиран в папка D:\\dosfiles\\ValPoch\\" + comboBox1.SelectedItem.ToString() + "_" + comboBox2.SelectedItem.ToString() + ".SVD" + Environment.NewLine;
            }

         
            if (Directory.Exists(startPath1))
            {
                Directory.Delete(startPath1, true);
                ZipFile.ExtractToDirectory(zipPath1, startPath1);
                Info += "Вашият архив е разархивиран в папка D:\\dosfiles\\SVK\\" + comboBox1.SelectedItem.ToString() + "_" + comboBox2.SelectedItem.ToString() + ".SVD" + Environment.NewLine;
            }
            else
            {
                ZipFile.ExtractToDirectory(zipPath1, startPath1);
                Info += "Вашият архив е разархивиран в папка D:\\dosfiles\\SVK\\" + comboBox1.SelectedItem.ToString() + "_" + comboBox2.SelectedItem.ToString() + ".SVD" + Environment.NewLine;
            }
            if (Info != "")
            {
                MessageBox.Show(Info);
                Application.Exit();
            }
            
        }
    }
}
