public class Gib : ListComponent<Gib> // TypeDefIndex: 9190
{
	public static int gibCount; 
	public MeshFilter _meshFilter; 
	public MeshRenderer _meshRenderer; 
	public MeshCollider _meshCollider; 
	public BoxCollider _boxCollider; 
	public SphereCollider _sphereCollider; 
	public CapsuleCollider _capsuleCollider; 
	public Rigidbody _rigidbody; 
	public static Vector2 InWaterDrag; 
	public static Vector2 InWaterAngularDrag; 


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

