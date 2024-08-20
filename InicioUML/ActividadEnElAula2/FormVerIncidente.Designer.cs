namespace ActividadEnElAula2
{
    partial class FormVerIncidente
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
            this.lbIncidente = new System.Windows.Forms.ListBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbIncidente
            // 
            this.lbIncidente.FormattingEnabled = true;
            this.lbIncidente.Location = new System.Drawing.Point(35, 13);
            this.lbIncidente.Name = "lbIncidente";
            this.lbIncidente.Size = new System.Drawing.Size(736, 420);
            this.lbIncidente.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(368, 447);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "button1";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // FormVerIncidente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lbIncidente);
            this.Name = "FormVerIncidente";
            this.Text = "FormVerIncidente";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbIncidente;
        private System.Windows.Forms.Button btnCerrar;
    }
}