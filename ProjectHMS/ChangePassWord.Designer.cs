namespace ProjectHMS
{
    partial class ChangePassWord
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
            this.label1 = new System.Windows.Forms.Label();
            this.dusertxt = new System.Windows.Forms.TextBox();
            this.dpasstxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dchangepasstbn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(61, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "New PassWord";
            // 
            // dusertxt
            // 
            this.dusertxt.Location = new System.Drawing.Point(246, 80);
            this.dusertxt.Name = "dusertxt";
            this.dusertxt.Size = new System.Drawing.Size(100, 20);
            this.dusertxt.TabIndex = 50;
            // 
            // dpasstxt
            // 
            this.dpasstxt.Location = new System.Drawing.Point(246, 135);
            this.dpasstxt.Name = "dpasstxt";
            this.dpasstxt.Size = new System.Drawing.Size(100, 20);
            this.dpasstxt.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(61, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "User Name";
            // 
            // dchangepasstbn
            // 
            this.dchangepasstbn.BackColor = System.Drawing.Color.SandyBrown;
            this.dchangepasstbn.Location = new System.Drawing.Point(122, 190);
            this.dchangepasstbn.Name = "dchangepasstbn";
            this.dchangepasstbn.Size = new System.Drawing.Size(150, 34);
            this.dchangepasstbn.TabIndex = 52;
            this.dchangepasstbn.Text = "CHANGE PASSWORD";
            this.dchangepasstbn.UseVisualStyleBackColor = false;
            this.dchangepasstbn.Click += new System.EventHandler(this.Dchangepasstbn_Click);
            // 
            // ChangePassWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(405, 327);
            this.Controls.Add(this.dchangepasstbn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dusertxt);
            this.Controls.Add(this.dpasstxt);
            this.Controls.Add(this.label3);
            this.Name = "ChangePassWord";
            this.Text = "ChangePassWord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dusertxt;
        private System.Windows.Forms.TextBox dpasstxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button dchangepasstbn;
    }
}