public struct LayerMask // TypeDefIndex: 3516
{	// Fields
	[NativeNameAttribute] // RVA: 0xC0C40 Offset: 0xC0040 VA: 0x1800C0C40
	private int m_Mask; // 0x0

	// Properties
	public int value { get; }

	// Methods

	// RVA: 0x18E4D80 Offset: 0x18E4180 VA: 0x1818E4D80
	public static int op_Implicit(LayerMask mask) { }

	// RVA: 0x18E4D80 Offset: 0x18E4180 VA: 0x1818E4D80
	public static LayerMask op_Implicit(int intVal) { }

	// RVA: 0x13A500 Offset: 0x139900 VA: 0x18013A500
	public int get_value() { }

	[NativeMethodAttribute] // RVA: 0xC0E50 Offset: 0xC0250 VA: 0x1800C0E50
	[StaticAccessorAttribute] // RVA: 0xC0E50 Offset: 0xC0250 VA: 0x1800C0E50
	// RVA: 0x18E4D00 Offset: 0x18E4100 VA: 0x1818E4D00
	public static string LayerToName(int layer) { }

	[NativeMethodAttribute] // RVA: 0xC0FE0 Offset: 0xC03E0 VA: 0x1800C0FE0
	[StaticAccessorAttribute] // RVA: 0xC0FE0 Offset: 0xC03E0 VA: 0x1800C0FE0
	// RVA: 0x18E4D40 Offset: 0x18E4140 VA: 0x1818E4D40
	public static int NameToLayer(string layerName) { }

	// RVA: 0x18E4C10 Offset: 0x18E4010 VA: 0x1818E4C10
	public static int GetMask(string[] layerNames) { }

}

