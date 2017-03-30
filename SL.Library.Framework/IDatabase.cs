using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Library.Framework
{
    public interface IDatabase
    {
        /* Explose database connection to plugin, or for custom use */

        /// <summary>
        /// Acquire database connection.
        /// Used to explose native DbConnection to plugin.
        /// </summary>
        /// <returns>Managed instance of database.</returns>
        IDatabaseInst Acquire();
        /// <summary>
        /// Release acquired database.
        /// In case of different database types, it may need immedite release after acquired.
        /// </summary>
        /// <param name="inst"></param>
        void Release(IDatabaseInst inst);


        /* Resources Management */

        Data.ResourceEntry AddResource(Data.ResourceEntry resource);
        Data.ResourceEntry GetResource(int id);

        void AlterResource(Data.ResourceEntry resource);
        void AlterPath(int id, string path);
        void AlterTags(int id, string tags);

        void DeleteResource(int id);


        /* Configuration operation */

        string ReadConfig(string key, string defaultValue = null);
        void WriteConfig(string key, string value);


    }
}
