public class DownloadHandler : IDisposable // TypeDefIndex: 4132
{	// Fields
	[VisibleToOtherModulesAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public byte[] data { get; }
	public string text { get; }

	// Methods

	[NativeMethodAttribute] // RVA: 0x90400 Offset: 0x8F800 VA: 0x180090400
	// RVA: 0x229A400 Offset: 0x2299800 VA: 0x18229A400
	private void Release() { }

	[VisibleToOtherModulesAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	internal void .ctor() { }

	// RVA: 0x229A020 Offset: 0x2299420 VA: 0x18229A020 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2299FB0 Offset: 0x22993B0 VA: 0x182299FB0 Slot: 4
	public void Dispose() { }

	// RVA: 0x95B120 Offset: 0x95A520 VA: 0x18095B120
	public byte[] get_data() { }

	// RVA: 0x95B210 Offset: 0x95A610 VA: 0x18095B210
	public string get_text() { }

	// RVA: 0xB372A0 Offset: 0xB366A0 VA: 0x180B372A0 Slot: 5
	protected virtual byte[] GetData() { }

	// RVA: 0x229A360 Offset: 0x2299760 VA: 0x18229A360 Slot: 6
	protected virtual string GetText() { }

	// RVA: 0x229A140 Offset: 0x2299540 VA: 0x18229A140
	private Encoding GetTextEncoder() { }

	// RVA: 0x229A100 Offset: 0x2299500 VA: 0x18229A100
	private string GetContentType() { }

	// RVA: -1 Offset: -1
	protected static T GetCheckedDownloader<T>(UnityWebRequest www) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14A4670 Offset: 0x14A3A70 VA: 0x1814A4670
	|-DownloadHandler.GetCheckedDownloader<DownloadHandlerTexture>
	|-DownloadHandler.GetCheckedDownloader<object>
	*/

	[NativeThrowsAttribute] // RVA: 0x91440 Offset: 0x90840 VA: 0x180091440
	[VisibleToOtherModulesAttribute] // RVA: 0x91440 Offset: 0x90840 VA: 0x180091440
	// RVA: 0x2299EF0 Offset: 0x22992F0 VA: 0x182299EF0
	internal static byte[] InternalGetByteArray(DownloadHandler dh) { }

}

