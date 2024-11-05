using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7_Lab1EmilySierra
{
    internal class Pizza
    {
        private string pizzaSize;
        private int cheese;
        private int pepperoni;
        private int ham;


        public Pizza()
        {
            //pizzaSize = string.Empty;
            //cheese = 0;
            //pepperoni = 0;
            //ham = 0;

        }

        public Pizza(string _pizzaSize, int _cheese, int _pepperoni, int _ham)
        {
            PizzaSize = _pizzaSize;
            Cheese = _cheese;
            Pepperoni = _pepperoni;
            Ham = _ham;
        }
        //getters and setters
        public string GetPizzaSize() { return this.pizzaSize; }
        public void SetPizzaSize(string pizzaSize) { this.pizzaSize = pizzaSize; }

        public int GetCheese() { return this.cheese; }
        public void SetCheese(int cheese) { this.cheese = cheese; }

        public int GetPepperoni() { return this.pepperoni; }
        public void SetPepperoni(int pepperoni) { this.pepperoni = pepperoni; }

        public int GetHam() { return this.ham; }
        public void SetHam(int ham) { this.ham = ham; }




        public string PizzaSize { get => pizzaSize; set => pizzaSize = value; }
        public int Cheese { get => cheese; set => cheese = value; }
        public int Pepperoni { get => pepperoni; set => pepperoni = value; }
        public int Ham { get => ham; set => ham = value; }





        //methods
        public double CalculateCost()
        {
            
            int pizzaCost = 0;
            double cost = 0;
            if (this.pizzaSize == "large")
            {
                
                pizzaCost += 14;
            } else if (this.pizzaSize == "medium")
            {
                pizzaCost += 12;
            } else if(this.pizzaSize == "small")
            {
                pizzaCost += 10;
            }
            

            cost =  pizzaCost + cheese*2 + pepperoni*2 + ham*2;


            return cost;
        }

        public String toString()
        {
            return "Pizza size: " + PizzaSize + " , cheese: " + Cheese + " , pepperoni: " + Pepperoni + " , ham: " + Ham + " . The total was: " + CalculateCost();
        }


    }
}
