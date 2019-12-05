using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseCrud
{
    public interface IDatabaseConnection
    {
        SQLite.SQLiteConnection DbConnection();
    }
}
