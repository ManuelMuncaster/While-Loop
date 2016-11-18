namespace While_Loop
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.enternumberLabel = new System.Windows.Forms.Label();
            this.endingnumberLabel = new System.Windows.Forms.Label();
            this.startingTextbox = new System.Windows.Forms.TextBox();
            this.endingTextbox = new System.Windows.Forms.TextBox();
            this.valueButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Prestige Elite Std", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(77, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(270, 31);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Fun with Loops!!";
            // 
            // enternumberLabel
            // 
            this.enternumberLabel.AutoSize = true;
            this.enternumberLabel.Font = new System.Drawing.Font("Tekton Pro Ext", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enternumberLabel.Location = new System.Drawing.Point(12, 54);
            this.enternumberLabel.Name = "enternumberLabel";
            this.enternumberLabel.Size = new System.Drawing.Size(287, 26);
            this.enternumberLabel.TabIndex = 1;
            this.enternumberLabel.Text = "Enter a starting number:";
            // 
            // endingnumberLabel
            // 
            this.endingnumberLabel.AutoSize = true;
            this.endingnumberLabel.Font = new System.Drawing.Font("Tekton Pro Ext", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endingnumberLabel.Location = new System.Drawing.Point(12, 92);
            this.endingnumberLabel.Name = "endingnumberLabel";
            this.endingnumberLabel.Size = new System.Drawing.Size(263, 26);
            this.endingnumberLabel.TabIndex = 2;
            this.endingnumberLabel.Text = "Enter a ending number:";
            // 
            // startingTextbox
            // 
            this.startingTextbox.Location = new System.Drawing.Point(306, 59);
            this.startingTextbox.Name = "startingTextbox";
            this.startingTextbox.Size = new System.Drawing.Size(100, 20);
            this.startingTextbox.TabIndex = 3;
            // 
            // endingTextbox
            // 
            this.endingTextbox.Location = new System.Drawing.Point(281, 98);
            this.endingTextbox.Name = "endingTextbox";
            this.endingTextbox.Size = new System.Drawing.Size(100, 20);
            this.endingTextbox.TabIndex = 4;
            // 
            // valueButton
            // 
            this.valueButton.Location = new System.Drawing.Point(297, 154);
            this.valueButton.Name = "valueButton";
            this.valueButton.Size = new System.Drawing.Size(84, 23);
            this.valueButton.TabIndex = 5;
            this.valueButton.Text = "Check Value!";
            this.valueButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valueButton);
            this.Controls.Add(this.endingTextbox);
            this.Controls.Add(this.startingTextbox);
            this.Controls.Add(this.endingnumberLabel);
            this.Controls.Add(this.enternumberLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label enternumberLabel;
        private System.Windows.Forms.Label endingnumberLabel;
        private System.Windows.Forms.TextBox startingTextbox;
        private System.Windows.Forms.TextBox endingTextbox;
        private System.Windows.Forms.Button valueButton;
        private System.Windows.Forms.Label label1;
    }
}

