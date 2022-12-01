public class BadImageFormatException : SystemException // TypeDefIndex: 177
{
	private string _fileName;
	private string _fusionLog;

	public override string Message { get; }
	public string FusionLog { get; }


	public void .ctor() { }

	public void .ctor(string message) { }

	public void .ctor(string message, Exception inner) { }

	public void .ctor(string message, string fileName) { }

	public override string get_Message() { }

	private void SetMessageField() { }

	public override string ToString() { }

	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	public string get_FusionLog() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

