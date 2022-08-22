public class FlameThrower : AttackEntity // TypeDefIndex: 8568
{	[HeaderAttribute] // RVA: 0xAAF20 Offset: 0xAA320 VA: 0x1800AAF20
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


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	private bool IsWeaponBusy() { }

	private void SetBusyFor(float dur) { }

	private void ClearBusy() { }

	public void ReduceAmmo(float firingTime) { }

	public void PilotLightToggle_Shared() { }

	public bool IsPilotOn() { }

	public bool IsFlameOn() { }

	public bool HasAmmo() { }

	public Item GetAmmo() { }

	public Sound GetFlameLoopSound() { }

	public Sound GetPilotLoopSound() { }

	public void Update() { }

	private void UpdateSounds(bool isFirstPerson = False) { }

	public override void OnInput() { }

	public void UpdateFlameStateFirstPerson() { }

	public override void OnViewmodelEvent(string name) { }

	public override void OnHolstered() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public override void GetItemOptions(List<Option> options) { }

	protected virtual void UpdateAmmoDisplay() { }

	public void .ctor() { }

}

