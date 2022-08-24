public class TMP_Asset : ScriptableObject // TypeDefIndex: 6743
{
	public int hashCode; 
	public Material material; 
	public int materialHashCode; 


	public void .ctor() { }

}

public class TMP_Character : TMP_TextElement // TypeDefIndex: 6744
{

	public void .ctor() { }

	public void .ctor(uint unicode, Glyph glyph) { }

	internal void .ctor(uint unicode, uint glyphIndex) { }

}

public struct TMP_Vertex // TypeDefIndex: 6745
{
	public Vector3 position; 
	public Vector2 uv; 
	public Vector2 uv2; 
	public Vector2 uv4; 
	public Color32 color; 

}

public struct TMP_CharacterInfo // TypeDefIndex: 6746
{
	public char character; 
	public int index; 
	public int stringLength; 
	public TMP_TextElementType elementType; 
	public TMP_TextElement textElement; 
	public TMP_FontAsset fontAsset; 
	public Material material; 
	public int materialReferenceIndex; 
	public bool isUsingAlternateTypeface; 
	public float pointSize; 
	public int lineNumber; 
	public int pageNumber; 
	public int vertexIndex; 
	public TMP_Vertex vertex_BL; 
	public TMP_Vertex vertex_TL; 
	public TMP_Vertex vertex_TR; 
	public TMP_Vertex vertex_BR; 
	public Vector3 topLeft; 
	public Vector3 bottomLeft; 
	public Vector3 topRight; 
	public Vector3 bottomRight; 
	public float origin; 
	public float ascender; 
	public float baseLine; 
	public float descender; 
	public float xAdvance; 
	public float aspectRatio; 
	public float scale; 
	public Color32 color; 
	public Color32 underlineColor; 
	public Color32 strikethroughColor; 
	public Color32 highlightColor; 
	public FontStyles style; 
	public bool isVisible; 

}

public class TMP_ColorGradient : ScriptableObject // TypeDefIndex: 6748
{
	public ColorMode colorMode; 
	public Color topLeft; 
	public Color topRight; 
	public Color bottomLeft; 
	public Color bottomRight; 
	private const ColorMode k_DefaultColorMode = 3;
	private static readonly Color k_DefaultColor; 


	public void .ctor() { }

	public void .ctor(Color color) { }

	public void .ctor(Color color0, Color color1, Color color2, Color color3) { }

	private static void .cctor() { }

}

public static class TMP_DefaultControls // TypeDefIndex: 6757
{
	private const float kWidth = 160;
	private const float kThickHeight = 30;
	private const float kThinHeight = 20;
	private static Vector2 s_ThickElementSize; 
	private static Vector2 s_ThinElementSize; 
	private static Color s_DefaultSelectableColor; 
	private static Color s_TextColor; 


	private static GameObject CreateUIElementRoot(string name, Vector2 size) { }

	private static GameObject CreateUIObject(string name, GameObject parent) { }

	private static void SetDefaultTextValues(TMP_Text lbl) { }

	private static void SetDefaultColorTransitionValues(Selectable slider) { }

	private static void SetParentAndAlign(GameObject child, GameObject parent) { }

	private static void SetLayerRecursively(GameObject go, int layer) { }

	public static GameObject CreateScrollbar(TMP_DefaultControls.Resources resources) { }

	public static GameObject CreateButton(TMP_DefaultControls.Resources resources) { }

	public static GameObject CreateText(TMP_DefaultControls.Resources resources) { }

	public static GameObject CreateInputField(TMP_DefaultControls.Resources resources) { }

	private static void .cctor() { }

}

public struct TMP_DefaultControls.Resources // TypeDefIndex: 6758
{
	public Sprite standard; 
	public Sprite background; 
	public Sprite inputField; 
	public Sprite knob; 
	public Sprite checkmark; 
	public Sprite dropdown; 
	public Sprite mask; 

}

public class TMP_FontAsset : TMP_Asset // TypeDefIndex: 6760
{
	[SerializeField] 
	private string m_Version; 
	[SerializeField] 
	internal string m_SourceFontFileGUID; 
	[SerializeField] 
	private Font m_SourceFontFile; 
	[SerializeField] 
	private AtlasPopulationMode m_AtlasPopulationMode; 
	[SerializeField] 
	private FaceInfo m_FaceInfo; 
	[SerializeField] 
	private List<Glyph> m_GlyphTable; 
	private Dictionary<uint, Glyph> m_GlyphLookupDictionary; 
	[SerializeField] 
	private List<TMP_Character> m_CharacterTable; 
	private Dictionary<uint, TMP_Character> m_CharacterLookupDictionary; 
	private Texture2D m_AtlasTexture; 
	[SerializeField] 
	private Texture2D[] m_AtlasTextures; 
	[SerializeField] 
	internal int m_AtlasTextureIndex; 
	[SerializeField] 
	private List<GlyphRect> m_UsedGlyphRects; 
	[SerializeField] 
	private List<GlyphRect> m_FreeGlyphRects; 
	[SerializeField] 
	private FaceInfo_Legacy m_fontInfo; 
	[SerializeField] 
	public Texture2D atlas; 
	[SerializeField] 
	private int m_AtlasWidth; 
	[SerializeField] 
	private int m_AtlasHeight; 
	[SerializeField] 
	private int m_AtlasPadding; 
	[SerializeField] 
	private GlyphRenderMode m_AtlasRenderMode; 
	[SerializeField] 
	internal List<TMP_Glyph> m_glyphInfoList; 
	[SerializeField] 
	[FormerlySerializedAsAttribute] 
	internal KerningTable m_KerningTable; 
	[SerializeField] 
	private TMP_FontFeatureTable m_FontFeatureTable; 
	[SerializeField] 
	private List<TMP_FontAsset> fallbackFontAssets; 
	[SerializeField] 
	public List<TMP_FontAsset> m_FallbackFontAssetTable; 
	[SerializeField] 
	internal FontAssetCreationSettings m_CreationSettings; 
	[SerializeField] 
	private TMP_FontWeightPair[] m_FontWeightTable; 
	[SerializeField] 
	private TMP_FontWeightPair[] fontWeights; 
	public float normalStyle; 
	public float normalSpacingOffset; 
	public float boldStyle; 
	public float boldSpacing; 
	public byte italicStyle; 
	public byte tabSize; 
	private byte m_oldTabSize; 
	internal bool m_IsFontAssetLookupTablesDirty; 
	private List<Glyph> m_GlyphsToPack; 
	private List<Glyph> m_GlyphsPacked; 
	private List<Glyph> m_GlyphsToRender; 
	private List<uint> m_GlyphIndexList; 
	private List<TMP_Character> m_CharactersToAdd; 
	internal static uint[] s_GlyphIndexArray; 
	internal static List<uint> s_MissingCharacterList; 

	public string version { get; set; }
	public Font sourceFontFile { get; set; }
	public AtlasPopulationMode atlasPopulationMode { get; set; }
	public FaceInfo faceInfo { get; set; }
	public List<Glyph> glyphTable { get; set; }
	public Dictionary<uint, Glyph> glyphLookupTable { get; }
	public List<TMP_Character> characterTable { get; set; }
	public Dictionary<uint, TMP_Character> characterLookupTable { get; }
	public Texture2D atlasTexture { get; }
	public Texture2D[] atlasTextures { get; set; }
	internal List<GlyphRect> usedGlyphRects { get; set; }
	internal List<GlyphRect> freeGlyphRects { get; set; }
	[ObsoleteAttribute] 
	public FaceInfo_Legacy fontInfo { get; }
	public int atlasWidth { get; set; }
	public int atlasHeight { get; set; }
	public int atlasPadding { get; set; }
	public GlyphRenderMode atlasRenderMode { get; set; }
	public TMP_FontFeatureTable fontFeatureTable { get; set; }
	public List<TMP_FontAsset> fallbackFontAssetTable { get; set; }
	public FontAssetCreationSettings creationSettings { get; set; }
	public TMP_FontWeightPair[] fontWeightTable { get; set; }


	public string get_version() { }

	internal void set_version(string value) { }

	public Font get_sourceFontFile() { }

	internal void set_sourceFontFile(Font value) { }

	public AtlasPopulationMode get_atlasPopulationMode() { }

	public void set_atlasPopulationMode(AtlasPopulationMode value) { }

	public FaceInfo get_faceInfo() { }

	internal void set_faceInfo(FaceInfo value) { }

	public List<Glyph> get_glyphTable() { }

	internal void set_glyphTable(List<Glyph> value) { }

	public Dictionary<uint, Glyph> get_glyphLookupTable() { }

	public List<TMP_Character> get_characterTable() { }

	internal void set_characterTable(List<TMP_Character> value) { }

	public Dictionary<uint, TMP_Character> get_characterLookupTable() { }

	public Texture2D get_atlasTexture() { }

	public Texture2D[] get_atlasTextures() { }

	public void set_atlasTextures(Texture2D[] value) { }

	internal List<GlyphRect> get_usedGlyphRects() { }

	internal void set_usedGlyphRects(List<GlyphRect> value) { }

	internal List<GlyphRect> get_freeGlyphRects() { }

	internal void set_freeGlyphRects(List<GlyphRect> value) { }

	public FaceInfo_Legacy get_fontInfo() { }

	public int get_atlasWidth() { }

	internal void set_atlasWidth(int value) { }

	public int get_atlasHeight() { }

	internal void set_atlasHeight(int value) { }

	public int get_atlasPadding() { }

	internal void set_atlasPadding(int value) { }

	public GlyphRenderMode get_atlasRenderMode() { }

	internal void set_atlasRenderMode(GlyphRenderMode value) { }

	public TMP_FontFeatureTable get_fontFeatureTable() { }

	internal void set_fontFeatureTable(TMP_FontFeatureTable value) { }

	public List<TMP_FontAsset> get_fallbackFontAssetTable() { }

	public void set_fallbackFontAssetTable(List<TMP_FontAsset> value) { }

	public FontAssetCreationSettings get_creationSettings() { }

	public void set_creationSettings(FontAssetCreationSettings value) { }

	public TMP_FontWeightPair[] get_fontWeightTable() { }

	internal void set_fontWeightTable(TMP_FontWeightPair[] value) { }

	public static TMP_FontAsset CreateFontAsset(Font font) { }

