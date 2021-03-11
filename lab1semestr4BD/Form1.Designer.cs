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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.DeleteHall_But = new System.Windows.Forms.Button();
            this.ChangeHall_But = new System.Windows.Forms.Button();
            this.DGVhall = new System.Windows.Forms.DataGridView();
            this.AddHall_But = new System.Windows.Forms.Button();
            this.PanelExhibit = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.DeleteExhibit_But = new System.Windows.Forms.Button();
            this.ChangeExhibit_But = new System.Windows.Forms.Button();
            this.DGVexhibit = new System.Windows.Forms.DataGridView();
            this.AddExhibit_But = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.PanelTrip = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.DeleteTrip_But = new System.Windows.Forms.Button();
            this.ChangeTrip_But = new System.Windows.Forms.Button();
            this.DGVtrip = new System.Windows.Forms.DataGridView();
            this.AddTrip_But = new System.Windows.Forms.Button();
            this.PanelStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVstaff)).BeginInit();
            this.PanelHall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVhall)).BeginInit();
            this.PanelExhibit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVexhibit)).BeginInit();
            this.PanelTrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVtrip)).BeginInit();
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
            this.OpenStaff.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OpenStaff.Location = new System.Drawing.Point(12, 12);
            this.OpenStaff.Name = "OpenStaff";
            this.OpenStaff.Size = new System.Drawing.Size(212, 66);
            this.OpenStaff.TabIndex = 1;
            this.OpenStaff.Text = "Сотрудники";
            this.OpenStaff.UseVisualStyleBackColor = false;
            this.OpenStaff.Click += new System.EventHandler(this.OpenStaff_Click);
            // 
            // OpenHalls
            // 
            this.OpenHalls.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OpenHalls.Location = new System.Drawing.Point(337, 12);
            this.OpenHalls.Name = "OpenHalls";
            this.OpenHalls.Size = new System.Drawing.Size(212, 66);
            this.OpenHalls.TabIndex = 2;
            this.OpenHalls.Text = "Залы";
            this.OpenHalls.UseVisualStyleBackColor = false;
            this.OpenHalls.Click += new System.EventHandler(this.OpenHalls_Click);
            // 
            // OpenExhibit
            // 
            this.OpenExhibit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OpenExhibit.Location = new System.Drawing.Point(645, 12);
            this.OpenExhibit.Name = "OpenExhibit";
            this.OpenExhibit.Size = new System.Drawing.Size(212, 66);
            this.OpenExhibit.TabIndex = 3;
            this.OpenExhibit.Text = "Экспонаты";
            this.OpenExhibit.UseVisualStyleBackColor = false;
            this.OpenExhibit.Click += new System.EventHandler(this.OpenExhibit_Click);
            // 
            // OpenTrips
            // 
            this.OpenTrips.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OpenTrips.Location = new System.Drawing.Point(931, 12);
            this.OpenTrips.Name = "OpenTrips";
            this.OpenTrips.Size = new System.Drawing.Size(212, 66);
            this.OpenTrips.TabIndex = 4;
            this.OpenTrips.Text = "Выставки";
            this.OpenTrips.UseVisualStyleBackColor = false;
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
            this.PanelHall.Controls.Add(this.comboBox1);
            this.PanelHall.Controls.Add(this.label5);
            this.PanelHall.Controls.Add(this.label6);
            this.PanelHall.Controls.Add(this.textBox6);
            this.PanelHall.Controls.Add(this.DeleteHall_But);
            this.PanelHall.Controls.Add(this.ChangeHall_But);
            this.PanelHall.Controls.Add(this.DGVhall);
            this.PanelHall.Controls.Add(this.AddHall_But);
            this.PanelHall.Location = new System.Drawing.Point(12, 99);
            this.PanelHall.Name = "PanelHall";
            this.PanelHall.Size = new System.Drawing.Size(1130, 546);
            this.PanelHall.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(490, 399);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(307, 33);
            this.comboBox1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(320, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Сотрудники";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(320, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Название зала";
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
            this.DeleteHall_But.Click += new System.EventHandler(this.DeleteHall_But_Click);
            // 
            // ChangeHall_But
            // 
            this.ChangeHall_But.Location = new System.Drawing.Point(20, 414);
            this.ChangeHall_But.Name = "ChangeHall_But";
            this.ChangeHall_But.Size = new System.Drawing.Size(284, 73);
            this.ChangeHall_But.TabIndex = 2;
            this.ChangeHall_But.Text = "Изменение";
            this.ChangeHall_But.UseVisualStyleBackColor = true;
            this.ChangeHall_But.Click += new System.EventHandler(this.ChangeHall_But_Click);
            // 
            // DGVhall
            // 
            this.DGVhall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVhall.Location = new System.Drawing.Point(20, 20);
            this.DGVhall.Name = "DGVhall";
            this.DGVhall.RowHeadersWidth = 51;
            this.DGVhall.RowTemplate.Height = 24;
            this.DGVhall.Size = new System.Drawing.Size(1088, 300);
            this.DGVhall.TabIndex = 1;
            // 
            // AddHall_But
            // 
            this.AddHall_But.Location = new System.Drawing.Point(20, 335);
            this.AddHall_But.Name = "AddHall_But";
            this.AddHall_But.Size = new System.Drawing.Size(284, 73);
            this.AddHall_But.TabIndex = 0;
            this.AddHall_But.Text = "Добавить";
            this.AddHall_But.UseVisualStyleBackColor = true;
            this.AddHall_But.Click += new System.EventHandler(this.AddHall_But_Click);
            // 
            // PanelExhibit
            // 
            this.PanelExhibit.Controls.Add(this.label8);
            this.PanelExhibit.Controls.Add(this.textBox5);
            this.PanelExhibit.Controls.Add(this.comboBox2);
            this.PanelExhibit.Controls.Add(this.label4);
            this.PanelExhibit.Controls.Add(this.label7);
            this.PanelExhibit.Controls.Add(this.textBox4);
            this.PanelExhibit.Controls.Add(this.DeleteExhibit_But);
            this.PanelExhibit.Controls.Add(this.ChangeExhibit_But);
            this.PanelExhibit.Controls.Add(this.DGVexhibit);
            this.PanelExhibit.Controls.Add(this.AddExhibit_But);
            this.PanelExhibit.Location = new System.Drawing.Point(15, 96);
            this.PanelExhibit.Name = "PanelExhibit";
            this.PanelExhibit.Size = new System.Drawing.Size(1130, 546);
            this.PanelExhibit.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(489, 432);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(307, 33);
            this.comboBox2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(319, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Зал выставки";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(320, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Экспонат";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(489, 335);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(307, 30);
            this.textBox4.TabIndex = 4;
            // 
            // DeleteExhibit_But
            // 
            this.DeleteExhibit_But.Location = new System.Drawing.Point(824, 335);
            this.DeleteExhibit_But.Name = "DeleteExhibit_But";
            this.DeleteExhibit_But.Size = new System.Drawing.Size(284, 73);
            this.DeleteExhibit_But.TabIndex = 3;
            this.DeleteExhibit_But.Text = "Удалить";
            this.DeleteExhibit_But.UseVisualStyleBackColor = true;
            this.DeleteExhibit_But.Click += new System.EventHandler(this.DeleteExhibit_But_Click);
            // 
            // ChangeExhibit_But
            // 
            this.ChangeExhibit_But.Location = new System.Drawing.Point(20, 414);
            this.ChangeExhibit_But.Name = "ChangeExhibit_But";
            this.ChangeExhibit_But.Size = new System.Drawing.Size(284, 73);
            this.ChangeExhibit_But.TabIndex = 2;
            this.ChangeExhibit_But.Text = "Изменение";
            this.ChangeExhibit_But.UseVisualStyleBackColor = true;
            this.ChangeExhibit_But.Click += new System.EventHandler(this.ChangeExhibit_But_Click);
            // 
            // DGVexhibit
            // 
            this.DGVexhibit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVexhibit.Location = new System.Drawing.Point(20, 20);
            this.DGVexhibit.Name = "DGVexhibit";
            this.DGVexhibit.RowHeadersWidth = 51;
            this.DGVexhibit.RowTemplate.Height = 24;
            this.DGVexhibit.Size = new System.Drawing.Size(1088, 300);
            this.DGVexhibit.TabIndex = 1;
            // 
            // AddExhibit_But
            // 
            this.AddExhibit_But.Location = new System.Drawing.Point(20, 335);
            this.AddExhibit_But.Name = "AddExhibit_But";
            this.AddExhibit_But.Size = new System.Drawing.Size(284, 73);
            this.AddExhibit_But.TabIndex = 0;
            this.AddExhibit_But.Text = "Добавить";
            this.AddExhibit_But.UseVisualStyleBackColor = true;
            this.AddExhibit_But.Click += new System.EventHandler(this.AddExhibit_But_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(318, 381);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Материал";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(487, 381);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(307, 30);
            this.textBox5.TabIndex = 10;
            // 
            // PanelTrip
            // 
            this.PanelTrip.Controls.Add(this.label9);
            this.PanelTrip.Controls.Add(this.textBox7);
            this.PanelTrip.Controls.Add(this.comboBox3);
            this.PanelTrip.Controls.Add(this.label10);
            this.PanelTrip.Controls.Add(this.label11);
            this.PanelTrip.Controls.Add(this.textBox8);
            this.PanelTrip.Controls.Add(this.DeleteTrip_But);
            this.PanelTrip.Controls.Add(this.ChangeTrip_But);
            this.PanelTrip.Controls.Add(this.DGVtrip);
            this.PanelTrip.Controls.Add(this.AddTrip_But);
            this.PanelTrip.Location = new System.Drawing.Point(18, 93);
            this.PanelTrip.Name = "PanelTrip";
            this.PanelTrip.Size = new System.Drawing.Size(1130, 546);
            this.PanelTrip.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(318, 381);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 25);
            this.label9.TabIndex = 11;
            this.label9.Text = "Дата";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox7.Location = new System.Drawing.Point(489, 330);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(307, 30);
            this.textBox7.TabIndex = 10;
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(489, 432);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(307, 33);
            this.comboBox3.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(319, 432);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 25);
            this.label10.TabIndex = 8;
            this.label10.Text = "Зал выставки";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(320, 335);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 25);
            this.label11.TabIndex = 7;
            this.label11.Text = "Кол-во людей";
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox8.Location = new System.Drawing.Point(489, 376);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(307, 30);
            this.textBox8.TabIndex = 4;
            // 
            // DeleteTrip_But
            // 
            this.DeleteTrip_But.Location = new System.Drawing.Point(824, 335);
            this.DeleteTrip_But.Name = "DeleteTrip_But";
            this.DeleteTrip_But.Size = new System.Drawing.Size(284, 73);
            this.DeleteTrip_But.TabIndex = 3;
            this.DeleteTrip_But.Text = "Удалить";
            this.DeleteTrip_But.UseVisualStyleBackColor = true;
            this.DeleteTrip_But.Click += new System.EventHandler(this.DeleteTrip_But_Click);
            // 
            // ChangeTrip_But
            // 
            this.ChangeTrip_But.Location = new System.Drawing.Point(20, 414);
            this.ChangeTrip_But.Name = "ChangeTrip_But";
            this.ChangeTrip_But.Size = new System.Drawing.Size(284, 73);
            this.ChangeTrip_But.TabIndex = 2;
            this.ChangeTrip_But.Text = "Изменение";
            this.ChangeTrip_But.UseVisualStyleBackColor = true;
            this.ChangeTrip_But.Click += new System.EventHandler(this.ChangeTrip_But_Click);
            // 
            // DGVtrip
            // 
            this.DGVtrip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVtrip.Location = new System.Drawing.Point(20, 20);
            this.DGVtrip.Name = "DGVtrip";
            this.DGVtrip.RowHeadersWidth = 51;
            this.DGVtrip.RowTemplate.Height = 24;
            this.DGVtrip.Size = new System.Drawing.Size(1088, 300);
            this.DGVtrip.TabIndex = 1;
            // 
            // AddTrip_But
            // 
            this.AddTrip_But.Location = new System.Drawing.Point(20, 335);
            this.AddTrip_But.Name = "AddTrip_But";
            this.AddTrip_But.Size = new System.Drawing.Size(284, 73);
            this.AddTrip_But.TabIndex = 0;
            this.AddTrip_But.Text = "Добавить";
            this.AddTrip_But.UseVisualStyleBackColor = true;
            this.AddTrip_But.Click += new System.EventHandler(this.AddTrip_But_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 657);
            this.Controls.Add(this.PanelTrip);
            this.Controls.Add(this.PanelExhibit);
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
            ((System.ComponentModel.ISupportInitialize)(this.DGVhall)).EndInit();
            this.PanelExhibit.ResumeLayout(false);
            this.PanelExhibit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVexhibit)).EndInit();
            this.PanelTrip.ResumeLayout(false);
            this.PanelTrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVtrip)).EndInit();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button DeleteHall_But;
        private System.Windows.Forms.Button ChangeHall_But;
        private System.Windows.Forms.DataGridView DGVhall;
        private System.Windows.Forms.Button AddHall_But;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel PanelExhibit;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button DeleteExhibit_But;
        private System.Windows.Forms.Button ChangeExhibit_But;
        private System.Windows.Forms.DataGridView DGVexhibit;
        private System.Windows.Forms.Button AddExhibit_But;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Panel PanelTrip;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button DeleteTrip_But;
        private System.Windows.Forms.Button ChangeTrip_But;
        private System.Windows.Forms.DataGridView DGVtrip;
        private System.Windows.Forms.Button AddTrip_But;
    }
}

