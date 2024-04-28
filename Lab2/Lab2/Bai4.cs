using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
            students = new List<Student>();
        }
        [Serializable]
        internal class Student
        {
            public string MSSV { get; set; }
            public string HoTen { get; set; }
            public string DienThoai { get; set; }
            public float DiemToan { get; set; }
            public float DiemVan { get; set; }
            public float DTB { get; set; }
        }
        private List<Student> students;

        private void button1_Click(object sender, EventArgs e)
        {
            string[] studentInfo = textBox1.Text.Split('\0');

            foreach (string info in studentInfo)
            {
                string[] data = info.Split('\n');

                if (data.Length == 5)
                {
                    Student student = new Student();
                    if (float.TryParse(data[3], out float diemToan) && float.TryParse(data[4], out float diemVan))
                    {
                        if (IsValidScore(diemToan) && IsValidScore(diemVan))
                        {
                            student.DiemToan = diemToan;
                            student.DiemVan = diemVan;
                            students.Add(student);
                        }
                        else
                        {
                            MessageBox.Show("Giá trị điểm không hợp lệ. Vui lòng kiểm tra lại.", "Lỗi");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Giá trị điểm không hợp lệ. Vui lòng kiểm tra lại.", "Lỗi");
                        return;
                    }
                    student.MSSV = data[0];
                    student.HoTen = data[1];
                    student.DienThoai = data[2];
                }
            }

            textBox1.Clear();
        }
        private bool IsValidScore(float score)
        {
            return score >= 0 && score <= 10;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SaveStudentsToBinaryFile("C:\\Users\\Admin\\OneDrive - Trường ĐH CNTT - University of Information Technology\\Tài liệu\\bai4.txt", students);
            MessageBox.Show("Dữ liệu đã được lưu vào file bai4.txt", "Thông báo");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            students = ReadStudentsFromBinaryFile("C:\\Users\\Admin\\OneDrive - Trường ĐH CNTT - University of Information Technology\\Tài liệu\\bai4.txt");
            CalculateAverageScores(students);
            SaveResultsToFile(students, "C:\\Users\\Admin\\OneDrive - Trường ĐH CNTT - University of Information Technology\\Tài liệu\\output100.txt");
            PrintResults(students);
            MessageBox.Show("Kết quả đã được tính và lưu vào file output.txt", "Thông báo");
        }
        private void SaveStudentsToBinaryFile(string filePath, List<Student> students)
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fileStream, students);
            }
        }

        private List<Student> ReadStudentsFromBinaryFile(string filePath)
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                return (List<Student>)binaryFormatter.Deserialize(fileStream);
            }
        }

        private void CalculateAverageScores(List<Student> students)
        {
            foreach (Student student in students)
            {
                student.DTB = (student.DiemToan + student.DiemVan) / 2;
            }
        }

        private void SaveResultsToFile(List<Student> students, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (Student student in students)
                {
                    writer.WriteLine($" {student.MSSV}");
                    writer.WriteLine($" {student.HoTen}");
                    writer.WriteLine($" {student.DienThoai}");
                    writer.WriteLine($" {student.DiemToan}");
                    writer.WriteLine($" {student.DiemVan}");
                    writer.WriteLine($" {student.DTB}");
                    writer.WriteLine();
                }
            }
        }

        private void PrintResults(List<Student> students)
        {
            string result = "";

            foreach (Student student in students)
            {
                result += $"MSSV: {student.MSSV}\n";
                result += $"Họ tên: {student.HoTen}\n";
                result += $"Số điện thoại: {student.DienThoai}\n";
                result += $"Toán: {student.DiemToan}\n";
                result += $"Văn: {student.DiemVan}\n";
                result += $"ĐTB: {student.DTB}\n";
                result += "\n";
            }

            MessageBox.Show(result, "Kết quả");
        }
    }

}