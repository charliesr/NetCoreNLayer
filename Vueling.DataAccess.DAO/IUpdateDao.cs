using Vueling.Common.Logic.Models;
using Vueling.DataAccess.DAO.Formats;

namespace Vueling.DataAccess.DAO
{
    public interface IUpdateDao<T> : IUpdate<T>, IBaseDao where T : IVuelingModelObject { }
}
