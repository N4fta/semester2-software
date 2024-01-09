using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;


namespace Final_Indv_Assg___Work_Tasks_by_Nuno.Classes
{
    [Serializable]
    public class Company
    {
        public Employee User { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public List<CompanyTask> CompanyTasks { get; set; } = new List<CompanyTask>();
        private SqlConnection conn = new SqlConnection("Server=mssqlstud.fhict.local;Database=dbi540432_student;User Id=dbi540432_student;Password=Martin1234;");

        private void LoadCSV(string filePath = "./Resources/MOCK_EMPLOYEE_DATA.csv")
        {
            try
            {
                using (var reader = new StreamReader(filePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    Employees.Clear();
                    Employee.ResetTakenIDs();
                    Employees = csv.GetRecords<Employee>().ToList();
                }
                //MessageBox.Show("CSVHelper Successful");
            }
            catch
            {
                //MessageBox.Show("CSVHelper Failed");
                try
                {
                    FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read);
                    using (TextFieldParser MyReader = new TextFieldParser(fs)) // OpenFile generates READ ONLY FileStream
                    {
                        MyReader.Delimiters = new string[] { ",", ";" };
                        MyReader.TrimWhiteSpace = true;
                        MyReader.ReadLine();
                        Employees.Clear();
                        Employee.ResetTakenIDs();
                        while (!MyReader.EndOfData)
                        {
                            string[] row = MyReader.ReadFields();
                            try
                            {
                                if (Enum.TryParse(row[10].Replace(" ", ""), out Departments department))
                                {
                                    Employees.Add(new Employee(Convert.ToInt32(row[0]), row[1], row[2], row[3], row[4], row[5], Convert.ToInt32(row[6]), row[7], row[8], row[9], department));
                                }
                            }
                            catch
                            {
                                //MessageBox.Show($"Employee id {row[0]} was not created");
                            }
                        }
                        //MessageBox.Show("TextFieldParser Successful");
                    }
                }
                catch
                {
                    MessageBox.Show("CSV file import Failed");
                }
            }
            if (Employees.Where(employee=>employee.Email == "admin").Count()==0) Employees.Add(new Employee("Admin", "", "admin", "admin", true));
        }
        private void SaveCSV(string filePath = "./Resources/MOCK_EMPLOYEE_DATA.csv")
        {
            try
            {
                using (var writer = new StreamWriter(filePath))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(Employees);
                }
            }
            catch
            {
                MessageBox.Show("File couldn't be saved");
            }
        }
#pragma warning disable SYSLIB0011
        private void SaveBinary(string filePath = "./Resources/AllMightySave.bf")
        {
            FileStream fs = null;
            BinaryFormatter bf = null;
            try
            {
                fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
                bf = new BinaryFormatter();
                bf.Serialize(fs, this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (fs != null) fs.Close();
            }
        }
#pragma warning restore SYSLIB0011
        private void LoadDatabase()
        {
            string sql = "SELECT * FROM [Employees] ORDER BY [id];";
            SqlCommand cmd = new SqlCommand(sql, conn);

            try
            {
                Employees.Clear();
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Departments department = Departments.All;
                    switch (Convert.ToInt32(dr[10]))
                    {
                        case 1:
                            department = Departments.All;
                            break;
                        case 2:
                            department = Departments.HumanResources;
                            break;
                        case 3:
                            department = Departments.Marketing;
                            break;
                        case 4:
                            department = Departments.Sales;
                            break;
                        case 5:
                            department = Departments.Support;
                            break;
                        case 6:
                            department = Departments.ResearchandDevelopment;
                            break;
                    }
                    //MessageBox.Show($"dr[11] = {dr[11]}\r\ndr[12] = {dr[12]}");
                    Employees.Add(new Employee(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), Convert.ToInt32(dr[6]), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(), department, dr[11].ToString(), (bool)dr[12]));
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void AddEmployeeToDatabase(Employee employee)
        {
            // Check if Member already exists
            string sql = "INSERT INTO [dbo].[Employees] ([id], [ssn], [first_name], [last_name], [gender], [street_name], [street_number], [zipcode], [city], [email], [department_id], [password], [admin]) " +
                "VALUES " +
                $"({employee.Id}" +
                $",\'{employee.Ssn}\'" +
                $",\'{employee.FirstName}\'" +
                $",\'{employee.LastName}\'" +
                $",\'{employee.Gender}\'" +
                $",\'{employee.StreetName}\'" +
                $",{employee.StreetNumber}" +
                $",\'{employee.ZipCode}\'" +
                $",\'{employee.City}\'" +
                $",\'{employee.Email}\'";
            switch (employee.Department)
            {
                case Departments.All:
                    sql += ",1";
                    break;
                case Departments.HumanResources:
                    sql += ",2";
                    break;
                case Departments.Marketing:
                    sql += ",3";
                    break;
                case Departments.Sales:
                    sql += ",4";
                    break;
                case Departments.Support:
                    sql += ",5";
                    break;
                case Departments.ResearchandDevelopment:
                    sql += ",6";
                    break;
            }
            sql += $",\'{employee.Password}\'";
            if (employee.Admin) sql += ",1)";
            else sql += ",0)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                int effectedRows = cmd.ExecuteNonQuery();
                //MessageBox.Show(effectedRows.ToString());
                conn.Close();
            }
            catch (SqlException ex)
            {
                if (ex.Number != 2627) // Code for violation of Primary key aka Employee with that ID already exists
                {
                    MessageBox.Show(ex.Message);
                }
            }
            finally
            {
                conn.Close();
            }
            
        }
        private void SaveDatabase()
        {
            foreach (Employee emp in Employees)
            {
                AddEmployeeToDatabase(emp);
            }
        }

        // Valid methods are Database, CSV and Binary
        // Filepath is optional
        public void Load(string method, string filePath = "./Resources/AllMightySave.bf")
        {
            switch (method)
            {
                case "Binary":
#pragma warning disable SYSLIB0011
                    FileStream fs = null;
                    BinaryFormatter bf = null;
                    try
                    {
                        fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                        bf = new BinaryFormatter();
                        //company = (Company)bf.Deserialize(fs); // Function in Form since it assigns a new value to company
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Couldn't find saveFile");
                    }
                    finally
                    {
                        if (fs != null) fs.Close();
                    }
#pragma warning restore SYSLIB0011
                    break;
                case "CSV":
                    LoadCSV(filePath);
                    break;
                case "Database":
                    LoadDatabase();
                    break;
                default:
                    // No Loading of Employees on boot
                    break;
            }
        }
        public void Save(string method, string filePath = "./Resources/AllMightySave.bf")
        {
            switch (method)
            {
                case "Binary":
                    SaveBinary(filePath);
                    break;
                case "CSV":
                    SaveCSV(filePath);
                    break;
                case "Database":
                    SaveDatabase();
                    break;
                default:
                    MessageBox.Show("Invalid method");
                    break;
            }
        }

        public CompanyTask[] GetTasks(string title = "", Statuses status = Statuses.All, Departments department = Departments.All)
        {
            List<CompanyTask> result = CompanyTasks;

            if (!string.IsNullOrWhiteSpace(title))
            {
                result = result.Where(task => task.Title.Contains(title)).ToList();
            }
            if (status != Statuses.All)
            {
                result = result.Where(task => task.Status == status).ToList();
            }
            if (department != Departments.All)
            {
                result = result.Where(task => task.Departments != null && task.Departments.Contains(department)).ToList();
            }
            if (User != null && User.Email != "admin")
            {
                result = result.Where(task => task.Employees.Contains(User)).ToList();
            }
            return result.ToArray();
        }
    }
}
