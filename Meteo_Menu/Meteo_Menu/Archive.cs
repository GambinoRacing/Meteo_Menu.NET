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
    public partial class Archive : Form
    {
        public Archive()
        {
            InitializeComponent();
        }

        private void Archive_Load(object sender, EventArgs e)
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

            if (!Directory.Exists(startPath))
            {
                Directory.CreateDirectory(startPath);
                MessageBox.Show("Не е намерена папка в директория ValPoch " + comboBox1.SelectedItem.ToString() + "_" + comboBox2.SelectedItem.ToString() + ".SVD" + 
                    ", най-вероятно нямате почвени дневници, затова ще бъде създадена празна папка за да може архивът да бъде създаден !");
            }

            if (File.Exists(zipPath))
            {
                File.Delete(zipPath);
                ZipFile.CreateFromDirectory(startPath, zipPath);
                Info += "Вашият архив е създаден в папка D:\\dosfiles\\" + comboBox1.SelectedItem.ToString() + "_" + comboBox2.SelectedItem.ToString() + ".SVR.zip" + Environment.NewLine;
            }
            else
            {
                ZipFile.CreateFromDirectory(startPath, zipPath);
                Info += "Вашият архив е създаден в папка D:\\dosfiles\\" + comboBox1.SelectedItem.ToString() + "_" + comboBox2.SelectedItem.ToString() + ".SVR.zip" + Environment.NewLine;
            }

            string startPath1 = @"D:\dosfiles\SVK\" + comboBox1.SelectedItem.ToString() + "_" + comboBox2.SelectedItem.ToString() + ".SVD";
            string zipPath1 = @"D:\dosfiles\" + comboBox1.SelectedItem.ToString() + "_" + comboBox2.SelectedItem.ToString() + ".SVK.zip";

            if (!Directory.Exists(startPath1))
            {
                Directory.CreateDirectory(startPath1);
                MessageBox.Show("Не е намерена папка в директория SVK " + comboBox1.SelectedItem.ToString() + "_" + comboBox2.SelectedItem.ToString() + ".SVD");
            }

            if (File.Exists(zipPath1))
            {
                File.Delete(zipPath1);
                ZipFile.CreateFromDirectory(startPath1, zipPath1);
                Info += "Вашият архив е създаден в папка D:\\dosfiles\\" + comboBox1.SelectedItem.ToString() + "_" + comboBox2.SelectedItem.ToString() + ".SVK.zip";
            }
            else
            {
                ZipFile.CreateFromDirectory(startPath1, zipPath1);
                Info += "Вашият архив е създаден в папка D:\\dosfiles\\" + comboBox1.SelectedItem.ToString() + "_" + comboBox2.SelectedItem.ToString() + ".SVK.zip";
            }
            if (Info != "")
            {
                MessageBox.Show(Info);
                Application.Exit();
            }
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
