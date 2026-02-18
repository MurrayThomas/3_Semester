
namespace AsyncGuiSimple {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            btnSync = new Button();
            btnAsync = new Button();
            btnIncrement = new Button();
            lblIncrement = new Label();
            lblBtnWasPressed = new Label();
            lblReady = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSync
            // 
            btnSync.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSync.Location = new Point(38, 37);
            btnSync.Name = "btnSync";
            btnSync.Size = new Size(123, 38);
            btnSync.TabIndex = 0;
            btnSync.Text = "Blocking";
            btnSync.UseVisualStyleBackColor = true;
            btnSync.Click += BtnSync_Click;
            // 
            // btnAsync
            // 
            btnAsync.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAsync.Location = new Point(38, 119);
            btnAsync.Name = "btnAsync";
            btnAsync.Size = new Size(123, 38);
            btnAsync.TabIndex = 1;
            btnAsync.Text = "Non-blocking";
            btnAsync.UseVisualStyleBackColor = true;
            btnAsync.Click += BtnAsync_Click;
            // 
            // btnIncrement
            // 
            btnIncrement.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnIncrement.Location = new Point(254, 81);
            btnIncrement.Name = "btnIncrement";
            btnIncrement.Size = new Size(123, 38);
            btnIncrement.TabIndex = 2;
            btnIncrement.Text = "Just add 1";
            btnIncrement.UseVisualStyleBackColor = true;
            btnIncrement.Click += BtnIncrement_Click;
            // 
            // lblIncrement
            // 
            lblIncrement.AutoSize = true;
            lblIncrement.Location = new Point(358, 137);
            lblIncrement.Name = "lblIncrement";
            lblIncrement.Size = new Size(15, 20);
            lblIncrement.TabIndex = 3;
            lblIncrement.Text = "..";
            lblIncrement.TextAlign = ContentAlignment.TopRight;
            // 
            // lblBtnWasPressed
            // 
            lblBtnWasPressed.AutoSize = true;
            lblBtnWasPressed.Location = new Point(38, 200);
            lblBtnWasPressed.Name = "lblBtnWasPressed";
            lblBtnWasPressed.Size = new Size(15, 20);
            lblBtnWasPressed.TabIndex = 4;
            lblBtnWasPressed.Text = "..";
            // 
            // lblReady
            // 
            lblReady.AutoSize = true;
            lblReady.Location = new Point(38, 242);
            lblReady.Name = "lblReady";
            lblReady.Size = new Size(15, 20);
            lblReady.TabIndex = 5;
            lblReady.Text = "..";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(298, 237);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 334);
            Controls.Add(pictureBox1);
            Controls.Add(lblReady);
            Controls.Add(lblBtnWasPressed);
            Controls.Add(lblIncrement);
            Controls.Add(btnIncrement);
            Controls.Add(btnAsync);
            Controls.Add(btnSync);
            Name = "Form1";
            Text = "Blocking or non-blocking";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Button btnAsync;
        private System.Windows.Forms.Button btnIncrement;
        private System.Windows.Forms.Label lblIncrement;
        private System.Windows.Forms.Label lblBtnWasPressed;
        private System.Windows.Forms.Label lblReady;
        private PictureBox pictureBox1;
    }
}

