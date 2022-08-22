public class HitboxSystem : MonoBehaviour, IPrefabPreProcess // TypeDefIndex: 9267
{	private float rebuildTime; // 0x18
	private const float rebuildDeltaTime = 0,03333334;
	public List<HitboxSystem.HitboxShape> hitboxes; // 0x20


	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public void TraceAll(HitboxCollision collision, HitTest test, List<TraceInfo> hits) { }

	private void OnDrawGizmos() { }

	public void UpdateTransforms(bool force = False) { }

	public void .ctor() { }

}

public class HitboxSystem.HitboxShape // TypeDefIndex: 9268
{	public Transform bone; // 0x10
	public HitboxDefinition.Type type; // 0x18
	public Matrix4x4 localTransform; // 0x1C
	public PhysicMaterial colliderMaterial; // 0x60
	private Matrix4x4 transform; // 0x68
	private Matrix4x4 inverseTransform; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector3 <Size>k__BackingField; // 0xE8

	public Matrix4x4 Transform { get; }
	public Vector3 Position { get; }
	public Quaternion Rotation { get; }
	public Vector3 Size { get; set; }


	public Matrix4x4 get_Transform() { }

	public Vector3 get_Position() { }

	public Quaternion get_Rotation() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Vector3 get_Size() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_Size(Vector3 value) { }

	public void UpdateTransform() { }

	public Vector3 TransformPoint(Vector3 pt) { }

	public Vector3 InverseTransformPoint(Vector3 pt) { }

	public Vector3 TransformDirection(Vector3 pt) { }

	public Vector3 InverseTransformDirection(Vector3 pt) { }

	public bool Trace(Ray ray, out RaycastHit hit, float forgivness = 0, float maxDistance = ∞) { }

	public Bounds GetBounds() { }

	public void .ctor() { }

}

private sealed class HitboxSystem.<>c // TypeDefIndex: 9269
{	public static readonly HitboxSystem.<>c <>9; // 0x0
	public static Func<HitboxDefinition, int> <>9__4_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal int <PreProcess>b__4_0(HitboxDefinition x) { }

}

