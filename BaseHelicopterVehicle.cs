public class BaseHelicopterVehicle : BaseVehicle // TypeDefIndex: 10029
{
	private Option __menuOption_Menu_Push; 
	[HeaderAttribute] 
	public float engineThrustMax; 
	public Vector3 torqueScale; 
	public Transform com; 
	public GameObject[] killTriggers; 
	[HeaderAttribute] 
	public Transform[] GroundPoints; 
	public Transform[] GroundEffects; 
	public GameObjectRef serverGibs; 
	public GameObjectRef explosionEffect; 
	public GameObjectRef fireBall; 
	public GameObjectRef impactEffectSmall; 
	public GameObjectRef impactEffectLarge; 
	[HeaderAttribute] 
	public SoundDefinition flightEngineSoundDef; 
	public SoundDefinition flightThwopsSoundDef; 
	public float rotorGainModSmoothing; 
	public float engineGainMin; 
	public float engineGainMax; 
	public float thwopGainMin; 
	public float thwopGainMax; 
	public float currentThrottle; 
	public float avgThrust; 
	public float liftDotMax; 
	public float altForceDotMin; 
	public float liftFraction; 
	public float thrustLerpSpeed; 
	private Sound flightEngineSound; 
	private Sound flightThwopsSound; 
	private SoundModulation.Modulator flightEngineGainMod; 
	private SoundModulation.Modulator flightThwopsGainMod; 
	private TimeSince timeSinceUpdatedGroundEffects; 

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public virtual void UpdateEffects() { }

	protected override void ClientInit(Entity info) { }

	public void InitializeClientsideEffects() { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public virtual void Menu_Push(BasePlayer player) { }

	public void .ctor() { }

}

public class BaseHelicopterVehicle.HelicopterInputState // TypeDefIndex: 10030
{
	public float throttle; 
	public float roll; 
	public float yaw; 
	public float pitch; 
	public bool groundControl; 


	public void Reset() { }

	public void .ctor() { }

}

