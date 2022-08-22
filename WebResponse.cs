public abstract class WebResponse : MarshalByRefObject, ISerializable, IDisposable // TypeDefIndex: 2911
{	public virtual long ContentLength { get; }
	public virtual Uri ResponseUri { get; }
	public virtual WebHeaderCollection Headers { get; }


	protected void .ctor() { }

	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	public virtual void Close() { }

	public void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	public virtual long get_ContentLength() { }

	public virtual Stream GetResponseStream() { }

	public virtual Uri get_ResponseUri() { }

	public virtual WebHeaderCollection get_Headers() { }

}

