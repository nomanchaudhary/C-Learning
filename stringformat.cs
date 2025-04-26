class StringFormat{

    public static void Main(){

        int age = 22;
        string name = "Muhammad Noman";
        string str = string.Format("Hey {0}! You are {1} years old.", name, age);
        Console.WriteLine(str);
    }
}