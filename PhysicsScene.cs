public struct PhysicsScene : IEquatable<PhysicsScene> // TypeDefIndex: 3933
{	// Fields
	private int m_Handle; // 0x0

	// Methods

	// RVA: 0x239320 Offset: 0x238720 VA: 0x180239320 Slot: 3
	public override string ToString() { }

	// RVA: 0x13A500 Offset: 0x139900 VA: 0x18013A500 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x238DE0 Offset: 0x2381E0 VA: 0x180238DE0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x2175A0 Offset: 0x2169A0 VA: 0x1802175A0 Slot: 4
	public bool Equals(PhysicsScene other) { }

	// RVA: 0x2390B0 Offset: 0x2384B0 VA: 0x1802390B0
	public bool Raycast(Vector3 origin, Vector3 direction, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[NativeNameAttribute] // RVA: 0x90140 Offset: 0x8F540 VA: 0x180090140
	[StaticAccessorAttribute] // RVA: 0x90140 Offset: 0x8F540 VA: 0x180090140
	// RVA: 0x2293180 Offset: 0x2292580 VA: 0x182293180
	private static bool Internal_RaycastTest(PhysicsScene physicsScene, Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x239030 Offset: 0x238430 VA: 0x180239030
	public bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[StaticAccessorAttribute] // RVA: 0x90660 Offset: 0x8FA60 VA: 0x180090660
	[NativeNameAttribute] // RVA: 0x90660 Offset: 0x8FA60 VA: 0x180090660
	// RVA: 0x2293260 Offset: 0x2292660 VA: 0x182293260
	private static bool Internal_Raycast(PhysicsScene physicsScene, Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x239120 Offset: 0x238520 VA: 0x180239120
	public int Raycast(Vector3 origin, Vector3 direction, RaycastHit[] raycastHits, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[NativeNameAttribute] // RVA: 0x90B40 Offset: 0x8FF40 VA: 0x180090B40
	[StaticAccessorAttribute] // RVA: 0x90B40 Offset: 0x8FF40 VA: 0x180090B40
	// RVA: 0x22930A0 Offset: 0x22924A0 VA: 0x1822930A0
	private static int Internal_RaycastNonAlloc(PhysicsScene physicsScene, Ray ray, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	[StaticAccessorAttribute] // RVA: 0x90D90 Offset: 0x90190 VA: 0x180090D90
	[NativeNameAttribute] // RVA: 0x90D90 Offset: 0x90190 VA: 0x180090D90
	// RVA: 0x2293990 Offset: 0x2292D90 VA: 0x182293990
	private static bool Query_CapsuleCast(PhysicsScene physicsScene, Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2292E80 Offset: 0x2292280 VA: 0x182292E80
	private static bool Internal_CapsuleCast(PhysicsScene physicsScene, Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x238D30 Offset: 0x238130 VA: 0x180238D30
	public bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[NativeNameAttribute] // RVA: 0x91150 Offset: 0x90550 VA: 0x180091150
	[StaticAccessorAttribute] // RVA: 0x91150 Offset: 0x90550 VA: 0x180091150
	// RVA: 0x2292DE0 Offset: 0x22921E0 VA: 0x182292DE0
	private static int Internal_CapsuleCastNonAlloc(PhysicsScene physicsScene, Vector3 p0, Vector3 p1, float radius, Vector3 direction, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x238C00 Offset: 0x238000 VA: 0x180238C00
	public int CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[StaticAccessorAttribute] // RVA: 0x913A0 Offset: 0x907A0 VA: 0x1800913A0
	[NativeNameAttribute] // RVA: 0x913A0 Offset: 0x907A0 VA: 0x1800913A0
	// RVA: 0x22936B0 Offset: 0x2292AB0 VA: 0x1822936B0
	private static int OverlapCapsuleNonAlloc_Internal(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x238F10 Offset: 0x238310 VA: 0x180238F10
	public int OverlapCapsule(Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask = -1, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[NativeNameAttribute] // RVA: 0x91730 Offset: 0x90B30 VA: 0x180091730
	[StaticAccessorAttribute] // RVA: 0x91730 Offset: 0x90B30 VA: 0x180091730
	// RVA: 0x2293AA0 Offset: 0x2292EA0 VA: 0x182293AA0
	private static bool Query_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x22933D0 Offset: 0x22927D0 VA: 0x1822933D0
	private static bool Internal_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2391A0 Offset: 0x2385A0 VA: 0x1802391A0
	public bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[NativeNameAttribute] // RVA: 0x92DD0 Offset: 0x921D0 VA: 0x180092DD0
	[StaticAccessorAttribute] // RVA: 0x92DD0 Offset: 0x921D0 VA: 0x180092DD0
	// RVA: 0x2293340 Offset: 0x2292740 VA: 0x182293340
	private static int Internal_SphereCastNonAlloc(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x239220 Offset: 0x238620 VA: 0x180239220
	public int SphereCast(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[StaticAccessorAttribute] // RVA: 0x930B0 Offset: 0x924B0 VA: 0x1800930B0
	[NativeNameAttribute] // RVA: 0x930B0 Offset: 0x924B0 VA: 0x1800930B0
	// RVA: 0x22937A0 Offset: 0x2292BA0 VA: 0x1822937A0
	private static int OverlapSphereNonAlloc_Internal(PhysicsScene physicsScene, Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x238FB0 Offset: 0x2383B0 VA: 0x180238FB0
	public int OverlapSphere(Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[NativeNameAttribute] // RVA: 0x93390 Offset: 0x92790 VA: 0x180093390
	[StaticAccessorAttribute] // RVA: 0x93390 Offset: 0x92790 VA: 0x180093390
	// RVA: 0x2293880 Offset: 0x2292C80 VA: 0x182293880
	private static bool Query_BoxCast(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, ref RaycastHit outHit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2292BB0 Offset: 0x2291FB0 VA: 0x182292BB0
	private static bool Internal_BoxCast(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x238B40 Offset: 0x237F40 VA: 0x180238B40
	public bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[NativeNameAttribute] // RVA: 0x93790 Offset: 0x92B90 VA: 0x180093790
	[StaticAccessorAttribute] // RVA: 0x93790 Offset: 0x92B90 VA: 0x180093790
	// RVA: 0x22935C0 Offset: 0x22929C0 VA: 0x1822935C0
	private static int OverlapBoxNonAlloc_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x238E60 Offset: 0x238260 VA: 0x180238E60
	public int OverlapBox(Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	// RVA: 0x2293110 Offset: 0x2292510 VA: 0x182293110
	private static bool Internal_RaycastTest_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x22931F0 Offset: 0x22925F0 VA: 0x1822931F0
	private static bool Internal_Raycast_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2293030 Offset: 0x2292430 VA: 0x182293030
	private static int Internal_RaycastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Ray ray, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2293920 Offset: 0x2292D20 VA: 0x182293920
	private static bool Query_CapsuleCast_Injected(ref PhysicsScene physicsScene, ref Vector3 point1, ref Vector3 point2, float radius, ref Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2292D70 Offset: 0x2292170 VA: 0x182292D70
	private static int Internal_CapsuleCastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Vector3 p0, ref Vector3 p1, float radius, ref Vector3 direction, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2293640 Offset: 0x2292A40 VA: 0x182293640
	private static int OverlapCapsuleNonAlloc_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 point0, ref Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2293A30 Offset: 0x2292E30 VA: 0x182293A30
	private static bool Query_SphereCast_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x22932D0 Offset: 0x22926D0 VA: 0x1822932D0
	private static int Internal_SphereCastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2293730 Offset: 0x2292B30 VA: 0x182293730
	private static int OverlapSphereNonAlloc_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2293810 Offset: 0x2292C10 VA: 0x182293810
	private static bool Query_BoxCast_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Vector3 direction, ref Quaternion orientation, float maxDistance, ref RaycastHit outHit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2293550 Offset: 0x2292950 VA: 0x182293550
	private static int OverlapBoxNonAlloc_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, Collider[] results, ref Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

}

