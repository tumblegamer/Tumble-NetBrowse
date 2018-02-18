namespace Tumble_NetBrowse
{
    partial class Settings
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mainTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.homePageBox = new System.Windows.Forms.TextBox();
            this.saveButon = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.currentPageButton = new System.Windows.Forms.Button();
            this.defaultButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.mainTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.mainTab);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(282, 145);
            this.tabControl1.TabIndex = 0;
            // 
            // mainTab
            // 
            this.mainTab.Controls.Add(this.defaultButton);
            this.mainTab.Controls.Add(this.currentPageButton);
            this.mainTab.Controls.Add(this.label1);
            this.mainTab.Controls.Add(this.homePageBox);
            this.mainTab.Location = new System.Drawing.Point(4, 22);
            this.mainTab.Name = "mainTab";
            this.mainTab.Padding = new System.Windows.Forms.Padding(3);
            this.mainTab.Size = new System.Drawing.Size(274, 119);
            this.mainTab.TabIndex = 0;
            this.mainTab.Text = "General";
            this.mainTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Homepage";
            // 
            // homePageBox
            // 
            this.homePageBox.Location = new System.Drawing.Point(72, 25);
            this.homePageBox.Name = "homePageBox";
            this.homePageBox.Size = new System.Drawing.Size(195, 20);
            this.homePageBox.TabIndex = 0;
            // 
            // saveButon
            // 
            this.saveButon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButon.Location = new System.Drawing.Point(197, 152);
            this.saveButon.Name = "saveButon";
            this.saveButon.Size = new System.Drawing.Size(75, 23);
            this.saveButon.TabIndex = 1;
            this.saveButon.Text = "Save";
            this.saveButon.UseVisualStyleBackColor = true;
            this.saveButon.Click += new System.EventHandler(this.saveButon_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(12, 152);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // currentPageButton
            // 
            this.currentPageButton.AutoSize = true;
            this.currentPageButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.currentPageButton.Location = new System.Drawing.Point(72, 52);
            this.currentPageButton.Name = "currentPageButton";
            this.currentPageButton.Size = new System.Drawing.Size(79, 23);
            this.currentPageButton.TabIndex = 2;
            this.currentPageButton.Text = "Current Page";
            this.currentPageButton.UseVisualStyleBackColor = true;
            this.currentPageButton.Click += new System.EventHandler(this.currentPageButton_Click);
            // 
            // defaultButton
            // 
            this.defaultButton.AutoSize = true;
            this.defaultButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.defaultButton.Location = new System.Drawing.Point(157, 51);
            this.defaultButton.Name = "defaultButton";
            this.defaultButton.Size = new System.Drawing.Size(51, 23);
            this.defaultButton.TabIndex = 3;
            this.defaultButton.Text = "Default";
            this.defaultButton.UseVisualStyleBackColor = true;
            this.defaultButton.Click += new System.EventHandler(this.defaultButton_Click);
            // 
            // Settings
            // 
            this.AcceptButton = this.saveButon;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(284, 187);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButon);
            this.Controls.Add(this.tabControl1);
            this.KeyPreview = true;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.Text = "Settings";
            this.tabControl1.ResumeLayout(false);
            this.mainTab.ResumeLayout(false);
            this.mainTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage mainTab;
        private System.Windows.Forms.TextBox homePageBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButon;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button defaultButton;
        private System.Windows.Forms.Button currentPageButton;
    }
}