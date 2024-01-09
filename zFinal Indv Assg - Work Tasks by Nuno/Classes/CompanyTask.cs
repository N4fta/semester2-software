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
        private static int[] _takenIDs = new int[150];
        public int Id { get; set; } = 1;
        public string Title { get; set; } = "";
        public List<Departments> Departments { get; set; } = new List<Departments>();
        public Statuses Status { get; set; } = Statuses.Open;
        public DateTime Deadline { get; set; } = DateTime.UtcNow;
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public string Description { get; set; } = "";

        public CompanyTask(string title, List<Departments> departments, Statuses status, DateTime deadline, List<Employee> employees, string description)
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
