using System;
using System.Collections.Generic;
using System.Text;

namespace DebtRefresh.Domain.Interfaces
{
    public interface IDataProvider
    {
        
        public void SaveData();

        public void GetData();

    }
}
