using System;
using System.Text;
using SAP.Connector;

namespace VC_SAP.Tables
{
[Serializable]
public class ZSPI_CABECERA_DEVTable : SAPTable 
{
public override Type GetElementType() 
{
return (typeof(ZSPI_CABECERA_DEV));
}
public override object CreateNewRow()
{ 
return new ZSPI_CABECERA_DEV();
}
public ZSPI_CABECERA_DEV this[int index] 
{
get 
{
return ((ZSPI_CABECERA_DEV)(List[index]));
}
set 
{
List[index]=value;
}
}
public int Add(ZSPI_CABECERA_DEV value) 
{
return List.Add(value);
}
public void Insert(int index, ZSPI_CABECERA_DEV value) 
{
List.Insert(index, value);
}
public int IndexOf(ZSPI_CABECERA_DEV value) 
{
return List.IndexOf(value);
}
public bool Contains(ZSPI_CABECERA_DEV value) 
{
return List.Contains(value);
}
public void Remove(ZSPI_CABECERA_DEV value) 
{
List.Remove(value);
}
public void CopyTo(ZSPI_CABECERA_DEV[] array, int index) 
{
List.CopyTo(array, index);
}
}
}