public sealed class TypeInitializationException : SystemException // TypeDefIndex: 324
{
	private string _typeName;

	public string TypeName { get; }


	private void .ctor() { }

	public void .ctor(string fullTypeName, Exception innerException) { }

	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	public string get_TypeName() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

