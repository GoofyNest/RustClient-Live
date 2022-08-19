internal sealed class SerObjectInfoCache // TypeDefIndex: 1110
{	// Fields
	internal string fullTypeName; // 0x10
	internal string assemblyString; // 0x18
	internal bool hasTypeForwardedFrom; // 0x20
	internal MemberInfo[] memberInfos; // 0x28
	internal string[] memberNames; // 0x30
	internal Type[] memberTypes; // 0x38

	// Methods

	// RVA: 0xFF6C00 Offset: 0xFF6000 VA: 0x180FF6C00
	internal void .ctor(string typeName, string assemblyName, bool hasTypeForwardedFrom) { }

	// RVA: 0x11FCFC0 Offset: 0x11FC3C0 VA: 0x1811FCFC0
	internal void .ctor(Type type) { }

}

