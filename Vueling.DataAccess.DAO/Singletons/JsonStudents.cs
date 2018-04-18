using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Vueling.Common.Logic;
using Vueling.Common.Logic.Models;
using Vueling.Common.Logic.Utils;
using Vueling.DataAccess.DAO.Formats;

namespace Vueling.DataAccess.DAO.Singletons
{
    public class JsonStudents
    {
        private readonly IVuelingLogger _log = ConfigurationUtils.LoadLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private static JsonStudents _instance;
        private readonly List<Student> _students;
        private static object syncLock = new object();

        protected JsonStudents()
        {
            _log.Debug(new StringBuilder(LogLiterals.NewSingletonInstance).Append(typeof(JsonStudents).FullName));
            var _format = FormatFactory<Student>.GetFormat(DataTypeAccess.json);
            _students = _format.GetAll();
        }

        public static JsonStudents GetInstance()
        {
            if (_instance == null)
            {
                lock (syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new JsonStudents();
                    }
                }
            }
            return _instance;
        }

        public List<Student> GetAll()
        {
            _log.Debug(new StringBuilder(LogLiterals.ReturningFromSingleton).Append(typeof(Student).FullName));
            return _students;
        }
    }
}
