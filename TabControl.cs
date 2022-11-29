public class TabControl : RustControl // TypeDefIndex: 7078
{
	public RectTransform TabContainer; 
	public RectTransform PanelContainer; 
	public RustButton ButtonControl; 
	public float InnerPadding; 
	public bool AllowCloseAll; 
	public Image Background; 
	public Image Foreground; 


	public RustLayout Panel(string name) { }

	public RustButton Button(string name) { }

	public void AddTab(string name, Translate.Phrase buttontext, Icons icon = 62241) { }

	protected override void ApplyStyle(StyleAsset.Group s) { }

	public void .ctor() { }

}

