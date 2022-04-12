
namespace Pars2012GUI
{
    partial class FrmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbVersenyzo = new System.Windows.Forms.ComboBox();
            this.lblCsoport = new System.Windows.Forms.Label();
            this.pbZaszlo = new System.Windows.Forms.PictureBox();
            this.lblNemzet = new System.Windows.Forms.Label();
            this.lblNemzetKod = new System.Windows.Forms.Label();
            this.lblSorozat = new System.Windows.Forms.Label();
            this.lblEredmeny = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbZaszlo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbZaszlo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblEredmeny);
            this.groupBox1.Controls.Add(this.lblSorozat);
            this.groupBox1.Controls.Add(this.lblNemzetKod);
            this.groupBox1.Controls.Add(this.lblNemzet);
            this.groupBox1.Controls.Add(this.lblCsoport);
            this.groupBox1.Controls.Add(this.cbVersenyzo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(46, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(436, 564);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Válasszon versenyzőt!";
            // 
            // cbVersenyzo
            // 
            this.cbVersenyzo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVersenyzo.FormattingEnabled = true;
            this.cbVersenyzo.Location = new System.Drawing.Point(30, 46);
            this.cbVersenyzo.Name = "cbVersenyzo";
            this.cbVersenyzo.Size = new System.Drawing.Size(374, 28);
            this.cbVersenyzo.TabIndex = 0;
            this.cbVersenyzo.SelectedIndexChanged += new System.EventHandler(this.cbVersenyzo_SelectedIndexChanged);
            // 
            // lblCsoport
            // 
            this.lblCsoport.AutoSize = true;
            this.lblCsoport.Location = new System.Drawing.Point(30, 105);
            this.lblCsoport.Name = "lblCsoport";
            this.lblCsoport.Size = new System.Drawing.Size(140, 20);
            this.lblCsoport.TabIndex = 1;
            this.lblCsoport.Text = "###CSOPORT###";
            // 
            // pbZaszlo
            // 
            this.pbZaszlo.Location = new System.Drawing.Point(34, 388);
            this.pbZaszlo.Name = "pbZaszlo";
            this.pbZaszlo.Size = new System.Drawing.Size(345, 145);
            this.pbZaszlo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbZaszlo.TabIndex = 2;
            this.pbZaszlo.TabStop = false;
            // 
            // lblNemzet
            // 
            this.lblNemzet.AutoSize = true;
            this.lblNemzet.Location = new System.Drawing.Point(30, 152);
            this.lblNemzet.Name = "lblNemzet";
            this.lblNemzet.Size = new System.Drawing.Size(128, 20);
            this.lblNemzet.TabIndex = 1;
            this.lblNemzet.Text = "###NEMZET###";
            // 
            // lblNemzetKod
            // 
            this.lblNemzetKod.AutoSize = true;
            this.lblNemzetKod.Location = new System.Drawing.Point(30, 198);
            this.lblNemzetKod.Name = "lblNemzetKod";
            this.lblNemzetKod.Size = new System.Drawing.Size(171, 20);
            this.lblNemzetKod.TabIndex = 1;
            this.lblNemzetKod.Text = "###NEMZET_KOD###";
            // 
            // lblSorozat
            // 
            this.lblSorozat.AutoSize = true;
            this.lblSorozat.Location = new System.Drawing.Point(30, 245);
            this.lblSorozat.Name = "lblSorozat";
            this.lblSorozat.Size = new System.Drawing.Size(140, 20);
            this.lblSorozat.TabIndex = 1;
            this.lblSorozat.Text = "###SOROZAT###";
            // 
            // lblEredmeny
            // 
            this.lblEredmeny.AutoSize = true;
            this.lblEredmeny.Location = new System.Drawing.Point(30, 292);
            this.lblEredmeny.Name = "lblEredmeny";
            this.lblEredmeny.Size = new System.Drawing.Size(155, 20);
            this.lblEredmeny.TabIndex = 1;
            this.lblEredmeny.Text = "###EREDMENY###";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Zászló:";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 626);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.Text = "London 2012 - Férfi kalapácsvetés - Selejtező";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbZaszlo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbZaszlo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblEredmeny;
        private System.Windows.Forms.Label lblSorozat;
        private System.Windows.Forms.Label lblNemzetKod;
        private System.Windows.Forms.Label lblNemzet;
        private System.Windows.Forms.Label lblCsoport;
        private System.Windows.Forms.ComboBox cbVersenyzo;
    }
}

