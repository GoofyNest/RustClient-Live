public struct Triangle // TypeDefIndex: 6594
{	// Fields
	public Vector3 point0; // 0x0
	public Vector3 point1; // 0xC
	public Vector3 point2; // 0x18

	// Properties
	public Vector3 Normal { get; }
	public Vector3 Center { get; }

	// Methods

	// RVA: 0x22DD40 Offset: 0x22D140 VA: 0x18022DD40
	public void .ctor(Vector3 point0, Vector3 point1, Vector3 point2) { }

	// RVA: 0x22DCF0 Offset: 0x22D0F0 VA: 0x18022DCF0
	public bool Trace(Ray ray, float radius, out RaycastHit hit, float maxDistance = ∞) { }

	// RVA: 0x22DB20 Offset: 0x22CF20 VA: 0x18022DB20
	private bool LineTest(Vector3 a, Vector3 b, Ray ray, float radius, out RaycastHit hit, float maxDistance) { }

	// RVA: 0x22DEC0 Offset: 0x22D2C0 VA: 0x18022DEC0
	public Vector3 get_Normal() { }

	// RVA: 0x22DD80 Offset: 0x22D180 VA: 0x18022DD80
	public Vector3 get_Center() { }

	// RVA: 0x22D9F0 Offset: 0x22CDF0 VA: 0x18022D9F0
	public Vector3 ClosestPoint(Vector3 pos) { }

	// RVA: 0x22DA30 Offset: 0x22CE30 VA: 0x18022DA30
	public float Distance(Vector3 pos) { }

	// RVA: 0x22DC00 Offset: 0x22D000 VA: 0x18022DC00
	public float SqrDistance(Vector3 pos) { }

}

