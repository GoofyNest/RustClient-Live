internal class PlayerConnectionInternal : IPlayerEditorConnectionNative // TypeDefIndex: 3475
{
	private void UnityEngine.IPlayerEditorConnectionNative.SendMessage(Guid messageId, byte[] data, int playerId) { }

	private bool UnityEngine.IPlayerEditorConnectionNative.TrySendMessage(Guid messageId, byte[] data, int playerId) { }

	private void UnityEngine.IPlayerEditorConnectionNative.Poll() { }

	private void UnityEngine.IPlayerEditorConnectionNative.RegisterInternal(Guid messageId) { }

	private void UnityEngine.IPlayerEditorConnectionNative.UnregisterInternal(Guid messageId) { }

	private void UnityEngine.IPlayerEditorConnectionNative.Initialize() { }

	private bool UnityEngine.IPlayerEditorConnectionNative.IsConnected() { }

	private void UnityEngine.IPlayerEditorConnectionNative.DisconnectAll() { }

	[FreeFunctionAttribute] // RVA: 0xB0910 Offset: 0xAFD10 VA: 0x1800B0910
	private static bool IsConnected() { }

	[FreeFunctionAttribute] // RVA: 0xB0940 Offset: 0xAFD40 VA: 0x1800B0940
	private static void Initialize() { }

	[FreeFunctionAttribute] // RVA: 0xB0A10 Offset: 0xAFE10 VA: 0x1800B0A10
	private static void RegisterInternal(string messageId) { }

	[FreeFunctionAttribute] // RVA: 0xB0A80 Offset: 0xAFE80 VA: 0x1800B0A80
	private static void UnregisterInternal(string messageId) { }

	[FreeFunctionAttribute] // RVA: 0xB1DE0 Offset: 0xB11E0 VA: 0x1800B1DE0
	private static void SendMessage(string messageId, byte[] data, int playerId) { }

	[FreeFunctionAttribute] // RVA: 0xB1EB0 Offset: 0xB12B0 VA: 0x1800B1EB0
	private static bool TrySendMessage(string messageId, byte[] data, int playerId) { }

	[FreeFunctionAttribute] // RVA: 0xB2060 Offset: 0xB1460 VA: 0x1800B2060
	private static void PollInternal() { }

	[FreeFunctionAttribute] // RVA: 0xB2240 Offset: 0xB1640 VA: 0x1800B2240
	private static void DisconnectAll() { }

	public void .ctor() { }

}

public class PlayerPrefsException : Exception // TypeDefIndex: 3476
{
	public void .ctor(string error) { }

}

public class PlayerPrefs // TypeDefIndex: 3477
{
	[NativeMethodAttribute] // RVA: 0xB23E0 Offset: 0xB17E0 VA: 0x1800B23E0
	private static bool TrySetInt(string key, int value) { }

	[NativeMethodAttribute] // RVA: 0xB2550 Offset: 0xB1950 VA: 0x1800B2550
	private static bool TrySetFloat(string key, float value) { }

	[NativeMethodAttribute] // RVA: 0xB2710 Offset: 0xB1B10 VA: 0x1800B2710
	private static bool TrySetSetString(string key, string value) { }

	public static void SetInt(string key, int value) { }

	public static int GetInt(string key, int defaultValue) { }

	public static int GetInt(string key) { }

	public static void SetFloat(string key, float value) { }

	public static float GetFloat(string key, float defaultValue) { }

	public static float GetFloat(string key) { }

	public static void SetString(string key, string value) { }

	public static string GetString(string key, string defaultValue) { }

	public static string GetString(string key) { }

	public static bool HasKey(string key) { }

	public static void DeleteKey(string key) { }

}

internal struct PlayerLoopSystemInternal // TypeDefIndex: 3662
{	public Type type; // 0x0
	public PlayerLoopSystem.UpdateFunction updateDelegate; // 0x8
	public IntPtr updateFunction; // 0x10
	public IntPtr loopConditionFunction; // 0x18
	public int numSubSystems; // 0x20

}

public struct PlayerLoopSystem // TypeDefIndex: 3663
{	public Type type; // 0x0
	public PlayerLoopSystem[] subSystemList; // 0x8
	public PlayerLoopSystem.UpdateFunction updateDelegate; // 0x10
	public IntPtr updateFunction; // 0x18
	public IntPtr loopConditionFunction; // 0x20

}

public sealed class PlayerLoopSystem.UpdateFunction : MulticastDelegate // TypeDefIndex: 3664
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke() { }

	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public class PlayerConnection : ScriptableObject // TypeDefIndex: 3789
{	internal static IPlayerEditorConnectionNative connectionNative; // 0x0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private PlayerEditorConnectionEvents m_PlayerEditorConnectionEvents; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private List<int> m_connectedPlayers; // 0x20
	private bool m_IsInitilized; // 0x28
	private static PlayerConnection s_Instance; // 0x8

	public static PlayerConnection instance { get; }
	public bool isConnected { get; }


	public static PlayerConnection get_instance() { }

	public bool get_isConnected() { }

	private static PlayerConnection CreateInstance() { }

	public void OnEnable() { }

	private IPlayerEditorConnectionNative GetConnectionNativeApi() { }

	public void Register(Guid messageId, UnityAction<MessageEventArgs> callback) { }

	public void Unregister(Guid messageId, UnityAction<MessageEventArgs> callback) { }

	public void RegisterConnection(UnityAction<int> callback) { }

	public void RegisterDisconnection(UnityAction<int> callback) { }

	public void UnregisterConnection(UnityAction<int> callback) { }

	public void UnregisterDisconnection(UnityAction<int> callback) { }

	public void Send(Guid messageId, byte[] data) { }

	public bool TrySend(Guid messageId, byte[] data) { }

	public bool BlockUntilRecvMsg(Guid messageId, int timeout) { }

	public void DisconnectAll() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static void MessageCallbackInternal(IntPtr data, ulong size, ulong guid, string messageId) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static void ConnectedCallbackInternal(int playerId) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static void DisconnectedCallback(int playerId) { }

	public void .ctor() { }

}

private sealed class PlayerConnection.<>c__DisplayClass12_0 // TypeDefIndex: 3790
{	public Guid messageId; // 0x10


	public void .ctor() { }

	internal bool <Register>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x) { }

}

private sealed class PlayerConnection.<>c__DisplayClass13_0 // TypeDefIndex: 3791
{	public Guid messageId; // 0x10


	public void .ctor() { }

	internal bool <Unregister>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x) { }

}

private sealed class PlayerConnection.<>c__DisplayClass20_0 // TypeDefIndex: 3792
{	public bool msgReceived; // 0x10


	public void .ctor() { }

	internal void <BlockUntilRecvMsg>b__0(MessageEventArgs args) { }

}

internal class PlayerEditorConnectionEvents // TypeDefIndex: 3793
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public List<PlayerEditorConnectionEvents.MessageTypeSubscribers> messageTypeSubscribers; // 0x10
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public PlayerEditorConnectionEvents.ConnectionChangeEvent connectionEvent; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public PlayerEditorConnectionEvents.ConnectionChangeEvent disconnectionEvent; // 0x20


	public void InvokeMessageIdSubscribers(Guid messageId, byte[] data, int playerId) { }

	public UnityEvent<MessageEventArgs> AddAndCreate(Guid messageId) { }

	public void UnregisterManagedCallback(Guid messageId, UnityAction<MessageEventArgs> callback) { }

	public void .ctor() { }

}

public class PlayerEditorConnectionEvents.MessageEvent : UnityEvent<MessageEventArgs> // TypeDefIndex: 3794
{
	public void .ctor() { }

}

public class PlayerEditorConnectionEvents.ConnectionChangeEvent : UnityEvent<int> // TypeDefIndex: 3795
{
	public void .ctor() { }

}

public class PlayerEditorConnectionEvents.MessageTypeSubscribers // TypeDefIndex: 3796
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string m_messageTypeId; // 0x10
	public int subscriberCount; // 0x18
	public PlayerEditorConnectionEvents.MessageEvent messageCallback; // 0x20

	public Guid MessageTypeId { get; set; }


	public Guid get_MessageTypeId() { }

	public void set_MessageTypeId(Guid value) { }

	public void .ctor() { }

}

private sealed class PlayerEditorConnectionEvents.<>c__DisplayClass6_0 // TypeDefIndex: 3797
{	public Guid messageId; // 0x10


	public void .ctor() { }

	internal bool <InvokeMessageIdSubscribers>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x) { }

}

private sealed class PlayerEditorConnectionEvents.<>c__DisplayClass7_0 // TypeDefIndex: 3798
{	public Guid messageId; // 0x10


	public void .ctor() { }

	internal bool <AddAndCreate>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x) { }

}

private sealed class PlayerEditorConnectionEvents.<>c__DisplayClass8_0 // TypeDefIndex: 3799
{	public Guid messageId; // 0x10


	public void .ctor() { }

	internal bool <UnregisterManagedCallback>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x) { }

}

public struct PlayerItemRecipe : IEquatable<PlayerItemRecipe> // TypeDefIndex: 5698
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly IReadOnlyList<PlayerItemRecipe.Ingredient> <Ingredients>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly IPlayerItemDefinition <Result>k__BackingField; // 0x8

	public IReadOnlyList<PlayerItemRecipe.Ingredient> Ingredients { get; }
	public IPlayerItemDefinition Result { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public IReadOnlyList<PlayerItemRecipe.Ingredient> get_Ingredients() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public IPlayerItemDefinition get_Result() { }

	public void .ctor(IReadOnlyList<PlayerItemRecipe.Ingredient> ingredients, IPlayerItemDefinition result) { }

	public bool Equals(PlayerItemRecipe other) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public static bool op_Equality(PlayerItemRecipe left, PlayerItemRecipe right) { }

	public static bool op_Inequality(PlayerItemRecipe left, PlayerItemRecipe right) { }

}

public struct PlayerItemRecipe.Ingredient : IEquatable<PlayerItemRecipe.Ingredient> // TypeDefIndex: 5699
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly int <DefinitionId>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly int <Amount>k__BackingField; // 0x4

	public int DefinitionId { get; }
	public int Amount { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int get_DefinitionId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int get_Amount() { }

	public void .ctor(int definitionId, int amount) { }

	public bool Equals(PlayerItemRecipe.Ingredient other) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public static bool op_Equality(PlayerItemRecipe.Ingredient left, PlayerItemRecipe.Ingredient right) { }

	public static bool op_Inequality(PlayerItemRecipe.Ingredient left, PlayerItemRecipe.Ingredient right) { }

}

private sealed class PlayerItemRecipe.<>c // TypeDefIndex: 5700
{	public static readonly PlayerItemRecipe.<>c <>9; // 0x0
	public static Func<PlayerItemRecipe.Ingredient, int> <>9__10_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal int <GetHashCode>b__10_0(PlayerItemRecipe.Ingredient i) { }

}

public static class PlayerItemExtensions // TypeDefIndex: 6156
{
	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static IPlayerItemDefinition GetDefinition(IPlayerItem item) { }

}

public struct PlayerInfo // TypeDefIndex: 6250
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Name>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Id>k__BackingField; // 0x8

	public string Name { get; set; }
	public string Id { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_Id() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Id(string value) { }

}