	public static TMP_FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = 1) { }

	private void Awake() { }

	internal void InitializeDictionaryLookupTables() { }

	public void ReadFontAssetDefinition() { }

	internal void SortCharacterTable() { }

	internal void SortGlyphTable() { }

	internal void SortGlyphAndCharacterTables() { }

	public bool HasCharacter(int character) { }

	public bool HasCharacter(char character) { }

	public bool HasCharacter(char character, bool searchFallbacks) { }

	private bool HasCharacter_Internal(char character, bool searchFallbacks) { }

	public bool HasCharacters(string text, out List<char> missingCharacters) { }

	public bool HasCharacters(string text) { }

	public static string GetCharacters(TMP_FontAsset fontAsset) { }

	public static int[] GetCharactersArray(TMP_FontAsset fontAsset) { }

	public bool TryAddCharacters(uint[] unicodes) { }

	public bool TryAddCharacters(uint[] unicodes, out uint[] missingUnicodes) { }

	public bool TryAddCharacters(string characters) { }

	public bool TryAddCharacters(string characters, out string missingCharacters) { }

	internal bool TryAddCharacter_Internal(uint unicode) { }

	internal TMP_Character AddCharacter_Internal(uint unicode, Glyph glyph) { }

	internal bool TryAddCharacterInternal(uint unicode, out TMP_Character character) { }

	internal uint GetGlyphIndex(uint unicode) { }

	internal void UpdateAtlasTexture() { }

	internal void UpdateGlyphAdjustmentRecords(uint unicode, uint glyphIndex) { }

	public void ClearFontAssetData(bool setAtlasSizeToZero = False) { }

	private void UpgradeFontAsset() { }

	private void UpgradeGlyphAdjustmentTableToFontFeatureTable() { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class TMP_FontAsset.<>c // TypeDefIndex: 6761
{
	public static readonly TMP_FontAsset.<>c <>9; 
	public static Func<TMP_Character, uint> <>9__100_0; 
	public static Func<Glyph, uint> <>9__101_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal uint <SortCharacterTable>b__100_0(TMP_Character c) { }

	internal uint <SortGlyphTable>b__101_0(Glyph c) { }

}

public class TMP_Glyph : TMP_TextElement_Legacy // TypeDefIndex: 6763
{

	public static TMP_Glyph Clone(TMP_Glyph source) { }

	public void .ctor() { }

}

public struct TMP_FontWeightPair // TypeDefIndex: 6765
{
	public TMP_FontAsset regularTypeface; 
	public TMP_FontAsset italicTypeface; 

}

public static class TMP_FontUtilities // TypeDefIndex: 6774
{
	private static List<int> k_searchedFontAssets; 


	public static TMP_FontAsset SearchForCharacter(TMP_FontAsset font, uint unicode, out TMP_Character character) { }

	public static TMP_FontAsset SearchForCharacter(List<TMP_FontAsset> fonts, uint unicode, out TMP_Character character) { }

	private static TMP_FontAsset SearchForCharacterInternal(TMP_FontAsset font, uint unicode, out TMP_Character character) { }

	private static TMP_FontAsset SearchForCharacterInternal(List<TMP_FontAsset> fonts, uint unicode, out TMP_Character character) { }

}

public class TMP_FontAssetUtilities // TypeDefIndex: 6775
{
	private static readonly TMP_FontAssetUtilities s_Instance; 
	private static List<int> k_SearchedFontAssets; 
	private static bool k_IsFontEngineInitialized; 

	public static TMP_FontAssetUtilities instance { get; }


	private static void .cctor() { }

	public static TMP_FontAssetUtilities get_instance() { }

	public static TMP_Character GetCharacterFromFontAsset(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface, out TMP_FontAsset fontAsset) { }

	private static TMP_Character GetCharacterFromFontAsset_Internal(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface, out TMP_FontAsset fontAsset) { }

	public static TMP_Character GetCharacterFromFontAssets(uint unicode, List<TMP_FontAsset> fontAssets, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface, out TMP_FontAsset fontAsset) { }

	private static bool TryGetCharacterFromFontFile(uint unicode, TMP_FontAsset fontAsset, out TMP_Character character) { }

	public static bool TryGetGlyphFromFontFile(uint glyphIndex, TMP_FontAsset fontAsset, out Glyph glyph) { }

	public void .ctor() { }

}

public class TMP_FontFeatureTable // TypeDefIndex: 6776
{
	[SerializeField] 
	internal List<TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords; 
	internal Dictionary<long, TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookupDictionary; 

	internal List<TMP_GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords { get; set; }


	internal List<TMP_GlyphPairAdjustmentRecord> get_glyphPairAdjustmentRecords() { }

	internal void set_glyphPairAdjustmentRecords(List<TMP_GlyphPairAdjustmentRecord> value) { }

	public void .ctor() { }

	public void SortGlyphPairAdjustmentRecords() { }

}

private sealed class TMP_FontFeatureTable.<>c // TypeDefIndex: 6777
{
	public static readonly TMP_FontFeatureTable.<>c <>9; 
	public static Func<TMP_GlyphPairAdjustmentRecord, uint> <>9__6_0; 
	public static Func<TMP_GlyphPairAdjustmentRecord, uint> <>9__6_1; 


	private static void .cctor() { }

	public void .ctor() { }

	internal uint <SortGlyphPairAdjustmentRecords>b__6_0(TMP_GlyphPairAdjustmentRecord s) { }

	internal uint <SortGlyphPairAdjustmentRecords>b__6_1(TMP_GlyphPairAdjustmentRecord s) { }

}

public struct TMP_GlyphValueRecord // TypeDefIndex: 6779
{
	[SerializeField] 
	private float m_XPlacement; 
	[SerializeField] 
	private float m_YPlacement; 
	[SerializeField] 
	private float m_XAdvance; 
	[SerializeField] 
	private float m_YAdvance; 

	public float xPlacement { get; set; }
	public float yPlacement { get; set; }
	public float xAdvance { get; set; }
	public float yAdvance { get; set; }


	public float get_xPlacement() { }

	public void set_xPlacement(float value) { }

	public float get_yPlacement() { }

	public void set_yPlacement(float value) { }

	public float get_xAdvance() { }

	public void set_xAdvance(float value) { }

	public float get_yAdvance() { }

	public void set_yAdvance(float value) { }

	public void .ctor(float xPlacement, float yPlacement, float xAdvance, float yAdvance) { }

	internal void .ctor(GlyphValueRecord_Legacy valueRecord) { }

	internal void .ctor(GlyphValueRecord valueRecord) { }

	public static TMP_GlyphValueRecord op_Addition(TMP_GlyphValueRecord a, TMP_GlyphValueRecord b) { }

}

public struct TMP_GlyphAdjustmentRecord // TypeDefIndex: 6780
{
	[SerializeField] 
	private uint m_GlyphIndex; 
	[SerializeField] 
	private TMP_GlyphValueRecord m_GlyphValueRecord; 

	public uint glyphIndex { get; set; }
	public TMP_GlyphValueRecord glyphValueRecord { get; set; }


	public uint get_glyphIndex() { }

	public void set_glyphIndex(uint value) { }

	public TMP_GlyphValueRecord get_glyphValueRecord() { }

	public void set_glyphValueRecord(TMP_GlyphValueRecord value) { }

	public void .ctor(uint glyphIndex, TMP_GlyphValueRecord glyphValueRecord) { }

	internal void .ctor(GlyphAdjustmentRecord adjustmentRecord) { }

}

public class TMP_GlyphPairAdjustmentRecord // TypeDefIndex: 6781
{
	[SerializeField] 
	private TMP_GlyphAdjustmentRecord m_FirstAdjustmentRecord; 
	[SerializeField] 
	private TMP_GlyphAdjustmentRecord m_SecondAdjustmentRecord; 
	[SerializeField] 
	private FontFeatureLookupFlags m_FeatureLookupFlags; 

	public TMP_GlyphAdjustmentRecord firstAdjustmentRecord { get; set; }
	public TMP_GlyphAdjustmentRecord secondAdjustmentRecord { get; set; }
	public FontFeatureLookupFlags featureLookupFlags { get; set; }


	public TMP_GlyphAdjustmentRecord get_firstAdjustmentRecord() { }

	public void set_firstAdjustmentRecord(TMP_GlyphAdjustmentRecord value) { }

	public TMP_GlyphAdjustmentRecord get_secondAdjustmentRecord() { }

	public void set_secondAdjustmentRecord(TMP_GlyphAdjustmentRecord value) { }

	public FontFeatureLookupFlags get_featureLookupFlags() { }

	public void set_featureLookupFlags(FontFeatureLookupFlags value) { }

	public void .ctor(TMP_GlyphAdjustmentRecord firstAdjustmentRecord, TMP_GlyphAdjustmentRecord secondAdjustmentRecord) { }

	internal void .ctor(GlyphPairAdjustmentRecord glyphPairAdjustmentRecord) { }

}

public class TMP_InputField : Selectable, IUpdateSelectedHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, ILayoutElement, IScrollHandler // TypeDefIndex: 6783
{
	protected TouchScreenKeyboard m_SoftKeyboard; 
	private static readonly char[] kSeparators; 
	[SerializeField] 
	protected RectTransform m_TextViewport; 
	[SerializeField] 
	protected TMP_Text m_TextComponent; 
	protected RectTransform m_TextComponentRectTransform; 
	[SerializeField] 
	protected Graphic m_Placeholder; 
	[SerializeField] 
	protected Scrollbar m_VerticalScrollbar; 
	[SerializeField] 
	protected TMP_ScrollbarEventHandler m_VerticalScrollbarEventHandler; 
	private bool m_IsDrivenByLayoutComponents; 
	private float m_ScrollPosition; 
	[SerializeField] 
	protected float m_ScrollSensitivity; 
	[SerializeField] 
	private TMP_InputField.ContentType m_ContentType; 
	[SerializeField] 
	private TMP_InputField.InputType m_InputType; 
	[SerializeField] 
	private char m_AsteriskChar; 
	[SerializeField] 
	private TouchScreenKeyboardType m_KeyboardType; 
	[SerializeField] 
	private TMP_InputField.LineType m_LineType; 
	[SerializeField] 
	private bool m_HideMobileInput; 
	[SerializeField] 
	private bool m_HideSoftKeyboard; 
	[SerializeField] 
	private TMP_InputField.CharacterValidation m_CharacterValidation; 
	[SerializeField] 
	private string m_RegexValue; 
	[SerializeField] 
	private float m_GlobalPointSize; 
	[SerializeField] 
	private int m_CharacterLimit; 
	[SerializeField] 
	private TMP_InputField.SubmitEvent m_OnEndEdit; 
	[SerializeField] 
	private TMP_InputField.SubmitEvent m_OnSubmit; 
	[SerializeField] 
	private TMP_InputField.SelectionEvent m_OnSelect; 
	[SerializeField] 
	private TMP_InputField.SelectionEvent m_OnDeselect; 
	[SerializeField] 
	private TMP_InputField.TextSelectionEvent m_OnTextSelection; 
	[SerializeField] 
	private TMP_InputField.TextSelectionEvent m_OnEndTextSelection; 
	[SerializeField] 
	private TMP_InputField.OnChangeEvent m_OnValueChanged; 
	[SerializeField] 
	private TMP_InputField.TouchScreenKeyboardEvent m_OnTouchScreenKeyboardStatusChanged; 
	[SerializeField] 
	private TMP_InputField.OnValidateInput m_OnValidateInput; 
	[SerializeField] 
	private Color m_CaretColor; 
	[SerializeField] 
	private bool m_CustomCaretColor; 
	[SerializeField] 
	private Color m_SelectionColor; 
	[SerializeField] 
	[TextAreaAttribute] 
	protected string m_Text; 
	[SerializeField] 
	[RangeAttribute] 
	private float m_CaretBlinkRate; 
	[SerializeField] 
	[RangeAttribute] 
	private int m_CaretWidth; 
	[SerializeField] 
	private bool m_ReadOnly; 
	[SerializeField] 
	private bool m_RichText; 
	protected int m_StringPosition; 
	protected int m_StringSelectPosition; 
	protected int m_CaretPosition; 
	protected int m_CaretSelectPosition; 
	private RectTransform caretRectTrans; 
	protected UIVertex[] m_CursorVerts; 
	private CanvasRenderer m_CachedInputRenderer; 
	private Vector2 m_LastPosition; 
	protected Mesh m_Mesh; 
	private bool m_AllowInput; 
	private bool m_ShouldActivateNextUpdate; 
	private bool m_UpdateDrag; 
	private bool m_DragPositionOutOfBounds; 
	private const float kHScrollSpeed = 0,05;
	private const float kVScrollSpeed = 0,1;
	protected bool m_CaretVisible; 
	private Coroutine m_BlinkCoroutine; 
	private float m_BlinkStartTime; 
	private Coroutine m_DragCoroutine; 
	private string m_OriginalText; 
	private bool m_WasCanceled; 
	private bool m_HasDoneFocusTransition; 
	private WaitForSecondsRealtime m_WaitForSecondsRealtime; 
	private bool m_PreventCallback; 
	private bool m_TouchKeyboardAllowsInPlaceEditing; 
	private bool m_IsTextComponentUpdateRequired; 
	private bool m_IsScrollbarUpdateRequired; 
	private bool m_IsUpdatingScrollbarValues; 
	private bool m_isLastKeyBackspace; 
	private float m_PointerDownClickStartTime; 
	private float m_KeyDownStartTime; 
	private float m_DoubleClickDelay; 
	private const string kEmailSpecialCharacters = "!#$%&\'*+-/=?^_`{|}~";
	[SerializeField] 
	protected TMP_FontAsset m_GlobalFontAsset; 
	[SerializeField] 
	protected bool m_OnFocusSelectAll; 
	protected bool m_isSelectAll; 
	[SerializeField] 
	protected bool m_ResetOnDeActivation; 
	private bool m_SelectionStillActive; 
	private bool m_ReleaseSelection; 
	private GameObject m_SelectedObject; 
	[SerializeField] 
	private bool m_RestoreOriginalTextOnEscape; 
	[SerializeField] 
	protected bool m_isRichTextEditingAllowed; 
	[SerializeField] 
	protected int m_LineLimit; 
	[SerializeField] 
	protected TMP_InputValidator m_InputValidator; 
	private bool m_isSelected; 
	private bool m_IsStringPositionDirty; 
	private bool m_IsCaretPositionDirty; 
	private bool m_forceRectTransformAdjustment; 
	private Event m_ProcessingEvent; 

	private BaseInput inputSystem { get; }
	private string compositionString { get; }
	protected Mesh mesh { get; }
	public bool shouldHideMobileInput { get; set; }
	public bool shouldHideSoftKeyboard { get; set; }
	public string text { get; set; }
	public bool isFocused { get; }
	public float caretBlinkRate { get; set; }
	public int caretWidth { get; set; }
	public RectTransform textViewport { get; set; }
	public TMP_Text textComponent { get; set; }
	public Graphic placeholder { get; set; }
	public Scrollbar verticalScrollbar { get; set; }
	public float scrollSensitivity { get; set; }
	public Color caretColor { get; set; }
	public bool customCaretColor { get; set; }
	public Color selectionColor { get; set; }
	public TMP_InputField.SubmitEvent onEndEdit { get; set; }
	public TMP_InputField.SubmitEvent onSubmit { get; set; }
	public TMP_InputField.SelectionEvent onSelect { get; set; }
	public TMP_InputField.SelectionEvent onDeselect { get; set; }
	public TMP_InputField.TextSelectionEvent onTextSelection { get; set; }
	public TMP_InputField.TextSelectionEvent onEndTextSelection { get; set; }
	public TMP_InputField.OnChangeEvent onValueChanged { get; set; }
	public TMP_InputField.TouchScreenKeyboardEvent onTouchScreenKeyboardStatusChanged { get; set; }
	public TMP_InputField.OnValidateInput onValidateInput { get; set; }
	public int characterLimit { get; set; }
	public float pointSize { get; set; }
	public TMP_FontAsset fontAsset { get; set; }
	public bool onFocusSelectAll { get; set; }
	public bool resetOnDeActivation { get; set; }
	public bool restoreOriginalTextOnEscape { get; set; }
	public bool isRichTextEditingAllowed { get; set; }
	public TMP_InputField.ContentType contentType { get; set; }
	public TMP_InputField.LineType lineType { get; set; }
	public int lineLimit { get; set; }
	public TMP_InputField.InputType inputType { get; set; }
	public TouchScreenKeyboardType keyboardType { get; set; }
	public TMP_InputField.CharacterValidation characterValidation { get; set; }
	public TMP_InputValidator inputValidator { get; set; }
	public bool readOnly { get; set; }
	public bool richText { get; set; }
	public bool multiLine { get; }
	public char asteriskChar { get; set; }
	public bool wasCanceled { get; }
	protected int caretPositionInternal { get; set; }
	protected int stringPositionInternal { get; set; }
	protected int caretSelectPositionInternal { get; set; }
	protected int stringSelectPositionInternal { get; set; }
	private bool hasSelection { get; }
	public int caretPosition { get; set; }
	public int selectionAnchorPosition { get; set; }
	public int selectionFocusPosition { get; set; }
	public int stringPosition { get; set; }
	public int selectionStringAnchorPosition { get; set; }
	public int selectionStringFocusPosition { get; set; }
	private static string clipboard { get; set; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }


	private BaseInput get_inputSystem() { }

	private string get_compositionString() { }

	protected void .ctor() { }

	protected Mesh get_mesh() { }

	public bool get_shouldHideMobileInput() { }

	public void set_shouldHideMobileInput(bool value) { }

	public bool get_shouldHideSoftKeyboard() { }

	public void set_shouldHideSoftKeyboard(bool value) { }

	private bool isKeyboardUsingEvents() { }

	public string get_text() { }

	public void set_text(string value) { }

	public void SetTextWithoutNotify(string input) { }

	private void SetText(string value, bool sendCallback = True) { }

	public bool get_isFocused() { }

	public float get_caretBlinkRate() { }

	public void set_caretBlinkRate(float value) { }

	public int get_caretWidth() { }

	public void set_caretWidth(int value) { }

	public RectTransform get_textViewport() { }

	public void set_textViewport(RectTransform value) { }

	public TMP_Text get_textComponent() { }

	public void set_textComponent(TMP_Text value) { }

	public Graphic get_placeholder() { }

	public void set_placeholder(Graphic value) { }

	public Scrollbar get_verticalScrollbar() { }

	public void set_verticalScrollbar(Scrollbar value) { }

	public float get_scrollSensitivity() { }

	public void set_scrollSensitivity(float value) { }

	public Color get_caretColor() { }

	public void set_caretColor(Color value) { }

	public bool get_customCaretColor() { }

	public void set_customCaretColor(bool value) { }

	public Color get_selectionColor() { }

	public void set_selectionColor(Color value) { }

	public TMP_InputField.SubmitEvent get_onEndEdit() { }

	public void set_onEndEdit(TMP_InputField.SubmitEvent value) { }

	public TMP_InputField.SubmitEvent get_onSubmit() { }

	public void set_onSubmit(TMP_InputField.SubmitEvent value) { }

	public TMP_InputField.SelectionEvent get_onSelect() { }

	public void set_onSelect(TMP_InputField.SelectionEvent value) { }

	public TMP_InputField.SelectionEvent get_onDeselect() { }

	public void set_onDeselect(TMP_InputField.SelectionEvent value) { }

	public TMP_InputField.TextSelectionEvent get_onTextSelection() { }

	public void set_onTextSelection(TMP_InputField.TextSelectionEvent value) { }

	public TMP_InputField.TextSelectionEvent get_onEndTextSelection() { }

	public void set_onEndTextSelection(TMP_InputField.TextSelectionEvent value) { }

	public TMP_InputField.OnChangeEvent get_onValueChanged() { }

	public void set_onValueChanged(TMP_InputField.OnChangeEvent value) { }

	public TMP_InputField.TouchScreenKeyboardEvent get_onTouchScreenKeyboardStatusChanged() { }

	public void set_onTouchScreenKeyboardStatusChanged(TMP_InputField.TouchScreenKeyboardEvent value) { }

	public TMP_InputField.OnValidateInput get_onValidateInput() { }

	public void set_onValidateInput(TMP_InputField.OnValidateInput value) { }

	public int get_characterLimit() { }

	public void set_characterLimit(int value) { }

	public float get_pointSize() { }

	public void set_pointSize(float value) { }

	public TMP_FontAsset get_fontAsset() { }

	public void set_fontAsset(TMP_FontAsset value) { }

	public bool get_onFocusSelectAll() { }

	public void set_onFocusSelectAll(bool value) { }

	public bool get_resetOnDeActivation() { }

	public void set_resetOnDeActivation(bool value) { }

	public bool get_restoreOriginalTextOnEscape() { }

	public void set_restoreOriginalTextOnEscape(bool value) { }

	public bool get_isRichTextEditingAllowed() { }

	public void set_isRichTextEditingAllowed(bool value) { }

	public TMP_InputField.ContentType get_contentType() { }

	public void set_contentType(TMP_InputField.ContentType value) { }

	public TMP_InputField.LineType get_lineType() { }

	public void set_lineType(TMP_InputField.LineType value) { }

	public int get_lineLimit() { }

	public void set_lineLimit(int value) { }

	public TMP_InputField.InputType get_inputType() { }

	public void set_inputType(TMP_InputField.InputType value) { }

	public TouchScreenKeyboardType get_keyboardType() { }

	public void set_keyboardType(TouchScreenKeyboardType value) { }

	public TMP_InputField.CharacterValidation get_characterValidation() { }

	public void set_characterValidation(TMP_InputField.CharacterValidation value) { }

	public TMP_InputValidator get_inputValidator() { }

	public void set_inputValidator(TMP_InputValidator value) { }

	public bool get_readOnly() { }

	public void set_readOnly(bool value) { }

	public bool get_richText() { }

	public void set_richText(bool value) { }

	public bool get_multiLine() { }

	public char get_asteriskChar() { }

	public void set_asteriskChar(char value) { }

	public bool get_wasCanceled() { }

	protected void ClampStringPos(ref int pos) { }

	protected void ClampCaretPos(ref int pos) { }

	protected int get_caretPositionInternal() { }

	protected void set_caretPositionInternal(int value) { }

	protected int get_stringPositionInternal() { }

	protected void set_stringPositionInternal(int value) { }

	protected int get_caretSelectPositionInternal() { }

	protected void set_caretSelectPositionInternal(int value) { }

	protected int get_stringSelectPositionInternal() { }

	protected void set_stringSelectPositionInternal(int value) { }

	private bool get_hasSelection() { }

	public int get_caretPosition() { }

	public void set_caretPosition(int value) { }

	public int get_selectionAnchorPosition() { }

	public void set_selectionAnchorPosition(int value) { }

	public int get_selectionFocusPosition() { }

	public void set_selectionFocusPosition(int value) { }

	public int get_stringPosition() { }

	public void set_stringPosition(int value) { }

	public int get_selectionStringAnchorPosition() { }

	public void set_selectionStringAnchorPosition(int value) { }

	public int get_selectionStringFocusPosition() { }

	public void set_selectionStringFocusPosition(int value) { }

	protected override void OnEnable() { }

	protected override void OnDisable() { }

	private void ON_TEXT_CHANGED(Object obj) { }

	[IteratorStateMachineAttribute] 
	private IEnumerator CaretBlink() { }

	private void SetCaretVisible() { }

	private void SetCaretActive() { }

	protected void OnFocus() { }

	protected void SelectAll() { }

	public void MoveTextEnd(bool shift) { }

	public void MoveTextStart(bool shift) { }

	public void MoveToEndOfLine(bool shift, bool ctrl) { }

	public void MoveToStartOfLine(bool shift, bool ctrl) { }

	private static string get_clipboard() { }

	private static void set_clipboard(string value) { }

	private bool InPlaceEditing() { }

	private void UpdateStringPositionFromKeyboard() { }

	protected virtual void LateUpdate() { }

	private bool MayDrag(PointerEventData eventData) { }

	public virtual void OnBeginDrag(PointerEventData eventData) { }

	public virtual void OnDrag(PointerEventData eventData) { }

	[IteratorStateMachineAttribute] 
	private IEnumerator MouseDragOutsideRect(PointerEventData eventData) { }

	public virtual void OnEndDrag(PointerEventData eventData) { }

	public override void OnPointerDown(PointerEventData eventData) { }

	protected TMP_InputField.EditState KeyPressed(Event evt) { }

	protected virtual bool IsValidChar(char c) { }

	public void ProcessEvent(Event e) { }

	public virtual void OnUpdateSelected(BaseEventData eventData) { }

	public virtual void OnScroll(PointerEventData eventData) { }

	private string GetSelectedString() { }

	private int FindNextWordBegin() { }

	private void MoveRight(bool shift, bool ctrl) { }

	private int FindPrevWordBegin() { }

	private void MoveLeft(bool shift, bool ctrl) { }

	private int LineUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	private int LineDownCharacterPosition(int originalPos, bool goToLastChar) { }

	private int PageUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	private int PageDownCharacterPosition(int originalPos, bool goToLastChar) { }

	private void MoveDown(bool shift) { }

	private void MoveDown(bool shift, bool goToLastChar) { }

	private void MoveUp(bool shift) { }

	private void MoveUp(bool shift, bool goToFirstChar) { }

	private void MovePageUp(bool shift) { }

	private void MovePageUp(bool shift, bool goToFirstChar) { }

	private void MovePageDown(bool shift) { }

	private void MovePageDown(bool shift, bool goToLastChar) { }

	private void Delete() { }

	private void DeleteKey() { }

	private void Backspace() { }

	protected virtual void Append(string input) { }

	protected virtual void Append(char input) { }

	private void Insert(char c) { }

	private void UpdateTouchKeyboardFromEditChanges() { }

	private void SendOnValueChangedAndUpdateLabel() { }

	private void SendOnValueChanged() { }

	protected void SendOnEndEdit() { }

	protected void SendOnSubmit() { }

	protected void SendOnFocus() { }

	protected void SendOnFocusLost() { }

	protected void SendOnTextSelection() { }

	protected void SendOnEndTextSelection() { }

	protected void SendTouchScreenKeyboardStatusChanged() { }

	protected void UpdateLabel() { }

	private void UpdateScrollbar() { }

	private void OnScrollbarValueChange(float value) { }

	private void AdjustTextPositionRelativeToViewport(float relativePosition) { }

	private int GetCaretPositionFromStringIndex(int stringIndex) { }

	private int GetMinCaretPositionFromStringIndex(int stringIndex) { }

	private int GetMaxCaretPositionFromStringIndex(int stringIndex) { }

	private int GetStringIndexFromCaretPosition(int caretPosition) { }

	public void ForceLabelUpdate() { }

	private void MarkGeometryAsDirty() { }

	public virtual void Rebuild(CanvasUpdate update) { }

	public virtual void LayoutComplete() { }

	public virtual void GraphicUpdateComplete() { }

	private void UpdateGeometry() { }

	private void AssignPositioningIfNeeded() { }

	private void OnFillVBO(Mesh vbo) { }

	private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset) { }

	private void CreateCursorVerts() { }

	private void GenerateHightlight(VertexHelper vbo, Vector2 roundingOffset) { }

	private void AdjustRectTransformRelativeToViewport(Vector2 startPosition, float height, bool isCharVisible) { }

	protected char Validate(string text, int pos, char ch) { }

	public void ActivateInputField() { }

	private void ActivateInputFieldInternal() { }

	public override void OnSelect(BaseEventData eventData) { }

	public virtual void OnPointerClick(PointerEventData eventData) { }

	public void OnControlClick() { }

	public void ReleaseSelection() { }

	public void DeactivateInputField(bool clearSelection = False) { }

	public override void OnDeselect(BaseEventData eventData) { }

	public virtual void OnSubmit(BaseEventData eventData) { }

	private void EnforceContentType() { }

	private void SetTextComponentWrapMode() { }

	private void SetTextComponentRichTextMode() { }

	private void SetToCustomIfContentTypeIsNot(TMP_InputField.ContentType[] allowedContentTypes) { }

	private void SetToCustom() { }

	private void SetToCustom(TMP_InputField.CharacterValidation characterValidation) { }

	protected override void DoStateTransition(Selectable.SelectionState state, bool instant) { }

	public virtual void CalculateLayoutInputHorizontal() { }

	public virtual void CalculateLayoutInputVertical() { }

	public virtual float get_minWidth() { }

	public virtual float get_preferredWidth() { }

	public virtual float get_flexibleWidth() { }

	public virtual float get_minHeight() { }

	public virtual float get_preferredHeight() { }

	public virtual float get_flexibleHeight() { }

	public virtual int get_layoutPriority() { }

	public void SetGlobalPointSize(float pointSize) { }

	public void SetGlobalFontAsset(TMP_FontAsset fontAsset) { }

	private static void .cctor() { }

	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }

}

