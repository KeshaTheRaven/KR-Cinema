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
    public partial class frmCinema : Form
    {
        public frmCinema()
        {
            InitializeComponent();
        }

        private void frmCinema_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "defaultDataSet.Банк". При необходимости она может быть перемещена или удалена.
            this.банкTableAdapter.Fill(this.defaultDataSet.Банк);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "defaultDataSet.Категория". При необходимости она может быть перемещена или удалена.
            this.категорияTableAdapter.Fill(this.defaultDataSet.Категория);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "defaultDataSet.Район". При необходимости она может быть перемещена или удалена.
            this.районTableAdapter.Fill(this.defaultDataSet.Район);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "defaultDataSet.Кинотеатр". При необходимости она может быть перемещена или удалена.
            this.кинотеатрTableAdapter.Fill(this.defaultDataSet.Кинотеатр);
            button8_Click(sender, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //фильтр данных в зависимости от введенных параметров
            кинотеатрBindingSource.Filter = "КинотеатрНомер=КинотеатрНомер";
            if (textBox1.Text.Length != 0)
                кинотеатрBindingSource.Filter = кинотеатрBindingSource.Filter + " and Кинотеатр LIKE '*" + textBox1.Text + "*'";
            if (comboBox1.Text.Length != 0)
                кинотеатрBindingSource.Filter = кинотеатрBindingSource.Filter + " and РайонНомер=" + Convert.ToString(comboBox1.SelectedValue);
            if (comboBox2.Text.Length != 0)
                кинотеатрBindingSource.Filter = кинотеатрBindingSource.Filter + " and КатегорияНомер=" + Convert.ToString(comboBox2.SelectedValue);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmCinema_Load(sender,  e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.кинотеатрTableAdapter.Update(this.defaultDataSet.Кинотеатр);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            кинотеатрBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить запись?", "Диалог удаления записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) //Если нажал Да
            {
                кинотеатрBindingSource.RemoveCurrent();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox1.Clear();
            кинотеатрBindingSource.Filter = "КинотеатрНомер=КинотеатрНомер";
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
                worksheet.Name = "Перечень кинотеатров";

                worksheet.Cells[2, 1] = "Перечень кинотеатров от " + DateTime.Today.ToString("dd-MM-yyyy");
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

                worksheet.Range["A" + Convert.ToString(1 + offset) + ":K" + Convert.ToString(dataGridView1.Rows.Count + offset)].Borders.LineStyle = 1;

                // устанавливаем жирный шрифт для заголовков 
                Microsoft.Office.Interop.Excel.Range rng = (Microsoft.Office.Interop.Excel.Range)worksheet.Rows[2];
                rng.Font.Bold = true;


                // авто-размер столбцов 
                worksheet.Columns.AutoFit();

                // сохранение файла 
                workbook.SaveAs("Перечень кинотеатров от " + DateTime.Today.ToString("dd-MM-yyyy") + ".xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            }
        }
    }
}
