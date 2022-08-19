public class HitboxSystem : MonoBehaviour, IPrefabPreProcess // TypeDefIndex: 9267
{	// Fields
	private float rebuildTime; // 0x18
	private const float rebuildDeltaTime = 0,03333334;
	public List<HitboxSystem.HitboxShape> hitboxes; // 0x20

	// Methods

	// RVA: 0x759C70 Offset: 0x759070 VA: 0x180759C70 Slot: 4
	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x75A340 Offset: 0x759740 VA: 0x18075A340
	public void TraceAll(HitboxCollision collision, HitTest test, List<TraceInfo> hits) { }

	// RVA: 0x7597B0 Offset: 0x758BB0 VA: 0x1807597B0
	private void OnDrawGizmos() { }

	// RVA: 0x75AE20 Offset: 0x75A220 VA: 0x18075AE20
	public void UpdateTransforms(bool force = False) { }

	// RVA: 0x75AFA0 Offset: 0x75A3A0 VA: 0x18075AFA0
	public void .ctor() { }

}

public class HitboxSystem.HitboxShape // TypeDefIndex: 9268
{	// Fields
	public Transform bone; // 0x10
	public HitboxDefinition.Type type; // 0x18
	public Matrix4x4 localTransform; // 0x1C
	public PhysicMaterial colliderMaterial; // 0x60
	private Matrix4x4 transform; // 0x68
	private Matrix4x4 inverseTransform; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector3 <Size>k__BackingField; // 0xE8

	// Properties
	public Matrix4x4 Transform { get; }
	public Vector3 Position { get; }
	public Quaternion Rotation { get; }
	public Vector3 Size { get; set; }

	// Methods

	// RVA: 0x4C61B0 Offset: 0x4C55B0 VA: 0x1804C61B0
	public Matrix4x4 get_Transform() { }

	// RVA: 0x7596A0 Offset: 0x758AA0 VA: 0x1807596A0
	public Vector3 get_Position() { }

	// RVA: 0x759740 Offset: 0x758B40 VA: 0x180759740
	public Quaternion get_Rotation() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x759770 Offset: 0x758B70 VA: 0x180759770
	public Vector3 get_Size() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x759790 Offset: 0x758B90 VA: 0x180759790
	private void set_Size(Vector3 value) { }

	// RVA: 0x759300 Offset: 0x758700 VA: 0x180759300
	public void UpdateTransform() { }

	// RVA: 0x7592B0 Offset: 0x7586B0 VA: 0x1807592B0
	public Vector3 TransformPoint(Vector3 pt) { }

	// RVA: 0x758DF0 Offset: 0x7581F0 VA: 0x180758DF0
	public Vector3 InverseTransformPoint(Vector3 pt) { }

	// RVA: 0x759260 Offset: 0x758660 VA: 0x180759260
	public Vector3 TransformDirection(Vector3 pt) { }

	// RVA: 0x758DA0 Offset: 0x7581A0 VA: 0x180758DA0
	public Vector3 InverseTransformDirection(Vector3 pt) { }

	// RVA: 0x758E40 Offset: 0x758240 VA: 0x180758E40
	public bool Trace(Ray ray, out RaycastHit hit, float forgivness = 0, float maxDistance = ∞) { }

	// RVA: 0x758BA0 Offset: 0x757FA0 VA: 0x180758BA0
	public Bounds GetBounds() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private sealed class HitboxSystem.<>c // TypeDefIndex: 9269
{	// Fields
	public static readonly HitboxSystem.<>c <>9; // 0x0
	public static Func<HitboxDefinition, int> <>9__4_0; // 0x8

	// Methods

	// RVA: 0x762A80 Offset: 0x761E80 VA: 0x180762A80
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x762950 Offset: 0x761D50 VA: 0x180762950
	internal int <PreProcess>b__4_0(HitboxDefinition x) { }

}

