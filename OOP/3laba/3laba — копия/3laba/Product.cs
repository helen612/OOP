using System;
using System.Collections.Generic;
using System.Text;


namespace lab3
{
    public abstract class Product : CompareableProduct
    {
        private string colour;
        private string material;
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
        public virtual int Compare(Product o)
        {
            return this.Colour.CompareTo(o.Colour);
        }
       

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
