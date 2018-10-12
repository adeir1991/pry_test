using System;
using System.Xml.Serialization;
using System.Xml.Schema;
using SAP.Connector;

namespace VC_SAP.Tables
{
[RfcStructure(AbapName="ZSPI_DETALLE_VEN", Length=472, Length2=912)]
[Serializable]
public class ZSPI_DETALLE_VEN : SAPStructure
{
[RfcField(AbapName="ID_DET_PED", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=24, Length2=48, Offset=0, Offset2=0)]
[XmlElement("ID_DET_PED", Form=XmlSchemaForm.Unqualified)]
public String Id_Det_Ped
{ 
get
{
return _Id_Det_Ped;
}
set
{
_Id_Det_Ped=value;
}
}
private String _Id_Det_Ped;
[RfcField(AbapName="COD_PED_SIG", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=70, Length2=140, Offset=24, Offset2=48)]
[XmlElement("COD_PED_SIG", Form=XmlSchemaForm.Unqualified)]
public String Cod_Ped_Sig
{ 
get
{
return _Cod_Ped_Sig;
}
set
{
_Cod_Ped_Sig=value;
}
}
private String _Cod_Ped_Sig;
[RfcField(AbapName="COD_PED_SAP", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=20, Length2=40, Offset=94, Offset2=188)]
[XmlElement("COD_PED_SAP", Form=XmlSchemaForm.Unqualified)]
public String Cod_Ped_Sap
{ 
get
{
return _Cod_Ped_Sap;
}
set
{
_Cod_Ped_Sap=value;
}
}
private String _Cod_Ped_Sap;
[RfcField(AbapName="COD_PREP_SAP", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=20, Length2=40, Offset=114, Offset2=228)]
[XmlElement("COD_PREP_SAP", Form=XmlSchemaForm.Unqualified)]
public String Cod_Prep_Sap
{ 
get
{
return _Cod_Prep_Sap;
}
set
{
_Cod_Prep_Sap=value;
}
}
private String _Cod_Prep_Sap;
[RfcField(AbapName="CENTRO", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=20, Length2=40, Offset=134, Offset2=268)]
[XmlElement("CENTRO", Form=XmlSchemaForm.Unqualified)]
public String Centro
{ 
get
{
return _Centro;
}
set
{
_Centro=value;
}
}
private String _Centro;
[RfcField(AbapName="P_EXP", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=8, Length2=16, Offset=154, Offset2=308)]
[XmlElement("P_EXP", Form=XmlSchemaForm.Unqualified)]
public String P_Exp
{ 
get
{
return _P_Exp;
}
set
{
_P_Exp=value;
}
}
private String _P_Exp;
[RfcField(AbapName="FEC_REG", RfcType=RFCTYPE.RFCTYPE_DATE, Length=16, Length2=32, Offset=162, Offset2=324)]
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
[RfcField(AbapName="C_CAMP", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=24, Length2=48, Offset=178, Offset2=356)]
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
[RfcField(AbapName="C_CLI_PROM", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=20, Length2=40, Offset=202, Offset2=404)]
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
[RfcField(AbapName="COD_PRO", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=36, Length2=72, Offset=222, Offset2=444)]
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
[RfcField(AbapName="COLOR", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=60, Length2=120, Offset=258, Offset2=516)]
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
[RfcField(AbapName="TALLA", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=16, Length2=32, Offset=318, Offset2=636)]
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
[RfcField(AbapName="CANT_WEB", RfcType=RFCTYPE.RFCTYPE_BCD, Decimals=3, Length=8, Length2=8, Offset=334, Offset2=668)]
[XmlElement("CANT_WEB", Form=XmlSchemaForm.Unqualified)]
public Decimal Cant_Web
{ 
get
{
return _Cant_Web;
}
set
{
_Cant_Web=value;
}
}
private Decimal _Cant_Web;
[RfcField(AbapName="CANT_PED", RfcType=RFCTYPE.RFCTYPE_BCD, Decimals=3, Length=8, Length2=8, Offset=342, Offset2=676)]
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
[RfcField(AbapName="CANT_DES", RfcType=RFCTYPE.RFCTYPE_BCD, Decimals=3, Length=7, Length2=7, Offset=350, Offset2=684)]
[XmlElement("CANT_DES", Form=XmlSchemaForm.Unqualified)]
public Decimal Cant_Des
{ 
get
{
return _Cant_Des;
}
set
{
_Cant_Des=value;
}
}
private Decimal _Cant_Des;
[RfcField(AbapName="STOCK_FEC", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=24, Length2=48, Offset=358, Offset2=692)]
[XmlElement("STOCK_FEC", Form=XmlSchemaForm.Unqualified)]
public String Stock_Fec
{ 
get
{
return _Stock_Fec;
}
set
{
_Stock_Fec=value;
}
}
private String _Stock_Fec;
[RfcField(AbapName="EST_RESERV", RfcType=RFCTYPE.RFCTYPE_INT, Length=4, Length2=4, Offset=384, Offset2=740)]
[XmlElement("EST_RESERV", Form=XmlSchemaForm.Unqualified)]
public Int32 Est_Reserv
{ 
get
{
return _Est_Reserv;
}
set
{
_Est_Reserv=value;
}
}
private Int32 _Est_Reserv;
[RfcField(AbapName="N_FACT", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=32, Length2=64, Offset=388, Offset2=744)]
[XmlElement("N_FACT", Form=XmlSchemaForm.Unqualified)]
public String N_Fact
{ 
get
{
return _N_Fact;
}
set
{
_N_Fact=value;
}
}
private String _N_Fact;
[RfcField(AbapName="N_GUIA", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=32, Length2=64, Offset=420, Offset2=808)]
[XmlElement("N_GUIA", Form=XmlSchemaForm.Unqualified)]
public String N_Guia
{ 
get
{
return _N_Guia;
}
set
{
_N_Guia=value;
}
}
private String _N_Guia;
[RfcField(AbapName="N_ENT", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=20, Length2=40, Offset=452, Offset2=872)]
[XmlElement("N_ENT", Form=XmlSchemaForm.Unqualified)]
public String N_Ent
{ 
get
{
return _N_Ent;
}
set
{
_N_Ent=value;
}
}
private String _N_Ent;
// Parameters
}
}