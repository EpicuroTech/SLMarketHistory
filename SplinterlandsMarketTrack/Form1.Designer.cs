namespace SplinterlandsMarketTrack
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonRequest = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonPeek = new System.Windows.Forms.Button();
            this.statistics = new System.Windows.Forms.GroupBox();
            this.labelRentMonthUSD = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelRentMonthDEC = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.labelTest = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.buttonToSql = new System.Windows.Forms.Button();
            this.buttonSendToEmail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRequest
            // 
            this.buttonRequest.Image = ((System.Drawing.Image)(resources.GetObject("buttonRequest.Image")));
            this.buttonRequest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRequest.Location = new System.Drawing.Point(36, 292);
            this.buttonRequest.Name = "buttonRequest";
            this.buttonRequest.Size = new System.Drawing.Size(205, 61);
            this.buttonRequest.TabIndex = 0;
            this.buttonRequest.Text = "Request Data";
            this.buttonRequest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRequest.UseVisualStyleBackColor = true;
            this.buttonRequest.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(660, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 286);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // buttonPeek
            // 
            this.buttonPeek.Image = ((System.Drawing.Image)(resources.GetObject("buttonPeek.Image")));
            this.buttonPeek.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPeek.Location = new System.Drawing.Point(364, 292);
            this.buttonPeek.Name = "buttonPeek";
            this.buttonPeek.Size = new System.Drawing.Size(205, 61);
            this.buttonPeek.TabIndex = 4;
            this.buttonPeek.Text = "Peek Response";
            this.buttonPeek.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPeek.UseVisualStyleBackColor = true;
            this.buttonPeek.Click += new System.EventHandler(this.buttonPeek_Click);
            // 
            // statistics
            // 
            this.statistics.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("statistics.BackgroundImage")));
            this.statistics.Controls.Add(this.labelRentMonthUSD);
            this.statistics.Controls.Add(this.label2);
            this.statistics.Controls.Add(this.labelRentMonthDEC);
            this.statistics.Controls.Add(this.label);
            this.statistics.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statistics.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.statistics.Location = new System.Drawing.Point(606, 292);
            this.statistics.Name = "statistics";
            this.statistics.Size = new System.Drawing.Size(1262, 704);
            this.statistics.TabIndex = 5;
            this.statistics.TabStop = false;
            this.statistics.Text = "Statistics";
            // 
            // labelRentMonthUSD
            // 
            this.labelRentMonthUSD.AutoSize = true;
            this.labelRentMonthUSD.BackColor = System.Drawing.Color.Transparent;
            this.labelRentMonthUSD.Font = new System.Drawing.Font("Showcard Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRentMonthUSD.Location = new System.Drawing.Point(472, 113);
            this.labelRentMonthUSD.Name = "labelRentMonthUSD";
            this.labelRentMonthUSD.Size = new System.Drawing.Size(70, 28);
            this.labelRentMonthUSD.TabIndex = 3;
            this.labelRentMonthUSD.Text = "WAIT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Amount in Usd/Month:";
            // 
            // labelRentMonthDEC
            // 
            this.labelRentMonthDEC.AutoSize = true;
            this.labelRentMonthDEC.BackColor = System.Drawing.Color.Transparent;
            this.labelRentMonthDEC.Location = new System.Drawing.Point(472, 61);
            this.labelRentMonthDEC.Name = "labelRentMonthDEC";
            this.labelRentMonthDEC.Size = new System.Drawing.Size(90, 35);
            this.labelRentMonthDEC.TabIndex = 1;
            this.labelRentMonthDEC.Text = "WAIT";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Location = new System.Drawing.Point(7, 61);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(442, 35);
            this.label.TabIndex = 0;
            this.label.Text = "Total Amount in Dec/Month:";
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTest.Location = new System.Drawing.Point(32, 33);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(9, 20);
            this.labelTest.TabIndex = 6;
            this.labelTest.Text = "\r\n";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(36, 169);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(205, 35);
            this.textBoxUsername.TabIndex = 7;
            this.textBoxUsername.Text = "epicurotech";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelUsername.Location = new System.Drawing.Point(31, 133);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(130, 29);
            this.labelUsername.TabIndex = 8;
            this.labelUsername.Text = "Username:";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelVersion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelVersion.Location = new System.Drawing.Point(1759, 33);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(110, 40);
            this.labelVersion.TabIndex = 4;
            this.labelVersion.Text = "Version: x.xx\r\n  @CarlosDias";
            // 
            // buttonToSql
            // 
            this.buttonToSql.Image = ((System.Drawing.Image)(resources.GetObject("buttonToSql.Image")));
            this.buttonToSql.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonToSql.Location = new System.Drawing.Point(36, 935);
            this.buttonToSql.Name = "buttonToSql";
            this.buttonToSql.Size = new System.Drawing.Size(205, 61);
            this.buttonToSql.TabIndex = 9;
            this.buttonToSql.Text = "Save to Sql";
            this.buttonToSql.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonToSql.UseVisualStyleBackColor = true;
            this.buttonToSql.Click += new System.EventHandler(this.buttonToSql_Click);
            // 
            // buttonSendToEmail
            // 
            this.buttonSendToEmail.Image = ((System.Drawing.Image)(resources.GetObject("buttonSendToEmail.Image")));
            this.buttonSendToEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSendToEmail.Location = new System.Drawing.Point(364, 935);
            this.buttonSendToEmail.Name = "buttonSendToEmail";
            this.buttonSendToEmail.Size = new System.Drawing.Size(205, 61);
            this.buttonSendToEmail.TabIndex = 10;
            this.buttonSendToEmail.Text = "Send To Email";
            this.buttonSendToEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSendToEmail.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.buttonSendToEmail);
            this.Controls.Add(this.buttonToSql);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.statistics);
            this.Controls.Add(this.buttonPeek);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonRequest);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MarketPlace Account Report";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statistics.ResumeLayout(false);
            this.statistics.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRequest;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonPeek;
        private System.Windows.Forms.GroupBox statistics;
        private System.Windows.Forms.Label labelTest;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelRentMonthDEC;
        private System.Windows.Forms.Label labelRentMonthUSD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Button buttonToSql;
        private System.Windows.Forms.Button buttonSendToEmail;
    }
}

