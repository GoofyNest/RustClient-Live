public struct RaycastResult // TypeDefIndex: 5095
{
	private GameObject m_GameObject; 
	public BaseRaycaster module; 
	public float distance; 
	public float index; 
	public int depth; 
	public int sortingLayer; 
	public int sortingOrder; 
	public Vector3 worldPosition; 
	public Vector3 worldNormal; 
	public Vector2 screenPosition; 

	public GameObject gameObject { get; set; }
	public bool isValid { get; }


	public GameObject get_gameObject() { }

	public void set_gameObject(GameObject value) { }

	public bool get_isValid() { }

	public void Clear() { }

	public override string ToString() { }

}

