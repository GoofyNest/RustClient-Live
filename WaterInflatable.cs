public class WaterInflatable : BaseMountable, IPoolVehicle, INotifyTrigger // TypeDefIndex: 10368
{
	public Rigidbody rigidBody; 
	public Transform centerOfMass; 
	public float forwardPushForce; 
	public float rearPushForce; 
	public float rotationForce; 
	public float maxSpeed; 
	public float maxPaddleFrequency; 
	public SoundDefinition paddleSfx; 
	public SoundDefinition smallPlayerMovementSound; 
	public SoundDefinition largePlayerMovementSound; 
	public BlendedSoundLoops waterLoops; 
	public float waterSoundSpeedDivisor; 
	public float additiveDownhillVelocity; 
	public GameObjectRef handSplashForwardEffect; 
	public GameObjectRef handSplashBackEffect; 
	public GameObjectRef footSplashEffect; 
	public float animationLerpSpeed; 
	public Transform smoothedEyePosition; 
	public float smoothedEyeSpeed; 
	public Buoyancy buoyancy; 
	public bool driftTowardsIsland; 
	public GameObjectRef mountEffect; 
	[RangeAttribute] 
	public float handSplashOffset; 
	public float velocitySplashMultiplier; 
	public Vector3 modifyEyeOffset; 
	[RangeAttribute] 
	public float inheritVelocityMultiplier; 
	private TimeSince lastPaddle; 
	public ParticleSystem[] movingParticleSystems; 
	public float movingParticlesThreshold; 
	public Transform headSpaceCheckPosition; 
	public float headSpaceCheckRadius; 
	private WaterInflatable.PaddleDirection lastPaddleDirection; 
	private Vector3 smoothedAnimDirection; 
	private Vector3 smoothedEyePos; 
	private Quaternion smoothedEyeRot; 

	public override bool IsSummerDlcVehicle { get; }


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override bool get_IsSummerDlcVehicle() { }

	[BaseEntity.RPC_Client] 
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

private enum WaterInflatable.PaddleDirection // TypeDefIndex: 10369
{
	public int value__; 
	public const WaterInflatable.PaddleDirection Forward = 0;
	public const WaterInflatable.PaddleDirection Left = 1;
	public const WaterInflatable.PaddleDirection Right = 2;
	public const WaterInflatable.PaddleDirection Back = 3;

}

private enum WaterInflatable.ParticleType // TypeDefIndex: 10370
{
	public int value__; 
	public const WaterInflatable.ParticleType HandForward = 0;
	public const WaterInflatable.ParticleType HandBack = 1;
	public const WaterInflatable.ParticleType Foot = 2;

}

