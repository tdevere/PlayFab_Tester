namespace PlayFab_Tester
{
    partial class frmPlayFabTester
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAPIS = new System.Windows.Forms.Label();
            this.lstAPI = new System.Windows.Forms.ListBox();
            this.btnInvoke = new System.Windows.Forms.Button();
            this.rtbResults = new System.Windows.Forms.RichTextBox();
            this.btnClearResults = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(822, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // lblAPIS
            // 
            this.lblAPIS.AutoSize = true;
            this.lblAPIS.Location = new System.Drawing.Point(12, 39);
            this.lblAPIS.Name = "lblAPIS";
            this.lblAPIS.Size = new System.Drawing.Size(60, 13);
            this.lblAPIS.TabIndex = 1;
            this.lblAPIS.Text = "API CALLS";
            // 
            // lstAPI
            // 
            this.lstAPI.FormattingEnabled = true;
            this.lstAPI.Items.AddRange(new object[] {
            "LoginWithCustomIDAsync"});
            this.lstAPI.Location = new System.Drawing.Point(15, 66);
            this.lstAPI.Name = "lstAPI";
            this.lstAPI.Size = new System.Drawing.Size(226, 95);
            this.lstAPI.TabIndex = 2;
            // 
            // btnInvoke
            // 
            this.btnInvoke.Location = new System.Drawing.Point(15, 167);
            this.btnInvoke.Name = "btnInvoke";
            this.btnInvoke.Size = new System.Drawing.Size(226, 23);
            this.btnInvoke.TabIndex = 3;
            this.btnInvoke.Text = "Invoke";
            this.btnInvoke.UseVisualStyleBackColor = true;
            this.btnInvoke.Click += new System.EventHandler(this.btnInvoke_Click);
            // 
            // rtbResults
            // 
            this.rtbResults.Location = new System.Drawing.Point(247, 65);
            this.rtbResults.Name = "rtbResults";
            this.rtbResults.Size = new System.Drawing.Size(571, 362);
            this.rtbResults.TabIndex = 4;
            this.rtbResults.Text = "";
            // 
            // btnClearResults
            // 
            this.btnClearResults.Location = new System.Drawing.Point(15, 196);
            this.btnClearResults.Name = "btnClearResults";
            this.btnClearResults.Size = new System.Drawing.Size(226, 23);
            this.btnClearResults.TabIndex = 5;
            this.btnClearResults.Text = "Clear Results";
            this.btnClearResults.UseVisualStyleBackColor = true;
            this.btnClearResults.Click += new System.EventHandler(this.btnClearResults_Click);
            // 
            // frmPlayFabTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 431);
            this.Controls.Add(this.btnClearResults);
            this.Controls.Add(this.rtbResults);
            this.Controls.Add(this.btnInvoke);
            this.Controls.Add(this.lstAPI);
            this.Controls.Add(this.lblAPIS);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPlayFabTester";
            this.Text = "PlayFab Tester";
            this.Load += new System.EventHandler(this.frmPlayFabTester_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label lblAPIS;
        private System.Windows.Forms.ListBox lstAPI;
        private System.Windows.Forms.Button btnInvoke;
        private System.Windows.Forms.RichTextBox rtbResults;
        private System.Windows.Forms.Button btnClearResults;
    }
}

