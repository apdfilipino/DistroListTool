namespace DistroListTool
{
    partial class ConfigureForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.configureTextBox = new System.Windows.Forms.TextBox();
            this.isLocalCheckBox = new System.Windows.Forms.CheckBox();
            this.configureButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path";
            // 
            // configureTextBox
            // 
            this.configureTextBox.Location = new System.Drawing.Point(54, 22);
            this.configureTextBox.Name = "configureTextBox";
            this.configureTextBox.Size = new System.Drawing.Size(243, 20);
            this.configureTextBox.TabIndex = 1;
            // 
            // isLocalCheckBox
            // 
            this.isLocalCheckBox.AutoSize = true;
            this.isLocalCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.isLocalCheckBox.Location = new System.Drawing.Point(12, 60);
            this.isLocalCheckBox.Name = "isLocalCheckBox";
            this.isLocalCheckBox.Size = new System.Drawing.Size(71, 17);
            this.isLocalCheckBox.TabIndex = 3;
            this.isLocalCheckBox.Text = "Local File";
            this.isLocalCheckBox.UseVisualStyleBackColor = true;
            // 
            // configureButton
            // 
            this.configureButton.Location = new System.Drawing.Point(222, 60);
            this.configureButton.Name = "configureButton";
            this.configureButton.Size = new System.Drawing.Size(75, 23);
            this.configureButton.TabIndex = 4;
            this.configureButton.Text = "Configure";
            this.configureButton.UseVisualStyleBackColor = true;
            this.configureButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConfigureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 104);
            this.Controls.Add(this.configureButton);
            this.Controls.Add(this.isLocalCheckBox);
            this.Controls.Add(this.configureTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConfigureForm";
            this.Text = "DL Tool - Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox configureTextBox;
        private System.Windows.Forms.CheckBox isLocalCheckBox;
        private System.Windows.Forms.Button configureButton;
    }
}