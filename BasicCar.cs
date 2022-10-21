public class BasicCar : BaseVehicle // TypeDefIndex: 11420
{
	public BasicCar.VehicleWheel[] wheels; 
	public float brakePedal; 
	public float gasPedal; 
	public float steering; 
	public Transform centerOfMass; 
	public Transform steeringWheel; 
	public float motorForceConstant; 
	public float brakeForceConstant; 
	public float GasLerpTime; 
	public float SteeringLerpTime; 
	public Transform driverEye; 
	public GameObjectRef chairRef; 
	public Transform chairAnchorTest; 
	public SoundPlayer idleLoopPlayer; 
	public Transform engineOffset; 
	public SoundDefinition engineSoundDef; 
	private SedanWheelSmoke wheelSmoke; 
	private float shockRestingPosY; 
	private float shockDistance; 
	private float traceDistanceNeutralPoint; 
	private int cachedMask; 
	private const float wheelSpinConstant = 120;
	private AverageVelocity averageVelocity; 
	private Sound engineSoundLoop; 
	private SoundModulation.Modulator engineSoundVolume; 
	private SoundModulation.Modulator engineSoundPitch; 


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

public class BasicCar.VehicleWheel // TypeDefIndex: 11421
{
	public Transform shock; 
	public WheelCollider wheelCollider; 
	public Transform wheel; 
	public Transform axle; 
	public bool steerWheel; 
	public bool brakeWheel; 
	public bool powerWheel; 


	public void .ctor() { }

}

