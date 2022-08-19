public class GraphicRaycaster : BaseRaycaster // TypeDefIndex: 4931
{	// Fields
	protected const int kNoEventMaskSet = -1;
	[FormerlySerializedAsAttribute] // RVA: 0xEBF90 Offset: 0xEB390 VA: 0x1800EBF90
	[SerializeField] // RVA: 0xEBF90 Offset: 0xEB390 VA: 0x1800EBF90
	private bool m_IgnoreReversedGraphics; // 0x20
	[FormerlySerializedAsAttribute] // RVA: 0xEC0C0 Offset: 0xEB4C0 VA: 0x1800EC0C0
	[SerializeField] // RVA: 0xEC0C0 Offset: 0xEB4C0 VA: 0x1800EC0C0
	private GraphicRaycaster.BlockingObjects m_BlockingObjects; // 0x24
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected LayerMask m_BlockingMask; // 0x28
	private Canvas m_Canvas; // 0x30
	private List<Graphic> m_RaycastResults; // 0x38
	private static readonly List<Graphic> s_SortedGraphics; // 0x0

	// Properties
	public override int sortOrderPriority { get; }
	public override int renderOrderPriority { get; }
	public bool ignoreReversedGraphics { get; set; }
	public GraphicRaycaster.BlockingObjects blockingObjects { get; set; }
	private Canvas canvas { get; }
	public override Camera eventCamera { get; }

	// Methods

	// RVA: 0x15E75F0 Offset: 0x15E69F0 VA: 0x1815E75F0 Slot: 20
	public override int get_sortOrderPriority() { }

	// RVA: 0x15E7590 Offset: 0x15E6990 VA: 0x1815E7590 Slot: 21
	public override int get_renderOrderPriority() { }

	// RVA: 0xB0BB80 Offset: 0xB0AF80 VA: 0x180B0BB80
	public bool get_ignoreReversedGraphics() { }

	// RVA: 0x7D99E0 Offset: 0x7D8DE0 VA: 0x1807D99E0
	public void set_ignoreReversedGraphics(bool value) { }

	// RVA: 0x7E8DA0 Offset: 0x7E81A0 VA: 0x1807E8DA0
	public GraphicRaycaster.BlockingObjects get_blockingObjects() { }

	// RVA: 0x7E8E00 Offset: 0x7E8200 VA: 0x1807E8E00
	public void set_blockingObjects(GraphicRaycaster.BlockingObjects value) { }

	// RVA: 0x15E7310 Offset: 0x15E6710 VA: 0x1815E7310
	protected void .ctor() { }

	// RVA: 0x15E7390 Offset: 0x15E6790 VA: 0x1815E7390
	private Canvas get_canvas() { }

	// RVA: 0x15E5BC0 Offset: 0x15E4FC0 VA: 0x1815E5BC0 Slot: 17
	public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

	// RVA: 0x15E7430 Offset: 0x15E6830 VA: 0x1815E7430 Slot: 18
	public override Camera get_eventCamera() { }

	// RVA: 0x15E6DF0 Offset: 0x15E61F0 VA: 0x1815E6DF0
	private static void Raycast(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, IList<Graphic> foundGraphics, List<Graphic> results) { }

	// RVA: 0x15E72B0 Offset: 0x15E66B0 VA: 0x1815E72B0
	private static void .cctor() { }

}

public enum GraphicRaycaster.BlockingObjects // TypeDefIndex: 4932
{	// Fields
	public int value__; // 0x0
	public const GraphicRaycaster.BlockingObjects None = 0;
	public const GraphicRaycaster.BlockingObjects TwoD = 1;
	public const GraphicRaycaster.BlockingObjects ThreeD = 2;
	public const GraphicRaycaster.BlockingObjects All = 3;

}

private sealed class GraphicRaycaster.<>c // TypeDefIndex: 4933
{	// Fields
	public static readonly GraphicRaycaster.<>c <>9; // 0x0
	public static Comparison<Graphic> <>9__24_0; // 0x8

	// Methods

	// RVA: 0x15FFB00 Offset: 0x15FEF00 VA: 0x1815FFB00
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x15FFA80 Offset: 0x15FEE80 VA: 0x1815FFA80
	internal int <Raycast>b__24_0(Graphic g1, Graphic g2) { }

}

