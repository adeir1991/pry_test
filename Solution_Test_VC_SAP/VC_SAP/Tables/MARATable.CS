using System;
using System.Text;
using SAP.Connector;

namespace VC_SAP.Tables
{
[Serializable]
public class MARATable : SAPTable 
{
public override Type GetElementType() 
{
return (typeof(MARA));
}
public override object CreateNewRow()
{ 
return new MARA();
}
public MARA this[int index] 
{
get 
{
return ((MARA)(List[index]));
}
set 
{
List[index]=value;
}
}
public int Add(MARA value) 
{
return List.Add(value);
}
public void Insert(int index, MARA value) 
{
List.Insert(index, value);
}
public int IndexOf(MARA value) 
{
return List.IndexOf(value);
}
public bool Contains(MARA value) 
{
return List.Contains(value);
}
public void Remove(MARA value) 
{
List.Remove(value);
}
public void CopyTo(MARA[] array, int index) 
{
List.CopyTo(array, index);
}
}
}