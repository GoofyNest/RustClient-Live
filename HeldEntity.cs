public class HeldEntity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6312
{
	public bool ShouldPool; 
	private bool _disposed; 
	public uint itemUID; 


	public static void ResetToPool(HeldEntity instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(HeldEntity instance) { }

	public HeldEntity Copy() { }

	public static HeldEntity Deserialize(Stream stream) { }

	public static HeldEntity DeserializeLengthDelimited(Stream stream) { }

	public static HeldEntity DeserializeLength(Stream stream, int length) { }

	public static HeldEntity Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, HeldEntity previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static HeldEntity Deserialize(byte[] buffer, HeldEntity instance, bool isDelta = False) { }

	public static HeldEntity Deserialize(Stream stream, HeldEntity instance, bool isDelta) { }

	public static HeldEntity DeserializeLengthDelimited(Stream stream, HeldEntity instance, bool isDelta) { }

	public static HeldEntity DeserializeLength(Stream stream, int length, HeldEntity instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, HeldEntity instance, HeldEntity previous) { }

	public static void Serialize(Stream stream, HeldEntity instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(HeldEntity instance) { }

	public static void SerializeLengthDelimited(Stream stream, HeldEntity instance) { }

	public void .ctor() { }

}

public class HeldEntity : BaseEntity // TypeDefIndex: 8575
{
	protected List<HeldEntity.PunchEntry> _punches; 
	protected Vector3 punchAdded; 
	protected float lastPunchTime; 
	public Animator worldModelAnimator; 
	public SoundDefinition thirdPersonDeploySound; 
	public SoundDefinition thirdPersonAimSound; 
	public SoundDefinition thirdPersonAimEndSound; 
	protected ViewModel viewModel; 
	protected bool isDeployed; 
	public static float lastExamineTime; 
	private float nextExamineTime; 
	public const BaseEntity.Flags Flag_ForceVisible = 65536;
	[HeaderAttribute] 
	public string handBone; 
	public AnimatorOverrideController HoldAnimationOverride; 
	public bool isBuildingTool; 
	[HeaderAttribute] 
	public float hostileScore; 
	public HeldEntity.HolsterInfo holsterInfo; 
	[HeaderAttribute] 
	public BasePlayer.CameraMode HeldCameraMode; 
	public Vector3 FirstPersonArmOffset; 
	public Vector3 FirstPersonArmRotation; 
	[RangeAttribute] 
	public float FirstPersonRotationStrength; 
	internal uint ownerItemUID; 

	public bool hostile { get; }


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public virtual void AddPunch(Vector3 amount, float duration) { }

	[BaseEntity.RPC_Client] 
	public void CL_Punch(BaseEntity.RPCMessage msg) { }

	public virtual void DoRecoilCompensation() { }

	public Vector3 GetAddedPunch() { }

	public virtual void SimPunches() { }

	protected override void ClientInit(Entity info) { }

	public float GetFovOverride() { }

	internal override void DoNetworkDestroy() { }

	public virtual void PostLateClientCycle() { }

	public override void PostNetworkUpdate() { }

	public void UpdateHolsteredOffset() { }

	public virtual void EditViewAngles() { }

	public virtual void ClampPitch(ref float pitch) { }

	public virtual void OnFrame() { }

	public virtual void OnInput() { }

	public virtual void Examine() { }

	public virtual void OnDeploy() { }

	public virtual void OnDeployed() { }

	public virtual void OnHolster() { }

	public virtual void OnHolstered() { }

	public virtual void OnViewmodelEvent(string name) { }

	public virtual void OnReliableEvent(string name) { }

	public virtual void ModifyCamera() { }

	public override bool ShouldDestroyImmediately() { }

	internal void UpdatePlayerModel(PlayerModel playerModel) { }

	protected virtual void ProcessPlayerModel(PlayerModel playerModel) { }

	public virtual AnimatorOverrideController GetHoldAnimations() { }

	public virtual float GetMovementMultiplier() { }

	public virtual void OnSpawnedForWorkshopPreview() { }

	public virtual bool HeldEntityBlocksMovement(InputState state) { }

	public virtual void ProcessSpectatorViewmodel(ViewModel vm) { }

	public virtual void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	public bool get_hostile() { }

	public bool LightsOn() { }

	public bool IsDeployed() { }

	public BasePlayer GetOwnerPlayer() { }

	public Connection GetOwnerConnection() { }

	public virtual bool CanBeUsedInWater() { }

	public virtual bool BlocksGestures() { }

	protected Item GetOwnerItem() { }

	public override Item GetItem() { }

	public ItemDefinition GetOwnerItemDefinition() { }

	public virtual bool IsInstrument() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class HeldEntity.PunchEntry // TypeDefIndex: 8576
{
	public Vector3 amount; 
	public float duration; 
	public float startTime; 
	public Vector3 amountAdded; 


	public void .ctor() { }

}

public class HeldEntity.HolsterInfo // TypeDefIndex: 8577
{
	public HeldEntity.HolsterInfo.HolsterSlot slot; 
	public bool displayWhenHolstered; 
	public string holsterBone; 
	public Vector3 holsterOffset; 
	public Vector3 holsterRotationOffset; 


	public void .ctor() { }

}

public enum HeldEntity.HolsterInfo.HolsterSlot // TypeDefIndex: 8578
{
	public int value__; 
	public const HeldEntity.HolsterInfo.HolsterSlot BACK = 0;
	public const HeldEntity.HolsterInfo.HolsterSlot RIGHT_THIGH = 1;
	public const HeldEntity.HolsterInfo.HolsterSlot LEFT_THIGH = 2;

}

public static class HeldEntity.HeldEntityFlags // TypeDefIndex: 8579
{
	public const BaseEntity.Flags Deployed = 1024;
	public const BaseEntity.Flags LightsOn = 2048;

}

