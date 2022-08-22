public class DefaultSerializationBinder : SerializationBinder // TypeDefIndex: 6000
{	internal static readonly DefaultSerializationBinder Instance; // 0x0
	private readonly ThreadSafeStore<DefaultSerializationBinder.TypeNameKey, Type> _typeCache; // 0x10


	private static Type GetTypeFromTypeNameKey(DefaultSerializationBinder.TypeNameKey typeNameKey) { }

	public override Type BindToType(string assemblyName, string typeName) { }

	public void .ctor() { }

	private static void .cctor() { }

}

internal struct DefaultSerializationBinder.TypeNameKey // TypeDefIndex: 6001
{	internal readonly string AssemblyName; // 0x0
	internal readonly string TypeName; // 0x8


	public void .ctor(string assemblyName, string typeName) { }

	public override int GetHashCode() { }

	public override bool Equals(object obj) { }

	public bool Equals(DefaultSerializationBinder.TypeNameKey other) { }

}

