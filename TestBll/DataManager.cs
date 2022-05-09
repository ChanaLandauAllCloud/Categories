using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDal;

namespace TestBll
{
    public class DataManager
    {
        public static List< ObjectIssue> GetIssues()
        {
            return DataDal.GetIssues(); 
        }
        public static List<ObjectIssue> GetIssueBySearch(string txt)
        {
            List <ObjectIssue> issues = DataDal.GetIssues();
            return issues.Where(x=>x.Issue.Name.Contains(txt)).ToList();
        }
    }
}
