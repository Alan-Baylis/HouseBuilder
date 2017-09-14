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
     
        List<HouseViewModel> HouseVMList = new List<HouseViewModel>();
        
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

            string kitchenText = "";
            if (regularRadioButton.Checked)
                kitchenText = "Regular old kitchen like a poor person";
            else if (gourmetRadioButton.Checked)
                kitchenText = "Gourmet Kitchen. Well look who thinks they're the next Gordan Ramsey.";

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
                        .setkitchen(kitchenText)
                        .setBathroomFlooring(bathFlooringComboBox.SelectedItem.ToString())
                        .setBedroomFlooring(bedFlooringComboBox.SelectedItem.ToString())
                        .setCommonAreaFlooring(commonFlooringComboBox.SelectedItem.ToString())
                        .Build();

            HouseVMList.Add(houseVM);

            ListForm.housesListBox.Items.Clear();

            foreach (var house in HouseVMList)
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
