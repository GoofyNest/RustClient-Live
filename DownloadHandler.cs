public class DownloadHandler : IDisposable // TypeDefIndex: 4132
{
	[VisibleToOtherModulesAttribute] 
	internal IntPtr m_Ptr; 

	public byte[] data { get; }
	public string text { get; }


	[NativeMethodAttribute] 
	private void Release() { }

	[VisibleToOtherModulesAttribute] 
	internal void .ctor() { }

	protected override void Finalize() { }

	public void Dispose() { }

	public byte[] get_data() { }

	public string get_text() { }

	protected virtual byte[] GetData() { }

	protected virtual string GetText() { }

	private Encoding GetTextEncoder() { }

	private string GetContentType() { }

	protected static T GetCheckedDownloader<T>(UnityWebRequest www) { }
	/* GenericInstMethod :
	|
	|-DownloadHandler.GetCheckedDownloader<DownloadHandlerTexture>
	|-DownloadHandler.GetCheckedDownloader<object>
	*/

	[NativeThrowsAttribute] 
	[VisibleToOtherModulesAttribute] 
	internal static byte[] InternalGetByteArray(DownloadHandler dh) { }

}

