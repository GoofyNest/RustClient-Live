public class WebException : InvalidOperationException, ISerializable // TypeDefIndex: 2897
{
// Namespace: System.Net
[Serializable]
public class WebException : InvalidOperationException, ISerializable // TypeDefIndex: 2897
	// Fields
	private WebExceptionStatus m_Status; // 0x88
	private WebResponse m_Response; // 0x90
	private WebExceptionInternalStatus m_InternalStatus; // 0x98

	// Properties
	public WebExceptionStatus Status { get; }
	public WebResponse Response { get; }

	// Methods

	// RVA: 0x11833C0 Offset: 0x11827C0 VA: 0x1811833C0
	public void .ctor() { }

	// RVA: 0x11834F0 Offset: 0x11828F0 VA: 0x1811834F0
	public void .ctor(string message) { }

	// RVA: 0x11834D0 Offset: 0x11828D0 VA: 0x1811834D0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x1183510 Offset: 0x1182910 VA: 0x181183510
	public void .ctor(string message, WebExceptionStatus status) { }

	// RVA: 0x11836A0 Offset: 0x1182AA0 VA: 0x1811836A0
	internal void .ctor(string message, WebExceptionStatus status, WebExceptionInternalStatus internalStatus, Exception innerException) { }

	// RVA: 0x1183530 Offset: 0x1182930 VA: 0x181183530
	public void .ctor(string message, Exception innerException, WebExceptionStatus status, WebResponse response) { }

	// RVA: 0x1183410 Offset: 0x1182810 VA: 0x181183410
	internal void .ctor(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response) { }

	// RVA: 0x1183310 Offset: 0x1182710 VA: 0x181183310
	internal void .ctor(string message, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus) { }

	// RVA: 0x11835D0 Offset: 0x11829D0 VA: 0x1811835D0
	internal void .ctor(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus) { }

	// RVA: 0x11833E0 Offset: 0x11827E0 VA: 0x1811833E0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x11832E0 Offset: 0x11826E0 VA: 0x1811832E0 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0xFF63E0 Offset: 0xFF57E0 VA: 0x180FF63E0 Slot: 10
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x5A44D0 Offset: 0x5A38D0 VA: 0x1805A44D0
	public WebExceptionStatus get_Status() { }

	// RVA: 0x4E09F0 Offset: 0x4DFDF0 VA: 0x1804E09F0
	public WebResponse get_Response() { }

}

