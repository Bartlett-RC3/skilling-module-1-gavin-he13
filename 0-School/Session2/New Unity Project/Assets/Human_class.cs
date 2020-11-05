//LIBRARIES
using System;
//Namespace

namespace RC3_Humans

{
    //class
    public class Human_Class
    {
        //variables
        string name;
        float height;
        string countryOfOrigin;

        //constructor
        public Human_Class(string _name, float _height)
        {
            name = _name;
            height = _height;


        
        }

        //functions
        public string GetName()
        {
            return name;
        }
        public float GetHeight()
        {
            return height;
        }

        public void SetCounrtyOfOrigin(String _countryOfOrigin)
        {
            countryOfOrigin = _countryOfOrigin;

        }
        //private make the instruction in next script not accessible
        private void Sleep()
        {
            //action
            
        }

        public void Running()
        {
            //take shoes
        }
        public void WorkOut()
        {
            //take clothes
        }










    }


}

