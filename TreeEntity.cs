public class TreeEntity : ResourceEntity, IPrefabPreProcess // TypeDefIndex: 8657
{	[HeaderAttribute] // RVA: 0xB7060 Offset: 0xB6460 VA: 0x1800B7060
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


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void TreeFall(BaseEntity.RPCMessage msg) { }

	public void TreeFallTick() { }

	public override void ResetState() { }

	public override bool ShouldLerp() { }

	protected override void ClientInit(Entity info) { }

	internal override void DoNetworkDestroy() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void CrackSound(BaseEntity.RPCMessage msg) { }

	public override float BoundsPadding() { }

	public override void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public void .ctor() { }

}

