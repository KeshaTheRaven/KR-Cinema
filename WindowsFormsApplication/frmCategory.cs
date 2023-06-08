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
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "defaultDataSet.Категория". При необходимости она может быть перемещена или удалена.
            this.категорияTableAdapter.Fill(this.defaultDataSet.Категория);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmCategory_Load( sender,  e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.категорияTableAdapter.Update(this.defaultDataSet.Категория);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            категорияBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить запись?", "Диалог удаления записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) //Если нажал Да
            {
                категорияBindingSource.RemoveCurrent();
            }
        }
    }
}
