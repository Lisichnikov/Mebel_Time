namespace Mebel_Time
{
    partial class Add_Delivery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Delivery));
            this.label_client = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.textBox_remaining_time = new System.Windows.Forms.TextBox();
            this.textBox_delivery_cost = new System.Windows.Forms.TextBox();
            this.textBox_client_id2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_client
            // 
            this.label_client.AutoSize = true;
            this.label_client.BackColor = System.Drawing.Color.Transparent;
            this.label_client.Font = new System.Drawing.Font("Unbounded", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_client.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label_client.Location = new System.Drawing.Point(46, 45);
            this.label_client.Name = "label_client";
            this.label_client.Size = new System.Drawing.Size(445, 44);
            this.label_client.TabIndex = 72;
            this.label_client.Text = "Создание записи";
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
            this.button_save.Location = new System.Drawing.Point(192, 256);
            this.button_save.Margin = new System.Windows.Forms.Padding(0);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(150, 50);
            this.button_save.TabIndex = 73;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Unbounded", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label25.Location = new System.Drawing.Point(73, 205);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(196, 20);
            this.label25.TabIndex = 93;
            this.label25.Text = "Время ожидания:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Font = new System.Drawing.Font("Unbounded", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label28.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label28.Location = new System.Drawing.Point(73, 168);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(174, 20);
            this.label28.TabIndex = 92;
            this.label28.Text = "Цена доставки:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("Unbounded", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label29.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label29.Location = new System.Drawing.Point(73, 131);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(127, 20);
            this.label29.TabIndex = 90;
            this.label29.Text = "ID клиента:";
            // 
            // textBox_remaining_time
            // 
            this.textBox_remaining_time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_remaining_time.Font = new System.Drawing.Font("Unbounded", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_remaining_time.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBox_remaining_time.Location = new System.Drawing.Point(271, 200);
            this.textBox_remaining_time.Name = "textBox_remaining_time";
            this.textBox_remaining_time.Size = new System.Drawing.Size(194, 31);
            this.textBox_remaining_time.TabIndex = 91;
            // 
            // textBox_delivery_cost
            // 
            this.textBox_delivery_cost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_delivery_cost.Font = new System.Drawing.Font("Unbounded", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_delivery_cost.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBox_delivery_cost.Location = new System.Drawing.Point(271, 162);
            this.textBox_delivery_cost.Name = "textBox_delivery_cost";
            this.textBox_delivery_cost.Size = new System.Drawing.Size(194, 31);
            this.textBox_delivery_cost.TabIndex = 89;
            // 
            // textBox_client_id2
            // 
            this.textBox_client_id2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_client_id2.Font = new System.Drawing.Font("Unbounded", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_client_id2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBox_client_id2.Location = new System.Drawing.Point(271, 125);
            this.textBox_client_id2.Name = "textBox_client_id2";
            this.textBox_client_id2.Size = new System.Drawing.Size(194, 31);
            this.textBox_client_id2.TabIndex = 88;
            // 
            // Add_Delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mebel_Time.Properties.Resources.Курсовая_работа_копия;
            this.ClientSize = new System.Drawing.Size(539, 327);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.textBox_remaining_time);
            this.Controls.Add(this.textBox_delivery_cost);
            this.Controls.Add(this.textBox_client_id2);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label_client);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_Delivery";
            this.Text = "Создание записи";
            this.Load += new System.EventHandler(this.Add_Delivery_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label_client;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textBox_remaining_time;
        private System.Windows.Forms.TextBox textBox_delivery_cost;
        private System.Windows.Forms.TextBox textBox_client_id2;
    }
}