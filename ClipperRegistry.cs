public class ClipperRegistry // TypeDefIndex: 4912
{	// Fields
	private static ClipperRegistry s_Instance; // 0x0
	private readonly IndexedSet<IClipper> m_Clippers; // 0x10

	// Properties
	public static ClipperRegistry instance { get; }

	// Methods

	// RVA: 0x10B4650 Offset: 0x10B3A50 VA: 0x1810B4650
	protected void .ctor() { }

	// RVA: 0x10B46C0 Offset: 0x10B3AC0 VA: 0x1810B46C0
	public static ClipperRegistry get_instance() { }

	// RVA: 0x10B4470 Offset: 0x10B3870 VA: 0x1810B4470
	public void Cull() { }

	// RVA: 0x10B4590 Offset: 0x10B3990 VA: 0x1810B4590
	public static void Register(IClipper c) { }

	// RVA: 0x10B45F0 Offset: 0x10B39F0 VA: 0x1810B45F0
	public static void Unregister(IClipper c) { }

}

