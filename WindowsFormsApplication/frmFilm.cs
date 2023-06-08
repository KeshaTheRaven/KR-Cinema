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
    public partial class frmFilm : Form
    {
        public frmFilm()
        {
            InitializeComponent();
        }

        private void frmFilm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "defaultDataSet.Сценарист". При необходимости она может быть перемещена или удалена.
            this.сценаристTableAdapter.Fill(this.defaultDataSet.Сценарист);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "defaultDataSet.Поставщик". При необходимости она может быть перемещена или удалена.
            this.поставщикTableAdapter.Fill(this.defaultDataSet.Поставщик);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "defaultDataSet.Жанр". При необходимости она может быть перемещена или удалена.
            this.жанрTableAdapter.Fill(this.defaultDataSet.Жанр);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "defaultDataSet.Студия". При необходимости она может быть перемещена или удалена.
            this.студияTableAdapter.Fill(this.defaultDataSet.Студия);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "defaultDataSet.Режиссер". При необходимости она может быть перемещена или удалена.
            this.режиссерTableAdapter.Fill(this.defaultDataSet.Режиссер);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "defaultDataSet.Фильм". При необходимости она может быть перемещена или удалена.
            this.фильмTableAdapter.Fill(this.defaultDataSet.Фильм);


            button8_Click( sender,  e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmFilm_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.фильмTableAdapter.Update(this.defaultDataSet.Фильм);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            фильмBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить запись?", "Диалог удаления записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) //Если нажал Да
            {
                фильмBindingSource.RemoveCurrent();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox1.Clear();
            фильмBindingSource.Filter = "ФильмНомер=ФильмНомер";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            {// создаем приложение Excel 
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // создаем новую книгу 
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                // создаем новый лист 
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                // приложение видимо 
                app.Visible = true;
                // связь с листом 
                worksheet = (Microsoft.Office.Interop.Excel._Worksheet)workbook.ActiveSheet;
                // переименование листа 
                worksheet.Name = "Перечень фильмов";

                worksheet.Cells[2, 1] = "Перечень фильмов от " + DateTime.Today.ToString("dd-MM-yyyy");
                int offset = 4;

                // выводим заголовок 
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                { worksheet.Cells[1 + offset, i] = dataGridView1.Columns[i - 1].HeaderText; }
                // экспорт данных 
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    { worksheet.Cells[i + 2 + offset, j + 1] = dataGridView1.Rows[i].Cells[j].FormattedValue.ToString(); }
                }

                worksheet.Range["A" + Convert.ToString(1 + offset) + ":H" + Convert.ToString(dataGridView1.Rows.Count + offset)].Borders.LineStyle = 1;

                // устанавливаем жирный шрифт для заголовков 
                Microsoft.Office.Interop.Excel.Range rng = (Microsoft.Office.Interop.Excel.Range)worksheet.Rows[2];
                rng.Font.Bold = true;


                // авто-размер столбцов 
                worksheet.Columns.AutoFit();

                // сохранение файла 
                workbook.SaveAs("Перечень фильмов от " + DateTime.Today.ToString("dd-MM-yyyy") + ".xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //фильтр данных в зависимости от введенных параметров
            фильмBindingSource.Filter = "ФильмНомер=ФильмНомер";
            if (textBox1.Text.Length != 0)
                фильмBindingSource.Filter = фильмBindingSource.Filter + " and Фильм LIKE '*" + textBox1.Text + "*'";
            if (comboBox1.Text.Length != 0)
                фильмBindingSource.Filter = фильмBindingSource.Filter + " and РежиссерНомер=" + Convert.ToString(comboBox1.SelectedValue);
            if (comboBox2.Text.Length != 0)
                фильмBindingSource.Filter = фильмBindingSource.Filter + " and СтудияНомер=" + Convert.ToString(comboBox2.SelectedValue);
            if (comboBox3.Text.Length != 0)
                фильмBindingSource.Filter = фильмBindingSource.Filter + " and ЖанрНомер=" + Convert.ToString(comboBox3.SelectedValue);

        }
    }
}
