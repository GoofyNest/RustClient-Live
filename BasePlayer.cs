internal class PlayerConnectionInternal : IPlayerEditorConnectionNative // TypeDefIndex: 3475
{	// Methods

	// RVA: 0x18F5BB0 Offset: 0x18F4FB0 VA: 0x1818F5BB0 Slot: 6
	private void UnityEngine.IPlayerEditorConnectionNative.SendMessage(Guid messageId, byte[] data, int playerId) { }

	// RVA: 0x18F5CD0 Offset: 0x18F50D0 VA: 0x1818F5CD0 Slot: 7
	private bool UnityEngine.IPlayerEditorConnectionNative.TrySendMessage(Guid messageId, byte[] data, int playerId) { }

	// RVA: 0x18F5A10 Offset: 0x18F4E10 VA: 0x1818F5A10 Slot: 8
	private void UnityEngine.IPlayerEditorConnectionNative.Poll() { }

	// RVA: 0x18F5B40 Offset: 0x18F4F40 VA: 0x1818F5B40 Slot: 9
	private void UnityEngine.IPlayerEditorConnectionNative.RegisterInternal(Guid messageId) { }

	// RVA: 0x18F5DF0 Offset: 0x18F51F0 VA: 0x1818F5DF0 Slot: 10
	private void UnityEngine.IPlayerEditorConnectionNative.UnregisterInternal(Guid messageId) { }

	// RVA: 0x18F59B0 Offset: 0x18F4DB0 VA: 0x1818F59B0 Slot: 4
	private void UnityEngine.IPlayerEditorConnectionNative.Initialize() { }

	// RVA: 0x18F59E0 Offset: 0x18F4DE0 VA: 0x1818F59E0 Slot: 11
	private bool UnityEngine.IPlayerEditorConnectionNative.IsConnected() { }

	// RVA: 0x18F5980 Offset: 0x18F4D80 VA: 0x1818F5980 Slot: 5
	private void UnityEngine.IPlayerEditorConnectionNative.DisconnectAll() { }

	[FreeFunctionAttribute] // RVA: 0xB0910 Offset: 0xAFD10 VA: 0x1800B0910
	// RVA: 0x18F59E0 Offset: 0x18F4DE0 VA: 0x1818F59E0
	private static bool IsConnected() { }

	[FreeFunctionAttribute] // RVA: 0xB0940 Offset: 0xAFD40 VA: 0x1800B0940
	// RVA: 0x18F59B0 Offset: 0x18F4DB0 VA: 0x1818F59B0
	private static void Initialize() { }

	[FreeFunctionAttribute] // RVA: 0xB0A10 Offset: 0xAFE10 VA: 0x1800B0A10
	// RVA: 0x18F5A40 Offset: 0x18F4E40 VA: 0x1818F5A40
	private static void RegisterInternal(string messageId) { }

	[FreeFunctionAttribute] // RVA: 0xB0A80 Offset: 0xAFE80 VA: 0x1800B0A80
	// RVA: 0x18F5E60 Offset: 0x18F5260 VA: 0x1818F5E60
	private static void UnregisterInternal(string messageId) { }

	[FreeFunctionAttribute] // RVA: 0xB1DE0 Offset: 0xB11E0 VA: 0x1800B1DE0
	// RVA: 0x18F5A80 Offset: 0x18F4E80 VA: 0x1818F5A80
	private static void SendMessage(string messageId, byte[] data, int playerId) { }

	[FreeFunctionAttribute] // RVA: 0xB1EB0 Offset: 0xB12B0 VA: 0x1800B1EB0
	// RVA: 0x18F5AE0 Offset: 0x18F4EE0 VA: 0x1818F5AE0
	private static bool TrySendMessage(string messageId, byte[] data, int playerId) { }

	[FreeFunctionAttribute] // RVA: 0xB2060 Offset: 0xB1460 VA: 0x1800B2060
	// RVA: 0x18F5A10 Offset: 0x18F4E10 VA: 0x1818F5A10
	private static void PollInternal() { }

	[FreeFunctionAttribute] // RVA: 0xB2240 Offset: 0xB1640 VA: 0x1800B2240
	// RVA: 0x18F5980 Offset: 0x18F4D80 VA: 0x1818F5980
	private static void DisconnectAll() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class PlayerPrefsException : Exception // TypeDefIndex: 3476
{	// Methods

	// RVA: 0x18F7C50 Offset: 0x18F7050 VA: 0x1818F7C50
	public void .ctor(string error) { }

}

public class PlayerPrefs // TypeDefIndex: 3477
{	// Methods

	[NativeMethodAttribute] // RVA: 0xB23E0 Offset: 0xB17E0 VA: 0x1800B23E0
	// RVA: 0x18F8130 Offset: 0x18F7530 VA: 0x1818F8130
	private static bool TrySetInt(string key, int value) { }

	[NativeMethodAttribute] // RVA: 0xB2550 Offset: 0xB1950 VA: 0x1800B2550
	// RVA: 0x18F80E0 Offset: 0x18F74E0 VA: 0x1818F80E0
	private static bool TrySetFloat(string key, float value) { }

	[NativeMethodAttribute] // RVA: 0xB2710 Offset: 0xB1B10 VA: 0x1800B2710
	// RVA: 0x18F8170 Offset: 0x18F7570 VA: 0x1818F8170
	private static bool TrySetSetString(string key, string value) { }

	// RVA: 0x18F7FB0 Offset: 0x18F73B0 VA: 0x1818F7FB0
	public static void SetInt(string key, int value) { }

	// RVA: 0x18F7D90 Offset: 0x18F7190 VA: 0x1818F7D90
	public static int GetInt(string key, int defaultValue) { }

	// RVA: 0x18F7DD0 Offset: 0x18F71D0 VA: 0x1818F7DD0
	public static int GetInt(string key) { }

	// RVA: 0x18F7F10 Offset: 0x18F7310 VA: 0x1818F7F10
	public static void SetFloat(string key, float value) { }

	// RVA: 0x18F7D00 Offset: 0x18F7100 VA: 0x1818F7D00
	public static float GetFloat(string key, float defaultValue) { }

	// RVA: 0x18F7D50 Offset: 0x18F7150 VA: 0x1818F7D50
	public static float GetFloat(string key) { }

	// RVA: 0x18F8040 Offset: 0x18F7440 VA: 0x1818F8040
	public static void SetString(string key, string value) { }

	// RVA: 0x18F7E80 Offset: 0x18F7280 VA: 0x1818F7E80
	public static string GetString(string key, string defaultValue) { }

	// RVA: 0x18F7E10 Offset: 0x18F7210 VA: 0x1818F7E10
	public static string GetString(string key) { }

	// RVA: 0x18F7ED0 Offset: 0x18F72D0 VA: 0x1818F7ED0
	public static bool HasKey(string key) { }

	// RVA: 0x18F7CC0 Offset: 0x18F70C0 VA: 0x1818F7CC0
	public static void DeleteKey(string key) { }

}

internal struct PlayerLoopSystemInternal // TypeDefIndex: 3662
{	// Fields
	public Type type; // 0x0
	public PlayerLoopSystem.UpdateFunction updateDelegate; // 0x8
	public IntPtr updateFunction; // 0x10
	public IntPtr loopConditionFunction; // 0x18
	public int numSubSystems; // 0x20

}

public struct PlayerLoopSystem // TypeDefIndex: 3663
{	// Fields
	public Type type; // 0x0
	public PlayerLoopSystem[] subSystemList; // 0x8
	public PlayerLoopSystem.UpdateFunction updateDelegate; // 0x10
	public IntPtr updateFunction; // 0x18
	public IntPtr loopConditionFunction; // 0x20

}

public sealed class PlayerLoopSystem.UpdateFunction : MulticastDelegate // TypeDefIndex: 3664
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x145EF20 Offset: 0x145E320 VA: 0x18145EF20 Slot: 12
	public virtual void Invoke() { }

	// RVA: 0x497020 Offset: 0x496420 VA: 0x180497020 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public class PlayerConnection : ScriptableObject // TypeDefIndex: 3789
{	// Fields
	internal static IPlayerEditorConnectionNative connectionNative; // 0x0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private PlayerEditorConnectionEvents m_PlayerEditorConnectionEvents; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private List<int> m_connectedPlayers; // 0x20
	private bool m_IsInitilized; // 0x28
	private static PlayerConnection s_Instance; // 0x8

	// Properties
	public static PlayerConnection instance { get; }
	public bool isConnected { get; }

	// Methods

	// RVA: 0x18F72D0 Offset: 0x18F66D0 VA: 0x1818F72D0
	public static PlayerConnection get_instance() { }

	// RVA: 0x18F7480 Offset: 0x18F6880 VA: 0x1818F7480
	public bool get_isConnected() { }

	// RVA: 0x18F6190 Offset: 0x18F5590 VA: 0x1818F6190
	private static PlayerConnection CreateInstance() { }

	// RVA: 0x18F64E0 Offset: 0x18F58E0 VA: 0x1818F64E0
	public void OnEnable() { }

	// RVA: 0x18F6350 Offset: 0x18F5750 VA: 0x1818F6350
	private IPlayerEditorConnectionNative GetConnectionNativeApi() { }

	// RVA: 0x18F6740 Offset: 0x18F5B40 VA: 0x1818F6740 Slot: 4
	public void Register(Guid messageId, UnityAction<MessageEventArgs> callback) { }

	// RVA: 0x18F6EC0 Offset: 0x18F62C0 VA: 0x1818F6EC0 Slot: 5
	public void Unregister(Guid messageId, UnityAction<MessageEventArgs> callback) { }

	// RVA: 0x18F6580 Offset: 0x18F5980 VA: 0x1818F6580 Slot: 6
	public void RegisterConnection(UnityAction<int> callback) { }

	// RVA: 0x18F66E0 Offset: 0x18F5AE0 VA: 0x1818F66E0 Slot: 7
	public void RegisterDisconnection(UnityAction<int> callback) { }

	// RVA: 0x18F6E00 Offset: 0x18F6200 VA: 0x1818F6E00 Slot: 8
	public void UnregisterConnection(UnityAction<int> callback) { }

	// RVA: 0x18F6E60 Offset: 0x18F6260 VA: 0x1818F6E60 Slot: 9
	public void UnregisterDisconnection(UnityAction<int> callback) { }

	// RVA: 0x18F6AA0 Offset: 0x18F5EA0 VA: 0x1818F6AA0 Slot: 10
	public void Send(Guid messageId, byte[] data) { }

	// RVA: 0x18F6C50 Offset: 0x18F6050 VA: 0x1818F6C50 Slot: 11
	public bool TrySend(Guid messageId, byte[] data) { }

	// RVA: 0x18F5EA0 Offset: 0x18F52A0 VA: 0x1818F5EA0
	public bool BlockUntilRecvMsg(Guid messageId, int timeout) { }

	// RVA: 0x18F6240 Offset: 0x18F5640 VA: 0x1818F6240 Slot: 12
	public void DisconnectAll() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x18F63B0 Offset: 0x18F57B0 VA: 0x1818F63B0
	private static void MessageCallbackInternal(IntPtr data, ulong size, ulong guid, string messageId) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x18F6110 Offset: 0x18F5510 VA: 0x1818F6110
	private static void ConnectedCallbackInternal(int playerId) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x18F62D0 Offset: 0x18F56D0 VA: 0x1818F62D0
	private static void DisconnectedCallback(int playerId) { }

	// RVA: 0x18F7150 Offset: 0x18F6550 VA: 0x1818F7150
	public void .ctor() { }

}

private sealed class PlayerConnection.<>c__DisplayClass12_0 // TypeDefIndex: 3790
{	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x18FC240 Offset: 0x18FB640 VA: 0x1818FC240
	internal bool <Register>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x) { }

}

private sealed class PlayerConnection.<>c__DisplayClass13_0 // TypeDefIndex: 3791
{	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x18FC2F0 Offset: 0x18FB6F0 VA: 0x1818FC2F0
	internal bool <Unregister>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x) { }

}

private sealed class PlayerConnection.<>c__DisplayClass20_0 // TypeDefIndex: 3792
{	// Fields
	public bool msgReceived; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x101B920 Offset: 0x101AD20 VA: 0x18101B920
	internal void <BlockUntilRecvMsg>b__0(MessageEventArgs args) { }

}

internal class PlayerEditorConnectionEvents // TypeDefIndex: 3793
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public List<PlayerEditorConnectionEvents.MessageTypeSubscribers> messageTypeSubscribers; // 0x10
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public PlayerEditorConnectionEvents.ConnectionChangeEvent connectionEvent; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public PlayerEditorConnectionEvents.ConnectionChangeEvent disconnectionEvent; // 0x20

	// Methods

	// RVA: 0x18F76F0 Offset: 0x18F6AF0 VA: 0x1818F76F0
	public void InvokeMessageIdSubscribers(Guid messageId, byte[] data, int playerId) { }

	// RVA: 0x18F7510 Offset: 0x18F6910 VA: 0x1818F7510
	public UnityEvent<MessageEventArgs> AddAndCreate(Guid messageId) { }

	// RVA: 0x18F7A40 Offset: 0x18F6E40 VA: 0x1818F7A40
	public void UnregisterManagedCallback(Guid messageId, UnityAction<MessageEventArgs> callback) { }

	// RVA: 0x18F7B50 Offset: 0x18F6F50 VA: 0x1818F7B50
	public void .ctor() { }

}

public class PlayerEditorConnectionEvents.MessageEvent : UnityEvent<MessageEventArgs> // TypeDefIndex: 3794
{	// Methods

	// RVA: 0x18F1C90 Offset: 0x18F1090 VA: 0x1818F1C90
	public void .ctor() { }

}

public class PlayerEditorConnectionEvents.ConnectionChangeEvent : UnityEvent<int> // TypeDefIndex: 3795
{	// Methods

	// RVA: 0x18E4190 Offset: 0x18E3590 VA: 0x1818E4190
	public void .ctor() { }

}

public class PlayerEditorConnectionEvents.MessageTypeSubscribers // TypeDefIndex: 3796
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string m_messageTypeId; // 0x10
	public int subscriberCount; // 0x18
	public PlayerEditorConnectionEvents.MessageEvent messageCallback; // 0x20

	// Properties
	public Guid MessageTypeId { get; set; }

	// Methods

	// RVA: 0x18F1D60 Offset: 0x18F1160 VA: 0x1818F1D60
	public Guid get_MessageTypeId() { }

	// RVA: 0x18F1DA0 Offset: 0x18F11A0 VA: 0x1818F1DA0
	public void set_MessageTypeId(Guid value) { }

	// RVA: 0x18F1CD0 Offset: 0x18F10D0 VA: 0x1818F1CD0
	public void .ctor() { }

}

private sealed class PlayerEditorConnectionEvents.<>c__DisplayClass6_0 // TypeDefIndex: 3797
{	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x18FC3A0 Offset: 0x18FB7A0 VA: 0x1818FC3A0
	internal bool <InvokeMessageIdSubscribers>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x) { }

}

private sealed class PlayerEditorConnectionEvents.<>c__DisplayClass7_0 // TypeDefIndex: 3798
{	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x18FC450 Offset: 0x18FB850 VA: 0x1818FC450
	internal bool <AddAndCreate>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x) { }

}

private sealed class PlayerEditorConnectionEvents.<>c__DisplayClass8_0 // TypeDefIndex: 3799
{	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x18FC500 Offset: 0x18FB900 VA: 0x1818FC500
	internal bool <UnregisterManagedCallback>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x) { }

}

public struct PlayerItemRecipe : IEquatable<PlayerItemRecipe> // TypeDefIndex: 5698
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly IReadOnlyList<PlayerItemRecipe.Ingredient> <Ingredients>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly IPlayerItemDefinition <Result>k__BackingField; // 0x8

	// Properties
	public IReadOnlyList<PlayerItemRecipe.Ingredient> Ingredients { get; }
	public IPlayerItemDefinition Result { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xFC6D0 Offset: 0xFBAD0 VA: 0x1800FC6D0
	public IReadOnlyList<PlayerItemRecipe.Ingredient> get_Ingredients() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF3DB0 Offset: 0xF31B0 VA: 0x1800F3DB0
	public IPlayerItemDefinition get_Result() { }

	// RVA: 0x23F5D0 Offset: 0x23E9D0 VA: 0x18023F5D0
	public void .ctor(IReadOnlyList<PlayerItemRecipe.Ingredient> ingredients, IPlayerItemDefinition result) { }

	// RVA: 0x23F480 Offset: 0x23E880 VA: 0x18023F480 Slot: 4
	public bool Equals(PlayerItemRecipe other) { }

	// RVA: 0x23F3E0 Offset: 0x23E7E0 VA: 0x18023F3E0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x23F4A0 Offset: 0x23E8A0 VA: 0x18023F4A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x22FAFF0 Offset: 0x22FA3F0 VA: 0x1822FAFF0
	public static bool op_Equality(PlayerItemRecipe left, PlayerItemRecipe right) { }

	// RVA: 0x22FB010 Offset: 0x22FA410 VA: 0x1822FB010
	public static bool op_Inequality(PlayerItemRecipe left, PlayerItemRecipe right) { }

}

public struct PlayerItemRecipe.Ingredient : IEquatable<PlayerItemRecipe.Ingredient> // TypeDefIndex: 5699
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly int <DefinitionId>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly int <Amount>k__BackingField; // 0x4

	// Properties
	public int DefinitionId { get; }
	public int Amount { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF3850 Offset: 0xF2C50 VA: 0x1800F3850
	public int get_DefinitionId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x14B670 Offset: 0x14AA70 VA: 0x18014B670
	public int get_Amount() { }

	// RVA: 0xF8460 Offset: 0xF7860 VA: 0x1800F8460
	public void .ctor(int definitionId, int amount) { }

	// RVA: 0xFA450 Offset: 0xF9850 VA: 0x1800FA450 Slot: 4
	public bool Equals(PlayerItemRecipe.Ingredient other) { }

	// RVA: 0x23F340 Offset: 0x23E740 VA: 0x18023F340 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x23F3D0 Offset: 0x23E7D0 VA: 0x18023F3D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x9519F0 Offset: 0x950DF0 VA: 0x1809519F0
	public static bool op_Equality(PlayerItemRecipe.Ingredient left, PlayerItemRecipe.Ingredient right) { }

	// RVA: 0x951A10 Offset: 0x950E10 VA: 0x180951A10
	public static bool op_Inequality(PlayerItemRecipe.Ingredient left, PlayerItemRecipe.Ingredient right) { }

}

private sealed class PlayerItemRecipe.<>c // TypeDefIndex: 5700
{	// Fields
	public static readonly PlayerItemRecipe.<>c <>9; // 0x0
	public static Func<PlayerItemRecipe.Ingredient, int> <>9__10_0; // 0x8

	// Methods

	// RVA: 0x22FB860 Offset: 0x22FAC60 VA: 0x1822FB860
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x22FB7A0 Offset: 0x22FABA0 VA: 0x1822FB7A0
	internal int <GetHashCode>b__10_0(PlayerItemRecipe.Ingredient i) { }

}

public static class PlayerItemExtensions // TypeDefIndex: 6156
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x23109B0 Offset: 0x230FDB0 VA: 0x1823109B0
	public static IPlayerItemDefinition GetDefinition(IPlayerItem item) { }

}

public struct PlayerInfo // TypeDefIndex: 6250
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Name>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Id>k__BackingField; // 0x8

	// Properties
	public string Name { get; set; }
	public string Id { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xFC6D0 Offset: 0xFBAD0 VA: 0x1800FC6D0
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF1380 Offset: 0xF0780 VA: 0x1800F1380
	public void set_Name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF3DB0 Offset: 0xF31B0 VA: 0x1800F3DB0
	public string get_Id() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF1390 Offset: 0xF0790 VA: 0x1800F1390
	public void set_Id(string value) { }

}

