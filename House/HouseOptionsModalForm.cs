using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace House
{
    public partial class HouseOptionsModalForm : Form
    {
        private ListForm ListForm;
      
        public HouseOptionsModalForm(ListForm listForm)
        {
            ListForm = listForm;

            InitializeComponent();

            string[] values = new[] { "carpet", "Tile", "Hardwood", "Lenoleum" };
            commonFlooringComboBox.Items.AddRange(values);
            bedFlooringComboBox.Items.AddRange(values);
            bathFlooringComboBox.Items.AddRange(values);
        }

        private void buildButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(houseNameTextBox.Text)
               || !oneRadioButton.Checked
               && !twoRadioButton.Checked
               && !regularRadioButton.Checked
               && !gourmetRadioButton.Checked
               || roomNumericUpDown.Value <= 0
               || bathFlooringComboBox.SelectedItem == null
               || bedFlooringComboBox.SelectedItem == null
               || commonFlooringComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please fill out all sections of the form!",
                                "Important Note",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
                return;
            }

            int storyText = 0;
            if (oneRadioButton.Checked)
                storyText = 1;
            else if (twoRadioButton.Checked)
                storyText = 2;

            House.KitchenType kitchen;
           
            if (regularRadioButton.Checked)
                kitchen = House.KitchenType.Regular;
            else 
                kitchen = House.KitchenType.Gormet;


            string basementText = basementCheckBox.Checked ?
                "true"
                : "false";

            string garageText = garageCheckBox.Checked ?
                    "true"
                    : "false";

            HouseViewModel houseVM;
            houseVM = new HouseViewModelBuilder()
                        .setName(houseNameTextBox.Text)
                        .setStories(storyText)
                        .setGarage(bool.Parse(garageText))
                        .setRooms(Convert.ToInt32(roomNumericUpDown.Value))
                        .setBasement(bool.Parse(basementText))
                        .setkitchen(kitchen)
                        .setBathroomFlooring(bathFlooringComboBox.SelectedItem.ToString())
                        .setBedroomFlooring(bedFlooringComboBox.SelectedItem.ToString())
                        .setCommonAreaFlooring(commonFlooringComboBox.SelectedItem.ToString())
                        .Build();

            ListForm.HouseVMList.Add(houseVM);

            ListForm.housesListBox.Items.Clear();

            foreach (var house in ListForm.HouseVMList)
            {
                ListForm.housesListBox.Items.Add(house.Name);
            }
            this.Hide();

            ListForm.Show();
           
        }

        private void HouseOptionsModalForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
