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
    public partial class frmSupplier : Form
    {
        public frmSupplier()
        {
            InitializeComponent();
        }

        private void frmSupplier_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "defaultDataSet.Банк". При необходимости она может быть перемещена или удалена.
            this.банкTableAdapter.Fill(this.defaultDataSet.Банк);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "defaultDataSet.Поставщик". При необходимости она может быть перемещена или удалена.
            this.поставщикTableAdapter.Fill(this.defaultDataSet.Поставщик);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmSupplier_Load( sender,  e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.поставщикTableAdapter.Update(this.defaultDataSet.Поставщик);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            поставщикBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить запись?", "Диалог удаления записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) //Если нажал Да
            {
                поставщикBindingSource.RemoveCurrent();
            }
        }
    }
}
