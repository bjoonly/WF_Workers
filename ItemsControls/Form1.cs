using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace ItemsControls
{
 
    public partial class Form1 : Form
    {
        List<Worker> workers;
        public Form1()
        {
            InitializeComponent();
            PositionComboBox.Items.AddRange(new string[] {"Programmer","Designer","Director" });
            AddressComboBox.Items.AddRange(new string[] { "Lonokombinativska", "Chornovola","Copernicus","Khreshchatyk","Pushkinskaya","Bohdan Khmelnystky"});
            CityComboBox.Items.AddRange(new string[]{"Rivne","Kharkiv","Lviv","Kyiv","Odesa","Kherson","Cherkasy","Khmelnytskyi","Zhytomyr"});
            workers = new List<Worker>(5);
        }

        private void AddWorkerButton1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(FirstNameTextBox.Text) && !String.IsNullOrWhiteSpace(LastNameTextBox.Text) && !String.IsNullOrWhiteSpace(HouseTextBox.Text)
                &&PositionComboBox.SelectedItem!=null && CityComboBox.SelectedItem!=null&&AddressComboBox.SelectedItem!=null)
            {
               Worker worker =new Worker(FirstNameTextBox.Text, LastNameTextBox.Text, SalaryNumericUpDown.Value, PositionComboBox.SelectedItem.ToString(), CityComboBox.SelectedItem.ToString(), AddressComboBox.SelectedItem.ToString(), HouseTextBox.Text);
                WorkersListBox.Items.Add(worker);
                workers.Add(worker);
            }

        }

        private void NewPositionButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(PositionComboBox.Text)&& !PositionComboBox.Items.Contains(PositionComboBox.Text))
            {
                PositionComboBox.Items.Add(PositionComboBox.Text);                      
            }
        }

        private void NewCItyButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(CityComboBox.Text)&& !CityComboBox.Items.Contains(CityComboBox.Text))
            {
                CityComboBox.Items.Add(CityComboBox.Text);

            }
        }

        private void NewAddressButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(AddressComboBox.Text)&& !AddressComboBox.Items.Contains(AddressComboBox.Text))
            {
                AddressComboBox.Items.Add(AddressComboBox.Text);
        
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
           
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Worker>));
            try
            {
                using (Stream fstream = File.Create("Workers.xml")) {
                    xmlSerializer.Serialize(fstream, workers);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            workers = null;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Worker>));
            using (Stream fstream = File.OpenRead("Workers.xml"))
            {
                workers = (List<Worker>)xmlSerializer.Deserialize(fstream);
            }
            WorkersListBox.Items.Clear();
            foreach (Worker item in workers)
            {
                WorkersListBox.Items.Add(item);
            }
        
          
        }

        private void deleteWorkerButton_Click(object sender, EventArgs e)
        {
            if (WorkersListBox.SelectedItem != null)
            {
                WorkersListBox.Items.RemoveAt(WorkersListBox.SelectedIndex);
            }

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            
            if (WorkersListBox.SelectedItem != null)
            {

                Worker worker = (Worker)WorkersListBox.SelectedItem;
                worker.FirstName = FirstNameTextBox.Text;
                worker.LastName = LastNameTextBox.Text;
                worker.Salary = SalaryNumericUpDown.Value;
                worker.Position = PositionComboBox.Text;
                worker.City = CityComboBox.Text;
                worker.Address = AddressComboBox.Text;
                workers[WorkersListBox.SelectedIndex] = worker;
                WorkersListBox.Items[WorkersListBox.SelectedIndex] = worker;
            }
        }

        private void WorkersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (WorkersListBox.SelectedIndex != -1) {
                int index = WorkersListBox.SelectedIndex;
            FirstNameTextBox.Text = workers[index].FirstName;
            LastNameTextBox.Text = workers[index].LastName;
            SalaryNumericUpDown.Value = workers[index].Salary;
            if (!PositionComboBox.Items.Contains(workers[index].Position))
                PositionComboBox.Items.Add(workers[index].Position);
            PositionComboBox.SelectedItem = workers[index].Position;
            if (!CityComboBox.Items.Contains(workers[index].City))
                CityComboBox.Items.Add(workers[index].City);
            CityComboBox.SelectedItem = workers[index].City;
            if (!AddressComboBox.Items.Contains(workers[index].Address))
                AddressComboBox.Items.Add(workers[index].Address);
            AddressComboBox.SelectedItem = workers[index].Address;
                HouseTextBox.Text = workers[index].House;
        }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            WorkersListBox.SelectedIndex = -1;
            FirstNameTextBox.Text = String.Empty;
            LastNameTextBox.Text = String.Empty;
            SalaryNumericUpDown.Value = SalaryNumericUpDown.Minimum;
            PositionComboBox.SelectedIndex = -1;
            CityComboBox.SelectedIndex = -1;
            AddressComboBox.SelectedIndex = -1;
            HouseTextBox.Text = String.Empty;
        }
    }
}
