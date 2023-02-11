namespace ProSource
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
            this.Tb = new System.Windows.Forms.RichTextBox();
            this.Search = new System.Windows.Forms.Button();
            this.Grp1 = new System.Windows.Forms.GroupBox();
            this.FromDocRdo = new System.Windows.Forms.RadioButton();
            this.TextBoxRdo = new System.Windows.Forms.RadioButton();
            this.SqlRdo = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PathCbox = new System.Windows.Forms.CheckBox();
            this.SqlExportRdo = new System.Windows.Forms.RadioButton();
            this.ExcellExportRdo = new System.Windows.Forms.RadioButton();
            this.TextFileRdo = new System.Windows.Forms.RadioButton();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Grp1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tb
            // 
            this.Tb.Location = new System.Drawing.Point(8, 3);
            this.Tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Tb.Name = "Tb";
            this.Tb.Size = new System.Drawing.Size(383, 382);
            this.Tb.TabIndex = 0;
            this.Tb.Text = "";
            this.Tb.TextChanged += new System.EventHandler(this.Tb_TextChanged);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(411, 135);
            this.Search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(121, 25);
            this.Search.TabIndex = 2;
            this.Search.Text = "Search Addresses";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.button2_Click);
            // 
            // Grp1
            // 
            this.Grp1.Controls.Add(this.FromDocRdo);
            this.Grp1.Controls.Add(this.TextBoxRdo);
            this.Grp1.Controls.Add(this.SqlRdo);
            this.Grp1.Location = new System.Drawing.Point(411, 3);
            this.Grp1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Grp1.Name = "Grp1";
            this.Grp1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Grp1.Size = new System.Drawing.Size(121, 128);
            this.Grp1.TabIndex = 3;
            this.Grp1.TabStop = false;
            this.Grp1.Text = "DataSource";
            // 
            // FromDocRdo
            // 
            this.FromDocRdo.AutoSize = true;
            this.FromDocRdo.Location = new System.Drawing.Point(5, 109);
            this.FromDocRdo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FromDocRdo.Name = "FromDocRdo";
            this.FromDocRdo.Size = new System.Drawing.Size(100, 17);
            this.FromDocRdo.TabIndex = 2;
            this.FromDocRdo.TabStop = true;
            this.FromDocRdo.Text = "From Document";
            this.FromDocRdo.UseVisualStyleBackColor = true;
            this.FromDocRdo.CheckedChanged += new System.EventHandler(this.FromDocRdo_CheckedChanged);
            // 
            // TextBoxRdo
            // 
            this.TextBoxRdo.AutoSize = true;
            this.TextBoxRdo.Checked = true;
            this.TextBoxRdo.Location = new System.Drawing.Point(5, 64);
            this.TextBoxRdo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBoxRdo.Name = "TextBoxRdo";
            this.TextBoxRdo.Size = new System.Drawing.Size(64, 17);
            this.TextBoxRdo.TabIndex = 1;
            this.TextBoxRdo.TabStop = true;
            this.TextBoxRdo.Text = "TextBox";
            this.TextBoxRdo.UseVisualStyleBackColor = true;
            // 
            // SqlRdo
            // 
            this.SqlRdo.AutoSize = true;
            this.SqlRdo.Location = new System.Drawing.Point(5, 17);
            this.SqlRdo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SqlRdo.Name = "SqlRdo";
            this.SqlRdo.Size = new System.Drawing.Size(57, 17);
            this.SqlRdo.TabIndex = 0;
            this.SqlRdo.Text = "Sql Db";
            this.SqlRdo.UseVisualStyleBackColor = true;
            this.SqlRdo.CheckedChanged += new System.EventHandler(this.SqlRdo_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(403, 382);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Clear Text Box";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PathCbox);
            this.groupBox1.Controls.Add(this.SqlExportRdo);
            this.groupBox1.Controls.Add(this.ExcellExportRdo);
            this.groupBox1.Controls.Add(this.TextFileRdo);
            this.groupBox1.Location = new System.Drawing.Point(403, 272);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(141, 94);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Export To:";
            // 
            // PathCbox
            // 
            this.PathCbox.AutoSize = true;
            this.PathCbox.Location = new System.Drawing.Point(70, 16);
            this.PathCbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PathCbox.Name = "PathCbox";
            this.PathCbox.Size = new System.Drawing.Size(73, 17);
            this.PathCbox.TabIndex = 6;
            this.PathCbox.Text = "New Path";
            this.PathCbox.UseVisualStyleBackColor = true;
            this.PathCbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // SqlExportRdo
            // 
            this.SqlExportRdo.AutoSize = true;
            this.SqlExportRdo.Location = new System.Drawing.Point(5, 39);
            this.SqlExportRdo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SqlExportRdo.Name = "SqlExportRdo";
            this.SqlExportRdo.Size = new System.Drawing.Size(40, 17);
            this.SqlExportRdo.TabIndex = 1;
            this.SqlExportRdo.Text = "Sql";
            this.SqlExportRdo.UseVisualStyleBackColor = true;
            // 
            // ExcellExportRdo
            // 
            this.ExcellExportRdo.AutoSize = true;
            this.ExcellExportRdo.Location = new System.Drawing.Point(5, 64);
            this.ExcellExportRdo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExcellExportRdo.Name = "ExcellExportRdo";
            this.ExcellExportRdo.Size = new System.Drawing.Size(53, 17);
            this.ExcellExportRdo.TabIndex = 1;
            this.ExcellExportRdo.Text = "Excell";
            this.ExcellExportRdo.UseVisualStyleBackColor = true;
            // 
            // TextFileRdo
            // 
            this.TextFileRdo.AutoSize = true;
            this.TextFileRdo.Checked = true;
            this.TextFileRdo.Location = new System.Drawing.Point(5, 17);
            this.TextFileRdo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextFileRdo.Name = "TextFileRdo";
            this.TextFileRdo.Size = new System.Drawing.Size(65, 17);
            this.TextFileRdo.TabIndex = 0;
            this.TextFileRdo.TabStop = true;
            this.TextFileRdo.Text = "Text File";
            this.TextFileRdo.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Image = global::ProSource.Properties.Resources.NewI;
            this.button5.Location = new System.Drawing.Point(475, 182);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(51, 81);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::ProSource.Properties.Resources.index;
            this.button2.Location = new System.Drawing.Point(413, 182);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 81);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 441);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Grp1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Tb);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Grp1.ResumeLayout(false);
            this.Grp1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Tb;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.GroupBox Grp1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.RadioButton TextBoxRdo;
        public System.Windows.Forms.RadioButton SqlRdo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        public System.Windows.Forms.RadioButton FromDocRdo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox PathCbox;
        public System.Windows.Forms.RadioButton SqlExportRdo;
        public System.Windows.Forms.RadioButton ExcellExportRdo;
        public System.Windows.Forms.RadioButton TextFileRdo;
    }
}

