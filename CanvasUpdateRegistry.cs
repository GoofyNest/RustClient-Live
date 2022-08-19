public class CanvasUpdateRegistry // TypeDefIndex: 4910
{	// Fields
	private static CanvasUpdateRegistry s_Instance; // 0x0
	private bool m_PerformingLayoutUpdate; // 0x10
	private bool m_PerformingGraphicUpdate; // 0x11
	private readonly IndexedSet<ICanvasElement> m_LayoutRebuildQueue; // 0x18
	private readonly IndexedSet<ICanvasElement> m_GraphicRebuildQueue; // 0x20
	private static readonly Comparison<ICanvasElement> s_SortLayoutFunction; // 0x8

	// Properties
	public static CanvasUpdateRegistry instance { get; }

	// Methods

	// RVA: 0x10B4200 Offset: 0x10B3600 VA: 0x1810B4200
	protected void .ctor() { }

	// RVA: 0x10B42D0 Offset: 0x10B36D0 VA: 0x1810B42D0
	public static CanvasUpdateRegistry get_instance() { }

	// RVA: 0x10B3460 Offset: 0x10B2860 VA: 0x1810B3460
	private bool ObjectValidForUpdate(ICanvasElement element) { }

	// RVA: 0x10B2EE0 Offset: 0x10B22E0 VA: 0x1810B2EE0
	private void CleanInvalidItems() { }

	// RVA: 0x10B3630 Offset: 0x10B2A30 VA: 0x1810B3630
	private void PerformUpdate() { }

	// RVA: 0x10B3560 Offset: 0x10B2960 VA: 0x1810B3560
	private static int ParentCount(Transform child) { }

	// RVA: 0x10B3DF0 Offset: 0x10B31F0 VA: 0x1810B3DF0
	private static int SortLayoutList(ICanvasElement x, ICanvasElement y) { }

	// RVA: 0x10B3D80 Offset: 0x10B3180 VA: 0x1810B3D80
	public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x10B3F10 Offset: 0x10B3310 VA: 0x1810B3F10
	public static bool TryRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x10B3140 Offset: 0x10B2540 VA: 0x1810B3140
	private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x10B3D10 Offset: 0x10B3110 VA: 0x1810B3D10
	public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x10B3EA0 Offset: 0x10B32A0 VA: 0x1810B3EA0
	public static bool TryRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x10B3090 Offset: 0x10B2490 VA: 0x1810B3090
	private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x10B3F80 Offset: 0x10B3380 VA: 0x1810B3F80
	public static void UnRegisterCanvasElementForRebuild(ICanvasElement element) { }

	// RVA: 0x10B32B0 Offset: 0x10B26B0 VA: 0x1810B32B0
	private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x10B31C0 Offset: 0x10B25C0 VA: 0x1810B31C0
	private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x10B3400 Offset: 0x10B2800 VA: 0x1810B3400
	public static bool IsRebuildingLayout() { }

	// RVA: 0x10B33A0 Offset: 0x10B27A0 VA: 0x1810B33A0
	public static bool IsRebuildingGraphics() { }

	// RVA: 0x10B4190 Offset: 0x10B3590 VA: 0x1810B4190
	private static void .cctor() { }

}

