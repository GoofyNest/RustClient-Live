public struct RaycastResult // TypeDefIndex: 5089
{	// Fields
	private GameObject m_GameObject; // 0x0
	public BaseRaycaster module; // 0x8
	public float distance; // 0x10
	public float index; // 0x14
	public int depth; // 0x18
	public int sortingLayer; // 0x1C
	public int sortingOrder; // 0x20
	public Vector3 worldPosition; // 0x24
	public Vector3 worldNormal; // 0x30
	public Vector2 screenPosition; // 0x3C

	// Properties
	public GameObject gameObject { get; set; }
	public bool isValid { get; }

	// Methods

	// RVA: 0xFC6D0 Offset: 0xFBAD0 VA: 0x1800FC6D0
	public GameObject get_gameObject() { }

	// RVA: 0xF1380 Offset: 0xF0780 VA: 0x1800F1380
	public void set_gameObject(GameObject value) { }

	// RVA: 0x19E640 Offset: 0x19DA40 VA: 0x18019E640
	public bool get_isValid() { }

	// RVA: 0x19E540 Offset: 0x19D940 VA: 0x18019E540
	public void Clear() { }

	// RVA: 0x19E630 Offset: 0x19DA30 VA: 0x18019E630 Slot: 3
	public override string ToString() { }

}

