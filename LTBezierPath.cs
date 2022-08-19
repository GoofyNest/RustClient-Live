public class LTBezierPath // TypeDefIndex: 5583
{	// Fields
	public Vector3[] pts; // 0x10
	public float length; // 0x18
	public bool orientToPath; // 0x1C
	public bool orientToPath2d; // 0x1D
	private LTBezier[] beziers; // 0x20
	private float[] lengthRatio; // 0x28
	private int currentBezier; // 0x30
	private int previousBezier; // 0x34

	// Properties
	public float distance { get; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1987320 Offset: 0x1986720 VA: 0x181987320
	public void .ctor(Vector3[] pts_) { }

	// RVA: 0x1987E60 Offset: 0x1987260 VA: 0x181987E60
	public void setPoints(Vector3[] pts_) { }

	// RVA: 0x772410 Offset: 0x771810 VA: 0x180772410
	public float get_distance() { }

	// RVA: 0x1987D50 Offset: 0x1987150 VA: 0x181987D50
	public Vector3 point(float ratio) { }

	// RVA: 0x1987460 Offset: 0x1986860 VA: 0x181987460
	public void place2d(Transform transform, float ratio) { }

	// RVA: 0x1987630 Offset: 0x1986A30 VA: 0x181987630
	public void placeLocal2d(Transform transform, float ratio) { }

	// RVA: 0x1987B40 Offset: 0x1986F40 VA: 0x181987B40
	public void place(Transform transform, float ratio) { }

	// RVA: 0x1987C70 Offset: 0x1987070 VA: 0x181987C70
	public void place(Transform transform, float ratio, Vector3 worldUp) { }

	// RVA: 0x1987980 Offset: 0x1986D80 VA: 0x181987980
	public void placeLocal(Transform transform, float ratio) { }

	// RVA: 0x1987800 Offset: 0x1986C00 VA: 0x181987800
	public void placeLocal(Transform transform, float ratio, Vector3 worldUp) { }

	// RVA: 0x1987350 Offset: 0x1986750 VA: 0x181987350
	public void gizmoDraw(float t = -1) { }

}

