public sealed class GUISkin : ScriptableObject // TypeDefIndex: 4044
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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


	public void .ctor() { }

	internal void OnEnable() { }

	internal static void CleanupRoots() { }

	public Font get_font() { }

	public void set_font(Font value) { }

	public GUIStyle get_box() { }

	public void set_box(GUIStyle value) { }

	public GUIStyle get_label() { }

	public void set_label(GUIStyle value) { }

	public GUIStyle get_textField() { }

	public void set_textField(GUIStyle value) { }

	public GUIStyle get_textArea() { }

	public void set_textArea(GUIStyle value) { }

	public GUIStyle get_button() { }

	public void set_button(GUIStyle value) { }

	public GUIStyle get_toggle() { }

	public void set_toggle(GUIStyle value) { }

	public GUIStyle get_window() { }

	public void set_window(GUIStyle value) { }

	public GUIStyle get_horizontalSlider() { }

	public void set_horizontalSlider(GUIStyle value) { }

	public GUIStyle get_horizontalSliderThumb() { }

	public void set_horizontalSliderThumb(GUIStyle value) { }

	internal GUIStyle get_horizontalSliderThumbExtent() { }

	internal void set_horizontalSliderThumbExtent(GUIStyle value) { }

	public GUIStyle get_verticalSlider() { }

	public void set_verticalSlider(GUIStyle value) { }

	public GUIStyle get_verticalSliderThumb() { }

	public void set_verticalSliderThumb(GUIStyle value) { }

	internal GUIStyle get_verticalSliderThumbExtent() { }

	internal void set_verticalSliderThumbExtent(GUIStyle value) { }

	public GUIStyle get_horizontalScrollbar() { }

	public void set_horizontalScrollbar(GUIStyle value) { }

	public GUIStyle get_horizontalScrollbarThumb() { }

	public void set_horizontalScrollbarThumb(GUIStyle value) { }

	public GUIStyle get_horizontalScrollbarLeftButton() { }

	public void set_horizontalScrollbarLeftButton(GUIStyle value) { }

	public GUIStyle get_horizontalScrollbarRightButton() { }

	public void set_horizontalScrollbarRightButton(GUIStyle value) { }

	public GUIStyle get_verticalScrollbar() { }

	public void set_verticalScrollbar(GUIStyle value) { }

	public GUIStyle get_verticalScrollbarThumb() { }

	public void set_verticalScrollbarThumb(GUIStyle value) { }

	public GUIStyle get_verticalScrollbarUpButton() { }

	public void set_verticalScrollbarUpButton(GUIStyle value) { }

	public GUIStyle get_verticalScrollbarDownButton() { }

	public void set_verticalScrollbarDownButton(GUIStyle value) { }

	public GUIStyle get_scrollView() { }

	public void set_scrollView(GUIStyle value) { }

	public GUIStyle[] get_customStyles() { }

	public void set_customStyles(GUIStyle[] value) { }

	public GUISettings get_settings() { }

	internal static GUIStyle get_error() { }

	internal void Apply() { }

	private void BuildStyleCache() { }

	public GUIStyle GetStyle(string styleName) { }

	public GUIStyle FindStyle(string styleName) { }

	internal void MakeCurrent() { }

	public IEnumerator GetEnumerator() { }

}

internal sealed class GUISkin.SkinChangedDelegate : MulticastDelegate // TypeDefIndex: 4045
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke() { }

	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

