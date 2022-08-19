public class ActivatedClientTypeEntry : TypeEntry // TypeDefIndex: 1127
{	// Fields
	private string applicationUrl; // 0x20
	private Type obj_type; // 0x28

	// Properties
	public string ApplicationUrl { get; }
	public IContextAttribute[] ContextAttributes { get; }
	public Type ObjectType { get; }

	// Methods

	// RVA: 0xFD5200 Offset: 0xFD4600 VA: 0x180FD5200
	public void .ctor(string typeName, string assemblyName, string appUrl) { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public string get_ApplicationUrl() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80
	public IContextAttribute[] get_ContextAttributes() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public Type get_ObjectType() { }

	// RVA: 0xFD51E0 Offset: 0xFD45E0 VA: 0x180FD51E0 Slot: 3
	public override string ToString() { }

}

