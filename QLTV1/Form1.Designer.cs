namespace QLTV1
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
            this.OpenConnection = new System.Windows.Forms.Button();
            this.CloseConnection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenConnection
            // 
            this.OpenConnection.Location = new System.Drawing.Point(25, 99);
            this.OpenConnection.Name = "OpenConnection";
            this.OpenConnection.Size = new System.Drawing.Size(103, 53);
            this.OpenConnection.TabIndex = 0;
            this.OpenConnection.Text = "Open";
            this.OpenConnection.UseVisualStyleBackColor = true;
            this.OpenConnection.Click += new System.EventHandler(this.OpenConnection_Click);
            // 
            // CloseConnection
            // 
            this.CloseConnection.Location = new System.Drawing.Point(161, 99);
            this.CloseConnection.Name = "CloseConnection";
            this.CloseConnection.Size = new System.Drawing.Size(103, 53);
            this.CloseConnection.TabIndex = 1;
            this.CloseConnection.Text = "Close";
            this.CloseConnection.UseVisualStyleBackColor = true;
            this.CloseConnection.Click += new System.EventHandler(this.CloseConnection_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 182);
            this.Controls.Add(this.CloseConnection);
            this.Controls.Add(this.OpenConnection);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenConnection;
        private System.Windows.Forms.Button CloseConnection;
    }
}

