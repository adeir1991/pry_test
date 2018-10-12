using System;
using System.Xml.Serialization;
using System.Xml.Schema;
using SAP.Connector;

namespace VC_SAP.Tables
{
[RfcStructure(AbapName="RFC_DB_OPT", Length=144, Length2=288)]
[Serializable]
public class RFC_DB_OPT : SAPStructure
{
[RfcField(AbapName="TEXT", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=144, Length2=288, Offset=0, Offset2=0)]
[XmlElement("TEXT", Form=XmlSchemaForm.Unqualified)]
public String Text
{ 
get
{
return _Text;
}
set
{
_Text=value;
}
}
private String _Text;
// Parameters
}
}