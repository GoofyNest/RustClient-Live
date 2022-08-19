public class CodeLock : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6306
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public CodeLock.Private pv; // 0x18
	public bool hasCode; // 0x20
	public bool hasGuestCode; // 0x21

	// Methods

	// RVA: 0x20A9CC0 Offset: 0x20A90C0 VA: 0x1820A9CC0
	public static void ResetToPool(CodeLock instance) { }

	// RVA: 0x20A9D80 Offset: 0x20A9180 VA: 0x1820A9D80
	public void ResetToPool() { }

	// RVA: 0x20A9B40 Offset: 0x20A8F40 VA: 0x1820A9B40 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20A8D60 Offset: 0x20A8160 VA: 0x1820A8D60
	public void CopyTo(CodeLock instance) { }

	// RVA: 0x20A8E50 Offset: 0x20A8250 VA: 0x1820A8E50
	public CodeLock Copy() { }

	// RVA: 0x20A9AC0 Offset: 0x20A8EC0 VA: 0x1820A9AC0
	public static CodeLock Deserialize(Stream stream) { }

	// RVA: 0x20A8F90 Offset: 0x20A8390 VA: 0x1820A8F90
	public static CodeLock DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20A95E0 Offset: 0x20A89E0 VA: 0x1820A95E0
	public static CodeLock DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20A99A0 Offset: 0x20A8DA0 VA: 0x1820A99A0
	public static CodeLock Deserialize(byte[] buffer) { }

	// RVA: 0x20A9C80 Offset: 0x20A9080 VA: 0x1820A9C80
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20AA440 Offset: 0x20A9840 VA: 0x1820AA440 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20AA460 Offset: 0x20A9860 VA: 0x1820AA460 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CodeLock previous) { }

	// RVA: 0x20A9CA0 Offset: 0x20A90A0 VA: 0x1820A9CA0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20A98A0 Offset: 0x20A8CA0 VA: 0x1820A98A0
	public static CodeLock Deserialize(byte[] buffer, CodeLock instance, bool isDelta = False) { }

	// RVA: 0x20A9670 Offset: 0x20A8A70 VA: 0x1820A9670
	public static CodeLock Deserialize(Stream stream, CodeLock instance, bool isDelta) { }

	// RVA: 0x20A9010 Offset: 0x20A8410 VA: 0x1820A9010
	public static CodeLock DeserializeLengthDelimited(Stream stream, CodeLock instance, bool isDelta) { }

	// RVA: 0x20A9310 Offset: 0x20A8710 VA: 0x1820A9310
	public static CodeLock DeserializeLength(Stream stream, int length, CodeLock instance, bool isDelta) { }

	// RVA: 0x20A9E40 Offset: 0x20A9240 VA: 0x1820A9E40
	public static void SerializeDelta(Stream stream, CodeLock instance, CodeLock previous) { }

	// RVA: 0x20AA220 Offset: 0x20A9620 VA: 0x1820AA220
	public static void Serialize(Stream stream, CodeLock instance) { }

	// RVA: 0x20AA430 Offset: 0x20A9830 VA: 0x1820AA430
	public byte[] ToProtoBytes() { }

	// RVA: 0x20AA440 Offset: 0x20A9840 VA: 0x1820AA440
	public void ToProto(Stream stream) { }

	// RVA: 0x20AA110 Offset: 0x20A9510 VA: 0x1820AA110
	public static byte[] SerializeToBytes(CodeLock instance) { }

	// RVA: 0x20AA060 Offset: 0x20A9460 VA: 0x1820AA060
	public static void SerializeLengthDelimited(Stream stream, CodeLock instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class CodeLock.Private : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6307
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string code; // 0x18
	public List<ulong> users; // 0x20
	public string guestCode; // 0x28
	public List<ulong> guestUsers; // 0x30

	// Methods

	// RVA: 0x20B8EC0 Offset: 0x20B82C0 VA: 0x1820B8EC0
	public static void ResetToPool(CodeLock.Private instance) { }

	// RVA: 0x20B8D20 Offset: 0x20B8120 VA: 0x1820B8D20
	public void ResetToPool() { }

	// RVA: 0x20B8C60 Offset: 0x20B8060 VA: 0x1820B8C60 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20B7760 Offset: 0x20B6B60 VA: 0x1820B7760
	public void CopyTo(CodeLock.Private instance) { }

	// RVA: 0x20B7980 Offset: 0x20B6D80 VA: 0x1820B7980
	public CodeLock.Private Copy() { }

	// RVA: 0x20B8320 Offset: 0x20B7720 VA: 0x1820B8320
	public static CodeLock.Private Deserialize(Stream stream) { }

	// RVA: 0x20B7D90 Offset: 0x20B7190 VA: 0x1820B7D90
	public static CodeLock.Private DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20B7E10 Offset: 0x20B7210 VA: 0x1820B7E10
	public static CodeLock.Private DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20B88B0 Offset: 0x20B7CB0 VA: 0x1820B88B0
	public static CodeLock.Private Deserialize(byte[] buffer) { }

	// RVA: 0x20B8CE0 Offset: 0x20B80E0 VA: 0x1820B8CE0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20B97A0 Offset: 0x20B8BA0 VA: 0x1820B97A0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20B97C0 Offset: 0x20B8BC0 VA: 0x1820B97C0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CodeLock.Private previous) { }

	// RVA: 0x20B8D00 Offset: 0x20B8100 VA: 0x1820B8D00 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20B8220 Offset: 0x20B7620 VA: 0x1820B8220
	public static CodeLock.Private Deserialize(byte[] buffer, CodeLock.Private instance, bool isDelta = False) { }

	// RVA: 0x20B8600 Offset: 0x20B7A00 VA: 0x1820B8600
	public static CodeLock.Private Deserialize(Stream stream, CodeLock.Private instance, bool isDelta) { }

	// RVA: 0x20B7A00 Offset: 0x20B6E00 VA: 0x1820B7A00
	public static CodeLock.Private DeserializeLengthDelimited(Stream stream, CodeLock.Private instance, bool isDelta) { }

	// RVA: 0x20B7EA0 Offset: 0x20B72A0 VA: 0x1820B7EA0
	public static CodeLock.Private DeserializeLength(Stream stream, int length, CodeLock.Private instance, bool isDelta) { }

	// RVA: 0x20B9060 Offset: 0x20B8460 VA: 0x1820B9060
	public static void SerializeDelta(Stream stream, CodeLock.Private instance, CodeLock.Private previous) { }

	// RVA: 0x20B94F0 Offset: 0x20B88F0 VA: 0x1820B94F0
	public static void Serialize(Stream stream, CodeLock.Private instance) { }

	// RVA: 0x20B9790 Offset: 0x20B8B90 VA: 0x1820B9790
	public byte[] ToProtoBytes() { }

	// RVA: 0x20B97A0 Offset: 0x20B8BA0 VA: 0x1820B97A0
	public void ToProto(Stream stream) { }

	// RVA: 0x20B93E0 Offset: 0x20B87E0 VA: 0x1820B93E0
	public static byte[] SerializeToBytes(CodeLock.Private instance) { }

	// RVA: 0x20B9330 Offset: 0x20B8730 VA: 0x1820B9330
	public static void SerializeLengthDelimited(Stream stream, CodeLock.Private instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class CodeLock : BaseLock // TypeDefIndex: 8373
{	// Fields
	private Option __menuOption_Menu_ChangeGuestCode; // 0x1C8
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

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x593440 Offset: 0x592840 VA: 0x180593440 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x5949A0 Offset: 0x593DA0 VA: 0x1805949A0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x594280 Offset: 0x593680 VA: 0x180594280 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x593DF0 Offset: 0x5931F0 VA: 0x180593DF0
	public bool IsCodeEntryBlocked() { }

	// RVA: 0x593E00 Offset: 0x593200 VA: 0x180593E00 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0xD3CB0 Offset: 0xD30B0 VA: 0x1800D3CB0
	[BaseEntity.Menu.Description] // RVA: 0xD3CB0 Offset: 0xD30B0 VA: 0x1800D3CB0
	[BaseEntity.Menu.Icon] // RVA: 0xD3CB0 Offset: 0xD30B0 VA: 0x1800D3CB0
	[BaseEntity.Menu.ShowIf] // RVA: 0xD3CB0 Offset: 0xD30B0 VA: 0x1800D3CB0
	// RVA: 0x594240 Offset: 0x593640 VA: 0x180594240
	public void Menu_Unlock(BasePlayer player) { }

	// RVA: 0x594200 Offset: 0x593600 VA: 0x180594200
	public bool Menu_Unlock_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xD5210 Offset: 0xD4610 VA: 0x1800D5210
	[BaseEntity.Menu.Description] // RVA: 0xD5210 Offset: 0xD4610 VA: 0x1800D5210
	[BaseEntity.Menu.Icon] // RVA: 0xD5210 Offset: 0xD4610 VA: 0x1800D5210
	[BaseEntity.Menu.ShowIf] // RVA: 0xD5210 Offset: 0xD4610 VA: 0x1800D5210
	// RVA: 0x5941C0 Offset: 0x5935C0 VA: 0x1805941C0
	public void Menu_Lock(BasePlayer player) { }

	// RVA: 0x594190 Offset: 0x593590 VA: 0x180594190
	public bool Menu_Lock_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xD5450 Offset: 0xD4850 VA: 0x1800D5450
	[BaseEntity.Menu.Description] // RVA: 0xD5450 Offset: 0xD4850 VA: 0x1800D5450
	[BaseEntity.Menu.Icon] // RVA: 0xD5450 Offset: 0xD4850 VA: 0x1800D5450
	[BaseEntity.Menu.ShowIf] // RVA: 0xD5450 Offset: 0xD4850 VA: 0x1800D5450
	// RVA: 0x594030 Offset: 0x593430 VA: 0x180594030
	public void Menu_ChangeLockCode(BasePlayer player) { }

	// RVA: 0x593FF0 Offset: 0x5933F0 VA: 0x180593FF0
	public bool Menu_ChangeLockCode_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xD5690 Offset: 0xD4A90 VA: 0x1800D5690
	[BaseEntity.Menu.Description] // RVA: 0xD5690 Offset: 0xD4A90 VA: 0x1800D5690
	[BaseEntity.Menu.Icon] // RVA: 0xD5690 Offset: 0xD4A90 VA: 0x1800D5690
	[BaseEntity.Menu.ShowIf] // RVA: 0xD5690 Offset: 0xD4A90 VA: 0x1800D5690
	// RVA: 0x593E90 Offset: 0x593290 VA: 0x180593E90
	public void Menu_ChangeGuestCode(BasePlayer player) { }

	// RVA: 0x593E60 Offset: 0x593260 VA: 0x180593E60
	public bool Menu_ChangeGuestCode_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5932C0 Offset: 0x5926C0 VA: 0x1805932C0
	private void EnterUnlockCode(BaseEntity.RPCMessage rpc) { }

	// RVA: 0x594990 Offset: 0x593D90 VA: 0x180594990
	public void .ctor() { }

	// RVA: 0x594920 Offset: 0x593D20 VA: 0x180594920
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5948C0 Offset: 0x593CC0 VA: 0x1805948C0
	private void <Menu_ChangeLockCode>b__23_0(string str) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x594860 Offset: 0x593C60 VA: 0x180594860
	private void <Menu_ChangeGuestCode>b__25_0(string str) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x594810 Offset: 0x593C10 VA: 0x180594810
	private void <EnterUnlockCode>b__27_0(string str) { }

}

