public struct Bounds : IEquatable<Bounds> // TypeDefIndex: 3372
{	// Fields
	private Vector3 m_Center; // 0x0
	[NativeNameAttribute] // RVA: 0x7D770 Offset: 0x7CB70 VA: 0x18007D770
	private Vector3 m_Extents; // 0xC

	// Properties
	public Vector3 center { get; set; }
	public Vector3 size { get; set; }
	public Vector3 extents { get; set; }
	public Vector3 min { get; set; }
	public Vector3 max { get; set; }

	// Methods

	// RVA: 0x212970 Offset: 0x211D70 VA: 0x180212970
	public void .ctor(Vector3 center, Vector3 size) { }

	// RVA: 0x2126A0 Offset: 0x211AA0 VA: 0x1802126A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x212400 Offset: 0x211800 VA: 0x180212400 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x212510 Offset: 0x211910 VA: 0x180212510 Slot: 4
	public bool Equals(Bounds other) { }

	// RVA: 0x212A20 Offset: 0x211E20 VA: 0x180212A20
	public Vector3 get_center() { }

	// RVA: 0x204DC0 Offset: 0x2041C0 VA: 0x180204DC0
	public void set_center(Vector3 value) { }

	// RVA: 0x212AA0 Offset: 0x211EA0 VA: 0x180212AA0
	public Vector3 get_size() { }

	// RVA: 0x212C30 Offset: 0x212030 VA: 0x180212C30
	public void set_size(Vector3 value) { }

	// RVA: 0x212A40 Offset: 0x211E40 VA: 0x180212A40
	public Vector3 get_extents() { }

	// RVA: 0x212B50 Offset: 0x211F50 VA: 0x180212B50
	public void set_extents(Vector3 value) { }

	// RVA: 0x212A80 Offset: 0x211E80 VA: 0x180212A80
	public Vector3 get_min() { }

	// RVA: 0x212BC0 Offset: 0x211FC0 VA: 0x180212BC0
	public void set_min(Vector3 value) { }

	// RVA: 0x212A60 Offset: 0x211E60 VA: 0x180212A60
	public Vector3 get_max() { }

	// RVA: 0x212B60 Offset: 0x211F60 VA: 0x180212B60
	public void set_max(Vector3 value) { }

	// RVA: 0x181B660 Offset: 0x181AA60 VA: 0x18181B660
	public static bool op_Equality(Bounds lhs, Bounds rhs) { }

	// RVA: 0x181B750 Offset: 0x181AB50 VA: 0x18181B750
	public static bool op_Inequality(Bounds lhs, Bounds rhs) { }

	// RVA: 0x212770 Offset: 0x211B70 VA: 0x180212770
	public void SetMinMax(Vector3 min, Vector3 max) { }

	// RVA: 0x2123D0 Offset: 0x2117D0 VA: 0x1802123D0
	public void Encapsulate(Vector3 point) { }

	// RVA: 0x2122B0 Offset: 0x2116B0 VA: 0x1802122B0
	public void Encapsulate(Bounds bounds) { }

	// RVA: 0x2125B0 Offset: 0x2119B0 VA: 0x1802125B0
	public void Expand(float amount) { }

	// RVA: 0x212700 Offset: 0x211B00 VA: 0x180212700
	public bool IntersectRay(Ray ray) { }

	// RVA: 0x212800 Offset: 0x211C00 VA: 0x180212800 Slot: 3
	public override string ToString() { }

	[NativeMethodAttribute] // RVA: 0x7D7A0 Offset: 0x7CBA0 VA: 0x18007D7A0
	// RVA: 0x212260 Offset: 0x211660 VA: 0x180212260
	public bool Contains(Vector3 point) { }

	[FreeFunctionAttribute] // RVA: 0x7D8F0 Offset: 0x7CCF0 VA: 0x18007D8F0
	// RVA: 0x2127B0 Offset: 0x211BB0 VA: 0x1802127B0
	public float SqrDistance(Vector3 point) { }

	[FreeFunctionAttribute] // RVA: 0x7DA00 Offset: 0x7CE00 VA: 0x18007DA00
	// RVA: 0x181B090 Offset: 0x181A490 VA: 0x18181B090
	private static bool IntersectRayAABB(Ray ray, Bounds bounds, out float dist) { }

	[FreeFunctionAttribute] // RVA: 0x7DB40 Offset: 0x7CF40 VA: 0x18007DB40
	// RVA: 0x2121F0 Offset: 0x2115F0 VA: 0x1802121F0
	public Vector3 ClosestPoint(Vector3 point) { }

	// RVA: 0x181AC50 Offset: 0x181A050 VA: 0x18181AC50
	private static bool Contains_Injected(ref Bounds _unity_self, ref Vector3 point) { }

	// RVA: 0x181B280 Offset: 0x181A680 VA: 0x18181B280
	private static float SqrDistance_Injected(ref Bounds _unity_self, ref Vector3 point) { }

	// RVA: 0x181B030 Offset: 0x181A430 VA: 0x18181B030
	private static bool IntersectRayAABB_Injected(ref Ray ray, ref Bounds bounds, out float dist) { }

	// RVA: 0x181AB90 Offset: 0x1819F90 VA: 0x18181AB90
	private static void ClosestPoint_Injected(ref Bounds _unity_self, ref Vector3 point, out Vector3 ret) { }

}

