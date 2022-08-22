public class TickInterpolator // TypeDefIndex: 11401
{	private List<TickInterpolator.Segment> points; // 0x10
	private int index; // 0x18
	public float Length; // 0x1C
	public Vector3 CurrentPoint; // 0x20
	public Vector3 StartPoint; // 0x2C
	public Vector3 EndPoint; // 0x38


	public void Reset() { }

	public void Reset(Vector3 point) { }

	public void AddPoint(Vector3 point) { }

	public bool MoveNext(float distance) { }

	public bool HasNext() { }

	public void TransformEntries(Matrix4x4 matrix) { }

	public void .ctor() { }

}

private struct TickInterpolator.Segment // TypeDefIndex: 11402
{	public Vector3 point; // 0x0
	public float length; // 0xC


	public void .ctor(Vector3 a, Vector3 b) { }

}

