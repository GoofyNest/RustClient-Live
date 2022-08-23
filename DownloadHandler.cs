public class DownloadHandler : IDisposable // TypeDefIndex: 4132
{	[VisibleToOtherModulesAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal IntPtr m_Ptr; // 0x10

	public byte[] data { get; }
	public string text { get; }


	[NativeMethodAttribute] // RVA: 0x90400 Offset: 0x8F800 VA: 0x180090400
	private void Release() { }

	[VisibleToOtherModulesAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	[NativeThrowsAttribute] // RVA: 0x91440 Offset: 0x90840 VA: 0x180091440
	[VisibleToOtherModulesAttribute] // RVA: 0x91440 Offset: 0x90840 VA: 0x180091440
	internal static byte[] InternalGetByteArray(DownloadHandler dh) { }

}

