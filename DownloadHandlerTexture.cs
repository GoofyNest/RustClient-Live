public sealed class DownloadHandlerTexture : DownloadHandler // TypeDefIndex: 4753
{	// Fields
	private Texture2D mTexture; // 0x18
	private bool mHasTexture; // 0x20
	private bool mNonReadable; // 0x21

	// Properties
	public Texture2D texture { get; }

	// Methods

	// RVA: 0x231CCC0 Offset: 0x231C0C0 VA: 0x18231CCC0
	private static IntPtr Create(DownloadHandlerTexture obj, bool readable) { }

	// RVA: 0x231CEA0 Offset: 0x231C2A0 VA: 0x18231CEA0
	private void InternalCreateTexture(bool readable) { }

	// RVA: 0x231D070 Offset: 0x231C470 VA: 0x18231D070
	public void .ctor(bool readable) { }

	// RVA: 0x231CE90 Offset: 0x231C290 VA: 0x18231CE90 Slot: 5
	protected override byte[] GetData() { }

	// RVA: 0x231CF30 Offset: 0x231C330 VA: 0x18231CF30
	public Texture2D get_texture() { }

	// RVA: 0x231CF30 Offset: 0x231C330 VA: 0x18231CF30
	private Texture2D InternalGetTexture() { }

	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	// RVA: 0x231CEF0 Offset: 0x231C2F0 VA: 0x18231CEF0
	private Texture2D InternalGetTextureNative() { }

	// RVA: 0x231CD10 Offset: 0x231C110 VA: 0x18231CD10
	public static Texture2D GetContent(UnityWebRequest www) { }

}

