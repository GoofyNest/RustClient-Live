public class DefaultSerializationBinder : SerializationBinder // TypeDefIndex: 6009
{
	internal static readonly DefaultSerializationBinder Instance;
	private readonly ThreadSafeStore<DefaultSerializationBinder.TypeNameKey, Type> _typeCache;


	private static Type GetTypeFromTypeNameKey(DefaultSerializationBinder.TypeNameKey typeNameKey) { }

	public override Type BindToType(string assemblyName, string typeName) { }

	public void .ctor() { }

	private static void .cctor() { }

}

internal struct DefaultSerializationBinder.TypeNameKey // TypeDefIndex: 6010
{
	internal readonly string AssemblyName;
	internal readonly string TypeName;


	public void .ctor(string assemblyName, string typeName) { }

	public override int GetHashCode() { }

	public override bool Equals(object obj) { }

	public bool Equals(DefaultSerializationBinder.TypeNameKey other) { }

}

