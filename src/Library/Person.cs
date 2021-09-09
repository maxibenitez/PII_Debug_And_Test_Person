﻿using System;

namespace UnitTestAndDebug
{
    public class Person
    {
        public Person(string name, string id, string birthday)
        {
            this.Name = name;
            this.ID = id;
            this.Birthday = birthday;
        }

        private string name;

        private string id;

        private string birthday;

        public string Name
        {
            get
            {
                return this.name;
            }
            
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
            }
        }
        public string ID
        {
            get
            {
                return this.id;
            }

            set
            {
                if (IdUtils.IdIsValid(value))
                {
                    this.id = value;
                }
            }
        }

         public string Birthday
        {
            get
            {
                return this.birthday;
            }

            set
            {
                if (IdUtils.BirthdayIsValid(value))
                {
                    this.birthday = value;
                }
            }
        }

        public void IntroduceYourself()
        {
            Console.WriteLine($"Soy {this.Name}, mi cédula es {this.ID} y mi fecha de nacimiento es {this.birthday}");
        }
    }
}
