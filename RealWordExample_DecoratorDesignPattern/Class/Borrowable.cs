using RealWordExample_DecoratorDesignPattern.Abstract;
using System;
using System.Collections.Generic;

namespace RealWordExample_DecoratorDesignPattern.Class
{
    public class Borrowable : Decorator
    {
        protected List<string> borrowers = new List<string>();

        public Borrowable(Library libraryItem) : base(libraryItem)
        {
        }

        public void BorrowItem(string name)
        {
            borrowers.Add(name);
            libraryItem.NumCopies--;
        }

        public void ReturnItem(string name)
        {
            borrowers.Remove(name);
            libraryItem.NumCopies++;
        }

        public override void Display()
        {
            base.Display();

            foreach (string borrower in borrowers)
            {
                Console.WriteLine(" Borçlu Müşteri: " + borrower);
            }
        }
    }
}
