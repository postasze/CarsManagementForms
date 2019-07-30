using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Samochody
{
    public class CarManager
    {
        private List<Car> carList = null;
        private MDIParent mainWindow = null;
        public int currentCarID = 1;

        public CarManager(MDIParent mainWindow)
        {
            this.carList = new List<Car>(0);
            this.mainWindow = mainWindow;
        }

        public List<Car> GetCarList()
        {
            return this.carList;
        }

        public MDIParent GetMDIParent()
        {
            return this.mainWindow;
        }

        public void AddCar(Car car)
        {
            carList.Add(car);
            UpdateAllWindows("Addition", car, currentCarID);
            currentCarID++;
        }

        public void EditCar(Car newCar, int id)
        {
            int index = FindCar(id);
            carList[index] = newCar;
            UpdateAllWindows("Edition", newCar, id);
        }

        public void RemoveCar(int id)
        {
            int index = FindCar(id);
            carList.RemoveAt(index);
            UpdateAllWindows("Removal", null, id);
        }

        private void UpdateAllWindows(String operation, Car car, int id)
        {
            Document document;
            for (int i = 0; i < this.mainWindow.MdiChildren.Length; i++)
            {
                document = (Document) this.mainWindow.MdiChildren[i];
                document.UpdateView(operation, car, id);
            }            
        }

        public void PrintCars()
        {
            Console.WriteLine("Wypisywanie pojazdow: ");
            for (int i = 0; i < carList.Count; ++i)
                carList[i].Print();
        }

        public int FindCar(int id)
        {
            for (int i = 0; i < this.carList.Count; i++)
            {
                if (this.carList[i].GetId() == id)
                    return i;
            }
            return -1;
        }

    }
}
