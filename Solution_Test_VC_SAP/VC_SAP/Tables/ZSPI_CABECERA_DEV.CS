using System;
using System.Xml.Serialization;
using System.Xml.Schema;
using SAP.Connector;

namespace VC_SAP.Tables
{
[RfcStructure(AbapName="ZSPI_CABECERA_DEV", Length=1608, Length2=3216)]
[Serializable]
public class ZSPI_CABECERA_DEV : SAPStructure
{
[RfcField(AbapName="MOT_PED", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=6, Length2=12, Offset=0, Offset2=0)]
[XmlElement("MOT_PED", Form=XmlSchemaForm.Unqualified)]
public String Mot_Ped
{ 
get
{
return _Mot_Ped;
}
set
{
_Mot_Ped=value;
}
}
private String _Mot_Ped;
[RfcField(AbapName="CLA_PED", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=8, Length2=16, Offset=6, Offset2=12)]
[XmlElement("CLA_PED", Form=XmlSchemaForm.Unqualified)]
public String Cla_Ped
{ 
get
{
return _Cla_Ped;
}
set
{
_Cla_Ped=value;
}
}
private String _Cla_Ped;
[RfcField(AbapName="ORG_VEN", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=8, Length2=16, Offset=14, Offset2=28)]
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
[RfcField(AbapName="C_DIST", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=4, Length2=8, Offset=22, Offset2=44)]
[XmlElement("C_DIST", Form=XmlSchemaForm.Unqualified)]
public String C_Dist
{ 
get
{
return _C_Dist;
}
set
{
_C_Dist=value;
}
}
private String _C_Dist;
[RfcField(AbapName="SECTOR", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=4, Length2=8, Offset=26, Offset2=52)]
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
[RfcField(AbapName="OF_VEN", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=8, Length2=16, Offset=30, Offset2=60)]
[XmlElement("OF_VEN", Form=XmlSchemaForm.Unqualified)]
public String Of_Ven
{ 
get
{
return _Of_Ven;
}
set
{
_Of_Ven=value;
}
}
private String _Of_Ven;
[RfcField(AbapName="C_PED_SIG", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=70, Length2=140, Offset=38, Offset2=76)]
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
[RfcField(AbapName="COD_SOL", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=20, Length2=40, Offset=108, Offset2=216)]
[XmlElement("COD_SOL", Form=XmlSchemaForm.Unqualified)]
public String Cod_Sol
{ 
get
{
return _Cod_Sol;
}
set
{
_Cod_Sol=value;
}
}
private String _Cod_Sol;
[RfcField(AbapName="C_CLI_DES", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=20, Length2=40, Offset=128, Offset2=256)]
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
[RfcField(AbapName="C_CLI_RES", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=20, Length2=40, Offset=148, Offset2=296)]
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
[RfcField(AbapName="A_ENVIO", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=360, Length2=720, Offset=168, Offset2=336)]
[XmlElement("A_ENVIO", Form=XmlSchemaForm.Unqualified)]
public String A_Envio
{ 
get
{
return _A_Envio;
}
set
{
_A_Envio=value;
}
}
private String _A_Envio;
[RfcField(AbapName="F_ENVIO", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=360, Length2=720, Offset=528, Offset2=1056)]
[XmlElement("F_ENVIO", Form=XmlSchemaForm.Unqualified)]
public String F_Envio
{ 
get
{
return _F_Envio;
}
set
{
_F_Envio=value;
}
}
private String _F_Envio;
[RfcField(AbapName="N_DOCUMENTO", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=360, Length2=720, Offset=888, Offset2=1776)]
[XmlElement("N_DOCUMENTO", Form=XmlSchemaForm.Unqualified)]
public String N_Documento
{ 
get
{
return _N_Documento;
}
set
{
_N_Documento=value;
}
}
private String _N_Documento;
[RfcField(AbapName="N_BULTOS", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=360, Length2=720, Offset=1248, Offset2=2496)]
[XmlElement("N_BULTOS", Form=XmlSchemaForm.Unqualified)]
public String N_Bultos
{ 
get
{
return _N_Bultos;
}
set
{
_N_Bultos=value;
}
}
private String _N_Bultos;
// Parameters
}
}