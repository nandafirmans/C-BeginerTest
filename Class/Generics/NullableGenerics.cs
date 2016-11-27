using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Class.Generics
{
    public class NullableGenerics<T> where T : struct
    {
        private object _value;

        public NullableGenerics()
        {
        }

        public NullableGenerics(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; }
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
            {
                return (T)_value;
            }

            return default(T);
        }
    }
}
