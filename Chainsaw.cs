public class Chainsaw : BaseMelee // TypeDefIndex: 8549
{	public float attackFadeInTime; // 0x2E0
	public float attackFadeInDelay; // 0x2E4
	public float attackFadeOutTime; // 0x2E8
	public float idleFadeInTimeFromOff; // 0x2EC
	public float idleFadeInTimeFromAttack; // 0x2F0
	public float idleFadeInDelay; // 0x2F4
	public float idleFadeOutTime; // 0x2F8
	private bool wasEngineOn; // 0x2FC
	private bool wasAttackingAudio; // 0x2FD
	public Renderer chainRenderer; // 0x300
	private MaterialPropertyBlock block; // 0x308
	private Vector2 saveST; // 0x310
	private float chainSpeed; // 0x318
	private float chainAmount; // 0x31C
	private float chainSpinUpRate; // 0x320
	[HeaderAttribute] // RVA: 0xA9DA0 Offset: 0xA91A0 VA: 0x1800A9DA0
	public float fuelPerSec; // 0x324
	public int maxAmmo; // 0x328
	public int ammo; // 0x32C
	public ItemDefinition fuelType; // 0x330
	public float reloadDuration; // 0x338
	[HeaderAttribute] // RVA: 0xA9E90 Offset: 0xA9290 VA: 0x1800A9E90
	public SoundPlayer idleLoop; // 0x340
	public SoundPlayer attackLoopAir; // 0x348
	public SoundPlayer revUp; // 0x350
	public SoundPlayer revDown; // 0x358
	public SoundPlayer offSound; // 0x360
	private string lastHitMaterial; // 0x368
	private float lastHitTime; // 0x370
	private float nextReleaseTime; // 0x374
	private float nextPressTime; // 0x378
	private bool wasAttacking; // 0x37C
	private float reloadFinishedTime; // 0x380
	public float engineStartChance; // 0x384


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

