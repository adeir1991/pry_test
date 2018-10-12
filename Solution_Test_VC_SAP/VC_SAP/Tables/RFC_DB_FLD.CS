using System;
using System.Xml.Serialization;
using System.Xml.Schema;
using SAP.Connector;

namespace VC_SAP.Tables
{
[RfcStructure(AbapName="RFC_DB_FLD", Length=206, Length2=412)]
[Serializable]
public class RFC_DB_FLD : SAPStructure
{
[RfcField(AbapName="FIELDNAME", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=60, Length2=120, Offset=0, Offset2=0)]
[XmlElement("FIELDNAME", Form=XmlSchemaForm.Unqualified)]
public String Fieldname
{ 
get
{
return _Fieldname;
}
set
{
_Fieldname=value;
}
}
private String _Fieldname;
[RfcField(AbapName="OFFSET", RfcType=RFCTYPE.RFCTYPE_NUM, Length=12, Length2=24, Offset=60, Offset2=120)]
[XmlElement("OFFSET", Form=XmlSchemaForm.Unqualified)]
public String Offset
{ 
get
{
return _Offset;
}
set
{
_Offset=value;
}
}
private String _Offset;
[RfcField(AbapName="LENGTH", RfcType=RFCTYPE.RFCTYPE_NUM, Length=12, Length2=24, Offset=72, Offset2=144)]
[XmlElement("LENGTH", Form=XmlSchemaForm.Unqualified)]
public String Length
{ 
get
{
return _Length;
}
set
{
_Length=value;
}
}
private String _Length;
[RfcField(AbapName="TYPE", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=84, Offset2=168)]
[XmlElement("TYPE", Form=XmlSchemaForm.Unqualified)]
public String Type
{ 
get
{
return _Type;
}
set
{
_Type=value;
}
}
private String _Type;
[RfcField(AbapName="FIELDTEXT", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=120, Length2=240, Offset=86, Offset2=172)]
[XmlElement("FIELDTEXT", Form=XmlSchemaForm.Unqualified)]
public String Fieldtext
{ 
get
{
return _Fieldtext;
}
set
{
_Fieldtext=value;
}
}
private String _Fieldtext;
// Parameters
}
}