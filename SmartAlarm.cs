public class SmartAlarm : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6367
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<ulong> subscriptions; // 0x18
	public string notificationTitle; // 0x20
	public string notificationBody; // 0x28

	// Methods

	// RVA: 0x1DAD820 Offset: 0x1DACC20 VA: 0x181DAD820
	public static void ResetToPool(SmartAlarm instance) { }

	// RVA: 0x1DAD950 Offset: 0x1DACD50 VA: 0x181DAD950
	public void ResetToPool() { }

	// RVA: 0x1DAD630 Offset: 0x1DACA30 VA: 0x181DAD630 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DAC390 Offset: 0x1DAB790 VA: 0x181DAC390
	public void CopyTo(SmartAlarm instance) { }

	// RVA: 0x1DAC4E0 Offset: 0x1DAB8E0 VA: 0x181DAC4E0
	public SmartAlarm Copy() { }

	// RVA: 0x1DAD090 Offset: 0x1DAC490 VA: 0x181DAD090
	public static SmartAlarm Deserialize(Stream stream) { }

	// RVA: 0x1DAC670 Offset: 0x1DABA70 VA: 0x181DAC670
	public static SmartAlarm DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DACA00 Offset: 0x1DABE00 VA: 0x181DACA00
	public static SmartAlarm DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DACD90 Offset: 0x1DAC190 VA: 0x181DACD90
	public static SmartAlarm Deserialize(byte[] buffer) { }

	// RVA: 0x1DAD7E0 Offset: 0x1DACBE0 VA: 0x181DAD7E0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DAE080 Offset: 0x1DAD480 VA: 0x181DAE080 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DAE0A0 Offset: 0x1DAD4A0 VA: 0x181DAE0A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SmartAlarm previous) { }

	// RVA: 0x1DAD800 Offset: 0x1DACC00 VA: 0x181DAD800 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DAD2F0 Offset: 0x1DAC6F0 VA: 0x181DAD2F0
	public static SmartAlarm Deserialize(byte[] buffer, SmartAlarm instance, bool isDelta = False) { }

	// RVA: 0x1DAD3F0 Offset: 0x1DAC7F0 VA: 0x181DAD3F0
	public static SmartAlarm Deserialize(Stream stream, SmartAlarm instance, bool isDelta) { }

	// RVA: 0x1DAC6F0 Offset: 0x1DABAF0 VA: 0x181DAC6F0
	public static SmartAlarm DeserializeLengthDelimited(Stream stream, SmartAlarm instance, bool isDelta) { }

	// RVA: 0x1DACA90 Offset: 0x1DABE90 VA: 0x181DACA90
	public static SmartAlarm DeserializeLength(Stream stream, int length, SmartAlarm instance, bool isDelta) { }

	// RVA: 0x1DADA80 Offset: 0x1DACE80 VA: 0x181DADA80
	public static void SerializeDelta(Stream stream, SmartAlarm instance, SmartAlarm previous) { }

	// RVA: 0x1DADE80 Offset: 0x1DAD280 VA: 0x181DADE80
	public static void Serialize(Stream stream, SmartAlarm instance) { }

	// RVA: 0x1DAE070 Offset: 0x1DAD470 VA: 0x181DAE070
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DAE080 Offset: 0x1DAD480 VA: 0x181DAE080
	public void ToProto(Stream stream) { }

	// RVA: 0x1DADD70 Offset: 0x1DAD170 VA: 0x181DADD70
	public static byte[] SerializeToBytes(SmartAlarm instance) { }

	// RVA: 0x1DADCC0 Offset: 0x1DAD0C0 VA: 0x181DADCC0
	public static void SerializeLengthDelimited(Stream stream, SmartAlarm instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class SmartAlarm : AppIOEntity, ISubscribable // TypeDefIndex: 8449
{	// Fields
	private Option __menuOption_MenuSetupNotification; // 0x2E0
	public const BaseEntity.Flags Flag_HasCustomMessage = 16384;
	public static readonly Translate.Phrase DefaultNotificationTitle; // 0x0
	public static readonly Translate.Phrase DefaultNotificationBody; // 0x8
	[HeaderAttribute] // RVA: 0x879A0 Offset: 0x86DA0 VA: 0x1800879A0
	public GameObjectRef SetupNotificationDialog; // 0x338
	public Animator Animator; // 0x340
	private static readonly int AnimatorOn; // 0x10

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x5C8430 Offset: 0x5C7830 VA: 0x1805C8430 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x5C9180 Offset: 0x5C8580 VA: 0x1805C9180 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x5C88F0 Offset: 0x5C7CF0 VA: 0x1805C88F0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x5C8860 Offset: 0x5C7C60 VA: 0x1805C8860
	public void OnAlarmStatusChange(bool isOn) { }

	[BaseEntity.Menu] // RVA: 0x87AB0 Offset: 0x86EB0 VA: 0x180087AB0
	[BaseEntity.Menu.Description] // RVA: 0x87AB0 Offset: 0x86EB0 VA: 0x180087AB0
	[BaseEntity.Menu.Icon] // RVA: 0x87AB0 Offset: 0x86EB0 VA: 0x180087AB0
	[BaseEntity.Menu.ShowIf] // RVA: 0x87AB0 Offset: 0x86EB0 VA: 0x180087AB0
	// RVA: 0x5C8820 Offset: 0x5C7C20 VA: 0x1805C8820
	public void MenuSetupNotification(BasePlayer player) { }

	// RVA: 0x5C87A0 Offset: 0x5C7BA0 VA: 0x1805C87A0
	public bool MenuSetupNotification_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5C8F10 Offset: 0x5C8310 VA: 0x1805C8F10
	private void SetupNotification(BaseEntity.RPCMessage rpc) { }

	// RVA: 0x5C8EA0 Offset: 0x5C82A0 VA: 0x1805C8EA0
	public void SetNotificationText(string title, string body) { }

	// RVA: 0x5C9170 Offset: 0x5C8570 VA: 0x1805C9170
	public void .ctor() { }

	// RVA: 0x5C90A0 Offset: 0x5C84A0 VA: 0x1805C90A0
	private static void .cctor() { }

}

