﻿using System;
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
    public partial class frmRent : Form
    {
        public frmRent()
        {
            InitializeComponent();
        }

        private void frmRent_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "defaultDataSet.Кинотеатр". При необходимости она может быть перемещена или удалена.
            this.кинотеатрTableAdapter.Fill(this.defaultDataSet.Кинотеатр);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "defaultDataSet.Фильм". При необходимости она может быть перемещена или удалена.
            this.фильмTableAdapter.Fill(this.defaultDataSet.Фильм);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "defaultDataSet.Аренда". При необходимости она может быть перемещена или удалена.
            this.арендаTableAdapter.Fill(this.defaultDataSet.Аренда);

            button6_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmRent_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.арендаTableAdapter.Update(this.defaultDataSet.Аренда);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            арендаBindingSource.AddNew();

            DataRowView drw = арендаBindingSource.Current as DataRowView;
            drw["ДатаНачала"] = DateTime.Today.ToString();
            drw["ДатаОкончания"] = DateTime.Today.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить запись?", "Диалог удаления записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) //Если нажал Да
            {
                арендаBindingSource.RemoveCurrent();
            }
        }

        private void button7_Click(object sender, EventArgs e)
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
                worksheet.Name = "Перечень аренд";

                worksheet.Cells[2, 1] = "Перечень аренд от " + DateTime.Today.ToString("dd-MM-yyyy");
                int offset = 4;
                int i = 0, j = 0;
                // выводим заголовок 
                for (i = 1; i < dataGridView1.Columns.Count + 1; i++)
                { worksheet.Cells[1 + offset, i] = dataGridView1.Columns[i - 1].HeaderText; }
                // экспорт данных 
                for (i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (j = 0; j < dataGridView1.Columns.Count; j++)
                    { worksheet.Cells[i + 2 + offset, j + 1] = dataGridView1.Rows[i].Cells[j].FormattedValue.ToString(); }
                }

                worksheet.Range["A" + Convert.ToString(1 + offset) + ":F" + Convert.ToString(dataGridView1.Rows.Count + offset)].Borders.LineStyle = 1;

                // устанавливаем жирный шрифт для заголовков 
                Microsoft.Office.Interop.Excel.Range rng = (Microsoft.Office.Interop.Excel.Range)worksheet.Rows[2];
                rng.Font.Bold = true;


                // авто-размер столбцов 
                worksheet.Columns.AutoFit();

                // сохранение файла 
                workbook.SaveAs("Перечень аренд от " + DateTime.Today.ToString("dd-MM-yyyy") + ".xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox5.Text = "";

            арендаBindingSource.Filter = "АрендаНомер=АрендаНомер";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //фильтр данных в зависимости от введенных параметров
            арендаBindingSource.Filter = "АрендаНомер=АрендаНомер";
            if (comboBox1.Text.Length != 0)
                арендаBindingSource.Filter = арендаBindingSource.Filter + " and КинотеатрНомер=" + Convert.ToString(comboBox1.SelectedValue);

            if (comboBox5.Text.Length != 0)
                арендаBindingSource.Filter = арендаBindingSource.Filter + " and ФильмНомер=" + Convert.ToString(comboBox5.SelectedValue);
        }
    }
}
