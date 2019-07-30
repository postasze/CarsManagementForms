using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Samochody
{
    public partial class CarRemoveWindow : Form
    {
        private CarManager carManager = null;

        public CarRemoveWindow(CarManager carManager)
        {
            this.carManager = carManager;
            InitializeComponent();
            fillComboBoxWithCars();
        }

        private void okButton_Clicked(object sender, EventArgs evArgs)
        {
            int id = this.comboBox1.Text[6] - 48;
            carManager.RemoveCar(id);

            this.Close();
        }

        private void cancelButton_Clicked(object sender, EventArgs evArgs)
        {
            this.Close();
        }

        private void fillComboBoxWithCars()
        {
            for (int i = 0; i < this.carManager.GetCarList().Count; i++)
            {
                this.comboBox1.Items.Add((this.carManager.GetCarList())[i].ToString());
            }
        }

        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            if (Equals(comboBox1.Text, "") || comboBox1.SelectedIndex < 0 ||
                this.carManager.GetCarList().Count <= comboBox1.SelectedIndex)
            {
                e.Cancel = true;
                errorProvider1.SetError(comboBox1, "Należy wybrać któryś pojazd do usunięcia");
            } 
        }

        private void comboBox1_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(comboBox1, "");
        }


    }
}
