using RealWordExample_DecoratorDesignPattern.Abstract;
using System;

namespace RealWordExample_DecoratorDesignPattern.Class
{
    public class Book : Library
    {
        private string _author;
        private string _title;

        public Book(string author, string title, int numCopies)
        {
            _author = author;
            _title = title;
            NumCopies = numCopies; // Kapsülleme
        }
        public override void Display()
        {
            Console.WriteLine("\n-------------- Kitap -------------");
            Console.WriteLine("\n Yazar: {0} ", _author);
            Console.WriteLine("\n Başlık: {0} ", _title);
            Console.WriteLine("\n Kopya Sayısı: {0} ", NumCopies);
        }
    }
}
