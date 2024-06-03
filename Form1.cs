using System.ComponentModel;

namespace MVVM_WinForms
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            DataContext = new EmployeeViewModel();

            listBox1.DataBindings.Add(new Binding("DataSource", DataContext, "Employees"));
            nameTextBox.DataBindings.Add(new Binding("Text", DataContext, "Name", true, DataSourceUpdateMode.OnPropertyChanged));
            ageNumericUpDown.DataBindings.Add(new Binding("Value", DataContext, "Age", true, DataSourceUpdateMode.OnPropertyChanged));
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            (DataContext as EmployeeViewModel).AddEmployee();
        }
    }
    public class EmployeeViewModel : INotifyPropertyChanged
    {
        public BindingList<Employee> Employees { get; } = new BindingList<Employee>();

        private string _name;
        private int _age;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public int Age
        {
            get => _age;
            set
            {
                _age = value;
                OnPropertyChanged(nameof(Age));
            }
        }

        public void AddEmployee()
        {
            Employees.Add(new Employee
            {
                Name = this.Name,
                Age = this.Age
            });

            this.Name = String.Empty;
            this.Age = 0;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"{Name} - {Age}";
        }
    }
}
