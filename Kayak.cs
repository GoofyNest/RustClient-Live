public class Kayak : BaseBoat, IPoolVehicle // TypeDefIndex: 8593
{	// Fields
	public ItemDefinition OarItem; // 0x438
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

	// Methods

	// RVA: 0x6B3F60 Offset: 0x6B3360 VA: 0x1806B3F60 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x6B3E60 Offset: 0x6B3260 VA: 0x1806B3E60
	public void OnPaddled(BaseEntity.RPCMessage msg) { }

	// RVA: 0x6B36C0 Offset: 0x6B2AC0 VA: 0x1806B36C0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x6B3750 Offset: 0x6B2B50 VA: 0x1806B3750 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0x6B4510 Offset: 0x6B3910 VA: 0x1806B4510 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x6B3D20 Offset: 0x6B3120 VA: 0x1806B3D20 Slot: 158
	public override void OnClientInput(BasePlayer player) { }

	// RVA: 0x6B32F0 Offset: 0x6B26F0 VA: 0x1806B32F0
	public void AnimationSplashEvent(string splashType, BasePlayer forPlayer) { }

	// RVA: 0x6B3830 Offset: 0x6B2C30 VA: 0x1806B3830
	private string GetEffectPath(bool forward) { }

	// RVA: 0x6B3A10 Offset: 0x6B2E10 VA: 0x1806B3A10
	private int GetPlayerSeat_Client(BasePlayer p) { }

	// RVA: 0x6B35D0 Offset: 0x6B29D0 VA: 0x1806B35D0 Slot: 192
	protected override bool CanPushNow(BasePlayer pusher) { }

	// RVA: 0x6B4470 Offset: 0x6B3870 VA: 0x1806B4470
	private bool ShowPushMenu(BasePlayer player) { }

	// RVA: 0x6B4AA0 Offset: 0x6B3EA0 VA: 0x1806B4AA0
	private void UpdateSounds() { }

	// RVA: 0x6B37E0 Offset: 0x6B2BE0 VA: 0x1806B37E0 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x6B3C20 Offset: 0x6B3020 VA: 0x1806B3C20
	public bool IsPlayerHoldingPaddle(BasePlayer player) { }

	// RVA: 0x6B38A0 Offset: 0x6B2CA0 VA: 0x1806B38A0
	private Vector3 GetPaddlePoint(int index, Kayak.PaddleDirection direction) { }

	// RVA: 0x6B3BB0 Offset: 0x6B2FB0 VA: 0x1806B3BB0
	private bool IsInWater() { }

	// RVA: 0x6B4BA0 Offset: 0x6B3FA0 VA: 0x1806B4BA0
	public void .ctor() { }

}

private struct Kayak.PlayerAnimationState // TypeDefIndex: 8594
{	// Fields
	public Vector3 smoothedAnimDirection; // 0x0
	public TimeSince lastPaddle; // 0xC
	public Kayak.PaddleDirection lastPaddleDirection; // 0x10

}

private enum Kayak.PaddleDirection // TypeDefIndex: 8595
{	// Fields
	public int value__; // 0x0
	public const Kayak.PaddleDirection Left = 0;
	public const Kayak.PaddleDirection Right = 1;
	public const Kayak.PaddleDirection LeftBack = 2;
	public const Kayak.PaddleDirection RightBack = 3;

}

