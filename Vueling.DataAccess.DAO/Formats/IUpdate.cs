using System;
using Vueling.Common.Logic.Models;

namespace Vueling.DataAccess.DAO.Formats
{
    public interface IUpdate<T> where T : IVuelingModelObject
    {
        bool Update(Guid guid, T entity);
    }
}
