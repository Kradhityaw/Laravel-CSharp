namespace laracs
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label kelasLabel;
            System.Windows.Forms.Label namaLabel;
            System.Windows.Forms.Label umurLabel;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kelasComboBox = new System.Windows.Forms.ComboBox();
            this.namaTextBox = new System.Windows.Forms.TextBox();
            this.umurNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.editCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            kelasLabel = new System.Windows.Forms.Label();
            namaLabel = new System.Windows.Forms.Label();
            umurLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.umurNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siswaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kelasLabel
            // 
            kelasLabel.AutoSize = true;
            kelasLabel.Location = new System.Drawing.Point(12, 260);
            kelasLabel.Name = "kelasLabel";
            kelasLabel.Size = new System.Drawing.Size(36, 13);
            kelasLabel.TabIndex = 1;
            kelasLabel.Text = "Kelas:";
            // 
            // namaLabel
            // 
            namaLabel.AutoSize = true;
            namaLabel.Location = new System.Drawing.Point(12, 287);
            namaLabel.Name = "namaLabel";
            namaLabel.Size = new System.Drawing.Size(38, 13);
            namaLabel.TabIndex = 3;
            namaLabel.Text = "Nama:";
            // 
            // umurLabel
            // 
            umurLabel.AutoSize = true;
            umurLabel.Location = new System.Drawing.Point(12, 310);
            umurLabel.Name = "umurLabel";
            umurLabel.Size = new System.Drawing.Size(35, 13);
            umurLabel.TabIndex = 5;
            umurLabel.Text = "Umur:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.editCol,
            this.delCol});
            this.dataGridView1.DataSource = this.siswaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(775, 225);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // kelasComboBox
            // 
            this.kelasComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Kelas", true));
            this.kelasComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kelasComboBox.FormattingEnabled = true;
            this.kelasComboBox.Items.AddRange(new object[] {
            "X",
            "XI",
            "XII"});
            this.kelasComboBox.Location = new System.Drawing.Point(56, 257);
            this.kelasComboBox.Name = "kelasComboBox";
            this.kelasComboBox.Size = new System.Drawing.Size(218, 21);
            this.kelasComboBox.TabIndex = 2;
            // 
            // namaTextBox
            // 
            this.namaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Nama", true));
            this.namaTextBox.Location = new System.Drawing.Point(56, 284);
            this.namaTextBox.Name = "namaTextBox";
            this.namaTextBox.Size = new System.Drawing.Size(218, 20);
            this.namaTextBox.TabIndex = 4;
            // 
            // umurNumericUpDown
            // 
            this.umurNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource1, "Umur", true));
            this.umurNumericUpDown.Location = new System.Drawing.Point(56, 310);
            this.umurNumericUpDown.Name = "umurNumericUpDown";
            this.umurNumericUpDown.Size = new System.Drawing.Size(218, 20);
            this.umurNumericUpDown.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 37);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // editCol
            // 
            this.editCol.HeaderText = "";
            this.editCol.Name = "editCol";
            this.editCol.ReadOnly = true;
            // 
            // delCol
            // 
            this.delCol.HeaderText = "";
            this.delCol.Name = "delCol";
            this.delCol.ReadOnly = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(laracs.Models.Siswa);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nama";
            this.dataGridViewTextBoxColumn1.HeaderText = "nama";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "umur";
            this.dataGridViewTextBoxColumn2.HeaderText = "umur";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "kelas";
            this.dataGridViewTextBoxColumn3.HeaderText = "kelas";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // siswaBindingSource
            // 
            this.siswaBindingSource.DataSource = typeof(laracs.Models.Siswa);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(kelasLabel);
            this.Controls.Add(this.kelasComboBox);
            this.Controls.Add(namaLabel);
            this.Controls.Add(this.namaTextBox);
            this.Controls.Add(umurLabel);
            this.Controls.Add(this.umurNumericUpDown);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.umurNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siswaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn umurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kelasDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource siswaBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox kelasComboBox;
        private System.Windows.Forms.TextBox namaTextBox;
        private System.Windows.Forms.NumericUpDown umurNumericUpDown;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn editCol;
        private System.Windows.Forms.DataGridViewButtonColumn delCol;
    }
}

