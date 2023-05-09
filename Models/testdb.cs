using testdb.Models;

namespace testdb.Data
{
    public class Appdbcontext:Appdbcontext
    {
        public Appdbcontext(Dbcontextoption<Appdbcontext>Option):base(Option)
        {

        }
        public Dbset<StudentData> Name { get; set; }

            }
}