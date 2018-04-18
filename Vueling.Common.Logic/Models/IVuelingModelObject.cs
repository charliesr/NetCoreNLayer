using System;

namespace Vueling.Common.Logic.Models
{
    public interface IVuelingModelObject : ICloneable
    {
        Guid Guid { get; set; }
        object GetObjectWithoutId();
    }
}
