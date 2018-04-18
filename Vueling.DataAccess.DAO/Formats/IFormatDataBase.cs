using Vueling.Common.Logic.Models;

namespace Vueling.DataAccess.DAO.Formats
{
    public interface IFormatDataBase<T> : IFormatText<T>, IDelete<T>, IUpdate<T> where T : IVuelingModelObject
    {
    }
}
