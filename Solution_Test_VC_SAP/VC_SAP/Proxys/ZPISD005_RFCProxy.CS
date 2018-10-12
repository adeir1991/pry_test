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
public class ZPISD005_RFC_ : SAPClient
{
public ZPISD005_RFC_(){}
public ZPISD005_RFC_(string connectionString) : base(connectionString){}
public ZPISD005_RFC_(System.ComponentModel.IContainer container) : base(container) {}    

// Exception constant for ABAP-Exception


[RfcMethod(AbapName="ZPISD005_RFC")]
[SoapDocumentMethodAttribute("http://tempuri.org/ZPISD005_RFC", 
RequestNamespace="urn:sap-com:document:sap:rfc:functions", 
RequestElementName="ZPISD005_RFC", 
ResponseNamespace="urn:sap-com:document:sap:rfc:functions", 
ResponseElementName="ZPISD005_RFC.Response")]
public virtual void ZPISD005_RFC (

[RfcParameter(AbapName="STATUS", RfcType=RFCTYPE.RFCTYPE_CHAR, Optional=false, Direction=RFCINOUT.OUT, Length=30, Length2=60)]
[XmlElement("STATUS", IsNullable=false, Form=XmlSchemaForm.Unqualified)]
out String STATUS
){
object[]results=null;
results=this.SAPInvoke("ZPISD005_RFC", new object[] {

});
 STATUS=(String)results[0];

}
}
}
