public sealed class InternalsVisibleToAttribute : Attribute // TypeDefIndex: 1307
{	// Fields
	private string _assemblyName; // 0x10
	private bool _allInternalsVisible; // 0x18

	// Properties
	public string AssemblyName { get; }
	public bool AllInternalsVisible { get; set; }

	// Methods

	// RVA: 0xFE28B0 Offset: 0xFE1CB0 VA: 0x180FE28B0
	public void .ctor(string assemblyName) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_AssemblyName() { }

	// RVA: 0x95B2D0 Offset: 0x95A6D0 VA: 0x18095B2D0
	public bool get_AllInternalsVisible() { }

	// RVA: 0x95B2F0 Offset: 0x95A6F0 VA: 0x18095B2F0
	public void set_AllInternalsVisible(bool value) { }

}

