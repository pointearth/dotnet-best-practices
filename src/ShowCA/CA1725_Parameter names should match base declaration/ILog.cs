using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CA1725_Parameter_names_should_match_base_declaration
{
    public interface ILog
    {
        void Error(Object o,Exception e);
    }
}
