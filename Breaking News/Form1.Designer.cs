namespace Breaking_News
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
            this.rdbKorea = new System.Windows.Forms.RadioButton();
            this.btnGetStas = new System.Windows.Forms.Button();
            this.txBxResult = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rdbBostad = new System.Windows.Forms.RadioButton();
            this.rdbEkonomi = new System.Windows.Forms.RadioButton();
            this.rdbAftonbladet = new System.Windows.Forms.RadioButton();
            this.rdbEpressen = new System.Windows.Forms.RadioButton();
            this.rdbDN = new System.Windows.Forms.RadioButton();
            this.rdbPolis = new System.Windows.Forms.RadioButton();
            this.grpBxSearchWords = new System.Windows.Forms.GroupBox();
            this.grpBxSites = new System.Windows.Forms.GroupBox();
            this.lblProgress = new System.Windows.Forms.Label();
            this.grpBxSearchWords.SuspendLayout();
            this.grpBxSites.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbKorea
            // 
            this.rdbKorea.AutoSize = true;
            this.rdbKorea.Location = new System.Drawing.Point(6, 19);
            this.rdbKorea.Name = "rdbKorea";
            this.rdbKorea.Size = new System.Drawing.Size(53, 17);
            this.rdbKorea.TabIndex = 1;
            this.rdbKorea.Text = "Korea";
            this.rdbKorea.UseVisualStyleBackColor = true;
            // 
            // btnGetStas
            // 
            this.btnGetStas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnGetStas.Location = new System.Drawing.Point(12, 162);
            this.btnGetStas.Name = "btnGetStas";
            this.btnGetStas.Size = new System.Drawing.Size(325, 23);
            this.btnGetStas.TabIndex = 2;
            this.btnGetStas.Text = "Get Statistics";
            this.btnGetStas.UseVisualStyleBackColor = true;
            this.btnGetStas.Click += new System.EventHandler(this._btnGetStas_Click);
            // 
            // txBxResult
            // 
            this.txBxResult.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txBxResult.Location = new System.Drawing.Point(121, 204);
            this.txBxResult.Name = "txBxResult";
            this.txBxResult.Size = new System.Drawing.Size(100, 20);
            this.txBxResult.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(151, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Result";
            // 
            // rdbBostad
            // 
            this.rdbBostad.AutoSize = true;
            this.rdbBostad.Location = new System.Drawing.Point(6, 47);
            this.rdbBostad.Name = "rdbBostad";
            this.rdbBostad.Size = new System.Drawing.Size(58, 17);
            this.rdbBostad.TabIndex = 13;
            this.rdbBostad.Text = "Bostad";
            this.rdbBostad.UseVisualStyleBackColor = true;
            // 
            // rdbEkonomi
            // 
            this.rdbEkonomi.AutoSize = true;
            this.rdbEkonomi.Location = new System.Drawing.Point(6, 75);
            this.rdbEkonomi.Name = "rdbEkonomi";
            this.rdbEkonomi.Size = new System.Drawing.Size(66, 17);
            this.rdbEkonomi.TabIndex = 14;
            this.rdbEkonomi.Text = "Ekonomi";
            this.rdbEkonomi.UseVisualStyleBackColor = true;
            // 
            // rdbAftonbladet
            // 
            this.rdbAftonbladet.AutoSize = true;
            this.rdbAftonbladet.Location = new System.Drawing.Point(6, 19);
            this.rdbAftonbladet.Name = "rdbAftonbladet";
            this.rdbAftonbladet.Size = new System.Drawing.Size(79, 17);
            this.rdbAftonbladet.TabIndex = 15;
            this.rdbAftonbladet.TabStop = true;
            this.rdbAftonbladet.Text = "Aftonbladet";
            this.rdbAftonbladet.UseVisualStyleBackColor = true;
            // 
            // rdbEpressen
            // 
            this.rdbEpressen.AutoSize = true;
            this.rdbEpressen.Location = new System.Drawing.Point(6, 50);
            this.rdbEpressen.Name = "rdbEpressen";
            this.rdbEpressen.Size = new System.Drawing.Size(69, 17);
            this.rdbEpressen.TabIndex = 16;
            this.rdbEpressen.TabStop = true;
            this.rdbEpressen.Text = "Epressen";
            this.rdbEpressen.UseVisualStyleBackColor = true;
            // 
            // rdbDN
            // 
            this.rdbDN.AutoSize = true;
            this.rdbDN.Location = new System.Drawing.Point(6, 81);
            this.rdbDN.Name = "rdbDN";
            this.rdbDN.Size = new System.Drawing.Size(102, 17);
            this.rdbDN.TabIndex = 17;
            this.rdbDN.TabStop = true;
            this.rdbDN.Text = "Dagens Nyheter";
            this.rdbDN.UseVisualStyleBackColor = true;
            // 
            // rdbPolis
            // 
            this.rdbPolis.AutoSize = true;
            this.rdbPolis.Location = new System.Drawing.Point(6, 103);
            this.rdbPolis.Name = "rdbPolis";
            this.rdbPolis.Size = new System.Drawing.Size(47, 17);
            this.rdbPolis.TabIndex = 18;
            this.rdbPolis.Text = "Polis";
            this.rdbPolis.UseVisualStyleBackColor = true;
            // 
            // grpBxSearchWords
            // 
            this.grpBxSearchWords.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpBxSearchWords.Controls.Add(this.rdbKorea);
            this.grpBxSearchWords.Controls.Add(this.rdbPolis);
            this.grpBxSearchWords.Controls.Add(this.rdbBostad);
            this.grpBxSearchWords.Controls.Add(this.rdbEkonomi);
            this.grpBxSearchWords.Location = new System.Drawing.Point(12, 12);
            this.grpBxSearchWords.Name = "grpBxSearchWords";
            this.grpBxSearchWords.Size = new System.Drawing.Size(139, 141);
            this.grpBxSearchWords.TabIndex = 19;
            this.grpBxSearchWords.TabStop = false;
            this.grpBxSearchWords.Text = "Keyword search settings";
            // 
            // grpBxSites
            // 
            this.grpBxSites.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpBxSites.Controls.Add(this.rdbAftonbladet);
            this.grpBxSites.Controls.Add(this.rdbDN);
            this.grpBxSites.Controls.Add(this.rdbEpressen);
            this.grpBxSites.Location = new System.Drawing.Point(183, 12);
            this.grpBxSites.Name = "grpBxSites";
            this.grpBxSites.Size = new System.Drawing.Size(154, 139);
            this.grpBxSites.TabIndex = 20;
            this.grpBxSites.TabStop = false;
            this.grpBxSites.Text = "Site search settings";
            // 
            // lblProgress
            // 
            this.lblProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProgress.Location = new System.Drawing.Point(7, 247);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(335, 13);
            this.lblProgress.TabIndex = 21;
            this.lblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 273);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.grpBxSites);
            this.Controls.Add(this.grpBxSearchWords);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txBxResult);
            this.Controls.Add(this.btnGetStas);
            this.Name = "Form1";
            this.Text = "Breaking News";
            this.grpBxSearchWords.ResumeLayout(false);
            this.grpBxSearchWords.PerformLayout();
            this.grpBxSites.ResumeLayout(false);
            this.grpBxSites.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdbKorea;
        private System.Windows.Forms.Button btnGetStas;
        private System.Windows.Forms.TextBox txBxResult;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rdbBostad;
        private System.Windows.Forms.RadioButton rdbEkonomi;
        private System.Windows.Forms.RadioButton rdbAftonbladet;
        private System.Windows.Forms.RadioButton rdbEpressen;
        private System.Windows.Forms.RadioButton rdbDN;
        private System.Windows.Forms.RadioButton rdbPolis;
        private System.Windows.Forms.GroupBox grpBxSearchWords;
        private System.Windows.Forms.GroupBox grpBxSites;
        private System.Windows.Forms.Label lblProgress;
    }
}

