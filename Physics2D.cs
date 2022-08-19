public class Physics2D // TypeDefIndex: 4080
{	// Fields
	private static List<Rigidbody2D> m_LastDisabledRigidbody2D; // 0x126D0

	// Properties
	public static PhysicsScene2D defaultPhysicsScene { get; }
	[StaticAccessorAttribute] // RVA: 0x6F650 Offset: 0x6EA50 VA: 0x18006F650
	public static bool queriesHitTriggers { get; }

	// Methods

	// RVA: 0xB372A0 Offset: 0xB366A0 VA: 0x180B372A0
	public static PhysicsScene2D get_defaultPhysicsScene() { }

	// RVA: 0x230B820 Offset: 0x230AC20 VA: 0x18230B820
	public static bool get_queriesHitTriggers() { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x230B660 Offset: 0x230AA60 VA: 0x18230B660
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x230AEA0 Offset: 0x230A2A0 VA: 0x18230AEA0
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[RequiredByNativeCodeAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	// RVA: 0x230B4C0 Offset: 0x230A8C0 VA: 0x18230B4C0
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x230B320 Offset: 0x230A720 VA: 0x18230B320
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth) { }

	// RVA: 0x230AF80 Offset: 0x230A380 VA: 0x18230AF80
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x230ADA0 Offset: 0x230A1A0 VA: 0x18230ADA0
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0x230B120 Offset: 0x230A520 VA: 0x18230B120
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, float distance) { }

	// RVA: 0x230B220 Offset: 0x230A620 VA: 0x18230B220
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, float distance = ∞) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x230A900 Offset: 0x2309D00 VA: 0x18230A900
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x230A7C0 Offset: 0x2309BC0 VA: 0x18230A7C0
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x230A680 Offset: 0x2309A80 VA: 0x18230A680
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance, int layerMask) { }

	[StaticAccessorAttribute] // RVA: 0xF08C0 Offset: 0xEFCC0 VA: 0x1800F08C0
	[NativeMethodAttribute] // RVA: 0xF08C0 Offset: 0xEFCC0 VA: 0x1800F08C0
	// RVA: 0x230A5E0 Offset: 0x23099E0 VA: 0x18230A5E0
	private static RaycastHit2D[] GetRayIntersectionAll_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x230AC80 Offset: 0x230A080 VA: 0x18230AC80
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x230AA30 Offset: 0x2309E30 VA: 0x18230AA30
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x230AB50 Offset: 0x2309F50 VA: 0x18230AB50
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance, int layerMask) { }

	// RVA: 0x230B7C0 Offset: 0x230ABC0 VA: 0x18230B7C0
	private static void .cctor() { }

	// RVA: 0x230A570 Offset: 0x2309970 VA: 0x18230A570
	private static RaycastHit2D[] GetRayIntersectionAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask) { }

}

