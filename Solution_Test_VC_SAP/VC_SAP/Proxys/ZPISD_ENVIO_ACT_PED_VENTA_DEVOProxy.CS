using System;
using VC_SAP.Tables;
using System.Xml.Serialization;
using System.Xml.Schema;
using System.Web.Services;
using System.Web.Services.Protocols;
using SAP.Connector;

namespace VC_SAP.Proxys
{
[WebServiceBinding(Name="dummy.Binding", Namespace="urn:sap-com:document:sap:rfc:functions")]
[Serializable]
public class ZPISD_ENVIO_ACT_PED_VENTA_DEVO_ : SAPClient
{
public ZPISD_ENVIO_ACT_PED_VENTA_DEVO_(){}
public ZPISD_ENVIO_ACT_PED_VENTA_DEVO_(string connectionString) : base(connectionString){}
public ZPISD_ENVIO_ACT_PED_VENTA_DEVO_(System.ComponentModel.IContainer container) : base(container) {}    

// Exception constant for ABAP-Exception


[RfcMethod(AbapName="ZPISD_ENVIO_ACT_PED_VENTA_DEVO")]
[SoapDocumentMethodAttribute("http://tempuri.org/ZPISD_ENVIO_ACT_PED_VENTA_DEVO", 
RequestNamespace="urn:sap-com:document:sap:rfc:functions", 
RequestElementName="ZPISD_ENVIO_ACT_PED_VENTA_DEVO", 
ResponseNamespace="urn:sap-com:document:sap:rfc:functions", 
ResponseElementName="ZPISD_ENVIO_ACT_PED_VENTA_DEVO.Response")]
public virtual void ZPISD_ENVIO_ACT_PED_VENTA_DEVO (

[RfcParameter(AbapName="F_PED_D", RfcType=RFCTYPE.RFCTYPE_STRING, Optional=false, Direction=RFCINOUT.IN, Length=0, Length2=0)]
[XmlElement("F_PED_D", IsNullable=false, Form=XmlSchemaForm.Unqualified)]
String F_PED_D,
[RfcParameter(AbapName="F_PED_V", RfcType=RFCTYPE.RFCTYPE_CHAR, Optional=false, Direction=RFCINOUT.IN, Length=10, Length2=20)]
[XmlElement("F_PED_V", IsNullable=false, Form=XmlSchemaForm.Unqualified)]
String F_PED_V,
[RfcParameter(AbapName="ET_CABECERA_DEV", RfcType=RFCTYPE.RFCTYPE_ITAB, Optional=false, Direction=RFCINOUT.INOUT)]
[XmlArray("ET_CABECERA_DEV", IsNullable=false, Form=XmlSchemaForm.Unqualified)]
[XmlArrayItem("item", IsNullable=false, Form=XmlSchemaForm.Unqualified)]
ref ZSPI_CABECERA_DEVTable ET_CABECERA_DEV,
[RfcParameter(AbapName="ET_CABECERA_VEN", RfcType=RFCTYPE.RFCTYPE_ITAB, Optional=false, Direction=RFCINOUT.INOUT)]
[XmlArray("ET_CABECERA_VEN", IsNullable=false, Form=XmlSchemaForm.Unqualified)]
[XmlArrayItem("item", IsNullable=false, Form=XmlSchemaForm.Unqualified)]
ref ZSPI_CABECERA_VENTable ET_CABECERA_VEN,
[RfcParameter(AbapName="ET_DETALLE_DEV", RfcType=RFCTYPE.RFCTYPE_ITAB, Optional=false, Direction=RFCINOUT.INOUT)]
[XmlArray("ET_DETALLE_DEV", IsNullable=false, Form=XmlSchemaForm.Unqualified)]
[XmlArrayItem("item", IsNullable=false, Form=XmlSchemaForm.Unqualified)]
ref ZSPI_DETALLE_DEVTable ET_DETALLE_DEV,
[RfcParameter(AbapName="ET_DETALLE_VEN", RfcType=RFCTYPE.RFCTYPE_ITAB, Optional=false, Direction=RFCINOUT.INOUT)]
[XmlArray("ET_DETALLE_VEN", IsNullable=false, Form=XmlSchemaForm.Unqualified)]
[XmlArrayItem("item", IsNullable=false, Form=XmlSchemaForm.Unqualified)]
ref ZSPI_DETALLE_VENTable ET_DETALLE_VEN
){
object[]results=null;
results=this.SAPInvoke("ZPISD_ENVIO_ACT_PED_VENTA_DEVO", new object[] {
F_PED_D,
F_PED_V,
ET_CABECERA_DEV,
ET_CABECERA_VEN,
ET_DETALLE_DEV,
ET_DETALLE_VEN
});
 ET_CABECERA_DEV=(ZSPI_CABECERA_DEVTable)results[0];
 ET_CABECERA_VEN=(ZSPI_CABECERA_VENTable)results[1];
 ET_DETALLE_DEV=(ZSPI_DETALLE_DEVTable)results[2];
 ET_DETALLE_VEN=(ZSPI_DETALLE_VENTable)results[3];

}
}
}
