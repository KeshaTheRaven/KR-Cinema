namespace WindowsFormsApplication
{
    partial class frmCinema
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.районBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.defaultDataSet = new WindowsFormsApplication.defaultDataSet();
            this.категорияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кинотеатрBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.категорияBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.районBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.кинотеатрTableAdapter = new WindowsFormsApplication.defaultDataSetTableAdapters.КинотеатрTableAdapter();
            this.районTableAdapter = new WindowsFormsApplication.defaultDataSetTableAdapters.РайонTableAdapter();
            this.категорияTableAdapter = new WindowsFormsApplication.defaultDataSetTableAdapters.КатегорияTableAdapter();
            this.банкBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.банкTableAdapter = new WindowsFormsApplication.defaultDataSetTableAdapters.БанкTableAdapter();
            this.кинотеатрDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Директор = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Владелец = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Телефон = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.районНомерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.БанкНомер = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ИНН = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.НомерСчета = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.категорияНомерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.КатегорияНомер = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.районBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.категорияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кинотеатрBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.категорияBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.районBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.банкBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кинотеатрDataGridViewTextBoxColumn,
            this.Директор,
            this.Владелец,
            this.Телефон,
            this.районНомерDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn,
            this.БанкНомер,
            this.ИНН,
            this.НомерСчета,
            this.категорияНомерDataGridViewTextBoxColumn,
            this.КатегорияНомер});
            this.dataGridView1.DataSource = this.кинотеатрBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1467, 304);
            this.dataGridView1.TabIndex = 69;
            // 
            // районBindingSource
            // 
            this.районBindingSource.DataMember = "Район";
            this.районBindingSource.DataSource = this.defaultDataSet;
            // 
            // defaultDataSet
            // 
            this.defaultDataSet.DataSetName = "defaultDataSet";
            this.defaultDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // категорияBindingSource
            // 
            this.категорияBindingSource.DataMember = "Категория";
            this.категорияBindingSource.DataSource = this.defaultDataSet;
            // 
            // кинотеатрBindingSource
            // 
            this.кинотеатрBindingSource.DataMember = "Кинотеатр";
            this.кинотеатрBindingSource.DataSource = this.defaultDataSet;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1467, 78);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 20);
            this.textBox1.TabIndex = 57;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(582, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Категория:";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.категорияBindingSource1;
            this.comboBox2.DisplayMember = "Категория";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(651, 19);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(196, 21);
            this.comboBox2.TabIndex = 54;
            this.comboBox2.ValueMember = "КатегорияНомер";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // категорияBindingSource1
            // 
            this.категорияBindingSource1.DataMember = "Категория";
            this.категорияBindingSource1.DataSource = this.defaultDataSet;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1386, 49);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 53;
            this.button8.Text = "Очистить";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1306, 49);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 48;
            this.button9.Text = "Отчет";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Район:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.районBindingSource1;
            this.comboBox1.DisplayMember = "Район";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(363, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 21);
            this.comboBox1.TabIndex = 42;
            this.comboBox1.ValueMember = "РайонНомер";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // районBindingSource1
            // 
            this.районBindingSource1.DataMember = "Район";
            this.районBindingSource1.DataSource = this.defaultDataSet;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 382);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1467, 44);
            this.panel1.TabIndex = 67;
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
            // кинотеатрTableAdapter
            // 
            this.кинотеатрTableAdapter.ClearBeforeFill = true;
            // 
            // районTableAdapter
            // 
            this.районTableAdapter.ClearBeforeFill = true;
            // 
            // категорияTableAdapter
            // 
            this.категорияTableAdapter.ClearBeforeFill = true;
            // 
            // банкBindingSource
            // 
            this.банкBindingSource.DataMember = "Банк";
            this.банкBindingSource.DataSource = this.defaultDataSet;
            // 
            // банкTableAdapter
            // 
            this.банкTableAdapter.ClearBeforeFill = true;
            // 
            // кинотеатрDataGridViewTextBoxColumn
            // 
            this.кинотеатрDataGridViewTextBoxColumn.DataPropertyName = "Кинотеатр";
            this.кинотеатрDataGridViewTextBoxColumn.HeaderText = "Кинотеатр";
            this.кинотеатрDataGridViewTextBoxColumn.Name = "кинотеатрDataGridViewTextBoxColumn";
            // 
            // Директор
            // 
            this.Директор.DataPropertyName = "Директор";
            this.Директор.HeaderText = "Директор";
            this.Директор.Name = "Директор";
            // 
            // Владелец
            // 
            this.Владелец.DataPropertyName = "Владелец";
            this.Владелец.HeaderText = "Владелец";
            this.Владелец.Name = "Владелец";
            // 
            // Телефон
            // 
            this.Телефон.DataPropertyName = "Телефон";
            this.Телефон.HeaderText = "Телефон";
            this.Телефон.Name = "Телефон";
            // 
            // районНомерDataGridViewTextBoxColumn
            // 
            this.районНомерDataGridViewTextBoxColumn.DataPropertyName = "РайонНомер";
            this.районНомерDataGridViewTextBoxColumn.DataSource = this.районBindingSource;
            this.районНомерDataGridViewTextBoxColumn.DisplayMember = "Район";
            this.районНомерDataGridViewTextBoxColumn.HeaderText = "Район";
            this.районНомерDataGridViewTextBoxColumn.Name = "районНомерDataGridViewTextBoxColumn";
            this.районНомерDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.районНомерDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.районНомерDataGridViewTextBoxColumn.ValueMember = "РайонНомер";
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            // 
            // БанкНомер
            // 
            this.БанкНомер.DataPropertyName = "БанкНомер";
            this.БанкНомер.DataSource = this.банкBindingSource;
            this.БанкНомер.DisplayMember = "Банк";
            this.БанкНомер.HeaderText = "Банк";
            this.БанкНомер.Name = "БанкНомер";
            this.БанкНомер.ValueMember = "БанкНомер";
            // 
            // ИНН
            // 
            this.ИНН.DataPropertyName = "ИНН";
            this.ИНН.HeaderText = "ИНН";
            this.ИНН.Name = "ИНН";
            // 
            // НомерСчета
            // 
            this.НомерСчета.DataPropertyName = "НомерСчета";
            this.НомерСчета.HeaderText = "НомерСчета";
            this.НомерСчета.Name = "НомерСчета";
            // 
            // категорияНомерDataGridViewTextBoxColumn
            // 
            this.категорияНомерDataGridViewTextBoxColumn.DataPropertyName = "КатегорияНомер";
            this.категорияНомерDataGridViewTextBoxColumn.DataSource = this.категорияBindingSource;
            this.категорияНомерDataGridViewTextBoxColumn.DisplayMember = "Категория";
            this.категорияНомерDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.категорияНомерDataGridViewTextBoxColumn.Name = "категорияНомерDataGridViewTextBoxColumn";
            this.категорияНомерDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.категорияНомерDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.категорияНомерDataGridViewTextBoxColumn.ValueMember = "КатегорияНомер";
            // 
            // КатегорияНомер
            // 
            this.КатегорияНомер.DataPropertyName = "КатегорияНомер";
            this.КатегорияНомер.DataSource = this.категорияBindingSource;
            this.КатегорияНомер.DisplayMember = "Вместимость";
            this.КатегорияНомер.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.КатегорияНомер.HeaderText = "Вместимость";
            this.КатегорияНомер.Name = "КатегорияНомер";
            this.КатегорияНомер.ReadOnly = true;
            this.КатегорияНомер.ValueMember = "КатегорияНомер";
            // 
            // frmCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 426);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frmCinema";
            this.Text = "frmCinema";
            this.Load += new System.EventHandler(this.frmCinema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.районBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.категорияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кинотеатрBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.категорияBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.районBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.банкBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private defaultDataSet defaultDataSet;
        private System.Windows.Forms.BindingSource кинотеатрBindingSource;
        private defaultDataSetTableAdapters.КинотеатрTableAdapter кинотеатрTableAdapter;
        private System.Windows.Forms.BindingSource районBindingSource;
        private defaultDataSetTableAdapters.РайонTableAdapter районTableAdapter;
        private System.Windows.Forms.BindingSource категорияBindingSource;
        private defaultDataSetTableAdapters.КатегорияTableAdapter категорияTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource категорияBindingSource1;
        private System.Windows.Forms.BindingSource районBindingSource1;
        private System.Windows.Forms.BindingSource банкBindingSource;
        private defaultDataSetTableAdapters.БанкTableAdapter банкTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кинотеатрDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Директор;
        private System.Windows.Forms.DataGridViewTextBoxColumn Владелец;
        private System.Windows.Forms.DataGridViewTextBoxColumn Телефон;
        private System.Windows.Forms.DataGridViewComboBoxColumn районНомерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn БанкНомер;
        private System.Windows.Forms.DataGridViewTextBoxColumn ИНН;
        private System.Windows.Forms.DataGridViewTextBoxColumn НомерСчета;
        private System.Windows.Forms.DataGridViewComboBoxColumn категорияНомерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn КатегорияНомер;
    }
}