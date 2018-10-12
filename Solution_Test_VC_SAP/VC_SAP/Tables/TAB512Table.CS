using System;
using System.Text;
using SAP.Connector;

namespace VC_SAP.Tables
{
[Serializable]
public class TAB512Table : SAPTable 
{
public override Type GetElementType() 
{
return (typeof(TAB512));
}
public override object CreateNewRow()
{ 
return new TAB512();
}
public TAB512 this[int index] 
{
get 
{
return ((TAB512)(List[index]));
}
set 
{
List[index]=value;
}
}
public int Add(TAB512 value) 
{
return List.Add(value);
}
public void Insert(int index, TAB512 value) 
{
List.Insert(index, value);
}
public int IndexOf(TAB512 value) 
{
return List.IndexOf(value);
}
public bool Contains(TAB512 value) 
{
return List.Contains(value);
}
public void Remove(TAB512 value) 
{
List.Remove(value);
}
public void CopyTo(TAB512[] array, int index) 
{
List.CopyTo(array, index);
}
}
}