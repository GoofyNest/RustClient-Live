public class BaseFishingRod : HeldEntity // TypeDefIndex: 8513
{	public GameObjectRef FishingBobberRef; // 0x1F8
	public float FishCatchDistance; // 0x200
	public LineRenderer ReelLineRenderer; // 0x208
	public Transform LineRendererWorldStartPos; // 0x210
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private BaseFishingRod.CatchState <CurrentState>k__BackingField; // 0x218
	private BaseFishingRod.FishState currentFishState; // 0x21C
	private EntityRef<FishingBobber> currentBobber; // 0x220
	public float ConditionLossOnSuccess; // 0x230
	public float ConditionLossOnFail; // 0x234
	public float GlobalStrainSpeedMultiplier; // 0x238
	public float MaxCastDistance; // 0x23C
	public const BaseEntity.Flags Straining = 128;
	public ItemModFishable ForceFish; // 0x240
	public static BaseEntity.Flags PullingLeftFlag; // 0x0
	public static BaseEntity.Flags PullingRightFlag; // 0x4
	public static BaseEntity.Flags ReelingInFlag; // 0x8
	public GameObjectRef BobberPreview; // 0x248
	public SoundDefinition onLineSoundDef; // 0x250
	public SoundDefinition strainSoundDef; // 0x258
	public AnimationCurve strainGainCurve; // 0x260
	public SoundDefinition tensionBreakSoundDef; // 0x268
	[ClientVar] // RVA: 0x815F0 Offset: 0x809F0 VA: 0x1800815F0
	public static bool ShowUI; // 0xC
	private Vector3[] lineRendererPositionsArray; // 0x270
	private Vector3[] lineRendererResultArray; // 0x278
	private float[] lineRendererSlack; // 0x280
	private float clientStrainAmountNormalised; // 0x288
	private TimeUntil canCancel; // 0x28C
	private FishingRodViewmodel rodViewModel; // 0x290
	private BobberPreview spawnedPreview; // 0x298
	private static int FailedCatch_Param; // 0x10
	private static int CaughtFish_Param; // 0x14
	private static int ReelingIn_Param; // 0x18
	private static int IsFishing_Param; // 0x1C
	private bool aimAnimationReady; // 0x2A0
	private static TimeSince lastLureFail; // 0x20
	public static TimeSince lastLineReset; // 0x24
	public static BaseFishingRod.FailReason lastFailReason; // 0x28
	private Sound onLineSound; // 0x2A8
	private Sound strainSound; // 0x2B0
	private SoundModulation.Modulator strainGainMod; // 0x2B8
	private TimeUntil consumingBackMovement; // 0x2C0
	private TimeSince reelInAnimTimer; // 0x2C4

	public BaseFishingRod.CatchState CurrentState { get; set; }
	public static bool ShowLureFailError { get; }


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public BaseFishingRod.CatchState get_CurrentState() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_CurrentState(BaseFishingRod.CatchState value) { }

	public static bool get_ShowLureFailError() { }

	public override void OnInput() { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	private void UpdateLineRenderer() { }

	private void UpdateSounds(bool onLine, float strainAmount) { }

	private Vector3 GetCurrentCastArcTarget(BasePlayer ply) { }

	private Vector3 GetWorldSpaceLineRendererStartPoint(BasePlayer ply, FishingRodViewmodel fishViewmodel) { }

	private Vector3 GetRodCatchPoint(BasePlayer ply, FishingRodViewmodel fishViewmodel) { }

	public override bool HeldEntityBlocksMovement(InputState state) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void Client_ReceiveCastPoint(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void Client_HookedSomething(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void Client_UpdateFishState(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void Client_OnCaughtFish(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void Client_ResetLine(BaseEntity.RPCMessage msg) { }

	public override void OnViewmodelEvent(string name) { }

	protected override void ProcessPlayerModel(PlayerModel playerModel) { }

	public override void OnHolster() { }

	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public override bool BlocksGestures() { }

	private bool AllowPullInDirection(Vector3 worldDirection, Vector3 bobberPosition) { }

	private bool EvaluateFishingPosition(ref Vector3 pos, BasePlayer ply, out BaseFishingRod.FailReason reason, out WaterBody waterBody) { }

	private Item GetCurrentLure() { }

	private bool HasReelInInput(InputState state) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum BaseFishingRod.CatchState // TypeDefIndex: 8514
{	public int value__; // 0x0
	public const BaseFishingRod.CatchState None = 0;
	public const BaseFishingRod.CatchState Aiming = 1;
	public const BaseFishingRod.CatchState Waiting = 2;
	public const BaseFishingRod.CatchState Catching = 3;
	public const BaseFishingRod.CatchState Caught = 4;

}

public enum BaseFishingRod.FishState // TypeDefIndex: 8515
{	public int value__; // 0x0
	public const BaseFishingRod.FishState PullingLeft = 1;
	public const BaseFishingRod.FishState PullingRight = 2;
	public const BaseFishingRod.FishState PullingBack = 4;

}

public enum BaseFishingRod.FailReason // TypeDefIndex: 8516
{	public int value__; // 0x0
	public const BaseFishingRod.FailReason UserRequested = 0;
	public const BaseFishingRod.FailReason BadAngle = 1;
	public const BaseFishingRod.FailReason TensionBreak = 2;
	public const BaseFishingRod.FailReason Unequipped = 3;
	public const BaseFishingRod.FailReason TimeOut = 4;
	public const BaseFishingRod.FailReason Success = 5;
	public const BaseFishingRod.FailReason NoWaterFound = 6;
	public const BaseFishingRod.FailReason Obstructed = 7;
	public const BaseFishingRod.FailReason NoLure = 8;
	public const BaseFishingRod.FailReason TooShallow = 9;
	public const BaseFishingRod.FailReason TooClose = 10;
	public const BaseFishingRod.FailReason TooFarAway = 11;
	public const BaseFishingRod.FailReason PlayerMoved = 12;

}

