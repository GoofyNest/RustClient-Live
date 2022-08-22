public struct RaycastResult // TypeDefIndex: 5089
{	private GameObject m_GameObject; // 0x0
	public BaseRaycaster module; // 0x8
	public float distance; // 0x10
	public float index; // 0x14
	public int depth; // 0x18
	public int sortingLayer; // 0x1C
	public int sortingOrder; // 0x20
	public Vector3 worldPosition; // 0x24
	public Vector3 worldNormal; // 0x30
	public Vector2 screenPosition; // 0x3C

	public GameObject gameObject { get; set; }
	public bool isValid { get; }


	public GameObject get_gameObject() { }

	public void set_gameObject(GameObject value) { }

	public bool get_isValid() { }

	public void Clear() { }

	public override string ToString() { }

}

