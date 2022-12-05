public class Modifier : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6460
{
	public bool ShouldPool;
	private bool _disposed;
	public int type;
	public int source;
	public float value;
	public float timeRemaing;
	public float duration;


	public static void ResetToPool(Modifier instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(Modifier instance) { }

	public Modifier Copy() { }

	public static Modifier Deserialize(Stream stream) { }

	public static Modifier DeserializeLengthDelimited(Stream stream) { }

	public static Modifier DeserializeLength(Stream stream, int length) { }

	public static Modifier Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, Modifier previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static Modifier Deserialize(byte[] buffer, Modifier instance, bool isDelta = False) { }

	public static Modifier Deserialize(Stream stream, Modifier instance, bool isDelta) { }

	public static Modifier DeserializeLengthDelimited(Stream stream, Modifier instance, bool isDelta) { }

	public static Modifier DeserializeLength(Stream stream, int length, Modifier instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, Modifier instance, Modifier previous) { }

	public static void Serialize(Stream stream, Modifier instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(Modifier instance) { }

	public static void SerializeLengthDelimited(Stream stream, Modifier instance) { }

	public void .ctor() { }

}

public class Modifier // TypeDefIndex: 11365
{
	[CompilerGeneratedAttribute]
	private Modifier.ModifierType <Type>k__BackingField;
	[CompilerGeneratedAttribute]
	private Modifier.ModifierSource <Source>k__BackingField;
	[CompilerGeneratedAttribute]
	private float <Value>k__BackingField;
	[CompilerGeneratedAttribute]
	private float <Duration>k__BackingField;
	[CompilerGeneratedAttribute]
	private float <TimeRemaining>k__BackingField;
	[CompilerGeneratedAttribute]
	private bool <Expired>k__BackingField;
	private float lastClientUpdateTimestamp;

	public Modifier.ModifierType Type { get; set; }
	public Modifier.ModifierSource Source { get; set; }
	public float Value { get; set; }
	public float Duration { get; set; }
	public float TimeRemaining { get; set; }
	public bool Expired { get; set; }
	public float ClientEstimatedTimeRemaining { get; }


	[CompilerGeneratedAttribute]
	public Modifier.ModifierType get_Type() { }

	[CompilerGeneratedAttribute]
	private void set_Type(Modifier.ModifierType value) { }

	[CompilerGeneratedAttribute]
	public Modifier.ModifierSource get_Source() { }

	[CompilerGeneratedAttribute]
	private void set_Source(Modifier.ModifierSource value) { }

	[CompilerGeneratedAttribute]
	public float get_Value() { }

	[CompilerGeneratedAttribute]
	private void set_Value(float value) { }

	[CompilerGeneratedAttribute]
	public float get_Duration() { }

	[CompilerGeneratedAttribute]
	private void set_Duration(float value) { }

	[CompilerGeneratedAttribute]
	public float get_TimeRemaining() { }

	[CompilerGeneratedAttribute]
	private void set_TimeRemaining(float value) { }

	[CompilerGeneratedAttribute]
	public bool get_Expired() { }

	[CompilerGeneratedAttribute]
	private void set_Expired(bool value) { }

	public float get_ClientEstimatedTimeRemaining() { }

	public void Init(Modifier.ModifierType type, Modifier.ModifierSource source, float value, float duration, float remaining) { }

	public void Tick(BaseCombatEntity ownerEntity, float delta) { }

	public Modifier Save() { }

	public void Load(Modifier m) { }

	public void .ctor() { }

}

public enum Modifier.ModifierType // TypeDefIndex: 11366
{
	public int value__;
	public const Modifier.ModifierType Wood_Yield = 0;
	public const Modifier.ModifierType Ore_Yield = 1;
	public const Modifier.ModifierType Radiation_Resistance = 2;
	public const Modifier.ModifierType Radiation_Exposure_Resistance = 3;
	public const Modifier.ModifierType Max_Health = 4;
	public const Modifier.ModifierType Scrap_Yield = 5;

}

public enum Modifier.ModifierSource // TypeDefIndex: 11367
{
	public int value__;
	public const Modifier.ModifierSource Tea = 0;

}