public enum TMP_InputField.ContentType // TypeDefIndex: 6784
{
	public int value__; 
	public const TMP_InputField.ContentType Standard = 0;
	public const TMP_InputField.ContentType Autocorrected = 1;
	public const TMP_InputField.ContentType IntegerNumber = 2;
	public const TMP_InputField.ContentType DecimalNumber = 3;
	public const TMP_InputField.ContentType Alphanumeric = 4;
	public const TMP_InputField.ContentType Name = 5;
	public const TMP_InputField.ContentType EmailAddress = 6;
	public const TMP_InputField.ContentType Password = 7;
	public const TMP_InputField.ContentType Pin = 8;
	public const TMP_InputField.ContentType Custom = 9;

}

public enum TMP_InputField.InputType // TypeDefIndex: 6785
{
	public int value__; 
	public const TMP_InputField.InputType Standard = 0;
	public const TMP_InputField.InputType AutoCorrect = 1;
	public const TMP_InputField.InputType Password = 2;

}

public enum TMP_InputField.CharacterValidation // TypeDefIndex: 6786
{
	public int value__; 
	public const TMP_InputField.CharacterValidation None = 0;
	public const TMP_InputField.CharacterValidation Digit = 1;
	public const TMP_InputField.CharacterValidation Integer = 2;
	public const TMP_InputField.CharacterValidation Decimal = 3;
	public const TMP_InputField.CharacterValidation Alphanumeric = 4;
	public const TMP_InputField.CharacterValidation Name = 5;
	public const TMP_InputField.CharacterValidation Regex = 6;
	public const TMP_InputField.CharacterValidation EmailAddress = 7;
	public const TMP_InputField.CharacterValidation CustomValidator = 8;

}

