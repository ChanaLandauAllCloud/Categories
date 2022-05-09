using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDal
{
    public class DataDal
    {
        public static List<ObjectIssue> GetIssues()
        {
            List<ObjectIssue> objects = new List<ObjectIssue>
            {
              new  ObjectIssue {
                Issue = new Issue
                {
                    ID = 1,
                    Name = "ארצות",

                },
                SubIssue= new List<Issue>
                {
                    new Issue
                    {
                        ID = 11,
                        Name = "ישראל"

                    },
                    new Issue
                    {
                        ID = 12,
                        Name = "בלגיה"

                    },
                    new Issue
                    {
                        ID = 13,
                        Name = "צרפת"

                    },
                    new Issue
                    {
                        ID = 14,
                        Name = "דנמרק"

                    },
                    new Issue
                    {
                        ID = 15,
                        Name = "הודו"

                    }

                }
             } ,

              new  ObjectIssue {
                Issue = new Issue
                {
                    ID = 2,
                    Name = "שמות בעלי חיים",

                },
                SubIssue= new List<Issue>
                {
                    new Issue
                    {
                        ID = 21,
                        Name = "אריה"

                    },
                    new Issue
                    {
                        ID = 22,
                        Name = "סוס"

                    } ,
                    new Issue
                    {
                        ID = 23,
                        Name = "זאב"

                    },            
                    new Issue
                    {
                        ID = 24,
                        Name = "חתול"

                    }, 
                    new Issue
                    {
                        ID = 25,
                        Name = "כלב"

                    }
                }
             } ,
              new  ObjectIssue {
                Issue = new Issue
                {
                    ID = 3,
                    Name = "שמות בני אדם",

                },
                SubIssue= new List<Issue>
                {
                    new Issue
                    {
                        ID = 31,
                        Name = "יהודה"

                    },
                    new Issue
                    {
                        ID = 32,
                        Name = "יעל"

                    },     
                    new Issue
                    {
                        ID = 33,
                        Name = "גלעד"

                    },
                    new Issue
                    {
                        ID = 34,
                        Name = "שירה"

                    },              
                    new Issue
                    {
                        ID = 35,
                        Name = "אור"

                    }

                }
             } ,

               new  ObjectIssue {
                Issue = new Issue
                {
                    ID = 4,
                    Name = "פירות וירקות",

                },
                SubIssue = new List<Issue>
                {
                    new Issue
                    {
                        ID = 41,
                        Name = "עגבניות"

                    },
                    new Issue
                    {
                        ID = 42,
                        Name = "מלפפונים"

                    },
                    new Issue
                    {
                        ID = 41,
                        Name = "תפוחים"

                    },
                    new Issue
                    {
                        ID = 42,
                        Name = "תפוזים"

                    },               
                    new Issue
                    {
                        ID = 42,
                        Name = "בטטות"

                    }

                }
                 },
              new  ObjectIssue {
                Issue = new Issue
                {
                    ID = 5,
                    Name = "מקצועות",

                },
                SubIssue= new List<Issue>
                {
                    new Issue
                    {
                        ID = 51,
                        Name = "מהנדס"

                    },
                    new Issue
                    {
                        ID = 52,
                        Name = "חייט"

                    } ,
                    new Issue
                    {
                        ID = 53,
                        Name = "מנהל חשבונות"

                    },
                    new Issue
                    {
                        ID = 54,
                        Name = "קבלן בנייה"

                    },
                    new Issue
                    {
                        ID = 25,
                        Name = "ספר"

                    }
                }
             } ,
              new  ObjectIssue {
                Issue = new Issue
                {
                    ID = 6,
                    Name = "מאכלים",

                },
                SubIssue= new List<Issue>
                {
                    new Issue
                    {
                        ID = 61,
                        Name = "לחם"

                    },
                    new Issue
                    {
                        ID = 62,
                        Name = "גבינה"

                    },
                    new Issue
                    {
                        ID = 63,
                        Name = "אורז"

                    },
                    new Issue
                    {
                        ID = 64,
                        Name = "פסטה"

                    },
                    new Issue
                    {
                        ID = 65,
                        Name = "נקניק"

                    }

                }
             } ,
               new  ObjectIssue {
                Issue = new Issue
                {
                    ID = 7,
                    Name = "מלחמות",

                },
                SubIssue= new List<Issue>
                {
                    new Issue
                    {
                        ID = 71,
                        Name = "מלחמת העולם הראשונה"

                    },
                    new Issue
                    {
                        ID = 72,
                        Name = "מלחמת המפרץ"

                    } ,
                    new Issue
                    {
                        ID = 73,
                        Name = "מלחמת וייטנאם"

                    },
                    new Issue
                    {
                        ID = 74,
                        Name = "מלחמת קוריאה"

                    },
                    new Issue
                    {
                        ID = 75,
                        Name = "מלחמת העולם הראשונה"

                    }
                }
             } ,
              new  ObjectIssue {
                Issue = new Issue
                {
                    ID = 8,
                    Name = "ערי בירה",

                },
                SubIssue= new List<Issue>
                {
                    new Issue
                    {
                        ID = 81,
                        Name = "ירושלים"

                    },
                    new Issue
                    {
                        ID = 82,
                        Name = "סיאול"

                    },
                    new Issue
                    {
                        ID = 83,
                        Name = "טוקיו"

                    },
                    new Issue
                    {
                        ID = 84,
                        Name = "רומא"

                    },
                    new Issue
                    {
                        ID = 85,
                        Name = "קייב"

                    }

                }
             } 
            };

            return objects;
        }



    }
}
