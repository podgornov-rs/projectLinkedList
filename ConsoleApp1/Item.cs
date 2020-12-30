﻿using System;

namespace projectLinkedList
{
    public class Item<T>
    {
        /// <summary>
        /// Данные хранимые в ячейки списка
        /// </summary>
        private T data = default(T);

        public T Data
        {
            get => data;
            set
            {
                if(value!=null)
                {
                    data = value;
                }
                else
                {
                    throw new ArgumentNullException(nameof(value));
                }
            }
        }

        /// <summary>
        /// Следеющая ячейка списка
        /// </summary>
        public Item<T> Next{ get; set; }

        public Item(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }


    }
}