public enum TMP_InputField.LineType // TypeDefIndex: 6787
{
	public int value__; 
	public const TMP_InputField.LineType SingleLine = 0;
	public const TMP_InputField.LineType MultiLineSubmit = 1;
	public const TMP_InputField.LineType MultiLineNewline = 2;

}

public sealed class TMP_InputField.OnValidateInput : MulticastDelegate // TypeDefIndex: 6788
{

	public void .ctor(object object, IntPtr method) { }

	public virtual char Invoke(string text, int charIndex, char addedChar) { }

	public virtual IAsyncResult BeginInvoke(string text, int charIndex, char addedChar, AsyncCallback callback, object object) { }

	public virtual char EndInvoke(IAsyncResult result) { }

}

public class TMP_InputField.SubmitEvent : UnityEvent<string> // TypeDefIndex: 6789
{

	public void .ctor() { }

}

public class TMP_InputField.OnChangeEvent : UnityEvent<string> // TypeDefIndex: 6790
{

	public void .ctor() { }

}

public class TMP_InputField.SelectionEvent : UnityEvent<string> // TypeDefIndex: 6791
{

	public void .ctor() { }

}

public class TMP_InputField.TextSelectionEvent : UnityEvent<string, int, int> // TypeDefIndex: 6792
{

	public void .ctor() { }

}

public class TMP_InputField.TouchScreenKeyboardEvent : UnityEvent<TouchScreenKeyboard.Status> // TypeDefIndex: 6793
{

	public void .ctor() { }

}

private sealed class TMP_InputField.<CaretBlink>d__267 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 6795
{
	private int <>1__state; 
	private object <>2__current; 
	public TMP_InputField <>4__this; 

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] 
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class TMP_InputField.<MouseDragOutsideRect>d__285 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 6796
{
	private int <>1__state; 
	private object <>2__current; 
	public TMP_InputField <>4__this; 
	public PointerEventData eventData; 

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] 
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.IEnumerator.get_Current() { }

}

public abstract class TMP_InputValidator : ScriptableObject // TypeDefIndex: 6798
{

	public abstract char Validate(ref string text, ref int pos, char ch);

	protected void .ctor() { }

}

public struct TMP_LineInfo // TypeDefIndex: 6799
{
	internal int controlCharacterCount; 
	public int characterCount; 
	public int visibleCharacterCount; 
	public int spaceCount; 
	public int wordCount; 
	public int firstCharacterIndex; 
	public int firstVisibleCharacterIndex; 
	public int lastCharacterIndex; 
	public int lastVisibleCharacterIndex; 
	public float length; 
	public float lineHeight; 
	public float ascender; 
	public float baseline; 
	public float descender; 
	public float maxAdvance; 
	public float width; 
	public float marginLeft; 
	public float marginRight; 
	public TextAlignmentOptions alignment; 
	public Extents lineExtents; 

}

internal static class TMP_ListPool<T> // TypeDefIndex: 6800
{
	private static readonly TMP_ObjectPool<List<T>> s_ListPool; 


	public static List<T> Get() { }
	/* GenericInstMethod :
	|
	|-TMP_ListPool<object>.Get
	|-TMP_ListPool<Canvas>.Get
	|-TMP_ListPool<IMaterialModifier>.Get
	|-TMP_ListPool<Mask>.Get
	*/

	public static void Release(List<T> toRelease) { }
	/* GenericInstMethod :
	|
	|-TMP_ListPool<object>.Release
	|-TMP_ListPool<Canvas>.Release
	|-TMP_ListPool<IMaterialModifier>.Release
	|-TMP_ListPool<Mask>.Release
	*/

	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-TMP_ListPool<object>..cctor
	*/

}

private sealed class TMP_ListPool.<>c<T> // TypeDefIndex: 6801
{
	public static readonly TMP_ListPool.<>c<T> <>9; 


	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-TMP_ListPool.<>c<object>..cctor
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-TMP_ListPool.<>c<object>..ctor
	*/

	internal void <.cctor>b__3_0(List<T> l) { }
	/* GenericInstMethod :
	|
	|-TMP_ListPool.<>c<object>.<.cctor>b__3_0
	*/

}

public static class TMP_MaterialManager // TypeDefIndex: 6802
{
	private static List<TMP_MaterialManager.MaskingMaterial> m_materialList; 
	private static Dictionary<long, TMP_MaterialManager.FallbackMaterial> m_fallbackMaterials; 
	private static Dictionary<int, long> m_fallbackMaterialLookup; 
	private static List<TMP_MaterialManager.FallbackMaterial> m_fallbackCleanupList; 
	private static bool isFallbackListDirty; 


	private static void .cctor() { }

	private static void OnPreRender(Camera cam) { }

	private static void OnPreRenderCanvas() { }

	public static Material GetStencilMaterial(Material baseMaterial, int stencilID) { }

	public static void ReleaseStencilMaterial(Material stencilMaterial) { }

	public static Material GetBaseMaterial(Material stencilMaterial) { }

	public static Material SetStencil(Material material, int stencilID) { }

	public static void AddMaskingMaterial(Material baseMaterial, Material stencilMaterial, int stencilID) { }

	public static void RemoveStencilMaterial(Material stencilMaterial) { }

	public static void ReleaseBaseMaterial(Material baseMaterial) { }

	public static void ClearMaterials() { }

	public static int GetStencilID(GameObject obj) { }

	public static Material GetMaterialForRendering(MaskableGraphic graphic, Material baseMaterial) { }

	private static Transform FindRootSortOverrideCanvas(Transform start) { }

	public static Material GetFallbackMaterial(Material sourceMaterial, Material targetMaterial) { }

	public static void AddFallbackMaterialReference(Material targetMaterial) { }

	public static void RemoveFallbackMaterialReference(Material targetMaterial) { }

	public static void CleanupFallbackMaterials() { }

	public static void ReleaseFallbackMaterial(Material fallackMaterial) { }

	public static void CopyMaterialPresetProperties(Material source, Material destination) { }

}

private class TMP_MaterialManager.FallbackMaterial // TypeDefIndex: 6803
{
	public int baseID; 
	public Material baseMaterial; 
	public long fallbackID; 
	public Material fallbackMaterial; 
	public int count; 


	public void .ctor() { }

}

private class TMP_MaterialManager.MaskingMaterial // TypeDefIndex: 6804
{
	public Material baseMaterial; 
	public Material stencilMaterial; 
	public int count; 
	public int stencilID; 


	public void .ctor() { }

}

private sealed class TMP_MaterialManager.<>c__DisplayClass10_0 // TypeDefIndex: 6805
{
	public Material stencilMaterial; 


	public void .ctor() { }

	internal bool <GetBaseMaterial>b__0(TMP_MaterialManager.MaskingMaterial item) { }

}

private sealed class TMP_MaterialManager.<>c__DisplayClass12_0 // TypeDefIndex: 6806
{
	public Material stencilMaterial; 


	public void .ctor() { }

	internal bool <AddMaskingMaterial>b__0(TMP_MaterialManager.MaskingMaterial item) { }

}

private sealed class TMP_MaterialManager.<>c__DisplayClass13_0 // TypeDefIndex: 6807
{
	public Material stencilMaterial; 


	public void .ctor() { }

	internal bool <RemoveStencilMaterial>b__0(TMP_MaterialManager.MaskingMaterial item) { }

}

private sealed class TMP_MaterialManager.<>c__DisplayClass14_0 // TypeDefIndex: 6808
{
	public Material baseMaterial; 


	public void .ctor() { }

	internal bool <ReleaseBaseMaterial>b__0(TMP_MaterialManager.MaskingMaterial item) { }

}

public struct TMP_MeshInfo // TypeDefIndex: 6810
{
	private static readonly Color32 s_DefaultColor; 
	private static readonly Vector3 s_DefaultNormal; 
	private static readonly Vector4 s_DefaultTangent; 
	private static readonly Bounds s_DefaultBounds; 
	public Mesh mesh; 
	public int vertexCount; 
	public Vector3[] vertices; 
	public Vector3[] normals; 
	public Vector4[] tangents; 
	public Vector2[] uvs0; 
	public Vector2[] uvs2; 
	public Color32[] colors32; 
	public int[] triangles; 


	public void .ctor(Mesh mesh, int size) { }

	public void .ctor(Mesh mesh, int size, bool isVolumetric) { }

	public void ResizeMeshInfo(int size) { }

	public void ResizeMeshInfo(int size, bool isVolumetric) { }

	public void Clear() { }

	public void Clear(bool uploadChanges) { }

	public void ClearUnusedVertices() { }

	public void ClearUnusedVertices(int startIndex) { }

	public void ClearUnusedVertices(int startIndex, bool updateMesh) { }

	public void SortGeometry(VertexSortingOrder order) { }

	public void SortGeometry(IList<int> sortingOrder) { }

	public void SwapVertexData(int src, int dst) { }

	private static void .cctor() { }

}

internal class TMP_ObjectPool<T> // TypeDefIndex: 6811
{
	private readonly Stack<T> m_Stack; 
	private readonly UnityAction<T> m_ActionOnGet; 
	private readonly UnityAction<T> m_ActionOnRelease; 
	[CompilerGeneratedAttribute] 
	private int <countAll>k__BackingField; 

	public int countAll { get; set; }
	public int countActive { get; }
	public int countInactive { get; }


	[CompilerGeneratedAttribute] 
	public int get_countAll() { }
	/* GenericInstMethod :
	|
	|-TMP_ObjectPool<object>.get_countAll
	*/

	[CompilerGeneratedAttribute] 
	private void set_countAll(int value) { }
	/* GenericInstMethod :
	|
	|-TMP_ObjectPool<object>.set_countAll
	*/

	public int get_countActive() { }
	/* GenericInstMethod :
	|
	|-TMP_ObjectPool<object>.get_countActive
	*/

	public int get_countInactive() { }
	/* GenericInstMethod :
	|
	|-TMP_ObjectPool<object>.get_countInactive
	*/

	public void .ctor(UnityAction<T> actionOnGet, UnityAction<T> actionOnRelease) { }
	/* GenericInstMethod :
	|
	|-TMP_ObjectPool<object>..ctor
	*/

	public T Get() { }
	/* GenericInstMethod :
	|
	|-TMP_ObjectPool<object>.Get
	*/

	public void Release(T element) { }
	/* GenericInstMethod :
	|
	|-TMP_ObjectPool<object>.Release
	*/

}

public struct TMP_FontStyleStack // TypeDefIndex: 6812
{
	public byte bold; 
	public byte italic; 
	public byte underline; 
	public byte strikethrough; 
	public byte highlight; 
	public byte superscript; 
	public byte subscript; 
	public byte uppercase; 
	public byte lowercase; 
	public byte smallcaps; 


	public void Clear() { }

	public byte Add(FontStyles style) { }

	public byte Remove(FontStyles style) { }

}

public struct TMP_RichTextTagStack<T> // TypeDefIndex: 6813
{
	public T[] m_ItemStack; 
	public int m_Index; 
	private int m_Capacity; 
	private T m_DefaultItem; 
	private const int k_DefaultCapacity = 4;


	public void .ctor(T[] tagStack) { }
	/* GenericInstMethod :
	|
	|-TMP_RichTextTagStack<int>..ctor
	|-TMP_RichTextTagStack<Int32Enum>..ctor
	|-TMP_RichTextTagStack<float>..ctor
	|-TMP_RichTextTagStack<TextAlignmentOptions>..ctor
	|-TMP_RichTextTagStack<Color32>..ctor
	|
	|-TMP_RichTextTagStack<object>..ctor
	|-TMP_RichTextTagStack<TMP_ColorGradient>..ctor
	|
	|-TMP_RichTextTagStack<MaterialReference>..ctor
	*/

	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-TMP_RichTextTagStack<int>..ctor
	|-TMP_RichTextTagStack<Int32Enum>..ctor
	|-TMP_RichTextTagStack<float>..ctor
	|-TMP_RichTextTagStack<FontWeight>..ctor
	|-TMP_RichTextTagStack<Color32>..ctor
	|
	|-TMP_RichTextTagStack<object>..ctor
	|
	|-TMP_RichTextTagStack<MaterialReference>..ctor
	*/

	public void Clear() { }
	/* GenericInstMethod :
	|
	|-TMP_RichTextTagStack<int>.Clear
	|-TMP_RichTextTagStack<Int32Enum>.Clear
	|-TMP_RichTextTagStack<object>.Clear
	|-TMP_RichTextTagStack<float>.Clear
	|-TMP_RichTextTagStack<MaterialReference>.Clear
	|-TMP_RichTextTagStack<Color32>.Clear
	*/

	public void SetDefault(T item) { }
	/* GenericInstMethod :
	|
	|-TMP_RichTextTagStack<int>.SetDefault
	|-TMP_RichTextTagStack<Int32Enum>.SetDefault
	|-TMP_RichTextTagStack<FontWeight>.SetDefault
	|-TMP_RichTextTagStack<TextAlignmentOptions>.SetDefault
	|-TMP_RichTextTagStack<Color32>.SetDefault
	|
	|-TMP_RichTextTagStack<object>.SetDefault
	|-TMP_RichTextTagStack<TMP_ColorGradient>.SetDefault
	|
	|-TMP_RichTextTagStack<float>.SetDefault
	|
	|-TMP_RichTextTagStack<MaterialReference>.SetDefault
	*/

	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-TMP_RichTextTagStack<int>.Add
	|-TMP_RichTextTagStack<Int32Enum>.Add
	|-TMP_RichTextTagStack<FontWeight>.Add
	|-TMP_RichTextTagStack<TextAlignmentOptions>.Add
	|-TMP_RichTextTagStack<Color32>.Add
	|
	|-TMP_RichTextTagStack<object>.Add
	|-TMP_RichTextTagStack<TMP_ColorGradient>.Add
	|
	|-TMP_RichTextTagStack<float>.Add
	|
	|-TMP_RichTextTagStack<MaterialReference>.Add
	*/

