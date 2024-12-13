using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_List

{
    public class Student
    {
        private string name;
        private double grade;

        public Student(string name, double grade)
        {
            this.name = name;
            this.grade = grade;
        }

        public override string ToString()
        {
            return $"{name} - {grade:F1}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Student other)
                return name == other.name && grade == other.grade;
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(name, grade);
        }

        public static bool operator ==(Student a, Student b)
        {
            if (ReferenceEquals(a, null)) return ReferenceEquals(b, null);
            return a.Equals(b);
        }

        public static bool operator !=(Student a, Student b)
        {
            return !(a == b);
        }
    }
}