public class Chainsaw : BaseMelee // TypeDefIndex: 8552
{
	public float attackFadeInTime; 
	public float attackFadeInDelay; 
	public float attackFadeOutTime; 
	public float idleFadeInTimeFromOff; 
	public float idleFadeInTimeFromAttack; 
	public float idleFadeInDelay; 
	public float idleFadeOutTime; 
	private bool wasEngineOn; 
	private bool wasAttackingAudio; 
	public Renderer chainRenderer; 
	private MaterialPropertyBlock block; 
	private Vector2 saveST; 
	private float chainSpeed; 
	private float chainAmount; 
	private float chainSpinUpRate; 
	[HeaderAttribute] 
	public float fuelPerSec; 
	public int maxAmmo; 
	public int ammo; 
	public ItemDefinition fuelType; 
	public float reloadDuration; 
	[HeaderAttribute] 
	public SoundPlayer idleLoop; 
	public SoundPlayer attackLoopAir; 
	public SoundPlayer revUp; 
	public SoundPlayer revDown; 
	public SoundPlayer offSound; 
	private string lastHitMaterial; 
	private float lastHitTime; 
	private float nextReleaseTime; 
	private float nextPressTime; 
	private bool wasAttacking; 
	private float reloadFinishedTime; 
	public float engineStartChance; 


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public void DelayedAttackLoop() { }

	public void DelayedIdleLoop() { }

	public void UpdateAudio() { }

	public void SetupVisuals() { }

	private void UpdateChain(bool on, bool attacking) { }

	public bool EngineOn() { }

	public bool IsAttacking() { }

	protected override void ClientInit(Entity info) { }

	public void Update() { }

	private bool IsReloading() { }

	public override void GetItemOptions(List<Option> options) { }

	protected override void DoAttack() { }

	public void SendServerReload() { }

	public override void OnViewmodelEvent(string name) { }

	public override void OnInput() { }

	public override void PostNetworkUpdate() { }

	public v_chainsaw GetChainsawViewmodel() { }

	public override void OnFrame() { }

	public void CleanupViewmodel() { }

	public override void OnHolster() { }

	public override void OnDeploy() { }

	protected virtual void UpdateAmmoDisplay() { }

	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	public override void DoAttackShared(HitInfo info) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public bool HasAmmo() { }

	public Item GetAmmo() { }

	public void .ctor() { }

}

