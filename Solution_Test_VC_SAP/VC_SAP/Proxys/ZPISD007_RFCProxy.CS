using System;
using System.Xml.Serialization;
using System.Xml.Schema;
using System.Web.Services;
using System.Web.Services.Protocols;
using SAP.Connector;

namespace VC_SAP
{
[WebServiceBinding(Name="dummy.Binding", Namespace="urn:sap-com:document:sap:rfc:functions")]
[Serializable]
public class ZPISD007_RFC_ : SAPClient
{
public ZPISD007_RFC_(){}
public ZPISD007_RFC_(string connectionString) : base(connectionString){}
public ZPISD007_RFC_(System.ComponentModel.IContainer container) : base(container) {}    

// Exception constant for ABAP-Exception


[RfcMethod(AbapName="ZPISD007_RFC")]
[SoapDocumentMethodAttribute("http://tempuri.org/ZPISD007_RFC", 
RequestNamespace="urn:sap-com:document:sap:rfc:functions", 
RequestElementName="ZPISD007_RFC", 
ResponseNamespace="urn:sap-com:document:sap:rfc:functions", 
ResponseElementName="ZPISD007_RFC.Response")]
public virtual void ZPISD007_RFC (

[RfcParameter(AbapName="STATUS", RfcType=RFCTYPE.RFCTYPE_CHAR, Optional=false, Direction=RFCINOUT.OUT, Length=30, Length2=60)]
[XmlElement("STATUS", IsNullable=false, Form=XmlSchemaForm.Unqualified)]
out String STATUS,
[RfcParameter(AbapName="PA_MATNR", RfcType=RFCTYPE.RFCTYPE_CHAR, Optional=true, Direction=RFCINOUT.IN, Length=18, Length2=36)]
[XmlElement("PA_MATNR", IsNullable=false, Form=XmlSchemaForm.Unqualified)]
String PA_MATNR,
[RfcParameter(AbapName="PA_PAR1", RfcType=RFCTYPE.RFCTYPE_CHAR, Optional=true, Direction=RFCINOUT.IN, Length=1, Length2=2)]
[XmlElement("PA_PAR1", IsNullable=false, Form=XmlSchemaForm.Unqualified)]
String PA_PAR1
){
object[]results=null;
results=this.SAPInvoke("ZPISD007_RFC", new object[] {
PA_MATNR,
PA_PAR1
});
 STATUS=(String)results[0];

}
}
}
