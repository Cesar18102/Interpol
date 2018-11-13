namespace Interpol
{
    partial class Form1
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
            this.Search = new System.Windows.Forms.Button();
            this.RemoveCriminal = new System.Windows.Forms.Button();
            this.AddCriminal = new System.Windows.Forms.Button();
            this.EditCriminal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Search.Font = new System.Drawing.Font("Segoe Marker", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(12, 161);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(442, 45);
            this.Search.TabIndex = 8;
            this.Search.Text = "Поиск";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // RemoveCriminal
            // 
            this.RemoveCriminal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveCriminal.Font = new System.Drawing.Font("Segoe Marker", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveCriminal.Location = new System.Drawing.Point(12, 59);
            this.RemoveCriminal.Name = "RemoveCriminal";
            this.RemoveCriminal.Size = new System.Drawing.Size(442, 45);
            this.RemoveCriminal.TabIndex = 7;
            this.RemoveCriminal.Text = "Удалить запись";
            this.RemoveCriminal.UseVisualStyleBackColor = true;
            this.RemoveCriminal.Click += new System.EventHandler(this.RemoveCriminal_Click);
            // 
            // AddCriminal
            // 
            this.AddCriminal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AddCriminal.Font = new System.Drawing.Font("Segoe Marker", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCriminal.Location = new System.Drawing.Point(12, 8);
            this.AddCriminal.Name = "AddCriminal";
            this.AddCriminal.Size = new System.Drawing.Size(442, 45);
            this.AddCriminal.TabIndex = 6;
            this.AddCriminal.Text = "Новая запись";
            this.AddCriminal.UseVisualStyleBackColor = true;
            this.AddCriminal.Click += new System.EventHandler(this.AddCriminal_Click);
            // 
            // EditCriminal
            // 
            this.EditCriminal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EditCriminal.Font = new System.Drawing.Font("Segoe Marker", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditCriminal.Location = new System.Drawing.Point(12, 110);
            this.EditCriminal.Name = "EditCriminal";
            this.EditCriminal.Size = new System.Drawing.Size(442, 45);
            this.EditCriminal.TabIndex = 9;
            this.EditCriminal.Text = "Изменить запись";
            this.EditCriminal.UseVisualStyleBackColor = true;
            this.EditCriminal.Click += new System.EventHandler(this.EditCriminal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 215);
            this.Controls.Add(this.EditCriminal);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.RemoveCriminal);
            this.Controls.Add(this.AddCriminal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INTERPOL";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button RemoveCriminal;
        private System.Windows.Forms.Button AddCriminal;
        private System.Windows.Forms.Button EditCriminal;



    }
}

