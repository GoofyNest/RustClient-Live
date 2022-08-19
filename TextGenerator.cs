public sealed class TextGenerator : IDisposable // TypeDefIndex: 3952
{	// Fields
	internal IntPtr m_Ptr; // 0x10
	private string m_LastString; // 0x18
	private TextGenerationSettings m_LastSettings; // 0x20
	private bool m_HasGenerated; // 0x80
	private TextGenerationError m_LastValid; // 0x84
	private readonly List<UIVertex> m_Verts; // 0x88
	private readonly List<UICharInfo> m_Characters; // 0x90
	private readonly List<UILineInfo> m_Lines; // 0x98
	private bool m_CachedVerts; // 0xA0
	private bool m_CachedCharacters; // 0xA1
	private bool m_CachedLines; // 0xA2

	// Properties
	public int characterCountVisible { get; }
	public IList<UIVertex> verts { get; }
	public IList<UICharInfo> characters { get; }
	public IList<UILineInfo> lines { get; }
	public Rect rectExtents { get; }
	public int characterCount { get; }
	public int lineCount { get; }

	// Methods

	// RVA: 0x2307150 Offset: 0x2306550 VA: 0x182307150
	public void .ctor() { }

	// RVA: 0x2307040 Offset: 0x2306440 VA: 0x182307040
	public void .ctor(int initialCapacity) { }

	// RVA: 0x2305B20 Offset: 0x2304F20 VA: 0x182305B20 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2306C40 Offset: 0x2306040 VA: 0x182306C40 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x2307250 Offset: 0x2306650 VA: 0x182307250
	public int get_characterCountVisible() { }

	// RVA: 0x2306CC0 Offset: 0x23060C0 VA: 0x182306CC0
	private TextGenerationSettings ValidatedSettings(TextGenerationSettings settings) { }

	// RVA: 0x2305EA0 Offset: 0x23052A0 VA: 0x182305EA0
	public void Invalidate() { }

	// RVA: 0x2305BD0 Offset: 0x2304FD0 VA: 0x182305BD0
	public void GetCharacters(List<UICharInfo> characters) { }

	// RVA: 0x2305C20 Offset: 0x2305020 VA: 0x182305C20
	public void GetLines(List<UILineInfo> lines) { }

	// RVA: 0x2305DE0 Offset: 0x23051E0 VA: 0x182305DE0
	public void GetVertices(List<UIVertex> vertices) { }

	// RVA: 0x2305D20 Offset: 0x2305120 VA: 0x182305D20
	public float GetPreferredWidth(string str, TextGenerationSettings settings) { }

	// RVA: 0x2305C70 Offset: 0x2305070 VA: 0x182305C70
	public float GetPreferredHeight(string str, TextGenerationSettings settings) { }

	// RVA: 0x2306560 Offset: 0x2305960 VA: 0x182306560
	public bool PopulateWithErrors(string str, TextGenerationSettings settings, GameObject context) { }

	// RVA: 0x2306BE0 Offset: 0x2305FE0 VA: 0x182306BE0
	public bool Populate(string str, TextGenerationSettings settings) { }

	// RVA: 0x23061D0 Offset: 0x23055D0 VA: 0x1823061D0
	private TextGenerationError PopulateWithError(string str, TextGenerationSettings settings) { }

	// RVA: 0x2305EB0 Offset: 0x23052B0 VA: 0x182305EB0
	private TextGenerationError PopulateAlways(string str, TextGenerationSettings settings) { }

	// RVA: 0x2307490 Offset: 0x2306890 VA: 0x182307490
	public IList<UIVertex> get_verts() { }

	// RVA: 0x23072D0 Offset: 0x23066D0 VA: 0x1823072D0
	public IList<UICharInfo> get_characters() { }

	// RVA: 0x2307380 Offset: 0x2306780 VA: 0x182307380
	public IList<UILineInfo> get_lines() { }

	// RVA: 0x2307440 Offset: 0x2306840 VA: 0x182307440
	public Rect get_rectExtents() { }

	// RVA: 0x2307290 Offset: 0x2306690 VA: 0x182307290
	public int get_characterCount() { }

	// RVA: 0x2307340 Offset: 0x2306740 VA: 0x182307340
	public int get_lineCount() { }

	[NativeMethodAttribute] // RVA: 0x90400 Offset: 0x8F800 VA: 0x180090400
	// RVA: 0x2305E30 Offset: 0x2305230 VA: 0x182305E30
	private static IntPtr Internal_Create() { }

	[NativeMethodAttribute] // RVA: 0x90400 Offset: 0x8F800 VA: 0x180090400
	// RVA: 0x2305E60 Offset: 0x2305260 VA: 0x182305E60
	private static void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x2306A60 Offset: 0x2305E60 VA: 0x182306A60
	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error) { }

	// RVA: 0x2306860 Offset: 0x2305C60 VA: 0x182306860
	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, VerticalWrapMode verticalOverFlow, HorizontalWrapMode horizontalOverflow, bool updateBounds, TextAnchor anchor, Vector2 extents, Vector2 pivot, bool generateOutOfBounds, bool alignByGeometry, out TextGenerationError error) { }

	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	// RVA: 0x2305DE0 Offset: 0x23051E0 VA: 0x182305DE0
	private void GetVerticesInternal(object vertices) { }

	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	// RVA: 0x2305BD0 Offset: 0x2304FD0 VA: 0x182305BD0
	private void GetCharactersInternal(object characters) { }

	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	// RVA: 0x2305C20 Offset: 0x2305020 VA: 0x182305C20
	private void GetLinesInternal(object lines) { }

	// RVA: 0x23073F0 Offset: 0x23067F0 VA: 0x1823073F0
	private void get_rectExtents_Injected(out Rect ret) { }

	// RVA: 0x23067A0 Offset: 0x2305BA0 VA: 0x1823067A0
	private bool Populate_Internal_Injected(string str, Font font, ref Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error) { }

}

