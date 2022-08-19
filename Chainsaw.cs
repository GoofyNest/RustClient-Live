public class Chainsaw : BaseMelee // TypeDefIndex: 8549
{	// Fields
	public float attackFadeInTime; // 0x2E0
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

	// Methods

	// RVA: 0x54C910 Offset: 0x54BD10 VA: 0x18054C910 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x54BC10 Offset: 0x54B010 VA: 0x18054BC10
	public void DelayedAttackLoop() { }

	// RVA: 0x54BC40 Offset: 0x54B040 VA: 0x18054BC40
	public void DelayedIdleLoop() { }

	// RVA: 0x54CE00 Offset: 0x54C200 VA: 0x18054CE00
	public void UpdateAudio() { }

	// RVA: 0x54CC50 Offset: 0x54C050 VA: 0x18054CC50
	public void SetupVisuals() { }

	// RVA: 0x54D220 Offset: 0x54C620 VA: 0x18054D220
	private void UpdateChain(bool on, bool attacking) { }

	// RVA: 0x4F2CB0 Offset: 0x4F20B0 VA: 0x1804F2CB0
	public bool EngineOn() { }

	// RVA: 0x54C230 Offset: 0x54B630 VA: 0x18054C230
	public bool IsAttacking() { }

	// RVA: 0x54BAE0 Offset: 0x54AEE0 VA: 0x18054BAE0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x54D460 Offset: 0x54C860 VA: 0x18054D460
	public void Update() { }

	// RVA: 0x54C240 Offset: 0x54B640 VA: 0x18054C240
	private bool IsReloading() { }

	// RVA: 0x54C0E0 Offset: 0x54B4E0 VA: 0x18054C0E0 Slot: 51
	public override void GetItemOptions(List<Option> options) { }

	// RVA: 0x54BC80 Offset: 0x54B080 VA: 0x18054BC80 Slot: 165
	protected override void DoAttack() { }

	// RVA: 0x54CC10 Offset: 0x54C010 VA: 0x18054CC10
	public void SendServerReload() { }

	// RVA: 0x54CA00 Offset: 0x54BE00 VA: 0x18054CA00 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	// RVA: 0x54C450 Offset: 0x54B850 VA: 0x18054C450 Slot: 138
	public override void OnInput() { }

	// RVA: 0x54CAB0 Offset: 0x54BEB0 VA: 0x18054CAB0 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x54C000 Offset: 0x54B400 VA: 0x18054C000
	public v_chainsaw GetChainsawViewmodel() { }

	// RVA: 0x54C300 Offset: 0x54B700 VA: 0x18054C300 Slot: 137
	public override void OnFrame() { }

	// RVA: 0x54BA60 Offset: 0x54AE60 VA: 0x18054BA60
	public void CleanupViewmodel() { }

	// RVA: 0x54C430 Offset: 0x54B830 VA: 0x18054C430 Slot: 142
	public override void OnHolster() { }

	// RVA: 0x54C2E0 Offset: 0x54B6E0 VA: 0x18054C2E0 Slot: 140
	public override void OnDeploy() { }

	// RVA: 0x54CD60 Offset: 0x54C160 VA: 0x18054CD60 Slot: 168
	protected virtual void UpdateAmmoDisplay() { }

	// RVA: 0x54CB60 Offset: 0x54BF60 VA: 0x18054CB60 Slot: 152
	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	// RVA: 0x54CAD0 Offset: 0x54BED0 VA: 0x18054CAD0 Slot: 153
	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	// RVA: 0x54BC70 Offset: 0x54B070 VA: 0x18054BC70 Slot: 160
	public override void DoAttackShared(HitInfo info) { }

	// RVA: 0x54C270 Offset: 0x54B670 VA: 0x18054C270 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x54C210 Offset: 0x54B610 VA: 0x18054C210
	public bool HasAmmo() { }

	// RVA: 0x54BF10 Offset: 0x54B310 VA: 0x18054BF10
	public Item GetAmmo() { }

	// RVA: 0x54D4C0 Offset: 0x54C8C0 VA: 0x18054D4C0
	public void .ctor() { }

}

