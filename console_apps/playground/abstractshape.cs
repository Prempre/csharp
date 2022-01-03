using System;


namespace ConsoleApps
{
    // compile with: csc -target:library abstractshape.cs
    public abstract class Shape
    {
        private string name;

        public Shape(string s)
        {
            Id = s; // calling the set accessor of the Id property.
        }

        public string Id 
        {
            get{
                return name;
            }
            set {
                name = value;
            }
        }

        // Area is a read-only property - only a get accessor is needed:
        public abstract double Area
        {
            get;
        }

        public override string ToString()
        {
            return $"{Id} Area = {Area:F2}";
        }

        
            
    }

}
