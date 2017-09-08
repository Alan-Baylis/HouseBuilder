﻿using System;
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
    public partial class Form1 : Form
    {
        HouseViewModel HouseVM;

        public Form1()
        {
            InitializeComponent();

            string[] values = new[] { "carpet", "Tile", "Hardwood", "Lenoleum" };
            commonFlooringComboBox.Items.AddRange(values);
            bedFlooringComboBox.Items.AddRange(values);
            bathFlooringComboBox.Items.AddRange(values);
        }

        private void buildButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text)
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
            
                string storyText = "";
                if (oneRadioButton.Checked)
                    storyText = "One story house";
                else if (twoRadioButton.Checked)
                    storyText = "Two story house";
              
                string kitchenText = "";
                if (regularRadioButton.Checked)
                    kitchenText = "Regular old kitchen like a poor person";
                else if (gourmetRadioButton.Checked)
                    kitchenText = "Gourmet Kitchen. Well look who thinks they're the next Gordan Ramsey.";

                string basementText = basementCheckBox.Checked ?
                    "You've chosen to add a basement. Just don't do anything weird down there!"
                    : "Pinching pennys?";

                string garageText = garageCheckBox.Checked ?
                    "You've chosen to add a third garage bay; good place to hide a body"
                    : "You've chosen not to add a third garage bay. Why even build a house?";

                House myHouse;
                myHouse = new HouseBuilder()
                    .setName(nameTextBox.Text)
                    .setBasement(basementText)
                    .setGarage(garageText)
                    .setkitchen(kitchenText)
                    .setStories(storyText)
                    .setRooms(Convert.ToInt32(roomNumericUpDown.Value))
                    .setBathroomFlooring(bathFlooringComboBox.SelectedItem.ToString())
                    .setBedroomFlooring(bedFlooringComboBox.SelectedItem.ToString())
                    .setCommonAreaFlooring(commonFlooringComboBox.SelectedItem.ToString())
                    .Build();

                HouseVM = new HouseViewModel(myHouse);

                resultTextBox.Text = HouseVM.ToString();

        }

        private void roomNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bedFlooringComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
