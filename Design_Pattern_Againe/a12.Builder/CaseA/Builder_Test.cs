using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Person
{
    public string name;
    public string age;
    public string gender;
    public string birthday;
    public string phonenumber;

    public class Builder
    {
        public string name;
        public string age;
        
        public string gender;
        public string birthday;
        public string phonenumber;

        public Builder(string name, string age)
        {
            this.name = name;
            this.age = age;
        }

        public Builder Gender(string gender)
        {
            this.gender = gender;
            return this;
        }

        public Builder Birthday(string birthday)
        {
            this.birthday = birthday;
            return this;
        }

        public Builder PhoneNumber(string number)
        {
            this.phonenumber = number;
            return this;
        }

        public Person build()
        {
            return new Person(this);
        }
    }

    private Person(Builder builder)
    {
        this.name = builder.name;
        this.age = builder.age;
        this.gender = builder.gender;
        this.birthday = builder.birthday;
        this.phonenumber = builder.phonenumber;
    }

    public override string ToString()
    {
        return $"Person \n" +
            $"Name : {name}\n" +
            $"Age : {age}\n" +
            $"Gender : {gender}\n" +
            $"BirthDay : {birthday}\n" +
            $"PhoneNumber : {phonenumber}\n";
    }
}