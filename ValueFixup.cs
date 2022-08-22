internal sealed class ValueFixup // TypeDefIndex: 1122
{	internal ValueFixupEnum valueFixupEnum; // 0x10
	internal Array arrayObj; // 0x18
	internal int[] indexMap; // 0x20
	internal object header; // 0x28
	internal object memberObject; // 0x30
	internal static MemberInfo valueInfo; // 0x0
	internal ReadObjectInfo objectInfo; // 0x38
	internal string memberName; // 0x40


	internal void .ctor(Array arrayObj, int[] indexMap) { }

	internal void .ctor(object memberObject, string memberName, ReadObjectInfo objectInfo) { }

	internal void Fixup(ParseRecord record, ParseRecord parent) { }

}

