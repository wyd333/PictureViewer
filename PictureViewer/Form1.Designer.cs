namespace PictureViewer
{
    partial class Form
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.StrechCheckBox = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.BackgroundButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ShowButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel.Controls.Add(this.PictureBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.StrechCheckBox, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.flowLayoutPanel, 1, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(785, 619);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // PictureBox
            // 
            this.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel.SetColumnSpan(this.PictureBox, 2);
            this.PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox.Location = new System.Drawing.Point(3, 3);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(779, 551);
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // StrechCheckBox
            // 
            this.StrechCheckBox.AutoSize = true;
            this.StrechCheckBox.Location = new System.Drawing.Point(3, 560);
            this.StrechCheckBox.Name = "StrechCheckBox";
            this.StrechCheckBox.Size = new System.Drawing.Size(88, 22);
            this.StrechCheckBox.TabIndex = 1;
            this.StrechCheckBox.Text = "Strech";
            this.StrechCheckBox.UseVisualStyleBackColor = true;
            this.StrechCheckBox.CheckedChanged += new System.EventHandler(this.StrechCheckBox_CheckedChanged);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Controls.Add(this.ShowButton);
            this.flowLayoutPanel.Controls.Add(this.ClearButton);
            this.flowLayoutPanel.Controls.Add(this.BackgroundButton);
            this.flowLayoutPanel.Controls.Add(this.CloseButton);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel.Location = new System.Drawing.Point(120, 560);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(662, 56);
            this.flowLayoutPanel.TabIndex = 2;
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Location = new System.Drawing.Point(17, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 28);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // BackgroundButton
            // 
            this.BackgroundButton.AutoSize = true;
            this.BackgroundButton.Location = new System.Drawing.Point(98, 3);
            this.BackgroundButton.Name = "BackgroundButton";
            this.BackgroundButton.Size = new System.Drawing.Size(234, 28);
            this.BackgroundButton.TabIndex = 1;
            this.BackgroundButton.Text = "Set the background color";
            this.BackgroundButton.UseVisualStyleBackColor = true;
            this.BackgroundButton.Click += new System.EventHandler(this.BackgroundButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.AutoSize = true;
            this.ClearButton.Location = new System.Drawing.Point(338, 3);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(171, 28);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.Text = "Clear the picture";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ShowButton
            // 
            this.ShowButton.AutoSize = true;
            this.ShowButton.Location = new System.Drawing.Point(515, 3);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(144, 28);
            this.ShowButton.TabIndex = 3;
            this.ShowButton.Text = "Show a picture";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            this.openFileDialog.Title = "Choose a picture file";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(785, 619);
            this.Controls.Add(this.tableLayoutPanel);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Form";
            this.Text = "Picture Viewer";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.flowLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.CheckBox StrechCheckBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button BackgroundButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

