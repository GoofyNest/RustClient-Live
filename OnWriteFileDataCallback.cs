public sealed class OnWriteFileDataCallback : MulticastDelegate // TypeDefIndex: 8912
{

	public void .ctor(object object, IntPtr method) { }

	public virtual WriteResult Invoke(ref WriteFileDataCallbackInfo data, out ArraySegment<byte> outDataBuffer) { }

	public virtual IAsyncResult BeginInvoke(ref WriteFileDataCallbackInfo data, out ArraySegment<byte> outDataBuffer, AsyncCallback callback, object object) { }

	public virtual WriteResult EndInvoke(ref WriteFileDataCallbackInfo data, out ArraySegment<byte> outDataBuffer, IAsyncResult result) { }

}

