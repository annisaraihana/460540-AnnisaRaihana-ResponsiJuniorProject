namespace WinFormsApp1
{
    partial class Form1
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
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblNamaKaryawan = new System.Windows.Forms.Label();
            this.lblDeptKaryawan = new System.Windows.Forms.Label();
            this.tbNamaKaryawan = new System.Windows.Forms.TextBox();
            this.tbDeptKaryawan = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbIDDept = new System.Windows.Forms.ListBox();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new System.Drawing.Point(22, 24);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(53, 52);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Location = new System.Drawing.Point(90, 41);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(34, 15);
            this.lblLogo.TabIndex = 1;
            this.lblLogo.Text = "Logo";
            // 
            // lblNamaKaryawan
            // 
            this.lblNamaKaryawan.AutoSize = true;
            this.lblNamaKaryawan.Location = new System.Drawing.Point(22, 101);
            this.lblNamaKaryawan.Name = "lblNamaKaryawan";
            this.lblNamaKaryawan.Size = new System.Drawing.Size(102, 15);
            this.lblNamaKaryawan.TabIndex = 2;
            this.lblNamaKaryawan.Text = "Nama Karyawan : ";
            // 
            // lblDeptKaryawan
            // 
            this.lblDeptKaryawan.AutoSize = true;
            this.lblDeptKaryawan.Location = new System.Drawing.Point(22, 143);
            this.lblDeptKaryawan.Name = "lblDeptKaryawan";
            this.lblDeptKaryawan.Size = new System.Drawing.Size(95, 15);
            this.lblDeptKaryawan.TabIndex = 3;
            this.lblDeptKaryawan.Text = "Dept. Karyawan :";
            // 
            // tbNamaKaryawan
            // 
            this.tbNamaKaryawan.Location = new System.Drawing.Point(130, 98);
            this.tbNamaKaryawan.Name = "tbNamaKaryawan";
            this.tbNamaKaryawan.Size = new System.Drawing.Size(194, 23);
            this.tbNamaKaryawan.TabIndex = 4;
            // 
            // tbDeptKaryawan
            // 
            this.tbDeptKaryawan.AllowDrop = true;
            this.tbDeptKaryawan.Location = new System.Drawing.Point(130, 140);
            this.tbDeptKaryawan.Name = "tbDeptKaryawan";
            this.tbDeptKaryawan.Size = new System.Drawing.Size(194, 23);
            this.tbDeptKaryawan.TabIndex = 5;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(22, 193);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(80, 26);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(219, 195);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 24);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(403, 196);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lbIDDept
            // 
            this.lbIDDept.FormattingEnabled = true;
            this.lbIDDept.ItemHeight = 15;
            this.lbIDDept.Location = new System.Drawing.Point(358, 24);
            this.lbIDDept.Name = "lbIDDept";
            this.lbIDDept.Size = new System.Drawing.Size(125, 139);
            this.lbIDDept.TabIndex = 9;
            // 
            // dgvTable
            // 
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(22, 246);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.RowTemplate.Height = 25;
            this.dgvTable.Size = new System.Drawing.Size(461, 237);
            this.dgvTable.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 513);
            this.Controls.Add(this.dgvTable);
            this.Controls.Add(this.lbIDDept);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.tbDeptKaryawan);
            this.Controls.Add(this.tbNamaKaryawan);
            this.Controls.Add(this.lblDeptKaryawan);
            this.Controls.Add(this.lblNamaKaryawan);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.pbLogo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbLogo;
        private Label lblLogo;
        private Label lblNamaKaryawan;
        private Label lblDeptKaryawan;
        private TextBox tbNamaKaryawan;
        private TextBox tbDeptKaryawan;
        private Button btnInsert;
        private Button btnEdit;
        private Button btnDelete;
        private ListBox lbIDDept;
        private DataGridView dgvTable;
    }
}