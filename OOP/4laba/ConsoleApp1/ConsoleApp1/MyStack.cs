using System;
using System.Collections.Generic;
using System.Text;

namespace oop1
{
	class MyStack<T> where T:IComparable
	{
	
		private class Data
		{
			private Data next;
			private T value;

			public Data getNext()
			{
				return next;
			}
			public void setNext(Data next)
			{
				this.next = next;
			}
			public T getValue()
			{
				return value;
			}
			public void setValue(T value)
			{
				this.value = value;
			}

			public Data()
			{
				value = default;
				next = default;
			}

			public String toString()
			{
				return value + " ";
			}
		};

		private Data head;
		private Data start;

		public MyStack()
		{
			start = new Data();
			head = start;
		}

		public void push(T obj)
		{
			Data ne = new Data();
			ne.setValue(obj);
			head.setNext(ne);
			head = ne;
		}

		public T pop()
		{
			if (head == start) return default;
			Data oh = head;
			Data iterator = start;
			while (iterator.getNext() != null && iterator.getNext() != head)
			{
				iterator = iterator.getNext();
			}
			head = iterator;
			head.setNext(null);
			return oh.getValue();

		}
		public void clear()
		{
			while (head != start)
			{
				Data iterator = start;
				while (iterator.getNext() != null && iterator.getNext() != head)
				{
					iterator = iterator.getNext();
				}
				head = iterator;
				head.setNext(null);
			}
		}
		public void print()
		{
			if (head == start) return;
			Data iterator = start.getNext();
			while (iterator != null)
			{
				Console.WriteLine(iterator.toString());
				iterator = iterator.getNext();
			}
		}

		public MyStack<T> clone()
		{
			if (head == start) return new MyStack<T>();
			MyStack<T> cl = new MyStack<T>();
			for (Data iterator = start.getNext(); iterator != null; iterator = iterator.getNext())
			{
				cl.push(iterator.getValue());
			}
			return cl;
		}

		public bool isEmpty()
		{
			return head == start;
		}

		public override bool Equals(object obj)
		{
			if (!(obj is MyStack<T>)) return false;
			MyStack<T> sobj = (MyStack <T>)obj;
			MyStack<T> mcl = clone();
			while(sobj.head!=sobj.start||mcl.head!=mcl.start)
			{
				if (!sobj.pop().Equals(mcl.pop()))
					return false;
			}
			if (sobj.head == sobj.start || mcl.head == mcl.start)
				return true;
			return false;
		}

		public void sort()
		{
			if (head == start) return;
			for (Data iterator = start.getNext(); iterator != null; iterator = iterator.getNext())
			{
				for (Data insit = start.getNext(); insit != null; insit = insit.getNext())
				{
					if (iterator.getValue().CompareTo(insit.getValue()) > 0)
					{
						T temp = iterator.getValue();
						iterator.setValue(insit.getValue());
						insit.setValue(temp);
					}
				}
			}
		}
	}

}
