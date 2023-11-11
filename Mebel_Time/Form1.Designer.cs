namespace Mebel_Time
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_client = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_save = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_newNote = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_year_of_birth = new System.Windows.Forms.TextBox();
            this.textBox_adress = new System.Windows.Forms.TextBox();
            this.textBox_otchestvo = new System.Windows.Forms.TextBox();
            this.textBox_phone_number = new System.Windows.Forms.TextBox();
            this.textBox_imya = new System.Windows.Forms.TextBox();
            this.textBox_familiya = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.pictureBox_search = new System.Windows.Forms.PictureBox();
            this.pictureBox_update = new System.Windows.Forms.PictureBox();
            this.pictureBox_eraser = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_client = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_client.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_update)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_eraser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.информацияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1262, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.информацияToolStripMenuItem.Text = "Информация";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_client);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1262, 645);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage_client
            // 
            this.tabPage_client.BackgroundImage = global::Mebel_Time.Properties.Resources.Курсовая_работа_копия;
            this.tabPage_client.Controls.Add(this.panel2);
            this.tabPage_client.Controls.Add(this.panel1);
            this.tabPage_client.Controls.Add(this.textBox_search);
            this.tabPage_client.Controls.Add(this.pictureBox_search);
            this.tabPage_client.Controls.Add(this.pictureBox_update);
            this.tabPage_client.Controls.Add(this.pictureBox_eraser);
            this.tabPage_client.Controls.Add(this.dataGridView1);
            this.tabPage_client.Controls.Add(this.label_client);
            this.tabPage_client.Location = new System.Drawing.Point(4, 25);
            this.tabPage_client.Name = "tabPage_client";
            this.tabPage_client.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_client.Size = new System.Drawing.Size(1254, 616);
            this.tabPage_client.TabIndex = 0;
            this.tabPage_client.Text = "Клиенты";
            this.tabPage_client.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button_save);
            this.panel2.Controls.Add(this.button_edit);
            this.panel2.Controls.Add(this.button_delete);
            this.panel2.Controls.Add(this.button_newNote);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(829, 388);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 217);
            this.panel2.TabIndex = 20;
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.Transparent;
            this.button_save.BackgroundImage = global::Mebel_Time.Properties.Resources.малая_кнопка;
            this.button_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_save.FlatAppearance.BorderSize = 0;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Unbounded", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_save.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button_save.Location = new System.Drawing.Point(195, 141);
            this.button_save.Margin = new System.Windows.Forms.Padding(0);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(150, 50);
            this.button_save.TabIndex = 26;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = false;
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.Color.Transparent;
            this.button_edit.BackgroundImage = global::Mebel_Time.Properties.Resources.малая_кнопка;
            this.button_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_edit.FlatAppearance.BorderSize = 0;
            this.button_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit.Font = new System.Drawing.Font("Unbounded", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_edit.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button_edit.Location = new System.Drawing.Point(195, 71);
            this.button_edit.Margin = new System.Windows.Forms.Padding(0);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(150, 50);
            this.button_edit.TabIndex = 25;
            this.button_edit.Text = "Изменить";
            this.button_edit.UseVisualStyleBackColor = false;
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.Transparent;
            this.button_delete.BackgroundImage = global::Mebel_Time.Properties.Resources.малая_кнопка;
            this.button_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Unbounded", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_delete.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button_delete.Location = new System.Drawing.Point(22, 141);
            this.button_delete.Margin = new System.Windows.Forms.Padding(0);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(150, 50);
            this.button_delete.TabIndex = 24;
            this.button_delete.Text = "Удалить";
            this.button_delete.UseVisualStyleBackColor = false;
            // 
            // button_newNote
            // 
            this.button_newNote.BackColor = System.Drawing.Color.Transparent;
            this.button_newNote.BackgroundImage = global::Mebel_Time.Properties.Resources.малая_кнопка;
            this.button_newNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_newNote.FlatAppearance.BorderSize = 0;
            this.button_newNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_newNote.Font = new System.Drawing.Font("Unbounded", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_newNote.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button_newNote.Location = new System.Drawing.Point(22, 71);
            this.button_newNote.Margin = new System.Windows.Forms.Padding(0);
            this.button_newNote.Name = "button_newNote";
            this.button_newNote.Size = new System.Drawing.Size(150, 50);
            this.button_newNote.TabIndex = 23;
            this.button_newNote.Text = "Новая запись";
            this.button_newNote.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Unbounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(18, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Управление записями:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox_year_of_birth);
            this.panel1.Controls.Add(this.textBox_adress);
            this.panel1.Controls.Add(this.textBox_otchestvo);
            this.panel1.Controls.Add(this.textBox_phone_number);
            this.panel1.Controls.Add(this.textBox_imya);
            this.panel1.Controls.Add(this.textBox_familiya);
            this.panel1.Controls.Add(this.textBox_id);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(56, 388);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 217);
            this.panel1.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Unbounded", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label7.Location = new System.Drawing.Point(348, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Номер телефона:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Unbounded", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label8.Location = new System.Drawing.Point(348, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "Адрес:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Unbounded", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label9.Location = new System.Drawing.Point(348, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Год рождения:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Unbounded", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label6.Location = new System.Drawing.Point(39, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Отчество:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Unbounded", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(39, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Фамилия:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Unbounded", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(39, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Имя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Unbounded", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(495, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "ID:";
            // 
            // textBox_year_of_birth
            // 
            this.textBox_year_of_birth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_year_of_birth.Font = new System.Drawing.Font("Unbounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_year_of_birth.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBox_year_of_birth.Location = new System.Drawing.Point(551, 90);
            this.textBox_year_of_birth.Name = "textBox_year_of_birth";
            this.textBox_year_of_birth.Size = new System.Drawing.Size(164, 31);
            this.textBox_year_of_birth.TabIndex = 27;
            // 
            // textBox_adress
            // 
            this.textBox_adress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_adress.Font = new System.Drawing.Font("Unbounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_adress.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBox_adress.Location = new System.Drawing.Point(551, 127);
            this.textBox_adress.Name = "textBox_adress";
            this.textBox_adress.Size = new System.Drawing.Size(164, 31);
            this.textBox_adress.TabIndex = 26;
            // 
            // textBox_otchestvo
            // 
            this.textBox_otchestvo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_otchestvo.Font = new System.Drawing.Font("Unbounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_otchestvo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBox_otchestvo.Location = new System.Drawing.Point(161, 164);
            this.textBox_otchestvo.Name = "textBox_otchestvo";
            this.textBox_otchestvo.Size = new System.Drawing.Size(164, 31);
            this.textBox_otchestvo.TabIndex = 25;
            // 
            // textBox_phone_number
            // 
            this.textBox_phone_number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_phone_number.Font = new System.Drawing.Font("Unbounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_phone_number.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBox_phone_number.Location = new System.Drawing.Point(551, 164);
            this.textBox_phone_number.Name = "textBox_phone_number";
            this.textBox_phone_number.Size = new System.Drawing.Size(164, 31);
            this.textBox_phone_number.TabIndex = 24;
            // 
            // textBox_imya
            // 
            this.textBox_imya.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_imya.Font = new System.Drawing.Font("Unbounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_imya.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBox_imya.Location = new System.Drawing.Point(161, 90);
            this.textBox_imya.Name = "textBox_imya";
            this.textBox_imya.Size = new System.Drawing.Size(164, 31);
            this.textBox_imya.TabIndex = 23;
            // 
            // textBox_familiya
            // 
            this.textBox_familiya.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_familiya.Font = new System.Drawing.Font("Unbounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_familiya.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBox_familiya.Location = new System.Drawing.Point(161, 127);
            this.textBox_familiya.Name = "textBox_familiya";
            this.textBox_familiya.Size = new System.Drawing.Size(164, 31);
            this.textBox_familiya.TabIndex = 22;
            // 
            // textBox_id
            // 
            this.textBox_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_id.Font = new System.Drawing.Font("Unbounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_id.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBox_id.Location = new System.Drawing.Point(551, 38);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(164, 31);
            this.textBox_id.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Unbounded", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(79, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 44);
            this.label1.TabIndex = 21;
            this.label1.Text = "Запись:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mebel_Time.Properties.Resources.мелка_кнопка_копия;
            this.pictureBox1.InitialImage = global::Mebel_Time.Properties.Resources.мелка_кнопка_копия;
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 56);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_search
            // 
            this.textBox_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_search.Font = new System.Drawing.Font("Unbounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_search.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBox_search.Location = new System.Drawing.Point(988, 46);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(210, 31);
            this.textBox_search.TabIndex = 18;
            // 
            // pictureBox_search
            // 
            this.pictureBox_search.Image = global::Mebel_Time.Properties.Resources.мелка_кнопка_search;
            this.pictureBox_search.InitialImage = global::Mebel_Time.Properties.Resources.мелка_кнопка_копия;
            this.pictureBox_search.Location = new System.Drawing.Point(909, 31);
            this.pictureBox_search.Name = "pictureBox_search";
            this.pictureBox_search.Size = new System.Drawing.Size(56, 56);
            this.pictureBox_search.TabIndex = 17;
            this.pictureBox_search.TabStop = false;
            // 
            // pictureBox_update
            // 
            this.pictureBox_update.Image = global::Mebel_Time.Properties.Resources.мелка_кнопка_update;
            this.pictureBox_update.InitialImage = global::Mebel_Time.Properties.Resources.мелка_кнопка_копия;
            this.pictureBox_update.Location = new System.Drawing.Point(838, 31);
            this.pictureBox_update.Name = "pictureBox_update";
            this.pictureBox_update.Size = new System.Drawing.Size(56, 56);
            this.pictureBox_update.TabIndex = 16;
            this.pictureBox_update.TabStop = false;
            this.pictureBox_update.Click += new System.EventHandler(this.pictureBox_update_Click);
            // 
            // pictureBox_eraser
            // 
            this.pictureBox_eraser.Image = global::Mebel_Time.Properties.Resources.мелка_кнопка_копия;
            this.pictureBox_eraser.InitialImage = global::Mebel_Time.Properties.Resources.мелка_кнопка_копия;
            this.pictureBox_eraser.Location = new System.Drawing.Point(766, 31);
            this.pictureBox_eraser.Name = "pictureBox_eraser";
            this.pictureBox_eraser.Size = new System.Drawing.Size(56, 56);
            this.pictureBox_eraser.TabIndex = 15;
            this.pictureBox_eraser.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(56, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1142, 282);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label_client
            // 
            this.label_client.AutoSize = true;
            this.label_client.BackColor = System.Drawing.Color.Transparent;
            this.label_client.Font = new System.Drawing.Font("Unbounded", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_client.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label_client.Location = new System.Drawing.Point(48, 31);
            this.label_client.Name = "label_client";
            this.label_client.Size = new System.Drawing.Size(435, 44);
            this.label_client.TabIndex = 13;
            this.label_client.Text = "Клиентская база";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1254, 616);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Управление";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage_client.ResumeLayout(false);
            this.tabPage_client.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_update)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_eraser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_client;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_client;
        private System.Windows.Forms.PictureBox pictureBox_update;
        private System.Windows.Forms.PictureBox pictureBox_eraser;
        private System.Windows.Forms.PictureBox pictureBox_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_newNote;
        private System.Windows.Forms.TextBox textBox_year_of_birth;
        private System.Windows.Forms.TextBox textBox_adress;
        private System.Windows.Forms.TextBox textBox_otchestvo;
        private System.Windows.Forms.TextBox textBox_phone_number;
        private System.Windows.Forms.TextBox textBox_imya;
        private System.Windows.Forms.TextBox textBox_familiya;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

