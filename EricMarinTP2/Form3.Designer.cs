namespace EricMarinTP2
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
            this.labelCamping = new System.Windows.Forms.Label();
            this.labelResevations = new System.Windows.Forms.Label();
            this.listBoxReservations = new System.Windows.Forms.ListBox();
            this.labelDetails = new System.Windows.Forms.Label();
            this.textBoxDetails = new System.Windows.Forms.TextBox();
            this.pictureBoxCamping = new System.Windows.Forms.PictureBox();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamping)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCamping
            // 
            this.labelCamping.AutoSize = true;
            this.labelCamping.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCamping.Location = new System.Drawing.Point(7, 9);
            this.labelCamping.Name = "labelCamping";
            this.labelCamping.Size = new System.Drawing.Size(219, 29);
            this.labelCamping.TabIndex = 1;
            this.labelCamping.Text = "Nom du Camping";
            // 
            // labelResevations
            // 
            this.labelResevations.AutoSize = true;
            this.labelResevations.BackColor = System.Drawing.Color.Wheat;
            this.labelResevations.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelResevations.Location = new System.Drawing.Point(16, 15);
            this.labelResevations.Name = "labelResevations";
            this.labelResevations.Size = new System.Drawing.Size(109, 19);
            this.labelResevations.TabIndex = 22;
            this.labelResevations.Text = "Réservations :";
            // 
            // listBoxReservations
            // 
            this.listBoxReservations.FormattingEnabled = true;
            this.listBoxReservations.ItemHeight = 15;
            this.listBoxReservations.Location = new System.Drawing.Point(16, 37);
            this.listBoxReservations.Name = "listBoxReservations";
            this.listBoxReservations.Size = new System.Drawing.Size(219, 244);
            this.listBoxReservations.TabIndex = 23;
            this.listBoxReservations.SelectedIndexChanged += new System.EventHandler(this.listBoxReservations_SelectedIndexChanged);
            // 
            // labelDetails
            // 
            this.labelDetails.AutoSize = true;
            this.labelDetails.BackColor = System.Drawing.Color.Wheat;
            this.labelDetails.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDetails.Location = new System.Drawing.Point(254, 15);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(67, 19);
            this.labelDetails.TabIndex = 24;
            this.labelDetails.Text = "Détails :";
            // 
            // textBoxDetails
            // 
            this.textBoxDetails.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDetails.Location = new System.Drawing.Point(254, 37);
            this.textBoxDetails.Multiline = true;
            this.textBoxDetails.Name = "textBoxDetails";
            this.textBoxDetails.ReadOnly = true;
            this.textBoxDetails.Size = new System.Drawing.Size(176, 244);
            this.textBoxDetails.TabIndex = 25;
            // 
            // pictureBoxCamping
            // 
            this.pictureBoxCamping.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCamping.Location = new System.Drawing.Point(451, 37);
            this.pictureBoxCamping.Name = "pictureBoxCamping";
            this.pictureBoxCamping.Size = new System.Drawing.Size(210, 169);
            this.pictureBoxCamping.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCamping.TabIndex = 26;
            this.pictureBoxCamping.TabStop = false;
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Location = new System.Drawing.Point(451, 235);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(210, 46);
            this.buttonQuitter.TabIndex = 27;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonQuitter);
            this.panel1.Controls.Add(this.pictureBoxCamping);
            this.panel1.Controls.Add(this.labelResevations);
            this.panel1.Controls.Add(this.listBoxReservations);
            this.panel1.Controls.Add(this.labelDetails);
            this.panel1.Controls.Add(this.textBoxDetails);
            this.panel1.Location = new System.Drawing.Point(7, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 294);
            this.panel1.TabIndex = 28;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(694, 356);
            this.Controls.Add(this.labelCamping);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Affichage des réservations";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamping)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelCamping;
        private Label labelResevations;
        private ListBox listBoxReservations;
        private Label labelDetails;
        private TextBox textBoxDetails;
        private PictureBox pictureBoxCamping;
        private Button buttonQuitter;
        private Panel panel1;
    }
}