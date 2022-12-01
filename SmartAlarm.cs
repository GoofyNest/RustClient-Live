public class SmartAlarm : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6376
{
	public bool ShouldPool;
	private bool _disposed;
	public List<ulong> subscriptions;
	public string notificationTitle;
	public string notificationBody;


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

public class SmartAlarm : AppIOEntity, ISubscribable // TypeDefIndex: 10169
{
	private Option __menuOption_MenuSetupNotification;
	public const BaseEntity.Flags Flag_HasCustomMessage = 16384;
	public static readonly Translate.Phrase DefaultNotificationTitle;
	public static readonly Translate.Phrase DefaultNotificationBody;
	[HeaderAttribute]
	public GameObjectRef SetupNotificationDialog;
	public Animator Animator;
	private static readonly int AnimatorOn;

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public void OnAlarmStatusChange(bool isOn) { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.ShowIf]
	public void MenuSetupNotification(BasePlayer player) { }

	public bool MenuSetupNotification_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client]
	private void SetupNotification(BaseEntity.RPCMessage rpc) { }

	public void SetNotificationText(string title, string body) { }

	public void .ctor() { }

	private static void .cctor() { }

}

