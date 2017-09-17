namespace Mini.WinForms
{
    partial class frmPrincipal
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
            this.txtOrigem = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.btnExec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOrigem
            // 
            this.txtOrigem.Location = new System.Drawing.Point(155, 31);
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.Size = new System.Drawing.Size(270, 20);
            this.txtOrigem.TabIndex = 0;
            this.txtOrigem.Text = "origem.html";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(155, 71);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(270, 20);
            this.txtDestino.TabIndex = 1;
            this.txtDestino.Text = "destino.html";
            // 
            // btnExec
            // 
            this.btnExec.Location = new System.Drawing.Point(155, 125);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(75, 23);
            this.btnExec.TabIndex = 2;
            this.btnExec.Text = "Executar";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 261);
            this.Controls.Add(this.btnExec);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtOrigem);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minimalizador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOrigem;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Button btnExec;
    }
}

