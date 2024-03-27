    abstract class Person
    {
        public virtual int Age {get;set;}
        public virtual string FirstName {get;set;}
        public virtual string LastName {get;set;}

        public Person(string firstname, string lastname, int age)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
        }

        public abstract string Greet();

        public virtual string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
