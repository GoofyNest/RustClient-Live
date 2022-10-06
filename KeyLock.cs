public class KeyLock : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6309
{
	public bool ShouldPool; 
	private bool _disposed; 
	public int code; 


	public static void ResetToPool(KeyLock instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(KeyLock instance) { }

	public KeyLock Copy() { }

	public static KeyLock Deserialize(Stream stream) { }

	public static KeyLock DeserializeLengthDelimited(Stream stream) { }

	public static KeyLock DeserializeLength(Stream stream, int length) { }

	public static KeyLock Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, KeyLock previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static KeyLock Deserialize(byte[] buffer, KeyLock instance, bool isDelta = False) { }

	public static KeyLock Deserialize(Stream stream, KeyLock instance, bool isDelta) { }

	public static KeyLock DeserializeLengthDelimited(Stream stream, KeyLock instance, bool isDelta) { }

	public static KeyLock DeserializeLength(Stream stream, int length, KeyLock instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, KeyLock instance, KeyLock previous) { }

	public static void Serialize(Stream stream, KeyLock instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(KeyLock instance) { }

	public static void SerializeLengthDelimited(Stream stream, KeyLock instance) { }

	public void .ctor() { }

}

public class KeyLock : BaseLock // TypeDefIndex: 10106
{
	private Option __menuOption_Menu_CreateKey; 
	private Option __menuOption_Menu_Lock; 
	private Option __menuOption_Menu_Unlock; 
	[ItemSelector] 
	public ItemDefinition keyItemType; 

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

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
	public void Menu_CreateKey(BasePlayer player) { }

	public void Menu_CreateKey_Proxy(ref Option option) { }

	public void .ctor() { }

}

