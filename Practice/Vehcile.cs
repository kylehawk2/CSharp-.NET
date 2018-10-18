using System;

namespace Practice 
{
    class Vehicle
    {
        private int maxNumPassengers;
        private string color;
        public int MaxNumPassengers
        {
            get { return maxNumPassengers; }
        }
        public string Color
        {
            get{ return Color; }
               
        }
        public Vehicle(int maxPass, string col)
        {
            maxNumPassengers = maxPass;
            color = col;
        }
    }
}