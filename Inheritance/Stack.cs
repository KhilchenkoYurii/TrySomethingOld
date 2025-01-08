namespace Inheritance;

public class Stack
{
    private List<Object> _stack;

    public Stack()
    {
        _stack = new List<Object>();
    }
    public void Push(object element)
    {
        if (element == null)
            throw new InvalidOperationException("object can`t be null");
        _stack.Add(element);
    }

    public object Pop()
    {
        if(_stack.Count == 0)
            throw new InvalidOperationException("Stack is empty");
        int index = _stack.Count - 1;
        object result = _stack[index];
        _stack.RemoveAt(index);
        return result;
    }

    public void Clear()
    {
        _stack = new List<Object>();
    }

}