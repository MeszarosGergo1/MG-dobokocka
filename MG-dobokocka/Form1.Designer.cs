namespace MG_dobokocka
{
    partial class Főablak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Főablak));
            this.label1 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.aladardobasai = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.aladarnyero2 = new System.Windows.Forms.Label();
            this.aladarhatosdobas2 = new System.Windows.Forms.Label();
            this.aladargyozelmekszama2 = new System.Windows.Forms.Label();
            this.aladardobasai2 = new System.Windows.Forms.Label();
            this.aladarnyero = new System.Windows.Forms.Label();
            this.aladarhatosdobas = new System.Windows.Forms.Label();
            this.aladargyozelmekszama = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bendeguzdobasai2 = new System.Windows.Forms.Label();
            this.kigyozott = new System.Windows.Forms.Label();
            this.bendeguznyeroszeria2 = new System.Windows.Forms.Label();
            this.bendeguzhatosdobas2 = new System.Windows.Forms.Label();
            this.bendeguzgyozelmekszama2 = new System.Windows.Forms.Label();
            this.bendeguznyeroszeria = new System.Windows.Forms.Label();
            this.bendeguzhatosdobas = new System.Windows.Forms.Label();
            this.bendeguzgyozelmekszama = new System.Windows.Forms.Label();
            this.bendegyozelmekszama = new System.Windows.Forms.Label();
            this.szamitas = new System.Windows.Forms.Button();
            this.kilepes = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(2, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dobókocka Verseny";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // aladardobasai
            // 
            this.aladardobasai.AutoSize = true;
            this.aladardobasai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aladardobasai.Location = new System.Drawing.Point(6, 16);
            this.aladardobasai.Name = "aladardobasai";
            this.aladardobasai.Size = new System.Drawing.Size(134, 20);
            this.aladardobasai.TabIndex = 1;
            this.aladardobasai.Text = "Aladár dobásai:";
            this.aladardobasai.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.aladarnyero2);
            this.groupBox1.Controls.Add(this.aladarhatosdobas2);
            this.groupBox1.Controls.Add(this.aladargyozelmekszama2);
            this.groupBox1.Controls.Add(this.aladardobasai2);
            this.groupBox1.Controls.Add(this.aladarnyero);
            this.groupBox1.Controls.Add(this.aladarhatosdobas);
            this.groupBox1.Controls.Add(this.aladargyozelmekszama);
            this.groupBox1.Controls.Add(this.aladardobasai);
            this.groupBox1.Location = new System.Drawing.Point(6, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 130);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // aladarnyero2
            // 
            this.aladarnyero2.AutoSize = true;
            this.aladarnyero2.Location = new System.Drawing.Point(175, 102);
            this.aladarnyero2.Name = "aladarnyero2";
            this.aladarnyero2.Size = new System.Drawing.Size(0, 13);
            this.aladarnyero2.TabIndex = 8;
            // 
            // aladarhatosdobas2
            // 
            this.aladarhatosdobas2.AutoSize = true;
            this.aladarhatosdobas2.Location = new System.Drawing.Point(175, 75);
            this.aladarhatosdobas2.Name = "aladarhatosdobas2";
            this.aladarhatosdobas2.Size = new System.Drawing.Size(0, 13);
            this.aladarhatosdobas2.TabIndex = 7;
            // 
            // aladargyozelmekszama2
            // 
            this.aladargyozelmekszama2.AutoSize = true;
            this.aladargyozelmekszama2.Location = new System.Drawing.Point(175, 47);
            this.aladargyozelmekszama2.Name = "aladargyozelmekszama2";
            this.aladargyozelmekszama2.Size = new System.Drawing.Size(0, 13);
            this.aladargyozelmekszama2.TabIndex = 6;
            // 
            // aladardobasai2
            // 
            this.aladardobasai2.AutoSize = true;
            this.aladardobasai2.Location = new System.Drawing.Point(145, 21);
            this.aladardobasai2.Name = "aladardobasai2";
            this.aladardobasai2.Size = new System.Drawing.Size(0, 13);
            this.aladardobasai2.TabIndex = 5;
            // 
            // aladarnyero
            // 
            this.aladarnyero.AutoSize = true;
            this.aladarnyero.Location = new System.Drawing.Point(93, 102);
            this.aladarnyero.Name = "aladarnyero";
            this.aladarnyero.Size = new System.Drawing.Size(74, 13);
            this.aladarnyero.TabIndex = 4;
            this.aladarnyero.Text = "nyerő szériája:";
            this.aladarnyero.Click += new System.EventHandler(this.label6_Click);
            // 
            // aladarhatosdobas
            // 
            this.aladarhatosdobas.AutoSize = true;
            this.aladarhatosdobas.Location = new System.Drawing.Point(46, 75);
            this.aladarhatosdobas.Name = "aladarhatosdobas";
            this.aladarhatosdobas.Size = new System.Drawing.Size(121, 13);
            this.aladarhatosdobas.TabIndex = 3;
            this.aladarhatosdobas.Text = "6-os dobásainak száma:";
            this.aladarhatosdobas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // aladargyozelmekszama
            // 
            this.aladargyozelmekszama.AutoSize = true;
            this.aladargyozelmekszama.Location = new System.Drawing.Point(74, 47);
            this.aladargyozelmekszama.Name = "aladargyozelmekszama";
            this.aladargyozelmekszama.Size = new System.Drawing.Size(93, 13);
            this.aladargyozelmekszama.TabIndex = 2;
            this.aladargyozelmekszama.Text = "győzelmek száma:";
            this.aladargyozelmekszama.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(30, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(758, 340);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MG_dobokocka.Properties.Resources.dobokocka1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(523, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bendeguzdobasai2);
            this.groupBox3.Controls.Add(this.kigyozott);
            this.groupBox3.Controls.Add(this.bendeguznyeroszeria2);
            this.groupBox3.Controls.Add(this.bendeguzhatosdobas2);
            this.groupBox3.Controls.Add(this.bendeguzgyozelmekszama2);
            this.groupBox3.Controls.Add(this.bendeguznyeroszeria);
            this.groupBox3.Controls.Add(this.bendeguzhatosdobas);
            this.groupBox3.Controls.Add(this.bendeguzgyozelmekszama);
            this.groupBox3.Controls.Add(this.bendegyozelmekszama);
            this.groupBox3.Location = new System.Drawing.Point(6, 193);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(511, 130);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // bendeguzdobasai2
            // 
            this.bendeguzdobasai2.AutoSize = true;
            this.bendeguzdobasai2.Location = new System.Drawing.Point(175, 21);
            this.bendeguzdobasai2.Name = "bendeguzdobasai2";
            this.bendeguzdobasai2.Size = new System.Drawing.Size(0, 13);
            this.bendeguzdobasai2.TabIndex = 13;
            // 
            // kigyozott
            // 
            this.kigyozott.AutoSize = true;
            this.kigyozott.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kigyozott.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kigyozott.Location = new System.Drawing.Point(288, 102);
            this.kigyozott.Name = "kigyozott";
            this.kigyozott.Size = new System.Drawing.Size(87, 13);
            this.kigyozott.TabIndex = 12;
            this.kigyozott.Text = "Valaki győzött";
            this.kigyozott.Click += new System.EventHandler(this.kigyozott_Click);
            // 
            // bendeguznyeroszeria2
            // 
            this.bendeguznyeroszeria2.AutoSize = true;
            this.bendeguznyeroszeria2.Location = new System.Drawing.Point(192, 102);
            this.bendeguznyeroszeria2.Name = "bendeguznyeroszeria2";
            this.bendeguznyeroszeria2.Size = new System.Drawing.Size(0, 13);
            this.bendeguznyeroszeria2.TabIndex = 11;
            // 
            // bendeguzhatosdobas2
            // 
            this.bendeguzhatosdobas2.AutoSize = true;
            this.bendeguzhatosdobas2.Location = new System.Drawing.Point(192, 75);
            this.bendeguzhatosdobas2.Name = "bendeguzhatosdobas2";
            this.bendeguzhatosdobas2.Size = new System.Drawing.Size(0, 13);
            this.bendeguzhatosdobas2.TabIndex = 10;
            // 
            // bendeguzgyozelmekszama2
            // 
            this.bendeguzgyozelmekszama2.AutoSize = true;
            this.bendeguzgyozelmekszama2.Location = new System.Drawing.Point(192, 49);
            this.bendeguzgyozelmekszama2.Name = "bendeguzgyozelmekszama2";
            this.bendeguzgyozelmekszama2.Size = new System.Drawing.Size(0, 13);
            this.bendeguzgyozelmekszama2.TabIndex = 9;
            // 
            // bendeguznyeroszeria
            // 
            this.bendeguznyeroszeria.AutoSize = true;
            this.bendeguznyeroszeria.Location = new System.Drawing.Point(112, 102);
            this.bendeguznyeroszeria.Name = "bendeguznyeroszeria";
            this.bendeguznyeroszeria.Size = new System.Drawing.Size(74, 13);
            this.bendeguznyeroszeria.TabIndex = 4;
            this.bendeguznyeroszeria.Text = "nyerő szériája:";
            // 
            // bendeguzhatosdobas
            // 
            this.bendeguzhatosdobas.AutoSize = true;
            this.bendeguzhatosdobas.Location = new System.Drawing.Point(66, 75);
            this.bendeguzhatosdobas.Name = "bendeguzhatosdobas";
            this.bendeguzhatosdobas.Size = new System.Drawing.Size(121, 13);
            this.bendeguzhatosdobas.TabIndex = 3;
            this.bendeguzhatosdobas.Text = "6-os dobásainak száma:";
            this.bendeguzhatosdobas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bendeguzgyozelmekszama
            // 
            this.bendeguzgyozelmekszama.AutoSize = true;
            this.bendeguzgyozelmekszama.Location = new System.Drawing.Point(93, 49);
            this.bendeguzgyozelmekszama.Name = "bendeguzgyozelmekszama";
            this.bendeguzgyozelmekszama.Size = new System.Drawing.Size(93, 13);
            this.bendeguzgyozelmekszama.TabIndex = 2;
            this.bendeguzgyozelmekszama.Text = "győzelmek száma:";
            this.bendeguzgyozelmekszama.Click += new System.EventHandler(this.label8_Click);
            // 
            // bendegyozelmekszama
            // 
            this.bendegyozelmekszama.AutoSize = true;
            this.bendegyozelmekszama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bendegyozelmekszama.Location = new System.Drawing.Point(6, 16);
            this.bendegyozelmekszama.Name = "bendegyozelmekszama";
            this.bendegyozelmekszama.Size = new System.Drawing.Size(163, 20);
            this.bendegyozelmekszama.TabIndex = 1;
            this.bendegyozelmekszama.Text = "Bendegúz dobásai:";
            this.bendegyozelmekszama.Click += new System.EventHandler(this.bendegyozelmekszama_Click);
            // 
            // szamitas
            // 
            this.szamitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.szamitas.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.szamitas.FlatAppearance.BorderSize = 2;
            this.szamitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.szamitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szamitas.ForeColor = System.Drawing.Color.Blue;
            this.szamitas.Location = new System.Drawing.Point(30, 412);
            this.szamitas.Name = "szamitas";
            this.szamitas.Size = new System.Drawing.Size(181, 32);
            this.szamitas.TabIndex = 5;
            this.szamitas.Text = "SZÁMÍTÁS";
            this.szamitas.UseVisualStyleBackColor = false;
            this.szamitas.Click += new System.EventHandler(this.szamitas_Click);
            // 
            // kilepes
            // 
            this.kilepes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kilepes.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.kilepes.FlatAppearance.BorderSize = 2;
            this.kilepes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kilepes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kilepes.ForeColor = System.Drawing.Color.Red;
            this.kilepes.Location = new System.Drawing.Point(607, 412);
            this.kilepes.Name = "kilepes";
            this.kilepes.Size = new System.Drawing.Size(181, 32);
            this.kilepes.TabIndex = 6;
            this.kilepes.Text = "KILÉPÉS";
            this.kilepes.UseVisualStyleBackColor = false;
            this.kilepes.Click += new System.EventHandler(this.kilepes_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Főablak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kilepes);
            this.Controls.Add(this.szamitas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Name = "Főablak";
            this.Text = "Főablak";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label aladardobasai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label aladarnyero;
        private System.Windows.Forms.Label aladarhatosdobas;
        private System.Windows.Forms.Label aladargyozelmekszama;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label bendeguznyeroszeria;
        private System.Windows.Forms.Label bendeguzhatosdobas;
        private System.Windows.Forms.Label bendeguzgyozelmekszama;
        private System.Windows.Forms.Label bendegyozelmekszama;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label bendeguznyeroszeria2;
        private System.Windows.Forms.Label bendeguzhatosdobas2;
        private System.Windows.Forms.Label bendeguzgyozelmekszama2;
        private System.Windows.Forms.Label aladarnyero2;
        private System.Windows.Forms.Label aladarhatosdobas2;
        private System.Windows.Forms.Label aladargyozelmekszama2;
        private System.Windows.Forms.Label aladardobasai2;
        private System.Windows.Forms.Label kigyozott;
        private System.Windows.Forms.Button kilepes;
        private System.Windows.Forms.Button szamitas;
        private System.Windows.Forms.Label bendeguzdobasai2;
        private System.Windows.Forms.Timer timer1;
    }
}

