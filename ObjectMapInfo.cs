internal sealed class ObjectMapInfo // TypeDefIndex: 1106
{	// Fields
	internal int objectId; // 0x10
	private int numMembers; // 0x14
	private string[] memberNames; // 0x18
	private Type[] memberTypes; // 0x20

	// Methods

	// RVA: 0x11F0C60 Offset: 0x11F0060 VA: 0x1811F0C60
	internal void .ctor(int objectId, int numMembers, string[] memberNames, Type[] memberTypes) { }

	// RVA: 0x11F0CC0 Offset: 0x11F00C0 VA: 0x1811F0CC0
	internal bool isCompatible(int numMembers, string[] memberNames, Type[] memberTypes) { }

}

