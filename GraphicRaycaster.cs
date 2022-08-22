public class GraphicRaycaster : BaseRaycaster // TypeDefIndex: 4931
{	protected const int kNoEventMaskSet = -1;
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

	public override int sortOrderPriority { get; }
	public override int renderOrderPriority { get; }
	public bool ignoreReversedGraphics { get; set; }
	public GraphicRaycaster.BlockingObjects blockingObjects { get; set; }
	private Canvas canvas { get; }
	public override Camera eventCamera { get; }


	public override int get_sortOrderPriority() { }

	public override int get_renderOrderPriority() { }

	public bool get_ignoreReversedGraphics() { }

	public void set_ignoreReversedGraphics(bool value) { }

	public GraphicRaycaster.BlockingObjects get_blockingObjects() { }

	public void set_blockingObjects(GraphicRaycaster.BlockingObjects value) { }

	protected void .ctor() { }

	private Canvas get_canvas() { }

	public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

	public override Camera get_eventCamera() { }

	private static void Raycast(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, IList<Graphic> foundGraphics, List<Graphic> results) { }

	private static void .cctor() { }

}

public enum GraphicRaycaster.BlockingObjects // TypeDefIndex: 4932
{	public int value__; // 0x0
	public const GraphicRaycaster.BlockingObjects None = 0;
	public const GraphicRaycaster.BlockingObjects TwoD = 1;
	public const GraphicRaycaster.BlockingObjects ThreeD = 2;
	public const GraphicRaycaster.BlockingObjects All = 3;

}

private sealed class GraphicRaycaster.<>c // TypeDefIndex: 4933
{	public static readonly GraphicRaycaster.<>c <>9; // 0x0
	public static Comparison<Graphic> <>9__24_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal int <Raycast>b__24_0(Graphic g1, Graphic g2) { }

}

