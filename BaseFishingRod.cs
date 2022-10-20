public class BaseFishingRod : HeldEntity // TypeDefIndex: 10220
{
	public GameObjectRef FishingBobberRef; 
	public float FishCatchDistance; 
	public LineRenderer ReelLineRenderer; 
	public Transform LineRendererWorldStartPos; 
	[CompilerGeneratedAttribute] 
	private BaseFishingRod.CatchState <CurrentState>k__BackingField; 
	private BaseFishingRod.FishState currentFishState; 
	private EntityRef<FishingBobber> currentBobber; 
	public float ConditionLossOnSuccess; 
	public float ConditionLossOnFail; 
	public float GlobalStrainSpeedMultiplier; 
	public float MaxCastDistance; 
	public const BaseEntity.Flags Straining = 128;
	public ItemModFishable ForceFish; 
	public static BaseEntity.Flags PullingLeftFlag; 
	public static BaseEntity.Flags PullingRightFlag; 
	public static BaseEntity.Flags ReelingInFlag; 
	public GameObjectRef BobberPreview; 
	public SoundDefinition onLineSoundDef; 
	public SoundDefinition strainSoundDef; 
	public AnimationCurve strainGainCurve; 
	public SoundDefinition tensionBreakSoundDef; 
	[ClientVar] 
	public static bool ShowUI; 
	private Vector3[] lineRendererPositionsArray; 
	private Vector3[] lineRendererResultArray; 
	private float[] lineRendererSlack; 
	private float clientStrainAmountNormalised; 
	private TimeUntil canCancel; 
	private FishingRodViewmodel rodViewModel; 
	private BobberPreview spawnedPreview; 
	private static int FailedCatch_Param; 
	private static int CaughtFish_Param; 
	private static int ReelingIn_Param; 
	private static int IsFishing_Param; 
	private bool aimAnimationReady; 
	private static TimeSince lastLureFail; 
	public static TimeSince lastLineReset; 
	public static BaseFishingRod.FailReason lastFailReason; 
	private Sound onLineSound; 
	private Sound strainSound; 
	private SoundModulation.Modulator strainGainMod; 
	private TimeUntil consumingBackMovement; 
	private TimeSince reelInAnimTimer; 

	public BaseFishingRod.CatchState CurrentState { get; set; }
	public static bool ShowLureFailError { get; }


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[CompilerGeneratedAttribute] 
	public BaseFishingRod.CatchState get_CurrentState() { }

	[CompilerGeneratedAttribute] 
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

	[BaseEntity.RPC_Client] 
	private void Client_ReceiveCastPoint(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
	private void Client_HookedSomething(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
	private void Client_UpdateFishState(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
	private void Client_OnCaughtFish(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
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

public enum BaseFishingRod.CatchState // TypeDefIndex: 10221
{
	public int value__; 
	public const BaseFishingRod.CatchState None = 0;
	public const BaseFishingRod.CatchState Aiming = 1;
	public const BaseFishingRod.CatchState Waiting = 2;
	public const BaseFishingRod.CatchState Catching = 3;
	public const BaseFishingRod.CatchState Caught = 4;

}

public enum BaseFishingRod.FishState // TypeDefIndex: 10222
{
	public int value__; 
	public const BaseFishingRod.FishState PullingLeft = 1;
	public const BaseFishingRod.FishState PullingRight = 2;
	public const BaseFishingRod.FishState PullingBack = 4;

}

public enum BaseFishingRod.FailReason // TypeDefIndex: 10223
{
	public int value__; 
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

