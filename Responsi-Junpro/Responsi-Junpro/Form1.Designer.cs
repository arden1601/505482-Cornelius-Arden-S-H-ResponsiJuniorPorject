namespace Responsi_Junpro
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
            karyawanLabel = new Label();
            departemenLabel = new Label();
            karyawanBox = new TextBox();
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            dgvData = new DataGridView();
            pictureBox1 = new PictureBox();
            btnInsert = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // karyawanLabel
            // 
            karyawanLabel.AutoSize = true;
            karyawanLabel.Location = new Point(36, 61);
            karyawanLabel.Name = "karyawanLabel";
            karyawanLabel.Size = new Size(93, 15);
            karyawanLabel.TabIndex = 1;
            karyawanLabel.Text = "Nama Karyawan";
            // 
            // departemenLabel
            // 
            departemenLabel.AutoSize = true;
            departemenLabel.Location = new Point(36, 98);
            departemenLabel.Name = "departemenLabel";
            departemenLabel.Size = new Size(85, 15);
            departemenLabel.TabIndex = 2;
            departemenLabel.Text = "Dep. Karyawan";
            // 
            // karyawanBox
            // 
            karyawanBox.Location = new Point(135, 61);
            karyawanBox.Name = "karyawanBox";
            karyawanBox.Size = new Size(173, 23);
            karyawanBox.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ID", "HR", "ENG", "DEV", "PM", "FIN" });
            comboBox1.Location = new Point(135, 98);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(173, 23);
            comboBox1.TabIndex = 4;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "ID Departemen", "HR: HR", "ENG: Engineer", "DEV: Developer", "PM: Product M", "FIN: Finance" });
            listBox1.Location = new Point(584, 27);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(157, 124);
            listBox1.TabIndex = 5;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(36, 212);
            dgvData.Name = "dgvData";
            dgvData.Size = new Size(705, 210);
            dgvData.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.download;
            pictureBox1.Location = new Point(402, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(36, 167);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(123, 39);
            btnInsert.TabIndex = 8;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(313, 167);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(123, 39);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(618, 167);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(123, 39);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnInsert);
            Controls.Add(pictureBox1);
            Controls.Add(dgvData);
            Controls.Add(listBox1);
            Controls.Add(comboBox1);
            Controls.Add(karyawanBox);
            Controls.Add(departemenLabel);
            Controls.Add(karyawanLabel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label karyawanLabel;
        private Label departemenLabel;
        private TextBox karyawanBox;
        private ComboBox comboBox1;
        private ListBox listBox1;
        private DataGridView dgvData;
        private PictureBox pictureBox1;
        private Button btnInsert;
        private Button btnEdit;
        private Button btnDelete;
    }
}
