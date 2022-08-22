public class SmartAlarm : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6367
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<ulong> subscriptions; // 0x18
	public string notificationTitle; // 0x20
	public string notificationBody; // 0x28


	public static void ResetToPool(SmartAlarm instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(SmartAlarm instance) { }

	public SmartAlarm Copy() { }

	public static SmartAlarm Deserialize(Stream stream) { }

	public static SmartAlarm DeserializeLengthDelimited(Stream stream) { }

	public static SmartAlarm DeserializeLength(Stream stream, int length) { }

	public static SmartAlarm Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, SmartAlarm previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static SmartAlarm Deserialize(byte[] buffer, SmartAlarm instance, bool isDelta = False) { }

	public static SmartAlarm Deserialize(Stream stream, SmartAlarm instance, bool isDelta) { }

	public static SmartAlarm DeserializeLengthDelimited(Stream stream, SmartAlarm instance, bool isDelta) { }

	public static SmartAlarm DeserializeLength(Stream stream, int length, SmartAlarm instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, SmartAlarm instance, SmartAlarm previous) { }

	public static void Serialize(Stream stream, SmartAlarm instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(SmartAlarm instance) { }

	public static void SerializeLengthDelimited(Stream stream, SmartAlarm instance) { }

	public void .ctor() { }

}

public class SmartAlarm : AppIOEntity, ISubscribable // TypeDefIndex: 8449
{	private Option __menuOption_MenuSetupNotification; // 0x2E0
	public const BaseEntity.Flags Flag_HasCustomMessage = 16384;
	public static readonly Translate.Phrase DefaultNotificationTitle; // 0x0
	public static readonly Translate.Phrase DefaultNotificationBody; // 0x8
	[HeaderAttribute] // RVA: 0x879A0 Offset: 0x86DA0 VA: 0x1800879A0
	public GameObjectRef SetupNotificationDialog; // 0x338
	public Animator Animator; // 0x340
	private static readonly int AnimatorOn; // 0x10

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public void OnAlarmStatusChange(bool isOn) { }

	[BaseEntity.Menu] // RVA: 0x87AB0 Offset: 0x86EB0 VA: 0x180087AB0
	[BaseEntity.Menu.Description] // RVA: 0x87AB0 Offset: 0x86EB0 VA: 0x180087AB0
	[BaseEntity.Menu.Icon] // RVA: 0x87AB0 Offset: 0x86EB0 VA: 0x180087AB0
	[BaseEntity.Menu.ShowIf] // RVA: 0x87AB0 Offset: 0x86EB0 VA: 0x180087AB0
	public void MenuSetupNotification(BasePlayer player) { }

	public bool MenuSetupNotification_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetupNotification(BaseEntity.RPCMessage rpc) { }

	public void SetNotificationText(string title, string body) { }

	public void .ctor() { }

	private static void .cctor() { }

}

