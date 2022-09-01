public class Telephone : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6391
{
	public bool ShouldPool; 
	private bool _disposed; 
	public int lastNumber; 
	public int phoneNumber; 
	public uint usingPlayer; 
	public string phoneName; 
	public PhoneDirectory savedNumbers; 
	public List<VoicemailEntry> voicemail; 


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

public class Telephone : ContainerIOEntity, ICassettePlayer // TypeDefIndex: 8464
{
	private Option __menuOption_Menu_Answer; 
	private Option __menuOption_Menu_MakeCall; 
	public const int MaxPhoneNameLength = 20;
	public const int MaxSavedNumbers = 10;
	public Transform PhoneHotspot; 
	public Transform AnsweringMachineHotspot; 
	public Transform[] HandsetRoots; 
	public ItemDefinition[] ValidCassettes; 
	public Transform ParentedHandsetTransform; 
	public LineRenderer CableLineRenderer; 
	public Transform CableStartPoint; 
	public Transform CableEndPoint; 
	public float LineDroopAmount; 
	[CompilerGeneratedAttribute] 
	private Cassette <cachedCassette>k__BackingField; 
	public PhoneController Controller; 
	private Vector3[] cablePoints; 
	private static Telephone.CensoredNumbers censoredNumbers; 

	public override bool HasMenuOptions { get; }
	public Cassette cachedCassette { get; set; }
	private static string CensoredNumbersPath { get; }
	private static int CensoredNumbersVersion { get; }
	public BaseEntity ToBaseEntity { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[CompilerGeneratedAttribute] 
	public Cassette get_cachedCassette() { }

	[CompilerGeneratedAttribute] 
	private void set_cachedCassette(Cassette value) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_MakeCall(BasePlayer player) { }

	private void DelayedViewModelDeploy() { }

	public void HolsterViewmodel() { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_Answer(BasePlayer player) { }

	[BaseEntity.RPC_Client] 
	public void SetClientState(BaseEntity.RPCMessage msg) { }

	private void LateUpdate() { }

	private void ApplyDroopCurve(Vector3[] points, Vector3 startPos, Vector3 endPos) { }

	private bool IsPhoneUsable(BasePlayer player) { }

	private bool IsPhoneRinging(BasePlayer player) { }

	private bool IsPlayerLookingAtPhone(BasePlayer player) { }

	private bool IsPlayerLookingAtAnsweringMachine(BasePlayer player) { }

	public override bool ShouldShowLootMenus() { }

	[BaseEntity.RPC_Client] 
	public void ClientOnDialFailed(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
	private void ClientReceiveAnsweringData(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
	private void ClientPlayAnsweringMessage(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
	public void OnIncomingCallDuringCall() { }

	[BaseEntity.RPC_Client] 
	public void OnReceivedVoice(BaseEntity.RPCMessage msg) { }

	public void OnLoadedWithCassette(Cassette c) { }

	[BaseEntity.RPC_Client] 
	public void ClientOnCassetteChanged(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
	private void ReceivePhoneDirectory(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
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

public enum Telephone.CallState // TypeDefIndex: 8465
{
	public int value__; 
	public const Telephone.CallState Idle = 0;
	public const Telephone.CallState Dialing = 1;
	public const Telephone.CallState Ringing = 2;
	public const Telephone.CallState InProcess = 3;

}

public enum Telephone.DialFailReason // TypeDefIndex: 8466
{
	public int value__; 
	public const Telephone.DialFailReason TimedOut = 0;
	public const Telephone.DialFailReason Engaged = 1;
	public const Telephone.DialFailReason WrongNumber = 2;
	public const Telephone.DialFailReason CallSelf = 3;
	public const Telephone.DialFailReason RemoteHangUp = 4;
	public const Telephone.DialFailReason NetworkBusy = 5;
	public const Telephone.DialFailReason TimeOutDuringCall = 6;
	public const Telephone.DialFailReason SelfHangUp = 7;

}

private class Telephone.CensoredNumbers // TypeDefIndex: 8467
{
	public List<int> numbers; 
	public int saveVersion; 


	public void .ctor() { }

}

