public class Kayak : BaseBoat, IPoolVehicle // TypeDefIndex: 8593
{	public ItemDefinition OarItem; // 0x438
	public float maxPaddleFrequency; // 0x440
	public float forwardPaddleForce; // 0x444
	public float multiDriverPaddleForceMultiplier; // 0x448
	public float rotatePaddleForce; // 0x44C
	public GameObjectRef forwardSplashEffect; // 0x450
	public GameObjectRef backSplashEffect; // 0x458
	public ParticleSystem moveSplashEffect; // 0x460
	public float animationLerpSpeed; // 0x468
	[HeaderAttribute] // RVA: 0x71F00 Offset: 0x71300 VA: 0x180071F00
	public BlendedSoundLoops waterLoops; // 0x470
	public float waterSoundSpeedDivisor; // 0x478
	public GameObjectRef pushLandEffect; // 0x480
	public GameObjectRef pushWaterEffect; // 0x488
	public PlayerModel.MountPoses noPaddlePose; // 0x490
	private TimeSince splashEffectCooldown; // 0x494
	private Kayak.PlayerAnimationState[] animationStates; // 0x498
	private float lastSoundUpdate; // 0x4A0


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void OnPaddled(BaseEntity.RPCMessage msg) { }

	protected override void ClientInit(Entity info) { }

	public override void ClientOnEnable() { }

	public override void UpdatePlayerModel(BasePlayer player) { }

	public override void OnClientInput(BasePlayer player) { }

	public void AnimationSplashEvent(string splashType, BasePlayer forPlayer) { }

	private string GetEffectPath(bool forward) { }

	private int GetPlayerSeat_Client(BasePlayer p) { }

	protected override bool CanPushNow(BasePlayer pusher) { }

	private bool ShowPushMenu(BasePlayer player) { }

	private void UpdateSounds() { }

	public override bool DisplayHealthInfo(BasePlayer player) { }

	public bool IsPlayerHoldingPaddle(BasePlayer player) { }

	private Vector3 GetPaddlePoint(int index, Kayak.PaddleDirection direction) { }

	private bool IsInWater() { }

	public void .ctor() { }

}

private struct Kayak.PlayerAnimationState // TypeDefIndex: 8594
{	public Vector3 smoothedAnimDirection; // 0x0
	public TimeSince lastPaddle; // 0xC
	public Kayak.PaddleDirection lastPaddleDirection; // 0x10

}

private enum Kayak.PaddleDirection // TypeDefIndex: 8595
{	public int value__; // 0x0
	public const Kayak.PaddleDirection Left = 0;
	public const Kayak.PaddleDirection Right = 1;
	public const Kayak.PaddleDirection LeftBack = 2;
	public const Kayak.PaddleDirection RightBack = 3;

}

