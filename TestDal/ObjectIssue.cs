using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDal
{
  public class ObjectIssue
    {
        public Issue Issue { get; set; }
        public List<Issue> SubIssue { get; set; }
    }
}
