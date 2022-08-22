public class LTBezierPath // TypeDefIndex: 5583
{	public Vector3[] pts; // 0x10
	public float length; // 0x18
	public bool orientToPath; // 0x1C
	public bool orientToPath2d; // 0x1D
	private LTBezier[] beziers; // 0x20
	private float[] lengthRatio; // 0x28
	private int currentBezier; // 0x30
	private int previousBezier; // 0x34

	public float distance { get; }


	public void .ctor() { }

	public void .ctor(Vector3[] pts_) { }

	public void setPoints(Vector3[] pts_) { }

	public float get_distance() { }

	public Vector3 point(float ratio) { }

	public void place2d(Transform transform, float ratio) { }

	public void placeLocal2d(Transform transform, float ratio) { }

	public void place(Transform transform, float ratio) { }

	public void place(Transform transform, float ratio, Vector3 worldUp) { }

	public void placeLocal(Transform transform, float ratio) { }

	public void placeLocal(Transform transform, float ratio, Vector3 worldUp) { }

	public void gizmoDraw(float t = -1) { }

}

