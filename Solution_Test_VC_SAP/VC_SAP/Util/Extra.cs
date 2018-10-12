using System;
using SAP.Connector;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VC_SAP.Util
{
    public class Extra
    {
        public Extra() { }

        public static Object Property(Object sender, String property)
        {
            Object _response;
            _response = sender.GetType().GetProperty(property).GetValue(sender, null);
            return _response;
        }

        public static long GetTimeExecRFC(Connection sender)
        {
            Object _performance = Property(sender, "Performance");
            Object _time = Property(_performance, "TotalRfcTime");
            return Convert.ToInt64(_time);
        }

        public static void RunError(Exception ex, String method)
        {
            int _code = ex.HResult;
            String _pattern = "HResult={0}, {1}";
            String _ERROR = String.Format("RFC={0}: {1}.", method, ex.Message);
            _ERROR = String.Format(_pattern, _code.ToString(), _ERROR);
            throw new Exception(_ERROR);
        }
    }
}
