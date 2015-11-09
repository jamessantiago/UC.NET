using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxlNetClient
{
    public static class AxlExtensions
    {
        public static XFkType DefaultOrNullIfEmpty(this XFkType data)
        {
            return string.IsNullOrEmpty(data.uuid) && string.IsNullOrEmpty(data.Value) ? null : data;
        }
    }
}
