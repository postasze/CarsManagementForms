using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Samochody
{
    public class Car
    {        
        // Lista typow samochodow
        private static string[] carTypes = { "osobowy", "ciezarowy", "jednosladowy" };

        // id samochodu
        private int id;

        // marka samochodu
        private String brand;

        // maksymalna predkosc 
        private int maximalSpeed;

        // Data produkcji
        private DateTime date;

        // Rodzaj samochodu
        private int carType;

        public static string [] GetCarTypes()
        {
            return carTypes;
        }

        public Car(int id, String brand, int maximalSpeed, DateTime date, int carType)
        {
            this.id = id;
            this.brand = brand;
            this.maximalSpeed = maximalSpeed;
            this.date = date;
            this.carType = carType;
        }

        public string GetCarType()
        {
            return carTypes[this.carType];
        }

        public int GetMaximalSpeed() 
        { 
            return this.maximalSpeed; 
        }

        public DateTime GetDate() 
        { 
            return this.date; 
        }

        public int GetCarTypeIndex() 
        { 
            return carType; 
        }

        public String GetBrand() 
        { 
            return brand; 
        }

        public int GetId()
        {
            return id;
        }

        public void SetMaximalSpeed(int maximalSpeed)
        {
            this.maximalSpeed = maximalSpeed;
        }

        public void SetBrand(String brand)
        {
            this.brand = brand;
        }

        public void SetCarTypeIndex(int i)
        {
            this.carType = i;
        }

        public void SetDate(DateTime date)
        {
            this.date = date;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public void UpdateCar(int id, String brand, int maximalSpeed, DateTime date, int carType)
        {
            this.id = id;
            this.brand = brand;
            this.maximalSpeed = maximalSpeed;
            this.date = date;
            this.carType = carType;
        }

        public void Print()
        {
            Console.WriteLine("Numer " + this.id + " Marka: " + this.brand + ", maksymalna predkosc: " + this.maximalSpeed
                + ", data produkcji: " + this.date.ToShortDateString() + ", typ pojazdu: " + this.GetCarType());
        }

        public override String ToString()
        {
            return "Numer " + this.id + " Marka: " + this.brand + ", maksymalna predkosc: " + this.maximalSpeed
                + ", data produkcji: " + this.date.ToShortDateString() + ", typ pojazdu: " + this.GetCarType();
        }

        public bool TheSameAs(Car obj)
        {
            if (obj.brand.Equals(this.brand) && 
                obj.maximalSpeed.Equals(this.maximalSpeed) &&
                obj.date.Equals(this.date) &&
                obj.carType.Equals(this.carType))
                    return true;
            else return false;
        }

        public TreeNode CreateTreeNode()
        {
            TreeNode[] subnodes = {new TreeNode(this.brand), new TreeNode(this.maximalSpeed.ToString()),
                new TreeNode(this.date.ToShortDateString()), new TreeNode(GetCarType())};
            TreeNode node = new TreeNode(this.id.ToString(), subnodes);
            return node;
        }

        public ListViewItem CreateListViewItem()
        {
            string[] subitems = { this.id.ToString(), this.brand.ToString(),
                this.maximalSpeed.ToString(), this.date.ToShortDateString(), this.GetCarType()};

            ListViewItem listViewItem = new ListViewItem(subitems, -1);
            return listViewItem;
        }
    }
}