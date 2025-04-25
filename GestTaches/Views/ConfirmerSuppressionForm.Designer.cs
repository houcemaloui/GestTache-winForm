namespace GestTaches.Views
{
    partial class ConfirmerSuppressionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmerSuppressionForm));
            this.labelMessageSupp = new System.Windows.Forms.Label();
            this.buttonConfSuppr = new System.Windows.Forms.Button();
            this.buttonAnnulerSupp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMessageSupp
            // 
            this.labelMessageSupp.AutoSize = true;
            this.labelMessageSupp.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessageSupp.ForeColor = System.Drawing.Color.Red;
            this.labelMessageSupp.Location = new System.Drawing.Point(55, 52);
            this.labelMessageSupp.Name = "labelMessageSupp";
            this.labelMessageSupp.Size = new System.Drawing.Size(363, 24);
            this.labelMessageSupp.TabIndex = 0;
            this.labelMessageSupp.Text = "Voulez-vous vraiment supprimer cette tâche ?";
            // 
            // buttonConfSuppr
            // 
            this.buttonConfSuppr.BackColor = System.Drawing.Color.Red;
            this.buttonConfSuppr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConfSuppr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfSuppr.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfSuppr.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonConfSuppr.Location = new System.Drawing.Point(90, 103);
            this.buttonConfSuppr.Name = "buttonConfSuppr";
            this.buttonConfSuppr.Size = new System.Drawing.Size(129, 43);
            this.buttonConfSuppr.TabIndex = 1;
            this.buttonConfSuppr.TabStop = false;
            this.buttonConfSuppr.Text = "Confirmer";
            this.buttonConfSuppr.UseVisualStyleBackColor = false;
            this.buttonConfSuppr.Click += new System.EventHandler(this.buttonConfSuppr_Click);
            // 
            // buttonAnnulerSupp
            // 
            this.buttonAnnulerSupp.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonAnnulerSupp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAnnulerSupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnnulerSupp.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnnulerSupp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAnnulerSupp.Location = new System.Drawing.Point(239, 103);
            this.buttonAnnulerSupp.Name = "buttonAnnulerSupp";
            this.buttonAnnulerSupp.Size = new System.Drawing.Size(129, 43);
            this.buttonAnnulerSupp.TabIndex = 2;
            this.buttonAnnulerSupp.TabStop = false;
            this.buttonAnnulerSupp.Text = "Annuler";
            this.buttonAnnulerSupp.UseVisualStyleBackColor = false;
            this.buttonAnnulerSupp.Click += new System.EventHandler(this.buttonAnnulerSupp_Click);
            // 
            // ConfirmerSuppressionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 186);
            this.Controls.Add(this.buttonAnnulerSupp);
            this.Controls.Add(this.buttonConfSuppr);
            this.Controls.Add(this.labelMessageSupp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfirmerSuppressionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Supprimer la tâche";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMessageSupp;
        private System.Windows.Forms.Button buttonConfSuppr;
        private System.Windows.Forms.Button buttonAnnulerSupp;
    }
}