public class PlayerTick : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6277
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public InputMessage inputState; // 0x18
	public Vector3 position; // 0x20
	public ModelState modelState; // 0x30
	public uint activeItem; // 0x38
	public Vector3 eyePos; // 0x3C
	public uint parentID; // 0x48
	public uint deltaMs; // 0x4C


	public static void ResetToPool(PlayerTick instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(PlayerTick instance) { }

	public PlayerTick Copy() { }

	public static PlayerTick Deserialize(Stream stream) { }

	public static PlayerTick DeserializeLengthDelimited(Stream stream) { }

	public static PlayerTick DeserializeLength(Stream stream, int length) { }

	public static PlayerTick Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, PlayerTick previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static PlayerTick Deserialize(byte[] buffer, PlayerTick instance, bool isDelta = False) { }

	public static PlayerTick Deserialize(Stream stream, PlayerTick instance, bool isDelta) { }

	public static PlayerTick DeserializeLengthDelimited(Stream stream, PlayerTick instance, bool isDelta) { }

	public static PlayerTick DeserializeLength(Stream stream, int length, PlayerTick instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, PlayerTick instance, PlayerTick previous) { }

	public static void Serialize(Stream stream, PlayerTick instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(PlayerTick instance) { }

	public static void SerializeLengthDelimited(Stream stream, PlayerTick instance) { }

	public void .ctor() { }

}

public class BasePlayer : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6443
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string name; // 0x18
	public ulong userid; // 0x20
	public PlayerInventory inventory; // 0x28
	public PlayerMetabolism metabolism; // 0x30
	public ModelState modelState; // 0x38
	public int playerFlags; // 0x40
	public uint heldEntity; // 0x44
	public float health; // 0x48
	public PersistantPlayer persistantData; // 0x50
	public float skinCol; // 0x58
	public float skinTex; // 0x5C
	public float skinMesh; // 0x60
	public PlayerLifeStory currentLife; // 0x68
	public PlayerLifeStory previousLife; // 0x70
	public uint mounted; // 0x78
	public ulong currentTeam; // 0x80
	public uint underwear; // 0x88
	public PlayerModifiers modifiers; // 0x90
	public int reputation; // 0x98
	public uint loopingGesture; // 0x9C
	public Missions missions; // 0xA0


	public static void ResetToPool(BasePlayer instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(BasePlayer instance) { }

	public BasePlayer Copy() { }

	public static BasePlayer Deserialize(Stream stream) { }

	public static BasePlayer DeserializeLengthDelimited(Stream stream) { }

	public static BasePlayer DeserializeLength(Stream stream, int length) { }

	public static BasePlayer Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, BasePlayer previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static BasePlayer Deserialize(byte[] buffer, BasePlayer instance, bool isDelta = False) { }

	public static BasePlayer Deserialize(Stream stream, BasePlayer instance, bool isDelta) { }

	public static BasePlayer DeserializeLengthDelimited(Stream stream, BasePlayer instance, bool isDelta) { }

	public static BasePlayer DeserializeLength(Stream stream, int length, BasePlayer instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, BasePlayer instance, BasePlayer previous) { }

	public static void Serialize(Stream stream, BasePlayer instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(BasePlayer instance) { }

	public static void SerializeLengthDelimited(Stream stream, BasePlayer instance) { }

	public void .ctor() { }

}

public class PlayerTeam : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6444
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong teamID; // 0x18
	public string teamName; // 0x20
	public ulong teamLeader; // 0x28
	public List<PlayerTeam.TeamMember> members; // 0x30
	public float teamLifetime; // 0x38
	public MapNote mapNote; // 0x40


	public static void ResetToPool(PlayerTeam instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(PlayerTeam instance) { }

	public PlayerTeam Copy() { }

	public static PlayerTeam Deserialize(Stream stream) { }

	public static PlayerTeam DeserializeLengthDelimited(Stream stream) { }

	public static PlayerTeam DeserializeLength(Stream stream, int length) { }

	public static PlayerTeam Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, PlayerTeam previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static PlayerTeam Deserialize(byte[] buffer, PlayerTeam instance, bool isDelta = False) { }

	public static PlayerTeam Deserialize(Stream stream, PlayerTeam instance, bool isDelta) { }

	public static PlayerTeam DeserializeLengthDelimited(Stream stream, PlayerTeam instance, bool isDelta) { }

	public static PlayerTeam DeserializeLength(Stream stream, int length, PlayerTeam instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, PlayerTeam instance, PlayerTeam previous) { }

	public static void Serialize(Stream stream, PlayerTeam instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(PlayerTeam instance) { }

	public static void SerializeLengthDelimited(Stream stream, PlayerTeam instance) { }

	public void .ctor() { }

}

public class PlayerTeam.TeamMember : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6445
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string displayName; // 0x18
	public ulong userID; // 0x20
	public float healthFraction; // 0x28
	public Vector3 position; // 0x2C
	public bool online; // 0x38
	public bool wounded; // 0x39


	public static void ResetToPool(PlayerTeam.TeamMember instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(PlayerTeam.TeamMember instance) { }

	public PlayerTeam.TeamMember Copy() { }

	public static PlayerTeam.TeamMember Deserialize(Stream stream) { }

	public static PlayerTeam.TeamMember DeserializeLengthDelimited(Stream stream) { }

	public static PlayerTeam.TeamMember DeserializeLength(Stream stream, int length) { }

	public static PlayerTeam.TeamMember Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, PlayerTeam.TeamMember previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static PlayerTeam.TeamMember Deserialize(byte[] buffer, PlayerTeam.TeamMember instance, bool isDelta = False) { }

	public static PlayerTeam.TeamMember Deserialize(Stream stream, PlayerTeam.TeamMember instance, bool isDelta) { }

	public static PlayerTeam.TeamMember DeserializeLengthDelimited(Stream stream, PlayerTeam.TeamMember instance, bool isDelta) { }

	public static PlayerTeam.TeamMember DeserializeLength(Stream stream, int length, PlayerTeam.TeamMember instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, PlayerTeam.TeamMember instance, PlayerTeam.TeamMember previous) { }

	public static void Serialize(Stream stream, PlayerTeam.TeamMember instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(PlayerTeam.TeamMember instance) { }

	public static void SerializeLengthDelimited(Stream stream, PlayerTeam.TeamMember instance) { }

	public void .ctor() { }

}

public class PlayerMetabolism : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6446
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float health; // 0x14
	public float calories; // 0x18
	public float hydration; // 0x1C
	public float heartrate; // 0x20
	public float temperature; // 0x24
	public float poison; // 0x28
	public float radiation_level; // 0x2C
	public float wetness; // 0x30
	public float dirtyness; // 0x34
	public float oxygen; // 0x38
	public float bleeding; // 0x3C
	public float radiation_poisoning; // 0x40
	public float comfort; // 0x44
	public float pending_health; // 0x48


	public static void ResetToPool(PlayerMetabolism instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(PlayerMetabolism instance) { }

	public PlayerMetabolism Copy() { }

	public static PlayerMetabolism Deserialize(Stream stream) { }

	public static PlayerMetabolism DeserializeLengthDelimited(Stream stream) { }

	public static PlayerMetabolism DeserializeLength(Stream stream, int length) { }

	public static PlayerMetabolism Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, PlayerMetabolism previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static PlayerMetabolism Deserialize(byte[] buffer, PlayerMetabolism instance, bool isDelta = False) { }

	public static PlayerMetabolism Deserialize(Stream stream, PlayerMetabolism instance, bool isDelta) { }

	public static PlayerMetabolism DeserializeLengthDelimited(Stream stream, PlayerMetabolism instance, bool isDelta) { }

	public static PlayerMetabolism DeserializeLength(Stream stream, int length, PlayerMetabolism instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, PlayerMetabolism instance, PlayerMetabolism previous) { }

	public static void Serialize(Stream stream, PlayerMetabolism instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(PlayerMetabolism instance) { }

	public static void SerializeLengthDelimited(Stream stream, PlayerMetabolism instance) { }

	public void .ctor() { }

}

public class PlayerModifiers : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6447
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<Modifier> modifiers; // 0x18


	public static void ResetToPool(PlayerModifiers instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(PlayerModifiers instance) { }

	public PlayerModifiers Copy() { }

	public static PlayerModifiers Deserialize(Stream stream) { }

	public static PlayerModifiers DeserializeLengthDelimited(Stream stream) { }

	public static PlayerModifiers DeserializeLength(Stream stream, int length) { }

	public static PlayerModifiers Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, PlayerModifiers previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static PlayerModifiers Deserialize(byte[] buffer, PlayerModifiers instance, bool isDelta = False) { }

	public static PlayerModifiers Deserialize(Stream stream, PlayerModifiers instance, bool isDelta) { }

	public static PlayerModifiers DeserializeLengthDelimited(Stream stream, PlayerModifiers instance, bool isDelta) { }

	public static PlayerModifiers DeserializeLength(Stream stream, int length, PlayerModifiers instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, PlayerModifiers instance, PlayerModifiers previous) { }

	public static void Serialize(Stream stream, PlayerModifiers instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(PlayerModifiers instance) { }

	public static void SerializeLengthDelimited(Stream stream, PlayerModifiers instance) { }

	public void .ctor() { }

}

public class PlayerInventory : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6454
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ItemContainer invMain; // 0x18
	public ItemContainer invBelt; // 0x20
	public ItemContainer invWear; // 0x28


	public static void ResetToPool(PlayerInventory instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(PlayerInventory instance) { }

	public PlayerInventory Copy() { }

	public static PlayerInventory Deserialize(Stream stream) { }

	public static PlayerInventory DeserializeLengthDelimited(Stream stream) { }

	public static PlayerInventory DeserializeLength(Stream stream, int length) { }

	public static PlayerInventory Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, PlayerInventory previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static PlayerInventory Deserialize(byte[] buffer, PlayerInventory instance, bool isDelta = False) { }

	public static PlayerInventory Deserialize(Stream stream, PlayerInventory instance, bool isDelta) { }

	public static PlayerInventory DeserializeLengthDelimited(Stream stream, PlayerInventory instance, bool isDelta) { }

	public static PlayerInventory DeserializeLength(Stream stream, int length, PlayerInventory instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, PlayerInventory instance, PlayerInventory previous) { }

	public static void Serialize(Stream stream, PlayerInventory instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(PlayerInventory instance) { }

	public static void SerializeLengthDelimited(Stream stream, PlayerInventory instance) { }

	public void .ctor() { }

}

public class PlayerLifeStory : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6456
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float secondsAlive; // 0x14
	public float metersWalked; // 0x18
	public float metersRun; // 0x1C
	public float secondsSleeping; // 0x20
	public uint timeBorn; // 0x24
	public uint timeDied; // 0x28
	public float secondsWilderness; // 0x2C
	public float secondsSwimming; // 0x30
	public float secondsInBase; // 0x34
	public float secondsInMonument; // 0x38
	public float secondsFlying; // 0x3C
	public float secondsBoating; // 0x40
	public float secondsDriving; // 0x44
	public float totalDamageTaken; // 0x48
	public float totalHealing; // 0x4C
	public PlayerLifeStory.DeathInfo deathInfo; // 0x50
	public List<PlayerLifeStory.WeaponStats> weaponStats; // 0x58
	public int killedPlayers; // 0x60
	public int killedScientists; // 0x64
	public int killedAnimals; // 0x68
	public List<PlayerLifeStory.GenericStat> genericStats; // 0x70


	public static void ResetToPool(PlayerLifeStory instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(PlayerLifeStory instance) { }

	public PlayerLifeStory Copy() { }

	public static PlayerLifeStory Deserialize(Stream stream) { }

	public static PlayerLifeStory DeserializeLengthDelimited(Stream stream) { }

	public static PlayerLifeStory DeserializeLength(Stream stream, int length) { }

	public static PlayerLifeStory Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, PlayerLifeStory previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static PlayerLifeStory Deserialize(byte[] buffer, PlayerLifeStory instance, bool isDelta = False) { }

	public static PlayerLifeStory Deserialize(Stream stream, PlayerLifeStory instance, bool isDelta) { }

	public static PlayerLifeStory DeserializeLengthDelimited(Stream stream, PlayerLifeStory instance, bool isDelta) { }

	public static PlayerLifeStory DeserializeLength(Stream stream, int length, PlayerLifeStory instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, PlayerLifeStory instance, PlayerLifeStory previous) { }

	public static void Serialize(Stream stream, PlayerLifeStory instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(PlayerLifeStory instance) { }

	public static void SerializeLengthDelimited(Stream stream, PlayerLifeStory instance) { }

	public void .ctor() { }

}

public class PlayerLifeStory.DeathInfo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6457
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string attackerName; // 0x18
	public ulong attackerSteamID; // 0x20
	public string hitBone; // 0x28
	public string inflictorName; // 0x30
	public int lastDamageType; // 0x38
	public float attackerDistance; // 0x3C


	public static void ResetToPool(PlayerLifeStory.DeathInfo instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(PlayerLifeStory.DeathInfo instance) { }

	public PlayerLifeStory.DeathInfo Copy() { }

	public static PlayerLifeStory.DeathInfo Deserialize(Stream stream) { }

	public static PlayerLifeStory.DeathInfo DeserializeLengthDelimited(Stream stream) { }

	public static PlayerLifeStory.DeathInfo DeserializeLength(Stream stream, int length) { }

	public static PlayerLifeStory.DeathInfo Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, PlayerLifeStory.DeathInfo previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static PlayerLifeStory.DeathInfo Deserialize(byte[] buffer, PlayerLifeStory.DeathInfo instance, bool isDelta = False) { }

	public static PlayerLifeStory.DeathInfo Deserialize(Stream stream, PlayerLifeStory.DeathInfo instance, bool isDelta) { }

	public static PlayerLifeStory.DeathInfo DeserializeLengthDelimited(Stream stream, PlayerLifeStory.DeathInfo instance, bool isDelta) { }

	public static PlayerLifeStory.DeathInfo DeserializeLength(Stream stream, int length, PlayerLifeStory.DeathInfo instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, PlayerLifeStory.DeathInfo instance, PlayerLifeStory.DeathInfo previous) { }

	public static void Serialize(Stream stream, PlayerLifeStory.DeathInfo instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(PlayerLifeStory.DeathInfo instance) { }

	public static void SerializeLengthDelimited(Stream stream, PlayerLifeStory.DeathInfo instance) { }

	public void .ctor() { }

}

public class PlayerLifeStory.WeaponStats : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6458
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string weaponName; // 0x18
	public ulong shotsFired; // 0x20
	public ulong shotsHit; // 0x28


	public static void ResetToPool(PlayerLifeStory.WeaponStats instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(PlayerLifeStory.WeaponStats instance) { }

	public PlayerLifeStory.WeaponStats Copy() { }

	public static PlayerLifeStory.WeaponStats Deserialize(Stream stream) { }

	public static PlayerLifeStory.WeaponStats DeserializeLengthDelimited(Stream stream) { }

	public static PlayerLifeStory.WeaponStats DeserializeLength(Stream stream, int length) { }

	public static PlayerLifeStory.WeaponStats Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, PlayerLifeStory.WeaponStats previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static PlayerLifeStory.WeaponStats Deserialize(byte[] buffer, PlayerLifeStory.WeaponStats instance, bool isDelta = False) { }

	public static PlayerLifeStory.WeaponStats Deserialize(Stream stream, PlayerLifeStory.WeaponStats instance, bool isDelta) { }

	public static PlayerLifeStory.WeaponStats DeserializeLengthDelimited(Stream stream, PlayerLifeStory.WeaponStats instance, bool isDelta) { }

	public static PlayerLifeStory.WeaponStats DeserializeLength(Stream stream, int length, PlayerLifeStory.WeaponStats instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, PlayerLifeStory.WeaponStats instance, PlayerLifeStory.WeaponStats previous) { }

	public static void Serialize(Stream stream, PlayerLifeStory.WeaponStats instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(PlayerLifeStory.WeaponStats instance) { }

	public static void SerializeLengthDelimited(Stream stream, PlayerLifeStory.WeaponStats instance) { }

	public void .ctor() { }

}

public class PlayerLifeStory.GenericStat : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6459
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string key; // 0x18
	public int value; // 0x20


	public static void ResetToPool(PlayerLifeStory.GenericStat instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(PlayerLifeStory.GenericStat instance) { }

	public PlayerLifeStory.GenericStat Copy() { }

	public static PlayerLifeStory.GenericStat Deserialize(Stream stream) { }

	public static PlayerLifeStory.GenericStat DeserializeLengthDelimited(Stream stream) { }

	public static PlayerLifeStory.GenericStat DeserializeLength(Stream stream, int length) { }

	public static PlayerLifeStory.GenericStat Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, PlayerLifeStory.GenericStat previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static PlayerLifeStory.GenericStat Deserialize(byte[] buffer, PlayerLifeStory.GenericStat instance, bool isDelta = False) { }

	public static PlayerLifeStory.GenericStat Deserialize(Stream stream, PlayerLifeStory.GenericStat instance, bool isDelta) { }

	public static PlayerLifeStory.GenericStat DeserializeLengthDelimited(Stream stream, PlayerLifeStory.GenericStat instance, bool isDelta) { }

	public static PlayerLifeStory.GenericStat DeserializeLength(Stream stream, int length, PlayerLifeStory.GenericStat instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, PlayerLifeStory.GenericStat instance, PlayerLifeStory.GenericStat previous) { }

	public static void Serialize(Stream stream, PlayerLifeStory.GenericStat instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(PlayerLifeStory.GenericStat instance) { }

	public static void SerializeLengthDelimited(Stream stream, PlayerLifeStory.GenericStat instance) { }

	public void .ctor() { }

}

public class PlayerState : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6462
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public double unHostileTimestamp; // 0x18
	public MapNote pointOfInterest; // 0x20
	public MapNote deathMarker; // 0x28
	public Missions missions; // 0x30


	public static void ResetToPool(PlayerState instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(PlayerState instance) { }

	public PlayerState Copy() { }

	public static PlayerState Deserialize(Stream stream) { }

	public static PlayerState DeserializeLengthDelimited(Stream stream) { }

	public static PlayerState DeserializeLength(Stream stream, int length) { }

	public static PlayerState Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, PlayerState previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static PlayerState Deserialize(byte[] buffer, PlayerState instance, bool isDelta = False) { }

	public static PlayerState Deserialize(Stream stream, PlayerState instance, bool isDelta) { }

	public static PlayerState DeserializeLengthDelimited(Stream stream, PlayerState instance, bool isDelta) { }

	public static PlayerState DeserializeLength(Stream stream, int length, PlayerState instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, PlayerState instance, PlayerState previous) { }

	public static void Serialize(Stream stream, PlayerState instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(PlayerState instance) { }

	public static void SerializeLengthDelimited(Stream stream, PlayerState instance) { }

	public void .ctor() { }

}

public class PlayerNameID : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6463
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string username; // 0x18
	public ulong userid; // 0x20


	public static void ResetToPool(PlayerNameID instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(PlayerNameID instance) { }

	public PlayerNameID Copy() { }

	public static PlayerNameID Deserialize(Stream stream) { }

	public static PlayerNameID DeserializeLengthDelimited(Stream stream) { }

	public static PlayerNameID DeserializeLength(Stream stream, int length) { }

	public static PlayerNameID Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, PlayerNameID previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static PlayerNameID Deserialize(byte[] buffer, PlayerNameID instance, bool isDelta = False) { }

	public static PlayerNameID Deserialize(Stream stream, PlayerNameID instance, bool isDelta) { }

	public static PlayerNameID DeserializeLengthDelimited(Stream stream, PlayerNameID instance, bool isDelta) { }

	public static PlayerNameID DeserializeLength(Stream stream, int length, PlayerNameID instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, PlayerNameID instance, PlayerNameID previous) { }

	public static void Serialize(Stream stream, PlayerNameID instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(PlayerNameID instance) { }

	public static void SerializeLengthDelimited(Stream stream, PlayerNameID instance) { }

	public void .ctor() { }

}

public class PlayerUpdateLoot : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6478
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint itemID; // 0x14
	public uint entityID; // 0x18
	public List<ItemContainer> containers; // 0x20


	public static void ResetToPool(PlayerUpdateLoot instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(PlayerUpdateLoot instance) { }

	public PlayerUpdateLoot Copy() { }

	public static PlayerUpdateLoot Deserialize(Stream stream) { }

	public static PlayerUpdateLoot DeserializeLengthDelimited(Stream stream) { }

	public static PlayerUpdateLoot DeserializeLength(Stream stream, int length) { }

	public static PlayerUpdateLoot Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, PlayerUpdateLoot previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static PlayerUpdateLoot Deserialize(byte[] buffer, PlayerUpdateLoot instance, bool isDelta = False) { }

	public static PlayerUpdateLoot Deserialize(Stream stream, PlayerUpdateLoot instance, bool isDelta) { }

	public static PlayerUpdateLoot DeserializeLengthDelimited(Stream stream, PlayerUpdateLoot instance, bool isDelta) { }

	public static PlayerUpdateLoot DeserializeLength(Stream stream, int length, PlayerUpdateLoot instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, PlayerUpdateLoot instance, PlayerUpdateLoot previous) { }

	public static void Serialize(Stream stream, PlayerUpdateLoot instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(PlayerUpdateLoot instance) { }

	public static void SerializeLengthDelimited(Stream stream, PlayerUpdateLoot instance) { }

	public void .ctor() { }

}

public class PlayerAttack : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6484
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Attack attack; // 0x18
	public int projectileID; // 0x20


	public static void ResetToPool(PlayerAttack instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(PlayerAttack instance) { }

	public PlayerAttack Copy() { }

	public static PlayerAttack Deserialize(Stream stream) { }

	public static PlayerAttack DeserializeLengthDelimited(Stream stream) { }

	public static PlayerAttack DeserializeLength(Stream stream, int length) { }

	public static PlayerAttack Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, PlayerAttack previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static PlayerAttack Deserialize(byte[] buffer, PlayerAttack instance, bool isDelta = False) { }

	public static PlayerAttack Deserialize(Stream stream, PlayerAttack instance, bool isDelta) { }

	public static PlayerAttack DeserializeLengthDelimited(Stream stream, PlayerAttack instance, bool isDelta) { }

	public static PlayerAttack DeserializeLength(Stream stream, int length, PlayerAttack instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, PlayerAttack instance, PlayerAttack previous) { }

	public static void Serialize(Stream stream, PlayerAttack instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(PlayerAttack instance) { }

	public static void SerializeLengthDelimited(Stream stream, PlayerAttack instance) { }

	public void .ctor() { }

}

public class PlayerProjectileAttack : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6485
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public PlayerAttack playerAttack; // 0x18
	public Vector3 hitVelocity; // 0x20
	public float hitDistance; // 0x2C
	public float travelTime; // 0x30


	public static void ResetToPool(PlayerProjectileAttack instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(PlayerProjectileAttack instance) { }

	public PlayerProjectileAttack Copy() { }

	public static PlayerProjectileAttack Deserialize(Stream stream) { }

	public static PlayerProjectileAttack DeserializeLengthDelimited(Stream stream) { }

	public static PlayerProjectileAttack DeserializeLength(Stream stream, int length) { }

	public static PlayerProjectileAttack Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, PlayerProjectileAttack previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static PlayerProjectileAttack Deserialize(byte[] buffer, PlayerProjectileAttack instance, bool isDelta = False) { }

	public static PlayerProjectileAttack Deserialize(Stream stream, PlayerProjectileAttack instance, bool isDelta) { }

	public static PlayerProjectileAttack DeserializeLengthDelimited(Stream stream, PlayerProjectileAttack instance, bool isDelta) { }

	public static PlayerProjectileAttack DeserializeLength(Stream stream, int length, PlayerProjectileAttack instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, PlayerProjectileAttack instance, PlayerProjectileAttack previous) { }

	public static void Serialize(Stream stream, PlayerProjectileAttack instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(PlayerProjectileAttack instance) { }

	public static void SerializeLengthDelimited(Stream stream, PlayerProjectileAttack instance) { }

	public void .ctor() { }

}

public class PlayerProjectileRicochet : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6486
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int projectileID; // 0x14
	public Vector3 hitPosition; // 0x18
	public Vector3 inVelocity; // 0x24
	public Vector3 outVelocity; // 0x30
	public Vector3 hitNormal; // 0x3C
	public float travelTime; // 0x48


	public static void ResetToPool(PlayerProjectileRicochet instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(PlayerProjectileRicochet instance) { }

	public PlayerProjectileRicochet Copy() { }

	public static PlayerProjectileRicochet Deserialize(Stream stream) { }

	public static PlayerProjectileRicochet DeserializeLengthDelimited(Stream stream) { }

	public static PlayerProjectileRicochet DeserializeLength(Stream stream, int length) { }

	public static PlayerProjectileRicochet Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, PlayerProjectileRicochet previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static PlayerProjectileRicochet Deserialize(byte[] buffer, PlayerProjectileRicochet instance, bool isDelta = False) { }

	public static PlayerProjectileRicochet Deserialize(Stream stream, PlayerProjectileRicochet instance, bool isDelta) { }

	public static PlayerProjectileRicochet DeserializeLengthDelimited(Stream stream, PlayerProjectileRicochet instance, bool isDelta) { }

	public static PlayerProjectileRicochet DeserializeLength(Stream stream, int length, PlayerProjectileRicochet instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, PlayerProjectileRicochet instance, PlayerProjectileRicochet previous) { }

	public static void Serialize(Stream stream, PlayerProjectileRicochet instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(PlayerProjectileRicochet instance) { }

	public static void SerializeLengthDelimited(Stream stream, PlayerProjectileRicochet instance) { }

	public void .ctor() { }

}

public class PlayerProjectileUpdate : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6487
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int projectileID; // 0x14
	public Vector3 curPosition; // 0x18
	public Vector3 curVelocity; // 0x24
	public float travelTime; // 0x30


	public static void ResetToPool(PlayerProjectileUpdate instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(PlayerProjectileUpdate instance) { }

	public PlayerProjectileUpdate Copy() { }

	public static PlayerProjectileUpdate Deserialize(Stream stream) { }

	public static PlayerProjectileUpdate DeserializeLengthDelimited(Stream stream) { }

	public static PlayerProjectileUpdate DeserializeLength(Stream stream, int length) { }

	public static PlayerProjectileUpdate Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, PlayerProjectileUpdate previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static PlayerProjectileUpdate Deserialize(byte[] buffer, PlayerProjectileUpdate instance, bool isDelta = False) { }

	public static PlayerProjectileUpdate Deserialize(Stream stream, PlayerProjectileUpdate instance, bool isDelta) { }

	public static PlayerProjectileUpdate DeserializeLengthDelimited(Stream stream, PlayerProjectileUpdate instance, bool isDelta) { }

	public static PlayerProjectileUpdate DeserializeLength(Stream stream, int length, PlayerProjectileUpdate instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, PlayerProjectileUpdate instance, PlayerProjectileUpdate previous) { }

	public static void Serialize(Stream stream, PlayerProjectileUpdate instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(PlayerProjectileUpdate instance) { }

	public static void SerializeLengthDelimited(Stream stream, PlayerProjectileUpdate instance) { }

	public void .ctor() { }

}

public class PlayerDetectedAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6544
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float range; // 0x14


	public static void ResetToPool(PlayerDetectedAIEventData instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(PlayerDetectedAIEventData instance) { }

	public PlayerDetectedAIEventData Copy() { }

	public static PlayerDetectedAIEventData Deserialize(Stream stream) { }

	public static PlayerDetectedAIEventData DeserializeLengthDelimited(Stream stream) { }

	public static PlayerDetectedAIEventData DeserializeLength(Stream stream, int length) { }

	public static PlayerDetectedAIEventData Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, PlayerDetectedAIEventData previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static PlayerDetectedAIEventData Deserialize(byte[] buffer, PlayerDetectedAIEventData instance, bool isDelta = False) { }

	public static PlayerDetectedAIEventData Deserialize(Stream stream, PlayerDetectedAIEventData instance, bool isDelta) { }

	public static PlayerDetectedAIEventData DeserializeLengthDelimited(Stream stream, PlayerDetectedAIEventData instance, bool isDelta) { }

	public static PlayerDetectedAIEventData DeserializeLength(Stream stream, int length, PlayerDetectedAIEventData instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, PlayerDetectedAIEventData instance, PlayerDetectedAIEventData previous) { }

	public static void Serialize(Stream stream, PlayerDetectedAIEventData instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(PlayerDetectedAIEventData instance) { }

	public static void SerializeLengthDelimited(Stream stream, PlayerDetectedAIEventData instance) { }

	public void .ctor() { }

}

public class PlayerIdleAnimationRandomiser : StateMachineBehaviour // TypeDefIndex: 8270
{	public int MaxValue; // 0x18
	public static int Param_Random; // 0x0
	private TimeSince lastRandomisation; // 0x1C


	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class BasePlayer : BaseCombatEntity, LootPanel.IHasLootPanel // TypeDefIndex: 8336
{	private Option __menuOption_Climb; // 0x240
	private Option __menuOption_Drink; // 0x298
	private Option __menuOption_InviteToTeam; // 0x2F0
	private Option __menuOption_Menu_AssistPlayer; // 0x348
	private Option __menuOption_Menu_LootPlayer; // 0x3A0
	private Option __menuOption_Promote; // 0x3F8
	private Option __menuOption_SaltWater; // 0x450
	[ClientVar] // RVA: 0x815F0 Offset: 0x809F0 VA: 0x1800815F0
	public static string lootPanelOverride; // 0x0
	private TimeSince lastOpenSoundPlay; // 0x4A8
	public BasePlayer.CameraMode currentViewMode; // 0x4AC
	public BasePlayer.CameraMode selectedViewMode; // 0x4B0
	private Vector3 lastRevivePoint; // 0x4B4
	private Vector3 lastReviveDirection; // 0x4C0
	public PlayerModel playerModel; // 0x4D0
	public bool Frozen; // 0x4D8
	public PlayerVoiceRecorder voiceRecorder; // 0x4E0
	public PlayerVoiceSpeaker voiceSpeaker; // 0x4E8
	public PlayerInput input; // 0x4F0
	public BaseMovement movement; // 0x4F8
	public BaseCollision collision; // 0x500
	private static InputState emptyState; // 0x8
	private GameObject _lookingAt; // 0x508
	private BaseEntity _lookingAtEntity; // 0x510
	private Collider _lookingAtCollider; // 0x518
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector3 <lookingAtPoint>k__BackingField; // 0x520
	private const string playerModelPrefab = "assets/prefabs/player/player_model.prefab";
	private const string playerCollisionPrefab = "assets/prefabs/player/player_collision.prefab";
	private float wakeTime; // 0x52C
	private bool needsClothesRebuild; // 0x530
	private bool wasSleeping; // 0x531
	private bool wokeUpBefore; // 0x532
	private bool wasDead; // 0x533
	private uint lastClothesHash; // 0x534
	private static ListDictionary<ulong, BasePlayer> visiblePlayerList; // 0x10
	public static int craftMode; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <IsWearingDiveGoggles>k__BackingField; // 0x538
	public ViewModel GestureViewModel; // 0x540
	public const float INTERACTION_TICK_RATE = 0,1;
	private RealTimeSince timeSinceUpdatedLookingAt; // 0x548
	private float nextTopologyTestTime; // 0x54C
	private float usePressTime; // 0x550
	private float useHeldTime; // 0x554
	private HitTest lookingAtTest; // 0x558
	public static float lastDeathTimeClient; // 0x1C
	private const float drinkRange = 1,5;
	private const float drinkMovementSpeed = 0,1;
	private Vector3 cachedWaterDrinkingPoint; // 0x560
	public const string GestureCancelString = "cancel";
	public GestureCollection gestureList; // 0x570
	private TimeUntil gestureFinishedTime; // 0x578
	private TimeSince blockHeldInputTimer; // 0x57C
	private GestureConfig currentGesture; // 0x580
	private HeldEntity disabledHeldEntity; // 0x588
	private float nextGestureMenuOpenTime; // 0x590
	private TimeSince lastGestureCancel; // 0x594
	public float client_lastHelloTime; // 0x598
	public ulong currentTeam; // 0x5A0
	public static readonly Translate.Phrase MaxTeamSizeToast; // 0x20
	public PlayerTeam clientTeam; // 0x5A8
	private float lastReceivedTeamTime; // 0x5B0
	private ulong lastPresenceTeamId; // 0x5B8
	private int lastPresenceTeamSize; // 0x5C0
	private string playerGroupKey; // 0x5C8
	private string playerGroupSizeKey; // 0x5D0
	private uint clActiveItem; // 0x5D8
	public MapNote ClientCurrentMapNote; // 0x5E0
	public MapNote ClientCurrentDeathNote; // 0x5E8
	public List<BaseMission.MissionInstance> missions; // 0x5F0
	private int _activeMission; // 0x5F8
	public ModelState modelState; // 0x600
	private EntityRef mounted; // 0x608
	private float nextSeatSwapTime; // 0x618
	public BaseEntity PetEntity; // 0x620
	private float lastPetCommandIssuedTime; // 0x628
	public uint PetPrefabID; // 0x62C
	public uint PetID; // 0x630
	public static bool PetWheelHasBeenOpened; // 0x28
	private float cachedBuildingPrivilegeTime; // 0x634
	private BuildingPrivlidge cachedBuildingPrivilege; // 0x638
	private int maxProjectileID; // 0x640
	private const int WILDERNESS = 1;
	private const int MONUMENT = 2;
	private const int BASE = 4;
	private const int FLYING = 8;
	private const int BOATING = 16;
	private const int SWIMMING = 32;
	private const int DRIVING = 64;
	private float lastUpdateTime; // 0x644
	private float cachedThreatLevel; // 0x648
	public const int serverTickRateDefault = 16;
	public const int clientTickRateDefault = 20;
	public int serverTickRate; // 0x64C
	public int clientTickRate; // 0x650
	public float serverTickInterval; // 0x654
	public float clientTickInterval; // 0x658
	private float lastSentTickTime; // 0x65C
	private Stopwatch lastTickStopwatch; // 0x660
	private PlayerTick lastSentTick; // 0x668
	private float nextVisThink; // 0x670
	private float lastTimeSeen; // 0x674
	private bool debugPrevVisible; // 0x678
	[HeaderAttribute] // RVA: 0xBB9B0 Offset: 0xBADB0 VA: 0x1800BB9B0
	public GameObjectRef fallDamageEffect; // 0x680
	public GameObjectRef drownEffect; // 0x688
	[InspectorFlagsAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public BasePlayer.PlayerFlags playerFlags; // 0x690
	public PlayerEyes eyes; // 0x698
	public PlayerInventory inventory; // 0x6A0
	public PlayerBlueprints blueprints; // 0x6A8
	public PlayerMetabolism metabolism; // 0x6B0
	public PlayerModifiers modifiers; // 0x6B8
	private CapsuleCollider playerCollider; // 0x6C0
	public PlayerBelt Belt; // 0x6C8
	private Rigidbody playerRigidbody; // 0x6D0
	public ulong userID; // 0x6D8
	public string UserIDString; // 0x6E0
	public int gamemodeteam; // 0x6E8
	public int reputation; // 0x6EC
	protected string _displayName; // 0x6F0
	private string _lastSetName; // 0x6F8
	public const float crouchSpeed = 1,7;
	public const float walkSpeed = 2,8;
	public const float runSpeed = 5,5;
	public const float crawlSpeed = 0,72;
	private BasePlayer.CapsuleColliderInfo playerColliderStanding; // 0x700
	private BasePlayer.CapsuleColliderInfo playerColliderDucked; // 0x714
	private BasePlayer.CapsuleColliderInfo playerColliderCrawling; // 0x728
	private BasePlayer.CapsuleColliderInfo playerColliderLyingDown; // 0x73C
	private ProtectionProperties cachedProtection; // 0x750
	public static bool oldCameraFix; // 0x29
	private float lastHeadshotSoundTime; // 0x758
	private float nextColliderRefreshTime; // 0x75C
	public bool clothingBlocksAiming; // 0x760
	public float clothingMoveSpeedReduction; // 0x764
	public float clothingWaterSpeedBonus; // 0x768
	public float clothingAccuracyBonus; // 0x76C
	public bool equippingBlocked; // 0x770
	public float eggVision; // 0x774
	private PhoneController activeTelephone; // 0x778
	public BaseEntity designingAIEntity; // 0x780

	public override bool HasMenuOptions { get; }
	public Translate.Phrase LootPanelTitle { get; }
	internal BasePlayer.CameraMode idealViewMode { get; }
	internal bool shouldDrawBody { get; }
	public GameObject lookingAt { get; }
	public BaseEntity lookingAtEntity { get; }
	public Collider lookingAtCollider { get; }
	public Vector3 lookingAtPoint { get; set; }
	public float TimeAwake { get; }
	public static BufferList<BasePlayer> VisiblePlayerList { get; }
	public bool IsWearingDiveGoggles { get; set; }
	public bool IsReceivingSnapshot { get; }
	public bool IsAdmin { get; }
	public bool IsDeveloper { get; }
	public bool IsAiming { get; }
	public bool IsFlying { get; }
	public bool IsConnected { get; }
	public bool InGesture { get; }
	private bool CurrentGestureBlocksMovement { get; }
	public bool CurrentGestureIsDance { get; }
	public bool CurrentGestureIsFullBody { get; }
	private bool InGestureCancelCooldown { get; }
	public float clientTeamLifetime { get; }
	public bool isMounted { get; }
	public bool isMountingHidingWeapon { get; }
	public Connection Connection { get; }
	public string displayName { get; set; }
	public override BaseEntity.TraitFlag Traits { get; }
	public bool HasActiveTelephone { get; }
	public bool IsDesigningAI { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override bool CanBeLooted(BasePlayer player) { }

	public Translate.Phrase get_LootPanelTitle() { }

	[BaseEntity.Menu] // RVA: 0xBBAB0 Offset: 0xBAEB0 VA: 0x1800BBAB0
	[BaseEntity.Menu.Description] // RVA: 0xBBAB0 Offset: 0xBAEB0 VA: 0x1800BBAB0
	[BaseEntity.Menu.Icon] // RVA: 0xBBAB0 Offset: 0xBAEB0 VA: 0x1800BBAB0
	[BaseEntity.Menu.ShowIf] // RVA: 0xBBAB0 Offset: 0xBAEB0 VA: 0x1800BBAB0
	public void Menu_LootPlayer(BasePlayer player) { }

	public bool Menu_LootPlayer_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void RPC_OpenLootPanel(BaseEntity.RPCMessage rpc) { }

	private void PlayOpenSound() { }

	public bool InFirstPersonMode() { }

	public void UpdateViewMode() { }

	internal BasePlayer.CameraMode get_idealViewMode() { }

	internal bool get_shouldDrawBody() { }

	public virtual void OnViewModeChanged() { }

	public void ModifyCamera() { }

	[BaseEntity.Menu] // RVA: 0xBBDA0 Offset: 0xBB1A0 VA: 0x1800BBDA0
	[BaseEntity.Menu.Description] // RVA: 0xBBDA0 Offset: 0xBB1A0 VA: 0x1800BBDA0
	[BaseEntity.Menu.Icon] // RVA: 0xBBDA0 Offset: 0xBB1A0 VA: 0x1800BBDA0
	[BaseEntity.Menu.ShowIf] // RVA: 0xBBDA0 Offset: 0xBB1A0 VA: 0x1800BBDA0
	public void Menu_AssistPlayer(BasePlayer player) { }

	public void Menu_AssistPlayer_TimeStart() { }

	public bool Menu_AssistPlayer_ShowIf(BasePlayer player) { }

	public GameObject get_lookingAt() { }

	public BaseEntity get_lookingAtEntity() { }

	public Collider get_lookingAtCollider() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Vector3 get_lookingAtPoint() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_lookingAtPoint(Vector3 value) { }

	public override float GetExtrapolationTime() { }

	public override Vector3 GetLocalVelocityClient() { }

	protected override void ClientInit(Entity info) { }

	private void CreatePlayerModel() { }

	private void CreatePlayerCollision() { }

	private void CreatePlayerMovement() { }

	internal void InitLocalPlayer() { }

	internal void InitRemotePlayer() { }

	public bool HasLocalControls() { }

	public override void SetNetworkPosition(Vector3 vPos) { }

	public override void SetNetworkRotation(Quaternion qRot) { }

	protected override void DoClientDestroy() { }

	public override void PostNetworkUpdate() { }

	private void OnFirstWakeUp() { }

	public float get_TimeAwake() { }

	public void CL_ClothingChanged() { }

	public void ForceRebuild() { }

	internal void RebuildWorldModel(PlayerModel pModel) { }

	private void SetDefaultFootstepEffects(PlayerModel pModel) { }

	public override void OnSignal(BaseEntity.Signal signal, string arg) { }

	public override Transform FindBone(string strName) { }

	public override Transform[] GetBones() { }

	public override bool ShouldLerp() { }

	public static BufferList<BasePlayer> get_VisiblePlayerList() { }

	public static void ClearVisibility() { }

	public static void RegisterForVisibility(BasePlayer player) { }

	public static void UnregisterFromVisibility(ulong userID) { }

	public static BasePlayer FindByID_Clientside(ulong userID) { }

	public static BasePlayer Find_Clientside(string strNameOrIDOrIP) { }

	public static float GetRandomFloatBasedOnUserID(ulong steamid, ulong seed) { }

	public override bool DisplayHealthInfo(BasePlayer player) { }

	public override bool ShouldDestroyWithGroup() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void SetInheritedVelocity(Vector3 velocity, uint entID) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void GetPerformanceReport(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void GetPerformanceReport_Frametime(BaseEntity.RPCMessage msg) { }

	public override void OnBecameRagdoll(Ragdoll rdoll) { }

	public override void OnVoiceData(byte[] data) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void RecieveAchievement(string name) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void CraftMode(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void StartDesigningAI(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void OnDebugAIEventTriggeredStateChange(int previousStateContainerID, int newStateContainerID, int sourceEventID) { }

	public override void ClientOnEnable() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void Client_OnRepairFailedResources(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void TakeDamageHit() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void AdminReceivedUGC(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void AdminReceivedPatternFirework(BaseEntity.RPCMessage msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_IsWearingDiveGoggles() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_IsWearingDiveGoggles(bool value) { }

	protected void UpdateClothesIfNeeded() { }

	public override void MakeVisible() { }

	protected void ClientUpdate_Sleeping() { }

	protected void ClientUpdate() { }

	public void RebuildClothingItems() { }

	public void UpdateClothingItems(SkinnedMultiMesh multiMesh) { }

	public void UpdateHolsterOffsets() { }

	public void PostLateClientCycle() { }

	public bool IsLocalPlayer() { }

	public void ClientUpdateLocalPlayer() { }

	public void UpdateTopologyStats() { }

	private void ClientTick() { }

	public void DoMovement() { }

	private void MountableOverrideViewAngles() { }

	public virtual void BlockSprint(float duration = 0,2) { }

	public virtual void BlockJump(float duration = 0,5) { }

	internal virtual void ClientInput(InputState state) { }

	internal void UseAction(InputState state) { }

	internal BaseEntity GetInteractionEntity() { }

	internal void QuickUse() { }

	internal void LongUse() { }

	internal void UseStop() { }

	internal bool UpdateLookingAt(float radius, bool includeSecondaryEntities) { }

	private void ResetLookingAt() { }

	private void SetLookingAt(HitTest lookingAtTest) { }

	private bool CheckLookingAtVisible(HitTest test, TraceInfo trace) { }

	private static BaseVehicle FindVehicleParentFor(BaseEntity entity) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void OnDied(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void OnRespawnInformation(BaseEntity.RPCMessage msg) { }

	private void RequestRespawnUpdates() { }

	public void OnLand(float fVelocity) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void StartLoading() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void FinishLoading() { }

	private void FullBlack_FadeIn() { }

	[IteratorStateMachineAttribute] // RVA: 0xBE780 Offset: 0xBDB80 VA: 0x1800BE780
	private IEnumerator FinishedLoadingRoutine() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void DirectionalDamage(Vector3 position, int damageType, int damageTotal) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void UnlockedBlueprint(BaseEntity.RPCMessage msg) { }

	private void CheckForRespawnInfo() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void UpdateRichPresenceState(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void HandleCompanionPairingResult(BaseEntity.RPCMessage msg) { }

	public Vector3 UpdateWaterDrinkingPoint() { }

	private Vector3 GetWaterDrinkingPoint() { }

	[BaseEntity.Menu] // RVA: 0xBEBF0 Offset: 0xBDFF0 VA: 0x1800BEBF0
	[BaseEntity.Menu.Description] // RVA: 0xBEBF0 Offset: 0xBDFF0 VA: 0x1800BEBF0
	[BaseEntity.Menu.Icon] // RVA: 0xBEBF0 Offset: 0xBDFF0 VA: 0x1800BEBF0
	[BaseEntity.Menu.ShowIf] // RVA: 0xBEBF0 Offset: 0xBDFF0 VA: 0x1800BEBF0
	public void Drink(BasePlayer player) { }

	public bool Drink_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xBEDE0 Offset: 0xBE1E0 VA: 0x1800BEDE0
	[BaseEntity.Menu.Description] // RVA: 0xBEDE0 Offset: 0xBE1E0 VA: 0x1800BEDE0
	[BaseEntity.Menu.Icon] // RVA: 0xBEDE0 Offset: 0xBE1E0 VA: 0x1800BEDE0
	[BaseEntity.Menu.ShowIf] // RVA: 0xBEDE0 Offset: 0xBE1E0 VA: 0x1800BEDE0
	public void SaltWater(BasePlayer player) { }

	public bool SaltWater_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xBEFA0 Offset: 0xBE3A0 VA: 0x1800BEFA0
	[BaseEntity.Menu.Description] // RVA: 0xBEFA0 Offset: 0xBE3A0 VA: 0x1800BEFA0
	[BaseEntity.Menu.Icon] // RVA: 0xBEFA0 Offset: 0xBE3A0 VA: 0x1800BEFA0
	[BaseEntity.Menu.ShowIf] // RVA: 0xBEFA0 Offset: 0xBE3A0 VA: 0x1800BEFA0
	public void Climb(BasePlayer player) { }

	public bool Climb_ShowIf(BasePlayer player) { }

	public bool HasPlayerFlag(BasePlayer.PlayerFlags f) { }

	public bool get_IsReceivingSnapshot() { }

	public bool get_IsAdmin() { }

	public bool get_IsDeveloper() { }

	public bool get_IsAiming() { }

	public bool get_IsFlying() { }

	public bool get_IsConnected() { }

	public bool get_InGesture() { }

	private bool get_CurrentGestureBlocksMovement() { }

	public bool get_CurrentGestureIsDance() { }

	public bool get_CurrentGestureIsFullBody() { }

	private bool get_InGestureCancelCooldown() { }

	private void SetGestureMenuOpen(bool wantsOpen) { }

	private void RequestStartGesture(GestureConfig g) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void Client_StartGesture(BaseEntity.RPCMessage msg) { }

	public void Client_StartGesture(GestureConfig gesture) { }

	private void ProcessDanceAction() { }

	public bool SayingHello() { }

	private void ProcessGestureStart() { }

	private void EndGesture() { }

	private void EndLocalGesture() { }

	private void EndGestureShared() { }

	private void HideHeldEntity(bool state) { }

	private void CancelGesture() { }

	public void RemoteGestureCancel() { }

	private bool CancelGestureInput() { }

	public void ClearGestureCooldown() { }

	public bool ConVarRequestStartGesture(string gestureName) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void Client_RemoteCancelledGesture() { }

	private bool IsGestureBlocked() { }

	public float get_clientTeamLifetime() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void CLIENT_ReceiveTeamInfo(BaseEntity.RPCMessage msg) { }

	private void UpdateSteamGroup(ulong teamId, int teamSize) { }

	private void ClearSteamGroup() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void CLIENT_ClearTeam(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void CLIENT_PendingInvite(BaseEntity.RPCMessage msg) { }

	[BaseEntity.Menu] // RVA: 0xC07C0 Offset: 0xBFBC0 VA: 0x1800C07C0
	[BaseEntity.Menu.Description] // RVA: 0xC07C0 Offset: 0xBFBC0 VA: 0x1800C07C0
	[BaseEntity.Menu.Icon] // RVA: 0xC07C0 Offset: 0xBFBC0 VA: 0x1800C07C0
	[BaseEntity.Menu.ShowIf] // RVA: 0xC07C0 Offset: 0xBFBC0 VA: 0x1800C07C0
	public void InviteToTeam(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xC0D20 Offset: 0xC0120 VA: 0x1800C0D20
	[BaseEntity.Menu.Description] // RVA: 0xC0D20 Offset: 0xC0120 VA: 0x1800C0D20
	[BaseEntity.Menu.Icon] // RVA: 0xC0D20 Offset: 0xC0120 VA: 0x1800C0D20
	[BaseEntity.Menu.ShowIf] // RVA: 0xC0D20 Offset: 0xC0120 VA: 0x1800C0D20
	public void Promote(BasePlayer player) { }

	public void Menu_Promote_Start() { }

	public bool Promote_ShowIf(BasePlayer player) { }

	public static bool LocalPlayerIsLeader() { }

	public bool Invite_ShowIf(BasePlayer player) { }

	public HeldEntity GetHeldEntity() { }

	public bool IsHoldingEntity<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12572D0 Offset: 0x12566D0 VA: 0x1812572D0
	|-BasePlayer.IsHoldingEntity<Hammer>
	|-BasePlayer.IsHoldingEntity<object>
	|-BasePlayer.IsHoldingEntity<WireTool>
	*/

	private Item GetHeldItem() { }

	public uint GetHeldItemID() { }

	private void HeldEntityViewAngles() { }

	private void HeldEntityFrame() { }

	private void HeldEntityInput() { }

	private bool HeldItemUse() { }

	public void HeldEntityStart() { }

	public void HeldEntityEnd() { }

	public bool IsHostileItem(Item item) { }

	public bool IsItemHoldRestricted(Item item) { }

	private void MapInfoOnEnable() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void Client_ReceiveMarkers(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void Client_UpdateDeathMarker(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void Client_AddNewDeathMarker(BaseEntity.RPCMessage msg) { }

	public void AddPointOfInterest(Vector3 position) { }

	public void ClearAllPointsOfInterest() { }

	public void ClearAllMapMarkers() { }

	public bool HasAttemptedMission(uint missionID) { }

	public bool CanAcceptMission(uint missionID) { }

	public bool IsMissionActive(uint missionID) { }

	public bool HasCompletedMission(uint missionID) { }

	public bool HasFailedMission(uint missionID) { }

	public void SetActiveMission(int index) { }

	public int GetActiveMission() { }

	public bool HasActiveMission() { }

	private void LoadMissions(Missions loadedMissions) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void OnModelState(BaseEntity.RPCMessage data) { }

	private void OnModelStateChanged() { }

	public bool get_isMounted() { }

	public bool get_isMountingHidingWeapon() { }

	public BaseMountable GetMounted() { }

	public BaseVehicle GetMountedVehicle() { }

	public void MarkSwapSeat() { }

	public bool SwapSeatCooldown() { }

	public void ClientUpdateMounted(uint id) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void CLIENT_SetPetPrefabID(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void CLIENT_SetPetPetLoadedStateIndex(BaseEntity.RPCMessage msg) { }

	private void LinkPet() { }

	private void SetPetMenuOpen(bool wantsOpen) { }

	private void ClientIssuePetCommand(int cmdType, int param, bool raycast) { }

	public bool IsSleeping() { }

	public bool IsSpectating() { }

	public bool IsRelaxed() { }

	public bool IsServerFalling() { }

	public override BuildingPrivlidge GetBuildingPrivilege() { }

	public bool CanBuild() { }

	public bool CanBuild(Vector3 position, Quaternion rotation, Bounds bounds) { }

	public bool CanBuild(OBB obb) { }

	public bool IsBuildingBlocked() { }

	public bool IsBuildingBlocked(Vector3 position, Quaternion rotation, Bounds bounds) { }

	public bool IsBuildingBlocked(OBB obb) { }

	public bool IsBuildingAuthed() { }

	public bool IsBuildingAuthed(Vector3 position, Quaternion rotation, Bounds bounds) { }

	public bool IsBuildingAuthed(OBB obb) { }

	public bool CanPlaceBuildingPrivilege() { }

	public bool CanPlaceBuildingPrivilege(Vector3 position, Quaternion rotation, Bounds bounds) { }

	public bool CanPlaceBuildingPrivilege(OBB obb) { }

	public int NewProjectileID() { }

	public int NewProjectileSeed() { }

	public void SendProjectileAttack(PlayerProjectileAttack attack) { }

	public void SendProjectileRicochet(PlayerProjectileRicochet ricochet) { }

	public void SendProjectileUpdate(PlayerProjectileUpdate update) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SpectatedPlayerHeadshot() { }

	public override float GetThreatLevel() { }

	public void EnsureUpdated() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void SetHostileLength(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void SetWeaponDrawnDuration(BaseEntity.RPCMessage msg) { }

	protected virtual void ModifyInputState(ref InputState inputState) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void ForcePositionToParentOffset(Vector3 position, uint entID) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void UpdateClientTickRate(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void ForcePositionTo(Vector3 position) { }

	internal void SendVoiceData(byte[] data, int len) { }

	internal void SendClientTick() { }

	public void NotifyUnderwearChange() { }

	public static void UpdatePlayerVisibilities() { }

	private float TimeSinceSeen() { }

	private void SetNextVisThink(float addTime) { }

	private bool WantsVisUpdate() { }

	public static bool IsAimingAt(BasePlayer aimer, BasePlayer target, float cone = 0,95) { }

	protected override void UpdateCullingSpheres() { }

	private void VisUpdateUsingCulling(float dist, bool visibility) { }

	private void VisUpdateUsingRays(float dist) { }

	private void LogDebugCull(float dist) { }

	protected override void OnVisibilityChanged(bool visible) { }

	private void VisUpdate() { }

	private bool VisPlayerArmed() { }

	private bool AnyPartVisible() { }

	private float CalcVisUpdateRate(float dist) { }

	private bool PointSeePoint(Vector3 target, Vector3 origin, float dist = 0, bool useGameTrace = False) { }

	public bool IsWounded() { }

	public bool IsCrawling() { }

	public bool IsIncapacitated() { }

	public override BasePlayer ToPlayer() { }

	public Connection get_Connection() { }

	public string get_displayName() { }

	public void set_displayName(string value) { }

	public static string SanitizePlayerNameString(string playerName, ulong userId) { }

	public bool IsGod() { }

	public override Quaternion GetNetworkRotation() { }

	public bool CanInteract() { }

	public bool CanInteract(bool usableWhileCrawling) { }

	public override float StartHealth() { }

	public override float StartMaxHealth() { }

	public override float MaxHealth() { }

	public override float MaxVelocity() { }

	public override OBB WorldSpaceBounds() { }

	public Vector3 GetMountVelocity() { }

	public override Vector3 GetInheritedProjectileVelocity() { }

	public override Vector3 GetInheritedThrowVelocity() { }

	public override Vector3 GetInheritedDropVelocity() { }

	public override void PreInitShared() { }

	public override void DestroyShared() { }

	public bool InSafeZone() { }

	public static void LateClientCycle() { }

	public static void ClientCycle(float deltaTime) { }

	public Bounds GetBounds(bool ducked) { }

	public Bounds GetBounds() { }

	public Vector3 GetCenter(bool ducked) { }

	public Vector3 GetCenter() { }

	public Vector3 GetOffset(bool ducked) { }

	public Vector3 GetOffset() { }

	public Vector3 GetSize(bool ducked) { }

	public Vector3 GetSize() { }

	public float GetHeight(bool ducked) { }

	public float GetHeight() { }

	public float GetRadius() { }

	public float GetJumpHeight() { }

	public override Vector3 TriggerPoint() { }

	public Vector3 NoClipOffset() { }

	public float NoClipRadius(float margin) { }

	public float MaxDeployDistance(Item item) { }

	public void ClientUpdatePersistantData(PersistantPlayer data) { }

	public float GetMinSpeed() { }

	public float GetMaxSpeed() { }

	public float GetSpeed(float running, float ducking, float crawling) { }

	public override void OnAttacked(HitInfo info) { }

	private void EnablePlayerCollider() { }

	private void DisablePlayerCollider() { }

	private void RefreshColliderSize(bool forced) { }

	private void SetPlayerRigidbodyState(bool isEnabled) { }

	private void AddPlayerRigidbody() { }

	private void RemovePlayerRigidbody() { }

	public bool IsEnsnared() { }

	public bool IsAttacking() { }

	public bool CanAttack() { }

	public bool OnLadder() { }

	public bool IsSwimming() { }

	public bool IsHeadUnderwater() { }

	public virtual bool IsOnGround() { }

	public bool IsRunning() { }

	public bool IsDucked() { }

	public bool RecentlyTeleported() { }

	public void ShowToast(int style, Translate.Phrase phrase) { }

	public void ChatMessage(string msg) { }

	public void ConsoleMessage(string msg) { }

	public override float PenetrationResistance(HitInfo info) { }

	public override void ScaleDamage(HitInfo info) { }

	private void UpdateMoveSpeedFromClothing() { }

	public virtual void UpdateProtectionFromClothing() { }

	public override string Categorize() { }

	public override string ToString() { }

	public string GetDebugStatus() { }

	public override Item GetItem(uint itemId) { }

	public override BaseEntity.TraitFlag get_Traits() { }

	public override float WaterFactor() { }

	public override float AirFactor() { }

	public float GetOxygenTime(out ItemModGiveOxygen.AirSupplyType airSupplyType) { }

	public override bool ShouldInheritNetworkGroup() { }

	public static bool AnyPlayersVisibleToEntity(Vector3 pos, float radius, BaseEntity source, Vector3 entityEyePos, bool ignorePlayersWithPriv = False) { }

	public bool IsStandingOnEntity(BaseEntity standingOn, int layerMask) { }

	public void SetActiveTelephone(PhoneController t) { }

	public bool get_HasActiveTelephone() { }

	public bool get_IsDesigningAI() { }

	public void ClearDesigningAIEntity() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum BasePlayer.CameraMode // TypeDefIndex: 8337
{	public int value__; // 0x0
	public const BasePlayer.CameraMode FirstPerson = 0;
	public const BasePlayer.CameraMode ThirdPerson = 1;
	public const BasePlayer.CameraMode Eyes = 2;
	public const BasePlayer.CameraMode FirstPersonWithArms = 3;
	public const BasePlayer.CameraMode DeathCamClassic = 4;
	public const BasePlayer.CameraMode Last = 3;

}

public enum BasePlayer.PlayerFlags // TypeDefIndex: 8338
{	public int value__; // 0x0
	public const BasePlayer.PlayerFlags Unused1 = 1;
	public const BasePlayer.PlayerFlags Unused2 = 2;
	public const BasePlayer.PlayerFlags IsAdmin = 4;
	public const BasePlayer.PlayerFlags ReceivingSnapshot = 8;
	public const BasePlayer.PlayerFlags Sleeping = 16;
	public const BasePlayer.PlayerFlags Spectating = 32;
	public const BasePlayer.PlayerFlags Wounded = 64;
	public const BasePlayer.PlayerFlags IsDeveloper = 128;
	public const BasePlayer.PlayerFlags Connected = 256;
	public const BasePlayer.PlayerFlags ThirdPersonViewmode = 1024;
	public const BasePlayer.PlayerFlags EyesViewmode = 2048;
	public const BasePlayer.PlayerFlags ChatMute = 4096;
	public const BasePlayer.PlayerFlags NoSprint = 8192;
	public const BasePlayer.PlayerFlags Aiming = 16384;
	public const BasePlayer.PlayerFlags DisplaySash = 32768;
	public const BasePlayer.PlayerFlags Relaxed = 65536;
	public const BasePlayer.PlayerFlags SafeZone = 131072;
	public const BasePlayer.PlayerFlags ServerFall = 262144;
	public const BasePlayer.PlayerFlags Incapacitated = 524288;
	public const BasePlayer.PlayerFlags Workbench1 = 1048576;
	public const BasePlayer.PlayerFlags Workbench2 = 2097152;
	public const BasePlayer.PlayerFlags Workbench3 = 4194304;

}

public enum BasePlayer.MapNoteType // TypeDefIndex: 8339
{	public int value__; // 0x0
	public const BasePlayer.MapNoteType Death = 0;
	public const BasePlayer.MapNoteType PointOfInterest = 1;

}

public enum BasePlayer.TimeCategory // TypeDefIndex: 8340
{	public int value__; // 0x0
	public const BasePlayer.TimeCategory Wilderness = 1;
	public const BasePlayer.TimeCategory Monument = 2;
	public const BasePlayer.TimeCategory Base = 4;
	public const BasePlayer.TimeCategory Flying = 8;
	public const BasePlayer.TimeCategory Boating = 16;
	public const BasePlayer.TimeCategory Swimming = 32;
	public const BasePlayer.TimeCategory Driving = 64;

}

public struct BasePlayer.CapsuleColliderInfo // TypeDefIndex: 8341
{	public float height; // 0x0
	public float radius; // 0x4
	public Vector3 center; // 0x8


	public void .ctor(float height, float radius, Vector3 center) { }

}

private sealed class BasePlayer.<>c // TypeDefIndex: 8342
{	public static readonly BasePlayer.<>c <>9; // 0x0
	public static Func<PlayerTeam.TeamMember, ulong> <>9__103_0; // 0x8
	public static Comparison<TraceInfo> <>9__148_0; // 0x10
	public static Predicate<RespawnInformation.SpawnOptions> <>9__155_0; // 0x18


	private static void .cctor() { }

	public void .ctor() { }

	internal ulong <OnBecameRagdoll>b__103_0(PlayerTeam.TeamMember m) { }

	internal int <UpdateLookingAt>b__148_0(TraceInfo a, TraceInfo b) { }

	internal bool <OnRespawnInformation>b__155_0(RespawnInformation.SpawnOptions p) { }

}

private sealed class BasePlayer.<FinishedLoadingRoutine>d__161 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 8343
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public BasePlayer <>4__this; // 0x20

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class BasePlayer.<>c__DisplayClass210_0 // TypeDefIndex: 8344
{	public GestureConfig g; // 0x10
	public BasePlayer <>4__this; // 0x18


	public void .ctor() { }

	internal void <SetGestureMenuOpen>b__0(BasePlayer ply) { }

}

private sealed class BasePlayer.<>c__DisplayClass304_0 // TypeDefIndex: 8345
{	public uint index; // 0x10


	public void .ctor() { }

	internal bool <CLIENT_SetPetPetLoadedStateIndex>b__0(PetCommandList.PetCommandDesc c) { }

}

private sealed class BasePlayer.<>c__DisplayClass306_0 // TypeDefIndex: 8346
{	public PetCommandList.PetCommandDesc desc; // 0x10
	public BasePlayer <>4__this; // 0x40


	public void .ctor() { }

	internal void <SetPetMenuOpen>b__0(BasePlayer ply) { }

}

public class PlayerInventory : EntityComponent<BasePlayer> // TypeDefIndex: 8620
{	public ItemContainer containerMain; // 0x20
	public ItemContainer containerBelt; // 0x28
	public ItemContainer containerWear; // 0x30
	public ItemCrafter crafting; // 0x38
	public PlayerLoot loot; // 0x40


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	protected void Initialize() { }

	public void DoDestroy() { }

	public void ClientInit(BasePlayer owner) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void UpdatedItemContainer(BaseEntity.RPCMessage packet) { }

	public Item FindItemUID(uint id) { }

	public Item FindItemID(string itemName) { }

	public Item FindItemID(int id) { }

	public Item FindBySubEntityID(uint subEntityID) { }

	public List<Item> FindItemIDs(int id) { }

	public ItemContainer FindContainer(uint id) { }

	public ItemContainer GetContainer(PlayerInventory.Type id) { }

	public void Load(PlayerInventory msg) { }

	public int GetAmount(int itemid) { }

	public Item[] AllItems() { }

	public int AllItemsNoAlloc(ref List<Item> items) { }

	public void FindAmmo(List<Item> list, AmmoTypes ammoType) { }

	public bool HasAmmo(AmmoTypes ammoType) { }

	public void .ctor() { }

}

public enum PlayerInventory.Type // TypeDefIndex: 8621
{	public int value__; // 0x0
	public const PlayerInventory.Type Main = 0;
	public const PlayerInventory.Type Belt = 1;
	public const PlayerInventory.Type Wear = 2;

}

public class PlayerLoot : EntityComponent<BasePlayer> // TypeDefIndex: 8622
{	public BaseEntity entitySource; // 0x20
	public Item itemSource; // 0x28
	public List<ItemContainer> containers; // 0x30
	private EntityRef clientEntity; // 0x38


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public bool IsLooting() { }

	public void Clear() { }

	public ItemContainer FindContainer(uint id) { }

	public Item FindItem(uint id) { }

	public BaseEntity GetClientEntity() { }

	public void ClientInit(BasePlayer owner) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void UpdateLoot(BaseEntity.RPCMessage rpc) { }

	public void .ctor() { }

}

public class PlayerMetabolism : BaseMetabolism<BasePlayer> // TypeDefIndex: 8623
{	public const float HotThreshold = 40;
	public const float ColdThreshold = 5;
	public const float OxygenHurtThreshold = 0,5;
	public const float OxygenDepleteTime = 10;
	public const float OxygenRefillTime = 1;
	public MetabolismAttribute temperature; // 0x40
	public MetabolismAttribute poison; // 0x48
	public MetabolismAttribute radiation_level; // 0x50
	public MetabolismAttribute radiation_poison; // 0x58
	public MetabolismAttribute wetness; // 0x60
	public MetabolismAttribute dirtyness; // 0x68
	public MetabolismAttribute oxygen; // 0x70
	public MetabolismAttribute bleeding; // 0x78
	public MetabolismAttribute comfort; // 0x80
	public MetabolismAttribute pending_health; // 0x88
	public bool isDirty; // 0x90
	private float lastConsumeTime; // 0x94
	private float lastUpdateTime; // 0x98


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void Reset() { }

	public bool CanConsume() { }

	public void MarkConsumption() { }

	public void ClientInit(BasePlayer owner) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void UpdateMetabolism(BaseEntity.RPCMessage packet) { }

	public PlayerMetabolism Save() { }

	public void Load(PlayerMetabolism s) { }

	public override MetabolismAttribute FindAttribute(MetabolismAttribute.Type type) { }

	public void OnLocalMetabolismUpdated() { }

	public void .ctor() { }

}

public class PlayerModifiers : BaseModifiers<BasePlayer> // TypeDefIndex: 8624
{
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public void Load(PlayerModifiers m) { }

	public void ClientInit(BasePlayer owner) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void UpdateModifiers(BaseEntity.RPCMessage packet) { }

	public void .ctor() { }

}

public class PlayerDetectionTrigger : TriggerBase // TypeDefIndex: 8703
{	public BaseDetector myDetector; // 0x30


	public void .ctor() { }

}

public class PlayerModelHair : MonoBehaviour // TypeDefIndex: 9213
{	public HairType type; // 0x18
	private Dictionary<Renderer, PlayerModelHair.RendererMaterials> materials; // 0x20

	public Dictionary<Renderer, PlayerModelHair.RendererMaterials> Materials { get; }


	public Dictionary<Renderer, PlayerModelHair.RendererMaterials> get_Materials() { }

	private void CacheOriginalMaterials() { }

	private void Setup(HairType type, HairSetCollection hair, int meshIndex, float typeNum, float dyeNum, MaterialPropertyBlock block) { }

	public void Setup(SkinSetCollection skin, float hairNum, float meshNum, MaterialPropertyBlock block) { }

	public static void GetRandomVariation(float hairNum, int typeIndex, int meshIndex, out float typeNum, out float dyeNum) { }

	public static float GetRandomHairType(float hairNum, int typeIndex) { }

	public void .ctor() { }

}

public struct PlayerModelHair.RendererMaterials // TypeDefIndex: 9214
{	public string[] names; // 0x0
	public Material[] original; // 0x8
	public Material[] replacement; // 0x10


	public void .ctor(Renderer r) { }

}

public class PlayerModelHairCap : MonoBehaviour // TypeDefIndex: 9216
{	[InspectorFlagsAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public HairCapMask hairCapMask; // 0x18


	public void SetupHairCap(SkinSetCollection skin, float hairNum, float meshNum, MaterialPropertyBlock block) { }

	public void .ctor() { }

}

public class PlayerModelSkin : MonoBehaviour, IPrefabPreProcess // TypeDefIndex: 9217
{	public PlayerModelSkin.SkinMaterialType MaterialType; // 0x18
	public Renderer SkinRenderer; // 0x20


	public void Setup(SkinSetCollection skin, float hairNum, float meshNum) { }

	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public void .ctor() { }

}

public enum PlayerModelSkin.SkinMaterialType // TypeDefIndex: 9218
{	public int value__; // 0x0
	public const PlayerModelSkin.SkinMaterialType HEAD = 0;
	public const PlayerModelSkin.SkinMaterialType EYE = 1;
	public const PlayerModelSkin.SkinMaterialType BODY = 2;

}

public class PlayerDetectedAIEvent : BaseAIEvent // TypeDefIndex: 9407
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <Range>k__BackingField; // 0x40

	public float Range { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public float get_Range() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Range(float value) { }

	public void .ctor() { }

}

public class PlayerAnimationEvents : MonoBehaviour // TypeDefIndex: 9644
{	private BasePlayer player; // 0x18


	protected void OnEnable() { }

	public void ThirdPersonReloadSound(AnimationEvent animEvent) { }

	public void ThirdPersonMeleeAttackSound(AnimationEvent animEvent) { }

	public void ThirdPersonDeploySound(AnimationEvent animEvent) { }

	public void ThirdPersonLiquidThrowSound(AnimationEvent animEvent) { }

	public void PlayThirdPersonSound(SoundDefinition def) { }

	public bool ShouldPlayThirdPersonSounds() { }

	public void SleepingEvent(AnimationEvent animEvent) { }

	public void SplashEvent(string splashType) { }

	public void WaterInflatableMovementSound(string type) { }

	public void .ctor() { }

}

public class PlayerBelt // TypeDefIndex: 9645
{	public static int SelectedSlot; // 0x0
	protected BasePlayer player; // 0x10

	public static int MaxBeltSlots { get; }


	public static int get_MaxBeltSlots() { }

	public void .ctor(BasePlayer player) { }

	public Item GetItemInSlot(int slot) { }

	public Item GetActiveItem() { }

	public bool CanHoldItem() { }

	public void FrameUpdate() { }

	public void ChangeSelect(int iSlot, bool allowRunAction = False) { }

	public void DoNextItemDirection(InputState state, int direction) { }

	public void ClientInput(InputState state) { }

	private static void .cctor() { }

}

public class PlayerBlueprints : EntityComponent<BasePlayer> // TypeDefIndex: 9646
{	public SteamInventory steamInventory; // 0x20
	private int[] craftableItems; // 0x28


	public void ClientInit() { }

	public void ClientUpdate(PersistantPlayer info) { }

	public bool HasUnlocked(ItemDefinition targetItem) { }

	public bool CanCraft(int itemid, int skinItemId, ulong playerId) { }

	public bool CheckSkinOwnership(int skinItemId, ulong playerId) { }

	public void .ctor() { }

}

public class PlayerEyes : EntityComponent<BasePlayer> // TypeDefIndex: 9647
{	public static readonly Vector3 EyeOffset; // 0x0
	public static readonly Vector3 DuckOffset; // 0xC
	public static readonly Vector3 CrawlOffset; // 0x18
	public Vector3 thirdPersonSleepingOffset; // 0x20
	public LazyAimProperties defaultLazyAim; // 0x30
	private Vector3 viewOffset; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Quaternion <bodyRotation>k__BackingField; // 0x44
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector3 <headAngles>k__BackingField; // 0x54
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Quaternion <rotationLook>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <IsAltLookingLegsThreshold>k__BackingField; // 0x70

	public Vector3 worldMountedPosition { get; }
	public Vector3 worldStandingPosition { get; }
	public Vector3 worldCrouchedPosition { get; }
	public Vector3 worldCrawlingPosition { get; }
	public Vector3 position { get; }
	private Vector3 BodyLeanOffset { get; }
	public Vector3 center { get; }
	public Vector3 offset { get; }
	public Quaternion rotation { get; set; }
	public Quaternion bodyRotation { get; set; }
	public Vector3 headAngles { get; set; }
	public Quaternion rotationLook { get; set; }
	public Quaternion parentRotation { get; }
	public bool canUpdateViewAngles { get; }
	public bool IsAltLookingLegsThreshold { get; set; }


	public Vector3 get_worldMountedPosition() { }

	public Vector3 get_worldStandingPosition() { }

	public Vector3 get_worldCrouchedPosition() { }

	public Vector3 get_worldCrawlingPosition() { }

	public Vector3 get_position() { }

	private Vector3 get_BodyLeanOffset() { }

	public Vector3 get_center() { }

	public Vector3 get_offset() { }

	public Quaternion get_rotation() { }

	public void set_rotation(Quaternion value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Quaternion get_bodyRotation() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_bodyRotation(Quaternion value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Vector3 get_headAngles() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_headAngles(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Quaternion get_rotationLook() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_rotationLook(Quaternion value) { }

	public Quaternion get_parentRotation() { }

	public bool get_canUpdateViewAngles() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_IsAltLookingLegsThreshold() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_IsAltLookingLegsThreshold(bool value) { }

	public void FrameUpdate(Camera cam) { }

	public void UpdateAltLegsThreshold(float yAngle) { }

	private void UpdateCamera(Camera cam) { }

	private void DoFirstPersonCamera(Camera cam) { }

	private void DoInEyeCamera(Camera cam) { }

	private void DoThirdPersonCamera(Camera cam) { }

	private void DoDeathCamera(Camera cam) { }

	private void ApplyCameraMoves(Camera cam) { }

	public Vector3 MovementForward() { }

	public Vector3 MovementRight() { }

	public Ray BodyRay() { }

	public Vector3 BodyForward() { }

	public Vector3 BodyRight() { }

	public Vector3 BodyUp() { }

	public Ray HeadRay() { }

	public Vector3 HeadForward() { }

	public Vector3 HeadRight() { }

	public Vector3 HeadUp() { }

	public Quaternion GetLookRotation() { }

	public Quaternion GetAimRotation() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class PlayerInput : EntityComponent<BasePlayer> // TypeDefIndex: 9648
{	public InputState state; // 0x20
	public bool hadInputBuffer; // 0x28
	private Quaternion bodyRotation; // 0x2C
	private Vector3 bodyAngles; // 0x3C
	private Quaternion headRotation; // 0x48
	private Vector3 headAngles; // 0x58
	public Vector3 recoilAngles; // 0x64
	public Vector2 viewDelta; // 0x70
	private float headLerp; // 0x78
	private int mouseWheelUp; // 0x7C
	private int mouseWheelDn; // 0x80
	private bool autorun; // 0x84
	private bool toggleDuck; // 0x85
	private bool toggleAds; // 0x86
	private uint lastAdsEntity; // 0x88
	private Vector3 pendingMouseDelta; // 0x8C
	public Vector3 offsetAngles; // 0x98
	private int ignoredButtons; // 0xA4
	private bool hasKeyFocus; // 0xA8

	private bool hasOnlyPartialKeyInput { get; }
	public static bool hasNoKeyInput { get; }


	protected void OnDisable() { }

	public void FrameUpdate() { }

	private bool CanToggleAds() { }

	private void Flip() { }

	public void ResetMouseDelta() { }

	private void AddMouseDelta() { }

	private void AdjustMouseMovement(ref Vector2 mm) { }

	private void UpdateViewAngles() { }

	public void ApplyViewAngles() { }

	public void SetViewVars(Vector3 newAngles) { }

	public void FinalizeRecoil() { }

	public void ResetOffsetAngles() { }

	public Quaternion ClientAngles() { }

	public Vector3 ClientLookVars() { }

	public Quaternion HeadAngles() { }

	public Vector3 HeadLookVars() { }

	private void ModifyInputState(InputMessage state) { }

	internal bool IsButtonDownNative(BUTTON btn) { }

	private InputMessage BuildInputState(bool allowModify = True) { }

	private bool IsAiming() { }

	private void UpdateButton(InputMessage state, BUTTON btn) { }

	public void IgnoreCurrentButtons() { }

	private bool get_hasOnlyPartialKeyInput() { }

	public static bool get_hasNoKeyInput() { }

	private void UpdateKeyFocus(bool hasFocus) { }

	public static void IgnoreCurrentKeys() { }

	public void .ctor() { }

}

public class PlayerModel : ListComponent<PlayerModel>, IOnParentDestroying // TypeDefIndex: 9649
{	public static float pm_uplimit; // 0x0
	public static float pm_downlimit; // 0x4
	public static float pm_upspine; // 0x8
	public static float pm_downspine; // 0xC
	public static Vector3 pm_lookoffset; // 0x10
	public static float pm_anglesmoothspeed; // 0x1C
	public static float pm_nohold; // 0x20
	public static float pm_ladder; // 0x24
	public static float pm_minweight; // 0x28
	private float _smoothAimWeight; // 0x18
	private float _smoothVelocity; // 0x1C
	private Vector3 _smoothlookAngle; // 0x20
	private bool allowMountedHeadLook; // 0x2C
	private Vector3 smoothLookDir; // 0x30
	private Vector3 lastSafeLookDir; // 0x3C
	public Transform[] Shoulders; // 0x48
	public Transform[] AdditionalSpineBones; // 0x50
	private static readonly HashSet<Wearable> FinishedLegWearables; // 0x30
	protected List<SkinnedMeshRenderer> LegParts; // 0x58
	private Transform[] fakeSpineBones; // 0x60
	private float extraLeanBack; // 0x68
	private Nullable<bool> drawState; // 0x6C
	private float timeInArmsMode; // 0x70
	protected static int speed; // 0x38
	protected static int acceleration; // 0x3C
	protected static int rotationYaw; // 0x40
	protected static int forward; // 0x44
	protected static int right; // 0x48
	protected static int up; // 0x4C
	protected static int ducked; // 0x50
	protected static int grounded; // 0x54
	protected static int crawling; // 0x58
	protected static int waterlevel; // 0x5C
	protected static int attack; // 0x60
	protected static int attack_alt; // 0x64
	protected static int deploy; // 0x68
	protected static int reload; // 0x6C
	protected static int throwWeapon; // 0x70
	protected static int holster; // 0x74
	protected static int aiming; // 0x78
	protected static int onLadder; // 0x7C
	protected static int posing; // 0x80
	protected static int poseType; // 0x84
	protected static int relaxGunPose; // 0x88
	protected static int vehicle_aim_yaw; // 0x8C
	protected static int vehicle_aim_speed; // 0x90
	protected static int onPhone; // 0x94
	protected static int usePoseTransition; // 0x98
	protected static int leftFootIK; // 0x9C
	protected static int rightFootIK; // 0xA0
	protected static int vehicleSteering; // 0xA4
	protected static int sitReaction; // 0xA8
	protected static int forwardReaction; // 0xAC
	protected static int rightReaction; // 0xB0
	public BoxCollider collision; // 0x78
	public GameObject censorshipCube; // 0x80
	public GameObject censorshipCubeBreasts; // 0x88
	public GameObject jawBone; // 0x90
	public GameObject neckBone; // 0x98
	public GameObject headBone; // 0xA0
	public EyeController eyeController; // 0xA8
	public EyeBlink blinkController; // 0xB0
	public Transform[] SpineBones; // 0xB8
	public Transform leftFootBone; // 0xC0
	public Transform rightFootBone; // 0xC8
	public Transform leftHandPropBone; // 0xD0
	public Transform rightHandPropBone; // 0xD8
	public Vector3 rightHandTarget; // 0xE0
	[HeaderAttribute] // RVA: 0x7F380 Offset: 0x7E780 VA: 0x18007F380
	public Vector3 leftHandTargetPosition; // 0xEC
	public Quaternion leftHandTargetRotation; // 0xF8
	public Vector3 rightHandTargetPosition; // 0x108
	public Quaternion rightHandTargetRotation; // 0x114
	public float steeringTargetDegrees; // 0x124
	public Vector3 rightFootTargetPosition; // 0x128
	public Quaternion rightFootTargetRotation; // 0x134
	public Vector3 leftFootTargetPosition; // 0x144
	public Quaternion leftFootTargetRotation; // 0x150
	public RuntimeAnimatorController CinematicAnimationController; // 0x160
	public Avatar DefaultAvatar; // 0x168
	public Avatar CinematicAvatar; // 0x170
	public RuntimeAnimatorController DefaultHoldType; // 0x178
	public RuntimeAnimatorController SleepGesture; // 0x180
	public RuntimeAnimatorController CrawlToIncapacitatedGesture; // 0x188
	public RuntimeAnimatorController StandToIncapacitatedGesture; // 0x190
	public RuntimeAnimatorController CurrentGesture; // 0x198
	[HeaderAttribute] // RVA: 0x7F400 Offset: 0x7E800 VA: 0x18007F400
	public SkinSetCollection MaleSkin; // 0x1A0
	public SkinSetCollection FemaleSkin; // 0x1A8
	public SubsurfaceProfile subsurfaceProfile; // 0x1B0
	[HeaderAttribute] // RVA: 0x7F5E0 Offset: 0x7E9E0 VA: 0x18007F5E0
	[RangeAttribute] // RVA: 0x7F5E0 Offset: 0x7E9E0 VA: 0x18007F5E0
	public float voiceVolume; // 0x1B8
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float skinColor; // 0x1BC
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float skinNumber; // 0x1C0
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float meshNumber; // 0x1C4
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float hairNumber; // 0x1C8
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public int skinType; // 0x1CC
	public MovementSounds movementSounds; // 0x1D0
	public bool showSash; // 0x1D8
	public int tempPoseType; // 0x1DC
	public uint underwearSkin; // 0x1E0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ulong <overrideSkinSeed>k__BackingField; // 0x1E8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Quaternion <AimAngles>k__BackingField; // 0x1F0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Quaternion <LookAngles>k__BackingField; // 0x200
	private const int LayerHands = 1;
	private const int LayerGestures = 2;
	private const int LayerPlayerGesturesUpperBody = 3;
	private const int LayerPlayerGesturesFullBody = 4;
	private const int LayerReactions = 5;
	private ModelState modelState; // 0x210
	internal Vector3 position; // 0x218
	internal Vector3 velocity; // 0x224
	internal Vector3 speedOverride; // 0x230
	private Vector3 newVelocity; // 0x23C
	internal Quaternion rotation; // 0x248
	internal Quaternion mountedRotation; // 0x258
	internal Vector3 smoothLeftFootIK; // 0x268
	internal Vector3 smoothRightFootIK; // 0x274
	internal bool drawShadowOnly; // 0x280
	internal bool isIncapacitated; // 0x281
	internal uint flinchLocation; // 0x284
	internal bool visible; // 0x288
	internal PlayerNameTag nameTag; // 0x290
	private bool animatorNeedsWarmup; // 0x298
	internal bool isLocalPlayer; // 0x299
	private SoundDefinition aimSoundDef; // 0x2A0
	private SoundDefinition aimEndSoundDef; // 0x2A8
	private bool InGesture; // 0x2B0
	private GestureConfig CurrentGestureConfig; // 0x2B8
	private bool InCinematic; // 0x2C0
	private RuntimeAnimatorController defaultAnimatorController; // 0x2C8
	private SkinnedMultiMesh _multiMesh; // 0x2D0
	private Animator _animator; // 0x2D8
	private LODGroup _lodGroup; // 0x2E0
	private RuntimeAnimatorController _currentGesture; // 0x2E8
	private float holdTypeLock; // 0x2F0
	private bool hasHeldEntity; // 0x2F4
	private bool wasMountedRightAim; // 0x2F5
	private int cachedMask; // 0x2F8
	private int cachedConstructionMask; // 0x2FC
	private HeldEntity WorkshopHeldEntity; // 0x300
	private bool wasCrawling; // 0x308
	private float mountedSpineLookWeight; // 0x30C
	private float mountedAnimSpeed; // 0x310
	private bool preserveBones; // 0x314
	private Nullable<float> downLimitOverride; // 0x318
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <IsNpc>k__BackingField; // 0x320
	private TimeSince timeSinceReactionStart; // 0x324
	private TimeSince timeSinceLeftFootTest; // 0x328
	private Vector3 cachedLeftFootPos; // 0x32C
	private Vector3 cachedLeftFootNormal; // 0x338
	private TimeSince timeSinceRightFootTest; // 0x344
	private Vector3 cachedRightFootPos; // 0x348
	private Vector3 cachedRightFootNormal; // 0x354

	public bool ShouldDoLegs { get; }
	public bool ShouldShowHands { get; }
	public ulong overrideSkinSeed { get; set; }
	public bool IsFemale { get; }
	public SkinSetCollection SkinSet { get; }
	public Quaternion AimAngles { get; set; }
	public Quaternion LookAngles { get; set; }
	private bool GestureAllowsSpineMovement { get; }
	private bool GestureAllowsRootMotion { get; }
	public bool IsFirstPerson { get; }
	public bool IsNpc { get; set; }
	public SkinnedMultiMesh multiMesh { get; }
	public Animator animator { get; }
	public LODGroup lodGroup { get; }


	public void SetMountedLookAtOverride(bool state) { }

	private void SpineIk() { }

	private void ParentArmsToCamera() { }

	private void OnAnimatorIK() { }

	private void HandIK(float cameraDistSq) { }

	private void FootIK(float cameraDistSq) { }

	private void HeadIK(float cameraDistSq) { }

	public bool get_ShouldDoLegs() { }

	public bool get_ShouldShowHands() { }

	private void ClearLegs() { }

	public void RebuildLegs() { }

	private void InitializeLegSpineBones() { }

	private void UpdateLegsBeforeRender() { }

	private void UpdateLegsDisable(bool forceDisable = False) { }

	private void AddLegRenderer(SkinnedMeshRenderer renderer, PaintableItem paintable) { }

	private Transform SwapLegBone(Transform bone) { }

	private static Vector3 GetFlat(Vector3 dir) { }

	public static void RebuildAll() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public ulong get_overrideSkinSeed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_overrideSkinSeed(ulong value) { }

	public bool get_IsFemale() { }

	public SkinSetCollection get_SkinSet() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Quaternion get_AimAngles() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_AimAngles(Quaternion value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Quaternion get_LookAngles() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_LookAngles(Quaternion value) { }

	private bool get_GestureAllowsSpineMovement() { }

	private bool get_GestureAllowsRootMotion() { }

	public bool get_IsFirstPerson() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_IsNpc() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_IsNpc(bool value) { }

	public SkinnedMultiMesh get_multiMesh() { }

	public Animator get_animator() { }

	public LODGroup get_lodGroup() { }

	public Vector3 GetTargetVelocity() { }

	protected void Awake() { }

	protected override void OnEnable() { }

	protected override void OnDisable() { }

	private void SetDefaultAnimatorWeights() { }

	private void UpdateMultiMesh(bool reset) { }

	private void UpdateCensorship() { }

	public void UpdateCollider(bool visible, bool sleeping, bool ducking, bool crawling, bool incapacitated) { }

	public void UpdateModelState(ModelState ms) { }

	public void UpdatePosition() { }

	internal void UpdateRotation() { }

	public void UpdateLocalVelocity(Vector3 velocity, Transform parent) { }

	public void UpdateVelocity() { }

	private void UpdateParameters() { }

	public void UpdateFrom(PlayerModel mdl) { }

	private void UpdateGlobalShaderConstants() { }

	public void LateCycle() { }

	public void FrameUpdate() { }

	private void FrameUpdate_Default() { }

	private void FrameUpdate_Sleeping() { }

	private void FrameUpdate_Incapacitated() { }

	private void FrameUpdate_OnLadder() { }

	public float GetAim360() { }

	public void UpdateVehicleAim360() { }

	public void ResetCurrentState(int layer = 0) { }

	private void DoAimingSounds(float prevAiming, float currentAiming) { }

	public void SetAimSounds(SoundDefinition aimDef, SoundDefinition aimEndDef) { }

	public void SetMountedLookAtWeight(float weight) { }

	public void SetMountedAnimationSpeed(float speed) { }

	internal void UpdateLocalPlayerPosition(Vector3 position, Quaternion quaternion) { }

	public void Attack() { }

	public void AltAttack() { }

	public void Deploy() { }

	public void Reload() { }

	public void Holster() { }

	public void Flinch(uint location) { }

	public void Flinch() { }

	public void SetReactionAnim(PlayerModel.ReactionDir direction, float weight) { }

	public void OnReactionEnded() { }

	public void Throw() { }

	public void Gesture(string gesture, GestureConfig forConfig) { }

	private void FadeInGestureUpperBodyLayer() { }

	private void FadeOutGestureUpperBodyLayer() { }

	private void FadeInGestureFullBodyLayer() { }

	private void FadeOutGestureFullBodyLayer() { }

	private void AnimatorWarmup() { }

	public void AlwaysAnimate(bool b) { }

	public void SetHoldType(RuntimeAnimatorController holdType, bool suppressHandLayer = False) { }

	public void SetHasHeldEntity(bool state) { }

	[IteratorStateMachineAttribute] // RVA: 0x80770 Offset: 0x7FB70 VA: 0x180080770
	public IEnumerator FadeOutGestureLayer() { }

	public void SetGesture() { }

	public void FadeOutPlayerGestureLayers() { }

	public void StopGesture() { }

	public void PlayCinematic(string name, float overrideSpeed = 1) { }

	public void StopCinematic() { }

	public void SetSpeedOverride(Vector3 speed) { }

	public Underwear GetReplacementUnderwear() { }

	public void RemoveUnderwearParts(SkinReplacement.SkinType typeToRemove) { }

	public void Clear() { }

	public void Rebuild(bool reset = True) { }

	public void AddPart(string strName, Item item) { }

	public void RemovePart(string strName) { }

	public bool HasPart(string strName) { }

	public bool IsBarefoot() { }

	public Color GetSkinColor() { }

	public void SetSkinProperties(MaterialPropertyBlock block) { }

	public void RefreshUnderwear() { }

	public void ForceModelSeed(ulong userID) { }

	public void ForceModelSeed(ulong userID, bool storeSkinChange) { }

	public Transform FindBone(string strName) { }

	public Transform[] GetBones() { }

	private Vector3 GetFootPlacement(Vector3 footPos, out Vector3 surfaceNormal) { }

	public void ApplyVisibility(bool vis, bool animatorVis, bool shadowVis) { }

	public void ToggleUpdateOffscreen(bool state) { }

	public void OnParentDestroying() { }

	public void WorkshopPreviewSetup(GameObject[] objects) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum PlayerModel.MountPoses // TypeDefIndex: 9650
{	public int value__; // 0x0
	public const PlayerModel.MountPoses Chair = 0;
	public const PlayerModel.MountPoses Driving = 1;
	public const PlayerModel.MountPoses Horseback = 2;
	public const PlayerModel.MountPoses HeliUnarmed = 3;
	public const PlayerModel.MountPoses HeliArmed = 4;
	public const PlayerModel.MountPoses HandMotorBoat = 5;
	public const PlayerModel.MountPoses MotorBoatPassenger = 6;
	public const PlayerModel.MountPoses SitGeneric = 7;
	public const PlayerModel.MountPoses SitRaft = 8;
	public const PlayerModel.MountPoses StandDrive = 9;
	public const PlayerModel.MountPoses SitShootingGeneric = 10;
	public const PlayerModel.MountPoses SitMinicopter_Pilot = 11;
	public const PlayerModel.MountPoses SitMinicopter_Passenger = 12;
	public const PlayerModel.MountPoses ArcadeLeft = 13;
	public const PlayerModel.MountPoses ArcadeRight = 14;
	public const PlayerModel.MountPoses SitSummer_Ring = 15;
	public const PlayerModel.MountPoses SitSummer_BoogieBoard = 16;
	public const PlayerModel.MountPoses SitCarPassenger = 17;
	public const PlayerModel.MountPoses SitSummer_Chair = 18;
	public const PlayerModel.MountPoses SitRaft_NoPaddle = 19;
	public const PlayerModel.MountPoses Sit_SecretLab = 20;
	public const PlayerModel.MountPoses Sit_Workcart = 21;
	public const PlayerModel.MountPoses Sit_Cardgame = 22;
	public const PlayerModel.MountPoses Sit_Crane = 23;
	public const PlayerModel.MountPoses Sit_Snowmobile_Shooting = 24;
	public const PlayerModel.MountPoses Sit_RetroSnowmobile_Shooting = 25;
	public const PlayerModel.MountPoses Driving_Snowmobile = 26;
	public const PlayerModel.MountPoses ZiplineHold = 27;
	public const PlayerModel.MountPoses Sit_Locomotive = 28;
	public const PlayerModel.MountPoses Standing = 128;

}

public enum PlayerModel.ReactionDir // TypeDefIndex: 9651
{	public int value__; // 0x0
	public const PlayerModel.ReactionDir North = 0;
	public const PlayerModel.ReactionDir South = 1;
	public const PlayerModel.ReactionDir East = 2;
	public const PlayerModel.ReactionDir West = 3;

}

private sealed class PlayerModel.<>c // TypeDefIndex: 9652
{	public static readonly PlayerModel.<>c <>9; // 0x0
	public static Func<Wearable, bool> <>9__199_0; // 0x8
	public static Func<Wearable, bool> <>9__199_1; // 0x10
	public static Func<Wearable, bool> <>9__199_2; // 0x18


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <UpdateCensorship>b__199_0(Wearable x) { }

	internal bool <UpdateCensorship>b__199_1(Wearable x) { }

	internal bool <UpdateCensorship>b__199_2(Wearable y) { }

}

private sealed class PlayerModel.<FadeOutGestureLayer>d__244 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9653
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PlayerModel <>4__this; // 0x20

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class PlayerModel.<>c__DisplayClass256_0 // TypeDefIndex: 9654
{	public string strName; // 0x10


	public void .ctor() { }

	internal bool <RemovePart>b__0(SkinnedMultiMesh.Part x) { }

}

private sealed class PlayerModel.<>c__DisplayClass257_0 // TypeDefIndex: 9655
{	public string strName; // 0x10


	public void .ctor() { }

	internal bool <HasPart>b__0(SkinnedMultiMesh.Part x) { }

}

public class PlayerModelCinematicList : PrefabAttribute, IClientComponent // TypeDefIndex: 9656
{	public PlayerModelCinematicList.PlayerModelCinematicAnimation[] Animations; // 0x98


	protected override Type GetIndexedType() { }

	public override void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public void .ctor() { }

}

public struct PlayerModelCinematicList.PlayerModelCinematicAnimation // TypeDefIndex: 9657
{	public string StateName; // 0x0
	public string ClipName; // 0x8
	public float Length; // 0x10

}

public class PlayerModelReactionEnded : StateMachineBehaviour // TypeDefIndex: 9658
{	private PlayerModel playerModel; // 0x18


	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public void .ctor() { }

}

public class PlayerNameTag : MonoBehaviour // TypeDefIndex: 9659
{	public CanvasGroup canvasGroup; // 0x18
	public Text text; // 0x20
	public Gradient color; // 0x28
	public float minDistance; // 0x30
	public float maxDistance; // 0x34
	public Vector3 positionOffset; // 0x38
	public Transform parentBone; // 0x48
	private float distanceFromCamera; // 0x50
	internal string lastName; // 0x58


	public void Initialize(BasePlayer player, Transform parent) { }

	public void UpdateFrom(BasePlayer player) { }

	private void LateUpdate() { }

	private void UpdateNameColor() { }

	public void PositionUpdate(bool visible) { }

	public void .ctor() { }

}

public class PlayerVoiceRecorder : EntityComponent<BasePlayer> // TypeDefIndex: 9661
{	internal static byte[] readBuffer; // 0x0
	internal static byte[] readBufferUncompressed; // 0x8
	private RealTimeSince timeSinceLastSpeak; // 0x20
	private RealTimeSince timeSinceLastCheck; // 0x24
	private Stopwatch TalkTimer; // 0x28

	public bool IsSpeaking { get; }


	public bool get_IsSpeaking() { }

	public void ClientFrame(BasePlayer player) { }

	public void ClientInput(InputState state) { }

	private bool DoesUserWantToTalk() { }

	public bool CanTalk() { }

	public void StopRecording() { }

	public void StartRecording() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class PlayerVoiceSpeaker : EntityComponent<BasePlayer> // TypeDefIndex: 9662
{	public VoiceProcessor voiceProcessor; // 0x20
	private float nextSpeechFakeChange; // 0x28
	private float speechFakeChangeMulti; // 0x2C
	private bool isFakingVolume; // 0x30
	private float fakedVolume; // 0x34
	private static bool hasAwardedRecordVoicesAchievement; // 0x0

	public float currentVolume { get; }


	public float get_currentVolume() { }

	public bool IsSpeaking() { }

	public void Receive(byte[] data) { }

	public float GetMouthVolume() { }

	public void ClientFrame() { }

	public bool ShouldMuteVoice() { }

	private bool IsPlayingLocalVoice() { }

	public bool ShouldReceiveVoice() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class PlayerWalkMovement : BaseMovement // TypeDefIndex: 9668
{	public const float WaterLevelHead = 0,75;
	public const float WaterLevelNeck = 0,65;
	public PhysicMaterial zeroFrictionMaterial; // 0x58
	public PhysicMaterial highFrictionMaterial; // 0x60
	public float capsuleHeight; // 0x68
	public float capsuleCenter; // 0x6C
	public float capsuleHeightDucked; // 0x70
	public float capsuleCenterDucked; // 0x74
	public float capsuleHeightCrawling; // 0x78
	public float capsuleCenterCrawling; // 0x7C
	public float gravityTestRadius; // 0x80
	public float gravityMultiplier; // 0x84
	public float gravityMultiplierSwimming; // 0x88
	public float maxAngleWalking; // 0x8C
	public float maxAngleClimbing; // 0x90
	public float maxAngleSliding; // 0x94
	public float maxStepHeight; // 0x98
	private Rigidbody body; // 0xA0
	private CollisionDetectionMode initialColDetectionMode; // 0xA8
	private CapsuleCollider capsule; // 0xB0
	private TriggerLadder ladder; // 0xB8
	private float maxVelocity; // 0xC0
	private float groundAngle; // 0xC4
	private float groundAngleNew; // 0xC8
	private float groundTime; // 0xCC
	private float jumpTime; // 0xD0
	private float landTime; // 0xD4
	private Vector3 previousPosition; // 0xD8
	private Vector3 previousVelocity; // 0xE4
	private Vector3 previousInheritedVelocity; // 0xF0
	private Vector3 groundNormal; // 0xFC
	private Vector3 groundNormalNew; // 0x108
	private Vector3 groundVelocity; // 0x114
	private Vector3 groundVelocityNew; // 0x120
	private float nextSprintTime; // 0x12C
	private float lastSprintTime; // 0x130
	private bool sprintForced; // 0x134
	private TimeSince attemptedMountTime; // 0x138
	private BaseEntity.MovementModify modify; // 0x13C
	private bool grounded; // 0x140
	private bool climbing; // 0x141
	private bool sliding; // 0x142
	private bool swimming; // 0x143
	private bool wasSwimming; // 0x144
	private bool jumping; // 0x145
	private bool wasJumping; // 0x146
	private bool falling; // 0x147
	private bool wasFalling; // 0x148
	private bool flying; // 0x149
	private bool wasFlying; // 0x14A
	private float forcedDuckDelta; // 0x14C


	protected void Awake() { }

	public override Collider GetCollider() { }

	protected void OnDisable() { }

	public override void Init(BasePlayer player) { }

	protected void OnCollisionEnter(Collision collision) { }

	protected void OnCollisionStay(Collision collision) { }

	private void GroundCheck(Collision collision) { }

	public override void TeleportTo(Vector3 position, BasePlayer player) { }

	public void UpdateCurrentLadder(InputState input, bool force = False) { }

	public static bool WantsSprint(InputState input) { }

	public override void ClientInput(InputState input, ModelState modelState) { }

	private void Movement_Water(InputState input, ModelState modelState) { }

	private void Movement_Mounted(InputState input, ModelState modelState) { }

	private void Movement_Ladder(InputState input, ModelState modelState) { }

	private void Movement_Noclip(InputState input, ModelState modelState) { }

	private void Movement_Walking(InputState input, ModelState modelState) { }

	private float GetHeldEntityMovementMultiplier() { }

	private void HandleGrounded(ModelState state, bool wantsGrounded) { }

	private void HandleRunDuckCrawl(ModelState state, bool wantsRun, bool wantsDuck, bool wantsCrawl) { }

	private float GetForcedDuck() { }

	private void HandleJumping(ModelState state, bool wantsJump, bool jumpInDirection = False) { }

	private bool CanJump() { }

	public override void BlockJump(float duration) { }

	public override void BlockSprint(float duration) { }

	public void SetKinematic(bool kinematic) { }

	public void ApplyForce(Vector3 force) { }

	private bool CanSprint() { }

	private void Jump(ModelState state, bool inDirection) { }

	public override void DoFixedUpdate(ModelState modelState) { }

	public void DoStepUp() { }

	private void UpdateVelocity() { }

	private void UpdateGravity(ModelState modelState) { }

	public override void FrameUpdate(BasePlayer player, ModelState state) { }

	private void TransformState(Matrix4x4 matrix) { }

	public override void SetParent(Transform parent) { }

	private Vector3 FallVelocity() { }

	public override Vector3 CurrentVelocity() { }

	public override float CurrentMoveSpeed() { }

	public override void PlayerAttemptedMount() { }

	public override void PlayerCompletedMount() { }

	public void .ctor() { }

}

public class PlayerCorpse : LootableCorpse // TypeDefIndex: 9669
{	public Buoyancy buoyancy; // 0x2D0
	public const BaseEntity.Flags Flag_Buoyant = 16384;
	public uint underwearSkin; // 0x2D8
	private ItemContainer clientClothing; // 0x2E0
	private uint lastClothes; // 0x2E8


	public bool IsBuoyant() { }

	protected override void ClientInit(Entity info) { }

	private void RebuildWorldModel() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	private void ToggleClientBuoyancy(bool isBuoyant) { }

	public override string Categorize() { }

	public void .ctor() { }

}

public class PlayerInventoryProperties : ScriptableObject // TypeDefIndex: 10748
{	public string niceName; // 0x18
	public int order; // 0x20
	public List<PlayerInventoryProperties.ItemAmountSkinned> belt; // 0x28
	public List<PlayerInventoryProperties.ItemAmountSkinned> main; // 0x30
	public List<PlayerInventoryProperties.ItemAmountSkinned> wear; // 0x38
	public PlayerInventoryProperties giveBase; // 0x40


	public void .ctor() { }

}

public class PlayerInventoryProperties.ItemAmountSkinned : ItemAmount // TypeDefIndex: 10749
{	public ulong skinOverride; // 0x20


	public void .ctor() { }

}

public class PlayerDetectedEventUI : BaseEventUI // TypeDefIndex: 10806
{
	public override void Init(AIEventType eventType, BaseStateUI stateUI) { }

	public override AIEventData Save() { }

	public override void Load(AIEventData data) { }

	public void .ctor() { }

}

public class Player : ConsoleSystem // TypeDefIndex: 11949
{	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static int tickrate_cl; // 0x0
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static int tickrate_sv; // 0x4
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool recoilcomp; // 0x8
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool footik; // 0x9
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static float footikdistance; // 0xC
	[ClientVar] // RVA: 0xB01C0 Offset: 0xAF5C0 VA: 0x1800B01C0
	public static float footikrate; // 0x10
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static bool triggerfix; // 0x14
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static bool eye_blinking; // 0x15
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static bool eye_movement; // 0x16
	[ClientVar] // RVA: 0xB0470 Offset: 0xAF870 VA: 0x1800B0470
	public static bool useCinematicAvatar; // 0x17
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static float noclipspeed; // 0x18
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static float noclipspeedslow; // 0x1C
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static float noclipspeedfast; // 0x20


	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static void cinematic_list(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static void gesture(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static void petcmd(ConsoleSystem.Arg arg) { }

	[ServerUserVar] // RVA: 0xB0810 Offset: 0xAFC10 VA: 0x1800B0810
	[ClientVar] // RVA: 0xB0810 Offset: 0xAFC10 VA: 0x1800B0810
	public static void cinematic_play(ConsoleSystem.Arg arg) { }

	[ServerUserVar] // RVA: 0xB0810 Offset: 0xAFC10 VA: 0x1800B0810
	[ClientVar] // RVA: 0xB0810 Offset: 0xAFC10 VA: 0x1800B0810
	public static void cinematic_stop(ConsoleSystem.Arg arg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class PlayerCull : ConsoleSystem // TypeDefIndex: 11950
{	private static bool _enabled; // 0x0
	[ClientVar] // RVA: 0x91110 Offset: 0x90510 VA: 0x180091110
	public static float updateRate; // 0x4
	[ClientVar] // RVA: 0xB09A0 Offset: 0xAFDA0 VA: 0x1800B09A0
	public static float minCullDist; // 0x8
	[ClientVar] // RVA: 0xB0A40 Offset: 0xAFE40 VA: 0x1800B0A40
	public static float maxSleeperDist; // 0xC
	[ClientVar] // RVA: 0x912C0 Offset: 0x906C0 VA: 0x1800912C0
	public static float maxPlayerDist; // 0x10
	[ClientVar] // RVA: 0xB1E10 Offset: 0xB1210 VA: 0x1800B1E10
	public static int visQuality; // 0x14
	[ClientVar] // RVA: 0x815F0 Offset: 0x809F0 VA: 0x1800815F0
	public static bool debug; // 0x18

	[ClientVar] // RVA: 0xB2090 Offset: 0xB1490 VA: 0x1800B2090
	public static bool enabled { get; set; }


	public static bool get_enabled() { }

	public static void set_enabled(bool value) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum PlayerMenuAnimation.Layers // TypeDefIndex: 12147
{
public enum PlayerMenuAnimation.Layers // TypeDefIndex: 12147
	public int value__; // 0x0
	public const PlayerMenuAnimation.Layers Movement = 0;

}

