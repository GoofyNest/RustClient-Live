public class BaseFishingRod : HeldEntity // TypeDefIndex: 8513
{	// Fields
	public GameObjectRef FishingBobberRef; // 0x1F8
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

	// Properties
	public BaseFishingRod.CatchState CurrentState { get; set; }
	public static bool ShowLureFailError { get; }

	// Methods

	// RVA: 0x803040 Offset: 0x802440 VA: 0x180803040 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x805390 Offset: 0x804790 VA: 0x180805390
	public BaseFishingRod.CatchState get_CurrentState() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x805410 Offset: 0x804810 VA: 0x180805410
	private void set_CurrentState(BaseFishingRod.CatchState value) { }

	// RVA: 0x8053A0 Offset: 0x8047A0 VA: 0x1808053A0
	public static bool get_ShowLureFailError() { }

	// RVA: 0x8022E0 Offset: 0x8016E0 VA: 0x1808022E0 Slot: 138
	public override void OnInput() { }

	// RVA: 0x801F50 Offset: 0x801350 VA: 0x180801F50 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x8049C0 Offset: 0x803DC0 VA: 0x1808049C0
	private void UpdateLineRenderer() { }

	// RVA: 0x804DC0 Offset: 0x8041C0 VA: 0x180804DC0
	private void UpdateSounds(bool onLine, float strainAmount) { }

	// RVA: 0x8015A0 Offset: 0x8009A0 VA: 0x1808015A0
	private Vector3 GetCurrentCastArcTarget(BasePlayer ply) { }

	// RVA: 0x801AB0 Offset: 0x800EB0 VA: 0x180801AB0
	private Vector3 GetWorldSpaceLineRendererStartPoint(BasePlayer ply, FishingRodViewmodel fishViewmodel) { }

	// RVA: 0x8017C0 Offset: 0x800BC0 VA: 0x1808017C0
	private Vector3 GetRodCatchPoint(BasePlayer ply, FishingRodViewmodel fishViewmodel) { }

	// RVA: 0x801DF0 Offset: 0x8011F0 VA: 0x180801DF0 Slot: 151
	public override bool HeldEntityBlocksMovement(InputState state) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x800500 Offset: 0x7FF900 VA: 0x180800500
	private void Client_ReceiveCastPoint(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8000E0 Offset: 0x7FF4E0 VA: 0x1808000E0
	private void Client_HookedSomething(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x800800 Offset: 0x7FFC00 VA: 0x180800800
	private void Client_UpdateFishState(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x800180 Offset: 0x7FF580 VA: 0x180800180
	private void Client_OnCaughtFish(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x800620 Offset: 0x7FFA20 VA: 0x180800620
	private void Client_ResetLine(BaseEntity.RPCMessage msg) { }

	// RVA: 0x804450 Offset: 0x803850 VA: 0x180804450 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	// RVA: 0x804530 Offset: 0x803930 VA: 0x180804530 Slot: 147
	protected override void ProcessPlayerModel(PlayerModel playerModel) { }

	// RVA: 0x802210 Offset: 0x801610 VA: 0x180802210 Slot: 142
	public override void OnHolster() { }

	// RVA: 0x804650 Offset: 0x803A50 VA: 0x180804650 Slot: 152
	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 153
	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	// RVA: 0x801EB0 Offset: 0x8012B0 VA: 0x180801EB0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x8000D0 Offset: 0x7FF4D0 VA: 0x1808000D0 Slot: 155
	public override bool BlocksGestures() { }

	// RVA: 0x7FFF60 Offset: 0x7FF360 VA: 0x1807FFF60
	private bool AllowPullInDirection(Vector3 worldDirection, Vector3 bobberPosition) { }

	// RVA: 0x800870 Offset: 0x7FFC70 VA: 0x180800870
	private bool EvaluateFishingPosition(ref Vector3 pos, BasePlayer ply, out BaseFishingRod.FailReason reason, out WaterBody waterBody) { }

	// RVA: 0x801740 Offset: 0x800B40 VA: 0x180801740
	private Item GetCurrentLure() { }

	// RVA: 0x801DA0 Offset: 0x8011A0 VA: 0x180801DA0
	private bool HasReelInInput(InputState state) { }

	// RVA: 0x8052A0 Offset: 0x8046A0 VA: 0x1808052A0
	public void .ctor() { }

	// RVA: 0x8051B0 Offset: 0x8045B0 VA: 0x1808051B0
	private static void .cctor() { }

}

public enum BaseFishingRod.CatchState // TypeDefIndex: 8514
{	// Fields
	public int value__; // 0x0
	public const BaseFishingRod.CatchState None = 0;
	public const BaseFishingRod.CatchState Aiming = 1;
	public const BaseFishingRod.CatchState Waiting = 2;
	public const BaseFishingRod.CatchState Catching = 3;
	public const BaseFishingRod.CatchState Caught = 4;

}

public enum BaseFishingRod.FishState // TypeDefIndex: 8515
{	// Fields
	public int value__; // 0x0
	public const BaseFishingRod.FishState PullingLeft = 1;
	public const BaseFishingRod.FishState PullingRight = 2;
	public const BaseFishingRod.FishState PullingBack = 4;

}

public enum BaseFishingRod.FailReason // TypeDefIndex: 8516
{	// Fields
	public int value__; // 0x0
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

