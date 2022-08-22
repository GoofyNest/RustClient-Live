public class HeldEntity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6312
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint itemUID; // 0x14


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
{	protected List<HeldEntity.PunchEntry> _punches; // 0x168
	protected Vector3 punchAdded; // 0x170
	protected float lastPunchTime; // 0x17C
	public Animator worldModelAnimator; // 0x180
	public SoundDefinition thirdPersonDeploySound; // 0x188
	public SoundDefinition thirdPersonAimSound; // 0x190
	public SoundDefinition thirdPersonAimEndSound; // 0x198
	protected ViewModel viewModel; // 0x1A0
	protected bool isDeployed; // 0x1A8
	public static float lastExamineTime; // 0x0
	private float nextExamineTime; // 0x1AC
	public const BaseEntity.Flags Flag_ForceVisible = 65536;
	[HeaderAttribute] // RVA: 0xABAB0 Offset: 0xAAEB0 VA: 0x1800ABAB0
	public string handBone; // 0x1B0
	public AnimatorOverrideController HoldAnimationOverride; // 0x1B8
	public bool isBuildingTool; // 0x1C0
	[HeaderAttribute] // RVA: 0xABB20 Offset: 0xAAF20 VA: 0x1800ABB20
	public float hostileScore; // 0x1C4
	public HeldEntity.HolsterInfo holsterInfo; // 0x1C8
	[HeaderAttribute] // RVA: 0xABC70 Offset: 0xAB070 VA: 0x1800ABC70
	public BasePlayer.CameraMode HeldCameraMode; // 0x1D0
	public Vector3 FirstPersonArmOffset; // 0x1D4
	public Vector3 FirstPersonArmRotation; // 0x1E0
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float FirstPersonRotationStrength; // 0x1EC
	internal uint ownerItemUID; // 0x1F0

	public bool hostile { get; }


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public virtual void AddPunch(Vector3 amount, float duration) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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
{	public Vector3 amount; // 0x10
	public float duration; // 0x1C
	public float startTime; // 0x20
	public Vector3 amountAdded; // 0x24


	public void .ctor() { }

}

public class HeldEntity.HolsterInfo // TypeDefIndex: 8577
{	public HeldEntity.HolsterInfo.HolsterSlot slot; // 0x10
	public bool displayWhenHolstered; // 0x14
	public string holsterBone; // 0x18
	public Vector3 holsterOffset; // 0x20
	public Vector3 holsterRotationOffset; // 0x2C


	public void .ctor() { }

}

public enum HeldEntity.HolsterInfo.HolsterSlot // TypeDefIndex: 8578
{	public int value__; // 0x0
	public const HeldEntity.HolsterInfo.HolsterSlot BACK = 0;
	public const HeldEntity.HolsterInfo.HolsterSlot RIGHT_THIGH = 1;
	public const HeldEntity.HolsterInfo.HolsterSlot LEFT_THIGH = 2;

}

public static class HeldEntity.HeldEntityFlags // TypeDefIndex: 8579
{	public const BaseEntity.Flags Deployed = 1024;
	public const BaseEntity.Flags LightsOn = 2048;

}

