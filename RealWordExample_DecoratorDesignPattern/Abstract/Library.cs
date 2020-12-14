namespace RealWordExample_DecoratorDesignPattern.Abstract
{
    public abstract class Library
    {
        private int _numCopies;
        public int NumCopies
        {
            get { return _numCopies; }
            set { _numCopies = value; }
        }
        public abstract void Display();
    }
}
