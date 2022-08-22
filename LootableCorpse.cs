public class LootableCorpse : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6300
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public LootableCorpse.Private privateData; // 0x18
	public ulong playerID; // 0x20
	public string playerName; // 0x28
	public uint underwearSkin; // 0x30


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

public class LootableCorpse.Private : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6301
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<ItemContainer> container; // 0x18


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

public class LootableCorpse : BaseCorpse, LootPanel.IHasLootPanel // TypeDefIndex: 8405
{	private Option __menuOption_Menu_Open; // 0x260
	public string lootPanelName; // 0x2B8
	public ulong playerSteamID; // 0x2C0
	public string _playerName; // 0x2C8

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

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void RPC_ClientLootCorpse(BaseEntity.RPCMessage rpc) { }

	[BaseEntity.Menu] // RVA: 0xDA000 Offset: 0xD9400 VA: 0x1800DA000
	[BaseEntity.Menu.Description] // RVA: 0xDA000 Offset: 0xD9400 VA: 0x1800DA000
	[BaseEntity.Menu.Icon] // RVA: 0xDA000 Offset: 0xD9400 VA: 0x1800DA000
	public void Menu_Open(BasePlayer player) { }

	public void .ctor() { }

}

