public static class GamePhysics // TypeDefIndex: 9258
{	// Fields
	public const int BufferLength = 8192;
	private static RaycastHit[] hitBuffer; // 0x0
	private static RaycastHit[] hitBufferB; // 0x8
	private static Collider[] colBuffer; // 0x10

	// Methods

	// RVA: 0x6F7090 Offset: 0x6F6490 VA: 0x1806F7090
	public static bool CheckSphere(Vector3 position, float radius, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 0) { }

	// RVA: 0x6F68A0 Offset: 0x6F5CA0 VA: 0x1806F68A0
	public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 0) { }

	// RVA: 0x6F6F60 Offset: 0x6F6360 VA: 0x1806F6F60
	public static bool CheckOBB(OBB obb, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 0) { }

	// RVA: 0x6F6740 Offset: 0x6F5B40 VA: 0x1806F6740
	public static bool CheckBounds(Bounds bounds, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 0) { }

	// RVA: 0x6F6BB0 Offset: 0x6F5FB0 VA: 0x1806F6BB0
	public static bool CheckInsideNonConvexMesh(Vector3 point, int layerMask = -5) { }

	// RVA: 0x6F6A20 Offset: 0x6F5E20 VA: 0x1806F6A20
	public static bool CheckInsideAnyCollider(Vector3 point, int layerMask = -5) { }

	// RVA: 0x6F84A0 Offset: 0x6F78A0 VA: 0x1806F84A0
	public static void OverlapSphere(Vector3 position, float radius, List<Collider> list, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }

	// RVA: 0x6F64A0 Offset: 0x6F58A0 VA: 0x1806F64A0
	public static void CapsuleSweep(Vector3 position0, Vector3 position1, float radius, Vector3 direction, float distance, List<RaycastHit> list, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }

	// RVA: 0x6F8220 Offset: 0x6F7620 VA: 0x1806F8220
	public static void OverlapCapsule(Vector3 point0, Vector3 point1, float radius, List<Collider> list, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }

	// RVA: 0x6F8350 Offset: 0x6F7750 VA: 0x1806F8350
	public static void OverlapOBB(OBB obb, List<Collider> list, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }

	// RVA: 0x6F8080 Offset: 0x6F7480 VA: 0x1806F8080
	public static void OverlapBounds(Bounds bounds, List<Collider> list, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }

	// RVA: 0x6F6300 Offset: 0x6F5700 VA: 0x1806F6300
	private static void BufferToList(int count, List<Collider> list) { }

	// RVA: -1 Offset: -1
	public static bool CheckSphere<T>(Vector3 pos, float radius, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1257C00 Offset: 0x1257000 VA: 0x181257C00
	|-GamePhysics.CheckSphere<object>
	|-GamePhysics.CheckSphere<TerrainCollisionTrigger>
	|-GamePhysics.CheckSphere<WaterVisibilityTrigger>
	*/

	// RVA: -1 Offset: -1
	public static bool CheckCapsule<T>(Vector3 start, Vector3 end, float radius, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12578F0 Offset: 0x1256CF0 VA: 0x1812578F0
	|-GamePhysics.CheckCapsule<object>
	|-GamePhysics.CheckCapsule<WaterVisibilityTrigger>
	*/

	// RVA: -1 Offset: -1
	public static bool CheckOBB<T>(OBB obb, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1257AE0 Offset: 0x1256EE0 VA: 0x181257AE0
	|-GamePhysics.CheckOBB<object>
	*/

	// RVA: -1 Offset: -1
	public static bool CheckBounds<T>(Bounds bounds, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12577F0 Offset: 0x1256BF0 VA: 0x1812577F0
	|-GamePhysics.CheckBounds<object>
	|-GamePhysics.CheckBounds<WaterVisibilityTrigger>
	*/

	// RVA: -1 Offset: -1
	private static bool CheckComponent<T>(List<Collider> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1257A30 Offset: 0x1256E30 VA: 0x181257A30
	|-GamePhysics.CheckComponent<object>
	*/

	// RVA: -1 Offset: -1
	public static void OverlapSphere<T>(Vector3 position, float radius, List<T> list, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15409D0 Offset: 0x153FDD0 VA: 0x1815409D0
	|-GamePhysics.OverlapSphere<EnvironmentVolume>
	|-GamePhysics.OverlapSphere<object>
	|-GamePhysics.OverlapSphere<TriggerBase>
	*/

	// RVA: -1 Offset: -1
	public static void OverlapCapsule<T>(Vector3 point0, Vector3 point1, float radius, List<T> list, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1540750 Offset: 0x153FB50 VA: 0x181540750
	|-GamePhysics.OverlapCapsule<object>
	|-GamePhysics.OverlapCapsule<TriggerBase>
	*/

	// RVA: -1 Offset: -1
	public static void OverlapOBB<T>(OBB obb, List<T> list, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1540880 Offset: 0x153FC80 VA: 0x181540880
	|-GamePhysics.OverlapOBB<EnvironmentVolume>
	|-GamePhysics.OverlapOBB<object>
	|-GamePhysics.OverlapOBB<TriggerBase>
	*/

	// RVA: -1 Offset: -1
	public static void OverlapBounds<T>(Bounds bounds, List<T> list, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15405A0 Offset: 0x153F9A0 VA: 0x1815405A0
	|-GamePhysics.OverlapBounds<object>
	*/

	// RVA: -1 Offset: -1
	private static void BufferToList<T>(int count, List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1540370 Offset: 0x153F770 VA: 0x181540370
	|-GamePhysics.BufferToList<object>
	*/

	// RVA: 0x6F72D0 Offset: 0x6F66D0 VA: 0x1806F72D0
	private static void HitBufferToList(int count, List<RaycastHit> list) { }

	// RVA: 0x6F8B50 Offset: 0x6F7F50 VA: 0x1806F8B50
	public static bool Trace(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 0, BaseEntity ignoreEntity) { }

	// RVA: 0x6F8A70 Offset: 0x6F7E70 VA: 0x1806F8A70
	public static void TraceAll(Ray ray, float radius, List<RaycastHit> hits, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 0, BaseEntity ignoreEntity) { }

	// RVA: 0x6F8780 Offset: 0x6F7B80 VA: 0x1806F8780
	public static void TraceAllUnordered(Ray ray, float radius, List<RaycastHit> hits, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction triggerInteraction = 0, BaseEntity ignoreEntity) { }

	// RVA: 0x6F7C60 Offset: 0x6F7060 VA: 0x1806F7C60
	public static bool LineOfSightRadius(Vector3 p0, Vector3 p1, int layerMask, float radius, float padding0, float padding1, BaseEntity ignoreEntity) { }

	// RVA: 0x6F7AB0 Offset: 0x6F6EB0 VA: 0x1806F7AB0
	public static bool LineOfSightRadius(Vector3 p0, Vector3 p1, int layerMask, float radius, float padding, BaseEntity ignoreEntity) { }

	// RVA: 0x6F7B90 Offset: 0x6F6F90 VA: 0x1806F7B90
	public static bool LineOfSightRadius(Vector3 p0, Vector3 p1, int layerMask, float radius, BaseEntity ignoreEntity) { }

	// RVA: 0x6F7E50 Offset: 0x6F7250 VA: 0x1806F7E50
	public static bool LineOfSight(Vector3 p0, Vector3 p1, int layerMask, float padding0, float padding1, BaseEntity ignoreEntity) { }

	// RVA: 0x6F7F70 Offset: 0x6F7370 VA: 0x1806F7F70
	public static bool LineOfSight(Vector3 p0, Vector3 p1, int layerMask, float padding, BaseEntity ignoreEntity) { }

	// RVA: 0x6F7D40 Offset: 0x6F7140 VA: 0x1806F7D40
	public static bool LineOfSight(Vector3 p0, Vector3 p1, int layerMask, BaseEntity ignoreEntity) { }

	// RVA: 0x6F7440 Offset: 0x6F6840 VA: 0x1806F7440
	private static bool LineOfSightInternal(Vector3 p0, Vector3 p1, int layerMask, float radius, float padding0, float padding1, BaseEntity ignoreEntity) { }

	// RVA: 0x6F8D60 Offset: 0x6F8160 VA: 0x1806F8D60
	public static bool Verify(RaycastHit hitInfo, BaseEntity ignoreEntity) { }

	// RVA: 0x6F8E10 Offset: 0x6F8210 VA: 0x1806F8E10
	public static bool Verify(Collider collider, Vector3 point, BaseEntity ignoreEntity) { }

	// RVA: 0x6F7150 Offset: 0x6F6550 VA: 0x1806F7150
	private static bool CompareEntity(BaseEntity a, BaseEntity b) { }

	// RVA: 0x6F71C0 Offset: 0x6F65C0 VA: 0x1806F71C0
	public static int HandleTerrainCollision(Vector3 position, int layerMask) { }

	// RVA: 0x6F8680 Offset: 0x6F7A80 VA: 0x1806F8680
	public static void Sort(List<RaycastHit> hits) { }

	// RVA: 0x6F8590 Offset: 0x6F7990 VA: 0x1806F8590
	public static void Sort(RaycastHit[] hits) { }

	// RVA: 0x6F9010 Offset: 0x6F8410 VA: 0x1806F9010
	private static void .cctor() { }

}

private sealed class GamePhysics.<>c // TypeDefIndex: 9259
{	// Fields
	public static readonly GamePhysics.<>c <>9; // 0x0
	public static Comparison<RaycastHit> <>9__41_0; // 0x8
	public static Comparison<RaycastHit> <>9__42_0; // 0x10

	// Methods

	// RVA: 0x701020 Offset: 0x700420 VA: 0x180701020
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x700FE0 Offset: 0x7003E0 VA: 0x180700FE0
	internal int <Sort>b__41_0(RaycastHit a, RaycastHit b) { }

	// RVA: 0x700FE0 Offset: 0x7003E0 VA: 0x180700FE0
	internal int <Sort>b__42_0(RaycastHit a, RaycastHit b) { }

}

