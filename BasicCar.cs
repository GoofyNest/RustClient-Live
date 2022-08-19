public class BasicCar : BaseVehicle // TypeDefIndex: 9698
{	// Fields
	public BasicCar.VehicleWheel[] wheels; // 0x3B8
	public float brakePedal; // 0x3C0
	public float gasPedal; // 0x3C4
	public float steering; // 0x3C8
	public Transform centerOfMass; // 0x3D0
	public Transform steeringWheel; // 0x3D8
	public float motorForceConstant; // 0x3E0
	public float brakeForceConstant; // 0x3E4
	public float GasLerpTime; // 0x3E8
	public float SteeringLerpTime; // 0x3EC
	public Transform driverEye; // 0x3F0
	public GameObjectRef chairRef; // 0x3F8
	public Transform chairAnchorTest; // 0x400
	public SoundPlayer idleLoopPlayer; // 0x408
	public Transform engineOffset; // 0x410
	public SoundDefinition engineSoundDef; // 0x418
	private SedanWheelSmoke wheelSmoke; // 0x420
	private float shockRestingPosY; // 0x428
	private float shockDistance; // 0x42C
	private float traceDistanceNeutralPoint; // 0x430
	private int cachedMask; // 0x434
	private const float wheelSpinConstant = 120;
	private AverageVelocity averageVelocity; // 0x438
	private Sound engineSoundLoop; // 0x440
	private SoundModulation.Modulator engineSoundVolume; // 0x448
	private SoundModulation.Modulator engineSoundPitch; // 0x450

	// Methods

	// RVA: 0x5264F0 Offset: 0x5258F0 VA: 0x1805264F0 Slot: 112
	public override float MaxVelocity() { }

	// RVA: 0x525C20 Offset: 0x525020 VA: 0x180525C20 Slot: 154
	public override Vector3 EyePositionForPlayer(BasePlayer player, Quaternion viewRot) { }

	// RVA: 0x525B40 Offset: 0x524F40 VA: 0x180525B40 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x526500 Offset: 0x525900 VA: 0x180526500 Slot: 59
	public override void SetNetworkPosition(Vector3 vPos) { }

	// RVA: 0x5258D0 Offset: 0x524CD0 VA: 0x1805258D0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x526EF0 Offset: 0x5262F0 VA: 0x180526EF0
	public void Update() { }

	// RVA: 0x525CF0 Offset: 0x5250F0 VA: 0x180525CF0
	private float GetShockHeightDelta(WheelCollider wheel, int i) { }

	// RVA: 0x525AE0 Offset: 0x524EE0 VA: 0x180525AE0
	private float ClientSteering() { }

	// RVA: 0x5264E0 Offset: 0x5258E0 VA: 0x1805264E0
	public bool IsBreaking() { }

	// RVA: 0x526940 Offset: 0x525D40 VA: 0x180526940
	private void UpdateTireAnimation() { }

	// RVA: 0x526350 Offset: 0x525750 VA: 0x180526350
	public void InitializeClientsideEffects() { }

	// RVA: 0x526570 Offset: 0x525970 VA: 0x180526570
	public void ShutdownClientsideEffects() { }

	// RVA: 0x4989F0 Offset: 0x497DF0 VA: 0x1804989F0
	public bool IsEngineOn() { }

	// RVA: 0x526640 Offset: 0x525A40 VA: 0x180526640
	public void UpdateSounds() { }

	// RVA: 0x526F50 Offset: 0x526350 VA: 0x180526F50
	public void .ctor() { }

}

public class BasicCar.VehicleWheel // TypeDefIndex: 9699
{	// Fields
	public Transform shock; // 0x10
	public WheelCollider wheelCollider; // 0x18
	public Transform wheel; // 0x20
	public Transform axle; // 0x28
	public bool steerWheel; // 0x30
	public bool brakeWheel; // 0x31
	public bool powerWheel; // 0x32

	// Methods

	// RVA: 0x542BE0 Offset: 0x541FE0 VA: 0x180542BE0
	public void .ctor() { }

}

