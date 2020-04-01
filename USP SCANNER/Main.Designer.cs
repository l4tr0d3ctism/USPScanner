namespace USP_SCANNER
{
    partial class USPScanfrm
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
            this.BtnScan = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SVCName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSVCPatch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSVCstmode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmACL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSVCVul = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmversion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.POCRep = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnScan
            // 
            this.BtnScan.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnScan.Location = new System.Drawing.Point(7, 342);
            this.BtnScan.Name = "BtnScan";
            this.BtnScan.Size = new System.Drawing.Size(94, 34);
            this.BtnScan.TabIndex = 0;
            this.BtnScan.Text = "Scan";
            this.BtnScan.UseVisualStyleBackColor = true;
            this.BtnScan.Click += new System.EventHandler(this.BtnScan_Click);
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SVCName,
            this.clmSVCPatch,
            this.clmSVCstmode,
            this.clmACL,
            this.clmSVCVul,
            this.clmversion});
            this.listView1.Location = new System.Drawing.Point(7, 133);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(816, 199);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // SVCName
            // 
            this.SVCName.Text = "Name";
            this.SVCName.Width = 120;
            // 
            // clmSVCPatch
            // 
            this.clmSVCPatch.Text = "Path Name";
            this.clmSVCPatch.Width = 270;
            // 
            // clmSVCstmode
            // 
            this.clmSVCstmode.Text = "Startup Mode";
            // 
            // clmACL
            // 
            this.clmACL.Text = "Write Permation";
            this.clmACL.Width = 89;
            // 
            // clmSVCVul
            // 
            this.clmSVCVul.Text = "Vulnerable";
            this.clmSVCVul.Width = 81;
            // 
            // clmversion
            // 
            this.clmversion.Text = "Version";
            this.clmversion.Width = 106;
            // 
            // POCRep
            // 
            this.POCRep.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.POCRep.Enabled = false;
            this.POCRep.Location = new System.Drawing.Point(107, 342);
            this.POCRep.Name = "POCRep";
            this.POCRep.Size = new System.Drawing.Size(159, 34);
            this.POCRep.TabIndex = 7;
            this.POCRep.Text = "Create POC Report";
            this.POCRep.UseVisualStyleBackColor = true;
            this.POCRep.Click += new System.EventHandler(this.POCRep_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox2.Location = new System.Drawing.Point(-15, -6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(612, 126);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::USP_SCANNER.Properties.Resources.sec;
            this.pictureBox1.Location = new System.Drawing.Point(703, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Marlett", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Unquoted Service Path Vulnerability Scanner";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(14, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Author : Moslem Haghighian";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(14, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Twitter: ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.linkLabel1.Location = new System.Drawing.Point(68, 71);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(198, 17);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://twitter.com/l4tr0d3ctism";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Font = new System.Drawing.Font("Marlett", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(415, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "And Patcher";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(272, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 34);
            this.button1.TabIndex = 16;
            this.button1.Text = "Patch it";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // USPScanfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 390);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.POCRep);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.BtnScan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "USPScanfrm";
            this.ShowIcon = false;
            this.Text = "USP Scanner";
            this.Load += new System.EventHandler(this.USPScanfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnScan;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader SVCName;
        private System.Windows.Forms.ColumnHeader clmSVCPatch;
        private System.Windows.Forms.ColumnHeader clmSVCstmode;
        private System.Windows.Forms.ColumnHeader clmSVCVul;
        private System.Windows.Forms.Button POCRep;
        private System.Windows.Forms.ColumnHeader clmACL;
        private System.Windows.Forms.ColumnHeader clmversion;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

