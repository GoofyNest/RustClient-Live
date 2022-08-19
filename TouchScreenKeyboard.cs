internal struct TouchScreenKeyboard_InternalConstructorHelperArguments // TypeDefIndex: 3559
{	// Fields
	public uint keyboardType; // 0x0
	public uint autocorrection; // 0x4
	public uint multiline; // 0x8
	public uint secure; // 0xC
	public uint alert; // 0x10
	public int characterLimit; // 0x14

}

public class TouchScreenKeyboard // TypeDefIndex: 3560
{	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
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

	// Methods

	[FreeFunctionAttribute] // RVA: 0xCDEA0 Offset: 0xCD2A0 VA: 0x1800CDEA0
	// RVA: 0x2177A10 Offset: 0x2176E10 VA: 0x182177A10
	private static void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x2177810 Offset: 0x2176C10 VA: 0x182177810
	private void Destroy() { }

	// RVA: 0x21778B0 Offset: 0x2176CB0 VA: 0x1821778B0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2177DB0 Offset: 0x21771B0 VA: 0x182177DB0
	public void .ctor(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	[FreeFunctionAttribute] // RVA: 0xCE000 Offset: 0xCD400 VA: 0x1800CE000
	// RVA: 0x2177D50 Offset: 0x2177150 VA: 0x182177D50
	private static IntPtr TouchScreenKeyboard_InternalConstructorHelper(ref TouchScreenKeyboard_InternalConstructorHelperArguments arguments, string text, string textPlaceholder) { }

	// RVA: 0x2177FA0 Offset: 0x21773A0 VA: 0x182177FA0
	public static bool get_isSupported() { }

	// RVA: 0x48A4F0 Offset: 0x4898F0 VA: 0x18048A4F0
	public static bool get_isInPlaceEditingAllowed() { }

	// RVA: 0x2177BC0 Offset: 0x2176FC0 VA: 0x182177BC0
	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2177A50 Offset: 0x2176E50 VA: 0x182177A50
	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure) { }

	[NativeNameAttribute] // RVA: 0xCFA40 Offset: 0xCEE40 VA: 0x1800CFA40
	// RVA: 0x2178080 Offset: 0x2177480 VA: 0x182178080
	public string get_text() { }

	[NativeNameAttribute] // RVA: 0xCFCA0 Offset: 0xCF0A0 VA: 0x1800CFCA0
	// RVA: 0x2178280 Offset: 0x2177680 VA: 0x182178280
	public void set_text(string value) { }

	[NativeNameAttribute] // RVA: 0xCFE50 Offset: 0xCF250 VA: 0x1800CFE50
	// RVA: 0x2178150 Offset: 0x2177550 VA: 0x182178150
	public static void set_hideInput(bool value) { }

	[NativeNameAttribute] // RVA: 0xCFEC0 Offset: 0xCF2C0 VA: 0x1800CFEC0
	// RVA: 0x2177EE0 Offset: 0x21772E0 VA: 0x182177EE0
	public bool get_active() { }

	[NativeNameAttribute] // RVA: 0xCFF70 Offset: 0xCF370 VA: 0x1800CFF70
	// RVA: 0x21780C0 Offset: 0x21774C0 VA: 0x1821780C0
	public void set_active(bool value) { }

	[NativeNameAttribute] // RVA: 0xD0070 Offset: 0xCF470 VA: 0x1800D0070
	// RVA: 0x2178040 Offset: 0x2177440 VA: 0x182178040
	public TouchScreenKeyboard.Status get_status() { }

	[NativeNameAttribute] // RVA: 0xD02A0 Offset: 0xCF6A0 VA: 0x1800D02A0
	// RVA: 0x2178110 Offset: 0x2177510 VA: 0x182178110
	public void set_characterLimit(int value) { }

	[NativeNameAttribute] // RVA: 0xD02D0 Offset: 0xCF6D0 VA: 0x1800D02D0
	// RVA: 0x2177F20 Offset: 0x2177320 VA: 0x182177F20
	public bool get_canGetSelection() { }

	[NativeNameAttribute] // RVA: 0xD0330 Offset: 0xCF730 VA: 0x1800D0330
	// RVA: 0x2177F60 Offset: 0x2177360 VA: 0x182177F60
	public bool get_canSetSelection() { }

	// RVA: 0x2177FF0 Offset: 0x21773F0 VA: 0x182177FF0
	public RangeInt get_selection() { }

	// RVA: 0x2178190 Offset: 0x2177590 VA: 0x182178190
	public void set_selection(RangeInt value) { }

	// RVA: 0x21779C0 Offset: 0x2176DC0 VA: 0x1821779C0
	private static void GetSelection(out int start, out int length) { }

	// RVA: 0x2177D10 Offset: 0x2177110 VA: 0x182177D10
	private static void SetSelection(int start, int length) { }

}

public enum TouchScreenKeyboard.Status // TypeDefIndex: 3561
{	// Fields
	public int value__; // 0x0
	public const TouchScreenKeyboard.Status Visible = 0;
	public const TouchScreenKeyboard.Status Done = 1;
	public const TouchScreenKeyboard.Status Canceled = 2;
	public const TouchScreenKeyboard.Status LostFocus = 3;

}

