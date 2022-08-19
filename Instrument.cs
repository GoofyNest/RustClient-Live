public class InstrumentRecording : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6368
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<InstrumentRecordingNote> notes; // 0x18
	public int forInstrument; // 0x20

	// Methods

	// RVA: 0x1C089A0 Offset: 0x1C07DA0 VA: 0x181C089A0
	public static void ResetToPool(InstrumentRecording instance) { }

	// RVA: 0x1C087C0 Offset: 0x1C07BC0 VA: 0x181C087C0
	public void ResetToPool() { }

	// RVA: 0x1C08700 Offset: 0x1C07B00 VA: 0x181C08700 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C078E0 Offset: 0x1C06CE0 VA: 0x181C078E0
	public void CopyTo(InstrumentRecording instance) { }

	// RVA: 0x1C07AB0 Offset: 0x1C06EB0 VA: 0x181C07AB0
	public InstrumentRecording Copy() { }

	// RVA: 0x1C08350 Offset: 0x1C07750 VA: 0x181C08350
	public static InstrumentRecording Deserialize(Stream stream) { }

	// RVA: 0x1C07B30 Offset: 0x1C06F30 VA: 0x181C07B30
	public static InstrumentRecording DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1C07EC0 Offset: 0x1C072C0 VA: 0x181C07EC0
	public static InstrumentRecording DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1C08230 Offset: 0x1C07630 VA: 0x181C08230
	public static InstrumentRecording Deserialize(byte[] buffer) { }

	// RVA: 0x1C08780 Offset: 0x1C07B80 VA: 0x181C08780
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1C091D0 Offset: 0x1C085D0 VA: 0x181C091D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1C091F0 Offset: 0x1C085F0 VA: 0x181C091F0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, InstrumentRecording previous) { }

	// RVA: 0x1C087A0 Offset: 0x1C07BA0 VA: 0x181C087A0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1C083D0 Offset: 0x1C077D0 VA: 0x181C083D0
	public static InstrumentRecording Deserialize(byte[] buffer, InstrumentRecording instance, bool isDelta = False) { }

	// RVA: 0x1C084D0 Offset: 0x1C078D0 VA: 0x181C084D0
	public static InstrumentRecording Deserialize(Stream stream, InstrumentRecording instance, bool isDelta) { }

	// RVA: 0x1C07BB0 Offset: 0x1C06FB0 VA: 0x181C07BB0
	public static InstrumentRecording DeserializeLengthDelimited(Stream stream, InstrumentRecording instance, bool isDelta) { }

	// RVA: 0x1C07F50 Offset: 0x1C07350 VA: 0x181C07F50
	public static InstrumentRecording DeserializeLength(Stream stream, int length, InstrumentRecording instance, bool isDelta) { }

	// RVA: 0x1C08B80 Offset: 0x1C07F80 VA: 0x181C08B80
	public static void SerializeDelta(Stream stream, InstrumentRecording instance, InstrumentRecording previous) { }

	// RVA: 0x1C08F90 Offset: 0x1C08390 VA: 0x181C08F90
	public static void Serialize(Stream stream, InstrumentRecording instance) { }

	// RVA: 0x1C091C0 Offset: 0x1C085C0 VA: 0x181C091C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1C091D0 Offset: 0x1C085D0 VA: 0x181C091D0
	public void ToProto(Stream stream) { }

	// RVA: 0x1C08E80 Offset: 0x1C08280 VA: 0x181C08E80
	public static byte[] SerializeToBytes(InstrumentRecording instance) { }

	// RVA: 0x1C08DD0 Offset: 0x1C081D0 VA: 0x181C08DD0
	public static void SerializeLengthDelimited(Stream stream, InstrumentRecording instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class InstrumentRecordingNote : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6369
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float startTime; // 0x14
	public float duration; // 0x18
	public int note; // 0x1C
	public int octave; // 0x20
	public float velocity; // 0x24
	public int noteType; // 0x28
	public bool shouldPlay; // 0x2C
	public bool hasPlayed; // 0x2D

	// Methods

	// RVA: 0x1C06FD0 Offset: 0x1C063D0 VA: 0x181C06FD0
	public static void ResetToPool(InstrumentRecordingNote instance) { }

	// RVA: 0x1C070B0 Offset: 0x1C064B0 VA: 0x181C070B0
	public void ResetToPool() { }

	// RVA: 0x1C06C10 Offset: 0x1C06010 VA: 0x181C06C10 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C05350 Offset: 0x1C04750 VA: 0x181C05350
	public void CopyTo(InstrumentRecordingNote instance) { }

	// RVA: 0x1C053A0 Offset: 0x1C047A0 VA: 0x181C053A0
	public InstrumentRecordingNote Copy() { }

	// RVA: 0x1C068A0 Offset: 0x1C05CA0 VA: 0x181C068A0
	public static InstrumentRecordingNote Deserialize(Stream stream) { }

	// RVA: 0x1C05840 Offset: 0x1C04C40 VA: 0x181C05840
	public static InstrumentRecordingNote DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1C058C0 Offset: 0x1C04CC0 VA: 0x181C058C0
	public static InstrumentRecordingNote DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1C06470 Offset: 0x1C05870 VA: 0x181C06470
	public static InstrumentRecordingNote Deserialize(byte[] buffer) { }

	// RVA: 0x1C06C90 Offset: 0x1C06090 VA: 0x181C06C90
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1C078A0 Offset: 0x1C06CA0 VA: 0x181C078A0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1C078C0 Offset: 0x1C06CC0 VA: 0x181C078C0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, InstrumentRecordingNote previous) { }

	// RVA: 0x1C06FB0 Offset: 0x1C063B0 VA: 0x181C06FB0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1C06060 Offset: 0x1C05460 VA: 0x181C06060
	public static InstrumentRecordingNote Deserialize(byte[] buffer, InstrumentRecordingNote instance, bool isDelta = False) { }

	// RVA: 0x1C05D30 Offset: 0x1C05130 VA: 0x181C05D30
	public static InstrumentRecordingNote Deserialize(Stream stream, InstrumentRecordingNote instance, bool isDelta) { }

	// RVA: 0x1C05440 Offset: 0x1C04840 VA: 0x181C05440
	public static InstrumentRecordingNote DeserializeLengthDelimited(Stream stream, InstrumentRecordingNote instance, bool isDelta) { }

	// RVA: 0x1C05950 Offset: 0x1C04D50 VA: 0x181C05950
	public static InstrumentRecordingNote DeserializeLength(Stream stream, int length, InstrumentRecordingNote instance, bool isDelta) { }

	// RVA: 0x1C07190 Offset: 0x1C06590 VA: 0x181C07190
	public static void SerializeDelta(Stream stream, InstrumentRecordingNote instance, InstrumentRecordingNote previous) { }

	// RVA: 0x1C076B0 Offset: 0x1C06AB0 VA: 0x181C076B0
	public static void Serialize(Stream stream, InstrumentRecordingNote instance) { }

	// RVA: 0x1C07890 Offset: 0x1C06C90 VA: 0x181C07890
	public byte[] ToProtoBytes() { }

	// RVA: 0x1C078A0 Offset: 0x1C06CA0 VA: 0x181C078A0
	public void ToProto(Stream stream) { }

	// RVA: 0x1C075A0 Offset: 0x1C069A0 VA: 0x181C075A0
	public static byte[] SerializeToBytes(InstrumentRecordingNote instance) { }

	// RVA: 0x1C074F0 Offset: 0x1C068F0 VA: 0x181C074F0
	public static void SerializeLengthDelimited(Stream stream, InstrumentRecordingNote instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class InstrumentMidiBindings : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6370
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<InstrumentMidiBinding> bindings; // 0x18
	public uint forInstrument; // 0x20

	// Methods

	// RVA: 0x1C04AE0 Offset: 0x1C03EE0 VA: 0x181C04AE0
	public static void ResetToPool(InstrumentMidiBindings instance) { }

	// RVA: 0x1C04900 Offset: 0x1C03D00 VA: 0x181C04900
	public void ResetToPool() { }

	// RVA: 0x1C04840 Offset: 0x1C03C40 VA: 0x181C04840 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C038D0 Offset: 0x1C02CD0 VA: 0x181C038D0
	public void CopyTo(InstrumentMidiBindings instance) { }

	// RVA: 0x1C03A80 Offset: 0x1C02E80 VA: 0x181C03A80
	public InstrumentMidiBindings Copy() { }

	// RVA: 0x1C04470 Offset: 0x1C03870 VA: 0x181C04470
	public static InstrumentMidiBindings Deserialize(Stream stream) { }

	// RVA: 0x1C03F80 Offset: 0x1C03380 VA: 0x181C03F80
	public static InstrumentMidiBindings DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1C04000 Offset: 0x1C03400 VA: 0x181C04000
	public static InstrumentMidiBindings DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1C044F0 Offset: 0x1C038F0 VA: 0x181C044F0
	public static InstrumentMidiBindings Deserialize(byte[] buffer) { }

	// RVA: 0x1C048C0 Offset: 0x1C03CC0 VA: 0x181C048C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1C05310 Offset: 0x1C04710 VA: 0x181C05310 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1C05330 Offset: 0x1C04730 VA: 0x181C05330 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, InstrumentMidiBindings previous) { }

	// RVA: 0x1C048E0 Offset: 0x1C03CE0 VA: 0x181C048E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1C04370 Offset: 0x1C03770 VA: 0x181C04370
	public static InstrumentMidiBindings Deserialize(byte[] buffer, InstrumentMidiBindings instance, bool isDelta = False) { }

	// RVA: 0x1C04610 Offset: 0x1C03A10 VA: 0x181C04610
	public static InstrumentMidiBindings Deserialize(Stream stream, InstrumentMidiBindings instance, bool isDelta) { }

	// RVA: 0x1C03C70 Offset: 0x1C03070 VA: 0x181C03C70
	public static InstrumentMidiBindings DeserializeLengthDelimited(Stream stream, InstrumentMidiBindings instance, bool isDelta) { }

	// RVA: 0x1C04090 Offset: 0x1C03490 VA: 0x181C04090
	public static InstrumentMidiBindings DeserializeLength(Stream stream, int length, InstrumentMidiBindings instance, bool isDelta) { }

	// RVA: 0x1C04CC0 Offset: 0x1C040C0 VA: 0x181C04CC0
	public static void SerializeDelta(Stream stream, InstrumentMidiBindings instance, InstrumentMidiBindings previous) { }

	// RVA: 0x1C050D0 Offset: 0x1C044D0 VA: 0x181C050D0
	public static void Serialize(Stream stream, InstrumentMidiBindings instance) { }

	// RVA: 0x1C05300 Offset: 0x1C04700 VA: 0x181C05300
	public byte[] ToProtoBytes() { }

	// RVA: 0x1C05310 Offset: 0x1C04710 VA: 0x181C05310
	public void ToProto(Stream stream) { }

	// RVA: 0x1C04FC0 Offset: 0x1C043C0 VA: 0x181C04FC0
	public static byte[] SerializeToBytes(InstrumentMidiBindings instance) { }

	// RVA: 0x1C04F10 Offset: 0x1C04310 VA: 0x181C04F10
	public static void SerializeLengthDelimited(Stream stream, InstrumentMidiBindings instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class InstrumentMidiBinding : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6371
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int noteFrom; // 0x14
	public int note; // 0x18
	public int noteOctave; // 0x1C
	public int noteType; // 0x20

	// Methods

	// RVA: 0x1C03210 Offset: 0x1C02610 VA: 0x181C03210
	public static void ResetToPool(InstrumentMidiBinding instance) { }

	// RVA: 0x1C032B0 Offset: 0x1C026B0 VA: 0x181C032B0
	public void ResetToPool() { }

	// RVA: 0x1C02F60 Offset: 0x1C02360 VA: 0x181C02F60 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C01DA0 Offset: 0x1C011A0 VA: 0x181C01DA0
	public void CopyTo(InstrumentMidiBinding instance) { }

	// RVA: 0x1C01DD0 Offset: 0x1C011D0 VA: 0x181C01DD0
	public InstrumentMidiBinding Copy() { }

	// RVA: 0x1C02D10 Offset: 0x1C02110 VA: 0x181C02D10
	public static InstrumentMidiBinding Deserialize(Stream stream) { }

	// RVA: 0x1C01E50 Offset: 0x1C01250 VA: 0x181C01E50
	public static InstrumentMidiBinding DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1C02470 Offset: 0x1C01870 VA: 0x181C02470
	public static InstrumentMidiBinding DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1C02A00 Offset: 0x1C01E00 VA: 0x181C02A00
	public static InstrumentMidiBinding Deserialize(byte[] buffer) { }

	// RVA: 0x1C02FE0 Offset: 0x1C023E0 VA: 0x181C02FE0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1C03890 Offset: 0x1C02C90 VA: 0x181C03890 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1C038B0 Offset: 0x1C02CB0 VA: 0x181C038B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, InstrumentMidiBinding previous) { }

	// RVA: 0x1C031F0 Offset: 0x1C025F0 VA: 0x181C031F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1C02500 Offset: 0x1C01900 VA: 0x181C02500
	public static InstrumentMidiBinding Deserialize(byte[] buffer, InstrumentMidiBinding instance, bool isDelta = False) { }

	// RVA: 0x1C027F0 Offset: 0x1C01BF0 VA: 0x181C027F0
	public static InstrumentMidiBinding Deserialize(Stream stream, InstrumentMidiBinding instance, bool isDelta) { }

	// RVA: 0x1C01ED0 Offset: 0x1C012D0 VA: 0x181C01ED0
	public static InstrumentMidiBinding DeserializeLengthDelimited(Stream stream, InstrumentMidiBinding instance, bool isDelta) { }

	// RVA: 0x1C021B0 Offset: 0x1C015B0 VA: 0x181C021B0
	public static InstrumentMidiBinding DeserializeLength(Stream stream, int length, InstrumentMidiBinding instance, bool isDelta) { }

	// RVA: 0x1C03350 Offset: 0x1C02750 VA: 0x181C03350
	public static void SerializeDelta(Stream stream, InstrumentMidiBinding instance, InstrumentMidiBinding previous) { }

	// RVA: 0x1C03730 Offset: 0x1C02B30 VA: 0x181C03730
	public static void Serialize(Stream stream, InstrumentMidiBinding instance) { }

	// RVA: 0x1C03880 Offset: 0x1C02C80 VA: 0x181C03880
	public byte[] ToProtoBytes() { }

	// RVA: 0x1C03890 Offset: 0x1C02C90 VA: 0x181C03890
	public void ToProto(Stream stream) { }

	// RVA: 0x1C03620 Offset: 0x1C02A20 VA: 0x181C03620
	public static byte[] SerializeToBytes(InstrumentMidiBinding instance) { }

	// RVA: 0x1C03570 Offset: 0x1C02970 VA: 0x181C03570
	public static void SerializeLengthDelimited(Stream stream, InstrumentMidiBinding instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public sealed class InstrumentNameEvent : BaseTextEvent // TypeDefIndex: 7537
{	// Methods

	// RVA: 0x1393BF0 Offset: 0x1392FF0 VA: 0x181393BF0
	public void .ctor() { }

	// RVA: 0x1393C10 Offset: 0x1393010 VA: 0x181393C10
	public void .ctor(string instrumentName) { }

	// RVA: 0x1393B30 Offset: 0x1392F30 VA: 0x181393B30 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x1393BA0 Offset: 0x1392FA0 VA: 0x181393BA0 Slot: 3
	public override string ToString() { }

}

public class InstrumentTool : HeldEntity // TypeDefIndex: 8586
{	// Fields
	public InstrumentKeyController KeyController; // 0x1F8
	public SoundDefinition DeploySound; // 0x200
	public Vector2 PitchClamp; // 0x208
	public bool UseAnimationSlotEvents; // 0x210
	public Transform MuzzleT; // 0x218
	public bool UsableByAutoTurrets; // 0x220
	private InstrumentViewmodel instrumentView; // 0x228

	// Methods

	// RVA: 0x81BFD0 Offset: 0x81B3D0 VA: 0x18081BFD0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x81B250 Offset: 0x81A650 VA: 0x18081B250 Slot: 136
	public override void ClampPitch(ref float pitch) { }

	// RVA: 0x81BDB0 Offset: 0x81B1B0 VA: 0x18081BDB0 Slot: 138
	public override void OnInput() { }

	// RVA: 0x81B5B0 Offset: 0x81A9B0 VA: 0x18081B5B0 Slot: 149
	public override float GetMovementMultiplier() { }

	// RVA: 0x81B650 Offset: 0x81AA50 VA: 0x18081B650 Slot: 157
	protected virtual void LateUpdate() { }

	// RVA: 0x81B790 Offset: 0x81AB90 VA: 0x18081B790 Slot: 141
	public override void OnDeployed() { }

	// RVA: 0x81B730 Offset: 0x81AB30 VA: 0x18081B730
	private void OnAnimationSlotSet(InstrumentKeyController.AnimationSlot slot) { }

	// RVA: 0x81BC10 Offset: 0x81B010 VA: 0x18081BC10 Slot: 143
	public override void OnHolstered() { }

	// RVA: 0x81C8E0 Offset: 0x81BCE0 VA: 0x18081C8E0 Slot: 147
	protected override void ProcessPlayerModel(PlayerModel playerModel) { }

	// RVA: 0x81BA40 Offset: 0x81AE40 VA: 0x18081BA40 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 158
	protected virtual void RemotePlayerDeploy(BasePlayer player) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 159
	protected virtual void RemotePlayerHolster(BasePlayer player) { }

	// RVA: 0x81C9F0 Offset: 0x81BDF0 VA: 0x18081C9F0 Slot: 152
	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	// RVA: 0x81CB10 Offset: 0x81BF10 VA: 0x18081CB10 Slot: 27
	public override void ResetState() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x81B2F0 Offset: 0x81A6F0 VA: 0x18081B2F0
	private void Client_PlayNote(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x81B470 Offset: 0x81A870 VA: 0x18081B470
	private void Client_StopNote(BaseEntity.RPCMessage msg) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 156
	public override bool IsInstrument() { }

	// RVA: 0x81CBE0 Offset: 0x81BFE0 VA: 0x18081CBE0
	public void .ctor() { }

}

public class InstrumentStateBehaviour : StateMachineBehaviour // TypeDefIndex: 8742
{	// Fields
	private static readonly int[] targetState; // 0x0
	private static readonly int[] states; // 0x8
	public int ignoreIndex; // 0x18
	private float lastCrossfade; // 0x1C
	public float AnimatorCrossfadeDuration; // 0x20

	// Methods

	// RVA: 0x81AD30 Offset: 0x81A130 VA: 0x18081AD30 Slot: 5
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x81B230 Offset: 0x81A630 VA: 0x18081B230
	public void .ctor() { }

	// RVA: 0x81AF30 Offset: 0x81A330 VA: 0x18081AF30
	private static void .cctor() { }

}

public class InstrumentViewmodel : MonoBehaviour // TypeDefIndex: 8743
{	// Fields
	public Animator ViewAnimator; // 0x18
	public bool UpdateA; // 0x20
	public bool UpdateB; // 0x21
	public bool UpdateC; // 0x22
	public bool UpdateD; // 0x23
	public bool UpdateE; // 0x24
	public bool UpdateF; // 0x25
	public bool UpdateG; // 0x26
	public bool UpdateRecentlyPlayed; // 0x27
	public bool UpdatePlayedNoteTrigger; // 0x28
	public bool UseTriggers; // 0x29
	private readonly int note_a; // 0x2C
	private readonly int note_b; // 0x30
	private readonly int note_c; // 0x34
	private readonly int note_d; // 0x38
	private readonly int note_e; // 0x3C
	private readonly int note_f; // 0x40
	private readonly int note_g; // 0x44
	private readonly int recentlyPlayedHash; // 0x48
	private readonly int playedNoteHash; // 0x4C

	// Methods

	// RVA: 0xA02350 Offset: 0xA01750 VA: 0x180A02350
	public void UpdateSlots(InstrumentKeyController.AnimationSlot currentSlot, bool recentlyPlayed, bool playedNoteThisFrame) { }

	// RVA: 0xA02610 Offset: 0xA01A10 VA: 0x180A02610
	private void UpdateState(int param, bool state) { }

	// RVA: 0xA02660 Offset: 0xA01A60 VA: 0x180A02660
	public void .ctor() { }

}

public class InstrumentToolGuitar : InstrumentTool // TypeDefIndex: 9467
{	// Fields
	public Transform InUseAligner; // 0x230
	public Transform DeployAligner; // 0x238
	public string DeployBone; // 0x240
	private Transform handBoneTarget; // 0x248
	private static readonly int deployHash; // 0x0

	// Methods

	// RVA: 0xA01ED0 Offset: 0xA012D0 VA: 0x180A01ED0 Slot: 157
	protected override void LateUpdate() { }

	// RVA: 0xA02250 Offset: 0xA01650 VA: 0x180A02250 Slot: 147
	protected override void ProcessPlayerModel(PlayerModel playerModel) { }

	// RVA: 0xA020F0 Offset: 0xA014F0 VA: 0x180A020F0 Slot: 145
	public override void OnReliableEvent(string name) { }

	// RVA: 0xA01E10 Offset: 0xA01210 VA: 0x180A01E10
	public void DeployBegin() { }

	// RVA: 0xA01E70 Offset: 0xA01270 VA: 0x180A01E70
	public void DeployComplete() { }

	// RVA: 0xA02210 Offset: 0xA01610 VA: 0x180A02210 Slot: 150
	public override void OnSpawnedForWorkshopPreview() { }

	// RVA: 0xA02340 Offset: 0xA01740 VA: 0x180A02340
	public void .ctor() { }

	// RVA: 0xA022F0 Offset: 0xA016F0 VA: 0x180A022F0
	private static void .cctor() { }

}

public class InstrumentDebugInput : MonoBehaviour // TypeDefIndex: 9548
{	// Fields
	public InstrumentKeyController KeyController; // 0x18
	public InstrumentKeyController.KeySet Note; // 0x20
	public float Frequency; // 0x2C
	public float StopAfter; // 0x30
	public SoundDefinition OverrideDefinition; // 0x38

	// Methods

	// RVA: 0x813970 Offset: 0x812D70 VA: 0x180813970
	public void .ctor() { }

}

public class InstrumentIKController : MonoBehaviour // TypeDefIndex: 9549
{	// Fields
	public Vector3 HitRotationVector; // 0x18
	public Transform[] LeftHandIkTargets; // 0x28
	public Transform[] LeftHandIKTargetHitRotations; // 0x30
	public Transform[] RightHandIkTargets; // 0x38
	public Transform[] RightHandIKTargetHitRotations; // 0x40
	public Transform[] RightFootIkTargets; // 0x48
	public AnimationCurve HandHeightCurve; // 0x50
	public float HandHeightMultiplier; // 0x58
	public float HandMoveLerpSpeed; // 0x5C
	public bool DebugHitRotation; // 0x60
	public AnimationCurve HandHitCurve; // 0x68
	public float NoteHitTime; // 0x70
	[HeaderAttribute] // RVA: 0x76D90 Offset: 0x76190 VA: 0x180076D90
	public float BodyLookWeight; // 0x74
	public float HeadLookWeight; // 0x78
	public float LookWeightLimit; // 0x7C
	public bool HoldHandsAtPlay; // 0x80
	private int currentLeftHandTarget; // 0x84
	private float leftHandTargetNoteTime; // 0x88
	private int currentRightHandTarget; // 0x8C
	private float rightHandTargetNoteTime; // 0x90
	private int currentRightFootTarget; // 0x94
	private float rightFootTargetNoteTime; // 0x98
	private Vector3 leftHandIkPos; // 0x9C
	private Vector3 rightHandIkPos; // 0xA8
	private Vector3 rightFootIkPos; // 0xB4
	private Transform iKWorkerTransform; // 0xC0
	private Transform rotationWorker; // 0xC8
	private float totalHandAnimTime; // 0xD0
	private float lastSetLeftHandTime; // 0xD4
	private float lastSetRightHandTime; // 0xD8
	private float lastSetRightFootTime; // 0xDC

	// Methods

	// RVA: 0x813C80 Offset: 0x813080 VA: 0x180813C80
	public void HoldHandsUpdate(InstrumentKeyController key) { }

	// RVA: 0x814210 Offset: 0x813610 VA: 0x180814210
	public void UpdateIK(BasePlayer forPlayer) { }

	// RVA: 0x8139B0 Offset: 0x812DB0 VA: 0x1808139B0
	private Vector3 GetHandHeight(float noteTime) { }

	// RVA: 0x813B40 Offset: 0x812F40 VA: 0x180813B40
	private Vector3 GetWorldSpaceIkTarget(int target, InstrumentKeyController.IKType type, Vector3 localOffset) { }

	// RVA: 0x813AB0 Offset: 0x812EB0 VA: 0x180813AB0
	private Transform GetHandTransform(int target, InstrumentKeyController.IKType type) { }

	// RVA: 0x813A40 Offset: 0x812E40 VA: 0x180813A40
	private Transform GetHandRotationTransform(int target, InstrumentKeyController.IKType type) { }

	// RVA: 0x813EA0 Offset: 0x8132A0 VA: 0x180813EA0
	public void SetIkTarget(InstrumentKeyController.IKType type, int target) { }

	// RVA: 0x814B80 Offset: 0x813F80 VA: 0x180814B80
	public void .ctor() { }

}

public class InstrumentIKTargetAttribute : PropertyAttribute // TypeDefIndex: 9550
{	// Methods

	// RVA: 0x531100 Offset: 0x530500 VA: 0x180531100
	public void .ctor() { }

}

public class InstrumentKeyController : MonoBehaviour // TypeDefIndex: 9551
{	// Fields
	public static readonly int PlayingNoteParam; // 0x0
	public static readonly int AnimationSlot1; // 0x4
	public static readonly int AnimationSlot2; // 0x8
	public static readonly int AnimationSlot3; // 0xC
	public static readonly int AnimationSlot4; // 0x10
	public static readonly int AnimationSlot5; // 0x14
	public static readonly int AnimationSlot6; // 0x18
	public static readonly int AnimationSlot7; // 0x1C
	private float lastAnimationSlotTime; // 0x18
	public Action<InstrumentKeyController.AnimationSlot> OnAnimationSlotSet; // 0x20
	private Nullable<InstrumentKeyController.AnimationSlot> setSlot; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private MicrophoneStandIOEntity <currentReceiver>k__BackingField; // 0x30
	private bool sustain; // 0x38
	private int lastMidiFrame; // 0x3C
	private int midiNotesThisFrame; // 0x40
	private InstrumentRecording activeRecording; // 0x48
	private string recordingFileName; // 0x50
	private float recordingStartTime; // 0x58
	private List<InstrumentRecordingNote> activeNotes; // 0x60
	private InstrumentRecording playingRecording; // 0x68
	private float playbackElapsedTime; // 0x70
	private List<int> stoppedNotes; // 0x78
	public const float DEFAULT_NOTE_VELOCITY = 1;
	public NoteBindingCollection Bindings; // 0x80
	public InstrumentKeyController.NoteBinding[] NoteBindings; // 0x88
	public Transform[] NoteSoundPositions; // 0x90
	public InstrumentIKController IKController; // 0x98
	public Transform LeftHandProp; // 0xA0
	public Transform RightHandProp; // 0xA8
	public Animator InstrumentAnimator; // 0xB0
	public BaseEntity RPCHandler; // 0xB8
	public uint overrideAchievementId; // 0xC0
	private const string ALL_INSTRUMENTS_ACHIEVEMENT_NAME = "PLAY_ALL_INSTRUMENTS";
	private const int INSTRUMENT_ACHIEVEMENT_COUNT = 11;
	private static HashSet<uint> playedInstruments; // 0x20
	private InstrumentKeyController.NoteBinding workerBinding; // 0xC8
	private BasePlayer midiPlayer; // 0xE0
	private bool playedFirstNote; // 0xE8
	private float teamAchievementCheck; // 0xEC
	private static bool awardedFullCollectionAchievement; // 0x28
	public TimeSince TimeInUse; // 0xF0
	private bool subscribedToMidi; // 0xF4
	private InstrumentMidiBindings activeMidiBindings; // 0xF8
	private bool hasSetupBindings; // 0x100
	private string autoplayPrefString; // 0x108
	private string autoplayDefaultName; // 0x110
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <FullKeyboardMode>k__BackingField; // 0x118
	private List<int> activeMidiNotes; // 0x120
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private InstrumentKeyController.AnimationSlot <CurrentAnimation>k__BackingField; // 0x128
	private BasePlayer OwnerPlayer; // 0x130
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <PlayedNoteThisFrame>k__BackingField; // 0x138

	// Properties
	public MicrophoneStandIOEntity currentReceiver { get; set; }
	public bool FullKeyboardMode { get; set; }
	public InstrumentKeyController.AnimationSlot CurrentAnimation { get; set; }
	public bool RecentlyPlayedNote { get; }
	private bool HeldByLocalPlayer { get; }
	private bool IsPlaying { get; }
	private int CurrentlyPlayingNotes { get; }
	public bool PlayedNoteThisFrame { get; set; }

	// Methods

	// RVA: 0x815040 Offset: 0x814440 VA: 0x180815040
	private void DisableProps() { }

	// RVA: 0x819ED0 Offset: 0x8192D0 VA: 0x180819ED0
	private void UpdateHeldProps(BasePlayer forPlayer) { }

	// RVA: 0x817DE0 Offset: 0x8171E0 VA: 0x180817DE0
	private void RunInstrumentAnimation(BasePlayer forPlayer) { }

	// RVA: 0x818360 Offset: 0x817760 VA: 0x180818360
	private void SetAnimationSlot(InstrumentKeyController.AnimationSlot slot, PlayerModel forPlayer) { }

	// RVA: 0x815130 Offset: 0x814530 VA: 0x180815130
	private int GetAnimationSlotHash(InstrumentKeyController.AnimationSlot slot) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public MicrophoneStandIOEntity get_currentReceiver() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4A2F10 Offset: 0x4A2310 VA: 0x1804A2F10
	private void set_currentReceiver(MicrophoneStandIOEntity value) { }

	// RVA: 0x8189B0 Offset: 0x817DB0 VA: 0x1808189B0
	public bool SetCurrentReceiver(MicrophoneStandIOEntity receiver) { }

	// RVA: 0x814ED0 Offset: 0x8142D0 VA: 0x180814ED0
	public void ClearReceiver() { }

	// RVA: 0x819A50 Offset: 0x818E50 VA: 0x180819A50
	public void SubscribeToMidi(BasePlayer forPlayer) { }

	// RVA: 0x81A200 Offset: 0x819600 VA: 0x18081A200
	public void UpdateMidiBindings() { }

	// RVA: 0x819CD0 Offset: 0x8190D0 VA: 0x180819CD0
	public void UnsubscribeFromMidi() { }

	// RVA: 0x817D80 Offset: 0x817180 VA: 0x180817D80
	public void ResetState() { }

	// RVA: 0x817490 Offset: 0x816890 VA: 0x180817490
	private void PlayNoteViaMIDI(int noteIndex, float velocity) { }

	// RVA: 0x8192B0 Offset: 0x8186B0 VA: 0x1808192B0
	private void StopNoteViaMIDI(int noteIndex) { }

	// RVA: 0x815C60 Offset: 0x815060 VA: 0x180815C60
	private void NoteOnDelegate(MidiChannel channel, int note, float velocity) { }

	// RVA: 0x8159C0 Offset: 0x814DC0 VA: 0x1808159C0
	private void NoteOffDelegate(MidiChannel channel, int note) { }

	// RVA: 0x8154C0 Offset: 0x8148C0 VA: 0x1808154C0
	private void KnobDelegate(MidiChannel channel, int knobNumber, float knobValue) { }

	// RVA: 0x814D10 Offset: 0x814110 VA: 0x180814D10
	private bool ApplyMidiRebinding(int inNote, out int index) { }

	// RVA: 0x814EF0 Offset: 0x8142F0 VA: 0x180814EF0
	private void ConvertMidiNoteToIndex(int note, out int index) { }

	// RVA: 0x818EB0 Offset: 0x8182B0 VA: 0x180818EB0
	public void StartRecording(string fileName) { }

	// RVA: 0x819830 Offset: 0x818C30 VA: 0x180819830
	public void StopRecording() { }

	// RVA: 0x817AE0 Offset: 0x816EE0 VA: 0x180817AE0
	private void RecordNoteStart(Notes note, int octave, float velocity, InstrumentKeyController.NoteType type, bool hold) { }

	// RVA: 0x817BD0 Offset: 0x816FD0 VA: 0x180817BD0
	private void RecordNoteStop(Notes note, int octave, InstrumentKeyController.NoteType type) { }

	// RVA: 0x817850 Offset: 0x816C50 VA: 0x180817850
	public void PlayRecording(InstrumentRecording recording) { }

	// RVA: 0x81A2A0 Offset: 0x8196A0 VA: 0x18081A2A0
	private void UpdatePlayingRecording(BasePlayer forPlayer) { }

	// RVA: 0x8197F0 Offset: 0x818BF0 VA: 0x1808197F0
	private void StopPlayingRecording() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x81AA10 Offset: 0x819E10 VA: 0x18081AA10
	public bool get_FullKeyboardMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x81AD10 Offset: 0x81A110 VA: 0x18081AD10
	private void set_FullKeyboardMode(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x81A940 Offset: 0x819D40 VA: 0x18081A940
	public InstrumentKeyController.AnimationSlot get_CurrentAnimation() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x81AD00 Offset: 0x81A100 VA: 0x18081AD00
	private void set_CurrentAnimation(InstrumentKeyController.AnimationSlot value) { }

	// RVA: 0x81ACD0 Offset: 0x81A0D0 VA: 0x18081ACD0
	public bool get_RecentlyPlayedNote() { }

	// RVA: 0x81AA20 Offset: 0x819E20 VA: 0x18081AA20
	private bool get_HeldByLocalPlayer() { }

	// RVA: 0x81ABB0 Offset: 0x819FB0 VA: 0x18081ABB0
	private bool get_IsPlaying() { }

	// RVA: 0x81A950 Offset: 0x819D50 VA: 0x18081A950
	private int get_CurrentlyPlayingNotes() { }

	// RVA: 0x818A50 Offset: 0x817E50 VA: 0x180818A50
	public void SetFullKeyboardMode(bool state) { }

	// RVA: 0x816140 Offset: 0x815540 VA: 0x180816140
	public void OnInput(BasePlayer player) { }

	// RVA: 0x816120 Offset: 0x815520 VA: 0x180816120
	private void OnDisable() { }

	// RVA: 0x8153D0 Offset: 0x8147D0 VA: 0x1808153D0
	public void InUseUpdate(BasePlayer forPlayer) { }

	// RVA: 0x8157B0 Offset: 0x814BB0 VA: 0x1808157B0
	public void LateUpdateInstrument(BasePlayer forPlayer) { }

	// RVA: 0x8173A0 Offset: 0x8167A0 VA: 0x1808173A0
	public void PlayNoteRPC(BaseEntity.RPCMessage msg, bool isLocal) { }

	// RVA: 0x8176B0 Offset: 0x816AB0 VA: 0x1808176B0
	public bool PlayNote(Notes note, InstrumentKeyController.NoteType type, int octave, float velocity, bool isLocal) { }

	// RVA: 0x819400 Offset: 0x818800 VA: 0x180819400
	public bool StopNote(Notes note, InstrumentKeyController.NoteType type, int octave) { }

	// RVA: 0x819200 Offset: 0x818600 VA: 0x180819200
	public void StopNoteRPC(BaseEntity.RPCMessage msg, bool isLocal) { }

	// RVA: 0x819030 Offset: 0x818430 VA: 0x180819030
	public void StopAllNotes(bool blockUntilRelease) { }

	// RVA: 0x819550 Offset: 0x818950 VA: 0x180819550
	public void StopOldestNote(bool blockUntilRelease, bool isVoiceStealing = False) { }

	// RVA: 0x815FD0 Offset: 0x8153D0 VA: 0x180815FD0
	public void OnClientBeginUse(BasePlayer player) { }

	// RVA: 0x818E10 Offset: 0x818210 VA: 0x180818E10
	public void SetupBindings() { }

	// RVA: 0x816070 Offset: 0x815470 VA: 0x180816070
	public void OnClientEndUse(BasePlayer player) { }

	// RVA: 0x816130 Offset: 0x815530 VA: 0x180816130
	public void OnEnable() { }

	// RVA: 0x815380 Offset: 0x814780 VA: 0x180815380
	private GameObject GetNoteSoundPosition(int index) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x81ACC0 Offset: 0x81A0C0 VA: 0x18081ACC0
	public bool get_PlayedNoteThisFrame() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x81AD20 Offset: 0x81A120 VA: 0x18081AD20
	private void set_PlayedNoteThisFrame(bool value) { }

	// RVA: 0x816C60 Offset: 0x816060 VA: 0x180816C60
	public void OnPlayerPlayedNote(Notes note, InstrumentKeyController.NoteType type, int octave, float velocity, BasePlayer player) { }

	// RVA: 0x8157C0 Offset: 0x814BC0 VA: 0x1808157C0
	private void LoadPlayedInstruments() { }

	// RVA: 0x8181B0 Offset: 0x8175B0 VA: 0x1808181B0
	private void SavePlayedInstruments() { }

	// RVA: 0x817170 Offset: 0x816570 VA: 0x180817170
	public void OnPlayerStoppedNote(Notes note, InstrumentKeyController.NoteType type, int octave) { }

	// RVA: 0x81A7F0 Offset: 0x819BF0 VA: 0x18081A7F0
	public void .ctor() { }

	// RVA: 0x81A6D0 Offset: 0x819AD0 VA: 0x18081A6D0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x819CC0 Offset: 0x8190C0 VA: 0x180819CC0
	private void <SetFullKeyboardMode>b__98_0() { }

}

public struct InstrumentKeyController.NoteBinding // TypeDefIndex: 9552
{	// Fields
	private Sound playingSound; // 0x0
	private float startedPlayingNote; // 0x8
	private float minimumNoteTime; // 0xC
	private float minimumSoundFadeOutTime; // 0x10
	private bool lastNoteState; // 0x14
	private bool blockUntilRelease; // 0x15
	public bool MidiOn; // 0x16
	public bool MouseOn; // 0x17

	// Properties
	public bool Playing { get; }
	public float PlayingDuration { get; }
	public bool RecentlyPlayedNote { get; }

	// Methods

	// RVA: 0xF8E70 Offset: 0xF8270 VA: 0x1800F8E70
	public bool get_Playing() { }

	// RVA: 0xF8E50 Offset: 0xF8250 VA: 0x1800F8E50
	public float get_PlayingDuration() { }

	// RVA: 0xF8ED0 Offset: 0xF82D0 VA: 0x1800F8ED0
	public bool get_RecentlyPlayedNote() { }

	// RVA: 0xF8D20 Offset: 0xF8120 VA: 0x1800F8D20
	private bool ButtonIsDown(Notes note, InstrumentKeyController.NoteType type) { }

	// RVA: 0xF8D30 Offset: 0xF8130 VA: 0x1800F8D30
	private bool ButtonJustPressed(Notes note, InstrumentKeyController.NoteType type) { }

	// RVA: 0xF8DF0 Offset: 0xF81F0 VA: 0x1800F8DF0
	public void Update(BasePlayer player, InstrumentKeyController keyController, int octave, NoteBindingCollection noteCollection, NoteBindingCollection.NoteData data) { }

	// RVA: 0xF8D80 Offset: 0xF8180 VA: 0x1800F8D80
	public bool PlaySound(bool isLocal, float velocity, InstrumentKeyController keyController, NoteBindingCollection noteCollection, NoteBindingCollection.NoteData data) { }

	// RVA: 0x81D4E0 Offset: 0x81C8E0 VA: 0x18081D4E0
	public static void SetupSound(bool isLocal, float velocity, NoteBindingCollection noteCollection, Sound forSound) { }

	// RVA: 0xF8DE0 Offset: 0xF81E0 VA: 0x1800F8DE0
	public bool StopPlayingNote(InstrumentKeyController keyController, bool blockUntilKeyRelease = False, bool isVoiceStealing = False) { }

	// RVA: 0xF8D10 Offset: 0xF8110 VA: 0x1800F8D10
	public void BlockKeyUntilRelease() { }

	// RVA: 0xF8D40 Offset: 0xF8140 VA: 0x1800F8D40
	private Sound CreateSound(InstrumentKeyController keyController, NoteBindingCollection.NoteData data) { }

}

public enum InstrumentKeyController.IKType // TypeDefIndex: 9553
{	// Fields
	public int value__; // 0x0
	public const InstrumentKeyController.IKType LeftHand = 0;
	public const InstrumentKeyController.IKType RightHand = 1;
	public const InstrumentKeyController.IKType RightFoot = 2;

}

public enum InstrumentKeyController.NoteType // TypeDefIndex: 9554
{	// Fields
	public int value__; // 0x0
	public const InstrumentKeyController.NoteType Regular = 0;
	public const InstrumentKeyController.NoteType Sharp = 1;

}

public enum InstrumentKeyController.InstrumentType // TypeDefIndex: 9555
{	// Fields
	public int value__; // 0x0
	public const InstrumentKeyController.InstrumentType Note = 0;
	public const InstrumentKeyController.InstrumentType Hold = 1;

}

public enum InstrumentKeyController.AnimationSlot // TypeDefIndex: 9556
{	// Fields
	public int value__; // 0x0
	public const InstrumentKeyController.AnimationSlot None = 0;
	public const InstrumentKeyController.AnimationSlot One = 1;
	public const InstrumentKeyController.AnimationSlot Two = 2;
	public const InstrumentKeyController.AnimationSlot Three = 3;
	public const InstrumentKeyController.AnimationSlot Four = 4;
	public const InstrumentKeyController.AnimationSlot Five = 5;
	public const InstrumentKeyController.AnimationSlot Six = 6;
	public const InstrumentKeyController.AnimationSlot Seven = 7;

}

public struct InstrumentKeyController.KeySet // TypeDefIndex: 9557
{	// Fields
	public Notes Note; // 0x0
	public InstrumentKeyController.NoteType NoteType; // 0x4
	public int OctaveShift; // 0x8

	// Methods

	// RVA: 0xF8C60 Offset: 0xF8060 VA: 0x1800F8C60 Slot: 3
	public override string ToString() { }

}

public struct InstrumentKeyController.NoteOverride // TypeDefIndex: 9558
{	// Fields
	public bool Override; // 0x0
	public InstrumentKeyController.KeySet Note; // 0x4

}

public struct InstrumentKeyController.IKNoteTarget // TypeDefIndex: 9559
{	// Fields
	public InstrumentKeyController.IKType TargetType; // 0x0
	public int IkIndex; // 0x4

}

public abstract class InstrumentTip : BaseTip // TypeDefIndex: 11605
{	// Properties
	public InstrumentKeyController Instrument { get; }

	// Methods

	// RVA: 0xC99EC0 Offset: 0xC992C0 VA: 0x180C99EC0
	public InstrumentKeyController get_Instrument() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0
	public bool IsKeypadHostingMusicBinds() { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	protected void .ctor() { }

}

