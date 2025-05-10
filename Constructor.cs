namespace Constructor
{
    class MyClass
    {
        static void Main()
        {
            Car mycar1 = new Car("red",120);
            Car mycar2 = new Car("blue", 160);
            Console.WriteLine(mycar1.color, mycar1.maxspeed);
             Console.WriteLine(mycar1.maxspeed);

            Console.WriteLine(mycar2.color, mycar2.maxspeed);
             Console.WriteLine(mycar2.maxspeed);
        }
    }
    class Car
    {
        public Car(string color1, int maxspeed1)
        {
            color = color1;
            maxspeed = maxspeed1;
        }
        public string color;
        public int maxspeed;
    }
}