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
public class RFC_READ_TABLE_ : SAPClient
{
public RFC_READ_TABLE_(){}
public RFC_READ_TABLE_(string connectionString) : base(connectionString){}
public RFC_READ_TABLE_(System.ComponentModel.IContainer container) : base(container) {}    

// Exception constant for ABAP-Exception

public const string Table_Without_Data="Table_Without_Data";
public const string Table_Not_Available="Table_Not_Available";
public const string Option_Not_Valid="Option_Not_Valid";
public const string Not_Authorized="Not_Authorized";
public const string Field_Not_Valid="Field_Not_Valid";
public const string Data_Buffer_Exceeded="Data_Buffer_Exceeded";

[RfcMethod(AbapName="RFC_READ_TABLE")]
[SoapDocumentMethodAttribute("http://tempuri.org/RFC_READ_TABLE", 
RequestNamespace="urn:sap-com:document:sap:rfc:functions", 
RequestElementName="RFC_READ_TABLE", 
ResponseNamespace="urn:sap-com:document:sap:rfc:functions", 
ResponseElementName="RFC_READ_TABLE.Response")]
public virtual void RFC_READ_TABLE (

[RfcParameter(AbapName="DELIMITER", RfcType=RFCTYPE.RFCTYPE_CHAR, Optional=true, Direction=RFCINOUT.IN, Length=1, Length2=2)]
[XmlElement("DELIMITER", IsNullable=false, Form=XmlSchemaForm.Unqualified)]
String DELIMITER,
[RfcParameter(AbapName="NO_DATA", RfcType=RFCTYPE.RFCTYPE_CHAR, Optional=true, Direction=RFCINOUT.IN, Length=1, Length2=2)]
[XmlElement("NO_DATA", IsNullable=false, Form=XmlSchemaForm.Unqualified)]
String NO_DATA,
[RfcParameter(AbapName="QUERY_TABLE", RfcType=RFCTYPE.RFCTYPE_CHAR, Optional=false, Direction=RFCINOUT.IN, Length=30, Length2=60)]
[XmlElement("QUERY_TABLE", IsNullable=false, Form=XmlSchemaForm.Unqualified)]
String QUERY_TABLE,
[RfcParameter(AbapName="ROWCOUNT", RfcType=RFCTYPE.RFCTYPE_INT, Optional=true, Direction=RFCINOUT.IN, Length=4, Length2=8)]
[XmlElement("ROWCOUNT", IsNullable=false, Form=XmlSchemaForm.Unqualified)]
Int32 ROWCOUNT,
[RfcParameter(AbapName="ROWSKIPS", RfcType=RFCTYPE.RFCTYPE_INT, Optional=true, Direction=RFCINOUT.IN, Length=4, Length2=8)]
[XmlElement("ROWSKIPS", IsNullable=false, Form=XmlSchemaForm.Unqualified)]
Int32 ROWSKIPS,
[RfcParameter(AbapName="DATA", RfcType=RFCTYPE.RFCTYPE_ITAB, Optional=false, Direction=RFCINOUT.INOUT)]
[XmlArray("DATA", IsNullable=false, Form=XmlSchemaForm.Unqualified)]
[XmlArrayItem("item", IsNullable=false, Form=XmlSchemaForm.Unqualified)]
ref TAB512Table DATA,
[RfcParameter(AbapName="FIELDS", RfcType=RFCTYPE.RFCTYPE_ITAB, Optional=false, Direction=RFCINOUT.INOUT)]
[XmlArray("FIELDS", IsNullable=false, Form=XmlSchemaForm.Unqualified)]
[XmlArrayItem("item", IsNullable=false, Form=XmlSchemaForm.Unqualified)]
ref RFC_DB_FLDTable FIELDS,
[RfcParameter(AbapName="OPTIONS", RfcType=RFCTYPE.RFCTYPE_ITAB, Optional=false, Direction=RFCINOUT.INOUT)]
[XmlArray("OPTIONS", IsNullable=false, Form=XmlSchemaForm.Unqualified)]
[XmlArrayItem("item", IsNullable=false, Form=XmlSchemaForm.Unqualified)]
ref RFC_DB_OPTTable OPTIONS
){
object[]results=null;
results=this.SAPInvoke("RFC_READ_TABLE", new object[] {
DELIMITER,
NO_DATA,
QUERY_TABLE,
ROWCOUNT,
ROWSKIPS,
DATA,
FIELDS,
OPTIONS
});
 DATA=(TAB512Table)results[0];
 FIELDS=(RFC_DB_FLDTable)results[1];
 OPTIONS=(RFC_DB_OPTTable)results[2];

}
}
}
