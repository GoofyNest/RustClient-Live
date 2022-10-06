public class TreeEntity : ResourceEntity, IPrefabPreProcess // TypeDefIndex: 10365
{
	[HeaderAttribute] 
	public bool fallOnKilled; 
	public float fallDuration; 
	public GameObjectRef fallStartSound; 
	public GameObjectRef fallImpactSound; 
	public GameObjectRef fallImpactParticles; 
	public SoundDefinition fallLeavesLoopDef; 
	public bool[] usedHeights; 
	public bool impactSoundPlayed; 
	private float treeDistanceUponFalling; 
	protected Transform treeBaseRef; 
	protected Vector3 oldSkinPos; 
	protected Quaternion oldSkinRot; 
	protected float lastTreeFallTickTime; 
	protected float fallStartTime; 
	private Sound fallLeavesLoop; 
	private SoundModulation.Modulator fallLeavesGainMod; 
	private Vector3 hitDirection; 
	private Vector3 rotateDirection; 
	private float impactSoundCheckHeight; 
	private const float treeFallMaxDistSq = 10000;
	public GameObjectRef prefab; 
	public bool hasBonusGame; 
	public GameObjectRef bonusHitEffect; 
	public GameObjectRef bonusHitSound; 
	public Collider serverCollider; 
	public Collider clientCollider; 
	public SoundDefinition smallCrackSoundDef; 
	public SoundDefinition medCrackSoundDef; 
	private float lastAttackDamage; 
	private const float crackSoundMaxDistSq = 900;
	private TreeLOD skin; 


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] 
	public void TreeFall(BaseEntity.RPCMessage msg) { }

	public void TreeFallTick() { }

	public override void ResetState() { }

	public override bool ShouldLerp() { }

	protected override void ClientInit(Entity info) { }

	internal override void DoNetworkDestroy() { }

	[BaseEntity.RPC_Client] 
	public void CrackSound(BaseEntity.RPCMessage msg) { }

	public override float BoundsPadding() { }

	public override void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public void .ctor() { }

}

