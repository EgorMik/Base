using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork13
{
    class TwoLinkedList<T>: IList<T>, ICollection<T>, IEnumerable<T>
    {
        private class Cell<T>
        {
            public T _value;
            public Cell<T> _prev;
            public Cell<T> _next;
        }

        private Cell<T> _head;
        private Cell<T> _tail;

        public TwoLinkedList()
        {
            Count = 0;
            _head = null;
            _tail = null;
        }


        public T this[int index]
        {
            get
            {
                this.IndexCheckForGet(index);
                Cell<T> current = this.MoveToIndex(index);
                return current._value;
            }
            set
            {
                this.IndexCheckForSet(index);
                Cell<T> current = this.MoveToIndex(index);
                current._value = value;

            }
        }

        public int Count { get; private set; }

        public bool IsReadOnly => false;

        private void IndexCheckForSet(int index)
        {
            if ((index < 0) || (index > Count))
                throw new Exception("Out of the List");
        }
        private void IndexCheckForGet(int index)
        {
            if ((index < 0) || (index >= Count))
                throw new Exception("Out of the List");
        }
        private Cell<T> MoveToIndex(int index)
        {
            Cell<T> current = _head;
            int currentIndex = 0;
            while (currentIndex != index)
            {
                current = current._next;
                currentIndex++;
            }
            return current;
        }

        public void Add(T item)
        {
            Cell<T> current = new Cell<T>();
            current._value = item;
            if (Count == 0)
            {
                _head = current;
            }
            if (Count != 0)
            {
                current._prev = _tail;
                _tail._next = current;
            }
            _tail = current;
            Count++;
        }

        public void Clear()
        {
            Count = 0;
            _head = null;
            _tail = null;
        }

        public bool Contains(T item)
        {
            return this.IndexOf(item) != -1;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            int index = 0;
            Cell<T> current = _head;
            while (current != null)
            {
                array[arrayIndex + index] = current._value;
                current = current._next;
                index++;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            Cell<T> current = _head;
            while (current != null)
            {
                T value = current._value;
                current = current._next;
                yield return value;
            }
        }

        public int IndexOf(T item)
        {
            int index = 0;
            Cell<T> current = _head;
            while (current != null)
            {
                if (current._value.Equals(item))
                {
                    return index;
                }
                else
                {
                    current = current._next;
                    index++;
                }
            }
            return -1;
        }

        public void Insert(int index, T item)
        {
            IndexCheckForSet(index);
            if (index == Count)
            {
                this.Add(item);
            }
            else
            {
                if (index == 0)
                {
                    Cell<T> newCell = new Cell<T>();
                    newCell._value = item;
                    _head._prev = newCell;
                    newCell._next = _head;
                    _head = newCell;
                }
                else
                {
                    Cell<T> current = this.MoveToIndex(index);
                    Cell<T> newCell = new Cell<T>();
                    newCell._value = item;
                    newCell._prev = current._prev;
                    current._prev = newCell;
                    newCell._prev._next = newCell;
                    newCell._next = current;
                }
                Count++;
            }

        }

        public bool Remove(T item)
        {

            int index = 0;
            Cell<T> current = _head;
            while (current != null)
            {
                if (current._value.Equals(item))
                {
                    if (index == Count - 1)
                    {
                        current._prev._next = null;
                        _tail = current._prev;
                    }
                    else
                    {
                        if (index == 0)
                        {
                            current._next._prev = null;
                            _head = current._next;
                        }
                        else
                        {
                            current._prev._next = current._next;
                            current._next._prev = current._prev;
                        }
                    }
                    current._prev = null;
                    current._next = null;
                    Count--;
                    return true;
                }
                else
                {
                    current._next = current;
                    index++;
                }
            }

            return false;
        }

        public void RemoveAt(int index)
        {
            IndexCheckForGet(index);
            Cell<T> current = this.MoveToIndex(index);
            if (index == Count - 1)
            {
                current._prev._next = null;
                _tail = current._prev;
            }
            else
            {
                if (index == 0)
                {
                    current._next._prev = null;
                    _head = current._next;
                }
                else
                {
                    current._prev._next = current._next;
                    current._next._prev = current._prev;
                }
            }
            current._prev = null;
            current._next = null;
            Count--;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
