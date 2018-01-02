using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clone
{
    class workExp
    {
        private string workDate;
        public string WorkDate
        {
            set { workDate = value; }
            get { return workDate; }
        }

        private string company;
        public string Company
        {
            set { company = value; }
            get { return company; }
        }
    }

    class Resume : ICloneable
    {
        private string age;
        private string sex;
        private string name;

        workExp work;

        public Resume(string name)
        {
            this.name = name;
            work = new workExp();
        }

        public void setPersonal(string age,string sex)
        {
            this.age = age;
            this.sex = sex;
        }

        public void setWorkExp(string workDate,string company)
        {
            work.Company = company;
            work.WorkDate = workDate;
        }

        public void show()
        {
            Console.WriteLine("name:{0},workDate:{1}",name,work.WorkDate);
            Console.WriteLine("age:{0},sex:{1}",age,sex);
        }

        public object Clone()
        {
            return (Object)this.MemberwiseClone();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Resume a = new Resume("poppy");
            a.setPersonal("25","male");
            a.setWorkExp("2016-2017","ezfun");
            a.show();

            //Resume b = new Resume("wxf");
            Resume b = (Resume)a.Clone();
            b.setWorkExp("2015-2017","baihong");
            b.show();

        }
    }
}
