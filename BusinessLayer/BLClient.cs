using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;


namespace BusinessLayer
{
    public class BLClient
    {
        private DLClient objectClient = new DLClient();

        public DataTable showClients()
        {
            DataTable tabla = new DataTable();
            tabla = objectClient.showClients();
            return tabla;
        }

        public void addClient(string name, string lastName, string gender, string age, string phone, string address)
        {
            objectClient.addClient(name, lastName, gender, Convert.ToInt32(age), phone, address);
        }

        public void editClient(string id, string name, string lastName, string gender, string age, string phone, string address)
        {
            objectClient.editClient(Convert.ToInt32(id), name, lastName, gender, Convert.ToInt32(age), phone, address);
        }

        public void deleteClient(string id)
        {
            objectClient.deleteClient(Convert.ToInt32(id));
        }
    }
}
