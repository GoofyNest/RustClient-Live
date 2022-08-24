public class CanvasUpdateRegistry // TypeDefIndex: 4910
{
	private static CanvasUpdateRegistry s_Instance; 
	private bool m_PerformingLayoutUpdate; 
	private bool m_PerformingGraphicUpdate; 
	private readonly IndexedSet<ICanvasElement> m_LayoutRebuildQueue; 
	private readonly IndexedSet<ICanvasElement> m_GraphicRebuildQueue; 
	private static readonly Comparison<ICanvasElement> s_SortLayoutFunction; 

	public static CanvasUpdateRegistry instance { get; }


	protected void .ctor() { }

	public static CanvasUpdateRegistry get_instance() { }

	private bool ObjectValidForUpdate(ICanvasElement element) { }

	private void CleanInvalidItems() { }

	private void PerformUpdate() { }

	private static int ParentCount(Transform child) { }

	private static int SortLayoutList(ICanvasElement x, ICanvasElement y) { }

	public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	public static bool TryRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	public static bool TryRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	public static void UnRegisterCanvasElementForRebuild(ICanvasElement element) { }

	private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	public static bool IsRebuildingLayout() { }

	public static bool IsRebuildingGraphics() { }

	private static void .cctor() { }

}

