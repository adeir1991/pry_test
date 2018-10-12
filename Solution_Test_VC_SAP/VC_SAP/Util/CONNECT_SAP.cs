using System;
using System.IO;
using System.Reflection;

namespace VC_SAP.Util
{
    class CONNECT_SAP
    {
        #region Propiedades
        private String _SYSTEMROOT = Path.GetPathRoot(Environment.SystemDirectory);
        private String _FOLDER_ROOT = "SAP";
        private String _EXTFILE = "TXT";

        public CONFIG_SAP CONFIGURATION { get; set; }
        public String STRING_CONNECT { get; set; }
        private String ENVIROMENT { get; set; }
        private String _PATHFILE { get; set; }
        #endregion

        #region Metodos
        public CONNECT_SAP(String _ENVIROMENT)
        {
            CONFIGURATION = new CONFIG_SAP();
            ENVIROMENT = _ENVIROMENT;
            PREPARE_PATH();
        }

        private String READ_VALUE(String key)
        {
            int _POS = -1;
            String _LINE = String.Empty;
            String _PARAMETER = String.Empty;
            StreamReader obj = File.OpenText(_PATHFILE);

            while (obj.Peek() != -1)
            {
                _LINE = obj.ReadLine();
                _POS = _LINE.IndexOf("=");
                _POS = _LINE.IndexOf(key + "=");

                if (_POS != -1)
                {
                    _POS = _LINE.IndexOf("=");
                    _PARAMETER = _LINE.Substring(_POS + 1);
                }
            }

            obj.Close();
            return _PARAMETER;
        }

        private void PREPARE_PATH()
        {
            String _PATH = String.Format(@"{0}\{1}\", _SYSTEMROOT, _FOLDER_ROOT);
            String _FILENAME = String.Format(@"{0}.{1}", ENVIROMENT, _EXTFILE);

            _PATHFILE = String.Format(@"{0}{1}", _PATH, _FILENAME);
        }

        public void ReadFile()
        {
            if (String.IsNullOrEmpty(ENVIROMENT) || File.Exists(_PATHFILE))
            {
                foreach (PropertyInfo _prop in typeof(CONFIG_SAP).GetProperties())
                {
                    String _KEY = _prop.Name;
                    String _VALUE = READ_VALUE(_KEY);
                    STRING_CONNECT += String.Format("{0}={1} ", _KEY, _VALUE);
                    CONFIGURATION.GetType().GetProperty(_KEY).SetValue(CONFIGURATION, _VALUE);
                }
                STRING_CONNECT = STRING_CONNECT.Trim();
            }
            else throw new Exception("FILE ERROR: El Archivo de configuración no existe para el ambiente indicado.");
        }
        #endregion
    }
}
