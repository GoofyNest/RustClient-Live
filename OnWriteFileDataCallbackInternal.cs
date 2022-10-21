internal sealed class OnWriteFileDataCallbackInternal : MulticastDelegate // TypeDefIndex: 8900
{

	public void .ctor(object object, IntPtr method) { }

	public virtual WriteResult Invoke(ref WriteFileDataCallbackInfoInternal data, IntPtr outDataBuffer, ref uint outDataWritten) { }

	public virtual IAsyncResult BeginInvoke(ref WriteFileDataCallbackInfoInternal data, IntPtr outDataBuffer, ref uint outDataWritten, AsyncCallback callback, object object) { }

	public virtual WriteResult EndInvoke(ref WriteFileDataCallbackInfoInternal data, ref uint outDataWritten, IAsyncResult result) { }

}

