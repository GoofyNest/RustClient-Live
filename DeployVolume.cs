public abstract class DeployVolume : PrefabAttribute // TypeDefIndex: 9843
{	// Fields
	public LayerMask layers; // 0x98
	[InspectorFlagsAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public ColliderInfo.Flags ignore; // 0x9C
	public DeployVolume.EntityMode entityMode; // 0xA0
	[FormerlySerializedAsAttribute] // RVA: 0x9F450 Offset: 0x9E850 VA: 0x18009F450
	public BaseEntity[] entityList; // 0xA8

	// Methods

	// RVA: 0x9B4C40 Offset: 0x9B4040 VA: 0x1809B4C40 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract bool Check(Vector3 position, Quaternion rotation, int mask = -1);

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract bool Check(Vector3 position, Quaternion rotation, OBB test, int mask = -1);

	// RVA: 0x9B4B70 Offset: 0x9B3F70 VA: 0x1809B4B70
	public static bool Check(Vector3 position, Quaternion rotation, DeployVolume[] volumes, int mask = -1) { }

	// RVA: 0x9B4A40 Offset: 0x9B3E40 VA: 0x1809B4A40
	public static bool Check(Vector3 position, Quaternion rotation, DeployVolume[] volumes, OBB test, int mask = -1) { }

	// RVA: 0x9B4930 Offset: 0x9B3D30 VA: 0x1809B4930
	public static bool CheckSphere(Vector3 pos, float radius, int layerMask, DeployVolume volume) { }

	// RVA: 0x9B44C0 Offset: 0x9B38C0 VA: 0x1809B44C0
	public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask, DeployVolume volume) { }

	// RVA: 0x9B4810 Offset: 0x9B3C10 VA: 0x1809B4810
	public static bool CheckOBB(OBB obb, int layerMask, DeployVolume volume) { }

	// RVA: 0x9B43C0 Offset: 0x9B37C0 VA: 0x1809B43C0
	public static bool CheckBounds(Bounds bounds, int layerMask, DeployVolume volume) { }

	// RVA: 0x9B45F0 Offset: 0x9B39F0 VA: 0x1809B45F0
	private static bool CheckFlags(List<Collider> list, DeployVolume volume) { }

	// RVA: 0x9B4CA0 Offset: 0x9B40A0 VA: 0x1809B4CA0
	protected void .ctor() { }

}

public enum DeployVolume.EntityMode // TypeDefIndex: 9844
{	// Fields
	public int value__; // 0x0
	public const DeployVolume.EntityMode ExcludeList = 0;
	public const DeployVolume.EntityMode IncludeList = 1;

}

