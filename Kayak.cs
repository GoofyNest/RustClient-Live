public class Kayak : BaseBoat, IPoolVehicle // TypeDefIndex: 8593
{
	public ItemDefinition OarItem; 
	public float maxPaddleFrequency; 
	public float forwardPaddleForce; 
	public float multiDriverPaddleForceMultiplier; 
	public float rotatePaddleForce; 
	public GameObjectRef forwardSplashEffect; 
	public GameObjectRef backSplashEffect; 
	public ParticleSystem moveSplashEffect; 
	public float animationLerpSpeed; 
	[HeaderAttribute] 
	public BlendedSoundLoops waterLoops; 
	public float waterSoundSpeedDivisor; 
	public GameObjectRef pushLandEffect; 
	public GameObjectRef pushWaterEffect; 
	public PlayerModel.MountPoses noPaddlePose; 
	private TimeSince splashEffectCooldown; 
	private Kayak.PlayerAnimationState[] animationStates; 
	private float lastSoundUpdate; 


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] 
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
{
	public Vector3 smoothedAnimDirection; 
	public TimeSince lastPaddle; 
	public Kayak.PaddleDirection lastPaddleDirection; 

}

private enum Kayak.PaddleDirection // TypeDefIndex: 8595
{
	public int value__; 
	public const Kayak.PaddleDirection Left = 0;
	public const Kayak.PaddleDirection Right = 1;
	public const Kayak.PaddleDirection LeftBack = 2;
	public const Kayak.PaddleDirection RightBack = 3;

}

