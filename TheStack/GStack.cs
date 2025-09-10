using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStack
{
    internal class GStack<T>
    {
        List<T> _gList;

        public List<T> GList
        {
            get { return _gList; }
            set { _gList = value; }
        }

        public void Push(T item)
        {
            _gList.Add(item);
        }
        public T Pop()
        {
                T pop = _gList.Last();
                _gList.RemoveAt(_gList.Count() - 1);
                return pop;
        }

        public T Peek()
        {
            return GList.Last();
        }
        public int Count()
        {
            return GList.Count();
        }
        public string CurrentType()
        {  
            return Convert.ToString(typeof(T));
        }
        public GStack()
        {
            _gList = new List<T>();
        }
    }
}
