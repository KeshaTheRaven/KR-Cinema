namespace WindowsFormsApplication
{
    partial class frmFilm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.режиссерBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.defaultDataSet = new WindowsFormsApplication.defaultDataSet();
            this.студияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.жанрBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.фильмBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.жанрBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.студияBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.режиссерBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.фильмTableAdapter = new WindowsFormsApplication.defaultDataSetTableAdapters.ФильмTableAdapter();
            this.режиссерTableAdapter = new WindowsFormsApplication.defaultDataSetTableAdapters.РежиссерTableAdapter();
            this.студияTableAdapter = new WindowsFormsApplication.defaultDataSetTableAdapters.СтудияTableAdapter();
            this.жанрTableAdapter = new WindowsFormsApplication.defaultDataSetTableAdapters.ЖанрTableAdapter();
            this.поставщикBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поставщикTableAdapter = new WindowsFormsApplication.defaultDataSetTableAdapters.ПоставщикTableAdapter();
            this.сценаристBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сценаристTableAdapter = new WindowsFormsApplication.defaultDataSetTableAdapters.СценаристTableAdapter();
            this.фильмDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ПоставщикНомер = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.режиссерНомерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.СценаристНомер = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.студияНомерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.жанрНомерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ГодВыхода = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Стоимость = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.режиссерBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.студияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.жанрBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильмBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.жанрBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.студияBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.режиссерBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сценаристBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фильмDataGridViewTextBoxColumn,
            this.ПоставщикНомер,
            this.режиссерНомерDataGridViewTextBoxColumn,
            this.СценаристНомер,
            this.студияНомерDataGridViewTextBoxColumn,
            this.жанрНомерDataGridViewTextBoxColumn,
            this.ГодВыхода,
            this.Стоимость});
            this.dataGridView1.DataSource = this.фильмBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1459, 373);
            this.dataGridView1.TabIndex = 72;
            // 
            // режиссерBindingSource
            // 
            this.режиссерBindingSource.DataMember = "Режиссер";
            this.режиссерBindingSource.DataSource = this.defaultDataSet;
            // 
            // defaultDataSet
            // 
            this.defaultDataSet.DataSetName = "defaultDataSet";
            this.defaultDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // студияBindingSource
            // 
            this.студияBindingSource.DataMember = "Студия";
            this.студияBindingSource.DataSource = this.defaultDataSet;
            // 
            // жанрBindingSource
            // 
            this.жанрBindingSource.DataMember = "Жанр";
            this.жанрBindingSource.DataSource = this.defaultDataSet;
            // 
            // фильмBindingSource
            // 
            this.фильмBindingSource.DataMember = "Фильм";
            this.фильмBindingSource.DataSource = this.defaultDataSet;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox3);
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
            this.groupBox1.Size = new System.Drawing.Size(1459, 78);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(892, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Жанр:";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.жанрBindingSource1;
            this.comboBox3.DisplayMember = "Жанр";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(946, 19);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(196, 21);
            this.comboBox3.TabIndex = 58;
            this.comboBox3.ValueMember = "ЖанрНомер";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // жанрBindingSource1
            // 
            this.жанрBindingSource1.DataMember = "Жанр";
            this.жанрBindingSource1.DataSource = this.defaultDataSet;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 20);
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
            this.label2.Location = new System.Drawing.Point(590, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Студия:";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.студияBindingSource1;
            this.comboBox2.DisplayMember = "Студия";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(651, 19);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(196, 21);
            this.comboBox2.TabIndex = 54;
            this.comboBox2.ValueMember = "СтудияНомер";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // студияBindingSource1
            // 
            this.студияBindingSource1.DataMember = "Студия";
            this.студияBindingSource1.DataSource = this.defaultDataSet;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1378, 49);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 53;
            this.button8.Text = "Очистить";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1298, 49);
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
            this.label1.Location = new System.Drawing.Point(296, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Режиссер:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.режиссерBindingSource1;
            this.comboBox1.DisplayMember = "Режиссер";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(363, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 21);
            this.comboBox1.TabIndex = 42;
            this.comboBox1.ValueMember = "РежиссерНомер";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // режиссерBindingSource1
            // 
            this.режиссерBindingSource1.DataMember = "Режиссер";
            this.режиссерBindingSource1.DataSource = this.defaultDataSet;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 451);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1459, 44);
            this.panel1.TabIndex = 70;
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
            // фильмTableAdapter
            // 
            this.фильмTableAdapter.ClearBeforeFill = true;
            // 
            // режиссерTableAdapter
            // 
            this.режиссерTableAdapter.ClearBeforeFill = true;
            // 
            // студияTableAdapter
            // 
            this.студияTableAdapter.ClearBeforeFill = true;
            // 
            // жанрTableAdapter
            // 
            this.жанрTableAdapter.ClearBeforeFill = true;
            // 
            // поставщикBindingSource
            // 
            this.поставщикBindingSource.DataMember = "Поставщик";
            this.поставщикBindingSource.DataSource = this.defaultDataSet;
            // 
            // поставщикTableAdapter
            // 
            this.поставщикTableAdapter.ClearBeforeFill = true;
            // 
            // сценаристBindingSource
            // 
            this.сценаристBindingSource.DataMember = "Сценарист";
            this.сценаристBindingSource.DataSource = this.defaultDataSet;
            // 
            // сценаристTableAdapter
            // 
            this.сценаристTableAdapter.ClearBeforeFill = true;
            // 
            // фильмDataGridViewTextBoxColumn
            // 
            this.фильмDataGridViewTextBoxColumn.DataPropertyName = "Фильм";
            this.фильмDataGridViewTextBoxColumn.HeaderText = "Фильм";
            this.фильмDataGridViewTextBoxColumn.Name = "фильмDataGridViewTextBoxColumn";
            // 
            // ПоставщикНомер
            // 
            this.ПоставщикНомер.DataPropertyName = "ПоставщикНомер";
            this.ПоставщикНомер.DataSource = this.поставщикBindingSource;
            this.ПоставщикНомер.DisplayMember = "Поставщик";
            this.ПоставщикНомер.HeaderText = "Поставщик";
            this.ПоставщикНомер.Name = "ПоставщикНомер";
            this.ПоставщикНомер.ValueMember = "ПоставщикНомер";
            // 
            // режиссерНомерDataGridViewTextBoxColumn
            // 
            this.режиссерНомерDataGridViewTextBoxColumn.DataPropertyName = "РежиссерНомер";
            this.режиссерНомерDataGridViewTextBoxColumn.DataSource = this.режиссерBindingSource;
            this.режиссерНомерDataGridViewTextBoxColumn.DisplayMember = "Режиссер";
            this.режиссерНомерDataGridViewTextBoxColumn.HeaderText = "Режиссер";
            this.режиссерНомерDataGridViewTextBoxColumn.Name = "режиссерНомерDataGridViewTextBoxColumn";
            this.режиссерНомерDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.режиссерНомерDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.режиссерНомерDataGridViewTextBoxColumn.ValueMember = "РежиссерНомер";
            // 
            // СценаристНомер
            // 
            this.СценаристНомер.DataPropertyName = "СценаристНомер";
            this.СценаристНомер.DataSource = this.сценаристBindingSource;
            this.СценаристНомер.DisplayMember = "Сценарист";
            this.СценаристНомер.HeaderText = "Сценарист";
            this.СценаристНомер.Name = "СценаристНомер";
            this.СценаристНомер.ValueMember = "СценаристНомер";
            // 
            // студияНомерDataGridViewTextBoxColumn
            // 
            this.студияНомерDataGridViewTextBoxColumn.DataPropertyName = "СтудияНомер";
            this.студияНомерDataGridViewTextBoxColumn.DataSource = this.студияBindingSource;
            this.студияНомерDataGridViewTextBoxColumn.DisplayMember = "Студия";
            this.студияНомерDataGridViewTextBoxColumn.HeaderText = "Студия";
            this.студияНомерDataGridViewTextBoxColumn.Name = "студияНомерDataGridViewTextBoxColumn";
            this.студияНомерDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.студияНомерDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.студияНомерDataGridViewTextBoxColumn.ValueMember = "СтудияНомер";
            // 
            // жанрНомерDataGridViewTextBoxColumn
            // 
            this.жанрНомерDataGridViewTextBoxColumn.DataPropertyName = "ЖанрНомер";
            this.жанрНомерDataGridViewTextBoxColumn.DataSource = this.жанрBindingSource;
            this.жанрНомерDataGridViewTextBoxColumn.DisplayMember = "Жанр";
            this.жанрНомерDataGridViewTextBoxColumn.HeaderText = "Жанр";
            this.жанрНомерDataGridViewTextBoxColumn.Name = "жанрНомерDataGridViewTextBoxColumn";
            this.жанрНомерDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.жанрНомерDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.жанрНомерDataGridViewTextBoxColumn.ValueMember = "ЖанрНомер";
            // 
            // ГодВыхода
            // 
            this.ГодВыхода.DataPropertyName = "ГодВыхода";
            this.ГодВыхода.HeaderText = "ГодВыхода";
            this.ГодВыхода.Name = "ГодВыхода";
            // 
            // Стоимость
            // 
            this.Стоимость.DataPropertyName = "Стоимость";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Стоимость.DefaultCellStyle = dataGridViewCellStyle2;
            this.Стоимость.HeaderText = "Стоимость";
            this.Стоимость.Name = "Стоимость";
            // 
            // frmFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 495);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frmFilm";
            this.Text = "frmFilm";
            this.Load += new System.EventHandler(this.frmFilm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.режиссерBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.студияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.жанрBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильмBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.жанрBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.студияBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.режиссерBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сценаристBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private defaultDataSet defaultDataSet;
        private System.Windows.Forms.BindingSource фильмBindingSource;
        private defaultDataSetTableAdapters.ФильмTableAdapter фильмTableAdapter;
        private System.Windows.Forms.BindingSource режиссерBindingSource;
        private defaultDataSetTableAdapters.РежиссерTableAdapter режиссерTableAdapter;
        private System.Windows.Forms.BindingSource студияBindingSource;
        private defaultDataSetTableAdapters.СтудияTableAdapter студияTableAdapter;
        private System.Windows.Forms.BindingSource жанрBindingSource;
        private defaultDataSetTableAdapters.ЖанрTableAdapter жанрTableAdapter;
        private System.Windows.Forms.BindingSource жанрBindingSource1;
        private System.Windows.Forms.BindingSource студияBindingSource1;
        private System.Windows.Forms.BindingSource режиссерBindingSource1;
        private System.Windows.Forms.BindingSource поставщикBindingSource;
        private defaultDataSetTableAdapters.ПоставщикTableAdapter поставщикTableAdapter;
        private System.Windows.Forms.BindingSource сценаристBindingSource;
        private defaultDataSetTableAdapters.СценаристTableAdapter сценаристTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn фильмDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ПоставщикНомер;
        private System.Windows.Forms.DataGridViewComboBoxColumn режиссерНомерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn СценаристНомер;
        private System.Windows.Forms.DataGridViewComboBoxColumn студияНомерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn жанрНомерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ГодВыхода;
        private System.Windows.Forms.DataGridViewTextBoxColumn Стоимость;
    }
}