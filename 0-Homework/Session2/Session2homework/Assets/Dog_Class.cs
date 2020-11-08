//LIBRARIES
using System;
using System.Dynamic;
//Namespace

namespace Doggie_Class


{
    //class
    public class Dog_Class
    {
        //variables
        string name;
        float height;
        float weight;
        string species;

        //constructor
        public Dog_Class(string _name, float _height, float _weight)
        {
            name = _name;
            height =_height;
            weight = _weight;
           

        }

        //BEHAVIOURS(Functions)
        public string GetName()
        {
            return name;
        }
        public float GetHeight()
        {
            return height;
        }
        public float GetWeight()
        {
            return weight;
        }
        public void SetSpecies(String _species)
        {
            species = _species;

        }
        //private make the instruction in next script not accessible
        public void Sleep()
        {

            //snoring

        }

        public void Running()
        {
            //running on river
        }
       
    }


}