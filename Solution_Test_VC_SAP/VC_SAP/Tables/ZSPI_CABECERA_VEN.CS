using System;
using System.Xml.Serialization;
using System.Xml.Schema;
using SAP.Connector;

namespace VC_SAP.Tables
{
[RfcStructure(AbapName="ZSPI_CABECERA_VEN", Length=262, Length2=522)]
[Serializable]
public class ZSPI_CABECERA_VEN : SAPStructure
{
[RfcField(AbapName="CLASE_PED", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=8, Length2=16, Offset=0, Offset2=0)]
[XmlElement("CLASE_PED", Form=XmlSchemaForm.Unqualified)]
public String Clase_Ped
{ 
get
{
return _Clase_Ped;
}
set
{
_Clase_Ped=value;
}
}
private String _Clase_Ped;
[RfcField(AbapName="ORG_VEN", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=8, Length2=16, Offset=8, Offset2=16)]
[XmlElement("ORG_VEN", Form=XmlSchemaForm.Unqualified)]
public String Org_Ven
{ 
get
{
return _Org_Ven;
}
set
{
_Org_Ven=value;
}
}
private String _Org_Ven;
[RfcField(AbapName="CAN_DIS", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=4, Length2=8, Offset=16, Offset2=32)]
[XmlElement("CAN_DIS", Form=XmlSchemaForm.Unqualified)]
public String Can_Dis
{ 
get
{
return _Can_Dis;
}
set
{
_Can_Dis=value;
}
}
private String _Can_Dis;
[RfcField(AbapName="SECTOR", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=4, Length2=8, Offset=20, Offset2=40)]
[XmlElement("SECTOR", Form=XmlSchemaForm.Unqualified)]
public String Sector
{ 
get
{
return _Sector;
}
set
{
_Sector=value;
}
}
private String _Sector;
[RfcField(AbapName="OF_VENTAS", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=8, Length2=16, Offset=24, Offset2=48)]
[XmlElement("OF_VENTAS", Form=XmlSchemaForm.Unqualified)]
public String Of_Ventas
{ 
get
{
return _Of_Ventas;
}
set
{
_Of_Ventas=value;
}
}
private String _Of_Ventas;
[RfcField(AbapName="C_PED_SIG", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=70, Length2=140, Offset=32, Offset2=64)]
[XmlElement("C_PED_SIG", Form=XmlSchemaForm.Unqualified)]
public String C_Ped_Sig
{ 
get
{
return _C_Ped_Sig;
}
set
{
_C_Ped_Sig=value;
}
}
private String _C_Ped_Sig;
[RfcField(AbapName="C_PED_SAP", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=20, Length2=40, Offset=102, Offset2=204)]
[XmlElement("C_PED_SAP", Form=XmlSchemaForm.Unqualified)]
public String C_Ped_Sap
{ 
get
{
return _C_Ped_Sap;
}
set
{
_C_Ped_Sap=value;
}
}
private String _C_Ped_Sap;
[RfcField(AbapName="C_PREP_SAP", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=20, Length2=40, Offset=122, Offset2=244)]
[XmlElement("C_PREP_SAP", Form=XmlSchemaForm.Unqualified)]
public String C_Prep_Sap
{ 
get
{
return _C_Prep_Sap;
}
set
{
_C_Prep_Sap=value;
}
}
private String _C_Prep_Sap;
[RfcField(AbapName="C_CLI_SOL", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=20, Length2=40, Offset=142, Offset2=284)]
[XmlElement("C_CLI_SOL", Form=XmlSchemaForm.Unqualified)]
public String C_Cli_Sol
{ 
get
{
return _C_Cli_Sol;
}
set
{
_C_Cli_Sol=value;
}
}
private String _C_Cli_Sol;
[RfcField(AbapName="C_CLI_DES", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=20, Length2=40, Offset=162, Offset2=324)]
[XmlElement("C_CLI_DES", Form=XmlSchemaForm.Unqualified)]
public String C_Cli_Des
{ 
get
{
return _C_Cli_Des;
}
set
{
_C_Cli_Des=value;
}
}
private String _C_Cli_Des;
[RfcField(AbapName="C_CLI_RES", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=20, Length2=40, Offset=182, Offset2=364)]
[XmlElement("C_CLI_RES", Form=XmlSchemaForm.Unqualified)]
public String C_Cli_Res
{ 
get
{
return _C_Cli_Res;
}
set
{
_C_Cli_Res=value;
}
}
private String _C_Cli_Res;
[RfcField(AbapName="FEC_PED", RfcType=RFCTYPE.RFCTYPE_DATE, Length=16, Length2=32, Offset=202, Offset2=404)]
[XmlElement("FEC_PED", Form=XmlSchemaForm.Unqualified)]
public String Fec_Ped
{ 
get
{
return _Fec_Ped;
}
set
{
_Fec_Ped=value;
}
}
private String _Fec_Ped;
[RfcField(AbapName="EST_ATEN", RfcType=RFCTYPE.RFCTYPE_INT1, Length=1, Length2=1, Offset=218, Offset2=436)]
[XmlElement("EST_ATEN", Form=XmlSchemaForm.Unqualified)]
public Byte Est_Aten
{ 
get
{
return _Est_Aten;
}
set
{
_Est_Aten=value;
}
}
private Byte _Est_Aten;
[RfcField(AbapName="ATEN_PARC", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=220, Offset2=438)]
[XmlElement("ATEN_PARC", Form=XmlSchemaForm.Unqualified)]
public String Aten_Parc
{ 
get
{
return _Aten_Parc;
}
set
{
_Aten_Parc=value;
}
}
private String _Aten_Parc;
[RfcField(AbapName="FEC_EST_ATEN", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=40, Length2=80, Offset=222, Offset2=442)]
[XmlElement("FEC_EST_ATEN", Form=XmlSchemaForm.Unqualified)]
public String Fec_Est_Aten
{ 
get
{
return _Fec_Est_Aten;
}
set
{
_Fec_Est_Aten=value;
}
}
private String _Fec_Est_Aten;
// Parameters
}
}