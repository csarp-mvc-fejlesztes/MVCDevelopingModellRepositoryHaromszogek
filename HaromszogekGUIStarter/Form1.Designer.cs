namespace HaromszogekGUI
{
    partial class Form1
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
            this.buttonBeolvas = new System.Windows.Forms.Button();
            this.groupBoxHaromszogAdatok = new System.Windows.Forms.GroupBox();
            this.buttonTorol = new System.Windows.Forms.Button();
            this.buttonModosit = new System.Windows.Forms.Button();
            this.buttonUjOldal = new System.Windows.Forms.Button();
            this.textBoxCOldal = new System.Windows.Forms.TextBox();
            this.textBoxBOldal = new System.Windows.Forms.TextBox();
            this.textBoxAOldal = new System.Windows.Forms.TextBox();
            this.labelC = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.buttonSzamol = new System.Windows.Forms.Button();
            this.labelOsszKerulet = new System.Windows.Forms.Label();
            this.labelSzerkeszthetokOsszkerulete = new System.Windows.Forms.Label();
            this.textBoxOsszkerulet = new System.Windows.Forms.TextBox();
            this.textBoxSzerkeszthetokOsszkerulete = new System.Windows.Forms.TextBox();
            this.buttonMentSzerkeszthetok = new System.Windows.Forms.Button();
            this.listBoxHaromszogek = new System.Windows.Forms.ListBox();
            this.errorProviderA = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderB = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderC = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxHaromszogAdatok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderC)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBeolvas
            // 
            this.buttonBeolvas.Location = new System.Drawing.Point(13, 13);
            this.buttonBeolvas.Name = "buttonBeolvas";
            this.buttonBeolvas.Size = new System.Drawing.Size(285, 23);
            this.buttonBeolvas.TabIndex = 0;
            this.buttonBeolvas.Text = "Beolvas tárolt adatokat fájlból";
            this.buttonBeolvas.UseVisualStyleBackColor = true;
            this.buttonBeolvas.Click += new System.EventHandler(this.buttonBeolvas_Click);
            // 
            // groupBoxHaromszogAdatok
            // 
            this.groupBoxHaromszogAdatok.Controls.Add(this.buttonTorol);
            this.groupBoxHaromszogAdatok.Controls.Add(this.buttonModosit);
            this.groupBoxHaromszogAdatok.Controls.Add(this.buttonUjOldal);
            this.groupBoxHaromszogAdatok.Controls.Add(this.textBoxCOldal);
            this.groupBoxHaromszogAdatok.Controls.Add(this.textBoxBOldal);
            this.groupBoxHaromszogAdatok.Controls.Add(this.textBoxAOldal);
            this.groupBoxHaromszogAdatok.Controls.Add(this.labelC);
            this.groupBoxHaromszogAdatok.Controls.Add(this.labelB);
            this.groupBoxHaromszogAdatok.Controls.Add(this.labelA);
            this.groupBoxHaromszogAdatok.Location = new System.Drawing.Point(13, 62);
            this.groupBoxHaromszogAdatok.Name = "groupBoxHaromszogAdatok";
            this.groupBoxHaromszogAdatok.Size = new System.Drawing.Size(285, 164);
            this.groupBoxHaromszogAdatok.TabIndex = 1;
            this.groupBoxHaromszogAdatok.TabStop = false;
            this.groupBoxHaromszogAdatok.Text = "Háromszög adatok";
            // 
            // buttonTorol
            // 
            this.buttonTorol.Location = new System.Drawing.Point(204, 135);
            this.buttonTorol.Name = "buttonTorol";
            this.buttonTorol.Size = new System.Drawing.Size(75, 23);
            this.buttonTorol.TabIndex = 8;
            this.buttonTorol.Text = "Töröl";
            this.buttonTorol.UseVisualStyleBackColor = true;
            // 
            // buttonModosit
            // 
            this.buttonModosit.Location = new System.Drawing.Point(106, 135);
            this.buttonModosit.Name = "buttonModosit";
            this.buttonModosit.Size = new System.Drawing.Size(75, 23);
            this.buttonModosit.TabIndex = 7;
            this.buttonModosit.Text = "Módosít";
            this.buttonModosit.UseVisualStyleBackColor = true;
            // 
            // buttonUjOldal
            // 
            this.buttonUjOldal.Location = new System.Drawing.Point(10, 135);
            this.buttonUjOldal.Name = "buttonUjOldal";
            this.buttonUjOldal.Size = new System.Drawing.Size(75, 23);
            this.buttonUjOldal.TabIndex = 6;
            this.buttonUjOldal.Text = "Új oldal";
            this.buttonUjOldal.UseVisualStyleBackColor = true;
            // 
            // textBoxCOldal
            // 
            this.textBoxCOldal.Location = new System.Drawing.Point(65, 82);
            this.textBoxCOldal.Name = "textBoxCOldal";
            this.textBoxCOldal.Size = new System.Drawing.Size(100, 20);
            this.textBoxCOldal.TabIndex = 5;
            // 
            // textBoxBOldal
            // 
            this.textBoxBOldal.Location = new System.Drawing.Point(65, 51);
            this.textBoxBOldal.Name = "textBoxBOldal";
            this.textBoxBOldal.Size = new System.Drawing.Size(100, 20);
            this.textBoxBOldal.TabIndex = 4;
            // 
            // textBoxAOldal
            // 
            this.textBoxAOldal.Location = new System.Drawing.Point(65, 20);
            this.textBoxAOldal.Name = "textBoxAOldal";
            this.textBoxAOldal.Size = new System.Drawing.Size(100, 20);
            this.textBoxAOldal.TabIndex = 3;
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(7, 85);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(42, 13);
            this.labelC.TabIndex = 2;
            this.labelC.Text = "C oldal:";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(7, 54);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(42, 13);
            this.labelB.TabIndex = 1;
            this.labelB.Text = "B oldal:";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(7, 20);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(42, 13);
            this.labelA.TabIndex = 0;
            this.labelA.Text = "A oldal:";
            // 
            // buttonSzamol
            // 
            this.buttonSzamol.Location = new System.Drawing.Point(13, 248);
            this.buttonSzamol.Name = "buttonSzamol";
            this.buttonSzamol.Size = new System.Drawing.Size(75, 23);
            this.buttonSzamol.TabIndex = 9;
            this.buttonSzamol.Text = "Számol";
            this.buttonSzamol.UseVisualStyleBackColor = true;
            // 
            // labelOsszKerulet
            // 
            this.labelOsszKerulet.AutoSize = true;
            this.labelOsszKerulet.Location = new System.Drawing.Point(26, 278);
            this.labelOsszKerulet.Name = "labelOsszKerulet";
            this.labelOsszKerulet.Size = new System.Drawing.Size(65, 13);
            this.labelOsszKerulet.TabIndex = 10;
            this.labelOsszKerulet.Text = "Összkerület:";
            // 
            // labelSzerkeszthetokOsszkerulete
            // 
            this.labelSzerkeszthetokOsszkerulete.AutoSize = true;
            this.labelSzerkeszthetokOsszkerulete.Location = new System.Drawing.Point(26, 303);
            this.labelSzerkeszthetokOsszkerulete.Name = "labelSzerkeszthetokOsszkerulete";
            this.labelSzerkeszthetokOsszkerulete.Size = new System.Drawing.Size(145, 13);
            this.labelSzerkeszthetokOsszkerulete.TabIndex = 11;
            this.labelSzerkeszthetokOsszkerulete.Text = "Szerkeszthetők összkerülete:";
            // 
            // textBoxOsszkerulet
            // 
            this.textBoxOsszkerulet.Location = new System.Drawing.Point(174, 271);
            this.textBoxOsszkerulet.Name = "textBoxOsszkerulet";
            this.textBoxOsszkerulet.ReadOnly = true;
            this.textBoxOsszkerulet.Size = new System.Drawing.Size(118, 20);
            this.textBoxOsszkerulet.TabIndex = 12;
            // 
            // textBoxSzerkeszthetokOsszkerulete
            // 
            this.textBoxSzerkeszthetokOsszkerulete.Location = new System.Drawing.Point(174, 296);
            this.textBoxSzerkeszthetokOsszkerulete.Name = "textBoxSzerkeszthetokOsszkerulete";
            this.textBoxSzerkeszthetokOsszkerulete.ReadOnly = true;
            this.textBoxSzerkeszthetokOsszkerulete.Size = new System.Drawing.Size(118, 20);
            this.textBoxSzerkeszthetokOsszkerulete.TabIndex = 13;
            // 
            // buttonMentSzerkeszthetok
            // 
            this.buttonMentSzerkeszthetok.Location = new System.Drawing.Point(13, 356);
            this.buttonMentSzerkeszthetok.Name = "buttonMentSzerkeszthetok";
            this.buttonMentSzerkeszthetok.Size = new System.Drawing.Size(285, 23);
            this.buttonMentSzerkeszthetok.TabIndex = 14;
            this.buttonMentSzerkeszthetok.Text = "Ment szerkeszthető háromszögeket fájlba";
            this.buttonMentSzerkeszthetok.UseVisualStyleBackColor = true;
            // 
            // listBoxHaromszogek
            // 
            this.listBoxHaromszogek.FormattingEnabled = true;
            this.listBoxHaromszogek.Location = new System.Drawing.Point(367, 13);
            this.listBoxHaromszogek.Name = "listBoxHaromszogek";
            this.listBoxHaromszogek.Size = new System.Drawing.Size(296, 368);
            this.listBoxHaromszogek.TabIndex = 15;
            // 
            // errorProviderA
            // 
            this.errorProviderA.ContainerControl = this;
            // 
            // errorProviderB
            // 
            this.errorProviderB.ContainerControl = this;
            // 
            // errorProviderC
            // 
            this.errorProviderC.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxHaromszogek);
            this.Controls.Add(this.buttonMentSzerkeszthetok);
            this.Controls.Add(this.textBoxSzerkeszthetokOsszkerulete);
            this.Controls.Add(this.textBoxOsszkerulet);
            this.Controls.Add(this.labelSzerkeszthetokOsszkerulete);
            this.Controls.Add(this.labelOsszKerulet);
            this.Controls.Add(this.buttonSzamol);
            this.Controls.Add(this.groupBoxHaromszogAdatok);
            this.Controls.Add(this.buttonBeolvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxHaromszogAdatok.ResumeLayout(false);
            this.groupBoxHaromszogAdatok.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBeolvas;
        private System.Windows.Forms.GroupBox groupBoxHaromszogAdatok;
        private System.Windows.Forms.Button buttonTorol;
        private System.Windows.Forms.Button buttonModosit;
        private System.Windows.Forms.Button buttonUjOldal;
        private System.Windows.Forms.TextBox textBoxCOldal;
        private System.Windows.Forms.TextBox textBoxBOldal;
        private System.Windows.Forms.TextBox textBoxAOldal;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Button buttonSzamol;
        private System.Windows.Forms.Label labelOsszKerulet;
        private System.Windows.Forms.Label labelSzerkeszthetokOsszkerulete;
        private System.Windows.Forms.TextBox textBoxOsszkerulet;
        private System.Windows.Forms.TextBox textBoxSzerkeszthetokOsszkerulete;
        private System.Windows.Forms.Button buttonMentSzerkeszthetok;
        private System.Windows.Forms.ListBox listBoxHaromszogek;
        private System.Windows.Forms.ErrorProvider errorProviderA;
        private System.Windows.Forms.ErrorProvider errorProviderB;
        private System.Windows.Forms.ErrorProvider errorProviderC;
    }
}

