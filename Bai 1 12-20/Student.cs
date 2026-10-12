namespace Bai_1_12_20
{
    public class Student
    {
        public string StudentId { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Gender { get; set; } = string.Empty;
        public string AvatarPath { get; set; } = string.Empty;

        public Student() { }

        public Student(string studentId, string fullName, int age, string gender, string avatarPath)
        {
            StudentId = studentId;
            FullName = fullName;
            Age = age;
            Gender = gender;
            AvatarPath = avatarPath;
        }

        public override string ToString()
        {
            return $"{StudentId} - {FullName}";
        }

        public static string ToCsvString(Student student)
        {
            var idEscaped = EscapeCsvField(student.StudentId);
            var nameEscaped = EscapeCsvField(student.FullName);
            var genderEscaped = EscapeCsvField(student.Gender);
            var avatarEscaped = EscapeCsvField(student.AvatarPath);

            return $"{idEscaped},{nameEscaped},{student.Age},{genderEscaped},{avatarEscaped}";
        }

        private static string EscapeCsvField(string field)
        {
            if (string.IsNullOrEmpty(field))
                return string.Empty;

            if (field.Contains(",") || field.Contains("\"") || field.Contains("\n"))
            {
                return "\"" + field.Replace("\"", "\"\"") + "\"";
            }

            return field;
        }
    }
}
