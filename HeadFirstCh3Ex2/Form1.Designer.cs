namespace HeadFirstCh3Ex2
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
            this.joesCashLabel = new System.Windows.Forms.Label();
            this.bobsCashLabel = new System.Windows.Forms.Label();
            this.bankCashLabel = new System.Windows.Forms.Label();
            this.giveJoeCash = new System.Windows.Forms.Button();
            this.getBobCash = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // joesCashLabel
            // 
            this.joesCashLabel.AutoSize = true;
            this.joesCashLabel.Location = new System.Drawing.Point(35, 24);
            this.joesCashLabel.Name = "joesCashLabel";
            this.joesCashLabel.Size = new System.Drawing.Size(35, 13);
            this.joesCashLabel.TabIndex = 0;
            this.joesCashLabel.Text = "label1";
            // 
            // bobsCashLabel
            // 
            this.bobsCashLabel.AutoSize = true;
            this.bobsCashLabel.Location = new System.Drawing.Point(38, 56);
            this.bobsCashLabel.Name = "bobsCashLabel";
            this.bobsCashLabel.Size = new System.Drawing.Size(35, 13);
            this.bobsCashLabel.TabIndex = 1;
            this.bobsCashLabel.Text = "label2";
            // 
            // bankCashLabel
            // 
            this.bankCashLabel.AutoSize = true;
            this.bankCashLabel.Location = new System.Drawing.Point(38, 73);
            this.bankCashLabel.Name = "bankCashLabel";
            this.bankCashLabel.Size = new System.Drawing.Size(35, 13);
            this.bankCashLabel.TabIndex = 2;
            this.bankCashLabel.Text = "label3";
            // 
            // giveJoeCash
            // 
            this.giveJoeCash.Location = new System.Drawing.Point(38, 101);
            this.giveJoeCash.Name = "giveJoeCash";
            this.giveJoeCash.Size = new System.Drawing.Size(75, 42);
            this.giveJoeCash.TabIndex = 3;
            this.giveJoeCash.Text = "Give $10 to Joe";
            this.giveJoeCash.UseVisualStyleBackColor = true;
            this.giveJoeCash.Click += new System.EventHandler(this.giveJoeCash_Click);
            // 
            // getBobCash
            // 
            this.getBobCash.Location = new System.Drawing.Point(119, 101);
            this.getBobCash.Name = "getBobCash";
            this.getBobCash.Size = new System.Drawing.Size(75, 42);
            this.getBobCash.TabIndex = 4;
            this.getBobCash.Text = "Receive $5 from Bob";
            this.getBobCash.UseVisualStyleBackColor = true;
            this.getBobCash.Click += new System.EventHandler(this.getBobCash_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 156);
            this.Controls.Add(this.getBobCash);
            this.Controls.Add(this.giveJoeCash);
            this.Controls.Add(this.bankCashLabel);
            this.Controls.Add(this.bobsCashLabel);
            this.Controls.Add(this.joesCashLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Fun with Joe and Bob";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label joesCashLabel;
        private System.Windows.Forms.Label bobsCashLabel;
        private System.Windows.Forms.Label bankCashLabel;
        private System.Windows.Forms.Button giveJoeCash;
        private System.Windows.Forms.Button getBobCash;
    }
}

