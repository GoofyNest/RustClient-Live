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

	[FreeFunctionAttribute] 
	private static bool IsConnected() { }

	[FreeFunctionAttribute] 
	private static void Initialize() { }

	[FreeFunctionAttribute] 
	private static void RegisterInternal(string messageId) { }

	[FreeFunctionAttribute] 
	private static void UnregisterInternal(string messageId) { }

	[FreeFunctionAttribute] 
	private static void SendMessage(string messageId, byte[] data, int playerId) { }

	[FreeFunctionAttribute] 
	private static bool TrySendMessage(string messageId, byte[] data, int playerId) { }

	[FreeFunctionAttribute] 
	private static void PollInternal() { }

	[FreeFunctionAttribute] 
	private static void DisconnectAll() { }

	public void .ctor() { }

}

public class PlayerPrefsException : Exception // TypeDefIndex: 3476
{

	public void .ctor(string error) { }

}

public class PlayerPrefs // TypeDefIndex: 3477
{

	[NativeMethodAttribute] 
	private static bool TrySetInt(string key, int value) { }

	[NativeMethodAttribute] 
	private static bool TrySetFloat(string key, float value) { }

	[NativeMethodAttribute] 
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

internal struct PlayerLoopSystemInternal // TypeDefIndex: 3664
{
	public Type type; 
	public PlayerLoopSystem.UpdateFunction updateDelegate; 
	public IntPtr updateFunction; 
	public IntPtr loopConditionFunction; 
	public int numSubSystems; 

}

public struct PlayerLoopSystem // TypeDefIndex: 3665
{
	public Type type; 
	public PlayerLoopSystem[] subSystemList; 
	public PlayerLoopSystem.UpdateFunction updateDelegate; 
	public IntPtr updateFunction; 
	public IntPtr loopConditionFunction; 

}

public sealed class PlayerLoopSystem.UpdateFunction : MulticastDelegate // TypeDefIndex: 3666
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke() { }

	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public class PlayerConnection : ScriptableObject // TypeDefIndex: 3791
{
	internal static IPlayerEditorConnectionNative connectionNative; 
	[SerializeField] 
	private PlayerEditorConnectionEvents m_PlayerEditorConnectionEvents; 
	[SerializeField] 
	private List<int> m_connectedPlayers; 
	private bool m_IsInitilized; 
	private static PlayerConnection s_Instance; 

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

	[RequiredByNativeCodeAttribute] 
	private static void MessageCallbackInternal(IntPtr data, ulong size, ulong guid, string messageId) { }

	[RequiredByNativeCodeAttribute] 
	private static void ConnectedCallbackInternal(int playerId) { }

	[RequiredByNativeCodeAttribute] 
	private static void DisconnectedCallback(int playerId) { }

	public void .ctor() { }

}

private sealed class PlayerConnection.<>c__DisplayClass12_0 // TypeDefIndex: 3792
{
	public Guid messageId; 


	public void .ctor() { }

	internal bool <Register>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x) { }

}

private sealed class PlayerConnection.<>c__DisplayClass13_0 // TypeDefIndex: 3793
{
	public Guid messageId; 


	public void .ctor() { }

	internal bool <Unregister>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x) { }

}

private sealed class PlayerConnection.<>c__DisplayClass20_0 // TypeDefIndex: 3794
{
	public bool msgReceived; 


	public void .ctor() { }

	internal void <BlockUntilRecvMsg>b__0(MessageEventArgs args) { }

}

internal class PlayerEditorConnectionEvents // TypeDefIndex: 3795
{
	[SerializeField] 
	public List<PlayerEditorConnectionEvents.MessageTypeSubscribers> messageTypeSubscribers; 
	[SerializeField] 
	public PlayerEditorConnectionEvents.ConnectionChangeEvent connectionEvent; 
	[SerializeField] 
	public PlayerEditorConnectionEvents.ConnectionChangeEvent disconnectionEvent; 


	public void InvokeMessageIdSubscribers(Guid messageId, byte[] data, int playerId) { }

	public UnityEvent<MessageEventArgs> AddAndCreate(Guid messageId) { }

	public void UnregisterManagedCallback(Guid messageId, UnityAction<MessageEventArgs> callback) { }

	public void .ctor() { }

}

public class PlayerEditorConnectionEvents.MessageEvent : UnityEvent<MessageEventArgs> // TypeDefIndex: 3796
{

	public void .ctor() { }

}

public class PlayerEditorConnectionEvents.ConnectionChangeEvent : UnityEvent<int> // TypeDefIndex: 3797
{

	public void .ctor() { }

}

public class PlayerEditorConnectionEvents.MessageTypeSubscribers // TypeDefIndex: 3798
{
	[SerializeField] 
	private string m_messageTypeId; 
	public int subscriberCount; 
	public PlayerEditorConnectionEvents.MessageEvent messageCallback; 

	public Guid MessageTypeId { get; set; }


	public Guid get_MessageTypeId() { }

	public void set_MessageTypeId(Guid value) { }

	public void .ctor() { }

}

private sealed class PlayerEditorConnectionEvents.<>c__DisplayClass6_0 // TypeDefIndex: 3799
{
	public Guid messageId; 


	public void .ctor() { }

	internal bool <InvokeMessageIdSubscribers>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x) { }

}

private sealed class PlayerEditorConnectionEvents.<>c__DisplayClass7_0 // TypeDefIndex: 3800
{
	public Guid messageId; 


	public void .ctor() { }

	internal bool <AddAndCreate>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x) { }

}

private sealed class PlayerEditorConnectionEvents.<>c__DisplayClass8_0 // TypeDefIndex: 3801
{
	public Guid messageId; 


	public void .ctor() { }

	internal bool <UnregisterManagedCallback>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x) { }

}

public struct PlayerItemRecipe : IEquatable<PlayerItemRecipe> // TypeDefIndex: 5702
{
	[CompilerGeneratedAttribute] 
	private readonly IReadOnlyList<PlayerItemRecipe.Ingredient> <Ingredients>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private readonly IPlayerItemDefinition <Result>k__BackingField; 

	public IReadOnlyList<PlayerItemRecipe.Ingredient> Ingredients { get; }
	public IPlayerItemDefinition Result { get; }


	[CompilerGeneratedAttribute] 
	public IReadOnlyList<PlayerItemRecipe.Ingredient> get_Ingredients() { }

	[CompilerGeneratedAttribute] 
	public IPlayerItemDefinition get_Result() { }

	public void .ctor(IReadOnlyList<PlayerItemRecipe.Ingredient> ingredients, IPlayerItemDefinition result) { }

	public bool Equals(PlayerItemRecipe other) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public static bool op_Equality(PlayerItemRecipe left, PlayerItemRecipe right) { }

	public static bool op_Inequality(PlayerItemRecipe left, PlayerItemRecipe right) { }

}

public struct PlayerItemRecipe.Ingredient : IEquatable<PlayerItemRecipe.Ingredient> // TypeDefIndex: 5703
{
	[CompilerGeneratedAttribute] 
	private readonly int <DefinitionId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private readonly int <Amount>k__BackingField; 

	public int DefinitionId { get; }
	public int Amount { get; }


	[CompilerGeneratedAttribute] 
	public int get_DefinitionId() { }

	[CompilerGeneratedAttribute] 
	public int get_Amount() { }

	public void .ctor(int definitionId, int amount) { }

	public bool Equals(PlayerItemRecipe.Ingredient other) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public static bool op_Equality(PlayerItemRecipe.Ingredient left, PlayerItemRecipe.Ingredient right) { }

	public static bool op_Inequality(PlayerItemRecipe.Ingredient left, PlayerItemRecipe.Ingredient right) { }

}

private sealed class PlayerItemRecipe.<>c // TypeDefIndex: 5704
{
	public static readonly PlayerItemRecipe.<>c <>9; 
	public static Func<PlayerItemRecipe.Ingredient, int> <>9__10_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal int <GetHashCode>b__10_0(PlayerItemRecipe.Ingredient i) { }

}

public static class PlayerItemExtensions // TypeDefIndex: 6160
{

	[ExtensionAttribute] 
	public static IPlayerItemDefinition GetDefinition(IPlayerItem item) { }

}

public struct PlayerInfo // TypeDefIndex: 6254
{
	[CompilerGeneratedAttribute] 
	private string <Name>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <Id>k__BackingField; 

	public string Name { get; set; }
	public string Id { get; set; }


	[CompilerGeneratedAttribute] 
	public string get_Name() { }

