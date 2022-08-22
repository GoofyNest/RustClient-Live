public struct LayerMask // TypeDefIndex: 3516
{	[NativeNameAttribute] // RVA: 0xC0C40 Offset: 0xC0040 VA: 0x1800C0C40
	private int m_Mask; // 0x0

	public int value { get; }


	public static int op_Implicit(LayerMask mask) { }

	public static LayerMask op_Implicit(int intVal) { }

	public int get_value() { }

	[NativeMethodAttribute] // RVA: 0xC0E50 Offset: 0xC0250 VA: 0x1800C0E50
	[StaticAccessorAttribute] // RVA: 0xC0E50 Offset: 0xC0250 VA: 0x1800C0E50
	public static string LayerToName(int layer) { }

	[NativeMethodAttribute] // RVA: 0xC0FE0 Offset: 0xC03E0 VA: 0x1800C0FE0
	[StaticAccessorAttribute] // RVA: 0xC0FE0 Offset: 0xC03E0 VA: 0x1800C0FE0
	public static int NameToLayer(string layerName) { }

	public static int GetMask(string[] layerNames) { }

}

