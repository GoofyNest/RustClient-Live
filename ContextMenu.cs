public sealed class ContextMenu : Attribute // TypeDefIndex: 3497
{	public readonly string menuItem; // 0x10
	public readonly bool validate; // 0x18
	public readonly int priority; // 0x1C


	public void .ctor(string itemName) { }

	public void .ctor(string itemName, bool isValidateFunction) { }

	public void .ctor(string itemName, bool isValidateFunction, int priority) { }

}

