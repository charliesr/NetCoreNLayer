using Vueling.Common.Logic.Models;
using Vueling.DataAccess.DAO.Formats;

namespace Vueling.DataAccess.DAO
{
    public interface IInsertDao<T> : IInsert<T>, IBaseDao where T : IVuelingModelObject { }
}
