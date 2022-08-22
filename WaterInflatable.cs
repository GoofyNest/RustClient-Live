public class WaterInflatable : BaseMountable, IPoolVehicle, INotifyTrigger // TypeDefIndex: 8659
{	public Rigidbody rigidBody; // 0x320
	public Transform centerOfMass; // 0x328
	public float forwardPushForce; // 0x330
	public float rearPushForce; // 0x334
	public float rotationForce; // 0x338
	public float maxSpeed; // 0x33C
	public float maxPaddleFrequency; // 0x340
	public SoundDefinition paddleSfx; // 0x348
	public SoundDefinition smallPlayerMovementSound; // 0x350
	public SoundDefinition largePlayerMovementSound; // 0x358
	public BlendedSoundLoops waterLoops; // 0x360
	public float waterSoundSpeedDivisor; // 0x368
	public float additiveDownhillVelocity; // 0x36C
	public GameObjectRef handSplashForwardEffect; // 0x370
	public GameObjectRef handSplashBackEffect; // 0x378
	public GameObjectRef footSplashEffect; // 0x380
	public float animationLerpSpeed; // 0x388
	public Transform smoothedEyePosition; // 0x390
	public float smoothedEyeSpeed; // 0x398
	public Buoyancy buoyancy; // 0x3A0
	public bool driftTowardsIsland; // 0x3A8
	public GameObjectRef mountEffect; // 0x3B0
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float handSplashOffset; // 0x3B8
	public float velocitySplashMultiplier; // 0x3BC
	public Vector3 modifyEyeOffset; // 0x3C0
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float inheritVelocityMultiplier; // 0x3CC
	private TimeSince lastPaddle; // 0x3D0
	public ParticleSystem[] movingParticleSystems; // 0x3D8
	public float movingParticlesThreshold; // 0x3E0
	public Transform headSpaceCheckPosition; // 0x3E8
	public float headSpaceCheckRadius; // 0x3F0
	private WaterInflatable.PaddleDirection lastPaddleDirection; // 0x3F4
	private Vector3 smoothedAnimDirection; // 0x3F8
	private Vector3 smoothedEyePos; // 0x404
	private Quaternion smoothedEyeRot; // 0x410

	public override bool IsSummerDlcVehicle { get; }


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override bool get_IsSummerDlcVehicle() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void OnPaddled(BaseEntity.RPCMessage msg) { }

	public override void UpdatePlayerModel(BasePlayer player) { }

	public override float GetMountedAnimationSpeed() { }

	public void AnimationSplashEvent(string splashType, BasePlayer forPlayer) { }

	public void AnimationMovementSoundEvent(string type, BasePlayer forPlayer) { }

	private string GetEffectPath(WaterInflatable.ParticleType t) { }

	private bool GetWorldSpaceSplashLocation(string eventString, BasePlayer player, out Vector3 resultPoint, out WaterInflatable.ParticleType type) { }

	private Vector3 ApplyHandOffset(Vector3 resultPoint) { }

	public override Transform GetEyeOverride() { }

	protected override void ClientOnPlayerDismounted(BasePlayer player) { }

	public override bool MountMenuVisible(BasePlayer player) { }

	public override void OnClientInput(BasePlayer player) { }

	protected override void ClientOnPlayerMounted(BasePlayer player) { }

	protected override void ProcessPlayerModel(PlayerModel playerModel) { }

	private void UpdateSounds(Vector3 worldVelocity) { }

	private void ToggleMovingParticles(bool state) { }

	public override Vector3 ModifyThirdPersonEyeOffset(Vector3 eyeOffset) { }

	public override bool LockThirdPersonOffset(out Vector3 offset) { }

	private bool IsOutOfWaterClient() { }

	public void OnObjects(TriggerNotify trigger) { }

	public void OnEmpty() { }

	public void .ctor() { }

}

private enum WaterInflatable.PaddleDirection // TypeDefIndex: 8660
{	public int value__; // 0x0
	public const WaterInflatable.PaddleDirection Forward = 0;
	public const WaterInflatable.PaddleDirection Left = 1;
	public const WaterInflatable.PaddleDirection Right = 2;
	public const WaterInflatable.PaddleDirection Back = 3;

}

private enum WaterInflatable.ParticleType // TypeDefIndex: 8661
{	public int value__; // 0x0
	public const WaterInflatable.ParticleType HandForward = 0;
	public const WaterInflatable.ParticleType HandBack = 1;
	public const WaterInflatable.ParticleType Foot = 2;

}

