public sealed class Font : Object // TypeDefIndex: 3964
{
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private static Action<Font> textureRebuilt; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private Font.FontTextureRebuildCallback m_FontTextureRebuildCallback; 

	public Material material { get; }
	public bool dynamic { get; }
	public int fontSize { get; }


	[CompilerGeneratedAttribute] 
	public static void add_textureRebuilt(Action<Font> value) { }

	[CompilerGeneratedAttribute] 
	public static void remove_textureRebuilt(Action<Font> value) { }

	public Material get_material() { }

	public bool get_dynamic() { }

	public int get_fontSize() { }

	public void .ctor() { }

	[RequiredByNativeCodeAttribute] 
	internal static void InvokeTextureRebuilt_Internal(Font font) { }

	public bool HasCharacter(char c) { }

	private bool HasCharacter(int c) { }

	private static void Internal_CreateFont(Font self, string name) { }

}

public sealed class Font.FontTextureRebuildCallback : MulticastDelegate // TypeDefIndex: 3965
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke() { }

	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

