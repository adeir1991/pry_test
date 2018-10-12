using System;
using System.Text;
using SAP.Connector;

namespace VC_SAP.Tables
{
[Serializable]
public class RFC_DB_OPTTable : SAPTable 
{
public override Type GetElementType() 
{
return (typeof(RFC_DB_OPT));
}
public override object CreateNewRow()
{ 
return new RFC_DB_OPT();
}
public RFC_DB_OPT this[int index] 
{
get 
{
return ((RFC_DB_OPT)(List[index]));
}
set 
{
List[index]=value;
}
}
public int Add(RFC_DB_OPT value) 
{
return List.Add(value);
}
public void Insert(int index, RFC_DB_OPT value) 
{
List.Insert(index, value);
}
public int IndexOf(RFC_DB_OPT value) 
{
return List.IndexOf(value);
}
public bool Contains(RFC_DB_OPT value) 
{
return List.Contains(value);
}
public void Remove(RFC_DB_OPT value) 
{
List.Remove(value);
}
public void CopyTo(RFC_DB_OPT[] array, int index) 
{
List.CopyTo(array, index);
}
}
}