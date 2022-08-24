internal sealed class ObjectProgress // TypeDefIndex: 1089
{
	internal static int opRecordIdCount; 
	internal bool isInitial; 
	internal int count; 
	internal BinaryTypeEnum expectedType; 
	internal object expectedTypeInformation; 
	internal string name; 
	internal InternalObjectTypeE objectTypeEnum; 
	internal InternalMemberTypeE memberTypeEnum; 
	internal InternalMemberValueE memberValueEnum; 
	internal Type dtType; 
	internal int numItems; 
	internal BinaryTypeEnum binaryTypeEnum; 
	internal object typeInformation; 
	internal int nullCount; 
	internal int memberLength; 
	internal BinaryTypeEnum[] binaryTypeEnumA; 
	internal object[] typeInformationA; 
	internal string[] memberNames; 
	internal Type[] memberTypes; 
	internal ParseRecord pr; 


internal void .ctor() { }

internal void Init() { }

internal void ArrayCountIncrement(int value) { }

internal bool GetNext(out BinaryTypeEnum outBinaryTypeEnum, out object outTypeInformation) { }

private static void .cctor() { }

}