	public T Remove() { }
	/* GenericInstMethod :
	|
	|-TMP_RichTextTagStack<int>.Remove
	|-TMP_RichTextTagStack<Int32Enum>.Remove
	|-TMP_RichTextTagStack<FontWeight>.Remove
	|-TMP_RichTextTagStack<TextAlignmentOptions>.Remove
	|-TMP_RichTextTagStack<Color32>.Remove
	|
	|-TMP_RichTextTagStack<object>.Remove
	|-TMP_RichTextTagStack<TMP_ColorGradient>.Remove
	|
	|-TMP_RichTextTagStack<float>.Remove
	|
	|-TMP_RichTextTagStack<MaterialReference>.Remove
	*/

	public void Push(T item) { }
	/* GenericInstMethod :
	|
	|-TMP_RichTextTagStack<int>.Push
	|-TMP_RichTextTagStack<Int32Enum>.Push
	|
	|-TMP_RichTextTagStack<object>.Push
	|
	|-TMP_RichTextTagStack<float>.Push
	|
	|-TMP_RichTextTagStack<MaterialReference>.Push
	|
	|-TMP_RichTextTagStack<Color32>.Push
	*/

	public T Pop() { }
	/* GenericInstMethod :
	|
	|-TMP_RichTextTagStack<int>.Pop
	|-TMP_RichTextTagStack<Int32Enum>.Pop
	|-TMP_RichTextTagStack<Color32>.Pop
	|
	|-TMP_RichTextTagStack<object>.Pop
	|
	|-TMP_RichTextTagStack<float>.Pop
	|
	|-TMP_RichTextTagStack<MaterialReference>.Pop
	*/

	public T Peek() { }
	/* GenericInstMethod :
	|
	|-TMP_RichTextTagStack<int>.Peek
	|-TMP_RichTextTagStack<Int32Enum>.Peek
	|-TMP_RichTextTagStack<FontWeight>.Peek
	|-TMP_RichTextTagStack<Color32>.Peek
	|
	|-TMP_RichTextTagStack<object>.Peek
	|
	|-TMP_RichTextTagStack<float>.Peek
	|
	|-TMP_RichTextTagStack<MaterialReference>.Peek
	*/

	public T CurrentItem() { }
	/* GenericInstMethod :
	|
	|-TMP_RichTextTagStack<int>.CurrentItem
	|-TMP_RichTextTagStack<Int32Enum>.CurrentItem
	|-TMP_RichTextTagStack<Color32>.CurrentItem
	|
	|-TMP_RichTextTagStack<object>.CurrentItem
	|
	|-TMP_RichTextTagStack<float>.CurrentItem
	|
	|-TMP_RichTextTagStack<MaterialReference>.CurrentItem
	*/

	public T PreviousItem() { }
	/* GenericInstMethod :
	|
	|-TMP_RichTextTagStack<int>.PreviousItem
	|-TMP_RichTextTagStack<Int32Enum>.PreviousItem
	|-TMP_RichTextTagStack<Color32>.PreviousItem
	|
	|-TMP_RichTextTagStack<object>.PreviousItem
	|
	|-TMP_RichTextTagStack<float>.PreviousItem
	|
	|-TMP_RichTextTagStack<MaterialReference>.PreviousItem
	*/

}

public class TMP_ScrollbarEventHandler : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, ISelectHandler, IDeselectHandler // TypeDefIndex: 6818
{
	public bool isSelected; 


	public void OnPointerClick(PointerEventData eventData) { }

	public void OnSelect(BaseEventData eventData) { }

	public void OnDeselect(BaseEventData eventData) { }

	public void .ctor() { }

}

public class TMP_SelectionCaret : MaskableGraphic // TypeDefIndex: 6819
{

	public override void Cull(Rect clipRect, bool validRect) { }

	public void .ctor() { }

}

public class TMP_Settings : ScriptableObject // TypeDefIndex: 6820
{
	private static TMP_Settings s_Instance; 
	[SerializeField] 
	private bool m_enableWordWrapping; 
	[SerializeField] 
	private bool m_enableKerning; 
	[SerializeField] 
	private bool m_enableExtraPadding; 
	[SerializeField] 
	private bool m_enableTintAllSprites; 
	[SerializeField] 
	private bool m_EnableRaycastTarget; 
	[SerializeField] 
	private bool m_GetFontFeaturesAtRuntime; 
	[SerializeField] 
	private int m_missingGlyphCharacter; 
	[SerializeField] 
	private bool m_warningsDisabled; 
	[SerializeField] 
	private TMP_FontAsset m_defaultFontAsset; 
	[SerializeField] 
	private string m_defaultFontAssetPath; 
	[SerializeField] 
	private float m_defaultFontSize; 
	[SerializeField] 
	private float m_defaultAutoSizeMinRatio; 
	[SerializeField] 
	private float m_defaultAutoSizeMaxRatio; 
	[SerializeField] 
	private Vector2 m_defaultTextMeshProTextContainerSize; 
	[SerializeField] 
	private Vector2 m_defaultTextMeshProUITextContainerSize; 
	[SerializeField] 
	private bool m_autoSizeTextContainer; 
	[SerializeField] 
	private List<TMP_FontAsset> m_fallbackFontAssets; 
	[SerializeField] 
	private bool m_matchMaterialPreset; 
	[SerializeField] 
	private string m_defaultColorGradientPresetsPath; 
	[SerializeField] 
	private bool m_enableEmojiSupport; 
	[SerializeField] 
	private TextAsset m_leadingCharacters; 
	[SerializeField] 
	private TextAsset m_followingCharacters; 
	[SerializeField] 
	private TMP_Settings.LineBreakingTable m_linebreakingRules; 

	public static string version { get; }
	public static bool enableWordWrapping { get; }
	public static bool enableKerning { get; }
	public static bool enableExtraPadding { get; }
	public static bool enableTintAllSprites { get; }
	public static bool enableRaycastTarget { get; }
	public static bool getFontFeaturesAtRuntime { get; }
	public static int missingGlyphCharacter { get; set; }
	public static bool warningsDisabled { get; }
	public static TMP_FontAsset defaultFontAsset { get; }
	public static string defaultFontAssetPath { get; }
	public static float defaultFontSize { get; }
	public static float defaultTextAutoSizingMinRatio { get; }
	public static float defaultTextAutoSizingMaxRatio { get; }
	public static Vector2 defaultTextMeshProTextContainerSize { get; }
	public static Vector2 defaultTextMeshProUITextContainerSize { get; }
	public static bool autoSizeTextContainer { get; }
	public static List<TMP_FontAsset> fallbackFontAssets { get; }
	public static bool matchMaterialPreset { get; }
	public static string defaultColorGradientPresetsPath { get; }
	public static bool enableEmojiSupport { get; set; }
	public static TextAsset leadingCharacters { get; }
	public static TextAsset followingCharacters { get; }
	public static TMP_Settings.LineBreakingTable linebreakingRules { get; }
	public static TMP_Settings instance { get; }


	public static string get_version() { }

	public static bool get_enableWordWrapping() { }

	public static bool get_enableKerning() { }

	public static bool get_enableExtraPadding() { }

	public static bool get_enableTintAllSprites() { }

	public static bool get_enableRaycastTarget() { }

	public static bool get_getFontFeaturesAtRuntime() { }

	public static int get_missingGlyphCharacter() { }

	public static void set_missingGlyphCharacter(int value) { }

	public static bool get_warningsDisabled() { }

	public static TMP_FontAsset get_defaultFontAsset() { }

	public static string get_defaultFontAssetPath() { }

	public static float get_defaultFontSize() { }

	public static float get_defaultTextAutoSizingMinRatio() { }

	public static float get_defaultTextAutoSizingMaxRatio() { }

	public static Vector2 get_defaultTextMeshProTextContainerSize() { }

	public static Vector2 get_defaultTextMeshProUITextContainerSize() { }

	public static bool get_autoSizeTextContainer() { }

	public static List<TMP_FontAsset> get_fallbackFontAssets() { }

	public static bool get_matchMaterialPreset() { }

	public static string get_defaultColorGradientPresetsPath() { }

	public static bool get_enableEmojiSupport() { }

	public static void set_enableEmojiSupport(bool value) { }

	public static TextAsset get_leadingCharacters() { }

	public static TextAsset get_followingCharacters() { }

	public static TMP_Settings.LineBreakingTable get_linebreakingRules() { }

	public static TMP_Settings get_instance() { }

	public static TMP_Settings LoadDefaultSettings() { }

	public static TMP_Settings GetSettings() { }

	public static TMP_FontAsset GetFontAsset() { }

	public static void LoadLinebreakingRules() { }

	private static Dictionary<int, char> GetCharacters(TextAsset file) { }

	public void .ctor() { }

}

public class TMP_Settings.LineBreakingTable // TypeDefIndex: 6821
{
	public Dictionary<int, char> leadingCharacters; 
	public Dictionary<int, char> followingCharacters; 


	public void .ctor() { }

}

public class TMP_SubMesh : MonoBehaviour // TypeDefIndex: 6823
{
	[SerializeField] 
	private TMP_FontAsset m_fontAsset; 
	[SerializeField] 
	private Material m_material; 
	[SerializeField] 
	private Material m_sharedMaterial; 
	private Material m_fallbackMaterial; 
	private Material m_fallbackSourceMaterial; 
	[SerializeField] 
	private bool m_isDefaultMaterial; 
	[SerializeField] 
	private float m_padding; 
	[SerializeField] 
	private Renderer m_renderer; 
	[SerializeField] 
	private MeshFilter m_meshFilter; 
	private Mesh m_mesh; 
	[SerializeField] 
	private TextMeshPro m_TextComponent; 
	private bool m_isRegisteredForEvents; 

	public TMP_FontAsset fontAsset { get; set; }
	public Material material { get; set; }
	public Material sharedMaterial { get; set; }
	public Material fallbackMaterial { get; set; }
	public Material fallbackSourceMaterial { get; set; }
	public bool isDefaultMaterial { get; set; }
	public float padding { get; set; }
	public Renderer renderer { get; }
	public MeshFilter meshFilter { get; }
	public Mesh mesh { get; set; }


	public TMP_FontAsset get_fontAsset() { }

	public void set_fontAsset(TMP_FontAsset value) { }

	public Material get_material() { }

	public void set_material(Material value) { }

	public Material get_sharedMaterial() { }

	public void set_sharedMaterial(Material value) { }

	public Material get_fallbackMaterial() { }

	public void set_fallbackMaterial(Material value) { }

	public Material get_fallbackSourceMaterial() { }

	public void set_fallbackSourceMaterial(Material value) { }

	public bool get_isDefaultMaterial() { }

	public void set_isDefaultMaterial(bool value) { }

	public float get_padding() { }

	public void set_padding(float value) { }

	public Renderer get_renderer() { }

	public MeshFilter get_meshFilter() { }

	public Mesh get_mesh() { }

	public void set_mesh(Mesh value) { }

	private void OnEnable() { }

	private void OnDisable() { }

	private void OnDestroy() { }

	public static TMP_SubMesh AddSubTextObject(TextMeshPro textComponent, MaterialReference materialReference) { }

	public void DestroySelf() { }

	private Material GetMaterial(Material mat) { }

	private Material CreateMaterialInstance(Material source) { }

	private Material GetSharedMaterial() { }

	private void SetSharedMaterial(Material mat) { }

	public float GetPaddingForMaterial() { }

	public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold) { }

	public void SetVerticesDirty() { }

	public void SetMaterialDirty() { }

	protected void UpdateMaterial() { }

	public void .ctor() { }

}

public class TMP_SubMeshUI : MaskableGraphic, IClippable, IMaskable, IMaterialModifier // TypeDefIndex: 6824
{
	[SerializeField] 
	private TMP_FontAsset m_fontAsset; 
	[SerializeField] 
	private Material m_material; 
	[SerializeField] 
	private Material m_sharedMaterial; 
	private Material m_fallbackMaterial; 
	private Material m_fallbackSourceMaterial; 
	[SerializeField] 
	private bool m_isDefaultMaterial; 
	[SerializeField] 
	private float m_padding; 
	[SerializeField] 
	private CanvasRenderer m_canvasRenderer; 
	private Mesh m_mesh; 
	[SerializeField] 
	private TextMeshProUGUI m_TextComponent; 
	private bool m_isRegisteredForEvents; 
	private bool m_materialDirty; 
	[SerializeField] 
	private int m_materialReferenceIndex; 

	public TMP_FontAsset fontAsset { get; set; }
	public override Texture mainTexture { get; }
	public override Material material { get; set; }
	public Material sharedMaterial { get; set; }
	public Material fallbackMaterial { get; set; }
	public Material fallbackSourceMaterial { get; set; }
	public override Material materialForRendering { get; }
	public bool isDefaultMaterial { get; set; }
	public float padding { get; set; }
	public CanvasRenderer canvasRenderer { get; }
	public Mesh mesh { get; set; }


	public TMP_FontAsset get_fontAsset() { }

	public void set_fontAsset(TMP_FontAsset value) { }

	public override Texture get_mainTexture() { }

	public override Material get_material() { }

	public override void set_material(Material value) { }

	public Material get_sharedMaterial() { }

	public void set_sharedMaterial(Material value) { }

	public Material get_fallbackMaterial() { }

	public void set_fallbackMaterial(Material value) { }

