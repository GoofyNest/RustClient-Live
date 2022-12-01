public class Text : MaskableGraphic, ILayoutElement // TypeDefIndex: 5020
{
	[SerializeField]
	private FontData m_FontData;
	[TextAreaAttribute]
	[SerializeField]
	protected string m_Text;
	private TextGenerator m_TextCache;
	private TextGenerator m_TextCacheForLayout;
	protected static Material s_DefaultText;
	protected bool m_DisableFontTextureRebuiltCallback;
	private readonly UIVertex[] m_TempVerts;

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


	protected void .ctor() { }

	public TextGenerator get_cachedTextGenerator() { }

	public TextGenerator get_cachedTextGeneratorForLayout() { }

	public override Texture get_mainTexture() { }

	public void FontTextureChanged() { }

	public Font get_font() { }

	public void set_font(Font value) { }

	public virtual string get_text() { }

	public virtual void set_text(string value) { }

	public bool get_supportRichText() { }

	public void set_supportRichText(bool value) { }

	public bool get_resizeTextForBestFit() { }

	public void set_resizeTextForBestFit(bool value) { }

	public int get_resizeTextMinSize() { }

	public void set_resizeTextMinSize(int value) { }

	public int get_resizeTextMaxSize() { }

	public void set_resizeTextMaxSize(int value) { }

	public TextAnchor get_alignment() { }

	public void set_alignment(TextAnchor value) { }

	public bool get_alignByGeometry() { }

	public void set_alignByGeometry(bool value) { }

	public int get_fontSize() { }

	public void set_fontSize(int value) { }

	public HorizontalWrapMode get_horizontalOverflow() { }

	public void set_horizontalOverflow(HorizontalWrapMode value) { }

	public VerticalWrapMode get_verticalOverflow() { }

	public void set_verticalOverflow(VerticalWrapMode value) { }

	public float get_lineSpacing() { }

	public void set_lineSpacing(float value) { }

	public FontStyle get_fontStyle() { }

	public void set_fontStyle(FontStyle value) { }

	public float get_pixelsPerUnit() { }

	protected override void OnEnable() { }

	protected override void OnDisable() { }

	protected override void UpdateGeometry() { }

	internal void AssignDefaultFont() { }

	public TextGenerationSettings GetGenerationSettings(Vector2 extents) { }

	public static Vector2 GetTextAnchorPivot(TextAnchor anchor) { }

	protected override void OnPopulateMesh(VertexHelper toFill) { }

	public virtual void CalculateLayoutInputHorizontal() { }

	public virtual void CalculateLayoutInputVertical() { }

	public virtual float get_minWidth() { }

	public virtual float get_preferredWidth() { }

	public virtual float get_flexibleWidth() { }

	public virtual float get_minHeight() { }

	public virtual float get_preferredHeight() { }

	public virtual float get_flexibleHeight() { }

	public virtual int get_layoutPriority() { }

	private static void .cctor() { }

}