	[CompilerGeneratedAttribute] 
	public void set_Name(string value) { }

	[CompilerGeneratedAttribute] 
	public string get_Id() { }

	[CompilerGeneratedAttribute] 
	public void set_Id(string value) { }

}

public class PlayerTick : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6281
{
	public bool ShouldPool; 
	private bool _disposed; 
	public InputMessage inputState; 
	public Vector3 position; 
	public ModelState modelState; 
	public uint activeItem; 
	public Vector3 eyePos; 
	public uint parentID; 
	public uint deltaMs; 


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

public class BasePlayer : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6448
{
	public bool ShouldPool; 
	private bool _disposed; 
	public string name; 
	public ulong userid; 
	public PlayerInventory inventory; 
	public PlayerMetabolism metabolism; 
	public ModelState modelState; 
	public int playerFlags; 
	public uint heldEntity; 
	public float health; 
	public PersistantPlayer persistantData; 
	public float skinCol; 
	public float skinTex; 
	public float skinMesh; 
	public PlayerLifeStory currentLife; 
	public PlayerLifeStory previousLife; 
	public uint mounted; 
	public ulong currentTeam; 
	public uint underwear; 
	public PlayerModifiers modifiers; 
	public int reputation; 
	public uint loopingGesture; 
	public Missions missions; 


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

public class PlayerTeam : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6449
{
	public bool ShouldPool; 
	private bool _disposed; 
	public ulong teamID; 
	public string teamName; 
	public ulong teamLeader; 
	public List<PlayerTeam.TeamMember> members; 
	public float teamLifetime; 
	public MapNote mapNote; 


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

public class PlayerTeam.TeamMember : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6450
{
	public bool ShouldPool; 
	private bool _disposed; 
	public string displayName; 
	public ulong userID; 
	public float healthFraction; 
	public Vector3 position; 
	public bool online; 
	public bool wounded; 


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

public class PlayerMetabolism : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6451
{
	public bool ShouldPool; 
	private bool _disposed; 
	public float health; 
	public float calories; 
	public float hydration; 
	public float heartrate; 
	public float temperature; 
	public float poison; 
	public float radiation_level; 
	public float wetness; 
	public float dirtyness; 
	public float oxygen; 
	public float bleeding; 
	public float radiation_poisoning; 
	public float comfort; 
	public float pending_health; 


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

public class PlayerModifiers : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6452
{
	public bool ShouldPool; 
	private bool _disposed; 
	public List<Modifier> modifiers; 


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

public class PlayerInventory : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6459
{
	public bool ShouldPool; 
	private bool _disposed; 
	public ItemContainer invMain; 
	public ItemContainer invBelt; 
	public ItemContainer invWear; 


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

public class PlayerLifeStory : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6461
{
	public bool ShouldPool; 
	private bool _disposed; 
	public float secondsAlive; 
	public float metersWalked; 
	public float metersRun; 
	public float secondsSleeping; 
	public uint timeBorn; 
	public uint timeDied; 
	public float secondsWilderness; 
	public float secondsSwimming; 
	public float secondsInBase; 
	public float secondsInMonument; 
	public float secondsFlying; 
	public float secondsBoating; 
	public float secondsDriving; 
	public float totalDamageTaken; 
	public float totalHealing; 
	public PlayerLifeStory.DeathInfo deathInfo; 
	public List<PlayerLifeStory.WeaponStats> weaponStats; 
	public int killedPlayers; 
	public int killedScientists; 
	public int killedAnimals; 
	public List<PlayerLifeStory.GenericStat> genericStats; 


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

public class PlayerLifeStory.DeathInfo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6462
{
	public bool ShouldPool; 
	private bool _disposed; 
	public string attackerName; 
	public ulong attackerSteamID; 
	public string hitBone; 
	public string inflictorName; 
	public int lastDamageType; 
	public float attackerDistance; 


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

public class PlayerLifeStory.WeaponStats : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6463
{
	public bool ShouldPool; 
	private bool _disposed; 
	public string weaponName; 
	public ulong shotsFired; 
	public ulong shotsHit; 


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

public class PlayerLifeStory.GenericStat : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6464
{
	public bool ShouldPool; 
	private bool _disposed; 
	public string key; 
	public int value; 


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

public class PlayerState : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6467
{
	public bool ShouldPool; 
	private bool _disposed; 
	public double unHostileTimestamp; 
	public MapNote pointOfInterest; 
	public MapNote deathMarker; 
	public Missions missions; 


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

public class PlayerNameID : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6468
{
	public bool ShouldPool; 
	private bool _disposed; 
	public string username; 
	public ulong userid; 


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

public class PlayerUpdateLoot : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6483
{
	public bool ShouldPool; 
	private bool _disposed; 
	public uint itemID; 
	public uint entityID; 
	public List<ItemContainer> containers; 


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

public class PlayerAttack : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6489
{
	public bool ShouldPool; 
	private bool _disposed; 
	public Attack attack; 
	public int projectileID; 


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

public class PlayerProjectileAttack : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6490
{
	public bool ShouldPool; 
	private bool _disposed; 
	public PlayerAttack playerAttack; 
	public Vector3 hitVelocity; 
	public float hitDistance; 
	public float travelTime; 


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

public class PlayerProjectileRicochet : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6491
{
	public bool ShouldPool; 
	private bool _disposed; 
	public int projectileID; 
	public Vector3 hitPosition; 
	public Vector3 inVelocity; 
	public Vector3 outVelocity; 
	public Vector3 hitNormal; 
	public float travelTime; 


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

public class PlayerProjectileUpdate : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6492
{
	public bool ShouldPool; 
	private bool _disposed; 
	public int projectileID; 
	public Vector3 curPosition; 
	public Vector3 curVelocity; 
	public float travelTime; 


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

public class PlayerDetectedAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6549
{
	public bool ShouldPool; 
	private bool _disposed; 
	public float range; 


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

public struct PlayerSanction // TypeDefIndex: 8615
{
	[CompilerGeneratedAttribute] 
	private long <TimePlaced>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <Action>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private long <TimeExpires>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <ReferenceId>k__BackingField; 

	public long TimePlaced { get; set; }
	public Utf8String Action { get; set; }
	public long TimeExpires { get; set; }
	public Utf8String ReferenceId { get; set; }


	[CompilerGeneratedAttribute] 
	public long get_TimePlaced() { }

