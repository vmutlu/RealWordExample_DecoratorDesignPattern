namespace RealWordExample_DecoratorDesignPattern.Abstract
{
    public abstract class Decorator : Library
    {
        protected Library libraryItem;

        public Decorator(Library libraryItem)
        {
            this.libraryItem = libraryItem;
        }

        public override void Display()
        {
            libraryItem.Display();
        }
    }
}
