public class TickInterpolator // TypeDefIndex: 11401
{	// Fields
	private List<TickInterpolator.Segment> points; // 0x10
	private int index; // 0x18
	public float Length; // 0x1C
	public Vector3 CurrentPoint; // 0x20
	public Vector3 StartPoint; // 0x2C
	public Vector3 EndPoint; // 0x38

	// Methods

	// RVA: 0x84E490 Offset: 0x84D890 VA: 0x18084E490
	public void Reset() { }

	// RVA: 0x84E4B0 Offset: 0x84D8B0 VA: 0x18084E4B0
	public void Reset(Vector3 point) { }

	// RVA: 0x84E240 Offset: 0x84D640 VA: 0x18084E240
	public void AddPoint(Vector3 point) { }

	// RVA: 0x84E3B0 Offset: 0x84D7B0 VA: 0x18084E3B0
	public bool MoveNext(float distance) { }

	// RVA: 0x84E360 Offset: 0x84D760 VA: 0x18084E360
	public bool HasNext() { }

	// RVA: 0x84E530 Offset: 0x84D930 VA: 0x18084E530
	public void TransformEntries(Matrix4x4 matrix) { }

	// RVA: 0x84E700 Offset: 0x84DB00 VA: 0x18084E700
	public void .ctor() { }

}

private struct TickInterpolator.Segment // TypeDefIndex: 11402
{	// Fields
	public Vector3 point; // 0x0
	public float length; // 0xC

	// Methods

	// RVA: 0xF9190 Offset: 0xF8590 VA: 0x1800F9190
	public void .ctor(Vector3 a, Vector3 b) { }

}

