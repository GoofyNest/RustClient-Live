public class HitboxSystem : MonoBehaviour, IPrefabPreProcess // TypeDefIndex: 10975
{
	private float rebuildTime; 
	private const float rebuildDeltaTime = 0,03333334;
	public List<HitboxSystem.HitboxShape> hitboxes; 


	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public void TraceAll(HitboxCollision collision, HitTest test, List<TraceInfo> hits) { }

	private void OnDrawGizmos() { }

	public void UpdateTransforms(bool force = False) { }

	public void .ctor() { }

}

public class HitboxSystem.HitboxShape // TypeDefIndex: 10976
{
	public Transform bone; 
	public HitboxDefinition.Type type; 
	public Matrix4x4 localTransform; 
	public PhysicMaterial colliderMaterial; 
	private Matrix4x4 transform; 
	private Matrix4x4 inverseTransform; 
	[CompilerGeneratedAttribute] 
	private Vector3 <Size>k__BackingField; 

	public Matrix4x4 Transform { get; }
	public Vector3 Position { get; }
	public Quaternion Rotation { get; }
	public Vector3 Size { get; set; }


	public Matrix4x4 get_Transform() { }

	public Vector3 get_Position() { }

	public Quaternion get_Rotation() { }

	[CompilerGeneratedAttribute] 
	public Vector3 get_Size() { }

	[CompilerGeneratedAttribute] 
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

private sealed class HitboxSystem.<>c // TypeDefIndex: 10977
{
	public static readonly HitboxSystem.<>c <>9; 
	public static Func<HitboxDefinition, int> <>9__4_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal int <PreProcess>b__4_0(HitboxDefinition x) { }

}

