﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace GeometryCollections {
    public class SimpleList<T>: IEnumerable<T> where T : IComparable {

        protected SimpleListItem<T> First = null;
        protected SimpleListItem<T> Last = null;
        public int Count { get; protected set; }

        public void Add(T elem) {
            SimpleListItem<T> NewItem = new SimpleListItem<T>(elem);
            Count++;
            if (Last == null) {
                First = NewItem;
                Last = NewItem;
            }
            else {
                Last.Next = NewItem;
                Last = NewItem;
            }
        }

        public SimpleListItem<T> GetItem(int index) {
            if ((index < 0) || (index >= Count)) {
                throw new Exception("Выход за границы списка.");
            }
            SimpleListItem<T> Current = First;
            int i = 0;
            while (i < index) {
                Current = Current.Next;
                i++;
            }
            return Current;
        }

        public T Get(int index) {
            return GetItem(index).Data;
        }

        public IEnumerator<T> GetEnumerator() {
            SimpleListItem<T> Current = First;
            while (Current != null) {
                yield return Current.Data;
                Current = Current.Next;
            }
        }
        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }

        public void Sort() {
            Sort(0, Count - 1);
        }

        private void Sort(int low, int high) {
            int i = low, j = high;
            T x = Get((low + high) / 2);
            while (i <= j) {
                while (Get(i).CompareTo(x) < 0) ++i;
                while (Get(j).CompareTo(x) > 0) --j;
                if (i <= j) {
                    Swap(i, j);
                    i++; j--;
                }

            }
            if (low < j) Sort(low, j);
            if (i < high) Sort(i, high);
        }

        private void Swap(int i, int j) {
            SimpleListItem<T> ci = GetItem(i);
            SimpleListItem<T> cj = GetItem(j);
            T temp = ci.Data;
            ci.Data = cj.Data;
            cj.Data = temp;
        }

    }
}
