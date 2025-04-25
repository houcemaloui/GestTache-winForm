namespace GestTaches.Views
{
    partial class GestTacheForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestTacheForm));
            this.TitreLabel = new System.Windows.Forms.Label();
            this.buttonAjoutTache = new System.Windows.Forms.Button();
            this.listViewTaches = new System.Windows.Forms.ListView();
            this.columnTitre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPriorite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEtat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Actions = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // TitreLabel
            // 
            this.TitreLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TitreLabel.AutoSize = true;
            this.TitreLabel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitreLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TitreLabel.Location = new System.Drawing.Point(282, 29);
            this.TitreLabel.Name = "TitreLabel";
            this.TitreLabel.Size = new System.Drawing.Size(391, 46);
            this.TitreLabel.TabIndex = 0;
            this.TitreLabel.Text = "Gestion des Tâches";
            // 
            // buttonAjoutTache
            // 
            this.buttonAjoutTache.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAjoutTache.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAjoutTache.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAjoutTache.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjoutTache.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjoutTache.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAjoutTache.Location = new System.Drawing.Point(759, 80);
            this.buttonAjoutTache.Name = "buttonAjoutTache";
            this.buttonAjoutTache.Size = new System.Drawing.Size(174, 45);
            this.buttonAjoutTache.TabIndex = 1;
            this.buttonAjoutTache.TabStop = false;
            this.buttonAjoutTache.Text = "Ajouter une tâche";
            this.buttonAjoutTache.UseVisualStyleBackColor = false;
            this.buttonAjoutTache.Click += new System.EventHandler(this.buttonAjoutTache_Click);
            // 
            // listViewTaches
            // 
            this.listViewTaches.AllowColumnReorder = true;
            this.listViewTaches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewTaches.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTitre,
            this.columnPriorite,
            this.columnEtat,
            this.Actions});
            this.listViewTaches.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewTaches.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.listViewTaches.FullRowSelect = true;
            this.listViewTaches.GridLines = true;
            this.listViewTaches.HideSelection = false;
            this.listViewTaches.Location = new System.Drawing.Point(116, 141);
            this.listViewTaches.Name = "listViewTaches";
            this.listViewTaches.Size = new System.Drawing.Size(817, 447);
            this.listViewTaches.TabIndex = 2;
            this.listViewTaches.UseCompatibleStateImageBehavior = false;
            this.listViewTaches.View = System.Windows.Forms.View.Details;
            // 
            // columnTitre
            // 
            this.columnTitre.Text = "Tâche";
            this.columnTitre.Width = 250;
            // 
            // columnPriorite
            // 
            this.columnPriorite.Text = "Ptiorité";
            this.columnPriorite.Width = 100;
            // 
            // columnEtat
            // 
            this.columnEtat.Text = "Etat";
            this.columnEtat.Width = 100;
            // 
            // Actions
            // 
            this.Actions.Text = "Actions";
            this.Actions.Width = 80;
            // 
            // GestTacheForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 600);
            this.Controls.Add(this.listViewTaches);
            this.Controls.Add(this.buttonAjoutTache);
            this.Controls.Add(this.TitreLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GestTacheForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste des tâches";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitreLabel;
        private System.Windows.Forms.Button buttonAjoutTache;
        private System.Windows.Forms.ListView listViewTaches;
        private System.Windows.Forms.ColumnHeader columnTitre;
        private System.Windows.Forms.ColumnHeader columnPriorite;
        private System.Windows.Forms.ColumnHeader columnEtat;
        private System.Windows.Forms.ColumnHeader Actions;
    }
}