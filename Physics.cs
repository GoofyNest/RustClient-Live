public class Physics // TypeDefIndex: 3934
{	// Properties
	public static Vector3 gravity { get; }
	public static bool queriesHitBackfaces { get; set; }
	[NativePropertyAttribute] // RVA: 0x9A840 Offset: 0x99C40 VA: 0x18009A840
	public static PhysicsScene defaultPhysicsScene { get; }
	public static bool autoSyncTransforms { get; set; }

	// Methods

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x2298650 Offset: 0x2297A50 VA: 0x182298650
	public static Vector3 get_gravity() { }

	// RVA: 0x2298690 Offset: 0x2297A90 VA: 0x182298690
	public static bool get_queriesHitBackfaces() { }

	// RVA: 0x2298700 Offset: 0x2297B00 VA: 0x182298700
	public static void set_queriesHitBackfaces(bool value) { }

	// RVA: 0x22985D0 Offset: 0x22979D0 VA: 0x1822985D0
	public static PhysicsScene get_defaultPhysicsScene() { }

	// RVA: 0x2294E80 Offset: 0x2294280 VA: 0x182294E80
	public static void IgnoreCollision(Collider collider1, Collider collider2, bool ignore) { }

	// RVA: 0x2296DF0 Offset: 0x22961F0 VA: 0x182296DF0
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2297360 Offset: 0x2296760 VA: 0x182297360
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2296B50 Offset: 0x2295F50 VA: 0x182296B50
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22970D0 Offset: 0x22964D0 VA: 0x1822970D0
	public static bool Raycast(Vector3 origin, Vector3 direction) { }

	// RVA: 0x2296D10 Offset: 0x2296110 VA: 0x182296D10
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[ExcludeFromDocsAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	// RVA: 0x2297820 Offset: 0x2296C20 VA: 0x182297820
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2297290 Offset: 0x2296690 VA: 0x182297290
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2296A80 Offset: 0x2295E80 VA: 0x182296A80
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo) { }

	// RVA: 0x2297720 Offset: 0x2296B20 VA: 0x182297720
	public static bool Raycast(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2296EC0 Offset: 0x22962C0 VA: 0x182296EC0
	public static bool Raycast(Ray ray, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2296C20 Offset: 0x2296020 VA: 0x182296C20
	public static bool Raycast(Ray ray, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2297630 Offset: 0x2296A30 VA: 0x182297630
	public static bool Raycast(Ray ray) { }

	// RVA: 0x2296FC0 Offset: 0x22963C0 VA: 0x182296FC0
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2297180 Offset: 0x2296580 VA: 0x182297180
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2297530 Offset: 0x2296930 VA: 0x182297530
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2297430 Offset: 0x2296830 VA: 0x182297430
	public static bool Raycast(Ray ray, out RaycastHit hitInfo) { }

	// RVA: 0x2294FC0 Offset: 0x22943C0 VA: 0x182294FC0
	public static bool Linecast(Vector3 start, Vector3 end, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x22952A0 Offset: 0x22946A0 VA: 0x1822952A0
	public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2295130 Offset: 0x2294530 VA: 0x182295130
	public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, int layerMask) { }

	// RVA: 0x22946C0 Offset: 0x2293AC0 VA: 0x1822946C0
	public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22945B0 Offset: 0x22939B0 VA: 0x1822945B0
	public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	// RVA: 0x2298060 Offset: 0x2297460 VA: 0x182298060
	public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2298150 Offset: 0x2297550 VA: 0x182298150
	public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	// RVA: 0x22983B0 Offset: 0x22977B0 VA: 0x1822983B0
	public static bool SphereCast(Ray ray, float radius, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2297F00 Offset: 0x2297300 VA: 0x182297F00
	public static bool SphereCast(Ray ray, float radius, float maxDistance, int layerMask) { }

	// RVA: 0x2298280 Offset: 0x2297680 VA: 0x182298280
	public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22984F0 Offset: 0x22978F0 VA: 0x1822984F0
	public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2298240 Offset: 0x2297640 VA: 0x182298240
	public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance) { }

	// RVA: 0x2294100 Offset: 0x2293500 VA: 0x182294100
	public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22942B0 Offset: 0x22936B0 VA: 0x1822942B0
	public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance, int layerMask) { }

	[NativeNameAttribute] // RVA: 0x95C30 Offset: 0x95030 VA: 0x180095C30
	[StaticAccessorAttribute] // RVA: 0x95C30 Offset: 0x95030 VA: 0x180095C30
	// RVA: 0x2294F50 Offset: 0x2294350 VA: 0x182294F50
	private static RaycastHit[] Internal_RaycastAll(PhysicsScene physicsScene, Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2295B30 Offset: 0x2294F30 VA: 0x182295B30
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2295AE0 Offset: 0x2294EE0 VA: 0x182295AE0
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2295D90 Offset: 0x2295190 VA: 0x182295D90
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2295DE0 Offset: 0x22951E0 VA: 0x182295DE0
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction) { }

	// RVA: 0x2295EE0 Offset: 0x22952E0 VA: 0x182295EE0
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[ExcludeFromDocsAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	// RVA: 0x2295E40 Offset: 0x2295240 VA: 0x182295E40
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2295CF0 Offset: 0x22950F0 VA: 0x182295CF0
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2295A50 Offset: 0x2294E50 VA: 0x182295A50
	public static RaycastHit[] RaycastAll(Ray ray) { }

	// RVA: 0x2296250 Offset: 0x2295650 VA: 0x182296250
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[ExcludeFromDocsAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	// RVA: 0x22967D0 Offset: 0x2295BD0 VA: 0x1822967D0
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2295F90 Offset: 0x2295390 VA: 0x182295F90
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2296510 Offset: 0x2295910 VA: 0x182296510
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results) { }

	// RVA: 0x2296100 Offset: 0x2295500 VA: 0x182296100
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2296680 Offset: 0x2295A80 VA: 0x182296680
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22963C0 Offset: 0x22957C0 VA: 0x1822963C0
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2296940 Offset: 0x2295D40 VA: 0x182296940
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results) { }

	[NativeNameAttribute] // RVA: 0x97180 Offset: 0x96580 VA: 0x180097180
	[StaticAccessorAttribute] // RVA: 0x97180 Offset: 0x96580 VA: 0x180097180
	// RVA: 0x22959D0 Offset: 0x2294DD0 VA: 0x1822959D0
	private static RaycastHit[] Query_SphereCastAll(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2297AD0 Offset: 0x2296ED0 VA: 0x182297AD0
	public static RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2297900 Offset: 0x2296D00 VA: 0x182297900
	public static RaycastHit[] SphereCastAll(Ray ray, float radius, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2298530 Offset: 0x2297930 VA: 0x182298530
	public static void SyncTransforms() { }

	// RVA: 0x2298560 Offset: 0x2297960 VA: 0x182298560
	public static bool get_autoSyncTransforms() { }

	// RVA: 0x22986C0 Offset: 0x2297AC0 VA: 0x1822986C0
	public static void set_autoSyncTransforms(bool value) { }

	// RVA: 0x22958A0 Offset: 0x2294CA0 VA: 0x1822958A0
	public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[StaticAccessorAttribute] // RVA: 0x97CD0 Offset: 0x970D0 VA: 0x180097CD0
	[NativeNameAttribute] // RVA: 0x97CD0 Offset: 0x970D0 VA: 0x180097CD0
	// RVA: 0x2294CA0 Offset: 0x22940A0 VA: 0x182294CA0
	private static bool CheckSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2294D10 Offset: 0x2294110 VA: 0x182294D10
	public static bool CheckSphere(Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2294DD0 Offset: 0x22941D0 VA: 0x182294DD0
	public static bool CheckSphere(Vector3 position, float radius, int layerMask) { }

	// RVA: 0x2294460 Offset: 0x2293860 VA: 0x182294460
	public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2297C60 Offset: 0x2297060 VA: 0x182297C60
	public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2297D90 Offset: 0x2297190 VA: 0x182297D90
	public static int SphereCastNonAlloc(Ray ray, float radius, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[NativeNameAttribute] // RVA: 0x98B30 Offset: 0x97F30 VA: 0x180098B30
	[StaticAccessorAttribute] // RVA: 0x98B30 Offset: 0x97F30 VA: 0x180098B30
	// RVA: 0x2294A00 Offset: 0x2293E00 VA: 0x182294A00
	private static bool CheckCapsule_Internal(PhysicsScene physicsScene, Vector3 start, Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2294A70 Offset: 0x2293E70 VA: 0x182294A70
	public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2294B50 Offset: 0x2293F50 VA: 0x182294B50
	public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask) { }

	[NativeNameAttribute] // RVA: 0x991A0 Offset: 0x985A0 VA: 0x1800991A0
	[StaticAccessorAttribute] // RVA: 0x991A0 Offset: 0x985A0 VA: 0x1800991A0
	// RVA: 0x2294840 Offset: 0x2293C40 VA: 0x182294840
	private static bool CheckBox_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x22948B0 Offset: 0x2293CB0 VA: 0x1822948B0
	public static bool CheckBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction) { }

	[StaticAccessorAttribute] // RVA: 0x999D0 Offset: 0x98DD0 VA: 0x1800999D0
	[NativeNameAttribute] // RVA: 0x999D0 Offset: 0x98DD0 VA: 0x1800999D0
	// RVA: 0x2295580 Offset: 0x2294980 VA: 0x182295580
	private static Collider[] OverlapBox_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x22955F0 Offset: 0x22949F0 VA: 0x1822955F0
	public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22956D0 Offset: 0x2294AD0 VA: 0x1822956D0
	public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask) { }

	// RVA: 0x2295420 Offset: 0x2294820 VA: 0x182295420
	public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x22957B0 Offset: 0x2294BB0 VA: 0x1822957B0
	public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2298610 Offset: 0x2297A10 VA: 0x182298610
	private static void get_gravity_Injected(out Vector3 ret) { }

	// RVA: 0x2298590 Offset: 0x2297990 VA: 0x182298590
	private static void get_defaultPhysicsScene_Injected(out PhysicsScene ret) { }

	// RVA: 0x2294EE0 Offset: 0x22942E0 VA: 0x182294EE0
	private static RaycastHit[] Internal_RaycastAll_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2295960 Offset: 0x2294D60 VA: 0x182295960
	private static RaycastHit[] Query_SphereCastAll_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2294C30 Offset: 0x2294030 VA: 0x182294C30
	private static bool CheckSphere_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2294990 Offset: 0x2293D90 VA: 0x182294990
	private static bool CheckCapsule_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 start, ref Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x22947D0 Offset: 0x2293BD0 VA: 0x1822947D0
	private static bool CheckBox_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2295510 Offset: 0x2294910 VA: 0x182295510
	private static Collider[] OverlapBox_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

}

public class Physics : ConsoleSystem // TypeDefIndex: 11948
{	// Fields
	[ClientVar] // RVA: 0xACE30 Offset: 0xAC230 VA: 0x1800ACE30
	public static int ragdollmode; // 0x0
	[ClientVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	[ServerVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	public static bool batchsynctransforms; // 0x4

	// Properties
	[ClientVar] // RVA: 0xAE2F0 Offset: 0xAD6F0 VA: 0x1800AE2F0
	[ServerVar] // RVA: 0xAE2F0 Offset: 0xAD6F0 VA: 0x1800AE2F0
	public static float steps { get; set; }
	[ClientVar] // RVA: 0xAFB70 Offset: 0xAEF70 VA: 0x1800AFB70
	[ServerVar] // RVA: 0xAFB70 Offset: 0xAEF70 VA: 0x1800AFB70
	public static float minsteps { get; set; }
	[ClientVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	[ServerVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	public static bool autosynctransforms { get; set; }

	// Methods

	// RVA: 0x366660 Offset: 0x365A60 VA: 0x180366660
	internal static void ApplyRagdoll(Rigidbody rigidBody) { }

	// RVA: 0x366890 Offset: 0x365C90 VA: 0x180366890
	public static float get_steps() { }

	// RVA: 0x3668F0 Offset: 0x365CF0 VA: 0x1803668F0
	public static void set_steps(float value) { }

	// RVA: 0x366870 Offset: 0x365C70 VA: 0x180366870
	public static float get_minsteps() { }

	// RVA: 0x3668C0 Offset: 0x365CC0 VA: 0x1803668C0
	public static void set_minsteps(float value) { }

	// RVA: 0x366860 Offset: 0x365C60 VA: 0x180366860
	public static bool get_autosynctransforms() { }

	// RVA: 0x3668B0 Offset: 0x365CB0 VA: 0x1803668B0
	public static void set_autosynctransforms(bool value) { }

	// RVA: 0x366800 Offset: 0x365C00 VA: 0x180366800
	public void .ctor() { }

	// RVA: 0x3667B0 Offset: 0x365BB0 VA: 0x1803667B0
	private static void .cctor() { }

}

