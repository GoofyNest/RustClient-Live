public class TypeLoadException : SystemException, ISerializable // TypeDefIndex: 325
{
	private string ClassName;
	private string AssemblyName;
	private string MessageArg;
	internal int ResourceId;

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

