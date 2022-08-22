internal sealed class SerObjectInfoCache // TypeDefIndex: 1110
{	internal string fullTypeName; // 0x10
	internal string assemblyString; // 0x18
	internal bool hasTypeForwardedFrom; // 0x20
	internal MemberInfo[] memberInfos; // 0x28
	internal string[] memberNames; // 0x30
	internal Type[] memberTypes; // 0x38


	internal void .ctor(string typeName, string assemblyName, bool hasTypeForwardedFrom) { }

	internal void .ctor(Type type) { }

}

