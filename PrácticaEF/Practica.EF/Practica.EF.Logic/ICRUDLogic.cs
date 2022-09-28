using System.Collections.Generic;

namespace Practica.EF.Logic
{
    public interface ICRUDLogic<T>
    {
        List<T> GetAll();
        void Add(T itemToAdd);
        void Update(T updatedItem);
        void Delete(int id);
    }
}