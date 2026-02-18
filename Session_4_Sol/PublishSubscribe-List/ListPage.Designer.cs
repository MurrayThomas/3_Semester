
namespace PublishSubscribe_List {
    partial class ListPage {
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
            this.btnGotoNamePage = new System.Windows.Forms.Button();
            this.lblHeadline = new System.Windows.Forms.Label();
            this.lvPersons = new System.Windows.Forms.ListView();
            this.lblNote = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGotoNamePage
            // 
            this.btnGotoNamePage.Location = new System.Drawing.Point(40, 42);
            this.btnGotoNamePage.Name = "btnGotoNamePage";
            this.btnGotoNamePage.Size = new System.Drawing.Size(194, 45);
            this.btnGotoNamePage.TabIndex = 0;
            this.btnGotoNamePage.Text = "Add a person";
            this.btnGotoNamePage.UseVisualStyleBackColor = true;
            this.btnGotoNamePage.Click += new System.EventHandler(this.BtnGotoNamePage_Click);
            // 
            // lblHeadline
            // 
            this.lblHeadline.AutoSize = true;
            this.lblHeadline.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeadline.Location = new System.Drawing.Point(40, 116);
            this.lblHeadline.Name = "lblHeadline";
            this.lblHeadline.Size = new System.Drawing.Size(133, 25);
            this.lblHeadline.TabIndex = 1;
            this.lblHeadline.Text = "List of persons";
            // 
            // lvPersons
            // 
            this.lvPersons.FullRowSelect = true;
            this.lvPersons.HideSelection = false;
            this.lvPersons.Location = new System.Drawing.Point(40, 144);
            this.lvPersons.Name = "lvPersons";
            this.lvPersons.Size = new System.Drawing.Size(299, 258);
            this.lvPersons.TabIndex = 2;
            this.lvPersons.UseCompatibleStateImageBehavior = false;
            this.lvPersons.View = System.Windows.Forms.View.List;
            this.lvPersons.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LvPersons_ItemSelectionChanged);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(40, 404);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(15, 20);
            this.lblNote.TabIndex = 3;
            this.lblNote.Text = "..";
            // 
            // ListPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 463);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lvPersons);
            this.Controls.Add(this.lblHeadline);
            this.Controls.Add(this.btnGotoNamePage);
            this.Name = "ListPage";
            this.Text = "ListPage";
            this.VisibleChanged += new System.EventHandler(this.OnVisible);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGotoNamePage;
        private System.Windows.Forms.Label lblHeadline;
        private System.Windows.Forms.ListView lvPersons;
        private System.Windows.Forms.Label lblNote;
    }
}