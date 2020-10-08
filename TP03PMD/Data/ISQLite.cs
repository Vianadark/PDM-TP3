using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TP03PMD.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
