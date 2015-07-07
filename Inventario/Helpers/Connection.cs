using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Helpers
{
    class Connection
    {
        public Connection()
        {
            config = "Database=inventario;Data Source=localhost;User Id=root;Password=;";

            try {
                cnn = GetConnection();
                cnn.Open();
                cmd = GetMysqlCommand();
                version = Convert.ToString(cmd.ExecuteScalar());
            } catch (MySqlException e) {
                // MetroFramework.MetroMessageBox.Show(null, e.Message, "Fatal error - PowerDev", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                System.Windows.Forms.MessageBox.Show(e.Message);
                close();
            }

        }

        public void DataAdapter(string query)
        {
            data = new MySqlDataAdapter(query, cnn);
        }

        public MySqlDataAdapter GetDataAdapter()
        {
            return data;
        }

        public string Version 
        {
            get { return version; }
        }

        public void close()
        {
            try
            {
                cnn.Clone();
            } catch (MySqlException e) {
                Console.WriteLine(e.Message);
            }
        }

        public static T GetObject<T>(MySql.Data.MySqlClient.MySqlDataReader reader)
        {
            var obj = Activator.CreateInstance(typeof(T));
            var fields = obj.GetType().GetFields();

            foreach (var field in obj.GetType().GetFields())
            {
                var attrs = field.GetCustomAttributes(typeof(System.Runtime.Serialization.DataMemberAttribute), true) as System.Runtime.Serialization.DataMemberAttribute[];

                if (attrs.Length == 0)
                {
                    continue;
                }

                var fieldID = attrs[0].Name;
                var fieldType = field.FieldType;

                field.SetValue(obj, reader.GetValue(reader.GetOrdinal(fieldID)));
            }

            return (T)obj;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(config);
        }

        public MySqlCommand GetMysqlCommand(string query)
        {
            return new MySqlCommand(query, cnn);
        }

        private MySqlCommand GetMysqlCommand()
        {
            return new MySqlCommand("SELECT VERSION()", cnn);
        }

        private string config;
        private string version;
        private MySqlConnection cnn;
        private MySqlCommand cmd;
        private MySqlDataAdapter data;

    }
}
