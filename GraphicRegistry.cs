public class GraphicRegistry // TypeDefIndex: 4934
{	// Fields
	private static GraphicRegistry s_Instance; // 0x0
	private readonly Dictionary<Canvas, IndexedSet<Graphic>> m_Graphics; // 0x10
	private static readonly List<Graphic> s_EmptyList; // 0x8

	// Properties
	public static GraphicRegistry instance { get; }

	// Methods

	// RVA: 0x15E7A60 Offset: 0x15E6E60 VA: 0x1815E7A60
	protected void .ctor() { }

	// RVA: 0x15E7B60 Offset: 0x15E6F60 VA: 0x1815E7B60
	public static GraphicRegistry get_instance() { }

	// RVA: 0x15E7720 Offset: 0x15E6B20 VA: 0x1815E7720
	public static void RegisterGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x15E78B0 Offset: 0x15E6CB0 VA: 0x1815E78B0
	public static void UnregisterGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x15E7650 Offset: 0x15E6A50 VA: 0x1815E7650
	public static IList<Graphic> GetGraphicsForCanvas(Canvas canvas) { }

	// RVA: 0x15E79F0 Offset: 0x15E6DF0 VA: 0x1815E79F0
	private static void .cctor() { }

}

