public class GraphicRegistry // TypeDefIndex: 4934
{	private static GraphicRegistry s_Instance; // 0x0
	private readonly Dictionary<Canvas, IndexedSet<Graphic>> m_Graphics; // 0x10
	private static readonly List<Graphic> s_EmptyList; // 0x8

	public static GraphicRegistry instance { get; }


	protected void .ctor() { }

	public static GraphicRegistry get_instance() { }

	public static void RegisterGraphicForCanvas(Canvas c, Graphic graphic) { }

	public static void UnregisterGraphicForCanvas(Canvas c, Graphic graphic) { }

	public static IList<Graphic> GetGraphicsForCanvas(Canvas canvas) { }

	private static void .cctor() { }

}

