namespace Fluent_Interface_Inheritance
{
    public class PersonJobBuilder<SELF> 
        : PersonInfoBuilder<PersonJobBuilder<SELF>>
        where SELF : PersonJobBuilder<SELF>
    {
        public SELF WorkAs(string position)
        {
            person.Position = position;
            return (SELF) this;
        }
    }
}
