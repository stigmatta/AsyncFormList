using System.Text.Json;

namespace AsyncFormList
{

    public partial class Form1 : Form
    {
        private SynchronizationContext sC = null;
        private string path = "students.json";
        private ListOfStudents listOfStudents = new ListOfStudents();

        public Form1()
        {
            InitializeComponent();
            sC = SynchronizationContext.Current;

            CreateListView();
            LoadStudents();
        }

        private bool CheckForEmpty()
        {
            return !string.IsNullOrEmpty(textBoxName.Text) &&
                   !string.IsNullOrEmpty(textBoxSurname.Text) &&
                   !string.IsNullOrEmpty(textBoxAge.Text) &&
                   !string.IsNullOrEmpty(textBoxGroup.Text);
        }
        private void CreateListView()
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Имя", 60);
            listView1.Columns.Add("Фамилия", 60);
            listView1.Columns.Add("Возраст", 60);
            listView1.Columns.Add("Группа", 60);
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            if (!CheckForEmpty())
            {
                MessageBox.Show("Some fields are empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var student = new Student(textBoxName.Text, textBoxSurname.Text, int.Parse(textBoxAge.Text), textBoxGroup.Text);

            listOfStudents.AddStudent(student);

            var json = JsonSerializer.Serialize(listOfStudents, new JsonSerializerOptions { WriteIndented = true });
            await File.WriteAllTextAsync(path, json).ContinueWith(task =>
            {
                LoadStudents();
            }, TaskScheduler.FromCurrentSynchronizationContext());

            var youngest = listOfStudents.GetYoungest();
            MessageBox.Show($"Youngest student is {youngest.Name} (Age is {youngest.Age})");


            textBoxName.Clear();
            textBoxSurname.Clear();
            textBoxAge.Clear();
            textBoxGroup.Clear();
        }

        private async void LoadStudents()
        {
            if (File.Exists(path))
            {
                try
                {
                    var json = await File.ReadAllTextAsync(path);
                    if (string.IsNullOrEmpty(json))
                        return;
                    listOfStudents = JsonSerializer.Deserialize<ListOfStudents>(json) ?? new ListOfStudents();
                    DisplayOnListView(listOfStudents);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading students: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DisplayOnListView(ListOfStudents list)
        {
            listView1.Items.Clear();

            foreach (var student in list.Students)
            {
                var item = new ListViewItem(student.Name);
                item.SubItems.Add(student.Surname);
                item.SubItems.Add(student.Age.ToString());
                item.SubItems.Add(student.Group);

                listView1.Items.Add(item);
            }
        }


        private void textBoxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0) return;

            listView1.Items.Clear();

            listOfStudents.Clear();

            File.WriteAllText(path, string.Empty);

            MessageBox.Show("All students have been cleared.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }

    [Serializable]
    public struct Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Group { get; set; }

        public Student(string name, string surname, int age, string group)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Group = group;
        }
    }

    [Serializable]
    public class ListOfStudents
    {
        public List<Student> Students { get; set; } = new List<Student>();

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void Clear()
        {
            Students.Clear();
        }

        public Student GetYoungest()
        {
            return Students.OrderBy(stud => stud.Age).FirstOrDefault();
        }

    }

}
