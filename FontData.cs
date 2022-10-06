public class FontData : ISerializationCallbackReceiver // TypeDefIndex: 4932
{
	[SerializeField] 
	[FormerlySerializedAsAttribute] 
	private Font m_Font; 
	[SerializeField] 
	[FormerlySerializedAsAttribute] 
	private int m_FontSize; 
	[SerializeField] 
	[FormerlySerializedAsAttribute] 
	private FontStyle m_FontStyle; 
	[SerializeField] 
	private bool m_BestFit; 
	[SerializeField] 
	private int m_MinSize; 
	[SerializeField] 
	private int m_MaxSize; 
	[SerializeField] 
	[FormerlySerializedAsAttribute] 
	private TextAnchor m_Alignment; 
	[SerializeField] 
	private bool m_AlignByGeometry; 
	[SerializeField] 
	[FormerlySerializedAsAttribute] 
	private bool m_RichText; 
	[SerializeField] 
	private HorizontalWrapMode m_HorizontalOverflow; 
	[SerializeField] 
	private VerticalWrapMode m_VerticalOverflow; 
	[SerializeField] 
	private float m_LineSpacing; 

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


	public static FontData get_defaultFontData() { }

	public Font get_font() { }

	public void set_font(Font value) { }

	public int get_fontSize() { }

	public void set_fontSize(int value) { }

	public FontStyle get_fontStyle() { }

	public void set_fontStyle(FontStyle value) { }

	public bool get_bestFit() { }

	public void set_bestFit(bool value) { }

	public int get_minSize() { }

	public void set_minSize(int value) { }

	public int get_maxSize() { }

	public void set_maxSize(int value) { }

	public TextAnchor get_alignment() { }

	public void set_alignment(TextAnchor value) { }

	public bool get_alignByGeometry() { }

	public void set_alignByGeometry(bool value) { }

	public bool get_richText() { }

	public void set_richText(bool value) { }

	public HorizontalWrapMode get_horizontalOverflow() { }

	public void set_horizontalOverflow(HorizontalWrapMode value) { }

	public VerticalWrapMode get_verticalOverflow() { }

	public void set_verticalOverflow(VerticalWrapMode value) { }

	public float get_lineSpacing() { }

	public void set_lineSpacing(float value) { }

	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	public void .ctor() { }

}

