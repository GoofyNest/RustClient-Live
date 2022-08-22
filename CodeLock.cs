public class CodeLock : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6306
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public CodeLock.Private pv; // 0x18
	public bool hasCode; // 0x20
	public bool hasGuestCode; // 0x21


	public static void ResetToPool(CodeLock instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(CodeLock instance) { }

	public CodeLock Copy() { }

	public static CodeLock Deserialize(Stream stream) { }

	public static CodeLock DeserializeLengthDelimited(Stream stream) { }

	public static CodeLock DeserializeLength(Stream stream, int length) { }

	public static CodeLock Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, CodeLock previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static CodeLock Deserialize(byte[] buffer, CodeLock instance, bool isDelta = False) { }

	public static CodeLock Deserialize(Stream stream, CodeLock instance, bool isDelta) { }

	public static CodeLock DeserializeLengthDelimited(Stream stream, CodeLock instance, bool isDelta) { }

	public static CodeLock DeserializeLength(Stream stream, int length, CodeLock instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, CodeLock instance, CodeLock previous) { }

	public static void Serialize(Stream stream, CodeLock instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(CodeLock instance) { }

	public static void SerializeLengthDelimited(Stream stream, CodeLock instance) { }

	public void .ctor() { }

}

public class CodeLock.Private : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6307
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string code; // 0x18
	public List<ulong> users; // 0x20
	public string guestCode; // 0x28
	public List<ulong> guestUsers; // 0x30


	public static void ResetToPool(CodeLock.Private instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(CodeLock.Private instance) { }

	public CodeLock.Private Copy() { }

	public static CodeLock.Private Deserialize(Stream stream) { }

	public static CodeLock.Private DeserializeLengthDelimited(Stream stream) { }

	public static CodeLock.Private DeserializeLength(Stream stream, int length) { }

	public static CodeLock.Private Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, CodeLock.Private previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static CodeLock.Private Deserialize(byte[] buffer, CodeLock.Private instance, bool isDelta = False) { }

	public static CodeLock.Private Deserialize(Stream stream, CodeLock.Private instance, bool isDelta) { }

	public static CodeLock.Private DeserializeLengthDelimited(Stream stream, CodeLock.Private instance, bool isDelta) { }

	public static CodeLock.Private DeserializeLength(Stream stream, int length, CodeLock.Private instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, CodeLock.Private instance, CodeLock.Private previous) { }

	public static void Serialize(Stream stream, CodeLock.Private instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(CodeLock.Private instance) { }

	public static void SerializeLengthDelimited(Stream stream, CodeLock.Private instance) { }

	public void .ctor() { }

}

public class CodeLock : BaseLock // TypeDefIndex: 8373
{	private Option __menuOption_Menu_ChangeGuestCode; // 0x1C8
	private Option __menuOption_Menu_ChangeLockCode; // 0x220
	private Option __menuOption_Menu_Lock; // 0x278
	private Option __menuOption_Menu_Unlock; // 0x2D0
	public GameObjectRef keyEnterDialog; // 0x328
	public GameObjectRef effectUnlocked; // 0x330
	public GameObjectRef effectLocked; // 0x338
	public GameObjectRef effectDenied; // 0x340
	public GameObjectRef effectCodeChanged; // 0x348
	public GameObjectRef effectShock; // 0x350
	private bool hasCode; // 0x358
	public const BaseEntity.Flags Flag_CodeEntryBlocked = 524288;
	public static readonly Translate.Phrase blockwarning; // 0x0

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public bool IsCodeEntryBlocked() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0xD3CB0 Offset: 0xD30B0 VA: 0x1800D3CB0
	[BaseEntity.Menu.Description] // RVA: 0xD3CB0 Offset: 0xD30B0 VA: 0x1800D3CB0
	[BaseEntity.Menu.Icon] // RVA: 0xD3CB0 Offset: 0xD30B0 VA: 0x1800D3CB0
	[BaseEntity.Menu.ShowIf] // RVA: 0xD3CB0 Offset: 0xD30B0 VA: 0x1800D3CB0
	public void Menu_Unlock(BasePlayer player) { }

	public bool Menu_Unlock_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xD5210 Offset: 0xD4610 VA: 0x1800D5210
	[BaseEntity.Menu.Description] // RVA: 0xD5210 Offset: 0xD4610 VA: 0x1800D5210
	[BaseEntity.Menu.Icon] // RVA: 0xD5210 Offset: 0xD4610 VA: 0x1800D5210
	[BaseEntity.Menu.ShowIf] // RVA: 0xD5210 Offset: 0xD4610 VA: 0x1800D5210
	public void Menu_Lock(BasePlayer player) { }

	public bool Menu_Lock_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xD5450 Offset: 0xD4850 VA: 0x1800D5450
	[BaseEntity.Menu.Description] // RVA: 0xD5450 Offset: 0xD4850 VA: 0x1800D5450
	[BaseEntity.Menu.Icon] // RVA: 0xD5450 Offset: 0xD4850 VA: 0x1800D5450
	[BaseEntity.Menu.ShowIf] // RVA: 0xD5450 Offset: 0xD4850 VA: 0x1800D5450
	public void Menu_ChangeLockCode(BasePlayer player) { }

	public bool Menu_ChangeLockCode_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xD5690 Offset: 0xD4A90 VA: 0x1800D5690
	[BaseEntity.Menu.Description] // RVA: 0xD5690 Offset: 0xD4A90 VA: 0x1800D5690
	[BaseEntity.Menu.Icon] // RVA: 0xD5690 Offset: 0xD4A90 VA: 0x1800D5690
	[BaseEntity.Menu.ShowIf] // RVA: 0xD5690 Offset: 0xD4A90 VA: 0x1800D5690
	public void Menu_ChangeGuestCode(BasePlayer player) { }

	public bool Menu_ChangeGuestCode_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void EnterUnlockCode(BaseEntity.RPCMessage rpc) { }

	public void .ctor() { }

	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <Menu_ChangeLockCode>b__23_0(string str) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <Menu_ChangeGuestCode>b__25_0(string str) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <EnterUnlockCode>b__27_0(string str) { }

}

