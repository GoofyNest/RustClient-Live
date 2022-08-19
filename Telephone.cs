public class Telephone : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6390
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int lastNumber; // 0x14
	public int phoneNumber; // 0x18
	public uint usingPlayer; // 0x1C
	public string phoneName; // 0x20
	public PhoneDirectory savedNumbers; // 0x28
	public List<VoicemailEntry> voicemail; // 0x30

	// Methods

	// RVA: 0x1DC4680 Offset: 0x1DC3A80 VA: 0x181DC4680
	public static void ResetToPool(Telephone instance) { }

	// RVA: 0x1DC48D0 Offset: 0x1DC3CD0 VA: 0x181DC48D0
	public void ResetToPool() { }

	// RVA: 0x1DC42F0 Offset: 0x1DC36F0 VA: 0x181DC42F0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DC2AE0 Offset: 0x1DC1EE0 VA: 0x181DC2AE0
	public void CopyTo(Telephone instance) { }

	// RVA: 0x1DC2C60 Offset: 0x1DC2060 VA: 0x181DC2C60
	public Telephone Copy() { }

	// RVA: 0x1DC3920 Offset: 0x1DC2D20 VA: 0x181DC3920
	public static Telephone Deserialize(Stream stream) { }

	// RVA: 0x1DC2CE0 Offset: 0x1DC20E0 VA: 0x181DC2CE0
	public static Telephone DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DC3140 Offset: 0x1DC2540 VA: 0x181DC3140
	public static Telephone DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DC3580 Offset: 0x1DC2980 VA: 0x181DC3580
	public static Telephone Deserialize(byte[] buffer) { }

	// RVA: 0x1DC4370 Offset: 0x1DC3770 VA: 0x181DC4370
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DC54C0 Offset: 0x1DC48C0 VA: 0x181DC54C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DC54E0 Offset: 0x1DC48E0 VA: 0x181DC54E0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Telephone previous) { }

	// RVA: 0x1DC4660 Offset: 0x1DC3A60 VA: 0x181DC4660 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DC3F20 Offset: 0x1DC3320 VA: 0x181DC3F20
	public static Telephone Deserialize(byte[] buffer, Telephone instance, bool isDelta = False) { }

	// RVA: 0x1DC3C20 Offset: 0x1DC3020 VA: 0x181DC3C20
	public static Telephone Deserialize(Stream stream, Telephone instance, bool isDelta) { }

	// RVA: 0x1DC2D60 Offset: 0x1DC2160 VA: 0x181DC2D60
	public static Telephone DeserializeLengthDelimited(Stream stream, Telephone instance, bool isDelta) { }

	// RVA: 0x1DC31D0 Offset: 0x1DC25D0 VA: 0x181DC31D0
	public static Telephone DeserializeLength(Stream stream, int length, Telephone instance, bool isDelta) { }

	// RVA: 0x1DC4B20 Offset: 0x1DC3F20 VA: 0x181DC4B20
	public static void SerializeDelta(Stream stream, Telephone instance, Telephone previous) { }

	// RVA: 0x1DC5120 Offset: 0x1DC4520 VA: 0x181DC5120
	public static void Serialize(Stream stream, Telephone instance) { }

	// RVA: 0x1DC54B0 Offset: 0x1DC48B0 VA: 0x181DC54B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DC54C0 Offset: 0x1DC48C0 VA: 0x181DC54C0
	public void ToProto(Stream stream) { }

	// RVA: 0x1DC5010 Offset: 0x1DC4410 VA: 0x181DC5010
	public static byte[] SerializeToBytes(Telephone instance) { }

	// RVA: 0x1DC4F60 Offset: 0x1DC4360 VA: 0x181DC4F60
	public static void SerializeLengthDelimited(Stream stream, Telephone instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class Telephone : ContainerIOEntity, ICassettePlayer // TypeDefIndex: 8462
{	// Fields
	private Option __menuOption_Menu_Answer; // 0x378
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

	// Properties
	public override bool HasMenuOptions { get; }
	public Cassette cachedCassette { get; set; }
	private static string CensoredNumbersPath { get; }
	private static int CensoredNumbersVersion { get; }
	public BaseEntity ToBaseEntity { get; }

	// Methods

	// RVA: 0x7AE2C0 Offset: 0x7AD6C0 VA: 0x1807AE2C0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7B2490 Offset: 0x7B1890 VA: 0x1807B2490 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x7AFFA0 Offset: 0x7AF3A0 VA: 0x1807AFFA0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7B2650 Offset: 0x7B1A50 VA: 0x1807B2650
	public Cassette get_cachedCassette() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7AFF50 Offset: 0x7AF350 VA: 0x1807AFF50
	private void set_cachedCassette(Cassette value) { }

	[BaseEntity.Menu] // RVA: 0x8FA30 Offset: 0x8EE30 VA: 0x18008FA30
	[BaseEntity.Menu.Description] // RVA: 0x8FA30 Offset: 0x8EE30 VA: 0x18008FA30
	[BaseEntity.Menu.Icon] // RVA: 0x8FA30 Offset: 0x8EE30 VA: 0x18008FA30
	[BaseEntity.Menu.ShowIf] // RVA: 0x8FA30 Offset: 0x8EE30 VA: 0x18008FA30
	// RVA: 0x7AFCD0 Offset: 0x7AF0D0 VA: 0x1807AFCD0
	public void Menu_MakeCall(BasePlayer player) { }

	// RVA: 0x7AE180 Offset: 0x7AD580 VA: 0x1807AE180
	private void DelayedViewModelDeploy() { }

	// RVA: 0x7AE890 Offset: 0x7ADC90 VA: 0x1807AE890
	public void HolsterViewmodel() { }

	[BaseEntity.Menu] // RVA: 0x8FDE0 Offset: 0x8F1E0 VA: 0x18008FDE0
	[BaseEntity.Menu.Description] // RVA: 0x8FDE0 Offset: 0x8F1E0 VA: 0x18008FDE0
	[BaseEntity.Menu.Icon] // RVA: 0x8FDE0 Offset: 0x8F1E0 VA: 0x18008FDE0
	[BaseEntity.Menu.ShowIf] // RVA: 0x8FDE0 Offset: 0x8F1E0 VA: 0x18008FDE0
	// RVA: 0x7AFC00 Offset: 0x7AF000 VA: 0x1807AFC00
	public void Menu_Answer(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7B1F00 Offset: 0x7B1300 VA: 0x1807B1F00
	public void SetClientState(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7AED50 Offset: 0x7AE150 VA: 0x1807AED50
	private void LateUpdate() { }

	// RVA: 0x7ADBB0 Offset: 0x7ACFB0 VA: 0x1807ADBB0
	private void ApplyDroopCurve(Vector3[] points, Vector3 startPos, Vector3 endPos) { }

	// RVA: 0x7AEA80 Offset: 0x7ADE80 VA: 0x1807AEA80
	private bool IsPhoneUsable(BasePlayer player) { }

	// RVA: 0x7AE9F0 Offset: 0x7ADDF0 VA: 0x1807AE9F0
	private bool IsPhoneRinging(BasePlayer player) { }

	// RVA: 0x7AEC40 Offset: 0x7AE040 VA: 0x1807AEC40
	private bool IsPlayerLookingAtPhone(BasePlayer player) { }

	// RVA: 0x7AEB30 Offset: 0x7ADF30 VA: 0x1807AEB30
	private bool IsPlayerLookingAtAnsweringMachine(BasePlayer player) { }

	// RVA: 0x7B1F40 Offset: 0x7B1340 VA: 0x1807B1F40 Slot: 164
	public override bool ShouldShowLootMenus() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7AE070 Offset: 0x7AD470 VA: 0x1807AE070
	public void ClientOnDialFailed(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7AE0F0 Offset: 0x7AD4F0 VA: 0x1807AE0F0
	private void ClientReceiveAnsweringData(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7AE0B0 Offset: 0x7AD4B0 VA: 0x1807AE0B0
	private void ClientPlayAnsweringMessage(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7AFF20 Offset: 0x7AF320 VA: 0x1807AFF20
	public void OnIncomingCallDuringCall() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7AFF60 Offset: 0x7AF360 VA: 0x1807AFF60
	public void OnReceivedVoice(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7AFF50 Offset: 0x7AF350 VA: 0x1807AFF50 Slot: 168
	public void OnLoadedWithCassette(Cassette c) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7ADEE0 Offset: 0x7AD2E0 VA: 0x1807ADEE0
	public void ClientOnCassetteChanged(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7B1DE0 Offset: 0x7B11E0 VA: 0x1807B1DE0
	private void ReceivePhoneDirectory(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7AE140 Offset: 0x7AD540 VA: 0x1807AE140
	private void ClientToggleVoicemail(BaseEntity.RPCMessage msg) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 169
	public void OnCensorRecordingsChanged() { }

	// RVA: 0x7AE970 Offset: 0x7ADD70 VA: 0x1807AE970
	public static bool IsNumberCensored(int number) { }

	// RVA: 0x7B2410 Offset: 0x7B1810 VA: 0x1807B2410
	private static string get_CensoredNumbersPath() { }

	// RVA: 0x7B2480 Offset: 0x7B1880 VA: 0x1807B2480
	private static int get_CensoredNumbersVersion() { }

	// RVA: 0x7AF4A0 Offset: 0x7AE8A0 VA: 0x1807AF4A0
	private static void LoadCensoredNumbers() { }

	// RVA: 0x7B1E20 Offset: 0x7B1220 VA: 0x1807B1E20
	private static void SaveCensoredNumbers() { }

	// RVA: 0x7B2100 Offset: 0x7B1500 VA: 0x1807B2100
	public static void ToggleNumberCensorship(int number, bool state) { }

	// RVA: 0x7AF730 Offset: 0x7AEB30 VA: 0x1807AF730 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x7ADE40 Offset: 0x7AD240 VA: 0x1807ADE40 Slot: 134
	public override bool CanPickup(BasePlayer player) { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80 Slot: 167
	public BaseEntity get_ToBaseEntity() { }

	// RVA: 0x7AFDA0 Offset: 0x7AF1A0 VA: 0x1807AFDA0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x7B23B0 Offset: 0x7B17B0 VA: 0x1807B23B0
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

public enum Telephone.CallState // TypeDefIndex: 8463
{	// Fields
	public int value__; // 0x0
	public const Telephone.CallState Idle = 0;
	public const Telephone.CallState Dialing = 1;
	public const Telephone.CallState Ringing = 2;
	public const Telephone.CallState InProcess = 3;

}

public enum Telephone.DialFailReason // TypeDefIndex: 8464
{	// Fields
	public int value__; // 0x0
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
{	// Fields
	public List<int> numbers; // 0x10
	public int saveVersion; // 0x18

	// Methods

	// RVA: 0x112F770 Offset: 0x112EB70 VA: 0x18112F770
	public void .ctor() { }

}

