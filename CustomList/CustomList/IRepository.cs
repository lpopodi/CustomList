using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public interface IRepository<T Tkey>
    {
        IEnumerable<T> GetItems();

        T GetItem(Tkey key);

        void AddItem(T newItem);

        void UpdateItem(Tkey key, T updatedItem);

        void DeleteItem(Tkey key);

        void UpdatedItems(IEnumerable<T> updatedItems);
    }
}
