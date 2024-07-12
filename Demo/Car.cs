using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Car
    {
		#region Attributes
		private int id  = default;
		private string? model = default;
		private double speed = default;
		#endregion

		#region Properties
		public int Id
		{
			get { return id; }
			set { id = value; }
		}
		public string? Model
		{
			get { return model; }
			set { model = value; }
		}
		public double Speed
		{
			get { return speed; }
			set { speed = value; }
		}
		#endregion

		// if you define constructor , compiler will no longer generate empty constructor

		/* public Car()
         {

         }*/
        public Car(int id ,  string model , double speed)
        {
            Console.WriteLine("Ctor 01");
            this.id = id;
			this.model = model;	
			this.speed = speed;
            
        }
		public Car(int id, string model):this (id , model , 180) // Constructor Chaining
        {
            Console.WriteLine("Ctor 02");
			//this.id = id;
			//this.model = model;
			//this.speed = 180;
            
        }
        public Car(int id):this(id, "Hyndai Elntra 2023" , 200)
        {
            Console.WriteLine("Ctor 03");
            /*this.id=id;
			this.model = "Hyndai Elntra 2023";
			this.speed = 200;*/
        }

        public override string ToString()
        {
            return $"Car Id {id} \nModel: {model} \nSpeed: {speed}";	
        }


    }
}
