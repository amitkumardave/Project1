using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
namespace WindowsFormsApplication1
{
    public partial class MogoStorage : Form
    {
        public MogoStorage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string connectionString = "mongodb://localhost/?safe=true";
            var client = new MongoClient(connectionString);
           
            MongoDatabaseBase database = (MongoDatabaseBase)client.GetDatabase("foo");
            var collection = database.GetCollection<BankInformation>("bank");
            for (int i = 0; i<500000;i++)
            { 
            var document = new BankInformation();
            document.BranchName = "Branchname" + i.ToString();
            document.AccountNumber = i.ToString();
            document.BranchCity = "Branch City " + i.ToString();
            document.BankName = "Bank name" + i.ToString();

            collection.InsertOne(document);
            }
             

         






        }

           }
}
