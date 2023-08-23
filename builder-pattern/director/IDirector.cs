using builder_pattern.builder;
using builder_pattern.@object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder_pattern.director
{
    public interface IDirector
    {
        Vehicle Instruct(IBuilder builder);
    }
}
