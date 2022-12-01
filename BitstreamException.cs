public class BitstreamException : MP3SharpException // TypeDefIndex: 7401
{
	private int _ErrorCode;

	internal virtual int ErrorCode { get; }


	internal void .ctor(string message, Exception inner) { }

	internal void .ctor(int errorcode, Exception inner) { }

	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	internal virtual int get_ErrorCode() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	private void InitBlock() { }

	internal static string GetErrorString(int errorcode) { }

}

