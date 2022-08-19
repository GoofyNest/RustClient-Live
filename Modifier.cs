public class Modifier : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6448
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int type; // 0x14
	public int source; // 0x18
	public float value; // 0x1C
	public float timeRemaing; // 0x20
	public float duration; // 0x24

	// Methods

	// RVA: 0x1F506A0 Offset: 0x1F4FAA0 VA: 0x181F506A0
	public static void ResetToPool(Modifier instance) { }

	// RVA: 0x1F50750 Offset: 0x1F4FB50 VA: 0x181F50750
	public void ResetToPool() { }

	// RVA: 0x1F50300 Offset: 0x1F4F700 VA: 0x181F50300 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E1C720 Offset: 0x1E1BB20 VA: 0x181E1C720
	public void CopyTo(Modifier instance) { }

	// RVA: 0x1F4EFD0 Offset: 0x1F4E3D0 VA: 0x181F4EFD0
	public Modifier Copy() { }

	// RVA: 0x1F50070 Offset: 0x1F4F470 VA: 0x181F50070
	public static Modifier Deserialize(Stream stream) { }

	// RVA: 0x1F4F380 Offset: 0x1F4E780 VA: 0x181F4F380
	public static Modifier DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F4F710 Offset: 0x1F4EB10 VA: 0x181F4F710
	public static Modifier DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F4F7A0 Offset: 0x1F4EBA0 VA: 0x181F4F7A0
	public static Modifier Deserialize(byte[] buffer) { }

	// RVA: 0x1F50430 Offset: 0x1F4F830 VA: 0x181F50430
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F50DD0 Offset: 0x1F501D0 VA: 0x181F50DD0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F50DF0 Offset: 0x1F501F0 VA: 0x181F50DF0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Modifier previous) { }

	// RVA: 0x1F50680 Offset: 0x1F4FA80 VA: 0x181F50680 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F4FD40 Offset: 0x1F4F140 VA: 0x181F4FD40
	public static Modifier Deserialize(byte[] buffer, Modifier instance, bool isDelta = False) { }

	// RVA: 0x1F4FAF0 Offset: 0x1F4EEF0 VA: 0x181F4FAF0
	public static Modifier Deserialize(Stream stream, Modifier instance, bool isDelta) { }

	// RVA: 0x1F4F050 Offset: 0x1F4E450 VA: 0x181F4F050
	public static Modifier DeserializeLengthDelimited(Stream stream, Modifier instance, bool isDelta) { }

	// RVA: 0x1F4F400 Offset: 0x1F4E800 VA: 0x181F4F400
	public static Modifier DeserializeLength(Stream stream, int length, Modifier instance, bool isDelta) { }

	// RVA: 0x1F50800 Offset: 0x1F4FC00 VA: 0x181F50800
	public static void SerializeDelta(Stream stream, Modifier instance, Modifier previous) { }

	// RVA: 0x1F50C50 Offset: 0x1F50050 VA: 0x181F50C50
	public static void Serialize(Stream stream, Modifier instance) { }

	// RVA: 0x1F50DC0 Offset: 0x1F501C0 VA: 0x181F50DC0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F50DD0 Offset: 0x1F501D0 VA: 0x181F50DD0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F50B40 Offset: 0x1F4FF40 VA: 0x181F50B40
	public static byte[] SerializeToBytes(Modifier instance) { }

	// RVA: 0x1F50A90 Offset: 0x1F4FE90 VA: 0x181F50A90
	public static void SerializeLengthDelimited(Stream stream, Modifier instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class Modifier // TypeDefIndex: 9622
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Modifier.ModifierType <Type>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Modifier.ModifierSource <Source>k__BackingField; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <Value>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <Duration>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <TimeRemaining>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <Expired>k__BackingField; // 0x24
	private float lastClientUpdateTimestamp; // 0x28

	// Properties
	public Modifier.ModifierType Type { get; set; }
	public Modifier.ModifierSource Source { get; set; }
	public float Value { get; set; }
	public float Duration { get; set; }
	public float TimeRemaining { get; set; }
	public bool Expired { get; set; }
	public float ClientEstimatedTimeRemaining { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	public Modifier.ModifierType get_Type() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x596240 Offset: 0x595640 VA: 0x180596240
	private void set_Type(Modifier.ModifierType value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x596230 Offset: 0x595630 VA: 0x180596230
	public Modifier.ModifierSource get_Source() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x596250 Offset: 0x595650 VA: 0x180596250
	private void set_Source(Modifier.ModifierSource value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x772410 Offset: 0x771810 VA: 0x180772410
	public float get_Value() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x772450 Offset: 0x771850 VA: 0x180772450
	private void set_Value(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7723E0 Offset: 0x7717E0 VA: 0x1807723E0
	public float get_Duration() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x772420 Offset: 0x771820 VA: 0x180772420
	private void set_Duration(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x772400 Offset: 0x771800 VA: 0x180772400
	public float get_TimeRemaining() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x772440 Offset: 0x771840 VA: 0x180772440
	private void set_TimeRemaining(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7723F0 Offset: 0x7717F0 VA: 0x1807723F0
	public bool get_Expired() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x772430 Offset: 0x771830 VA: 0x180772430
	private void set_Expired(bool value) { }

	// RVA: 0x772340 Offset: 0x771740 VA: 0x180772340
	public float get_ClientEstimatedTimeRemaining() { }

	// RVA: 0x772200 Offset: 0x771600 VA: 0x180772200
	public void Init(Modifier.ModifierType type, Modifier.ModifierSource source, float value, float duration, float remaining) { }

	// RVA: 0x772300 Offset: 0x771700 VA: 0x180772300
	public void Tick(BaseCombatEntity ownerEntity, float delta) { }

	// RVA: 0x772280 Offset: 0x771680 VA: 0x180772280
	public Modifier Save() { }

	// RVA: 0x772250 Offset: 0x771650 VA: 0x180772250
	public void Load(Modifier m) { }

	// RVA: 0x772320 Offset: 0x771720 VA: 0x180772320
	public void .ctor() { }

}

public enum Modifier.ModifierType // TypeDefIndex: 9623
{	// Fields
	public int value__; // 0x0
	public const Modifier.ModifierType Wood_Yield = 0;
	public const Modifier.ModifierType Ore_Yield = 1;
	public const Modifier.ModifierType Radiation_Resistance = 2;
	public const Modifier.ModifierType Radiation_Exposure_Resistance = 3;
	public const Modifier.ModifierType Max_Health = 4;
	public const Modifier.ModifierType Scrap_Yield = 5;

}

public enum Modifier.ModifierSource // TypeDefIndex: 9624
{	// Fields
	public int value__; // 0x0
	public const Modifier.ModifierSource Tea = 0;

}

