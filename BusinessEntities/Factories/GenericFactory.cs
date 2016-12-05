using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class GenericFactory<T>
    {
        private GenericFactory() { }

        static readonly Dictionary<Guid, Func<T>> _dict = new Dictionary<Guid, Func<T>>();

        public static T Create(Guid key)
        {
            Func<T> constructor = null;
            if (_dict.TryGetValue(key, out constructor))
                return constructor();

            throw new ArgumentException("No type registered for this key");
        }

        public static void Register(Guid key, Func<T> creator)
        {
            _dict.Add(key, creator);
        }
    }
}
