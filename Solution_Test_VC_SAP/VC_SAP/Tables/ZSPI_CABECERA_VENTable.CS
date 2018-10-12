using System;
using System.Text;
using SAP.Connector;

namespace VC_SAP.Tables
{
[Serializable]
public class ZSPI_CABECERA_VENTable : SAPTable 
{
public override Type GetElementType() 
{
return (typeof(ZSPI_CABECERA_VEN));
}
public override object CreateNewRow()
{ 
return new ZSPI_CABECERA_VEN();
}
public ZSPI_CABECERA_VEN this[int index] 
{
get 
{
return ((ZSPI_CABECERA_VEN)(List[index]));
}
set 
{
List[index]=value;
}
}
public int Add(ZSPI_CABECERA_VEN value) 
{
return List.Add(value);
}
public void Insert(int index, ZSPI_CABECERA_VEN value) 
{
List.Insert(index, value);
}
public int IndexOf(ZSPI_CABECERA_VEN value) 
{
return List.IndexOf(value);
}
public bool Contains(ZSPI_CABECERA_VEN value) 
{
return List.Contains(value);
}
public void Remove(ZSPI_CABECERA_VEN value) 
{
List.Remove(value);
}
public void CopyTo(ZSPI_CABECERA_VEN[] array, int index) 
{
List.CopyTo(array, index);
}
}
}