using System.Collections;

public class ArrayCustomEnumerator:IEnumerator
{
    private Object[] _array;
    private int index = -1;
    public ArrayCustomEnumerator(Object[] array)
    {
        _array = array;
    }

    public object Current => _array[index];

    public bool MoveNext()
    {
        if (index <= _array.Length-1)
        {
            index++;
            return true;
        }
        return false;
    }

    public void Reset()
    {
        index = -1;
    }
}