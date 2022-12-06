namespace EricMarinTP2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.labelTitre = new System.Windows.Forms.Label();
            this.labelSousTitre = new System.Windows.Forms.Label();
            this.pictureBoxCamping = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDebut = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFin = new System.Windows.Forms.DateTimePicker();
            this.labelDebut = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRerservation = new System.Windows.Forms.Button();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamping)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIcon.Image")));
            this.pictureBoxIcon.Location = new System.Drawing.Point(29, 16);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(80, 74);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIcon.TabIndex = 0;
            this.pictureBoxIcon.TabStop = false;
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitre.Location = new System.Drawing.Point(131, 28);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(159, 29);
            this.labelTitre.TabIndex = 1;
            this.labelTitre.Text = "Camping QC";
            // 
            // labelSousTitre
            // 
            this.labelSousTitre.AutoSize = true;
            this.labelSousTitre.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSousTitre.Location = new System.Drawing.Point(131, 71);
            this.labelSousTitre.Name = "labelSousTitre";
            this.labelSousTitre.Size = new System.Drawing.Size(284, 19);
            this.labelSousTitre.TabIndex = 2;
            this.labelSousTitre.Text = "Système de réservation - Hébergement";
            // 
            // pictureBoxCamping
            // 
            this.pictureBoxCamping.BackColor = System.Drawing.Color.Wheat;
            this.pictureBoxCamping.Location = new System.Drawing.Point(111, 129);
            this.pictureBoxCamping.Name = "pictureBoxCamping";
            this.pictureBoxCamping.Size = new System.Drawing.Size(242, 199);
            this.pictureBoxCamping.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCamping.TabIndex = 3;
            this.pictureBoxCamping.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Parc du Bic",
            "Parc du Mont-Orford",
            "Camping du Rocher Percé",
            "Camping de la plage de St-Siméon"});
            this.comboBox1.Location = new System.Drawing.Point(73, 357);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(332, 23);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "Choix de l\'hébergément";
            // 
            // dateTimePickerDebut
            // 
            this.dateTimePickerDebut.Location = new System.Drawing.Point(73, 422);
            this.dateTimePickerDebut.Name = "dateTimePickerDebut";
            this.dateTimePickerDebut.Size = new System.Drawing.Size(161, 23);
            this.dateTimePickerDebut.TabIndex = 5;
            // 
            // dateTimePickerFin
            // 
            this.dateTimePickerFin.Location = new System.Drawing.Point(182, 313);
            this.dateTimePickerFin.Name = "dateTimePickerFin";
            this.dateTimePickerFin.Size = new System.Drawing.Size(161, 23);
            this.dateTimePickerFin.TabIndex = 6;
            // 
            // labelDebut
            // 
            this.labelDebut.AutoSize = true;
            this.labelDebut.BackColor = System.Drawing.Color.Wheat;
            this.labelDebut.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDebut.Location = new System.Drawing.Point(73, 404);
            this.labelDebut.Name = "labelDebut";
            this.labelDebut.Size = new System.Drawing.Size(87, 16);
            this.labelDebut.TabIndex = 7;
            this.labelDebut.Text = "Date d\'arrivée";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Wheat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(313, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Date de départ";
            // 
            // buttonRerservation
            // 
            this.buttonRerservation.Location = new System.Drawing.Point(73, 476);
            this.buttonRerservation.Name = "buttonRerservation";
            this.buttonRerservation.Size = new System.Drawing.Size(161, 41);
            this.buttonRerservation.TabIndex = 9;
            this.buttonRerservation.Text = "Réservation";
            this.buttonRerservation.UseVisualStyleBackColor = true;
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Location = new System.Drawing.Point(244, 476);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(161, 41);
            this.buttonQuitter.TabIndex = 10;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dateTimePickerFin);
            this.panel1.Location = new System.Drawing.Point(61, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 429);
            this.panel1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(479, 558);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.buttonRerservation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDebut);
            this.Controls.Add(this.dateTimePickerDebut);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBoxCamping);
            this.Controls.Add(this.labelSousTitre);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.pictureBoxIcon);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "EricMarinMejiaTP02";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamping)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBoxIcon;
        private Label labelTitre;
        private Label labelSousTitre;
        private PictureBox pictureBoxCamping;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePickerDebut;
        private DateTimePicker dateTimePickerFin;
        private Label labelDebut;
        private Label label1;
        private Button buttonRerservation;
        private Button buttonQuitter;
        private Panel panel1;
    }
}