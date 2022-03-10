using System;
using System.Collections.Generic;
using System.Text;

namespace Car
{
    class Vehiculo
    {
        private int id;
        private string mark;
        private string model;
        private int km;
        private float price;

        public void setId(int ID)
        {
            this.id = ID;
            ID = 4;
        }

        public int getId()
        {
            return this.id;
        }
        public void setMark(string MARK)
        {
            this.mark = MARK;
            Console.WriteLine("Enter U Car Mark: ");
            Console.ReadLine();
        }
        public string getMark()
        {
            return this.mark;
        }
        public void setModel(string MODEL)
        {
            this.model = MODEL;
            Console.WriteLine("Enter U Car Model: ");
            int valor1 = Convert.ToInt32(Console.ReadLine());
            if(valor1 < 0)
            {
                break;
            }
            else
            {
                continue;
            }
        }
        public string getModel()
        {
            return this.model;
        }
        public void setKm(int KM)
        {
            this.km = KM;
            Console.WriteLine("Enter The Mileage Of U Car: ");
            Console.ReadLine();
        }
        public int getKm()
        {
            return this.km;
        }
        public void setPrice(float PRICE)
        {
            this.price = PRICE;
            Console.WriteLine("Enter The Car Price: ");
            int valor2 = Convert.ToInt32(Console.ReadLine());
            if(valor2 < 0)
            {
                break;
            }
            else
            {
                continue;
            }
        }
        public float getPrice()
        {
            return this.price;
        }
        public void showCar()
        {
            Console.WriteLine("Id: " + getId);
            Console.WriteLine("Mark: " + getMark);
            Console.WriteLine("Model: " + getModel);
            Console.WriteLine("Price: " + getPrice);

        }
    }
   
}