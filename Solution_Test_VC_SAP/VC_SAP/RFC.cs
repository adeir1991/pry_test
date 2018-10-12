using System;
using System.Linq;
using System.Data;
using VC_SAP.Util;
using VC_SAP.Tables;
using VC_SAP.Proxys;
using VC_SAP.Models;
using System.ComponentModel;
using System.Collections.Generic;

namespace VC_SAP
{
    public class RFC
    {
        #region Propiedades
        public String Entorno
        {
            get { return _ENTORNO; }
            set
            {
                _ENTORNO = value;
                CONNECT_TO_SAP();
            }
        }
        public String Error { get; set; }
        private CONNECT_SAP _CONFIG { get; set; }
        private String _ENTORNO = String.Empty;
        #endregion

        #region Metodos
        public RFC() { }

        [Description("Inicializa la clase y permite indicar el ambiente a SAP al cual debe conectarse.")]
        public RFC(String Entorno)
        {
            _ENTORNO = Entorno;
            CONNECT_TO_SAP();
        }

        private IEnumerable<String> ClearDataRFC(DataTable data)
        {
            char _ERROR_CHAR_ = '†';
            return (from x in data.AsEnumerable() select x.Field<String>(0).ToString().TrimEnd(_ERROR_CHAR_).TrimStart(_ERROR_CHAR_).Trim());
        }

        private void SET_RESULT(ref ResultRFC result, SAP.Connector.Connection sender, String status)
        {
            result.Tiempo = Extra.GetTimeExecRFC(sender);
            result.Exito = (status.Equals("1"));
        }

        private void CONNECT_TO_SAP()
        {
            _CONFIG = new CONNECT_SAP(_ENTORNO);
            _CONFIG.ReadFile();
        }
        #endregion

        #region RFC's
        [Description("Consulta a las tablas SAP, al ser vacío el parámetro Delimitador este se asigna a '|'.")]
        public IEnumerable<String> READ_TABLE(String Tabla, String Delimitador, List<String> Campos, List<String> Consulta)
        {
            IEnumerable<String> _DATA;
            RFC_READ_TABLE_ _PROXY = null;

            try
            {
                int ROWCOUNT = 0;
                int ROWSKIPS = 0;
                String NO_DATA = String.Empty;
                TAB512Table DATA = new TAB512Table();
                RFC_DB_FLDTable FIELDS = new RFC_DB_FLDTable();
                RFC_DB_OPTTable OPTIONS = new RFC_DB_OPTTable();
                _PROXY = new RFC_READ_TABLE_(_CONFIG.STRING_CONNECT);

                foreach (String valor in Campos)
                {
                    RFC_DB_FLD _FIELD = new RFC_DB_FLD();
                    _FIELD.Fieldname = valor.ToUpper().Trim();
                    _FIELD.Fieldtext = valor.ToUpper().Trim();
                    _FIELD.Length = "000000";
                    _FIELD.Offset = "000000";
                    FIELDS.Add(_FIELD);
                }

                if (Consulta != null)
                {
                    foreach (String valor in Consulta)
                    {
                        RFC_DB_OPT _OPTION = new RFC_DB_OPT();
                        _OPTION.Text = valor.ToUpper().Trim();
                        OPTIONS.Add(_OPTION);
                    }
                }

                Tabla = Tabla.ToUpper().Trim();
                Delimitador = (Delimitador == null) ? "|" : Delimitador;
                _PROXY.RFC_READ_TABLE(Delimitador, NO_DATA, Tabla, ROWCOUNT, ROWSKIPS, ref DATA, ref FIELDS, ref OPTIONS);
                _DATA = ClearDataRFC(DATA.ToADODataTable());
            }
            catch (Exception ex)
            {
                int _code = ex.HResult;
                String _ERROR = "RFC=READ_TABLE: {0}.";

                _DATA = null;

                if (_code.Equals(-2146232832)) _ERROR = String.Format(_ERROR, "Algunos campos no existen en la tabla " + Tabla);
                else Extra.RunError(ex, "READ_TABLE");
            }
            finally
            {
                _PROXY.Connection.Close();
                _PROXY.Dispose();
            }

            return _DATA;
        }

