internal struct TouchScreenKeyboard_InternalConstructorHelperArguments // TypeDefIndex: 3559
{
	public uint keyboardType; 
	public uint autocorrection; 
	public uint multiline; 
	public uint secure; 
	public uint alert; 
	public int characterLimit; 

}

public class TouchScreenKeyboard // TypeDefIndex: 3560
{
	internal IntPtr m_Ptr; 

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


	[FreeFunctionAttribute] 
	private static void Internal_Destroy(IntPtr ptr) { }

	private void Destroy() { }

	protected override void Finalize() { }

	public void .ctor(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	[FreeFunctionAttribute] 
	private static IntPtr TouchScreenKeyboard_InternalConstructorHelper(ref TouchScreenKeyboard_InternalConstructorHelperArguments arguments, string text, string textPlaceholder) { }

	public static bool get_isSupported() { }

	public static bool get_isInPlaceEditingAllowed() { }

	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	[ExcludeFromDocsAttribute] 
	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure) { }

	[NativeNameAttribute] 
	public string get_text() { }

	[NativeNameAttribute] 
	public void set_text(string value) { }

	[NativeNameAttribute] 
	public static void set_hideInput(bool value) { }

	[NativeNameAttribute] 
	public bool get_active() { }

	[NativeNameAttribute] 
	public void set_active(bool value) { }

	[NativeNameAttribute] 
	public TouchScreenKeyboard.Status get_status() { }

	[NativeNameAttribute] 
	public void set_characterLimit(int value) { }

	[NativeNameAttribute] 
	public bool get_canGetSelection() { }

	[NativeNameAttribute] 
	public bool get_canSetSelection() { }

	public RangeInt get_selection() { }

	public void set_selection(RangeInt value) { }

	private static void GetSelection(out int start, out int length) { }

	private static void SetSelection(int start, int length) { }

}

public enum TouchScreenKeyboard.Status // TypeDefIndex: 3561
{
	public int value__; 
	public const TouchScreenKeyboard.Status Visible = 0;
	public const TouchScreenKeyboard.Status Done = 1;
	public const TouchScreenKeyboard.Status Canceled = 2;
	public const TouchScreenKeyboard.Status LostFocus = 3;

}

