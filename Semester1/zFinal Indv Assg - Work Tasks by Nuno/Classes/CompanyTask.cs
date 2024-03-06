using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Indv_Assg___Work_Tasks_by_Nuno.Classes
{
    [Serializable]
    public class CompanyTask
    {
        [Ignore]
        private static int[] _takenIDs = new int[150];
        [Ignore]
        public int Id { get; set; } = 1;
        [Name("title")]
        public string Title { get; set; } = "";
        [Ignore]
        public List<Departments> Departments { get; set; } = new List<Departments>();
        [Name("status")]
        public Statuses Status { get; set; } = Statuses.Open;
        [Name("deadline")]
        public DateTime Deadline { get; set; } = DateTime.UtcNow;
        [Ignore]
        public List<Employee> Employees { get; set; } = new List<Employee>();
        [Name("description")]
        public string Description { get; set; } = "";

        public CompanyTask(string title, Statuses status, DateTime deadline, string description, List<Employee> employees = null, List<Departments> departments = null)
        {
            while (Array.IndexOf(_takenIDs, Id) != -1) Id++;
            Title = title;
            Departments = departments;
            Status = status;
            Deadline = deadline;
            Employees = employees;
            Description = description;
        }

        public static void ResetTakenIDs()
        {
            for (int i = 0; i < 150; i++) _takenIDs[i] = 0;
        }

        public override string? ToString()
        {
            return Title + " - " + Status.ToString();
        }
    }
}
