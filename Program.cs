using System;

namespace constructor_get_set
{
    class Book
    {

        int isbn;
        int pages;
        double price;
        public Book() //constructor
        {

            this.isbn = -10; // default values
            this.pages = -10;
            this.price = -10;
        }
        public int getisbn() // get method
        {
            return this.isbn;
        }
        public int getpages()
        {
            return this.pages;
        }
        public double getprice()
        {
            return this.price;
        }
        public void setisbn(int myisbn) //set method
        {
            this.isbn = myisbn;
        }
        public void setpages(int mypages)
        {
            this.pages = mypages;
        }
        public void setprice(double myprice)
        {
            this.price = myprice;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            //b.setisbn(100); // inti values
            //b.setpages(500);
            //b.setprice(.00);
            Console.WriteLine(b.getisbn());
            Console.WriteLine(b.getpages());
            Console.WriteLine(b.getprice());
        }
    }
}
