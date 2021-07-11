
namespace DataBaseManager
{
    partial class Form2
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
            this.dataBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.insertData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dataBox
            // 
            this.dataBox.FormattingEnabled = true;
            this.dataBox.ItemHeight = 20;
            this.dataBox.Location = new System.Drawing.Point(26, 43);
            this.dataBox.Name = "dataBox";
            this.dataBox.Size = new System.Drawing.Size(624, 244);
            this.dataBox.TabIndex = 0;
            this.dataBox.DoubleClick += new System.EventHandler(this.dataBox_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data";
            // 
            // insertData
            // 
            this.insertData.Location = new System.Drawing.Point(267, 315);
            this.insertData.Name = "insertData";
            this.insertData.Size = new System.Drawing.Size(167, 57);
            this.insertData.TabIndex = 2;
            this.insertData.Text = "Insert";
            this.insertData.UseVisualStyleBackColor = true;
            this.insertData.Click += new System.EventHandler(this.insertData_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.insertData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox dataBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button insertData;
    }
}