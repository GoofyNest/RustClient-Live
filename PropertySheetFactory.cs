public sealed class PropertySheetFactory // TypeDefIndex: 11862
{	// Fields
	private readonly Dictionary<Shader, PropertySheet> m_Sheets; // 0x10

	// Methods

	// RVA: 0x11D16E0 Offset: 0x11D0AE0 VA: 0x1811D16E0
	public void .ctor() { }

	[ObsoleteAttribute] // RVA: 0x7DA40 Offset: 0x7CE40 VA: 0x18007DA40
	// RVA: 0x11D1400 Offset: 0x11D0800 VA: 0x1811D1400
	public PropertySheet Get(string shaderName) { }

	// RVA: 0x11D1230 Offset: 0x11D0630 VA: 0x1811D1230
	public PropertySheet Get(Shader shader) { }

	// RVA: 0x11D14D0 Offset: 0x11D08D0 VA: 0x1811D14D0
	public void Release() { }

}

