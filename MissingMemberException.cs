public class MissingMemberException : MemberAccessException, ISerializable // TypeDefIndex: 271
{	protected string ClassName; // 0x88
	protected string MemberName; // 0x90
	protected byte[] Signature; // 0x98

	public override string Message { get; }


	public void .ctor() { }

	public void .ctor(string message) { }

	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	public override string get_Message() { }

	internal static string FormatSignature(byte[] signature) { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

