namespace Valutavalto_from_20241119
{
    partial class Form
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
            this.dgadatok = new System.Windows.Forms.DataGridView();
            this.nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arfolyam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devosszeg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txnev = new System.Windows.Forms.TextBox();
            this.txatvaltoossz = new System.Windows.Forms.TextBox();
            this.txarfolyam = new System.Windows.Forms.TextBox();
            this.cbdevizakod = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbletszam = new System.Windows.Forms.Label();
            this.lbftosszeg = new System.Windows.Forms.Label();
            this.lbdevizaosszeg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgadatok)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgadatok
            // 
            this.dgadatok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgadatok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nev,
            this.ft,
            this.devkod,
            this.arfolyam,
            this.devosszeg});
            this.dgadatok.Location = new System.Drawing.Point(14, 12);
            this.dgadatok.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgadatok.Name = "dgadatok";
            this.dgadatok.Size = new System.Drawing.Size(623, 413);
            this.dgadatok.TabIndex = 0;
            // 
            // nev
            // 
            this.nev.HeaderText = "Név";
            this.nev.Name = "nev";
            this.nev.ReadOnly = true;
            this.nev.Width = 200;
            // 
            // ft
            // 
            this.ft.HeaderText = "Forint összeg";
            this.ft.Name = "ft";
            this.ft.ReadOnly = true;
            this.ft.Width = 80;
            // 
            // devkod
            // 
            this.devkod.HeaderText = "Devizakód";
            this.devkod.Name = "devkod";
            this.devkod.ReadOnly = true;
            this.devkod.Width = 90;
            // 
            // arfolyam
            // 
            this.arfolyam.HeaderText = "Árfolyam";
            this.arfolyam.Name = "arfolyam";
            this.arfolyam.ReadOnly = true;
            this.arfolyam.Width = 90;
            // 
            // devosszeg
            // 
            this.devosszeg.HeaderText = "Deviza összeg";
            this.devosszeg.Name = "devosszeg";
            this.devosszeg.ReadOnly = true;
            this.devosszeg.Width = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(656, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(656, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Átváltandó összeg [Ft]:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(656, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Devizakód:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(656, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Deviza összeg: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(656, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Árfolyam:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(719, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 57);
            this.button1.TabIndex = 6;
            this.button1.Text = "Mentés";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txnev
            // 
            this.txnev.Location = new System.Drawing.Point(696, 12);
            this.txnev.Name = "txnev";
            this.txnev.Size = new System.Drawing.Size(212, 20);
            this.txnev.TabIndex = 7;
            // 
            // txatvaltoossz
            // 
            this.txatvaltoossz.Location = new System.Drawing.Point(800, 55);
            this.txatvaltoossz.Name = "txatvaltoossz";
            this.txatvaltoossz.Size = new System.Drawing.Size(108, 20);
            this.txatvaltoossz.TabIndex = 8;
            this.txatvaltoossz.TextChanged += new System.EventHandler(this.txatvaltoossz_TextChanged);
            // 
            // txarfolyam
            // 
            this.txarfolyam.Location = new System.Drawing.Point(721, 143);
            this.txarfolyam.Name = "txarfolyam";
            this.txarfolyam.Size = new System.Drawing.Size(108, 20);
            this.txarfolyam.TabIndex = 9;
            this.txarfolyam.TextChanged += new System.EventHandler(this.txarfolyam_TextChanged);
            // 
            // cbdevizakod
            // 
            this.cbdevizakod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdevizakod.FormattingEnabled = true;
            this.cbdevizakod.Items.AddRange(new object[] {
            "CZK",
            "EUR",
            "USD"});
            this.cbdevizakod.Location = new System.Drawing.Point(733, 99);
            this.cbdevizakod.Name = "cbdevizakod";
            this.cbdevizakod.Size = new System.Drawing.Size(96, 21);
            this.cbdevizakod.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbdevizaosszeg);
            this.groupBox1.Controls.Add(this.lbftosszeg);
            this.groupBox1.Controls.Add(this.lbletszam);
            this.groupBox1.Location = new System.Drawing.Point(659, 318);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 107);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statisztika - USD váltók";
            // 
            // lbletszam
            // 
            this.lbletszam.AutoSize = true;
            this.lbletszam.Location = new System.Drawing.Point(15, 26);
            this.lbletszam.Name = "lbletszam";
            this.lbletszam.Size = new System.Drawing.Size(61, 13);
            this.lbletszam.TabIndex = 0;
            this.lbletszam.Text = "Létszám: ";
            // 
            // lbftosszeg
            // 
            this.lbftosszeg.AutoSize = true;
            this.lbftosszeg.Location = new System.Drawing.Point(15, 55);
            this.lbftosszeg.Name = "lbftosszeg";
            this.lbftosszeg.Size = new System.Drawing.Size(90, 13);
            this.lbftosszeg.TabIndex = 1;
            this.lbftosszeg.Text = "Forint összeg: ";
            // 
            // lbdevizaosszeg
            // 
            this.lbdevizaosszeg.AutoSize = true;
            this.lbdevizaosszeg.Location = new System.Drawing.Point(15, 84);
            this.lbdevizaosszeg.Name = "lbdevizaosszeg";
            this.lbdevizaosszeg.Size = new System.Drawing.Size(97, 13);
            this.lbdevizaosszeg.TabIndex = 2;
            this.lbdevizaosszeg.Text = "Deviza összeg: ";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbdevizakod);
            this.Controls.Add(this.txarfolyam);
            this.Controls.Add(this.txatvaltoossz);
            this.Controls.Add(this.txnev);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgadatok);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Valuta váltó";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgadatok)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgadatok;
        private System.Windows.Forms.DataGridViewTextBoxColumn nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn ft;
        private System.Windows.Forms.DataGridViewTextBoxColumn devkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn arfolyam;
        private System.Windows.Forms.DataGridViewTextBoxColumn devosszeg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txnev;
        private System.Windows.Forms.TextBox txatvaltoossz;
        private System.Windows.Forms.TextBox txarfolyam;
        private System.Windows.Forms.ComboBox cbdevizakod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbdevizaosszeg;
        private System.Windows.Forms.Label lbftosszeg;
        private System.Windows.Forms.Label lbletszam;
    }
}

