public class HeldEntity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6312
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint itemUID; // 0x14

	// Methods

	// RVA: 0x1D5FE40 Offset: 0x1D5F240 VA: 0x181D5FE40
	public static void ResetToPool(HeldEntity instance) { }

	// RVA: 0x1D5FEC0 Offset: 0x1D5F2C0 VA: 0x181D5FEC0
	public void ResetToPool() { }

	// RVA: 0x1D5FD10 Offset: 0x1D5F110 VA: 0x181D5FD10 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BF9250 Offset: 0x1BF8650 VA: 0x181BF9250
	public void CopyTo(HeldEntity instance) { }

	// RVA: 0x1D5F390 Offset: 0x1D5E790 VA: 0x181D5F390
	public HeldEntity Copy() { }

	// RVA: 0x1D5FB90 Offset: 0x1D5EF90 VA: 0x181D5FB90
	public static HeldEntity Deserialize(Stream stream) { }

	// RVA: 0x1D5F400 Offset: 0x1D5E800 VA: 0x181D5F400
	public static HeldEntity DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D5F8A0 Offset: 0x1D5ECA0 VA: 0x181D5F8A0
	public static HeldEntity DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D5FA70 Offset: 0x1D5EE70 VA: 0x181D5FA70
	public static HeldEntity Deserialize(byte[] buffer) { }

	// RVA: 0x1D5FE00 Offset: 0x1D5F200 VA: 0x181D5FE00
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D60390 Offset: 0x1D5F790 VA: 0x181D60390 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D60460 Offset: 0x1D5F860 VA: 0x181D60460 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, HeldEntity previous) { }

	// RVA: 0x1D5FE20 Offset: 0x1D5F220 VA: 0x181D5FE20 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D5FC10 Offset: 0x1D5F010 VA: 0x181D5FC10
	public static HeldEntity Deserialize(byte[] buffer, HeldEntity instance, bool isDelta = False) { }

	// RVA: 0x1D5F930 Offset: 0x1D5ED30 VA: 0x181D5F930
	public static HeldEntity Deserialize(Stream stream, HeldEntity instance, bool isDelta) { }

	// RVA: 0x1D5F480 Offset: 0x1D5E880 VA: 0x181D5F480
	public static HeldEntity DeserializeLengthDelimited(Stream stream, HeldEntity instance, bool isDelta) { }

	// RVA: 0x1D5F6A0 Offset: 0x1D5EAA0 VA: 0x181D5F6A0
	public static HeldEntity DeserializeLength(Stream stream, int length, HeldEntity instance, bool isDelta) { }

	// RVA: 0x1D5FF40 Offset: 0x1D5F340 VA: 0x181D5FF40
	public static void SerializeDelta(Stream stream, HeldEntity instance, HeldEntity previous) { }

	// RVA: 0x1D602B0 Offset: 0x1D5F6B0 VA: 0x181D602B0
	public static void Serialize(Stream stream, HeldEntity instance) { }

	// RVA: 0x1D60380 Offset: 0x1D5F780 VA: 0x181D60380
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D60390 Offset: 0x1D5F790 VA: 0x181D60390
	public void ToProto(Stream stream) { }

	// RVA: 0x1D60100 Offset: 0x1D5F500 VA: 0x181D60100
	public static byte[] SerializeToBytes(HeldEntity instance) { }

	// RVA: 0x1D60050 Offset: 0x1D5F450 VA: 0x181D60050
	public static void SerializeLengthDelimited(Stream stream, HeldEntity instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class HeldEntity : BaseEntity // TypeDefIndex: 8575
{	// Fields
	protected List<HeldEntity.PunchEntry> _punches; // 0x168
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

	// Properties
	public bool hostile { get; }

	// Methods

	// RVA: 0x751DB0 Offset: 0x7511B0 VA: 0x180751DB0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x751000 Offset: 0x750400 VA: 0x180751000 Slot: 131
	public virtual void AddPunch(Vector3 amount, float duration) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7510D0 Offset: 0x7504D0 VA: 0x1807510D0
	public void CL_Punch(BaseEntity.RPCMessage msg) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 132
	public virtual void DoRecoilCompensation() { }

	// RVA: 0x751400 Offset: 0x750800 VA: 0x180751400
	public Vector3 GetAddedPunch() { }

	// RVA: 0x7525A0 Offset: 0x7519A0 VA: 0x1807525A0 Slot: 133
	public virtual void SimPunches() { }

	// RVA: 0x751180 Offset: 0x750580 VA: 0x180751180 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x751420 Offset: 0x750820 VA: 0x180751420
	public float GetFovOverride() { }

	// RVA: 0x751250 Offset: 0x750650 VA: 0x180751250 Slot: 20
	internal override void DoNetworkDestroy() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 134
	public virtual void PostLateClientCycle() { }

	// RVA: 0x752260 Offset: 0x751660 VA: 0x180752260 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x752A70 Offset: 0x751E70 VA: 0x180752A70
	public void UpdateHolsteredOffset() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 135
	public virtual void EditViewAngles() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 136
	public virtual void ClampPitch(ref float pitch) { }

	// RVA: 0x751C20 Offset: 0x751020 VA: 0x180751C20 Slot: 137
	public virtual void OnFrame() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 138
	public virtual void OnInput() { }

	// RVA: 0x751290 Offset: 0x750690 VA: 0x180751290 Slot: 139
	public virtual void Examine() { }

	// RVA: 0x751960 Offset: 0x750D60 VA: 0x180751960 Slot: 140
	public virtual void OnDeploy() { }

	// RVA: 0x751C10 Offset: 0x751010 VA: 0x180751C10 Slot: 141
	public virtual void OnDeployed() { }

	// RVA: 0x751C40 Offset: 0x751040 VA: 0x180751C40 Slot: 142
	public virtual void OnHolster() { }

	// RVA: 0x751DA0 Offset: 0x7511A0 VA: 0x180751DA0 Slot: 143
	public virtual void OnHolstered() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 144
	public virtual void OnViewmodelEvent(string name) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 145
	public virtual void OnReliableEvent(string name) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 146
	public virtual void ModifyCamera() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 18
	public override bool ShouldDestroyImmediately() { }

	// RVA: 0x753270 Offset: 0x752670 VA: 0x180753270
	internal void UpdatePlayerModel(PlayerModel playerModel) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 147
	protected virtual void ProcessPlayerModel(PlayerModel playerModel) { }

	// RVA: 0x751610 Offset: 0x750A10 VA: 0x180751610 Slot: 148
	public virtual AnimatorOverrideController GetHoldAnimations() { }

	// RVA: 0x4C0690 Offset: 0x4BFA90 VA: 0x1804C0690 Slot: 149
	public virtual float GetMovementMultiplier() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 150
	public virtual void OnSpawnedForWorkshopPreview() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 151
	public virtual bool HeldEntityBlocksMovement(InputState state) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 152
	public virtual void ProcessSpectatorViewmodel(ViewModel vm) { }

	// RVA: 0x7524F0 Offset: 0x7518F0 VA: 0x1807524F0 Slot: 153
	public virtual void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	// RVA: 0x753420 Offset: 0x752820 VA: 0x180753420
	public bool get_hostile() { }

	// RVA: 0x7518F0 Offset: 0x750CF0 VA: 0x1807518F0
	public bool LightsOn() { }

	// RVA: 0x7518E0 Offset: 0x750CE0 VA: 0x1807518E0
	public bool IsDeployed() { }

	// RVA: 0x751820 Offset: 0x750C20 VA: 0x180751820
	public BasePlayer GetOwnerPlayer() { }

	// RVA: 0x751630 Offset: 0x750A30 VA: 0x180751630
	public Connection GetOwnerConnection() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 154
	public virtual bool CanBeUsedInWater() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 155
	public virtual bool BlocksGestures() { }

	// RVA: 0x751740 Offset: 0x750B40 VA: 0x180751740
	protected Item GetOwnerItem() { }

	// RVA: 0x751620 Offset: 0x750A20 VA: 0x180751620 Slot: 117
	public override Item GetItem() { }

	// RVA: 0x7516C0 Offset: 0x750AC0 VA: 0x1807516C0
	public ItemDefinition GetOwnerItemDefinition() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 156
	public virtual bool IsInstrument() { }

	// RVA: 0x751900 Offset: 0x750D00 VA: 0x180751900 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x753330 Offset: 0x752730 VA: 0x180753330
	public void .ctor() { }

	// RVA: 0x7532F0 Offset: 0x7526F0 VA: 0x1807532F0
	private static void .cctor() { }

}

public class HeldEntity.PunchEntry // TypeDefIndex: 8576
{	// Fields
	public Vector3 amount; // 0x10
	public float duration; // 0x1C
	public float startTime; // 0x20
	public Vector3 amountAdded; // 0x24

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class HeldEntity.HolsterInfo // TypeDefIndex: 8577
{	// Fields
	public HeldEntity.HolsterInfo.HolsterSlot slot; // 0x10
	public bool displayWhenHolstered; // 0x14
	public string holsterBone; // 0x18
	public Vector3 holsterOffset; // 0x20
	public Vector3 holsterRotationOffset; // 0x2C

	// Methods

	// RVA: 0x75B5E0 Offset: 0x75A9E0 VA: 0x18075B5E0
	public void .ctor() { }

}

public enum HeldEntity.HolsterInfo.HolsterSlot // TypeDefIndex: 8578
{	// Fields
	public int value__; // 0x0
	public const HeldEntity.HolsterInfo.HolsterSlot BACK = 0;
	public const HeldEntity.HolsterInfo.HolsterSlot RIGHT_THIGH = 1;
	public const HeldEntity.HolsterInfo.HolsterSlot LEFT_THIGH = 2;

}

public static class HeldEntity.HeldEntityFlags // TypeDefIndex: 8579
{	// Fields
	public const BaseEntity.Flags Deployed = 1024;
	public const BaseEntity.Flags LightsOn = 2048;

}