	public Material get_fallbackSourceMaterial() { }

	public void set_fallbackSourceMaterial(Material value) { }

	public override Material get_materialForRendering() { }

	public bool get_isDefaultMaterial() { }

	public void set_isDefaultMaterial(bool value) { }

	public float get_padding() { }

	public void set_padding(float value) { }

	public CanvasRenderer get_canvasRenderer() { }

	public Mesh get_mesh() { }

	public void set_mesh(Mesh value) { }

	public static TMP_SubMeshUI AddSubTextObject(TextMeshProUGUI textComponent, MaterialReference materialReference) { }

	protected override void OnEnable() { }

	protected override void OnDisable() { }

	protected override void OnDestroy() { }

	protected override void OnTransformParentChanged() { }

	public override Material GetModifiedMaterial(Material baseMaterial) { }

	public float GetPaddingForMaterial() { }

	public float GetPaddingForMaterial(Material mat) { }

	public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold) { }

	public override void SetAllDirty() { }

	public override void SetVerticesDirty() { }

	public override void SetLayoutDirty() { }

	public override void SetMaterialDirty() { }

	public void SetPivotDirty() { }

	public override void Cull(Rect clipRect, bool validRect) { }

	protected override void UpdateGeometry() { }

	public override void Rebuild(CanvasUpdate update) { }

	public void RefreshMaterial() { }

	protected override void UpdateMaterial() { }

	public override void RecalculateClipping() { }

	public override void RecalculateMasking() { }

	private Material GetMaterial() { }

	private Material GetMaterial(Material mat) { }

	private Material CreateMaterialInstance(Material source) { }

	private Material GetSharedMaterial() { }

	private void SetSharedMaterial(Material mat) { }

	public void .ctor() { }

}

public enum TMP_TextElementType // TypeDefIndex: 6830
{
	public int value__; 
	public const TMP_TextElementType Character = 0;
	public const TMP_TextElementType Unused = 1;

}

public abstract class TMP_Text : MaskableGraphic // TypeDefIndex: 6837
{
	[SerializeField] 
	[TextAreaAttribute] 
	protected string m_text; 
	[SerializeField] 
	protected bool m_isRightToLeft; 
	[SerializeField] 
	protected TMP_FontAsset m_fontAsset; 
	protected TMP_FontAsset m_currentFontAsset; 
	protected bool m_isSDFShader; 
	[SerializeField] 
	protected Material m_sharedMaterial; 
	protected Material m_currentMaterial; 
	protected MaterialReference[] m_materialReferences; 
	protected Dictionary<int, int> m_materialReferenceIndexLookup; 
	protected TMP_RichTextTagStack<MaterialReference> m_materialReferenceStack; 
	protected int m_currentMaterialIndex; 
	[SerializeField] 
	protected Material[] m_fontSharedMaterials; 
	[SerializeField] 
	protected Material m_fontMaterial; 
	[SerializeField] 
	protected Material[] m_fontMaterials; 
	protected bool m_isMaterialDirty; 
	[SerializeField] 
	[ColorUsageAttribute] 
	protected Color32 m_fontColor32; 
	[SerializeField] 
	[ColorUsageAttribute] 
	protected Color m_fontColor; 
	protected static Color32 s_colorWhite; 
	protected Color32 m_underlineColor; 
	protected Color32 m_strikethroughColor; 
	protected Color32 m_highlightColor; 
	protected Vector4 m_highlightPadding; 
	[SerializeField] 
	protected bool m_enableVertexGradient; 
	[SerializeField] 
	protected ColorMode m_colorMode; 
	[SerializeField] 
	protected VertexGradient m_fontColorGradient; 
	[SerializeField] 
	protected TMP_ColorGradient m_fontColorGradientPreset; 
	[SerializeField] 
	protected bool m_overrideHtmlColors; 
	[SerializeField] 
	protected Color32 m_faceColor; 
	[SerializeField] 
	protected Color32 m_outlineColor; 
	protected float m_outlineWidth; 
	[SerializeField] 
	protected float m_fontSize; 
	protected float m_currentFontSize; 
	[SerializeField] 
	protected float m_fontSizeBase; 
	protected TMP_RichTextTagStack<float> m_sizeStack; 
	[SerializeField] 
	protected FontWeight m_fontWeight; 
	protected FontWeight m_FontWeightInternal; 
	protected TMP_RichTextTagStack<FontWeight> m_FontWeightStack; 
	[SerializeField] 
	protected bool m_enableAutoSizing; 
	protected float m_maxFontSize; 
	protected float m_minFontSize; 
	[SerializeField] 
	protected float m_fontSizeMin; 
	[SerializeField] 
	protected float m_fontSizeMax; 
	[SerializeField] 
	protected FontStyles m_fontStyle; 
	protected FontStyles m_FontStyleInternal; 
	protected TMP_FontStyleStack m_fontStyleStack; 
	protected bool m_isUsingBold; 
	[SerializeField] 
	[FormerlySerializedAsAttribute] 
	protected TextAlignmentOptions m_textAlignment; 
	protected TextAlignmentOptions m_lineJustification; 
	protected TMP_RichTextTagStack<TextAlignmentOptions> m_lineJustificationStack; 
	protected Vector3[] m_textContainerLocalCorners; 
	[SerializeField] 
	protected float m_characterSpacing; 
	protected float m_cSpacing; 
	protected float m_monoSpacing; 
	[SerializeField] 
	protected float m_wordSpacing; 
	[SerializeField] 
	protected float m_lineSpacing; 
	protected float m_lineSpacingDelta; 
	protected float m_lineHeight; 
	[SerializeField] 
	protected float m_lineSpacingMax; 
	[SerializeField] 
	protected float m_paragraphSpacing; 
	[SerializeField] 
	protected float m_charWidthMaxAdj; 
	protected float m_charWidthAdjDelta; 
	[SerializeField] 
	protected bool m_enableWordWrapping; 
	protected bool m_isCharacterWrappingEnabled; 
	protected bool m_isNonBreakingSpace; 
	protected bool m_isIgnoringAlignment; 
	[SerializeField] 
	protected float m_wordWrappingRatios; 
	[SerializeField] 
	protected TextOverflowModes m_overflowMode; 
	[SerializeField] 
	protected int m_firstOverflowCharacterIndex; 
	[SerializeField] 
	protected TMP_Text m_linkedTextComponent; 
	[SerializeField] 
	protected bool m_isLinkedTextComponent; 
	[SerializeField] 
	protected bool m_isTextTruncated; 
	[SerializeField] 
	protected bool m_enableKerning; 
	[SerializeField] 
	protected bool m_enableExtraPadding; 
	[SerializeField] 
	protected bool checkPaddingRequired; 
	[SerializeField] 
	protected bool m_isRichText; 
	protected bool m_isOverlay; 
	[SerializeField] 
	protected bool m_isOrthographic; 
	[SerializeField] 
	protected bool m_isCullingEnabled; 
	[SerializeField] 
	protected bool m_ignoreRectMaskCulling; 
	[SerializeField] 
	protected bool m_ignoreCulling; 
	[SerializeField] 
	protected TextureMappingOptions m_horizontalMapping; 
	[SerializeField] 
	protected TextureMappingOptions m_verticalMapping; 
	[SerializeField] 
	protected float m_uvLineOffset; 
	protected TextRenderFlags m_renderMode; 
	[SerializeField] 
	protected VertexSortingOrder m_geometrySortingOrder; 
	[SerializeField] 
	protected bool m_VertexBufferAutoSizeReduction; 
	[SerializeField] 
	protected int m_firstVisibleCharacter; 
	protected int m_maxVisibleCharacters; 
	protected int m_maxVisibleWords; 
	protected int m_maxVisibleLines; 
	[SerializeField] 
	protected bool m_useMaxVisibleDescender; 
	[SerializeField] 
	protected int m_pageToDisplay; 
	protected bool m_isNewPage; 
	[SerializeField] 
	protected Vector4 m_margin; 
	protected float m_marginLeft; 
	protected float m_marginRight; 
	protected float m_marginWidth; 
	protected float m_marginHeight; 
	protected float m_width; 
	[SerializeField] 
	protected TMP_TextInfo m_textInfo; 
	protected bool m_havePropertiesChanged; 
	[SerializeField] 
	protected bool m_isUsingLegacyAnimationComponent; 
	protected Transform m_transform; 
	protected RectTransform m_rectTransform; 
	[CompilerGeneratedAttribute] 
	private bool <autoSizeTextContainer>k__BackingField; 
	protected bool m_autoSizeTextContainer; 
	protected Mesh m_mesh; 
	[SerializeField] 
	protected bool m_isVolumetricText; 
	protected float m_flexibleHeight; 
	protected float m_flexibleWidth; 
	protected float m_minWidth; 
	protected float m_minHeight; 
	protected float m_maxWidth; 
	protected float m_maxHeight; 
	protected LayoutElement m_LayoutElement; 
	protected float m_preferredWidth; 
	protected float m_renderedWidth; 
	protected bool m_isPreferredWidthDirty; 
	protected float m_preferredHeight; 
	protected float m_renderedHeight; 
	protected bool m_isPreferredHeightDirty; 
	protected bool m_isCalculatingPreferredValues; 
	private int m_recursiveCount; 
	protected int m_layoutPriority; 
	protected bool m_isCalculateSizeRequired; 
	protected bool m_isLayoutDirty; 
	protected bool m_verticesAlreadyDirty; 
	protected bool m_layoutAlreadyDirty; 
	protected bool m_isAwake; 
	internal bool m_isWaitingOnResourceLoad; 
	internal bool m_isInputParsingRequired; 
	protected string old_text; 
	protected float m_fontScale; 
	protected float m_fontScaleMultiplier; 
	protected char[] m_htmlTag; 
	protected RichTextTagAttribute[] m_xmlAttribute; 
	protected float[] m_attributeParameterValues; 
	protected float tag_LineIndent; 
	protected float tag_Indent; 
	protected TMP_RichTextTagStack<float> m_indentStack; 
	protected bool tag_NoParsing; 
	protected bool m_isParsingText; 
	protected Matrix4x4 m_FXMatrix; 
	protected bool m_isFXMatrixSet; 
	protected TMP_Text.UnicodeChar[] m_TextParsingBuffer; 
	private TMP_CharacterInfo[] m_internalCharacterInfo; 
	protected int m_totalCharacterCount; 
	protected WordWrapState m_SavedWordWrapState; 
	protected WordWrapState m_SavedLineState; 
	protected int m_characterCount; 
	protected int m_firstCharacterOfLine; 
	protected int m_firstVisibleCharacterOfLine; 
	protected int m_lastCharacterOfLine; 
	protected int m_lastVisibleCharacterOfLine; 
	protected int m_lineNumber; 
	protected int m_lineVisibleCharacterCount; 
	protected int m_pageNumber; 
	protected float m_maxAscender; 
	protected float m_maxCapHeight; 
	protected float m_maxDescender; 
	protected float m_maxLineAscender; 
	protected float m_maxLineDescender; 
	protected float m_startOfLineAscender; 
	protected float m_lineOffset; 
	protected Extents m_meshExtents; 
	protected Color32 m_htmlColor; 
	protected TMP_RichTextTagStack<Color32> m_colorStack; 
	protected TMP_RichTextTagStack<Color32> m_underlineColorStack; 
	protected TMP_RichTextTagStack<Color32> m_strikethroughColorStack; 
	protected TMP_RichTextTagStack<Color32> m_highlightColorStack; 
	protected TMP_ColorGradient m_colorGradientPreset; 
	protected TMP_RichTextTagStack<TMP_ColorGradient> m_colorGradientStack; 
	protected float m_tabSpacing; 
	protected float m_spacing; 
	protected TMP_RichTextTagStack<int> m_styleStack; 
	protected TMP_RichTextTagStack<int> m_actionStack; 
	protected float m_padding; 
	protected float m_baselineOffset; 
	protected TMP_RichTextTagStack<float> m_baselineOffsetStack; 
	protected float m_xAdvance; 
	protected TMP_TextElementType m_textElementType; 
	protected TMP_TextElement m_cached_TextElement; 
	protected TMP_Character m_cached_Underline_Character; 
	protected TMP_Character m_cached_Ellipsis_Character; 
	protected int m_spriteCount; 
	protected int m_spriteIndex; 
	protected int m_spriteAnimationID; 
	protected bool m_ignoreActiveState; 
	protected static Vector2 k_LargePositiveVector2; 
	protected static Vector2 k_LargeNegativeVector2; 
	protected static float k_LargePositiveFloat; 
	protected static float k_LargeNegativeFloat; 
	protected static int k_LargePositiveInt; 
	protected static int k_LargeNegativeInt; 

