public class MissingMethodException : MissingMemberException, ISerializable // TypeDefIndex: 272
{	private string signature; // 0xA0

	public override string Message { get; }


	public void .ctor() { }

	public void .ctor(string message) { }

	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	public override string get_Message() { }

	public void .ctor(string className, string methodName) { }

	private void .ctor(string className, string methodName, string signature, string message) { }

}

