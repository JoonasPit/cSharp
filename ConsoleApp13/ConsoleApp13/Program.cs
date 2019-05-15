using System;

namespace ConsoleApp13
{
    public void VertaileKirja(Kirja kirja)
    {

    }
    public class Kirja
    {
        String bookName,bookAuthor;
        int bookPages;
        double bookPrice;

       public Kirja()
        {
            bookName = "";
            bookAuthor = "";
            bookPages = 0;
            bookPrice = 0;
        }

        public Kirja(String bookName, String bookAuthor, int bookPages, double bookPrice)
        {
            this.bookName = bookName;
            this.bookAuthor = bookAuthor;
            this.bookPages = bookPages;
            this.bookPrice = bookPrice;
        }


        public String printOut()
        {
            return bookName + ", " + bookAuthor + ", " + bookPages + ", "  + bookPrice;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Kirja book = new Kirja("Kirja", "K. Kirjoittaja", 528, 21.8);
            Console.WriteLine(book.printOut());
          
        }
    }
}
