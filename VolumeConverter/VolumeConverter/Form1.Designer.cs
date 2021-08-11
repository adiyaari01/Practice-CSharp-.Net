
namespace VolumeConverter
{
    partial class volumeConverter
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
            this.converButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.clTextBox = new System.Windows.Forms.TextBox();
            this.litreTextBox = new System.Windows.Forms.TextBox();
            this.clLabel = new System.Windows.Forms.Label();
            this.litreLabel = new System.Windows.Forms.Label();
            this.ConvertCLTitelLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // converButton
            // 
            this.converButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.converButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.converButton.ForeColor = System.Drawing.Color.Cornsilk;
            this.converButton.Location = new System.Drawing.Point(186, 327);
            this.converButton.Name = "converButton";
            this.converButton.Size = new System.Drawing.Size(161, 60);
            this.converButton.TabIndex = 0;
            this.converButton.Text = "Convert";
            this.converButton.UseVisualStyleBackColor = false;
            this.converButton.Click += new System.EventHandler(this.converButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.clearButton.Location = new System.Drawing.Point(353, 327);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(153, 60);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // clTextBox
            // 
            this.clTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.clTextBox.Location = new System.Drawing.Point(186, 129);
            this.clTextBox.Multiline = true;
            this.clTextBox.Name = "clTextBox";
            this.clTextBox.Size = new System.Drawing.Size(169, 48);
            this.clTextBox.TabIndex = 2;
            this.clTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // litreTextBox
            // 
            this.litreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.litreTextBox.Location = new System.Drawing.Point(186, 207);
            this.litreTextBox.Multiline = true;
            this.litreTextBox.Name = "litreTextBox";
            this.litreTextBox.Size = new System.Drawing.Size(169, 50);
            this.litreTextBox.TabIndex = 3;
            this.litreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clLabel
            // 
            this.clLabel.AutoSize = true;
            this.clLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.clLabel.Location = new System.Drawing.Point(393, 129);
            this.clLabel.Name = "clLabel";
            this.clLabel.Size = new System.Drawing.Size(55, 36);
            this.clLabel.TabIndex = 4;
            this.clLabel.Text = "CL";
            // 
            // litreLabel
            // 
            this.litreLabel.AutoSize = true;
            this.litreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.litreLabel.Location = new System.Drawing.Point(393, 226);
            this.litreLabel.Name = "litreLabel";
            this.litreLabel.Size = new System.Drawing.Size(78, 36);
            this.litreLabel.TabIndex = 5;
            this.litreLabel.Text = "Litre";
            // 
            // ConvertCLTitelLabel
            // 
            this.ConvertCLTitelLabel.AutoSize = true;
            this.ConvertCLTitelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ConvertCLTitelLabel.ForeColor = System.Drawing.Color.Black;
            this.ConvertCLTitelLabel.Location = new System.Drawing.Point(120, 28);
            this.ConvertCLTitelLabel.Name = "ConvertCLTitelLabel";
            this.ConvertCLTitelLabel.Size = new System.Drawing.Size(548, 69);
            this.ConvertCLTitelLabel.TabIndex = 6;
            this.ConvertCLTitelLabel.Text = "Convert CL to Litre";
            // 
            // volumeConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ConvertCLTitelLabel);
            this.Controls.Add(this.litreLabel);
            this.Controls.Add(this.clLabel);
            this.Controls.Add(this.litreTextBox);
            this.Controls.Add(this.clTextBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.converButton);
            this.MaximizeBox = false;
            this.Name = "volumeConverter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Volume Converter CL to Litre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button converButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox clTextBox;
        private System.Windows.Forms.TextBox litreTextBox;
        private System.Windows.Forms.Label clLabel;
        private System.Windows.Forms.Label litreLabel;
        private System.Windows.Forms.Label ConvertCLTitelLabel;
    }
}