        public DataTable ZPISD_ENVIO_ACT_PED_VENTA_DEVO(String PedidoSAP)
        {
            DataTable _DATA = new DataTable();
            ResultRFC _result = new ResultRFC();
            ZPISD_ENVIO_ACT_PED_VENTA_DEVO_ _PROXY = null;

            try
            {
                String _STATUS = String.Empty;
                String F_PED_D = String.Empty;
                String F_PED_V = PedidoSAP.Trim();
                ZSPI_DETALLE_DEVTable ET_DETALLE_DEV = new ZSPI_DETALLE_DEVTable();
                ZSPI_DETALLE_VENTable ET_DETALLE_VEN = new ZSPI_DETALLE_VENTable();
                ZSPI_CABECERA_VENTable ET_CABECERA_VEN = new ZSPI_CABECERA_VENTable();
                ZSPI_CABECERA_DEVTable ET_CABECERA_DEV = new ZSPI_CABECERA_DEVTable();

                _PROXY = new ZPISD_ENVIO_ACT_PED_VENTA_DEVO_(_CONFIG.STRING_CONNECT);
                _PROXY.ZPISD_ENVIO_ACT_PED_VENTA_DEVO(F_PED_D, F_PED_V, ref ET_CABECERA_DEV, ref ET_CABECERA_VEN, ref ET_DETALLE_DEV, ref ET_DETALLE_VEN);
                SET_RESULT(ref _result, _PROXY.Connection, _STATUS);
                _DATA = ET_DETALLE_VEN.ToADODataTable();
            }
            catch (Exception ex) { Extra.RunError(ex, "ZPISD_ENVIO_ACT_PED_VENTA_DEVO"); }
            finally
            {
                _PROXY.Connection.Close();
                _PROXY.Dispose();
            }

            return _DATA;
        }

        [Description("Registra un producto al maestro de productos desde el ambiente indicado a SQL.")]
        public ResultRFC ZPISD007_RFC(bool isAFS, String Cod_Producto)
        {
            ResultRFC _result = new ResultRFC();
            ZPISD007_RFC_ _PROXY = null;

            try
            {
                String PA_MATNR = Cod_Producto.Trim();
                String PA_PAR1 = (isAFS) ? "1" : "0";
                String _STATUS = String.Empty;

                _PROXY = new ZPISD007_RFC_(_CONFIG.STRING_CONNECT);
                _PROXY.ZPISD007_RFC(out _STATUS, PA_MATNR, PA_PAR1);
                SET_RESULT(ref _result, _PROXY.Connection, _STATUS);
            }
            catch (Exception ex)
            { Extra.RunError(ex, "ZPISD007_RFC"); }
            finally
            {
                _PROXY.Connection.Close();
                _PROXY.Dispose();
            }

            return _result;
        }

        [Description("Registra todo o un producto campaña al maestro de producto campaña desde el ambiente indicado a SQL.")]
        public ResultRFC ZPISD003_RFC(String Campaña, String Cod_Producto)
        {
            ResultRFC _result = new ResultRFC();
            ZPISD003_RFC_ _PROXY = null;

            try
            {                
                String _STATUS = String.Empty;
                String PA_CAMP = Campaña.Trim();
                String PA_MATE = Cod_Producto.Trim();

                _PROXY = new ZPISD003_RFC_(_CONFIG.STRING_CONNECT);
                _PROXY.ZPISD003_RFC(out _STATUS, PA_CAMP, PA_MATE);
                SET_RESULT(ref _result, _PROXY.Connection, _STATUS);
                _result.Valor = int.Parse(_STATUS);
                _result.Exito = true;
            }
            catch (Exception ex) { Extra.RunError(ex, "ZPISD003_RFC"); }
            finally
            {
                _PROXY.Connection.Close();
                _PROXY.Dispose();
            }

            return _result;
        }

        [Description("Registra todo el maestro de marcas desde el ambiente indicado a SQL.")]
        public ResultRFC ZPISD005_RFC()
        {
            ResultRFC _result = new ResultRFC();
            ZPISD005_RFC_ _PROXY = null;

            try
            {
                String _STATUS = String.Empty;

                _PROXY = new ZPISD005_RFC_(_CONFIG.STRING_CONNECT);
                _PROXY.ZPISD005_RFC(out _STATUS);
                SET_RESULT(ref _result, _PROXY.Connection, _STATUS);
            }
            catch (Exception ex) { Extra.RunError(ex, "ZPISD005_RFC"); }
            finally
            {
                _PROXY.Connection.Close();
                _PROXY.Dispose();
            }

            return _result;
        }
        #endregion
    }
}