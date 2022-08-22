public class WebException : InvalidOperationException, ISerializable // TypeDefIndex: 2897
{
[Serializable]
public class WebException : InvalidOperationException, ISerializable // TypeDefIndex: 2897
	private WebExceptionStatus m_Status; // 0x88
	private WebResponse m_Response; // 0x90
	private WebExceptionInternalStatus m_InternalStatus; // 0x98

	public WebExceptionStatus Status { get; }
	public WebResponse Response { get; }


	public void .ctor() { }

	public void .ctor(string message) { }

	public void .ctor(string message, Exception innerException) { }

	public void .ctor(string message, WebExceptionStatus status) { }

	internal void .ctor(string message, WebExceptionStatus status, WebExceptionInternalStatus internalStatus, Exception innerException) { }

	public void .ctor(string message, Exception innerException, WebExceptionStatus status, WebResponse response) { }

	internal void .ctor(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response) { }

	internal void .ctor(string message, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus) { }

	internal void .ctor(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus) { }

	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	public WebExceptionStatus get_Status() { }

	public WebResponse get_Response() { }

}