	[CompilerGeneratedAttribute] 
	public void set_TimePlaced(long value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_Action() { }

	[CompilerGeneratedAttribute] 
	public void set_Action(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public long get_TimeExpires() { }

	[CompilerGeneratedAttribute] 
	public void set_TimeExpires(long value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_ReferenceId() { }

	[CompilerGeneratedAttribute] 
	public void set_ReferenceId(Utf8String value) { }

	internal void Set(ref PlayerSanctionInternal other) { }

}

internal struct PlayerSanctionInternal : IGettable<PlayerSanction>, ISettable<PlayerSanction>, IDisposable // TypeDefIndex: 8616
{
	private int m_ApiVersion; 
	private long m_TimePlaced; 
	private IntPtr m_Action; 
	private long m_TimeExpires; 
	private IntPtr m_ReferenceId; 

	public long TimePlaced { get; set; }
	public Utf8String Action { get; set; }
	public long TimeExpires { get; set; }
	public Utf8String ReferenceId { get; set; }


	public long get_TimePlaced() { }

	public void set_TimePlaced(long value) { }

	public Utf8String get_Action() { }

	public void set_Action(Utf8String value) { }

	public long get_TimeExpires() { }

	public void set_TimeExpires(long value) { }

	public Utf8String get_ReferenceId() { }

	public void set_ReferenceId(Utf8String value) { }

	public void Set(ref PlayerSanction other) { }

	public void Set(ref Nullable<PlayerSanction> other) { }

	public void Dispose() { }

	public void Get(out PlayerSanction output) { }

}

public enum PlayerReportsCategory // TypeDefIndex: 8624
{
	public int value__; 
	public const PlayerReportsCategory Invalid = 0;
	public const PlayerReportsCategory Cheating = 1;
	public const PlayerReportsCategory Exploiting = 2;
	public const PlayerReportsCategory OffensiveProfile = 3;
	public const PlayerReportsCategory VerbalAbuse = 4;
	public const PlayerReportsCategory Scamming = 5;
	public const PlayerReportsCategory Spamming = 6;
	public const PlayerReportsCategory Other = 7;

}

public sealed class PlayerDataStorageFileTransferRequest : Handle // TypeDefIndex: 8900
{

	public void .ctor() { }

	public void .ctor(IntPtr innerHandle) { }

	public Result CancelRequest() { }

	public Result GetFileRequestState() { }

	public Result GetFilename(out Utf8String outStringBuffer) { }

	public void Release() { }

}

public sealed class PlayerDataStorageInterface : Handle // TypeDefIndex: 8901
{
	public const int CopyfilemetadataatindexoptionsApiLatest = 1;
	public const int CopyfilemetadatabyfilenameoptionsApiLatest = 1;
	public const int DeletecacheoptionsApiLatest = 1;
	public const int DeletefileoptionsApiLatest = 1;
	public const int DuplicatefileoptionsApiLatest = 1;
	public const int FileMaxSizeBytes = 67108864;
	public const int FilemetadataApiLatest = 3;
	public const int FilenameMaxLengthBytes = 64;
	public const int GetfilemetadatacountoptionsApiLatest = 1;
	public const int QueryfilelistoptionsApiLatest = 1;
	public const int QueryfileoptionsApiLatest = 1;
	public const int ReadfileoptionsApiLatest = 1;
	public const int WritefileoptionsApiLatest = 1;


	public void .ctor() { }

	public void .ctor(IntPtr innerHandle) { }

	public Result CopyFileMetadataAtIndex(ref CopyFileMetadataAtIndexOptions copyFileMetadataOptions, out Nullable<FileMetadata> outMetadata) { }

	public Result CopyFileMetadataByFilename(ref CopyFileMetadataByFilenameOptions copyFileMetadataOptions, out Nullable<FileMetadata> outMetadata) { }

	public Result DeleteCache(ref DeleteCacheOptions options, object clientData, OnDeleteCacheCompleteCallback completionCallback) { }

	public void DeleteFile(ref DeleteFileOptions deleteOptions, object clientData, OnDeleteFileCompleteCallback completionCallback) { }

	public void DuplicateFile(ref DuplicateFileOptions duplicateOptions, object clientData, OnDuplicateFileCompleteCallback completionCallback) { }

	public Result GetFileMetadataCount(ref GetFileMetadataCountOptions getFileMetadataCountOptions, out int outFileMetadataCount) { }

	public void QueryFile(ref QueryFileOptions queryFileOptions, object clientData, OnQueryFileCompleteCallback completionCallback) { }

	public void QueryFileList(ref QueryFileListOptions queryFileListOptions, object clientData, OnQueryFileListCompleteCallback completionCallback) { }

	public PlayerDataStorageFileTransferRequest ReadFile(ref ReadFileOptions readOptions, object clientData, OnReadFileCompleteCallback completionCallback) { }

	public PlayerDataStorageFileTransferRequest WriteFile(ref WriteFileOptions writeOptions, object clientData, OnWriteFileCompleteCallback completionCallback) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnDeleteCacheCompleteCallbackInternalImplementation(ref DeleteCacheCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnDeleteFileCompleteCallbackInternalImplementation(ref DeleteFileCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnDuplicateFileCompleteCallbackInternalImplementation(ref DuplicateFileCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnFileTransferProgressCallbackInternalImplementation(ref FileTransferProgressCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnQueryFileCompleteCallbackInternalImplementation(ref QueryFileCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnQueryFileListCompleteCallbackInternalImplementation(ref QueryFileListCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnReadFileCompleteCallbackInternalImplementation(ref ReadFileCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static ReadResult OnReadFileDataCallbackInternalImplementation(ref ReadFileDataCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnWriteFileCompleteCallbackInternalImplementation(ref WriteFileCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static WriteResult OnWriteFileDataCallbackInternalImplementation(ref WriteFileDataCallbackInfoInternal data, IntPtr outDataBuffer, ref uint outDataWritten) { }

}

public struct PlayerAchievement // TypeDefIndex: 9929
{
	[CompilerGeneratedAttribute] 
	private Utf8String <AchievementId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private double <Progress>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Nullable<DateTimeOffset> <UnlockTime>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private PlayerStatInfo[] <StatInfo>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <DisplayName>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <Description>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <IconURL>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <FlavorText>k__BackingField; 

	public Utf8String AchievementId { get; set; }
	public double Progress { get; set; }
	public Nullable<DateTimeOffset> UnlockTime { get; set; }
	public PlayerStatInfo[] StatInfo { get; set; }
	public Utf8String DisplayName { get; set; }
	public Utf8String Description { get; set; }
	public Utf8String IconURL { get; set; }
	public Utf8String FlavorText { get; set; }


	[CompilerGeneratedAttribute] 
	public Utf8String get_AchievementId() { }

	[CompilerGeneratedAttribute] 
	public void set_AchievementId(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public double get_Progress() { }

	[CompilerGeneratedAttribute] 
	public void set_Progress(double value) { }

	[CompilerGeneratedAttribute] 
	public Nullable<DateTimeOffset> get_UnlockTime() { }

	[CompilerGeneratedAttribute] 
	public void set_UnlockTime(Nullable<DateTimeOffset> value) { }

	[CompilerGeneratedAttribute] 
	public PlayerStatInfo[] get_StatInfo() { }

	[CompilerGeneratedAttribute] 
	public void set_StatInfo(PlayerStatInfo[] value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_DisplayName() { }

	[CompilerGeneratedAttribute] 
	public void set_DisplayName(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_Description() { }

	[CompilerGeneratedAttribute] 
	public void set_Description(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_IconURL() { }

	[CompilerGeneratedAttribute] 
	public void set_IconURL(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_FlavorText() { }

	[CompilerGeneratedAttribute] 
	public void set_FlavorText(Utf8String value) { }

	internal void Set(ref PlayerAchievementInternal other) { }

}

internal struct PlayerAchievementInternal : IGettable<PlayerAchievement>, ISettable<PlayerAchievement>, IDisposable // TypeDefIndex: 9930
{
	private int m_ApiVersion; 
	private IntPtr m_AchievementId; 
	private double m_Progress; 
	private long m_UnlockTime; 
	private int m_StatInfoCount; 
	private IntPtr m_StatInfo; 
	private IntPtr m_DisplayName; 
	private IntPtr m_Description; 
	private IntPtr m_IconURL; 
	private IntPtr m_FlavorText; 

	public Utf8String AchievementId { get; set; }
	public double Progress { get; set; }
	public Nullable<DateTimeOffset> UnlockTime { get; set; }
	public PlayerStatInfo[] StatInfo { get; set; }
	public Utf8String DisplayName { get; set; }
	public Utf8String Description { get; set; }
	public Utf8String IconURL { get; set; }
	public Utf8String FlavorText { get; set; }


	public Utf8String get_AchievementId() { }

	public void set_AchievementId(Utf8String value) { }

	public double get_Progress() { }

	public void set_Progress(double value) { }

	public Nullable<DateTimeOffset> get_UnlockTime() { }

	public void set_UnlockTime(Nullable<DateTimeOffset> value) { }

	public PlayerStatInfo[] get_StatInfo() { }

	public void set_StatInfo(PlayerStatInfo[] value) { }

	public Utf8String get_DisplayName() { }

	public void set_DisplayName(Utf8String value) { }

	public Utf8String get_Description() { }

	public void set_Description(Utf8String value) { }

	public Utf8String get_IconURL() { }

	public void set_IconURL(Utf8String value) { }

	public Utf8String get_FlavorText() { }

	public void set_FlavorText(Utf8String value) { }

	public void Set(ref PlayerAchievement other) { }

	public void Set(ref Nullable<PlayerAchievement> other) { }

	public void Dispose() { }

	public void Get(out PlayerAchievement output) { }

}

public struct PlayerStatInfo // TypeDefIndex: 9931
{
	[CompilerGeneratedAttribute] 
	private Utf8String <Name>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <CurrentValue>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ThresholdValue>k__BackingField; 

	public Utf8String Name { get; set; }
	public int CurrentValue { get; set; }
	public int ThresholdValue { get; set; }


	[CompilerGeneratedAttribute] 
	public Utf8String get_Name() { }

	[CompilerGeneratedAttribute] 
	public void set_Name(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public int get_CurrentValue() { }

	[CompilerGeneratedAttribute] 
	public void set_CurrentValue(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ThresholdValue() { }

	[CompilerGeneratedAttribute] 
	public void set_ThresholdValue(int value) { }

	internal void Set(ref PlayerStatInfoInternal other) { }

}

internal struct PlayerStatInfoInternal : IGettable<PlayerStatInfo>, ISettable<PlayerStatInfo>, IDisposable // TypeDefIndex: 9932
{
	private int m_ApiVersion; 
	private IntPtr m_Name; 
	private int m_CurrentValue; 
	private int m_ThresholdValue; 

	public Utf8String Name { get; set; }
	public int CurrentValue { get; set; }
	public int ThresholdValue { get; set; }


	public Utf8String get_Name() { }

	public void set_Name(Utf8String value) { }

	public int get_CurrentValue() { }

	public void set_CurrentValue(int value) { }

	public int get_ThresholdValue() { }

	public void set_ThresholdValue(int value) { }

	public void Set(ref PlayerStatInfo other) { }

	public void Set(ref Nullable<PlayerStatInfo> other) { }

	public void Dispose() { }

	public void Get(out PlayerStatInfo output) { }

}

public class PlayerIdleAnimationRandomiser : StateMachineBehaviour // TypeDefIndex: 9974
{
	public int MaxValue; 
	public static int Param_Random; 
	private TimeSince lastRandomisation; 


	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class BasePlayer : BaseCombatEntity, LootPanel.IHasLootPanel, IIdealSlotEntity // TypeDefIndex: 10041
{
	private Option __menuOption_Climb; 
	private Option __menuOption_Drink; 
	private Option __menuOption_InviteToTeam; 
	private Option __menuOption_Menu_AssistPlayer; 
	private Option __menuOption_Menu_LootPlayer; 
	private Option __menuOption_Promote; 
	private Option __menuOption_SaltWater; 
	[ClientVar] 
	public static string lootPanelOverride; 
	private TimeSince lastOpenSoundPlay; 
	public BasePlayer.CameraMode currentViewMode; 
	public BasePlayer.CameraMode selectedViewMode; 
	private Vector3 lastRevivePoint; 
	private Vector3 lastReviveDirection; 
	public PlayerModel playerModel; 
	public bool Frozen; 
	public PlayerVoiceRecorder voiceRecorder; 
	public PlayerVoiceSpeaker voiceSpeaker; 
	public PlayerInput input; 
	public BaseMovement movement; 
	public BaseCollision collision; 
	private static InputState emptyState; 
	private GameObject _lookingAt; 
	private BaseEntity _lookingAtEntity; 
	private Collider _lookingAtCollider; 
	[CompilerGeneratedAttribute] 
	private Vector3 <lookingAtPoint>k__BackingField; 
	private const string playerModelPrefab = "assets/prefabs/player/player_model.prefab";
	private const string playerCollisionPrefab = "assets/prefabs/player/player_collision.prefab";
	private float wakeTime; 
	private bool needsClothesRebuild; 
	private bool wasSleeping; 
	private bool wokeUpBefore; 
	private bool wasDead; 
	private uint lastClothesHash; 
	private static ListDictionary<ulong, BasePlayer> visiblePlayerList; 
	public static int craftMode; 
	[CompilerGeneratedAttribute] 
	private bool <IsWearingDiveGoggles>k__BackingField; 
	public ViewModel GestureViewModel; 
	public const float INTERACTION_TICK_RATE = 0,1;
	private RealTimeSince timeSinceUpdatedLookingAt; 
	private float nextTopologyTestTime; 
	private float usePressTime; 
	private float useHeldTime; 
	private HitTest lookingAtTest; 
	public static float lastDeathTimeClient; 
	private const float drinkRange = 1,5;
	private const float drinkMovementSpeed = 0,1;
	private Vector3 cachedWaterDrinkingPoint; 
	public const string GestureCancelString = "cancel";
	public GestureCollection gestureList; 
	private TimeUntil gestureFinishedTime; 
	private TimeSince blockHeldInputTimer; 
	private GestureConfig currentGesture; 
	private HeldEntity disabledHeldEntity; 
	private float nextGestureMenuOpenTime; 
	private TimeSince lastGestureCancel; 
	public float client_lastHelloTime; 
	public ulong currentTeam; 
	public static readonly Translate.Phrase MaxTeamSizeToast; 
	public PlayerTeam clientTeam; 
	private float lastReceivedTeamTime; 
	private ulong lastPresenceTeamId; 
	private int lastPresenceTeamSize; 
	private string playerGroupKey; 
	private string playerGroupSizeKey; 
	private uint clActiveItem; 
	public MapNote ClientCurrentMapNote; 
	public MapNote ClientCurrentDeathNote; 
	public List<BaseMission.MissionInstance> missions; 
	private int _activeMission; 
	public ModelState modelState; 
	private EntityRef mounted; 
	private float nextSeatSwapTime; 
	public BaseEntity PetEntity; 
	private float lastPetCommandIssuedTime; 
	public uint PetPrefabID; 
	public uint PetID; 
	public static bool PetWheelHasBeenOpened; 
	private float cachedBuildingPrivilegeTime; 
	private BuildingPrivlidge cachedBuildingPrivilege; 
	private int maxProjectileID; 
	private const int WILDERNESS = 1;
	private const int MONUMENT = 2;
	private const int BASE = 4;
	private const int FLYING = 8;
	private const int BOATING = 16;
	private const int SWIMMING = 32;
	private const int DRIVING = 64;
	private float lastUpdateTime; 
	private float cachedThreatLevel; 
	public const int serverTickRateDefault = 16;
	public const int clientTickRateDefault = 20;
	public int serverTickRate; 
	public int clientTickRate; 
	public float serverTickInterval; 
	public float clientTickInterval; 
	private float lastSentTickTime; 
	private Stopwatch lastTickStopwatch; 
	private PlayerTick lastSentTick; 
	private float nextVisThink; 
	private float lastTimeSeen; 
	private bool debugPrevVisible; 
	[HeaderAttribute] 
	public GameObjectRef fallDamageEffect; 
	public GameObjectRef drownEffect; 
	[InspectorFlagsAttribute] 
	public BasePlayer.PlayerFlags playerFlags; 
	public PlayerEyes eyes; 
	public PlayerInventory inventory; 
	public PlayerBlueprints blueprints; 
	public PlayerMetabolism metabolism; 
	public PlayerModifiers modifiers; 
	private CapsuleCollider playerCollider; 
	public PlayerBelt Belt; 
	private Rigidbody playerRigidbody; 
	public ulong userID; 
	public string UserIDString; 
	public int gamemodeteam; 
	public int reputation; 
	protected string _displayName; 
	private string _lastSetName; 
	public const float crouchSpeed = 1,7;
	public const float walkSpeed = 2,8;
	public const float runSpeed = 5,5;
	public const float crawlSpeed = 0,72;
	private BasePlayer.CapsuleColliderInfo playerColliderStanding; 
	private BasePlayer.CapsuleColliderInfo playerColliderDucked; 
	private BasePlayer.CapsuleColliderInfo playerColliderCrawling; 
	private BasePlayer.CapsuleColliderInfo playerColliderLyingDown; 
	private ProtectionProperties cachedProtection; 
	public static bool oldCameraFix; 
	private float lastHeadshotSoundTime; 
	private float nextColliderRefreshTime; 
	public bool clothingBlocksAiming; 
	public float clothingMoveSpeedReduction; 
	public float clothingWaterSpeedBonus; 
	public float clothingAccuracyBonus; 
	public bool equippingBlocked; 
	public float eggVision; 
	private PhoneController activeTelephone; 
	public BaseEntity designingAIEntity; 

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

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_LootPlayer(BasePlayer player) { }

	public bool Menu_LootPlayer_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] 
	private void RPC_OpenLootPanel(BaseEntity.RPCMessage rpc) { }

	private void PlayOpenSound() { }

	public bool InFirstPersonMode() { }

	public void UpdateViewMode() { }

	internal BasePlayer.CameraMode get_idealViewMode() { }

	internal bool get_shouldDrawBody() { }

	public virtual void OnViewModeChanged() { }

	public void ModifyCamera() { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_AssistPlayer(BasePlayer player) { }

	public void Menu_AssistPlayer_TimeStart() { }

	public bool Menu_AssistPlayer_ShowIf(BasePlayer player) { }

	public GameObject get_lookingAt() { }

	public BaseEntity get_lookingAtEntity() { }

	public Collider get_lookingAtCollider() { }

	[CompilerGeneratedAttribute] 
	public Vector3 get_lookingAtPoint() { }

	[CompilerGeneratedAttribute] 
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

	[BaseEntity.RPC_Client] 
	public void SetInheritedVelocity(Vector3 velocity, uint entID) { }

	[BaseEntity.RPC_Client] 
	public void GetPerformanceReport(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
	public void GetPerformanceReport_Frametime(BaseEntity.RPCMessage msg) { }

	public override void OnBecameRagdoll(Ragdoll rdoll) { }

	public override void OnVoiceData(byte[] data) { }

	[BaseEntity.RPC_Client] 
	public void RecieveAchievement(string name) { }

	[BaseEntity.RPC_Client] 
	public void CraftMode(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
	public void StartDesigningAI(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
	public void OnDebugAIEventTriggeredStateChange(int previousStateContainerID, int newStateContainerID, int sourceEventID) { }

	public override void ClientOnEnable() { }

	[BaseEntity.RPC_Client] 
	private void Client_OnRepairFailedResources(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
	private void TakeDamageHit() { }

	[BaseEntity.RPC_Client] 
	private void AdminReceivedUGC(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
	private void AdminReceivedPatternFirework(BaseEntity.RPCMessage msg) { }

	[CompilerGeneratedAttribute] 
	public bool get_IsWearingDiveGoggles() { }

	[CompilerGeneratedAttribute] 
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

	[BaseEntity.RPC_Client] 
	private void OnDied(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
	private void OnRespawnInformation(BaseEntity.RPCMessage msg) { }

	private void RequestRespawnUpdates() { }

	public void OnLand(float fVelocity) { }

	[BaseEntity.RPC_Client] 
	private void StartLoading() { }

	[BaseEntity.RPC_Client] 
	private void FinishLoading() { }

	private void FullBlack_FadeIn() { }

	[IteratorStateMachineAttribute] 
	private IEnumerator FinishedLoadingRoutine() { }

	[BaseEntity.RPC_Client] 
	private void DirectionalDamage(Vector3 position, int damageType, int damageTotal) { }

	[BaseEntity.RPC_Client] 
	public void UnlockedBlueprint(BaseEntity.RPCMessage msg) { }

	private void CheckForRespawnInfo() { }

	[BaseEntity.RPC_Client] 
	public void UpdateRichPresenceState(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
	public void HandleCompanionPairingResult(BaseEntity.RPCMessage msg) { }

	public Vector3 UpdateWaterDrinkingPoint() { }

	private Vector3 GetWaterDrinkingPoint() { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Drink(BasePlayer player) { }

	public bool Drink_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void SaltWater(BasePlayer player) { }

	public bool SaltWater_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
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

	[BaseEntity.RPC_Client] 
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

	[BaseEntity.RPC_Client] 
	private void Client_RemoteCancelledGesture() { }

	private bool IsGestureBlocked() { }

	public float get_clientTeamLifetime() { }

	[BaseEntity.RPC_Client] 
	public void CLIENT_ReceiveTeamInfo(BaseEntity.RPCMessage msg) { }

	private void UpdateSteamGroup(ulong teamId, int teamSize) { }

	private void ClearSteamGroup() { }

	[BaseEntity.RPC_Client] 
	public void CLIENT_ClearTeam(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
	public void CLIENT_PendingInvite(BaseEntity.RPCMessage msg) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void InviteToTeam(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Promote(BasePlayer player) { }

	public void Menu_Promote_Start() { }

	public bool Promote_ShowIf(BasePlayer player) { }

	public static bool LocalPlayerIsLeader() { }

	public bool Invite_ShowIf(BasePlayer player) { }

	public HeldEntity GetHeldEntity() { }

	public bool IsHoldingEntity<T>() { }
	/* GenericInstMethod :
	|
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

	[BaseEntity.RPC_Client] 
	public void Client_ReceiveMarkers(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
	public void Client_UpdateDeathMarker(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
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

	[BaseEntity.RPC_Client] 
	private void OnModelState(BaseEntity.RPCMessage data) { }

	private void OnModelStateChanged() { }

	public bool get_isMounted() { }

	public bool get_isMountingHidingWeapon() { }

	public BaseMountable GetMounted() { }

	public BaseVehicle GetMountedVehicle() { }

	public void MarkSwapSeat() { }

	public bool SwapSeatCooldown() { }

	public void ClientUpdateMounted(uint id) { }

	[BaseEntity.RPC_Client] 
	public void CLIENT_SetPetPrefabID(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
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

	[BaseEntity.RPC_Client] 
	private void SpectatedPlayerHeadshot() { }

	public override float GetThreatLevel() { }

	public void EnsureUpdated() { }

	[BaseEntity.RPC_Client] 
	public void SetHostileLength(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
	public void SetWeaponDrawnDuration(BaseEntity.RPCMessage msg) { }

	protected virtual void ModifyInputState(ref InputState inputState) { }

	[BaseEntity.RPC_Client] 
	private void ForcePositionToParentOffset(Vector3 position, uint entID) { }

	[BaseEntity.RPC_Client] 
	public void UpdateClientTickRate(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
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

	public override Vector3 GetInheritedProjectileVelocity(Vector3 direction) { }

	public override Vector3 GetInheritedThrowVelocity(Vector3 direction) { }

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

	public void ShowToast(GameTip.Styles style, Translate.Phrase phrase, string[] arguments) { }

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

public enum BasePlayer.CameraMode // TypeDefIndex: 10042
{
	public int value__; 
	public const BasePlayer.CameraMode FirstPerson = 0;
	public const BasePlayer.CameraMode ThirdPerson = 1;
	public const BasePlayer.CameraMode Eyes = 2;
	public const BasePlayer.CameraMode FirstPersonWithArms = 3;
	public const BasePlayer.CameraMode DeathCamClassic = 4;
	public const BasePlayer.CameraMode Last = 3;

}

public enum BasePlayer.PlayerFlags // TypeDefIndex: 10043
{
	public int value__; 
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

public enum BasePlayer.MapNoteType // TypeDefIndex: 10044
{
	public int value__; 
	public const BasePlayer.MapNoteType Death = 0;
	public const BasePlayer.MapNoteType PointOfInterest = 1;

}

public enum BasePlayer.TimeCategory // TypeDefIndex: 10045
{
	public int value__; 
	public const BasePlayer.TimeCategory Wilderness = 1;
	public const BasePlayer.TimeCategory Monument = 2;
	public const BasePlayer.TimeCategory Base = 4;
	public const BasePlayer.TimeCategory Flying = 8;
	public const BasePlayer.TimeCategory Boating = 16;
	public const BasePlayer.TimeCategory Swimming = 32;
	public const BasePlayer.TimeCategory Driving = 64;

}

public struct BasePlayer.CapsuleColliderInfo // TypeDefIndex: 10046
{
	public float height; 
	public float radius; 
	public Vector3 center; 


	public void .ctor(float height, float radius, Vector3 center) { }

}

private sealed class BasePlayer.<>c // TypeDefIndex: 10047
{
	public static readonly BasePlayer.<>c <>9; 
	public static Func<PlayerTeam.TeamMember, ulong> <>9__103_0; 
	public static Comparison<TraceInfo> <>9__148_0; 
	public static Predicate<RespawnInformation.SpawnOptions> <>9__155_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal ulong <OnBecameRagdoll>b__103_0(PlayerTeam.TeamMember m) { }

	internal int <UpdateLookingAt>b__148_0(TraceInfo a, TraceInfo b) { }

	internal bool <OnRespawnInformation>b__155_0(RespawnInformation.SpawnOptions p) { }

}

private sealed class BasePlayer.<FinishedLoadingRoutine>d__161 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10048
{
	private int <>1__state; 
	private object <>2__current; 
	public BasePlayer <>4__this; 

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] 
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class BasePlayer.<>c__DisplayClass210_0 // TypeDefIndex: 10049
{
	public GestureConfig g; 
	public BasePlayer <>4__this; 


	public void .ctor() { }

	internal void <SetGestureMenuOpen>b__0(BasePlayer ply) { }

}

private sealed class BasePlayer.<>c__DisplayClass304_0 // TypeDefIndex: 10050
{
	public uint index; 


	public void .ctor() { }

	internal bool <CLIENT_SetPetPetLoadedStateIndex>b__0(PetCommandList.PetCommandDesc c) { }

}

private sealed class BasePlayer.<>c__DisplayClass306_0 // TypeDefIndex: 10051
{
	public PetCommandList.PetCommandDesc desc; 
	public BasePlayer <>4__this; 


	public void .ctor() { }

	internal void <SetPetMenuOpen>b__0(BasePlayer ply) { }

}

public class PlayerInventory : EntityComponent<BasePlayer> // TypeDefIndex: 10327
{
	public ItemContainer containerMain; 
	public ItemContainer containerBelt; 
	public ItemContainer containerWear; 
	public ItemCrafter crafting; 
	public PlayerLoot loot; 


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	protected void Initialize() { }

	public void DoDestroy() { }

	public void ClientInit(BasePlayer owner) { }

	[BaseEntity.RPC_Client] 
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

public enum PlayerInventory.Type // TypeDefIndex: 10328
{
	public int value__; 
	public const PlayerInventory.Type Main = 0;
	public const PlayerInventory.Type Belt = 1;
	public const PlayerInventory.Type Wear = 2;

}

public class PlayerLoot : EntityComponent<BasePlayer> // TypeDefIndex: 10329
{
	public BaseEntity entitySource; 
	public Item itemSource; 
	public List<ItemContainer> containers; 
	private EntityRef clientEntity; 


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public bool IsLooting() { }

	public void Clear() { }

	public ItemContainer FindContainer(uint id) { }

	public Item FindItem(uint id) { }

	public BaseEntity GetClientEntity() { }

	public void ClientInit(BasePlayer owner) { }

	[BaseEntity.RPC_Client] 
	private void UpdateLoot(BaseEntity.RPCMessage rpc) { }

	public void .ctor() { }

}

public class PlayerMetabolism : BaseMetabolism<BasePlayer> // TypeDefIndex: 10330
{
	public const float HotThreshold = 40;
	public const float ColdThreshold = 5;
	public const float OxygenHurtThreshold = 0,5;
	public const float OxygenDepleteTime = 10;
	public const float OxygenRefillTime = 1;
	public MetabolismAttribute temperature; 
	public MetabolismAttribute poison; 
	public MetabolismAttribute radiation_level; 
	public MetabolismAttribute radiation_poison; 
	public MetabolismAttribute wetness; 
	public MetabolismAttribute dirtyness; 
	public MetabolismAttribute oxygen; 
	public MetabolismAttribute bleeding; 
	public MetabolismAttribute comfort; 
	public MetabolismAttribute pending_health; 
	public bool isDirty; 
	private float lastConsumeTime; 
	private float lastUpdateTime; 


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void Reset() { }

	public bool CanConsume() { }

	public void MarkConsumption() { }

	public void ClientInit(BasePlayer owner) { }

	[BaseEntity.RPC_Client] 
	public void UpdateMetabolism(BaseEntity.RPCMessage packet) { }

	public PlayerMetabolism Save() { }

	public void Load(PlayerMetabolism s) { }

	public override MetabolismAttribute FindAttribute(MetabolismAttribute.Type type) { }

	public void OnLocalMetabolismUpdated() { }

	public void .ctor() { }

}

public class PlayerModifiers : BaseModifiers<BasePlayer> // TypeDefIndex: 10331
{

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public void Load(PlayerModifiers m) { }

	public void ClientInit(BasePlayer owner) { }

	[BaseEntity.RPC_Client] 
	public void UpdateModifiers(BaseEntity.RPCMessage packet) { }

	public void .ctor() { }

}

public class PlayerDetectionTrigger : TriggerBase // TypeDefIndex: 10411
{
	public BaseDetector myDetector; 


	public void .ctor() { }

}

public class PlayerModelHair : MonoBehaviour // TypeDefIndex: 10921
{
	public HairType type; 
	private Dictionary<Renderer, PlayerModelHair.RendererMaterials> materials; 

	public Dictionary<Renderer, PlayerModelHair.RendererMaterials> Materials { get; }


	public Dictionary<Renderer, PlayerModelHair.RendererMaterials> get_Materials() { }

	private void CacheOriginalMaterials() { }

	private void Setup(HairType type, HairSetCollection hair, int meshIndex, float typeNum, float dyeNum, MaterialPropertyBlock block) { }

	public void Setup(SkinSetCollection skin, float hairNum, float meshNum, MaterialPropertyBlock block) { }

	public static void GetRandomVariation(float hairNum, int typeIndex, int meshIndex, out float typeNum, out float dyeNum) { }

	public static float GetRandomHairType(float hairNum, int typeIndex) { }

	public void .ctor() { }

}

public struct PlayerModelHair.RendererMaterials // TypeDefIndex: 10922
{
	public string[] names; 
	public Material[] original; 
	public Material[] replacement; 


	public void .ctor(Renderer r) { }

}

public class PlayerModelHairCap : MonoBehaviour // TypeDefIndex: 10924
{
	[InspectorFlagsAttribute] 
	public HairCapMask hairCapMask; 


	public void SetupHairCap(SkinSetCollection skin, float hairNum, float meshNum, MaterialPropertyBlock block) { }

	public void .ctor() { }

}

public class PlayerModelSkin : MonoBehaviour, IPrefabPreProcess // TypeDefIndex: 10925
{
	public PlayerModelSkin.SkinMaterialType MaterialType; 
	public Renderer SkinRenderer; 


	public void Setup(SkinSetCollection skin, float hairNum, float meshNum) { }

	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public void .ctor() { }

}

public enum PlayerModelSkin.SkinMaterialType // TypeDefIndex: 10926
{
	public int value__; 
	public const PlayerModelSkin.SkinMaterialType HEAD = 0;
	public const PlayerModelSkin.SkinMaterialType EYE = 1;
	public const PlayerModelSkin.SkinMaterialType BODY = 2;

}

public class PlayerDetectedAIEvent : BaseAIEvent // TypeDefIndex: 11117
{
	[CompilerGeneratedAttribute] 
	private float <Range>k__BackingField; 

	public float Range { get; set; }


	[CompilerGeneratedAttribute] 
	public float get_Range() { }

	[CompilerGeneratedAttribute] 
	public void set_Range(float value) { }

	public void .ctor() { }

}

public class PlayerAnimationEvents : MonoBehaviour // TypeDefIndex: 11355
{
	private BasePlayer player; 


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

public class PlayerBelt // TypeDefIndex: 11356
{
	public static int SelectedSlot; 
	protected BasePlayer player; 

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

public class PlayerBlueprints : EntityComponent<BasePlayer> // TypeDefIndex: 11357
{
	public SteamInventory steamInventory; 
	private int[] craftableItems; 


	public void ClientInit() { }

	public void ClientUpdate(PersistantPlayer info) { }

	public bool HasUnlocked(ItemDefinition targetItem) { }

	public bool CanCraft(int itemid, int skinItemId, ulong playerId) { }

	public bool CheckSkinOwnership(int skinItemId, ulong playerId) { }

	public void .ctor() { }

}

public class PlayerEyes : EntityComponent<BasePlayer> // TypeDefIndex: 11358
{
	public static readonly Vector3 EyeOffset; 
	public static readonly Vector3 DuckOffset; 
	public static readonly Vector3 CrawlOffset; 
	public Vector3 thirdPersonSleepingOffset; 
	public LazyAimProperties defaultLazyAim; 
	private Vector3 viewOffset; 
	[CompilerGeneratedAttribute] 
	private Quaternion <bodyRotation>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Vector3 <headAngles>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Quaternion <rotationLook>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <IsAltLookingLegsThreshold>k__BackingField; 

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

	[CompilerGeneratedAttribute] 
	public Quaternion get_bodyRotation() { }

	[CompilerGeneratedAttribute] 
	public void set_bodyRotation(Quaternion value) { }

	[CompilerGeneratedAttribute] 
	public Vector3 get_headAngles() { }

	[CompilerGeneratedAttribute] 
	public void set_headAngles(Vector3 value) { }

	[CompilerGeneratedAttribute] 
	public Quaternion get_rotationLook() { }

	[CompilerGeneratedAttribute] 
	public void set_rotationLook(Quaternion value) { }

	public Quaternion get_parentRotation() { }

	public bool get_canUpdateViewAngles() { }

	[CompilerGeneratedAttribute] 
	public bool get_IsAltLookingLegsThreshold() { }

	[CompilerGeneratedAttribute] 
	private void set_IsAltLookingLegsThreshold(bool value) { }

	public void FrameUpdate(Camera cam) { }

	public void UpdateAltLegsThreshold(float yAngle) { }

	private void UpdateCamera(Camera cam) { }

	private void DoFirstPersonCamera(Camera cam) { }

	private void DoInEyeCamera(Camera cam) { }

	public void DoThirdPersonCamera(Camera cam) { }

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

public class PlayerInput : EntityComponent<BasePlayer> // TypeDefIndex: 11359
{
	public InputState state; 
	public bool hadInputBuffer; 
	private Quaternion bodyRotation; 
	private Vector3 bodyAngles; 
	private Quaternion headRotation; 
	private Vector3 headAngles; 
	public Vector3 recoilAngles; 
	public Vector2 viewDelta; 
	private float headLerp; 
	private int mouseWheelUp; 
	private int mouseWheelDn; 
	private bool autorun; 
	private bool toggleDuck; 
	private bool toggleAds; 
	private uint lastAdsEntity; 
	private Vector3 pendingMouseDelta; 
	public Vector3 offsetAngles; 
	private int ignoredButtons; 
	private bool hasKeyFocus; 

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

public class PlayerModel : ListComponent<PlayerModel>, IOnParentDestroying // TypeDefIndex: 11360
{
	public static float pm_uplimit; 
	public static float pm_downlimit; 
	public static float pm_upspine; 
	public static float pm_downspine; 
	public static Vector3 pm_lookoffset; 
	public static float pm_anglesmoothspeed; 
	public static float pm_nohold; 
	public static float pm_ladder; 
	public static float pm_minweight; 
	private float _smoothAimWeight; 
	private float _smoothVelocity; 
	private Vector3 _smoothlookAngle; 
	private bool allowMountedHeadLook; 
	private Vector3 smoothLookDir; 
	private Vector3 lastSafeLookDir; 
	public Transform[] Shoulders; 
	public Transform[] AdditionalSpineBones; 
	private static readonly HashSet<Wearable> FinishedLegWearables; 
	protected List<SkinnedMeshRenderer> LegParts; 
	private Transform[] fakeSpineBones; 
	private float extraLeanBack; 
	private Nullable<bool> drawState; 
	private float timeInArmsMode; 
	protected static int speed; 
	protected static int acceleration; 
	protected static int rotationYaw; 
	protected static int forward; 
	protected static int right; 
	protected static int up; 
	protected static int ducked; 
	protected static int grounded; 
	protected static int crawling; 
	protected static int waterlevel; 
	protected static int attack; 
	protected static int attack_alt; 
	protected static int deploy; 
	protected static int reload; 
	protected static int throwWeapon; 
	protected static int holster; 
	protected static int aiming; 
	protected static int onLadder; 
	protected static int posing; 
	protected static int poseType; 
	protected static int relaxGunPose; 
	protected static int vehicle_aim_yaw; 
	protected static int vehicle_aim_speed; 
	protected static int onPhone; 
	protected static int usePoseTransition; 
	protected static int leftFootIK; 
	protected static int rightFootIK; 
	protected static int vehicleSteering; 
	protected static int sitReaction; 
	protected static int forwardReaction; 
	protected static int rightReaction; 
	public BoxCollider collision; 
	public GameObject censorshipCube; 
	public GameObject censorshipCubeBreasts; 
	public GameObject jawBone; 
	public GameObject neckBone; 
	public GameObject headBone; 
	public EyeController eyeController; 
	public EyeBlink blinkController; 
	public Transform[] SpineBones; 
	public Transform leftFootBone; 
	public Transform rightFootBone; 
	public Transform leftHandPropBone; 
	public Transform rightHandPropBone; 
	public Vector3 rightHandTarget; 
	[HeaderAttribute] 
	public Vector3 leftHandTargetPosition; 
	public Quaternion leftHandTargetRotation; 
	public Vector3 rightHandTargetPosition; 
	public Quaternion rightHandTargetRotation; 
	public float steeringTargetDegrees; 
	public Vector3 rightFootTargetPosition; 
	public Quaternion rightFootTargetRotation; 
	public Vector3 leftFootTargetPosition; 
	public Quaternion leftFootTargetRotation; 
	public RuntimeAnimatorController CinematicAnimationController; 
	public Avatar DefaultAvatar; 
	public Avatar CinematicAvatar; 
	public RuntimeAnimatorController DefaultHoldType; 
	public RuntimeAnimatorController SleepGesture; 
	public RuntimeAnimatorController CrawlToIncapacitatedGesture; 
	public RuntimeAnimatorController StandToIncapacitatedGesture; 
	public RuntimeAnimatorController CurrentGesture; 
	[HeaderAttribute] 
	public SkinSetCollection MaleSkin; 
	public SkinSetCollection FemaleSkin; 
	public SubsurfaceProfile subsurfaceProfile; 
	[HeaderAttribute] 
	[RangeAttribute] 
	public float voiceVolume; 
	[RangeAttribute] 
	public float skinColor; 
	[RangeAttribute] 
	public float skinNumber; 
	[RangeAttribute] 
	public float meshNumber; 
	[RangeAttribute] 
	public float hairNumber; 
	[RangeAttribute] 
	public int skinType; 
	public MovementSounds movementSounds; 
	public bool showSash; 
	public int tempPoseType; 
	public uint underwearSkin; 
	[CompilerGeneratedAttribute] 
	private ulong <overrideSkinSeed>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Quaternion <AimAngles>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Quaternion <LookAngles>k__BackingField; 
	private const int LayerHands = 1;
	private const int LayerGestures = 2;
	private const int LayerPlayerGesturesUpperBody = 3;
	private const int LayerPlayerGesturesFullBody = 4;
	private const int LayerReactions = 5;
	private ModelState modelState; 
	internal Vector3 position; 
	internal Vector3 velocity; 
	internal Vector3 speedOverride; 
	private Vector3 newVelocity; 
	internal Quaternion rotation; 
	internal Quaternion mountedRotation; 
	internal Vector3 smoothLeftFootIK; 
	internal Vector3 smoothRightFootIK; 
	internal bool drawShadowOnly; 
	internal bool isIncapacitated; 
	internal uint flinchLocation; 
	internal bool visible; 
	internal PlayerNameTag nameTag; 
	private bool animatorNeedsWarmup; 
	internal bool isLocalPlayer; 
	private SoundDefinition aimSoundDef; 
	private SoundDefinition aimEndSoundDef; 
	private bool InGesture; 
	private GestureConfig CurrentGestureConfig; 
	private bool InCinematic; 
	private RuntimeAnimatorController defaultAnimatorController; 
	private SkinnedMultiMesh _multiMesh; 
	private Animator _animator; 
	private LODGroup _lodGroup; 
	private RuntimeAnimatorController _currentGesture; 
	private float holdTypeLock; 
	private bool hasHeldEntity; 
	private bool wasMountedRightAim; 
	private int cachedMask; 
	private int cachedConstructionMask; 
	private HeldEntity WorkshopHeldEntity; 
	private bool wasCrawling; 
	private float mountedSpineLookWeight; 
	private float mountedAnimSpeed; 
	private bool preserveBones; 
	private Nullable<float> downLimitOverride; 
	[CompilerGeneratedAttribute] 
	private bool <IsNpc>k__BackingField; 
	private TimeSince timeSinceReactionStart; 
	private TimeSince timeSinceLeftFootTest; 
	private Vector3 cachedLeftFootPos; 
	private Vector3 cachedLeftFootNormal; 
	private TimeSince timeSinceRightFootTest; 
	private Vector3 cachedRightFootPos; 
	private Vector3 cachedRightFootNormal; 

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

	[CompilerGeneratedAttribute] 
	public ulong get_overrideSkinSeed() { }

	[CompilerGeneratedAttribute] 
	private void set_overrideSkinSeed(ulong value) { }

	public bool get_IsFemale() { }

	public SkinSetCollection get_SkinSet() { }

	[CompilerGeneratedAttribute] 
	public Quaternion get_AimAngles() { }

	[CompilerGeneratedAttribute] 
	public void set_AimAngles(Quaternion value) { }

	[CompilerGeneratedAttribute] 
	public Quaternion get_LookAngles() { }

	[CompilerGeneratedAttribute] 
	public void set_LookAngles(Quaternion value) { }

	private bool get_GestureAllowsSpineMovement() { }

	private bool get_GestureAllowsRootMotion() { }

	public bool get_IsFirstPerson() { }

	[CompilerGeneratedAttribute] 
	public bool get_IsNpc() { }

	[CompilerGeneratedAttribute] 
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

	[IteratorStateMachineAttribute] 
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

public enum PlayerModel.MountPoses // TypeDefIndex: 11361
{
	public int value__; 
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

public enum PlayerModel.ReactionDir // TypeDefIndex: 11362
{
	public int value__; 
	public const PlayerModel.ReactionDir North = 0;
	public const PlayerModel.ReactionDir South = 1;
	public const PlayerModel.ReactionDir East = 2;
	public const PlayerModel.ReactionDir West = 3;

}

private sealed class PlayerModel.<>c // TypeDefIndex: 11363
{
	public static readonly PlayerModel.<>c <>9; 
	public static Func<Wearable, bool> <>9__199_0; 
	public static Func<Wearable, bool> <>9__199_1; 
	public static Func<Wearable, bool> <>9__199_2; 


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <UpdateCensorship>b__199_0(Wearable x) { }

	internal bool <UpdateCensorship>b__199_1(Wearable x) { }

	internal bool <UpdateCensorship>b__199_2(Wearable y) { }

}

private sealed class PlayerModel.<FadeOutGestureLayer>d__244 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11364
{
	private int <>1__state; 
	private object <>2__current; 
	public PlayerModel <>4__this; 

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] 
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class PlayerModel.<>c__DisplayClass256_0 // TypeDefIndex: 11365
{
	public string strName; 


	public void .ctor() { }

	internal bool <RemovePart>b__0(SkinnedMultiMesh.Part x) { }

}

private sealed class PlayerModel.<>c__DisplayClass257_0 // TypeDefIndex: 11366
{
	public string strName; 


	public void .ctor() { }

	internal bool <HasPart>b__0(SkinnedMultiMesh.Part x) { }

}

public class PlayerModelCinematicList : PrefabAttribute, IClientComponent // TypeDefIndex: 11367
{
	public PlayerModelCinematicList.PlayerModelCinematicAnimation[] Animations; 


	protected override Type GetIndexedType() { }

	public override void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public void .ctor() { }

}

public struct PlayerModelCinematicList.PlayerModelCinematicAnimation // TypeDefIndex: 11368
{
	public string StateName; 
	public string ClipName; 
	public float Length; 

}

public class PlayerModelReactionEnded : StateMachineBehaviour // TypeDefIndex: 11369
{
	private PlayerModel playerModel; 


	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public void .ctor() { }

}

public class PlayerNameTag : MonoBehaviour // TypeDefIndex: 11370
{
	public CanvasGroup canvasGroup; 
	public Text text; 
	public Gradient color; 
	public float minDistance; 
	public float maxDistance; 
	public Vector3 positionOffset; 
	public Transform parentBone; 
	private float distanceFromCamera; 
	internal string lastName; 


	public void Initialize(BasePlayer player, Transform parent) { }

	public void UpdateFrom(BasePlayer player) { }

	private void LateUpdate() { }

	private void UpdateNameColor() { }

	public void PositionUpdate(bool visible) { }

	public void .ctor() { }

}

public class PlayerVoiceRecorder : EntityComponent<BasePlayer> // TypeDefIndex: 11372
{
	internal static byte[] readBuffer; 
	internal static byte[] readBufferUncompressed; 
	private RealTimeSince timeSinceLastSpeak; 
	private RealTimeSince timeSinceLastCheck; 
	private Stopwatch TalkTimer; 

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

public class PlayerVoiceSpeaker : EntityComponent<BasePlayer> // TypeDefIndex: 11373
{
	public VoiceProcessor voiceProcessor; 
	private float nextSpeechFakeChange; 
	private float speechFakeChangeMulti; 
	private bool isFakingVolume; 
	private float fakedVolume; 
	private static bool hasAwardedRecordVoicesAchievement; 

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

public class PlayerWalkMovement : BaseMovement // TypeDefIndex: 11379
{
	public const float WaterLevelHead = 0,75;
	public const float WaterLevelNeck = 0,65;
	public PhysicMaterial zeroFrictionMaterial; 
	public PhysicMaterial highFrictionMaterial; 
	public float capsuleHeight; 
	public float capsuleCenter; 
	public float capsuleHeightDucked; 
	public float capsuleCenterDucked; 
	public float capsuleHeightCrawling; 
	public float capsuleCenterCrawling; 
	public float gravityTestRadius; 
	public float gravityMultiplier; 
	public float gravityMultiplierSwimming; 
	public float maxAngleWalking; 
	public float maxAngleClimbing; 
	public float maxAngleSliding; 
	public float maxStepHeight; 
	private Rigidbody body; 
	private CollisionDetectionMode initialColDetectionMode; 
	private CapsuleCollider capsule; 
	private TriggerLadder ladder; 
	private float maxVelocity; 
	private float groundAngle; 
	private float groundAngleNew; 
	private float groundTime; 
	private float jumpTime; 
	private float landTime; 
	private Vector3 previousPosition; 
	private Vector3 previousVelocity; 
	private Vector3 previousInheritedVelocity; 
	private Vector3 groundNormal; 
	private Vector3 groundNormalNew; 
	private Vector3 groundVelocity; 
	private Vector3 groundVelocityNew; 
	private float nextSprintTime; 
	private float lastSprintTime; 
	private bool sprintForced; 
	private TimeSince attemptedMountTime; 
	private BaseEntity.MovementModify modify; 
	private bool grounded; 
	private bool climbing; 
	private bool sliding; 
	private bool swimming; 
	private bool wasSwimming; 
	private bool jumping; 
	private bool wasJumping; 
	private bool falling; 
	private bool wasFalling; 
	private bool flying; 
	private bool wasFlying; 
	private float forcedDuckDelta; 


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

public class PlayerCorpse : LootableCorpse // TypeDefIndex: 11380
{
	public Buoyancy buoyancy; 
	public const BaseEntity.Flags Flag_Buoyant = 16384;
	public uint underwearSkin; 
	private ItemContainer clientClothing; 
	private uint lastClothes; 


	public bool IsBuoyant() { }

	protected override void ClientInit(Entity info) { }

	private void RebuildWorldModel() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	private void ToggleClientBuoyancy(bool isBuoyant) { }

	public override string Categorize() { }

	public void .ctor() { }

}

public class PlayerInventoryProperties : ScriptableObject // TypeDefIndex: 12465
{
	public string niceName; 
	public int order; 
	public List<PlayerInventoryProperties.ItemAmountSkinned> belt; 
	public List<PlayerInventoryProperties.ItemAmountSkinned> main; 
	public List<PlayerInventoryProperties.ItemAmountSkinned> wear; 
	public PlayerInventoryProperties giveBase; 


	public void .ctor() { }

}

public class PlayerInventoryProperties.ItemAmountSkinned : ItemAmount // TypeDefIndex: 12466
{
	public ulong skinOverride; 


	public void .ctor() { }

}

public class PlayerDetectedEventUI : BaseEventUI // TypeDefIndex: 12525
{

	public override void Init(AIEventType eventType, BaseStateUI stateUI) { }

	public override AIEventData Save() { }

	public override void Load(AIEventData data) { }

	public void .ctor() { }

}

public class Player : ConsoleSystem // TypeDefIndex: 13688
{
	[ServerVar] 
	public static int tickrate_cl; 
	[ServerVar] 
	public static int tickrate_sv; 
	[ClientVar] 
	public static bool recoilcomp; 
	[ClientVar] 
	public static bool footik; 
	[ClientVar] 
	public static float footikdistance; 
	[ClientVar] 
	public static float footikrate; 
	[ClientVar] 
	public static bool triggerfix; 
	[ClientVar] 
	public static bool eye_blinking; 
	[ClientVar] 
	public static bool eye_movement; 
	[ClientVar] 
	public static bool useCinematicAvatar; 
	[ClientVar] 
	public static float noclipspeed; 
	[ClientVar] 
	public static float noclipspeedslow; 
	[ClientVar] 
	public static float noclipspeedfast; 


	[ClientVar] 
	public static void cinematic_list(ConsoleSystem.Arg arg) { }

	[ClientVar] 
	public static void gesture(ConsoleSystem.Arg arg) { }

	[ClientVar] 
	public static void petcmd(ConsoleSystem.Arg arg) { }

	[ServerUserVar] 
	[ClientVar] 
	public static void cinematic_play(ConsoleSystem.Arg arg) { }

	[ServerUserVar] 
	[ClientVar] 
	public static void cinematic_stop(ConsoleSystem.Arg arg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class PlayerCull : ConsoleSystem // TypeDefIndex: 13689
{
	private static bool _enabled; 
	[ClientVar] 
	public static float updateRate; 
	[ClientVar] 
	public static float minCullDist; 
	[ClientVar] 
	public static float maxSleeperDist; 
	[ClientVar] 
	public static float maxPlayerDist; 
	[ClientVar] 
	public static int visQuality; 
	[ClientVar] 
	public static bool debug; 

	[ClientVar] 
	public static bool enabled { get; set; }


	public static bool get_enabled() { }

	public static void set_enabled(bool value) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum PlayerMenuAnimation.Layers // TypeDefIndex: 13886
{

public enum PlayerMenuAnimation.Layers
	public int value__; 
	public const PlayerMenuAnimation.Layers Movement = 0;

}

