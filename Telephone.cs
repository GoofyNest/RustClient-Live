public class Telephone : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6390
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int lastNumber; // 0x14
	public int phoneNumber; // 0x18
	public uint usingPlayer; // 0x1C
	public string phoneName; // 0x20
	public PhoneDirectory savedNumbers; // 0x28
	public List<VoicemailEntry> voicemail; // 0x30


	public static void ResetToPool(Telephone instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(Telephone instance) { }

	public Telephone Copy() { }

	public static Telephone Deserialize(Stream stream) { }

	public static Telephone DeserializeLengthDelimited(Stream stream) { }

	public static Telephone DeserializeLength(Stream stream, int length) { }

	public static Telephone Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, Telephone previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static Telephone Deserialize(byte[] buffer, Telephone instance, bool isDelta = False) { }

	public static Telephone Deserialize(Stream stream, Telephone instance, bool isDelta) { }

	public static Telephone DeserializeLengthDelimited(Stream stream, Telephone instance, bool isDelta) { }

	public static Telephone DeserializeLength(Stream stream, int length, Telephone instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, Telephone instance, Telephone previous) { }

	public static void Serialize(Stream stream, Telephone instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(Telephone instance) { }

	public static void SerializeLengthDelimited(Stream stream, Telephone instance) { }

	public void .ctor() { }

}

public class Telephone : ContainerIOEntity, ICassettePlayer // TypeDefIndex: 8462
{	private Option __menuOption_Menu_Answer; // 0x378
	private Option __menuOption_Menu_MakeCall; // 0x3D0
	public const int MaxPhoneNameLength = 20;
	public const int MaxSavedNumbers = 10;
	public Transform PhoneHotspot; // 0x428
	public Transform AnsweringMachineHotspot; // 0x430
	public Transform[] HandsetRoots; // 0x438
	public ItemDefinition[] ValidCassettes; // 0x440
	public Transform ParentedHandsetTransform; // 0x448
	public LineRenderer CableLineRenderer; // 0x450
	public Transform CableStartPoint; // 0x458
	public Transform CableEndPoint; // 0x460
	public float LineDroopAmount; // 0x468
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Cassette <cachedCassette>k__BackingField; // 0x470
	public PhoneController Controller; // 0x478
	private Vector3[] cablePoints; // 0x480
	private static Telephone.CensoredNumbers censoredNumbers; // 0x0

	public override bool HasMenuOptions { get; }
	public Cassette cachedCassette { get; set; }
	private static string CensoredNumbersPath { get; }
	private static int CensoredNumbersVersion { get; }
	public BaseEntity ToBaseEntity { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Cassette get_cachedCassette() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_cachedCassette(Cassette value) { }

	[BaseEntity.Menu] // RVA: 0x8FA30 Offset: 0x8EE30 VA: 0x18008FA30
	[BaseEntity.Menu.Description] // RVA: 0x8FA30 Offset: 0x8EE30 VA: 0x18008FA30
	[BaseEntity.Menu.Icon] // RVA: 0x8FA30 Offset: 0x8EE30 VA: 0x18008FA30
	[BaseEntity.Menu.ShowIf] // RVA: 0x8FA30 Offset: 0x8EE30 VA: 0x18008FA30
	public void Menu_MakeCall(BasePlayer player) { }

	private void DelayedViewModelDeploy() { }

	public void HolsterViewmodel() { }

	[BaseEntity.Menu] // RVA: 0x8FDE0 Offset: 0x8F1E0 VA: 0x18008FDE0
	[BaseEntity.Menu.Description] // RVA: 0x8FDE0 Offset: 0x8F1E0 VA: 0x18008FDE0
	[BaseEntity.Menu.Icon] // RVA: 0x8FDE0 Offset: 0x8F1E0 VA: 0x18008FDE0
	[BaseEntity.Menu.ShowIf] // RVA: 0x8FDE0 Offset: 0x8F1E0 VA: 0x18008FDE0
	public void Menu_Answer(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void SetClientState(BaseEntity.RPCMessage msg) { }

	private void LateUpdate() { }

	private void ApplyDroopCurve(Vector3[] points, Vector3 startPos, Vector3 endPos) { }

	private bool IsPhoneUsable(BasePlayer player) { }

	private bool IsPhoneRinging(BasePlayer player) { }

	private bool IsPlayerLookingAtPhone(BasePlayer player) { }

	private bool IsPlayerLookingAtAnsweringMachine(BasePlayer player) { }

	public override bool ShouldShowLootMenus() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void ClientOnDialFailed(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void ClientReceiveAnsweringData(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void ClientPlayAnsweringMessage(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void OnIncomingCallDuringCall() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void OnReceivedVoice(BaseEntity.RPCMessage msg) { }

	public void OnLoadedWithCassette(Cassette c) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void ClientOnCassetteChanged(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void ReceivePhoneDirectory(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void ClientToggleVoicemail(BaseEntity.RPCMessage msg) { }

	public void OnCensorRecordingsChanged() { }

	public static bool IsNumberCensored(int number) { }

	private static string get_CensoredNumbersPath() { }

	private static int get_CensoredNumbersVersion() { }

	private static void LoadCensoredNumbers() { }

	private static void SaveCensoredNumbers() { }

	public static void ToggleNumberCensorship(int number, bool state) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public override bool CanPickup(BasePlayer player) { }

	public BaseEntity get_ToBaseEntity() { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum Telephone.CallState // TypeDefIndex: 8463
{	public int value__; // 0x0
	public const Telephone.CallState Idle = 0;
	public const Telephone.CallState Dialing = 1;
	public const Telephone.CallState Ringing = 2;
	public const Telephone.CallState InProcess = 3;

}

public enum Telephone.DialFailReason // TypeDefIndex: 8464
{	public int value__; // 0x0
	public const Telephone.DialFailReason TimedOut = 0;
	public const Telephone.DialFailReason Engaged = 1;
	public const Telephone.DialFailReason WrongNumber = 2;
	public const Telephone.DialFailReason CallSelf = 3;
	public const Telephone.DialFailReason RemoteHangUp = 4;
	public const Telephone.DialFailReason NetworkBusy = 5;
	public const Telephone.DialFailReason TimeOutDuringCall = 6;
	public const Telephone.DialFailReason SelfHangUp = 7;

}

private class Telephone.CensoredNumbers // TypeDefIndex: 8465
{	public List<int> numbers; // 0x10
	public int saveVersion; // 0x18


	public void .ctor() { }

}

