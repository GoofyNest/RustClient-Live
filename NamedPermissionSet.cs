public sealed class NamedPermissionSet : PermissionSet // TypeDefIndex: 901
{	// Fields
	private string name; // 0x30
	private string description; // 0x38

	// Properties
	public string Name { get; set; }

	// Methods

	// RVA: 0x17AF100 Offset: 0x17AE500 VA: 0x1817AF100
	internal void .ctor() { }

	// RVA: 0x17AEFA0 Offset: 0x17AE3A0 VA: 0x1817AEFA0
	public void .ctor(string name, PermissionState state) { }

	// RVA: 0x17AEE50 Offset: 0x17AE250 VA: 0x1817AEE50
	public void .ctor(string name) { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public string get_Name() { }

	// RVA: 0x17AF1A0 Offset: 0x17AE5A0 VA: 0x1817AF1A0
	public void set_Name(string value) { }

	// RVA: 0x17AEDC0 Offset: 0x17AE1C0 VA: 0x1817AEDC0 Slot: 12
	public override SecurityElement ToXml() { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x17AECD0 Offset: 0x17AE0D0 VA: 0x1817AECD0 Slot: 0
	public override bool Equals(object obj) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x17AED50 Offset: 0x17AE150 VA: 0x1817AED50 Slot: 2
	public override int GetHashCode() { }

}

