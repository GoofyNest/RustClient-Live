public class KeyLock : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6305
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int code; // 0x14

	// Methods

	// RVA: 0x1F17020 Offset: 0x1F16420 VA: 0x181F17020
	public static void ResetToPool(KeyLock instance) { }

	// RVA: 0x1F16FA0 Offset: 0x1F163A0 VA: 0x181F16FA0
	public void ResetToPool() { }

	// RVA: 0x1F16E70 Offset: 0x1F16270 VA: 0x181F16E70 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BF9250 Offset: 0x1BF8650 VA: 0x181BF9250
	public void CopyTo(KeyLock instance) { }

	// RVA: 0x1F164F0 Offset: 0x1F158F0 VA: 0x181F164F0
	public KeyLock Copy() { }

	// RVA: 0x1F16A90 Offset: 0x1F15E90 VA: 0x181F16A90
	public static KeyLock Deserialize(Stream stream) { }

	// RVA: 0x1F16560 Offset: 0x1F15960 VA: 0x181F16560
	public static KeyLock DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F16800 Offset: 0x1F15C00 VA: 0x181F16800
	public static KeyLock DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F16C10 Offset: 0x1F16010 VA: 0x181F16C10
	public static KeyLock Deserialize(byte[] buffer) { }

	// RVA: 0x1F16F60 Offset: 0x1F16360 VA: 0x181F16F60
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F174F0 Offset: 0x1F168F0 VA: 0x181F174F0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F175C0 Offset: 0x1F169C0 VA: 0x181F175C0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, KeyLock previous) { }

	// RVA: 0x1F16F80 Offset: 0x1F16380 VA: 0x181F16F80 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F16B10 Offset: 0x1F15F10 VA: 0x181F16B10
	public static KeyLock Deserialize(byte[] buffer, KeyLock instance, bool isDelta = False) { }

	// RVA: 0x1F16D30 Offset: 0x1F16130 VA: 0x181F16D30
	public static KeyLock Deserialize(Stream stream, KeyLock instance, bool isDelta) { }

	// RVA: 0x1F165E0 Offset: 0x1F159E0 VA: 0x181F165E0
	public static KeyLock DeserializeLengthDelimited(Stream stream, KeyLock instance, bool isDelta) { }

	// RVA: 0x1F16890 Offset: 0x1F15C90 VA: 0x181F16890
	public static KeyLock DeserializeLength(Stream stream, int length, KeyLock instance, bool isDelta) { }

	// RVA: 0x1F170A0 Offset: 0x1F164A0 VA: 0x181F170A0
	public static void SerializeDelta(Stream stream, KeyLock instance, KeyLock previous) { }

	// RVA: 0x1F17410 Offset: 0x1F16810 VA: 0x181F17410
	public static void Serialize(Stream stream, KeyLock instance) { }

	// RVA: 0x1F174E0 Offset: 0x1F168E0 VA: 0x181F174E0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F174F0 Offset: 0x1F168F0 VA: 0x181F174F0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F17260 Offset: 0x1F16660 VA: 0x181F17260
	public static byte[] SerializeToBytes(KeyLock instance) { }

	// RVA: 0x1F171B0 Offset: 0x1F165B0 VA: 0x181F171B0
	public static void SerializeLengthDelimited(Stream stream, KeyLock instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class KeyLock : BaseLock // TypeDefIndex: 8401
{	// Fields
	private Option __menuOption_Menu_CreateKey; // 0x1C8
	private Option __menuOption_Menu_Lock; // 0x220
	private Option __menuOption_Menu_Unlock; // 0x278
	[ItemSelector] // RVA: 0xA7410 Offset: 0xA6810 VA: 0x1800A7410
	public ItemDefinition keyItemType; // 0x2D0

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x6B5D30 Offset: 0x6B5130 VA: 0x1806B5D30 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x6B66B0 Offset: 0x6B5AB0 VA: 0x1806B66B0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0xE9530 Offset: 0xE8930 VA: 0x1800E9530
	[BaseEntity.Menu.Description] // RVA: 0xE9530 Offset: 0xE8930 VA: 0x1800E9530
	[BaseEntity.Menu.Icon] // RVA: 0xE9530 Offset: 0xE8930 VA: 0x1800E9530
	[BaseEntity.Menu.ShowIf] // RVA: 0xE9530 Offset: 0xE8930 VA: 0x1800E9530
	// RVA: 0x6B6670 Offset: 0x6B5A70 VA: 0x1806B6670
	public void Menu_Unlock(BasePlayer player) { }

	// RVA: 0x6B6660 Offset: 0x6B5A60 VA: 0x1806B6660
	public bool Menu_Unlock_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE9960 Offset: 0xE8D60 VA: 0x1800E9960
	[BaseEntity.Menu.Description] // RVA: 0xE9960 Offset: 0xE8D60 VA: 0x1800E9960
	[BaseEntity.Menu.Icon] // RVA: 0xE9960 Offset: 0xE8D60 VA: 0x1800E9960
	[BaseEntity.Menu.ShowIf] // RVA: 0xE9960 Offset: 0xE8D60 VA: 0x1800E9960
	// RVA: 0x6B6620 Offset: 0x6B5A20 VA: 0x1806B6620
	public void Menu_Lock(BasePlayer player) { }

	// RVA: 0x6B6600 Offset: 0x6B5A00 VA: 0x1806B6600
	public bool Menu_Lock_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xE9BA0 Offset: 0xE8FA0 VA: 0x1800E9BA0
	[BaseEntity.Menu.Description] // RVA: 0xE9BA0 Offset: 0xE8FA0 VA: 0x1800E9BA0
	[BaseEntity.Menu.Icon] // RVA: 0xE9BA0 Offset: 0xE8FA0 VA: 0x1800E9BA0
	// RVA: 0x6B65C0 Offset: 0x6B59C0 VA: 0x1806B65C0
	public void Menu_CreateKey(BasePlayer player) { }

	// RVA: 0x6B64E0 Offset: 0x6B58E0 VA: 0x1806B64E0
	public void Menu_CreateKey_Proxy(ref Option option) { }

	// RVA: 0x594990 Offset: 0x593D90 VA: 0x180594990
	public void .ctor() { }

}

