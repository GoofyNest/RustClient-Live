public class BaseHelicopter : BaseCombatEntity // TypeDefIndex: 8519
{	// Fields
	public BaseHelicopter.weakspot[] weakspots; // 0x240
	public GameObject rotorPivot; // 0x248
	public GameObject mainRotor; // 0x250
	public GameObject mainRotor_blades; // 0x258
	public GameObject mainRotor_blur; // 0x260
	public GameObject tailRotor; // 0x268
	public GameObject tailRotor_blades; // 0x270
	public GameObject tailRotor_blur; // 0x278
	public GameObject rocket_tube_left; // 0x280
	public GameObject rocket_tube_right; // 0x288
	public GameObject left_gun_yaw; // 0x290
	public GameObject left_gun_pitch; // 0x298
	public GameObject left_gun_muzzle; // 0x2A0
	public GameObject right_gun_yaw; // 0x2A8
	public GameObject right_gun_pitch; // 0x2B0
	public GameObject right_gun_muzzle; // 0x2B8
	public GameObject spotlight_rotation; // 0x2C0
	public GameObjectRef rocket_fire_effect; // 0x2C8
	public GameObjectRef gun_fire_effect; // 0x2D0
	public GameObjectRef bulletEffect; // 0x2D8
	public GameObjectRef explosionEffect; // 0x2E0
	public GameObjectRef fireBall; // 0x2E8
	public GameObjectRef crateToDrop; // 0x2F0
	public int maxCratesToSpawn; // 0x2F8
	public float bulletSpeed; // 0x2FC
	public float bulletDamage; // 0x300
	public GameObjectRef servergibs; // 0x308
	public GameObjectRef debrisFieldMarker; // 0x310
	public SoundDefinition rotorWashSoundDef; // 0x318
	private Sound _rotorWashSound; // 0x320
	public SoundDefinition flightEngineSoundDef; // 0x328
	public SoundDefinition flightThwopsSoundDef; // 0x330
	private Sound flightEngineSound; // 0x338
	private Sound flightThwopsSound; // 0x340
	private SoundModulation.Modulator flightEngineGainMod; // 0x348
	private SoundModulation.Modulator flightThwopsGainMod; // 0x350
	public float rotorGainModSmoothing; // 0x358
	public float engineGainMin; // 0x35C
	public float engineGainMax; // 0x360
	public float thwopGainMin; // 0x364
	public float thwopGainMax; // 0x368
	public float spotlightJitterAmount; // 0x36C
	public float spotlightJitterSpeed; // 0x370
	public GameObject[] nightLights; // 0x378
	public Vector3 spotlightTarget; // 0x380
	public float engineSpeed; // 0x38C
	public float targetEngineSpeed; // 0x390
	public float blur_rotationScale; // 0x394
	public ParticleSystem[] _rotorWashParticles; // 0x398
	private PatrolHelicopterAI myAI; // 0x3A0
	public GameObjectRef mapMarkerEntityPrefab; // 0x3A8
	private Quaternion client_rotorPivotIdeal; // 0x3B0
	private bool nightLightsOn; // 0x3C0

	// Methods

	// RVA: 0xA1F4B0 Offset: 0xA1E8B0 VA: 0x180A1F4B0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA1EF10 Offset: 0xA1E310 VA: 0x180A1EF10
	public void InitalizeWeakspots() { }

	// RVA: 0x73C880 Offset: 0x73BC80 VA: 0x18073C880 Slot: 112
	public override float MaxVelocity() { }

	// RVA: 0xA1EE80 Offset: 0xA1E280 VA: 0x180A1EE80 Slot: 28
	public override void InitShared() { }

	// RVA: 0xA1F1F0 Offset: 0xA1E5F0 VA: 0x180A1F1F0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xA1E8A0 Offset: 0xA1DCA0 VA: 0x180A1E8A0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xA1EF90 Offset: 0xA1E390 VA: 0x180A1EF90
	public void InitializeClientsideEffects() { }

	// RVA: 0xA1E8C0 Offset: 0xA1DCC0 VA: 0x180A1E8C0 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0xA1F900 Offset: 0xA1ED00 VA: 0x180A1F900
	public void SetLights(bool areOn) { }

	// RVA: 0xA20370 Offset: 0xA1F770 VA: 0x180A20370
	public void Update() { }

	// RVA: 0xA1FA20 Offset: 0xA1EE20 VA: 0x180A1FA20
	public void UpdateEffects() { }

	// RVA: 0xA20230 Offset: 0xA1F630 VA: 0x180A20230
	public void UpdateRotorWashPosition(Vector3 pos, Vector3 normal) { }

	// RVA: 0xA1F9A0 Offset: 0xA1EDA0 VA: 0x180A1F9A0
	public void ToggleRotorWash(bool enabled) { }

	// RVA: 0xA201A0 Offset: 0xA1F5A0 VA: 0x180A201A0
	public void UpdateRotorVisibility() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA1E9A0 Offset: 0xA1DDA0 VA: 0x180A1E9A0
	public void FireGun(BaseEntity.RPCMessage rpc) { }

	// RVA: 0xA20AD0 Offset: 0xA1FED0 VA: 0x180A20AD0
	public void .ctor() { }

}

public class BaseHelicopter.weakspot // TypeDefIndex: 8520
{	// Fields
	public BaseHelicopter body; // 0x10
	public string[] bonenames; // 0x18
	public float maxHealth; // 0x20
	public float health; // 0x24
	public float healthFractionOnDestroyed; // 0x28
	public GameObjectRef destroyedParticles; // 0x30
	public GameObjectRef damagedParticles; // 0x38
	public GameObject damagedEffect; // 0x40
	public GameObject destroyedEffect; // 0x48
	public List<BasePlayer> attackers; // 0x50

	// Methods

	// RVA: 0xA33390 Offset: 0xA32790 VA: 0x180A33390
	public float HealthFraction() { }

	// RVA: 0xA33270 Offset: 0xA32670 VA: 0x180A33270
	public void ClientHealthUpdate(float newHealth) { }

	// RVA: 0xA333A0 Offset: 0xA327A0 VA: 0x180A333A0
	public void .ctor() { }

}

