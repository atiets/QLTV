namespace QLTV1.UC
{
    partial class TheLoaiUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Them = new System.Windows.Forms.Button();
            this.dgv_TheLoai = new System.Windows.Forms.DataGridView();
            this.ahihi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TheLoai)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(154, 123);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // dgv_TheLoai
            // 
            this.dgv_TheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TheLoai.Location = new System.Drawing.Point(0, 210);
            this.dgv_TheLoai.Name = "dgv_TheLoai";
            this.dgv_TheLoai.RowHeadersWidth = 51;
            this.dgv_TheLoai.RowTemplate.Height = 24;
            this.dgv_TheLoai.Size = new System.Drawing.Size(1149, 292);
            this.dgv_TheLoai.TabIndex = 1;
            this.dgv_TheLoai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ahihi
            // 
            this.ahihi.AutoSize = true;
            this.ahihi.Location = new System.Drawing.Point(378, 85);
            this.ahihi.Name = "ahihi";
            this.ahihi.Size = new System.Drawing.Size(35, 16);
            this.ahihi.TabIndex = 2;
            this.ahihi.Text = "ahihi";
            // 
            // TheLoaiUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ahihi);
            this.Controls.Add(this.dgv_TheLoai);
            this.Controls.Add(this.btn_Them);
            this.Name = "TheLoaiUC";
            this.Size = new System.Drawing.Size(1149, 505);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TheLoai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridView dgv_TheLoai;
        private System.Windows.Forms.Label ahihi;
    }
}
