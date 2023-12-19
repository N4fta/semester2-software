using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;

namespace Week14_Day1___Extending_Student_Group
{
    public class ProjectGroup
    {
        private string _name;
        private int _ID;
        private List<Member> _members = new List<Member>();
        private SqlConnection conn = new SqlConnection("Server=mssqlstud.fhict.local;Database=dbi540432_student;User Id=dbi540432_student;Password=Martin1234;");

        public ProjectGroup(string name)
        {
            _name = name;
            _ID = 1;
        }
        public void AddMember(Member member)
        {
            
            // Check if Member already exists
            if (_members.Where(m => m.Name == member.Name).Count()>=1)
            {
                MessageBox.Show("Member already exists");
                return;
            }
            string studentNumber;
            if (member.StudentNumber == null)
            {
                studentNumber = "null";
            }
            else
            {
                studentNumber = member.StudentNumber.ToString();
            }
            string sql = "INSERT INTO [dbo].[Students] ([StudentName],[StudentNumber],[ProjectID])" +
                $"VALUES ('{member.Name}', {studentNumber}, {this._ID});";
            SqlCommand cmd = new SqlCommand(sql, conn);

            conn.Open();
            int effectedRows = cmd.ExecuteNonQuery();
            //MessageBox.Show(effectedRows.ToString());
            conn.Close();

            //_members.Add(member);

        }
        public Member[] GetMembers()
        {

            string sql = "SELECT * FROM [Students] ORDER BY [StudentName];";
            SqlCommand cmd = new SqlCommand(sql, conn);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            _members.Clear();
            while (dr.Read())
            {
                if (dr[1].GetType() != typeof(DBNull))
                {
                    _members.Add(new Member(dr[0].ToString(), Convert.ToInt32(dr[1])));
                }
                else
                {
                    _members.Add(new Member(dr[0].ToString()));
                }
            }
            conn.Close();

            return _members.ToArray();
        }
        public string GetInfo()
        {
            if (_members.Count == 0)
            {
                return _name;
            }
            string m = _name + ":";
            foreach (Member member in GetMembers())
            {
                m += " " + member.GetInfo();
            }
            return m;
        }
        public override string ToString()
        {
            return _name;
        }
    }
}
