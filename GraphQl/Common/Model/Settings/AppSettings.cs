using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model.Settings
{
    #region AppSettings
    public class AppSettings
    {
        public string[] CorsSetting { get; set; } = new string[0];
        public MongoConnectionModel MongoConnection { get; set; } = new MongoConnectionModel();

    }
    #endregion

    #region Base ConnectionStringModel
    public class ConnectionStringModel
    {
        public string ConnectionString { get; set; } = string.Empty;
    }
    #endregion

    #region MongoConnectionModel
    public class MongoConnectionModel : ConnectionStringModel
    {
        public string InstanceName { get; set; } = string.Empty;
    }
    #endregion

}
