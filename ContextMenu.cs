public sealed class ContextMenu : Attribute // TypeDefIndex: 3500
{
	public readonly string menuItem; 
	public readonly bool validate; 
	public readonly int priority; 


	public void .ctor(string itemName) { }

	public void .ctor(string itemName, bool isValidateFunction) { }

	public void .ctor(string itemName, bool isValidateFunction, int priority) { }

}

