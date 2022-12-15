public class CodeLock : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6315
{
	public bool ShouldPool;
	private bool _disposed;
	public CodeLock.Private pv;
	public bool hasCode;
	public bool hasGuestCode;


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

public class CodeLock.Private : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6316
{
	public bool ShouldPool;
	private bool _disposed;
	public string code;
	public List<ulong> users;
	public string guestCode;
	public List<ulong> guestUsers;


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

public class CodeLock : BaseLock // TypeDefIndex: 10096
{
	private Option __menuOption_Menu_ChangeGuestCode;
	private Option __menuOption_Menu_ChangeLockCode;
	private Option __menuOption_Menu_Lock;
	private Option __menuOption_Menu_Unlock;
	public GameObjectRef keyEnterDialog;
	public GameObjectRef effectUnlocked;
	public GameObjectRef effectLocked;
	public GameObjectRef effectDenied;
	public GameObjectRef effectCodeChanged;
	public GameObjectRef effectShock;
	private bool hasCode;
	public const BaseEntity.Flags Flag_CodeEntryBlocked = 524288;
	public static readonly Translate.Phrase blockwarning;

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public bool IsCodeEntryBlocked() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.ShowIf]
	public void Menu_Unlock(BasePlayer player) { }

	public bool Menu_Unlock_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.ShowIf]
	public void Menu_Lock(BasePlayer player) { }

	public bool Menu_Lock_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.ShowIf]
	public void Menu_ChangeLockCode(BasePlayer player) { }

	public bool Menu_ChangeLockCode_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.ShowIf]
	public void Menu_ChangeGuestCode(BasePlayer player) { }

	public bool Menu_ChangeGuestCode_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client]
	private void EnterUnlockCode(BaseEntity.RPCMessage rpc) { }

	public void .ctor() { }

	private static void .cctor() { }

	[CompilerGeneratedAttribute]
	private void <Menu_ChangeLockCode>

	[CompilerGeneratedAttribute]
	private void <Menu_ChangeGuestCode>

	[CompilerGeneratedAttribute]
	private void <EnterUnlockCode>

}

