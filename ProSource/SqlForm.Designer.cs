namespace ProSource
{
    partial class SqlForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DefaulrRdo = new System.Windows.Forms.RadioButton();
            this.CustomRdo = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.DetailsGrp = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tb2 = new System.Windows.Forms.RichTextBox();
            this.Tb3 = new System.Windows.Forms.RichTextBox();
            this.Tb1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.DetailsGrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CustomRdo);
            this.groupBox1.Controls.Add(this.DefaulrRdo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 85);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // DefaulrRdo
            // 
            this.DefaulrRdo.AutoSize = true;
            this.DefaulrRdo.Checked = true;
            this.DefaulrRdo.Location = new System.Drawing.Point(6, 34);
            this.DefaulrRdo.Name = "DefaulrRdo";
            this.DefaulrRdo.Size = new System.Drawing.Size(86, 24);
            this.DefaulrRdo.TabIndex = 0;
            this.DefaulrRdo.TabStop = true;
            this.DefaulrRdo.Text = "Default";
            this.DefaulrRdo.UseVisualStyleBackColor = true;
            // 
            // CustomRdo
            // 
            this.CustomRdo.AutoSize = true;
            this.CustomRdo.Location = new System.Drawing.Point(183, 34);
            this.CustomRdo.Name = "CustomRdo";
            this.CustomRdo.Size = new System.Drawing.Size(89, 24);
            this.CustomRdo.TabIndex = 0;
            this.CustomRdo.Text = "Custom";
            this.CustomRdo.UseVisualStyleBackColor = true;
            this.CustomRdo.CheckedChanged += new System.EventHandler(this.CustomRdo_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Import";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DetailsGrp
            // 
            this.DetailsGrp.Controls.Add(this.label2);
            this.DetailsGrp.Controls.Add(this.label3);
            this.DetailsGrp.Controls.Add(this.label1);
            this.DetailsGrp.Controls.Add(this.Tb2);
            this.DetailsGrp.Controls.Add(this.Tb3);
            this.DetailsGrp.Controls.Add(this.Tb1);
            this.DetailsGrp.Location = new System.Drawing.Point(12, 96);
            this.DetailsGrp.Name = "DetailsGrp";
            this.DetailsGrp.Size = new System.Drawing.Size(294, 273);
            this.DetailsGrp.TabIndex = 4;
            this.DetailsGrp.TabStop = false;
            this.DetailsGrp.Text = "Details";
            this.DetailsGrp.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "DatabaseName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "TableName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Server Instance";
            // 
            // Tb2
            // 
            this.Tb2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tb2.Location = new System.Drawing.Point(5, 115);
            this.Tb2.Name = "Tb2";
            this.Tb2.Size = new System.Drawing.Size(246, 46);
            this.Tb2.TabIndex = 3;
            this.Tb2.Text = "";
            // 
            // Tb3
            // 
            this.Tb3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tb3.Location = new System.Drawing.Point(1, 197);
            this.Tb3.Name = "Tb3";
            this.Tb3.Size = new System.Drawing.Size(246, 46);
            this.Tb3.TabIndex = 4;
            this.Tb3.Text = "";
            // 
            // Tb1
            // 
            this.Tb1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tb1.Location = new System.Drawing.Point(5, 43);
            this.Tb1.Name = "Tb1";
            this.Tb1.Size = new System.Drawing.Size(246, 46);
            this.Tb1.TabIndex = 5;
            this.Tb1.Text = "";
            // 
            // SqlForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 417);
            this.Controls.Add(this.DetailsGrp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "SqlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SqlForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.DetailsGrp.ResumeLayout(false);
            this.DetailsGrp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton CustomRdo;
        private System.Windows.Forms.RadioButton DefaulrRdo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox DetailsGrp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.RichTextBox Tb2;
        public System.Windows.Forms.RichTextBox Tb3;
        public System.Windows.Forms.RichTextBox Tb1;
    }
}