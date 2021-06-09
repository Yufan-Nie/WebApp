using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp_IService;
using WebApp_Models.Model;

namespace WebApp_Service
{
    public class Query : IQuery
    {
        public readonly testContext _testContext;
        public List<Table1> QueryAsync()
        {
            return _testContext.Set<Table1>().ToList();
        }
    }
}
