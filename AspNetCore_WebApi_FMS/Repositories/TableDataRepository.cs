using AspNetCore_WebApi_FMS.Data;
using AspNetCore_WebApi_FMS.Models;
using System.Collections.Generic;
using System.Linq;

namespace AspNetCore_WebApi_FMS.Repositories
{
    public class TableDataRepository : ITableData
    {

        private FMSDbContext _db;
        public TableDataRepository(FMSDbContext context)
        {
            this._db = context;
        }
        public TableData GetTableDatas()
        {
            var tbList = new TableData();
            tbList.Actors = _db.Actors.ToList();
            tbList.Categories = _db.Categories.ToList();
            tbList.Languages = _db.Languages.ToList();
             return tbList;
        }
    }
}
