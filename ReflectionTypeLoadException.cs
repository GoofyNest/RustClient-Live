public sealed class ReflectionTypeLoadException : SystemException, ISerializable // TypeDefIndex: 548
{	private Type[] _classes; // 0x88
	private Exception[] _exceptions; // 0x90

	public Type[] Types { get; }


	private void .ctor() { }

	public void .ctor(Type[] classes, Exception[] exceptions) { }

	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	public Type[] get_Types() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

