using System;
using System.Collections.Generic;
using System.Text;

namespace Car
{
    class Vehiculo
    {
        private int id;
        private string marca;
        private string model;
        private int km;
        private float price;

        public void setId(int ID)
        {
            this.id = ID;
        }

        public int getId()
        {
            return this.id;
        }
        public void setMarca(string MARCA)
        {
            this.marca = MARCA;
        }
        public string getMarca()
        {
            return this.marca;
        }
        public void setModel(string MODEL)
        {
            this.model = MODEL;
        }
        public string getModel()
        {
            return this.model;
        }
    }
}