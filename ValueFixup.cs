internal sealed class ValueFixup // TypeDefIndex: 1122
{
	internal ValueFixupEnum valueFixupEnum; 
	internal Array arrayObj; 
	internal int[] indexMap; 
	internal object header; 
	internal object memberObject; 
	internal static MemberInfo valueInfo; 
	internal ReadObjectInfo objectInfo; 
	internal string memberName; 


internal void .ctor(Array arrayObj, int[] indexMap) { }

internal void .ctor(object memberObject, string memberName, ReadObjectInfo objectInfo) { }

internal void Fixup(ParseRecord record, ParseRecord parent) { }

}

