using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarServiceDB
{
    class DAL
    {
        string connectionString = @"Data Source=DESKTOP-HKUF1MT\SQLEXPRESS; Initial Catalog = Автосервис; Integrated Security = True;";
        public ArrayList GetAllClients()
        {
            ArrayList allClients = new ArrayList();
            string query = "select * from dbo.[Клиенты] order by [ФИО клиента]";
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                        foreach (DbDataRecord result in reader)
                        {
                            allClients.Add(result);
                        }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }   
            return allClients;
        }
        public ArrayList GetAllSevicesForClients(string clientID)
        {
            ArrayList allServices = new ArrayList();
            string query = string.Format("Select dbo.[Оказываемые услуги].*, dbo.[Персонал].ФИО from dbo.[Оказываемые услуги], dbo.[Клиенты и услуги], dbo.[Клиенты], dbo.Персонал, dbo.[Персонал и оказываемые услуги] where dbo.[Клиенты и услуги].[ID клиента] = dbo.[Клиенты].[ID клиента] and dbo.[Клиенты и услуги].[ID услуги] = dbo.[Оказываемые услуги].[ID услуги] and dbo.[Клиенты и услуги].[ID клиента] = '{0}' and dbo.[Персонал и оказываемые услуги].[ID персонала] = dbo.[Персонал].[ID работника] and dbo.[Персонал и оказываемые услуги].[ID оказываемой услуги] = dbo.[Оказываемые услуги].[ID услуги]", clientID);
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            using (connection)
            {
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                        foreach (DbDataRecord result in reader)
                        {
                            allServices.Add(result);
                        }    
                    
                }
                catch(Exception ex)
                {
                   MessageBox.Show(ex.Message);
                }
            }
                return allServices;
        }
        public ArrayList GetAllWorkers()
        {
            ArrayList allWorkers = new ArrayList();
            string query = string.Format("select * from dbo.Персонал");
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            using (connection)
            {
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        foreach (DbDataRecord result in reader)
                        {
                            allWorkers.Add(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return allWorkers;
            }
        }
        public ArrayList GetAllSevices()
        {
            ArrayList allServices = new ArrayList();
            string query = string.Format("Select * from dbo.[Оказываемые услуги]");
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            using (connection)
            {
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                        foreach (DbDataRecord result in reader)
                        {
                            allServices.Add(result);
                        }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return allServices;
        }
        public bool AddNewCalling(string clientID, string serviceID)
        {
            bool flagresult = false;
            string query = string.Format("INSERT INTO dbo.[Клиенты и услуги] ([ID клиента], [ID услуги]) VALUES ('{0}', '{1}')", clientID, serviceID);
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            using (connection)
            {
                try
                {
                    connection.Open();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        flagresult = true;
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
                return flagresult;
        }
        public bool AddNewService(Guid serviceID, string serviceName, decimal servicePrice, string workerID)
        {

            bool flagresult = false;
            string query = string.Format("INSERT INTO dbo.[Оказываемые услуги] ([ID услуги], [Наименование услуги], [Стоимость услуги]) VALUES ('{0}', '{1}', '{2}')", serviceID, serviceName, servicePrice);
            string query1 = string.Format("insert into dbo.[Персонал и оказываемые услуги] ([ID персонала], [ID оказываемой услуги]) values ('{0}', '{1}')", workerID, serviceID);
            SqlConnection connection = new SqlConnection(connectionString);

            using (connection)
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlCommand command1 = new SqlCommand(query1, connection);
                try
                {
                    connection.Open();
                    if ((command.ExecuteNonQuery() == 1) && (command1.ExecuteNonQuery() == 1))
                    {
                        flagresult = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
                return flagresult;
        }
        public bool AddNewClient(string clientName, string registrationDate, string phoneNumber, string email)
        {
            bool flagresult = false;
            Guid clientID = Guid.NewGuid();
            string query = string.Format("INSERT INTO dbo.[Клиенты] ([ID клиента], [ФИО клиента], [Дата регистрации клиента], [Номер телефона клиента], [Электронная почта клиента]) VALUES ('{0}','{1}','{2}','{3}','{4}')",clientID, clientName, registrationDate, phoneNumber, email);
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            using (connection)
            {
                try
                {
                    connection.Open();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        flagresult = true;
                    }    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
                return flagresult;
        }
        public bool AddNewWorker(string workerName, string phoneNumer, string serviceID)
        {
            Guid workerID = Guid.NewGuid();
            bool flagresult = false;
            string query1 = string.Format("INSERT INTO dbo.Персонал ([ID работника], [ФИО], [Номер телефона]) VALUES ('{0}', '{1}', '{2}')", workerID, workerName, phoneNumer);
            string query2 = string.Format("insert into dbo.[Персонал и оказываемые услуги] ([ID персонала], [ID оказываемой услуги]) values ('{0}', '{1}')", workerID, serviceID);
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command1 = new SqlCommand(query1, connection);
            SqlCommand command2 = new SqlCommand(query2, connection);
            using (connection)
            {
                try
                {
                    connection.Open();  
                    if (command1.ExecuteNonQuery()==1 && command2.ExecuteNonQuery() == 1)
                    {
                        flagresult = true;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
                return flagresult;
        }
        public void InsertPhoneNumber(TextBox textBox)
        {
            string phoneNumber;
            phoneNumber = textBox.Text;
            if (phoneNumber.Length == 6)
            {
                textBox.Text = textBox.Text + ")";
                textBox.SelectionStart = textBox.Text.Length;
            }
            if (phoneNumber.Length == 10)
            {
                textBox.Text = textBox.Text + "-";
                textBox.SelectionStart = textBox.Text.Length;
            }
            if (phoneNumber.Length == 13)
            {
                textBox.Text = textBox.Text + "-";
                textBox.SelectionStart = textBox.Text.Length;
            }
        }
    }
}

