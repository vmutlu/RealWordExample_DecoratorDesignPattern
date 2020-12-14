using RealWordExample_DecoratorDesignPattern.Abstract;
using System;

namespace RealWordExample_DecoratorDesignPattern.Class
{
    public class Video : Library
    {
        private string _director;
        private string _title;
        private int _playTime;

        public Video(string director, string title, int numCopies, int playTime)
        {
            this._director = director;
            this._title = title;
            this.NumCopies = numCopies;
            this._playTime = playTime;
        }

        public override void Display()
        {
            Console.WriteLine("\nVideo ----- ");
            Console.WriteLine(" Yönetmen: {0}", _director);
            Console.WriteLine(" Başlık: {0}", _title);
            Console.WriteLine(" # Kopya: {0}", NumCopies);
            Console.WriteLine(" Oyun Süresi: {0}\n", _playTime);
        }
    }
}
