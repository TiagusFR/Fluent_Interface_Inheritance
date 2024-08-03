namespace Fluent_Interface_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var me = Person.New
                .Called("Tiago")
                .WorkAs("Developer")
                .Build();
        }
    }
}