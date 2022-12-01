public struct TextGenerationSettings // TypeDefIndex: 3956
{
	public Font font;
	public Color color;
	public int fontSize;
	public float lineSpacing;
	public bool richText;
	public float scaleFactor;
	public FontStyle fontStyle;
	public TextAnchor textAnchor;
	public bool alignByGeometry;
	public bool resizeTextForBestFit;
	public int resizeTextMinSize;
	public int resizeTextMaxSize;
	public bool updateBounds;
	public VerticalWrapMode verticalOverflow;
	public HorizontalWrapMode horizontalOverflow;
	public Vector2 generationExtents;
	public Vector2 pivot;
	public bool generateOutOfBounds;


	private bool CompareColors(Color left, Color right) { }

	private bool CompareVector2(Vector2 left, Vector2 right) { }

	public bool Equals(TextGenerationSettings other) { }

}

