using Vueling.Common.Logic;
using Vueling.Common.Logic.Models;

namespace Vueling.DataAccess.DAO.Formats
{
    public interface IFormatText<T> : ISelect<T>, IInsert<T> where T : IVuelingModelObject { }
}