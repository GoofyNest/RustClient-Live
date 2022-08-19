public static class EZSoftBoneUtility // TypeDefIndex: 7137
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x228A640 Offset: 0x2289A40 VA: 0x18228A640
	internal static Vector3 Abs(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x228B240 Offset: 0x228A640 VA: 0x18228B240
	public static float Max(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x228A6F0 Offset: 0x2289AF0 VA: 0x18228A6F0
	public static bool Contains(LayerMask mask, int layer) { }

	// RVA: 0x228AD60 Offset: 0x228A160 VA: 0x18228AD60
	public static void GetCapsuleParams(CapsuleCollider collider, out Vector3 center0, out Vector3 center1, out float radius) { }

	// RVA: 0x228B0B0 Offset: 0x228A4B0 VA: 0x18228B0B0
	public static void GetCylinderParams(Transform transform, out Vector3 center, out Vector3 direction, out float radius, out float height) { }

	// RVA: 0x228D5C0 Offset: 0x228C9C0 VA: 0x18228D5C0
	public static void PointOutsideSphere(ref Vector3 position, SphereCollider collider, float spacing) { }

	// RVA: 0x228D7B0 Offset: 0x228CBB0 VA: 0x18228D7B0
	private static void PointOutsideSphere(ref Vector3 position, Vector3 spherePosition, float radius) { }

	// RVA: 0x228C2C0 Offset: 0x228B6C0 VA: 0x18228C2C0
	public static void PointInsideSphere(ref Vector3 position, SphereCollider collider, float spacing) { }

	// RVA: 0x228C140 Offset: 0x228B540 VA: 0x18228C140
	private static void PointInsideSphere(ref Vector3 position, Vector3 spherePosition, float radius) { }

	// RVA: 0x228CD00 Offset: 0x228C100 VA: 0x18228CD00
	public static void PointOutsideCapsule(ref Vector3 position, CapsuleCollider collider, float spacing) { }

	// RVA: 0x228CA20 Offset: 0x228BE20 VA: 0x18228CA20
	public static void PointOutsideCapsule(ref Vector3 position, Vector3 center0, Vector3 center1, float radius) { }

	// RVA: 0x228BC60 Offset: 0x228B060 VA: 0x18228BC60
	public static void PointInsideCapsule(ref Vector3 position, CapsuleCollider collider, float spacing) { }

	// RVA: 0x228B980 Offset: 0x228AD80 VA: 0x18228B980
	private static void PointInsideCapsule(ref Vector3 position, Vector3 center0, Vector3 center1, float radius) { }

	// RVA: 0x228D3F0 Offset: 0x228C7F0 VA: 0x18228D3F0
	public static void PointOutsideCylinder(ref Vector3 position, Transform transform, float spacing) { }

	// RVA: 0x228D130 Offset: 0x228C530 VA: 0x18228D130
	private static void PointOutsideCylinder(ref Vector3 position, Vector3 center, Vector3 direction, float radius, float height) { }

	// RVA: 0x228BF70 Offset: 0x228B370 VA: 0x18228BF70
	public static void PointInsideCylinder(ref Vector3 position, Transform transform, float spacing) { }

	// RVA: 0x228BD10 Offset: 0x228B110 VA: 0x18228BD10
	private static void PointInsideCylinder(ref Vector3 position, Vector3 center, Vector3 direction, float radius, float height) { }

	// RVA: 0x228C660 Offset: 0x228BA60 VA: 0x18228C660
	public static void PointOutsideBox(ref Vector3 position, BoxCollider collider, float spacing) { }

	// RVA: 0x228C390 Offset: 0x228B790 VA: 0x18228C390
	public static void PointOutsideBox(ref Vector3 position, Vector3 boxSize) { }

	// RVA: 0x228B480 Offset: 0x228A880 VA: 0x18228B480
	public static void PointInsideBox(ref Vector3 position, BoxCollider collider, float spacing) { }

	// RVA: 0x228B2C0 Offset: 0x228A6C0 VA: 0x18228B2C0
	private static void PointInsideBox(ref Vector3 position, Vector3 boxSize) { }

	// RVA: 0x228CDB0 Offset: 0x228C1B0 VA: 0x18228CDB0
	public static void PointOutsideCollider(ref Vector3 position, Collider collider, float spacing) { }

	// RVA: 0x228A730 Offset: 0x2289B30 VA: 0x18228A730
	public static void DrawGizmosArrow(Vector3 startPoint, Vector3 direction, float halfWidth, Vector3 normal) { }

	// RVA: 0x228ACA0 Offset: 0x228A0A0 VA: 0x18228ACA0
	public static void DrawGizmosPolyLine(Vector3[] vertices) { }

}

