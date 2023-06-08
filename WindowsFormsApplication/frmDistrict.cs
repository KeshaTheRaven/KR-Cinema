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
    public partial class frmDistrict : Form
    {
        public frmDistrict()
        {
            InitializeComponent();
        }

        private void frmDistrict_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "defaultDataSet.Район". При необходимости она может быть перемещена или удалена.
            this.районTableAdapter.Fill(this.defaultDataSet.Район);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmDistrict_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.районTableAdapter.Update(this.defaultDataSet.Район);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            районBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить запись?", "Диалог удаления записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) //Если нажал Да
            {
                районBindingSource.RemoveCurrent();
            }
        }
    }
}
