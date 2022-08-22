public class BaseHelicopterVehicle : BaseVehicle // TypeDefIndex: 8325
{	private Option __menuOption_Menu_Push; // 0x3B8
	[HeaderAttribute] // RVA: 0xB6F00 Offset: 0xB6300 VA: 0x1800B6F00
	public float engineThrustMax; // 0x410
	public Vector3 torqueScale; // 0x414
	public Transform com; // 0x420
	public GameObject[] killTriggers; // 0x428
	[HeaderAttribute] // RVA: 0x785E0 Offset: 0x779E0 VA: 0x1800785E0
	public Transform[] GroundPoints; // 0x430
	public Transform[] GroundEffects; // 0x438
	public GameObjectRef serverGibs; // 0x440
	public GameObjectRef explosionEffect; // 0x448
	public GameObjectRef fireBall; // 0x450
	public GameObjectRef impactEffectSmall; // 0x458
	public GameObjectRef impactEffectLarge; // 0x460
	[HeaderAttribute] // RVA: 0xA9E90 Offset: 0xA9290 VA: 0x1800A9E90
	public SoundDefinition flightEngineSoundDef; // 0x468
	public SoundDefinition flightThwopsSoundDef; // 0x470
	public float rotorGainModSmoothing; // 0x478
	public float engineGainMin; // 0x47C
	public float engineGainMax; // 0x480
	public float thwopGainMin; // 0x484
	public float thwopGainMax; // 0x488
	public float currentThrottle; // 0x48C
	public float avgThrust; // 0x490
	public float liftDotMax; // 0x494
	public float altForceDotMin; // 0x498
	public float liftFraction; // 0x49C
	public float thrustLerpSpeed; // 0x4A0
	private Sound flightEngineSound; // 0x4A8
	private Sound flightThwopsSound; // 0x4B0
	private SoundModulation.Modulator flightEngineGainMod; // 0x4B8
	private SoundModulation.Modulator flightThwopsGainMod; // 0x4C0
	private TimeSince timeSinceUpdatedGroundEffects; // 0x4C8

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public virtual void UpdateEffects() { }

	protected override void ClientInit(Entity info) { }

	public void InitializeClientsideEffects() { }

	[BaseEntity.Menu] // RVA: 0x8C890 Offset: 0x8BC90 VA: 0x18008C890
	[BaseEntity.Menu.Description] // RVA: 0x8C890 Offset: 0x8BC90 VA: 0x18008C890
	[BaseEntity.Menu.Icon] // RVA: 0x8C890 Offset: 0x8BC90 VA: 0x18008C890
	[BaseEntity.Menu.ShowIf] // RVA: 0x8C890 Offset: 0x8BC90 VA: 0x18008C890
	public virtual void Menu_Push(BasePlayer player) { }

	public void .ctor() { }

}

public class BaseHelicopterVehicle.HelicopterInputState // TypeDefIndex: 8326
{	public float throttle; // 0x10
	public float roll; // 0x14
	public float yaw; // 0x18
	public float pitch; // 0x1C
	public bool groundControl; // 0x20


	public void Reset() { }

	public void .ctor() { }

}

