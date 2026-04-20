namespace oopTask1
{

    class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            this.age = age;
        }

        public string Name { get; set; }
        private int age { get; set; }

        public void print()
        {
            Console.WriteLine($"this person Name is {Name} and it is {age} Year old");
        }


    }



    class Student : Person
    {
        public Student(string name, int age) : base(name, age) { }

        public void print()
        {
            Console.WriteLine($"this Student Name is {Name} ");
        }
    

    public static void Main()
        {
            Person p1 = new Person("shahas", 21);
            p1.print();

            Student s1 = new Student("haneen", 20);
            s1.print();
        }





    }

}
