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

namespace Final_Indv_Assg___Work_Tasks_by_Nuno.Classes
{
    [Serializable]
    public class Company
    {
        public Employee User { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public List<CompanyTask> CompanyTasks { get; set; } = new List<CompanyTask>();

        public void ImportCSV(string filePath = "./Resources/MOCK_EMPLOYEE_DATA.csv")
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
        public void ExportCSV(string filePath = "./Resources/MOCK_EMPLOYEE_DATA.csv")
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
        public void SaveAll(string filePath = "./Resources/AllMightySave.bf")
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
