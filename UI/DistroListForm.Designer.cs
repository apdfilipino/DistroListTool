namespace DistroListTool
{
    partial class DistroListForm
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
            this.distroListComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.templatesComboBox = new System.Windows.Forms.ComboBox();
            this.openButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Distro List";
            // 
            // distroListComboBox
            // 
            this.distroListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.distroListComboBox.FormattingEnabled = true;
            this.distroListComboBox.Location = new System.Drawing.Point(70, 12);
            this.distroListComboBox.Name = "distroListComboBox";
            this.distroListComboBox.Size = new System.Drawing.Size(367, 21);
            this.distroListComboBox.TabIndex = 1;
            this.distroListComboBox.SelectedIndexChanged += new System.EventHandler(this.distroListComboBox_SelectedIndexChanged);
            this.distroListComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.On_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Templates";
            // 
            // templatesComboBox
            // 
            this.templatesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.templatesComboBox.FormattingEnabled = true;
            this.templatesComboBox.Location = new System.Drawing.Point(70, 49);
            this.templatesComboBox.Name = "templatesComboBox";
            this.templatesComboBox.Size = new System.Drawing.Size(367, 21);
            this.templatesComboBox.TabIndex = 3;
            this.templatesComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.On_KeyUp);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(191, 87);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 4;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            this.openButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.On_KeyUp);
            // 
            // DistroListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 128);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.templatesComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.distroListComboBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DistroListForm";
            this.Text = "DL Tool";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.On_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox distroListComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox templatesComboBox;
        private System.Windows.Forms.Button openButton;
    }
}