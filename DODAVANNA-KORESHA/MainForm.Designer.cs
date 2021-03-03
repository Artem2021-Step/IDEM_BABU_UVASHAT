
namespace TreeViewAddElement
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbCategories = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tvCategories = new System.Windows.Forms.TreeView();
            this.gbCategories.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCategories
            // 
            this.gbCategories.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbCategories.Controls.Add(this.btnSearch);
            this.gbCategories.Controls.Add(this.txtSearch);
            this.gbCategories.Controls.Add(this.btnAdd);
            this.gbCategories.Controls.Add(this.tvCategories);
            this.gbCategories.Location = new System.Drawing.Point(11, 10);
            this.gbCategories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCategories.Name = "gbCategories";
            this.gbCategories.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCategories.Size = new System.Drawing.Size(678, 319);
            this.gbCategories.TabIndex = 0;
            this.gbCategories.TabStop = false;
            this.gbCategories.Text = "Дерево";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(26, 55);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(304, 32);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "ПОШУК КОРЕША ДЛЯ ТЕМКИ";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtSearch.Location = new System.Drawing.Point(6, 0);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "КЛИЧКА";
            this.txtSearch.Size = new System.Drawing.Size(340, 34);
            this.txtSearch.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAdd.Location = new System.Drawing.Point(26, 221);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(304, 54);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "ДОДАТИ КОРЕША В ТЕМКУ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tvCategories
            // 
            this.tvCategories.BackColor = System.Drawing.SystemColors.GrayText;
            this.tvCategories.Location = new System.Drawing.Point(346, 1);
            this.tvCategories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tvCategories.Name = "tvCategories";
            this.tvCategories.Size = new System.Drawing.Size(326, 295);
            this.tvCategories.TabIndex = 0;
            this.tvCategories.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvCategories_BeforeExpand);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.gbCategories);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Головна форма";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbCategories.ResumeLayout(false);
            this.gbCategories.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCategories;
        private System.Windows.Forms.TreeView tvCategories;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}

