using System;
using System.Reflection;


namespace csharp_tutorials
{
    class Complex
    {

        // Public fields 
        private double re, im;
  

        // Constructors
        public Complex(double _re, double _im)
        {
            re = _re; im = _im;
        }

        public Complex() : this(0, 0) { }

        // Properties
        public double Re
        {
            get { return re; }
            set { re = value; }
        }

        public double Im
        {
            get { return im; }
            set { im = value; }
        }

        // Methods
        public Complex Add(double re2, double im2)
        {
            return new Complex(re + re2, im + im2);
        }

        public Complex Sub(double re2, double im2)
        {
            return new Complex(re - re2, im - im2);
        }

        public void Print(string text)
        {
            Console.Write(text);
            Console.Write("{0:f2}", re);
            if (im > 0)
                Console.Write("+");
            Console.WriteLine("{0:f2}*j", im);
        }
    }
    /* 
     This class shows how to use Object.GetType and Reflection.Methodinfo to get the metadata of an object
        1. Call the GetType method on the object and pass returned type to a Type variable 
        2. on The Type variable call the methodsinfo and pass the returned values to a methodinfo variable 
    
    */
    class GetMetaDataByObjectGetType
    {
        // Get information about the types of complex class using System.Object.GetType()

        // 1.  Declare an instance of the Complex class
        Complex cm = new Complex(5, 8);

        public void ReturnMetaData()
        {

            // 2. Get the type from the instance 
            Type tp = cm.GetType();  // method GetType() of class Object

            // 3. Get a list of methods of the Complex class
            // Select methods according to the following criteria:
            // - only public methods;
            // - only from an instance;
            // - only those methods that are declared in the Complex class.
            MethodInfo[] mi = tp.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

            // 4. Display the names of the methods of the Complex class
            foreach (MethodInfo m in mi)
            {
                Console.WriteLine("{0}", m.Name);
            }

            Console.ReadKey();
        }
    }

    /*
     This class shows how to use Typeof class and Reflection.ConstructorInfo to get the metadata of an object
        1. Call the pass the object to the typeof and store the returned type in a  Type variable 
        2. on The Type variable call the ConstructorInfo and pass the returned values to a ConstructorInfo variable 
    */
    class GetMetaDataByTypeOf
    {
        // Get information about the types of complex class using typeof()

        // 1. Get an instance of System.Type from the Complex class
        Type tp = typeof(Complex);


        public void ReturnMetaData()
        {
            // 2.  Get a list of the complex class constructors 
            ConstructorInfo[] ci = tp.GetConstructors();


            // 3. Print a list of constructors with parameters
            foreach (ConstructorInfo c in ci)
            {
                Console.WriteLine(c.Name + "(");

                // Generate a list of constructor parameters 
                ParameterInfo[] pi = c.GetParameters();

                for (int i = 0; i < pi.Length; i++)
                {
                    Console.Write("{0} {1}", pi[i].ParameterType.Name, pi[i].Name);
                    if (i < pi.Length - 1)
                        Console.Write(", ");
                }
                Console.WriteLine(")");
            }
            Console.ReadKey();
        }
    }
    /*
        class GetMetaByTypeGetType
        {
            //string assembly_path = @"C:\Users\Clinton\source\csharp\bestprog\best-prog-lessons\understanding-metadata\bin\Debug\understanding-metadata.exe"
            // 1. Load the assembly 
            Assembly asm = Assembly.Load("understanding-metadata");

            // 2. Get the type from assembly 
            public void ReturnMetaData()
            {
                // -- this commend need to fix
                Type tp = asm.GetType("understanding-metadata");

                // 3. Get attributes of class Complex
                object[] objs = tp.GetCustomAttributes(true);

                // 4. Display attribaute names on screen
                foreach(object obj in objs)
                {
                    Console.WriteLine(obj.GetType().Name);
                }
            }
   
        }
    */
}
