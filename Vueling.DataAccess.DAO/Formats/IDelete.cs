using System;
using Vueling.Common.Logic.Models;

namespace Vueling.DataAccess.DAO.Formats
{
    public interface IDelete<T> where T : IVuelingModelObject
    {
        bool DeleteByGuid(Guid guid);
    }
}