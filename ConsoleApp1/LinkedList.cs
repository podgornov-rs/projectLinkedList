using System.Collections;

namespace projectLinkedList
{
    /// <summary>
    /// Односвязный список
    /// </summary>
    public class LinkedList<T> : IEnumerable
    {
        /// <summary>
        /// Первый элемент списка
        /// </summary>
        public Item<T> Head { get; private set; }

        /// <summary>
        /// Последний элемент списка
        /// </summary>
        public Item<T> Tail { get; private set; }

        /// <summary>
        /// Количество элементов в списке
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Создать пустой список
        /// </summary>
        public LinkedList()
        {
            Clear();
        }

        /// <summary>
        /// Создать список с начальным элементом
        /// </summary>
        /// <param name="data"></param>
        public LinkedList(T data)
        {
            SetHeadAndTail(data);
        }

        /// <summary>
        /// Добавить данные в конец списка
        /// </summary>
        /// <param name="data"></param>
        public void Add(T data)
        {
            if (Tail != null)
            {
                Item<T> item = new Item<T>(data);
                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else
            {
                SetHeadAndTail(data);
            }
        }

        /// <summary>
        /// Удалить первое вхождение данныx список
        /// </summary>
        /// <param name="data"></param>
        public void Delete(T data)
        {
            if(Head != null)
            {

                if(Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }

                var current = Head.Next;
                var previous = Head;

                while(current.Next != null)
                {
                    if(current.Data.Equals(data))
                    {
                        previous.Next = current.Next;
                        Count--;
                    }
                    previous = current;
                    current = current.Next;
                }
            }
        }

        /// <summary>
        /// Добавить данные в начало списка
        /// </summary>
        public void AppendHead(T data)
        {
            var item = new Item<T>(data);
            {
                item.Next = Head;
            }
            Head = item;
            Count++;
        }

        /// <summary>
        /// Очистить списк
        /// </summary>
        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        private void SetHeadAndTail(T data)
        {
            Item<T> item = new Item<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }

        /// <summary>
        /// Получить перечисление всех элементов списка
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while(current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public override string ToString()
        {
            return "LinkedList" + Count + " элементов";
        }

    }
}