public class PlayerTick : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6277
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public InputMessage inputState; // 0x18
	public Vector3 position; // 0x20
	public ModelState modelState; // 0x30
	public uint activeItem; // 0x38
	public Vector3 eyePos; // 0x3C
	public uint parentID; // 0x48
	public uint deltaMs; // 0x4C

	// Methods

	// RVA: 0x201C2B0 Offset: 0x201B6B0 VA: 0x18201C2B0
	public static void ResetToPool(PlayerTick instance) { }

	// RVA: 0x201C3F0 Offset: 0x201B7F0 VA: 0x18201C3F0
	public void ResetToPool() { }

	// RVA: 0x201BDA0 Offset: 0x201B1A0 VA: 0x18201BDA0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x201A300 Offset: 0x2019700 VA: 0x18201A300
	public void CopyTo(PlayerTick instance) { }

	// RVA: 0x201A530 Offset: 0x2019930 VA: 0x18201A530
	public PlayerTick Copy() { }

	// RVA: 0x201AEC0 Offset: 0x201A2C0 VA: 0x18201AEC0
	public static PlayerTick Deserialize(Stream stream) { }

	// RVA: 0x201A5B0 Offset: 0x20199B0 VA: 0x18201A5B0
	public static PlayerTick DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x201AA40 Offset: 0x2019E40 VA: 0x18201AA40
	public static PlayerTick DeserializeLength(Stream stream, int length) { }

	// RVA: 0x201B980 Offset: 0x201AD80 VA: 0x18201B980
	public static PlayerTick Deserialize(byte[] buffer) { }

	// RVA: 0x201BF60 Offset: 0x201B360 VA: 0x18201BF60
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x201D280 Offset: 0x201C680 VA: 0x18201D280 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x201D2A0 Offset: 0x201C6A0 VA: 0x18201D2A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerTick previous) { }

	// RVA: 0x201C290 Offset: 0x201B690 VA: 0x18201C290 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x201B230 Offset: 0x201A630 VA: 0x18201B230
	public static PlayerTick Deserialize(byte[] buffer, PlayerTick instance, bool isDelta = False) { }

	// RVA: 0x201B650 Offset: 0x201AA50 VA: 0x18201B650
	public static PlayerTick Deserialize(Stream stream, PlayerTick instance, bool isDelta) { }

	// RVA: 0x201A630 Offset: 0x2019A30 VA: 0x18201A630
	public static PlayerTick DeserializeLengthDelimited(Stream stream, PlayerTick instance, bool isDelta) { }

	// RVA: 0x201AAD0 Offset: 0x2019ED0 VA: 0x18201AAD0
	public static PlayerTick DeserializeLength(Stream stream, int length, PlayerTick instance, bool isDelta) { }

	// RVA: 0x201C530 Offset: 0x201B930 VA: 0x18201C530
	public static void SerializeDelta(Stream stream, PlayerTick instance, PlayerTick previous) { }

	// RVA: 0x201CDA0 Offset: 0x201C1A0 VA: 0x18201CDA0
	public static void Serialize(Stream stream, PlayerTick instance) { }

	// RVA: 0x201D270 Offset: 0x201C670 VA: 0x18201D270
	public byte[] ToProtoBytes() { }

	// RVA: 0x201D280 Offset: 0x201C680 VA: 0x18201D280
	public void ToProto(Stream stream) { }

	// RVA: 0x201CC90 Offset: 0x201C090 VA: 0x18201CC90
	public static byte[] SerializeToBytes(PlayerTick instance) { }

	// RVA: 0x201CBE0 Offset: 0x201BFE0 VA: 0x18201CBE0
	public static void SerializeLengthDelimited(Stream stream, PlayerTick instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class BasePlayer : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6443
{	// Fields
	public bool ShouldPool; // 0x10
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

	// Methods

	// RVA: 0x1FFE930 Offset: 0x1FFDD30 VA: 0x181FFE930
	public static void ResetToPool(BasePlayer instance) { }

	// RVA: 0x1FFE5F0 Offset: 0x1FFD9F0 VA: 0x181FFE5F0
	public void ResetToPool() { }

	// RVA: 0x1FFE530 Offset: 0x1FFD930 VA: 0x181FFE530 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1FFC690 Offset: 0x1FFBA90 VA: 0x181FFC690
	public void CopyTo(BasePlayer instance) { }

	// RVA: 0x1FFC940 Offset: 0x1FFBD40 VA: 0x181FFC940
	public BasePlayer Copy() { }

	// RVA: 0x1FFDB30 Offset: 0x1FFCF30 VA: 0x181FFDB30
	public static BasePlayer Deserialize(Stream stream) { }

	// RVA: 0x1FFC9C0 Offset: 0x1FFBDC0 VA: 0x181FFC9C0
	public static BasePlayer DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1FFD280 Offset: 0x1FFC680 VA: 0x181FFD280
	public static BasePlayer DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1FFDBB0 Offset: 0x1FFCFB0 VA: 0x181FFDBB0
	public static BasePlayer Deserialize(byte[] buffer) { }

	// RVA: 0x1FFE5B0 Offset: 0x1FFD9B0 VA: 0x181FFE5B0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2000730 Offset: 0x1FFFB30 VA: 0x182000730 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2000750 Offset: 0x1FFFB50 VA: 0x182000750 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BasePlayer previous) { }

	// RVA: 0x1FFE5D0 Offset: 0x1FFD9D0 VA: 0x181FFE5D0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1FFE430 Offset: 0x1FFD830 VA: 0x181FFE430
	public static BasePlayer Deserialize(byte[] buffer, BasePlayer instance, bool isDelta = False) { }

	// RVA: 0x1FFDCD0 Offset: 0x1FFD0D0 VA: 0x181FFDCD0
	public static BasePlayer Deserialize(Stream stream, BasePlayer instance, bool isDelta) { }

	// RVA: 0x1FFCA40 Offset: 0x1FFBE40 VA: 0x181FFCA40
	public static BasePlayer DeserializeLengthDelimited(Stream stream, BasePlayer instance, bool isDelta) { }

	// RVA: 0x1FFD310 Offset: 0x1FFC710 VA: 0x181FFD310
	public static BasePlayer DeserializeLength(Stream stream, int length, BasePlayer instance, bool isDelta) { }

	// RVA: 0x1FFEC70 Offset: 0x1FFE070 VA: 0x181FFEC70
	public static void SerializeDelta(Stream stream, BasePlayer instance, BasePlayer previous) { }

	// RVA: 0x1FFFBE0 Offset: 0x1FFEFE0 VA: 0x181FFFBE0
	public static void Serialize(Stream stream, BasePlayer instance) { }

	// RVA: 0x2000720 Offset: 0x1FFFB20 VA: 0x182000720
	public byte[] ToProtoBytes() { }

	// RVA: 0x2000730 Offset: 0x1FFFB30 VA: 0x182000730
	public void ToProto(Stream stream) { }

	// RVA: 0x1FFFAD0 Offset: 0x1FFEED0 VA: 0x181FFFAD0
	public static byte[] SerializeToBytes(BasePlayer instance) { }

	// RVA: 0x1FFFA20 Offset: 0x1FFEE20 VA: 0x181FFFA20
	public static void SerializeLengthDelimited(Stream stream, BasePlayer instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class PlayerTeam : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6444
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong teamID; // 0x18
	public string teamName; // 0x20
	public ulong teamLeader; // 0x28
	public List<PlayerTeam.TeamMember> members; // 0x30
	public float teamLifetime; // 0x38
	public MapNote mapNote; // 0x40

	// Methods

	// RVA: 0x203E340 Offset: 0x203D740 VA: 0x18203E340
	public static void ResetToPool(PlayerTeam instance) { }

	// RVA: 0x203E590 Offset: 0x203D990 VA: 0x18203E590
	public void ResetToPool() { }

	// RVA: 0x203DF40 Offset: 0x203D340 VA: 0x18203DF40 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x203C450 Offset: 0x203B850 VA: 0x18203C450
	public void CopyTo(PlayerTeam instance) { }

	// RVA: 0x203C690 Offset: 0x203BA90 VA: 0x18203C690
	public PlayerTeam Copy() { }

	// RVA: 0x203D440 Offset: 0x203C840 VA: 0x18203D440
	public static PlayerTeam Deserialize(Stream stream) { }

	// RVA: 0x203C710 Offset: 0x203BB10 VA: 0x18203C710
	public static PlayerTeam DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x203CBC0 Offset: 0x203BFC0 VA: 0x18203CBC0
	public static PlayerTeam DeserializeLength(Stream stream, int length) { }

	// RVA: 0x203D050 Offset: 0x203C450 VA: 0x18203D050
	public static PlayerTeam Deserialize(byte[] buffer) { }

	// RVA: 0x203DFC0 Offset: 0x203D3C0 VA: 0x18203DFC0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x203F200 Offset: 0x203E600 VA: 0x18203F200 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x203F220 Offset: 0x203E620 VA: 0x18203F220 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerTeam previous) { }

	// RVA: 0x203E320 Offset: 0x203D720 VA: 0x18203E320 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x203DB00 Offset: 0x203CF00 VA: 0x18203DB00
	public static PlayerTeam Deserialize(byte[] buffer, PlayerTeam instance, bool isDelta = False) { }

	// RVA: 0x203D7A0 Offset: 0x203CBA0 VA: 0x18203D7A0
	public static PlayerTeam Deserialize(Stream stream, PlayerTeam instance, bool isDelta) { }

	// RVA: 0x203C790 Offset: 0x203BB90 VA: 0x18203C790
	public static PlayerTeam DeserializeLengthDelimited(Stream stream, PlayerTeam instance, bool isDelta) { }

	// RVA: 0x203CC50 Offset: 0x203C050 VA: 0x18203CC50
	public static PlayerTeam DeserializeLength(Stream stream, int length, PlayerTeam instance, bool isDelta) { }

	// RVA: 0x203E7F0 Offset: 0x203DBF0 VA: 0x18203E7F0
	public static void SerializeDelta(Stream stream, PlayerTeam instance, PlayerTeam previous) { }

	// RVA: 0x203EE10 Offset: 0x203E210 VA: 0x18203EE10
	public static void Serialize(Stream stream, PlayerTeam instance) { }

	// RVA: 0x203F1F0 Offset: 0x203E5F0 VA: 0x18203F1F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x203F200 Offset: 0x203E600 VA: 0x18203F200
	public void ToProto(Stream stream) { }

	// RVA: 0x203ED00 Offset: 0x203E100 VA: 0x18203ED00
	public static byte[] SerializeToBytes(PlayerTeam instance) { }

	// RVA: 0x203EC50 Offset: 0x203E050 VA: 0x18203EC50
	public static void SerializeLengthDelimited(Stream stream, PlayerTeam instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class PlayerTeam.TeamMember : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6445
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string displayName; // 0x18
	public ulong userID; // 0x20
	public float healthFraction; // 0x28
	public Vector3 position; // 0x2C
	public bool online; // 0x38
	public bool wounded; // 0x39

	// Methods

	// RVA: 0x204E3A0 Offset: 0x204D7A0 VA: 0x18204E3A0
	public static void ResetToPool(PlayerTeam.TeamMember instance) { }

	// RVA: 0x204E2C0 Offset: 0x204D6C0 VA: 0x18204E2C0
	public void ResetToPool() { }

	// RVA: 0x204DF80 Offset: 0x204D380 VA: 0x18204DF80 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x204C720 Offset: 0x204BB20 VA: 0x18204C720
	public void CopyTo(PlayerTeam.TeamMember instance) { }

	// RVA: 0x204C790 Offset: 0x204BB90 VA: 0x18204C790
	public PlayerTeam.TeamMember Copy() { }

	// RVA: 0x204D910 Offset: 0x204CD10 VA: 0x18204D910
	public static PlayerTeam.TeamMember Deserialize(Stream stream) { }

	// RVA: 0x204C840 Offset: 0x204BC40 VA: 0x18204C840
	public static PlayerTeam.TeamMember DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x204CC30 Offset: 0x204C030 VA: 0x18204CC30
	public static PlayerTeam.TeamMember DeserializeLength(Stream stream, int length) { }

	// RVA: 0x204DBF0 Offset: 0x204CFF0 VA: 0x18204DBF0
	public static PlayerTeam.TeamMember Deserialize(byte[] buffer) { }

	// RVA: 0x204E000 Offset: 0x204D400 VA: 0x18204E000
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x204ECC0 Offset: 0x204E0C0 VA: 0x18204ECC0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x204ECE0 Offset: 0x204E0E0 VA: 0x18204ECE0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerTeam.TeamMember previous) { }

	// RVA: 0x204E2A0 Offset: 0x204D6A0 VA: 0x18204E2A0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x204D5B0 Offset: 0x204C9B0 VA: 0x18204D5B0
	public static PlayerTeam.TeamMember Deserialize(byte[] buffer, PlayerTeam.TeamMember instance, bool isDelta = False) { }

	// RVA: 0x204D300 Offset: 0x204C700 VA: 0x18204D300
	public static PlayerTeam.TeamMember Deserialize(Stream stream, PlayerTeam.TeamMember instance, bool isDelta) { }

	// RVA: 0x204C8C0 Offset: 0x204BCC0 VA: 0x18204C8C0
	public static PlayerTeam.TeamMember DeserializeLengthDelimited(Stream stream, PlayerTeam.TeamMember instance, bool isDelta) { }

	// RVA: 0x204CFC0 Offset: 0x204C3C0 VA: 0x18204CFC0
	public static PlayerTeam.TeamMember DeserializeLength(Stream stream, int length, PlayerTeam.TeamMember instance, bool isDelta) { }

	// RVA: 0x204E480 Offset: 0x204D880 VA: 0x18204E480
	public static void SerializeDelta(Stream stream, PlayerTeam.TeamMember instance, PlayerTeam.TeamMember previous) { }

	// RVA: 0x204EA30 Offset: 0x204DE30 VA: 0x18204EA30
	public static void Serialize(Stream stream, PlayerTeam.TeamMember instance) { }

	// RVA: 0x204ECB0 Offset: 0x204E0B0 VA: 0x18204ECB0
	public byte[] ToProtoBytes() { }

	// RVA: 0x204ECC0 Offset: 0x204E0C0 VA: 0x18204ECC0
	public void ToProto(Stream stream) { }

	// RVA: 0x204E920 Offset: 0x204DD20 VA: 0x18204E920
	public static byte[] SerializeToBytes(PlayerTeam.TeamMember instance) { }

	// RVA: 0x204E870 Offset: 0x204DC70 VA: 0x18204E870
	public static void SerializeLengthDelimited(Stream stream, PlayerTeam.TeamMember instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class PlayerMetabolism : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6446
{	// Fields
	public bool ShouldPool; // 0x10
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

	// Methods

	// RVA: 0x1EB08D0 Offset: 0x1EAFCD0 VA: 0x181EB08D0
	public static void ResetToPool(PlayerMetabolism instance) { }

	// RVA: 0x1EB0790 Offset: 0x1EAFB90 VA: 0x181EB0790
	public void ResetToPool() { }

	// RVA: 0x1EB0580 Offset: 0x1EAF980 VA: 0x181EB0580 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EAF0B0 Offset: 0x1EAE4B0 VA: 0x181EAF0B0
	public void CopyTo(PlayerMetabolism instance) { }

	// RVA: 0x1EAF120 Offset: 0x1EAE520 VA: 0x181EAF120
	public PlayerMetabolism Copy() { }

	// RVA: 0x1EB03E0 Offset: 0x1EAF7E0 VA: 0x181EB03E0
	public static PlayerMetabolism Deserialize(Stream stream) { }

	// RVA: 0x1EAF780 Offset: 0x1EAEB80 VA: 0x181EAF780
	public static PlayerMetabolism DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EAFD80 Offset: 0x1EAF180 VA: 0x181EAFD80
	public static PlayerMetabolism DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EB0460 Offset: 0x1EAF860 VA: 0x181EB0460
	public static PlayerMetabolism Deserialize(byte[] buffer) { }

	// RVA: 0x1EB0750 Offset: 0x1EAFB50 VA: 0x181EB0750
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EB1470 Offset: 0x1EB0870 VA: 0x181EB1470 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EB1490 Offset: 0x1EB0890 VA: 0x181EB1490 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerMetabolism previous) { }

	// RVA: 0x1EB0770 Offset: 0x1EAFB70 VA: 0x181EB0770 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EAFE10 Offset: 0x1EAF210 VA: 0x181EAFE10
	public static PlayerMetabolism Deserialize(byte[] buffer, PlayerMetabolism instance, bool isDelta = False) { }

	// RVA: 0x1EAFF10 Offset: 0x1EAF310 VA: 0x181EAFF10
	public static PlayerMetabolism Deserialize(Stream stream, PlayerMetabolism instance, bool isDelta) { }

	// RVA: 0x1EAF1E0 Offset: 0x1EAE5E0 VA: 0x181EAF1E0
	public static PlayerMetabolism DeserializeLengthDelimited(Stream stream, PlayerMetabolism instance, bool isDelta) { }

	// RVA: 0x1EAF800 Offset: 0x1EAEC00 VA: 0x181EAF800
	public static PlayerMetabolism DeserializeLength(Stream stream, int length, PlayerMetabolism instance, bool isDelta) { }

	// RVA: 0x1EB0A10 Offset: 0x1EAFE10 VA: 0x181EB0A10
	public static void SerializeDelta(Stream stream, PlayerMetabolism instance, PlayerMetabolism previous) { }

	// RVA: 0x1EB11A0 Offset: 0x1EB05A0 VA: 0x181EB11A0
	public static void Serialize(Stream stream, PlayerMetabolism instance) { }

	// RVA: 0x1EB1460 Offset: 0x1EB0860 VA: 0x181EB1460
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EB1470 Offset: 0x1EB0870 VA: 0x181EB1470
	public void ToProto(Stream stream) { }

	// RVA: 0x1EB1090 Offset: 0x1EB0490 VA: 0x181EB1090
	public static byte[] SerializeToBytes(PlayerMetabolism instance) { }

	// RVA: 0x1EB0FE0 Offset: 0x1EB03E0 VA: 0x181EB0FE0
	public static void SerializeLengthDelimited(Stream stream, PlayerMetabolism instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class PlayerModifiers : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6447
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<Modifier> modifiers; // 0x18

	// Methods

	// RVA: 0x1EB23D0 Offset: 0x1EB17D0 VA: 0x181EB23D0
	public static void ResetToPool(PlayerModifiers instance) { }

	// RVA: 0x1EB2580 Offset: 0x1EB1980 VA: 0x181EB2580
	public void ResetToPool() { }

	// RVA: 0x1EB2150 Offset: 0x1EB1550 VA: 0x181EB2150 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EB14B0 Offset: 0x1EB08B0 VA: 0x181EB14B0
	public void CopyTo(PlayerModifiers instance) { }

	// RVA: 0x1EB15E0 Offset: 0x1EB09E0 VA: 0x181EB15E0
	public PlayerModifiers Copy() { }

	// RVA: 0x1EB1E40 Offset: 0x1EB1240 VA: 0x181EB1E40
	public static PlayerModifiers Deserialize(Stream stream) { }

	// RVA: 0x1EB1750 Offset: 0x1EB0B50 VA: 0x181EB1750
	public static PlayerModifiers DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EB1A40 Offset: 0x1EB0E40 VA: 0x181EB1A40
	public static PlayerModifiers DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EB1D20 Offset: 0x1EB1120 VA: 0x181EB1D20
	public static PlayerModifiers Deserialize(byte[] buffer) { }

	// RVA: 0x1EB2390 Offset: 0x1EB1790 VA: 0x181EB2390
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EB2CC0 Offset: 0x1EB20C0 VA: 0x181EB2CC0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EB2CE0 Offset: 0x1EB20E0 VA: 0x181EB2CE0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerModifiers previous) { }

	// RVA: 0x1EB23B0 Offset: 0x1EB17B0 VA: 0x181EB23B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EB1EC0 Offset: 0x1EB12C0 VA: 0x181EB1EC0
	public static PlayerModifiers Deserialize(byte[] buffer, PlayerModifiers instance, bool isDelta = False) { }

	// RVA: 0x1EB1FC0 Offset: 0x1EB13C0 VA: 0x181EB1FC0
	public static PlayerModifiers Deserialize(Stream stream, PlayerModifiers instance, bool isDelta) { }

	// RVA: 0x1EB17D0 Offset: 0x1EB0BD0 VA: 0x181EB17D0
	public static PlayerModifiers DeserializeLengthDelimited(Stream stream, PlayerModifiers instance, bool isDelta) { }

	// RVA: 0x1EB1AD0 Offset: 0x1EB0ED0 VA: 0x181EB1AD0
	public static PlayerModifiers DeserializeLength(Stream stream, int length, PlayerModifiers instance, bool isDelta) { }

	// RVA: 0x1EB2730 Offset: 0x1EB1B30 VA: 0x181EB2730
	public static void SerializeDelta(Stream stream, PlayerModifiers instance, PlayerModifiers previous) { }

	// RVA: 0x1EB2AD0 Offset: 0x1EB1ED0 VA: 0x181EB2AD0
	public static void Serialize(Stream stream, PlayerModifiers instance) { }

	// RVA: 0x1EB2CB0 Offset: 0x1EB20B0 VA: 0x181EB2CB0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EB2CC0 Offset: 0x1EB20C0 VA: 0x181EB2CC0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EB29C0 Offset: 0x1EB1DC0 VA: 0x181EB29C0
	public static byte[] SerializeToBytes(PlayerModifiers instance) { }

	// RVA: 0x1EB2910 Offset: 0x1EB1D10 VA: 0x181EB2910
	public static void SerializeLengthDelimited(Stream stream, PlayerModifiers instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class PlayerInventory : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6454
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ItemContainer invMain; // 0x18
	public ItemContainer invBelt; // 0x20
	public ItemContainer invWear; // 0x28

	// Methods

	// RVA: 0x1EAA250 Offset: 0x1EA9650 VA: 0x181EAA250
	public static void ResetToPool(PlayerInventory instance) { }

	// RVA: 0x1EAA370 Offset: 0x1EA9770 VA: 0x181EAA370
	public void ResetToPool() { }

	// RVA: 0x1EA9EB0 Offset: 0x1EA92B0 VA: 0x181EA9EB0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EA8CA0 Offset: 0x1EA80A0 VA: 0x181EA8CA0
	public void CopyTo(PlayerInventory instance) { }

	// RVA: 0x1EA8DA0 Offset: 0x1EA81A0 VA: 0x181EA8DA0
	public PlayerInventory Copy() { }

	// RVA: 0x1EA9540 Offset: 0x1EA8940 VA: 0x181EA9540
	public static PlayerInventory Deserialize(Stream stream) { }

	// RVA: 0x1EA8EE0 Offset: 0x1EA82E0 VA: 0x181EA8EE0
	public static PlayerInventory DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EA94B0 Offset: 0x1EA88B0 VA: 0x181EA94B0
	public static PlayerInventory DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EA9A00 Offset: 0x1EA8E00 VA: 0x181EA9A00
	public static PlayerInventory Deserialize(byte[] buffer) { }

	// RVA: 0x1EAA050 Offset: 0x1EA9450 VA: 0x181EAA050
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EAAD50 Offset: 0x1EAA150 VA: 0x181EAAD50 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EAAD70 Offset: 0x1EAA170 VA: 0x181EAAD70 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerInventory previous) { }

	// RVA: 0x1EAA230 Offset: 0x1EA9630 VA: 0x181EAA230 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EA9760 Offset: 0x1EA8B60 VA: 0x181EA9760
	public static PlayerInventory Deserialize(byte[] buffer, PlayerInventory instance, bool isDelta = False) { }

	// RVA: 0x1EA9CD0 Offset: 0x1EA90D0 VA: 0x181EA9CD0
	public static PlayerInventory Deserialize(Stream stream, PlayerInventory instance, bool isDelta) { }

	// RVA: 0x1EA8F60 Offset: 0x1EA8360 VA: 0x181EA8F60
	public static PlayerInventory DeserializeLengthDelimited(Stream stream, PlayerInventory instance, bool isDelta) { }

	// RVA: 0x1EA9220 Offset: 0x1EA8620 VA: 0x181EA9220
	public static PlayerInventory DeserializeLength(Stream stream, int length, PlayerInventory instance, bool isDelta) { }

	// RVA: 0x1EAA490 Offset: 0x1EA9890 VA: 0x181EAA490
	public static void SerializeDelta(Stream stream, PlayerInventory instance, PlayerInventory previous) { }

	// RVA: 0x1EAA9E0 Offset: 0x1EA9DE0 VA: 0x181EAA9E0
	public static void Serialize(Stream stream, PlayerInventory instance) { }

	// RVA: 0x1EAAD40 Offset: 0x1EAA140 VA: 0x181EAAD40
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EAAD50 Offset: 0x1EAA150 VA: 0x181EAAD50
	public void ToProto(Stream stream) { }

	// RVA: 0x1EAA8D0 Offset: 0x1EA9CD0 VA: 0x181EAA8D0
	public static byte[] SerializeToBytes(PlayerInventory instance) { }

	// RVA: 0x1EAA820 Offset: 0x1EA9C20 VA: 0x181EAA820
	public static void SerializeLengthDelimited(Stream stream, PlayerInventory instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class PlayerLifeStory : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6456
{	// Fields
	public bool ShouldPool; // 0x10
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

	// Methods

	// RVA: 0x1EAD570 Offset: 0x1EAC970 VA: 0x181EAD570
	public static void ResetToPool(PlayerLifeStory instance) { }

	// RVA: 0x1EAD120 Offset: 0x1EAC520 VA: 0x181EAD120
	public void ResetToPool() { }

	// RVA: 0x1EAD060 Offset: 0x1EAC460 VA: 0x181EAD060 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EAAD90 Offset: 0x1EAA190 VA: 0x181EAAD90
	public void CopyTo(PlayerLifeStory instance) { }

	// RVA: 0x1EAB210 Offset: 0x1EAA610 VA: 0x181EAB210
	public PlayerLifeStory Copy() { }

	// RVA: 0x1EAC580 Offset: 0x1EAB980 VA: 0x181EAC580
	public static PlayerLifeStory Deserialize(Stream stream) { }

	// RVA: 0x1EABB90 Offset: 0x1EAAF90 VA: 0x181EABB90
	public static PlayerLifeStory DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EAC4F0 Offset: 0x1EAB8F0 VA: 0x181EAC4F0
	public static PlayerLifeStory DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EACF40 Offset: 0x1EAC340 VA: 0x181EACF40
	public static PlayerLifeStory Deserialize(byte[] buffer) { }

	// RVA: 0x1EAD0E0 Offset: 0x1EAC4E0 VA: 0x181EAD0E0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EAF070 Offset: 0x1EAE470 VA: 0x181EAF070 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EAF090 Offset: 0x1EAE490 VA: 0x181EAF090 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerLifeStory previous) { }

	// RVA: 0x1EAD100 Offset: 0x1EAC500 VA: 0x181EAD100 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EAC600 Offset: 0x1EABA00 VA: 0x181EAC600
	public static PlayerLifeStory Deserialize(byte[] buffer, PlayerLifeStory instance, bool isDelta = False) { }

	// RVA: 0x1EAC700 Offset: 0x1EABB00 VA: 0x181EAC700
	public static PlayerLifeStory Deserialize(Stream stream, PlayerLifeStory instance, bool isDelta) { }

	// RVA: 0x1EAB290 Offset: 0x1EAA690 VA: 0x181EAB290
	public static PlayerLifeStory DeserializeLengthDelimited(Stream stream, PlayerLifeStory instance, bool isDelta) { }

	// RVA: 0x1EABC10 Offset: 0x1EAB010 VA: 0x181EABC10
	public static PlayerLifeStory DeserializeLength(Stream stream, int length, PlayerLifeStory instance, bool isDelta) { }

	// RVA: 0x1EAD9C0 Offset: 0x1EACDC0 VA: 0x181EAD9C0
	public static void SerializeDelta(Stream stream, PlayerLifeStory instance, PlayerLifeStory previous) { }

	// RVA: 0x1EAE7D0 Offset: 0x1EADBD0 VA: 0x181EAE7D0
	public static void Serialize(Stream stream, PlayerLifeStory instance) { }

	// RVA: 0x1EAF060 Offset: 0x1EAE460 VA: 0x181EAF060
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EAF070 Offset: 0x1EAE470 VA: 0x181EAF070
	public void ToProto(Stream stream) { }

	// RVA: 0x1EAE6C0 Offset: 0x1EADAC0 VA: 0x181EAE6C0
	public static byte[] SerializeToBytes(PlayerLifeStory instance) { }

	// RVA: 0x1EAE610 Offset: 0x1EADA10 VA: 0x181EAE610
	public static void SerializeLengthDelimited(Stream stream, PlayerLifeStory instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class PlayerLifeStory.DeathInfo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6457
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string attackerName; // 0x18
	public ulong attackerSteamID; // 0x20
	public string hitBone; // 0x28
	public string inflictorName; // 0x30
	public int lastDamageType; // 0x38
	public float attackerDistance; // 0x3C

	// Methods

	// RVA: 0x1E9CF50 Offset: 0x1E9C350 VA: 0x181E9CF50
	public static void ResetToPool(PlayerLifeStory.DeathInfo instance) { }

	// RVA: 0x1E9D080 Offset: 0x1E9C480 VA: 0x181E9D080
	public void ResetToPool() { }

	// RVA: 0x1E9CC00 Offset: 0x1E9C000 VA: 0x181E9CC00 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E9B5A0 Offset: 0x1E9A9A0 VA: 0x181E9B5A0
	public void CopyTo(PlayerLifeStory.DeathInfo instance) { }

	// RVA: 0x1E9B610 Offset: 0x1E9AA10 VA: 0x181E9B610
	public PlayerLifeStory.DeathInfo Copy() { }

	// RVA: 0x1E9C280 Offset: 0x1E9B680 VA: 0x181E9C280
	public static PlayerLifeStory.DeathInfo Deserialize(Stream stream) { }

	// RVA: 0x1E9BA60 Offset: 0x1E9AE60 VA: 0x181E9BA60
	public static PlayerLifeStory.DeathInfo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E9BE50 Offset: 0x1E9B250 VA: 0x181E9BE50
	public static PlayerLifeStory.DeathInfo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E9C840 Offset: 0x1E9BC40 VA: 0x181E9C840
	public static PlayerLifeStory.DeathInfo Deserialize(byte[] buffer) { }

	// RVA: 0x1E9CC80 Offset: 0x1E9C080 VA: 0x181E9CC80
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E9D8E0 Offset: 0x1E9CCE0 VA: 0x181E9D8E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E9D900 Offset: 0x1E9CD00 VA: 0x181E9D900 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerLifeStory.DeathInfo previous) { }

	// RVA: 0x1E9CF30 Offset: 0x1E9C330 VA: 0x181E9CF30 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E9BEE0 Offset: 0x1E9B2E0 VA: 0x181E9BEE0
	public static PlayerLifeStory.DeathInfo Deserialize(byte[] buffer, PlayerLifeStory.DeathInfo instance, bool isDelta = False) { }

	// RVA: 0x1E9C580 Offset: 0x1E9B980 VA: 0x181E9C580
	public static PlayerLifeStory.DeathInfo Deserialize(Stream stream, PlayerLifeStory.DeathInfo instance, bool isDelta) { }

	// RVA: 0x1E9B6D0 Offset: 0x1E9AAD0 VA: 0x181E9B6D0
	public static PlayerLifeStory.DeathInfo DeserializeLengthDelimited(Stream stream, PlayerLifeStory.DeathInfo instance, bool isDelta) { }

	// RVA: 0x1E9BAE0 Offset: 0x1E9AEE0 VA: 0x181E9BAE0
	public static PlayerLifeStory.DeathInfo DeserializeLength(Stream stream, int length, PlayerLifeStory.DeathInfo instance, bool isDelta) { }

	// RVA: 0x1E9D1B0 Offset: 0x1E9C5B0 VA: 0x181E9D1B0
	public static void SerializeDelta(Stream stream, PlayerLifeStory.DeathInfo instance, PlayerLifeStory.DeathInfo previous) { }

	// RVA: 0x1E9D680 Offset: 0x1E9CA80 VA: 0x181E9D680
	public static void Serialize(Stream stream, PlayerLifeStory.DeathInfo instance) { }

	// RVA: 0x1E9D8D0 Offset: 0x1E9CCD0 VA: 0x181E9D8D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E9D8E0 Offset: 0x1E9CCE0 VA: 0x181E9D8E0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E9D570 Offset: 0x1E9C970 VA: 0x181E9D570
	public static byte[] SerializeToBytes(PlayerLifeStory.DeathInfo instance) { }

	// RVA: 0x1E9D4C0 Offset: 0x1E9C8C0 VA: 0x181E9D4C0
	public static void SerializeLengthDelimited(Stream stream, PlayerLifeStory.DeathInfo instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class PlayerLifeStory.WeaponStats : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6458
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string weaponName; // 0x18
	public ulong shotsFired; // 0x20
	public ulong shotsHit; // 0x28

	// Methods

	// RVA: 0x1EB4000 Offset: 0x1EB3400 VA: 0x181EB4000
	public static void ResetToPool(PlayerLifeStory.WeaponStats instance) { }

	// RVA: 0x1EB3F50 Offset: 0x1EB3350 VA: 0x181EB3F50
	public void ResetToPool() { }

	// RVA: 0x1EB3CF0 Offset: 0x1EB30F0 VA: 0x181EB3CF0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EB2D00 Offset: 0x1EB2100 VA: 0x181EB2D00
	public void CopyTo(PlayerLifeStory.WeaponStats instance) { }

	// RVA: 0x1EB2D50 Offset: 0x1EB2150 VA: 0x181EB2D50
	public PlayerLifeStory.WeaponStats Copy() { }

	// RVA: 0x1EB3930 Offset: 0x1EB2D30 VA: 0x181EB3930
	public static PlayerLifeStory.WeaponStats Deserialize(Stream stream) { }

	// RVA: 0x1EB3070 Offset: 0x1EB2470 VA: 0x181EB3070
	public static PlayerLifeStory.WeaponStats DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EB3360 Offset: 0x1EB2760 VA: 0x181EB3360
	public static PlayerLifeStory.WeaponStats DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EB33F0 Offset: 0x1EB27F0 VA: 0x181EB33F0
	public static PlayerLifeStory.WeaponStats Deserialize(byte[] buffer) { }

	// RVA: 0x1EB3D70 Offset: 0x1EB3170 VA: 0x181EB3D70
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EB4630 Offset: 0x1EB3A30 VA: 0x181EB4630 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EB4650 Offset: 0x1EB3A50 VA: 0x181EB4650 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerLifeStory.WeaponStats previous) { }

	// RVA: 0x1EB3F30 Offset: 0x1EB3330 VA: 0x181EB3F30 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EB36A0 Offset: 0x1EB2AA0 VA: 0x181EB36A0
	public static PlayerLifeStory.WeaponStats Deserialize(byte[] buffer, PlayerLifeStory.WeaponStats instance, bool isDelta = False) { }

	// RVA: 0x1EB3B30 Offset: 0x1EB2F30 VA: 0x181EB3B30
	public static PlayerLifeStory.WeaponStats Deserialize(Stream stream, PlayerLifeStory.WeaponStats instance, bool isDelta) { }

	// RVA: 0x1EB2DE0 Offset: 0x1EB21E0 VA: 0x181EB2DE0
	public static PlayerLifeStory.WeaponStats DeserializeLengthDelimited(Stream stream, PlayerLifeStory.WeaponStats instance, bool isDelta) { }

	// RVA: 0x1EB30F0 Offset: 0x1EB24F0 VA: 0x181EB30F0
	public static PlayerLifeStory.WeaponStats DeserializeLength(Stream stream, int length, PlayerLifeStory.WeaponStats instance, bool isDelta) { }

	// RVA: 0x1EB40B0 Offset: 0x1EB34B0 VA: 0x181EB40B0
	public static void SerializeDelta(Stream stream, PlayerLifeStory.WeaponStats instance, PlayerLifeStory.WeaponStats previous) { }

	// RVA: 0x1EB4490 Offset: 0x1EB3890 VA: 0x181EB4490
	public static void Serialize(Stream stream, PlayerLifeStory.WeaponStats instance) { }

	// RVA: 0x1EB4620 Offset: 0x1EB3A20 VA: 0x181EB4620
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EB4630 Offset: 0x1EB3A30 VA: 0x181EB4630
	public void ToProto(Stream stream) { }

	// RVA: 0x1EB4380 Offset: 0x1EB3780 VA: 0x181EB4380
	public static byte[] SerializeToBytes(PlayerLifeStory.WeaponStats instance) { }

	// RVA: 0x1EB42D0 Offset: 0x1EB36D0 VA: 0x181EB42D0
	public static void SerializeLengthDelimited(Stream stream, PlayerLifeStory.WeaponStats instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class PlayerLifeStory.GenericStat : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6459
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string key; // 0x18
	public int value; // 0x20

	// Methods

	// RVA: 0x1E9FC40 Offset: 0x1E9F040 VA: 0x181E9FC40
	public static void ResetToPool(PlayerLifeStory.GenericStat instance) { }

	// RVA: 0x1E9FBA0 Offset: 0x1E9EFA0 VA: 0x181E9FBA0
	public void ResetToPool() { }

	// RVA: 0x1E9FAE0 Offset: 0x1E9EEE0 VA: 0x181E9FAE0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E9EDB0 Offset: 0x1E9E1B0 VA: 0x181E9EDB0
	public void CopyTo(PlayerLifeStory.GenericStat instance) { }

	// RVA: 0x1E9EDF0 Offset: 0x1E9E1F0 VA: 0x181E9EDF0
	public PlayerLifeStory.GenericStat Copy() { }

	// RVA: 0x1E9F430 Offset: 0x1E9E830 VA: 0x181E9F430
	public static PlayerLifeStory.GenericStat Deserialize(Stream stream) { }

	// RVA: 0x1E9EE80 Offset: 0x1E9E280 VA: 0x181E9EE80
	public static PlayerLifeStory.GenericStat DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E9F3A0 Offset: 0x1E9E7A0 VA: 0x181E9F3A0
	public static PlayerLifeStory.GenericStat DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E9F870 Offset: 0x1E9EC70 VA: 0x181E9F870
	public static PlayerLifeStory.GenericStat Deserialize(byte[] buffer) { }

	// RVA: 0x1E9FB60 Offset: 0x1E9EF60 VA: 0x181E9FB60
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EA01D0 Offset: 0x1E9F5D0 VA: 0x181EA01D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EA01F0 Offset: 0x1E9F5F0 VA: 0x181EA01F0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerLifeStory.GenericStat previous) { }

	// RVA: 0x1E9FB80 Offset: 0x1E9EF80 VA: 0x181E9FB80 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E9F5F0 Offset: 0x1E9E9F0 VA: 0x181E9F5F0
	public static PlayerLifeStory.GenericStat Deserialize(byte[] buffer, PlayerLifeStory.GenericStat instance, bool isDelta = False) { }

	// RVA: 0x1E9F6F0 Offset: 0x1E9EAF0 VA: 0x181E9F6F0
	public static PlayerLifeStory.GenericStat Deserialize(Stream stream, PlayerLifeStory.GenericStat instance, bool isDelta) { }

	// RVA: 0x1E9EF00 Offset: 0x1E9E300 VA: 0x181E9EF00
	public static PlayerLifeStory.GenericStat DeserializeLengthDelimited(Stream stream, PlayerLifeStory.GenericStat instance, bool isDelta) { }

	// RVA: 0x1E9F160 Offset: 0x1E9E560 VA: 0x181E9F160
	public static PlayerLifeStory.GenericStat DeserializeLength(Stream stream, int length, PlayerLifeStory.GenericStat instance, bool isDelta) { }

	// RVA: 0x1E9FCE0 Offset: 0x1E9F0E0 VA: 0x181E9FCE0
	public static void SerializeDelta(Stream stream, PlayerLifeStory.GenericStat instance, PlayerLifeStory.GenericStat previous) { }

	// RVA: 0x1EA0060 Offset: 0x1E9F460 VA: 0x181EA0060
	public static void Serialize(Stream stream, PlayerLifeStory.GenericStat instance) { }

	// RVA: 0x1EA01C0 Offset: 0x1E9F5C0 VA: 0x181EA01C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EA01D0 Offset: 0x1E9F5D0 VA: 0x181EA01D0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E9FF50 Offset: 0x1E9F350 VA: 0x181E9FF50
	public static byte[] SerializeToBytes(PlayerLifeStory.GenericStat instance) { }

	// RVA: 0x1E9FEA0 Offset: 0x1E9F2A0 VA: 0x181E9FEA0
	public static void SerializeLengthDelimited(Stream stream, PlayerLifeStory.GenericStat instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class PlayerState : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6462
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public double unHostileTimestamp; // 0x18
	public MapNote pointOfInterest; // 0x20
	public MapNote deathMarker; // 0x28
	public Missions missions; // 0x30

	// Methods

	// RVA: 0x203B990 Offset: 0x203AD90 VA: 0x18203B990
	public static void ResetToPool(PlayerState instance) { }

	// RVA: 0x203B860 Offset: 0x203AC60 VA: 0x18203B860
	public void ResetToPool() { }

	// RVA: 0x203B460 Offset: 0x203A860 VA: 0x18203B460 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x203A080 Offset: 0x2039480 VA: 0x18203A080
	public void CopyTo(PlayerState instance) { }

	// RVA: 0x203A170 Offset: 0x2039570 VA: 0x18203A170
	public PlayerState Copy() { }

	// RVA: 0x203ACE0 Offset: 0x203A0E0 VA: 0x18203ACE0
	public static PlayerState Deserialize(Stream stream) { }

	// RVA: 0x203A5D0 Offset: 0x20399D0 VA: 0x18203A5D0
	public static PlayerState DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x203A650 Offset: 0x2039A50 VA: 0x18203A650
	public static PlayerState DeserializeLength(Stream stream, int length) { }

	// RVA: 0x203A9C0 Offset: 0x2039DC0 VA: 0x18203A9C0
	public static PlayerState Deserialize(byte[] buffer) { }

	// RVA: 0x203B610 Offset: 0x203AA10 VA: 0x18203B610
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x203C410 Offset: 0x203B810 VA: 0x18203C410 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x203C430 Offset: 0x203B830 VA: 0x18203C430 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerState previous) { }

	// RVA: 0x203B840 Offset: 0x203AC40 VA: 0x18203B840 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x203AF40 Offset: 0x203A340 VA: 0x18203AF40
	public static PlayerState Deserialize(byte[] buffer, PlayerState instance, bool isDelta = False) { }

	// RVA: 0x203B230 Offset: 0x203A630 VA: 0x18203B230
	public static PlayerState Deserialize(Stream stream, PlayerState instance, bool isDelta) { }

	// RVA: 0x203A2C0 Offset: 0x20396C0 VA: 0x18203A2C0
	public static PlayerState DeserializeLengthDelimited(Stream stream, PlayerState instance, bool isDelta) { }

	// RVA: 0x203A6E0 Offset: 0x2039AE0 VA: 0x18203A6E0
	public static PlayerState DeserializeLength(Stream stream, int length, PlayerState instance, bool isDelta) { }

	// RVA: 0x203BAC0 Offset: 0x203AEC0 VA: 0x18203BAC0
	public static void SerializeDelta(Stream stream, PlayerState instance, PlayerState previous) { }

	// RVA: 0x203C060 Offset: 0x203B460 VA: 0x18203C060
	public static void Serialize(Stream stream, PlayerState instance) { }

	// RVA: 0x203C400 Offset: 0x203B800 VA: 0x18203C400
	public byte[] ToProtoBytes() { }

	// RVA: 0x203C410 Offset: 0x203B810 VA: 0x18203C410
	public void ToProto(Stream stream) { }

	// RVA: 0x203BF50 Offset: 0x203B350 VA: 0x18203BF50
	public static byte[] SerializeToBytes(PlayerState instance) { }

	// RVA: 0x203BEA0 Offset: 0x203B2A0 VA: 0x18203BEA0
	public static void SerializeLengthDelimited(Stream stream, PlayerState instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class PlayerNameID : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6463
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string username; // 0x18
	public ulong userid; // 0x20

	// Methods

	// RVA: 0x2032AC0 Offset: 0x2031EC0 VA: 0x182032AC0
	public static void ResetToPool(PlayerNameID instance) { }

	// RVA: 0x2032A10 Offset: 0x2031E10 VA: 0x182032A10
	public void ResetToPool() { }

	// RVA: 0x20328B0 Offset: 0x2031CB0 VA: 0x1820328B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DA81B0 Offset: 0x1DA75B0 VA: 0x181DA81B0
	public void CopyTo(PlayerNameID instance) { }

	// RVA: 0x2031BB0 Offset: 0x2030FB0 VA: 0x182031BB0
	public PlayerNameID Copy() { }

	// RVA: 0x20325F0 Offset: 0x20319F0 VA: 0x1820325F0
	public static PlayerNameID Deserialize(Stream stream) { }

	// RVA: 0x2031C40 Offset: 0x2031040 VA: 0x182031C40
	public static PlayerNameID DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2032160 Offset: 0x2031560 VA: 0x182032160
	public static PlayerNameID DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2032370 Offset: 0x2031770 VA: 0x182032370
	public static PlayerNameID Deserialize(byte[] buffer) { }

	// RVA: 0x20329D0 Offset: 0x2031DD0 VA: 0x1820329D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2033060 Offset: 0x2032460 VA: 0x182033060 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2033080 Offset: 0x2032480 VA: 0x182033080 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerNameID previous) { }

	// RVA: 0x20329F0 Offset: 0x2031DF0 VA: 0x1820329F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20327B0 Offset: 0x2031BB0 VA: 0x1820327B0
	public static PlayerNameID Deserialize(byte[] buffer, PlayerNameID instance, bool isDelta = False) { }

	// RVA: 0x20321F0 Offset: 0x20315F0 VA: 0x1820321F0
	public static PlayerNameID Deserialize(Stream stream, PlayerNameID instance, bool isDelta) { }

	// RVA: 0x2031CC0 Offset: 0x20310C0 VA: 0x182031CC0
	public static PlayerNameID DeserializeLengthDelimited(Stream stream, PlayerNameID instance, bool isDelta) { }

	// RVA: 0x2031F20 Offset: 0x2031320 VA: 0x182031F20
	public static PlayerNameID DeserializeLength(Stream stream, int length, PlayerNameID instance, bool isDelta) { }

	// RVA: 0x2032B70 Offset: 0x2031F70 VA: 0x182032B70
	public static void SerializeDelta(Stream stream, PlayerNameID instance, PlayerNameID previous) { }

	// RVA: 0x2032EF0 Offset: 0x20322F0 VA: 0x182032EF0
	public static void Serialize(Stream stream, PlayerNameID instance) { }

	// RVA: 0x2033050 Offset: 0x2032450 VA: 0x182033050
	public byte[] ToProtoBytes() { }

	// RVA: 0x2033060 Offset: 0x2032460 VA: 0x182033060
	public void ToProto(Stream stream) { }

	// RVA: 0x2032DE0 Offset: 0x20321E0 VA: 0x182032DE0
	public static byte[] SerializeToBytes(PlayerNameID instance) { }

	// RVA: 0x2032D30 Offset: 0x2032130 VA: 0x182032D30
	public static void SerializeLengthDelimited(Stream stream, PlayerNameID instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class PlayerUpdateLoot : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6478
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint itemID; // 0x14
	public uint entityID; // 0x18
	public List<ItemContainer> containers; // 0x20

	// Methods

	// RVA: 0x20408A0 Offset: 0x203FCA0 VA: 0x1820408A0
	public static void ResetToPool(PlayerUpdateLoot instance) { }

	// RVA: 0x2040A70 Offset: 0x203FE70 VA: 0x182040A70
	public void ResetToPool() { }

	// RVA: 0x20405F0 Offset: 0x203F9F0 VA: 0x1820405F0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x203F240 Offset: 0x203E640 VA: 0x18203F240
	public void CopyTo(PlayerUpdateLoot instance) { }

	// RVA: 0x203F370 Offset: 0x203E770 VA: 0x18203F370
	public PlayerUpdateLoot Copy() { }

	// RVA: 0x203FBC0 Offset: 0x203EFC0 VA: 0x18203FBC0
	public static PlayerUpdateLoot Deserialize(Stream stream) { }

	// RVA: 0x203F7E0 Offset: 0x203EBE0 VA: 0x18203F7E0
	public static PlayerUpdateLoot DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x203FB30 Offset: 0x203EF30 VA: 0x18203FB30
	public static PlayerUpdateLoot DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2040310 Offset: 0x203F710 VA: 0x182040310
	public static PlayerUpdateLoot Deserialize(byte[] buffer) { }

	// RVA: 0x2040670 Offset: 0x203FA70 VA: 0x182040670
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20412E0 Offset: 0x20406E0 VA: 0x1820412E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2041300 Offset: 0x2040700 VA: 0x182041300 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerUpdateLoot previous) { }

	// RVA: 0x2040880 Offset: 0x203FC80 VA: 0x182040880 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2040020 Offset: 0x203F420 VA: 0x182040020
	public static PlayerUpdateLoot Deserialize(byte[] buffer, PlayerUpdateLoot instance, bool isDelta = False) { }

	// RVA: 0x203FE00 Offset: 0x203F200 VA: 0x18203FE00
	public static PlayerUpdateLoot Deserialize(Stream stream, PlayerUpdateLoot instance, bool isDelta) { }

	// RVA: 0x203F4F0 Offset: 0x203E8F0 VA: 0x18203F4F0
	public static PlayerUpdateLoot DeserializeLengthDelimited(Stream stream, PlayerUpdateLoot instance, bool isDelta) { }

	// RVA: 0x203F860 Offset: 0x203EC60 VA: 0x18203F860
	public static PlayerUpdateLoot DeserializeLength(Stream stream, int length, PlayerUpdateLoot instance, bool isDelta) { }

	// RVA: 0x2040C40 Offset: 0x2040040 VA: 0x182040C40
	public static void SerializeDelta(Stream stream, PlayerUpdateLoot instance, PlayerUpdateLoot previous) { }

	// RVA: 0x2041090 Offset: 0x2040490 VA: 0x182041090
	public static void Serialize(Stream stream, PlayerUpdateLoot instance) { }

	// RVA: 0x20412D0 Offset: 0x20406D0 VA: 0x1820412D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x20412E0 Offset: 0x20406E0 VA: 0x1820412E0
	public void ToProto(Stream stream) { }

	// RVA: 0x2040F80 Offset: 0x2040380 VA: 0x182040F80
	public static byte[] SerializeToBytes(PlayerUpdateLoot instance) { }

	// RVA: 0x2040ED0 Offset: 0x20402D0 VA: 0x182040ED0
	public static void SerializeLengthDelimited(Stream stream, PlayerUpdateLoot instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class PlayerAttack : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6484
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Attack attack; // 0x18
	public int projectileID; // 0x20

	// Methods

	// RVA: 0x1EA7420 Offset: 0x1EA6820 VA: 0x181EA7420
	public static void ResetToPool(PlayerAttack instance) { }

	// RVA: 0x1EA74D0 Offset: 0x1EA68D0 VA: 0x181EA74D0
	public void ResetToPool() { }

	// RVA: 0x1EA72B0 Offset: 0x1EA66B0 VA: 0x181EA72B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EA64D0 Offset: 0x1EA58D0 VA: 0x181EA64D0
	public void CopyTo(PlayerAttack instance) { }

	// RVA: 0x1EA6560 Offset: 0x1EA5960 VA: 0x181EA6560
	public PlayerAttack Copy() { }

	// RVA: 0x1EA6CF0 Offset: 0x1EA60F0 VA: 0x181EA6CF0
	public static PlayerAttack Deserialize(Stream stream) { }

	// RVA: 0x1EA6630 Offset: 0x1EA5A30 VA: 0x181EA6630
	public static PlayerAttack DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EA6B60 Offset: 0x1EA5F60 VA: 0x181EA6B60
	public static PlayerAttack DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EA7040 Offset: 0x1EA6440 VA: 0x181EA7040
	public static PlayerAttack Deserialize(byte[] buffer) { }

	// RVA: 0x1EA73E0 Offset: 0x1EA67E0 VA: 0x181EA73E0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EA7B70 Offset: 0x1EA6F70 VA: 0x181EA7B70 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EA7B90 Offset: 0x1EA6F90 VA: 0x181EA7B90 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerAttack previous) { }

	// RVA: 0x1EA7400 Offset: 0x1EA6800 VA: 0x181EA7400 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EA6BF0 Offset: 0x1EA5FF0 VA: 0x181EA6BF0
	public static PlayerAttack Deserialize(byte[] buffer, PlayerAttack instance, bool isDelta = False) { }

	// RVA: 0x1EA6EB0 Offset: 0x1EA62B0 VA: 0x181EA6EB0
	public static PlayerAttack Deserialize(Stream stream, PlayerAttack instance, bool isDelta) { }

	// RVA: 0x1EA66B0 Offset: 0x1EA5AB0 VA: 0x181EA66B0
	public static PlayerAttack DeserializeLengthDelimited(Stream stream, PlayerAttack instance, bool isDelta) { }

	// RVA: 0x1EA6920 Offset: 0x1EA5D20 VA: 0x181EA6920
	public static PlayerAttack DeserializeLength(Stream stream, int length, PlayerAttack instance, bool isDelta) { }

	// RVA: 0x1EA7580 Offset: 0x1EA6980 VA: 0x181EA7580
	public static void SerializeDelta(Stream stream, PlayerAttack instance, PlayerAttack previous) { }

	// RVA: 0x1EA7970 Offset: 0x1EA6D70 VA: 0x181EA7970
	public static void Serialize(Stream stream, PlayerAttack instance) { }

	// RVA: 0x1EA7B60 Offset: 0x1EA6F60 VA: 0x181EA7B60
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EA7B70 Offset: 0x1EA6F70 VA: 0x181EA7B70
	public void ToProto(Stream stream) { }

	// RVA: 0x1EA7860 Offset: 0x1EA6C60 VA: 0x181EA7860
	public static byte[] SerializeToBytes(PlayerAttack instance) { }

	// RVA: 0x1EA77B0 Offset: 0x1EA6BB0 VA: 0x181EA77B0
	public static void SerializeLengthDelimited(Stream stream, PlayerAttack instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class PlayerProjectileAttack : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6485
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public PlayerAttack playerAttack; // 0x18
	public Vector3 hitVelocity; // 0x20
	public float hitDistance; // 0x2C
	public float travelTime; // 0x30

	// Methods

	// RVA: 0x20346F0 Offset: 0x2033AF0 VA: 0x1820346F0
	public static void ResetToPool(PlayerProjectileAttack instance) { }

	// RVA: 0x20347D0 Offset: 0x2033BD0 VA: 0x1820347D0
	public void ResetToPool() { }

	// RVA: 0x2034350 Offset: 0x2033750 VA: 0x182034350 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20330A0 Offset: 0x20324A0 VA: 0x1820330A0
	public void CopyTo(PlayerProjectileAttack instance) { }

	// RVA: 0x2033140 Offset: 0x2032540 VA: 0x182033140
	public PlayerProjectileAttack Copy() { }

	// RVA: 0x2033BE0 Offset: 0x2032FE0 VA: 0x182033BE0
	public static PlayerProjectileAttack Deserialize(Stream stream) { }

	// RVA: 0x2033510 Offset: 0x2032910 VA: 0x182033510
	public static PlayerProjectileAttack DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2033590 Offset: 0x2032990 VA: 0x182033590
	public static PlayerProjectileAttack DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20338E0 Offset: 0x2032CE0 VA: 0x1820338E0
	public static PlayerProjectileAttack Deserialize(byte[] buffer) { }

	// RVA: 0x20344B0 Offset: 0x20338B0 VA: 0x1820344B0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2035180 Offset: 0x2034580 VA: 0x182035180 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20351A0 Offset: 0x20345A0 VA: 0x1820351A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerProjectileAttack previous) { }

	// RVA: 0x20346D0 Offset: 0x2033AD0 VA: 0x1820346D0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2034070 Offset: 0x2033470 VA: 0x182034070
	public static PlayerProjectileAttack Deserialize(byte[] buffer, PlayerProjectileAttack instance, bool isDelta = False) { }

	// RVA: 0x2033E40 Offset: 0x2033240 VA: 0x182033E40
	public static PlayerProjectileAttack Deserialize(Stream stream, PlayerProjectileAttack instance, bool isDelta) { }

	// RVA: 0x2033220 Offset: 0x2032620 VA: 0x182033220
	public static PlayerProjectileAttack DeserializeLengthDelimited(Stream stream, PlayerProjectileAttack instance, bool isDelta) { }

	// RVA: 0x2033620 Offset: 0x2032A20 VA: 0x182033620
	public static PlayerProjectileAttack DeserializeLength(Stream stream, int length, PlayerProjectileAttack instance, bool isDelta) { }

	// RVA: 0x20348B0 Offset: 0x2033CB0 VA: 0x1820348B0
	public static void SerializeDelta(Stream stream, PlayerProjectileAttack instance, PlayerProjectileAttack previous) { }

	// RVA: 0x2034E90 Offset: 0x2034290 VA: 0x182034E90
	public static void Serialize(Stream stream, PlayerProjectileAttack instance) { }

	// RVA: 0x2035170 Offset: 0x2034570 VA: 0x182035170
	public byte[] ToProtoBytes() { }

	// RVA: 0x2035180 Offset: 0x2034580 VA: 0x182035180
	public void ToProto(Stream stream) { }

	// RVA: 0x2034D80 Offset: 0x2034180 VA: 0x182034D80
	public static byte[] SerializeToBytes(PlayerProjectileAttack instance) { }

	// RVA: 0x2034CD0 Offset: 0x20340D0 VA: 0x182034CD0
	public static void SerializeLengthDelimited(Stream stream, PlayerProjectileAttack instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class PlayerProjectileRicochet : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6486
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int projectileID; // 0x14
	public Vector3 hitPosition; // 0x18
	public Vector3 inVelocity; // 0x24
	public Vector3 outVelocity; // 0x30
	public Vector3 hitNormal; // 0x3C
	public float travelTime; // 0x48

	// Methods

	// RVA: 0x2037380 Offset: 0x2036780 VA: 0x182037380
	public static void ResetToPool(PlayerProjectileRicochet instance) { }

	// RVA: 0x20372B0 Offset: 0x20366B0 VA: 0x1820372B0
	public void ResetToPool() { }

	// RVA: 0x2036BD0 Offset: 0x2035FD0 VA: 0x182036BD0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20351C0 Offset: 0x20345C0 VA: 0x1820351C0
	public void CopyTo(PlayerProjectileRicochet instance) { }

	// RVA: 0x2035220 Offset: 0x2034620 VA: 0x182035220
	public PlayerProjectileRicochet Copy() { }

	// RVA: 0x20365F0 Offset: 0x20359F0 VA: 0x1820365F0
	public static PlayerProjectileRicochet Deserialize(Stream stream) { }

	// RVA: 0x20352E0 Offset: 0x20346E0 VA: 0x1820352E0
	public static PlayerProjectileRicochet DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20359A0 Offset: 0x2034DA0 VA: 0x1820359A0
	public static PlayerProjectileRicochet DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2036020 Offset: 0x2035420 VA: 0x182036020
	public static PlayerProjectileRicochet Deserialize(byte[] buffer) { }

	// RVA: 0x2036D30 Offset: 0x2036130 VA: 0x182036D30
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2038120 Offset: 0x2037520 VA: 0x182038120 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2038140 Offset: 0x2037540 VA: 0x182038140 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerProjectileRicochet previous) { }

	// RVA: 0x2036FA0 Offset: 0x20363A0 VA: 0x182036FA0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2036890 Offset: 0x2035C90 VA: 0x182036890
	public static PlayerProjectileRicochet Deserialize(byte[] buffer, PlayerProjectileRicochet instance, bool isDelta = False) { }

	// RVA: 0x2036380 Offset: 0x2035780 VA: 0x182036380
	public static PlayerProjectileRicochet Deserialize(Stream stream, PlayerProjectileRicochet instance, bool isDelta) { }

	// RVA: 0x2035660 Offset: 0x2034A60 VA: 0x182035660
	public static PlayerProjectileRicochet DeserializeLengthDelimited(Stream stream, PlayerProjectileRicochet instance, bool isDelta) { }

	// RVA: 0x2035D00 Offset: 0x2035100 VA: 0x182035D00
	public static PlayerProjectileRicochet DeserializeLength(Stream stream, int length, PlayerProjectileRicochet instance, bool isDelta) { }

	// RVA: 0x2037450 Offset: 0x2036850 VA: 0x182037450
	public static void SerializeDelta(Stream stream, PlayerProjectileRicochet instance, PlayerProjectileRicochet previous) { }

	// RVA: 0x2037D00 Offset: 0x2037100 VA: 0x182037D00
	public static void Serialize(Stream stream, PlayerProjectileRicochet instance) { }

	// RVA: 0x2038110 Offset: 0x2037510 VA: 0x182038110
	public byte[] ToProtoBytes() { }

	// RVA: 0x2038120 Offset: 0x2037520 VA: 0x182038120
	public void ToProto(Stream stream) { }

	// RVA: 0x2037BF0 Offset: 0x2036FF0 VA: 0x182037BF0
	public static byte[] SerializeToBytes(PlayerProjectileRicochet instance) { }

	// RVA: 0x2037B40 Offset: 0x2036F40 VA: 0x182037B40
	public static void SerializeLengthDelimited(Stream stream, PlayerProjectileRicochet instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class PlayerProjectileUpdate : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6487
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int projectileID; // 0x14
	public Vector3 curPosition; // 0x18
	public Vector3 curVelocity; // 0x24
	public float travelTime; // 0x30

	// Methods

	// RVA: 0x2039630 Offset: 0x2038A30 VA: 0x182039630
	public static void ResetToPool(PlayerProjectileUpdate instance) { }

	// RVA: 0x20396E0 Offset: 0x2038AE0 VA: 0x1820396E0
	public void ResetToPool() { }

	// RVA: 0x20392D0 Offset: 0x20386D0 VA: 0x1820392D0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2038160 Offset: 0x2037560 VA: 0x182038160
	public void CopyTo(PlayerProjectileUpdate instance) { }

	// RVA: 0x20381A0 Offset: 0x20375A0 VA: 0x1820381A0
	public PlayerProjectileUpdate Copy() { }

	// RVA: 0x20388D0 Offset: 0x2037CD0 VA: 0x1820388D0
	public static PlayerProjectileUpdate Deserialize(Stream stream) { }

	// RVA: 0x2038240 Offset: 0x2037640 VA: 0x182038240
	public static PlayerProjectileUpdate DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2038840 Offset: 0x2037C40 VA: 0x182038840
	public static PlayerProjectileUpdate DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2038B10 Offset: 0x2037F10 VA: 0x182038B10
	public static PlayerProjectileUpdate Deserialize(byte[] buffer) { }

	// RVA: 0x2039400 Offset: 0x2038800 VA: 0x182039400
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x203A040 Offset: 0x2039440 VA: 0x18203A040 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x203A060 Offset: 0x2039460 VA: 0x18203A060 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerProjectileUpdate previous) { }

	// RVA: 0x2039610 Offset: 0x2038A10 VA: 0x182039610 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2039000 Offset: 0x2038400 VA: 0x182039000
	public static PlayerProjectileUpdate Deserialize(byte[] buffer, PlayerProjectileUpdate instance, bool isDelta = False) { }

	// RVA: 0x2038DF0 Offset: 0x20381F0 VA: 0x182038DF0
	public static PlayerProjectileUpdate Deserialize(Stream stream, PlayerProjectileUpdate instance, bool isDelta) { }

	// RVA: 0x20382C0 Offset: 0x20376C0 VA: 0x1820382C0
	public static PlayerProjectileUpdate DeserializeLengthDelimited(Stream stream, PlayerProjectileUpdate instance, bool isDelta) { }

	// RVA: 0x2038590 Offset: 0x2037990 VA: 0x182038590
	public static PlayerProjectileUpdate DeserializeLength(Stream stream, int length, PlayerProjectileUpdate instance, bool isDelta) { }

	// RVA: 0x2039790 Offset: 0x2038B90 VA: 0x182039790
	public static void SerializeDelta(Stream stream, PlayerProjectileUpdate instance, PlayerProjectileUpdate previous) { }

	// RVA: 0x2039DA0 Offset: 0x20391A0 VA: 0x182039DA0
	public static void Serialize(Stream stream, PlayerProjectileUpdate instance) { }

	// RVA: 0x203A030 Offset: 0x2039430 VA: 0x18203A030
	public byte[] ToProtoBytes() { }

	// RVA: 0x203A040 Offset: 0x2039440 VA: 0x18203A040
	public void ToProto(Stream stream) { }

	// RVA: 0x2039C90 Offset: 0x2039090 VA: 0x182039C90
	public static byte[] SerializeToBytes(PlayerProjectileUpdate instance) { }

	// RVA: 0x2039BE0 Offset: 0x2038FE0 VA: 0x182039BE0
	public static void SerializeLengthDelimited(Stream stream, PlayerProjectileUpdate instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class PlayerDetectedAIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6544
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float range; // 0x14

	// Methods

	// RVA: 0x1EA86F0 Offset: 0x1EA7AF0 VA: 0x181EA86F0
	public static void ResetToPool(PlayerDetectedAIEventData instance) { }

	// RVA: 0x1EA8670 Offset: 0x1EA7A70 VA: 0x181EA8670
	public void ResetToPool() { }

	// RVA: 0x1EA8540 Offset: 0x1EA7940 VA: 0x181EA8540 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BF9250 Offset: 0x1BF8650 VA: 0x181BF9250
	public void CopyTo(PlayerDetectedAIEventData instance) { }

	// RVA: 0x1EA7BB0 Offset: 0x1EA6FB0 VA: 0x181EA7BB0
	public PlayerDetectedAIEventData Copy() { }

	// RVA: 0x1EA84C0 Offset: 0x1EA78C0 VA: 0x181EA84C0
	public static PlayerDetectedAIEventData Deserialize(Stream stream) { }

	// RVA: 0x1EA7C20 Offset: 0x1EA7020 VA: 0x181EA7C20
	public static PlayerDetectedAIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EA80C0 Offset: 0x1EA74C0 VA: 0x181EA80C0
	public static PlayerDetectedAIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EA83A0 Offset: 0x1EA77A0 VA: 0x181EA83A0
	public static PlayerDetectedAIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x1EA8630 Offset: 0x1EA7A30 VA: 0x181EA8630
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EA8B40 Offset: 0x1EA7F40 VA: 0x181EA8B40 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EA8B60 Offset: 0x1EA7F60 VA: 0x181EA8B60 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PlayerDetectedAIEventData previous) { }

	// RVA: 0x1EA8650 Offset: 0x1EA7A50 VA: 0x181EA8650 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EA82A0 Offset: 0x1EA76A0 VA: 0x181EA82A0
	public static PlayerDetectedAIEventData Deserialize(byte[] buffer, PlayerDetectedAIEventData instance, bool isDelta = False) { }

	// RVA: 0x1EA8150 Offset: 0x1EA7550 VA: 0x181EA8150
	public static PlayerDetectedAIEventData Deserialize(Stream stream, PlayerDetectedAIEventData instance, bool isDelta) { }

	// RVA: 0x1EA7CA0 Offset: 0x1EA70A0 VA: 0x181EA7CA0
	public static PlayerDetectedAIEventData DeserializeLengthDelimited(Stream stream, PlayerDetectedAIEventData instance, bool isDelta) { }

	// RVA: 0x1EA7EC0 Offset: 0x1EA72C0 VA: 0x181EA7EC0
	public static PlayerDetectedAIEventData DeserializeLength(Stream stream, int length, PlayerDetectedAIEventData instance, bool isDelta) { }

	// RVA: 0x1EA8770 Offset: 0x1EA7B70 VA: 0x181EA8770
	public static void SerializeDelta(Stream stream, PlayerDetectedAIEventData instance, PlayerDetectedAIEventData previous) { }

	// RVA: 0x1EA8A50 Offset: 0x1EA7E50 VA: 0x181EA8A50
	public static void Serialize(Stream stream, PlayerDetectedAIEventData instance) { }

	// RVA: 0x1EA8B30 Offset: 0x1EA7F30 VA: 0x181EA8B30
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EA8B40 Offset: 0x1EA7F40 VA: 0x181EA8B40
	public void ToProto(Stream stream) { }

	// RVA: 0x1EA8940 Offset: 0x1EA7D40 VA: 0x181EA8940
	public static byte[] SerializeToBytes(PlayerDetectedAIEventData instance) { }

	// RVA: 0x1EA8890 Offset: 0x1EA7C90 VA: 0x181EA8890
	public static void SerializeLengthDelimited(Stream stream, PlayerDetectedAIEventData instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class PlayerIdleAnimationRandomiser : StateMachineBehaviour // TypeDefIndex: 8270
{	// Fields
	public int MaxValue; // 0x18
	public static int Param_Random; // 0x0
	private TimeSince lastRandomisation; // 0x1C

	// Methods

	// RVA: 0xC2DCA0 Offset: 0xC2D0A0 VA: 0x180C2DCA0 Slot: 5
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0xC2DED0 Offset: 0xC2D2D0 VA: 0x180C2DED0
	public void .ctor() { }

	// RVA: 0xC2DE80 Offset: 0xC2D280 VA: 0x180C2DE80
	private static void .cctor() { }

}

public class BasePlayer : BaseCombatEntity, LootPanel.IHasLootPanel // TypeDefIndex: 8336
{	// Fields
	private Option __menuOption_Climb; // 0x240
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

	// Properties
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

	// Methods

	// RVA: 0x72BB10 Offset: 0x72AF10 VA: 0x18072BB10 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7463C0 Offset: 0x7457C0 VA: 0x1807463C0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x733C70 Offset: 0x733070 VA: 0x180733C70 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x721980 Offset: 0x720D80 VA: 0x180721980 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	// RVA: 0x746900 Offset: 0x745D00 VA: 0x180746900 Slot: 145
	public Translate.Phrase get_LootPanelTitle() { }

	[BaseEntity.Menu] // RVA: 0xBBAB0 Offset: 0xBAEB0 VA: 0x1800BBAB0
	[BaseEntity.Menu.Description] // RVA: 0xBBAB0 Offset: 0xBAEB0 VA: 0x1800BBAB0
	[BaseEntity.Menu.Icon] // RVA: 0xBBAB0 Offset: 0xBAEB0 VA: 0x1800BBAB0
	[BaseEntity.Menu.ShowIf] // RVA: 0xBBAB0 Offset: 0xBAEB0 VA: 0x1800BBAB0
	// RVA: 0x732B60 Offset: 0x731F60 VA: 0x180732B60
	public void Menu_LootPlayer(BasePlayer player) { }

	// RVA: 0x732B40 Offset: 0x731F40 VA: 0x180732B40
	public bool Menu_LootPlayer_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x73E520 Offset: 0x73D920 VA: 0x18073E520
	private void RPC_OpenLootPanel(BaseEntity.RPCMessage rpc) { }

	// RVA: 0x73C890 Offset: 0x73BC90 VA: 0x18073C890
	private void PlayOpenSound() { }

	// RVA: 0x72EA30 Offset: 0x72DE30 VA: 0x18072EA30
	public bool InFirstPersonMode() { }

	// RVA: 0x7446B0 Offset: 0x743AB0 VA: 0x1807446B0
	public void UpdateViewMode() { }

	// RVA: 0x746A70 Offset: 0x745E70 VA: 0x180746A70
	internal BasePlayer.CameraMode get_idealViewMode() { }

	// RVA: 0x746ED0 Offset: 0x7462D0 VA: 0x180746ED0
	internal bool get_shouldDrawBody() { }

	// RVA: 0x73C350 Offset: 0x73B750 VA: 0x18073C350 Slot: 146
	public virtual void OnViewModeChanged() { }

	// RVA: 0x732BD0 Offset: 0x731FD0 VA: 0x180732BD0
	public void ModifyCamera() { }

	[BaseEntity.Menu] // RVA: 0xBBDA0 Offset: 0xBB1A0 VA: 0x1800BBDA0
	[BaseEntity.Menu.Description] // RVA: 0xBBDA0 Offset: 0xBB1A0 VA: 0x1800BBDA0
	[BaseEntity.Menu.Icon] // RVA: 0xBBDA0 Offset: 0xBB1A0 VA: 0x1800BBDA0
	[BaseEntity.Menu.ShowIf] // RVA: 0xBBDA0 Offset: 0xBB1A0 VA: 0x1800BBDA0
	// RVA: 0x732B00 Offset: 0x731F00 VA: 0x180732B00
	public void Menu_AssistPlayer(BasePlayer player) { }

	// RVA: 0x732AC0 Offset: 0x731EC0 VA: 0x180732AC0
	public void Menu_AssistPlayer_TimeStart() { }

	// RVA: 0x732830 Offset: 0x731C30 VA: 0x180732830
	public bool Menu_AssistPlayer_ShowIf(BasePlayer player) { }

	// RVA: 0x746E80 Offset: 0x746280 VA: 0x180746E80
	public GameObject get_lookingAt() { }

	// RVA: 0x746E10 Offset: 0x746210 VA: 0x180746E10
	public BaseEntity get_lookingAtEntity() { }

	// RVA: 0x746DC0 Offset: 0x7461C0 VA: 0x180746DC0
	public Collider get_lookingAtCollider() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x746E60 Offset: 0x746260 VA: 0x180746E60
	public Vector3 get_lookingAtPoint() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x747290 Offset: 0x746690 VA: 0x180747290
	private void set_lookingAtPoint(Vector3 value) { }

	// RVA: 0x72AE60 Offset: 0x72A260 VA: 0x18072AE60 Slot: 52
	public override float GetExtrapolationTime() { }

	// RVA: 0x72B910 Offset: 0x72AD10 VA: 0x18072B910 Slot: 57
	public override Vector3 GetLocalVelocityClient() { }

	// RVA: 0x723480 Offset: 0x722880 VA: 0x180723480 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x7281A0 Offset: 0x7275A0 VA: 0x1807281A0
	private void CreatePlayerModel() { }

	// RVA: 0x727FF0 Offset: 0x7273F0 VA: 0x180727FF0
	private void CreatePlayerCollision() { }

	// RVA: 0x7286C0 Offset: 0x727AC0 VA: 0x1807286C0
	private void CreatePlayerMovement() { }

	// RVA: 0x72EA80 Offset: 0x72DE80 VA: 0x18072EA80
	internal void InitLocalPlayer() { }

	// RVA: 0x72ED60 Offset: 0x72E160 VA: 0x18072ED60
	internal void InitRemotePlayer() { }

	// RVA: 0x72E0E0 Offset: 0x72D4E0 VA: 0x18072E0E0
	public bool HasLocalControls() { }

	// RVA: 0x741250 Offset: 0x740650 VA: 0x180741250 Slot: 59
	public override void SetNetworkPosition(Vector3 vPos) { }

	// RVA: 0x741300 Offset: 0x740700 VA: 0x180741300 Slot: 60
	public override void SetNetworkRotation(Quaternion qRot) { }

	// RVA: 0x728B80 Offset: 0x727F80 VA: 0x180728B80 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x73D000 Offset: 0x73C400 VA: 0x18073D000 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x7335A0 Offset: 0x7329A0 VA: 0x1807335A0
	private void OnFirstWakeUp() { }

	// RVA: 0x746930 Offset: 0x745D30 VA: 0x180746930
	public float get_TimeAwake() { }

	// RVA: 0x720F80 Offset: 0x720380 VA: 0x180720F80
	public void CL_ClothingChanged() { }

	// RVA: 0x72A270 Offset: 0x729670 VA: 0x18072A270
	public void ForceRebuild() { }

	// RVA: 0x73E9C0 Offset: 0x73DDC0 VA: 0x18073E9C0
	internal void RebuildWorldModel(PlayerModel pModel) { }

	// RVA: 0x7409E0 Offset: 0x73FDE0 VA: 0x1807409E0
	private void SetDefaultFootstepEffects(PlayerModel pModel) { }

	// RVA: 0x73BDD0 Offset: 0x73B1D0 VA: 0x18073BDD0 Slot: 83
	public override void OnSignal(BaseEntity.Signal signal, string arg) { }

	// RVA: 0x729880 Offset: 0x728C80 VA: 0x180729880 Slot: 124
	public override Transform FindBone(string strName) { }

	// RVA: 0x72A3A0 Offset: 0x7297A0 VA: 0x18072A3A0 Slot: 123
	public override Transform[] GetBones() { }

	// RVA: 0x741B10 Offset: 0x740F10 VA: 0x180741B10 Slot: 58
	public override bool ShouldLerp() { }

	// RVA: 0x746990 Offset: 0x745D90 VA: 0x180746990
	public static BufferList<BasePlayer> get_VisiblePlayerList() { }

	// RVA: 0x722FB0 Offset: 0x7223B0 VA: 0x180722FB0
	public static void ClearVisibility() { }

	// RVA: 0x73F160 Offset: 0x73E560 VA: 0x18073F160
	public static void RegisterForVisibility(BasePlayer player) { }

	// RVA: 0x742410 Offset: 0x741810 VA: 0x180742410
	public static void UnregisterFromVisibility(ulong userID) { }

	// RVA: 0x729980 Offset: 0x728D80 VA: 0x180729980
	public static BasePlayer FindByID_Clientside(ulong userID) { }

	// RVA: 0x729B50 Offset: 0x728F50 VA: 0x180729B50
	public static BasePlayer Find_Clientside(string strNameOrIDOrIP) { }

	// RVA: 0x72D900 Offset: 0x72CD00 VA: 0x18072D900
	public static float GetRandomFloatBasedOnUserID(ulong steamid, ulong seed) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x741AE0 Offset: 0x740EE0 VA: 0x180741AE0 Slot: 17
	public override bool ShouldDestroyWithGroup() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x740EA0 Offset: 0x7402A0 VA: 0x180740EA0
	public void SetInheritedVelocity(Vector3 velocity, uint entID) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x72D640 Offset: 0x72CA40 VA: 0x18072D640
	public void GetPerformanceReport(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x72D1C0 Offset: 0x72C5C0 VA: 0x18072D1C0
	public void GetPerformanceReport_Frametime(BaseEntity.RPCMessage msg) { }

	// RVA: 0x732FF0 Offset: 0x7323F0 VA: 0x180732FF0 Slot: 63
	public override void OnBecameRagdoll(Ragdoll rdoll) { }

	// RVA: 0x73C850 Offset: 0x73BC50 VA: 0x18073C850 Slot: 74
	public override void OnVoiceData(byte[] data) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x73ED30 Offset: 0x73E130 VA: 0x18073ED30
	public void RecieveAchievement(string name) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x727D80 Offset: 0x727180 VA: 0x180727D80
	public void CraftMode(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x741E00 Offset: 0x741200 VA: 0x180741E00
	public void StartDesigningAI(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x733360 Offset: 0x732760 VA: 0x180733360
	public void OnDebugAIEventTriggeredStateChange(int previousStateContainerID, int newStateContainerID, int sourceEventID) { }

	// RVA: 0x724420 Offset: 0x723820 VA: 0x180724420 Slot: 13
	public override void ClientOnEnable() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x726800 Offset: 0x725C00 VA: 0x180726800
	private void Client_OnRepairFailedResources(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x742070 Offset: 0x741470 VA: 0x180742070
	private void TakeDamageHit() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x71F550 Offset: 0x71E950 VA: 0x18071F550
	private void AdminReceivedUGC(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x71F490 Offset: 0x71E890 VA: 0x18071F490
	private void AdminReceivedPatternFirework(BaseEntity.RPCMessage msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7468F0 Offset: 0x745CF0 VA: 0x1807468F0
	public bool get_IsWearingDiveGoggles() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x747080 Offset: 0x746480 VA: 0x180747080
	private void set_IsWearingDiveGoggles(bool value) { }

	// RVA: 0x742560 Offset: 0x741960 VA: 0x180742560
	protected void UpdateClothesIfNeeded() { }

	// RVA: 0x732530 Offset: 0x731930 VA: 0x180732530 Slot: 89
	public override void MakeVisible() { }

	// RVA: 0x7258E0 Offset: 0x724CE0 VA: 0x1807258E0
	protected void ClientUpdate_Sleeping() { }

	// RVA: 0x725CC0 Offset: 0x7250C0 VA: 0x180725CC0
	protected void ClientUpdate() { }

	// RVA: 0x73E7A0 Offset: 0x73DBA0 VA: 0x18073E7A0
	public void RebuildClothingItems() { }

	// RVA: 0x742A50 Offset: 0x741E50 VA: 0x180742A50
	public void UpdateClothingItems(SkinnedMultiMesh multiMesh) { }

	// RVA: 0x743180 Offset: 0x742580 VA: 0x180743180
	public void UpdateHolsterOffsets() { }

	// RVA: 0x73CF40 Offset: 0x73C340 VA: 0x18073CF40
	public void PostLateClientCycle() { }

	// RVA: 0x7306B0 Offset: 0x72FAB0 VA: 0x1807306B0
	public bool IsLocalPlayer() { }

	// RVA: 0x724580 Offset: 0x723980 VA: 0x180724580
	public void ClientUpdateLocalPlayer() { }

	// RVA: 0x744550 Offset: 0x743950 VA: 0x180744550
	public void UpdateTopologyStats() { }

	// RVA: 0x7244D0 Offset: 0x7238D0 VA: 0x1807244D0
	private void ClientTick() { }

	// RVA: 0x728E70 Offset: 0x728270 VA: 0x180728E70
	public void DoMovement() { }

	// RVA: 0x732CC0 Offset: 0x7320C0 VA: 0x180732CC0
	private void MountableOverrideViewAngles() { }

	// RVA: 0x7204C0 Offset: 0x71F8C0 VA: 0x1807204C0 Slot: 147
	public virtual void BlockSprint(float duration = 0,2) { }

	// RVA: 0x720420 Offset: 0x71F820 VA: 0x180720420 Slot: 148
	public virtual void BlockJump(float duration = 0,5) { }

	// RVA: 0x723970 Offset: 0x722D70 VA: 0x180723970 Slot: 149
	internal virtual void ClientInput(InputState state) { }

	// RVA: 0x744A10 Offset: 0x743E10 VA: 0x180744A10
	internal void UseAction(InputState state) { }

	// RVA: 0x72B400 Offset: 0x72A800 VA: 0x18072B400
	internal BaseEntity GetInteractionEntity() { }

	// RVA: 0x73E380 Offset: 0x73D780 VA: 0x18073E380
	internal void QuickUse() { }

	// RVA: 0x732470 Offset: 0x731870 VA: 0x180732470
	internal void LongUse() { }

	// RVA: 0x744CE0 Offset: 0x7440E0 VA: 0x180744CE0
	internal void UseStop() { }

	// RVA: 0x743310 Offset: 0x742710 VA: 0x180743310
	internal bool UpdateLookingAt(float radius, bool includeSecondaryEntities) { }

	// RVA: 0x73F5B0 Offset: 0x73E9B0 VA: 0x18073F5B0
	private void ResetLookingAt() { }

	// RVA: 0x741030 Offset: 0x740430 VA: 0x180741030
	private void SetLookingAt(HitTest lookingAtTest) { }

	// RVA: 0x7227B0 Offset: 0x721BB0 VA: 0x1807227B0
	private bool CheckLookingAtVisible(HitTest test, TraceInfo trace) { }

	// RVA: 0x729A10 Offset: 0x728E10 VA: 0x180729A10
	private static BaseVehicle FindVehicleParentFor(BaseEntity entity) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7334D0 Offset: 0x7328D0 VA: 0x1807334D0
	private void OnDied(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7338D0 Offset: 0x732CD0 VA: 0x1807338D0
	private void OnRespawnInformation(BaseEntity.RPCMessage msg) { }

	// RVA: 0x73F460 Offset: 0x73E860 VA: 0x18073F460
	private void RequestRespawnUpdates() { }

	// RVA: 0x7336E0 Offset: 0x732AE0 VA: 0x1807336E0
	public void OnLand(float fVelocity) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x741F90 Offset: 0x741390 VA: 0x180741F90
	private void StartLoading() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x729DF0 Offset: 0x7291F0 VA: 0x180729DF0
	private void FinishLoading() { }

	// RVA: 0x72A280 Offset: 0x729680 VA: 0x18072A280
	private void FullBlack_FadeIn() { }

	[IteratorStateMachineAttribute] // RVA: 0xBE780 Offset: 0xBDB80 VA: 0x1800BE780
	// RVA: 0x729F40 Offset: 0x729340 VA: 0x180729F40
	private IEnumerator FinishedLoadingRoutine() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x728960 Offset: 0x727D60 VA: 0x180728960
	private void DirectionalDamage(Vector3 position, int damageType, int damageTotal) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7423A0 Offset: 0x7417A0 VA: 0x1807423A0
	public void UnlockedBlueprint(BaseEntity.RPCMessage msg) { }

	// RVA: 0x722740 Offset: 0x721B40 VA: 0x180722740
	private void CheckForRespawnInfo() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7442B0 Offset: 0x7436B0 VA: 0x1807442B0
	public void UpdateRichPresenceState(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x72DBE0 Offset: 0x72CFE0 VA: 0x18072DBE0
	public void HandleCompanionPairingResult(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7446F0 Offset: 0x743AF0 VA: 0x1807446F0
	public Vector3 UpdateWaterDrinkingPoint() { }

	// RVA: 0x72DBC0 Offset: 0x72CFC0 VA: 0x18072DBC0
	private Vector3 GetWaterDrinkingPoint() { }

	[BaseEntity.Menu] // RVA: 0xBEBF0 Offset: 0xBDFF0 VA: 0x1800BEBF0
	[BaseEntity.Menu.Description] // RVA: 0xBEBF0 Offset: 0xBDFF0 VA: 0x1800BEBF0
	[BaseEntity.Menu.Icon] // RVA: 0xBEBF0 Offset: 0xBDFF0 VA: 0x1800BEBF0
	[BaseEntity.Menu.ShowIf] // RVA: 0xBEBF0 Offset: 0xBDFF0 VA: 0x1800BEBF0
	// RVA: 0x729110 Offset: 0x728510 VA: 0x180729110
	public void Drink(BasePlayer player) { }

	// RVA: 0x728F30 Offset: 0x728330 VA: 0x180728F30
	public bool Drink_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xBEDE0 Offset: 0xBE1E0 VA: 0x1800BEDE0
	[BaseEntity.Menu.Description] // RVA: 0xBEDE0 Offset: 0xBE1E0 VA: 0x1800BEDE0
	[BaseEntity.Menu.Icon] // RVA: 0xBEDE0 Offset: 0xBE1E0 VA: 0x1800BEDE0
	[BaseEntity.Menu.ShowIf] // RVA: 0xBEDE0 Offset: 0xBE1E0 VA: 0x1800BEDE0
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void SaltWater(BasePlayer player) { }

	// RVA: 0x73F730 Offset: 0x73EB30 VA: 0x18073F730
	public bool SaltWater_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xBEFA0 Offset: 0xBE3A0 VA: 0x1800BEFA0
	[BaseEntity.Menu.Description] // RVA: 0xBEFA0 Offset: 0xBE3A0 VA: 0x1800BEFA0
	[BaseEntity.Menu.Icon] // RVA: 0xBEFA0 Offset: 0xBE3A0 VA: 0x1800BEFA0
	[BaseEntity.Menu.ShowIf] // RVA: 0xBEFA0 Offset: 0xBE3A0 VA: 0x1800BEFA0
	// RVA: 0x727500 Offset: 0x726900 VA: 0x180727500
	public void Climb(BasePlayer player) { }

	// RVA: 0x727230 Offset: 0x726630 VA: 0x180727230
	public bool Climb_ShowIf(BasePlayer player) { }

	// RVA: 0x72E150 Offset: 0x72D550 VA: 0x18072E150
	public bool HasPlayerFlag(BasePlayer.PlayerFlags f) { }

	// RVA: 0x7468E0 Offset: 0x745CE0 VA: 0x1807468E0
	public bool get_IsReceivingSnapshot() { }

	// RVA: 0x746800 Offset: 0x745C00 VA: 0x180746800
	public bool get_IsAdmin() { }

	// RVA: 0x7468B0 Offset: 0x745CB0 VA: 0x1807468B0
	public bool get_IsDeveloper() { }

	// RVA: 0x746810 Offset: 0x745C10 VA: 0x180746810
	public bool get_IsAiming() { }

	// RVA: 0x7468C0 Offset: 0x745CC0 VA: 0x1807468C0
	public bool get_IsFlying() { }

	// RVA: 0x746820 Offset: 0x745C20 VA: 0x180746820
	public bool get_IsConnected() { }

	// RVA: 0x746750 Offset: 0x745B50 VA: 0x180746750
	public bool get_InGesture() { }

	// RVA: 0x7462A0 Offset: 0x7456A0 VA: 0x1807462A0
	private bool get_CurrentGestureBlocksMovement() { }

	// RVA: 0x7462E0 Offset: 0x7456E0 VA: 0x1807462E0
	public bool get_CurrentGestureIsDance() { }

	// RVA: 0x746320 Offset: 0x745720 VA: 0x180746320
	public bool get_CurrentGestureIsFullBody() { }

	// RVA: 0x746720 Offset: 0x745B20 VA: 0x180746720
	private bool get_InGestureCancelCooldown() { }

	// RVA: 0x740AA0 Offset: 0x73FEA0 VA: 0x180740AA0
	private void SetGestureMenuOpen(bool wantsOpen) { }

	// RVA: 0x73F500 Offset: 0x73E900 VA: 0x18073F500
	private void RequestStartGesture(GestureConfig g) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x726D60 Offset: 0x726160 VA: 0x180726D60
	private void Client_StartGesture(BaseEntity.RPCMessage msg) { }

	// RVA: 0x726DC0 Offset: 0x7261C0 VA: 0x180726DC0
	public void Client_StartGesture(GestureConfig gesture) { }

	// RVA: 0x73D6F0 Offset: 0x73CAF0 VA: 0x18073D6F0
	private void ProcessDanceAction() { }

	// RVA: 0x73FA80 Offset: 0x73EE80 VA: 0x18073FA80
	public bool SayingHello() { }

	// RVA: 0x73DC00 Offset: 0x73D000 VA: 0x18073DC00
	private void ProcessGestureStart() { }

	// RVA: 0x729430 Offset: 0x728830 VA: 0x180729430
	private void EndGesture() { }

	// RVA: 0x7294D0 Offset: 0x7288D0 VA: 0x1807294D0
	private void EndLocalGesture() { }

	// RVA: 0x7292C0 Offset: 0x7286C0 VA: 0x1807292C0
	private void EndGestureShared() { }

	// RVA: 0x72E8C0 Offset: 0x72DCC0 VA: 0x18072E8C0
	private void HideHeldEntity(bool state) { }

	// RVA: 0x722460 Offset: 0x721860 VA: 0x180722460
	private void CancelGesture() { }

	// RVA: 0x73F250 Offset: 0x73E650 VA: 0x18073F250
	public void RemoteGestureCancel() { }

	// RVA: 0x722040 Offset: 0x721440 VA: 0x180722040
	private bool CancelGestureInput() { }

	// RVA: 0x722E60 Offset: 0x722260 VA: 0x180722E60
	public void ClearGestureCooldown() { }

	// RVA: 0x727B10 Offset: 0x726F10 VA: 0x180727B10
	public bool ConVarRequestStartGesture(string gestureName) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x726D10 Offset: 0x726110 VA: 0x180726D10
	private void Client_RemoteCancelledGesture() { }

	// RVA: 0x72FFF0 Offset: 0x72F3F0 VA: 0x18072FFF0
	private bool IsGestureBlocked() { }

	// RVA: 0x746A00 Offset: 0x745E00 VA: 0x180746A00
	public float get_clientTeamLifetime() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x720AB0 Offset: 0x71FEB0 VA: 0x180720AB0
	public void CLIENT_ReceiveTeamInfo(BaseEntity.RPCMessage msg) { }

	// RVA: 0x744300 Offset: 0x743700 VA: 0x180744300
	private void UpdateSteamGroup(ulong teamId, int teamSize) { }

	// RVA: 0x722E90 Offset: 0x722290 VA: 0x180722E90
	private void ClearSteamGroup() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x720560 Offset: 0x71F960 VA: 0x180720560
	public void CLIENT_ClearTeam(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x720700 Offset: 0x71FB00 VA: 0x180720700
	public void CLIENT_PendingInvite(BaseEntity.RPCMessage msg) { }

	[BaseEntity.Menu] // RVA: 0xC07C0 Offset: 0xBFBC0 VA: 0x1800C07C0
	[BaseEntity.Menu.Description] // RVA: 0xC07C0 Offset: 0xBFBC0 VA: 0x1800C07C0
	[BaseEntity.Menu.Icon] // RVA: 0xC07C0 Offset: 0xBFBC0 VA: 0x1800C07C0
	[BaseEntity.Menu.ShowIf] // RVA: 0xC07C0 Offset: 0xBFBC0 VA: 0x1800C07C0
	// RVA: 0x72EDD0 Offset: 0x72E1D0 VA: 0x18072EDD0
	public void InviteToTeam(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xC0D20 Offset: 0xC0120 VA: 0x1800C0D20
	[BaseEntity.Menu.Description] // RVA: 0xC0D20 Offset: 0xC0120 VA: 0x1800C0D20
	[BaseEntity.Menu.Icon] // RVA: 0xC0D20 Offset: 0xC0120 VA: 0x1800C0D20
	[BaseEntity.Menu.ShowIf] // RVA: 0xC0D20 Offset: 0xC0120 VA: 0x1800C0D20
	// RVA: 0x73E1F0 Offset: 0x73D5F0 VA: 0x18073E1F0
	public void Promote(BasePlayer player) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void Menu_Promote_Start() { }

	// RVA: 0x73DE20 Offset: 0x73D220 VA: 0x18073DE20
	public bool Promote_ShowIf(BasePlayer player) { }

	// RVA: 0x731F70 Offset: 0x731370 VA: 0x180731F70
	public static bool LocalPlayerIsLeader() { }

	// RVA: 0x72F330 Offset: 0x72E730 VA: 0x18072F330
	public bool Invite_ShowIf(BasePlayer player) { }

	// RVA: 0x72AF50 Offset: 0x72A350 VA: 0x18072AF50
	public HeldEntity GetHeldEntity() { }

	// RVA: -1 Offset: -1
	public bool IsHoldingEntity<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12572D0 Offset: 0x12566D0 VA: 0x1812572D0
	|-BasePlayer.IsHoldingEntity<Hammer>
	|-BasePlayer.IsHoldingEntity<object>
	|-BasePlayer.IsHoldingEntity<WireTool>
	*/

	// RVA: 0x72B190 Offset: 0x72A590 VA: 0x18072B190
	private Item GetHeldItem() { }

	// RVA: 0x72B140 Offset: 0x72A540 VA: 0x18072B140
	public uint GetHeldItemID() { }

	// RVA: 0x72E6A0 Offset: 0x72DAA0 VA: 0x18072E6A0
	private void HeldEntityViewAngles() { }

	// RVA: 0x72E230 Offset: 0x72D630 VA: 0x18072E230
	private void HeldEntityFrame() { }

	// RVA: 0x72E400 Offset: 0x72D800 VA: 0x18072E400
	private void HeldEntityInput() { }

	// RVA: 0x72E7C0 Offset: 0x72DBC0 VA: 0x18072E7C0
	private bool HeldItemUse() { }

	// RVA: 0x72E5D0 Offset: 0x72D9D0 VA: 0x18072E5D0
	public void HeldEntityStart() { }

	// RVA: 0x72E160 Offset: 0x72D560 VA: 0x18072E160
	public void HeldEntityEnd() { }

	// RVA: 0x7303B0 Offset: 0x72F7B0 VA: 0x1807303B0
	public bool IsHostileItem(Item item) { }

	// RVA: 0x730510 Offset: 0x72F910 VA: 0x180730510
	public bool IsItemHoldRestricted(Item item) { }

	// RVA: 0x7325E0 Offset: 0x7319E0 VA: 0x1807325E0
	private void MapInfoOnEnable() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7269D0 Offset: 0x725DD0 VA: 0x1807269D0
	public void Client_ReceiveMarkers(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x727100 Offset: 0x726500 VA: 0x180727100
	public void Client_UpdateDeathMarker(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7266C0 Offset: 0x725AC0 VA: 0x1807266C0
	public void Client_AddNewDeathMarker(BaseEntity.RPCMessage msg) { }

	// RVA: 0x71F3B0 Offset: 0x71E7B0 VA: 0x18071F3B0
	public void AddPointOfInterest(Vector3 position) { }

	// RVA: 0x722D10 Offset: 0x722110 VA: 0x180722D10
	public void ClearAllPointsOfInterest() { }

	// RVA: 0x722BB0 Offset: 0x721FB0 VA: 0x180722BB0
	public void ClearAllMapMarkers() { }

	// RVA: 0x72DC90 Offset: 0x72D090 VA: 0x18072DC90
	public bool HasAttemptedMission(uint missionID) { }

	// RVA: 0x7212C0 Offset: 0x7206C0 VA: 0x1807212C0
	public bool CanAcceptMission(uint missionID) { }

	// RVA: 0x730790 Offset: 0x72FB90 VA: 0x180730790
	public bool IsMissionActive(uint missionID) { }

	// RVA: 0x72DE00 Offset: 0x72D200 VA: 0x18072DE00
	public bool HasCompletedMission(uint missionID) { }

	// RVA: 0x72DF70 Offset: 0x72D370 VA: 0x18072DF70
	public bool HasFailedMission(uint missionID) { }

	// RVA: 0x7409C0 Offset: 0x73FDC0 VA: 0x1807409C0
	public void SetActiveMission(int index) { }

	// RVA: 0x72A390 Offset: 0x729790 VA: 0x18072A390
	public int GetActiveMission() { }

	// RVA: 0x72DC80 Offset: 0x72D080 VA: 0x18072DC80
	public bool HasActiveMission() { }

	// RVA: 0x731550 Offset: 0x730950 VA: 0x180731550
	private void LoadMissions(Missions loadedMissions) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x733840 Offset: 0x732C40 VA: 0x180733840
	private void OnModelState(BaseEntity.RPCMessage data) { }

	// RVA: 0x7337A0 Offset: 0x732BA0 VA: 0x1807337A0
	private void OnModelStateChanged() { }

	// RVA: 0x746CC0 Offset: 0x7460C0 VA: 0x180746CC0
	public bool get_isMounted() { }

	// RVA: 0x746CF0 Offset: 0x7460F0 VA: 0x180746CF0
	public bool get_isMountingHidingWeapon() { }

	// RVA: 0x72CC80 Offset: 0x72C080 VA: 0x18072CC80
	public BaseMountable GetMounted() { }

	// RVA: 0x72CC30 Offset: 0x72C030 VA: 0x18072CC30
	public BaseVehicle GetMountedVehicle() { }

	// RVA: 0x732630 Offset: 0x731A30 VA: 0x180732630
	public void MarkSwapSeat() { }

	// RVA: 0x742040 Offset: 0x741440 VA: 0x180742040
	public bool SwapSeatCooldown() { }

	// RVA: 0x7253A0 Offset: 0x7247A0 VA: 0x1807253A0
	public void ClientUpdateMounted(uint id) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x720EB0 Offset: 0x7202B0 VA: 0x180720EB0
	public void CLIENT_SetPetPrefabID(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x720D00 Offset: 0x720100 VA: 0x180720D00
	public void CLIENT_SetPetPetLoadedStateIndex(BaseEntity.RPCMessage msg) { }

	// RVA: 0x731400 Offset: 0x730800 VA: 0x180731400
	private void LinkPet() { }

	// RVA: 0x741410 Offset: 0x740810 VA: 0x180741410
	private void SetPetMenuOpen(bool wantsOpen) { }

	// RVA: 0x724330 Offset: 0x723730 VA: 0x180724330
	private void ClientIssuePetCommand(int cmdType, int param, bool raycast) { }

	// RVA: 0x730A70 Offset: 0x72FE70 VA: 0x180730A70
	public bool IsSleeping() { }

	// RVA: 0x730A80 Offset: 0x72FE80 VA: 0x180730A80
	public bool IsSpectating() { }

	// RVA: 0x7309A0 Offset: 0x72FDA0 VA: 0x1807309A0
	public bool IsRelaxed() { }

	// RVA: 0x730A60 Offset: 0x72FE60 VA: 0x180730A60
	public bool IsServerFalling() { }

	// RVA: 0x72A7B0 Offset: 0x729BB0 VA: 0x18072A7B0 Slot: 82
	public override BuildingPrivlidge GetBuildingPrivilege() { }

	// RVA: 0x721C50 Offset: 0x721050 VA: 0x180721C50
	public bool CanBuild() { }

	// RVA: 0x721AF0 Offset: 0x720EF0 VA: 0x180721AF0
	public bool CanBuild(Vector3 position, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x721A20 Offset: 0x720E20 VA: 0x180721A20
	public bool CanBuild(OBB obb) { }

	// RVA: 0x72FD80 Offset: 0x72F180 VA: 0x18072FD80
	public bool IsBuildingBlocked() { }

	// RVA: 0x72FC20 Offset: 0x72F020 VA: 0x18072FC20
	public bool IsBuildingBlocked(Vector3 position, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x72FB40 Offset: 0x72EF40 VA: 0x18072FB40
	public bool IsBuildingBlocked(OBB obb) { }

	// RVA: 0x72F940 Offset: 0x72ED40 VA: 0x18072F940
	public bool IsBuildingAuthed() { }

	// RVA: 0x72F9E0 Offset: 0x72EDE0 VA: 0x18072F9E0
	public bool IsBuildingAuthed(Vector3 position, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x72F870 Offset: 0x72EC70 VA: 0x18072F870
	public bool IsBuildingAuthed(OBB obb) { }

	// RVA: 0x721DE0 Offset: 0x7211E0 VA: 0x180721DE0
	public bool CanPlaceBuildingPrivilege() { }

	// RVA: 0x721E50 Offset: 0x721250 VA: 0x180721E50
	public bool CanPlaceBuildingPrivilege(Vector3 position, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x721F90 Offset: 0x721390 VA: 0x180721F90
	public bool CanPlaceBuildingPrivilege(OBB obb) { }

	// RVA: 0x732D50 Offset: 0x732150 VA: 0x180732D50
	public int NewProjectileID() { }

	// RVA: 0x732D60 Offset: 0x732160 VA: 0x180732D60
	public int NewProjectileSeed() { }

	// RVA: 0x740710 Offset: 0x73FB10 VA: 0x180740710
	public void SendProjectileAttack(PlayerProjectileAttack attack) { }

	// RVA: 0x740760 Offset: 0x73FB60 VA: 0x180740760
	public void SendProjectileRicochet(PlayerProjectileRicochet ricochet) { }

	// RVA: 0x7407B0 Offset: 0x73FBB0 VA: 0x1807407B0
	public void SendProjectileUpdate(PlayerProjectileUpdate update) { }

	// RVA: 0x731B10 Offset: 0x730F10 VA: 0x180731B10 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x741D70 Offset: 0x741170 VA: 0x180741D70
	private void SpectatedPlayerHeadshot() { }

	// RVA: 0x72DBA0 Offset: 0x72CFA0 VA: 0x18072DBA0 Slot: 141
	public override float GetThreatLevel() { }

	// RVA: 0x7295F0 Offset: 0x7289F0 VA: 0x1807295F0
	public void EnsureUpdated() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x740DF0 Offset: 0x7401F0 VA: 0x180740DF0
	public void SetHostileLength(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x741A40 Offset: 0x740E40 VA: 0x180741A40
	public void SetWeaponDrawnDuration(BaseEntity.RPCMessage msg) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 150
	protected virtual void ModifyInputState(ref InputState inputState) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x729FB0 Offset: 0x7293B0 VA: 0x180729FB0
	private void ForcePositionToParentOffset(Vector3 position, uint entID) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x742500 Offset: 0x741900 VA: 0x180742500
	public void UpdateClientTickRate(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x72A0E0 Offset: 0x7294E0 VA: 0x18072A0E0
	private void ForcePositionTo(Vector3 position) { }

	// RVA: 0x740800 Offset: 0x73FC00 VA: 0x180740800
	internal void SendVoiceData(byte[] data, int len) { }

	// RVA: 0x740020 Offset: 0x73F420 VA: 0x180740020
	internal void SendClientTick() { }

	// RVA: 0x732DC0 Offset: 0x7321C0 VA: 0x180732DC0
	public void NotifyUnderwearChange() { }

	// RVA: 0x743FB0 Offset: 0x7433B0 VA: 0x180743FB0
	public static void UpdatePlayerVisibilities() { }

	// RVA: 0x7421A0 Offset: 0x7415A0 VA: 0x1807421A0
	private float TimeSinceSeen() { }

	// RVA: 0x7413E0 Offset: 0x7407E0 VA: 0x1807413E0
	private void SetNextVisThink(float addTime) { }

	// RVA: 0x745820 Offset: 0x744C20 VA: 0x180745820
	private bool WantsVisUpdate() { }

	// RVA: 0x72F570 Offset: 0x72E970 VA: 0x18072F570
	public static bool IsAimingAt(BasePlayer aimer, BasePlayer target, float cone = 0,95) { }

	// RVA: 0x742EB0 Offset: 0x7422B0 VA: 0x180742EB0 Slot: 90
	protected override void UpdateCullingSpheres() { }

	// RVA: 0x744E60 Offset: 0x744260 VA: 0x180744E60
	private void VisUpdateUsingCulling(float dist, bool visibility) { }

	// RVA: 0x744F70 Offset: 0x744370 VA: 0x180744F70
	private void VisUpdateUsingRays(float dist) { }

	// RVA: 0x732120 Offset: 0x731520 VA: 0x180732120
	private void LogDebugCull(float dist) { }

	// RVA: 0x73C550 Offset: 0x73B950 VA: 0x18073C550 Slot: 92
	protected override void OnVisibilityChanged(bool visible) { }

	// RVA: 0x745390 Offset: 0x744790 VA: 0x180745390
	private void VisUpdate() { }

	// RVA: 0x744DA0 Offset: 0x7441A0 VA: 0x180744DA0
	private bool VisPlayerArmed() { }

	// RVA: 0x71F820 Offset: 0x71EC20 VA: 0x18071F820
	private bool AnyPartVisible() { }

	// RVA: 0x721180 Offset: 0x720580 VA: 0x180721180
	private float CalcVisUpdateRate(float dist) { }

	// RVA: 0x73CC70 Offset: 0x73C070 VA: 0x18073CC70
	private bool PointSeePoint(Vector3 target, Vector3 origin, float dist = 0, bool useGameTrace = False) { }

	// RVA: 0x730D60 Offset: 0x730160 VA: 0x180730D60
	public bool IsWounded() { }

	// RVA: 0x72FE30 Offset: 0x72F230 VA: 0x18072FE30
	public bool IsCrawling() { }

	// RVA: 0x730500 Offset: 0x72F900 VA: 0x180730500
	public bool IsIncapacitated() { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80 Slot: 97
	public override BasePlayer ToPlayer() { }

	// RVA: 0x746290 Offset: 0x745690 VA: 0x180746290
	public Connection get_Connection() { }

	// RVA: 0x746A50 Offset: 0x745E50 VA: 0x180746A50
	public string get_displayName() { }

	// RVA: 0x747090 Offset: 0x746490 VA: 0x180747090
	public void set_displayName(string value) { }

	// RVA: 0x73F900 Offset: 0x73ED00 VA: 0x18073F900
	public static string SanitizePlayerNameString(string playerName, ulong userId) { }

	// RVA: 0x7302E0 Offset: 0x72F6E0 VA: 0x1807302E0
	public bool IsGod() { }

	// RVA: 0x72CD20 Offset: 0x72C120 VA: 0x18072CD20 Slot: 25
	public override Quaternion GetNetworkRotation() { }

	// RVA: 0x721D80 Offset: 0x721180 VA: 0x180721D80
	public bool CanInteract() { }

	// RVA: 0x721CF0 Offset: 0x7210F0 VA: 0x180721CF0
	public bool CanInteract(bool usableWhileCrawling) { }

	// RVA: 0x741F70 Offset: 0x741370 VA: 0x180741F70 Slot: 143
	public override float StartHealth() { }

	// RVA: 0x73C880 Offset: 0x73BC80 VA: 0x18073C880 Slot: 144
	public override float StartMaxHealth() { }

	// RVA: 0x732670 Offset: 0x731A70 VA: 0x180732670 Slot: 111
	public override float MaxHealth() { }

	// RVA: 0x732720 Offset: 0x731B20 VA: 0x180732720 Slot: 112
	public override float MaxVelocity() { }

	// RVA: 0x745D00 Offset: 0x745100 VA: 0x180745D00 Slot: 103
	public override OBB WorldSpaceBounds() { }

	// RVA: 0x72CB60 Offset: 0x72BF60 VA: 0x18072CB60
	public Vector3 GetMountVelocity() { }

	// RVA: 0x72B280 Offset: 0x72A680 VA: 0x18072B280 Slot: 100
	public override Vector3 GetInheritedProjectileVelocity() { }

	// RVA: 0x72B340 Offset: 0x72A740 VA: 0x18072B340 Slot: 101
	public override Vector3 GetInheritedThrowVelocity() { }

	// RVA: 0x72B1C0 Offset: 0x72A5C0 VA: 0x18072B1C0 Slot: 102
	public override Vector3 GetInheritedDropVelocity() { }

	// RVA: 0x73D280 Offset: 0x73C680 VA: 0x18073D280 Slot: 29
	public override void PreInitShared() { }

	// RVA: 0x7288E0 Offset: 0x727CE0 VA: 0x1807288E0 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x72EA50 Offset: 0x72DE50 VA: 0x18072EA50
	public bool InSafeZone() { }

	// RVA: 0x730D70 Offset: 0x730170 VA: 0x180730D70
	public static void LateClientCycle() { }

	// RVA: 0x723170 Offset: 0x722570 VA: 0x180723170
	public static void ClientCycle(float deltaTime) { }

	// RVA: 0x72A430 Offset: 0x729830 VA: 0x18072A430
	public Bounds GetBounds(bool ducked) { }

	// RVA: 0x72A5C0 Offset: 0x7299C0 VA: 0x18072A5C0
	public Bounds GetBounds() { }

	// RVA: 0x72A880 Offset: 0x729C80 VA: 0x18072A880
	public Vector3 GetCenter(bool ducked) { }

	// RVA: 0x72A9A0 Offset: 0x729DA0 VA: 0x18072A9A0
	public Vector3 GetCenter() { }

	// RVA: 0x72CE40 Offset: 0x72C240 VA: 0x18072CE40
	public Vector3 GetOffset(bool ducked) { }

	// RVA: 0x72CDC0 Offset: 0x72C1C0 VA: 0x18072CDC0
	public Vector3 GetOffset() { }

	// RVA: 0x72DA00 Offset: 0x72CE00 VA: 0x18072DA00
	public Vector3 GetSize(bool ducked) { }

	// RVA: 0x72D980 Offset: 0x72CD80 VA: 0x18072D980
	public Vector3 GetSize() { }

	// RVA: 0x72AF30 Offset: 0x72A330 VA: 0x18072AF30
	public float GetHeight(bool ducked) { }

	// RVA: 0x72AEF0 Offset: 0x72A2F0 VA: 0x18072AEF0
	public float GetHeight() { }

	// RVA: 0x72D8F0 Offset: 0x72CCF0 VA: 0x18072D8F0
	public float GetRadius() { }

	// RVA: 0x72B900 Offset: 0x72AD00 VA: 0x18072B900
	public float GetJumpHeight() { }

	// RVA: 0x7422A0 Offset: 0x7416A0 VA: 0x1807422A0 Slot: 104
	public override Vector3 TriggerPoint() { }

	// RVA: 0x732D70 Offset: 0x732170 VA: 0x180732D70
	public Vector3 NoClipOffset() { }

	// RVA: 0x732DB0 Offset: 0x7321B0 VA: 0x180732DB0
	public float NoClipRadius(float margin) { }

	// RVA: 0x732660 Offset: 0x731A60 VA: 0x180732660
	public float MaxDeployDistance(Item item) { }

	// RVA: 0x7258B0 Offset: 0x724CB0 VA: 0x1807258B0
	public void ClientUpdatePersistantData(PersistantPlayer data) { }

	// RVA: 0x72CB30 Offset: 0x72BF30 VA: 0x18072CB30
	public float GetMinSpeed() { }

	// RVA: 0x72BAE0 Offset: 0x72AEE0 VA: 0x18072BAE0
	public float GetMaxSpeed() { }

	// RVA: 0x72DA60 Offset: 0x72CE60 VA: 0x18072DA60
	public float GetSpeed(float running, float ducking, float crawling) { }

	// RVA: 0x732E00 Offset: 0x732200 VA: 0x180732E00 Slot: 116
	public override void OnAttacked(HitInfo info) { }

	// RVA: 0x729260 Offset: 0x728660 VA: 0x180729260
	private void EnablePlayerCollider() { }

	// RVA: 0x728B20 Offset: 0x727F20 VA: 0x180728B20
	private void DisablePlayerCollider() { }

	// RVA: 0x73EE50 Offset: 0x73E250 VA: 0x18073EE50
	private void RefreshColliderSize(bool forced) { }

	// RVA: 0x741A20 Offset: 0x740E20 VA: 0x180741A20
	private void SetPlayerRigidbodyState(bool isEnabled) { }

	// RVA: 0x71F230 Offset: 0x71E630 VA: 0x18071F230
	private void AddPlayerRigidbody() { }

	// RVA: 0x73F330 Offset: 0x73E730 VA: 0x18073F330
	private void RemovePlayerRigidbody() { }

	// RVA: 0x72FF00 Offset: 0x72F300 VA: 0x18072FF00
	public bool IsEnsnared() { }

	// RVA: 0x72F740 Offset: 0x72EB40 VA: 0x18072F740
	public bool IsAttacking() { }

	// RVA: 0x721730 Offset: 0x720B30 VA: 0x180721730
	public bool CanAttack() { }

	// RVA: 0x733650 Offset: 0x732A50 VA: 0x180733650
	public bool OnLadder() { }

	// RVA: 0x730D10 Offset: 0x730110 VA: 0x180730D10
	public bool IsSwimming() { }

	// RVA: 0x730360 Offset: 0x72F760 VA: 0x180730360
	public bool IsHeadUnderwater() { }

	// RVA: 0x730900 Offset: 0x72FD00 VA: 0x180730900 Slot: 151
	public virtual bool IsOnGround() { }

	// RVA: 0x7309B0 Offset: 0x72FDB0 VA: 0x1807309B0
	public bool IsRunning() { }

	// RVA: 0x72FE50 Offset: 0x72F250 VA: 0x18072FE50
	public bool IsDucked() { }

	// RVA: 0x73ECA0 Offset: 0x73E0A0 VA: 0x18073ECA0
	public bool RecentlyTeleported() { }

	// RVA: 0x741B70 Offset: 0x740F70 VA: 0x180741B70
	public void ShowToast(int style, Translate.Phrase phrase) { }

	// RVA: 0x722530 Offset: 0x721930 VA: 0x180722530
	public void ChatMessage(string msg) { }

	// RVA: 0x727CC0 Offset: 0x7270C0 VA: 0x180727CC0
	public void ConsoleMessage(string msg) { }

	// RVA: 0x73C880 Offset: 0x73BC80 VA: 0x18073C880 Slot: 114
	public override float PenetrationResistance(HitInfo info) { }

	// RVA: 0x73FD90 Offset: 0x73F190 VA: 0x18073FD90 Slot: 142
	public override void ScaleDamage(HitInfo info) { }

	// RVA: 0x743BE0 Offset: 0x742FE0 VA: 0x180743BE0
	private void UpdateMoveSpeedFromClothing() { }

	// RVA: 0x744190 Offset: 0x743590 VA: 0x180744190 Slot: 152
	public virtual void UpdateProtectionFromClothing() { }

	// RVA: 0x722500 Offset: 0x721900 VA: 0x180722500 Slot: 122
	public override string Categorize() { }

	// RVA: 0x7421C0 Offset: 0x7415C0 VA: 0x1807421C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x72AB10 Offset: 0x729F10 VA: 0x18072AB10
	public string GetDebugStatus() { }

	// RVA: 0x72B850 Offset: 0x72AC50 VA: 0x18072B850 Slot: 118
	public override Item GetItem(uint itemId) { }

	// RVA: 0x746970 Offset: 0x745D70 VA: 0x180746970 Slot: 86
	public override BaseEntity.TraitFlag get_Traits() { }

	// RVA: 0x745840 Offset: 0x744C40 VA: 0x180745840 Slot: 107
	public override float WaterFactor() { }

	// RVA: 0x71F770 Offset: 0x71EB70 VA: 0x18071F770 Slot: 108
	public override float AirFactor() { }

	// RVA: 0x72CE90 Offset: 0x72C290 VA: 0x18072CE90
	public float GetOxygenTime(out ItemModGiveOxygen.AirSupplyType airSupplyType) { }

	// RVA: 0x730A80 Offset: 0x72FE80 VA: 0x180730A80 Slot: 128
	public override bool ShouldInheritNetworkGroup() { }

	// RVA: 0x71FE60 Offset: 0x71F260 VA: 0x18071FE60
	public static bool AnyPlayersVisibleToEntity(Vector3 pos, float radius, BaseEntity source, Vector3 entityEyePos, bool ignorePlayersWithPriv = False) { }

	// RVA: 0x730A90 Offset: 0x72FE90 VA: 0x180730A90
	public bool IsStandingOnEntity(BaseEntity standingOn, int layerMask) { }

	// RVA: 0x7409D0 Offset: 0x73FDD0 VA: 0x1807409D0
	public void SetActiveTelephone(PhoneController t) { }

	// RVA: 0x746360 Offset: 0x745760 VA: 0x180746360
	public bool get_HasActiveTelephone() { }

	// RVA: 0x746850 Offset: 0x745C50 VA: 0x180746850
	public bool get_IsDesigningAI() { }

	// RVA: 0x722E40 Offset: 0x722240 VA: 0x180722E40
	public void ClearDesigningAIEntity() { }

	// RVA: 0x7460E0 Offset: 0x7454E0 VA: 0x1807460E0
	public void .ctor() { }

	// RVA: 0x745F90 Offset: 0x745390 VA: 0x180745F90
	private static void .cctor() { }

}

public enum BasePlayer.CameraMode // TypeDefIndex: 8337
{	// Fields
	public int value__; // 0x0
	public const BasePlayer.CameraMode FirstPerson = 0;
	public const BasePlayer.CameraMode ThirdPerson = 1;
	public const BasePlayer.CameraMode Eyes = 2;
	public const BasePlayer.CameraMode FirstPersonWithArms = 3;
	public const BasePlayer.CameraMode DeathCamClassic = 4;
	public const BasePlayer.CameraMode Last = 3;

}

public enum BasePlayer.PlayerFlags // TypeDefIndex: 8338
{	// Fields
	public int value__; // 0x0
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
{	// Fields
	public int value__; // 0x0
	public const BasePlayer.MapNoteType Death = 0;
	public const BasePlayer.MapNoteType PointOfInterest = 1;

}

public enum BasePlayer.TimeCategory // TypeDefIndex: 8340
{	// Fields
	public int value__; // 0x0
	public const BasePlayer.TimeCategory Wilderness = 1;
	public const BasePlayer.TimeCategory Monument = 2;
	public const BasePlayer.TimeCategory Base = 4;
	public const BasePlayer.TimeCategory Flying = 8;
	public const BasePlayer.TimeCategory Boating = 16;
	public const BasePlayer.TimeCategory Swimming = 32;
	public const BasePlayer.TimeCategory Driving = 64;

}

public struct BasePlayer.CapsuleColliderInfo // TypeDefIndex: 8341
{	// Fields
	public float height; // 0x0
	public float radius; // 0x4
	public Vector3 center; // 0x8

	// Methods

	// RVA: 0xF9D40 Offset: 0xF9140 VA: 0x1800F9D40
	public void .ctor(float height, float radius, Vector3 center) { }

}

private sealed class BasePlayer.<>c // TypeDefIndex: 8342
{	// Fields
	public static readonly BasePlayer.<>c <>9; // 0x0
	public static Func<PlayerTeam.TeamMember, ulong> <>9__103_0; // 0x8
	public static Comparison<TraceInfo> <>9__148_0; // 0x10
	public static Predicate<RespawnInformation.SpawnOptions> <>9__155_0; // 0x18

	// Methods

	// RVA: 0x91A8F0 Offset: 0x919CF0 VA: 0x18091A8F0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x91A670 Offset: 0x919A70 VA: 0x18091A670
	internal ulong <OnBecameRagdoll>b__103_0(PlayerTeam.TeamMember m) { }

	// RVA: 0x91A740 Offset: 0x919B40 VA: 0x18091A740
	internal int <UpdateLookingAt>b__148_0(TraceInfo a, TraceInfo b) { }

	// RVA: 0x91A690 Offset: 0x919A90 VA: 0x18091A690
	internal bool <OnRespawnInformation>b__155_0(RespawnInformation.SpawnOptions p) { }

}

private sealed class BasePlayer.<FinishedLoadingRoutine>d__161 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 8343
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public BasePlayer <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x919DB0 Offset: 0x9191B0 VA: 0x180919DB0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x91A310 Offset: 0x919710 VA: 0x18091A310 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class BasePlayer.<>c__DisplayClass210_0 // TypeDefIndex: 8344
{	// Fields
	public GestureConfig g; // 0x10
	public BasePlayer <>4__this; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x91A760 Offset: 0x919B60 VA: 0x18091A760
	internal void <SetGestureMenuOpen>b__0(BasePlayer ply) { }

}

private sealed class BasePlayer.<>c__DisplayClass304_0 // TypeDefIndex: 8345
{	// Fields
	public uint index; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x91A790 Offset: 0x919B90 VA: 0x18091A790
	internal bool <CLIENT_SetPetPetLoadedStateIndex>b__0(PetCommandList.PetCommandDesc c) { }

}

private sealed class BasePlayer.<>c__DisplayClass306_0 // TypeDefIndex: 8346
{	// Fields
	public PetCommandList.PetCommandDesc desc; // 0x10
	public BasePlayer <>4__this; // 0x40

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x91A7B0 Offset: 0x919BB0 VA: 0x18091A7B0
	internal void <SetPetMenuOpen>b__0(BasePlayer ply) { }

}

public class PlayerInventory : EntityComponent<BasePlayer> // TypeDefIndex: 8620
{	// Fields
	public ItemContainer containerMain; // 0x20
	public ItemContainer containerBelt; // 0x28
	public ItemContainer containerWear; // 0x30
	public ItemCrafter crafting; // 0x38
	public PlayerLoot loot; // 0x40

	// Methods

	// RVA: 0xC31E60 Offset: 0xC31260 VA: 0x180C31E60 Slot: 9
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xC31AB0 Offset: 0xC30EB0 VA: 0x180C31AB0
	protected void Initialize() { }

	// RVA: 0xC31290 Offset: 0xC30690 VA: 0x180C31290
	public void DoDestroy() { }

	// RVA: 0xC31210 Offset: 0xC30610 VA: 0x180C31210
	public void ClientInit(BasePlayer owner) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC322B0 Offset: 0xC316B0 VA: 0x180C322B0
	private void UpdatedItemContainer(BaseEntity.RPCMessage packet) { }

	// RVA: 0xC318D0 Offset: 0xC30CD0 VA: 0x180C318D0
	public Item FindItemUID(uint id) { }

	// RVA: 0xC315F0 Offset: 0xC309F0 VA: 0x180C315F0
	public Item FindItemID(string itemName) { }

	// RVA: 0xC31710 Offset: 0xC30B10 VA: 0x180C31710
	public Item FindItemID(int id) { }

	// RVA: 0xC31370 Offset: 0xC30770 VA: 0x180C31370
	public Item FindBySubEntityID(uint subEntityID) { }

	// RVA: 0xC317E0 Offset: 0xC30BE0 VA: 0x180C317E0
	public List<Item> FindItemIDs(int id) { }

	// RVA: 0xC31440 Offset: 0xC30840 VA: 0x180C31440
	public ItemContainer FindContainer(uint id) { }

	// RVA: 0xC31A30 Offset: 0xC30E30 VA: 0x180C31A30
	public ItemContainer GetContainer(PlayerInventory.Type id) { }

	// RVA: 0xC31D10 Offset: 0xC31110 VA: 0x180C31D10
	public void Load(PlayerInventory msg) { }

	// RVA: 0xC319B0 Offset: 0xC30DB0 VA: 0x180C319B0
	public int GetAmount(int itemid) { }

	// RVA: 0xC31140 Offset: 0xC30540 VA: 0x180C31140
	public Item[] AllItems() { }

	// RVA: 0xC31070 Offset: 0xC30470 VA: 0x180C31070
	public int AllItemsNoAlloc(ref List<Item> items) { }

	// RVA: 0xC31320 Offset: 0xC30720 VA: 0x180C31320
	public void FindAmmo(List<Item> list, AmmoTypes ammoType) { }

	// RVA: 0xC31A50 Offset: 0xC30E50 VA: 0x180C31A50
	public bool HasAmmo(AmmoTypes ammoType) { }

	// RVA: 0xC324A0 Offset: 0xC318A0 VA: 0x180C324A0
	public void .ctor() { }

}

public enum PlayerInventory.Type // TypeDefIndex: 8621
{	// Fields
	public int value__; // 0x0
	public const PlayerInventory.Type Main = 0;
	public const PlayerInventory.Type Belt = 1;
	public const PlayerInventory.Type Wear = 2;

}

public class PlayerLoot : EntityComponent<BasePlayer> // TypeDefIndex: 8622
{	// Fields
	public BaseEntity entitySource; // 0x20
	public Item itemSource; // 0x28
	public List<ItemContainer> containers; // 0x30
	private EntityRef clientEntity; // 0x38

	// Methods

	// RVA: 0xC328F0 Offset: 0xC31CF0 VA: 0x180C328F0 Slot: 9
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xC328B0 Offset: 0xC31CB0 VA: 0x180C328B0
	public bool IsLooting() { }

	// RVA: 0xC324E0 Offset: 0xC318E0 VA: 0x180C324E0
	public void Clear() { }

	// RVA: 0xC32570 Offset: 0xC31970 VA: 0x180C32570
	public ItemContainer FindContainer(uint id) { }

	// RVA: 0xC32700 Offset: 0xC31B00 VA: 0x180C32700
	public Item FindItem(uint id) { }

	// RVA: 0xC328A0 Offset: 0xC31CA0 VA: 0x180C328A0
	public BaseEntity GetClientEntity() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void ClientInit(BasePlayer owner) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC32D40 Offset: 0xC32140 VA: 0x180C32D40
	private void UpdateLoot(BaseEntity.RPCMessage rpc) { }

	// RVA: 0xC32FD0 Offset: 0xC323D0 VA: 0x180C32FD0
	public void .ctor() { }

}

public class PlayerMetabolism : BaseMetabolism<BasePlayer> // TypeDefIndex: 8623
{	// Fields
	public const float HotThreshold = 40;
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

	// Methods

	// RVA: 0xC33650 Offset: 0xC32A50 VA: 0x180C33650 Slot: 9
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xC33AA0 Offset: 0xC32EA0 VA: 0x180C33AA0 Slot: 10
	public override void Reset() { }

	// RVA: 0xC33040 Offset: 0xC32440 VA: 0x180C33040
	public bool CanConsume() { }

	// RVA: 0xC33410 Offset: 0xC32810 VA: 0x180C33410
	public void MarkConsumption() { }

	// RVA: 0xC330F0 Offset: 0xC324F0 VA: 0x180C330F0
	public void ClientInit(BasePlayer owner) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC33D60 Offset: 0xC33160 VA: 0x180C33D60
	public void UpdateMetabolism(BaseEntity.RPCMessage packet) { }

	// RVA: 0xC33BB0 Offset: 0xC32FB0 VA: 0x180C33BB0
	public PlayerMetabolism Save() { }

	// RVA: 0xC331F0 Offset: 0xC325F0 VA: 0x180C331F0
	public void Load(PlayerMetabolism s) { }

	// RVA: 0xC33140 Offset: 0xC32540 VA: 0x180C33140 Slot: 12
	public override MetabolismAttribute FindAttribute(MetabolismAttribute.Type type) { }

	// RVA: 0xC33430 Offset: 0xC32830 VA: 0x180C33430
	public void OnLocalMetabolismUpdated() { }

	// RVA: 0xC33E40 Offset: 0xC33240 VA: 0x180C33E40
	public void .ctor() { }

}

public class PlayerModifiers : BaseModifiers<BasePlayer> // TypeDefIndex: 8624
{	// Methods

	// RVA: 0x96D720 Offset: 0x96CB20 VA: 0x18096D720 Slot: 9
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x96D370 Offset: 0x96C770 VA: 0x18096D370
	public void Load(PlayerModifiers m) { }

	// RVA: 0x96D310 Offset: 0x96C710 VA: 0x18096D310
	public void ClientInit(BasePlayer owner) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x96DB70 Offset: 0x96CF70 VA: 0x18096DB70
	public void UpdateModifiers(BaseEntity.RPCMessage packet) { }

	// RVA: 0x96DC50 Offset: 0x96D050 VA: 0x18096DC50
	public void .ctor() { }

}

public class PlayerDetectionTrigger : TriggerBase // TypeDefIndex: 8703
{	// Fields
	public BaseDetector myDetector; // 0x30

	// Methods

	// RVA: 0x4D0250 Offset: 0x4CF650 VA: 0x1804D0250
	public void .ctor() { }

}

public class PlayerModelHair : MonoBehaviour // TypeDefIndex: 9213
{	// Fields
	public HairType type; // 0x18
	private Dictionary<Renderer, PlayerModelHair.RendererMaterials> materials; // 0x20

	// Properties
	public Dictionary<Renderer, PlayerModelHair.RendererMaterials> Materials { get; }

	// Methods

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public Dictionary<Renderer, PlayerModelHair.RendererMaterials> get_Materials() { }

	// RVA: 0xC34110 Offset: 0xC33510 VA: 0x180C34110
	private void CacheOriginalMaterials() { }

	// RVA: 0xC348B0 Offset: 0xC33CB0 VA: 0x180C348B0
	private void Setup(HairType type, HairSetCollection hair, int meshIndex, float typeNum, float dyeNum, MaterialPropertyBlock block) { }

	// RVA: 0xC34510 Offset: 0xC33910 VA: 0x180C34510
	public void Setup(SkinSetCollection skin, float hairNum, float meshNum, MaterialPropertyBlock block) { }

	// RVA: 0xC343F0 Offset: 0xC337F0 VA: 0x180C343F0
	public static void GetRandomVariation(float hairNum, int typeIndex, int meshIndex, out float typeNum, out float dyeNum) { }

	// RVA: 0xC34360 Offset: 0xC33760 VA: 0x180C34360
	public static float GetRandomHairType(float hairNum, int typeIndex) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public struct PlayerModelHair.RendererMaterials // TypeDefIndex: 9214
{	// Fields
	public string[] names; // 0x0
	public Material[] original; // 0x8
	public Material[] replacement; // 0x10

	// Methods

	// RVA: 0xFAB20 Offset: 0xF9F20 VA: 0x1800FAB20
	public void .ctor(Renderer r) { }

}

public class PlayerModelHairCap : MonoBehaviour // TypeDefIndex: 9216
{	// Fields
	[InspectorFlagsAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public HairCapMask hairCapMask; // 0x18

	// Methods

	// RVA: 0x96CE00 Offset: 0x96C200 VA: 0x18096CE00
	public void SetupHairCap(SkinSetCollection skin, float hairNum, float meshNum, MaterialPropertyBlock block) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class PlayerModelSkin : MonoBehaviour, IPrefabPreProcess // TypeDefIndex: 9217
{	// Fields
	public PlayerModelSkin.SkinMaterialType MaterialType; // 0x18
	public Renderer SkinRenderer; // 0x20

	// Methods

	// RVA: 0x96D1D0 Offset: 0x96C5D0 VA: 0x18096D1D0
	public void Setup(SkinSetCollection skin, float hairNum, float meshNum) { }

	// RVA: 0x96D170 Offset: 0x96C570 VA: 0x18096D170 Slot: 4
	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public enum PlayerModelSkin.SkinMaterialType // TypeDefIndex: 9218
{	// Fields
	public int value__; // 0x0
	public const PlayerModelSkin.SkinMaterialType HEAD = 0;
	public const PlayerModelSkin.SkinMaterialType EYE = 1;
	public const PlayerModelSkin.SkinMaterialType BODY = 2;

}

public class PlayerDetectedAIEvent : BaseAIEvent // TypeDefIndex: 9407
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <Range>k__BackingField; // 0x40

	// Properties
	public float Range { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x54D6A0 Offset: 0x54CAA0 VA: 0x18054D6A0
	public float get_Range() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x54D6B0 Offset: 0x54CAB0 VA: 0x18054D6B0
	public void set_Range(float value) { }

	// RVA: 0xC28720 Offset: 0xC27B20 VA: 0x180C28720
	public void .ctor() { }

}

public class PlayerAnimationEvents : MonoBehaviour // TypeDefIndex: 9644
{	// Fields
	private BasePlayer player; // 0x18

	// Methods

	// RVA: 0x8E27E0 Offset: 0x8E1BE0 VA: 0x1808E27E0
	protected void OnEnable() { }

	// RVA: 0x8E2F40 Offset: 0x8E2340 VA: 0x1808E2F40
	public void ThirdPersonReloadSound(AnimationEvent animEvent) { }

	// RVA: 0x8E2DF0 Offset: 0x8E21F0 VA: 0x1808E2DF0
	public void ThirdPersonMeleeAttackSound(AnimationEvent animEvent) { }

	// RVA: 0x8E2B80 Offset: 0x8E1F80 VA: 0x1808E2B80
	public void ThirdPersonDeploySound(AnimationEvent animEvent) { }

	// RVA: 0x8E2CA0 Offset: 0x8E20A0 VA: 0x1808E2CA0
	public void ThirdPersonLiquidThrowSound(AnimationEvent animEvent) { }

	// RVA: 0x8E2880 Offset: 0x8E1C80 VA: 0x1808E2880
	public void PlayThirdPersonSound(SoundDefinition def) { }

	// RVA: 0x8E2930 Offset: 0x8E1D30 VA: 0x1808E2930
	public bool ShouldPlayThirdPersonSounds() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void SleepingEvent(AnimationEvent animEvent) { }

	// RVA: 0x8E2A30 Offset: 0x8E1E30 VA: 0x1808E2A30
	public void SplashEvent(string splashType) { }

	// RVA: 0x8E3200 Offset: 0x8E2600 VA: 0x1808E3200
	public void WaterInflatableMovementSound(string type) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class PlayerBelt // TypeDefIndex: 9645
{	// Fields
	public static int SelectedSlot; // 0x0
	protected BasePlayer player; // 0x10

	// Properties
	public static int MaxBeltSlots { get; }

	// Methods

	// RVA: 0x8E3F40 Offset: 0x8E3340 VA: 0x1808E3F40
	public static int get_MaxBeltSlots() { }

	// RVA: 0x6C0000 Offset: 0x6BF400 VA: 0x1806C0000
	public void .ctor(BasePlayer player) { }

	// RVA: 0x8E3E10 Offset: 0x8E3210 VA: 0x1808E3E10
	public Item GetItemInSlot(int slot) { }

	// RVA: 0x8E3D70 Offset: 0x8E3170 VA: 0x1808E3D70
	public Item GetActiveItem() { }

	// RVA: 0x8E3310 Offset: 0x8E2710 VA: 0x1808E3310
	public bool CanHoldItem() { }

	// RVA: 0x8E3CB0 Offset: 0x8E30B0 VA: 0x1808E3CB0
	public void FrameUpdate() { }

	// RVA: 0x8E3400 Offset: 0x8E2800 VA: 0x1808E3400
	public void ChangeSelect(int iSlot, bool allowRunAction = False) { }

	// RVA: 0x8E3B80 Offset: 0x8E2F80 VA: 0x1808E3B80
	public void DoNextItemDirection(InputState state, int direction) { }

	// RVA: 0x8E36B0 Offset: 0x8E2AB0 VA: 0x1808E36B0
	public void ClientInput(InputState state) { }

	// RVA: 0x8E3F00 Offset: 0x8E3300 VA: 0x1808E3F00
	private static void .cctor() { }

}

public class PlayerBlueprints : EntityComponent<BasePlayer> // TypeDefIndex: 9646
{	// Fields
	public SteamInventory steamInventory; // 0x20
	private int[] craftableItems; // 0x28

	// Methods

	// RVA: 0x8E4240 Offset: 0x8E3640 VA: 0x1808E4240
	public void ClientInit() { }

	// RVA: 0x8E42F0 Offset: 0x8E36F0 VA: 0x1808E42F0
	public void ClientUpdate(PersistantPlayer info) { }

	// RVA: 0x8E43B0 Offset: 0x8E37B0 VA: 0x1808E43B0
	public bool HasUnlocked(ItemDefinition targetItem) { }

	// RVA: 0x8E3F50 Offset: 0x8E3350 VA: 0x1808E3F50
	public bool CanCraft(int itemid, int skinItemId, ulong playerId) { }

	// RVA: 0x8E4140 Offset: 0x8E3540 VA: 0x1808E4140
	public bool CheckSkinOwnership(int skinItemId, ulong playerId) { }

	// RVA: 0x8E47A0 Offset: 0x8E3BA0 VA: 0x1808E47A0
	public void .ctor() { }

}

public class PlayerEyes : EntityComponent<BasePlayer> // TypeDefIndex: 9647
{	// Fields
	public static readonly Vector3 EyeOffset; // 0x0
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

	// Properties
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

	// Methods

	// RVA: 0xC2D890 Offset: 0xC2CC90 VA: 0x180C2D890
	public Vector3 get_worldMountedPosition() { }

	// RVA: 0xC2DA80 Offset: 0xC2CE80 VA: 0x180C2DA80
	public Vector3 get_worldStandingPosition() { }

	// RVA: 0xC2D790 Offset: 0xC2CB90 VA: 0x180C2D790
	public Vector3 get_worldCrouchedPosition() { }

	// RVA: 0xC2D690 Offset: 0xC2CA90 VA: 0x180C2D690
	public Vector3 get_worldCrawlingPosition() { }

	// RVA: 0xC2D150 Offset: 0xC2C550 VA: 0x180C2D150
	public Vector3 get_position() { }

	// RVA: 0xC2C810 Offset: 0xC2BC10 VA: 0x180C2C810
	private Vector3 get_BodyLeanOffset() { }

	// RVA: 0xC2CB70 Offset: 0xC2BF70 VA: 0x180C2CB70
	public Vector3 get_center() { }

	// RVA: 0xC2CE90 Offset: 0xC2C290 VA: 0x180C2CE90
	public Vector3 get_offset() { }

	// RVA: 0xC2D5E0 Offset: 0xC2C9E0 VA: 0x180C2D5E0
	public Quaternion get_rotation() { }

	// RVA: 0xC2DBE0 Offset: 0xC2CFE0 VA: 0x180C2DBE0
	public void set_rotation(Quaternion value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC2CA90 Offset: 0xC2BE90 VA: 0x180C2CA90
	public Quaternion get_bodyRotation() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC2DBB0 Offset: 0xC2CFB0 VA: 0x180C2DBB0
	public void set_bodyRotation(Quaternion value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC2CE70 Offset: 0xC2C270 VA: 0x180C2CE70
	public Vector3 get_headAngles() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC2DBC0 Offset: 0xC2CFC0 VA: 0x180C2DBC0
	public void set_headAngles(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC2D5D0 Offset: 0xC2C9D0 VA: 0x180C2D5D0
	public Quaternion get_rotationLook() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC2DBD0 Offset: 0xC2CFD0 VA: 0x180C2DBD0
	public void set_rotationLook(Quaternion value) { }

	// RVA: 0xC2CFC0 Offset: 0xC2C3C0 VA: 0x180C2CFC0
	public Quaternion get_parentRotation() { }

	// RVA: 0xC2CAA0 Offset: 0xC2BEA0 VA: 0x180C2CAA0
	public bool get_canUpdateViewAngles() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC2CA80 Offset: 0xC2BE80 VA: 0x180C2CA80
	public bool get_IsAltLookingLegsThreshold() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC2DBA0 Offset: 0xC2CFA0 VA: 0x180C2DBA0
	private void set_IsAltLookingLegsThreshold(bool value) { }

	// RVA: 0xC2B3A0 Offset: 0xC2A7A0 VA: 0x180C2B3A0
	public void FrameUpdate(Camera cam) { }

	// RVA: 0xC2C430 Offset: 0xC2B830 VA: 0x180C2C430
	public void UpdateAltLegsThreshold(float yAngle) { }

	// RVA: 0xC2C4A0 Offset: 0xC2B8A0 VA: 0x180C2C4A0
	private void UpdateCamera(Camera cam) { }

	// RVA: 0xC29480 Offset: 0xC28880 VA: 0x180C29480
	private void DoFirstPersonCamera(Camera cam) { }

	// RVA: 0xC29AD0 Offset: 0xC28ED0 VA: 0x180C29AD0
	private void DoInEyeCamera(Camera cam) { }

	// RVA: 0xC29E20 Offset: 0xC29220 VA: 0x180C29E20
	private void DoThirdPersonCamera(Camera cam) { }

	// RVA: 0xC28EA0 Offset: 0xC282A0 VA: 0x180C28EA0
	private void DoDeathCamera(Camera cam) { }

	// RVA: 0xC28870 Offset: 0xC27C70 VA: 0x180C28870
	private void ApplyCameraMoves(Camera cam) { }

	// RVA: 0xC2C0B0 Offset: 0xC2B4B0 VA: 0x180C2C0B0
	public Vector3 MovementForward() { }

	// RVA: 0xC2C270 Offset: 0xC2B670 VA: 0x180C2C270
	public Vector3 MovementRight() { }

	// RVA: 0xC28A50 Offset: 0xC27E50 VA: 0x180C28A50
	public Ray BodyRay() { }

	// RVA: 0xC28900 Offset: 0xC27D00 VA: 0x180C28900
	public Vector3 BodyForward() { }

	// RVA: 0xC28C00 Offset: 0xC28000 VA: 0x180C28C00
	public Vector3 BodyRight() { }

	// RVA: 0xC28D50 Offset: 0xC28150 VA: 0x180C28D50
	public Vector3 BodyUp() { }

	// RVA: 0xC2BCF0 Offset: 0xC2B0F0 VA: 0x180C2BCF0
	public Ray HeadRay() { }

	// RVA: 0xC2BC00 Offset: 0xC2B000 VA: 0x180C2BC00
	public Vector3 HeadForward() { }

	// RVA: 0xC2BED0 Offset: 0xC2B2D0 VA: 0x180C2BED0
	public Vector3 HeadRight() { }

	// RVA: 0xC2BFC0 Offset: 0xC2B3C0 VA: 0x180C2BFC0
	public Vector3 HeadUp() { }

	// RVA: 0xC2BA80 Offset: 0xC2AE80 VA: 0x180C2BA80
	public Quaternion GetLookRotation() { }

	// RVA: 0xC2B9C0 Offset: 0xC2ADC0 VA: 0x180C2B9C0
	public Quaternion GetAimRotation() { }

	// RVA: 0xC2C750 Offset: 0xC2BB50 VA: 0x180C2C750
	public void .ctor() { }

	// RVA: 0xC2C650 Offset: 0xC2BA50 VA: 0x180C2C650
	private static void .cctor() { }

}

public class PlayerInput : EntityComponent<BasePlayer> // TypeDefIndex: 9648
{	// Fields
	public InputState state; // 0x20
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

	// Properties
	private bool hasOnlyPartialKeyInput { get; }
	public static bool hasNoKeyInput { get; }

	// Methods

	// RVA: 0xC30A90 Offset: 0xC2FE90 VA: 0x180C30A90
	protected void OnDisable() { }

	// RVA: 0xC2FC60 Offset: 0xC2F060 VA: 0x180C2FC60
	public void FrameUpdate() { }

	// RVA: 0xC2F680 Offset: 0xC2EA80 VA: 0x180C2F680
	private bool CanToggleAds() { }

	// RVA: 0xC2FAF0 Offset: 0xC2EEF0 VA: 0x180C2FAF0
	private void Flip() { }

	// RVA: 0xC30B10 Offset: 0xC2FF10 VA: 0x180C30B10
	public void ResetMouseDelta() { }

	// RVA: 0xC2DEE0 Offset: 0xC2D2E0 VA: 0x180C2DEE0
	private void AddMouseDelta() { }

	// RVA: 0xC2E1B0 Offset: 0xC2D5B0 VA: 0x180C2E1B0
	private void AdjustMouseMovement(ref Vector2 mm) { }

	// RVA: 0xC30D10 Offset: 0xC30110 VA: 0x180C30D10
	private void UpdateViewAngles() { }

	// RVA: 0xC2E3F0 Offset: 0xC2D7F0 VA: 0x180C2E3F0
	public void ApplyViewAngles() { }

	// RVA: 0xC30BF0 Offset: 0xC2FFF0 VA: 0x180C30BF0
	public void SetViewVars(Vector3 newAngles) { }

	// RVA: 0xC2F910 Offset: 0xC2ED10 VA: 0x180C2F910
	public void FinalizeRecoil() { }

	// RVA: 0xC30B80 Offset: 0xC2FF80 VA: 0x180C30B80
	public void ResetOffsetAngles() { }

	// RVA: 0xC2F8E0 Offset: 0xC2ECE0 VA: 0x180C2F8E0
	public Quaternion ClientAngles() { }

	// RVA: 0xC2F8F0 Offset: 0xC2ECF0 VA: 0x180C2F8F0
	public Vector3 ClientLookVars() { }

	// RVA: 0xC1F280 Offset: 0xC1E680 VA: 0x180C1F280
	public Quaternion HeadAngles() { }

	// RVA: 0xC30090 Offset: 0xC2F490 VA: 0x180C30090
	public Vector3 HeadLookVars() { }

	// RVA: 0xC30A00 Offset: 0xC2FE00 VA: 0x180C30A00
	private void ModifyInputState(InputMessage state) { }

	// RVA: 0xC30500 Offset: 0xC2F900 VA: 0x180C30500
	internal bool IsButtonDownNative(BUTTON btn) { }

	// RVA: 0xC2EF90 Offset: 0xC2E390 VA: 0x180C2EF90
	private InputMessage BuildInputState(bool allowModify = True) { }

	// RVA: 0xC303B0 Offset: 0xC2F7B0 VA: 0x180C303B0
	private bool IsAiming() { }

	// RVA: 0xC30C80 Offset: 0xC30080 VA: 0x180C30C80
	private void UpdateButton(InputMessage state, BUTTON btn) { }

	// RVA: 0xC300B0 Offset: 0xC2F4B0 VA: 0x180C300B0
	public void IgnoreCurrentButtons() { }

	// RVA: 0xC31000 Offset: 0xC30400 VA: 0x180C31000
	private bool get_hasOnlyPartialKeyInput() { }

	// RVA: 0xC30E70 Offset: 0xC30270 VA: 0x180C30E70
	public static bool get_hasNoKeyInput() { }

	// RVA: 0xC30CF0 Offset: 0xC300F0 VA: 0x180C30CF0
	private void UpdateKeyFocus(bool hasFocus) { }

	// RVA: 0xC301C0 Offset: 0xC2F5C0 VA: 0x180C301C0
	public static void IgnoreCurrentKeys() { }

	// RVA: 0xC30E00 Offset: 0xC30200 VA: 0x180C30E00
	public void .ctor() { }

}

public class PlayerModel : ListComponent<PlayerModel>, IOnParentDestroying // TypeDefIndex: 9649
{	// Fields
	public static float pm_uplimit; // 0x0
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

	// Properties
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

	// Methods

	// RVA: 0xC3E1D0 Offset: 0xC3D5D0 VA: 0x180C3E1D0
	public void SetMountedLookAtOverride(bool state) { }

	// RVA: 0xC3E5F0 Offset: 0xC3D9F0 VA: 0x180C3E5F0
	private void SpineIk() { }

	// RVA: 0xC3C3E0 Offset: 0xC3B7E0 VA: 0x180C3C3E0
	private void ParentArmsToCamera() { }

	// RVA: 0xC3BA50 Offset: 0xC3AE50 VA: 0x180C3BA50
	private void OnAnimatorIK() { }

	// RVA: 0xC3A0B0 Offset: 0xC394B0 VA: 0x180C3A0B0
	private void HandIK(float cameraDistSq) { }

	// RVA: 0xC368C0 Offset: 0xC35CC0 VA: 0x180C368C0
	private void FootIK(float cameraDistSq) { }

	// RVA: 0xC3A510 Offset: 0xC39910 VA: 0x180C3A510
	private void HeadIK(float cameraDistSq) { }

	// RVA: 0xC43EE0 Offset: 0xC432E0 VA: 0x180C43EE0
	public bool get_ShouldDoLegs() { }

	// RVA: 0xC43F60 Offset: 0xC43360 VA: 0x180C43F60
	public bool get_ShouldShowHands() { }

	// RVA: 0xC35560 Offset: 0xC34960 VA: 0x180C35560
	private void ClearLegs() { }

	// RVA: 0xC3CD90 Offset: 0xC3C190 VA: 0x180C3CD90
	public void RebuildLegs() { }

	// RVA: 0xC3ABF0 Offset: 0xC39FF0 VA: 0x180C3ABF0
	private void InitializeLegSpineBones() { }

	// RVA: 0xC3FE00 Offset: 0xC3F200 VA: 0x180C3FE00
	private void UpdateLegsBeforeRender() { }

	// RVA: 0xC40CF0 Offset: 0xC400F0 VA: 0x180C40CF0
	private void UpdateLegsDisable(bool forceDisable = False) { }

	// RVA: 0xC34A90 Offset: 0xC33E90 VA: 0x180C34A90
	private void AddLegRenderer(SkinnedMeshRenderer renderer, PaintableItem paintable) { }

	// RVA: 0xC3EFE0 Offset: 0xC3E3E0 VA: 0x180C3EFE0
	private Transform SwapLegBone(Transform bone) { }

	// RVA: 0xC39520 Offset: 0xC38920 VA: 0x180C39520
	private static Vector3 GetFlat(Vector3 dir) { }

	// RVA: 0xC3C990 Offset: 0xC3BD90 VA: 0x180C3C990
	public static void RebuildAll() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC44240 Offset: 0xC43640 VA: 0x180C44240
	public ulong get_overrideSkinSeed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC44280 Offset: 0xC43680 VA: 0x180C44280
	private void set_overrideSkinSeed(ulong value) { }

	// RVA: 0xC43E90 Offset: 0xC43290 VA: 0x180C43E90
	public bool get_IsFemale() { }

	// RVA: 0xC44040 Offset: 0xC43440 VA: 0x180C44040
	public SkinSetCollection get_SkinSet() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC43D40 Offset: 0xC43140 VA: 0x180C43D40
	public Quaternion get_AimAngles() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC44250 Offset: 0xC43650 VA: 0x180C44250
	public void set_AimAngles(Quaternion value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC43ED0 Offset: 0xC432D0 VA: 0x180C43ED0
	public Quaternion get_LookAngles() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC44270 Offset: 0xC43670 VA: 0x180C44270
	public void set_LookAngles(Quaternion value) { }

	// RVA: 0xC43DF0 Offset: 0xC431F0 VA: 0x180C43DF0
	private bool get_GestureAllowsSpineMovement() { }

	// RVA: 0xC43D50 Offset: 0xC43150 VA: 0x180C43D50
	private bool get_GestureAllowsRootMotion() { }

	// RVA: 0xC43EA0 Offset: 0xC432A0 VA: 0x180C43EA0
	public bool get_IsFirstPerson() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC43EC0 Offset: 0xC432C0 VA: 0x180C43EC0
	public bool get_IsNpc() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC44260 Offset: 0xC43660 VA: 0x180C44260
	public void set_IsNpc(bool value) { }

	// RVA: 0xC441A0 Offset: 0xC435A0 VA: 0x180C441A0
	public SkinnedMultiMesh get_multiMesh() { }

	// RVA: 0xC44060 Offset: 0xC43460 VA: 0x180C44060
	public Animator get_animator() { }

	// RVA: 0xC44100 Offset: 0xC43500 VA: 0x180C44100
	public LODGroup get_lodGroup() { }

	// RVA: 0xC39F50 Offset: 0xC39350 VA: 0x180C39F50
	public Vector3 GetTargetVelocity() { }

	// RVA: 0xC354C0 Offset: 0xC348C0 VA: 0x180C354C0
	protected void Awake() { }

	// RVA: 0xC3BE70 Offset: 0xC3B270 VA: 0x180C3BE70 Slot: 6
	protected override void OnEnable() { }

	// RVA: 0xC3BB80 Offset: 0xC3AF80 VA: 0x180C3BB80 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0xC3DAB0 Offset: 0xC3CEB0 VA: 0x180C3DAB0
	private void SetDefaultAnimatorWeights() { }

	// RVA: 0xC41390 Offset: 0xC40790 VA: 0x180C41390
	private void UpdateMultiMesh(bool reset) { }

	// RVA: 0xC3F520 Offset: 0xC3E920 VA: 0x180C3F520
	private void UpdateCensorship() { }

	// RVA: 0xC3F9A0 Offset: 0xC3EDA0 VA: 0x180C3F9A0
	public void UpdateCollider(bool visible, bool sleeping, bool ducking, bool crawling, bool incapacitated) { }

	// RVA: 0xC41340 Offset: 0xC40740 VA: 0x180C41340
	public void UpdateModelState(ModelState ms) { }

	// RVA: 0xC41E00 Offset: 0xC41200 VA: 0x180C41E00
	public void UpdatePosition() { }

	// RVA: 0xC41F20 Offset: 0xC41320 VA: 0x180C41F20
	internal void UpdateRotation() { }

	// RVA: 0xC41270 Offset: 0xC40670 VA: 0x180C41270
	public void UpdateLocalVelocity(Vector3 velocity, Transform parent) { }

	// RVA: 0xC428A0 Offset: 0xC41CA0 VA: 0x180C428A0
	public void UpdateVelocity() { }

	// RVA: 0xC41520 Offset: 0xC40920 VA: 0x180C41520
	private void UpdateParameters() { }

	// RVA: 0xC3FC10 Offset: 0xC3F010 VA: 0x180C3FC10
	public void UpdateFrom(PlayerModel mdl) { }

	// RVA: 0xC3FC70 Offset: 0xC3F070 VA: 0x180C3FC70
	private void UpdateGlobalShaderConstants() { }

	// RVA: 0xC3B3D0 Offset: 0xC3A7D0 VA: 0x180C3B3D0
	public void LateCycle() { }

	// RVA: 0xC38B30 Offset: 0xC37F30 VA: 0x180C38B30
	public void FrameUpdate() { }

	// RVA: 0xC38150 Offset: 0xC37550 VA: 0x180C38150
	private void FrameUpdate_Default() { }

	// RVA: 0xC38860 Offset: 0xC37C60 VA: 0x180C38860
	private void FrameUpdate_Sleeping() { }

	// RVA: 0xC382C0 Offset: 0xC376C0 VA: 0x180C382C0
	private void FrameUpdate_Incapacitated() { }

	// RVA: 0xC38590 Offset: 0xC37990 VA: 0x180C38590
	private void FrameUpdate_OnLadder() { }

	// RVA: 0xC392B0 Offset: 0xC386B0 VA: 0x180C392B0
	public float GetAim360() { }

	// RVA: 0xC423B0 Offset: 0xC417B0 VA: 0x180C423B0
	public void UpdateVehicleAim360() { }

	// RVA: 0xC3D960 Offset: 0xC3CD60 VA: 0x180C3D960
	public void ResetCurrentState(int layer = 0) { }

	// RVA: 0xC36060 Offset: 0xC35460 VA: 0x180C36060
	private void DoAimingSounds(float prevAiming, float currentAiming) { }

	// RVA: 0xC3DA70 Offset: 0xC3CE70 VA: 0x180C3DA70
	public void SetAimSounds(SoundDefinition aimDef, SoundDefinition aimEndDef) { }

	// RVA: 0xC3E1E0 Offset: 0xC3D5E0 VA: 0x180C3E1E0
	public void SetMountedLookAtWeight(float weight) { }

	// RVA: 0xC3E1C0 Offset: 0xC3D5C0 VA: 0x180C3E1C0
	public void SetMountedAnimationSpeed(float speed) { }

	// RVA: 0xC40F20 Offset: 0xC40320 VA: 0x180C40F20
	internal void UpdateLocalPlayerPosition(Vector3 position, Quaternion quaternion) { }

	// RVA: 0xC35440 Offset: 0xC34840 VA: 0x180C35440
	public void Attack() { }

	// RVA: 0xC35100 Offset: 0xC34500 VA: 0x180C35100
	public void AltAttack() { }

	// RVA: 0xC35FB0 Offset: 0xC353B0 VA: 0x180C35FB0
	public void Deploy() { }

	// RVA: 0xC3D6E0 Offset: 0xC3CAE0 VA: 0x180C3D6E0
	public void Reload() { }

	// RVA: 0xC3AB70 Offset: 0xC39F70 VA: 0x180C3AB70
	public void Holster() { }

	// RVA: 0xC36860 Offset: 0xC35C60 VA: 0x180C36860
	public void Flinch(uint location) { }

	// RVA: 0xC36890 Offset: 0xC35C90 VA: 0x180C36890
	public void Flinch() { }

	// RVA: 0xC3E1F0 Offset: 0xC3D5F0 VA: 0x180C3E1F0
	public void SetReactionAnim(PlayerModel.ReactionDir direction, float weight) { }

	// RVA: 0xC3C3B0 Offset: 0xC3B7B0 VA: 0x180C3C3B0
	public void OnReactionEnded() { }

	// RVA: 0xC3F310 Offset: 0xC3E710 VA: 0x180C3F310
	public void Throw() { }

	// RVA: 0xC38F20 Offset: 0xC38320 VA: 0x180C38F20
	public void Gesture(string gesture, GestureConfig forConfig) { }

	// RVA: 0xC362C0 Offset: 0xC356C0 VA: 0x180C362C0
	private void FadeInGestureUpperBodyLayer() { }

	// RVA: 0xC365B0 Offset: 0xC359B0 VA: 0x180C365B0
	private void FadeOutGestureUpperBodyLayer() { }

	// RVA: 0xC361A0 Offset: 0xC355A0 VA: 0x180C361A0
	private void FadeInGestureFullBodyLayer() { }

	// RVA: 0xC363E0 Offset: 0xC357E0 VA: 0x180C363E0
	private void FadeOutGestureFullBodyLayer() { }

	// RVA: 0xC351B0 Offset: 0xC345B0 VA: 0x180C351B0
	private void AnimatorWarmup() { }

	// RVA: 0xC35180 Offset: 0xC34580 VA: 0x180C35180
	public void AlwaysAnimate(bool b) { }

	// RVA: 0xC3DE40 Offset: 0xC3D240 VA: 0x180C3DE40
	public void SetHoldType(RuntimeAnimatorController holdType, bool suppressHandLayer = False) { }

	// RVA: 0xC3DE30 Offset: 0xC3D230 VA: 0x180C3DE30
	public void SetHasHeldEntity(bool state) { }

	[IteratorStateMachineAttribute] // RVA: 0x80770 Offset: 0x7FB70 VA: 0x180080770
	// RVA: 0xC36540 Offset: 0xC35940 VA: 0x180C36540
	public IEnumerator FadeOutGestureLayer() { }

	// RVA: 0xC3DBE0 Offset: 0xC3CFE0 VA: 0x180C3DBE0
	public void SetGesture() { }

	// RVA: 0xC36710 Offset: 0xC35B10 VA: 0x180C36710
	public void FadeOutPlayerGestureLayers() { }

	// RVA: 0xC3EEE0 Offset: 0xC3E2E0 VA: 0x180C3EEE0
	public void StopGesture() { }

	// RVA: 0xC3C800 Offset: 0xC3BC00 VA: 0x180C3C800
	public void PlayCinematic(string name, float overrideSpeed = 1) { }

	// RVA: 0xC3EE80 Offset: 0xC3E280 VA: 0x180C3EE80
	public void StopCinematic() { }

	// RVA: 0xC3E5D0 Offset: 0xC3D9D0 VA: 0x180C3E5D0
	public void SetSpeedOverride(Vector3 speed) { }

	// RVA: 0xC39E90 Offset: 0xC39290 VA: 0x180C39E90
	public Underwear GetReplacementUnderwear() { }

	// RVA: 0xC3D830 Offset: 0xC3CC30 VA: 0x180C3D830
	public void RemoveUnderwearParts(SkinReplacement.SkinType typeToRemove) { }

	// RVA: 0xC356C0 Offset: 0xC34AC0 VA: 0x180C356C0
	public void Clear() { }

	// RVA: 0xC3D150 Offset: 0xC3C550 VA: 0x180C3D150
	public void Rebuild(bool reset = True) { }

	// RVA: 0xC34E20 Offset: 0xC34220 VA: 0x180C34E20
	public void AddPart(string strName, Item item) { }

	// RVA: 0xC3D760 Offset: 0xC3CB60 VA: 0x180C3D760
	public void RemovePart(string strName) { }

	// RVA: 0xC3A450 Offset: 0xC39850 VA: 0x180C3A450
	public bool HasPart(string strName) { }

	// RVA: 0xC3B340 Offset: 0xC3A740 VA: 0x180C3B340
	public bool IsBarefoot() { }

	// RVA: 0xC39ED0 Offset: 0xC392D0 VA: 0x180C39ED0
	public Color GetSkinColor() { }

	// RVA: 0xC3E4B0 Offset: 0xC3D8B0 VA: 0x180C3E4B0
	public void SetSkinProperties(MaterialPropertyBlock block) { }

	// RVA: 0xC3D350 Offset: 0xC3C750 VA: 0x180C3D350
	public void RefreshUnderwear() { }

	// RVA: 0xC37F20 Offset: 0xC37320 VA: 0x180C37F20
	public void ForceModelSeed(ulong userID) { }

	// RVA: 0xC38030 Offset: 0xC37430 VA: 0x180C38030
	public void ForceModelSeed(ulong userID, bool storeSkinChange) { }

	// RVA: 0xC36830 Offset: 0xC35C30 VA: 0x180C36830
	public Transform FindBone(string strName) { }

	// RVA: 0xC394F0 Offset: 0xC388F0 VA: 0x180C394F0
	public Transform[] GetBones() { }

	// RVA: 0xC39560 Offset: 0xC38960 VA: 0x180C39560
	private Vector3 GetFootPlacement(Vector3 footPos, out Vector3 surfaceNormal) { }

	// RVA: 0xC35210 Offset: 0xC34610 VA: 0x180C35210
	public void ApplyVisibility(bool vis, bool animatorVis, bool shadowVis) { }

	// RVA: 0xC3F3B0 Offset: 0xC3E7B0 VA: 0x180C3F3B0
	public void ToggleUpdateOffscreen(bool state) { }

	// RVA: 0xC3C2B0 Offset: 0xC3B6B0 VA: 0x180C3C2B0 Slot: 8
	public void OnParentDestroying() { }

	// RVA: 0xC42CB0 Offset: 0xC420B0 VA: 0x180C42CB0
	public void WorkshopPreviewSetup(GameObject[] objects) { }

	// RVA: 0xC43B90 Offset: 0xC42F90 VA: 0x180C43B90
	public void .ctor() { }

	// RVA: 0xC43650 Offset: 0xC42A50 VA: 0x180C43650
	private static void .cctor() { }

}

public enum PlayerModel.MountPoses // TypeDefIndex: 9650
{	// Fields
	public int value__; // 0x0
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
{	// Fields
	public int value__; // 0x0
	public const PlayerModel.ReactionDir North = 0;
	public const PlayerModel.ReactionDir South = 1;
	public const PlayerModel.ReactionDir East = 2;
	public const PlayerModel.ReactionDir West = 3;

}

private sealed class PlayerModel.<>c // TypeDefIndex: 9652
{	// Fields
	public static readonly PlayerModel.<>c <>9; // 0x0
	public static Func<Wearable, bool> <>9__199_0; // 0x8
	public static Func<Wearable, bool> <>9__199_1; // 0x10
	public static Func<Wearable, bool> <>9__199_2; // 0x18

	// Methods

	// RVA: 0xC446D0 Offset: 0xC43AD0 VA: 0x180C446D0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xC44670 Offset: 0xC43A70 VA: 0x180C44670
	internal bool <UpdateCensorship>b__199_0(Wearable x) { }

	// RVA: 0xC44690 Offset: 0xC43A90 VA: 0x180C44690
	internal bool <UpdateCensorship>b__199_1(Wearable x) { }

	// RVA: 0xC446B0 Offset: 0xC43AB0 VA: 0x180C446B0
	internal bool <UpdateCensorship>b__199_2(Wearable y) { }

}

private sealed class PlayerModel.<FadeOutGestureLayer>d__244 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9653
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PlayerModel <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xC44290 Offset: 0xC43690 VA: 0x180C44290 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC44620 Offset: 0xC43A20 VA: 0x180C44620 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class PlayerModel.<>c__DisplayClass256_0 // TypeDefIndex: 9654
{	// Fields
	public string strName; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x5DDF80 Offset: 0x5DD380 VA: 0x1805DDF80
	internal bool <RemovePart>b__0(SkinnedMultiMesh.Part x) { }

}

private sealed class PlayerModel.<>c__DisplayClass257_0 // TypeDefIndex: 9655
{	// Fields
	public string strName; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x5DDF80 Offset: 0x5DD380 VA: 0x1805DDF80
	internal bool <HasPart>b__0(SkinnedMultiMesh.Part x) { }

}

public class PlayerModelCinematicList : PrefabAttribute, IClientComponent // TypeDefIndex: 9656
{	// Fields
	public PlayerModelCinematicList.PlayerModelCinematicAnimation[] Animations; // 0x98

	// Methods

	// RVA: 0xC34020 Offset: 0xC33420 VA: 0x180C34020 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0xC34080 Offset: 0xC33480 VA: 0x180C34080 Slot: 5
	public override void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0xC340B0 Offset: 0xC334B0 VA: 0x180C340B0
	public void .ctor() { }

}

public struct PlayerModelCinematicList.PlayerModelCinematicAnimation // TypeDefIndex: 9657
{	// Fields
	public string StateName; // 0x0
	public string ClipName; // 0x8
	public float Length; // 0x10

}

public class PlayerModelReactionEnded : StateMachineBehaviour // TypeDefIndex: 9658
{	// Fields
	private PlayerModel playerModel; // 0x18

	// Methods

	// RVA: 0x96D070 Offset: 0x96C470 VA: 0x18096D070 Slot: 4
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x6A7040 Offset: 0x6A6440 VA: 0x1806A7040
	public void .ctor() { }

}

public class PlayerNameTag : MonoBehaviour // TypeDefIndex: 9659
{	// Fields
	public CanvasGroup canvasGroup; // 0x18
	public Text text; // 0x20
	public Gradient color; // 0x28
	public float minDistance; // 0x30
	public float maxDistance; // 0x34
	public Vector3 positionOffset; // 0x38
	public Transform parentBone; // 0x48
	private float distanceFromCamera; // 0x50
	internal string lastName; // 0x58

	// Methods

	// RVA: 0x96DC90 Offset: 0x96D090 VA: 0x18096DC90
	public void Initialize(BasePlayer player, Transform parent) { }

	// RVA: 0x96E1B0 Offset: 0x96D5B0 VA: 0x18096E1B0
	public void UpdateFrom(BasePlayer player) { }

	// RVA: 0x96DF40 Offset: 0x96D340 VA: 0x18096DF40
	private void LateUpdate() { }

	// RVA: 0x96E310 Offset: 0x96D710 VA: 0x18096E310
	private void UpdateNameColor() { }

	// RVA: 0x96E090 Offset: 0x96D490 VA: 0x18096E090
	public void PositionUpdate(bool visible) { }

	// RVA: 0x96E560 Offset: 0x96D960 VA: 0x18096E560
	public void .ctor() { }

}

public class PlayerVoiceRecorder : EntityComponent<BasePlayer> // TypeDefIndex: 9661
{	// Fields
	internal static byte[] readBuffer; // 0x0
	internal static byte[] readBufferUncompressed; // 0x8
	private RealTimeSince timeSinceLastSpeak; // 0x20
	private RealTimeSince timeSinceLastCheck; // 0x24
	private Stopwatch TalkTimer; // 0x28

	// Properties
	public bool IsSpeaking { get; }

	// Methods

	// RVA: 0x96F440 Offset: 0x96E840 VA: 0x18096F440
	public bool get_IsSpeaking() { }

	// RVA: 0x96E6A0 Offset: 0x96DAA0 VA: 0x18096E6A0
	public void ClientFrame(BasePlayer player) { }

	// RVA: 0x96EC60 Offset: 0x96E060 VA: 0x18096EC60
	public void ClientInput(InputState state) { }

	// RVA: 0x96EDD0 Offset: 0x96E1D0 VA: 0x18096EDD0
	private bool DoesUserWantToTalk() { }

	// RVA: 0x96E5C0 Offset: 0x96D9C0 VA: 0x18096E5C0
	public bool CanTalk() { }

	// RVA: 0x96F150 Offset: 0x96E550 VA: 0x18096F150
	public void StopRecording() { }

	// RVA: 0x96EFA0 Offset: 0x96E3A0 VA: 0x18096EFA0
	public void StartRecording() { }

	// RVA: 0x96F3D0 Offset: 0x96E7D0 VA: 0x18096F3D0
	public void .ctor() { }

	// RVA: 0x96F350 Offset: 0x96E750 VA: 0x18096F350
	private static void .cctor() { }

}

public class PlayerVoiceSpeaker : EntityComponent<BasePlayer> // TypeDefIndex: 9662
{	// Fields
	public VoiceProcessor voiceProcessor; // 0x20
	private float nextSpeechFakeChange; // 0x28
	private float speechFakeChangeMulti; // 0x2C
	private bool isFakingVolume; // 0x30
	private float fakedVolume; // 0x34
	private static bool hasAwardedRecordVoicesAchievement; // 0x0

	// Properties
	public float currentVolume { get; }

	// Methods

	// RVA: 0x970470 Offset: 0x96F870 VA: 0x180970470
	public float get_currentVolume() { }

	// RVA: 0x96FCD0 Offset: 0x96F0D0 VA: 0x18096FCD0
	public bool IsSpeaking() { }

	// RVA: 0x96FD60 Offset: 0x96F160 VA: 0x18096FD60
	public void Receive(byte[] data) { }

	// RVA: 0x96F960 Offset: 0x96ED60 VA: 0x18096F960
	public float GetMouthVolume() { }

	// RVA: 0x96F470 Offset: 0x96E870 VA: 0x18096F470
	public void ClientFrame() { }

	// RVA: 0x9700F0 Offset: 0x96F4F0 VA: 0x1809700F0
	public bool ShouldMuteVoice() { }

	// RVA: 0x96FBD0 Offset: 0x96EFD0 VA: 0x18096FBD0
	private bool IsPlayingLocalVoice() { }

	// RVA: 0x970210 Offset: 0x96F610 VA: 0x180970210
	public bool ShouldReceiveVoice() { }

	// RVA: 0x970430 Offset: 0x96F830 VA: 0x180970430
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

public class PlayerWalkMovement : BaseMovement // TypeDefIndex: 9668
{	// Fields
	public const float WaterLevelHead = 0,75;
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

	// Methods

	// RVA: 0x970550 Offset: 0x96F950 VA: 0x180970550
	protected void Awake() { }

	// RVA: 0x972280 Offset: 0x971680 VA: 0x180972280 Slot: 6
	public override Collider GetCollider() { }

	// RVA: 0x975440 Offset: 0x974840 VA: 0x180975440
	protected void OnDisable() { }

	// RVA: 0x972C70 Offset: 0x972070 VA: 0x180972C70 Slot: 7
	public override void Init(BasePlayer player) { }

	// RVA: 0x975280 Offset: 0x974680 VA: 0x180975280
	protected void OnCollisionEnter(Collision collision) { }

	// RVA: 0x975360 Offset: 0x974760 VA: 0x180975360
	protected void OnCollisionStay(Collision collision) { }

	// RVA: 0x972430 Offset: 0x971830 VA: 0x180972430
	private void GroundCheck(Collision collision) { }

	// RVA: 0x975AF0 Offset: 0x974EF0 VA: 0x180975AF0 Slot: 13
	public override void TeleportTo(Vector3 position, BasePlayer player) { }

	// RVA: 0x975E20 Offset: 0x975220 VA: 0x180975E20
	public void UpdateCurrentLadder(InputState input, bool force = False) { }

	// RVA: 0x976E90 Offset: 0x976290 VA: 0x180976E90
	public static bool WantsSprint(InputState input) { }

	// RVA: 0x970840 Offset: 0x96FC40 VA: 0x180970840 Slot: 10
	public override void ClientInput(InputState input, ModelState modelState) { }

	// RVA: 0x9746D0 Offset: 0x973AD0 VA: 0x1809746D0
	private void Movement_Water(InputState input, ModelState modelState) { }

	// RVA: 0x9737B0 Offset: 0x972BB0 VA: 0x1809737B0
	private void Movement_Mounted(InputState input, ModelState modelState) { }

	// RVA: 0x973160 Offset: 0x972560 VA: 0x180973160
	private void Movement_Ladder(InputState input, ModelState modelState) { }

	// RVA: 0x9738C0 Offset: 0x972CC0 VA: 0x1809738C0
	private void Movement_Noclip(InputState input, ModelState modelState) { }

	// RVA: 0x973E50 Offset: 0x973250 VA: 0x180973E50
	private void Movement_Walking(InputState input, ModelState modelState) { }

	// RVA: 0x972380 Offset: 0x971780 VA: 0x180972380
	private float GetHeldEntityMovementMultiplier() { }

	// RVA: 0x972700 Offset: 0x971B00 VA: 0x180972700
	private void HandleGrounded(ModelState state, bool wantsGrounded) { }

	// RVA: 0x972880 Offset: 0x971C80 VA: 0x180972880
	private void HandleRunDuckCrawl(ModelState state, bool wantsRun, bool wantsDuck, bool wantsCrawl) { }

	// RVA: 0x972290 Offset: 0x971690 VA: 0x180972290
	private float GetForcedDuck() { }

	// RVA: 0x972750 Offset: 0x971B50 VA: 0x180972750
	private void HandleJumping(ModelState state, bool wantsJump, bool jumpInDirection = False) { }

	// RVA: 0x9706C0 Offset: 0x96FAC0 VA: 0x1809706C0
	private bool CanJump() { }

	// RVA: 0x970630 Offset: 0x96FA30 VA: 0x180970630 Slot: 8
	public override void BlockJump(float duration) { }

	// RVA: 0x970670 Offset: 0x96FA70 VA: 0x180970670 Slot: 9
	public override void BlockSprint(float duration) { }

	// RVA: 0x9758C0 Offset: 0x974CC0 VA: 0x1809758C0
	public void SetKinematic(bool kinematic) { }

	// RVA: 0x970510 Offset: 0x96F910 VA: 0x180970510
	public void ApplyForce(Vector3 force) { }

	// RVA: 0x9707D0 Offset: 0x96FBD0 VA: 0x1809707D0
	private bool CanSprint() { }

	// RVA: 0x972E40 Offset: 0x972240 VA: 0x180972E40
	private void Jump(ModelState state, bool inDirection) { }

	// RVA: 0x970BF0 Offset: 0x96FFF0 VA: 0x180970BF0 Slot: 11
	public override void DoFixedUpdate(ModelState modelState) { }

	// RVA: 0x971410 Offset: 0x970810 VA: 0x180971410
	public void DoStepUp() { }

	// RVA: 0x976340 Offset: 0x975740 VA: 0x180976340
	private void UpdateVelocity() { }

	// RVA: 0x975FF0 Offset: 0x9753F0 VA: 0x180975FF0
	private void UpdateGravity(ModelState modelState) { }

	// RVA: 0x971DE0 Offset: 0x9711E0 VA: 0x180971DE0 Slot: 12
	public override void FrameUpdate(BasePlayer player, ModelState state) { }

	// RVA: 0x975C10 Offset: 0x975010 VA: 0x180975C10
	private void TransformState(Matrix4x4 matrix) { }

	// RVA: 0x9758F0 Offset: 0x974CF0 VA: 0x1809758F0 Slot: 15
	public override void SetParent(Transform parent) { }

	// RVA: 0x971D30 Offset: 0x971130 VA: 0x180971D30
	private Vector3 FallVelocity() { }

	// RVA: 0x970BB0 Offset: 0x96FFB0 VA: 0x180970BB0 Slot: 4
	public override Vector3 CurrentVelocity() { }

	// RVA: 0x970B60 Offset: 0x96FF60 VA: 0x180970B60 Slot: 5
	public override float CurrentMoveSpeed() { }

	// RVA: 0x975860 Offset: 0x974C60 VA: 0x180975860 Slot: 16
	public override void PlayerAttemptedMount() { }

	// RVA: 0x975890 Offset: 0x974C90 VA: 0x180975890 Slot: 17
	public override void PlayerCompletedMount() { }

	// RVA: 0x976F20 Offset: 0x976320 VA: 0x180976F20
	public void .ctor() { }

}

public class PlayerCorpse : LootableCorpse // TypeDefIndex: 9669
{	// Fields
	public Buoyancy buoyancy; // 0x2D0
	public const BaseEntity.Flags Flag_Buoyant = 16384;
	public uint underwearSkin; // 0x2D8
	private ItemContainer clientClothing; // 0x2E0
	private uint lastClothes; // 0x2E8

	// Methods

	// RVA: 0x5717B0 Offset: 0x570BB0 VA: 0x1805717B0
	public bool IsBuoyant() { }

	// RVA: 0xC27ED0 Offset: 0xC272D0 VA: 0x180C27ED0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xC281C0 Offset: 0xC275C0 VA: 0x180C281C0
	private void RebuildWorldModel() { }

	// RVA: 0xC27EF0 Offset: 0xC272F0 VA: 0x180C27EF0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xC28080 Offset: 0xC27480 VA: 0x180C28080 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0xC285E0 Offset: 0xC279E0 VA: 0x180C285E0
	private void ToggleClientBuoyancy(bool isBuoyant) { }

	// RVA: 0xC27EA0 Offset: 0xC272A0 VA: 0x180C27EA0 Slot: 122
	public override string Categorize() { }

	// RVA: 0xC28700 Offset: 0xC27B00 VA: 0x180C28700
	public void .ctor() { }

}

public class PlayerInventoryProperties : ScriptableObject // TypeDefIndex: 10748
{	// Fields
	public string niceName; // 0x18
	public int order; // 0x20
	public List<PlayerInventoryProperties.ItemAmountSkinned> belt; // 0x28
	public List<PlayerInventoryProperties.ItemAmountSkinned> main; // 0x30
	public List<PlayerInventoryProperties.ItemAmountSkinned> wear; // 0x38
	public PlayerInventoryProperties giveBase; // 0x40

	// Methods

	// RVA: 0xC31060 Offset: 0xC30460 VA: 0x180C31060
	public void .ctor() { }

}

public class PlayerInventoryProperties.ItemAmountSkinned : ItemAmount // TypeDefIndex: 10749
{	// Fields
	public ulong skinOverride; // 0x20

	// Methods

	// RVA: 0xC27E90 Offset: 0xC27290 VA: 0x180C27E90
	public void .ctor() { }

}

public class PlayerDetectedEventUI : BaseEventUI // TypeDefIndex: 10806
{	// Methods

	// RVA: 0x84F880 Offset: 0x84EC80 VA: 0x18084F880 Slot: 4
	public override void Init(AIEventType eventType, BaseStateUI stateUI) { }

	// RVA: 0xC287C0 Offset: 0xC27BC0 VA: 0x180C287C0 Slot: 5
	public override AIEventData Save() { }

	// RVA: 0xC28750 Offset: 0xC27B50 VA: 0x180C28750 Slot: 6
	public override void Load(AIEventData data) { }

	// RVA: 0x4B7D40 Offset: 0x4B7140 VA: 0x1804B7D40
	public void .ctor() { }

}

public class Player : ConsoleSystem // TypeDefIndex: 11949
{	// Fields
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
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

	// Methods

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x366DD0 Offset: 0x3661D0 VA: 0x180366DD0
	public static void cinematic_list(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x367530 Offset: 0x366930 VA: 0x180367530
	public static void gesture(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x367670 Offset: 0x366A70 VA: 0x180367670
	public static void petcmd(ConsoleSystem.Arg arg) { }

	[ServerUserVar] // RVA: 0xB0810 Offset: 0xAFC10 VA: 0x1800B0810
	[ClientVar] // RVA: 0xB0810 Offset: 0xAFC10 VA: 0x1800B0810
	// RVA: 0x367260 Offset: 0x366660 VA: 0x180367260
	public static void cinematic_play(ConsoleSystem.Arg arg) { }

	[ServerUserVar] // RVA: 0xB0810 Offset: 0xAFC10 VA: 0x1800B0810
	[ClientVar] // RVA: 0xB0810 Offset: 0xAFC10 VA: 0x1800B0810
	// RVA: 0x367430 Offset: 0x366830 VA: 0x180367430
	public static void cinematic_stop(ConsoleSystem.Arg arg) { }

	// RVA: 0x366D70 Offset: 0x366170 VA: 0x180366D70
	public void .ctor() { }

	// RVA: 0x366C40 Offset: 0x366040 VA: 0x180366C40
	private static void .cctor() { }

}

public class PlayerCull : ConsoleSystem // TypeDefIndex: 11950
{	// Fields
	private static bool _enabled; // 0x0
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

	// Properties
	[ClientVar] // RVA: 0xB2090 Offset: 0xB1490 VA: 0x1800B2090
	public static bool enabled { get; set; }

	// Methods

	// RVA: 0x366A30 Offset: 0x365E30 VA: 0x180366A30
	public static bool get_enabled() { }

	// RVA: 0x366A90 Offset: 0x365E90 VA: 0x180366A90
	public static void set_enabled(bool value) { }

	// RVA: 0x3669D0 Offset: 0x365DD0 VA: 0x1803669D0
	public void .ctor() { }

	// RVA: 0x366920 Offset: 0x365D20 VA: 0x180366920
	private static void .cctor() { }

}

public enum PlayerMenuAnimation.Layers // TypeDefIndex: 12147
{
// Namespace: 
public enum PlayerMenuAnimation.Layers // TypeDefIndex: 12147
	// Fields
	public int value__; // 0x0
	public const PlayerMenuAnimation.Layers Movement = 0;

}

