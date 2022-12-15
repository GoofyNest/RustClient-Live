public class Gibbable : PrefabAttribute, IClientComponent // TypeDefIndex: 11645
{
	public GameObject gibSource;
	public Material[] customMaterials;
	public GameObject materialSource;
	public bool copyMaterialBlock;
	public bool applyDamageTexture;
	public PhysicMaterial physicsMaterial;
	public GameObjectRef fxPrefab;
	public bool spawnFxPrefab;
	[TooltipAttribute]
	public bool important;
	public bool useContinuousCollision;
	public float explodeScale;
	public float scaleOverride;
	[ReadOnlyAttribute]
	public int uniqueId;
	public Gibbable.BoundsEffectType boundsEffectType;
	public bool isConditional;
	[ReadOnlyAttribute]
	public Bounds effectBounds;
	public List<Gibbable.OverrideMesh> MeshOverrides;
	private static MaterialPropertyBlock propertyBlock;
	private static Material copyMaterial;
	private Gib newGib;
	private Gibbable.GibMesh[] gibRenderers;


	protected override void AttributeSetup(GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public void CreateGibs(Transform forObject, Gibbable.ParentingType parentingType, Vector3 initialVelocity) { }

	public void CreateGibs(Transform forObject, Gibbable.ParentingType parentingType, Vector3 initialVelocity, Vector3 fxPos, Quaternion fxRotation) { }

	private Vector3 Position(Vector3 position, Quaternion rotation) { }

	private Material[] GetMaterialsForGib(Gibbable.GibMesh mesh) { }

	public bool GetMeshOverride(int index, out Gibbable.OverrideMesh m) { }

	private string GetPathForEffect(Gibbable.BoundsEffectType type) { }

	protected override Type GetIndexedType() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public struct Gibbable.OverrideMesh // TypeDefIndex: 11646
{
	public bool enabled;
	public Gibbable.ColliderType ColliderType;
	public Vector3 BoxSize;
	public Vector3 ColliderCentre;
	public float ColliderRadius;
	public float CapsuleHeight;
	public int CapsuleDirection;
	public bool BlockMaterialCopy;

}

public enum Gibbable.ColliderType // TypeDefIndex: 11647
{
	public int value__;
	public const Gibbable.ColliderType Box = 0;
	public const Gibbable.ColliderType Sphere = 1;
	public const Gibbable.ColliderType Capsule = 2;

}

public enum Gibbable.ParentingType // TypeDefIndex: 11648
{
	public int value__;
	public const Gibbable.ParentingType None = 0;
	public const Gibbable.ParentingType GibsOnly = 1;
	public const Gibbable.ParentingType FXOnly = 2;
	public const Gibbable.ParentingType All = 3;

}

public enum Gibbable.BoundsEffectType // TypeDefIndex: 11649
{
	public int value__;
	public const Gibbable.BoundsEffectType None = 0;
	public const Gibbable.BoundsEffectType Electrical = 1;
	public const Gibbable.BoundsEffectType Glass = 2;
	public const Gibbable.BoundsEffectType Scrap = 3;
	public const Gibbable.BoundsEffectType Stone = 4;
	public const Gibbable.BoundsEffectType Wood = 5;

}

private struct Gibbable.GibMesh // TypeDefIndex: 11650
{
	public Transform transform;
	public MeshFilter filter;
	public MeshCollider collider;
	public Vector3 localPosition;
	public Quaternion localRotation;
	public Material[] materials;

}

