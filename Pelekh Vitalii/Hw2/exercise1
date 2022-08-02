using System;
using System.Collections;

namespace Hw2
{
    internal class exersice1
    {
        interface IDeveloper : IComparable
        {
            string Tool { get; set; }
            void Create();
            void Destroy();

        }

        class Programmer : IDeveloper, IComparable
        {
            private string language;
            public string Tool 
            {
                get { 
                    return language; 
                }
                set { 
                    language = value; 
                }
            }

            public Programmer(string language)
            {
                this.language = language;
            }

            public void Create()
            {
                Console.WriteLine($"I've added {language} in the method Create()");
            }

            public void Destroy()
            {
                Console.WriteLine($"I've removed {language} from the method Destroy()");
            }

            public int CompareTo(object o)
            {
                Programmer p = o as Programmer;
                Builder b = o as Builder;
                if (p != null)
                    return this.Tool.CompareTo(p.Tool);
                else if (b != null)
                    return this.Tool.CompareTo(b.Tool);
                else
                    throw new ArgumentException("Object is not a developer");
            }
        }

        internal class Builder : IDeveloper, IComparable
        {
            private string tool;
            public string Tool
            {
                get
                {
                    return tool;
                }
                set
                {
                    tool = value;
                }
            }

            public Builder(string tool)
            {
                this.tool = tool;
            }

            public void Create()
            {
                Console.WriteLine($"I've added {tool} in the method Create()");
            }

            public void Destroy()
            {
                Console.WriteLine($"I've removed {tool} from the method Destroy()");
            }

            public int CompareTo(object o)
            {
                Programmer p = o as Programmer;
                Builder b = o as Builder;
                if (p != null)
                    return this.Tool.CompareTo(p.Tool);
                else if (b != null)
                    return this.Tool.CompareTo(b.Tool);
                else
                    throw new ArgumentException("Object is not a geek");
            }
        }

        static void Main(string[] args)
        {
            ArrayList geeks = new ArrayList()
            {
                new Programmer("Python"),
                new Programmer("Prolog"),
                new Programmer("LISP"),
                new Builder("Tensorflow"),
                new Builder("Keras"),
                new Builder("Pandas")
            };

            foreach (IDeveloper geek in geeks)
            {
                geek.Create();
                geek.Destroy();
            }

            geeks.Sort();

            Console.WriteLine("\n\nSorted array:");

            foreach (IDeveloper geek in geeks)
            {
                geek.Create();
                geek.Destroy();
            }
        }
    }
}
