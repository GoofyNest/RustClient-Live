public class TMP_Asset : ScriptableObject // TypeDefIndex: 6743
{	public int hashCode; // 0x18
	public Material material; // 0x20
	public int materialHashCode; // 0x28


	public void .ctor() { }

}

public class TMP_Character : TMP_TextElement // TypeDefIndex: 6744
{
	public void .ctor() { }

	public void .ctor(uint unicode, Glyph glyph) { }

	internal void .ctor(uint unicode, uint glyphIndex) { }

}

public struct TMP_Vertex // TypeDefIndex: 6745
{	public Vector3 position; // 0x0
	public Vector2 uv; // 0xC
	public Vector2 uv2; // 0x14
	public Vector2 uv4; // 0x1C
	public Color32 color; // 0x24

}

public struct TMP_CharacterInfo // TypeDefIndex: 6746
{	public char character; // 0x0
	public int index; // 0x4
	public int stringLength; // 0x8
	public TMP_TextElementType elementType; // 0xC
	public TMP_TextElement textElement; // 0x10
	public TMP_FontAsset fontAsset; // 0x18
	public Material material; // 0x20
	public int materialReferenceIndex; // 0x28
	public bool isUsingAlternateTypeface; // 0x2C
	public float pointSize; // 0x30
	public int lineNumber; // 0x34
	public int pageNumber; // 0x38
	public int vertexIndex; // 0x3C
	public TMP_Vertex vertex_BL; // 0x40
	public TMP_Vertex vertex_TL; // 0x68
	public TMP_Vertex vertex_TR; // 0x90
	public TMP_Vertex vertex_BR; // 0xB8
	public Vector3 topLeft; // 0xE0
	public Vector3 bottomLeft; // 0xEC
	public Vector3 topRight; // 0xF8
	public Vector3 bottomRight; // 0x104
	public float origin; // 0x110
	public float ascender; // 0x114
	public float baseLine; // 0x118
	public float descender; // 0x11C
	public float xAdvance; // 0x120
	public float aspectRatio; // 0x124
	public float scale; // 0x128
	public Color32 color; // 0x12C
	public Color32 underlineColor; // 0x130
	public Color32 strikethroughColor; // 0x134
	public Color32 highlightColor; // 0x138
	public FontStyles style; // 0x13C
	public bool isVisible; // 0x140

}

public class TMP_ColorGradient : ScriptableObject // TypeDefIndex: 6748
{	public ColorMode colorMode; // 0x18
	public Color topLeft; // 0x1C
	public Color topRight; // 0x2C
	public Color bottomLeft; // 0x3C
	public Color bottomRight; // 0x4C
	private const ColorMode k_DefaultColorMode = 3;
	private static readonly Color k_DefaultColor; // 0x0


	public void .ctor() { }

	public void .ctor(Color color) { }

	public void .ctor(Color color0, Color color1, Color color2, Color color3) { }

	private static void .cctor() { }

}

