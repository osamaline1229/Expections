using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    internal class User
    {
        string name { get; set; }
        public int Id { get; set; }

        public Gender gender { get; set; }
        public CarType carType{ get; set; }

        public User(int Id, string name, Gender gender, CarType carType)
        {
            this.Id = Id;
            this.name = name;
            this.gender = gender;
            this.carType = carType;
        }
        
        enum Gender
        {
            Male,
            FAMALE,
            OTHER
        }

        enum CarType
        {
            [Description("this is a Basic ride. car will be non air-conditioned")]
            BASIC=100,
            [Description("this is aPREMIUM ride. AC is good")]
            PREMIUM = 300,
            [Description("this is a Basic ride. car will be non air-conditioned")]
            VAN =202,
            [Description("this is a Message seats")]
            ULTRA_PREMIUM =305,
            [Description("this is has no AC")]
            MOTORCYCLE = 50


        }
    }
}
