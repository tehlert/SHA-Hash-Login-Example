
namespace HashingLoginExample
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
            this.textLabel = new System.Windows.Forms.Label();
            this.hashLabel = new System.Windows.Forms.Label();
            this.hashAlgorithmLabel = new System.Windows.Forms.Label();
            this.hashAlgorithmComboBox = new System.Windows.Forms.ComboBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.hashButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.originalTextBox = new System.Windows.Forms.RichTextBox();
            this.hashTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Location = new System.Drawing.Point(13, 13);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(52, 30);
            this.textLabel.TabIndex = 1;
            this.textLabel.Text = "Text:";
            // 
            // hashLabel
            // 
            this.hashLabel.AutoSize = true;
            this.hashLabel.Location = new System.Drawing.Point(13, 116);
            this.hashLabel.Name = "hashLabel";
            this.hashLabel.Size = new System.Drawing.Size(61, 30);
            this.hashLabel.TabIndex = 3;
            this.hashLabel.Text = "Hash:";
            // 
            // hashAlgorithmLabel
            // 
            this.hashAlgorithmLabel.AutoSize = true;
            this.hashAlgorithmLabel.Location = new System.Drawing.Point(13, 221);
            this.hashAlgorithmLabel.Name = "hashAlgorithmLabel";
            this.hashAlgorithmLabel.Size = new System.Drawing.Size(153, 30);
            this.hashAlgorithmLabel.TabIndex = 4;
            this.hashAlgorithmLabel.Text = "Hash Algorithm:";
            // 
            // hashAlgorithmComboBox
            // 
            this.hashAlgorithmComboBox.AllowDrop = true;
            this.hashAlgorithmComboBox.FormattingEnabled = true;
            this.hashAlgorithmComboBox.Location = new System.Drawing.Point(173, 221);
            this.hashAlgorithmComboBox.Name = "hashAlgorithmComboBox";
            this.hashAlgorithmComboBox.Size = new System.Drawing.Size(183, 38);
            this.hashAlgorithmComboBox.TabIndex = 5;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(362, 221);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(69, 30);
            this.statusLabel.TabIndex = 6;
            this.statusLabel.Text = "Status:";
            // 
            // hashButton
            // 
            this.hashButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.hashButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.hashButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hashButton.Location = new System.Drawing.Point(559, 216);
            this.hashButton.Name = "hashButton";
            this.hashButton.Size = new System.Drawing.Size(177, 41);
            this.hashButton.TabIndex = 7;
            this.hashButton.Text = "Calculate Hash";
            this.hashButton.UseVisualStyleBackColor = true;
            this.hashButton.Click += new System.EventHandler(this.hashButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.confirmButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.Location = new System.Drawing.Point(742, 216);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(114, 41);
            this.confirmButton.TabIndex = 8;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // originalTextBox
            // 
            this.originalTextBox.Location = new System.Drawing.Point(99, 13);
            this.originalTextBox.Name = "originalTextBox";
            this.originalTextBox.Size = new System.Drawing.Size(757, 97);
            this.originalTextBox.TabIndex = 9;
            this.originalTextBox.Text = "";
            // 
            // hashTextBox
            // 
            this.hashTextBox.Location = new System.Drawing.Point(99, 116);
            this.hashTextBox.Name = "hashTextBox";
            this.hashTextBox.Size = new System.Drawing.Size(757, 97);
            this.hashTextBox.TabIndex = 10;
            this.hashTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(868, 292);
            this.Controls.Add(this.hashTextBox);
            this.Controls.Add(this.originalTextBox);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.hashButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.hashAlgorithmComboBox);
            this.Controls.Add(this.hashAlgorithmLabel);
            this.Controls.Add(this.hashLabel);
            this.Controls.Add(this.textLabel);
            this.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "Form1";
            this.Text = "Hash Visualizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Label hashLabel;
        private System.Windows.Forms.Label hashAlgorithmLabel;
        private System.Windows.Forms.ComboBox hashAlgorithmComboBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button hashButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.RichTextBox originalTextBox;
        private System.Windows.Forms.RichTextBox hashTextBox;
    }
}

