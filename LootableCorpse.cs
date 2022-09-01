public class LootableCorpse : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6301
{
	public bool ShouldPool; 
	private bool _disposed; 
	public LootableCorpse.Private privateData; 
	public ulong playerID; 
	public string playerName; 
	public uint underwearSkin; 


	public static void ResetToPool(LootableCorpse instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(LootableCorpse instance) { }

	public LootableCorpse Copy() { }

	public static LootableCorpse Deserialize(Stream stream) { }

	public static LootableCorpse DeserializeLengthDelimited(Stream stream) { }

	public static LootableCorpse DeserializeLength(Stream stream, int length) { }

	public static LootableCorpse Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, LootableCorpse previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static LootableCorpse Deserialize(byte[] buffer, LootableCorpse instance, bool isDelta = False) { }

	public static LootableCorpse Deserialize(Stream stream, LootableCorpse instance, bool isDelta) { }

	public static LootableCorpse DeserializeLengthDelimited(Stream stream, LootableCorpse instance, bool isDelta) { }

	public static LootableCorpse DeserializeLength(Stream stream, int length, LootableCorpse instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, LootableCorpse instance, LootableCorpse previous) { }

	public static void Serialize(Stream stream, LootableCorpse instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(LootableCorpse instance) { }

	public static void SerializeLengthDelimited(Stream stream, LootableCorpse instance) { }

	public void .ctor() { }

}

public class LootableCorpse.Private : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6302
{
	public bool ShouldPool; 
	private bool _disposed; 
	public List<ItemContainer> container; 


	public static void ResetToPool(LootableCorpse.Private instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(LootableCorpse.Private instance) { }

	public LootableCorpse.Private Copy() { }

	public static LootableCorpse.Private Deserialize(Stream stream) { }

	public static LootableCorpse.Private DeserializeLengthDelimited(Stream stream) { }

	public static LootableCorpse.Private DeserializeLength(Stream stream, int length) { }

	public static LootableCorpse.Private Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, LootableCorpse.Private previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static LootableCorpse.Private Deserialize(byte[] buffer, LootableCorpse.Private instance, bool isDelta = False) { }

	public static LootableCorpse.Private Deserialize(Stream stream, LootableCorpse.Private instance, bool isDelta) { }

	public static LootableCorpse.Private DeserializeLengthDelimited(Stream stream, LootableCorpse.Private instance, bool isDelta) { }

	public static LootableCorpse.Private DeserializeLength(Stream stream, int length, LootableCorpse.Private instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, LootableCorpse.Private instance, LootableCorpse.Private previous) { }

	public static void Serialize(Stream stream, LootableCorpse.Private instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(LootableCorpse.Private instance) { }

	public static void SerializeLengthDelimited(Stream stream, LootableCorpse.Private instance) { }

	public void .ctor() { }

}

public class LootableCorpse : BaseCorpse, LootPanel.IHasLootPanel // TypeDefIndex: 8407
{
	private Option __menuOption_Menu_Open; 
	public string lootPanelName; 
	public ulong playerSteamID; 
	public string _playerName; 

	public override bool HasMenuOptions { get; }
	public virtual string playerName { get; set; }
	public Translate.Phrase LootPanelTitle { get; }
	public Translate.Phrase LootPanelName { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public virtual string get_playerName() { }

	public virtual void set_playerName(string value) { }

	public Translate.Phrase get_LootPanelTitle() { }

	public Translate.Phrase get_LootPanelName() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.RPC_Client] 
	private void RPC_ClientLootCorpse(BaseEntity.RPCMessage rpc) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	public void Menu_Open(BasePlayer player) { }

	public void .ctor() { }

}

