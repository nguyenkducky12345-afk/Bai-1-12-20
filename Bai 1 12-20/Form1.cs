namespace Bai_1_12_20
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();
        private BindingSource bindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
            InitializeBindingSource();
            LoadSampleData();
        }

        private void InitializeDataGridView()
        {
            dataGridView.AutoGenerateColumns = false;
            dataGridView.Columns.Clear();

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "StudentId",
                DataPropertyName = "StudentId",
                HeaderText = "Student ID",
                Width = 100
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FullName",
                DataPropertyName = "FullName",
                HeaderText = "Full Name",
                Width = 150
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Age",
                DataPropertyName = "Age",
                HeaderText = "Age",
                Width = 80
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Gender",
                DataPropertyName = "Gender",
                HeaderText = "Gender",
                Width = 100
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "AvatarPath",
                DataPropertyName = "AvatarPath",
                HeaderText = "Avatar Path",
                Width = 170
            });
        }

        private void InitializeBindingSource()
        {
            bindingSource.DataSource = students;

            dataGridView.DataSource = bindingSource;

            textBoxId.DataBindings.Add("Text", bindingSource, "StudentId");
            textBoxFullName.DataBindings.Add("Text", bindingSource, "FullName");
            textBoxAge.DataBindings.Add("Text", bindingSource, "Age");
            comboBoxGender.DataBindings.Add("Text", bindingSource, "Gender");
        }

        private void LoadSampleData()
        {
            students.Add(new Student("SV001", "Nguyễn Văn A", 20, "Male", ""));
            students.Add(new Student("SV002", "Trần Thị B", 21, "Female", ""));
            students.Add(new Student("SV003", "Hoàng Văn C", 19, "Male", ""));
            students.Add(new Student("SV004", "Phạm Thị D", 22, "Female", ""));

            bindingSource.DataSource = students;
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            bindingSource.DataSource = students;
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                int currentIndex = dataGridView.CurrentRow.Index;
                bindingSource.Position = currentIndex;
                DisplayAvatar();
            }
        }

        private void DisplayAvatar()
        {
            if (bindingSource.Current is Student student && !string.IsNullOrEmpty(student.AvatarPath))
            {
                try
                {
                    if (File.Exists(student.AvatarPath))
                    {
                        pictureBoxAvatar.Image = Image.FromFile(student.AvatarPath);
                    }
                    else
                    {
                        pictureBoxAvatar.Image = null;
                        MessageBox.Show("Avatar file not found: " + student.AvatarPath, "Warning");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading avatar: " + ex.Message, "Error");
                    pictureBoxAvatar.Image = null;
                }
            }
            else
            {
                pictureBoxAvatar.Image = null;
            }
        }

        private void ButtonChooseAvatar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*";
                openFileDialog.Title = "Choose Avatar Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (bindingSource.Current is Student student)
                    {
                        student.AvatarPath = openFileDialog.FileName;
                        DisplayAvatar();
                        RefreshDataGridView();
                    }
                }
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxId.Text) || string.IsNullOrWhiteSpace(textBoxFullName.Text))
            {
                MessageBox.Show("Please fill in Student ID and Full Name", "Validation Error");
                return;
            }

            if (!int.TryParse(textBoxAge.Text, out int age))
            {
                MessageBox.Show("Please enter a valid age", "Validation Error");
                return;
            }

            var newStudent = new Student(
                textBoxId.Text,
                textBoxFullName.Text,
                age,
                comboBoxGender.SelectedItem?.ToString() ?? "Other",
                ""
            );

            students.Add(newStudent);
            RefreshDataGridView();
            ClearFields();
            MessageBox.Show("Student added successfully", "Success");
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current is Student student)
            {
                if (string.IsNullOrWhiteSpace(textBoxFullName.Text))
                {
                    MessageBox.Show("Please fill in Full Name", "Validation Error");
                    return;
                }

                if (!int.TryParse(textBoxAge.Text, out int age))
                {
                    MessageBox.Show("Please enter a valid age", "Validation Error");
                    return;
                }

                student.FullName = textBoxFullName.Text;
                student.Age = age;
                student.Gender = comboBoxGender.SelectedItem?.ToString() ?? "Other";

                RefreshDataGridView();
                MessageBox.Show("Student updated successfully", "Success");
            }
            else
            {
                MessageBox.Show("Please select a student to update", "Warning");
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current is Student student)
            {
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete {student.FullName}?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo
                );

                if (result == DialogResult.Yes)
                {
                    students.Remove(student);
                    RefreshDataGridView();
                    ClearFields();
                    MessageBox.Show("Student deleted successfully", "Success");
                }
            }
            else
            {
                MessageBox.Show("Please select a student to delete", "Warning");
            }
        }

        private void ButtonExportCsv_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV Files|*.csv|All Files|*.*";
                saveFileDialog.Title = "Export Students to CSV";
                saveFileDialog.FileName = "students.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName, false, System.Text.Encoding.UTF8))
                        {
                            // Write header
                            writer.WriteLine("StudentId,FullName,Age,Gender,AvatarPath");

                            // Write data rows
                            foreach (var student in students)
                            {
                                writer.WriteLine(Student.ToCsvString(student));
                            }
                        }

                        MessageBox.Show("Students exported successfully to:\n" + saveFileDialog.FileName, "Success");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error exporting CSV: " + ex.Message, "Error");
                    }
                }
            }
        }

        private void ClearFields()
        {
            bindingSource.Position = -1;
            textBoxId.Clear();
            textBoxFullName.Clear();
            textBoxAge.Clear();
            comboBoxGender.SelectedIndex = -1;
            pictureBoxAvatar.Image = null;
        }
    }
}
