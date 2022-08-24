public class MissingMemberException : MemberAccessException, ISerializable // TypeDefIndex: 271
{
	protected string ClassName; 
	protected string MemberName; 
	protected byte[] Signature; 

	public override string Message { get; }


	public void .ctor() { }

	public void .ctor(string message) { }

	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	public override string get_Message() { }

	internal static string FormatSignature(byte[] signature) { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

