public abstract class SerializationBinder // TypeDefIndex: 1053
{
	public virtual void BindToName(Type serializedType, out string assemblyName, out string typeName) { }

	public abstract Type BindToType(string assemblyName, string typeName);

	protected void .ctor() { }

}

