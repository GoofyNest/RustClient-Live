public class ObjectDisposedException : InvalidOperationException // TypeDefIndex: 280
{	private string objectName; // 0x88

	public override string Message { get; }
	public string ObjectName { get; }


	private void .ctor() { }

	public void .ctor(string objectName) { }

	public void .ctor(string objectName, string message) { }

	public override string get_Message() { }

	public string get_ObjectName() { }

	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

