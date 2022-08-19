public sealed class ContextMenu : Attribute // TypeDefIndex: 3497
{	// Fields
	public readonly string menuItem; // 0x10
	public readonly bool validate; // 0x18
	public readonly int priority; // 0x1C

	// Methods

	// RVA: 0x18216A0 Offset: 0x1820AA0 VA: 0x1818216A0
	public void .ctor(string itemName) { }

	// RVA: 0x18216E0 Offset: 0x1820AE0 VA: 0x1818216E0
	public void .ctor(string itemName, bool isValidateFunction) { }

	// RVA: 0x1821730 Offset: 0x1820B30 VA: 0x181821730
	public void .ctor(string itemName, bool isValidateFunction, int priority) { }

}

