namespace GestTaches
{
    partial class ConfirmerTacheTermineeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmerTacheTermineeForm));
            this.labelTacheTerminee = new System.Windows.Forms.Label();
            this.buttonConfirmer = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTacheTerminee
            // 
            this.labelTacheTerminee.AutoSize = true;
            this.labelTacheTerminee.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTacheTerminee.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelTacheTerminee.Location = new System.Drawing.Point(57, 50);
            this.labelTacheTerminee.Name = "labelTacheTerminee";
            this.labelTacheTerminee.Size = new System.Drawing.Size(410, 24);
            this.labelTacheTerminee.TabIndex = 0;
            this.labelTacheTerminee.Text = "Voulez-vous marquer cette tâche comme terminée ?";
            this.labelTacheTerminee.Click += new System.EventHandler(this.labelTacheTerminee_Click);
            // 
            // buttonConfirmer
            // 
            this.buttonConfirmer.BackColor = System.Drawing.Color.Green;
            this.buttonConfirmer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConfirmer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmer.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonConfirmer.Location = new System.Drawing.Point(103, 99);
            this.buttonConfirmer.Name = "buttonConfirmer";
            this.buttonConfirmer.Size = new System.Drawing.Size(134, 45);
            this.buttonConfirmer.TabIndex = 1;
            this.buttonConfirmer.TabStop = false;
            this.buttonConfirmer.Text = "Confirmer";
            this.buttonConfirmer.UseVisualStyleBackColor = false;
            this.buttonConfirmer.Click += new System.EventHandler(this.buttonConfirmer_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonAnnuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnnuler.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnnuler.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAnnuler.Location = new System.Drawing.Point(265, 99);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(134, 45);
            this.buttonAnnuler.TabIndex = 2;
            this.buttonAnnuler.TabStop = false;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = false;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // ConfirmerTacheTermineeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 207);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonConfirmer);
            this.Controls.Add(this.labelTacheTerminee);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfirmerTacheTermineeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Terminer la tâche";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTacheTerminee;
        private System.Windows.Forms.Button buttonConfirmer;
        private System.Windows.Forms.Button buttonAnnuler;
    }
}