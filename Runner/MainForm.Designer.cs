
namespace Runner
{
    partial class MainForm
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FindMissing_BTN = new System.Windows.Forms.Button();
            this.RemoveDuplicate_BTN = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(12, 12);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(695, 82);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.Text = "Please Enter Your Input Here !";
            this.inputTextBox.Enter += new System.EventHandler(this.inputTextBox_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(539, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "For Finding Duplicates in array : Please enter a string which is seperated by Com" +
    "ma ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Examples: 1,2,2,3,4  | a,b,b,c | aa,b,aa,c";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(572, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "For Finding missing number in array : Please enter a string which is seperated by" +
    " Comma ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Examples: 1,2,3,4,6";
            // 
            // FindMissing_BTN
            // 
            this.FindMissing_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindMissing_BTN.Location = new System.Drawing.Point(27, 236);
            this.FindMissing_BTN.Name = "FindMissing_BTN";
            this.FindMissing_BTN.Size = new System.Drawing.Size(239, 77);
            this.FindMissing_BTN.TabIndex = 5;
            this.FindMissing_BTN.Text = "Find Missing Number in Array";
            this.FindMissing_BTN.UseVisualStyleBackColor = true;
            this.FindMissing_BTN.Click += new System.EventHandler(this.FindMissing_BTN_Click);
            // 
            // RemoveDuplicate_BTN
            // 
            this.RemoveDuplicate_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.RemoveDuplicate_BTN.Location = new System.Drawing.Point(471, 236);
            this.RemoveDuplicate_BTN.Name = "RemoveDuplicate_BTN";
            this.RemoveDuplicate_BTN.Size = new System.Drawing.Size(236, 77);
            this.RemoveDuplicate_BTN.TabIndex = 6;
            this.RemoveDuplicate_BTN.Text = "Remove Duplicates From an Array";
            this.RemoveDuplicate_BTN.UseVisualStyleBackColor = true;
            this.RemoveDuplicate_BTN.Click += new System.EventHandler(this.RemoveDuplicate_BTN_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(24, 339);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 17);
            this.resultLabel.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.RemoveDuplicate_BTN);
            this.Controls.Add(this.FindMissing_BTN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputTextBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button FindMissing_BTN;
        private System.Windows.Forms.Button RemoveDuplicate_BTN;
        private System.Windows.Forms.Label resultLabel;
    }
}