	public string text { get; set; }
	public bool isRightToLeftText { get; set; }
	public TMP_FontAsset font { get; set; }
	public virtual Material fontSharedMaterial { get; set; }
	public virtual Material[] fontSharedMaterials { get; set; }
	public Material fontMaterial { get; set; }
	public virtual Material[] fontMaterials { get; set; }
	public override Color color { get; set; }
	public float alpha { get; set; }
	public bool enableVertexGradient { get; set; }
	public VertexGradient colorGradient { get; set; }
	public TMP_ColorGradient colorGradientPreset { get; set; }
	public bool overrideColorTags { get; set; }
	public Color32 faceColor { get; set; }
	public Color32 outlineColor { get; set; }
	public float outlineWidth { get; set; }
	public float fontSize { get; set; }
	public float fontScale { get; }
	public FontWeight fontWeight { get; set; }
	public float pixelsPerUnit { get; }
	public bool enableAutoSizing { get; set; }
	public float fontSizeMin { get; set; }
	public float fontSizeMax { get; set; }
	public FontStyles fontStyle { get; set; }
	public bool isUsingBold { get; }
	public TextAlignmentOptions alignment { get; set; }
	public float characterSpacing { get; set; }
	public float wordSpacing { get; set; }
	public float lineSpacing { get; set; }
	public float lineSpacingAdjustment { get; set; }
	public float paragraphSpacing { get; set; }
	public float characterWidthAdjustment { get; set; }
	public bool enableWordWrapping { get; set; }
	public float wordWrappingRatios { get; set; }
	public TextOverflowModes overflowMode { get; set; }
	public bool isTextOverflowing { get; }
	public int firstOverflowCharacterIndex { get; }
	public TMP_Text linkedTextComponent { get; set; }
	public bool isLinkedTextComponent { get; set; }
	public bool isTextTruncated { get; }
	public bool enableKerning { get; set; }
	public bool extraPadding { get; set; }
	public bool richText { get; set; }
	public bool isOverlay { get; set; }
	public bool isOrthographic { get; set; }
	public bool enableCulling { get; set; }
	public bool ignoreRectMaskCulling { get; set; }
	public bool ignoreVisibility { get; set; }
	public TextureMappingOptions horizontalMapping { get; set; }
	public TextureMappingOptions verticalMapping { get; set; }
	public float mappingUvLineOffset { get; set; }
	public TextRenderFlags renderMode { get; set; }
	public VertexSortingOrder geometrySortingOrder { get; set; }
	public bool vertexBufferAutoSizeReduction { get; set; }
	public int firstVisibleCharacter { get; set; }
	public int maxVisibleCharacters { get; set; }
	public int maxVisibleWords { get; set; }
	public int maxVisibleLines { get; set; }
	public bool useMaxVisibleDescender { get; set; }
	public int pageToDisplay { get; set; }
	public virtual Vector4 margin { get; set; }
	public TMP_TextInfo textInfo { get; }
	public bool havePropertiesChanged { get; set; }
	public bool isUsingLegacyAnimationComponent { get; set; }
	public Transform transform { get; }
	public RectTransform rectTransform { get; }
	public virtual bool autoSizeTextContainer { get; set; }
	public virtual Mesh mesh { get; }
	public bool isVolumetricText { get; set; }
	public Bounds bounds { get; }
	public Bounds textBounds { get; }
	public float flexibleHeight { get; }
	public float flexibleWidth { get; }
	public float minWidth { get; }
	public float minHeight { get; }
	public float maxWidth { get; }
	public float maxHeight { get; }
	protected LayoutElement layoutElement { get; }
	public virtual float preferredWidth { get; }
	public virtual float preferredHeight { get; }
	public virtual float renderedWidth { get; }
	public virtual float renderedHeight { get; }
	public int layoutPriority { get; }


	public string get_text() { }

	public void set_text(string value) { }

	public bool get_isRightToLeftText() { }

	public void set_isRightToLeftText(bool value) { }

	public TMP_FontAsset get_font() { }

	public void set_font(TMP_FontAsset value) { }

	public virtual Material get_fontSharedMaterial() { }

	public virtual void set_fontSharedMaterial(Material value) { }

	public virtual Material[] get_fontSharedMaterials() { }

	public virtual void set_fontSharedMaterials(Material[] value) { }

	public Material get_fontMaterial() { }

	public void set_fontMaterial(Material value) { }

	public virtual Material[] get_fontMaterials() { }

	public virtual void set_fontMaterials(Material[] value) { }

	public override Color get_color() { }

	public override void set_color(Color value) { }

	public float get_alpha() { }

	public void set_alpha(float value) { }

	public bool get_enableVertexGradient() { }

	public void set_enableVertexGradient(bool value) { }

	public VertexGradient get_colorGradient() { }

	public void set_colorGradient(VertexGradient value) { }

	public TMP_ColorGradient get_colorGradientPreset() { }

	public void set_colorGradientPreset(TMP_ColorGradient value) { }

	public bool get_overrideColorTags() { }

	public void set_overrideColorTags(bool value) { }

	public Color32 get_faceColor() { }

	public void set_faceColor(Color32 value) { }

	public Color32 get_outlineColor() { }

	public void set_outlineColor(Color32 value) { }

	public float get_outlineWidth() { }

	public void set_outlineWidth(float value) { }

	public float get_fontSize() { }

	public void set_fontSize(float value) { }

	public float get_fontScale() { }

	public FontWeight get_fontWeight() { }

	public void set_fontWeight(FontWeight value) { }

	public float get_pixelsPerUnit() { }

	public bool get_enableAutoSizing() { }

	public void set_enableAutoSizing(bool value) { }

	public float get_fontSizeMin() { }

	public void set_fontSizeMin(float value) { }

	public float get_fontSizeMax() { }

	public void set_fontSizeMax(float value) { }

	public FontStyles get_fontStyle() { }

	public void set_fontStyle(FontStyles value) { }

	public bool get_isUsingBold() { }

	public TextAlignmentOptions get_alignment() { }

	public void set_alignment(TextAlignmentOptions value) { }

	public float get_characterSpacing() { }

	public void set_characterSpacing(float value) { }

	public float get_wordSpacing() { }

	public void set_wordSpacing(float value) { }

	public float get_lineSpacing() { }

	public void set_lineSpacing(float value) { }

	public float get_lineSpacingAdjustment() { }

	public void set_lineSpacingAdjustment(float value) { }

	public float get_paragraphSpacing() { }

	public void set_paragraphSpacing(float value) { }

	public float get_characterWidthAdjustment() { }

	public void set_characterWidthAdjustment(float value) { }

	public bool get_enableWordWrapping() { }

	public void set_enableWordWrapping(bool value) { }

	public float get_wordWrappingRatios() { }

	public void set_wordWrappingRatios(float value) { }

	public TextOverflowModes get_overflowMode() { }

	public void set_overflowMode(TextOverflowModes value) { }

	public bool get_isTextOverflowing() { }

	public int get_firstOverflowCharacterIndex() { }

	public TMP_Text get_linkedTextComponent() { }

	public void set_linkedTextComponent(TMP_Text value) { }

	public bool get_isLinkedTextComponent() { }

	public void set_isLinkedTextComponent(bool value) { }

	public bool get_isTextTruncated() { }

	public bool get_enableKerning() { }

	public void set_enableKerning(bool value) { }

	public bool get_extraPadding() { }

	public void set_extraPadding(bool value) { }

	public bool get_richText() { }

	public void set_richText(bool value) { }

	public bool get_isOverlay() { }

	public void set_isOverlay(bool value) { }

	public bool get_isOrthographic() { }

	public void set_isOrthographic(bool value) { }

	public bool get_enableCulling() { }

	public void set_enableCulling(bool value) { }

	public bool get_ignoreRectMaskCulling() { }

	public void set_ignoreRectMaskCulling(bool value) { }

	public bool get_ignoreVisibility() { }

	public void set_ignoreVisibility(bool value) { }

	public TextureMappingOptions get_horizontalMapping() { }

	public void set_horizontalMapping(TextureMappingOptions value) { }

	public TextureMappingOptions get_verticalMapping() { }

	public void set_verticalMapping(TextureMappingOptions value) { }

	public float get_mappingUvLineOffset() { }

	public void set_mappingUvLineOffset(float value) { }

	public TextRenderFlags get_renderMode() { }

	public void set_renderMode(TextRenderFlags value) { }

	public VertexSortingOrder get_geometrySortingOrder() { }

	public void set_geometrySortingOrder(VertexSortingOrder value) { }

	public bool get_vertexBufferAutoSizeReduction() { }

	public void set_vertexBufferAutoSizeReduction(bool value) { }

	public int get_firstVisibleCharacter() { }

	public void set_firstVisibleCharacter(int value) { }

	public int get_maxVisibleCharacters() { }

	public void set_maxVisibleCharacters(int value) { }

	public int get_maxVisibleWords() { }

	public void set_maxVisibleWords(int value) { }

	public int get_maxVisibleLines() { }

	public void set_maxVisibleLines(int value) { }

	public bool get_useMaxVisibleDescender() { }

	public void set_useMaxVisibleDescender(bool value) { }

	public int get_pageToDisplay() { }

	public void set_pageToDisplay(int value) { }

	public virtual Vector4 get_margin() { }

	public virtual void set_margin(Vector4 value) { }

	public TMP_TextInfo get_textInfo() { }

	public bool get_havePropertiesChanged() { }

	public void set_havePropertiesChanged(bool value) { }

	public bool get_isUsingLegacyAnimationComponent() { }

	public void set_isUsingLegacyAnimationComponent(bool value) { }

	public Transform get_transform() { }

	public RectTransform get_rectTransform() { }

	[CompilerGeneratedAttribute] 
	public virtual bool get_autoSizeTextContainer() { }

	[CompilerGeneratedAttribute] 
	public virtual void set_autoSizeTextContainer(bool value) { }

	public virtual Mesh get_mesh() { }

	public bool get_isVolumetricText() { }

	public void set_isVolumetricText(bool value) { }

	public Bounds get_bounds() { }

	public Bounds get_textBounds() { }

	public float get_flexibleHeight() { }

	public float get_flexibleWidth() { }

	public float get_minWidth() { }

	public float get_minHeight() { }

	public float get_maxWidth() { }

	public float get_maxHeight() { }

	protected LayoutElement get_layoutElement() { }

	public virtual float get_preferredWidth() { }

	public virtual float get_preferredHeight() { }

	public virtual float get_renderedWidth() { }

	public virtual float get_renderedHeight() { }

	public int get_layoutPriority() { }

	protected virtual void LoadFontAsset() { }

	protected virtual void SetSharedMaterial(Material mat) { }

	protected virtual Material GetMaterial(Material mat) { }

	protected virtual void SetFontBaseMaterial(Material mat) { }

	protected virtual Material[] GetSharedMaterials() { }

	protected virtual void SetSharedMaterials(Material[] materials) { }

	protected virtual Material[] GetMaterials(Material[] mats) { }

	protected virtual Material CreateMaterialInstance(Material source) { }

	protected void SetVertexColorGradient(TMP_ColorGradient gradient) { }

	protected void SetTextSortingOrder(VertexSortingOrder order) { }

	protected void SetTextSortingOrder(int[] order) { }

	protected virtual void SetFaceColor(Color32 color) { }

	protected virtual void SetOutlineColor(Color32 color) { }

	protected virtual void SetOutlineThickness(float thickness) { }

	protected virtual void SetShaderDepth() { }

	protected virtual void SetCulling() { }

	protected virtual float GetPaddingForMaterial() { }

	protected virtual float GetPaddingForMaterial(Material mat) { }

	protected virtual Vector3[] GetTextContainerLocalCorners() { }

	public virtual void ForceMeshUpdate() { }

	public virtual void ForceMeshUpdate(bool ignoreActiveState) { }

	internal void SetTextInternal(string text) { }

	public virtual void UpdateGeometry(Mesh mesh, int index) { }

	public virtual void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	public virtual void UpdateVertexData() { }

	public virtual void SetVertices(Vector3[] vertices) { }

	public virtual void UpdateMeshPadding() { }

	public override void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	public override void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	protected virtual void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	protected virtual void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	protected void ParseInputText() { }

	protected void StringToCharArray(string sourceText, ref TMP_Text.UnicodeChar[] charBuffer) { }

	protected void StringBuilderToIntArray(StringBuilder sourceText, ref TMP_Text.UnicodeChar[] charBuffer) { }

	private bool IsTagName(ref string text, string tag, int index) { }

	private bool IsTagName(ref char[] text, string tag, int index) { }

	private bool IsTagName(ref int[] text, string tag, int index) { }

	private bool IsTagName(ref StringBuilder text, string tag, int index) { }

	private int GetTagHashCode(ref string text, int index, out int closeIndex) { }

	private int GetTagHashCode(ref char[] text, int index, out int closeIndex) { }

	private int GetTagHashCode(ref int[] text, int index, out int closeIndex) { }

	private int GetTagHashCode(ref StringBuilder text, int index, out int closeIndex) { }

	private void ResizeInternalArray<T>(ref T[] array) { }
	/* GenericInstMethod :
	|
	|-TMP_Text.ResizeInternalArray<object>
	|
	|-TMP_Text.ResizeInternalArray<TMP_Text.UnicodeChar>
	*/

	protected virtual int SetArraySizes(TMP_Text.UnicodeChar[] chars) { }

	protected virtual void GenerateTextMesh() { }

	public Vector2 GetPreferredValues() { }

	public Vector2 GetPreferredValues(float width, float height) { }

	public Vector2 GetPreferredValues(string text) { }

	public Vector2 GetPreferredValues(string text, float width, float height) { }

	protected float GetPreferredWidth() { }

	protected float GetPreferredWidth(Vector2 margin) { }

	protected float GetPreferredHeight() { }

	protected float GetPreferredHeight(Vector2 margin) { }

	public Vector2 GetRenderedValues() { }

	public Vector2 GetRenderedValues(bool onlyVisibleCharacters) { }

	protected float GetRenderedWidth() { }

	protected float GetRenderedWidth(bool onlyVisibleCharacters) { }

	protected float GetRenderedHeight() { }

	protected float GetRenderedHeight(bool onlyVisibleCharacters) { }

	protected virtual Vector2 CalculatePreferredValues(float defaultFontSize, Vector2 marginSize, bool ignoreTextAutoSizing) { }

	protected virtual Bounds GetCompoundBounds() { }

	protected Bounds GetTextBounds() { }

	protected Bounds GetTextBounds(bool onlyVisibleCharacters) { }

	protected virtual void AdjustLineOffset(int startIndex, int endIndex, float offset) { }

