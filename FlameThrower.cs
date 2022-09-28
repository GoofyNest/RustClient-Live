public class FlameThrower : AttackEntity // TypeDefIndex: 10240
{
	[HeaderAttribute] 
	public int maxAmmo; 
	public int ammo; 
	public ItemDefinition fuelType; 
	public float timeSinceLastAttack; 
	[FormerlySerializedAsAttribute] 
	public float nextReadyTime; 
	public float flameRange; 
	public float flameRadius; 
	public ParticleSystem[] flameEffects; 
	public FlameJet jet; 
	public GameObjectRef fireballPrefab; 
	public List<DamageTypeEntry> damagePerSec; 
	public SoundDefinition flameStart3P; 
	public SoundDefinition flameLoop3P; 
	public SoundDefinition flameStop3P; 
	public SoundDefinition pilotLoopSoundDef; 
	private float tickRate; 
	private float lastFlameTick; 
	public float fuelPerSec; 
	private float ammoRemainder; 
	public float reloadDuration; 
	private bool isReloading; 
	private Sound loopSound; 
	private Sound pilotLoopSound; 
	private float currentGaugeSetting; 
	private bool wasFlameOn; 
	private float nextUnfireTime; 
	private bool firing; 


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

