public class Gib : ListComponent<Gib> // TypeDefIndex: 9190
{	// Fields
	public static int gibCount; // 0x0
	public MeshFilter _meshFilter; // 0x18
	public MeshRenderer _meshRenderer; // 0x20
	public MeshCollider _meshCollider; // 0x28
	public BoxCollider _boxCollider; // 0x30
	public SphereCollider _sphereCollider; // 0x38
	public CapsuleCollider _capsuleCollider; // 0x40
	public Rigidbody _rigidbody; // 0x48
	public static Vector2 InWaterDrag; // 0x4
	public static Vector2 InWaterAngularDrag; // 0xC

	// Methods

	// RVA: 0xC79420 Offset: 0xC78820 VA: 0x180C79420
	public void DestroyViaConvar() { }

	// RVA: 0xC79130 Offset: 0xC78530 VA: 0x180C79130
	private void DestroyGib() { }

	// RVA: 0xC79820 Offset: 0xC78C20 VA: 0x180C79820
	public void SetUpDestroy(float minTime, float maxTime) { }

	// RVA: 0xC797A0 Offset: 0xC78BA0 VA: 0x180C797A0 Slot: 6
	protected override void OnEnable() { }

	// RVA: 0xC79700 Offset: 0xC78B00 VA: 0x180C79700 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0xC78EF0 Offset: 0xC782F0 VA: 0x180C78EF0
	public static Gib Create(Mesh mesh, Material[] materials, Vector3 position, Quaternion rotation) { }

	// RVA: 0xC78710 Offset: 0xC77B10 VA: 0x180C78710
	private static Gib CreateGibRoot(Vector3 position, Quaternion rotation) { }

	// RVA: 0xC78910 Offset: 0xC77D10 VA: 0x180C78910
	public void CreatePhysics(Mesh physicsMesh, PhysicMaterial physicsMaterial, Vector3 vel, bool inWater) { }

	// RVA: 0xC78C50 Offset: 0xC78050 VA: 0x180C78C50
	public void CreatePhysics(Mesh physicsMesh, PhysicMaterial physicsMaterial, Vector3 vel, Vector3 angVel, bool inWater) { }

	// RVA: 0xC78830 Offset: 0xC77C30 VA: 0x180C78830
	public void CreatePhysics(Gibbable.OverrideMesh overrideMesh, PhysicMaterial physicsMaterial, Vector3 vel, float scale, bool inWater) { }

	// RVA: 0xC789C0 Offset: 0xC77DC0 VA: 0x180C789C0
	public void CreatePhysics(Gibbable.OverrideMesh overrideMesh, PhysicMaterial physicsMaterial, Vector3 vel, Vector3 angVel, float scale, bool inWater) { }

	// RVA: 0xC79550 Offset: 0xC78950 VA: 0x180C79550
	private void EnableCollider(Gibbable.ColliderType type) { }

	// RVA: 0xC79950 Offset: 0xC78D50 VA: 0x180C79950
	private void SetupCollider(Gibbable.OverrideMesh overrideMesh, PhysicMaterial physicsMaterial, float scale) { }

	// RVA: 0xC79620 Offset: 0xC78A20 VA: 0x180C79620
	public static string GetEffect(PhysicMaterial physicMaterial) { }

	// RVA: 0xC79DE0 Offset: 0xC791E0 VA: 0x180C79DE0
	public void .ctor() { }

	// RVA: 0xC79D10 Offset: 0xC79110 VA: 0x180C79D10
	private static void .cctor() { }

}

