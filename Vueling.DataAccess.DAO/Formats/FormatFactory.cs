using System;
using System.Reflection;
using Vueling.Common.Logic;
using Vueling.Common.Logic.Models;

namespace Vueling.DataAccess.DAO.Formats
{
    public static class FormatFactory<T> where T : IVuelingModelObject
    {
        public static IFormat<T> GetFormat(DataTypeAccess dataTypeAccess)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var typeString = string.Concat(assembly.GetName().Name, ".", dataTypeAccess.ToString().Substring(0, 1).ToUpper(), dataTypeAccess.ToString().Substring(1), "Format`1");
            var type = assembly.GetType(typeString);
            return (IFormat<T>)Activator.CreateInstance(type.MakeGenericType(typeof(T)));
        }
    }
}

