namespace XPOCollection_Teste
{
    partial class Form3
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
            this.btnAbrirForm4 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // btnAbrirForm4
            // 
            this.btnAbrirForm4.Location = new System.Drawing.Point(35, 40);
            this.btnAbrirForm4.Name = "btnAbrirForm4";
            this.btnAbrirForm4.Size = new System.Drawing.Size(124, 37);
            this.btnAbrirForm4.TabIndex = 0;
            this.btnAbrirForm4.Text = "Abrir Form 3";
            this.btnAbrirForm4.Click += new System.EventHandler(this.btnAbrirForm4_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(81, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Form 3";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(197, 99);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnAbrirForm4);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAbrirForm4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}