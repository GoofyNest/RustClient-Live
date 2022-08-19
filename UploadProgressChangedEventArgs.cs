public class UploadProgressChangedEventArgs : ProgressChangedEventArgs // TypeDefIndex: 2977
{	// Fields
	private long m_BytesReceived; // 0x20
	private long m_TotalBytesToReceive; // 0x28
	private long m_BytesSent; // 0x30
	private long m_TotalBytesToSend; // 0x38

	// Methods

	// RVA: 0x100AA80 Offset: 0x1009E80 VA: 0x18100AA80
	internal void .ctor(int progressPercentage, object userToken, long bytesSent, long totalBytesToSend, long bytesReceived, long totalBytesToReceive) { }

}

