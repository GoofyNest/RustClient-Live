public class WellKnownClientTypeEntry : TypeEntry // TypeDefIndex: 1154
{	// Fields
	private Type obj_type; // 0x20
	private string obj_url; // 0x28
	private string app_url; // 0x30

	// Properties
	public string ApplicationUrl { get; }
	public Type ObjectType { get; }
	public string ObjectUrl { get; }

	// Methods

	// RVA: 0x1201770 Offset: 0x1200B70 VA: 0x181201770
	public void .ctor(string typeName, string assemblyName, string objectUrl) { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public string get_ApplicationUrl() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public Type get_ObjectType() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public string get_ObjectUrl() { }

	// RVA: 0x1201730 Offset: 0x1200B30 VA: 0x181201730 Slot: 3
	public override string ToString() { }

}

