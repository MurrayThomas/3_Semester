namespace PublishSubscribe_Data {
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
            this.btnGotoNamePage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGotoNamePage
            // 
            this.btnGotoNamePage.Location = new System.Drawing.Point(65, 54);
            this.btnGotoNamePage.Name = "btnGotoNamePage";
            this.btnGotoNamePage.Size = new System.Drawing.Size(154, 29);
            this.btnGotoNamePage.TabIndex = 0;
            this.btnGotoNamePage.Text = "Goto name page";
            this.btnGotoNamePage.UseVisualStyleBackColor = true;
            this.btnGotoNamePage.Click += new System.EventHandler(this.BtnGotoNamePage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name input:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(75, 136);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(15, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "..";
            // 
            // SubscriberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 204);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGotoNamePage);
            this.Name = "SubscriberForm";
            this.Text = "Subscriber Form";
            this.VisibleChanged += new System.EventHandler(this.OnVisible);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGotoNamePage;
        private Label label1;
        private Label lblName;
    }
}