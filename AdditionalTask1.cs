using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Xml.Linq;

namespace MVVM_WinForms
{
    public partial class AdditionalTask1 : Form
    {
        public AdditionalTask1()
        {
            InitializeComponent();

            DataContext = new EmployeeViewModel_Additional();

            listBox1.DataBindings.Add(new Binding("DataSource", DataContext, "Employees"));
            listBox1.DataBindings.Add(new Binding("SelectedItem", DataContext, "SelectedEmployee", true));
            nameTextBox.DataBindings.Add(new Binding("Text", DataContext, "Name", true, DataSourceUpdateMode.OnPropertyChanged));
            ageNumericUpDown.DataBindings.Add(new Binding("Value", DataContext, "Age", true, DataSourceUpdateMode.OnPropertyChanged));
            addButton.DataBindings.Add(new Binding("Command", DataContext, "AddCommand", true));
            deleteButton.DataBindings.Add(new Binding("Command", DataContext, "DeleteCommand", true));
        }

    }
    public class EmployeeViewModel_Additional : INotifyPropertyChanged
    {
        public BindingList<Employee_Additional> Employees { get; } = new BindingList<Employee_Additional>();

        private string _name;
        private int _age;
        private Employee_Additional _selectedEmployee;
        public ICommand AddCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        public EmployeeViewModel_Additional()
        {
            AddCommand = new MainCommand(_ =>
            {
                Employees.Add(new Employee_Additional { Name = this.Name, Age = this.Age });
                Name = ""; Age = 0;
            });
            DeleteCommand = new MainCommand(_ =>
            {
                if (SelectedEmployee != null)
                {
                    Employees.Remove(SelectedEmployee);
                }
            });
        }

        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }
        public int Age
        {
            get => _age;
            set
            {
                if (_age != value)
                {
                    _age = value;
                    OnPropertyChanged(nameof(Age));
                }
            }
        }
        public Employee_Additional SelectedEmployee
        {
            get { return _selectedEmployee; }
            set
            {
                _selectedEmployee = value;
                OnPropertyChanged(nameof(SelectedEmployee));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    public class Employee_Additional
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"{Name} - {Age}";
        }
    }
    public class MainCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        Action<object?> action;
        public MainCommand(Action<object?> action)
        {
            this.action = action;
        }
        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter) => action?.Invoke(parameter);
    }
}
