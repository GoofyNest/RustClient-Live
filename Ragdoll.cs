public class Ragdoll : BaseMonoBehaviour, IPrefabPreProcess // TypeDefIndex: 9225
{	// Fields
	public Transform eyeTransform; // 0x18
	public Transform centerBone; // 0x20
	public Rigidbody primaryBody; // 0x28
	public PhysicMaterial physicMaterial; // 0x30
	public SpringJoint corpseJoint; // 0x38
	public Skeleton skeleton; // 0x40
	public Model model; // 0x48
	public List<Joint> joints; // 0x50
	public List<CharacterJoint> characterJoints; // 0x58
	public List<ConfigurableJoint> configurableJoints; // 0x60
	public List<Rigidbody> rigidbodies; // 0x68
	public GameObject GibEffect; // 0x70
	public Rigidbody pinTo; // 0x78
	private LODGroup _lodGroup; // 0x80
	private ArticulatedOccludee occludee; // 0x88
	protected bool IsSetup; // 0x90

	// Properties
	public LODGroup lodGroup { get; }

	// Methods

	// RVA: 0x6A5420 Offset: 0x6A4820 VA: 0x1806A5420
	public LODGroup get_lodGroup() { }

	// RVA: 0x6A41E0 Offset: 0x6A35E0 VA: 0x1806A41E0
	public void Awake() { }

	// RVA: 0x6A4C00 Offset: 0x6A4000 VA: 0x1806A4C00
	private void RagdollSetup() { }

	// RVA: 0x6A4380 Offset: 0x6A3780 VA: 0x1806A4380
	public void CopyBonesFrom(Model otherModel) { }

	// RVA: 0x6A48F0 Offset: 0x6A3CF0 VA: 0x1806A48F0
	public void MoveRigidbodiesToRoot() { }

	// RVA: 0x6A46F0 Offset: 0x6A3AF0 VA: 0x1806A46F0
	public void CreatePinJoint() { }

	// RVA: 0x6A5220 Offset: 0x6A4620 VA: 0x1806A5220
	private void UpdateLODBounds() { }

	// RVA: 0x6A5190 Offset: 0x6A4590 VA: 0x1806A5190
	public void SetRagdollSkin(int iSkin) { }

	// RVA: 0x6A49C0 Offset: 0x6A3DC0 VA: 0x1806A49C0
	public void OnGibbed() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 7
	public virtual void Init() { }

	// RVA: 0x6A4B00 Offset: 0x6A3F00 VA: 0x1806A4B00 Slot: 6
	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x6A5330 Offset: 0x6A4730 VA: 0x1806A5330
	public void .ctor() { }

}

