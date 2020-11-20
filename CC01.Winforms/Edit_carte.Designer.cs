
namespace CC01.Winforms
{
    partial class Edit_carte
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
            this.textsearchecole = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oobservation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ecolsupprim = new System.Windows.Forms.Button();
            this.ecolemodif = new System.Windows.Forms.Button();
            this.ecoleajout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textsearchecole
            // 
            this.textsearchecole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textsearchecole.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textsearchecole.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textsearchecole.Location = new System.Drawing.Point(115, 99);
            this.textsearchecole.Margin = new System.Windows.Forms.Padding(2);
            this.textsearchecole.Name = "textsearchecole";
            this.textsearchecole.Size = new System.Drawing.Size(279, 28);
            this.textsearchecole.TabIndex = 18;
            this.textsearchecole.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.equipement,
            this.quantite,
            this.oobservation});
            this.dataGridView1.Location = new System.Drawing.Point(32, 131);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(972, 294);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // numero
            // 
            this.numero.HeaderText = "matricule";
            this.numero.MinimumWidth = 6;
            this.numero.Name = "numero";
            this.numero.Width = 125;
            // 
            // equipement
            // 
            this.equipement.HeaderText = "nom";
            this.equipement.MinimumWidth = 6;
            this.equipement.Name = "equipement";
            this.equipement.Width = 500;
            // 
            // quantite
            // 
            this.quantite.HeaderText = "prenom";
            this.quantite.MinimumWidth = 6;
            this.quantite.Name = "quantite";
            this.quantite.Width = 125;
            // 
            // oobservation
            // 
            this.oobservation.HeaderText = "Email";
            this.oobservation.MinimumWidth = 6;
            this.oobservation.Name = "oobservation";
            this.oobservation.Width = 700;
            // 
            // ecolsupprim
            // 
            this.ecolsupprim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ecolsupprim.BackColor = System.Drawing.Color.Crimson;
            this.ecolsupprim.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecolsupprim.ForeColor = System.Drawing.Color.White;
            this.ecolsupprim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ecolsupprim.Location = new System.Drawing.Point(674, 6);
            this.ecolsupprim.Margin = new System.Windows.Forms.Padding(2);
            this.ecolsupprim.Name = "ecolsupprim";
            this.ecolsupprim.Size = new System.Drawing.Size(183, 40);
            this.ecolsupprim.TabIndex = 14;
            this.ecolsupprim.Text = "Supprimer";
            this.ecolsupprim.UseVisualStyleBackColor = false;
            this.ecolsupprim.Click += new System.EventHandler(this.ecolsupprim_Click);
            // 
            // ecolemodif
            // 
            this.ecolemodif.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ecolemodif.BackColor = System.Drawing.Color.DarkCyan;
            this.ecolemodif.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecolemodif.ForeColor = System.Drawing.Color.White;
            this.ecolemodif.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ecolemodif.Location = new System.Drawing.Point(390, 6);
            this.ecolemodif.Margin = new System.Windows.Forms.Padding(2);
            this.ecolemodif.Name = "ecolemodif";
            this.ecolemodif.Size = new System.Drawing.Size(183, 40);
            this.ecolemodif.TabIndex = 13;
            this.ecolemodif.Text = "Modifier";
            this.ecolemodif.UseVisualStyleBackColor = false;
            this.ecolemodif.Click += new System.EventHandler(this.ecolemodif_Click);
            // 
            // ecoleajout
            // 
            this.ecoleajout.BackColor = System.Drawing.Color.LimeGreen;
            this.ecoleajout.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecoleajout.ForeColor = System.Drawing.Color.White;
            this.ecoleajout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ecoleajout.Location = new System.Drawing.Point(99, 6);
            this.ecoleajout.Margin = new System.Windows.Forms.Padding(2);
            this.ecoleajout.Name = "ecoleajout";
            this.ecoleajout.Size = new System.Drawing.Size(183, 40);
            this.ecoleajout.TabIndex = 11;
            this.ecoleajout.Text = "Ajouter";
            this.ecoleajout.UseVisualStyleBackColor = false;
            this.ecoleajout.Click += new System.EventHandler(this.ecoleajout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "SEARCH";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(390, 441);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(294, 58);
            this.button1.TabIndex = 21;
            this.button1.Text = "IMPRIMER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Edit_carte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1028, 521);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textsearchecole);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ecolsupprim);
            this.Controls.Add(this.ecolemodif);
            this.Controls.Add(this.ecoleajout);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Edit_carte";
            this.Text = "Editecole";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textsearchecole;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ecolsupprim;
        private System.Windows.Forms.Button ecolemodif;
        private System.Windows.Forms.Button ecoleajout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipement;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn oobservation;
        private System.Windows.Forms.Button button1;
    }
}