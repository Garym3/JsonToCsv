namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_convertFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btn_convertFile
            // 
            this.btn_convertFile.Location = new System.Drawing.Point(107, 91);
            this.btn_convertFile.Name = "btn_convertFile";
            this.btn_convertFile.Size = new System.Drawing.Size(122, 56);
            this.btn_convertFile.TabIndex = 0;
            this.btn_convertFile.Text = "Convert File";
            this.btn_convertFile.UseVisualStyleBackColor = true;
            this.btn_convertFile.Click += new System.EventHandler(this.Btn_convertFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 239);
            this.Controls.Add(this.btn_convertFile);
            this.Name = "Form1";
            this.Text = "WX";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_convertFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

