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
    public partial class CarEditWindow : Form
    {
        private CarManager carManager = null;
        enum carType {osobowy, ciezarowy, jednosladowy};
        carType currentCarType = carType.osobowy;

        public CarEditWindow(CarManager carManager)
        {
            this.carManager = carManager;
            InitializeComponent();
            fillComboBoxWithCars();
        }

        private void fillComboBoxWithCars()
        {
            for (int i = 0; i < this.carManager.GetCarList().Count; i++)
            {
                this.comboBox1.Items.Add((this.carManager.GetCarList())[i].ToString());
            }
        }

        private void okButton_Clicked(object sender, EventArgs evArgs)
        {
            int id = this.comboBox1.Text[6] - 48;
            String brand = brandTextBox.Text.ToString();
            int maximalSpeed = Int32.Parse(speedTextBox.Text);
            DateTime date = DateTime.Parse(dateTimePicker.Text.ToString());
            int carType = typeComboBox.SelectedIndex;
            
            carManager.EditCar(new Car(id, brand, maximalSpeed, date, carType),
                id);
            this.Close();
        }

        private void cancelButton_Clicked(object sender, EventArgs evArgs)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            currentCarType = (carType)(((int)currentCarType + 1) % 3);

            if (currentCarType.Equals(carType.osobowy))
            {
                this.pictureBox1.Image = global::Samochody.Properties.Resources.osobowy1;
                this.typeComboBox.SelectedIndex = 0;
            }       
            else if (currentCarType.Equals(carType.ciezarowy))
            {
                this.pictureBox1.Image = global::Samochody.Properties.Resources.cieżarowy1;
                this.typeComboBox.SelectedIndex = 1;
            }
            else if (currentCarType.Equals(carType.jednosladowy))
            {
                this.pictureBox1.Image = global::Samochody.Properties.Resources.jednośladowy1;
                this.typeComboBox.SelectedIndex = 2;
            }
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.typeComboBox.SelectedIndex)
            { 
                case 0:
                    this.pictureBox1.Image = global::Samochody.Properties.Resources.osobowy1;
                    break;
                case 1:
                    this.pictureBox1.Image = global::Samochody.Properties.Resources.cieżarowy1;
                    break;
                case 2:
                    this.pictureBox1.Image = global::Samochody.Properties.Resources.jednośladowy1;
                    break;

            }
        }

        private void speedTextBox_Validating(object sender, CancelEventArgs e)
        {
            try { Convert.ToInt32(speedTextBox.Text); }
            catch
            {
                e.Cancel = true;
                errorProvider1.SetError(speedTextBox, "Wprowadź liczbę");
            }
        }

        private void speedTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(speedTextBox, "");
        }

        private void brandTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (Equals(brandTextBox.Text, ""))
            {
                e.Cancel = true;
                errorProvider1.SetError(brandTextBox, "To pole nie powinno być puste");
            }
        }

        private void brandTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(brandTextBox, "");
        }

        private void typeComboBox_Validating(object sender, CancelEventArgs e)
        {
            if ((typeComboBox.SelectedIndex != 0 && typeComboBox.SelectedIndex != 1
                && typeComboBox.SelectedIndex != 2) || Equals(typeComboBox.Text, ""))
            {
                e.Cancel = true;
                errorProvider1.SetError(typeComboBox, "Należy wybrać jeden z trzech typów pojazdu");
            }
        }

        private void typeComboBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(typeComboBox, "");
        }

        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            if (Equals(comboBox1.Text, "") || comboBox1.SelectedIndex < 0|| 
                this.carManager.GetCarList().Count <= comboBox1.SelectedIndex)
            {
                e.Cancel = true;
                errorProvider1.SetError(comboBox1, "Należy wybrać któryś pojazd do edycji");
            }        
        }

        private void comboBox1_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(comboBox1, "");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = this.comboBox1.Text[6] - 48;
            int index = this.carManager.FindCar(id);
            this.brandTextBox.Text = (this.carManager.GetCarList())[index].GetBrand();
            this.speedTextBox.Text = (this.carManager.GetCarList())[index].GetMaximalSpeed().ToString();
            this.typeComboBox.Text = (this.carManager.GetCarList())[index].GetCarType();
            this.dateTimePicker.Text = (this.carManager.GetCarList())[index].GetDate().ToString();
        }
    }
}
