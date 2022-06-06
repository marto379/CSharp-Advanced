using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniParking
{
    public class Car
    {
        public Car(string make,string model,int HP,string regNum)
        {
            Make = make; 

            Model = model;
            HorsePower = HP;
            RegNum = regNum;
        }
        //make, model, horsePower and registrationNumber
        string make;
        string model;
        int horsePower;
        string regNum;

        public string Make { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public string RegNum { get; set; }

        public override string ToString()
        {
           StringBuilder sb = new StringBuilder();
            sb.Append("Make: " + Make).Append(Environment.NewLine);
            sb.Append("Model: " + Model).Append(Environment.NewLine);
            sb.Append("HorsePower: " + HorsePower).Append(Environment.NewLine);
            sb.Append("RegistrationNumber: " + RegNum);

            return sb.ToString();   

        }
    }
}
