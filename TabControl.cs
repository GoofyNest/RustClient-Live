public class TabControl : RustControl // TypeDefIndex: 7038
{	// Fields
	public RectTransform TabContainer; // 0x30
	public RectTransform PanelContainer; // 0x38
	public RustButton ButtonControl; // 0x40
	public float InnerPadding; // 0x48
	public bool AllowCloseAll; // 0x4C
	public Image Background; // 0x50
	public Image Foreground; // 0x58

	// Methods

	// RVA: 0xFCF240 Offset: 0xFCE640 VA: 0x180FCF240
	public RustLayout Panel(string name) { }

	// RVA: 0xFCF1D0 Offset: 0xFCE5D0 VA: 0x180FCF1D0
	public RustButton Button(string name) { }

	// RVA: 0xFCEBF0 Offset: 0xFCDFF0 VA: 0x180FCEBF0
	public void AddTab(string name, Translate.Phrase buttontext, Icons icon = 62241) { }

	// RVA: 0xFCF0C0 Offset: 0xFCE4C0 VA: 0x180FCF0C0 Slot: 30
	protected override void ApplyStyle(StyleAsset.Group s) { }

	// RVA: 0xFCF2B0 Offset: 0xFCE6B0 VA: 0x180FCF2B0
	public void .ctor() { }

}

