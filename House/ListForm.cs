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
    public partial class ListForm : Form
    {
        private HouseOptionsModalForm HouseOptions;

        public List<HouseViewModel> HouseVMList = new List<HouseViewModel>();

        public ListForm()
        {
            InitializeComponent();
        }

        private void housesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (housesListBox.SelectedIndices.Count.Equals(0))
            {
                return;
            }
            else
            {
                 int selectedIndex = housesListBox.SelectedIndices[0];

                HouseViewModel selectedHouseVM = HouseVMList[selectedIndex];

                resultTextBox.Text = selectedHouseVM.ToString();
            }
        }

        private void ListForm_Load(object sender, EventArgs e)
        {
            
        }

        public void addButton_Click(object sender, EventArgs e)
        {
            HouseOptions = new HouseOptionsModalForm(this);
            HouseOptions.ShowDialog();
        }
    }
}
