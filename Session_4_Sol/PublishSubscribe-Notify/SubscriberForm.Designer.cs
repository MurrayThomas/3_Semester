namespace PublishSubscribe_Notify {
    partial class SubscriberForm {
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
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.btnGotoNamePage = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name input:";
            // 
            // btnGotoNamePage
            // 
            this.btnGotoNamePage.Location = new System.Drawing.Point(59, 54);
            this.btnGotoNamePage.Name = "btnGotoNamePage";
            this.btnGotoNamePage.Size = new System.Drawing.Size(160, 29);
            this.btnGotoNamePage.TabIndex = 1;
            this.btnGotoNamePage.Text = "Goto name page";
            this.btnGotoNamePage.UseVisualStyleBackColor = true;
            this.btnGotoNamePage.Click += new System.EventHandler(this.BtnGotoNamePage_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(64, 148);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(15, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "..";
            // 
            // SubscriberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(402, 253);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnGotoNamePage);
            this.Controls.Add(this.label1);
            this.Name = "SubscriberForm";
            this.Text = "SubscriberForm";
            this.VisibleChanged += new System.EventHandler(this.OnVisible);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnGotoNamePage;
        private Label lblName;
    }
}