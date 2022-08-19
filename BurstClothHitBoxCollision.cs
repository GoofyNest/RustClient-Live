public class BurstClothHitBoxCollision : BurstCloth, IClientComponent, IPrefabPreProcess // TypeDefIndex: 8674
{	// Fields
	[HeaderAttribute] // RVA: 0xB90D0 Offset: 0xB84D0 VA: 0x1800B90D0
	public float GravityStrength; // 0x130
	public float DefaultLength; // 0x134
	public float MountedLengthMultiplier; // 0x138
	public float DuckedLengthMultiplier; // 0x13C
	public float CorpseLengthMultiplier; // 0x140
	[HeaderAttribute] // RVA: 0x94CE0 Offset: 0x940E0 VA: 0x180094CE0
	public string[] IgnoreKeywords; // 0x148
	private BasePlayer _player; // 0x150
	private Ragdoll _ragdoll; // 0x158
	private HitboxSystem _hitboxSystem; // 0x160

	// Methods

	// RVA: 0x709E00 Offset: 0x709200 VA: 0x180709E00 Slot: 4
	protected override void Awake() { }

	// RVA: 0x70AFB0 Offset: 0x70A3B0 VA: 0x18070AFB0
	public void PlayerPreviewVisibility(bool isVisible) { }

	// RVA: 0x709EE0 Offset: 0x7092E0 VA: 0x180709EE0 Slot: 7
	protected override void FrameUpdate() { }

	// RVA: 0x70B0A0 Offset: 0x70A4A0 VA: 0x18070B0A0
	private void UpdateSimulationSpace() { }

	// RVA: 0x70AEB0 Offset: 0x70A2B0 VA: 0x18070AEB0 Slot: 8
	protected override ValueTuple<Vector3, Quaternion, Vector3> GetOriginTransform() { }

	// RVA: 0x70AB10 Offset: 0x709F10 VA: 0x18070AB10
	private ValueTuple<Quaternion, Vector3> GetOrientation() { }

	// RVA: 0x70A1C0 Offset: 0x7095C0 VA: 0x18070A1C0 Slot: 9
	protected override void GatherColliders(List<CapsuleParams> colliders) { }

	// RVA: 0x70AFC0 Offset: 0x70A3C0 VA: 0x18070AFC0 Slot: 10
	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x70B1C0 Offset: 0x70A5C0 VA: 0x18070B1C0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x70AFD0 Offset: 0x70A3D0 VA: 0x18070AFD0
	private bool <GatherColliders>g__ShouldIgnore|15_0(string name) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	internal static void <GatherColliders>g__Swap|15_1<T>(ref T a, ref T b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58A750 Offset: 0x589B50 VA: 0x18058A750
	|-BurstClothHitBoxCollision.<GatherColliders>g__Swap|15_1<object>
	|
	|-RVA: 0x153EE10 Offset: 0x153E210 VA: 0x18153EE10
	|-BurstClothHitBoxCollision.<GatherColliders>g__Swap|15_1<ValueTuple<float, Vector3>>
	*/

}

