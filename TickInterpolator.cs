public class TickInterpolator // TypeDefIndex: 13193
{
	private List<TickInterpolator.Segment> points; 
	private int index; 
	public float Length; 
	public Vector3 CurrentPoint; 
	public Vector3 StartPoint; 
	public Vector3 EndPoint; 


	public void Reset() { }

	public void Reset(Vector3 point) { }

	public void AddPoint(Vector3 point) { }

	public bool MoveNext(float distance) { }

	public bool HasNext() { }

	public void TransformEntries(Matrix4x4 matrix) { }

	public void .ctor() { }

}

private struct TickInterpolator.Segment // TypeDefIndex: 13194
{
	public Vector3 point; 
	public float length; 


	public void .ctor(Vector3 a, Vector3 b) { }

}

