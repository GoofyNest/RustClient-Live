public class GraphicRaycaster : BaseRaycaster // TypeDefIndex: 4937
{
	protected const int kNoEventMaskSet = -1;
	[FormerlySerializedAsAttribute] 
	[SerializeField] 
	private bool m_IgnoreReversedGraphics; 
	[FormerlySerializedAsAttribute] 
	[SerializeField] 
	private GraphicRaycaster.BlockingObjects m_BlockingObjects; 
	[SerializeField] 
	protected LayerMask m_BlockingMask; 
	private Canvas m_Canvas; 
	private List<Graphic> m_RaycastResults; 
	private static readonly List<Graphic> s_SortedGraphics; 

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

public enum GraphicRaycaster.BlockingObjects // TypeDefIndex: 4938
{
	public int value__; 
	public const GraphicRaycaster.BlockingObjects None = 0;
	public const GraphicRaycaster.BlockingObjects TwoD = 1;
	public const GraphicRaycaster.BlockingObjects ThreeD = 2;
	public const GraphicRaycaster.BlockingObjects All = 3;

}

private sealed class GraphicRaycaster.<>c // TypeDefIndex: 4939
{
	public static readonly GraphicRaycaster.<>c <>9; 
	public static Comparison<Graphic> <>9__24_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal int <Raycast>

}

