public class FlameThrower : AttackEntity // TypeDefIndex: 8568
{	// Fields
	[HeaderAttribute] // RVA: 0xAAF20 Offset: 0xAA320 VA: 0x1800AAF20
	public int maxAmmo; // 0x280
	public int ammo; // 0x284
	public ItemDefinition fuelType; // 0x288
	public float timeSinceLastAttack; // 0x290
	[FormerlySerializedAsAttribute] // RVA: 0xAB090 Offset: 0xAA490 VA: 0x1800AB090
	public float nextReadyTime; // 0x294
	public float flameRange; // 0x298
	public float flameRadius; // 0x29C
	public ParticleSystem[] flameEffects; // 0x2A0
	public FlameJet jet; // 0x2A8
	public GameObjectRef fireballPrefab; // 0x2B0
	public List<DamageTypeEntry> damagePerSec; // 0x2B8
	public SoundDefinition flameStart3P; // 0x2C0
	public SoundDefinition flameLoop3P; // 0x2C8
	public SoundDefinition flameStop3P; // 0x2D0
	public SoundDefinition pilotLoopSoundDef; // 0x2D8
	private float tickRate; // 0x2E0
	private float lastFlameTick; // 0x2E4
	public float fuelPerSec; // 0x2E8
	private float ammoRemainder; // 0x2EC
	public float reloadDuration; // 0x2F0
	private bool isReloading; // 0x2F4
	private Sound loopSound; // 0x2F8
	private Sound pilotLoopSound; // 0x300
	private float currentGaugeSetting; // 0x308
	private bool wasFlameOn; // 0x30C
	private float nextUnfireTime; // 0x310
	private bool firing; // 0x314

	// Methods

	// RVA: 0x78D180 Offset: 0x78C580 VA: 0x18078D180 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x78C910 Offset: 0x78BD10 VA: 0x18078C910
	private bool IsWeaponBusy() { }

	// RVA: 0x78D400 Offset: 0x78C800 VA: 0x18078D400
	private void SetBusyFor(float dur) { }

	// RVA: 0x78C420 Offset: 0x78B820 VA: 0x18078C420
	private void ClearBusy() { }

	// RVA: 0x78D330 Offset: 0x78C730 VA: 0x18078D330
	public void ReduceAmmo(float firingTime) { }

	// RVA: 0x78D2F0 Offset: 0x78C6F0 VA: 0x18078D2F0
	public void PilotLightToggle_Shared() { }

	// RVA: 0x4F2CB0 Offset: 0x4F20B0 VA: 0x1804F2CB0
	public bool IsPilotOn() { }

	// RVA: 0x786750 Offset: 0x785B50 VA: 0x180786750
	public bool IsFlameOn() { }

	// RVA: 0x78C810 Offset: 0x78BC10 VA: 0x18078C810
	public bool HasAmmo() { }

	// RVA: 0x78C450 Offset: 0x78B850 VA: 0x18078C450
	public Item GetAmmo() { }

	// RVA: 0x78C540 Offset: 0x78B940 VA: 0x18078C540
	public Sound GetFlameLoopSound() { }

	// RVA: 0x78C740 Offset: 0x78BB40 VA: 0x18078C740
	public Sound GetPilotLoopSound() { }

	// RVA: 0x78D820 Offset: 0x78CC20 VA: 0x18078D820
	public void Update() { }

	// RVA: 0x78D630 Offset: 0x78CA30 VA: 0x18078D630
	private void UpdateSounds(bool isFirstPerson = False) { }

	// RVA: 0x78C9C0 Offset: 0x78BDC0 VA: 0x18078C9C0 Slot: 138
	public override void OnInput() { }

	// RVA: 0x78D4D0 Offset: 0x78C8D0 VA: 0x18078D4D0
	public void UpdateFlameStateFirstPerson() { }

	// RVA: 0x78D270 Offset: 0x78C670 VA: 0x18078D270 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	// RVA: 0x78C9B0 Offset: 0x78BDB0 VA: 0x18078C9B0 Slot: 143
	public override void OnHolstered() { }

	// RVA: 0x78C940 Offset: 0x78BD40 VA: 0x18078C940 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x78C610 Offset: 0x78BA10 VA: 0x18078C610 Slot: 51
	public override void GetItemOptions(List<Option> options) { }

	// RVA: 0x78D430 Offset: 0x78C830 VA: 0x18078D430 Slot: 160
	protected virtual void UpdateAmmoDisplay() { }

	// RVA: 0x78DAF0 Offset: 0x78CEF0 VA: 0x18078DAF0
	public void .ctor() { }

}

