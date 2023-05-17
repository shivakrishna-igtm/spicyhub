using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpiceApp.Data.Migrations
{
    public interface IDbInitializer
    {
        void Initialize();
    }
}
