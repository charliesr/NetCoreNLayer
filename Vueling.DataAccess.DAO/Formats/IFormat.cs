using Vueling.Common.Logic.Models;

namespace Vueling.DataAccess.DAO.Formats
{
    public interface IFormat<T> : ISelect<T>, IInsert<T>, IUpdate<T>, IDelete<T> where T : IVuelingModelObject { }
}