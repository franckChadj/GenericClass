namespace GenericClass
{
    // the constrainst that forces GenericLcass to be instanciated only by value types
    public class GenericClass<T> where T : struct
    {
        // Create the private list for the class
        private List<T> _col;
        
        // Method that add an item to the private collection
        public void addItem(T item)
        {
            _col.Add(item);
        }

        //the method to search an item within the list
        public T searchItem(int index)
        {
            if (index >= 0 && index < _col.Count)
                return _col[index];
            throw new IndexOutOfRangeException("Index is out of range.");
        }

        //the method that returns the reversed sorted list
        public ICollection<T> reverseSortedList()
        {
            List<T> sortedCol = _col.OrderByDescending(x => x).ToList();
            return sortedCol;
        }

    }
}
