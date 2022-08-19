public class Text : MaskableGraphic, ILayoutElement // TypeDefIndex: 5014
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private FontData m_FontData; // 0xC8
	[TextAreaAttribute] // RVA: 0x7D8B0 Offset: 0x7CCB0 VA: 0x18007D8B0
	[SerializeField] // RVA: 0x7D8B0 Offset: 0x7CCB0 VA: 0x18007D8B0
	protected string m_Text; // 0xD0
	private TextGenerator m_TextCache; // 0xD8
	private TextGenerator m_TextCacheForLayout; // 0xE0
	protected static Material s_DefaultText; // 0x0
	protected bool m_DisableFontTextureRebuiltCallback; // 0xE8
	private readonly UIVertex[] m_TempVerts; // 0xF0

	// Properties
	public TextGenerator cachedTextGenerator { get; }
	public TextGenerator cachedTextGeneratorForLayout { get; }
	public override Texture mainTexture { get; }
	public Font font { get; set; }
	public virtual string text { get; set; }
	public bool supportRichText { get; set; }
	public bool resizeTextForBestFit { get; set; }
	public int resizeTextMinSize { get; set; }
	public int resizeTextMaxSize { get; set; }
	public TextAnchor alignment { get; set; }
	public bool alignByGeometry { get; set; }
	public int fontSize { get; set; }
	public HorizontalWrapMode horizontalOverflow { get; set; }
	public VerticalWrapMode verticalOverflow { get; set; }
	public float lineSpacing { get; set; }
	public FontStyle fontStyle { get; set; }
	public float pixelsPerUnit { get; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }

	// Methods

	// RVA: 0x2240C90 Offset: 0x2240090 VA: 0x182240C90
	protected void .ctor() { }

	// RVA: 0x2240DF0 Offset: 0x22401F0 VA: 0x182240DF0
	public TextGenerator get_cachedTextGenerator() { }

	// RVA: 0x2240D70 Offset: 0x2240170 VA: 0x182240D70
	public TextGenerator get_cachedTextGeneratorForLayout() { }

	// RVA: 0x2240F30 Offset: 0x2240330 VA: 0x182240F30 Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0x223FF20 Offset: 0x223F320 VA: 0x18223FF20
	public void FontTextureChanged() { }

	// RVA: 0x2240ED0 Offset: 0x22402D0 VA: 0x182240ED0
	public Font get_font() { }

	// RVA: 0x2241750 Offset: 0x2240B50 VA: 0x182241750
	public void set_font(Font value) { }

	// RVA: 0xC53130 Offset: 0xC52530 VA: 0x180C53130 Slot: 72
	public virtual string get_text() { }

	// RVA: 0x2241A80 Offset: 0x2240E80 VA: 0x182241A80 Slot: 73
	public virtual void set_text(string value) { }

	// RVA: 0x22415B0 Offset: 0x22409B0 VA: 0x1822415B0
	public bool get_supportRichText() { }

	// RVA: 0x2241A20 Offset: 0x2240E20 VA: 0x182241A20
	public void set_supportRichText(bool value) { }

	// RVA: 0x2241550 Offset: 0x2240950 VA: 0x182241550
	public bool get_resizeTextForBestFit() { }

	// RVA: 0x2241900 Offset: 0x2240D00 VA: 0x182241900
	public void set_resizeTextForBestFit(bool value) { }

	// RVA: 0x2241590 Offset: 0x2240990 VA: 0x182241590
	public int get_resizeTextMinSize() { }

	// RVA: 0x22419C0 Offset: 0x2240DC0 VA: 0x1822419C0
	public void set_resizeTextMinSize(int value) { }

	// RVA: 0x2241570 Offset: 0x2240970 VA: 0x182241570
	public int get_resizeTextMaxSize() { }

	// RVA: 0x2241960 Offset: 0x2240D60 VA: 0x182241960
	public void set_resizeTextMaxSize(int value) { }

	// RVA: 0x2240D50 Offset: 0x2240150 VA: 0x182240D50
	public TextAnchor get_alignment() { }

	// RVA: 0x2241630 Offset: 0x2240A30 VA: 0x182241630
	public void set_alignment(TextAnchor value) { }

	// RVA: 0x2240D30 Offset: 0x2240130 VA: 0x182240D30
	public bool get_alignByGeometry() { }

	// RVA: 0x22415F0 Offset: 0x22409F0 VA: 0x1822415F0
	public void set_alignByGeometry(bool value) { }

	// RVA: 0x2240E90 Offset: 0x2240290 VA: 0x182240E90
	public int get_fontSize() { }

	// RVA: 0x2241690 Offset: 0x2240A90 VA: 0x182241690
	public void set_fontSize(int value) { }

	// RVA: 0x2240EF0 Offset: 0x22402F0 VA: 0x182240EF0
	public HorizontalWrapMode get_horizontalOverflow() { }

	// RVA: 0x2241840 Offset: 0x2240C40 VA: 0x182241840
	public void set_horizontalOverflow(HorizontalWrapMode value) { }

	// RVA: 0x22415D0 Offset: 0x22409D0 VA: 0x1822415D0
	public VerticalWrapMode get_verticalOverflow() { }

	// RVA: 0x2241B70 Offset: 0x2240F70 VA: 0x182241B70
	public void set_verticalOverflow(VerticalWrapMode value) { }

	// RVA: 0x2240F10 Offset: 0x2240310 VA: 0x182240F10
	public float get_lineSpacing() { }

	// RVA: 0x22418A0 Offset: 0x2240CA0 VA: 0x1822418A0
	public void set_lineSpacing(float value) { }

	// RVA: 0x2240EB0 Offset: 0x22402B0 VA: 0x182240EB0
	public FontStyle get_fontStyle() { }

	// RVA: 0x22416F0 Offset: 0x2240AF0 VA: 0x1822416F0
	public void set_fontStyle(FontStyle value) { }

	// RVA: 0x2241150 Offset: 0x2240550 VA: 0x182241150
	public float get_pixelsPerUnit() { }

	// RVA: 0x2240480 Offset: 0x223F880 VA: 0x182240480 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x2240420 Offset: 0x223F820 VA: 0x182240420 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2240C00 Offset: 0x2240000 VA: 0x182240C00 Slot: 41
	protected override void UpdateGeometry() { }

	// RVA: 0x223FE00 Offset: 0x223F200 VA: 0x18223FE00
	internal void AssignDefaultFont() { }

	// RVA: 0x2240050 Offset: 0x223F450 VA: 0x182240050
	public TextGenerationSettings GetGenerationSettings(Vector2 extents) { }

	// RVA: 0x22402A0 Offset: 0x223F6A0 VA: 0x1822402A0
	public static Vector2 GetTextAnchorPivot(TextAnchor anchor) { }

	// RVA: 0x2240500 Offset: 0x223F900 VA: 0x182240500 Slot: 44
	protected override void OnPopulateMesh(VertexHelper toFill) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 74
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 75
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x581F40 Offset: 0x581340 VA: 0x180581F40 Slot: 76
	public virtual float get_minWidth() { }

	// RVA: 0x2241420 Offset: 0x2240820 VA: 0x182241420 Slot: 77
	public virtual float get_preferredWidth() { }

	// RVA: 0xC62540 Offset: 0xC61940 VA: 0x180C62540 Slot: 78
	public virtual float get_flexibleWidth() { }

	// RVA: 0x581F40 Offset: 0x581340 VA: 0x180581F40 Slot: 79
	public virtual float get_minHeight() { }

	// RVA: 0x22412D0 Offset: 0x22406D0 VA: 0x1822412D0 Slot: 80
	public virtual float get_preferredHeight() { }

	// RVA: 0xC62540 Offset: 0xC61940 VA: 0x180C62540 Slot: 81
	public virtual float get_flexibleHeight() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 82
	public virtual int get_layoutPriority() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

