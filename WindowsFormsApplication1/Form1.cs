using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FrmBusinessEntity : Form
    {
        public FrmBusinessEntity()
        {
            InitializeComponent();
        }

        private string convertToSQLType(string internalType)
        {

            string sqlType = "";


            sqlType = internalType;
            return sqlType;
        
        }

        private string convertToSQLLength(string length)
        {

            string sqlLength = "";


            sqlLength = length;
            return sqlLength;

        }

        /// <summary>
        /// Generate database and code objects
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerate_Click(object sender, EventArgs e)
        {

            string tableScript = "Create table [" + txtEntityName.Text + "]  ( [Id] [int] IDENTITY(1,1) NOT NULL,  ";

            for (int i=0; i<grdAttributes.RowCount-1;i++)
            {

                tableScript = tableScript + grdAttributes.Rows[i].Cells[0].Value;

                tableScript = tableScript + " " + convertToSQLType(grdAttributes.Rows[i].Cells[1].Value.ToString() )+"  (" + convertToSQLLength(grdAttributes.Rows[i].Cells[2].Value.ToString())+")," ;

                



            }


            tableScript = tableScript + " CONSTRAINT [PK_" + txtEntityName.Text + "] PRIMARY KEY CLUSTERED ";
            tableScript=tableScript+" (";
            tableScript=tableScript+" 	[Id] ASC";
            tableScript = tableScript + " )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]";
            tableScript=tableScript+" ) ON [PRIMARY]";



            ///Generate trigger on table to build auditing
            if(chkAuditing.Checked)
            { 
            
            
            
            
            }

            ///Generate table and trigger to write old value in history table , naming convention entity_history
            if (chkHistory.Checked)
            { }

            ///Generate code to add log via log4Net on qualified events
            if (chkLogging.Checked)
            { }



        }
    }
}
