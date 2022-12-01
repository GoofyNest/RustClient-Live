public class PhysicsRaycaster : BaseRaycaster // TypeDefIndex: 5099
{
	protected const int kNoEventMaskSet = -1;
	protected Camera m_EventCamera;
	[SerializeField]
	protected LayerMask m_EventMask;
	[SerializeField]
	protected int m_MaxRayIntersections;
	protected int m_LastMaxRayIntersections;
	private RaycastHit[] m_Hits;

	public override Camera eventCamera { get; }
	public virtual int depth { get; }
	public int finalEventMask { get; }
	public LayerMask eventMask { get; set; }
	public int maxRayIntersections { get; set; }


	protected void .ctor() { }

	public override Camera get_eventCamera() { }

	public virtual int get_depth() { }

	public int get_finalEventMask() { }

	public LayerMask get_eventMask() { }

	public void set_eventMask(LayerMask value) { }

	public int get_maxRayIntersections() { }

	public void set_maxRayIntersections(int value) { }

	protected bool ComputeRayAndDistance(PointerEventData eventData, ref Ray ray, ref float distanceToClipPlane) { }

	public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

}

private class PhysicsRaycaster.RaycastHitComparer : IComparer<RaycastHit> // TypeDefIndex: 5100
{
	public static PhysicsRaycaster.RaycastHitComparer instance;


	public int Compare(RaycastHit x, RaycastHit y) { }

	public void .ctor() { }

	private static void .cctor() { }

}

