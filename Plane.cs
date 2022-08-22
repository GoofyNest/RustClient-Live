public struct Plane // TypeDefIndex: 3374
{	internal const int size = 16;
	private Vector3 m_Normal; // 0x0
	private float m_Distance; // 0xC

	public Vector3 normal { get; set; }
	public float distance { get; set; }


	public Vector3 get_normal() { }

	public void set_normal(Vector3 value) { }

	public float get_distance() { }

	public void set_distance(float value) { }

	public void .ctor(Vector3 inNormal, Vector3 inPoint) { }

	public void SetNormalAndPosition(Vector3 inNormal, Vector3 inPoint) { }

	public Vector3 ClosestPointOnPlane(Vector3 point) { }

	public bool GetSide(Vector3 point) { }

	public bool Raycast(Ray ray, out float enter) { }

	public override string ToString() { }

}

