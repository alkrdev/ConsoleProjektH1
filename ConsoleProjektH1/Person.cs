namespace ConsoleProjektH1
{
    /// <summary>
    /// A class to describe and contain the value of people
    /// </summary>
    public class Person
    {
        public string Name;
        public int Age;
        public double Balance;
        
        public Person(string name, int age, double balance)
        {
            Name = name;
            Age = age;
            Balance = balance;
        }
    }
}