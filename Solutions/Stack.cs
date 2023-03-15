public partial class Program
{
    public class Stack
    {
        private List<object> _stack = new List<object>();
        public void Push(object obj)
        {
            if(obj == null)
                throw new InvalidOperationException("obj is null");
            else
                this._stack.Add(obj);
        }

        public object Pop()
        {
            if (_stack.Count == 0)
                throw new InvalidOperationException("Stack is empty");
            else
            {
                var lastIndex = _stack.Count - 1;
                object lastItem = _stack[lastIndex];
                _stack.RemoveAt(lastIndex);

                return lastItem;
            }
        }

        public void Clear()
        {
            _stack.Clear(); 
        }
    }
}