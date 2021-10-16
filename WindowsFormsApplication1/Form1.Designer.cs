namespace WindowsFormsApplication1
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
            this.coordinatesListBox = new System.Windows.Forms.ListBox();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.AddValueButton = new System.Windows.Forms.Button();
            this.DeleteValueButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.NavigateButton = new System.Windows.Forms.Button();
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // coordinatesListBox
            // 
            this.coordinatesListBox.FormattingEnabled = true;
            this.coordinatesListBox.Location = new System.Drawing.Point(36, 134);
            this.coordinatesListBox.Name = "coordinatesListBox";
            this.coordinatesListBox.Size = new System.Drawing.Size(263, 264);
            this.coordinatesListBox.TabIndex = 1;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(50, 44);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(228, 20);
            this.inputTextBox.TabIndex = 2;
            // 
            // AddValueButton
            // 
            this.AddValueButton.Location = new System.Drawing.Point(25, 85);
            this.AddValueButton.Name = "AddValueButton";
            this.AddValueButton.Size = new System.Drawing.Size(75, 23);
            this.AddValueButton.TabIndex = 3;
            this.AddValueButton.Text = "Ekle";
            this.AddValueButton.UseVisualStyleBackColor = true;
            this.AddValueButton.Click += new System.EventHandler(this.AddValueButton_Click);
            // 
            // DeleteValueButton
            // 
            this.DeleteValueButton.Location = new System.Drawing.Point(127, 85);
            this.DeleteValueButton.Name = "DeleteValueButton";
            this.DeleteValueButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteValueButton.TabIndex = 4;
            this.DeleteValueButton.Text = "Seçileni Sil";
            this.DeleteValueButton.UseVisualStyleBackColor = true;
            this.DeleteValueButton.Click += new System.EventHandler(this.DeleteValueButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(238, 85);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Temizle";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // NavigateButton
            // 
            this.NavigateButton.Location = new System.Drawing.Point(330, 238);
            this.NavigateButton.Name = "NavigateButton";
            this.NavigateButton.Size = new System.Drawing.Size(75, 23);
            this.NavigateButton.TabIndex = 6;
            this.NavigateButton.Text = "Hesapla";
            this.NavigateButton.UseVisualStyleBackColor = true;
            this.NavigateButton.Click += new System.EventHandler(this.NavigateButton_Click);
            // 
            // outputListBox
            // 
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.Location = new System.Drawing.Point(435, 134);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(169, 251);
            this.outputListBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "İnput değeri text alandan ekleyerek doldurunuz.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(330, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "*İlk satıra arada boşluk olacak şekilde sağ üst koordinat bilgisini giriniz ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(330, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "*Gezici konumunu arada boşluk olacak şekilde giriniz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(330, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "*Gezici talimalatlarını boşluksuz M,R,L harfleri ile giriniz.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 410);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputListBox);
            this.Controls.Add(this.NavigateButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DeleteValueButton);
            this.Controls.Add(this.AddValueButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.coordinatesListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox coordinatesListBox;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button AddValueButton;
        private System.Windows.Forms.Button DeleteValueButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button NavigateButton;
        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

