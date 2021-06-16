using System;
using System.Reflection;

namespace test_dev
{
	public static class Program
	{

		/**
		 * TODO - This is a .NET Core console application
		 * There are two classes in this project - Model and Dto
		 * Both of them have the same properties.
		 * In the code below, I have created an object from Model class. 
		 * Your task is to map this object to the object of Dto class.
		 * You are suppose to do it in two different ways - Way 1. Whatever you like. If you want you can map them manually. Way 2. Using reflection.
		 * A little bit hint for Way 2 - You can write an extension method that uses reflection to get properties and types from Model class and converts values of object of Model class to a new object of Dto call. 
		 * BONUS - If you manage to do this easily and still have some time - Extend the Model and Dto classes with a property of type List<string> and also convert this using reflection
		 * You can freely use Google, Stack Overflow, or any other online help you want.
		 * If you don't understand the task, please contact me at ipole@daenet.com
		 **/
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Model model = new Model();
			model.Id = 1;
			model.Name = "Test";
			model.CreatedAt = DateTime.UtcNow;
			model.ReferenceNumber = 1212121;

			Dto dto = new Dto(); // Here map the values from model to dto.
		}


	}
}
