public static class Make // TypeDefIndex: 7049
{	// Fields
	public static string PrefabRoot; // 0x0
	public static Translate.Phrase phrase_on; // 0x8
	public static Translate.Phrase phrase_off; // 0x10
	public static Translate.Phrase phrase_enabled; // 0x18
	public static Translate.Phrase phrase_disabled; // 0x20

	// Methods

	// RVA: 0xFBE0C0 Offset: 0xFBD4C0 VA: 0x180FBE0C0
	public static LayoutElement Flex() { }

	// RVA: 0xFBDE00 Offset: 0xFBD200 VA: 0x180FBDE00
	public static RustButton Button(Translate.Phrase label, Icons icon = 61530, bool toggle = False, string style = "Normal", bool autoSize = False) { }

	// RVA: 0xFBE5B0 Offset: 0xFBD9B0 VA: 0x180FBE5B0
	public static RustButton MenuOption(Translate.Phrase label, Icons icon = 0, string style = "Normal") { }

	// RVA: 0xFBE750 Offset: 0xFBDB50 VA: 0x180FBE750
	public static Menu Menu(Option[] options, Nullable<Option> selectedOption, bool AllowFiltering = False, string style = "Normal") { }

	// RVA: 0xFBED80 Offset: 0xFBE180 VA: 0x180FBED80
	public static Video Video(string style = "Normal") { }

	// RVA: 0xFBE160 Offset: 0xFBD560 VA: 0x180FBE160
	public static RustButton HeaderButton(Translate.Phrase label, Translate.Phrase subtitle, string style = "Header") { }

	// RVA: 0xFBE880 Offset: 0xFBDC80 VA: 0x180FBE880
	public static RustOption Option(Option[] enumOptions, string style = "Normal") { }

	// RVA: 0xFBDCC0 Offset: 0xFBD0C0 VA: 0x180FBDCC0
	public static RustButtonGroup ButtonGroup(Option[] enumOptions, string style = "Normal") { }

	// RVA: 0xFBDF80 Offset: 0xFBD380 VA: 0x180FBDF80
	public static Dropdown Dropdown(Option[] enumOptions, string style = "Normal") { }

	// RVA: 0xFBE400 Offset: 0xFBD800 VA: 0x180FBE400
	public static RustInput Input(Translate.Phrase placeholder, string style = "Normal") { }

	// RVA: 0xFBE320 Offset: 0xFBD720 VA: 0x180FBE320
	public static RustIcon Icon(Icons icon = 63417, string style = "Normal") { }

	// RVA: 0xFBE9C0 Offset: 0xFBDDC0 VA: 0x180FBE9C0
	public static RustSlider Slider(float minValue, float maxValue, float currentValue, bool integer = False, string style = "Normal") { }

	// RVA: 0xFBEBC0 Offset: 0xFBDFC0 VA: 0x180FBEBC0
	public static RustToggle Toggle(Translate.Phrase on, Translate.Phrase off, string style = "Normal") { }

	// RVA: 0xFBDC10 Offset: 0xFBD010 VA: 0x180FBDC10
	public static Blocker Blocker(string style = "Normal") { }

	// RVA: 0xFBEB50 Offset: 0xFBDF50 VA: 0x180FBEB50
	public static RustToggle ToggleOnOff(string style = "Normal") { }

	// RVA: 0xFBEAE0 Offset: 0xFBDEE0 VA: 0x180FBEAE0
	public static RustToggle ToggleEnabledDisabled(string style = "Normal") { }

	// RVA: 0xFBEE30 Offset: 0xFBE230 VA: 0x180FBEE30
	private static void .cctor() { }

}

public static class Make.Container // TypeDefIndex: 7050
{	// Methods

	// RVA: 0xFB9180 Offset: 0xFB8580 VA: 0x180FB9180
	public static RustWrapper Toolbar(string style = "Normal") { }

	// RVA: 0xFB9020 Offset: 0xFB8420 VA: 0x180FB9020
	public static RustWrapper Popup(string style = "Normal") { }

	// RVA: 0xFB8F70 Offset: 0xFB8370 VA: 0x180FB8F70
	public static RustWrapper Indent(string style = "Normal") { }

	// RVA: 0xFB90D0 Offset: 0xFB84D0 VA: 0x180FB90D0
	public static TabControl TabControl(string style = "Normal") { }

	// RVA: 0xFB9230 Offset: 0xFB8630 VA: 0x180FB9230
	public static RustLayout Vertical(string style = "Normal") { }

}

public static class Make.Form // TypeDefIndex: 7051
{	// Methods

	// RVA: 0xFBC320 Offset: 0xFBB720 VA: 0x180FBC320
	public static RustWrapper Toolbar(string style = "Normal") { }

	// RVA: 0xFBC270 Offset: 0xFBB670 VA: 0x180FBC270
	public static RustWrapper Popup(string style = "Normal") { }

	// RVA: 0xFBC3D0 Offset: 0xFBB7D0 VA: 0x180FBC3D0
	public static RustWrapper Vertical(Translate.Phrase phrase, UIBehaviour control, string style = "Normal") { }

	// RVA: 0xFBC0E0 Offset: 0xFBB4E0 VA: 0x180FBC0E0
	public static RustWrapper Horizontal(Translate.Phrase phrase, UIBehaviour control, string style = "Normal") { }

}

public static class Make.Label // TypeDefIndex: 7052
{	// Methods

	// RVA: 0xFBD760 Offset: 0xFBCB60 VA: 0x180FBD760
	public static RustText Normal(Translate.Phrase text) { }

	// RVA: 0xFBD880 Offset: 0xFBCC80 VA: 0x180FBD880
	public static RustText Small(Translate.Phrase text) { }

	// RVA: 0xFBD640 Offset: 0xFBCA40 VA: 0x180FBD640
	public static RustText Large(Translate.Phrase text) { }

}

