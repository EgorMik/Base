using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11
{
    class ListArray :IList<int>, IEnumerator<int>
    {
         private int[] _collection = new int[1000];
    private int _position = -1;


    private void CheckArraySize()
    {
        if (Count == _collection.Length)
        {
            Array.Resize(ref _collection, _collection.Length + 1000);
        }
    }

    private void CheckIndex(int index)
    {
        if ((index > Count) || (index <= 0))
        {
            throw new Exception();
        }
    }

    public int this[int index]
    {
        get
        {
            this.CheckIndex(index);
            return _collection[index];
        }
        set
        {
            this.CheckIndex(index);
            _collection[index] = value;
        }
    }

    public int Count { get; private set; } = 0;


    public bool IsReadOnly
    {
        get
        {
            return false;
        }
    }

    object IEnumerator.Current
    {
        get
        {
            return Current;
        }
    }

    public int Current
    {
        get
        {
            return _collection[_position];
        }
    }


    public void Add(int item)
    {
        _collection[Count] = item;
        Count++;
        this.CheckArraySize();
    }

    public void Clear()
    {
        this.Count = 0;
    }

    public bool Contains(int item)
    {
        for (int i = 0; i < Count; i++)
        {
            if (_collection[i] == item)
            {
                return true;
            }
        }
        return false;
    }

    public void CopyTo(int[] array, int arrayIndex)
    {
        for (int i = 0; i < Count; i++)
        {
            array[arrayIndex + i] = this._collection[i];
        }
    }

    public IEnumerator<int> GetEnumerator()
    {
        return (IEnumerator<int>)this;
    }

    public int IndexOf(int item)
    {
        for (int i = 0; i < Count; i++)
        {
            if (_collection[i] == item)
            {
                return i;
            }
        }
        return -1;
    }


    public void Insert(int index, int item)
    {
        this.CheckArraySize();
        this.CheckIndex(index);

        for (int i = Count - 1; i >= index; i--)
        {
            this._collection[i + 1] = this._collection[i];
        }
        this._collection[index] = item;
        this.Count++;
    }

    public bool Remove(int item)
    {
        bool beInThisCollectionMarker = false;
        for (int i = 0; i < Count; i++)
        {
            if (_collection[i] == item)
            {
                this.RemoveAt(i);
                beInThisCollectionMarker = true;
            }
        }
        return beInThisCollectionMarker;
    }

    public void RemoveAt(int index)
    {
        this.CheckIndex(index--);
        for (int i = index; i < Count - 1; i++)
        {
            this._collection[i] = this._collection[i + 1];
        }
        this.Count--;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this._collection.GetEnumerator();
    }

    public void Dispose()
    {

    }

    public bool MoveNext()
    {
        _position++;
        return (_position <= Count);

    }

    public void Reset()
    {
        _position = -1;
    }
    }
}
