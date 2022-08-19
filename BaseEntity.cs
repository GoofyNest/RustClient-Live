public class BaseEntity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6293
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector3 pos; // 0x14
	public Vector3 rot; // 0x20
	public int flags; // 0x2C
	public float time; // 0x30
	public ulong skinid; // 0x38

	// Methods

	// RVA: 0x1FF9110 Offset: 0x1FF8510 VA: 0x181FF9110
	public static void ResetToPool(BaseEntity instance) { }

	// RVA: 0x1FF91D0 Offset: 0x1FF85D0 VA: 0x181FF91D0
	public void ResetToPool() { }

	// RVA: 0x1FF8D60 Offset: 0x1FF8160 VA: 0x181FF8D60 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1FF7A40 Offset: 0x1FF6E40 VA: 0x181FF7A40
	public void CopyTo(BaseEntity instance) { }

	// RVA: 0x1FF7A90 Offset: 0x1FF6E90 VA: 0x181FF7A90
	public BaseEntity Copy() { }

	// RVA: 0x1FF87B0 Offset: 0x1FF7BB0 VA: 0x181FF87B0
	public static BaseEntity Deserialize(Stream stream) { }

	// RVA: 0x1FF7B30 Offset: 0x1FF6F30 VA: 0x181FF7B30
	public static BaseEntity DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1FF7ED0 Offset: 0x1FF72D0 VA: 0x181FF7ED0
	public static BaseEntity DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1FF8A30 Offset: 0x1FF7E30 VA: 0x181FF8A30
	public static BaseEntity Deserialize(byte[] buffer) { }

	// RVA: 0x1FF8EA0 Offset: 0x1FF82A0 VA: 0x181FF8EA0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1FF9BB0 Offset: 0x1FF8FB0 VA: 0x181FF9BB0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1FF9BD0 Offset: 0x1FF8FD0 VA: 0x181FF9BD0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BaseEntity previous) { }

	// RVA: 0x1FF90F0 Offset: 0x1FF84F0 VA: 0x181FF90F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1FF84A0 Offset: 0x1FF78A0 VA: 0x181FF84A0
	public static BaseEntity Deserialize(byte[] buffer, BaseEntity instance, bool isDelta = False) { }

	// RVA: 0x1FF8250 Offset: 0x1FF7650 VA: 0x181FF8250
	public static BaseEntity Deserialize(Stream stream, BaseEntity instance, bool isDelta) { }

	// RVA: 0x1FF7BB0 Offset: 0x1FF6FB0 VA: 0x181FF7BB0
	public static BaseEntity DeserializeLengthDelimited(Stream stream, BaseEntity instance, bool isDelta) { }

	// RVA: 0x1FF7F60 Offset: 0x1FF7360 VA: 0x181FF7F60
	public static BaseEntity DeserializeLength(Stream stream, int length, BaseEntity instance, bool isDelta) { }

	// RVA: 0x1FF9290 Offset: 0x1FF8690 VA: 0x181FF9290
	public static void SerializeDelta(Stream stream, BaseEntity instance, BaseEntity previous) { }

	// RVA: 0x1FF98F0 Offset: 0x1FF8CF0 VA: 0x181FF98F0
	public static void Serialize(Stream stream, BaseEntity instance) { }

	// RVA: 0x1FF9BA0 Offset: 0x1FF8FA0 VA: 0x181FF9BA0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1FF9BB0 Offset: 0x1FF8FB0 VA: 0x181FF9BB0
	public void ToProto(Stream stream) { }

	// RVA: 0x1FF97E0 Offset: 0x1FF8BE0 VA: 0x181FF97E0
	public static byte[] SerializeToBytes(BaseEntity instance) { }

	// RVA: 0x1FF9730 Offset: 0x1FF8B30 VA: 0x181FF9730
	public static void SerializeLengthDelimited(Stream stream, BaseEntity instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class BaseEntity : BaseNetworkable, IProvider, IPosLerpTarget, ILerpInfo, IPrefabPreProcess // TypeDefIndex: 8492
{	// Fields
	protected Ragdoll ragdoll; // 0x78
	internal PositionLerp positionLerp; // 0x80
	private List<Option> menuOptions; // 0x88
	private static Queue<BaseEntity> globalBroadcastQueue; // 0x0
	private static uint globalBroadcastProtocol; // 0x8
	private uint broadcastProtocol; // 0x90
	private List<EntityLink> links; // 0x98
	private bool linkedToNeighbours; // 0xA0
	private List<BaseEntity.ServerFileRequest> _pendingFileRequests; // 0xA8
	private Action updateParentingAction; // 0xB0
	private BaseEntity addedToParentEntity; // 0xB8
	public ItemSkin itemSkin; // 0xC0
	private EntityRef[] entitySlots; // 0xC8
	protected List<TriggerBase> triggers; // 0xD0
	protected bool isVisible; // 0xD8
	protected bool isAnimatorVisible; // 0xD9
	protected bool isShadowVisible; // 0xDA
	protected OccludeeSphere localOccludee; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <Weight>k__BackingField; // 0x100
	[HeaderAttribute] // RVA: 0x9F2A0 Offset: 0x9E6A0 VA: 0x18009F2A0
	public Bounds bounds; // 0x104
	public GameObjectRef impactEffect; // 0x120
	public bool enableSaving; // 0x128
	public bool syncPosition; // 0x129
	public Model model; // 0x130
	[InspectorFlagsAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public BaseEntity.Flags flags; // 0x138
	public uint parentBone; // 0x13C
	public ulong skinID; // 0x140
	private EntityComponentBase[] _components; // 0x148
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool HasBrain; // 0x150
	protected string _name; // 0x158
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ulong <OwnerID>k__BackingField; // 0x160

	// Properties
	public virtual bool HasMenuOptions { get; }
	public virtual float RealisticMass { get; }
	public virtual BaseEntity.TraitFlag Traits { get; }
	public float Weight { get; set; }
	public EntityComponentBase[] Components { get; }
	public virtual bool IsNpc { get; }
	public ulong OwnerID { get; set; }

	// Methods

	// RVA: 0x7FA660 Offset: 0x7F9A60 VA: 0x1807FA660 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x7F5BA0 Offset: 0x7F4FA0 VA: 0x1807F5BA0
	public void GetEntityMenu(BasePlayer player, List<Option> optionList) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 49
	public virtual void GetMenuOptions(List<Option> list) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 50
	public virtual bool get_HasMenuOptions() { }

	// RVA: 0x7F6250 Offset: 0x7F5650 VA: 0x1807F6250 Slot: 51
	public virtual void GetItemOptions(List<Option> options) { }

	// RVA: 0x7F6CA0 Offset: 0x7F60A0 VA: 0x1807F6CA0
	public BaseEntity.MovementModify GetMovementModify() { }

	// RVA: 0x7F5CE0 Offset: 0x7F50E0 VA: 0x1807F5CE0 Slot: 52
	public virtual float GetExtrapolationTime() { }

	// RVA: 0x7F60A0 Offset: 0x7F54A0 VA: 0x1807F60A0 Slot: 53
	public virtual float GetInterpolationDelay() { }

	// RVA: 0x7F6130 Offset: 0x7F5530 VA: 0x1807F6130 Slot: 54
	public virtual float GetInterpolationInertia() { }

	// RVA: 0x7F61C0 Offset: 0x7F55C0 VA: 0x1807F61C0 Slot: 55
	public virtual float GetInterpolationSmoothing() { }

	// RVA: 0x7F5640 Offset: 0x7F4A40 VA: 0x1807F5640 Slot: 56
	public virtual Quaternion GetAngularVelocityClient() { }

	// RVA: 0x7F64A0 Offset: 0x7F58A0 VA: 0x1807F64A0 Slot: 57
	public virtual Vector3 GetLocalVelocityClient() { }

	// RVA: 0x7F3B40 Offset: 0x7F2F40 VA: 0x1807F3B40 Slot: 43
	public void DrawInterpolationState(Interpolator.Segment<TransformSnapshot> segment, List<TransformSnapshot> entries) { }

	// RVA: 0x7F8FD0 Offset: 0x7F83D0 VA: 0x1807F8FD0 Slot: 44
	public void LerpIdleDisable() { }

	// RVA: 0x7F2DC0 Offset: 0x7F21C0 VA: 0x1807F2DC0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x7F2E70 Offset: 0x7F2270 VA: 0x1807F2E70 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0x7FA2F0 Offset: 0x7F96F0 VA: 0x1807FA2F0
	public void OnPositionalFromNetwork(Vector3 vPos, Vector3 vAng, float time) { }

	// RVA: 0x7FD6B0 Offset: 0x7FCAB0 VA: 0x1807FD6B0
	public void StartLerping(float time) { }

	// RVA: 0x7FD830 Offset: 0x7FCC30 VA: 0x1807FD830
	public void StopLerping() { }

	// RVA: 0x7FD2A0 Offset: 0x7FC6A0 VA: 0x1807FD2A0 Slot: 58
	public virtual bool ShouldLerp() { }

	// RVA: 0x7FCD90 Offset: 0x7FC190 VA: 0x1807FCD90 Slot: 59
	public virtual void SetNetworkPosition(Vector3 vPos) { }

	// RVA: 0x7FCF00 Offset: 0x7FC300 VA: 0x1807FCF00 Slot: 60
	public virtual void SetNetworkRotation(Quaternion qRot) { }

	// RVA: 0x7F3B20 Offset: 0x7F2F20 VA: 0x1807F3B20 Slot: 61
	public virtual void DoDestroyEffects(BaseNetworkable.DestroyMode mode, Message msg) { }

	// RVA: 0x7FD3A0 Offset: 0x7FC7A0 VA: 0x1807FD3A0 Slot: 62
	protected virtual void SpawnGibs() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0 Slot: 20
	internal override void DoNetworkDestroy() { }

	// RVA: 0x7FBA20 Offset: 0x7FAE20 VA: 0x1807FBA20 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x7FA030 Offset: 0x7F9430 VA: 0x1807FA030 Slot: 63
	public virtual void OnBecameRagdoll(Ragdoll rdoll) { }

	// RVA: 0x7F6620 Offset: 0x7F5A20 VA: 0x1807F6620 Slot: 64
	public virtual Info GetMenuInformation(GameObject primaryObject, BasePlayer player) { }

	// RVA: 0x7F79F0 Offset: 0x7F6DF0 VA: 0x1807F79F0 Slot: 65
	protected virtual bool HideMenuItems(BasePlayer player) { }

	// RVA: 0x7F6910 Offset: 0x7F5D10 VA: 0x1807F6910 Slot: 66
	public virtual List<Option> GetMenuItems(BasePlayer player) { }

	// RVA: 0x7FB810 Offset: 0x7FAC10 VA: 0x1807FB810 Slot: 67
	public virtual void OnUse(BasePlayer player) { }

	// RVA: 0x7FB5F0 Offset: 0x7FA9F0 VA: 0x1807FB5F0 Slot: 68
	public virtual void OnUseHeld(BasePlayer player) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 69
	public virtual void OnUseStopped(BasePlayer player) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 70
	public virtual void OnRendered() { }

	// RVA: 0x7F3870 Offset: 0x7F2C70 VA: 0x1807F3870 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x7F5D70 Offset: 0x7F5170 VA: 0x1807F5D70 Slot: 71
	internal virtual Transform GetEyeTransform() { }

	// RVA: 0x7F9F20 Offset: 0x7F9320 VA: 0x1807F9F20 Slot: 72
	public virtual bool NeedsCrosshair() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 73
	public virtual bool AlwaysShowCrosshair() { }

	// RVA: 0x7FD1F0 Offset: 0x7FC5F0 VA: 0x1807FD1F0 Slot: 17
	public override bool ShouldDestroyWithGroup() { }

	// RVA: 0x7F3460 Offset: 0x7F2860 VA: 0x1807F3460
	public void DetachEffects() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 74
	public virtual void OnVoiceData(byte[] data) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 75
	public virtual void LookingAtTick() { }

	// RVA: 0x73C880 Offset: 0x73BC80 VA: 0x18073C880 Slot: 76
	public virtual float get_RealisticMass() { }

	// RVA: 0x7FA0E0 Offset: 0x7F94E0 VA: 0x1807FA0E0 Slot: 77
	public virtual void OnCollision(Collision collision, BaseEntity hitEntity) { }

	// RVA: 0x7FBB10 Offset: 0x7FAF10 VA: 0x1807FBB10
	protected void ReceiveCollisionMessages(bool b) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 78
	public virtual void DebugClient(int rep, float time) { }

	// RVA: 0x7FA130 Offset: 0x7F9530 VA: 0x1807FA130
	public void OnDebugStart() { }

	// RVA: 0x7F33A0 Offset: 0x7F27A0 VA: 0x1807F33A0
	protected void DebugText(Vector3 pos, string str, Color color, float time) { }

	// RVA: 0x7F79B0 Offset: 0x7F6DB0 VA: 0x1807F79B0 Slot: 79
	public bool HasFlag(BaseEntity.Flags f) { }

	// RVA: 0x7FB980 Offset: 0x7FAD80 VA: 0x1807FB980
	public bool ParentHasFlag(BaseEntity.Flags f) { }

	// RVA: 0x7FCBC0 Offset: 0x7FBFC0 VA: 0x1807FCBC0
	public void SetFlag(BaseEntity.Flags f, bool b, bool recursive = False, bool networkupdate = True) { }

	// RVA: 0x7F8000 Offset: 0x7F7400 VA: 0x1807F8000
	public bool IsOn() { }

	// RVA: 0x7F8010 Offset: 0x7F7410 VA: 0x1807F8010
	public bool IsOpen() { }

	// RVA: 0x7F7FF0 Offset: 0x7F73F0 VA: 0x1807F7FF0
	public bool IsOnFire() { }

	// RVA: 0x7F7D40 Offset: 0x7F7140 VA: 0x1807F7D40
	public bool IsLocked() { }

	// RVA: 0x7F7B50 Offset: 0x7F6F50 VA: 0x1807F7B50 Slot: 4
	public override bool IsDebugging() { }

	// RVA: 0x7F7B60 Offset: 0x7F6F60 VA: 0x1807F7B60
	public bool IsDisabled() { }

	// RVA: 0x7F7B40 Offset: 0x7F6F40 VA: 0x1807F7B40
	public bool IsBroken() { }

	// RVA: 0x7F79F0 Offset: 0x7F6DF0 VA: 0x1807F79F0
	public bool IsBusy() { }

	// RVA: 0x7F65D0 Offset: 0x7F59D0 VA: 0x1807F65D0 Slot: 5
	public override string GetLogColor() { }

	// RVA: 0x7FA1F0 Offset: 0x7F95F0 VA: 0x1807FA1F0 Slot: 80
	public virtual void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x7F7E40 Offset: 0x7F7240 VA: 0x1807F7E40
	public bool IsOccupied(Socket_Base socket) { }

	// RVA: 0x7F7D50 Offset: 0x7F7150 VA: 0x1807F7D50
	public bool IsOccupied(string socketName) { }

	// RVA: 0x7F4800 Offset: 0x7F3C00 VA: 0x1807F4800
	public EntityLink FindLink(Socket_Base socket) { }

	// RVA: 0x7F4900 Offset: 0x7F3D00 VA: 0x1807F4900
	public EntityLink FindLink(string socketName) { }

	// RVA: 0x7F49E0 Offset: 0x7F3DE0 VA: 0x1807F49E0
	public EntityLink FindLink(string[] socketNames) { }

	// RVA: -1 Offset: -1
	public T FindLinkedEntity<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E3830 Offset: 0x5E2C30 VA: 0x1805E3830
	|-BaseEntity.FindLinkedEntity<object>
	*/

	// RVA: -1 Offset: -1
	public void EntityLinkMessage<T>(Action<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1537C00 Offset: 0x1537000 VA: 0x181537C00
	|-BaseEntity.EntityLinkMessage<object>
	*/

	// RVA: -1 Offset: -1
	public void EntityLinkBroadcast<T, S>(Action<T> action, Func<S, bool> canTraverseSocket) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15372A0 Offset: 0x15366A0 VA: 0x1815372A0
	|-BaseEntity.EntityLinkBroadcast<object, object>
	*/

	// RVA: -1 Offset: -1
	public void EntityLinkBroadcast<T>(Action<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15377C0 Offset: 0x1536BC0 VA: 0x1815377C0
	|-BaseEntity.EntityLinkBroadcast<object>
	*/

	// RVA: 0x7F42E0 Offset: 0x7F36E0 VA: 0x1807F42E0
	public void EntityLinkBroadcast() { }

	// RVA: 0x7FBBA0 Offset: 0x7FAFA0 VA: 0x1807FBBA0
	public bool ReceivedEntityLinkBroadcast() { }

	// RVA: 0x7F5B60 Offset: 0x7F4F60 VA: 0x1807F5B60
	public List<EntityLink> GetEntityLinks(bool linkToNeighbours = True) { }

	// RVA: 0x7F9000 Offset: 0x7F8400 VA: 0x1807F9000
	private void LinkToEntity(BaseEntity other) { }

	// RVA: 0x7F9260 Offset: 0x7F8660 VA: 0x1807F9260
	private void LinkToNeighbours() { }

	// RVA: 0x7F7A00 Offset: 0x7F6E00 VA: 0x1807F7A00
	private void InitEntityLinks() { }

	// RVA: 0x7F5560 Offset: 0x7F4960 VA: 0x1807F5560
	private void FreeEntityLinks() { }

	// RVA: 0x7FBC10 Offset: 0x7FB010 VA: 0x1807FBC10
	public void RefreshEntityLinks() { }

	[ObsoleteAttribute] // RVA: 0x9F600 Offset: 0x9EA00 VA: 0x18009F600
	// RVA: 0x7FC490 Offset: 0x7FB890 VA: 0x1807FC490
	public void RequestFileFromServer(uint crc, FileStorage.Type type, string responseFunction, uint part = 0) { }

	// RVA: 0x7FC150 Offset: 0x7FB550 VA: 0x1807FC150
	public void RequestFileFromServer(IServerFileReceiver receiver, FileStorage.Type type, uint crc, uint part = 0, bool respondIfNotFound = False) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7F2AD0 Offset: 0x7F1ED0 VA: 0x1807F2AD0
	public void CL_ReceiveFileRequest(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7F3070 Offset: 0x7F2470 VA: 0x1807F3070
	private void CompletePendingFileRequests(FileStorage.Type type, uint crc, uint part, byte[] data) { }

	// RVA: 0x7FD9F0 Offset: 0x7FCDF0 VA: 0x1807FD9F0
	public void UpdateChildren() { }

	// RVA: 0x7FE760 Offset: 0x7FDB60 VA: 0x1807FE760
	public void UpdateParenting() { }

	// RVA: 0x7FE0E0 Offset: 0x7FD4E0 VA: 0x1807FE0E0
	public void UpdateParenting(bool worldPositionStays) { }

	// RVA: 0x7FCFD0 Offset: 0x7FC3D0 VA: 0x1807FCFD0
	private void SetParentTransform(Transform parent, bool worldPositionStays = True) { }

	// RVA: 0x7FDD60 Offset: 0x7FD160 VA: 0x1807FDD60
	protected void UpdateDisableState() { }

	// RVA: 0x7F7810 Offset: 0x7F6C10 VA: 0x1807F7810
	private bool HasClientTransformOffset() { }

	// RVA: 0x7FBF20 Offset: 0x7FB320 VA: 0x1807FBF20
	private void RemoveClientTransformOffset() { }

	// RVA: 0x7F2490 Offset: 0x7F1890 VA: 0x1807F2490
	private void AddClientTransformOffset() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 81
	public virtual void OnParentChangingClient(Transform oldParent, Transform newParent) { }

	// RVA: 0x7F5AF0 Offset: 0x7F4EF0 VA: 0x1807F5AF0 Slot: 82
	public virtual BuildingPrivlidge GetBuildingPrivilege() { }

	// RVA: 0x7F5800 Offset: 0x7F4C00 VA: 0x1807F5800
	public BuildingPrivlidge GetBuildingPrivilege(OBB obb) { }

	// RVA: -1 Offset: -1
	public void ServerRPC<T1, T2, T3, T4, T5>(SendMethod sendMethod, string funcName, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1539360 Offset: 0x1538760 VA: 0x181539360
	|-BaseEntity.ServerRPC<byte, byte, uint, uint, object>
	|
	|-RVA: 0x1539870 Offset: 0x1538C70 VA: 0x181539870
	|-BaseEntity.ServerRPC<int, int, int, int, byte>
	|
	|-RVA: 0x15395F0 Offset: 0x15389F0 VA: 0x1815395F0
	|-BaseEntity.ServerRPC<int, Color, Color, Color, Color>
	|
	|-RVA: 0x153B600 Offset: 0x153AA00 VA: 0x18153B600
	|-BaseEntity.ServerRPC<object, object, object, object, object>
	|
	|-RVA: 0x153C220 Offset: 0x153B620 VA: 0x18153C220
	|-BaseEntity.ServerRPC<uint, byte, uint, uint, bool>
	|
	|-RVA: 0x153CA50 Offset: 0x153BE50 VA: 0x18153CA50
	|-BaseEntity.ServerRPC<uint, int, uint, int, int>
	*/

	// RVA: -1 Offset: -1
	public void ServerRPC<T1, T2, T3, T4>(SendMethod sendMethod, string funcName, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1539AB0 Offset: 0x1538EB0 VA: 0x181539AB0
	|-BaseEntity.ServerRPC<int, int, int, int>
	|
	|-RVA: 0x1539CD0 Offset: 0x15390D0 VA: 0x181539CD0
	|-BaseEntity.ServerRPC<int, int, int, float>
	|
	|-RVA: 0x153A2D0 Offset: 0x15396D0 VA: 0x18153A2D0
	|-BaseEntity.ServerRPC<int, int, object, bool>
	|
	|-RVA: 0x153AAB0 Offset: 0x1539EB0 VA: 0x18153AAB0
	|-BaseEntity.ServerRPC<int, uint, object, bool>
	|
	|-RVA: 0x153B3E0 Offset: 0x153A7E0 VA: 0x18153B3E0
	|-BaseEntity.ServerRPC<object, object, int, object>
	|
	|-RVA: 0x153B850 Offset: 0x153AC50 VA: 0x18153B850
	|-BaseEntity.ServerRPC<object, object, object, object>
	|
	|-RVA: 0x153C410 Offset: 0x153B810 VA: 0x18153C410
	|-BaseEntity.ServerRPC<uint, byte, uint, uint>
	|
	|-RVA: 0x153D550 Offset: 0x153C950 VA: 0x18153D550
	|-BaseEntity.ServerRPC<uint, uint, sbyte, int>
	|
	|-RVA: 0x153DC20 Offset: 0x153D020 VA: 0x18153DC20
	|-BaseEntity.ServerRPC<ulong, uint, uint, object>
	|
	|-RVA: 0x153E2C0 Offset: 0x153D6C0 VA: 0x18153E2C0
	|-BaseEntity.ServerRPC<Vector3, Vector3, int, int>
	|
	|-RVA: 0x153E730 Offset: 0x153DB30 VA: 0x18153E730
	|-BaseEntity.ServerRPC<Vector3, Vector3, Vector3, int>
	*/

	// RVA: -1 Offset: -1
	public void ServerRPC<T1, T2, T3>(SendMethod sendMethod, string funcName, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1538F70 Offset: 0x1538370 VA: 0x181538F70
	|-BaseEntity.ServerRPC<bool, Vector3, uint>
	|
	|-RVA: 0x1539EA0 Offset: 0x15392A0 VA: 0x181539EA0
	|-BaseEntity.ServerRPC<int, int, int>
	|
	|-RVA: 0x153A100 Offset: 0x1539500 VA: 0x18153A100
	|-BaseEntity.ServerRPC<int, int, Ray>
	|
	|-RVA: 0x153A710 Offset: 0x1539B10 VA: 0x18153A710
	|-BaseEntity.ServerRPC<int, object, int>
	|
	|-RVA: 0x153BA80 Offset: 0x153AE80 VA: 0x18153BA80
	|-BaseEntity.ServerRPC<object, object, object>
	|
	|-RVA: 0x153C630 Offset: 0x153BA30 VA: 0x18153C630
	|-BaseEntity.ServerRPC<uint, int, bool>
	|
	|-RVA: 0x153C830 Offset: 0x153BC30 VA: 0x18153C830
	|-BaseEntity.ServerRPC<uint, int, int>
	|
	|-RVA: 0x153CDE0 Offset: 0x153C1E0 VA: 0x18153CDE0
	|-BaseEntity.ServerRPC<uint, object, int>
	|
	|-RVA: 0x153CFE0 Offset: 0x153C3E0 VA: 0x18153CFE0
	|-BaseEntity.ServerRPC<uint, object, object>
	|
	|-RVA: 0x153D1A0 Offset: 0x153C5A0 VA: 0x18153D1A0
	|-BaseEntity.ServerRPC<uint, object, ulong>
	|
	|-RVA: 0x153E040 Offset: 0x153D440 VA: 0x18153E040
	|-BaseEntity.ServerRPC<Vector3, Vector3, bool>
	|
	|-RVA: 0x153E540 Offset: 0x153D940 VA: 0x18153E540
	|-BaseEntity.ServerRPC<Vector3, Vector3, float>
	*/

	// RVA: -1 Offset: -1
	public void ServerRPC<T1, T2>(SendMethod sendMethod, string funcName, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x153A530 Offset: 0x1539930 VA: 0x18153A530
	|-BaseEntity.ServerRPC<int, int>
	|
	|-RVA: 0x153A910 Offset: 0x1539D10 VA: 0x18153A910
	|-BaseEntity.ServerRPC<int, object>
	|
	|-RVA: 0x153B200 Offset: 0x153A600 VA: 0x18153B200
	|-BaseEntity.ServerRPC<object, bool>
	|
	|-RVA: 0x153BC80 Offset: 0x153B080 VA: 0x18153BC80
	|-BaseEntity.ServerRPC<object, object>
	|
	|-RVA: 0x153CC40 Offset: 0x153C040 VA: 0x18153CC40
	|-BaseEntity.ServerRPC<uint, int>
	|
	|-RVA: 0x153D360 Offset: 0x153C760 VA: 0x18153D360
	|-BaseEntity.ServerRPC<uint, object>
	|
	|-RVA: 0x153D8A0 Offset: 0x153CCA0 VA: 0x18153D8A0
	|-BaseEntity.ServerRPC<ulong, int>
	|
	|-RVA: 0x153DA80 Offset: 0x153CE80 VA: 0x18153DA80
	|-BaseEntity.ServerRPC<ulong, object>
	|
	|-RVA: 0x153AE80 Offset: 0x153A280 VA: 0x18153AE80
	|-BaseEntity.ServerRPC<Ray, int>
	|
	|-RVA: 0x153B040 Offset: 0x153A440 VA: 0x18153B040
	|-BaseEntity.ServerRPC<Ray, uint>
	|
	|-RVA: 0x153EA60 Offset: 0x153DE60 VA: 0x18153EA60
	|-BaseEntity.ServerRPC<Vector3, Vector3>
	*/

	// RVA: -1 Offset: -1
	public void ServerRPC<T1>(SendMethod sendMethod, string funcName, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1539150 Offset: 0x1538550 VA: 0x181539150
	|-BaseEntity.ServerRPC<bool>
	|
	|-RVA: 0x153AC80 Offset: 0x153A080 VA: 0x18153AC80
	|-BaseEntity.ServerRPC<int>
	|
	|-RVA: 0x153BE90 Offset: 0x153B290 VA: 0x18153BE90
	|-BaseEntity.ServerRPC<object>
	|
	|-RVA: 0x153C010 Offset: 0x153B410 VA: 0x18153C010
	|-BaseEntity.ServerRPC<float>
	|
	|-RVA: 0x153D720 Offset: 0x153CB20 VA: 0x18153D720
	|-BaseEntity.ServerRPC<uint>
	|
	|-RVA: 0x153DE40 Offset: 0x153D240 VA: 0x18153DE40
	|-BaseEntity.ServerRPC<ulong>
	|
	|-RVA: 0x153EC70 Offset: 0x153E070 VA: 0x18153EC70
	|-BaseEntity.ServerRPC<Vector3>
	*/

	// RVA: 0x7FC880 Offset: 0x7FBC80 VA: 0x1807FC880
	public void ServerRPC(SendMethod sendMethod, string funcName) { }

	// RVA: -1 Offset: -1
	public void ServerRPC<T1, T2, T3, T4, T5>(string funcName, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1539300 Offset: 0x1538700 VA: 0x181539300
	|-BaseEntity.ServerRPC<byte, byte, uint, uint, byte[]>
	|-BaseEntity.ServerRPC<byte, byte, uint, uint, object>
	|
	|-RVA: 0x1539810 Offset: 0x1538C10 VA: 0x181539810
	|-BaseEntity.ServerRPC<int, int, int, int, byte>
	|
	|-RVA: 0x1539550 Offset: 0x1538950 VA: 0x181539550
	|-BaseEntity.ServerRPC<int, Color, Color, Color, Color>
	|
	|-RVA: 0x153B7F0 Offset: 0x153ABF0 VA: 0x18153B7F0
	|-BaseEntity.ServerRPC<object, object, object, object, object>
	|-BaseEntity.ServerRPC<string, string, string, string, string>
	|
	|-RVA: 0x153C1C0 Offset: 0x153B5C0 VA: 0x18153C1C0
	|-BaseEntity.ServerRPC<uint, byte, uint, uint, bool>
	|
	|-RVA: 0x153C9F0 Offset: 0x153BDF0 VA: 0x18153C9F0
	|-BaseEntity.ServerRPC<uint, int, uint, int, int>
	*/

	// RVA: -1 Offset: -1
	public void ServerRPC<T1, T2, T3, T4>(string funcName, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x153A4A0 Offset: 0x15398A0 VA: 0x18153A4A0
	|-BaseEntity.ServerRPC<int, int, byte[], bool>
	|-BaseEntity.ServerRPC<int, int, object, bool>
	|-BaseEntity.ServerRPC<int, uint, byte[], bool>
	|-BaseEntity.ServerRPC<int, uint, object, bool>
	|
	|-RVA: 0x1539A60 Offset: 0x1538E60 VA: 0x181539A60
	|-BaseEntity.ServerRPC<int, int, int, int>
	|
	|-RVA: 0x1539C80 Offset: 0x1539080 VA: 0x181539C80
	|-BaseEntity.ServerRPC<int, int, int, float>
	|
	|-RVA: 0x153B5B0 Offset: 0x153A9B0 VA: 0x18153B5B0
	|-BaseEntity.ServerRPC<object, object, int, object>
	|-BaseEntity.ServerRPC<string, string, int, string>
	|
	|-RVA: 0x153BA30 Offset: 0x153AE30 VA: 0x18153BA30
	|-BaseEntity.ServerRPC<object, object, object, object>
	|
	|-RVA: 0x153C5E0 Offset: 0x153B9E0 VA: 0x18153C5E0
	|-BaseEntity.ServerRPC<uint, byte, uint, uint>
	|
	|-RVA: 0x153D500 Offset: 0x153C900 VA: 0x18153D500
	|-BaseEntity.ServerRPC<uint, uint, sbyte, int>
	|
	|-RVA: 0x153DDF0 Offset: 0x153D1F0 VA: 0x18153DDF0
	|-BaseEntity.ServerRPC<ulong, uint, uint, byte[]>
	|-BaseEntity.ServerRPC<ulong, uint, uint, object>
	|
	|-RVA: 0x153E230 Offset: 0x153D630 VA: 0x18153E230
	|-BaseEntity.ServerRPC<Vector3, Vector3, int, int>
	|
	|-RVA: 0x153E950 Offset: 0x153DD50 VA: 0x18153E950
	|-BaseEntity.ServerRPC<Vector3, Vector3, Vector3, int>
	*/

	// RVA: -1 Offset: -1
	public void ServerRPC<T1, T2, T3>(string funcName, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1538F10 Offset: 0x1538310 VA: 0x181538F10
	|-BaseEntity.ServerRPC<bool, Vector3, uint>
	|
	|-RVA: 0x153A6D0 Offset: 0x1539AD0 VA: 0x18153A6D0
	|-BaseEntity.ServerRPC<int, byte[], int>
	|-BaseEntity.ServerRPC<int, object, int>
	|-BaseEntity.ServerRPC<uint, object, int>
	|
	|-RVA: 0x153A060 Offset: 0x1539460 VA: 0x18153A060
	|-BaseEntity.ServerRPC<int, int, int>
	|-BaseEntity.ServerRPC<uint, int, int>
	|
	|-RVA: 0x153A0A0 Offset: 0x15394A0 VA: 0x18153A0A0
	|-BaseEntity.ServerRPC<int, int, Ray>
	|
	|-RVA: 0x153BC40 Offset: 0x153B040 VA: 0x18153BC40
	|-BaseEntity.ServerRPC<object, object, object>
	|
	|-RVA: 0x153CFA0 Offset: 0x153C3A0 VA: 0x18153CFA0
	|-BaseEntity.ServerRPC<uint, byte[], ulong>
	|-BaseEntity.ServerRPC<uint, object, object>
	|-BaseEntity.ServerRPC<uint, object, ulong>
	|
	|-RVA: 0x153C7F0 Offset: 0x153BBF0 VA: 0x18153C7F0
	|-BaseEntity.ServerRPC<uint, int, bool>
	|
	|-RVA: 0x153DFC0 Offset: 0x153D3C0 VA: 0x18153DFC0
	|-BaseEntity.ServerRPC<Vector3, Vector3, bool>
	|
	|-RVA: 0x153E4C0 Offset: 0x153D8C0 VA: 0x18153E4C0
	|-BaseEntity.ServerRPC<Vector3, Vector3, float>
	*/

	// RVA: -1 Offset: -1
	public void ServerRPC<T1, T2>(string funcName, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x153A8D0 Offset: 0x1539CD0 VA: 0x18153A8D0
	|-BaseEntity.ServerRPC<int, SprayList>
	|-BaseEntity.ServerRPC<int, byte[]>
	|-BaseEntity.ServerRPC<int, object>
	|-BaseEntity.ServerRPC<int, string>
	|-BaseEntity.ServerRPC<uint, byte[]>
	|-BaseEntity.ServerRPC<uint, object>
	|-BaseEntity.ServerRPC<uint, string>
	|
	|-RVA: 0x153A4F0 Offset: 0x15398F0 VA: 0x18153A4F0
	|-BaseEntity.ServerRPC<int, int>
	|-BaseEntity.ServerRPC<uint, int>
	|
	|-RVA: 0x153B3A0 Offset: 0x153A7A0 VA: 0x18153B3A0
	|-BaseEntity.ServerRPC<object, bool>
	|-BaseEntity.ServerRPC<string, bool>
	|
	|-RVA: 0x153BE20 Offset: 0x153B220 VA: 0x18153BE20
	|-BaseEntity.ServerRPC<object, object>
	|-BaseEntity.ServerRPC<string, string>
	|-BaseEntity.ServerRPC<ulong, object>
	|-BaseEntity.ServerRPC<ulong, string>
	|
	|-RVA: 0x153DA40 Offset: 0x153CE40 VA: 0x18153DA40
	|-BaseEntity.ServerRPC<ulong, int>
	|
	|-RVA: 0x153AE30 Offset: 0x153A230 VA: 0x18153AE30
	|-BaseEntity.ServerRPC<Ray, int>
	|-BaseEntity.ServerRPC<Ray, uint>
	|
	|-RVA: 0x153E9F0 Offset: 0x153DDF0 VA: 0x18153E9F0
	|-BaseEntity.ServerRPC<Vector3, Vector3>
	*/

	// RVA: -1 Offset: -1
	public void ServerRPC<T1>(string funcName, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x153BE60 Offset: 0x153B260 VA: 0x18153BE60
	|-BaseEntity.ServerRPC<AIDesign>
	|-BaseEntity.ServerRPC<ArcadeGame>
	|-BaseEntity.ServerRPC<CreateBuilding>
	|-BaseEntity.ServerRPC<MapNote>
	|-BaseEntity.ServerRPC<PatternFirework.Design>
	|-BaseEntity.ServerRPC<PlayerAttack>
	|-BaseEntity.ServerRPC<PlayerProjectileAttack>
	|-BaseEntity.ServerRPC<PlayerProjectileRicochet>
	|-BaseEntity.ServerRPC<PlayerProjectileUpdate>
	|-BaseEntity.ServerRPC<ProjectileShoot>
	|-BaseEntity.ServerRPC<object>
	|-BaseEntity.ServerRPC<string>
	|-BaseEntity.ServerRPC<ulong>
	|
	|-RVA: 0x15392D0 Offset: 0x15386D0 VA: 0x1815392D0
	|-BaseEntity.ServerRPC<bool>
	|
	|-RVA: 0x153AE00 Offset: 0x153A200 VA: 0x18153AE00
	|-BaseEntity.ServerRPC<int>
	|-BaseEntity.ServerRPC<uint>
	|
	|-RVA: 0x153C190 Offset: 0x153B590 VA: 0x18153C190
	|-BaseEntity.ServerRPC<float>
	|
	|-RVA: 0x153EC30 Offset: 0x153E030 VA: 0x18153EC30
	|-BaseEntity.ServerRPC<Vector3>
	*/

	// RVA: 0x7FCBB0 Offset: 0x7FBFB0 VA: 0x1807FCBB0
	public void ServerRPC(string funcName) { }

	// RVA: 0x7FC6D0 Offset: 0x7FBAD0 VA: 0x1807FC6D0
	private bool ServerRPCStart(string funcName) { }

	// RVA: -1 Offset: -1
	private void ServerRPCWrite<T>(T arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1538BE0 Offset: 0x1537FE0 VA: 0x181538BE0
	|-BaseEntity.ServerRPCWrite<bool>
	|-BaseEntity.ServerRPCWrite<byte>
	|-BaseEntity.ServerRPCWrite<sbyte>
	|
	|-RVA: 0x1538CC0 Offset: 0x15380C0 VA: 0x181538CC0
	|-BaseEntity.ServerRPCWrite<int>
	|-BaseEntity.ServerRPCWrite<uint>
	|
	|-RVA: 0x1538DB0 Offset: 0x15381B0 VA: 0x181538DB0
	|-BaseEntity.ServerRPCWrite<object>
	|-BaseEntity.ServerRPCWrite<ulong>
	|
	|-RVA: 0x1538E20 Offset: 0x1538220 VA: 0x181538E20
	|-BaseEntity.ServerRPCWrite<float>
	|
	|-RVA: 0x1538C50 Offset: 0x1538050 VA: 0x181538C50
	|-BaseEntity.ServerRPCWrite<Color>
	|
	|-RVA: 0x1538D30 Offset: 0x1538130 VA: 0x181538D30
	|-BaseEntity.ServerRPCWrite<Ray>
	|
	|-RVA: 0x1538E90 Offset: 0x1538290 VA: 0x181538E90
	|-BaseEntity.ServerRPCWrite<Vector3>
	*/

	// RVA: 0x7FC660 Offset: 0x7FBA60 VA: 0x1807FC660
	private void ServerRPCSend(SendInfo sendInfo) { }

	// RVA: -1 Offset: -1
	public void ServerRPCList<T1>(string funcName, List<T1> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1538510 Offset: 0x1537910 VA: 0x181538510
	|-BaseEntity.ServerRPCList<object>
	*/

	// RVA: -1 Offset: -1
	public void ServerRPCList<T1, T2, T3, T4, T5>(string funcName, List<T1> list, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1538180 Offset: 0x1537580 VA: 0x181538180
	|-BaseEntity.ServerRPCList<object, object, object, object, object>
	*/

	// RVA: -1 Offset: -1
	public void ServerRPCList<T1, T2, T3, T4, T5, T6>(string funcName, List<T1> list, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1537DE0 Offset: 0x15371E0 VA: 0x181537DE0
	|-BaseEntity.ServerRPCList<object, object, object, object, object, object>
	|
	|-RVA: 0x1538830 Offset: 0x1537C30 VA: 0x181538830
	|-BaseEntity.ServerRPCList<Vector3, uint, int, uint, int, int>
	*/

	// RVA: 0x7F27E0 Offset: 0x7F1BE0 VA: 0x1807F27E0
	public void CL_RPCMessage(uint nameID, ulong sourceConnection, Message message) { }

	// RVA: 0x7FC5B0 Offset: 0x7FB9B0 VA: 0x1807FC5B0
	public void SendSignalBroadcast(BaseEntity.Signal signal, string arg = "") { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7FD2C0 Offset: 0x7FC6C0 VA: 0x1807FD2C0
	private void SignalFromServerEx(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7FD350 Offset: 0x7FC750 VA: 0x1807FD350
	private void SignalFromServer(BaseEntity.RPCMessage msg) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 83
	public virtual void OnSignal(BaseEntity.Signal signal, string arg) { }

	// RVA: 0x7FB260 Offset: 0x7FA660 VA: 0x1807FB260
	private void OnSkinChanged(ulong oldSkinID, ulong newSkinID) { }

	// RVA: 0x7FB5D0 Offset: 0x7FA9D0 VA: 0x1807FB5D0
	private void OnSkinRefreshStart() { }

	// RVA: 0x7FB5B0 Offset: 0x7FA9B0 VA: 0x1807FB5B0
	private void OnSkinRefreshEnd() { }

	// RVA: 0x7FBA40 Offset: 0x7FAE40 VA: 0x1807FBA40 Slot: 84
	public virtual void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x7F7730 Offset: 0x7F6B30 VA: 0x1807F7730
	public bool HasAnySlot() { }

	// RVA: 0x7F72B0 Offset: 0x7F66B0 VA: 0x1807F72B0
	public BaseEntity GetSlot(BaseEntity.Slot slot) { }

	// RVA: 0x7F7170 Offset: 0x7F6570 VA: 0x1807F7170
	public string GetSlotAnchorName(BaseEntity.Slot slot) { }

	// RVA: 0x7F7200 Offset: 0x7F6600 VA: 0x1807F7200
	public Transform GetSlotAnchor(BaseEntity.Slot slot) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 85
	public virtual bool HasSlot(BaseEntity.Slot slot) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 86
	public virtual BaseEntity.TraitFlag get_Traits() { }

	// RVA: 0x7F79C0 Offset: 0x7F6DC0 VA: 0x1807F79C0
	public bool HasTrait(BaseEntity.TraitFlag f) { }

	// RVA: 0x7F77E0 Offset: 0x7F6BE0 VA: 0x1807F77E0
	public bool HasAnyTrait(BaseEntity.TraitFlag f) { }

	// RVA: 0x7F4230 Offset: 0x7F3630 VA: 0x1807F4230 Slot: 87
	public virtual bool EnterTrigger(TriggerBase trigger) { }

	// RVA: 0x7F8F30 Offset: 0x7F8330 VA: 0x1807F8F30 Slot: 88
	public virtual void LeaveTrigger(TriggerBase trigger) { }

	// RVA: 0x7FBF80 Offset: 0x7FB380 VA: 0x1807FBF80
	public void RemoveFromTriggers() { }

	// RVA: -1 Offset: -1
	public T FindTrigger<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E39F0 Offset: 0x5E2DF0 VA: 0x1805E39F0
	|-BaseEntity.FindTrigger<object>
	|-BaseEntity.FindTrigger<TriggerLadder>
	|-BaseEntity.FindTrigger<TriggerNoSpray>
	*/

	// RVA: -1 Offset: -1
	public bool FindTrigger<T>(out T result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1257230 Offset: 0x1256630 VA: 0x181257230
	|-BaseEntity.FindTrigger<object>
	*/

	// RVA: 0x7F4AE0 Offset: 0x7F3EE0 VA: 0x1807F4AE0
	private void ForceUpdateTriggersAction() { }

	// RVA: 0x7F4B10 Offset: 0x7F3F10 VA: 0x1807F4B10
	public void ForceUpdateTriggers(bool enter = True, bool exit = True, bool invoke = True) { }

	// RVA: 0x7F9F00 Offset: 0x7F9300 VA: 0x1807F9F00 Slot: 89
	public virtual void MakeVisible() { }

	// RVA: 0x7FDBE0 Offset: 0x7FCFE0 VA: 0x1807FDBE0 Slot: 90
	protected virtual void UpdateCullingSpheres() { }

	// RVA: 0x7FBCF0 Offset: 0x7FB0F0 VA: 0x1807FBCF0 Slot: 91
	protected virtual void RegisterForCulling() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 92
	protected virtual void OnVisibilityChanged(bool visible) { }

	// RVA: 0x7FD970 Offset: 0x7FCD70 VA: 0x1807FD970 Slot: 93
	protected virtual void UnregisterFromCulling() { }

	// RVA: 0x7FDB10 Offset: 0x7FCF10 VA: 0x1807FDB10 Slot: 94
	protected virtual void UpdateCullingBounds() { }

	// RVA: 0x7F2DA0 Offset: 0x7F21A0 VA: 0x1807F2DA0 Slot: 95
	protected virtual bool CheckVisibility() { }

	// RVA: 0x7F2C80 Offset: 0x7F2080 VA: 0x1807F2C80
	protected float CalcEntityVisUpdateRate() { }

	// RVA: 0x7F32D0 Offset: 0x7F26D0 VA: 0x1807F32D0 Slot: 96
	protected virtual void DebugDrawCullingBounds() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7FEF50 Offset: 0x7FE350 VA: 0x1807FEF50
	public float get_Weight() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7FEF70 Offset: 0x7FE370 VA: 0x1807FEF70
	protected void set_Weight(float value) { }

	// RVA: 0x7FEED0 Offset: 0x7FE2D0 VA: 0x1807FEED0
	public EntityComponentBase[] get_Components() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 97
	public virtual BasePlayer ToPlayer() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 98
	public virtual bool get_IsNpc() { }

	// RVA: 0x7EC160 Offset: 0x7EB560 VA: 0x1807EC160 Slot: 28
	public override void InitShared() { }

	// RVA: 0x7EF080 Offset: 0x7EE480 VA: 0x1807EF080 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x7FC540 Offset: 0x7FB940 VA: 0x1807FC540 Slot: 27
	public override void ResetState() { }

	// RVA: 0x581F40 Offset: 0x581340 VA: 0x180581F40 Slot: 99
	public virtual float InheritedVelocityScale() { }

	// RVA: 0x7F5EF0 Offset: 0x7F52F0 VA: 0x1807F5EF0 Slot: 100
	public virtual Vector3 GetInheritedProjectileVelocity() { }

	// RVA: 0x7F6070 Offset: 0x7F5470 VA: 0x1807F6070 Slot: 101
	public virtual Vector3 GetInheritedThrowVelocity() { }

	// RVA: 0x7F5E10 Offset: 0x7F5210 VA: 0x1807F5E10 Slot: 102
	public virtual Vector3 GetInheritedDropVelocity() { }

	// RVA: 0x7F6EB0 Offset: 0x7F62B0 VA: 0x1807F6EB0
	public Vector3 GetParentVelocity() { }

	// RVA: 0x7F7310 Offset: 0x7F6710 VA: 0x1807F7310
	public Vector3 GetWorldVelocity() { }

	// RVA: 0x7F6530 Offset: 0x7F5930 VA: 0x1807F6530
	public Vector3 GetLocalVelocity() { }

	// RVA: 0x7F56D0 Offset: 0x7F4AD0 VA: 0x1807F56D0
	public Quaternion GetAngularVelocity() { }

	// RVA: 0x7FEC00 Offset: 0x7FE000 VA: 0x1807FEC00 Slot: 103
	public virtual OBB WorldSpaceBounds() { }

	// RVA: 0x2F99E0 Offset: 0x2F8DE0 VA: 0x1802F99E0
	public Vector3 PivotPoint() { }

	// RVA: 0x7F2D60 Offset: 0x7F2160 VA: 0x1807F2D60
	public Vector3 CenterPoint() { }

	// RVA: 0x7F2FC0 Offset: 0x7F23C0 VA: 0x1807F2FC0
	public Vector3 ClosestPoint(Vector3 position) { }

	// RVA: 0x7F2D60 Offset: 0x7F2160 VA: 0x1807F2D60 Slot: 104
	public virtual Vector3 TriggerPoint() { }

	// RVA: 0x7F3730 Offset: 0x7F2B30 VA: 0x1807F3730 Slot: 105
	public float Distance(Vector3 position) { }

	// RVA: 0x7FD570 Offset: 0x7FC970 VA: 0x1807FD570
	public float SqrDistance(Vector3 position) { }

	// RVA: 0x7F36D0 Offset: 0x7F2AD0 VA: 0x1807F36D0
	public float Distance(BaseEntity other) { }

	// RVA: 0x7FD510 Offset: 0x7FC910 VA: 0x1807FD510
	public float SqrDistance(BaseEntity other) { }

	// RVA: 0x7F3590 Offset: 0x7F2990 VA: 0x1807F3590
	public float Distance2D(Vector3 position) { }

	// RVA: 0x7FD3D0 Offset: 0x7FC7D0 VA: 0x1807FD3D0
	public float SqrDistance2D(Vector3 position) { }

	// RVA: 0x7F36D0 Offset: 0x7F2AD0 VA: 0x1807F36D0
	public float Distance2D(BaseEntity other) { }

	// RVA: 0x7FD510 Offset: 0x7FC910 VA: 0x1807FD510
	public float SqrDistance2D(BaseEntity other) { }

	// RVA: 0x7F8B70 Offset: 0x7F7F70 VA: 0x1807F8B70
	public bool IsVisible(Ray ray, int layerMask, float maxDistance) { }

	// RVA: 0x7F8520 Offset: 0x7F7920 VA: 0x1807F8520
	public bool IsVisibleSpecificLayers(Vector3 position, Vector3 target, int layerMask, float maxDistance = ∞) { }

	// RVA: 0x7F8790 Offset: 0x7F7B90 VA: 0x1807F8790
	public bool IsVisible(Vector3 position, Vector3 target, float maxDistance = ∞) { }

	// RVA: 0x7F8A10 Offset: 0x7F7E10 VA: 0x1807F8A10
	public bool IsVisible(Vector3 position, float maxDistance = ∞) { }

	// RVA: 0x7F8310 Offset: 0x7F7710 VA: 0x1807F8310
	public bool IsVisibleAndCanSee(Vector3 position, float maxDistance = ∞) { }

	// RVA: 0x7F7F50 Offset: 0x7F7350 VA: 0x1807F7F50
	public bool IsOlderThan(BaseEntity other) { }

	// RVA: 0x7F8020 Offset: 0x7F7420 VA: 0x1807F8020 Slot: 106
	public virtual bool IsOutside() { }

	// RVA: 0x7F8080 Offset: 0x7F7480 VA: 0x1807F8080
	public bool IsOutside(Vector3 position) { }

	// RVA: 0x7FE770 Offset: 0x7FDB70 VA: 0x1807FE770 Slot: 107
	public virtual float WaterFactor() { }

	// RVA: 0x7F2530 Offset: 0x7F1930 VA: 0x1807F2530 Slot: 108
	public virtual float AirFactor() { }

	// RVA: 0x7FE940 Offset: 0x7FDD40 VA: 0x1807FE940
	public bool WaterTestFromVolumes(Vector3 pos, out WaterLevel.WaterInfo info) { }

	// RVA: 0x7F7C00 Offset: 0x7F7000 VA: 0x1807F7C00
	public bool IsInWaterVolume(Vector3 pos) { }

	// RVA: 0x7FE810 Offset: 0x7FDC10 VA: 0x1807FE810
	public bool WaterTestFromVolumes(Bounds bounds, out WaterLevel.WaterInfo info) { }

	// RVA: 0x7FEA70 Offset: 0x7FDE70 VA: 0x1807FEA70
	public bool WaterTestFromVolumes(Vector3 start, Vector3 end, float radius, out WaterLevel.WaterInfo info) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 109
	public virtual bool BlocksWaterFor(BasePlayer player) { }

	// RVA: 0x581F40 Offset: 0x581340 VA: 0x180581F40 Slot: 110
	public virtual float Health() { }

	// RVA: 0x581F40 Offset: 0x581340 VA: 0x180581F40 Slot: 111
	public virtual float MaxHealth() { }

	// RVA: 0x581F40 Offset: 0x581340 VA: 0x180581F40 Slot: 112
	public virtual float MaxVelocity() { }

	// RVA: 0x7F2570 Offset: 0x7F1970 VA: 0x1807F2570 Slot: 113
	public virtual float BoundsPadding() { }

	// RVA: 0x73C880 Offset: 0x73BC80 VA: 0x18073C880 Slot: 114
	public virtual float PenetrationResistance(HitInfo info) { }

	// RVA: 0x7F5E00 Offset: 0x7F5200 VA: 0x1807F5E00 Slot: 115
	public virtual GameObjectRef GetImpactEffect(HitInfo info) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 116
	public virtual void OnAttacked(HitInfo info) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 117
	public virtual Item GetItem() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 118
	public virtual Item GetItem(uint itemId) { }

	// RVA: 0x7F7700 Offset: 0x7F6B00 VA: 0x1807F7700 Slot: 119
	public virtual void GiveItem(Item item, BaseEntity.GiveItemReason reason = 0) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 120
	public virtual bool CanBeLooted(BasePlayer player) { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80 Slot: 121
	public virtual BaseEntity GetEntity() { }

	// RVA: 0x7FD880 Offset: 0x7FCC80 VA: 0x1807FD880 Slot: 3
	public override string ToString() { }

	// RVA: 0x7F2D30 Offset: 0x7F2130 VA: 0x1807F2D30 Slot: 122
	public virtual string Categorize() { }

	// RVA: 0x7F9A50 Offset: 0x7F8E50 VA: 0x1807F9A50
	public void Log(string str) { }

	// RVA: 0x7FCCE0 Offset: 0x7FC0E0 VA: 0x1807FCCE0
	public void SetModel(Model mdl) { }

	// RVA: 0x71AF80 Offset: 0x71A380 VA: 0x18071AF80
	public Model GetModel() { }

	// RVA: 0x7F5770 Offset: 0x7F4B70 VA: 0x1807F5770 Slot: 123
	public virtual Transform[] GetBones() { }

	// RVA: 0x7F4690 Offset: 0x7F3A90 VA: 0x1807F4690 Slot: 124
	public virtual Transform FindBone(string strName) { }

	// RVA: 0x7F45B0 Offset: 0x7F39B0 VA: 0x1807F45B0 Slot: 125
	public virtual uint FindBoneID(Transform boneTransform) { }

	// RVA: 0x7F4740 Offset: 0x7F3B40 VA: 0x1807F4740 Slot: 126
	public virtual Transform FindClosestBone(Vector3 worldPos) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7FEF40 Offset: 0x7FE340 VA: 0x1807FEF40
	public ulong get_OwnerID() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7FEF60 Offset: 0x7FE360 VA: 0x1807FEF60
	public void set_OwnerID(ulong value) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 127
	public virtual bool ShouldBlockProjectiles() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 128
	public virtual bool ShouldInheritNetworkGroup() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 129
	public virtual bool SupportsChildDeployables() { }

	// RVA: 0x7F2580 Offset: 0x7F1980 VA: 0x1807F2580
	public void BroadcastEntityMessage(string msg, float radius = 20, int layerMask = 1218652417) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 130
	public virtual void OnEntityMessage(BaseEntity from, string msg) { }

	// RVA: 0x7F9550 Offset: 0x7F8950 VA: 0x1807F9550 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x7FEDC0 Offset: 0x7FE1C0 VA: 0x1807FEDC0
	public void .ctor() { }

	// RVA: 0x7FED40 Offset: 0x7FE140 VA: 0x1807FED40
	private static void .cctor() { }

}

public class BaseEntity.Menu : Attribute // TypeDefIndex: 8493
{	// Fields
	public string TitleToken; // 0x10
	public string TitleEnglish; // 0x18
	public string UseVariable; // 0x20
	public int Order; // 0x28
	public string ProxyFunction; // 0x30
	public float Time; // 0x38
	public string OnStart; // 0x40
	public string OnProgress; // 0x48
	public bool LongUseOnly; // 0x50

	// Methods

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

	// RVA: 0x805420 Offset: 0x804820 VA: 0x180805420
	public void .ctor(string menuTitleToken, string menuTitleEnglish) { }

}

public struct BaseEntity.Menu.Option // TypeDefIndex: 8494
{	// Fields
	public Translate.Phrase name; // 0x0
	public Translate.Phrase description; // 0x8
	public Sprite icon; // 0x10
	public int order; // 0x18
	public bool usableWhileWounded; // 0x1C

	// Methods

	// RVA: 0xF8650 Offset: 0xF7A50 VA: 0x1800F8650
	public void CopyTo(ref Option option) { }

}

public class BaseEntity.Menu.Description : Attribute // TypeDefIndex: 8495
{	// Fields
	public string token; // 0x10
	public string english; // 0x18

	// Methods

	// RVA: 0x805420 Offset: 0x804820 VA: 0x180805420
	public void .ctor(string t, string e) { }

}

public class BaseEntity.Menu.Icon : Attribute // TypeDefIndex: 8496
{	// Fields
	public string icon; // 0x10

	// Methods

	// RVA: 0x805E80 Offset: 0x805280 VA: 0x180805E80
	public void .ctor(string i) { }

}

public class BaseEntity.Menu.ShowIf : Attribute // TypeDefIndex: 8497
{	// Fields
	public string functionName; // 0x10

	// Methods

	// RVA: 0x805E80 Offset: 0x805280 VA: 0x180805E80
	public void .ctor(string testFunc) { }

}

public class BaseEntity.Menu.UsableWhileWounded : Attribute // TypeDefIndex: 8498
{	// Methods

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

}

public struct BaseEntity.MovementModify // TypeDefIndex: 8499
{	// Fields
	public float drag; // 0x0

}

public enum BaseEntity.Flags // TypeDefIndex: 8500
{	// Fields
	public int value__; // 0x0
	public const BaseEntity.Flags Placeholder = 1;
	public const BaseEntity.Flags On = 2;
	public const BaseEntity.Flags OnFire = 4;
	public const BaseEntity.Flags Open = 8;
	public const BaseEntity.Flags Locked = 16;
	public const BaseEntity.Flags Debugging = 32;
	public const BaseEntity.Flags Disabled = 64;
	public const BaseEntity.Flags Reserved1 = 128;
	public const BaseEntity.Flags Reserved2 = 256;
	public const BaseEntity.Flags Reserved3 = 512;
	public const BaseEntity.Flags Reserved4 = 1024;
	public const BaseEntity.Flags Reserved5 = 2048;
	public const BaseEntity.Flags Broken = 4096;
	public const BaseEntity.Flags Busy = 8192;
	public const BaseEntity.Flags Reserved6 = 16384;
	public const BaseEntity.Flags Reserved7 = 32768;
	public const BaseEntity.Flags Reserved8 = 65536;
	public const BaseEntity.Flags Reserved9 = 131072;
	public const BaseEntity.Flags Reserved10 = 262144;
	public const BaseEntity.Flags Reserved11 = 524288;

}

private struct BaseEntity.ServerFileRequest : IEquatable<BaseEntity.ServerFileRequest> // TypeDefIndex: 8501
{	// Fields
	public readonly FileStorage.Type Type; // 0x0
	public readonly uint NumId; // 0x4
	public readonly uint Crc; // 0x8
	public readonly IServerFileReceiver Receiver; // 0x10
	public readonly float Time; // 0x18

	// Methods

	// RVA: 0xF88A0 Offset: 0xF7CA0 VA: 0x1800F88A0
	public void .ctor(FileStorage.Type type, uint numId, uint crc, IServerFileReceiver receiver) { }

	// RVA: 0xF87F0 Offset: 0xF7BF0 VA: 0x1800F87F0 Slot: 4
	public bool Equals(BaseEntity.ServerFileRequest other) { }

	// RVA: 0xF8740 Offset: 0xF7B40 VA: 0x1800F8740 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xF8840 Offset: 0xF7C40 VA: 0x1800F8840 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x805FD0 Offset: 0x8053D0 VA: 0x180805FD0
	public static bool op_Equality(BaseEntity.ServerFileRequest left, BaseEntity.ServerFileRequest right) { }

	// RVA: 0x806080 Offset: 0x805480 VA: 0x180806080
	public static bool op_Inequality(BaseEntity.ServerFileRequest left, BaseEntity.ServerFileRequest right) { }

}

public class BaseEntity.Query.EntityTree // TypeDefIndex: 8503
{
// Namespace: 
public class BaseEntity.Query.EntityTree // TypeDefIndex: 8503
	// Fields
	private Grid<BaseEntity> Grid; // 0x10
	private Grid<BasePlayer> PlayerGrid; // 0x18
	private Grid<BaseEntity> BrainGrid; // 0x20

	// Methods

	// RVA: 0x805D90 Offset: 0x805190 VA: 0x180805D90
	public void .ctor(float worldSize) { }

	// RVA: 0x8055B0 Offset: 0x8049B0 VA: 0x1808055B0
	public void Add(BaseEntity ent) { }

	// RVA: 0x805510 Offset: 0x804910 VA: 0x180805510
	public void AddPlayer(BasePlayer player) { }

	// RVA: 0x805470 Offset: 0x804870 VA: 0x180805470
	public void AddBrain(BaseEntity entity) { }

	// RVA: 0x805C90 Offset: 0x805090 VA: 0x180805C90
	public void Remove(BaseEntity ent, bool isPlayer = False) { }

	// RVA: 0x805C30 Offset: 0x805030 VA: 0x180805C30
	public void RemovePlayer(BasePlayer player) { }

	// RVA: 0x805BA0 Offset: 0x804FA0 VA: 0x180805BA0
	public void RemoveBrain(BaseEntity entity) { }

	// RVA: 0x805970 Offset: 0x804D70 VA: 0x180805970
	public void Move(BaseEntity ent) { }

	// RVA: 0x8058D0 Offset: 0x804CD0 VA: 0x1808058D0
	public void MovePlayer(BasePlayer player) { }

	// RVA: 0x805830 Offset: 0x804C30 VA: 0x180805830
	public void MoveBrain(BaseEntity entity) { }

	// RVA: 0x8056F0 Offset: 0x804AF0 VA: 0x1808056F0
	public int GetInSphere(Vector3 position, float distance, BaseEntity[] results, Func<BaseEntity, bool> filter) { }

	// RVA: 0x805790 Offset: 0x804B90 VA: 0x180805790
	public int GetPlayersInSphere(Vector3 position, float distance, BasePlayer[] results, Func<BasePlayer, bool> filter) { }

	// RVA: 0x805650 Offset: 0x804A50 VA: 0x180805650
	public int GetBrainsInSphere(Vector3 position, float distance, BaseEntity[] results, Func<BaseEntity, bool> filter) { }

}

public class BaseEntity.RPC_Shared : Attribute // TypeDefIndex: 8504
{	// Methods

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

}

public struct BaseEntity.RPCMessage // TypeDefIndex: 8505
{	// Fields
	public Connection connection; // 0x0
	public BasePlayer player; // 0x8
	public NetRead read; // 0x10

}

public class BaseEntity.RPC_Client : BaseEntity.RPC_Shared // TypeDefIndex: 8506
{	// Methods

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

}

public enum BaseEntity.Signal // TypeDefIndex: 8507
{	// Fields
	public int value__; // 0x0
	public const BaseEntity.Signal Attack = 0;
	public const BaseEntity.Signal Alt_Attack = 1;
	public const BaseEntity.Signal DryFire = 2;
	public const BaseEntity.Signal Reload = 3;
	public const BaseEntity.Signal Deploy = 4;
	public const BaseEntity.Signal Flinch_Head = 5;
	public const BaseEntity.Signal Flinch_Chest = 6;
	public const BaseEntity.Signal Flinch_Stomach = 7;
	public const BaseEntity.Signal Flinch_RearHead = 8;
	public const BaseEntity.Signal Flinch_RearTorso = 9;
	public const BaseEntity.Signal Throw = 10;
	public const BaseEntity.Signal Relax = 11;
	public const BaseEntity.Signal Gesture = 12;
	public const BaseEntity.Signal PhysImpact = 13;
	public const BaseEntity.Signal Eat = 14;
	public const BaseEntity.Signal Startled = 15;
	public const BaseEntity.Signal Admire = 16;

}

public enum BaseEntity.Slot // TypeDefIndex: 8508
{	// Fields
	public int value__; // 0x0
	public const BaseEntity.Slot Lock = 0;
	public const BaseEntity.Slot FireMod = 1;
	public const BaseEntity.Slot UpperModifier = 2;
	public const BaseEntity.Slot MiddleModifier = 3;
	public const BaseEntity.Slot LowerModifier = 4;
	public const BaseEntity.Slot CenterDecoration = 5;
	public const BaseEntity.Slot LowerCenterDecoration = 6;
	public const BaseEntity.Slot StorageMonitor = 7;
	public const BaseEntity.Slot Count = 8;

}

public enum BaseEntity.TraitFlag // TypeDefIndex: 8509
{	// Fields
	public int value__; // 0x0
	public const BaseEntity.TraitFlag None = 0;
	public const BaseEntity.TraitFlag Alive = 1;
	public const BaseEntity.TraitFlag Animal = 2;
	public const BaseEntity.TraitFlag Human = 4;
	public const BaseEntity.TraitFlag Interesting = 8;
	public const BaseEntity.TraitFlag Food = 16;
	public const BaseEntity.TraitFlag Meat = 32;
	public const BaseEntity.TraitFlag Water = 32;

}

public enum BaseEntity.GiveItemReason // TypeDefIndex: 8511
{
// Namespace: 
public enum BaseEntity.GiveItemReason // TypeDefIndex: 8511
	// Fields
	public int value__; // 0x0
	public const BaseEntity.GiveItemReason Generic = 0;
	public const BaseEntity.GiveItemReason ResourceHarvested = 1;
	public const BaseEntity.GiveItemReason PickedUp = 2;
	public const BaseEntity.GiveItemReason Crafted = 3;

}

private sealed class BaseEntity.<>c // TypeDefIndex: 8512
{	// Fields
	public static readonly BaseEntity.<>c <>9; // 0x0
	public static Comparison<Option> <>9__35_0; // 0x8
	public static Predicate<BaseEntity.ServerFileRequest> <>9__93_0; // 0x10

	// Methods

	// RVA: 0x806170 Offset: 0x805570 VA: 0x180806170
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x8060D0 Offset: 0x8054D0 VA: 0x1808060D0
	internal int <GetMenuItems>b__35_0(Option x, Option y) { }

	// RVA: 0x806100 Offset: 0x805500 VA: 0x180806100
	internal bool <RequestFileFromServer>b__93_0(BaseEntity.ServerFileRequest r) { }

}

