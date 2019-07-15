using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyServiceSample
{
    public interface ISample
    {
        // OS名の文字列を返すメソッド
        string getOSName();
    }
}
