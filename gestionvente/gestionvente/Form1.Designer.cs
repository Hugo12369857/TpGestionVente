namespace gestionvente
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listeClient = new System.Windows.Forms.ListView();
            this.modification = new System.Windows.Forms.Button();
            this.ajouter = new System.Windows.Forms.Button();
            this.supprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(82, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(403, 23);
            this.comboBox1.TabIndex = 0;
            // 
            // listeClient
            // 
            this.listeClient.Location = new System.Drawing.Point(82, 109);
            this.listeClient.Name = "listeClient";
            this.listeClient.Size = new System.Drawing.Size(403, 230);
            this.listeClient.TabIndex = 1;
            this.listeClient.UseCompatibleStateImageBehavior = false;
            // 
            // modification
            // 
            this.modification.Location = new System.Drawing.Point(667, 77);
            this.modification.Name = "modification";
            this.modification.Size = new System.Drawing.Size(89, 23);
            this.modification.TabIndex = 2;
            this.modification.Text = "modification";
            this.modification.UseVisualStyleBackColor = true;
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(667, 119);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(89, 23);
            this.ajouter.TabIndex = 3;
            this.ajouter.Text = "ajouter";
            this.ajouter.UseVisualStyleBackColor = true;
            // 
            // supprimer
            // 
            this.supprimer.Location = new System.Drawing.Point(667, 169);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(89, 23);
            this.supprimer.TabIndex = 4;
            this.supprimer.Text = "supprimer";
            this.supprimer.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.modification);
            this.Controls.Add(this.listeClient);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox comboBox1;
        private ListView listeClient;
        private Button modification;
        private Button ajouter;
        private Button supprimer;
    }
}