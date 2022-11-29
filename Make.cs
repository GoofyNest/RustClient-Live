public static class Make // TypeDefIndex: 7089
{
	public static string PrefabRoot; 
	public static Translate.Phrase phrase_on; 
	public static Translate.Phrase phrase_off; 
	public static Translate.Phrase phrase_enabled; 
	public static Translate.Phrase phrase_disabled; 


	public static LayoutElement Flex() { }

	public static RustButton Button(Translate.Phrase label, Icons icon = 61530, bool toggle = False, string style = "Normal", bool autoSize = False) { }

	public static RustButton MenuOption(Translate.Phrase label, Icons icon = 0, string style = "Normal") { }

	public static Menu Menu(Option[] options, Nullable<Option> selectedOption, bool AllowFiltering = False, string style = "Normal") { }

	public static Video Video(string style = "Normal") { }

	public static RustButton HeaderButton(Translate.Phrase label, Translate.Phrase subtitle, string style = "Header") { }

	public static RustOption Option(Option[] enumOptions, string style = "Normal") { }

	public static RustButtonGroup ButtonGroup(Option[] enumOptions, string style = "Normal") { }

	public static Dropdown Dropdown(Option[] enumOptions, string style = "Normal") { }

	public static RustInput Input(Translate.Phrase placeholder, string style = "Normal") { }

	public static RustIcon Icon(Icons icon = 63417, string style = "Normal") { }

	public static RustSlider Slider(float minValue, float maxValue, float currentValue, bool integer = False, string style = "Normal") { }

	public static RustToggle Toggle(Translate.Phrase on, Translate.Phrase off, string style = "Normal") { }

	public static Blocker Blocker(string style = "Normal") { }

	public static RustToggle ToggleOnOff(string style = "Normal") { }

	public static RustToggle ToggleEnabledDisabled(string style = "Normal") { }

	private static void .cctor() { }

}

public static class Make.Container // TypeDefIndex: 7090
{

	public static RustWrapper Toolbar(string style = "Normal") { }

	public static RustWrapper Popup(string style = "Normal") { }

	public static RustWrapper Indent(string style = "Normal") { }

	public static TabControl TabControl(string style = "Normal") { }

	public static RustLayout Vertical(string style = "Normal") { }

}

public static class Make.Form // TypeDefIndex: 7091
{

	public static RustWrapper Toolbar(string style = "Normal") { }

	public static RustWrapper Popup(string style = "Normal") { }

	public static RustWrapper Vertical(Translate.Phrase phrase, UIBehaviour control, string style = "Normal") { }

	public static RustWrapper Horizontal(Translate.Phrase phrase, UIBehaviour control, string style = "Normal") { }

}

public static class Make.Label // TypeDefIndex: 7092
{

	public static RustText Normal(Translate.Phrase text) { }

	public static RustText Small(Translate.Phrase text) { }

	public static RustText Large(Translate.Phrase text) { }

}

