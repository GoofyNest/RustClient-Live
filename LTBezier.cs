public class LTBezier // TypeDefIndex: 5582
{	// Fields
	public float length; // 0x10
	private Vector3 a; // 0x14
	private Vector3 aa; // 0x20
	private Vector3 bb; // 0x2C
	private Vector3 cc; // 0x38
	private float len; // 0x44
	private float[] arcLengths; // 0x48

	// Methods

	// RVA: 0x1988320 Offset: 0x1987720 VA: 0x181988320
	public void .ctor(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float precision) { }

	// RVA: 0x1988930 Offset: 0x1987D30 VA: 0x181988930
	private float map(float u) { }

	// RVA: 0x1988790 Offset: 0x1987B90 VA: 0x181988790
	private Vector3 bezierPoint(float t) { }

	// RVA: 0x1988A80 Offset: 0x1987E80 VA: 0x181988A80
	public Vector3 point(float t) { }

}

