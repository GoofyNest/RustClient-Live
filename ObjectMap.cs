internal sealed class ObjectMap // TypeDefIndex: 1088
{	// Fields
	internal string objectName; // 0x10
	internal Type objectType; // 0x18
	internal BinaryTypeEnum[] binaryTypeEnumA; // 0x20
	internal object[] typeInformationA; // 0x28
	internal Type[] memberTypes; // 0x30
	internal string[] memberNames; // 0x38
	internal ReadObjectInfo objectInfo; // 0x40
	internal bool isInitObjectInfo; // 0x48
	internal ObjectReader objectReader; // 0x50
	internal int objectId; // 0x58
	internal BinaryAssemblyInfo assemblyInfo; // 0x60

	// Methods

	// RVA: 0x11F1570 Offset: 0x11F0970 VA: 0x1811F1570
	internal void .ctor(string objectName, Type objectType, string[] memberNames, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo) { }

	// RVA: 0x11F0FF0 Offset: 0x11F03F0 VA: 0x1811F0FF0
	internal void .ctor(string objectName, string[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, object[] typeInformationA, int[] memberAssemIds, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo, SizedArray assemIdToAssemblyTable) { }

	// RVA: 0x11F0E30 Offset: 0x11F0230 VA: 0x1811F0E30
	internal ReadObjectInfo CreateObjectInfo(ref SerializationInfo si, ref object[] memberData) { }

	// RVA: 0x11F0E80 Offset: 0x11F0280 VA: 0x1811F0E80
	internal static ObjectMap Create(string name, Type objectType, string[] memberNames, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo) { }

	// RVA: 0x11F0F20 Offset: 0x11F0320 VA: 0x1811F0F20
	internal static ObjectMap Create(string name, string[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, object[] typeInformationA, int[] memberAssemIds, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo, SizedArray assemIdToAssemblyTable) { }

}

internal class ObjectMap // TypeDefIndex: 2082
{	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

