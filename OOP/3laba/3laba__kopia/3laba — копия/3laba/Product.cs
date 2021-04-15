using System;
using System.Collections.Generic;
using System.Text;


namespace lab3
{
    public abstract class Product : CompareableProduct
    {
        private string colour;
        private string material;
        static private int[] sortWeight = { 1, 2, 3 };
        internal readonly object Countrymake;

        protected string Material
        {
            get
            { return material; }
            set
            { material = value; }
        }
     
        protected string Colour
        {
            get
            { return colour; }
            set
            { colour = value; }
        }

        public void setSortWeight(int i,int w){
            sortWeight[i] = w;
        }

        public int getSortWeight(object T)
        {
            if (T is Unit) return sortWeight[0];
            else if (T is Mechanizm) return sortWeight[1];
            else return sortWeight[2];
        }

        public Product(string material, string colour)
        {
            Colour = colour;
            Material = material;
           
         
        }

        public Product(Product product)
        {
            Colour = product.Colour;
            Material = product.Material;
           
         
        }
        public abstract int Compare(Product o);
       

        public override bool Equals(Object obj)
        {
            if (!(obj is Product)) return false;
            var product = (Product)obj;

            if (Material == product.Material &&
        
            Colour == product.Colour)
            return true;
            else
            return false;
        }
        public override string ToString()
        {
            return $"Цвет: {Colour} " +  $"Материал: {Material} " ;
        }

        
    }
}
