public sealed class GUISkin : ScriptableObject // TypeDefIndex: 4044
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Font m_Font; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GUIStyle m_box; // 0x20
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GUIStyle m_button; // 0x28
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GUIStyle m_toggle; // 0x30
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GUIStyle m_label; // 0x38
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GUIStyle m_textField; // 0x40
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GUIStyle m_textArea; // 0x48
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GUIStyle m_window; // 0x50
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GUIStyle m_horizontalSlider; // 0x58
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GUIStyle m_horizontalSliderThumb; // 0x60
	private GUIStyle m_horizontalSliderThumbExtent; // 0x68
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GUIStyle m_verticalSlider; // 0x70
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GUIStyle m_verticalSliderThumb; // 0x78
	private GUIStyle m_verticalSliderThumbExtent; // 0x80
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GUIStyle m_horizontalScrollbar; // 0x88
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GUIStyle m_horizontalScrollbarThumb; // 0x90
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GUIStyle m_horizontalScrollbarLeftButton; // 0x98
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GUIStyle m_horizontalScrollbarRightButton; // 0xA0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GUIStyle m_verticalScrollbar; // 0xA8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GUIStyle m_verticalScrollbarThumb; // 0xB0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GUIStyle m_verticalScrollbarUpButton; // 0xB8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GUIStyle m_verticalScrollbarDownButton; // 0xC0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GUIStyle m_ScrollView; // 0xC8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal GUIStyle[] m_CustomStyles; // 0xD0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GUISettings m_Settings; // 0xD8
	internal static GUIStyle ms_Error; // 0x0
	private Dictionary<string, GUIStyle> m_Styles; // 0xE0
	internal static GUISkin.SkinChangedDelegate m_SkinChanged; // 0x8
	internal static GUISkin current; // 0x10

	// Properties
	public Font font { get; set; }
	public GUIStyle box { get; set; }
	public GUIStyle label { get; set; }
	public GUIStyle textField { get; set; }
	public GUIStyle textArea { get; set; }
	public GUIStyle button { get; set; }
	public GUIStyle toggle { get; set; }
	public GUIStyle window { get; set; }
	public GUIStyle horizontalSlider { get; set; }
	public GUIStyle horizontalSliderThumb { get; set; }
	internal GUIStyle horizontalSliderThumbExtent { get; set; }
	public GUIStyle verticalSlider { get; set; }
	public GUIStyle verticalSliderThumb { get; set; }
	internal GUIStyle verticalSliderThumbExtent { get; set; }
	public GUIStyle horizontalScrollbar { get; set; }
	public GUIStyle horizontalScrollbarThumb { get; set; }
	public GUIStyle horizontalScrollbarLeftButton { get; set; }
	public GUIStyle horizontalScrollbarRightButton { get; set; }
	public GUIStyle verticalScrollbar { get; set; }
	public GUIStyle verticalScrollbarThumb { get; set; }
	public GUIStyle verticalScrollbarUpButton { get; set; }
	public GUIStyle verticalScrollbarDownButton { get; set; }
	public GUIStyle scrollView { get; set; }
	public GUIStyle[] customStyles { get; set; }
	public GUISettings settings { get; }
	internal static GUIStyle error { get; }

	// Methods

	// RVA: 0x1A69780 Offset: 0x1A68B80 VA: 0x181A69780
	public void .ctor() { }

	// RVA: 0x1A67E80 Offset: 0x1A67280 VA: 0x181A67E80
	internal void OnEnable() { }

	// RVA: 0x1A69100 Offset: 0x1A68500 VA: 0x181A69100
	internal static void CleanupRoots() { }

	// RVA: 0x1818770 Offset: 0x1817B70 VA: 0x181818770
	public Font get_font() { }

	// RVA: 0x1A69C20 Offset: 0x1A69020 VA: 0x181A69C20
	public void set_font(Font value) { }

	// RVA: 0x1A5DBD0 Offset: 0x1A5CFD0 VA: 0x181A5DBD0
	public GUIStyle get_box() { }

	// RVA: 0x1A69A90 Offset: 0x1A68E90 VA: 0x181A69A90
	public void set_box(GUIStyle value) { }

	// RVA: 0x1A699E0 Offset: 0x1A68DE0 VA: 0x181A699E0
	public GUIStyle get_label() { }

	// RVA: 0x1A6A0E0 Offset: 0x1A694E0 VA: 0x181A6A0E0
	public void set_label(GUIStyle value) { }

	// RVA: 0x1A5EE80 Offset: 0x1A5E280 VA: 0x181A5EE80
	public GUIStyle get_textField() { }

	// RVA: 0x1A6A260 Offset: 0x1A69660 VA: 0x181A6A260
	public void set_textField(GUIStyle value) { }

	// RVA: 0xEBFB60 Offset: 0xEBEF60 VA: 0x180EBFB60
	public GUIStyle get_textArea() { }

	// RVA: 0x1A6A1E0 Offset: 0x1A695E0 VA: 0x181A6A1E0
	public void set_textArea(GUIStyle value) { }

	// RVA: 0x1818760 Offset: 0x1817B60 VA: 0x181818760
	public GUIStyle get_button() { }

	// RVA: 0x1A69B10 Offset: 0x1A68F10 VA: 0x181A69B10
	public void set_button(GUIStyle value) { }

	// RVA: 0xEC9460 Offset: 0xEC8860 VA: 0x180EC9460
	public GUIStyle get_toggle() { }

	// RVA: 0x1A6A2E0 Offset: 0x1A696E0 VA: 0x181A6A2E0
	public void set_toggle(GUIStyle value) { }

	// RVA: 0x1A69A80 Offset: 0x1A68E80 VA: 0x181A69A80
	public GUIStyle get_window() { }

	// RVA: 0x1A6A6E0 Offset: 0x1A69AE0 VA: 0x181A6A6E0
	public void set_window(GUIStyle value) { }

	// RVA: 0x1A699D0 Offset: 0x1A68DD0 VA: 0x181A699D0
	public GUIStyle get_horizontalSlider() { }

	// RVA: 0x1A6A060 Offset: 0x1A69460 VA: 0x181A6A060
	public void set_horizontalSlider(GUIStyle value) { }

	// RVA: 0xEBF980 Offset: 0xEBED80 VA: 0x180EBF980
	public GUIStyle get_horizontalSliderThumb() { }

	// RVA: 0x1A69FE0 Offset: 0x1A693E0 VA: 0x181A69FE0
	public void set_horizontalSliderThumb(GUIStyle value) { }

	// RVA: 0x1A699C0 Offset: 0x1A68DC0 VA: 0x181A699C0
	internal GUIStyle get_horizontalSliderThumbExtent() { }

	// RVA: 0x1A69F60 Offset: 0x1A69360 VA: 0x181A69F60
	internal void set_horizontalSliderThumbExtent(GUIStyle value) { }

	// RVA: 0x1A69A70 Offset: 0x1A68E70 VA: 0x181A69A70
	public GUIStyle get_verticalSlider() { }

	// RVA: 0x1A6A660 Offset: 0x1A69A60 VA: 0x181A6A660
	public void set_verticalSlider(GUIStyle value) { }

	// RVA: 0x1A69A60 Offset: 0x1A68E60 VA: 0x181A69A60
	public GUIStyle get_verticalSliderThumb() { }

	// RVA: 0x1A6A5E0 Offset: 0x1A699E0 VA: 0x181A6A5E0
	public void set_verticalSliderThumb(GUIStyle value) { }

	// RVA: 0x1A69A50 Offset: 0x1A68E50 VA: 0x181A69A50
	internal GUIStyle get_verticalSliderThumbExtent() { }

	// RVA: 0x1A6A560 Offset: 0x1A69960 VA: 0x181A6A560
	internal void set_verticalSliderThumbExtent(GUIStyle value) { }

	// RVA: 0x1A699B0 Offset: 0x1A68DB0 VA: 0x181A699B0
	public GUIStyle get_horizontalScrollbar() { }

	// RVA: 0x1A69EE0 Offset: 0x1A692E0 VA: 0x181A69EE0
	public void set_horizontalScrollbar(GUIStyle value) { }

	// RVA: 0x1A699A0 Offset: 0x1A68DA0 VA: 0x181A699A0
	public GUIStyle get_horizontalScrollbarThumb() { }

	// RVA: 0x1A69E60 Offset: 0x1A69260 VA: 0x181A69E60
	public void set_horizontalScrollbarThumb(GUIStyle value) { }

	// RVA: 0x1A69980 Offset: 0x1A68D80 VA: 0x181A69980
	public GUIStyle get_horizontalScrollbarLeftButton() { }

	// RVA: 0x1A69D60 Offset: 0x1A69160 VA: 0x181A69D60
	public void set_horizontalScrollbarLeftButton(GUIStyle value) { }

	// RVA: 0x1A69990 Offset: 0x1A68D90 VA: 0x181A69990
	public GUIStyle get_horizontalScrollbarRightButton() { }

	// RVA: 0x1A69DE0 Offset: 0x1A691E0 VA: 0x181A69DE0
	public void set_horizontalScrollbarRightButton(GUIStyle value) { }

	// RVA: 0x1A69A40 Offset: 0x1A68E40 VA: 0x181A69A40
	public GUIStyle get_verticalScrollbar() { }

	// RVA: 0x1A6A4E0 Offset: 0x1A698E0 VA: 0x181A6A4E0
	public void set_verticalScrollbar(GUIStyle value) { }

	// RVA: 0x1A69A20 Offset: 0x1A68E20 VA: 0x181A69A20
	public GUIStyle get_verticalScrollbarThumb() { }

	// RVA: 0x1A6A3E0 Offset: 0x1A697E0 VA: 0x181A6A3E0
	public void set_verticalScrollbarThumb(GUIStyle value) { }

	// RVA: 0x1A69A30 Offset: 0x1A68E30 VA: 0x181A69A30
	public GUIStyle get_verticalScrollbarUpButton() { }

	// RVA: 0x1A6A460 Offset: 0x1A69860 VA: 0x181A6A460
	public void set_verticalScrollbarUpButton(GUIStyle value) { }

	// RVA: 0x1A69A10 Offset: 0x1A68E10 VA: 0x181A69A10
	public GUIStyle get_verticalScrollbarDownButton() { }

	// RVA: 0x1A6A360 Offset: 0x1A69760 VA: 0x181A6A360
	public void set_verticalScrollbarDownButton(GUIStyle value) { }

	// RVA: 0x1A699F0 Offset: 0x1A68DF0 VA: 0x181A699F0
	public GUIStyle get_scrollView() { }

	// RVA: 0x1A6A160 Offset: 0x1A69560 VA: 0x181A6A160
	public void set_scrollView(GUIStyle value) { }

	// RVA: 0x1A69880 Offset: 0x1A68C80 VA: 0x181A69880
	public GUIStyle[] get_customStyles() { }

	// RVA: 0x1A69B90 Offset: 0x1A68F90 VA: 0x181A69B90
	public void set_customStyles(GUIStyle[] value) { }

	// RVA: 0x1A69A00 Offset: 0x1A68E00 VA: 0x181A69A00
	public GUISettings get_settings() { }

	// RVA: 0x1A69890 Offset: 0x1A68C90 VA: 0x181A69890
	internal static GUIStyle get_error() { }

	// RVA: 0x1A67E80 Offset: 0x1A67280 VA: 0x181A67E80
	internal void Apply() { }

	// RVA: 0x1A67EF0 Offset: 0x1A672F0 VA: 0x181A67EF0
	private void BuildStyleCache() { }

	// RVA: 0x1A692A0 Offset: 0x1A686A0 VA: 0x181A692A0
	public GUIStyle GetStyle(string styleName) { }

	// RVA: 0x1A69160 Offset: 0x1A68560 VA: 0x181A69160
	public GUIStyle FindStyle(string styleName) { }

	// RVA: 0x1A696D0 Offset: 0x1A68AD0 VA: 0x181A696D0
	internal void MakeCurrent() { }

	// RVA: 0x1A69200 Offset: 0x1A68600 VA: 0x181A69200
	public IEnumerator GetEnumerator() { }

}

internal sealed class GUISkin.SkinChangedDelegate : MulticastDelegate // TypeDefIndex: 4045
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A76FB0 Offset: 0x1A763B0 VA: 0x181A76FB0 Slot: 12
	public virtual void Invoke() { }

	// RVA: 0x497020 Offset: 0x496420 VA: 0x180497020 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

