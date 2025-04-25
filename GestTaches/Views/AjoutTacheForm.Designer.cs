namespace GestTaches.Views
{
    partial class AjoutTacheForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutTacheForm));
            this.labelTitre = new System.Windows.Forms.Label();
            this.textTitre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboPriorite = new System.Windows.Forms.ComboBox();
            this.buttonAjoutTache = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelTitre.Location = new System.Drawing.Point(35, 24);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(174, 29);
            this.labelTitre.TabIndex = 0;
            this.labelTitre.Text = "Titre de la tâche :";
            // 
            // textTitre
            // 
            this.textTitre.Location = new System.Drawing.Point(40, 61);
            this.textTitre.Name = "textTitre";
            this.textTitre.Size = new System.Drawing.Size(503, 26);
            this.textTitre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(128, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Priorité :";
            // 
            // comboPriorite
            // 
            this.comboPriorite.FormattingEnabled = true;
            this.comboPriorite.Location = new System.Drawing.Point(243, 116);
            this.comboPriorite.Name = "comboPriorite";
            this.comboPriorite.Size = new System.Drawing.Size(179, 28);
            this.comboPriorite.TabIndex = 3;
            // 
            // buttonAjoutTache
            // 
            this.buttonAjoutTache.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAjoutTache.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAjoutTache.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjoutTache.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjoutTache.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonAjoutTache.Location = new System.Drawing.Point(111, 186);
            this.buttonAjoutTache.Name = "buttonAjoutTache";
            this.buttonAjoutTache.Size = new System.Drawing.Size(166, 54);
            this.buttonAjoutTache.TabIndex = 4;
            this.buttonAjoutTache.TabStop = false;
            this.buttonAjoutTache.Text = "Ajouter";
            this.buttonAjoutTache.UseVisualStyleBackColor = false;
            this.buttonAjoutTache.Click += new System.EventHandler(this.buttonAjoutTache_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonAnnuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnnuler.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnnuler.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonAnnuler.Location = new System.Drawing.Point(323, 186);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(162, 54);
            this.buttonAnnuler.TabIndex = 5;
            this.buttonAnnuler.TabStop = false;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = false;
            // 
            // AjoutTacheForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 278);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonAjoutTache);
            this.Controls.Add(this.comboPriorite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textTitre);
            this.Controls.Add(this.labelTitre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AjoutTacheForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajouter une tâche";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.TextBox textTitre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboPriorite;
        private System.Windows.Forms.Button buttonAjoutTache;
        private System.Windows.Forms.Button buttonAnnuler;
    }
}