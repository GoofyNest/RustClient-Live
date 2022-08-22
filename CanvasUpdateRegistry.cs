public class CanvasUpdateRegistry // TypeDefIndex: 4910
{	private static CanvasUpdateRegistry s_Instance; // 0x0
	private bool m_PerformingLayoutUpdate; // 0x10
	private bool m_PerformingGraphicUpdate; // 0x11
	private readonly IndexedSet<ICanvasElement> m_LayoutRebuildQueue; // 0x18
	private readonly IndexedSet<ICanvasElement> m_GraphicRebuildQueue; // 0x20
	private static readonly Comparison<ICanvasElement> s_SortLayoutFunction; // 0x8

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

