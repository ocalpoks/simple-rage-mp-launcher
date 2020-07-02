namespace Launcher
{
    partial class MainWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.port_textbox = new System.Windows.Forms.TextBox();
            this.ip_textbox = new System.Windows.Forms.TextBox();
            this.Connect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SelectDirectoryGTA5 = new System.Windows.Forms.Button();
            this.SelectDirectory = new System.Windows.Forms.FolderBrowserDialog();
            this.showDirectory = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Адрес";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Порт";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.showDirectory);
            this.groupBox1.Controls.Add(this.SelectDirectoryGTA5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.name_textbox);
            this.groupBox1.Controls.Add(this.port_textbox);
            this.groupBox1.Controls.Add(this.ip_textbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 268);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры подключения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Имя";
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(86, 202);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(265, 26);
            this.name_textbox.TabIndex = 5;
            this.name_textbox.Text = "Player";
            // 
            // port_textbox
            // 
            this.port_textbox.Location = new System.Drawing.Point(86, 156);
            this.port_textbox.Name = "port_textbox";
            this.port_textbox.Size = new System.Drawing.Size(265, 26);
            this.port_textbox.TabIndex = 4;
            this.port_textbox.Text = "22005";
            // 
            // ip_textbox
            // 
            this.ip_textbox.Location = new System.Drawing.Point(86, 107);
            this.ip_textbox.Name = "ip_textbox";
            this.ip_textbox.Size = new System.Drawing.Size(265, 26);
            this.ip_textbox.TabIndex = 3;
            this.ip_textbox.Text = "127.0.0.1";
            // 
            // Connect
            // 
            this.Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Connect.Location = new System.Drawing.Point(218, 287);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(169, 39);
            this.Connect.TabIndex = 3;
            this.Connect.Text = "Подключиться";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "GTA5";
            // 
            // SelectDirectoryGTA5
            // 
            this.SelectDirectoryGTA5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectDirectoryGTA5.Location = new System.Drawing.Point(86, 42);
            this.SelectDirectoryGTA5.Name = "SelectDirectoryGTA5";
            this.SelectDirectoryGTA5.Size = new System.Drawing.Size(125, 27);
            this.SelectDirectoryGTA5.TabIndex = 7;
            this.SelectDirectoryGTA5.Text = "Выбрать";
            this.SelectDirectoryGTA5.UseVisualStyleBackColor = true;
            this.SelectDirectoryGTA5.Click += new System.EventHandler(this.SelectDirectoryGTA5_Click);
            // 
            // SelectDirectory
            // 
            this.SelectDirectory.SelectedPath = "D:\\Program Files\\Rockstar Games\\Grand Theft Auto V";
            // 
            // showDirectory
            // 
            this.showDirectory.AutoSize = true;
            this.showDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showDirectory.Location = new System.Drawing.Point(19, 78);
            this.showDirectory.Name = "showDirectory";
            this.showDirectory.Size = new System.Drawing.Size(0, 15);
            this.showDirectory.TabIndex = 8;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(402, 334);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Launcher";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.TextBox port_textbox;
        private System.Windows.Forms.TextBox ip_textbox;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SelectDirectoryGTA5;
        private System.Windows.Forms.FolderBrowserDialog SelectDirectory;
        private System.Windows.Forms.Label showDirectory;
    }
}

