public class DefaultSerializationBinder : SerializationBinder // TypeDefIndex: 6000
{	// Fields
	internal static readonly DefaultSerializationBinder Instance; // 0x0
	private readonly ThreadSafeStore<DefaultSerializationBinder.TypeNameKey, Type> _typeCache; // 0x10

	// Methods

	// RVA: 0x13EA000 Offset: 0x13E9400 VA: 0x1813EA000
	private static Type GetTypeFromTypeNameKey(DefaultSerializationBinder.TypeNameKey typeNameKey) { }

	// RVA: 0x13E9F60 Offset: 0x13E9360 VA: 0x1813E9F60 Slot: 5
	public override Type BindToType(string assemblyName, string typeName) { }

	// RVA: 0x13EA350 Offset: 0x13E9750 VA: 0x1813EA350
	public void .ctor() { }

	// RVA: 0x13EA270 Offset: 0x13E9670 VA: 0x1813EA270
	private static void .cctor() { }

}

internal struct DefaultSerializationBinder.TypeNameKey // TypeDefIndex: 6001
{	// Fields
	internal readonly string AssemblyName; // 0x0
	internal readonly string TypeName; // 0x8

	// Methods

	// RVA: 0xF5940 Offset: 0xF4D40 VA: 0x1800F5940
	public void .ctor(string assemblyName, string typeName) { }

	// RVA: 0x1EF210 Offset: 0x1EE610 VA: 0x1801EF210 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1EF160 Offset: 0x1EE560 VA: 0x1801EF160 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xF5880 Offset: 0xF4C80 VA: 0x1800F5880
	public bool Equals(DefaultSerializationBinder.TypeNameKey other) { }

}

