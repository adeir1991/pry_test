using System;
using System.Xml.Serialization;
using System.Xml.Schema;
using SAP.Connector;

namespace VC_SAP.Tables
{
[RfcStructure(AbapName="TAB512", Length=1024, Length2=2048)]
[Serializable]
public class TAB512 : SAPStructure
{
[RfcField(AbapName="WA", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=1024, Length2=2048, Offset=0, Offset2=0)]
[XmlElement("WA", Form=XmlSchemaForm.Unqualified)]
public String Wa
{ 
get
{
return _Wa;
}
set
{
_Wa=value;
}
}
private String _Wa;
// Parameters
}
}