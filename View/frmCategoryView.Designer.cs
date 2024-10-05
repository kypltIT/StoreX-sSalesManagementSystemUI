namespace WarehouseManagementUI.View
{
    partial class frmCategoryView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvSr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcategoryCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSr,
            this.dgvid,
            this.dgvcategoryCode,
            this.dgvname,
            this.dgvdescription,
            this.dgvEdit,
            this.dgvDelete});
            this.dataGridView1.Location = new System.Drawing.Point(12, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 322);
            this.dataGridView1.TabIndex = 1;
            // 
            // dgvSr
            // 
            this.dgvSr.HeaderText = "Sr #";
            this.dgvSr.MinimumWidth = 6;
            this.dgvSr.Name = "dgvSr";
            this.dgvSr.ReadOnly = true;
            this.dgvSr.Width = 125;
            // 
            // dgvid
            // 
            this.dgvid.HeaderText = "Id";
            this.dgvid.MinimumWidth = 6;
            this.dgvid.Name = "dgvid";
            this.dgvid.ReadOnly = true;
            this.dgvid.Width = 125;
            // 
            // dgvcategoryCode
            // 
            this.dgvcategoryCode.HeaderText = "Category Code";
            this.dgvcategoryCode.MinimumWidth = 6;
            this.dgvcategoryCode.Name = "dgvcategoryCode";
            this.dgvcategoryCode.ReadOnly = true;
            this.dgvcategoryCode.Width = 125;
            // 
            // dgvname
            // 
            this.dgvname.HeaderText = "Name";
            this.dgvname.MinimumWidth = 6;
            this.dgvname.Name = "dgvname";
            this.dgvname.ReadOnly = true;
            this.dgvname.Width = 125;
            // 
            // dgvdescription
            // 
            this.dgvdescription.HeaderText = "Description";
            this.dgvdescription.MinimumWidth = 6;
            this.dgvdescription.Name = "dgvdescription";
            this.dgvdescription.ReadOnly = true;
            this.dgvdescription.Width = 125;
            // 
            // dgvEdit
            // 
            this.dgvEdit.HeaderText = "";
            this.dgvEdit.MinimumWidth = 6;
            this.dgvEdit.Name = "dgvEdit";
            this.dgvEdit.ReadOnly = true;
            this.dgvEdit.Text = "Edit";
            this.dgvEdit.Width = 125;
            // 
            // dgvDelete
            // 
            this.dgvDelete.HeaderText = "";
            this.dgvDelete.MinimumWidth = 6;
            this.dgvDelete.Name = "dgvDelete";
            this.dgvDelete.ReadOnly = true;
            this.dgvDelete.Text = "Delete";
            this.dgvDelete.Width = 125;
            // 
            // frmCategoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmCategoryView";
            this.Text = "frmCategoryView";
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcategoryCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvdescription;
        private System.Windows.Forms.DataGridViewButtonColumn dgvEdit;
        private System.Windows.Forms.DataGridViewButtonColumn dgvDelete;
    }
}