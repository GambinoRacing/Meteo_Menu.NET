using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meteo_Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Archive a = new Archive();
            a.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            unArchive ua = new unArchive();
            ua.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ArchiveSynop archiveS = new ArchiveSynop();
            archiveS.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            unArchiveSynop unArchiveS = new unArchiveSynop();
            unArchiveS.Show();
            this.Hide();
        }

        private void frmCreation_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 frm = new Form1();
            Application.Exit();
        }
    }
}
