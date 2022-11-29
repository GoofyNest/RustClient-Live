public sealed class TextGenerator : IDisposable // TypeDefIndex: 3957
{
	internal IntPtr m_Ptr; 
	private string m_LastString; 
	private TextGenerationSettings m_LastSettings; 
	private bool m_HasGenerated; 
	private TextGenerationError m_LastValid; 
	private readonly List<UIVertex> m_Verts; 
	private readonly List<UICharInfo> m_Characters; 
	private readonly List<UILineInfo> m_Lines; 
	private bool m_CachedVerts; 
	private bool m_CachedCharacters; 
	private bool m_CachedLines; 

	public int characterCountVisible { get; }
	public IList<UIVertex> verts { get; }
	public IList<UICharInfo> characters { get; }
	public IList<UILineInfo> lines { get; }
	public Rect rectExtents { get; }
	public int characterCount { get; }
	public int lineCount { get; }


	public void .ctor() { }

	public void .ctor(int initialCapacity) { }

	protected override void Finalize() { }

	private void System.IDisposable.Dispose() { }

	public int get_characterCountVisible() { }

	private TextGenerationSettings ValidatedSettings(TextGenerationSettings settings) { }

	public void Invalidate() { }

	public void GetCharacters(List<UICharInfo> characters) { }

	public void GetLines(List<UILineInfo> lines) { }

	public void GetVertices(List<UIVertex> vertices) { }

	public float GetPreferredWidth(string str, TextGenerationSettings settings) { }

	public float GetPreferredHeight(string str, TextGenerationSettings settings) { }

	public bool PopulateWithErrors(string str, TextGenerationSettings settings, GameObject context) { }

	public bool Populate(string str, TextGenerationSettings settings) { }

	private TextGenerationError PopulateWithError(string str, TextGenerationSettings settings) { }

	private TextGenerationError PopulateAlways(string str, TextGenerationSettings settings) { }

	public IList<UIVertex> get_verts() { }

	public IList<UICharInfo> get_characters() { }

	public IList<UILineInfo> get_lines() { }

	public Rect get_rectExtents() { }

	public int get_characterCount() { }

	public int get_lineCount() { }

	[NativeMethodAttribute] 
	private static IntPtr Internal_Create() { }

	[NativeMethodAttribute] 
	private static void Internal_Destroy(IntPtr ptr) { }

	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error) { }

	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, VerticalWrapMode verticalOverFlow, HorizontalWrapMode horizontalOverflow, bool updateBounds, TextAnchor anchor, Vector2 extents, Vector2 pivot, bool generateOutOfBounds, bool alignByGeometry, out TextGenerationError error) { }

	[NativeThrowsAttribute] 
	private void GetVerticesInternal(object vertices) { }

	[NativeThrowsAttribute] 
	private void GetCharactersInternal(object characters) { }

	[NativeThrowsAttribute] 
	private void GetLinesInternal(object lines) { }

	private void get_rectExtents_Injected(out Rect ret) { }

	private bool Populate_Internal_Injected(string str, Font font, ref Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error) { }

}

