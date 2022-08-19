public class FontData : ISerializationCallbackReceiver // TypeDefIndex: 4928
{	// Fields
	[SerializeField] // RVA: 0xE9380 Offset: 0xE8780 VA: 0x1800E9380
	[FormerlySerializedAsAttribute] // RVA: 0xE9380 Offset: 0xE8780 VA: 0x1800E9380
	private Font m_Font; // 0x10
	[SerializeField] // RVA: 0xE94A0 Offset: 0xE88A0 VA: 0x1800E94A0
	[FormerlySerializedAsAttribute] // RVA: 0xE94A0 Offset: 0xE88A0 VA: 0x1800E94A0
	private int m_FontSize; // 0x18
	[SerializeField] // RVA: 0xE9680 Offset: 0xE8A80 VA: 0x1800E9680
	[FormerlySerializedAsAttribute] // RVA: 0xE9680 Offset: 0xE8A80 VA: 0x1800E9680
	private FontStyle m_FontStyle; // 0x1C
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_BestFit; // 0x20
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int m_MinSize; // 0x24
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int m_MaxSize; // 0x28
	[SerializeField] // RVA: 0xE9AF0 Offset: 0xE8EF0 VA: 0x1800E9AF0
	[FormerlySerializedAsAttribute] // RVA: 0xE9AF0 Offset: 0xE8EF0 VA: 0x1800E9AF0
	private TextAnchor m_Alignment; // 0x2C
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_AlignByGeometry; // 0x30
	[SerializeField] // RVA: 0xE9D90 Offset: 0xE9190 VA: 0x1800E9D90
	[FormerlySerializedAsAttribute] // RVA: 0xE9D90 Offset: 0xE9190 VA: 0x1800E9D90
	private bool m_RichText; // 0x31
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private HorizontalWrapMode m_HorizontalOverflow; // 0x34
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private VerticalWrapMode m_VerticalOverflow; // 0x38
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_LineSpacing; // 0x3C

	// Properties
	public static FontData defaultFontData { get; }
	public Font font { get; set; }
	public int fontSize { get; set; }
	public FontStyle fontStyle { get; set; }
	public bool bestFit { get; set; }
	public int minSize { get; set; }
	public int maxSize { get; set; }
	public TextAnchor alignment { get; set; }
	public bool alignByGeometry { get; set; }
	public bool richText { get; set; }
	public HorizontalWrapMode horizontalOverflow { get; set; }
	public VerticalWrapMode verticalOverflow { get; set; }
	public float lineSpacing { get; set; }

	// Methods

	// RVA: 0x15E5590 Offset: 0x15E4990 VA: 0x1815E5590
	public static FontData get_defaultFontData() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public Font get_font() { }

	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	public void set_font(Font value) { }

	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200
	public int get_fontSize() { }

	// RVA: 0x7E8E20 Offset: 0x7E8220 VA: 0x1807E8E20
	public void set_fontSize(int value) { }

	// RVA: 0x4BE1F0 Offset: 0x4BD5F0 VA: 0x1804BE1F0
	public FontStyle get_fontStyle() { }

	// RVA: 0x95B2E0 Offset: 0x95A6E0 VA: 0x18095B2E0
	public void set_fontStyle(FontStyle value) { }

	// RVA: 0xB0BB80 Offset: 0xB0AF80 VA: 0x180B0BB80
	public bool get_bestFit() { }

	// RVA: 0x7D99E0 Offset: 0x7D8DE0 VA: 0x1807D99E0
	public void set_bestFit(bool value) { }

	// RVA: 0x7E8DA0 Offset: 0x7E81A0 VA: 0x1807E8DA0
	public int get_minSize() { }

	// RVA: 0x7E8E00 Offset: 0x7E8200 VA: 0x1807E8E00
	public void set_minSize(int value) { }

	// RVA: 0x4BB390 Offset: 0x4BA790 VA: 0x1804BB390
	public int get_maxSize() { }

	// RVA: 0x7E8DF0 Offset: 0x7E81F0 VA: 0x1807E8DF0
	public void set_maxSize(int value) { }

	// RVA: 0x5F7BF0 Offset: 0x5F6FF0 VA: 0x1805F7BF0
	public TextAnchor get_alignment() { }

	// RVA: 0x10B2ED0 Offset: 0x10B22D0 VA: 0x1810B2ED0
	public void set_alignment(TextAnchor value) { }

	// RVA: 0x8298F0 Offset: 0x828CF0 VA: 0x1808298F0
	public bool get_alignByGeometry() { }

	// RVA: 0x829920 Offset: 0x828D20 VA: 0x180829920
	public void set_alignByGeometry(bool value) { }

	// RVA: 0xFF6160 Offset: 0xFF5560 VA: 0x180FF6160
	public bool get_richText() { }

	// RVA: 0x15E5610 Offset: 0x15E4A10 VA: 0x1815E5610
	public void set_richText(bool value) { }

	// RVA: 0x5FC780 Offset: 0x5FBB80 VA: 0x1805FC780
	public HorizontalWrapMode get_horizontalOverflow() { }

	// RVA: 0xD6ED70 Offset: 0xD6E170 VA: 0x180D6ED70
	public void set_horizontalOverflow(HorizontalWrapMode value) { }

	// RVA: 0x516B70 Offset: 0x515F70 VA: 0x180516B70
	public VerticalWrapMode get_verticalOverflow() { }

	// RVA: 0xC53FC0 Offset: 0xC533C0 VA: 0x180C53FC0
	public void set_verticalOverflow(VerticalWrapMode value) { }

	// RVA: 0xA004A0 Offset: 0x9FF8A0 VA: 0x180A004A0
	public float get_lineSpacing() { }

	// RVA: 0x53BBE0 Offset: 0x53AFE0 VA: 0x18053BBE0
	public void set_lineSpacing(float value) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 4
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x15E54F0 Offset: 0x15E48F0 VA: 0x1815E54F0 Slot: 5
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

