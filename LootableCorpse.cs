public class LootableCorpse : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6300
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public LootableCorpse.Private privateData; // 0x18
	public ulong playerID; // 0x20
	public string playerName; // 0x28
	public uint underwearSkin; // 0x30

	// Methods

	// RVA: 0x1F20B40 Offset: 0x1F1FF40 VA: 0x181F20B40
	public static void ResetToPool(LootableCorpse instance) { }

	// RVA: 0x1F20A40 Offset: 0x1F1FE40 VA: 0x181F20A40
	public void ResetToPool() { }

	// RVA: 0x1F20890 Offset: 0x1F1FC90 VA: 0x181F20890 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F1F960 Offset: 0x1F1ED60 VA: 0x181F1F960
	public void CopyTo(LootableCorpse instance) { }

	// RVA: 0x1F1FA60 Offset: 0x1F1EE60 VA: 0x181F1FA60
	public LootableCorpse Copy() { }

	// RVA: 0x1F20450 Offset: 0x1F1F850 VA: 0x181F20450
	public static LootableCorpse Deserialize(Stream stream) { }

	// RVA: 0x1F1FBB0 Offset: 0x1F1EFB0 VA: 0x181F1FBB0
	public static LootableCorpse DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F202C0 Offset: 0x1F1F6C0 VA: 0x181F202C0
	public static LootableCorpse DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F204D0 Offset: 0x1F1F8D0 VA: 0x181F204D0
	public static LootableCorpse Deserialize(byte[] buffer) { }

	// RVA: 0x1F20A00 Offset: 0x1F1FE00 VA: 0x181F20A00
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F21350 Offset: 0x1F20750 VA: 0x181F21350 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F21370 Offset: 0x1F20770 VA: 0x181F21370 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, LootableCorpse previous) { }

	// RVA: 0x1F20A20 Offset: 0x1F1FE20 VA: 0x181F20A20 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F20350 Offset: 0x1F1F750 VA: 0x181F20350
	public static LootableCorpse Deserialize(byte[] buffer, LootableCorpse instance, bool isDelta = False) { }

	// RVA: 0x1F205F0 Offset: 0x1F1F9F0 VA: 0x181F205F0
	public static LootableCorpse Deserialize(Stream stream, LootableCorpse instance, bool isDelta) { }

	// RVA: 0x1F1FC30 Offset: 0x1F1F030 VA: 0x181F1FC30
	public static LootableCorpse DeserializeLengthDelimited(Stream stream, LootableCorpse instance, bool isDelta) { }

	// RVA: 0x1F1FF90 Offset: 0x1F1F390 VA: 0x181F1FF90
	public static LootableCorpse DeserializeLength(Stream stream, int length, LootableCorpse instance, bool isDelta) { }

	// RVA: 0x1F20C40 Offset: 0x1F20040 VA: 0x181F20C40
	public static void SerializeDelta(Stream stream, LootableCorpse instance, LootableCorpse previous) { }

	// RVA: 0x1F210D0 Offset: 0x1F204D0 VA: 0x181F210D0
	public static void Serialize(Stream stream, LootableCorpse instance) { }

	// RVA: 0x1F21340 Offset: 0x1F20740 VA: 0x181F21340
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F21350 Offset: 0x1F20750 VA: 0x181F21350
	public void ToProto(Stream stream) { }

	// RVA: 0x1F20FC0 Offset: 0x1F203C0 VA: 0x181F20FC0
	public static byte[] SerializeToBytes(LootableCorpse instance) { }

	// RVA: 0x1F20F10 Offset: 0x1F20310 VA: 0x181F20F10
	public static void SerializeLengthDelimited(Stream stream, LootableCorpse instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class LootableCorpse.Private : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6301
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<ItemContainer> container; // 0x18

	// Methods

	// RVA: 0x1F27140 Offset: 0x1F26540 VA: 0x181F27140
	public static void ResetToPool(LootableCorpse.Private instance) { }

	// RVA: 0x1F26F90 Offset: 0x1F26390 VA: 0x181F26F90
	public void ResetToPool() { }

	// RVA: 0x1F26ED0 Offset: 0x1F262D0 VA: 0x181F26ED0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F261B0 Offset: 0x1F255B0 VA: 0x181F261B0
	public void CopyTo(LootableCorpse.Private instance) { }

	// RVA: 0x1F26340 Offset: 0x1F25740 VA: 0x181F26340
	public LootableCorpse.Private Copy() { }

	// RVA: 0x1F26D30 Offset: 0x1F26130 VA: 0x181F26D30
	public static LootableCorpse.Private Deserialize(Stream stream) { }

	// RVA: 0x1F263C0 Offset: 0x1F257C0 VA: 0x181F263C0
	public static LootableCorpse.Private DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F269B0 Offset: 0x1F25DB0 VA: 0x181F269B0
	public static LootableCorpse.Private DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F26DB0 Offset: 0x1F261B0 VA: 0x181F26DB0
	public static LootableCorpse.Private Deserialize(byte[] buffer) { }

	// RVA: 0x1F26F50 Offset: 0x1F26350 VA: 0x181F26F50
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F27880 Offset: 0x1F26C80 VA: 0x181F27880 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F278A0 Offset: 0x1F26CA0 VA: 0x181F278A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, LootableCorpse.Private previous) { }

	// RVA: 0x1F26F70 Offset: 0x1F26370 VA: 0x181F26F70 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F26A40 Offset: 0x1F25E40 VA: 0x181F26A40
	public static LootableCorpse.Private Deserialize(byte[] buffer, LootableCorpse.Private instance, bool isDelta = False) { }

	// RVA: 0x1F26B40 Offset: 0x1F25F40 VA: 0x181F26B40
	public static LootableCorpse.Private Deserialize(Stream stream, LootableCorpse.Private instance, bool isDelta) { }

	// RVA: 0x1F26440 Offset: 0x1F25840 VA: 0x181F26440
	public static LootableCorpse.Private DeserializeLengthDelimited(Stream stream, LootableCorpse.Private instance, bool isDelta) { }

	// RVA: 0x1F26710 Offset: 0x1F25B10 VA: 0x181F26710
	public static LootableCorpse.Private DeserializeLength(Stream stream, int length, LootableCorpse.Private instance, bool isDelta) { }

	// RVA: 0x1F272F0 Offset: 0x1F266F0 VA: 0x181F272F0
	public static void SerializeDelta(Stream stream, LootableCorpse.Private instance, LootableCorpse.Private previous) { }

	// RVA: 0x1F27690 Offset: 0x1F26A90 VA: 0x181F27690
	public static void Serialize(Stream stream, LootableCorpse.Private instance) { }

	// RVA: 0x1F27870 Offset: 0x1F26C70 VA: 0x181F27870
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F27880 Offset: 0x1F26C80 VA: 0x181F27880
	public void ToProto(Stream stream) { }

	// RVA: 0x1F27580 Offset: 0x1F26980 VA: 0x181F27580
	public static byte[] SerializeToBytes(LootableCorpse.Private instance) { }

	// RVA: 0x1F274D0 Offset: 0x1F268D0 VA: 0x181F274D0
	public static void SerializeLengthDelimited(Stream stream, LootableCorpse.Private instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class LootableCorpse : BaseCorpse, LootPanel.IHasLootPanel // TypeDefIndex: 8405
{	// Fields
	private Option __menuOption_Menu_Open; // 0x260
	public string lootPanelName; // 0x2B8
	public ulong playerSteamID; // 0x2C0
	public string _playerName; // 0x2C8

	// Properties
	public override bool HasMenuOptions { get; }
	public virtual string playerName { get; set; }
	public Translate.Phrase LootPanelTitle { get; }
	public Translate.Phrase LootPanelName { get; }

	// Methods

	// RVA: 0x56B4B0 Offset: 0x56A8B0 VA: 0x18056B4B0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x56B7F0 Offset: 0x56ABF0 VA: 0x18056B7F0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x56BDD0 Offset: 0x56B1D0 VA: 0x18056BDD0 Slot: 146
	public virtual string get_playerName() { }

	// RVA: 0x56BDF0 Offset: 0x56B1F0 VA: 0x18056BDF0 Slot: 147
	public virtual void set_playerName(string value) { }

	// RVA: 0x56BDA0 Offset: 0x56B1A0 VA: 0x18056BDA0 Slot: 145
	public Translate.Phrase get_LootPanelTitle() { }

	// RVA: 0x56BD60 Offset: 0x56B160 VA: 0x18056BD60
	public Translate.Phrase get_LootPanelName() { }

	// RVA: 0x56B730 Offset: 0x56AB30 VA: 0x18056B730 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x56BC90 Offset: 0x56B090 VA: 0x18056BC90
	private void RPC_ClientLootCorpse(BaseEntity.RPCMessage rpc) { }

	[BaseEntity.Menu] // RVA: 0xDA000 Offset: 0xD9400 VA: 0x1800DA000
	[BaseEntity.Menu.Description] // RVA: 0xDA000 Offset: 0xD9400 VA: 0x1800DA000
	[BaseEntity.Menu.Icon] // RVA: 0xDA000 Offset: 0xD9400 VA: 0x1800DA000
	// RVA: 0x56B7B0 Offset: 0x56ABB0 VA: 0x18056B7B0
	public void Menu_Open(BasePlayer player) { }

	// RVA: 0x56BD10 Offset: 0x56B110 VA: 0x18056BD10
	public void .ctor() { }

}

