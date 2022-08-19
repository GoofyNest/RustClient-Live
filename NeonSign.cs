public class NeonSign : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6392
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<NeonSign.Lights> frameLighting; // 0x18
	public int currentFrame; // 0x20
	public float animationSpeed; // 0x24

	// Methods

	// RVA: 0x1F87720 Offset: 0x1F86B20 VA: 0x181F87720
	public static void ResetToPool(NeonSign instance) { }

	// RVA: 0x1F87910 Offset: 0x1F86D10 VA: 0x181F87910
	public void ResetToPool() { }

	// RVA: 0x1F87660 Offset: 0x1F86A60 VA: 0x181F87660 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F86650 Offset: 0x1F85A50 VA: 0x181F86650
	public void CopyTo(NeonSign instance) { }

	// RVA: 0x1F86800 Offset: 0x1F85C00 VA: 0x181F86800
	public NeonSign Copy() { }

	// RVA: 0x1F874E0 Offset: 0x1F868E0 VA: 0x181F874E0
	public static NeonSign Deserialize(Stream stream) { }

	// RVA: 0x1F86A00 Offset: 0x1F85E00 VA: 0x181F86A00
	public static NeonSign DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F86DC0 Offset: 0x1F861C0 VA: 0x181F86DC0
	public static NeonSign DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F87160 Offset: 0x1F86560 VA: 0x181F87160
	public static NeonSign Deserialize(byte[] buffer) { }

	// RVA: 0x1F876E0 Offset: 0x1F86AE0 VA: 0x181F876E0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F881E0 Offset: 0x1F875E0 VA: 0x181F881E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F88200 Offset: 0x1F87600 VA: 0x181F88200 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, NeonSign previous) { }

	// RVA: 0x1F87700 Offset: 0x1F86B00 VA: 0x181F87700 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F87560 Offset: 0x1F86960 VA: 0x181F87560
	public static NeonSign Deserialize(byte[] buffer, NeonSign instance, bool isDelta = False) { }

	// RVA: 0x1F87280 Offset: 0x1F86680 VA: 0x181F87280
	public static NeonSign Deserialize(Stream stream, NeonSign instance, bool isDelta) { }

	// RVA: 0x1F86A80 Offset: 0x1F85E80 VA: 0x181F86A80
	public static NeonSign DeserializeLengthDelimited(Stream stream, NeonSign instance, bool isDelta) { }

	// RVA: 0x1F86E50 Offset: 0x1F86250 VA: 0x181F86E50
	public static NeonSign DeserializeLength(Stream stream, int length, NeonSign instance, bool isDelta) { }

	// RVA: 0x1F87B00 Offset: 0x1F86F00 VA: 0x181F87B00
	public static void SerializeDelta(Stream stream, NeonSign instance, NeonSign previous) { }

	// RVA: 0x1F87F80 Offset: 0x1F87380 VA: 0x181F87F80
	public static void Serialize(Stream stream, NeonSign instance) { }

	// RVA: 0x1F881D0 Offset: 0x1F875D0 VA: 0x181F881D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F881E0 Offset: 0x1F875E0 VA: 0x181F881E0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F87E70 Offset: 0x1F87270 VA: 0x181F87E70
	public static byte[] SerializeToBytes(NeonSign instance) { }

	// RVA: 0x1F87DC0 Offset: 0x1F871C0 VA: 0x181F87DC0
	public static void SerializeLengthDelimited(Stream stream, NeonSign instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class NeonSign.Lights : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6393
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Color topLeft; // 0x14
	public Color topRight; // 0x24
	public Color bottomLeft; // 0x34
	public Color bottomRight; // 0x44

	// Methods

	// RVA: 0x1F7E8B0 Offset: 0x1F7DCB0 VA: 0x181F7E8B0
	public static void ResetToPool(NeonSign.Lights instance) { }

	// RVA: 0x1F7E950 Offset: 0x1F7DD50 VA: 0x181F7E950
	public void ResetToPool() { }

	// RVA: 0x1F7E630 Offset: 0x1F7DA30 VA: 0x181F7E630 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F7D570 Offset: 0x1F7C970 VA: 0x181F7D570
	public void CopyTo(NeonSign.Lights instance) { }

	// RVA: 0x1F7D5B0 Offset: 0x1F7C9B0 VA: 0x181F7D5B0
	public NeonSign.Lights Copy() { }

	// RVA: 0x1F7E220 Offset: 0x1F7D620 VA: 0x181F7E220
	public static NeonSign.Lights Deserialize(Stream stream) { }

	// RVA: 0x1F7D8F0 Offset: 0x1F7CCF0 VA: 0x181F7D8F0
	public static NeonSign.Lights DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F7D970 Offset: 0x1F7CD70 VA: 0x181F7D970
	public static NeonSign.Lights DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F7DCA0 Offset: 0x1F7D0A0 VA: 0x181F7DCA0
	public static NeonSign.Lights Deserialize(byte[] buffer) { }

	// RVA: 0x1F7E6B0 Offset: 0x1F7DAB0 VA: 0x181F7E6B0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F7F470 Offset: 0x1F7E870 VA: 0x181F7F470 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F7F490 Offset: 0x1F7E890 VA: 0x181F7F490 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, NeonSign.Lights previous) { }

	// RVA: 0x1F7E890 Offset: 0x1F7DC90 VA: 0x181F7E890 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F7DF70 Offset: 0x1F7D370 VA: 0x181F7DF70
	public static NeonSign.Lights Deserialize(byte[] buffer, NeonSign.Lights instance, bool isDelta = False) { }

	// RVA: 0x1F7E440 Offset: 0x1F7D840 VA: 0x181F7E440
	public static NeonSign.Lights Deserialize(Stream stream, NeonSign.Lights instance, bool isDelta) { }

	// RVA: 0x1F7D630 Offset: 0x1F7CA30 VA: 0x181F7D630
	public static NeonSign.Lights DeserializeLengthDelimited(Stream stream, NeonSign.Lights instance, bool isDelta) { }

	// RVA: 0x1F7DA00 Offset: 0x1F7CE00 VA: 0x181F7DA00
	public static NeonSign.Lights DeserializeLength(Stream stream, int length, NeonSign.Lights instance, bool isDelta) { }

	// RVA: 0x1F7E9F0 Offset: 0x1F7DDF0 VA: 0x181F7E9F0
	public static void SerializeDelta(Stream stream, NeonSign.Lights instance, NeonSign.Lights previous) { }

	// RVA: 0x1F7F0C0 Offset: 0x1F7E4C0 VA: 0x181F7F0C0
	public static void Serialize(Stream stream, NeonSign.Lights instance) { }

	// RVA: 0x1F7F460 Offset: 0x1F7E860 VA: 0x181F7F460
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F7F470 Offset: 0x1F7E870 VA: 0x181F7F470
	public void ToProto(Stream stream) { }

	// RVA: 0x1F7EFB0 Offset: 0x1F7E3B0 VA: 0x181F7EFB0
	public static byte[] SerializeToBytes(NeonSign.Lights instance) { }

	// RVA: 0x1F7EF00 Offset: 0x1F7E300 VA: 0x181F7EF00
	public static void SerializeLengthDelimited(Stream stream, NeonSign.Lights instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class NeonSign : Signage // TypeDefIndex: 8424
{	// Fields
	private Option __menuOption_SwitchToFastSpeed; // 0x3D0
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

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x7CA190 Offset: 0x7C9590 VA: 0x1807CA190 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7CC180 Offset: 0x7CB580 VA: 0x1807CC180 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x7CAC20 Offset: 0x7CA020 VA: 0x1807CAC20 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x7CA020 Offset: 0x7C9420 VA: 0x1807CA020 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0x7CAC00 Offset: 0x7CA000 VA: 0x1807CAC00 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x7CBAD0 Offset: 0x7CAED0 VA: 0x1807CBAD0
	public void UpdateNeonDisplay() { }

	// RVA: 0x7CB770 Offset: 0x7CAB70 VA: 0x1807CB770
	private void UpdateLights() { }

	// RVA: 0x7CBFE0 Offset: 0x7CB3E0 VA: 0x1807CBFE0
	private void UpdateSounds() { }

	// RVA: 0x7CABF0 Offset: 0x7C9FF0 VA: 0x1807CABF0 Slot: 171
	protected override void OnEnterTextureRange() { }

	// RVA: 0x7CB070 Offset: 0x7CA470 VA: 0x1807CB070 Slot: 169
	public override void OnTextureWasEdited(int frame, Texture2D texture, bool fromFile = False) { }

	[BaseEntity.Menu] // RVA: 0x7B050 Offset: 0x7A450 VA: 0x18007B050
	[BaseEntity.Menu.Description] // RVA: 0x7B050 Offset: 0x7A450 VA: 0x18007B050
	[BaseEntity.Menu.Icon] // RVA: 0x7B050 Offset: 0x7A450 VA: 0x18007B050
	[BaseEntity.Menu.ShowIf] // RVA: 0x7B050 Offset: 0x7A450 VA: 0x18007B050
	// RVA: 0x7CB720 Offset: 0x7CAB20 VA: 0x1807CB720
	public void SwitchToSlowSpeed(BasePlayer player) { }

	// RVA: 0x7CB660 Offset: 0x7CAA60 VA: 0x1807CB660
	public bool SwitchToSlowSpeed_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7B410 Offset: 0x7A810 VA: 0x18007B410
	[BaseEntity.Menu.Description] // RVA: 0x7B410 Offset: 0x7A810 VA: 0x18007B410
	[BaseEntity.Menu.Icon] // RVA: 0x7B410 Offset: 0x7A810 VA: 0x18007B410
	[BaseEntity.Menu.ShowIf] // RVA: 0x7B410 Offset: 0x7A810 VA: 0x18007B410
	// RVA: 0x7CB610 Offset: 0x7CAA10 VA: 0x1807CB610
	public void SwitchToMediumSpeed(BasePlayer player) { }

	// RVA: 0x7CB550 Offset: 0x7CA950 VA: 0x1807CB550
	public bool SwitchToMediumSpeed_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7B770 Offset: 0x7AB70 VA: 0x18007B770
	[BaseEntity.Menu.Description] // RVA: 0x7B770 Offset: 0x7AB70 VA: 0x18007B770
	[BaseEntity.Menu.Icon] // RVA: 0x7B770 Offset: 0x7AB70 VA: 0x18007B770
	[BaseEntity.Menu.ShowIf] // RVA: 0x7B770 Offset: 0x7AB70 VA: 0x18007B770
	// RVA: 0x7CB500 Offset: 0x7CA900 VA: 0x1807CB500
	public void SwitchToFastSpeed(BasePlayer player) { }

	// RVA: 0x7CB440 Offset: 0x7CA840 VA: 0x1807CB440
	public bool SwitchToFastSpeed_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7CB400 Offset: 0x7CA800 VA: 0x1807CB400
	public void SetFrame(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7CA930 Offset: 0x7C9D30 VA: 0x1807CA930 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x7CA030 Offset: 0x7C9430 VA: 0x1807CA030
	private void EnsureInitialized() { }

	// RVA: 0x7C9F40 Offset: 0x7C9340 VA: 0x1807C9F40
	private static Color ClampColor(Color color) { }

	// RVA: 0x7CC110 Offset: 0x7CB510 VA: 0x1807CC110
	public void .ctor() { }

}

