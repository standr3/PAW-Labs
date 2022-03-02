using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        private int cod; //data membra, neaccesibila afara
        private string nume;

        public Student()
        {
            cod = 0;
            nume = "NN";
        }

        public Student(int c, string n)
        {
            cod = c;
            nume = n;
        }

        public Student(Student s)
        {
            cod = s.cod;
            nume = s.nume;
        }

        public int Cod  //proprietatea accesibila din afara
        {
            get { return cod; }
            set     //value este param implicit
            {
                if (value > 0)
                    cod = value;
            }
        }

        public string Nume
        {
            get { return nume; }
            set
            {
                if (value.Length > 5)   //verificam despre valoarea noua, nu pe cea existenta
                    nume = value;
            }
        }

        public void afisare()
        {
            Console.WriteLine("Studentul are codul {0} si numele {1}", cod, nume); //diferenta dintre c si C este ca se apeleaza diferit, dar afiseaza acelasi lucru in acest ex

        }

        public override string ToString()
        {
            return "Studentul cu numele " + nume + " are codul " + cod;
        }
    }

    //tema: clasa Autoturism: marca, tip, an fabricatie: get,set, ToString..ce am facut la ora
    class Autoturism
    {
        private string marca;
        private string tip;


        public Autoturism()
        {
            this.marca = "NA";
            this.tip   = "NA";
        }
        public Autoturism(string marca, string tip)
        {
            this.marca = marca;
            this.tip   = tip;
        }
        public Autoturism(Autoturism a)
        {
            this.marca = a.marca;
            this.tip   = a.tip;
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Tip
        {
            get { return tip; }
            set { tip = value; }
        }
        public void afisare()
        {
            Console.WriteLine("Autoturismul are marca {0} si tipul {1}", marca, tip);
        }
        public override string ToString()
        {
            return "Autoturismul cu marca " + marca + " are tipul " + tip;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student(5, "Maria");
            Student s3 = new Student(s2);
            Student s4 = s2;

            s2.Nume = "Andrei";

            s4.afisare();
            //s1.afisare();
            //Console.WriteLine(s2.ToString());

            ArrayList lista = new ArrayList();

            lista.Add(s1);
            lista.Add(s2);
            lista.Add(s3);
            lista.Add(s4);

            foreach (Student s in lista)
                Console.WriteLine(s.ToString());

            for (int i = 0; i < lista.Count; i++)
                ((Student)lista[i]).afisare();

            Console.ReadLine();


        }
    }
}
