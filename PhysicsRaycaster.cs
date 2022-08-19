public class PhysicsRaycaster : BaseRaycaster // TypeDefIndex: 5093
{	// Fields
	protected const int kNoEventMaskSet = -1;
	protected Camera m_EventCamera; // 0x20
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected LayerMask m_EventMask; // 0x28
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected int m_MaxRayIntersections; // 0x2C
	protected int m_LastMaxRayIntersections; // 0x30
	private RaycastHit[] m_Hits; // 0x38

	// Properties
	public override Camera eventCamera { get; }
	public virtual int depth { get; }
	public int finalEventMask { get; }
	public LayerMask eventMask { get; set; }
	public int maxRayIntersections { get; set; }

	// Methods

	// RVA: 0x10C1B70 Offset: 0x10C0F70 VA: 0x1810C1B70
	protected void .ctor() { }

	// RVA: 0x10C2540 Offset: 0x10C1940 VA: 0x1810C2540 Slot: 18
	public override Camera get_eventCamera() { }

	// RVA: 0x10C2480 Offset: 0x10C1880 VA: 0x1810C2480 Slot: 22
	public virtual int get_depth() { }

	// RVA: 0x10C25E0 Offset: 0x10C19E0 VA: 0x1810C25E0
	public int get_finalEventMask() { }

	// RVA: 0x4BB390 Offset: 0x4BA790 VA: 0x1804BB390
	public LayerMask get_eventMask() { }

	// RVA: 0x7E8DF0 Offset: 0x7E81F0 VA: 0x1807E8DF0
	public void set_eventMask(LayerMask value) { }

	// RVA: 0x5F7BF0 Offset: 0x5F6FF0 VA: 0x1805F7BF0
	public int get_maxRayIntersections() { }

	// RVA: 0x10B2ED0 Offset: 0x10B22D0 VA: 0x1810B2ED0
	public void set_maxRayIntersections(int value) { }

	// RVA: 0x10C1BA0 Offset: 0x10C0FA0 VA: 0x1810C1BA0
	protected bool ComputeRayAndDistance(PointerEventData eventData, ref Ray ray, ref float distanceToClipPlane) { }

	// RVA: 0x10C1F80 Offset: 0x10C1380 VA: 0x1810C1F80 Slot: 17
	public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

}

private class PhysicsRaycaster.RaycastHitComparer : IComparer<RaycastHit> // TypeDefIndex: 5094
{	// Fields
	public static PhysicsRaycaster.RaycastHitComparer instance; // 0x2B0AAA0

	// Methods

	// RVA: 0x700FE0 Offset: 0x7003E0 VA: 0x180700FE0 Slot: 4
	public int Compare(RaycastHit x, RaycastHit y) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x10C4890 Offset: 0x10C3C90 VA: 0x1810C4890
	private static void .cctor() { }

}

