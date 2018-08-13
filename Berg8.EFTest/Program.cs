using System;
using System.Linq;

namespace Berg8.EFTest
{
    using System.Data.Entity;
    using Berg8.EF;
    public static class Program
    {
        static void Main(string[] args)
        {
            using (WorkflowContext db = WorkflowContext.CreateInstance("Server=.;Database=Workflow;User Id=sa;Password='admin@1234';Integrated Security=true; Trusted_Connection=True;"))
            {
                var a = db.Workflow;
                Console.WriteLine(a.Count());
                Console.ReadLine();
            }
        }
    }
}
