namespace WindowsFormsApp1
{
    partial class FormBoostrap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBoostrap));
            this.TxtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.checkBoxProd = new System.Windows.Forms.CheckBox();
            this.comboLocation = new System.Windows.Forms.ComboBox();
            this.Title = new System.Windows.Forms.Label();
            this.Location = new System.Windows.Forms.Label();
            this.ComboType = new System.Windows.Forms.ComboBox();
            this.Type = new System.Windows.Forms.Label();
            this.Criticity = new System.Windows.Forms.Label();
            this.comboCriticity = new System.Windows.Forms.ComboBox();
            this.Environment = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxPreprod = new System.Windows.Forms.CheckBox();
            this.checkBoxDemo = new System.Windows.Forms.CheckBox();
            this.StartDate = new System.Windows.Forms.Label();
            this.Duration = new System.Windows.Forms.Label();
            this.DurationInHours = new System.Windows.Forms.NumericUpDown();
            this.Status = new System.Windows.Forms.Label();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.Percent = new System.Windows.Forms.Label();
            this.comboPercent = new System.Windows.Forms.ComboBox();
            this.butCancel = new System.Windows.Forms.Button();
            this.ButSubmit = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SendEmail = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DurationInHours)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtTitle
            // 
            this.TxtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTitle.Location = new System.Drawing.Point(24, 98);
            this.TxtTitle.Multiline = true;
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(260, 32);
            this.TxtTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create new task";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(24, 522);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(280, 22);
            this.dateTimePicker.TabIndex = 2;
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(28, 284);
            this.TxtDescription.Multiline = true;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(653, 179);
            this.TxtDescription.TabIndex = 3;
            // 
            // checkBoxProd
            // 
            this.checkBoxProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxProd.AutoSize = true;
            this.checkBoxProd.Location = new System.Drawing.Point(477, 182);
            this.checkBoxProd.Name = "checkBoxProd";
            this.checkBoxProd.Size = new System.Drawing.Size(58, 20);
            this.checkBoxProd.TabIndex = 4;
            this.checkBoxProd.Text = "Prod";
            this.checkBoxProd.UseVisualStyleBackColor = true;
            // 
            // comboLocation
            // 
            this.comboLocation.FormattingEnabled = true;
            this.comboLocation.ItemHeight = 16;
            this.comboLocation.Items.AddRange(new object[] {
            "Barcelona",
            "Badalona",
            "Mataro",
            "Gibraltar",
            "Paises bajos"});
            this.comboLocation.Location = new System.Drawing.Point(345, 98);
            this.comboLocation.Name = "comboLocation";
            this.comboLocation.Size = new System.Drawing.Size(283, 24);
            this.comboLocation.TabIndex = 5;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(24, 70);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(41, 20);
            this.Title.TabIndex = 6;
            this.Title.Text = "Title";
            // 
            // Location
            // 
            this.Location.AutoSize = true;
            this.Location.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location.Location = new System.Drawing.Point(341, 70);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(73, 20);
            this.Location.TabIndex = 7;
            this.Location.Text = "Location";
            // 
            // ComboType
            // 
            this.ComboType.FormattingEnabled = true;
            this.ComboType.Items.AddRange(new object[] {
            "Incident",
            "Agravio",
            "bounds"});
            this.ComboType.Location = new System.Drawing.Point(29, 182);
            this.ComboType.Name = "ComboType";
            this.ComboType.Size = new System.Drawing.Size(166, 24);
            this.ComboType.TabIndex = 8;
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type.Location = new System.Drawing.Point(25, 153);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(45, 20);
            this.Type.TabIndex = 9;
            this.Type.Text = "Type";
            // 
            // Criticity
            // 
            this.Criticity.AutoSize = true;
            this.Criticity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Criticity.Location = new System.Drawing.Point(228, 153);
            this.Criticity.Name = "Criticity";
            this.Criticity.Size = new System.Drawing.Size(66, 20);
            this.Criticity.TabIndex = 10;
            this.Criticity.Text = "Criticity";
            // 
            // comboCriticity
            // 
            this.comboCriticity.FormattingEnabled = true;
            this.comboCriticity.Items.AddRange(new object[] {
            "Minor",
            "Normal",
            "Serious",
            "Hight"});
            this.comboCriticity.Location = new System.Drawing.Point(232, 182);
            this.comboCriticity.Name = "comboCriticity";
            this.comboCriticity.Size = new System.Drawing.Size(166, 24);
            this.comboCriticity.TabIndex = 11;
            // 
            // Environment
            // 
            this.Environment.AutoSize = true;
            this.Environment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Environment.Location = new System.Drawing.Point(473, 141);
            this.Environment.Name = "Environment";
            this.Environment.Size = new System.Drawing.Size(102, 20);
            this.Environment.TabIndex = 12;
            this.Environment.Text = "Environment";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Description";
            // 
            // checkBoxPreprod
            // 
            this.checkBoxPreprod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxPreprod.AutoSize = true;
            this.checkBoxPreprod.Location = new System.Drawing.Point(477, 208);
            this.checkBoxPreprod.Name = "checkBoxPreprod";
            this.checkBoxPreprod.Size = new System.Drawing.Size(78, 20);
            this.checkBoxPreprod.TabIndex = 14;
            this.checkBoxPreprod.Text = "Preprod";
            this.checkBoxPreprod.UseVisualStyleBackColor = true;
            // 
            // checkBoxDemo
            // 
            this.checkBoxDemo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxDemo.AutoSize = true;
            this.checkBoxDemo.Location = new System.Drawing.Point(477, 234);
            this.checkBoxDemo.Name = "checkBoxDemo";
            this.checkBoxDemo.Size = new System.Drawing.Size(66, 20);
            this.checkBoxDemo.TabIndex = 15;
            this.checkBoxDemo.Text = "Demo";
            this.checkBoxDemo.UseVisualStyleBackColor = true;
            // 
            // StartDate
            // 
            this.StartDate.AutoSize = true;
            this.StartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDate.Location = new System.Drawing.Point(25, 488);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(82, 20);
            this.StartDate.TabIndex = 16;
            this.StartDate.Text = "Start date";
            // 
            // Duration
            // 
            this.Duration.AutoSize = true;
            this.Duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Duration.Location = new System.Drawing.Point(379, 488);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(150, 20);
            this.Duration.TabIndex = 17;
            this.Duration.Text = "Duration (in hours)";
            // 
            // DurationInHours
            // 
            this.DurationInHours.DecimalPlaces = 2;
            this.DurationInHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DurationInHours.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.DurationInHours.Location = new System.Drawing.Point(383, 522);
            this.DurationInHours.Name = "DurationInHours";
            this.DurationInHours.Size = new System.Drawing.Size(278, 22);
            this.DurationInHours.TabIndex = 19;
            this.DurationInHours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.Location = new System.Drawing.Point(20, 564);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(57, 20);
            this.Status.TabIndex = 21;
            this.Status.Text = "Status";
            // 
            // comboStatus
            // 
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "Planned",
            "Alive",
            "Death"});
            this.comboStatus.Location = new System.Drawing.Point(24, 597);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(208, 24);
            this.comboStatus.TabIndex = 20;
            // 
            // Percent
            // 
            this.Percent.AutoSize = true;
            this.Percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Percent.Location = new System.Drawing.Point(379, 564);
            this.Percent.Name = "Percent";
            this.Percent.Size = new System.Drawing.Size(140, 20);
            this.Percent.TabIndex = 22;
            this.Percent.Text = "Percent complete";
            // 
            // comboPercent
            // 
            this.comboPercent.FormattingEnabled = true;
            this.comboPercent.Items.AddRange(new object[] {
            "0%",
            "25%",
            "50%",
            "75%",
            "100%"});
            this.comboPercent.Location = new System.Drawing.Point(383, 597);
            this.comboPercent.Name = "comboPercent";
            this.comboPercent.Size = new System.Drawing.Size(208, 24);
            this.comboPercent.TabIndex = 23;
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(516, 693);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 33);
            this.butCancel.TabIndex = 24;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // ButSubmit
            // 
            this.ButSubmit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ButSubmit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButSubmit.Location = new System.Drawing.Point(597, 693);
            this.ButSubmit.Name = "ButSubmit";
            this.ButSubmit.Size = new System.Drawing.Size(75, 33);
            this.ButSubmit.TabIndex = 25;
            this.ButSubmit.Text = "Submit";
            this.ButSubmit.UseVisualStyleBackColor = false;
            this.ButSubmit.Click += new System.EventHandler(this.ButSubmit_Click);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(695, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = resources.GetString("label12.Text");
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1, 664);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(695, 16);
            this.label13.TabIndex = 27;
            this.label13.Text = resources.GetString("label13.Text");
            // 
            // SendEmail
            // 
            this.SendEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SendEmail.AutoSize = true;
            this.SendEmail.Location = new System.Drawing.Point(29, 641);
            this.SendEmail.Name = "SendEmail";
            this.SendEmail.Size = new System.Drawing.Size(262, 20);
            this.SendEmail.TabIndex = 28;
            this.SendEmail.Text = "Check here if you want to send an email";
            this.SendEmail.UseVisualStyleBackColor = true;
            // 
            // FormBoostrap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 738);
            this.Controls.Add(this.SendEmail);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ButSubmit);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.comboPercent);
            this.Controls.Add(this.Percent);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.comboStatus);
            this.Controls.Add(this.DurationInHours);
            this.Controls.Add(this.Duration);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.checkBoxDemo);
            this.Controls.Add(this.checkBoxPreprod);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Environment);
            this.Controls.Add(this.comboCriticity);
            this.Controls.Add(this.Criticity);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.ComboType);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.comboLocation);
            this.Controls.Add(this.checkBoxProd);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtTitle);
            this.Name = "FormBoostrap";
            this.Text = "FormBoostrap";
            this.Load += new System.EventHandler(this.FormBoostrap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DurationInHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.CheckBox checkBoxProd;
        private System.Windows.Forms.ComboBox comboLocation;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Location;
        private System.Windows.Forms.ComboBox ComboType;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label Criticity;
        private System.Windows.Forms.ComboBox comboCriticity;
        private System.Windows.Forms.Label Environment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxPreprod;
        private System.Windows.Forms.CheckBox checkBoxDemo;
        private System.Windows.Forms.Label StartDate;
        private System.Windows.Forms.Label Duration;
        private System.Windows.Forms.NumericUpDown DurationInHours;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.Label Percent;
        private System.Windows.Forms.ComboBox comboPercent;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button ButSubmit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox SendEmail;
    }
}