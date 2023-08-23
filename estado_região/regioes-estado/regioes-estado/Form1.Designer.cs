namespace regioes_estado
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CboTot = new System.Windows.Forms.ComboBox();
            this.CboNort = new System.Windows.Forms.ComboBox();
            this.CboNord = new System.Windows.Forms.ComboBox();
            this.CboSul = new System.Windows.Forms.ComboBox();
            this.CboSud = new System.Windows.Forms.ComboBox();
            this.CboCent = new System.Windows.Forms.ComboBox();
            this.Btninserir = new System.Windows.Forms.Button();
            this.BtnremovNort = new System.Windows.Forms.Button();
            this.BtnRemoveNord = new System.Windows.Forms.Button();
            this.BtnremoveSul = new System.Windows.Forms.Button();
            this.BtnRemoveSud = new System.Windows.Forms.Button();
            this.BtnRemoveCent = new System.Windows.Forms.Button();
            this.LblTot = new System.Windows.Forms.Label();
            this.LblNort = new System.Windows.Forms.Label();
            this.lblNord = new System.Windows.Forms.Label();
            this.lblsul = new System.Windows.Forms.Label();
            this.lblSud = new System.Windows.Forms.Label();
            this.lblCent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Todos os Estados:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Região Norte:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Região Nordeste:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Região Sul:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Região Sudeste:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Região Centro-Oeste";
            // 
            // CboTot
            // 
            this.CboTot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTot.FormattingEnabled = true;
            this.CboTot.Items.AddRange(new object[] {
            "AC",
            "AP",
            "AM",
            "PA",
            "RO",
            "RR",
            "TC",
            "AL",
            "BA",
            "CE",
            "MA",
            "PB",
            "PE",
            "PI",
            "RN",
            "SE",
            "DF",
            "GO",
            "MT",
            "MS",
            "ES",
            "MG",
            "RJ",
            "SP",
            "PR",
            "RS",
            "SC"});
            this.CboTot.Location = new System.Drawing.Point(172, 42);
            this.CboTot.Name = "CboTot";
            this.CboTot.Size = new System.Drawing.Size(272, 21);
            this.CboTot.TabIndex = 6;
            this.CboTot.SelectedIndexChanged += new System.EventHandler(this.CboTot_SelectedIndexChanged);
            // 
            // CboNort
            // 
            this.CboNort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboNort.FormattingEnabled = true;
            this.CboNort.Location = new System.Drawing.Point(172, 79);
            this.CboNort.Name = "CboNort";
            this.CboNort.Size = new System.Drawing.Size(272, 21);
            this.CboNort.TabIndex = 7;
            // 
            // CboNord
            // 
            this.CboNord.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboNord.FormattingEnabled = true;
            this.CboNord.Location = new System.Drawing.Point(172, 119);
            this.CboNord.Name = "CboNord";
            this.CboNord.Size = new System.Drawing.Size(272, 21);
            this.CboNord.TabIndex = 8;
            // 
            // CboSul
            // 
            this.CboSul.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboSul.FormattingEnabled = true;
            this.CboSul.Location = new System.Drawing.Point(172, 241);
            this.CboSul.Name = "CboSul";
            this.CboSul.Size = new System.Drawing.Size(272, 21);
            this.CboSul.TabIndex = 11;
            // 
            // CboSud
            // 
            this.CboSud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboSud.FormattingEnabled = true;
            this.CboSud.Location = new System.Drawing.Point(172, 201);
            this.CboSud.Name = "CboSud";
            this.CboSud.Size = new System.Drawing.Size(272, 21);
            this.CboSud.TabIndex = 10;
            // 
            // CboCent
            // 
            this.CboCent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCent.FormattingEnabled = true;
            this.CboCent.Location = new System.Drawing.Point(172, 156);
            this.CboCent.Name = "CboCent";
            this.CboCent.Size = new System.Drawing.Size(272, 21);
            this.CboCent.TabIndex = 9;
            // 
            // Btninserir
            // 
            this.Btninserir.Location = new System.Drawing.Point(459, 42);
            this.Btninserir.Name = "Btninserir";
            this.Btninserir.Size = new System.Drawing.Size(67, 20);
            this.Btninserir.TabIndex = 12;
            this.Btninserir.Text = "-";
            this.Btninserir.UseVisualStyleBackColor = true;
            this.Btninserir.Click += new System.EventHandler(this.Btninserir_Click);
            // 
            // BtnremovNort
            // 
            this.BtnremovNort.Location = new System.Drawing.Point(459, 83);
            this.BtnremovNort.Name = "BtnremovNort";
            this.BtnremovNort.Size = new System.Drawing.Size(67, 20);
            this.BtnremovNort.TabIndex = 13;
            this.BtnremovNort.Text = "-";
            this.BtnremovNort.UseVisualStyleBackColor = true;
            this.BtnremovNort.Click += new System.EventHandler(this.BtnremovNort_Click);
            // 
            // BtnRemoveNord
            // 
            this.BtnRemoveNord.Location = new System.Drawing.Point(459, 120);
            this.BtnRemoveNord.Name = "BtnRemoveNord";
            this.BtnRemoveNord.Size = new System.Drawing.Size(67, 20);
            this.BtnRemoveNord.TabIndex = 14;
            this.BtnRemoveNord.Text = "-";
            this.BtnRemoveNord.UseVisualStyleBackColor = true;
            this.BtnRemoveNord.Click += new System.EventHandler(this.BtnRemoveNord_Click);
            // 
            // BtnremoveSul
            // 
            this.BtnremoveSul.Location = new System.Drawing.Point(459, 244);
            this.BtnremoveSul.Name = "BtnremoveSul";
            this.BtnremoveSul.Size = new System.Drawing.Size(67, 20);
            this.BtnremoveSul.TabIndex = 17;
            this.BtnremoveSul.Text = "-";
            this.BtnremoveSul.UseVisualStyleBackColor = true;
            // 
            // BtnRemoveSud
            // 
            this.BtnRemoveSud.Location = new System.Drawing.Point(459, 201);
            this.BtnRemoveSud.Name = "BtnRemoveSud";
            this.BtnRemoveSud.Size = new System.Drawing.Size(67, 20);
            this.BtnRemoveSud.TabIndex = 16;
            this.BtnRemoveSud.Text = "-";
            this.BtnRemoveSud.UseVisualStyleBackColor = true;
            // 
            // BtnRemoveCent
            // 
            this.BtnRemoveCent.Location = new System.Drawing.Point(459, 160);
            this.BtnRemoveCent.Name = "BtnRemoveCent";
            this.BtnRemoveCent.Size = new System.Drawing.Size(67, 20);
            this.BtnRemoveCent.TabIndex = 15;
            this.BtnRemoveCent.Text = "-";
            this.BtnRemoveCent.UseVisualStyleBackColor = true;
            this.BtnRemoveCent.Click += new System.EventHandler(this.BtnRemoveCent_Click);
            // 
            // LblTot
            // 
            this.LblTot.AutoSize = true;
            this.LblTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTot.Location = new System.Drawing.Point(561, 45);
            this.LblTot.Name = "LblTot";
            this.LblTot.Size = new System.Drawing.Size(18, 20);
            this.LblTot.TabIndex = 18;
            this.LblTot.Text = "0";
            // 
            // LblNort
            // 
            this.LblNort.AutoSize = true;
            this.LblNort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNort.Location = new System.Drawing.Point(561, 83);
            this.LblNort.Name = "LblNort";
            this.LblNort.Size = new System.Drawing.Size(18, 20);
            this.LblNort.TabIndex = 19;
            this.LblNort.Text = "0";
            // 
            // lblNord
            // 
            this.lblNord.AutoSize = true;
            this.lblNord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNord.Location = new System.Drawing.Point(561, 122);
            this.lblNord.Name = "lblNord";
            this.lblNord.Size = new System.Drawing.Size(18, 20);
            this.lblNord.TabIndex = 20;
            this.lblNord.Text = "0";
            // 
            // lblsul
            // 
            this.lblsul.AutoSize = true;
            this.lblsul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsul.Location = new System.Drawing.Point(561, 237);
            this.lblsul.Name = "lblsul";
            this.lblsul.Size = new System.Drawing.Size(18, 20);
            this.lblsul.TabIndex = 23;
            this.lblsul.Text = "0";
            // 
            // lblSud
            // 
            this.lblSud.AutoSize = true;
            this.lblSud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSud.Location = new System.Drawing.Point(561, 199);
            this.lblSud.Name = "lblSud";
            this.lblSud.Size = new System.Drawing.Size(18, 20);
            this.lblSud.TabIndex = 22;
            this.lblSud.Text = "0";
            // 
            // lblCent
            // 
            this.lblCent.AutoSize = true;
            this.lblCent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCent.Location = new System.Drawing.Point(561, 159);
            this.lblCent.Name = "lblCent";
            this.lblCent.Size = new System.Drawing.Size(18, 20);
            this.lblCent.TabIndex = 21;
            this.lblCent.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 450);
            this.Controls.Add(this.lblsul);
            this.Controls.Add(this.lblSud);
            this.Controls.Add(this.lblCent);
            this.Controls.Add(this.lblNord);
            this.Controls.Add(this.LblNort);
            this.Controls.Add(this.LblTot);
            this.Controls.Add(this.BtnremoveSul);
            this.Controls.Add(this.BtnRemoveSud);
            this.Controls.Add(this.BtnRemoveCent);
            this.Controls.Add(this.BtnRemoveNord);
            this.Controls.Add(this.BtnremovNort);
            this.Controls.Add(this.Btninserir);
            this.Controls.Add(this.CboSul);
            this.Controls.Add(this.CboSud);
            this.Controls.Add(this.CboCent);
            this.Controls.Add(this.CboNord);
            this.Controls.Add(this.CboNort);
            this.Controls.Add(this.CboTot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Estados X Regiões";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CboTot;
        private System.Windows.Forms.ComboBox CboNort;
        private System.Windows.Forms.ComboBox CboNord;
        private System.Windows.Forms.ComboBox CboSul;
        private System.Windows.Forms.ComboBox CboSud;
        private System.Windows.Forms.ComboBox CboCent;
        private System.Windows.Forms.Button Btninserir;
        private System.Windows.Forms.Button BtnremovNort;
        private System.Windows.Forms.Button BtnRemoveNord;
        private System.Windows.Forms.Button BtnremoveSul;
        private System.Windows.Forms.Button BtnRemoveSud;
        private System.Windows.Forms.Button BtnRemoveCent;
        private System.Windows.Forms.Label LblTot;
        private System.Windows.Forms.Label LblNort;
        private System.Windows.Forms.Label lblNord;
        private System.Windows.Forms.Label lblsul;
        private System.Windows.Forms.Label lblSud;
        private System.Windows.Forms.Label lblCent;
    }
}

