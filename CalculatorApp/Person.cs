namespace CalculatorApp
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }


        public Person UpdatePerson(string updatedName, int updatedAge, Person person)
        {
            if (!string.IsNullOrEmpty(Name))
            {
                Name = updatedName;
            }

            if (Age != 0)
            {
                Age = updatedAge;
            }

            return person;
        }
    }
}