public static class TMP_DefaultControls // TypeDefIndex: 6757
{	private const float kWidth = 160;
	private const float kThickHeight = 30;
	private const float kThinHeight = 20;
	private static Vector2 s_ThickElementSize; // 0x0
	private static Vector2 s_ThinElementSize; // 0x8
	private static Color s_DefaultSelectableColor; // 0x10
	private static Color s_TextColor; // 0x20


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
{	public Sprite standard; // 0x0
	public Sprite background; // 0x8
	public Sprite inputField; // 0x10
	public Sprite knob; // 0x18
	public Sprite checkmark; // 0x20
	public Sprite dropdown; // 0x28
	public Sprite mask; // 0x30

}

public class TMP_FontAsset : TMP_Asset // TypeDefIndex: 6760
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string m_Version; // 0x30
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal string m_SourceFontFileGUID; // 0x38
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Font m_SourceFontFile; // 0x40
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private AtlasPopulationMode m_AtlasPopulationMode; // 0x48
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private FaceInfo m_FaceInfo; // 0x50
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private List<Glyph> m_GlyphTable; // 0xA8
	private Dictionary<uint, Glyph> m_GlyphLookupDictionary; // 0xB0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private List<TMP_Character> m_CharacterTable; // 0xB8
	private Dictionary<uint, TMP_Character> m_CharacterLookupDictionary; // 0xC0
	private Texture2D m_AtlasTexture; // 0xC8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Texture2D[] m_AtlasTextures; // 0xD0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal int m_AtlasTextureIndex; // 0xD8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private List<GlyphRect> m_UsedGlyphRects; // 0xE0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private List<GlyphRect> m_FreeGlyphRects; // 0xE8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private FaceInfo_Legacy m_fontInfo; // 0xF0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Texture2D atlas; // 0xF8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int m_AtlasWidth; // 0x100
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int m_AtlasHeight; // 0x104
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int m_AtlasPadding; // 0x108
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GlyphRenderMode m_AtlasRenderMode; // 0x10C
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal List<TMP_Glyph> m_glyphInfoList; // 0x110
	[SerializeField] // RVA: 0xCB580 Offset: 0xCA980 VA: 0x1800CB580
	[FormerlySerializedAsAttribute] // RVA: 0xCB580 Offset: 0xCA980 VA: 0x1800CB580
	internal KerningTable m_KerningTable; // 0x118
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TMP_FontFeatureTable m_FontFeatureTable; // 0x120
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private List<TMP_FontAsset> fallbackFontAssets; // 0x128
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public List<TMP_FontAsset> m_FallbackFontAssetTable; // 0x130
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal FontAssetCreationSettings m_CreationSettings; // 0x138
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TMP_FontWeightPair[] m_FontWeightTable; // 0x190
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TMP_FontWeightPair[] fontWeights; // 0x198
	public float normalStyle; // 0x1A0
	public float normalSpacingOffset; // 0x1A4
	public float boldStyle; // 0x1A8
	public float boldSpacing; // 0x1AC
	public byte italicStyle; // 0x1B0
	public byte tabSize; // 0x1B1
	private byte m_oldTabSize; // 0x1B2
	internal bool m_IsFontAssetLookupTablesDirty; // 0x1B3
	private List<Glyph> m_GlyphsToPack; // 0x1B8
	private List<Glyph> m_GlyphsPacked; // 0x1C0
	private List<Glyph> m_GlyphsToRender; // 0x1C8
	private List<uint> m_GlyphIndexList; // 0x1D0
	private List<TMP_Character> m_CharactersToAdd; // 0x1D8
	internal static uint[] s_GlyphIndexArray; // 0x0
	internal static List<uint> s_MissingCharacterList; // 0x8

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
	[ObsoleteAttribute] // RVA: 0xCBF80 Offset: 0xCB380 VA: 0x1800CBF80
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
{	public static readonly TMP_FontAsset.<>c <>9; // 0x0
	public static Func<TMP_Character, uint> <>9__100_0; // 0x8
	public static Func<Glyph, uint> <>9__101_0; // 0x10


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
{	public TMP_FontAsset regularTypeface; // 0x0
	public TMP_FontAsset italicTypeface; // 0x8

}

public static class TMP_FontUtilities // TypeDefIndex: 6774
{	private static List<int> k_searchedFontAssets; // 0x2B0AACC


	public static TMP_FontAsset SearchForCharacter(TMP_FontAsset font, uint unicode, out TMP_Character character) { }

	public static TMP_FontAsset SearchForCharacter(List<TMP_FontAsset> fonts, uint unicode, out TMP_Character character) { }

	private static TMP_FontAsset SearchForCharacterInternal(TMP_FontAsset font, uint unicode, out TMP_Character character) { }

	private static TMP_FontAsset SearchForCharacterInternal(List<TMP_FontAsset> fonts, uint unicode, out TMP_Character character) { }

}

public class TMP_FontAssetUtilities // TypeDefIndex: 6775
{	private static readonly TMP_FontAssetUtilities s_Instance; // 0x0
	private static List<int> k_SearchedFontAssets; // 0x8
	private static bool k_IsFontEngineInitialized; // 0x10

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
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal List<TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords; // 0x10
	internal Dictionary<long, TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookupDictionary; // 0x18

	internal List<TMP_GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords { get; set; }


	internal List<TMP_GlyphPairAdjustmentRecord> get_glyphPairAdjustmentRecords() { }

	internal void set_glyphPairAdjustmentRecords(List<TMP_GlyphPairAdjustmentRecord> value) { }

	public void .ctor() { }

	public void SortGlyphPairAdjustmentRecords() { }

}

private sealed class TMP_FontFeatureTable.<>c // TypeDefIndex: 6777
{	public static readonly TMP_FontFeatureTable.<>c <>9; // 0x0
	public static Func<TMP_GlyphPairAdjustmentRecord, uint> <>9__6_0; // 0x8
	public static Func<TMP_GlyphPairAdjustmentRecord, uint> <>9__6_1; // 0x10


	private static void .cctor() { }

	public void .ctor() { }

	internal uint <SortGlyphPairAdjustmentRecords>b__6_0(TMP_GlyphPairAdjustmentRecord s) { }

	internal uint <SortGlyphPairAdjustmentRecords>b__6_1(TMP_GlyphPairAdjustmentRecord s) { }

}

public struct TMP_GlyphValueRecord // TypeDefIndex: 6779
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_XPlacement; // 0x0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_YPlacement; // 0x4
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_XAdvance; // 0x8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_YAdvance; // 0xC

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
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private uint m_GlyphIndex; // 0x0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TMP_GlyphValueRecord m_GlyphValueRecord; // 0x4

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
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TMP_GlyphAdjustmentRecord m_FirstAdjustmentRecord; // 0x10
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TMP_GlyphAdjustmentRecord m_SecondAdjustmentRecord; // 0x24
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private FontFeatureLookupFlags m_FeatureLookupFlags; // 0x38

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
{	protected TouchScreenKeyboard m_SoftKeyboard; // 0xE8
	private static readonly char[] kSeparators; // 0x0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected RectTransform m_TextViewport; // 0xF0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected TMP_Text m_TextComponent; // 0xF8
	protected RectTransform m_TextComponentRectTransform; // 0x100
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected Graphic m_Placeholder; // 0x108
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected Scrollbar m_VerticalScrollbar; // 0x110
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected TMP_ScrollbarEventHandler m_VerticalScrollbarEventHandler; // 0x118
	private bool m_IsDrivenByLayoutComponents; // 0x120
	private float m_ScrollPosition; // 0x124
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected float m_ScrollSensitivity; // 0x128
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TMP_InputField.ContentType m_ContentType; // 0x12C
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TMP_InputField.InputType m_InputType; // 0x130
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private char m_AsteriskChar; // 0x134
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TouchScreenKeyboardType m_KeyboardType; // 0x138
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TMP_InputField.LineType m_LineType; // 0x13C
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_HideMobileInput; // 0x140
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_HideSoftKeyboard; // 0x141
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TMP_InputField.CharacterValidation m_CharacterValidation; // 0x144
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string m_RegexValue; // 0x148
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_GlobalPointSize; // 0x150
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int m_CharacterLimit; // 0x154
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TMP_InputField.SubmitEvent m_OnEndEdit; // 0x158
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TMP_InputField.SubmitEvent m_OnSubmit; // 0x160
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TMP_InputField.SelectionEvent m_OnSelect; // 0x168
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TMP_InputField.SelectionEvent m_OnDeselect; // 0x170
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TMP_InputField.TextSelectionEvent m_OnTextSelection; // 0x178
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TMP_InputField.TextSelectionEvent m_OnEndTextSelection; // 0x180
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TMP_InputField.OnChangeEvent m_OnValueChanged; // 0x188
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TMP_InputField.TouchScreenKeyboardEvent m_OnTouchScreenKeyboardStatusChanged; // 0x190
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TMP_InputField.OnValidateInput m_OnValidateInput; // 0x198
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color m_CaretColor; // 0x1A0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_CustomCaretColor; // 0x1B0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color m_SelectionColor; // 0x1B4
	[SerializeField] // RVA: 0xD0640 Offset: 0xCFA40 VA: 0x1800D0640
	[TextAreaAttribute] // RVA: 0xD0640 Offset: 0xCFA40 VA: 0x1800D0640
	protected string m_Text; // 0x1C8
	[SerializeField] // RVA: 0xD0710 Offset: 0xCFB10 VA: 0x1800D0710
	[RangeAttribute] // RVA: 0xD0710 Offset: 0xCFB10 VA: 0x1800D0710
	private float m_CaretBlinkRate; // 0x1D0
	[SerializeField] // RVA: 0xD0830 Offset: 0xCFC30 VA: 0x1800D0830
	[RangeAttribute] // RVA: 0xD0830 Offset: 0xCFC30 VA: 0x1800D0830
	private int m_CaretWidth; // 0x1D4
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_ReadOnly; // 0x1D8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_RichText; // 0x1D9
	protected int m_StringPosition; // 0x1DC
	protected int m_StringSelectPosition; // 0x1E0
	protected int m_CaretPosition; // 0x1E4
	protected int m_CaretSelectPosition; // 0x1E8
	private RectTransform caretRectTrans; // 0x1F0
	protected UIVertex[] m_CursorVerts; // 0x1F8
	private CanvasRenderer m_CachedInputRenderer; // 0x200
	private Vector2 m_LastPosition; // 0x208
	protected Mesh m_Mesh; // 0x210
	private bool m_AllowInput; // 0x218
	private bool m_ShouldActivateNextUpdate; // 0x219
	private bool m_UpdateDrag; // 0x21A
	private bool m_DragPositionOutOfBounds; // 0x21B
	private const float kHScrollSpeed = 0,05;
	private const float kVScrollSpeed = 0,1;
	protected bool m_CaretVisible; // 0x21C
	private Coroutine m_BlinkCoroutine; // 0x220
	private float m_BlinkStartTime; // 0x228
	private Coroutine m_DragCoroutine; // 0x230
	private string m_OriginalText; // 0x238
	private bool m_WasCanceled; // 0x240
	private bool m_HasDoneFocusTransition; // 0x241
	private WaitForSecondsRealtime m_WaitForSecondsRealtime; // 0x248
	private bool m_PreventCallback; // 0x250
	private bool m_TouchKeyboardAllowsInPlaceEditing; // 0x251
	private bool m_IsTextComponentUpdateRequired; // 0x252
	private bool m_IsScrollbarUpdateRequired; // 0x253
	private bool m_IsUpdatingScrollbarValues; // 0x254
	private bool m_isLastKeyBackspace; // 0x255
	private float m_PointerDownClickStartTime; // 0x258
	private float m_KeyDownStartTime; // 0x25C
	private float m_DoubleClickDelay; // 0x260
	private const string kEmailSpecialCharacters = "!#$%&\'*+-/=?^_`{|}~";
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected TMP_FontAsset m_GlobalFontAsset; // 0x268
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected bool m_OnFocusSelectAll; // 0x270
	protected bool m_isSelectAll; // 0x271
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected bool m_ResetOnDeActivation; // 0x272
	private bool m_SelectionStillActive; // 0x273
	private bool m_ReleaseSelection; // 0x274
	private GameObject m_SelectedObject; // 0x278
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_RestoreOriginalTextOnEscape; // 0x280
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected bool m_isRichTextEditingAllowed; // 0x281
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected int m_LineLimit; // 0x284
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected TMP_InputValidator m_InputValidator; // 0x288
	private bool m_isSelected; // 0x290
	private bool m_IsStringPositionDirty; // 0x291
	private bool m_IsCaretPositionDirty; // 0x292
	private bool m_forceRectTransformAdjustment; // 0x293
	private Event m_ProcessingEvent; // 0x298

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

	[IteratorStateMachineAttribute] // RVA: 0xD1020 Offset: 0xD0420 VA: 0x1800D1020
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

	[IteratorStateMachineAttribute] // RVA: 0xD1160 Offset: 0xD0560 VA: 0x1800D1160
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
{	public int value__; // 0x0
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
{	public int value__; // 0x0
	public const TMP_InputField.InputType Standard = 0;
	public const TMP_InputField.InputType AutoCorrect = 1;
	public const TMP_InputField.InputType Password = 2;

}

public enum TMP_InputField.CharacterValidation // TypeDefIndex: 6786
{	public int value__; // 0x0
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
{	public int value__; // 0x0
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
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public TMP_InputField <>4__this; // 0x20

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class TMP_InputField.<MouseDragOutsideRect>d__285 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 6796
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public TMP_InputField <>4__this; // 0x20
	public PointerEventData eventData; // 0x28

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

}

public abstract class TMP_InputValidator : ScriptableObject // TypeDefIndex: 6798
{
	public abstract char Validate(ref string text, ref int pos, char ch);

	protected void .ctor() { }

}

public struct TMP_LineInfo // TypeDefIndex: 6799
{	internal int controlCharacterCount; // 0x0
	public int characterCount; // 0x4
	public int visibleCharacterCount; // 0x8
	public int spaceCount; // 0xC
	public int wordCount; // 0x10
	public int firstCharacterIndex; // 0x14
	public int firstVisibleCharacterIndex; // 0x18
	public int lastCharacterIndex; // 0x1C
	public int lastVisibleCharacterIndex; // 0x20
	public float length; // 0x24
	public float lineHeight; // 0x28
	public float ascender; // 0x2C
	public float baseline; // 0x30
	public float descender; // 0x34
	public float maxAdvance; // 0x38
	public float width; // 0x3C
	public float marginLeft; // 0x40
	public float marginRight; // 0x44
	public TextAlignmentOptions alignment; // 0x48
	public Extents lineExtents; // 0x4C

}

internal static class TMP_ListPool<T> // TypeDefIndex: 6800
{	private static readonly TMP_ObjectPool<List<T>> s_ListPool; // 0x0


	public static List<T> Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17A8880 Offset: 0x17A7C80 VA: 0x1817A8880
	|-TMP_ListPool<object>.Get
	|-TMP_ListPool<Canvas>.Get
	|-TMP_ListPool<IMaterialModifier>.Get
	|-TMP_ListPool<Mask>.Get
	*/

	public static void Release(List<T> toRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17A89F0 Offset: 0x17A7DF0 VA: 0x1817A89F0
	|-TMP_ListPool<object>.Release
	|-TMP_ListPool<Canvas>.Release
	|-TMP_ListPool<IMaterialModifier>.Release
	|-TMP_ListPool<Mask>.Release
	*/

	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17A8B70 Offset: 0x17A7F70 VA: 0x1817A8B70
	|-TMP_ListPool<object>..cctor
	*/

}

private sealed class TMP_ListPool.<>c<T> // TypeDefIndex: 6801
{	public static readonly TMP_ListPool.<>c<T> <>9; // 0x0


	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD602E0 Offset: 0xD5F6E0 VA: 0x180D602E0
	|-TMP_ListPool.<>c<object>..cctor
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55DC0 Offset: 0xD551C0 VA: 0x180D55DC0
	|-TMP_ListPool.<>c<object>..ctor
	*/

	internal void <.cctor>b__3_0(List<T> l) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E3C40 Offset: 0x15E3040 VA: 0x1815E3C40
	|-TMP_ListPool.<>c<object>.<.cctor>b__3_0
	*/

}

public static class TMP_MaterialManager // TypeDefIndex: 6802
{	private static List<TMP_MaterialManager.MaskingMaterial> m_materialList; // 0x0
	private static Dictionary<long, TMP_MaterialManager.FallbackMaterial> m_fallbackMaterials; // 0x8
	private static Dictionary<int, long> m_fallbackMaterialLookup; // 0x10
	private static List<TMP_MaterialManager.FallbackMaterial> m_fallbackCleanupList; // 0x18
	private static bool isFallbackListDirty; // 0x20


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
{	public int baseID; // 0x10
	public Material baseMaterial; // 0x18
	public long fallbackID; // 0x20
	public Material fallbackMaterial; // 0x28
	public int count; // 0x30


	public void .ctor() { }

}

private class TMP_MaterialManager.MaskingMaterial // TypeDefIndex: 6804
{	public Material baseMaterial; // 0x10
	public Material stencilMaterial; // 0x18
	public int count; // 0x20
	public int stencilID; // 0x24


	public void .ctor() { }

}

private sealed class TMP_MaterialManager.<>c__DisplayClass10_0 // TypeDefIndex: 6805
{	public Material stencilMaterial; // 0x10


	public void .ctor() { }

	internal bool <GetBaseMaterial>b__0(TMP_MaterialManager.MaskingMaterial item) { }

}

private sealed class TMP_MaterialManager.<>c__DisplayClass12_0 // TypeDefIndex: 6806
{	public Material stencilMaterial; // 0x10


	public void .ctor() { }

	internal bool <AddMaskingMaterial>b__0(TMP_MaterialManager.MaskingMaterial item) { }

}

private sealed class TMP_MaterialManager.<>c__DisplayClass13_0 // TypeDefIndex: 6807
{	public Material stencilMaterial; // 0x10


	public void .ctor() { }

	internal bool <RemoveStencilMaterial>b__0(TMP_MaterialManager.MaskingMaterial item) { }

}

private sealed class TMP_MaterialManager.<>c__DisplayClass14_0 // TypeDefIndex: 6808
{	public Material baseMaterial; // 0x10


	public void .ctor() { }

	internal bool <ReleaseBaseMaterial>b__0(TMP_MaterialManager.MaskingMaterial item) { }

}

public struct TMP_MeshInfo // TypeDefIndex: 6810
{	private static readonly Color32 s_DefaultColor; // 0x0
	private static readonly Vector3 s_DefaultNormal; // 0x4
	private static readonly Vector4 s_DefaultTangent; // 0x10
	private static readonly Bounds s_DefaultBounds; // 0x20
	public Mesh mesh; // 0x0
	public int vertexCount; // 0x8
	public Vector3[] vertices; // 0x10
	public Vector3[] normals; // 0x18
	public Vector4[] tangents; // 0x20
	public Vector2[] uvs0; // 0x28
	public Vector2[] uvs2; // 0x30
	public Color32[] colors32; // 0x38
	public int[] triangles; // 0x40


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
{	private readonly Stack<T> m_Stack; // 0x0
	private readonly UnityAction<T> m_ActionOnGet; // 0x0
	private readonly UnityAction<T> m_ActionOnRelease; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <countAll>k__BackingField; // 0x0

	public int countAll { get; set; }
	public int countActive { get; }
	public int countInactive { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int get_countAll() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4BB390 Offset: 0x4BA790 VA: 0x1804BB390
	|-TMP_ObjectPool<object>.get_countAll
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_countAll(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7E8DF0 Offset: 0x7E81F0 VA: 0x1807E8DF0
	|-TMP_ObjectPool<object>.set_countAll
	*/

	public int get_countActive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17A90C0 Offset: 0x17A84C0 VA: 0x1817A90C0
	|-TMP_ObjectPool<object>.get_countActive
	*/

	public int get_countInactive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE02AD0 Offset: 0xE01ED0 VA: 0x180E02AD0
	|-TMP_ObjectPool<object>.get_countInactive
	*/

	public void .ctor(UnityAction<T> actionOnGet, UnityAction<T> actionOnRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17A9000 Offset: 0x17A8400 VA: 0x1817A9000
	|-TMP_ObjectPool<object>..ctor
	*/

	public T Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17A8E10 Offset: 0x17A8210 VA: 0x1817A8E10
	|-TMP_ObjectPool<object>.Get
	*/

	public void Release(T element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17A8F00 Offset: 0x17A8300 VA: 0x1817A8F00
	|-TMP_ObjectPool<object>.Release
	*/

}

public struct TMP_FontStyleStack // TypeDefIndex: 6812
{	public byte bold; // 0x0
	public byte italic; // 0x1
	public byte underline; // 0x2
	public byte strikethrough; // 0x3
	public byte highlight; // 0x4
	public byte superscript; // 0x5
	public byte subscript; // 0x6
	public byte uppercase; // 0x7
	public byte lowercase; // 0x8
	public byte smallcaps; // 0x9


	public void Clear() { }

	public byte Add(FontStyles style) { }

	public byte Remove(FontStyles style) { }

}

public struct TMP_RichTextTagStack<T> // TypeDefIndex: 6813
{	public T[] m_ItemStack; // 0x0
	public int m_Index; // 0x0
	private int m_Capacity; // 0x0
	private T m_DefaultItem; // 0x0
	private const int k_DefaultCapacity = 4;


	public void .ctor(T[] tagStack) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x210310 Offset: 0x20F710 VA: 0x180210310
	|-TMP_RichTextTagStack<int>..ctor
	|-TMP_RichTextTagStack<Int32Enum>..ctor
	|-TMP_RichTextTagStack<float>..ctor
	|-TMP_RichTextTagStack<TextAlignmentOptions>..ctor
	|-TMP_RichTextTagStack<Color32>..ctor
	|
	|-RVA: 0x210460 Offset: 0x20F860 VA: 0x180210460
	|-TMP_RichTextTagStack<object>..ctor
	|-TMP_RichTextTagStack<TMP_ColorGradient>..ctor
	|
	|-RVA: 0x210540 Offset: 0x20F940 VA: 0x180210540
	|-TMP_RichTextTagStack<MaterialReference>..ctor
	*/

	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x210360 Offset: 0x20F760 VA: 0x180210360
	|-TMP_RichTextTagStack<int>..ctor
	|-TMP_RichTextTagStack<Int32Enum>..ctor
	|-TMP_RichTextTagStack<float>..ctor
	|-TMP_RichTextTagStack<FontWeight>..ctor
	|-TMP_RichTextTagStack<Color32>..ctor
	|
	|-RVA: 0x2103E0 Offset: 0x20F7E0 VA: 0x1802103E0
	|-TMP_RichTextTagStack<object>..ctor
	|
	|-RVA: 0x2104B0 Offset: 0x20F8B0 VA: 0x1802104B0
	|-TMP_RichTextTagStack<MaterialReference>..ctor
	*/

	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20F3B0 Offset: 0x20E7B0 VA: 0x18020F3B0
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
	|-RVA: 0x2101E0 Offset: 0x20F5E0 VA: 0x1802101E0
	|-TMP_RichTextTagStack<int>.SetDefault
	|-TMP_RichTextTagStack<Int32Enum>.SetDefault
	|-TMP_RichTextTagStack<FontWeight>.SetDefault
	|-TMP_RichTextTagStack<TextAlignmentOptions>.SetDefault
	|-TMP_RichTextTagStack<Color32>.SetDefault
	|
	|-RVA: 0x210220 Offset: 0x20F620 VA: 0x180210220
	|-TMP_RichTextTagStack<object>.SetDefault
	|-TMP_RichTextTagStack<TMP_ColorGradient>.SetDefault
	|
	|-RVA: 0x2102D0 Offset: 0x20F6D0 VA: 0x1802102D0
	|-TMP_RichTextTagStack<float>.SetDefault
	|
	|-RVA: 0x210270 Offset: 0x20F670 VA: 0x180210270
	|-TMP_RichTextTagStack<MaterialReference>.SetDefault
	*/

	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20F270 Offset: 0x20E670 VA: 0x18020F270
	|-TMP_RichTextTagStack<int>.Add
	|-TMP_RichTextTagStack<Int32Enum>.Add
	|-TMP_RichTextTagStack<FontWeight>.Add
	|-TMP_RichTextTagStack<TextAlignmentOptions>.Add
	|-TMP_RichTextTagStack<Color32>.Add
	|
	|-RVA: 0x20F2B0 Offset: 0x20E6B0 VA: 0x18020F2B0
	|-TMP_RichTextTagStack<object>.Add
	|-TMP_RichTextTagStack<TMP_ColorGradient>.Add
	|
	|-RVA: 0x20F300 Offset: 0x20E700 VA: 0x18020F300
	|-TMP_RichTextTagStack<float>.Add
	|
	|-RVA: 0x20F340 Offset: 0x20E740 VA: 0x18020F340
	|-TMP_RichTextTagStack<MaterialReference>.Add
	*/

	public T Remove() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x210100 Offset: 0x20F500 VA: 0x180210100
	|-TMP_RichTextTagStack<int>.Remove
	|-TMP_RichTextTagStack<Int32Enum>.Remove
	|-TMP_RichTextTagStack<FontWeight>.Remove
	|-TMP_RichTextTagStack<TextAlignmentOptions>.Remove
	|-TMP_RichTextTagStack<Color32>.Remove
	|
	|-RVA: 0x210170 Offset: 0x20F570 VA: 0x180210170
	|-TMP_RichTextTagStack<object>.Remove
	|-TMP_RichTextTagStack<TMP_ColorGradient>.Remove
	|
	|-RVA: 0x20FFD0 Offset: 0x20F3D0 VA: 0x18020FFD0
	|-TMP_RichTextTagStack<float>.Remove
	|
	|-RVA: 0x210050 Offset: 0x20F450 VA: 0x180210050
	|-TMP_RichTextTagStack<MaterialReference>.Remove
	*/

	public void Push(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20FB20 Offset: 0x20EF20 VA: 0x18020FB20
	|-TMP_RichTextTagStack<int>.Push
	|-TMP_RichTextTagStack<Int32Enum>.Push
	|
	|-RVA: 0x20FDF0 Offset: 0x20F1F0 VA: 0x18020FDF0
	|-TMP_RichTextTagStack<object>.Push
	|
	|-RVA: 0x20FEE0 Offset: 0x20F2E0 VA: 0x18020FEE0
	|-TMP_RichTextTagStack<float>.Push
	|
	|-RVA: 0x20FC00 Offset: 0x20F000 VA: 0x18020FC00
	|-TMP_RichTextTagStack<MaterialReference>.Push
	|
	|-RVA: 0x20FD10 Offset: 0x20F110 VA: 0x18020FD10
	|-TMP_RichTextTagStack<Color32>.Push
	*/

	public T Pop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20F800 Offset: 0x20EC00 VA: 0x18020F800
	|-TMP_RichTextTagStack<int>.Pop
	|-TMP_RichTextTagStack<Int32Enum>.Pop
	|-TMP_RichTextTagStack<Color32>.Pop
	|
	|-RVA: 0x20F860 Offset: 0x20EC60 VA: 0x18020F860
	|-TMP_RichTextTagStack<object>.Pop
	|
	|-RVA: 0x20F8D0 Offset: 0x20ECD0 VA: 0x18020F8D0
	|-TMP_RichTextTagStack<float>.Pop
	|
	|-RVA: 0x20F710 Offset: 0x20EB10 VA: 0x18020F710
	|-TMP_RichTextTagStack<MaterialReference>.Pop
	*/

	public T Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20F5A0 Offset: 0x20E9A0 VA: 0x18020F5A0
	|-TMP_RichTextTagStack<int>.Peek
	|-TMP_RichTextTagStack<Int32Enum>.Peek
	|-TMP_RichTextTagStack<FontWeight>.Peek
	|-TMP_RichTextTagStack<Color32>.Peek
	|
	|-RVA: 0x20F670 Offset: 0x20EA70 VA: 0x18020F670
	|-TMP_RichTextTagStack<object>.Peek
	|
	|-RVA: 0x20F6C0 Offset: 0x20EAC0 VA: 0x18020F6C0
	|-TMP_RichTextTagStack<float>.Peek
	|
	|-RVA: 0x20F5F0 Offset: 0x20E9F0 VA: 0x18020F5F0
	|-TMP_RichTextTagStack<MaterialReference>.Peek
	*/

	public T CurrentItem() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20F3C0 Offset: 0x20E7C0 VA: 0x18020F3C0
	|-TMP_RichTextTagStack<int>.CurrentItem
	|-TMP_RichTextTagStack<Int32Enum>.CurrentItem
	|-TMP_RichTextTagStack<Color32>.CurrentItem
	|
	|-RVA: 0x20F530 Offset: 0x20E930 VA: 0x18020F530
	|-TMP_RichTextTagStack<object>.CurrentItem
	|
	|-RVA: 0x20F4C0 Offset: 0x20E8C0 VA: 0x18020F4C0
	|-TMP_RichTextTagStack<float>.CurrentItem
	|
	|-RVA: 0x20F420 Offset: 0x20E820 VA: 0x18020F420
	|-TMP_RichTextTagStack<MaterialReference>.CurrentItem
	*/

	public T PreviousItem() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20F930 Offset: 0x20ED30 VA: 0x18020F930
	|-TMP_RichTextTagStack<int>.PreviousItem
	|-TMP_RichTextTagStack<Int32Enum>.PreviousItem
	|-TMP_RichTextTagStack<Color32>.PreviousItem
	|
	|-RVA: 0x20F9A0 Offset: 0x20EDA0 VA: 0x18020F9A0
	|-TMP_RichTextTagStack<object>.PreviousItem
	|
	|-RVA: 0x20FAB0 Offset: 0x20EEB0 VA: 0x18020FAB0
	|-TMP_RichTextTagStack<float>.PreviousItem
	|
	|-RVA: 0x20FA10 Offset: 0x20EE10 VA: 0x18020FA10
	|-TMP_RichTextTagStack<MaterialReference>.PreviousItem
	*/

}

public class TMP_ScrollbarEventHandler : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, ISelectHandler, IDeselectHandler // TypeDefIndex: 6818
{	public bool isSelected; // 0x18


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
{	private static TMP_Settings s_Instance; // 0x0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_enableWordWrapping; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_enableKerning; // 0x19
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_enableExtraPadding; // 0x1A
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_enableTintAllSprites; // 0x1B
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_EnableRaycastTarget; // 0x1C
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_GetFontFeaturesAtRuntime; // 0x1D
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int m_missingGlyphCharacter; // 0x20
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_warningsDisabled; // 0x24
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TMP_FontAsset m_defaultFontAsset; // 0x28
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string m_defaultFontAssetPath; // 0x30
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_defaultFontSize; // 0x38
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_defaultAutoSizeMinRatio; // 0x3C
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_defaultAutoSizeMaxRatio; // 0x40
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector2 m_defaultTextMeshProTextContainerSize; // 0x44
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector2 m_defaultTextMeshProUITextContainerSize; // 0x4C
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_autoSizeTextContainer; // 0x54
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private List<TMP_FontAsset> m_fallbackFontAssets; // 0x58
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_matchMaterialPreset; // 0x60
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string m_defaultColorGradientPresetsPath; // 0x68
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_enableEmojiSupport; // 0x70
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TextAsset m_leadingCharacters; // 0x78
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TextAsset m_followingCharacters; // 0x80
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TMP_Settings.LineBreakingTable m_linebreakingRules; // 0x88

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
{	public Dictionary<int, char> leadingCharacters; // 0x10
	public Dictionary<int, char> followingCharacters; // 0x18


	public void .ctor() { }

}

public class TMP_SubMesh : MonoBehaviour // TypeDefIndex: 6823
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TMP_FontAsset m_fontAsset; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Material m_material; // 0x20
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Material m_sharedMaterial; // 0x28
	private Material m_fallbackMaterial; // 0x30
	private Material m_fallbackSourceMaterial; // 0x38
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_isDefaultMaterial; // 0x40
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_padding; // 0x44
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Renderer m_renderer; // 0x48
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private MeshFilter m_meshFilter; // 0x50
	private Mesh m_mesh; // 0x58
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TextMeshPro m_TextComponent; // 0x60
	private bool m_isRegisteredForEvents; // 0x68

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
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TMP_FontAsset m_fontAsset; // 0xC8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Material m_material; // 0xD0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Material m_sharedMaterial; // 0xD8
	private Material m_fallbackMaterial; // 0xE0
	private Material m_fallbackSourceMaterial; // 0xE8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_isDefaultMaterial; // 0xF0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_padding; // 0xF4
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private CanvasRenderer m_canvasRenderer; // 0xF8
	private Mesh m_mesh; // 0x100
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TextMeshProUGUI m_TextComponent; // 0x108
	private bool m_isRegisteredForEvents; // 0x110
	private bool m_materialDirty; // 0x111
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int m_materialReferenceIndex; // 0x114

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
{	public int value__; // 0x0
	public const TMP_TextElementType Character = 0;
	public const TMP_TextElementType Unused = 1;

}

public abstract class TMP_Text : MaskableGraphic // TypeDefIndex: 6837
{	[SerializeField] // RVA: 0xD0640 Offset: 0xCFA40 VA: 0x1800D0640
	[TextAreaAttribute] // RVA: 0xD0640 Offset: 0xCFA40 VA: 0x1800D0640
	protected string m_text; // 0xC8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected bool m_isRightToLeft; // 0xD0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected TMP_FontAsset m_fontAsset; // 0xD8
	protected TMP_FontAsset m_currentFontAsset; // 0xE0
	protected bool m_isSDFShader; // 0xE8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected Material m_sharedMaterial; // 0xF0
	protected Material m_currentMaterial; // 0xF8
	protected MaterialReference[] m_materialReferences; // 0x100
	protected Dictionary<int, int> m_materialReferenceIndexLookup; // 0x108
	protected TMP_RichTextTagStack<MaterialReference> m_materialReferenceStack; // 0x110
	protected int m_currentMaterialIndex; // 0x150
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected Material[] m_fontSharedMaterials; // 0x158
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected Material m_fontMaterial; // 0x160
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected Material[] m_fontMaterials; // 0x168
	protected bool m_isMaterialDirty; // 0x170
	[SerializeField] // RVA: 0xD6F10 Offset: 0xD6310 VA: 0x1800D6F10
	[ColorUsageAttribute] // RVA: 0xD6F10 Offset: 0xD6310 VA: 0x1800D6F10
	protected Color32 m_fontColor32; // 0x174
	[SerializeField] // RVA: 0xD6F10 Offset: 0xD6310 VA: 0x1800D6F10
	[ColorUsageAttribute] // RVA: 0xD6F10 Offset: 0xD6310 VA: 0x1800D6F10
	protected Color m_fontColor; // 0x178
	protected static Color32 s_colorWhite; // 0x0
	protected Color32 m_underlineColor; // 0x188
	protected Color32 m_strikethroughColor; // 0x18C
	protected Color32 m_highlightColor; // 0x190
	protected Vector4 m_highlightPadding; // 0x194
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected bool m_enableVertexGradient; // 0x1A4
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected ColorMode m_colorMode; // 0x1A8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected VertexGradient m_fontColorGradient; // 0x1AC
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected TMP_ColorGradient m_fontColorGradientPreset; // 0x1F0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected bool m_overrideHtmlColors; // 0x1F8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected Color32 m_faceColor; // 0x1FC
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected Color32 m_outlineColor; // 0x200
	protected float m_outlineWidth; // 0x204
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected float m_fontSize; // 0x208
	protected float m_currentFontSize; // 0x20C
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected float m_fontSizeBase; // 0x210
	protected TMP_RichTextTagStack<float> m_sizeStack; // 0x218
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected FontWeight m_fontWeight; // 0x230
	protected FontWeight m_FontWeightInternal; // 0x234
	protected TMP_RichTextTagStack<FontWeight> m_FontWeightStack; // 0x238
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected bool m_enableAutoSizing; // 0x250
	protected float m_maxFontSize; // 0x254
	protected float m_minFontSize; // 0x258
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected float m_fontSizeMin; // 0x25C
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected float m_fontSizeMax; // 0x260
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected FontStyles m_fontStyle; // 0x264
	protected FontStyles m_FontStyleInternal; // 0x268
	protected TMP_FontStyleStack m_fontStyleStack; // 0x26C
	protected bool m_isUsingBold; // 0x276
	[SerializeField] // RVA: 0xD8C30 Offset: 0xD8030 VA: 0x1800D8C30
	[FormerlySerializedAsAttribute] // RVA: 0xD8C30 Offset: 0xD8030 VA: 0x1800D8C30
	protected TextAlignmentOptions m_textAlignment; // 0x278
	protected TextAlignmentOptions m_lineJustification; // 0x27C
	protected TMP_RichTextTagStack<TextAlignmentOptions> m_lineJustificationStack; // 0x280
	protected Vector3[] m_textContainerLocalCorners; // 0x298
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected float m_characterSpacing; // 0x2A0
	protected float m_cSpacing; // 0x2A4
	protected float m_monoSpacing; // 0x2A8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected float m_wordSpacing; // 0x2AC
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected float m_lineSpacing; // 0x2B0
	protected float m_lineSpacingDelta; // 0x2B4
	protected float m_lineHeight; // 0x2B8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected float m_lineSpacingMax; // 0x2BC
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected float m_paragraphSpacing; // 0x2C0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected float m_charWidthMaxAdj; // 0x2C4
	protected float m_charWidthAdjDelta; // 0x2C8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected bool m_enableWordWrapping; // 0x2CC
	protected bool m_isCharacterWrappingEnabled; // 0x2CD
	protected bool m_isNonBreakingSpace; // 0x2CE
	protected bool m_isIgnoringAlignment; // 0x2CF
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected float m_wordWrappingRatios; // 0x2D0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected TextOverflowModes m_overflowMode; // 0x2D4
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected int m_firstOverflowCharacterIndex; // 0x2D8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected TMP_Text m_linkedTextComponent; // 0x2E0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected bool m_isLinkedTextComponent; // 0x2E8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected bool m_isTextTruncated; // 0x2E9
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected bool m_enableKerning; // 0x2EA
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected bool m_enableExtraPadding; // 0x2EB
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected bool checkPaddingRequired; // 0x2EC
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected bool m_isRichText; // 0x2ED
	protected bool m_isOverlay; // 0x2EE
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected bool m_isOrthographic; // 0x2EF
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected bool m_isCullingEnabled; // 0x2F0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected bool m_ignoreRectMaskCulling; // 0x2F1
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected bool m_ignoreCulling; // 0x2F2
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected TextureMappingOptions m_horizontalMapping; // 0x2F4
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected TextureMappingOptions m_verticalMapping; // 0x2F8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected float m_uvLineOffset; // 0x2FC
	protected TextRenderFlags m_renderMode; // 0x300
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected VertexSortingOrder m_geometrySortingOrder; // 0x304
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected bool m_VertexBufferAutoSizeReduction; // 0x308
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected int m_firstVisibleCharacter; // 0x30C
	protected int m_maxVisibleCharacters; // 0x310
	protected int m_maxVisibleWords; // 0x314
	protected int m_maxVisibleLines; // 0x318
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected bool m_useMaxVisibleDescender; // 0x31C
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected int m_pageToDisplay; // 0x320
	protected bool m_isNewPage; // 0x324
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected Vector4 m_margin; // 0x328
	protected float m_marginLeft; // 0x338
	protected float m_marginRight; // 0x33C
	protected float m_marginWidth; // 0x340
	protected float m_marginHeight; // 0x344
	protected float m_width; // 0x348
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected TMP_TextInfo m_textInfo; // 0x350
	protected bool m_havePropertiesChanged; // 0x358
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected bool m_isUsingLegacyAnimationComponent; // 0x359
	protected Transform m_transform; // 0x360
	protected RectTransform m_rectTransform; // 0x368
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <autoSizeTextContainer>k__BackingField; // 0x370
	protected bool m_autoSizeTextContainer; // 0x371
	protected Mesh m_mesh; // 0x378
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected bool m_isVolumetricText; // 0x380
	protected float m_flexibleHeight; // 0x384
	protected float m_flexibleWidth; // 0x388
	protected float m_minWidth; // 0x38C
	protected float m_minHeight; // 0x390
	protected float m_maxWidth; // 0x394
	protected float m_maxHeight; // 0x398
	protected LayoutElement m_LayoutElement; // 0x3A0
	protected float m_preferredWidth; // 0x3A8
	protected float m_renderedWidth; // 0x3AC
	protected bool m_isPreferredWidthDirty; // 0x3B0
	protected float m_preferredHeight; // 0x3B4
	protected float m_renderedHeight; // 0x3B8
	protected bool m_isPreferredHeightDirty; // 0x3BC
	protected bool m_isCalculatingPreferredValues; // 0x3BD
	private int m_recursiveCount; // 0x3C0
	protected int m_layoutPriority; // 0x3C4
	protected bool m_isCalculateSizeRequired; // 0x3C8
	protected bool m_isLayoutDirty; // 0x3C9
	protected bool m_verticesAlreadyDirty; // 0x3CA
	protected bool m_layoutAlreadyDirty; // 0x3CB
	protected bool m_isAwake; // 0x3CC
	internal bool m_isWaitingOnResourceLoad; // 0x3CD
	internal bool m_isInputParsingRequired; // 0x3CE
	protected string old_text; // 0x3D0
	protected float m_fontScale; // 0x3D8
	protected float m_fontScaleMultiplier; // 0x3DC
	protected char[] m_htmlTag; // 0x3E0
	protected RichTextTagAttribute[] m_xmlAttribute; // 0x3E8
	protected float[] m_attributeParameterValues; // 0x3F0
	protected float tag_LineIndent; // 0x3F8
	protected float tag_Indent; // 0x3FC
	protected TMP_RichTextTagStack<float> m_indentStack; // 0x400
	protected bool tag_NoParsing; // 0x418
	protected bool m_isParsingText; // 0x419
	protected Matrix4x4 m_FXMatrix; // 0x41C
	protected bool m_isFXMatrixSet; // 0x45C
	protected TMP_Text.UnicodeChar[] m_TextParsingBuffer; // 0x460
	private TMP_CharacterInfo[] m_internalCharacterInfo; // 0x468
	protected int m_totalCharacterCount; // 0x470
	protected WordWrapState m_SavedWordWrapState; // 0x478
	protected WordWrapState m_SavedLineState; // 0x6F8
	protected int m_characterCount; // 0x978
	protected int m_firstCharacterOfLine; // 0x97C
	protected int m_firstVisibleCharacterOfLine; // 0x980
	protected int m_lastCharacterOfLine; // 0x984
	protected int m_lastVisibleCharacterOfLine; // 0x988
	protected int m_lineNumber; // 0x98C
	protected int m_lineVisibleCharacterCount; // 0x990
	protected int m_pageNumber; // 0x994
	protected float m_maxAscender; // 0x998
	protected float m_maxCapHeight; // 0x99C
	protected float m_maxDescender; // 0x9A0
	protected float m_maxLineAscender; // 0x9A4
	protected float m_maxLineDescender; // 0x9A8
	protected float m_startOfLineAscender; // 0x9AC
	protected float m_lineOffset; // 0x9B0
	protected Extents m_meshExtents; // 0x9B4
	protected Color32 m_htmlColor; // 0x9C4
	protected TMP_RichTextTagStack<Color32> m_colorStack; // 0x9C8
	protected TMP_RichTextTagStack<Color32> m_underlineColorStack; // 0x9E0
	protected TMP_RichTextTagStack<Color32> m_strikethroughColorStack; // 0x9F8
	protected TMP_RichTextTagStack<Color32> m_highlightColorStack; // 0xA10
	protected TMP_ColorGradient m_colorGradientPreset; // 0xA28
	protected TMP_RichTextTagStack<TMP_ColorGradient> m_colorGradientStack; // 0xA30
	protected float m_tabSpacing; // 0xA48
	protected float m_spacing; // 0xA4C
	protected TMP_RichTextTagStack<int> m_styleStack; // 0xA50
	protected TMP_RichTextTagStack<int> m_actionStack; // 0xA68
	protected float m_padding; // 0xA80
	protected float m_baselineOffset; // 0xA84
	protected TMP_RichTextTagStack<float> m_baselineOffsetStack; // 0xA88
	protected float m_xAdvance; // 0xAA0
	protected TMP_TextElementType m_textElementType; // 0xAA4
	protected TMP_TextElement m_cached_TextElement; // 0xAA8
	protected TMP_Character m_cached_Underline_Character; // 0xAB0
	protected TMP_Character m_cached_Ellipsis_Character; // 0xAB8
	protected int m_spriteCount; // 0xAC0
	protected int m_spriteIndex; // 0xAC4
	protected int m_spriteAnimationID; // 0xAC8
	protected bool m_ignoreActiveState; // 0xACC
	protected static Vector2 k_LargePositiveVector2; // 0x4
	protected static Vector2 k_LargeNegativeVector2; // 0xC
	protected static float k_LargePositiveFloat; // 0x14
	protected static float k_LargeNegativeFloat; // 0x18
	protected static int k_LargePositiveInt; // 0x1C
	protected static int k_LargeNegativeInt; // 0x20

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

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public virtual bool get_autoSizeTextContainer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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
	|-RVA: 0x5EDAA0 Offset: 0x5ECEA0 VA: 0x1805EDAA0
	|-TMP_Text.ResizeInternalArray<object>
	|
	|-RVA: 0x5EDB30 Offset: 0x5ECF30 VA: 0x1805EDB30
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
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected TextElementType m_ElementType; // 0x10
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private uint m_Unicode; // 0x14
	private Glyph m_Glyph; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private uint m_GlyphIndex; // 0x20
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_Scale; // 0x24

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
{	public int id; // 0x10
	public float x; // 0x14
	public float y; // 0x18
	public float width; // 0x1C
	public float height; // 0x20
	public float xOffset; // 0x24
	public float yOffset; // 0x28
	public float xAdvance; // 0x2C
	public float scale; // 0x30


	public void .ctor() { }

}

public class TMP_TextInfo // TypeDefIndex: 6842
{	private static Vector2 k_InfinityVectorPositive; // 0x0
	private static Vector2 k_InfinityVectorNegative; // 0x8
	public TMP_Text textComponent; // 0x10
	public int characterCount; // 0x18
	public int spriteCount; // 0x1C
	public int spaceCount; // 0x20
	public int wordCount; // 0x24
	public int linkCount; // 0x28
	public int lineCount; // 0x2C
	public int pageCount; // 0x30
	public int materialCount; // 0x34
	public TMP_CharacterInfo[] characterInfo; // 0x38
	public TMP_WordInfo[] wordInfo; // 0x40
	public TMP_LinkInfo[] linkInfo; // 0x48
	public TMP_LineInfo[] lineInfo; // 0x50
	public TMP_PageInfo[] pageInfo; // 0x58
	public TMP_MeshInfo[] meshInfo; // 0x60
	private TMP_MeshInfo[] m_CachedMeshInfo; // 0x68


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
	|-RVA: 0x5ED5F0 Offset: 0x5EC9F0 VA: 0x1805ED5F0
	|-TMP_TextInfo.Resize<object>
	|-TMP_TextInfo.Resize<TMP_SubMesh>
	|-TMP_TextInfo.Resize<TMP_SubMeshUI>
	|
	|-RVA: 0x5ED800 Offset: 0x5ECC00 VA: 0x1805ED800
	|-TMP_TextInfo.Resize<TMP_LinkInfo>
	|
	|-RVA: 0x5EDA10 Offset: 0x5ECE10 VA: 0x1805EDA10
	|-TMP_TextInfo.Resize<TMP_WordInfo>
	*/

	public static void Resize<T>(ref T[] array, int size, bool isBlockAllocated) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5ED680 Offset: 0x5ECA80 VA: 0x1805ED680
	|-TMP_TextInfo.Resize<object>
	|-TMP_TextInfo.Resize<Material>
	|
	|-RVA: 0x5ED740 Offset: 0x5ECB40 VA: 0x1805ED740
	|-TMP_TextInfo.Resize<TMP_CharacterInfo>
	|
	|-RVA: 0x5ED890 Offset: 0x5ECC90 VA: 0x1805ED890
	|-TMP_TextInfo.Resize<TMP_MeshInfo>
	|
	|-RVA: 0x5ED950 Offset: 0x5ECD50 VA: 0x1805ED950
	|-TMP_TextInfo.Resize<TMP_PageInfo>
	*/

	private static void .cctor() { }

}

public class TMP_TextParsingUtilities // TypeDefIndex: 6843
{	private static readonly TMP_TextParsingUtilities s_Instance; // 0x2B40
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
{	private static Vector3[] m_rectWorldCorners; // 0x2BCE
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
{	public Vector3 Point1; // 0x0
	public Vector3 Point2; // 0xC


	public void .ctor(Vector3 p1, Vector3 p2) { }

}

public class TMP_UpdateManager // TypeDefIndex: 6848
{	private static TMP_UpdateManager s_Instance; // 0x0
	private readonly List<TMP_Text> m_LayoutRebuildQueue; // 0x10
	private Dictionary<int, int> m_LayoutQueueLookup; // 0x18
	private readonly List<TMP_Text> m_GraphicRebuildQueue; // 0x20
	private Dictionary<int, int> m_GraphicQueueLookup; // 0x28
	private readonly List<TMP_Text> m_InternalUpdateQueue; // 0x30
	private Dictionary<int, int> m_InternalUpdateLookup; // 0x38

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
{	private static TMP_UpdateRegistry s_Instance; // 0x0
	private readonly List<ICanvasElement> m_LayoutRebuildQueue; // 0x10
	private Dictionary<int, int> m_LayoutQueueLookup; // 0x18
	private readonly List<ICanvasElement> m_GraphicRebuildQueue; // 0x20
	private Dictionary<int, int> m_GraphicQueueLookup; // 0x28

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
{	public const float FLOAT_MAX = 32767;
	public const float FLOAT_MIN = -32767;
	public const int INT_MAX = 2147483647;
	public const int INT_MIN = -2147483647;
	public const float FLOAT_UNSET = -32767;
	public const int INT_UNSET = -32767;
	public static Vector2 MAX_16BIT; // 0x0
	public static Vector2 MIN_16BIT; // 0x8


	public static bool Approximately(float a, float b) { }

	private static void .cctor() { }

}

public enum TMP_VertexDataUpdateFlags // TypeDefIndex: 6855
{	public int value__; // 0x0
	public const TMP_VertexDataUpdateFlags None = 0;
	public const TMP_VertexDataUpdateFlags Vertices = 1;
	public const TMP_VertexDataUpdateFlags Uv0 = 2;
	public const TMP_VertexDataUpdateFlags Uv2 = 4;
	public const TMP_VertexDataUpdateFlags Uv4 = 8;
	public const TMP_VertexDataUpdateFlags Colors32 = 16;
	public const TMP_VertexDataUpdateFlags All = 255;

}

public struct TMP_PageInfo // TypeDefIndex: 6857
{	public int firstCharacterIndex; // 0x0
	public int lastCharacterIndex; // 0x4
	public float ascender; // 0x8
	public float baseLine; // 0xC
	public float descender; // 0x10

}

public struct TMP_LinkInfo // TypeDefIndex: 6858
{	public TMP_Text textComponent; // 0x0
	public int hashCode; // 0x8
	public int linkIdFirstCharacterIndex; // 0xC
	public int linkIdLength; // 0x10
	public int linkTextfirstCharacterIndex; // 0x14
	public int linkTextLength; // 0x18
	internal char[] linkID; // 0x20


	internal void SetLinkID(char[] text, int startIndex, int length) { }

	public string GetLinkText() { }

	public string GetLinkID() { }

}

public struct TMP_WordInfo // TypeDefIndex: 6859
{	public TMP_Text textComponent; // 0x0
	public int firstCharacterIndex; // 0x8
	public int lastCharacterIndex; // 0xC
	public int characterCount; // 0x10


	public string GetWord() { }

}

public struct TMP_SpriteInfo // TypeDefIndex: 6860
{	public int spriteIndex; // 0x0
	public int characterIndex; // 0x4
	public int vertexIndex; // 0x8

}

