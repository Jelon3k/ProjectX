namespace ProjectX
{
    partial class UserSettings
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSettings));
            this.ladownoscTx = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.rabatTx = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // ladownoscTx
            // 
            this.ladownoscTx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ladownoscTx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ladownoscTx.ForeColor = System.Drawing.Color.White;
            this.ladownoscTx.HintForeColor = System.Drawing.Color.White;
            this.ladownoscTx.HintText = "";
            this.ladownoscTx.isPassword = false;
            this.ladownoscTx.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.ladownoscTx.LineIdleColor = System.Drawing.Color.Gray;
            this.ladownoscTx.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.ladownoscTx.LineThickness = 3;
            this.ladownoscTx.Location = new System.Drawing.Point(374, 68);
            this.ladownoscTx.Margin = new System.Windows.Forms.Padding(4);
            this.ladownoscTx.Name = "ladownoscTx";
            this.ladownoscTx.Size = new System.Drawing.Size(227, 33);
            this.ladownoscTx.TabIndex = 0;
            this.ladownoscTx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ladownoscTx.OnValueChanged += new System.EventHandler(this.rabatTx_OnValueChanged);
            // 
            // rabatTx
            // 
            this.rabatTx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rabatTx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.rabatTx.ForeColor = System.Drawing.Color.White;
            this.rabatTx.HintForeColor = System.Drawing.Color.White;
            this.rabatTx.HintText = "";
            this.rabatTx.isPassword = false;
            this.rabatTx.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.rabatTx.LineIdleColor = System.Drawing.Color.Gray;
            this.rabatTx.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.rabatTx.LineThickness = 3;
            this.rabatTx.Location = new System.Drawing.Point(374, 135);
            this.rabatTx.Margin = new System.Windows.Forms.Padding(4);
            this.rabatTx.Name = "rabatTx";
            this.rabatTx.Size = new System.Drawing.Size(227, 33);
            this.rabatTx.TabIndex = 1;
            this.rabatTx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.rabatTx.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox2_OnValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(374, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "ŁADWONOŚĆ POJAZDU W KG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(374, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "RABAT SKLEPU";
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(76)))), ((int)(((byte)(80)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Zapisz";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 40;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(406, 194);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(152, 51);
            this.bunifuThinButton21.TabIndex = 4;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // UserSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rabatTx);
            this.Controls.Add(this.ladownoscTx);
            this.Name = "UserSettings";
            this.Size = new System.Drawing.Size(1000, 513);
            this.Load += new System.EventHandler(this.UserSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox ladownoscTx;
        private Bunifu.Framework.UI.BunifuMaterialTextbox rabatTx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
    }
}
