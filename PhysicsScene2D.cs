public struct PhysicsScene2D : IEquatable<PhysicsScene2D> // TypeDefIndex: 4079
{
// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0xEE800 Offset: 0xEDC00 VA: 0x1800EE800
public struct PhysicsScene2D : IEquatable<PhysicsScene2D> // TypeDefIndex: 4079
	// Fields
	private int m_Handle; // 0x0

	// Methods

	// RVA: 0x240290 Offset: 0x23F690 VA: 0x180240290 Slot: 3
	public override string ToString() { }

	// RVA: 0x13A500 Offset: 0x139900 VA: 0x18013A500 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x23FFD0 Offset: 0x23F3D0 VA: 0x18023FFD0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x2175A0 Offset: 0x2169A0 VA: 0x1802175A0 Slot: 4
	public bool Equals(PhysicsScene2D other) { }

	// RVA: 0x2400A0 Offset: 0x23F4A0 VA: 0x1802400A0
	public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask = -5) { }

	// RVA: 0x240220 Offset: 0x23F620 VA: 0x180240220
	public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter) { }

	[NativeMethodAttribute] // RVA: 0xEEAA0 Offset: 0xEDEA0 VA: 0x1800EEAA0
	[StaticAccessorAttribute] // RVA: 0xEEAA0 Offset: 0xEDEA0 VA: 0x1800EEAA0
	// RVA: 0x230BC60 Offset: 0x230B060 VA: 0x18230BC60
	private static RaycastHit2D Raycast_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter) { }

	// RVA: 0x240180 Offset: 0x23F580 VA: 0x180240180
	public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	[NativeMethodAttribute] // RVA: 0xEEDA0 Offset: 0xEE1A0 VA: 0x1800EEDA0
	[StaticAccessorAttribute] // RVA: 0xEEDA0 Offset: 0xEE1A0 VA: 0x1800EEDA0
	// RVA: 0x230BA80 Offset: 0x230AE80 VA: 0x18230BA80
	private static int RaycastArray_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0x2400E0 Offset: 0x23F4E0 VA: 0x1802400E0
	public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results) { }

	[StaticAccessorAttribute] // RVA: 0xEF100 Offset: 0xEE500 VA: 0x1800EF100
	[NativeMethodAttribute] // RVA: 0xEF100 Offset: 0xEE500 VA: 0x1800EF100
	// RVA: 0x230BB70 Offset: 0x230AF70 VA: 0x18230BB70
	private static int RaycastList_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results) { }

	// RVA: 0x240050 Offset: 0x23F450 VA: 0x180240050
	public int GetRayIntersection(Ray ray, float distance, RaycastHit2D[] results, int layerMask = -5) { }

	[NativeMethodAttribute] // RVA: 0xEF740 Offset: 0xEEB40 VA: 0x1800EF740
	[StaticAccessorAttribute] // RVA: 0xEF740 Offset: 0xEEB40 VA: 0x1800EF740
	// RVA: 0x230B8C0 Offset: 0x230ACC0 VA: 0x18230B8C0
	private static int GetRayIntersectionArray_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask, RaycastHit2D[] results) { }

	// RVA: 0x230BBF0 Offset: 0x230AFF0 VA: 0x18230BBF0
	private static void Raycast_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, out RaycastHit2D ret) { }

	// RVA: 0x230BA10 Offset: 0x230AE10 VA: 0x18230BA10
	private static int RaycastArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0x230BB00 Offset: 0x230AF00 VA: 0x18230BB00
	private static int RaycastList_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, List<RaycastHit2D> results) { }

	// RVA: 0x230B850 Offset: 0x230AC50 VA: 0x18230B850
	private static int GetRayIntersectionArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask, RaycastHit2D[] results) { }

}

