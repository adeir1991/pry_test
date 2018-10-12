using System;
using System.Xml.Serialization;
using System.Xml.Schema;
using SAP.Connector;

namespace VC_SAP.Tables
{
[RfcStructure(AbapName="ZSPI_DETALLE_DEV", Length=1464, Length2=2900)]
[Serializable]
public class ZSPI_DETALLE_DEV : SAPStructure
{
[RfcField(AbapName="C_PED_SIG", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=70, Length2=140, Offset=0, Offset2=0)]
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
[RfcField(AbapName="ID_SUB_PED", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=20, Length2=40, Offset=70, Offset2=140)]
[XmlElement("ID_SUB_PED", Form=XmlSchemaForm.Unqualified)]
public String Id_Sub_Ped
{ 
get
{
return _Id_Sub_Ped;
}
set
{
_Id_Sub_Ped=value;
}
}
private String _Id_Sub_Ped;
[RfcField(AbapName="ID_SUB_DET", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=24, Length2=48, Offset=90, Offset2=180)]
[XmlElement("ID_SUB_DET", Form=XmlSchemaForm.Unqualified)]
public String Id_Sub_Det
{ 
get
{
return _Id_Sub_Det;
}
set
{
_Id_Sub_Det=value;
}
}
private String _Id_Sub_Det;
[RfcField(AbapName="FEC_REG", RfcType=RFCTYPE.RFCTYPE_DATE, Length=16, Length2=32, Offset=114, Offset2=228)]
[XmlElement("FEC_REG", Form=XmlSchemaForm.Unqualified)]
public String Fec_Reg
{ 
get
{
return _Fec_Reg;
}
set
{
_Fec_Reg=value;
}
}
private String _Fec_Reg;
[RfcField(AbapName="C_CAMP", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=24, Length2=48, Offset=130, Offset2=260)]
[XmlElement("C_CAMP", Form=XmlSchemaForm.Unqualified)]
public String C_Camp
{ 
get
{
return _C_Camp;
}
set
{
_C_Camp=value;
}
}
private String _C_Camp;
[RfcField(AbapName="C_CLI_PROM", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=20, Length2=40, Offset=154, Offset2=308)]
[XmlElement("C_CLI_PROM", Form=XmlSchemaForm.Unqualified)]
public String C_Cli_Prom
{ 
get
{
return _C_Cli_Prom;
}
set
{
_C_Cli_Prom=value;
}
}
private String _C_Cli_Prom;
[RfcField(AbapName="COD_PRO", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=36, Length2=72, Offset=174, Offset2=348)]
[XmlElement("COD_PRO", Form=XmlSchemaForm.Unqualified)]
public String Cod_Pro
{ 
get
{
return _Cod_Pro;
}
set
{
_Cod_Pro=value;
}
}
private String _Cod_Pro;
[RfcField(AbapName="COLOR", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=60, Length2=120, Offset=210, Offset2=420)]
[XmlElement("COLOR", Form=XmlSchemaForm.Unqualified)]
public String Color
{ 
get
{
return _Color;
}
set
{
_Color=value;
}
}
private String _Color;
[RfcField(AbapName="TALLA", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=16, Length2=32, Offset=270, Offset2=540)]
[XmlElement("TALLA", Form=XmlSchemaForm.Unqualified)]
public String Talla
{ 
get
{
return _Talla;
}
set
{
_Talla=value;
}
}
private String _Talla;
[RfcField(AbapName="CANT_PED", RfcType=RFCTYPE.RFCTYPE_BCD, Decimals=3, Length=8, Length2=8, Offset=286, Offset2=572)]
[XmlElement("CANT_PED", Form=XmlSchemaForm.Unqualified)]
public Decimal Cant_Ped
{ 
get
{
return _Cant_Ped;
}
set
{
_Cant_Ped=value;
}
}
private Decimal _Cant_Ped;
[RfcField(AbapName="CANT_ACEPT", RfcType=RFCTYPE.RFCTYPE_BCD, Decimals=3, Length=8, Length2=8, Offset=294, Offset2=580)]
[XmlElement("CANT_ACEPT", Form=XmlSchemaForm.Unqualified)]
public Decimal Cant_Acept
{ 
get
{
return _Cant_Acept;
}
set
{
_Cant_Acept=value;
}
}
private Decimal _Cant_Acept;
[RfcField(AbapName="N_INTER_SAP", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=20, Length2=40, Offset=302, Offset2=588)]
[XmlElement("N_INTER_SAP", Form=XmlSchemaForm.Unqualified)]
public String N_Inter_Sap
{ 
get
{
return _N_Inter_Sap;
}
set
{
_N_Inter_Sap=value;
}
}
private String _N_Inter_Sap;
[RfcField(AbapName="T_MOTIVO", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=6, Length2=12, Offset=322, Offset2=628)]
[XmlElement("T_MOTIVO", Form=XmlSchemaForm.Unqualified)]
public String T_Motivo
{ 
get
{
return _T_Motivo;
}
set
{
_T_Motivo=value;
}
}
private String _T_Motivo;
[RfcField(AbapName="T_MOT_LIN", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=6, Length2=12, Offset=328, Offset2=640)]
[XmlElement("T_MOT_LIN", Form=XmlSchemaForm.Unqualified)]
public String T_Mot_Lin
{ 
get
{
return _T_Mot_Lin;
}
set
{
_T_Mot_Lin=value;
}
}
private String _T_Mot_Lin;
[RfcField(AbapName="DESC", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=360, Length2=720, Offset=334, Offset2=652)]
[XmlElement("DESC", Form=XmlSchemaForm.Unqualified)]
public String Desc
{ 
get
{
return _Desc;
}
set
{
_Desc=value;
}
}
private String _Desc;
[RfcField(AbapName="OBS_ACEP_REC", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=360, Length2=720, Offset=694, Offset2=1372)]
[XmlElement("OBS_ACEP_REC", Form=XmlSchemaForm.Unqualified)]
public String Obs_Acep_Rec
{ 
get
{
return _Obs_Acep_Rec;
}
set
{
_Obs_Acep_Rec=value;
}
}
private String _Obs_Acep_Rec;
[RfcField(AbapName="EST_ACEP_REC", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=360, Length2=720, Offset=1054, Offset2=2092)]
[XmlElement("EST_ACEP_REC", Form=XmlSchemaForm.Unqualified)]
public String Est_Acep_Rec
{ 
get
{
return _Est_Acep_Rec;
}
set
{
_Est_Acep_Rec=value;
}
}
private String _Est_Acep_Rec;
[RfcField(AbapName="FEC_ATEN", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=40, Length2=80, Offset=1414, Offset2=2812)]
[XmlElement("FEC_ATEN", Form=XmlSchemaForm.Unqualified)]
public String Fec_Aten
{ 
get
{
return _Fec_Aten;
}
set
{
_Fec_Aten=value;
}
}
private String _Fec_Aten;
[RfcField(AbapName="EST_SUB_PED", RfcType=RFCTYPE.RFCTYPE_INT, Length=4, Length2=4, Offset=1456, Offset2=2892)]
[XmlElement("EST_SUB_PED", Form=XmlSchemaForm.Unqualified)]
public Int32 Est_Sub_Ped
{ 
get
{
return _Est_Sub_Ped;
}
set
{
_Est_Sub_Ped=value;
}
}
private Int32 _Est_Sub_Ped;
[RfcField(AbapName="AT_PARC", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=1460, Offset2=2896)]
[XmlElement("AT_PARC", Form=XmlSchemaForm.Unqualified)]
public String At_Parc
{ 
get
{
return _At_Parc;
}
set
{
_At_Parc=value;
}
}
private String _At_Parc;
// Parameters
}
}