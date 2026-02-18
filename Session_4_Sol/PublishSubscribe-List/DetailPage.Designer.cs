
namespace PublishSubscribe_List {
    partial class DetailPage {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.dropdownIds = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFirst = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLast = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input id:";
            // 
            // dropdownIds
            // 
            this.dropdownIds.FormattingEnabled = true;
            this.dropdownIds.Location = new System.Drawing.Point(125, 56);
            this.dropdownIds.Name = "dropdownIds";
            this.dropdownIds.Size = new System.Drawing.Size(58, 28);
            this.dropdownIds.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Input firstname:";
            // 
            // tbFirst
            // 
            this.tbFirst.Location = new System.Drawing.Point(56, 155);
            this.tbFirst.Name = "tbFirst";
            this.tbFirst.Size = new System.Drawing.Size(277, 27);
            this.tbFirst.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Input lastname:";
            // 
            // tbLast
            // 
            this.tbLast.Location = new System.Drawing.Point(56, 223);
            this.tbLast.Name = "tbLast";
            this.tbLast.Size = new System.Drawing.Size(277, 27);
            this.tbLast.TabIndex = 5;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(225, 269);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(108, 36);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // DetailPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 385);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbLast);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbFirst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dropdownIds);
            this.Controls.Add(this.label1);
            this.Name = "DetailPage";
            this.Text = "DetailPage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClose);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox dropdownIds;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFirst;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLast;
        private System.Windows.Forms.Button btnOk;
    }
}