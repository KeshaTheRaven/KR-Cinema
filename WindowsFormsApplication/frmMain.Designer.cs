namespace WindowsFormsApplication
{
    partial class frmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.режиссерыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сценаристыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.жанрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.районыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кинотеатрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поставщикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.категорииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильмыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кинотеатрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.опцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.банкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.арендыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(610, 473);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.кинотеатрToolStripMenuItem,
            this.опцииToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(610, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.режиссерыToolStripMenuItem,
            this.сценаристыToolStripMenuItem,
            this.студииToolStripMenuItem,
            this.жанрыToolStripMenuItem,
            this.районыToolStripMenuItem,
            this.банкиToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // режиссерыToolStripMenuItem
            // 
            this.режиссерыToolStripMenuItem.Name = "режиссерыToolStripMenuItem";
            this.режиссерыToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.режиссерыToolStripMenuItem.Text = "Режиссеры";
            this.режиссерыToolStripMenuItem.Click += new System.EventHandler(this.режиссерыToolStripMenuItem_Click);
            // 
            // сценаристыToolStripMenuItem
            // 
            this.сценаристыToolStripMenuItem.Name = "сценаристыToolStripMenuItem";
            this.сценаристыToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.сценаристыToolStripMenuItem.Text = "Сценаристы";
            this.сценаристыToolStripMenuItem.Click += new System.EventHandler(this.сценаристыToolStripMenuItem_Click);
            // 
            // студииToolStripMenuItem
            // 
            this.студииToolStripMenuItem.Name = "студииToolStripMenuItem";
            this.студииToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.студииToolStripMenuItem.Text = "Студии";
            this.студииToolStripMenuItem.Click += new System.EventHandler(this.студииToolStripMenuItem_Click);
            // 
            // жанрыToolStripMenuItem
            // 
            this.жанрыToolStripMenuItem.Name = "жанрыToolStripMenuItem";
            this.жанрыToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.жанрыToolStripMenuItem.Text = "Жанры";
            this.жанрыToolStripMenuItem.Click += new System.EventHandler(this.жанрыToolStripMenuItem_Click);
            // 
            // районыToolStripMenuItem
            // 
            this.районыToolStripMenuItem.Name = "районыToolStripMenuItem";
            this.районыToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.районыToolStripMenuItem.Text = "Районы";
            this.районыToolStripMenuItem.Click += new System.EventHandler(this.районыToolStripMenuItem_Click);
            // 
            // кинотеатрToolStripMenuItem
            // 
            this.кинотеатрToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поставщикиToolStripMenuItem,
            this.категорииToolStripMenuItem,
            this.фильмыToolStripMenuItem,
            this.кинотеатрыToolStripMenuItem,
            this.арендыToolStripMenuItem});
            this.кинотеатрToolStripMenuItem.Name = "кинотеатрToolStripMenuItem";
            this.кинотеатрToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.кинотеатрToolStripMenuItem.Text = "Кинотеатр";
            // 
            // поставщикиToolStripMenuItem
            // 
            this.поставщикиToolStripMenuItem.Name = "поставщикиToolStripMenuItem";
            this.поставщикиToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.поставщикиToolStripMenuItem.Text = "Поставщики";
            this.поставщикиToolStripMenuItem.Click += new System.EventHandler(this.поставщикиToolStripMenuItem_Click_1);
            // 
            // категорииToolStripMenuItem
            // 
            this.категорииToolStripMenuItem.Name = "категорииToolStripMenuItem";
            this.категорииToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.категорииToolStripMenuItem.Text = "Категории";
            this.категорииToolStripMenuItem.Click += new System.EventHandler(this.категорииToolStripMenuItem_Click);
            // 
            // фильмыToolStripMenuItem
            // 
            this.фильмыToolStripMenuItem.Name = "фильмыToolStripMenuItem";
            this.фильмыToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.фильмыToolStripMenuItem.Text = "Фильмы";
            this.фильмыToolStripMenuItem.Click += new System.EventHandler(this.фильмыToolStripMenuItem_Click);
            // 
            // кинотеатрыToolStripMenuItem
            // 
            this.кинотеатрыToolStripMenuItem.Name = "кинотеатрыToolStripMenuItem";
            this.кинотеатрыToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.кинотеатрыToolStripMenuItem.Text = "Кинотеатры";
            this.кинотеатрыToolStripMenuItem.Click += new System.EventHandler(this.кинотеатрыToolStripMenuItem_Click);
            // 
            // опцииToolStripMenuItem
            // 
            this.опцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.опцииToolStripMenuItem.Name = "опцииToolStripMenuItem";
            this.опцииToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.опцииToolStripMenuItem.Text = "Опции";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(548, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 27);
            this.button1.TabIndex = 17;
            this.button1.Text = "Вход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(486, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(113, 20);
            this.textBox2.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(486, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 20);
            this.textBox1.TabIndex = 15;
            // 
            // банкиToolStripMenuItem
            // 
            this.банкиToolStripMenuItem.Name = "банкиToolStripMenuItem";
            this.банкиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.банкиToolStripMenuItem.Text = "Банки";
            this.банкиToolStripMenuItem.Click += new System.EventHandler(this.банкиToolStripMenuItem_Click);
            // 
            // арендыToolStripMenuItem
            // 
            this.арендыToolStripMenuItem.Name = "арендыToolStripMenuItem";
            this.арендыToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.арендыToolStripMenuItem.Text = "Аренды";
            this.арендыToolStripMenuItem.Click += new System.EventHandler(this.арендыToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 497);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Кинотеатр";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem режиссерыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem жанрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem районыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кинотеатрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильмыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кинотеатрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem опцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem категорииToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem сценаристыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поставщикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem банкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem арендыToolStripMenuItem;
    }
}

