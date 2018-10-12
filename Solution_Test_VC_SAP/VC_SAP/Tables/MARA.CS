using System;
using System.Xml.Serialization;
using System.Xml.Schema;
using SAP.Connector;

namespace VC_SAP.Tables
{
[RfcStructure(AbapName="MARA", Length=2770, Length2=5378)]
[Serializable]
public class MARA : SAPStructure
{
[RfcField(AbapName="MANDT", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=6, Length2=12, Offset=0, Offset2=0)]
[XmlElement("MANDT", Form=XmlSchemaForm.Unqualified)]
public String Mandt
{ 
get
{
return _Mandt;
}
set
{
_Mandt=value;
}
}
private String _Mandt;
[RfcField(AbapName="MATNR", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=36, Length2=72, Offset=6, Offset2=12)]
[XmlElement("MATNR", Form=XmlSchemaForm.Unqualified)]
public String Matnr
{ 
get
{
return _Matnr;
}
set
{
_Matnr=value;
}
}
private String _Matnr;
[RfcField(AbapName="ERSDA", RfcType=RFCTYPE.RFCTYPE_DATE, Length=16, Length2=32, Offset=42, Offset2=84)]
[XmlElement("ERSDA", Form=XmlSchemaForm.Unqualified)]
public String Ersda
{ 
get
{
return _Ersda;
}
set
{
_Ersda=value;
}
}
private String _Ersda;
[RfcField(AbapName="ERNAM", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=24, Length2=48, Offset=58, Offset2=116)]
[XmlElement("ERNAM", Form=XmlSchemaForm.Unqualified)]
public String Ernam
{ 
get
{
return _Ernam;
}
set
{
_Ernam=value;
}
}
private String _Ernam;
[RfcField(AbapName="LAEDA", RfcType=RFCTYPE.RFCTYPE_DATE, Length=16, Length2=32, Offset=82, Offset2=164)]
[XmlElement("LAEDA", Form=XmlSchemaForm.Unqualified)]
public String Laeda
{ 
get
{
return _Laeda;
}
set
{
_Laeda=value;
}
}
private String _Laeda;
[RfcField(AbapName="AENAM", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=24, Length2=48, Offset=98, Offset2=196)]
[XmlElement("AENAM", Form=XmlSchemaForm.Unqualified)]
public String Aenam
{ 
get
{
return _Aenam;
}
set
{
_Aenam=value;
}
}
private String _Aenam;
[RfcField(AbapName="VPSTA", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=30, Length2=60, Offset=122, Offset2=244)]
[XmlElement("VPSTA", Form=XmlSchemaForm.Unqualified)]
public String Vpsta
{ 
get
{
return _Vpsta;
}
set
{
_Vpsta=value;
}
}
private String _Vpsta;
[RfcField(AbapName="PSTAT", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=30, Length2=60, Offset=152, Offset2=304)]
[XmlElement("PSTAT", Form=XmlSchemaForm.Unqualified)]
public String Pstat
{ 
get
{
return _Pstat;
}
set
{
_Pstat=value;
}
}
private String _Pstat;
[RfcField(AbapName="LVORM", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=182, Offset2=364)]
[XmlElement("LVORM", Form=XmlSchemaForm.Unqualified)]
public String Lvorm
{ 
get
{
return _Lvorm;
}
set
{
_Lvorm=value;
}
}
private String _Lvorm;
[RfcField(AbapName="MTART", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=8, Length2=16, Offset=184, Offset2=368)]
[XmlElement("MTART", Form=XmlSchemaForm.Unqualified)]
public String Mtart
{ 
get
{
return _Mtart;
}
set
{
_Mtart=value;
}
}
private String _Mtart;
[RfcField(AbapName="MBRSH", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=192, Offset2=384)]
[XmlElement("MBRSH", Form=XmlSchemaForm.Unqualified)]
public String Mbrsh
{ 
get
{
return _Mbrsh;
}
set
{
_Mbrsh=value;
}
}
private String _Mbrsh;
[RfcField(AbapName="MATKL", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=18, Length2=36, Offset=194, Offset2=388)]
[XmlElement("MATKL", Form=XmlSchemaForm.Unqualified)]
public String Matkl
{ 
get
{
return _Matkl;
}
set
{
_Matkl=value;
}
}
private String _Matkl;
[RfcField(AbapName="BISMT", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=36, Length2=72, Offset=212, Offset2=424)]
[XmlElement("BISMT", Form=XmlSchemaForm.Unqualified)]
public String Bismt
{ 
get
{
return _Bismt;
}
set
{
_Bismt=value;
}
}
private String _Bismt;
[RfcField(AbapName="MEINS", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=6, Length2=12, Offset=248, Offset2=496)]
[XmlElement("MEINS", Form=XmlSchemaForm.Unqualified)]
public String Meins
{ 
get
{
return _Meins;
}
set
{
_Meins=value;
}
}
private String _Meins;
[RfcField(AbapName="BSTME", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=6, Length2=12, Offset=254, Offset2=508)]
[XmlElement("BSTME", Form=XmlSchemaForm.Unqualified)]
public String Bstme
{ 
get
{
return _Bstme;
}
set
{
_Bstme=value;
}
}
private String _Bstme;
[RfcField(AbapName="ZEINR", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=44, Length2=88, Offset=260, Offset2=520)]
[XmlElement("ZEINR", Form=XmlSchemaForm.Unqualified)]
public String Zeinr
{ 
get
{
return _Zeinr;
}
set
{
_Zeinr=value;
}
}
private String _Zeinr;
[RfcField(AbapName="ZEIAR", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=6, Length2=12, Offset=304, Offset2=608)]
[XmlElement("ZEIAR", Form=XmlSchemaForm.Unqualified)]
public String Zeiar
{ 
get
{
return _Zeiar;
}
set
{
_Zeiar=value;
}
}
private String _Zeiar;
[RfcField(AbapName="ZEIVR", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=4, Length2=8, Offset=310, Offset2=620)]
[XmlElement("ZEIVR", Form=XmlSchemaForm.Unqualified)]
public String Zeivr
{ 
get
{
return _Zeivr;
}
set
{
_Zeivr=value;
}
}
private String _Zeivr;
[RfcField(AbapName="ZEIFO", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=8, Length2=16, Offset=314, Offset2=628)]
[XmlElement("ZEIFO", Form=XmlSchemaForm.Unqualified)]
public String Zeifo
{ 
get
{
return _Zeifo;
}
set
{
_Zeifo=value;
}
}
private String _Zeifo;
[RfcField(AbapName="AESZN", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=12, Length2=24, Offset=322, Offset2=644)]
[XmlElement("AESZN", Form=XmlSchemaForm.Unqualified)]
public String Aeszn
{ 
get
{
return _Aeszn;
}
set
{
_Aeszn=value;
}
}
private String _Aeszn;
[RfcField(AbapName="BLATT", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=6, Length2=12, Offset=334, Offset2=668)]
[XmlElement("BLATT", Form=XmlSchemaForm.Unqualified)]
public String Blatt
{ 
get
{
return _Blatt;
}
set
{
_Blatt=value;
}
}
private String _Blatt;
[RfcField(AbapName="BLANZ", RfcType=RFCTYPE.RFCTYPE_NUM, Length=6, Length2=12, Offset=340, Offset2=680)]
[XmlElement("BLANZ", Form=XmlSchemaForm.Unqualified)]
public String Blanz
{ 
get
{
return _Blanz;
}
set
{
_Blanz=value;
}
}
private String _Blanz;
[RfcField(AbapName="FERTH", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=36, Length2=72, Offset=346, Offset2=692)]
[XmlElement("FERTH", Form=XmlSchemaForm.Unqualified)]
public String Ferth
{ 
get
{
return _Ferth;
}
set
{
_Ferth=value;
}
}
private String _Ferth;
[RfcField(AbapName="FORMT", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=8, Length2=16, Offset=382, Offset2=764)]
[XmlElement("FORMT", Form=XmlSchemaForm.Unqualified)]
public String Formt
{ 
get
{
return _Formt;
}
set
{
_Formt=value;
}
}
private String _Formt;
[RfcField(AbapName="GROES", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=64, Length2=128, Offset=390, Offset2=780)]
[XmlElement("GROES", Form=XmlSchemaForm.Unqualified)]
public String Groes
{ 
get
{
return _Groes;
}
set
{
_Groes=value;
}
}
private String _Groes;
[RfcField(AbapName="WRKST", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=96, Length2=192, Offset=454, Offset2=908)]
[XmlElement("WRKST", Form=XmlSchemaForm.Unqualified)]
public String Wrkst
{ 
get
{
return _Wrkst;
}
set
{
_Wrkst=value;
}
}
private String _Wrkst;
[RfcField(AbapName="NORMT", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=36, Length2=72, Offset=550, Offset2=1100)]
[XmlElement("NORMT", Form=XmlSchemaForm.Unqualified)]
public String Normt
{ 
get
{
return _Normt;
}
set
{
_Normt=value;
}
}
private String _Normt;
[RfcField(AbapName="LABOR", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=6, Length2=12, Offset=586, Offset2=1172)]
[XmlElement("LABOR", Form=XmlSchemaForm.Unqualified)]
public String Labor
{ 
get
{
return _Labor;
}
set
{
_Labor=value;
}
}
private String _Labor;
[RfcField(AbapName="EKWSL", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=8, Length2=16, Offset=592, Offset2=1184)]
[XmlElement("EKWSL", Form=XmlSchemaForm.Unqualified)]
public String Ekwsl
{ 
get
{
return _Ekwsl;
}
set
{
_Ekwsl=value;
}
}
private String _Ekwsl;
[RfcField(AbapName="BRGEW", RfcType=RFCTYPE.RFCTYPE_BCD, Decimals=3, Length=7, Length2=7, Offset=600, Offset2=1200)]
[XmlElement("BRGEW", Form=XmlSchemaForm.Unqualified)]
public Decimal Brgew
{ 
get
{
return _Brgew;
}
set
{
_Brgew=value;
}
}
private Decimal _Brgew;
[RfcField(AbapName="NTGEW", RfcType=RFCTYPE.RFCTYPE_BCD, Decimals=3, Length=7, Length2=7, Offset=607, Offset2=1208)]
[XmlElement("NTGEW", Form=XmlSchemaForm.Unqualified)]
public Decimal Ntgew
{ 
get
{
return _Ntgew;
}
set
{
_Ntgew=value;
}
}
private Decimal _Ntgew;
[RfcField(AbapName="GEWEI", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=6, Length2=12, Offset=614, Offset2=1216)]
[XmlElement("GEWEI", Form=XmlSchemaForm.Unqualified)]
public String Gewei
{ 
get
{
return _Gewei;
}
set
{
_Gewei=value;
}
}
private String _Gewei;
[RfcField(AbapName="VOLUM", RfcType=RFCTYPE.RFCTYPE_BCD, Decimals=3, Length=7, Length2=7, Offset=620, Offset2=1228)]
[XmlElement("VOLUM", Form=XmlSchemaForm.Unqualified)]
public Decimal Volum
{ 
get
{
return _Volum;
}
set
{
_Volum=value;
}
}
private Decimal _Volum;
[RfcField(AbapName="VOLEH", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=6, Length2=12, Offset=628, Offset2=1236)]
[XmlElement("VOLEH", Form=XmlSchemaForm.Unqualified)]
public String Voleh
{ 
get
{
return _Voleh;
}
set
{
_Voleh=value;
}
}
private String _Voleh;
[RfcField(AbapName="BEHVO", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=4, Length2=8, Offset=634, Offset2=1248)]
[XmlElement("BEHVO", Form=XmlSchemaForm.Unqualified)]
public String Behvo
{ 
get
{
return _Behvo;
}
set
{
_Behvo=value;
}
}
private String _Behvo;
[RfcField(AbapName="RAUBE", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=4, Length2=8, Offset=638, Offset2=1256)]
[XmlElement("RAUBE", Form=XmlSchemaForm.Unqualified)]
public String Raube
{ 
get
{
return _Raube;
}
set
{
_Raube=value;
}
}
private String _Raube;
[RfcField(AbapName="TEMPB", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=4, Length2=8, Offset=642, Offset2=1264)]
[XmlElement("TEMPB", Form=XmlSchemaForm.Unqualified)]
public String Tempb
{ 
get
{
return _Tempb;
}
set
{
_Tempb=value;
}
}
private String _Tempb;
[RfcField(AbapName="DISST", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=6, Length2=12, Offset=646, Offset2=1272)]
[XmlElement("DISST", Form=XmlSchemaForm.Unqualified)]
public String Disst
{ 
get
{
return _Disst;
}
set
{
_Disst=value;
}
}
private String _Disst;
[RfcField(AbapName="TRAGR", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=8, Length2=16, Offset=652, Offset2=1284)]
[XmlElement("TRAGR", Form=XmlSchemaForm.Unqualified)]
public String Tragr
{ 
get
{
return _Tragr;
}
set
{
_Tragr=value;
}
}
private String _Tragr;
[RfcField(AbapName="STOFF", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=36, Length2=72, Offset=660, Offset2=1300)]
[XmlElement("STOFF", Form=XmlSchemaForm.Unqualified)]
public String Stoff
{ 
get
{
return _Stoff;
}
set
{
_Stoff=value;
}
}
private String _Stoff;
[RfcField(AbapName="SPART", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=4, Length2=8, Offset=696, Offset2=1372)]
[XmlElement("SPART", Form=XmlSchemaForm.Unqualified)]
public String Spart
{ 
get
{
return _Spart;
}
set
{
_Spart=value;
}
}
private String _Spart;
[RfcField(AbapName="KUNNR", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=20, Length2=40, Offset=700, Offset2=1380)]
[XmlElement("KUNNR", Form=XmlSchemaForm.Unqualified)]
public String Kunnr
{ 
get
{
return _Kunnr;
}
set
{
_Kunnr=value;
}
}
private String _Kunnr;
[RfcField(AbapName="EANNR", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=26, Length2=52, Offset=720, Offset2=1420)]
[XmlElement("EANNR", Form=XmlSchemaForm.Unqualified)]
public String Eannr
{ 
get
{
return _Eannr;
}
set
{
_Eannr=value;
}
}
private String _Eannr;
[RfcField(AbapName="WESCH", RfcType=RFCTYPE.RFCTYPE_BCD, Decimals=3, Length=7, Length2=7, Offset=746, Offset2=1472)]
[XmlElement("WESCH", Form=XmlSchemaForm.Unqualified)]
public Decimal Wesch
{ 
get
{
return _Wesch;
}
set
{
_Wesch=value;
}
}
private Decimal _Wesch;
[RfcField(AbapName="BWVOR", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=754, Offset2=1480)]
[XmlElement("BWVOR", Form=XmlSchemaForm.Unqualified)]
public String Bwvor
{ 
get
{
return _Bwvor;
}
set
{
_Bwvor=value;
}
}
private String _Bwvor;
[RfcField(AbapName="BWSCL", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=756, Offset2=1484)]
[XmlElement("BWSCL", Form=XmlSchemaForm.Unqualified)]
public String Bwscl
{ 
get
{
return _Bwscl;
}
set
{
_Bwscl=value;
}
}
private String _Bwscl;
[RfcField(AbapName="SAISO", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=8, Length2=16, Offset=758, Offset2=1488)]
[XmlElement("SAISO", Form=XmlSchemaForm.Unqualified)]
public String Saiso
{ 
get
{
return _Saiso;
}
set
{
_Saiso=value;
}
}
private String _Saiso;
[RfcField(AbapName="ETIAR", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=4, Length2=8, Offset=766, Offset2=1504)]
[XmlElement("ETIAR", Form=XmlSchemaForm.Unqualified)]
public String Etiar
{ 
get
{
return _Etiar;
}
set
{
_Etiar=value;
}
}
private String _Etiar;
[RfcField(AbapName="ETIFO", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=4, Length2=8, Offset=770, Offset2=1512)]
[XmlElement("ETIFO", Form=XmlSchemaForm.Unqualified)]
public String Etifo
{ 
get
{
return _Etifo;
}
set
{
_Etifo=value;
}
}
private String _Etifo;
[RfcField(AbapName="ENTAR", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=774, Offset2=1520)]
[XmlElement("ENTAR", Form=XmlSchemaForm.Unqualified)]
public String Entar
{ 
get
{
return _Entar;
}
set
{
_Entar=value;
}
}
private String _Entar;
[RfcField(AbapName="EAN11", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=36, Length2=72, Offset=776, Offset2=1524)]
[XmlElement("EAN11", Form=XmlSchemaForm.Unqualified)]
public String Ean11
{ 
get
{
return _Ean11;
}
set
{
_Ean11=value;
}
}
private String _Ean11;
[RfcField(AbapName="NUMTP", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=4, Length2=8, Offset=812, Offset2=1596)]
[XmlElement("NUMTP", Form=XmlSchemaForm.Unqualified)]
public String Numtp
{ 
get
{
return _Numtp;
}
set
{
_Numtp=value;
}
}
private String _Numtp;
[RfcField(AbapName="LAENG", RfcType=RFCTYPE.RFCTYPE_BCD, Decimals=3, Length=7, Length2=7, Offset=816, Offset2=1604)]
[XmlElement("LAENG", Form=XmlSchemaForm.Unqualified)]
public Decimal Laeng
{ 
get
{
return _Laeng;
}
set
{
_Laeng=value;
}
}
private Decimal _Laeng;
[RfcField(AbapName="BREIT", RfcType=RFCTYPE.RFCTYPE_BCD, Decimals=3, Length=7, Length2=7, Offset=823, Offset2=1612)]
[XmlElement("BREIT", Form=XmlSchemaForm.Unqualified)]
public Decimal Breit
{ 
get
{
return _Breit;
}
set
{
_Breit=value;
}
}
private Decimal _Breit;
[RfcField(AbapName="HOEHE", RfcType=RFCTYPE.RFCTYPE_BCD, Decimals=3, Length=7, Length2=7, Offset=830, Offset2=1620)]
[XmlElement("HOEHE", Form=XmlSchemaForm.Unqualified)]
public Decimal Hoehe
{ 
get
{
return _Hoehe;
}
set
{
_Hoehe=value;
}
}
private Decimal _Hoehe;
[RfcField(AbapName="MEABM", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=6, Length2=12, Offset=838, Offset2=1628)]
[XmlElement("MEABM", Form=XmlSchemaForm.Unqualified)]
public String Meabm
{ 
get
{
return _Meabm;
}
set
{
_Meabm=value;
}
}
private String _Meabm;
[RfcField(AbapName="PRDHA", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=36, Length2=72, Offset=844, Offset2=1640)]
[XmlElement("PRDHA", Form=XmlSchemaForm.Unqualified)]
public String Prdha
{ 
get
{
return _Prdha;
}
set
{
_Prdha=value;
}
}
private String _Prdha;
[RfcField(AbapName="AEKLK", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=880, Offset2=1712)]
[XmlElement("AEKLK", Form=XmlSchemaForm.Unqualified)]
public String Aeklk
{ 
get
{
return _Aeklk;
}
set
{
_Aeklk=value;
}
}
private String _Aeklk;
[RfcField(AbapName="CADKZ", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=882, Offset2=1716)]
[XmlElement("CADKZ", Form=XmlSchemaForm.Unqualified)]
public String Cadkz
{ 
get
{
return _Cadkz;
}
set
{
_Cadkz=value;
}
}
private String _Cadkz;
[RfcField(AbapName="QMPUR", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=884, Offset2=1720)]
[XmlElement("QMPUR", Form=XmlSchemaForm.Unqualified)]
public String Qmpur
{ 
get
{
return _Qmpur;
}
set
{
_Qmpur=value;
}
}
private String _Qmpur;
[RfcField(AbapName="ERGEW", RfcType=RFCTYPE.RFCTYPE_BCD, Decimals=3, Length=7, Length2=7, Offset=886, Offset2=1724)]
[XmlElement("ERGEW", Form=XmlSchemaForm.Unqualified)]
public Decimal Ergew
{ 
get
{
return _Ergew;
}
set
{
_Ergew=value;
}
}
private Decimal _Ergew;
[RfcField(AbapName="ERGEI", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=6, Length2=12, Offset=894, Offset2=1732)]
[XmlElement("ERGEI", Form=XmlSchemaForm.Unqualified)]
public String Ergei
{ 
get
{
return _Ergei;
}
set
{
_Ergei=value;
}
}
private String _Ergei;
[RfcField(AbapName="ERVOL", RfcType=RFCTYPE.RFCTYPE_BCD, Decimals=3, Length=7, Length2=7, Offset=900, Offset2=1744)]
[XmlElement("ERVOL", Form=XmlSchemaForm.Unqualified)]
public Decimal Ervol
{ 
get
{
return _Ervol;
}
set
{
_Ervol=value;
}
}
private Decimal _Ervol;
[RfcField(AbapName="ERVOE", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=6, Length2=12, Offset=908, Offset2=1752)]
[XmlElement("ERVOE", Form=XmlSchemaForm.Unqualified)]
public String Ervoe
{ 
get
{
return _Ervoe;
}
set
{
_Ervoe=value;
}
}
private String _Ervoe;
[RfcField(AbapName="GEWTO", RfcType=RFCTYPE.RFCTYPE_BCD, Decimals=1, Length=2, Length2=2, Offset=914, Offset2=1764)]
[XmlElement("GEWTO", Form=XmlSchemaForm.Unqualified)]
public Decimal Gewto
{ 
get
{
return _Gewto;
}
set
{
_Gewto=value;
}
}
private Decimal _Gewto;
[RfcField(AbapName="VOLTO", RfcType=RFCTYPE.RFCTYPE_BCD, Decimals=1, Length=2, Length2=2, Offset=916, Offset2=1766)]
[XmlElement("VOLTO", Form=XmlSchemaForm.Unqualified)]
public Decimal Volto
{ 
get
{
return _Volto;
}
set
{
_Volto=value;
}
}
private Decimal _Volto;
[RfcField(AbapName="VABME", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=918, Offset2=1768)]
[XmlElement("VABME", Form=XmlSchemaForm.Unqualified)]
public String Vabme
{ 
get
{
return _Vabme;
}
set
{
_Vabme=value;
}
}
private String _Vabme;
[RfcField(AbapName="KZREV", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=920, Offset2=1772)]
[XmlElement("KZREV", Form=XmlSchemaForm.Unqualified)]
public String Kzrev
{ 
get
{
return _Kzrev;
}
set
{
_Kzrev=value;
}
}
private String _Kzrev;
[RfcField(AbapName="KZKFG", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=922, Offset2=1776)]
[XmlElement("KZKFG", Form=XmlSchemaForm.Unqualified)]
public String Kzkfg
{ 
get
{
return _Kzkfg;
}
set
{
_Kzkfg=value;
}
}
private String _Kzkfg;
[RfcField(AbapName="XCHPF", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=924, Offset2=1780)]
[XmlElement("XCHPF", Form=XmlSchemaForm.Unqualified)]
public String Xchpf
{ 
get
{
return _Xchpf;
}
set
{
_Xchpf=value;
}
}
private String _Xchpf;
[RfcField(AbapName="VHART", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=8, Length2=16, Offset=926, Offset2=1784)]
[XmlElement("VHART", Form=XmlSchemaForm.Unqualified)]
public String Vhart
{ 
get
{
return _Vhart;
}
set
{
_Vhart=value;
}
}
private String _Vhart;
[RfcField(AbapName="FUELG", RfcType=RFCTYPE.RFCTYPE_BCD, Length=2, Length2=2, Offset=934, Offset2=1800)]
[XmlElement("FUELG", Form=XmlSchemaForm.Unqualified)]
public Decimal Fuelg
{ 
get
{
return _Fuelg;
}
set
{
_Fuelg=value;
}
}
private Decimal _Fuelg;
[RfcField(AbapName="STFAK", RfcType=RFCTYPE.RFCTYPE_INT2, Length=2, Length2=2, Offset=936, Offset2=1802)]
[XmlElement("STFAK", Form=XmlSchemaForm.Unqualified)]
public Int16 Stfak
{ 
get
{
return _Stfak;
}
set
{
_Stfak=value;
}
}
private Int16 _Stfak;
[RfcField(AbapName="MAGRV", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=8, Length2=16, Offset=938, Offset2=1804)]
[XmlElement("MAGRV", Form=XmlSchemaForm.Unqualified)]
public String Magrv
{ 
get
{
return _Magrv;
}
set
{
_Magrv=value;
}
}
private String _Magrv;
[RfcField(AbapName="BEGRU", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=8, Length2=16, Offset=946, Offset2=1820)]
[XmlElement("BEGRU", Form=XmlSchemaForm.Unqualified)]
public String Begru
{ 
get
{
return _Begru;
}
set
{
_Begru=value;
}
}
private String _Begru;
[RfcField(AbapName="DATAB", RfcType=RFCTYPE.RFCTYPE_DATE, Length=16, Length2=32, Offset=954, Offset2=1836)]
[XmlElement("DATAB", Form=XmlSchemaForm.Unqualified)]
public String Datab
{ 
get
{
return _Datab;
}
set
{
_Datab=value;
}
}
private String _Datab;
[RfcField(AbapName="LIQDT", RfcType=RFCTYPE.RFCTYPE_DATE, Length=16, Length2=32, Offset=970, Offset2=1868)]
[XmlElement("LIQDT", Form=XmlSchemaForm.Unqualified)]
public String Liqdt
{ 
get
{
return _Liqdt;
}
set
{
_Liqdt=value;
}
}
private String _Liqdt;
[RfcField(AbapName="SAISJ", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=8, Length2=16, Offset=986, Offset2=1900)]
[XmlElement("SAISJ", Form=XmlSchemaForm.Unqualified)]
public String Saisj
{ 
get
{
return _Saisj;
}
set
{
_Saisj=value;
}
}
private String _Saisj;
[RfcField(AbapName="PLGTP", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=4, Length2=8, Offset=994, Offset2=1916)]
[XmlElement("PLGTP", Form=XmlSchemaForm.Unqualified)]
public String Plgtp
{ 
get
{
return _Plgtp;
}
set
{
_Plgtp=value;
}
}
private String _Plgtp;
[RfcField(AbapName="MLGUT", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=998, Offset2=1924)]
[XmlElement("MLGUT", Form=XmlSchemaForm.Unqualified)]
public String Mlgut
{ 
get
{
return _Mlgut;
}
set
{
_Mlgut=value;
}
}
private String _Mlgut;
[RfcField(AbapName="EXTWG", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=36, Length2=72, Offset=1000, Offset2=1928)]
[XmlElement("EXTWG", Form=XmlSchemaForm.Unqualified)]
public String Extwg
{ 
get
{
return _Extwg;
}
set
{
_Extwg=value;
}
}
private String _Extwg;
[RfcField(AbapName="SATNR", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=36, Length2=72, Offset=1036, Offset2=2000)]
[XmlElement("SATNR", Form=XmlSchemaForm.Unqualified)]
public String Satnr
{ 
get
{
return _Satnr;
}
set
{
_Satnr=value;
}
}
private String _Satnr;
[RfcField(AbapName="ATTYP", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=4, Length2=8, Offset=1072, Offset2=2072)]
[XmlElement("ATTYP", Form=XmlSchemaForm.Unqualified)]
public String Attyp
{ 
get
{
return _Attyp;
}
set
{
_Attyp=value;
}
}
private String _Attyp;
[RfcField(AbapName="KZKUP", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=1076, Offset2=2080)]
[XmlElement("KZKUP", Form=XmlSchemaForm.Unqualified)]
public String Kzkup
{ 
get
{
return _Kzkup;
}
set
{
_Kzkup=value;
}
}
private String _Kzkup;
[RfcField(AbapName="KZNFM", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=1078, Offset2=2084)]
[XmlElement("KZNFM", Form=XmlSchemaForm.Unqualified)]
public String Kznfm
{ 
get
{
return _Kznfm;
}
set
{
_Kznfm=value;
}
}
private String _Kznfm;
[RfcField(AbapName="PMATA", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=36, Length2=72, Offset=1080, Offset2=2088)]
[XmlElement("PMATA", Form=XmlSchemaForm.Unqualified)]
public String Pmata
{ 
get
{
return _Pmata;
}
set
{
_Pmata=value;
}
}
private String _Pmata;
[RfcField(AbapName="MSTAE", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=4, Length2=8, Offset=1116, Offset2=2160)]
[XmlElement("MSTAE", Form=XmlSchemaForm.Unqualified)]
public String Mstae
{ 
get
{
return _Mstae;
}
set
{
_Mstae=value;
}
}
private String _Mstae;
[RfcField(AbapName="MSTAV", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=4, Length2=8, Offset=1120, Offset2=2168)]
[XmlElement("MSTAV", Form=XmlSchemaForm.Unqualified)]
public String Mstav
{ 
get
{
return _Mstav;
}
set
{
_Mstav=value;
}
}
private String _Mstav;
[RfcField(AbapName="MSTDE", RfcType=RFCTYPE.RFCTYPE_DATE, Length=16, Length2=32, Offset=1124, Offset2=2176)]
[XmlElement("MSTDE", Form=XmlSchemaForm.Unqualified)]
public String Mstde
{ 
get
{
return _Mstde;
}
set
{
_Mstde=value;
}
}
private String _Mstde;
[RfcField(AbapName="MSTDV", RfcType=RFCTYPE.RFCTYPE_DATE, Length=16, Length2=32, Offset=1140, Offset2=2208)]
[XmlElement("MSTDV", Form=XmlSchemaForm.Unqualified)]
public String Mstdv
{ 
get
{
return _Mstdv;
}
set
{
_Mstdv=value;
}
}
private String _Mstdv;
[RfcField(AbapName="TAKLV", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=1156, Offset2=2240)]
[XmlElement("TAKLV", Form=XmlSchemaForm.Unqualified)]
public String Taklv
{ 
get
{
return _Taklv;
}
set
{
_Taklv=value;
}
}
private String _Taklv;
[RfcField(AbapName="RBNRM", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=18, Length2=36, Offset=1158, Offset2=2244)]
[XmlElement("RBNRM", Form=XmlSchemaForm.Unqualified)]
public String Rbnrm
{ 
get
{
return _Rbnrm;
}
set
{
_Rbnrm=value;
}
}
private String _Rbnrm;
[RfcField(AbapName="MHDRZ", RfcType=RFCTYPE.RFCTYPE_BCD, Length=3, Length2=3, Offset=1176, Offset2=2280)]
[XmlElement("MHDRZ", Form=XmlSchemaForm.Unqualified)]
public Decimal Mhdrz
{ 
get
{
return _Mhdrz;
}
set
{
_Mhdrz=value;
}
}
private Decimal _Mhdrz;
[RfcField(AbapName="MHDHB", RfcType=RFCTYPE.RFCTYPE_BCD, Length=3, Length2=3, Offset=1179, Offset2=2284)]
[XmlElement("MHDHB", Form=XmlSchemaForm.Unqualified)]
public Decimal Mhdhb
{ 
get
{
return _Mhdhb;
}
set
{
_Mhdhb=value;
}
}
private Decimal _Mhdhb;
[RfcField(AbapName="MHDLP", RfcType=RFCTYPE.RFCTYPE_BCD, Length=2, Length2=2, Offset=1182, Offset2=2288)]
[XmlElement("MHDLP", Form=XmlSchemaForm.Unqualified)]
public Decimal Mhdlp
{ 
get
{
return _Mhdlp;
}
set
{
_Mhdlp=value;
}
}
private Decimal _Mhdlp;
[RfcField(AbapName="INHME", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=6, Length2=12, Offset=1184, Offset2=2290)]
[XmlElement("INHME", Form=XmlSchemaForm.Unqualified)]
public String Inhme
{ 
get
{
return _Inhme;
}
set
{
_Inhme=value;
}
}
private String _Inhme;
[RfcField(AbapName="INHAL", RfcType=RFCTYPE.RFCTYPE_BCD, Decimals=3, Length=7, Length2=7, Offset=1190, Offset2=2302)]
[XmlElement("INHAL", Form=XmlSchemaForm.Unqualified)]
public Decimal Inhal
{ 
get
{
return _Inhal;
}
set
{
_Inhal=value;
}
}
private Decimal _Inhal;
[RfcField(AbapName="VPREH", RfcType=RFCTYPE.RFCTYPE_BCD, Length=3, Length2=3, Offset=1197, Offset2=2310)]
[XmlElement("VPREH", Form=XmlSchemaForm.Unqualified)]
public Decimal Vpreh
{ 
get
{
return _Vpreh;
}
set
{
_Vpreh=value;
}
}
private Decimal _Vpreh;
[RfcField(AbapName="ETIAG", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=36, Length2=72, Offset=1200, Offset2=2314)]
[XmlElement("ETIAG", Form=XmlSchemaForm.Unqualified)]
public String Etiag
{ 
get
{
return _Etiag;
}
set
{
_Etiag=value;
}
}
private String _Etiag;
[RfcField(AbapName="INHBR", RfcType=RFCTYPE.RFCTYPE_BCD, Decimals=3, Length=7, Length2=7, Offset=1236, Offset2=2386)]
[XmlElement("INHBR", Form=XmlSchemaForm.Unqualified)]
public Decimal Inhbr
{ 
get
{
return _Inhbr;
}
set
{
_Inhbr=value;
}
}
private Decimal _Inhbr;
[RfcField(AbapName="CMETH", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=1244, Offset2=2394)]
[XmlElement("CMETH", Form=XmlSchemaForm.Unqualified)]
public String Cmeth
{ 
get
{
return _Cmeth;
}
set
{
_Cmeth=value;
}
}
private String _Cmeth;
[RfcField(AbapName="CUOBF", RfcType=RFCTYPE.RFCTYPE_NUM, Length=36, Length2=72, Offset=1246, Offset2=2398)]
[XmlElement("CUOBF", Form=XmlSchemaForm.Unqualified)]
public String Cuobf
{ 
get
{
return _Cuobf;
}
set
{
_Cuobf=value;
}
}
private String _Cuobf;
[RfcField(AbapName="KZUMW", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=1282, Offset2=2470)]
[XmlElement("KZUMW", Form=XmlSchemaForm.Unqualified)]
public String Kzumw
{ 
get
{
return _Kzumw;
}
set
{
_Kzumw=value;
}
}
private String _Kzumw;
[RfcField(AbapName="KOSCH", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=36, Length2=72, Offset=1284, Offset2=2474)]
[XmlElement("KOSCH", Form=XmlSchemaForm.Unqualified)]
public String Kosch
{ 
get
{
return _Kosch;
}
set
{
_Kosch=value;
}
}
private String _Kosch;
[RfcField(AbapName="SPROF", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=1320, Offset2=2546)]
[XmlElement("SPROF", Form=XmlSchemaForm.Unqualified)]
public String Sprof
{ 
get
{
return _Sprof;
}
set
{
_Sprof=value;
}
}
private String _Sprof;
[RfcField(AbapName="NRFHG", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=1322, Offset2=2550)]
[XmlElement("NRFHG", Form=XmlSchemaForm.Unqualified)]
public String Nrfhg
{ 
get
{
return _Nrfhg;
}
set
{
_Nrfhg=value;
}
}
private String _Nrfhg;
[RfcField(AbapName="MFRPN", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=80, Length2=160, Offset=1324, Offset2=2554)]
[XmlElement("MFRPN", Form=XmlSchemaForm.Unqualified)]
public String Mfrpn
{ 
get
{
return _Mfrpn;
}
set
{
_Mfrpn=value;
}
}
private String _Mfrpn;
[RfcField(AbapName="MFRNR", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=20, Length2=40, Offset=1404, Offset2=2714)]
[XmlElement("MFRNR", Form=XmlSchemaForm.Unqualified)]
public String Mfrnr
{ 
get
{
return _Mfrnr;
}
set
{
_Mfrnr=value;
}
}
private String _Mfrnr;
[RfcField(AbapName="BMATN", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=36, Length2=72, Offset=1424, Offset2=2754)]
[XmlElement("BMATN", Form=XmlSchemaForm.Unqualified)]
public String Bmatn
{ 
get
{
return _Bmatn;
}
set
{
_Bmatn=value;
}
}
private String _Bmatn;
[RfcField(AbapName="MPROF", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=8, Length2=16, Offset=1460, Offset2=2826)]
[XmlElement("MPROF", Form=XmlSchemaForm.Unqualified)]
public String Mprof
{ 
get
{
return _Mprof;
}
set
{
_Mprof=value;
}
}
private String _Mprof;
[RfcField(AbapName="KZWSM", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=1468, Offset2=2842)]
[XmlElement("KZWSM", Form=XmlSchemaForm.Unqualified)]
public String Kzwsm
{ 
get
{
return _Kzwsm;
}
set
{
_Kzwsm=value;
}
}
private String _Kzwsm;
[RfcField(AbapName="SAITY", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=4, Length2=8, Offset=1470, Offset2=2846)]
[XmlElement("SAITY", Form=XmlSchemaForm.Unqualified)]
public String Saity
{ 
get
{
return _Saity;
}
set
{
_Saity=value;
}
}
private String _Saity;
[RfcField(AbapName="PROFL", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=6, Length2=12, Offset=1474, Offset2=2854)]
[XmlElement("PROFL", Form=XmlSchemaForm.Unqualified)]
public String Profl
{ 
get
{
return _Profl;
}
set
{
_Profl=value;
}
}
private String _Profl;
[RfcField(AbapName="IHIVI", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=1480, Offset2=2866)]
[XmlElement("IHIVI", Form=XmlSchemaForm.Unqualified)]
public String Ihivi
{ 
get
{
return _Ihivi;
}
set
{
_Ihivi=value;
}
}
private String _Ihivi;
[RfcField(AbapName="ILOOS", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=1482, Offset2=2870)]
[XmlElement("ILOOS", Form=XmlSchemaForm.Unqualified)]
public String Iloos
{ 
get
{
return _Iloos;
}
set
{
_Iloos=value;
}
}
private String _Iloos;
[RfcField(AbapName="SERLV", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=1484, Offset2=2874)]
[XmlElement("SERLV", Form=XmlSchemaForm.Unqualified)]
public String Serlv
{ 
get
{
return _Serlv;
}
set
{
_Serlv=value;
}
}
private String _Serlv;
[RfcField(AbapName="KZGVH", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=1486, Offset2=2878)]
[XmlElement("KZGVH", Form=XmlSchemaForm.Unqualified)]
public String Kzgvh
{ 
get
{
return _Kzgvh;
}
set
{
_Kzgvh=value;
}
}
private String _Kzgvh;
[RfcField(AbapName="XGCHP", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=1488, Offset2=2882)]
[XmlElement("XGCHP", Form=XmlSchemaForm.Unqualified)]
public String Xgchp
{ 
get
{
return _Xgchp;
}
set
{
_Xgchp=value;
}
}
private String _Xgchp;
[RfcField(AbapName="KZEFF", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=1490, Offset2=2886)]
[XmlElement("KZEFF", Form=XmlSchemaForm.Unqualified)]
public String Kzeff
{ 
get
{
return _Kzeff;
}
set
{
_Kzeff=value;
}
}
private String _Kzeff;
[RfcField(AbapName="COMPL", RfcType=RFCTYPE.RFCTYPE_NUM, Length=4, Length2=8, Offset=1492, Offset2=2890)]
[XmlElement("COMPL", Form=XmlSchemaForm.Unqualified)]
public String Compl
{ 
get
{
return _Compl;
}
set
{
_Compl=value;
}
}
private String _Compl;
[RfcField(AbapName="IPRKZ", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=1496, Offset2=2898)]
[XmlElement("IPRKZ", Form=XmlSchemaForm.Unqualified)]
public String Iprkz
{ 
get
{
return _Iprkz;
}
set
{
_Iprkz=value;
}
}
private String _Iprkz;
[RfcField(AbapName="RDMHD", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=1498, Offset2=2902)]
[XmlElement("RDMHD", Form=XmlSchemaForm.Unqualified)]
public String Rdmhd
{ 
get
{
return _Rdmhd;
}
set
{
_Rdmhd=value;
}
}
private String _Rdmhd;
[RfcField(AbapName="PRZUS", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=1500, Offset2=2906)]
[XmlElement("PRZUS", Form=XmlSchemaForm.Unqualified)]
public String Przus
{ 
get
{
return _Przus;
}
set
{
_Przus=value;
}
}
private String _Przus;
[RfcField(AbapName="MTPOS_MARA", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=8, Length2=16, Offset=1502, Offset2=2910)]
[XmlElement("MTPOS_MARA", Form=XmlSchemaForm.Unqualified)]
public String Mtpos_Mara
{ 
get
{
return _Mtpos_Mara;
}
set
{
_Mtpos_Mara=value;
}
}
private String _Mtpos_Mara;
[RfcField(AbapName="BFLME", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=1510, Offset2=2926)]
[XmlElement("BFLME", Form=XmlSchemaForm.Unqualified)]
public String Bflme
{ 
get
{
return _Bflme;
}
set
{
_Bflme=value;
}
}
private String _Bflme;
[RfcField(AbapName="MATFI", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=1512, Offset2=2930)]
[XmlElement("MATFI", Form=XmlSchemaForm.Unqualified)]
public String Matfi
{ 
get
{
return _Matfi;
}
set
{
_Matfi=value;
}
}
private String _Matfi;
[RfcField(AbapName="CMREL", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=1514, Offset2=2934)]
[XmlElement("CMREL", Form=XmlSchemaForm.Unqualified)]
public String Cmrel
{ 
get
{
return _Cmrel;
}
set
{
_Cmrel=value;
}
}
private String _Cmrel;
[RfcField(AbapName="BBTYP", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=1516, Offset2=2938)]
[XmlElement("BBTYP", Form=XmlSchemaForm.Unqualified)]
public String Bbtyp
{ 
get
{
return _Bbtyp;
}
set
{
_Bbtyp=value;
}
}
private String _Bbtyp;
[RfcField(AbapName="SLED_BBD", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=1518, Offset2=2942)]
[XmlElement("SLED_BBD", Form=XmlSchemaForm.Unqualified)]
public String Sled_Bbd
{ 
get
{
return _Sled_Bbd;
}
set
{
_Sled_Bbd=value;
}
}
private String _Sled_Bbd;
[RfcField(AbapName="GTIN_VARIANT", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=4, Length2=8, Offset=1520, Offset2=2946)]
[XmlElement("GTIN_VARIANT", Form=XmlSchemaForm.Unqualified)]
public String Gtin_Variant
{ 
get
{
return _Gtin_Variant;
}
set
{
_Gtin_Variant=value;
}
}
private String _Gtin_Variant;
[RfcField(AbapName="GENNR", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=36, Length2=72, Offset=1524, Offset2=2954)]
[XmlElement("GENNR", Form=XmlSchemaForm.Unqualified)]
public String Gennr
{ 
get
{
return _Gennr;
}
set
{
_Gennr=value;
}
}
private String _Gennr;
[RfcField(AbapName="RMATP", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=36, Length2=72, Offset=1560, Offset2=3026)]
[XmlElement("RMATP", Form=XmlSchemaForm.Unqualified)]
public String Rmatp
{ 
get
{
return _Rmatp;
}
set
{
_Rmatp=value;
}
}
private String _Rmatp;
[RfcField(AbapName="GDS_RELEVANT", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=1596, Offset2=3098)]
[XmlElement("GDS_RELEVANT", Form=XmlSchemaForm.Unqualified)]
public String Gds_Relevant
{ 
get
{
return _Gds_Relevant;
}
set
{
_Gds_Relevant=value;
}
}
private String _Gds_Relevant;
[RfcField(AbapName="WEORA", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=1598, Offset2=3102)]
[XmlElement("WEORA", Form=XmlSchemaForm.Unqualified)]
public String Weora
{ 
get
{
return _Weora;
}
set
{
_Weora=value;
}
}
private String _Weora;
[RfcField(AbapName="HUTYP_DFLT", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=8, Length2=16, Offset=1600, Offset2=3106)]
[XmlElement("HUTYP_DFLT", Form=XmlSchemaForm.Unqualified)]
public String Hutyp_Dflt
{ 
get
{
return _Hutyp_Dflt;
}
set
{
_Hutyp_Dflt=value;
}
}
private String _Hutyp_Dflt;
[RfcField(AbapName="PILFERABLE", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=1608, Offset2=3122)]
[XmlElement("PILFERABLE", Form=XmlSchemaForm.Unqualified)]
public String Pilferable
{ 
get
{
return _Pilferable;
}
set
{
_Pilferable=value;
}
}
private String _Pilferable;
[RfcField(AbapName="WHSTC", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=4, Length2=8, Offset=1610, Offset2=3126)]
[XmlElement("WHSTC", Form=XmlSchemaForm.Unqualified)]
public String Whstc
{ 
get
{
return _Whstc;
}
set
{
_Whstc=value;
}
}
private String _Whstc;
[RfcField(AbapName="WHMATGR", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=8, Length2=16, Offset=1614, Offset2=3134)]
[XmlElement("WHMATGR", Form=XmlSchemaForm.Unqualified)]
public String Whmatgr
{ 
get
{
return _Whmatgr;
}
set
{
_Whmatgr=value;
}
}
private String _Whmatgr;
[RfcField(AbapName="HNDLCODE", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=8, Length2=16, Offset=1622, Offset2=3150)]
[XmlElement("HNDLCODE", Form=XmlSchemaForm.Unqualified)]
public String Hndlcode
{ 
get
{
return _Hndlcode;
}
set
{
_Hndlcode=value;
}
}
private String _Hndlcode;
[RfcField(AbapName="HAZMAT", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=1630, Offset2=3166)]
[XmlElement("HAZMAT", Form=XmlSchemaForm.Unqualified)]
public String Hazmat
{ 
get
{
return _Hazmat;
}
set
{
_Hazmat=value;
}
}
private String _Hazmat;
[RfcField(AbapName="HUTYP", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=8, Length2=16, Offset=1632, Offset2=3170)]
[XmlElement("HUTYP", Form=XmlSchemaForm.Unqualified)]
public String Hutyp
{ 
get
{
return _Hutyp;
}
set
{
_Hutyp=value;
}
}
private String _Hutyp;
[RfcField(AbapName="TARE_VAR", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=1640, Offset2=3186)]
[XmlElement("TARE_VAR", Form=XmlSchemaForm.Unqualified)]
public String Tare_Var
{ 
get
{
return _Tare_Var;
}
set
{
_Tare_Var=value;
}
}
private String _Tare_Var;
[RfcField(AbapName="MAXC", RfcType=RFCTYPE.RFCTYPE_BCD, Decimals=3, Length=8, Length2=8, Offset=1642, Offset2=3190)]
[XmlElement("MAXC", Form=XmlSchemaForm.Unqualified)]
public Decimal Maxc
{ 
get
{
return _Maxc;
}
set
{
_Maxc=value;
}
}
private Decimal _Maxc;
[RfcField(AbapName="MAXC_TOL", RfcType=RFCTYPE.RFCTYPE_BCD, Decimals=1, Length=2, Length2=2, Offset=1650, Offset2=3198)]
[XmlElement("MAXC_TOL", Form=XmlSchemaForm.Unqualified)]
public Decimal Maxc_Tol
{ 
get
{
return _Maxc_Tol;
}
set
{
_Maxc_Tol=value;
}
}
private Decimal _Maxc_Tol;
[RfcField(AbapName="MAXL", RfcType=RFCTYPE.RFCTYPE_BCD, Decimals=3, Length=8, Length2=8, Offset=1652, Offset2=3200)]
[XmlElement("MAXL", Form=XmlSchemaForm.Unqualified)]
public Decimal Maxl
{ 
get
{
return _Maxl;
}
set
{
_Maxl=value;
}
}
private Decimal _Maxl;
[RfcField(AbapName="MAXB", RfcType=RFCTYPE.RFCTYPE_BCD, Decimals=3, Length=8, Length2=8, Offset=1660, Offset2=3208)]
[XmlElement("MAXB", Form=XmlSchemaForm.Unqualified)]
public Decimal Maxb
{ 
get
{
return _Maxb;
}
set
{
_Maxb=value;
}
}
private Decimal _Maxb;
[RfcField(AbapName="MAXH", RfcType=RFCTYPE.RFCTYPE_BCD, Decimals=3, Length=8, Length2=8, Offset=1668, Offset2=3216)]
[XmlElement("MAXH", Form=XmlSchemaForm.Unqualified)]
public Decimal Maxh
{ 
get
{
return _Maxh;
}
set
{
_Maxh=value;
}
}
private Decimal _Maxh;
[RfcField(AbapName="MAXDIM_UOM", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=6, Length2=12, Offset=1676, Offset2=3224)]
[XmlElement("MAXDIM_UOM", Form=XmlSchemaForm.Unqualified)]
public String Maxdim_Uom
{ 
get
{
return _Maxdim_Uom;
}
set
{
_Maxdim_Uom=value;
}
}
private String _Maxdim_Uom;
[RfcField(AbapName="HERKL", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=6, Length2=12, Offset=1682, Offset2=3236)]
[XmlElement("HERKL", Form=XmlSchemaForm.Unqualified)]
public String Herkl
{ 
get
{
return _Herkl;
}
set
{
_Herkl=value;
}
}
private String _Herkl;
[RfcField(AbapName="MFRGR", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=16, Length2=32, Offset=1688, Offset2=3248)]
[XmlElement("MFRGR", Form=XmlSchemaForm.Unqualified)]
public String Mfrgr
{ 
get
{
return _Mfrgr;
}
set
{
_Mfrgr=value;
}
}
private String _Mfrgr;
[RfcField(AbapName="QQTIME", RfcType=RFCTYPE.RFCTYPE_BCD, Length=2, Length2=2, Offset=1704, Offset2=3280)]
[XmlElement("QQTIME", Form=XmlSchemaForm.Unqualified)]
public Decimal Qqtime
{ 
get
{
return _Qqtime;
}
set
{
_Qqtime=value;
}
}
private Decimal _Qqtime;
[RfcField(AbapName="QQTIMEUOM", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=6, Length2=12, Offset=1706, Offset2=3282)]
[XmlElement("QQTIMEUOM", Form=XmlSchemaForm.Unqualified)]
public String Qqtimeuom
{ 
get
{
return _Qqtimeuom;
}
set
{
_Qqtimeuom=value;
}
}
private String _Qqtimeuom;
[RfcField(AbapName="QGRP", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=8, Length2=16, Offset=1712, Offset2=3294)]
[XmlElement("QGRP", Form=XmlSchemaForm.Unqualified)]
public String Qgrp
{ 
get
{
return _Qgrp;
}
set
{
_Qgrp=value;
}
}
private String _Qgrp;
[RfcField(AbapName="SERIAL", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=8, Length2=16, Offset=1720, Offset2=3310)]
[XmlElement("SERIAL", Form=XmlSchemaForm.Unqualified)]
public String Serial
{ 
get
{
return _Serial;
}
set
{
_Serial=value;
}
}
private String _Serial;
[RfcField(AbapName="PS_SMARTFORM", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=60, Length2=120, Offset=1728, Offset2=3326)]
[XmlElement("PS_SMARTFORM", Form=XmlSchemaForm.Unqualified)]
public String Ps_Smartform
{ 
get
{
return _Ps_Smartform;
}
set
{
_Ps_Smartform=value;
}
}
private String _Ps_Smartform;
[RfcField(AbapName="LOGUNIT", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=6, Length2=12, Offset=1788, Offset2=3446)]
[XmlElement("LOGUNIT", Form=XmlSchemaForm.Unqualified)]
public String Logunit
{ 
get
{
return _Logunit;
}
set
{
_Logunit=value;
}
}
private String _Logunit;
[RfcField(AbapName="CWQREL", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=1794, Offset2=3458)]
[XmlElement("CWQREL", Form=XmlSchemaForm.Unqualified)]
public String Cwqrel
{ 
get
{
return _Cwqrel;
}
set
{
_Cwqrel=value;
}
}
private String _Cwqrel;
[RfcField(AbapName="CWQPROC", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=4, Length2=8, Offset=1796, Offset2=3462)]
[XmlElement("CWQPROC", Form=XmlSchemaForm.Unqualified)]
public String Cwqproc
{ 
get
{
return _Cwqproc;
}
set
{
_Cwqproc=value;
}
}
private String _Cwqproc;
[RfcField(AbapName="CWQTOLGR", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=18, Length2=36, Offset=1800, Offset2=3470)]
[XmlElement("CWQTOLGR", Form=XmlSchemaForm.Unqualified)]
public String Cwqtolgr
{ 
get
{
return _Cwqtolgr;
}
set
{
_Cwqtolgr=value;
}
}
private String _Cwqtolgr;
[RfcField(AbapName="ADPROF", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=6, Length2=12, Offset=1818, Offset2=3506)]
[XmlElement("ADPROF", Form=XmlSchemaForm.Unqualified)]
public String Adprof
{ 
get
{
return _Adprof;
}
set
{
_Adprof=value;
}
}
private String _Adprof;
[RfcField(AbapName="IPMIPPRODUCT", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=80, Length2=160, Offset=1824, Offset2=3518)]
[XmlElement("IPMIPPRODUCT", Form=XmlSchemaForm.Unqualified)]
public String Ipmipproduct
{ 
get
{
return _Ipmipproduct;
}
set
{
_Ipmipproduct=value;
}
}
private String _Ipmipproduct;
[RfcField(AbapName="ALLOW_PMAT_IGNO", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=1904, Offset2=3678)]
[XmlElement("ALLOW_PMAT_IGNO", Form=XmlSchemaForm.Unqualified)]
public String Allow_Pmat_Igno
{ 
get
{
return _Allow_Pmat_Igno;
}
set
{
_Allow_Pmat_Igno=value;
}
}
private String _Allow_Pmat_Igno;
[RfcField(AbapName="MEDIUM", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=12, Length2=24, Offset=1906, Offset2=3682)]
[XmlElement("MEDIUM", Form=XmlSchemaForm.Unqualified)]
public String Medium
{ 
get
{
return _Medium;
}
set
{
_Medium=value;
}
}
private String _Medium;
[RfcField(AbapName="ANIMAL_ORIGIN", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=1918, Offset2=3706)]
[XmlElement("ANIMAL_ORIGIN", Form=XmlSchemaForm.Unqualified)]
public String Animal_Origin
{ 
get
{
return _Animal_Origin;
}
set
{
_Animal_Origin=value;
}
}
private String _Animal_Origin;
[RfcField(AbapName="TEXTILE_COMP_IND", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=1920, Offset2=3710)]
[XmlElement("TEXTILE_COMP_IND", Form=XmlSchemaForm.Unqualified)]
public String Textile_Comp_Ind
{ 
get
{
return _Textile_Comp_Ind;
}
set
{
_Textile_Comp_Ind=value;
}
}
private String _Textile_Comp_Ind;
[RfcField(AbapName="ANP", RfcType=RFCTYPE.RFCTYPE_NUM, Length=18, Length2=36, Offset=1922, Offset2=3714)]
[XmlElement("ANP", Form=XmlSchemaForm.Unqualified)]
public String Anp
{ 
get
{
return _Anp;
}
set
{
_Anp=value;
}
}
private String _Anp;
[RfcField(AbapName="/BEV1/LULEINH", RfcType=RFCTYPE.RFCTYPE_NUM, Length=16, Length2=32, Offset=1940, Offset2=3750)]
[XmlElement("_BEV1_LULEINH", Form=XmlSchemaForm.Unqualified)]
public String _Bev1_Luleinh
{ 
get
{
return __Bev1_Luleinh;
}
set
{
__Bev1_Luleinh=value;
}
}
private String __Bev1_Luleinh;
[RfcField(AbapName="/BEV1/LULDEGRP", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=6, Length2=12, Offset=1956, Offset2=3782)]
[XmlElement("_BEV1_LULDEGRP", Form=XmlSchemaForm.Unqualified)]
public String _Bev1_Luldegrp
{ 
get
{
return __Bev1_Luldegrp;
}
set
{
__Bev1_Luldegrp=value;
}
}
private String __Bev1_Luldegrp;
[RfcField(AbapName="/BEV1/NESTRUCCAT", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=1962, Offset2=3794)]
[XmlElement("_BEV1_NESTRUCCAT", Form=XmlSchemaForm.Unqualified)]
public String _Bev1_Nestruccat
{ 
get
{
return __Bev1_Nestruccat;
}
set
{
__Bev1_Nestruccat=value;
}
}
private String __Bev1_Nestruccat;
[RfcField(AbapName="/DSD/SL_TOLTYP", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=8, Length2=16, Offset=1964, Offset2=3798)]
[XmlElement("_DSD_SL_TOLTYP", Form=XmlSchemaForm.Unqualified)]
public String _Dsd_Sl_Toltyp
{ 
get
{
return __Dsd_Sl_Toltyp;
}
set
{
__Dsd_Sl_Toltyp=value;
}
}
private String __Dsd_Sl_Toltyp;
[RfcField(AbapName="/DSD/SV_CNT_GRP", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=20, Length2=40, Offset=1972, Offset2=3814)]
[XmlElement("_DSD_SV_CNT_GRP", Form=XmlSchemaForm.Unqualified)]
public String _Dsd_Sv_Cnt_Grp
{ 
get
{
return __Dsd_Sv_Cnt_Grp;
}
set
{
__Dsd_Sv_Cnt_Grp=value;
}
}
private String __Dsd_Sv_Cnt_Grp;
[RfcField(AbapName="/DSD/VC_GROUP", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=12, Length2=24, Offset=1992, Offset2=3854)]
[XmlElement("_DSD_VC_GROUP", Form=XmlSchemaForm.Unqualified)]
public String _Dsd_Vc_Group
{ 
get
{
return __Dsd_Vc_Group;
}
set
{
__Dsd_Vc_Group=value;
}
}
private String __Dsd_Vc_Group;
[RfcField(AbapName="/VSO/R_TILT_IND", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=2004, Offset2=3878)]
[XmlElement("_VSO_R_TILT_IND", Form=XmlSchemaForm.Unqualified)]
public String _Vso_R_Tilt_Ind
{ 
get
{
return __Vso_R_Tilt_Ind;
}
set
{
__Vso_R_Tilt_Ind=value;
}
}
private String __Vso_R_Tilt_Ind;
[RfcField(AbapName="/VSO/R_STACK_IND", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=2006, Offset2=3882)]
[XmlElement("_VSO_R_STACK_IND", Form=XmlSchemaForm.Unqualified)]
public String _Vso_R_Stack_Ind
{ 
get
{
return __Vso_R_Stack_Ind;
}
set
{
__Vso_R_Stack_Ind=value;
}
}
private String __Vso_R_Stack_Ind;
[RfcField(AbapName="/VSO/R_BOT_IND", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=2008, Offset2=3886)]
[XmlElement("_VSO_R_BOT_IND", Form=XmlSchemaForm.Unqualified)]
public String _Vso_R_Bot_Ind
{ 
get
{
return __Vso_R_Bot_Ind;
}
set
{
__Vso_R_Bot_Ind=value;
}
}
private String __Vso_R_Bot_Ind;
[RfcField(AbapName="/VSO/R_TOP_IND", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=2010, Offset2=3890)]
[XmlElement("_VSO_R_TOP_IND", Form=XmlSchemaForm.Unqualified)]
public String _Vso_R_Top_Ind
{ 
get
{
return __Vso_R_Top_Ind;
}
set
{
__Vso_R_Top_Ind=value;
}
}
private String __Vso_R_Top_Ind;
[RfcField(AbapName="/VSO/R_STACK_NO", RfcType=RFCTYPE.RFCTYPE_NUM, Length=6, Length2=12, Offset=2012, Offset2=3894)]
[XmlElement("_VSO_R_STACK_NO", Form=XmlSchemaForm.Unqualified)]
public String _Vso_R_Stack_No
{ 
get
{
return __Vso_R_Stack_No;
}
set
{
__Vso_R_Stack_No=value;
}
}
private String __Vso_R_Stack_No;
[RfcField(AbapName="/VSO/R_PAL_IND", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=2018, Offset2=3906)]
[XmlElement("_VSO_R_PAL_IND", Form=XmlSchemaForm.Unqualified)]
public String _Vso_R_Pal_Ind
{ 
get
{
return __Vso_R_Pal_Ind;
}
set
{
__Vso_R_Pal_Ind=value;
}
}
private String __Vso_R_Pal_Ind;
[RfcField(AbapName="/VSO/R_PAL_OVR_D", RfcType=RFCTYPE.RFCTYPE_BCD, Decimals=3, Length=7, Length2=7, Offset=2020, Offset2=3910)]
[XmlElement("_VSO_R_PAL_OVR_D", Form=XmlSchemaForm.Unqualified)]
public Decimal _Vso_R_Pal_Ovr_D
{ 
get
{
return __Vso_R_Pal_Ovr_D;
}
set
{
__Vso_R_Pal_Ovr_D=value;
}
}
private Decimal __Vso_R_Pal_Ovr_D;
[RfcField(AbapName="/VSO/R_PAL_OVR_W", RfcType=RFCTYPE.RFCTYPE_BCD, Decimals=3, Length=7, Length2=7, Offset=2027, Offset2=3918)]
[XmlElement("_VSO_R_PAL_OVR_W", Form=XmlSchemaForm.Unqualified)]
public Decimal _Vso_R_Pal_Ovr_W
{ 
get
{
return __Vso_R_Pal_Ovr_W;
}
set
{
__Vso_R_Pal_Ovr_W=value;
}
}
private Decimal __Vso_R_Pal_Ovr_W;
[RfcField(AbapName="/VSO/R_PAL_B_HT", RfcType=RFCTYPE.RFCTYPE_BCD, Decimals=3, Length=7, Length2=7, Offset=2034, Offset2=3926)]
[XmlElement("_VSO_R_PAL_B_HT", Form=XmlSchemaForm.Unqualified)]
public Decimal _Vso_R_Pal_B_Ht
{ 
get
{
return __Vso_R_Pal_B_Ht;
}
set
{
__Vso_R_Pal_B_Ht=value;
}
}
private Decimal __Vso_R_Pal_B_Ht;
[RfcField(AbapName="/VSO/R_PAL_MIN_H", RfcType=RFCTYPE.RFCTYPE_BCD, Decimals=3, Length=7, Length2=7, Offset=2041, Offset2=3934)]
[XmlElement("_VSO_R_PAL_MIN_H", Form=XmlSchemaForm.Unqualified)]
public Decimal _Vso_R_Pal_Min_H
{ 
get
{
return __Vso_R_Pal_Min_H;
}
set
{
__Vso_R_Pal_Min_H=value;
}
}
private Decimal __Vso_R_Pal_Min_H;
[RfcField(AbapName="/VSO/R_TOL_B_HT", RfcType=RFCTYPE.RFCTYPE_BCD, Decimals=3, Length=7, Length2=7, Offset=2048, Offset2=3942)]
[XmlElement("_VSO_R_TOL_B_HT", Form=XmlSchemaForm.Unqualified)]
public Decimal _Vso_R_Tol_B_Ht
{ 
get
{
return __Vso_R_Tol_B_Ht;
}
set
{
__Vso_R_Tol_B_Ht=value;
}
}
private Decimal __Vso_R_Tol_B_Ht;
[RfcField(AbapName="/VSO/R_NO_P_GVH", RfcType=RFCTYPE.RFCTYPE_NUM, Length=4, Length2=8, Offset=2056, Offset2=3950)]
[XmlElement("_VSO_R_NO_P_GVH", Form=XmlSchemaForm.Unqualified)]
public String _Vso_R_No_P_Gvh
{ 
get
{
return __Vso_R_No_P_Gvh;
}
set
{
__Vso_R_No_P_Gvh=value;
}
}
private String __Vso_R_No_P_Gvh;
[RfcField(AbapName="/VSO/R_QUAN_UNIT", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=6, Length2=12, Offset=2060, Offset2=3958)]
[XmlElement("_VSO_R_QUAN_UNIT", Form=XmlSchemaForm.Unqualified)]
public String _Vso_R_Quan_Unit
{ 
get
{
return __Vso_R_Quan_Unit;
}
set
{
__Vso_R_Quan_Unit=value;
}
}
private String __Vso_R_Quan_Unit;
[RfcField(AbapName="/VSO/R_KZGVH_IND", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=2066, Offset2=3970)]
[XmlElement("_VSO_R_KZGVH_IND", Form=XmlSchemaForm.Unqualified)]
public String _Vso_R_Kzgvh_Ind
{ 
get
{
return __Vso_R_Kzgvh_Ind;
}
set
{
__Vso_R_Kzgvh_Ind=value;
}
}
private String __Vso_R_Kzgvh_Ind;
[RfcField(AbapName="PACKCODE", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=20, Length2=40, Offset=2068, Offset2=3974)]
[XmlElement("PACKCODE", Form=XmlSchemaForm.Unqualified)]
public String Packcode
{ 
get
{
return _Packcode;
}
set
{
_Packcode=value;
}
}
private String _Packcode;
[RfcField(AbapName="DG_PACK_STATUS", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=20, Length2=40, Offset=2088, Offset2=4014)]
[XmlElement("DG_PACK_STATUS", Form=XmlSchemaForm.Unqualified)]
public String Dg_Pack_Status
{ 
get
{
return _Dg_Pack_Status;
}
set
{
_Dg_Pack_Status=value;
}
}
private String _Dg_Pack_Status;
[RfcField(AbapName="MCOND", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=2108, Offset2=4054)]
[XmlElement("MCOND", Form=XmlSchemaForm.Unqualified)]
public String Mcond
{ 
get
{
return _Mcond;
}
set
{
_Mcond=value;
}
}
private String _Mcond;
[RfcField(AbapName="RETDELC", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=2110, Offset2=4058)]
[XmlElement("RETDELC", Form=XmlSchemaForm.Unqualified)]
public String Retdelc
{ 
get
{
return _Retdelc;
}
set
{
_Retdelc=value;
}
}
private String _Retdelc;
[RfcField(AbapName="LOGLEV_RETO", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=2112, Offset2=4062)]
[XmlElement("LOGLEV_RETO", Form=XmlSchemaForm.Unqualified)]
public String Loglev_Reto
{ 
get
{
return _Loglev_Reto;
}
set
{
_Loglev_Reto=value;
}
}
private String _Loglev_Reto;
[RfcField(AbapName="NSNID", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=18, Length2=36, Offset=2114, Offset2=4066)]
[XmlElement("NSNID", Form=XmlSchemaForm.Unqualified)]
public String Nsnid
{ 
get
{
return _Nsnid;
}
set
{
_Nsnid=value;
}
}
private String _Nsnid;
[RfcField(AbapName="IMATN", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=36, Length2=72, Offset=2132, Offset2=4102)]
[XmlElement("IMATN", Form=XmlSchemaForm.Unqualified)]
public String Imatn
{ 
get
{
return _Imatn;
}
set
{
_Imatn=value;
}
}
private String _Imatn;
[RfcField(AbapName="PICNUM", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=36, Length2=72, Offset=2168, Offset2=4174)]
[XmlElement("PICNUM", Form=XmlSchemaForm.Unqualified)]
public String Picnum
{ 
get
{
return _Picnum;
}
set
{
_Picnum=value;
}
}
private String _Picnum;
[RfcField(AbapName="BSTAT", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=4, Length2=8, Offset=2204, Offset2=4246)]
[XmlElement("BSTAT", Form=XmlSchemaForm.Unqualified)]
public String Bstat
{ 
get
{
return _Bstat;
}
set
{
_Bstat=value;
}
}
private String _Bstat;
[RfcField(AbapName="COLOR_ATINN", RfcType=RFCTYPE.RFCTYPE_NUM, Length=20, Length2=40, Offset=2208, Offset2=4254)]
[XmlElement("COLOR_ATINN", Form=XmlSchemaForm.Unqualified)]
public String Color_Atinn
{ 
get
{
return _Color_Atinn;
}
set
{
_Color_Atinn=value;
}
}
private String _Color_Atinn;
[RfcField(AbapName="SIZE1_ATINN", RfcType=RFCTYPE.RFCTYPE_NUM, Length=20, Length2=40, Offset=2228, Offset2=4294)]
[XmlElement("SIZE1_ATINN", Form=XmlSchemaForm.Unqualified)]
public String Size1_Atinn
{ 
get
{
return _Size1_Atinn;
}
set
{
_Size1_Atinn=value;
}
}
private String _Size1_Atinn;
[RfcField(AbapName="SIZE2_ATINN", RfcType=RFCTYPE.RFCTYPE_NUM, Length=20, Length2=40, Offset=2248, Offset2=4334)]
[XmlElement("SIZE2_ATINN", Form=XmlSchemaForm.Unqualified)]
public String Size2_Atinn
{ 
get
{
return _Size2_Atinn;
}
set
{
_Size2_Atinn=value;
}
}
private String _Size2_Atinn;
[RfcField(AbapName="COLOR", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=36, Length2=72, Offset=2268, Offset2=4374)]
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
[RfcField(AbapName="SIZE1", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=36, Length2=72, Offset=2304, Offset2=4446)]
[XmlElement("SIZE1", Form=XmlSchemaForm.Unqualified)]
public String Size1
{ 
get
{
return _Size1;
}
set
{
_Size1=value;
}
}
private String _Size1;
[RfcField(AbapName="SIZE2", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=36, Length2=72, Offset=2340, Offset2=4518)]
[XmlElement("SIZE2", Form=XmlSchemaForm.Unqualified)]
public String Size2
{ 
get
{
return _Size2;
}
set
{
_Size2=value;
}
}
private String _Size2;
[RfcField(AbapName="FREE_CHAR", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=36, Length2=72, Offset=2376, Offset2=4590)]
[XmlElement("FREE_CHAR", Form=XmlSchemaForm.Unqualified)]
public String Free_Char
{ 
get
{
return _Free_Char;
}
set
{
_Free_Char=value;
}
}
private String _Free_Char;
[RfcField(AbapName="CARE_CODE", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=32, Length2=64, Offset=2412, Offset2=4662)]
[XmlElement("CARE_CODE", Form=XmlSchemaForm.Unqualified)]
public String Care_Code
{ 
get
{
return _Care_Code;
}
set
{
_Care_Code=value;
}
}
private String _Care_Code;
[RfcField(AbapName="BRAND_ID", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=8, Length2=16, Offset=2444, Offset2=4726)]
[XmlElement("BRAND_ID", Form=XmlSchemaForm.Unqualified)]
public String Brand_Id
{ 
get
{
return _Brand_Id;
}
set
{
_Brand_Id=value;
}
}
private String _Brand_Id;
[RfcField(AbapName="FIBER_CODE1", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=6, Length2=12, Offset=2452, Offset2=4742)]
[XmlElement("FIBER_CODE1", Form=XmlSchemaForm.Unqualified)]
public String Fiber_Code1
{ 
get
{
return _Fiber_Code1;
}
set
{
_Fiber_Code1=value;
}
}
private String _Fiber_Code1;
[RfcField(AbapName="FIBER_PART1", RfcType=RFCTYPE.RFCTYPE_NUM, Length=6, Length2=12, Offset=2458, Offset2=4754)]
[XmlElement("FIBER_PART1", Form=XmlSchemaForm.Unqualified)]
public String Fiber_Part1
{ 
get
{
return _Fiber_Part1;
}
set
{
_Fiber_Part1=value;
}
}
private String _Fiber_Part1;
[RfcField(AbapName="FIBER_CODE2", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=6, Length2=12, Offset=2464, Offset2=4766)]
[XmlElement("FIBER_CODE2", Form=XmlSchemaForm.Unqualified)]
public String Fiber_Code2
{ 
get
{
return _Fiber_Code2;
}
set
{
_Fiber_Code2=value;
}
}
private String _Fiber_Code2;
[RfcField(AbapName="FIBER_PART2", RfcType=RFCTYPE.RFCTYPE_NUM, Length=6, Length2=12, Offset=2470, Offset2=4778)]
[XmlElement("FIBER_PART2", Form=XmlSchemaForm.Unqualified)]
public String Fiber_Part2
{ 
get
{
return _Fiber_Part2;
}
set
{
_Fiber_Part2=value;
}
}
private String _Fiber_Part2;
[RfcField(AbapName="FIBER_CODE3", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=6, Length2=12, Offset=2476, Offset2=4790)]
[XmlElement("FIBER_CODE3", Form=XmlSchemaForm.Unqualified)]
public String Fiber_Code3
{ 
get
{
return _Fiber_Code3;
}
set
{
_Fiber_Code3=value;
}
}
private String _Fiber_Code3;
[RfcField(AbapName="FIBER_PART3", RfcType=RFCTYPE.RFCTYPE_NUM, Length=6, Length2=12, Offset=2482, Offset2=4802)]
[XmlElement("FIBER_PART3", Form=XmlSchemaForm.Unqualified)]
public String Fiber_Part3
{ 
get
{
return _Fiber_Part3;
}
set
{
_Fiber_Part3=value;
}
}
private String _Fiber_Part3;
[RfcField(AbapName="FIBER_CODE4", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=6, Length2=12, Offset=2488, Offset2=4814)]
[XmlElement("FIBER_CODE4", Form=XmlSchemaForm.Unqualified)]
public String Fiber_Code4
{ 
get
{
return _Fiber_Code4;
}
set
{
_Fiber_Code4=value;
}
}
private String _Fiber_Code4;
[RfcField(AbapName="FIBER_PART4", RfcType=RFCTYPE.RFCTYPE_NUM, Length=6, Length2=12, Offset=2494, Offset2=4826)]
[XmlElement("FIBER_PART4", Form=XmlSchemaForm.Unqualified)]
public String Fiber_Part4
{ 
get
{
return _Fiber_Part4;
}
set
{
_Fiber_Part4=value;
}
}
private String _Fiber_Part4;
[RfcField(AbapName="FIBER_CODE5", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=6, Length2=12, Offset=2500, Offset2=4838)]
[XmlElement("FIBER_CODE5", Form=XmlSchemaForm.Unqualified)]
public String Fiber_Code5
{ 
get
{
return _Fiber_Code5;
}
set
{
_Fiber_Code5=value;
}
}
private String _Fiber_Code5;
[RfcField(AbapName="FIBER_PART5", RfcType=RFCTYPE.RFCTYPE_NUM, Length=6, Length2=12, Offset=2506, Offset2=4850)]
[XmlElement("FIBER_PART5", Form=XmlSchemaForm.Unqualified)]
public String Fiber_Part5
{ 
get
{
return _Fiber_Part5;
}
set
{
_Fiber_Part5=value;
}
}
private String _Fiber_Part5;
[RfcField(AbapName="FASHGRD", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=8, Length2=16, Offset=2512, Offset2=4862)]
[XmlElement("FASHGRD", Form=XmlSchemaForm.Unqualified)]
public String Fashgrd
{ 
get
{
return _Fashgrd;
}
set
{
_Fashgrd=value;
}
}
private String _Fashgrd;
[RfcField(AbapName="J_3AMIND", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=2520, Offset2=4878)]
[XmlElement("J_3AMIND", Form=XmlSchemaForm.Unqualified)]
public String J_3amind
{ 
get
{
return _J_3amind;
}
set
{
_J_3amind=value;
}
}
private String _J_3amind;
[RfcField(AbapName="J_3AMSTAT", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=2522, Offset2=4882)]
[XmlElement("J_3AMSTAT", Form=XmlSchemaForm.Unqualified)]
public String J_3amstat
{ 
get
{
return _J_3amstat;
}
set
{
_J_3amstat=value;
}
}
private String _J_3amstat;
[RfcField(AbapName="J_3APGNR", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=36, Length2=72, Offset=2524, Offset2=4886)]
[XmlElement("J_3APGNR", Form=XmlSchemaForm.Unqualified)]
public String J_3apgnr
{ 
get
{
return _J_3apgnr;
}
set
{
_J_3apgnr=value;
}
}
private String _J_3apgnr;
[RfcField(AbapName="J_3AKALSV", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=12, Length2=24, Offset=2560, Offset2=4958)]
[XmlElement("J_3AKALSV", Form=XmlSchemaForm.Unqualified)]
public String J_3akalsv
{ 
get
{
return _J_3akalsv;
}
set
{
_J_3akalsv=value;
}
}
private String _J_3akalsv;
[RfcField(AbapName="J_3AKALSM", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=12, Length2=24, Offset=2572, Offset2=4982)]
[XmlElement("J_3AKALSM", Form=XmlSchemaForm.Unqualified)]
public String J_3akalsm
{ 
get
{
return _J_3akalsm;
}
set
{
_J_3akalsm=value;
}
}
private String _J_3akalsm;
[RfcField(AbapName="J_3ASMAT", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=2584, Offset2=5006)]
[XmlElement("J_3ASMAT", Form=XmlSchemaForm.Unqualified)]
public String J_3asmat
{ 
get
{
return _J_3asmat;
}
set
{
_J_3asmat=value;
}
}
private String _J_3asmat;
[RfcField(AbapName="J_3APROFP", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=20, Length2=40, Offset=2586, Offset2=5010)]
[XmlElement("J_3APROFP", Form=XmlSchemaForm.Unqualified)]
public String J_3aprofp
{ 
get
{
return _J_3aprofp;
}
set
{
_J_3aprofp=value;
}
}
private String _J_3aprofp;
[RfcField(AbapName="J_3APROFC", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=20, Length2=40, Offset=2606, Offset2=5050)]
[XmlElement("J_3APROFC", Form=XmlSchemaForm.Unqualified)]
public String J_3aprofc
{ 
get
{
return _J_3aprofc;
}
set
{
_J_3aprofc=value;
}
}
private String _J_3aprofc;
[RfcField(AbapName="J_3APROFG", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=20, Length2=40, Offset=2626, Offset2=5090)]
[XmlElement("J_3APROFG", Form=XmlSchemaForm.Unqualified)]
public String J_3aprofg
{ 
get
{
return _J_3aprofg;
}
set
{
_J_3aprofg=value;
}
}
private String _J_3aprofg;
[RfcField(AbapName="J_3APROFT", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=20, Length2=40, Offset=2646, Offset2=5130)]
[XmlElement("J_3APROFT", Form=XmlSchemaForm.Unqualified)]
public String J_3aproft
{ 
get
{
return _J_3aproft;
}
set
{
_J_3aproft=value;
}
}
private String _J_3aproft;
[RfcField(AbapName="J_3AGMID", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=4, Length2=8, Offset=2666, Offset2=5170)]
[XmlElement("J_3AGMID", Form=XmlSchemaForm.Unqualified)]
public String J_3agmid
{ 
get
{
return _J_3agmid;
}
set
{
_J_3agmid=value;
}
}
private String _J_3agmid;
[RfcField(AbapName="J_3ANOGRID", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=2670, Offset2=5178)]
[XmlElement("J_3ANOGRID", Form=XmlSchemaForm.Unqualified)]
public String J_3anogrid
{ 
get
{
return _J_3anogrid;
}
set
{
_J_3anogrid=value;
}
}
private String _J_3anogrid;
[RfcField(AbapName="J_3AFCC", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=10, Length2=20, Offset=2672, Offset2=5182)]
[XmlElement("J_3AFCC", Form=XmlSchemaForm.Unqualified)]
public String J_3afcc
{ 
get
{
return _J_3afcc;
}
set
{
_J_3afcc=value;
}
}
private String _J_3afcc;
[RfcField(AbapName="J_3AGEND", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=4, Length2=8, Offset=2682, Offset2=5202)]
[XmlElement("J_3AGEND", Form=XmlSchemaForm.Unqualified)]
public String J_3agend
{ 
get
{
return _J_3agend;
}
set
{
_J_3agend=value;
}
}
private String _J_3agend;
[RfcField(AbapName="J_3ACOL", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=10, Length2=20, Offset=2686, Offset2=5210)]
[XmlElement("J_3ACOL", Form=XmlSchemaForm.Unqualified)]
public String J_3acol
{ 
get
{
return _J_3acol;
}
set
{
_J_3acol=value;
}
}
private String _J_3acol;
[RfcField(AbapName="J_4KCSGR", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=8, Length2=16, Offset=2696, Offset2=5230)]
[XmlElement("J_4KCSGR", Form=XmlSchemaForm.Unqualified)]
public String J_4kcsgr
{ 
get
{
return _J_4kcsgr;
}
set
{
_J_4kcsgr=value;
}
}
private String _J_4kcsgr;
[RfcField(AbapName="/AFS/SCLAS", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=8, Length2=16, Offset=2704, Offset2=5246)]
[XmlElement("_AFS_SCLAS", Form=XmlSchemaForm.Unqualified)]
public String _Afs_Sclas
{ 
get
{
return __Afs_Sclas;
}
set
{
__Afs_Sclas=value;
}
}
private String __Afs_Sclas;
[RfcField(AbapName="/AFS/SCHNITT", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=36, Length2=72, Offset=2712, Offset2=5262)]
[XmlElement("_AFS_SCHNITT", Form=XmlSchemaForm.Unqualified)]
public String _Afs_Schnitt
{ 
get
{
return __Afs_Schnitt;
}
set
{
__Afs_Schnitt=value;
}
}
private String __Afs_Schnitt;
[RfcField(AbapName="J_4KCOVSA", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=16, Length2=32, Offset=2748, Offset2=5334)]
[XmlElement("J_4KCOVSA", Form=XmlSchemaForm.Unqualified)]
public String J_4kcovsa
{ 
get
{
return _J_4kcovsa;
}
set
{
_J_4kcovsa=value;
}
}
private String _J_4kcovsa;
[RfcField(AbapName="/AFS/SEALV", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=2764, Offset2=5366)]
[XmlElement("_AFS_SEALV", Form=XmlSchemaForm.Unqualified)]
public String _Afs_Sealv
{ 
get
{
return __Afs_Sealv;
}
set
{
__Afs_Sealv=value;
}
}
private String __Afs_Sealv;
[RfcField(AbapName="/AFS/SEAFX", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=2766, Offset2=5370)]
[XmlElement("_AFS_SEAFX", Form=XmlSchemaForm.Unqualified)]
public String _Afs_Seafx
{ 
get
{
return __Afs_Seafx;
}
set
{
__Afs_Seafx=value;
}
}
private String __Afs_Seafx;
[RfcField(AbapName="/AFS/SEAIM", RfcType=RFCTYPE.RFCTYPE_CHAR, Length=2, Length2=4, Offset=2768, Offset2=5374)]
[XmlElement("_AFS_SEAIM", Form=XmlSchemaForm.Unqualified)]
public String _Afs_Seaim
{ 
get
{
return __Afs_Seaim;
}
set
{
__Afs_Seaim=value;
}
}
private String __Afs_Seaim;
// Parameters
}
}