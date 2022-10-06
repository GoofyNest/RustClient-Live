public sealed class DownloadHandlerTexture : DownloadHandler // TypeDefIndex: 4756
{
	private Texture2D mTexture; 
	private bool mHasTexture; 
	private bool mNonReadable; 

	public Texture2D texture { get; }


	private static IntPtr Create(DownloadHandlerTexture obj, bool readable) { }

	private void InternalCreateTexture(bool readable) { }

	public void .ctor(bool readable) { }

	protected override byte[] GetData() { }

	public Texture2D get_texture() { }

	private Texture2D InternalGetTexture() { }

	[NativeThrowsAttribute] 
	private Texture2D InternalGetTextureNative() { }

	public static Texture2D GetContent(UnityWebRequest www) { }

}

