public abstract class WebResponse : MarshalByRefObject, ISerializable, IDisposable // TypeDefIndex: 2911
{	// Properties
	public virtual long ContentLength { get; }
	public virtual Uri ResponseUri { get; }
	public virtual WebHeaderCollection Headers { get; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x11879A0 Offset: 0x1186DA0 VA: 0x1811879A0 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 8
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 9
	public virtual void Close() { }

	// RVA: 0x1189C70 Offset: 0x1189070 VA: 0x181189C70 Slot: 7
	public void Dispose() { }

	// RVA: 0x1189CE0 Offset: 0x11890E0 VA: 0x181189CE0 Slot: 10
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1189D90 Offset: 0x1189190 VA: 0x181189D90 Slot: 11
	public virtual long get_ContentLength() { }

	// RVA: 0x1189D50 Offset: 0x1189150 VA: 0x181189D50 Slot: 12
	public virtual Stream GetResponseStream() { }

	// RVA: 0x1189E10 Offset: 0x1189210 VA: 0x181189E10 Slot: 13
	public virtual Uri get_ResponseUri() { }

	// RVA: 0x1189DD0 Offset: 0x11891D0 VA: 0x181189DD0 Slot: 14
	public virtual WebHeaderCollection get_Headers() { }

}

