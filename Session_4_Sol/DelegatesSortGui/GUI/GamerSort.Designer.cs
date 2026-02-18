namespace DelegatesSortGui {
    partial class GamerSort {
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
            lbGamers = new ListBox();
            lblGamers = new Label();
            btnByName = new Button();
            btnByHighScore = new Button();
            SuspendLayout();
            // 
            // lbGamers
            // 
            lbGamers.FormattingEnabled = true;
            lbGamers.Location = new Point(56, 80);
            lbGamers.Name = "lbGamers";
            lbGamers.Size = new Size(234, 304);
            lbGamers.TabIndex = 0;
            // 
            // lblGamers
            // 
            lblGamers.AutoSize = true;
            lblGamers.Location = new Point(57, 53);
            lblGamers.Name = "lblGamers";
            lblGamers.Size = new Size(67, 20);
            lblGamers.TabIndex = 1;
            lblGamers.Text = "GAMERS";
            // 
            // btnByName
            // 
            btnByName.Location = new Point(335, 123);
            btnByName.Name = "btnByName";
            btnByName.Size = new Size(158, 29);
            btnByName.TabIndex = 2;
            btnByName.Text = "Sort by name";
            btnByName.UseVisualStyleBackColor = true;
            btnByName.Click += BtnByName_Click;
            // 
            // btnByHighScore
            // 
            btnByHighScore.Location = new Point(335, 192);
            btnByHighScore.Name = "btnByHighScore";
            btnByHighScore.Size = new Size(158, 29);
            btnByHighScore.TabIndex = 3;
            btnByHighScore.Text = "Sort by high score";
            btnByHighScore.UseVisualStyleBackColor = true;
            btnByHighScore.Click += BtnByHighScore_Click;
            // 
            // GamerSort
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 437);
            Controls.Add(btnByHighScore);
            Controls.Add(btnByName);
            Controls.Add(lblGamers);
            Controls.Add(lbGamers);
            Name = "GamerSort";
            Text = "Gamer statistics";
            Load += GamerSort_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbGamers;
        private Label lblGamers;
        private Button btnByName;
        private Button btnByHighScore;
    }
}
