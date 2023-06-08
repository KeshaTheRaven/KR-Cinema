namespace WindowsFormsApplication
{
    partial class frmRent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.defaultDataSet = new WindowsFormsApplication.defaultDataSet();
            this.арендаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.арендаTableAdapter = new WindowsFormsApplication.defaultDataSetTableAdapters.АрендаTableAdapter();
            this.фильмBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.фильмTableAdapter = new WindowsFormsApplication.defaultDataSetTableAdapters.ФильмTableAdapter();
            this.фильмBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.кинотеатрBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кинотеатрTableAdapter = new WindowsFormsApplication.defaultDataSetTableAdapters.КинотеатрTableAdapter();
            this.defaultDataSet1 = new WindowsFormsApplication.defaultDataSet();
            this.кинотеатрBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.фильмНомерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.кинотеатрНомерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.датаНачалаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаОкончанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаОплатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пениDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defaultDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.арендаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильмBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильмBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кинотеатрBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кинотеатрBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фильмНомерDataGridViewTextBoxColumn,
            this.кинотеатрНомерDataGridViewTextBoxColumn,
            this.датаНачалаDataGridViewTextBoxColumn,
            this.датаОкончанияDataGridViewTextBoxColumn,
            this.суммаОплатыDataGridViewTextBoxColumn,
            this.пениDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.арендаBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1422, 401);
            this.dataGridView1.TabIndex = 52;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.comboBox5);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1422, 92);
            this.panel2.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 88;
            this.label5.Text = "Фильм:";
            // 
            // comboBox5
            // 
            this.comboBox5.DataSource = this.фильмBindingSource1;
            this.comboBox5.DisplayMember = "Фильм";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(332, 22);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(176, 21);
            this.comboBox5.TabIndex = 87;
            this.comboBox5.ValueMember = "ФильмНомер";
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1249, 56);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 78;
            this.button7.Text = "Печать";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1329, 56);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 77;
            this.button6.Text = "Очистить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Кинотеатр:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.кинотеатрBindingSource1;
            this.comboBox1.DisplayMember = "Кинотеатр";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(78, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 21);
            this.comboBox1.TabIndex = 68;
            this.comboBox1.ValueMember = "КинотеатрНомер";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 493);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1422, 44);
            this.panel1.TabIndex = 50;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(8, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Обновить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(248, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(167, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // defaultDataSet
            // 
            this.defaultDataSet.DataSetName = "defaultDataSet";
            this.defaultDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // арендаBindingSource
            // 
            this.арендаBindingSource.DataMember = "Аренда";
            this.арендаBindingSource.DataSource = this.defaultDataSet;
            // 
            // арендаTableAdapter
            // 
            this.арендаTableAdapter.ClearBeforeFill = true;
            // 
            // фильмBindingSource
            // 
            this.фильмBindingSource.DataMember = "Фильм";
            this.фильмBindingSource.DataSource = this.defaultDataSet;
            // 
            // фильмTableAdapter
            // 
            this.фильмTableAdapter.ClearBeforeFill = true;
            // 
            // фильмBindingSource1
            // 
            this.фильмBindingSource1.DataMember = "Фильм";
            this.фильмBindingSource1.DataSource = this.defaultDataSet;
            // 
            // кинотеатрBindingSource
            // 
            this.кинотеатрBindingSource.DataMember = "Кинотеатр";
            this.кинотеатрBindingSource.DataSource = this.defaultDataSet;
            // 
            // кинотеатрTableAdapter
            // 
            this.кинотеатрTableAdapter.ClearBeforeFill = true;
            // 
            // defaultDataSet1
            // 
            this.defaultDataSet1.DataSetName = "defaultDataSet";
            this.defaultDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // кинотеатрBindingSource1
            // 
            this.кинотеатрBindingSource1.DataMember = "Кинотеатр";
            this.кинотеатрBindingSource1.DataSource = this.defaultDataSet1;
            // 
            // фильмНомерDataGridViewTextBoxColumn
            // 
            this.фильмНомерDataGridViewTextBoxColumn.DataPropertyName = "ФильмНомер";
            this.фильмНомерDataGridViewTextBoxColumn.DataSource = this.фильмBindingSource;
            this.фильмНомерDataGridViewTextBoxColumn.DisplayMember = "Фильм";
            this.фильмНомерDataGridViewTextBoxColumn.HeaderText = "Фильм";
            this.фильмНомерDataGridViewTextBoxColumn.Name = "фильмНомерDataGridViewTextBoxColumn";
            this.фильмНомерDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.фильмНомерDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.фильмНомерDataGridViewTextBoxColumn.ValueMember = "ФильмНомер";
            // 
            // кинотеатрНомерDataGridViewTextBoxColumn
            // 
            this.кинотеатрНомерDataGridViewTextBoxColumn.DataPropertyName = "КинотеатрНомер";
            this.кинотеатрНомерDataGridViewTextBoxColumn.DataSource = this.кинотеатрBindingSource;
            this.кинотеатрНомерDataGridViewTextBoxColumn.DisplayMember = "Кинотеатр";
            this.кинотеатрНомерDataGridViewTextBoxColumn.HeaderText = "Кинотеатр";
            this.кинотеатрНомерDataGridViewTextBoxColumn.Name = "кинотеатрНомерDataGridViewTextBoxColumn";
            this.кинотеатрНомерDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.кинотеатрНомерDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.кинотеатрНомерDataGridViewTextBoxColumn.ValueMember = "КинотеатрНомер";
            // 
            // датаНачалаDataGridViewTextBoxColumn
            // 
            this.датаНачалаDataGridViewTextBoxColumn.DataPropertyName = "ДатаНачала";
            this.датаНачалаDataGridViewTextBoxColumn.HeaderText = "ДатаНачала";
            this.датаНачалаDataGridViewTextBoxColumn.Name = "датаНачалаDataGridViewTextBoxColumn";
            // 
            // датаОкончанияDataGridViewTextBoxColumn
            // 
            this.датаОкончанияDataGridViewTextBoxColumn.DataPropertyName = "ДатаОкончания";
            this.датаОкончанияDataGridViewTextBoxColumn.HeaderText = "ДатаОкончания";
            this.датаОкончанияDataGridViewTextBoxColumn.Name = "датаОкончанияDataGridViewTextBoxColumn";
            // 
            // суммаОплатыDataGridViewTextBoxColumn
            // 
            this.суммаОплатыDataGridViewTextBoxColumn.DataPropertyName = "СуммаОплаты";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.суммаОплатыDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.суммаОплатыDataGridViewTextBoxColumn.HeaderText = "СуммаОплаты";
            this.суммаОплатыDataGridViewTextBoxColumn.Name = "суммаОплатыDataGridViewTextBoxColumn";
            // 
            // пениDataGridViewTextBoxColumn
            // 
            this.пениDataGridViewTextBoxColumn.DataPropertyName = "Пени";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.пениDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.пениDataGridViewTextBoxColumn.HeaderText = "Пени";
            this.пениDataGridViewTextBoxColumn.Name = "пениDataGridViewTextBoxColumn";
            // 
            // frmRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 537);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmRent";
            this.Text = "frmRent";
            this.Load += new System.EventHandler(this.frmRent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.defaultDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.арендаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильмBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильмBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кинотеатрBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кинотеатрBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private defaultDataSet defaultDataSet;
        private System.Windows.Forms.BindingSource арендаBindingSource;
        private defaultDataSetTableAdapters.АрендаTableAdapter арендаTableAdapter;
        private System.Windows.Forms.BindingSource фильмBindingSource;
        private defaultDataSetTableAdapters.ФильмTableAdapter фильмTableAdapter;
        private System.Windows.Forms.BindingSource фильмBindingSource1;
        private System.Windows.Forms.BindingSource кинотеатрBindingSource;
        private defaultDataSetTableAdapters.КинотеатрTableAdapter кинотеатрTableAdapter;
        private defaultDataSet defaultDataSet1;
        private System.Windows.Forms.BindingSource кинотеатрBindingSource1;
        private System.Windows.Forms.DataGridViewComboBoxColumn фильмНомерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn кинотеатрНомерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаНачалаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаОкончанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаОплатыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn пениDataGridViewTextBoxColumn;
    }
}