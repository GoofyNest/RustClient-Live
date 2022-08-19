public sealed class NeutralResourcesLanguageAttribute : Attribute // TypeDefIndex: 488
{	// Fields
	private string _culture; // 0x10
	private UltimateResourceFallbackLocation _fallbackLoc; // 0x18

	// Properties
	public string CultureName { get; }
	public UltimateResourceFallbackLocation Location { get; }

	// Methods

	// RVA: 0xFE60B0 Offset: 0xFE54B0 VA: 0x180FE60B0
	public void .ctor(string cultureName) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_CultureName() { }

	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200
	public UltimateResourceFallbackLocation get_Location() { }

}

