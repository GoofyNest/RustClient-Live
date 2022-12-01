public class BurstClothHitBoxCollision : BurstCloth, IClientComponent, IPrefabPreProcess // TypeDefIndex: 10400
{
	[HeaderAttribute]
	public bool UseLocalGravity;
	public float GravityStrength;
	public float DefaultLength;
	public float MountedLengthMultiplier;
	public float DuckedLengthMultiplier;
	public float CorpseLengthMultiplier;
	public Transform UpAxis;
	[HeaderAttribute]
	public Transform ColliderRoot;
	[TooltipAttribute]
	public string[] IgnoreKeywords;
	private BasePlayer _player;
	private Ragdoll _ragdoll;
	private HitboxSystem _hitboxSystem;


	protected override void Awake() { }

	public void PlayerPreviewVisibility(bool isVisible) { }

	protected override void FrameUpdate() { }

	private void UpdateSimulationSpace() { }

	protected override ValueTuple<Vector3, Quaternion, Vector3> GetOriginTransform() { }

	private ValueTuple<Quaternion, Vector3> GetOrientation() { }

	protected override void GatherColliders(List<CapsuleParams> colliders) { }

	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public void .ctor() { }

	[CompilerGeneratedAttribute]
	private bool <GatherColliders>g__ShouldIgnore|18_0(string name) { }

	[CompilerGeneratedAttribute]
	internal static void <GatherColliders>g__Swap|18_1<T>(ref T a, ref T b) { }
	/* GenericInstMethod :
	|
	|-BurstClothHitBoxCollision.<GatherColliders>g__Swap|18_1<object>
	|
	|-BurstClothHitBoxCollision.<GatherColliders>g__Swap|18_1<ValueTuple<float, Vector3>>
	*/

}

