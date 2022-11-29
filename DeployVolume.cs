public abstract class DeployVolume : PrefabAttribute // TypeDefIndex: 11580
{
	public LayerMask layers; 
	[InspectorFlagsAttribute] 
	public ColliderInfo.Flags ignore; 
	public DeployVolume.EntityMode entityMode; 
	[FormerlySerializedAsAttribute] 
	public BaseEntity[] entityList; 
	[CompilerGeneratedAttribute] 
	private static Collider <LastDeployHit>k__BackingField; 

	public static Collider LastDeployHit { get; set; }


	protected override Type GetIndexedType() { }

	protected abstract bool Check(Vector3 position, Quaternion rotation, int mask = -1);

	protected abstract bool Check(Vector3 position, Quaternion rotation, OBB test, int mask = -1);

	public static bool Check(Vector3 position, Quaternion rotation, DeployVolume[] volumes, int mask = -1) { }

	public static bool Check(Vector3 position, Quaternion rotation, DeployVolume[] volumes, OBB test, int mask = -1) { }

	public static bool CheckSphere(Vector3 pos, float radius, int layerMask, DeployVolume volume) { }

	public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask, DeployVolume volume) { }

	public static bool CheckOBB(OBB obb, int layerMask, DeployVolume volume) { }

	public static bool CheckBounds(Bounds bounds, int layerMask, DeployVolume volume) { }

	[CompilerGeneratedAttribute] 
	public static Collider get_LastDeployHit() { }

	[CompilerGeneratedAttribute] 
	private static void set_LastDeployHit(Collider value) { }

	private static bool CheckFlags(List<Collider> list, DeployVolume volume) { }

	protected void .ctor() { }

	private static void .cctor() { }

}

public enum DeployVolume.EntityMode // TypeDefIndex: 11581
{
	public int value__; 
	public const DeployVolume.EntityMode ExcludeList = 0;
	public const DeployVolume.EntityMode IncludeList = 1;

}

