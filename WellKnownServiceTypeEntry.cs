public class WellKnownServiceTypeEntry : TypeEntry // TypeDefIndex: 1156
{	// Fields
	private Type obj_type; // 0x20
	private string obj_uri; // 0x28
	private WellKnownObjectMode obj_mode; // 0x30

	// Properties
	public WellKnownObjectMode Mode { get; }
	public Type ObjectType { get; }
	public string ObjectUri { get; }

	// Methods

	// RVA: 0x1201B00 Offset: 0x1200F00 VA: 0x181201B00
	public void .ctor(string typeName, string assemblyName, string objectUri, WellKnownObjectMode mode) { }

	// RVA: 0xA178C0 Offset: 0xA16CC0 VA: 0x180A178C0
	public WellKnownObjectMode get_Mode() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public Type get_ObjectType() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public string get_ObjectUri() { }

	// RVA: 0x12018C0 Offset: 0x1200CC0 VA: 0x1812018C0 Slot: 3
	public override string ToString() { }

}