	protected void ResizeLineExtents(int size) { }

	public virtual TMP_TextInfo GetTextInfo(string text) { }

	public virtual void ComputeMarginSize() { }

	protected void SaveWordWrappingState(ref WordWrapState state, int index, int count) { }

	protected int RestoreWordWrappingState(ref WordWrapState state) { }

	protected virtual void SaveGlyphVertexInfo(float padding, float style_padding, Color32 vertexColor) { }

	protected virtual void FillCharacterVertexBuffers(int i, int index_X4) { }

	protected virtual void FillCharacterVertexBuffers(int i, int index_X4, bool isVolumetric) { }

	protected virtual void DrawUnderlineMesh(Vector3 start, Vector3 end, ref int index, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor) { }

	protected virtual void DrawTextHighlight(Vector3 start, Vector3 end, ref int index, Color32 highlightColor) { }

	protected void LoadDefaultSettings() { }

	protected void GetSpecialCharacters(TMP_FontAsset fontAsset) { }

	protected void ReplaceTagWithCharacter(int[] chars, int insertionIndex, int tagLength, char c) { }

	protected TMP_FontAsset GetFontAssetForWeight(int fontWeight) { }

	protected virtual void SetActiveSubMeshes(bool state) { }

	protected virtual void ClearSubMeshObjects() { }

	public virtual void ClearMesh() { }

	public virtual void ClearMesh(bool uploadGeometry) { }

	public virtual string GetParsedText() { }

	protected Vector2 PackUV(float x, float y, float scale) { }

	protected float PackUV(float x, float y) { }

	internal virtual void InternalUpdate() { }

	protected int HexToInt(char hex) { }

	protected int GetUTF16(string text, int i) { }

	protected int GetUTF16(StringBuilder text, int i) { }

	protected int GetUTF32(string text, int i) { }

	protected int GetUTF32(StringBuilder text, int i) { }

	protected Color32 HexCharsToColor(char[] hexChars, int tagCount) { }

	protected Color32 HexCharsToColor(char[] hexChars, int startIndex, int length) { }

	private int GetAttributeParameters(char[] chars, int startIndex, int length, ref float[] parameters) { }

	protected float ConvertToFloat(char[] chars, int startIndex, int length) { }

	protected float ConvertToFloat(char[] chars, int startIndex, int length, out int lastIndex) { }

	protected bool ValidateHtmlTag(TMP_Text.UnicodeChar[] chars, int startIndex, out int endIndex) { }

	protected void .ctor() { }

	private static void .cctor() { }

}

public class TMP_TextElement // TypeDefIndex: 6840
{
	[SerializeField] 
	protected TextElementType m_ElementType; 
	[SerializeField] 
	private uint m_Unicode; 
	private Glyph m_Glyph; 
	[SerializeField] 
	private uint m_GlyphIndex; 
	[SerializeField] 
	private float m_Scale; 

	public TextElementType elementType { get; }
	public uint unicode { get; set; }
	public Glyph glyph { get; set; }
	public uint glyphIndex { get; set; }
	public float scale { get; set; }


	public TextElementType get_elementType() { }

	public uint get_unicode() { }

	public void set_unicode(uint value) { }

	public Glyph get_glyph() { }

	public void set_glyph(Glyph value) { }

	public uint get_glyphIndex() { }

	public void set_glyphIndex(uint value) { }

	public float get_scale() { }

	public void set_scale(float value) { }

	public void .ctor() { }

}

public class TMP_TextElement_Legacy // TypeDefIndex: 6841
{
	public int id; 
	public float x; 
	public float y; 
	public float width; 
	public float height; 
	public float xOffset; 
	public float yOffset; 
	public float xAdvance; 
	public float scale; 


	public void .ctor() { }

}

public class TMP_TextInfo // TypeDefIndex: 6842
{
	private static Vector2 k_InfinityVectorPositive; 
	private static Vector2 k_InfinityVectorNegative; 
	public TMP_Text textComponent; 
	public int characterCount; 
	public int spriteCount; 
	public int spaceCount; 
	public int wordCount; 
	public int linkCount; 
	public int lineCount; 
	public int pageCount; 
	public int materialCount; 
	public TMP_CharacterInfo[] characterInfo; 
	public TMP_WordInfo[] wordInfo; 
	public TMP_LinkInfo[] linkInfo; 
	public TMP_LineInfo[] lineInfo; 
	public TMP_PageInfo[] pageInfo; 
	public TMP_MeshInfo[] meshInfo; 
	private TMP_MeshInfo[] m_CachedMeshInfo; 


	public void .ctor() { }

	public void .ctor(TMP_Text textComponent) { }

	public void Clear() { }

	public void ClearMeshInfo(bool updateMesh) { }

	public void ClearAllMeshInfo() { }

	public void ResetVertexLayout(bool isVolumetric) { }

	public void ClearUnusedVertices(MaterialReference[] materials) { }

	public void ClearLineInfo() { }

	public TMP_MeshInfo[] CopyMeshInfoVertexData() { }

	public static void Resize<T>(ref T[] array, int size) { }
	/* GenericInstMethod :
	|
	|-TMP_TextInfo.Resize<object>
	|-TMP_TextInfo.Resize<TMP_SubMesh>
	|-TMP_TextInfo.Resize<TMP_SubMeshUI>
	|
	|-TMP_TextInfo.Resize<TMP_LinkInfo>
	|
	|-TMP_TextInfo.Resize<TMP_WordInfo>
	*/

	public static void Resize<T>(ref T[] array, int size, bool isBlockAllocated) { }
	/* GenericInstMethod :
	|
	|-TMP_TextInfo.Resize<object>
	|-TMP_TextInfo.Resize<Material>
	|
	|-TMP_TextInfo.Resize<TMP_CharacterInfo>
	|
	|-TMP_TextInfo.Resize<TMP_MeshInfo>
	|
	|-TMP_TextInfo.Resize<TMP_PageInfo>
	*/

	private static void .cctor() { }

}

public class TMP_TextParsingUtilities // TypeDefIndex: 6843
{
	private static readonly TMP_TextParsingUtilities s_Instance; 
	private const string k_LookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-";
	private const string k_LookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-";

	public static TMP_TextParsingUtilities instance { get; }


	private static void .cctor() { }

	public static TMP_TextParsingUtilities get_instance() { }

	public static uint GetHashCode(string s) { }

	public static int GetHashCodeCaseSensitive(string s) { }

	public static char ToLowerASCIIFast(char c) { }

	public static char ToUpperASCIIFast(char c) { }

	public static uint ToUpperASCIIFast(uint c) { }

	public static uint ToLowerASCIIFast(uint c) { }

	public static bool IsHighSurrogate(uint c) { }

	public static bool IsLowSurrogate(uint c) { }

	public void .ctor() { }

}

public static class TMP_TextUtilities // TypeDefIndex: 6846
{
	private static Vector3[] m_rectWorldCorners; 
	private const string k_lookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-";
	private const string k_lookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-";


	public static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera) { }

	public static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera, out CaretPosition cursor) { }

	public static int FindNearestLine(TMP_Text text, Vector3 position, Camera camera) { }

	public static int FindNearestCharacterOnLine(TMP_Text text, Vector3 position, int line, Camera camera, bool visibleOnly) { }

	public static bool IsIntersectingRectTransform(RectTransform rectTransform, Vector3 position, Camera camera) { }

	public static int FindIntersectingCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly) { }

	public static int FindNearestCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly) { }

	public static int FindIntersectingWord(TMP_Text text, Vector3 position, Camera camera) { }

	public static int FindNearestWord(TMP_Text text, Vector3 position, Camera camera) { }

	public static int FindIntersectingLine(TMP_Text text, Vector3 position, Camera camera) { }

	public static int FindIntersectingLink(TMP_Text text, Vector3 position, Camera camera) { }

	public static int FindNearestLink(TMP_Text text, Vector3 position, Camera camera) { }

	private static bool PointIntersectRectangle(Vector3 m, Vector3 a, Vector3 b, Vector3 c, Vector3 d) { }

	public static bool ScreenPointToWorldPointInRectangle(Transform transform, Vector2 screenPoint, Camera cam, out Vector3 worldPoint) { }

	private static bool IntersectLinePlane(TMP_TextUtilities.LineSegment line, Vector3 point, Vector3 normal, out Vector3 intersectingPoint) { }

	public static float DistanceToLine(Vector3 a, Vector3 b, Vector3 point) { }

	public static char ToLowerFast(char c) { }

	public static char ToUpperFast(char c) { }

	public static int GetSimpleHashCode(string s) { }

	public static uint GetSimpleHashCodeLowercase(string s) { }

	public static int HexToInt(char hex) { }

	public static int StringHexToInt(string s) { }

	private static void .cctor() { }

}

private struct TMP_TextUtilities.LineSegment // TypeDefIndex: 6847
{
	public Vector3 Point1; 
	public Vector3 Point2; 


	public void .ctor(Vector3 p1, Vector3 p2) { }

}

public class TMP_UpdateManager // TypeDefIndex: 6848
{
	private static TMP_UpdateManager s_Instance; 
	private readonly List<TMP_Text> m_LayoutRebuildQueue; 
	private Dictionary<int, int> m_LayoutQueueLookup; 
	private readonly List<TMP_Text> m_GraphicRebuildQueue; 
	private Dictionary<int, int> m_GraphicQueueLookup; 
	private readonly List<TMP_Text> m_InternalUpdateQueue; 
	private Dictionary<int, int> m_InternalUpdateLookup; 

	public static TMP_UpdateManager instance { get; }


	public static TMP_UpdateManager get_instance() { }

	protected void .ctor() { }

	internal static void RegisterTextObjectForUpdate(TMP_Text textObject) { }

	private void InternalRegisterTextObjectForUpdate(TMP_Text textObject) { }

	public static void RegisterTextElementForLayoutRebuild(TMP_Text element) { }

	private bool InternalRegisterTextElementForLayoutRebuild(TMP_Text element) { }

	public static void RegisterTextElementForGraphicRebuild(TMP_Text element) { }

	private bool InternalRegisterTextElementForGraphicRebuild(TMP_Text element) { }

	private void OnBeginFrameRendering(ScriptableRenderContext renderContext, Camera[] cameras) { }

	private void OnCameraPreCull(Camera cam) { }

	private void DoRebuilds() { }

	internal static void UnRegisterTextObjectForUpdate(TMP_Text textObject) { }

	public static void UnRegisterTextElementForRebuild(TMP_Text element) { }

	private void InternalUnRegisterTextElementForGraphicRebuild(TMP_Text element) { }

	private void InternalUnRegisterTextElementForLayoutRebuild(TMP_Text element) { }

	private void InternalUnRegisterTextObjectForUpdate(TMP_Text textObject) { }

}

public class TMP_UpdateRegistry // TypeDefIndex: 6849
{
	private static TMP_UpdateRegistry s_Instance; 
	private readonly List<ICanvasElement> m_LayoutRebuildQueue; 
	private Dictionary<int, int> m_LayoutQueueLookup; 
	private readonly List<ICanvasElement> m_GraphicRebuildQueue; 
	private Dictionary<int, int> m_GraphicQueueLookup; 

	public static TMP_UpdateRegistry instance { get; }


	public static TMP_UpdateRegistry get_instance() { }

	protected void .ctor() { }

	public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	private void PerformUpdateForCanvasRendererObjects() { }

	private void PerformUpdateForMeshRendererObjects() { }

	public static void UnRegisterCanvasElementForRebuild(ICanvasElement element) { }

	private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

}

public static class TMP_Math // TypeDefIndex: 6854
{
	public const float FLOAT_MAX = 32767;
	public const float FLOAT_MIN = -32767;
	public const int INT_MAX = 2147483647;
	public const int INT_MIN = -2147483647;
	public const float FLOAT_UNSET = -32767;
	public const int INT_UNSET = -32767;
	public static Vector2 MAX_16BIT; 
	public static Vector2 MIN_16BIT; 


	public static bool Approximately(float a, float b) { }

	private static void .cctor() { }

}

public enum TMP_VertexDataUpdateFlags // TypeDefIndex: 6855
{
	public int value__; 
	public const TMP_VertexDataUpdateFlags None = 0;
	public const TMP_VertexDataUpdateFlags Vertices = 1;
	public const TMP_VertexDataUpdateFlags Uv0 = 2;
	public const TMP_VertexDataUpdateFlags Uv2 = 4;
	public const TMP_VertexDataUpdateFlags Uv4 = 8;
	public const TMP_VertexDataUpdateFlags Colors32 = 16;
	public const TMP_VertexDataUpdateFlags All = 255;

}

public struct TMP_PageInfo // TypeDefIndex: 6857
{
	public int firstCharacterIndex; 
	public int lastCharacterIndex; 
	public float ascender; 
	public float baseLine; 
	public float descender; 

}

public struct TMP_LinkInfo // TypeDefIndex: 6858
{
	public TMP_Text textComponent; 
	public int hashCode; 
	public int linkIdFirstCharacterIndex; 
	public int linkIdLength; 
	public int linkTextfirstCharacterIndex; 
	public int linkTextLength; 
	internal char[] linkID; 


	internal void SetLinkID(char[] text, int startIndex, int length) { }

	public string GetLinkText() { }

	public string GetLinkID() { }

}

public struct TMP_WordInfo // TypeDefIndex: 6859
{
	public TMP_Text textComponent; 
	public int firstCharacterIndex; 
	public int lastCharacterIndex; 
	public int characterCount; 


	public string GetWord() { }

}

public struct TMP_SpriteInfo // TypeDefIndex: 6860
{
	public int spriteIndex; 
	public int characterIndex; 
	public int vertexIndex; 

}

