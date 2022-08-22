public class TabControl : RustControl // TypeDefIndex: 7038
{	public RectTransform TabContainer; // 0x30
	public RectTransform PanelContainer; // 0x38
	public RustButton ButtonControl; // 0x40
	public float InnerPadding; // 0x48
	public bool AllowCloseAll; // 0x4C
	public Image Background; // 0x50
	public Image Foreground; // 0x58


	public RustLayout Panel(string name) { }

	public RustButton Button(string name) { }

	public void AddTab(string name, Translate.Phrase buttontext, Icons icon = 62241) { }

	protected override void ApplyStyle(StyleAsset.Group s) { }

	public void .ctor() { }

}

