using System;
namespace PracticeProblems.Basic_Programs
{
class Car {
    public string model;
    public int value;
    public string color;

    public Car(string model2, int value2, string color2){
        model = model2;
        value = value2;
        color = color2;
    }

public void DisplayModel(){
    Console.WriteLine("Enter the model of the car: " + model);
}
    

}

public static void Main()
{
    Car car1 = new Car("Ford", 20000, "Red");
    Car car2 = new Car("Bugatti", 2000000, "Black");
    Console.WriteLine(car1.model);
    Console.WriteLine(car2.model);  
}

}