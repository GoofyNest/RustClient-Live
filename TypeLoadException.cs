public class TypeLoadException : SystemException, ISerializable // TypeDefIndex: 325
{	private string ClassName; // 0x88
	private string AssemblyName; // 0x90
	private string MessageArg; // 0x98
	internal int ResourceId; // 0xA0

	public override string Message { get; }


	public void .ctor() { }

	public void .ctor(string message) { }

	public override string get_Message() { }

	private void SetMessageField() { }

	private void .ctor(string className, string assemblyName) { }

	private void .ctor(string className, string assemblyName, string messageArg, int resourceId) { }

	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

