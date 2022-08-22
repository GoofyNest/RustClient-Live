public class NeonSign : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6392
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<NeonSign.Lights> frameLighting; // 0x18
	public int currentFrame; // 0x20
	public float animationSpeed; // 0x24


	public static void ResetToPool(NeonSign instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(NeonSign instance) { }

	public NeonSign Copy() { }

	public static NeonSign Deserialize(Stream stream) { }

	public static NeonSign DeserializeLengthDelimited(Stream stream) { }

	public static NeonSign DeserializeLength(Stream stream, int length) { }

	public static NeonSign Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, NeonSign previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static NeonSign Deserialize(byte[] buffer, NeonSign instance, bool isDelta = False) { }

	public static NeonSign Deserialize(Stream stream, NeonSign instance, bool isDelta) { }

	public static NeonSign DeserializeLengthDelimited(Stream stream, NeonSign instance, bool isDelta) { }

	public static NeonSign DeserializeLength(Stream stream, int length, NeonSign instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, NeonSign instance, NeonSign previous) { }

	public static void Serialize(Stream stream, NeonSign instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(NeonSign instance) { }

	public static void SerializeLengthDelimited(Stream stream, NeonSign instance) { }

	public void .ctor() { }

}

public class NeonSign.Lights : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6393
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Color topLeft; // 0x14
	public Color topRight; // 0x24
	public Color bottomLeft; // 0x34
	public Color bottomRight; // 0x44


	public static void ResetToPool(NeonSign.Lights instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(NeonSign.Lights instance) { }

	public NeonSign.Lights Copy() { }

	public static NeonSign.Lights Deserialize(Stream stream) { }

	public static NeonSign.Lights DeserializeLengthDelimited(Stream stream) { }

	public static NeonSign.Lights DeserializeLength(Stream stream, int length) { }

	public static NeonSign.Lights Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, NeonSign.Lights previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static NeonSign.Lights Deserialize(byte[] buffer, NeonSign.Lights instance, bool isDelta = False) { }

	public static NeonSign.Lights Deserialize(Stream stream, NeonSign.Lights instance, bool isDelta) { }

	public static NeonSign.Lights DeserializeLengthDelimited(Stream stream, NeonSign.Lights instance, bool isDelta) { }

	public static NeonSign.Lights DeserializeLength(Stream stream, int length, NeonSign.Lights instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, NeonSign.Lights instance, NeonSign.Lights previous) { }

	public static void Serialize(Stream stream, NeonSign.Lights instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(NeonSign.Lights instance) { }

	public static void SerializeLengthDelimited(Stream stream, NeonSign.Lights instance) { }

	public void .ctor() { }

}

public class NeonSign : Signage // TypeDefIndex: 8424
{	private Option __menuOption_SwitchToFastSpeed; // 0x3D0
	private Option __menuOption_SwitchToMediumSpeed; // 0x428
	private Option __menuOption_SwitchToSlowSpeed; // 0x480
	private const float FastSpeed = 0,5;
	private const float MediumSpeed = 1;
	private const float SlowSpeed = 2;
	private const float MinSpeed = 0,5;
	private const float MaxSpeed = 5;
	[HeaderAttribute] // RVA: 0x7ACF0 Offset: 0x7A0F0 VA: 0x18007ACF0
	public Light topLeft; // 0x4D8
	public Light topRight; // 0x4E0
	public Light bottomLeft; // 0x4E8
	public Light bottomRight; // 0x4F0
	public float lightIntensity; // 0x4F8
	[RangeAttribute] // RVA: 0x7AD20 Offset: 0x7A120 VA: 0x18007AD20
	public int powerConsumption; // 0x4FC
	public Material activeMaterial; // 0x500
	public Material inactiveMaterial; // 0x508
	private float animationSpeed; // 0x510
	private int currentFrame; // 0x514
	private List<NeonSign.Lights> frameLighting; // 0x518
	public AmbienceEmitter ambientSoundEmitter; // 0x520
	public SoundDefinition switchSoundDef; // 0x528

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override int ConsumptionAmount() { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	public void UpdateNeonDisplay() { }

	private void UpdateLights() { }

	private void UpdateSounds() { }

	protected override void OnEnterTextureRange() { }

	public override void OnTextureWasEdited(int frame, Texture2D texture, bool fromFile = False) { }

	[BaseEntity.Menu] // RVA: 0x7B050 Offset: 0x7A450 VA: 0x18007B050
	[BaseEntity.Menu.Description] // RVA: 0x7B050 Offset: 0x7A450 VA: 0x18007B050
	[BaseEntity.Menu.Icon] // RVA: 0x7B050 Offset: 0x7A450 VA: 0x18007B050
	[BaseEntity.Menu.ShowIf] // RVA: 0x7B050 Offset: 0x7A450 VA: 0x18007B050
	public void SwitchToSlowSpeed(BasePlayer player) { }

	public bool SwitchToSlowSpeed_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7B410 Offset: 0x7A810 VA: 0x18007B410
	[BaseEntity.Menu.Description] // RVA: 0x7B410 Offset: 0x7A810 VA: 0x18007B410
	[BaseEntity.Menu.Icon] // RVA: 0x7B410 Offset: 0x7A810 VA: 0x18007B410
	[BaseEntity.Menu.ShowIf] // RVA: 0x7B410 Offset: 0x7A810 VA: 0x18007B410
	public void SwitchToMediumSpeed(BasePlayer player) { }

	public bool SwitchToMediumSpeed_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7B770 Offset: 0x7AB70 VA: 0x18007B770
	[BaseEntity.Menu.Description] // RVA: 0x7B770 Offset: 0x7AB70 VA: 0x18007B770
	[BaseEntity.Menu.Icon] // RVA: 0x7B770 Offset: 0x7AB70 VA: 0x18007B770
	[BaseEntity.Menu.ShowIf] // RVA: 0x7B770 Offset: 0x7AB70 VA: 0x18007B770
	public void SwitchToFastSpeed(BasePlayer player) { }

	public bool SwitchToFastSpeed_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void SetFrame(BaseEntity.RPCMessage msg) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	private void EnsureInitialized() { }

	private static Color ClampColor(Color color) { }

	public void .ctor() { }

}

