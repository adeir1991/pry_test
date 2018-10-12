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
public class ZPISD003_RFC_ : SAPClient
{
public ZPISD003_RFC_(){}
public ZPISD003_RFC_(string connectionString) : base(connectionString){}
public ZPISD003_RFC_(System.ComponentModel.IContainer container) : base(container) {}    

// Exception constant for ABAP-Exception


[RfcMethod(AbapName="ZPISD003_RFC")]
[SoapDocumentMethodAttribute("http://tempuri.org/ZPISD003_RFC", 
RequestNamespace="urn:sap-com:document:sap:rfc:functions", 
RequestElementName="ZPISD003_RFC", 
ResponseNamespace="urn:sap-com:document:sap:rfc:functions", 
ResponseElementName="ZPISD003_RFC.Response")]
public virtual void ZPISD003_RFC (

[RfcParameter(AbapName="STATUS", RfcType=RFCTYPE.RFCTYPE_CHAR, Optional=false, Direction=RFCINOUT.OUT, Length=30, Length2=60)]
[XmlElement("STATUS", IsNullable=false, Form=XmlSchemaForm.Unqualified)]
out String STATUS,
[RfcParameter(AbapName="PA_CAMP", RfcType=RFCTYPE.RFCTYPE_CHAR, Optional=true, Direction=RFCINOUT.IN, Length=11, Length2=22)]
[XmlElement("PA_CAMP", IsNullable=false, Form=XmlSchemaForm.Unqualified)]
String PA_CAMP,
[RfcParameter(AbapName="PA_MATE", RfcType=RFCTYPE.RFCTYPE_CHAR, Optional=true, Direction=RFCINOUT.IN, Length=18, Length2=36)]
[XmlElement("PA_MATE", IsNullable=false, Form=XmlSchemaForm.Unqualified)]
String PA_MATE
){
object[]results=null;
results=this.SAPInvoke("ZPISD003_RFC", new object[] {
PA_CAMP,
PA_MATE
});
 STATUS=(String)results[0];

}
}
}
