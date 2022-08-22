public class PhysicsRaycaster : BaseRaycaster // TypeDefIndex: 5093
{	protected const int kNoEventMaskSet = -1;
	protected Camera m_EventCamera; // 0x20
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected LayerMask m_EventMask; // 0x28
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected int m_MaxRayIntersections; // 0x2C
	protected int m_LastMaxRayIntersections; // 0x30
	private RaycastHit[] m_Hits; // 0x38

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

private class PhysicsRaycaster.RaycastHitComparer : IComparer<RaycastHit> // TypeDefIndex: 5094
{	public static PhysicsRaycaster.RaycastHitComparer instance; // 0x2B0AAA0


	public int Compare(RaycastHit x, RaycastHit y) { }

	public void .ctor() { }

	private static void .cctor() { }

}

