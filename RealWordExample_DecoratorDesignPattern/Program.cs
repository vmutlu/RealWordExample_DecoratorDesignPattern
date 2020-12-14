using RealWordExample_DecoratorDesignPattern.Class;
using System;

namespace RealWordExample_DecoratorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Veysel MUTLU", "Decorator Design Pattern", 100);
            book.Display();

            Video video = new Video("Veysel MUTLU", "Junior Developer.mp4", 23, 92);
            video.Display();

            Console.WriteLine("\n Video Ödünç Alınabilir Yapılıyor");

            Borrowable borrowvideo = new Borrowable(video);
            borrowvideo.BorrowItem("Müşteri #1");
            borrowvideo.BorrowItem("Müşteri #2");

            borrowvideo.Display();


            Console.ReadKey();
        }
    }
}
