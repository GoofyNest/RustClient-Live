public class GraphicRegistry // TypeDefIndex: 4938
{
	private static GraphicRegistry s_Instance; 
	private readonly Dictionary<Canvas, IndexedSet<Graphic>> m_Graphics; 
	private static readonly List<Graphic> s_EmptyList; 

	public static GraphicRegistry instance { get; }


	protected void .ctor() { }

	public static GraphicRegistry get_instance() { }

	public static void RegisterGraphicForCanvas(Canvas c, Graphic graphic) { }

	public static void UnregisterGraphicForCanvas(Canvas c, Graphic graphic) { }

	public static IList<Graphic> GetGraphicsForCanvas(Canvas canvas) { }

	private static void .cctor() { }

}

