public class WaterInflatable : BaseMountable, IPoolVehicle, INotifyTrigger // TypeDefIndex: 8659
{	// Fields
	public Rigidbody rigidBody; // 0x320
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

	// Properties
	public override bool IsSummerDlcVehicle { get; }

	// Methods

	// RVA: 0xC0F3C0 Offset: 0xC0E7C0 VA: 0x180C0F3C0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 171
	public override bool get_IsSummerDlcVehicle() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC0F360 Offset: 0xC0E760 VA: 0x180C0F360
	public void OnPaddled(BaseEntity.RPCMessage msg) { }

	// RVA: 0xC0FB20 Offset: 0xC0EF20 VA: 0x180C0FB20 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x4C0690 Offset: 0x4BFA90 VA: 0x1804C0690 Slot: 164
	public override float GetMountedAnimationSpeed() { }

	// RVA: 0xC0E160 Offset: 0xC0D560 VA: 0x180C0E160
	public void AnimationSplashEvent(string splashType, BasePlayer forPlayer) { }

	// RVA: 0xC0DFA0 Offset: 0xC0D3A0 VA: 0x180C0DFA0
	public void AnimationMovementSoundEvent(string type, BasePlayer forPlayer) { }

	// RVA: 0xC0E870 Offset: 0xC0DC70 VA: 0x180C0E870
	private string GetEffectPath(WaterInflatable.ParticleType t) { }

	// RVA: 0xC0EB70 Offset: 0xC0DF70 VA: 0x180C0EB70
	private bool GetWorldSpaceSplashLocation(string eventString, BasePlayer player, out Vector3 resultPoint, out WaterInflatable.ParticleType type) { }

	// RVA: 0xC0E3F0 Offset: 0xC0D7F0 VA: 0x180C0E3F0
	private Vector3 ApplyHandOffset(Vector3 resultPoint) { }

	// RVA: 0xC0E900 Offset: 0xC0DD00 VA: 0x180C0E900 Slot: 148
	public override Transform GetEyeOverride() { }

	// RVA: 0xC0E5F0 Offset: 0xC0D9F0 VA: 0x180C0E5F0 Slot: 178
	protected override void ClientOnPlayerDismounted(BasePlayer player) { }

	// RVA: 0xC0F090 Offset: 0xC0E490 VA: 0x180C0F090 Slot: 184
	public override bool MountMenuVisible(BasePlayer player) { }

	// RVA: 0xC0F190 Offset: 0xC0E590 VA: 0x180C0F190 Slot: 158
	public override void OnClientInput(BasePlayer player) { }

	// RVA: 0xC0E660 Offset: 0xC0DA60 VA: 0x180C0E660 Slot: 179
	protected override void ClientOnPlayerMounted(BasePlayer player) { }

	// RVA: 0xC0F820 Offset: 0xC0EC20 VA: 0x180C0F820 Slot: 160
	protected override void ProcessPlayerModel(PlayerModel playerModel) { }

	// RVA: 0xC0FDA0 Offset: 0xC0F1A0 VA: 0x180C0FDA0
	private void UpdateSounds(Vector3 worldVelocity) { }

	// RVA: 0xC0FA70 Offset: 0xC0EE70 VA: 0x180C0FA70
	private void ToggleMovingParticles(bool state) { }

	// RVA: 0xC0EFD0 Offset: 0xC0E3D0 VA: 0x180C0EFD0 Slot: 167
	public override Vector3 ModifyThirdPersonEyeOffset(Vector3 eyeOffset) { }

	// RVA: 0xC0EF60 Offset: 0xC0E360 VA: 0x180C0EF60 Slot: 168
	public override bool LockThirdPersonOffset(out Vector3 offset) { }

	// RVA: 0xC0EF00 Offset: 0xC0E300 VA: 0x180C0EF00
	private bool IsOutOfWaterClient() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 186
	public void OnObjects(TriggerNotify trigger) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 187
	public void OnEmpty() { }

	// RVA: 0xC0FE80 Offset: 0xC0F280 VA: 0x180C0FE80
	public void .ctor() { }

}

private enum WaterInflatable.PaddleDirection // TypeDefIndex: 8660
{	// Fields
	public int value__; // 0x0
	public const WaterInflatable.PaddleDirection Forward = 0;
	public const WaterInflatable.PaddleDirection Left = 1;
	public const WaterInflatable.PaddleDirection Right = 2;
	public const WaterInflatable.PaddleDirection Back = 3;

}

private enum WaterInflatable.ParticleType // TypeDefIndex: 8661
{	// Fields
	public int value__; // 0x0
	public const WaterInflatable.ParticleType HandForward = 0;
	public const WaterInflatable.ParticleType HandBack = 1;
	public const WaterInflatable.ParticleType Foot = 2;

}

