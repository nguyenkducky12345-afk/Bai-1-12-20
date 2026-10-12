namespace Bai_1_12_20
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
            components = new System.ComponentModel.Container();
            dataGridView = new DataGridView();
            labelStudentId = new Label();
            labelFullName = new Label();
            labelAge = new Label();
            labelGender = new Label();
            textBoxId = new TextBox();
            textBoxFullName = new TextBox();
            textBoxAge = new TextBox();
            comboBoxGender = new ComboBox();
            pictureBoxAvatar = new PictureBox();
            buttonChooseAvatar = new Button();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            buttonExportCsv = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).BeginInit();
            SuspendLayout();

            // dataGridView
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 12);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 29;
            dataGridView.Size = new Size(600, 280);
            dataGridView.TabIndex = 0;
            dataGridView.SelectionChanged += DataGridView_SelectionChanged;

            // labelStudentId
            labelStudentId.AutoSize = true;
            labelStudentId.Location = new Point(12, 310);
            labelStudentId.Name = "labelStudentId";
            labelStudentId.Size = new Size(70, 15);
            labelStudentId.TabIndex = 1;
            labelStudentId.Text = "Student ID:";

            // textBoxId
            textBoxId.Location = new Point(90, 310);
            textBoxId.Name = "textBoxId";
            textBoxId.ReadOnly = true;
            textBoxId.Size = new Size(150, 23);
            textBoxId.TabIndex = 2;

            // labelFullName
            labelFullName.AutoSize = true;
            labelFullName.Location = new Point(12, 340);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(70, 15);
            labelFullName.TabIndex = 3;
            labelFullName.Text = "Full Name:";

            // textBoxFullName
            textBoxFullName.Location = new Point(90, 340);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(150, 23);
            textBoxFullName.TabIndex = 4;

            // labelAge
            labelAge.AutoSize = true;
            labelAge.Location = new Point(260, 310);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(33, 15);
            labelAge.TabIndex = 5;
            labelAge.Text = "Age:";

            // textBoxAge
            textBoxAge.Location = new Point(300, 310);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(100, 23);
            textBoxAge.TabIndex = 6;

            // labelGender
            labelGender.AutoSize = true;
            labelGender.Location = new Point(260, 340);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(52, 15);
            labelGender.TabIndex = 7;
            labelGender.Text = "Gender:";

            // comboBoxGender
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            comboBoxGender.Location = new Point(300, 340);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(100, 23);
            comboBoxGender.TabIndex = 8;

            // pictureBoxAvatar
            pictureBoxAvatar.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxAvatar.Location = new Point(620, 12);
            pictureBoxAvatar.Name = "pictureBoxAvatar";
            pictureBoxAvatar.Size = new Size(168, 180);
            pictureBoxAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAvatar.TabIndex = 9;
            pictureBoxAvatar.TabStop = false;

            // buttonChooseAvatar
            buttonChooseAvatar.Location = new Point(620, 200);
            buttonChooseAvatar.Name = "buttonChooseAvatar";
            buttonChooseAvatar.Size = new Size(168, 27);
            buttonChooseAvatar.TabIndex = 10;
            buttonChooseAvatar.Text = "Choose Avatar";
            buttonChooseAvatar.UseVisualStyleBackColor = true;
            buttonChooseAvatar.Click += ButtonChooseAvatar_Click;

            // buttonAdd
            buttonAdd.Location = new Point(620, 240);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 27);
            buttonAdd.TabIndex = 11;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += ButtonAdd_Click;

            // buttonUpdate
            buttonUpdate.Location = new Point(713, 240);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(75, 27);
            buttonUpdate.TabIndex = 12;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += ButtonUpdate_Click;

            // buttonDelete
            buttonDelete.Location = new Point(620, 273);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 27);
            buttonDelete.TabIndex = 13;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += ButtonDelete_Click;

            // buttonExportCsv
            buttonExportCsv.Location = new Point(713, 273);
            buttonExportCsv.Name = "buttonExportCsv";
            buttonExportCsv.Size = new Size(75, 27);
            buttonExportCsv.TabIndex = 14;
            buttonExportCsv.Text = "Export CSV";
            buttonExportCsv.UseVisualStyleBackColor = true;
            buttonExportCsv.Click += ButtonExportCsv_Click;

            // Form1
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 380);
            Controls.Add(buttonExportCsv);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(buttonChooseAvatar);
            Controls.Add(pictureBoxAvatar);
            Controls.Add(comboBoxGender);
            Controls.Add(textBoxAge);
            Controls.Add(labelGender);
            Controls.Add(textBoxFullName);
            Controls.Add(labelAge);
            Controls.Add(labelFullName);
            Controls.Add(textBoxId);
            Controls.Add(labelStudentId);
            Controls.Add(dataGridView);
            Name = "Form1";
            Text = "Student Management System";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private Label labelStudentId;
        private Label labelFullName;
        private Label labelAge;
        private Label labelGender;
        private TextBox textBoxId;
        private TextBox textBoxFullName;
        private TextBox textBoxAge;
        private ComboBox comboBoxGender;
        private PictureBox pictureBoxAvatar;
        private Button buttonChooseAvatar;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Button buttonExportCsv;
    }
}
