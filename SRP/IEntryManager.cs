using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    public interface IEntryManager<T>
    {
        public void AddEntity(T entity);

        public void RemoveEntryAt(int index);
    }
}
