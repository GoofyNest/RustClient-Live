public class BaseHelicopter : BaseCombatEntity // TypeDefIndex: 10228
{
	public BaseHelicopter.weakspot[] weakspots; 
	public GameObject rotorPivot; 
	public GameObject mainRotor; 
	public GameObject mainRotor_blades; 
	public GameObject mainRotor_blur; 
	public GameObject tailRotor; 
	public GameObject tailRotor_blades; 
	public GameObject tailRotor_blur; 
	public GameObject rocket_tube_left; 
	public GameObject rocket_tube_right; 
	public GameObject left_gun_yaw; 
	public GameObject left_gun_pitch; 
	public GameObject left_gun_muzzle; 
	public GameObject right_gun_yaw; 
	public GameObject right_gun_pitch; 
	public GameObject right_gun_muzzle; 
	public GameObject spotlight_rotation; 
	public GameObjectRef rocket_fire_effect; 
	public GameObjectRef gun_fire_effect; 
	public GameObjectRef bulletEffect; 
	public GameObjectRef explosionEffect; 
	public GameObjectRef fireBall; 
	public GameObjectRef crateToDrop; 
	public int maxCratesToSpawn; 
	public float bulletSpeed; 
	public float bulletDamage; 
	public GameObjectRef servergibs; 
	public GameObjectRef debrisFieldMarker; 
	public SoundDefinition rotorWashSoundDef; 
	private Sound _rotorWashSound; 
	public SoundDefinition flightEngineSoundDef; 
	public SoundDefinition flightThwopsSoundDef; 
	private Sound flightEngineSound; 
	private Sound flightThwopsSound; 
	private SoundModulation.Modulator flightEngineGainMod; 
	private SoundModulation.Modulator flightThwopsGainMod; 
	public float rotorGainModSmoothing; 
	public float engineGainMin; 
	public float engineGainMax; 
	public float thwopGainMin; 
	public float thwopGainMax; 
	public float spotlightJitterAmount; 
	public float spotlightJitterSpeed; 
	public GameObject[] nightLights; 
	public Vector3 spotlightTarget; 
	public float engineSpeed; 
	public float targetEngineSpeed; 
	public float blur_rotationScale; 
	public ParticleSystem[] _rotorWashParticles; 
	private PatrolHelicopterAI myAI; 
	public GameObjectRef mapMarkerEntityPrefab; 
	private Quaternion client_rotorPivotIdeal; 
	private bool nightLightsOn; 


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public void InitalizeWeakspots() { }

	public override float MaxVelocity() { }

	public override void InitShared() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	protected override void ClientInit(Entity info) { }

	public void InitializeClientsideEffects() { }

	protected override void DoClientDestroy() { }

	public void SetLights(bool areOn) { }

	public void Update() { }

	public void UpdateEffects() { }

	public void UpdateRotorWashPosition(Vector3 pos, Vector3 normal) { }

	public void ToggleRotorWash(bool enabled) { }

	public void UpdateRotorVisibility() { }

	[BaseEntity.RPC_Client] 
	public void FireGun(BaseEntity.RPCMessage rpc) { }

	public void .ctor() { }

}

public class BaseHelicopter.weakspot // TypeDefIndex: 10229
{
	public BaseHelicopter body; 
	public string[] bonenames; 
	public float maxHealth; 
	public float health; 
	public float healthFractionOnDestroyed; 
	public GameObjectRef destroyedParticles; 
	public GameObjectRef damagedParticles; 
	public GameObject damagedEffect; 
	public GameObject destroyedEffect; 
	public List<BasePlayer> attackers; 


	public float HealthFraction() { }

	public void ClientHealthUpdate(float newHealth) { }

	public void .ctor() { }

}

