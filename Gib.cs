public class Gib : ListComponent<Gib> // TypeDefIndex: 9190
{	public static int gibCount; // 0x0
	public MeshFilter _meshFilter; // 0x18
	public MeshRenderer _meshRenderer; // 0x20
	public MeshCollider _meshCollider; // 0x28
	public BoxCollider _boxCollider; // 0x30
	public SphereCollider _sphereCollider; // 0x38
	public CapsuleCollider _capsuleCollider; // 0x40
	public Rigidbody _rigidbody; // 0x48
	public static Vector2 InWaterDrag; // 0x4
	public static Vector2 InWaterAngularDrag; // 0xC


	public void DestroyViaConvar() { }

	private void DestroyGib() { }

	public void SetUpDestroy(float minTime, float maxTime) { }

	protected override void OnEnable() { }

	protected override void OnDisable() { }

	public static Gib Create(Mesh mesh, Material[] materials, Vector3 position, Quaternion rotation) { }

	private static Gib CreateGibRoot(Vector3 position, Quaternion rotation) { }

	public void CreatePhysics(Mesh physicsMesh, PhysicMaterial physicsMaterial, Vector3 vel, bool inWater) { }

	public void CreatePhysics(Mesh physicsMesh, PhysicMaterial physicsMaterial, Vector3 vel, Vector3 angVel, bool inWater) { }

	public void CreatePhysics(Gibbable.OverrideMesh overrideMesh, PhysicMaterial physicsMaterial, Vector3 vel, float scale, bool inWater) { }

	public void CreatePhysics(Gibbable.OverrideMesh overrideMesh, PhysicMaterial physicsMaterial, Vector3 vel, Vector3 angVel, float scale, bool inWater) { }

	private void EnableCollider(Gibbable.ColliderType type) { }

	private void SetupCollider(Gibbable.OverrideMesh overrideMesh, PhysicMaterial physicsMaterial, float scale) { }

	public static string GetEffect(PhysicMaterial physicMaterial) { }

	public void .ctor() { }

	private static void .cctor() { }

}

