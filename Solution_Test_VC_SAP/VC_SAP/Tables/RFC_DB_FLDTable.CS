using System;
using System.Text;
using SAP.Connector;

namespace VC_SAP.Tables
{
[Serializable]
public class RFC_DB_FLDTable : SAPTable 
{
public override Type GetElementType() 
{
return (typeof(RFC_DB_FLD));
}
public override object CreateNewRow()
{ 
return new RFC_DB_FLD();
}
public RFC_DB_FLD this[int index] 
{
get 
{
return ((RFC_DB_FLD)(List[index]));
}
set 
{
List[index]=value;
}
}
public int Add(RFC_DB_FLD value) 
{
return List.Add(value);
}
public void Insert(int index, RFC_DB_FLD value) 
{
List.Insert(index, value);
}
public int IndexOf(RFC_DB_FLD value) 
{
return List.IndexOf(value);
}
public bool Contains(RFC_DB_FLD value) 
{
return List.Contains(value);
}
public void Remove(RFC_DB_FLD value) 
{
List.Remove(value);
}
public void CopyTo(RFC_DB_FLD[] array, int index) 
{
List.CopyTo(array, index);
}
}
}