internal struct TouchScreenKeyboard_InternalConstructorHelperArguments // TypeDefIndex: 3559
{	public uint keyboardType; // 0x0
	public uint autocorrection; // 0x4
	public uint multiline; // 0x8
	public uint secure; // 0xC
	public uint alert; // 0x10
	public int characterLimit; // 0x14

}

public class TouchScreenKeyboard // TypeDefIndex: 3560
{	internal IntPtr m_Ptr; // 0x10

	public static bool isSupported { get; }
	public static bool isInPlaceEditingAllowed { get; }
	public string text { get; set; }
	public static bool hideInput { set; }
	public bool active { get; set; }
	public TouchScreenKeyboard.Status status { get; }
	public int characterLimit { set; }
	public bool canGetSelection { get; }
	public bool canSetSelection { get; }
	public RangeInt selection { get; set; }


	[FreeFunctionAttribute] // RVA: 0xCDEA0 Offset: 0xCD2A0 VA: 0x1800CDEA0
	private static void Internal_Destroy(IntPtr ptr) { }

	private void Destroy() { }

	protected override void Finalize() { }

	public void .ctor(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	[FreeFunctionAttribute] // RVA: 0xCE000 Offset: 0xCD400 VA: 0x1800CE000
	private static IntPtr TouchScreenKeyboard_InternalConstructorHelper(ref TouchScreenKeyboard_InternalConstructorHelperArguments arguments, string text, string textPlaceholder) { }

	public static bool get_isSupported() { }

	public static bool get_isInPlaceEditingAllowed() { }

	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure) { }

	[NativeNameAttribute] // RVA: 0xCFA40 Offset: 0xCEE40 VA: 0x1800CFA40
	public string get_text() { }

	[NativeNameAttribute] // RVA: 0xCFCA0 Offset: 0xCF0A0 VA: 0x1800CFCA0
	public void set_text(string value) { }

	[NativeNameAttribute] // RVA: 0xCFE50 Offset: 0xCF250 VA: 0x1800CFE50
	public static void set_hideInput(bool value) { }

	[NativeNameAttribute] // RVA: 0xCFEC0 Offset: 0xCF2C0 VA: 0x1800CFEC0
	public bool get_active() { }

	[NativeNameAttribute] // RVA: 0xCFF70 Offset: 0xCF370 VA: 0x1800CFF70
	public void set_active(bool value) { }

	[NativeNameAttribute] // RVA: 0xD0070 Offset: 0xCF470 VA: 0x1800D0070
	public TouchScreenKeyboard.Status get_status() { }

	[NativeNameAttribute] // RVA: 0xD02A0 Offset: 0xCF6A0 VA: 0x1800D02A0
	public void set_characterLimit(int value) { }

	[NativeNameAttribute] // RVA: 0xD02D0 Offset: 0xCF6D0 VA: 0x1800D02D0
	public bool get_canGetSelection() { }

	[NativeNameAttribute] // RVA: 0xD0330 Offset: 0xCF730 VA: 0x1800D0330
	public bool get_canSetSelection() { }

	public RangeInt get_selection() { }

	public void set_selection(RangeInt value) { }

	private static void GetSelection(out int start, out int length) { }

	private static void SetSelection(int start, int length) { }

}

public enum TouchScreenKeyboard.Status // TypeDefIndex: 3561
{	public int value__; // 0x0
	public const TouchScreenKeyboard.Status Visible = 0;
	public const TouchScreenKeyboard.Status Done = 1;
	public const TouchScreenKeyboard.Status Canceled = 2;
	public const TouchScreenKeyboard.Status LostFocus = 3;

}

