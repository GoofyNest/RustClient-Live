public sealed class DownloadHandlerTexture : DownloadHandler // TypeDefIndex: 4753
{	private Texture2D mTexture; // 0x18
	private bool mHasTexture; // 0x20
	private bool mNonReadable; // 0x21

	public Texture2D texture { get; }


	private static IntPtr Create(DownloadHandlerTexture obj, bool readable) { }

	private void InternalCreateTexture(bool readable) { }

	public void .ctor(bool readable) { }

	protected override byte[] GetData() { }

	public Texture2D get_texture() { }

	private Texture2D InternalGetTexture() { }

	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	private Texture2D InternalGetTextureNative() { }

	public static Texture2D GetContent(UnityWebRequest www) { }

}

