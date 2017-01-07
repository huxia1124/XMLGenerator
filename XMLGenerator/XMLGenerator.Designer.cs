namespace XMLGenerator
{
    partial class XMLGenerator
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
            this.button1 = new System.Windows.Forms.Button();
            this.txData = new System.Windows.Forms.TextBox();
            this.txTemplate = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txStart = new System.Windows.Forms.TextBox();
            this.txEnd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txOutDir = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(549, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txData
            // 
            this.txData.Location = new System.Drawing.Point(12, 44);
            this.txData.Name = "txData";
            this.txData.Size = new System.Drawing.Size(531, 20);
            this.txData.TabIndex = 1;
            this.txData.Text = "K:\\1.xlsx";
            // 
            // txTemplate
            // 
            this.txTemplate.Location = new System.Drawing.Point(12, 145);
            this.txTemplate.Name = "txTemplate";
            this.txTemplate.Size = new System.Drawing.Size(531, 20);
            this.txTemplate.TabIndex = 3;
            this.txTemplate.Text = "K:\\1.xml";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(549, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start";
            // 
            // txStart
            // 
            this.txStart.Location = new System.Drawing.Point(117, 79);
            this.txStart.Name = "txStart";
            this.txStart.Size = new System.Drawing.Size(100, 20);
            this.txStart.TabIndex = 5;
            this.txStart.Text = "A1";
            // 
            // txEnd
            // 
            this.txEnd.Location = new System.Drawing.Point(255, 79);
            this.txEnd.Name = "txEnd";
            this.txEnd.Size = new System.Drawing.Size(100, 20);
            this.txEnd.TabIndex = 7;
            this.txEnd.Text = "AL100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "End";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "XML Template";
            // 
            // txOutDir
            // 
            this.txOutDir.Location = new System.Drawing.Point(12, 224);
            this.txOutDir.Name = "txOutDir";
            this.txOutDir.Size = new System.Drawing.Size(531, 20);
            this.txOutDir.TabIndex = 9;
            this.txOutDir.Text = "K:\\out1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Output Directory";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(549, 222);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Browse";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(544, 278);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(80, 50);
            this.btnGenerate.TabIndex = 12;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Range";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Data Source";
            // 
            // lbStatus
            // 
            this.lbStatus.Location = new System.Drawing.Point(12, 315);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(526, 16);
            this.lbStatus.TabIndex = 15;
            // 
            // XMLGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 340);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txOutDir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txEnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txTemplate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txData);
            this.Controls.Add(this.button1);
            this.Name = "XMLGenerator";
            this.Text = "XMLGenerator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txData;
        private System.Windows.Forms.TextBox txTemplate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txStart;
        private System.Windows.Forms.TextBox txEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txOutDir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbStatus;
    }
}

