using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApp_Models.Model;

namespace WebApp_IService
{
    public interface IQuery
    {
        List<Table1> QueryAsync();
    }
}
