public class RelationshipManager : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6359
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong lastTeamIndex; // 0x18
	public List<PlayerTeam> teamList; // 0x20
	public int maxTeamSize; // 0x28
	public List<RelationshipManager.PlayerRelationships> relationships; // 0x30

	// Methods

	// RVA: 0x1DFC200 Offset: 0x1DFB600 VA: 0x181DFC200
	public static void ResetToPool(RelationshipManager instance) { }

	// RVA: 0x1DFBED0 Offset: 0x1DFB2D0 VA: 0x181DFBED0
	public void ResetToPool() { }

	// RVA: 0x1DFBE10 Offset: 0x1DFB210 VA: 0x181DFBE10 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DFACD0 Offset: 0x1DFA0D0 VA: 0x181DFACD0
	public void CopyTo(RelationshipManager instance) { }

	// RVA: 0x1DFAF60 Offset: 0x1DFA360 VA: 0x181DFAF60
	public RelationshipManager Copy() { }

	// RVA: 0x1DFB870 Offset: 0x1DFAC70 VA: 0x181DFB870
	public static RelationshipManager Deserialize(Stream stream) { }

	// RVA: 0x1DFAFE0 Offset: 0x1DFA3E0 VA: 0x181DFAFE0
	public static RelationshipManager DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DFB430 Offset: 0x1DFA830 VA: 0x181DFB430
	public static RelationshipManager DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DFBCF0 Offset: 0x1DFB0F0 VA: 0x181DFBCF0
	public static RelationshipManager Deserialize(byte[] buffer) { }

	// RVA: 0x1DFBE90 Offset: 0x1DFB290 VA: 0x181DFBE90
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DFCE80 Offset: 0x1DFC280 VA: 0x181DFCE80 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DFCEA0 Offset: 0x1DFC2A0 VA: 0x181DFCEA0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, RelationshipManager previous) { }

	// RVA: 0x1DFBEB0 Offset: 0x1DFB2B0 VA: 0x181DFBEB0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DFB8F0 Offset: 0x1DFACF0 VA: 0x181DFB8F0
	public static RelationshipManager Deserialize(byte[] buffer, RelationshipManager instance, bool isDelta = False) { }

	// RVA: 0x1DFB9F0 Offset: 0x1DFADF0 VA: 0x181DFB9F0
	public static RelationshipManager Deserialize(Stream stream, RelationshipManager instance, bool isDelta) { }

	// RVA: 0x1DFB060 Offset: 0x1DFA460 VA: 0x181DFB060
	public static RelationshipManager DeserializeLengthDelimited(Stream stream, RelationshipManager instance, bool isDelta) { }

	// RVA: 0x1DFB4C0 Offset: 0x1DFA8C0 VA: 0x181DFB4C0
	public static RelationshipManager DeserializeLength(Stream stream, int length, RelationshipManager instance, bool isDelta) { }

	// RVA: 0x1DFC520 Offset: 0x1DFB920 VA: 0x181DFC520
	public static void SerializeDelta(Stream stream, RelationshipManager instance, RelationshipManager previous) { }

	// RVA: 0x1DFCAD0 Offset: 0x1DFBED0 VA: 0x181DFCAD0
	public static void Serialize(Stream stream, RelationshipManager instance) { }

	// RVA: 0x1DFCE70 Offset: 0x1DFC270 VA: 0x181DFCE70
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DFCE80 Offset: 0x1DFC280 VA: 0x181DFCE80
	public void ToProto(Stream stream) { }

	// RVA: 0x1DFC9C0 Offset: 0x1DFBDC0 VA: 0x181DFC9C0
	public static byte[] SerializeToBytes(RelationshipManager instance) { }

	// RVA: 0x1DFC910 Offset: 0x1DFBD10 VA: 0x181DFC910
	public static void SerializeLengthDelimited(Stream stream, RelationshipManager instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class RelationshipManager.PlayerRelationshipInfo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6360
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong playerID; // 0x18
	public int type; // 0x20
	public int weight; // 0x24
	public uint mugshotCrc; // 0x28
	public string displayName; // 0x30
	public string notes; // 0x38
	public float timeSinceSeen; // 0x40

	// Methods

	// RVA: 0x1DF34A0 Offset: 0x1DF28A0 VA: 0x181DF34A0
	public static void ResetToPool(RelationshipManager.PlayerRelationshipInfo instance) { }

	// RVA: 0x1DF3380 Offset: 0x1DF2780 VA: 0x181DF3380
	public void ResetToPool() { }

	// RVA: 0x1DF2C70 Offset: 0x1DF2070 VA: 0x181DF2C70 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DF1160 Offset: 0x1DF0560 VA: 0x181DF1160
	public void CopyTo(RelationshipManager.PlayerRelationshipInfo instance) { }

	// RVA: 0x1DF11D0 Offset: 0x1DF05D0 VA: 0x181DF11D0
	public RelationshipManager.PlayerRelationshipInfo Copy() { }

	// RVA: 0x1DF2540 Offset: 0x1DF1940 VA: 0x181DF2540
	public static RelationshipManager.PlayerRelationshipInfo Deserialize(Stream stream) { }

	// RVA: 0x1DF1280 Offset: 0x1DF0680 VA: 0x181DF1280
	public static RelationshipManager.PlayerRelationshipInfo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DF1A80 Offset: 0x1DF0E80 VA: 0x181DF1A80
	public static RelationshipManager.PlayerRelationshipInfo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DF2870 Offset: 0x1DF1C70 VA: 0x181DF2870
	public static RelationshipManager.PlayerRelationshipInfo Deserialize(byte[] buffer) { }

	// RVA: 0x1DF2CF0 Offset: 0x1DF20F0 VA: 0x181DF2CF0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DF3D30 Offset: 0x1DF3130 VA: 0x181DF3D30 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DF3D50 Offset: 0x1DF3150 VA: 0x181DF3D50 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, RelationshipManager.PlayerRelationshipInfo previous) { }

	// RVA: 0x1DF2FE0 Offset: 0x1DF23E0 VA: 0x181DF2FE0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DF1E70 Offset: 0x1DF1270 VA: 0x181DF1E70
	public static RelationshipManager.PlayerRelationshipInfo Deserialize(byte[] buffer, RelationshipManager.PlayerRelationshipInfo instance, bool isDelta = False) { }

	// RVA: 0x1DF2250 Offset: 0x1DF1650 VA: 0x181DF2250
	public static RelationshipManager.PlayerRelationshipInfo Deserialize(Stream stream, RelationshipManager.PlayerRelationshipInfo instance, bool isDelta) { }

	// RVA: 0x1DF1300 Offset: 0x1DF0700 VA: 0x181DF1300
	public static RelationshipManager.PlayerRelationshipInfo DeserializeLengthDelimited(Stream stream, RelationshipManager.PlayerRelationshipInfo instance, bool isDelta) { }

	// RVA: 0x1DF16D0 Offset: 0x1DF0AD0 VA: 0x181DF16D0
	public static RelationshipManager.PlayerRelationshipInfo DeserializeLength(Stream stream, int length, RelationshipManager.PlayerRelationshipInfo instance, bool isDelta) { }

	// RVA: 0x1DF35C0 Offset: 0x1DF29C0 VA: 0x181DF35C0
	public static void SerializeDelta(Stream stream, RelationshipManager.PlayerRelationshipInfo instance, RelationshipManager.PlayerRelationshipInfo previous) { }

	// RVA: 0x1DF3AD0 Offset: 0x1DF2ED0 VA: 0x181DF3AD0
	public static void Serialize(Stream stream, RelationshipManager.PlayerRelationshipInfo instance) { }

	// RVA: 0x1DF3D20 Offset: 0x1DF3120 VA: 0x181DF3D20
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DF3D30 Offset: 0x1DF3130 VA: 0x181DF3D30
	public void ToProto(Stream stream) { }

	// RVA: 0x1DF39C0 Offset: 0x1DF2DC0 VA: 0x181DF39C0
	public static byte[] SerializeToBytes(RelationshipManager.PlayerRelationshipInfo instance) { }

	// RVA: 0x1DF3910 Offset: 0x1DF2D10 VA: 0x181DF3910
	public static void SerializeLengthDelimited(Stream stream, RelationshipManager.PlayerRelationshipInfo instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class RelationshipManager.PlayerRelationships : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6361
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong playerID; // 0x18
	public List<RelationshipManager.PlayerRelationshipInfo> relations; // 0x20

	// Methods

	// RVA: 0x1DF56D0 Offset: 0x1DF4AD0 VA: 0x181DF56D0
	public static void ResetToPool(RelationshipManager.PlayerRelationships instance) { }

	// RVA: 0x1DF5890 Offset: 0x1DF4C90 VA: 0x181DF5890
	public void ResetToPool() { }

	// RVA: 0x1DF5610 Offset: 0x1DF4A10 VA: 0x181DF5610 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DF3D70 Offset: 0x1DF3170 VA: 0x181DF3D70
	public void CopyTo(RelationshipManager.PlayerRelationships instance) { }

	// RVA: 0x1DF3F30 Offset: 0x1DF3330 VA: 0x181DF3F30
	public RelationshipManager.PlayerRelationships Copy() { }

	// RVA: 0x1DF4EB0 Offset: 0x1DF42B0 VA: 0x181DF4EB0
	public static RelationshipManager.PlayerRelationships Deserialize(Stream stream) { }

	// RVA: 0x1DF4640 Offset: 0x1DF3A40 VA: 0x181DF4640
	public static RelationshipManager.PlayerRelationships DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DF46C0 Offset: 0x1DF3AC0 VA: 0x181DF46C0
	public static RelationshipManager.PlayerRelationships DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DF54F0 Offset: 0x1DF48F0 VA: 0x181DF54F0
	public static RelationshipManager.PlayerRelationships Deserialize(byte[] buffer) { }

	// RVA: 0x1DF5690 Offset: 0x1DF4A90 VA: 0x181DF5690
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DF6080 Offset: 0x1DF5480 VA: 0x181DF6080 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DF60A0 Offset: 0x1DF54A0 VA: 0x181DF60A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, RelationshipManager.PlayerRelationships previous) { }

	// RVA: 0x1DF56B0 Offset: 0x1DF4AB0 VA: 0x181DF56B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DF4DB0 Offset: 0x1DF41B0 VA: 0x181DF4DB0
	public static RelationshipManager.PlayerRelationships Deserialize(byte[] buffer, RelationshipManager.PlayerRelationships instance, bool isDelta = False) { }

	// RVA: 0x1DF4F30 Offset: 0x1DF4330 VA: 0x181DF4F30
	public static RelationshipManager.PlayerRelationships Deserialize(Stream stream, RelationshipManager.PlayerRelationships instance, bool isDelta) { }

	// RVA: 0x1DF3FB0 Offset: 0x1DF33B0 VA: 0x181DF3FB0
	public static RelationshipManager.PlayerRelationships DeserializeLengthDelimited(Stream stream, RelationshipManager.PlayerRelationships instance, bool isDelta) { }

	// RVA: 0x1DF4750 Offset: 0x1DF3B50 VA: 0x181DF4750
	public static RelationshipManager.PlayerRelationships DeserializeLength(Stream stream, int length, RelationshipManager.PlayerRelationships instance, bool isDelta) { }

	// RVA: 0x1DF5A50 Offset: 0x1DF4E50 VA: 0x181DF5A50
	public static void SerializeDelta(Stream stream, RelationshipManager.PlayerRelationships instance, RelationshipManager.PlayerRelationships previous) { }

	// RVA: 0x1DF5E50 Offset: 0x1DF5250 VA: 0x181DF5E50
	public static void Serialize(Stream stream, RelationshipManager.PlayerRelationships instance) { }

	// RVA: 0x1DF6070 Offset: 0x1DF5470 VA: 0x181DF6070
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DF6080 Offset: 0x1DF5480 VA: 0x181DF6080
	public void ToProto(Stream stream) { }

	// RVA: 0x1DF5D40 Offset: 0x1DF5140 VA: 0x181DF5D40
	public static byte[] SerializeToBytes(RelationshipManager.PlayerRelationships instance) { }

	// RVA: 0x1DF5C90 Offset: 0x1DF5090 VA: 0x181DF5C90
	public static void SerializeLengthDelimited(Stream stream, RelationshipManager.PlayerRelationships instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class RelationshipManager : BaseEntity // TypeDefIndex: 8628
{	// Fields
	private const int MugshotResolution = 256;
	private const int MugshotMaxFileSize = 65536;
	private const float MugshotMaxDistance = 50;
	public static RelationshipManager.PlayerRelationships localRelationships; // 0x0
	[ClientVar] // RVA: 0xB3A00 Offset: 0xB2E00 VA: 0x1800B3A00
	public static Vector3 mugshotOffset; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static RelationshipManager <ClientInstance>k__BackingField; // 0x18
	public static int clientMaxTeamSize; // 0x20

	// Properties
	public static RelationshipManager ClientInstance { get; set; }

	// Methods

	// RVA: 0x92ABA0 Offset: 0x929FA0 VA: 0x18092ABA0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x92B3B0 Offset: 0x92A7B0 VA: 0x18092B3B0
	public static void RequestUpdatedContacts() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x928ED0 Offset: 0x9282D0 VA: 0x180928ED0
	public void CLIENT_DoMugshot(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x928FB0 Offset: 0x9283B0 VA: 0x180928FB0
	public void CLIENT_RecieveLocalRelationships(BaseEntity.RPCMessage msg) { }

	// RVA: 0x92A760 Offset: 0x929B60 VA: 0x18092A760
	public static void ChangeRelationship(ulong targetPlayerID, RelationshipManager.RelationshipType newRelationshipType) { }

	// RVA: 0x92B4D0 Offset: 0x92A8D0 VA: 0x18092B4D0
	public static bool VisCheck(Vector3 a, Vector3 b) { }

	// RVA: 0x929B30 Offset: 0x928F30 VA: 0x180929B30
	public static void CaptureAndSendMugshot(BasePlayer targetPlayer) { }

	// RVA: 0x92A8F0 Offset: 0x929CF0 VA: 0x18092A8F0
	public static RelationshipManager.PlayerRelationships GetLocal() { }

	// RVA: 0x92A950 Offset: 0x929D50 VA: 0x18092A950
	private static uint GetSteamIdHash(ulong requesterSteamId, ulong targetSteamId) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x92B810 Offset: 0x92AC10 VA: 0x18092B810
	public static RelationshipManager get_ClientInstance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x92B870 Offset: 0x92AC70 VA: 0x18092B870
	private static void set_ClientInstance(RelationshipManager value) { }

	// RVA: 0x92AAD0 Offset: 0x929ED0 VA: 0x18092AAD0
	public void OnEnable() { }

	// RVA: 0x92AA00 Offset: 0x929E00 VA: 0x18092AA00
	public void OnDestroy() { }

	// RVA: 0x92B470 Offset: 0x92A870 VA: 0x18092B470
	public static bool TeamsEnabled() { }

	// RVA: 0x92A960 Offset: 0x929D60 VA: 0x18092A960 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x92B7B0 Offset: 0x92ABB0 VA: 0x18092B7B0
	public void .ctor() { }

	// RVA: 0x92B670 Offset: 0x92AA70 VA: 0x18092B670
	private static void .cctor() { }

}

public enum RelationshipManager.RelationshipType // TypeDefIndex: 8629
{	// Fields
	public int value__; // 0x0
	public const RelationshipManager.RelationshipType NONE = 0;
	public const RelationshipManager.RelationshipType Acquaintance = 1;
	public const RelationshipManager.RelationshipType Friend = 2;
	public const RelationshipManager.RelationshipType Enemy = 3;

}

public class RelationshipManager.PlayerRelationshipInfo : Pool.IPooled, IServerFileReceiver // TypeDefIndex: 8630
{	// Fields
	public string displayName; // 0x10
	public ulong player; // 0x18
	public RelationshipManager.RelationshipType type; // 0x20
	public int weight; // 0x24
	public uint mugshotCrc; // 0x28
	public string notes; // 0x30
	public float lastSeenTime; // 0x38
	private readonly Action mugshotTimeoutAction; // 0x40
	private uint loadedMugshotCrc; // 0x48
	public bool mugshotLoading; // 0x4C
	public Texture2D mugshotTexture; // 0x50

	// Properties
	public bool IsMugshotLoaded { get; }

	// Methods

	// RVA: 0x91B2D0 Offset: 0x91A6D0 VA: 0x18091B2D0
	public bool get_IsMugshotLoaded() { }

	// RVA: 0x91AC80 Offset: 0x91A080 VA: 0x18091AC80 Slot: 4
	public void EnterPool() { }

	// RVA: 0x91AC80 Offset: 0x91A080 VA: 0x18091AC80 Slot: 5
	public void LeavePool() { }

	// RVA: 0x91B030 Offset: 0x91A430 VA: 0x18091B030
	private void Reset() { }

	// RVA: 0x91B260 Offset: 0x91A660 VA: 0x18091B260
	public void .ctor() { }

	// RVA: 0x91AE60 Offset: 0x91A260 VA: 0x18091AE60
	public void RequestMugshot() { }

	// RVA: 0x91B250 Offset: 0x91A650 VA: 0x18091B250
	private void WaitingForMugshotTimeout() { }

	// RVA: 0x91AC90 Offset: 0x91A090 VA: 0x18091AC90 Slot: 6
	public void OnServerFileReceived(FileStorage.Type type, uint numId, uint crc, byte[] data) { }

}

public class RelationshipManager.PlayerRelationships : Pool.IPooled // TypeDefIndex: 8631
{	// Fields
	public bool dirty; // 0x10
	public ulong ownerPlayer; // 0x18
	public Dictionary<ulong, RelationshipManager.PlayerRelationshipInfo> relations; // 0x20

	// Methods

	// RVA: 0x91B3C0 Offset: 0x91A7C0 VA: 0x18091B3C0
	public RelationshipManager.PlayerRelationshipInfo GetRelations(ulong player) { }

	// RVA: 0x91B530 Offset: 0x91A930 VA: 0x18091B530
	public void .ctor() { }

	// RVA: 0x91B340 Offset: 0x91A740 VA: 0x18091B340 Slot: 4
	public void EnterPool() { }

	// RVA: 0x91B4A0 Offset: 0x91A8A0 VA: 0x18091B4A0 Slot: 5
	public void LeavePool() { }

}

private sealed class RelationshipManager.<>c // TypeDefIndex: 8632
{	// Fields
	public static readonly RelationshipManager.<>c <>9; // 0x0
	public static Func<ulong, ulong> <>9__10_0; // 0x8
	public static Func<RelationshipManager.PlayerRelationshipInfo, ulong> <>9__10_1; // 0x10

	// Methods

	// RVA: 0x9364A0 Offset: 0x9358A0 VA: 0x1809364A0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x7B2BE0 Offset: 0x7B1FE0 VA: 0x1807B2BE0
	internal ulong <CLIENT_RecieveLocalRelationships>b__10_0(ulong r) { }

	// RVA: 0x936440 Offset: 0x935840 VA: 0x180936440
	internal ulong <CLIENT_RecieveLocalRelationships>b__10_1(RelationshipManager.PlayerRelationshipInfo r) { }

}

