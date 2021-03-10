namespace lab1semestr4BD
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
            this.AddStaff_But = new System.Windows.Forms.Button();
            this.OpenStaff = new System.Windows.Forms.Button();
            this.OpenHalls = new System.Windows.Forms.Button();
            this.OpenExhibit = new System.Windows.Forms.Button();
            this.OpenTrips = new System.Windows.Forms.Button();
            this.PanelStaff = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DeleteStaff_But = new System.Windows.Forms.Button();
            this.ChangeStaff_But = new System.Windows.Forms.Button();
            this.DGVstaff = new System.Windows.Forms.DataGridView();
            this.PanelHall = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.DeleteHall_But = new System.Windows.Forms.Button();
            this.ChangeHall_But = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddHall_But = new System.Windows.Forms.Button();
            this.PanelStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVstaff)).BeginInit();
            this.PanelHall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddStaff_But
            // 
            this.AddStaff_But.Location = new System.Drawing.Point(20, 335);
            this.AddStaff_But.Name = "AddStaff_But";
            this.AddStaff_But.Size = new System.Drawing.Size(284, 73);
            this.AddStaff_But.TabIndex = 0;
            this.AddStaff_But.Text = "Добавить";
            this.AddStaff_But.UseVisualStyleBackColor = true;
            this.AddStaff_But.Click += new System.EventHandler(this.AddStaff_But_Click);
            // 
            // OpenStaff
            // 
            this.OpenStaff.Location = new System.Drawing.Point(12, 12);
            this.OpenStaff.Name = "OpenStaff";
            this.OpenStaff.Size = new System.Drawing.Size(212, 66);
            this.OpenStaff.TabIndex = 1;
            this.OpenStaff.Text = "Сотрудники";
            this.OpenStaff.UseVisualStyleBackColor = true;
            this.OpenStaff.Click += new System.EventHandler(this.OpenStaff_Click);
            // 
            // OpenHalls
            // 
            this.OpenHalls.Location = new System.Drawing.Point(337, 12);
            this.OpenHalls.Name = "OpenHalls";
            this.OpenHalls.Size = new System.Drawing.Size(212, 66);
            this.OpenHalls.TabIndex = 2;
            this.OpenHalls.Text = "Залы";
            this.OpenHalls.UseVisualStyleBackColor = true;
            this.OpenHalls.Click += new System.EventHandler(this.OpenHalls_Click);
            // 
            // OpenExhibit
            // 
            this.OpenExhibit.Location = new System.Drawing.Point(645, 12);
            this.OpenExhibit.Name = "OpenExhibit";
            this.OpenExhibit.Size = new System.Drawing.Size(212, 66);
            this.OpenExhibit.TabIndex = 3;
            this.OpenExhibit.Text = "Экспонаты";
            this.OpenExhibit.UseVisualStyleBackColor = true;
            this.OpenExhibit.Click += new System.EventHandler(this.OpenExhibit_Click);
            // 
            // OpenTrips
            // 
            this.OpenTrips.Location = new System.Drawing.Point(931, 12);
            this.OpenTrips.Name = "OpenTrips";
            this.OpenTrips.Size = new System.Drawing.Size(212, 66);
            this.OpenTrips.TabIndex = 4;
            this.OpenTrips.Text = "Выставки";
            this.OpenTrips.UseVisualStyleBackColor = true;
            this.OpenTrips.Click += new System.EventHandler(this.OpenTrips_Click);
            // 
            // PanelStaff
            // 
            this.PanelStaff.Controls.Add(this.label3);
            this.PanelStaff.Controls.Add(this.label2);
            this.PanelStaff.Controls.Add(this.label1);
            this.PanelStaff.Controls.Add(this.textBox3);
            this.PanelStaff.Controls.Add(this.textBox2);
            this.PanelStaff.Controls.Add(this.textBox1);
            this.PanelStaff.Controls.Add(this.DeleteStaff_But);
            this.PanelStaff.Controls.Add(this.ChangeStaff_But);
            this.PanelStaff.Controls.Add(this.DGVstaff);
            this.PanelStaff.Controls.Add(this.AddStaff_But);
            this.PanelStaff.Location = new System.Drawing.Point(13, 99);
            this.PanelStaff.Name = "PanelStaff";
            this.PanelStaff.Size = new System.Drawing.Size(1130, 546);
            this.PanelStaff.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(355, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Должность";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(355, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(355, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Фамилия";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(489, 457);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(307, 30);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(489, 399);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(307, 30);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(489, 335);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(307, 30);
            this.textBox1.TabIndex = 4;
            // 
            // DeleteStaff_But
            // 
            this.DeleteStaff_But.Location = new System.Drawing.Point(824, 335);
            this.DeleteStaff_But.Name = "DeleteStaff_But";
            this.DeleteStaff_But.Size = new System.Drawing.Size(284, 73);
            this.DeleteStaff_But.TabIndex = 3;
            this.DeleteStaff_But.Text = "Удалить";
            this.DeleteStaff_But.UseVisualStyleBackColor = true;
            this.DeleteStaff_But.Click += new System.EventHandler(this.DeleteStaff_But_Click);
            // 
            // ChangeStaff_But
            // 
            this.ChangeStaff_But.Location = new System.Drawing.Point(20, 414);
            this.ChangeStaff_But.Name = "ChangeStaff_But";
            this.ChangeStaff_But.Size = new System.Drawing.Size(284, 73);
            this.ChangeStaff_But.TabIndex = 2;
            this.ChangeStaff_But.Text = "Изменение";
            this.ChangeStaff_But.UseVisualStyleBackColor = true;
            this.ChangeStaff_But.Click += new System.EventHandler(this.ChangeStaff_But_Click);
            // 
            // DGVstaff
            // 
            this.DGVstaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVstaff.Location = new System.Drawing.Point(20, 20);
            this.DGVstaff.Name = "DGVstaff";
            this.DGVstaff.RowHeadersWidth = 51;
            this.DGVstaff.RowTemplate.Height = 24;
            this.DGVstaff.Size = new System.Drawing.Size(1088, 300);
            this.DGVstaff.TabIndex = 1;
            // 
            // PanelHall
            // 
            this.PanelHall.Controls.Add(this.label4);
            this.PanelHall.Controls.Add(this.label5);
            this.PanelHall.Controls.Add(this.label6);
            this.PanelHall.Controls.Add(this.textBox4);
            this.PanelHall.Controls.Add(this.textBox5);
            this.PanelHall.Controls.Add(this.textBox6);
            this.PanelHall.Controls.Add(this.DeleteHall_But);
            this.PanelHall.Controls.Add(this.ChangeHall_But);
            this.PanelHall.Controls.Add(this.dataGridView1);
            this.PanelHall.Controls.Add(this.AddHall_But);
            this.PanelHall.Location = new System.Drawing.Point(12, 99);
            this.PanelHall.Name = "PanelHall";
            this.PanelHall.Size = new System.Drawing.Size(1130, 546);
            this.PanelHall.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(355, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Должность";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(355, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Имя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(355, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Фамилия";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(489, 457);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(307, 30);
            this.textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(489, 399);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(307, 30);
            this.textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox6.Location = new System.Drawing.Point(489, 335);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(307, 30);
            this.textBox6.TabIndex = 4;
            // 
            // DeleteHall_But
            // 
            this.DeleteHall_But.Location = new System.Drawing.Point(824, 335);
            this.DeleteHall_But.Name = "DeleteHall_But";
            this.DeleteHall_But.Size = new System.Drawing.Size(284, 73);
            this.DeleteHall_But.TabIndex = 3;
            this.DeleteHall_But.Text = "Удалить";
            this.DeleteHall_But.UseVisualStyleBackColor = true;
            // 
            // ChangeHall_But
            // 
            this.ChangeHall_But.Location = new System.Drawing.Point(20, 414);
            this.ChangeHall_But.Name = "ChangeHall_But";
            this.ChangeHall_But.Size = new System.Drawing.Size(284, 73);
            this.ChangeHall_But.TabIndex = 2;
            this.ChangeHall_But.Text = "Изменение";
            this.ChangeHall_But.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1088, 300);
            this.dataGridView1.TabIndex = 1;
            // 
            // AddHall_But
            // 
            this.AddHall_But.Location = new System.Drawing.Point(20, 335);
            this.AddHall_But.Name = "AddHall_But";
            this.AddHall_But.Size = new System.Drawing.Size(284, 73);
            this.AddHall_But.TabIndex = 0;
            this.AddHall_But.Text = "Добавить";
            this.AddHall_But.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 657);
            this.Controls.Add(this.PanelHall);
            this.Controls.Add(this.PanelStaff);
            this.Controls.Add(this.OpenTrips);
            this.Controls.Add(this.OpenExhibit);
            this.Controls.Add(this.OpenHalls);
            this.Controls.Add(this.OpenStaff);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная 1";
            this.PanelStaff.ResumeLayout(false);
            this.PanelStaff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVstaff)).EndInit();
            this.PanelHall.ResumeLayout(false);
            this.PanelHall.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddStaff_But;
        private System.Windows.Forms.Button OpenStaff;
        private System.Windows.Forms.Button OpenHalls;
        private System.Windows.Forms.Button OpenExhibit;
        private System.Windows.Forms.Button OpenTrips;
        private System.Windows.Forms.Panel PanelStaff;
        private System.Windows.Forms.Button DeleteStaff_But;
        private System.Windows.Forms.Button ChangeStaff_But;
        private System.Windows.Forms.DataGridView DGVstaff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel PanelHall;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button DeleteHall_But;
        private System.Windows.Forms.Button ChangeHall_But;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddHall_But;
    }
}

