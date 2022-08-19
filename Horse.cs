public class Horse : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6366
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int runState; // 0x14
	public int numStorageSlots; // 0x18
	public int breedIndex; // 0x1C
	public float staminaSeconds; // 0x20
	public float currentMaxStaminaSeconds; // 0x24
	public float maxSpeed; // 0x28

	// Methods

	// RVA: 0x1BF7700 Offset: 0x1BF6B00 VA: 0x181BF7700
	public static void ResetToPool(Horse instance) { }

	// RVA: 0x1BF77C0 Offset: 0x1BF6BC0 VA: 0x181BF77C0
	public void ResetToPool() { }

	// RVA: 0x1BF7310 Offset: 0x1BF6710 VA: 0x181BF7310 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BF5DF0 Offset: 0x1BF51F0 VA: 0x181BF5DF0
	public void CopyTo(Horse instance) { }

	// RVA: 0x1BF5E30 Offset: 0x1BF5230 VA: 0x181BF5E30
	public Horse Copy() { }

	// RVA: 0x1BF6A30 Offset: 0x1BF5E30 VA: 0x181BF6A30
	public static Horse Deserialize(Stream stream) { }

	// RVA: 0x1BF5EC0 Offset: 0x1BF52C0 VA: 0x181BF5EC0
	public static Horse DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1BF6600 Offset: 0x1BF5A00 VA: 0x181BF6600
	public static Horse DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1BF6690 Offset: 0x1BF5A90 VA: 0x181BF6690
	public static Horse Deserialize(byte[] buffer) { }

	// RVA: 0x1BF7450 Offset: 0x1BF6850 VA: 0x181BF7450
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1BF7EC0 Offset: 0x1BF72C0 VA: 0x181BF7EC0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1BF7EE0 Offset: 0x1BF72E0 VA: 0x181BF7EE0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Horse previous) { }

	// RVA: 0x1BF76E0 Offset: 0x1BF6AE0 VA: 0x181BF76E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1BF6D00 Offset: 0x1BF6100 VA: 0x181BF6D00
	public static Horse Deserialize(byte[] buffer, Horse instance, bool isDelta = False) { }

	// RVA: 0x1BF7080 Offset: 0x1BF6480 VA: 0x181BF7080
	public static Horse Deserialize(Stream stream, Horse instance, bool isDelta) { }

	// RVA: 0x1BF5F40 Offset: 0x1BF5340 VA: 0x181BF5F40
	public static Horse DeserializeLengthDelimited(Stream stream, Horse instance, bool isDelta) { }

	// RVA: 0x1BF62B0 Offset: 0x1BF56B0 VA: 0x181BF62B0
	public static Horse DeserializeLength(Stream stream, int length, Horse instance, bool isDelta) { }

	// RVA: 0x1BF7880 Offset: 0x1BF6C80 VA: 0x181BF7880
	public static void SerializeDelta(Stream stream, Horse instance, Horse previous) { }

	// RVA: 0x1BF7D20 Offset: 0x1BF7120 VA: 0x181BF7D20
	public static void Serialize(Stream stream, Horse instance) { }

	// RVA: 0x1BF7EB0 Offset: 0x1BF72B0 VA: 0x181BF7EB0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1BF7EC0 Offset: 0x1BF72C0 VA: 0x181BF7EC0
	public void ToProto(Stream stream) { }

	// RVA: 0x1BF7C10 Offset: 0x1BF7010 VA: 0x181BF7C10
	public static byte[] SerializeToBytes(Horse instance) { }

	// RVA: 0x1BF7B60 Offset: 0x1BF6F60 VA: 0x181BF7B60
	public static void SerializeLengthDelimited(Stream stream, Horse instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class Horse : BaseAnimalNPC // TypeDefIndex: 8927
{	// Fields
	[ServerVar] // RVA: 0xB4180 Offset: 0xB3580 VA: 0x1800B4180
	public static float Population; // 0x1680

	// Properties
	public override float RealisticMass { get; }
	public override BaseEntity.TraitFlag Traits { get; }

	// Methods

	// RVA: 0x75BFD0 Offset: 0x75B3D0 VA: 0x18075BFD0 Slot: 76
	public override float get_RealisticMass() { }

	// RVA: 0x527A50 Offset: 0x526E50 VA: 0x180527A50 Slot: 86
	public override BaseEntity.TraitFlag get_Traits() { }

	// RVA: 0x75BFA0 Offset: 0x75B3A0 VA: 0x18075BFA0 Slot: 122
	public override string Categorize() { }

	// RVA: 0x527A30 Offset: 0x526E30 VA: 0x180527A30
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

