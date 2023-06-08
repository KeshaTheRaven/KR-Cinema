using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class frmMain : Form
    {


        public frmMain()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void режиссерыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDirector newForm = new frmDirector();
            newForm.Text = режиссерыToolStripMenuItem.Text;
            newForm.Show();
        }

        private void студииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudio newForm = new frmStudio();
            newForm.Text = студииToolStripMenuItem.Text;
            newForm.Show();
        }

        private void жанрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGenre newForm = new frmGenre();
            newForm.Text = жанрыToolStripMenuItem.Text;
            newForm.Show();
        }

        private void районыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDistrict newForm = new frmDistrict();
            newForm.Text = районыToolStripMenuItem.Text;
            newForm.Show();
        }

        private void категорииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategory newForm = new frmCategory();
            newForm.Text = категорииToolStripMenuItem.Text;
            newForm.Show();
        }

        private void кинотеатрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCinema newForm = new frmCinema();
            newForm.Text = кинотеатрыToolStripMenuItem.Text;
            newForm.Show();
        }

        private void фильмыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFilm newForm = new frmFilm();
            newForm.Text = фильмыToolStripMenuItem.Text;
            newForm.Show();
        }




        private void сценаристыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmScriptwriter newForm = new frmScriptwriter();
            newForm.Text = сценаристыToolStripMenuItem.Text;
            newForm.Show();
        }


        private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }






        private void button1_Click(object sender, EventArgs e)
        {


            if ((textBox1.Text == "admin") && (textBox2.Text == "master"))
            {
                справочникиToolStripMenuItem.Visible = true;
                кинотеатрToolStripMenuItem.Visible = true;
                textBox1.Hide();
                textBox2.Hide();
                button1.Hide();
                textBox1.Clear();
                textBox2.Clear();
                this.Text = this.Text + " (режим администратора)";
                return;
            }


            textBox1.Clear();
            textBox2.Clear();
            MessageBox.Show("Введена неверная пара логин/пароль!");


        }

        private void поставщикиToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmSupplier newForm = new frmSupplier();
            newForm.Text = поставщикиToolStripMenuItem.Text;
            newForm.Show();
        }

        private void банкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBank newForm = new frmBank();
            newForm.Text = банкиToolStripMenuItem.Text;
            newForm.Show();
        }

        private void арендыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRent newForm = new frmRent();
            newForm.Text = арендыToolStripMenuItem.Text;
            newForm.Show();
        }
    }
}
