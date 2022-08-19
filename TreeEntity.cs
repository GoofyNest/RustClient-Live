public class TreeEntity : ResourceEntity, IPrefabPreProcess // TypeDefIndex: 8657
{	// Fields
	[HeaderAttribute] // RVA: 0xB7060 Offset: 0xB6460 VA: 0x1800B7060
	public bool fallOnKilled; // 0x180
	public float fallDuration; // 0x184
	public GameObjectRef fallStartSound; // 0x188
	public GameObjectRef fallImpactSound; // 0x190
	public GameObjectRef fallImpactParticles; // 0x198
	public SoundDefinition fallLeavesLoopDef; // 0x1A0
	public bool[] usedHeights; // 0x1A8
	public bool impactSoundPlayed; // 0x1B0
	private float treeDistanceUponFalling; // 0x1B4
	protected Transform treeBaseRef; // 0x1B8
	protected Vector3 oldSkinPos; // 0x1C0
	protected Quaternion oldSkinRot; // 0x1CC
	protected float lastTreeFallTickTime; // 0x1DC
	protected float fallStartTime; // 0x1E0
	private Sound fallLeavesLoop; // 0x1E8
	private SoundModulation.Modulator fallLeavesGainMod; // 0x1F0
	private Vector3 hitDirection; // 0x1F8
	private Vector3 rotateDirection; // 0x204
	private float impactSoundCheckHeight; // 0x210
	private const float treeFallMaxDistSq = 10000;
	public GameObjectRef prefab; // 0x218
	public bool hasBonusGame; // 0x220
	public GameObjectRef bonusHitEffect; // 0x228
	public GameObjectRef bonusHitSound; // 0x230
	public Collider serverCollider; // 0x238
	public Collider clientCollider; // 0x240
	public SoundDefinition smallCrackSoundDef; // 0x248
	public SoundDefinition medCrackSoundDef; // 0x250
	private float lastAttackDamage; // 0x258
	private const float crackSoundMaxDistSq = 900;
	private TreeLOD skin; // 0x260

	// Methods

	// RVA: 0x9F8B60 Offset: 0x9F7F60 VA: 0x1809F8B60 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9F9FB0 Offset: 0x9F93B0 VA: 0x1809F9FB0
	public void TreeFall(BaseEntity.RPCMessage msg) { }

	// RVA: 0x9F97A0 Offset: 0x9F8BA0 VA: 0x1809F97A0
	public void TreeFallTick() { }

	// RVA: 0x9F9540 Offset: 0x9F8940 VA: 0x1809F9540 Slot: 27
	public override void ResetState() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 58
	public override bool ShouldLerp() { }

	// RVA: 0x9F8720 Offset: 0x9F7B20 VA: 0x1809F8720 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x9F8A30 Offset: 0x9F7E30 VA: 0x1809F8A30 Slot: 20
	internal override void DoNetworkDestroy() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9F88E0 Offset: 0x9F7CE0 VA: 0x1809F88E0
	public void CrackSound(BaseEntity.RPCMessage msg) { }

	// RVA: 0x4C0690 Offset: 0x4BFA90 VA: 0x1804C0690 Slot: 113
	public override float BoundsPadding() { }

	// RVA: 0x9F9400 Offset: 0x9F8800 VA: 0x1809F9400 Slot: 84
	public override void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x9FA6C0 Offset: 0x9F9AC0 VA: 0x1809FA6C0
	public void .ctor() { }

}

