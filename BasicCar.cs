public class BasicCar : BaseVehicle // TypeDefIndex: 9698
{	public BasicCar.VehicleWheel[] wheels; // 0x3B8
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


	public override float MaxVelocity() { }

	public override Vector3 EyePositionForPlayer(BasePlayer player, Quaternion viewRot) { }

	protected override void DoClientDestroy() { }

	public override void SetNetworkPosition(Vector3 vPos) { }

	protected override void ClientInit(Entity info) { }

	public void Update() { }

	private float GetShockHeightDelta(WheelCollider wheel, int i) { }

	private float ClientSteering() { }

	public bool IsBreaking() { }

	private void UpdateTireAnimation() { }

	public void InitializeClientsideEffects() { }

	public void ShutdownClientsideEffects() { }

	public bool IsEngineOn() { }

	public void UpdateSounds() { }

	public void .ctor() { }

}

public class BasicCar.VehicleWheel // TypeDefIndex: 9699
{	public Transform shock; // 0x10
	public WheelCollider wheelCollider; // 0x18
	public Transform wheel; // 0x20
	public Transform axle; // 0x28
	public bool steerWheel; // 0x30
	public bool brakeWheel; // 0x31
	public bool powerWheel; // 0x32


	public void .ctor() { }

}

