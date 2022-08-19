public sealed class Font : Object // TypeDefIndex: 3959
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private static Action<Font> textureRebuilt; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private Font.FontTextureRebuildCallback m_FontTextureRebuildCallback; // 0x18

	// Properties
	public Material material { get; }
	public bool dynamic { get; }
	public int fontSize { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x23053B0 Offset: 0x23047B0 VA: 0x1823053B0
	public static void add_textureRebuilt(Action<Font> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2305520 Offset: 0x2304920 VA: 0x182305520
	public static void remove_textureRebuilt(Action<Font> value) { }

	// RVA: 0x23054E0 Offset: 0x23048E0 VA: 0x1823054E0
	public Material get_material() { }

	// RVA: 0x2305460 Offset: 0x2304860 VA: 0x182305460
	public bool get_dynamic() { }

	// RVA: 0x23054A0 Offset: 0x23048A0 VA: 0x1823054A0
	public int get_fontSize() { }

	// RVA: 0x2305330 Offset: 0x2304730 VA: 0x182305330
	public void .ctor() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x23052C0 Offset: 0x23046C0 VA: 0x1823052C0
	internal static void InvokeTextureRebuilt_Internal(Font font) { }

	// RVA: 0x23051E0 Offset: 0x23045E0 VA: 0x1823051E0
	public bool HasCharacter(char c) { }

	// RVA: 0x2305230 Offset: 0x2304630 VA: 0x182305230
	private bool HasCharacter(int c) { }

	// RVA: 0x2305270 Offset: 0x2304670 VA: 0x182305270
	private static void Internal_CreateFont(Font self, string name) { }

}

public sealed class Font.FontTextureRebuildCallback : MulticastDelegate // TypeDefIndex: 3960
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x145EF20 Offset: 0x145E320 VA: 0x18145EF20 Slot: 12
	public virtual void Invoke() { }

	// RVA: 0x497020 Offset: 0x496420 VA: 0x180497020 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

