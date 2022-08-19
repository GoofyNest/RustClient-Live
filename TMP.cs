public class TMP_Asset : ScriptableObject // TypeDefIndex: 6743
{	// Fields
	public int hashCode; // 0x18
	public Material material; // 0x20
	public int materialHashCode; // 0x28

	// Methods

	// RVA: 0x4C0870 Offset: 0x4BFC70 VA: 0x1804C0870
	public void .ctor() { }

}

public class TMP_Character : TMP_TextElement // TypeDefIndex: 6744
{	// Methods

	// RVA: 0xC49B30 Offset: 0xC48F30 VA: 0x180C49B30
	public void .ctor() { }

	// RVA: 0xC49A60 Offset: 0xC48E60 VA: 0x180C49A60
	public void .ctor(uint unicode, Glyph glyph) { }

	// RVA: 0xC49AD0 Offset: 0xC48ED0 VA: 0x180C49AD0
	internal void .ctor(uint unicode, uint glyphIndex) { }

}

public struct TMP_Vertex // TypeDefIndex: 6745
{	// Fields
	public Vector3 position; // 0x0
	public Vector2 uv; // 0xC
	public Vector2 uv2; // 0x14
	public Vector2 uv4; // 0x1C
	public Color32 color; // 0x24

}

public struct TMP_CharacterInfo // TypeDefIndex: 6746
{	// Fields
	public char character; // 0x0
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
{	// Fields
	public ColorMode colorMode; // 0x18
	public Color topLeft; // 0x1C
	public Color topRight; // 0x2C
	public Color bottomLeft; // 0x3C
	public Color bottomRight; // 0x4C
	private const ColorMode k_DefaultColorMode = 3;
	private static readonly Color k_DefaultColor; // 0x0

	// Methods

	// RVA: 0xC49BB0 Offset: 0xC48FB0 VA: 0x180C49BB0
	public void .ctor() { }

	// RVA: 0xC49CE0 Offset: 0xC490E0 VA: 0x180C49CE0
	public void .ctor(Color color) { }

	// RVA: 0xC49C70 Offset: 0xC49070 VA: 0x180C49C70
	public void .ctor(Color color0, Color color1, Color color2, Color color3) { }

	// RVA: 0xC49B60 Offset: 0xC48F60 VA: 0x180C49B60
	private static void .cctor() { }

}

public static class TMP_DefaultControls // TypeDefIndex: 6757
{	// Fields
	private const float kWidth = 160;
	private const float kThickHeight = 30;
	private const float kThinHeight = 20;
	private static Vector2 s_ThickElementSize; // 0x0
	private static Vector2 s_ThinElementSize; // 0x8
	private static Color s_DefaultSelectableColor; // 0x10
	private static Color s_TextColor; // 0x20

	// Methods

	// RVA: 0xC4ACC0 Offset: 0xC4A0C0 VA: 0x180C4ACC0
	private static GameObject CreateUIElementRoot(string name, Vector2 size) { }

	// RVA: 0xC4AD60 Offset: 0xC4A160 VA: 0x180C4AD60
	private static GameObject CreateUIObject(string name, GameObject parent) { }

	// RVA: 0xC4AEB0 Offset: 0xC4A2B0 VA: 0x180C4AEB0
	private static void SetDefaultTextValues(TMP_Text lbl) { }

	// RVA: 0xC4AE10 Offset: 0xC4A210 VA: 0x180C4AE10
	private static void SetDefaultColorTransitionValues(Selectable slider) { }

	// RVA: 0xC4B030 Offset: 0xC4A430 VA: 0x180C4B030
	private static void SetParentAndAlign(GameObject child, GameObject parent) { }

	// RVA: 0xC4AF50 Offset: 0xC4A350 VA: 0x180C4AF50
	private static void SetLayerRecursively(GameObject go, int layer) { }

	// RVA: 0xC4A810 Offset: 0xC49C10 VA: 0x180C4A810
	public static GameObject CreateScrollbar(TMP_DefaultControls.Resources resources) { }

	// RVA: 0xC49D30 Offset: 0xC49130 VA: 0x180C49D30
	public static GameObject CreateButton(TMP_DefaultControls.Resources resources) { }

	// RVA: 0xC4AB70 Offset: 0xC49F70 VA: 0x180C4AB70
	public static GameObject CreateText(TMP_DefaultControls.Resources resources) { }

	// RVA: 0xC4A070 Offset: 0xC49470 VA: 0x180C4A070
	public static GameObject CreateInputField(TMP_DefaultControls.Resources resources) { }

	// RVA: 0xC4B120 Offset: 0xC4A520 VA: 0x180C4B120
	private static void .cctor() { }

}

public struct TMP_DefaultControls.Resources // TypeDefIndex: 6758
{	// Fields
	public Sprite standard; // 0x0
	public Sprite background; // 0x8
	public Sprite inputField; // 0x10
	public Sprite knob; // 0x18
	public Sprite checkmark; // 0x20
	public Sprite dropdown; // 0x28
	public Sprite mask; // 0x30

}

public class TMP_FontAsset : TMP_Asset // TypeDefIndex: 6760
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	// Properties
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

	// Methods

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public string get_version() { }

	// RVA: 0x4A2F10 Offset: 0x4A2310 VA: 0x1804A2F10
	internal void set_version(string value) { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	public Font get_sourceFontFile() { }

	// RVA: 0x4B94A0 Offset: 0x4B88A0 VA: 0x1804B94A0
	internal void set_sourceFontFile(Font value) { }

	// RVA: 0x5B1C80 Offset: 0x5B1080 VA: 0x1805B1C80
	public AtlasPopulationMode get_atlasPopulationMode() { }

	// RVA: 0x5B1C90 Offset: 0x5B1090 VA: 0x1805B1C90
	public void set_atlasPopulationMode(AtlasPopulationMode value) { }

	// RVA: 0xC531D0 Offset: 0xC525D0 VA: 0x180C531D0
	public FaceInfo get_faceInfo() { }

	// RVA: 0xC532E0 Offset: 0xC526E0 VA: 0x180C532E0
	internal void set_faceInfo(FaceInfo value) { }

	// RVA: 0x9321E0 Offset: 0x9315E0 VA: 0x1809321E0
	public List<Glyph> get_glyphTable() { }

	// RVA: 0xC53340 Offset: 0xC52740 VA: 0x180C53340
	internal void set_glyphTable(List<Glyph> value) { }

	// RVA: 0xC53230 Offset: 0xC52630 VA: 0x180C53230
	public Dictionary<uint, Glyph> get_glyphLookupTable() { }

	// RVA: 0x7AACD0 Offset: 0x7AA0D0 VA: 0x1807AACD0
	public List<TMP_Character> get_characterTable() { }

	// RVA: 0xA2BE10 Offset: 0xA2B210 VA: 0x180A2BE10
	internal void set_characterTable(List<TMP_Character> value) { }

	// RVA: 0xC53150 Offset: 0xC52550 VA: 0x180C53150
	public Dictionary<uint, TMP_Character> get_characterLookupTable() { }

	// RVA: 0xC53070 Offset: 0xC52470 VA: 0x180C53070
	public Texture2D get_atlasTexture() { }

	// RVA: 0xC53130 Offset: 0xC52530 VA: 0x180C53130
	public Texture2D[] get_atlasTextures() { }

	// RVA: 0xC53280 Offset: 0xC52680 VA: 0x180C53280
	public void set_atlasTextures(Texture2D[] value) { }

	// RVA: 0x4EBD40 Offset: 0x4EB140 VA: 0x1804EBD40
	internal List<GlyphRect> get_usedGlyphRects() { }

	// RVA: 0x4EBD50 Offset: 0x4EB150 VA: 0x1804EBD50
	internal void set_usedGlyphRects(List<GlyphRect> value) { }

	// RVA: 0x94E830 Offset: 0x94DC30 VA: 0x18094E830
	internal List<GlyphRect> get_freeGlyphRects() { }

	// RVA: 0x94E8B0 Offset: 0x94DCB0 VA: 0x18094E8B0
	internal void set_freeGlyphRects(List<GlyphRect> value) { }

	// RVA: 0xC53210 Offset: 0xC52610 VA: 0x180C53210
	public FaceInfo_Legacy get_fontInfo() { }

	// RVA: 0xC53140 Offset: 0xC52540 VA: 0x180C53140
	public int get_atlasWidth() { }

	// RVA: 0xC53290 Offset: 0xC52690 VA: 0x180C53290
	internal void set_atlasWidth(int value) { }

	// RVA: 0xC53050 Offset: 0xC52450 VA: 0x180C53050
	public int get_atlasHeight() { }

	// RVA: 0xC53260 Offset: 0xC52660 VA: 0x180C53260
	internal void set_atlasHeight(int value) { }

	// RVA: 0x94E6E0 Offset: 0x94DAE0 VA: 0x18094E6E0
	public int get_atlasPadding() { }

	// RVA: 0x94E880 Offset: 0x94DC80 VA: 0x18094E880
	internal void set_atlasPadding(int value) { }

	// RVA: 0xC53060 Offset: 0xC52460 VA: 0x180C53060
	public GlyphRenderMode get_atlasRenderMode() { }

	// RVA: 0xC53270 Offset: 0xC52670 VA: 0x180C53270
	internal void set_atlasRenderMode(GlyphRenderMode value) { }

	// RVA: 0x7F5E00 Offset: 0x7F5200 VA: 0x1807F5E00
	public TMP_FontFeatureTable get_fontFeatureTable() { }

	// RVA: 0xC53320 Offset: 0xC52720 VA: 0x180C53320
	internal void set_fontFeatureTable(TMP_FontFeatureTable value) { }

	// RVA: 0x71AF80 Offset: 0x71A380 VA: 0x18071AF80
	public List<TMP_FontAsset> get_fallbackFontAssetTable() { }

	// RVA: 0x71B010 Offset: 0x71A410 VA: 0x18071B010
	public void set_fallbackFontAssetTable(List<TMP_FontAsset> value) { }

	// RVA: 0xC53180 Offset: 0xC52580 VA: 0x180C53180
	public FontAssetCreationSettings get_creationSettings() { }

	// RVA: 0xC532A0 Offset: 0xC526A0 VA: 0x180C532A0
	public void set_creationSettings(FontAssetCreationSettings value) { }

	// RVA: 0xC53220 Offset: 0xC52620 VA: 0x180C53220
	public TMP_FontWeightPair[] get_fontWeightTable() { }

	// RVA: 0xC53330 Offset: 0xC52730 VA: 0x180C53330
	internal void set_fontWeightTable(TMP_FontWeightPair[] value) { }

	// RVA: 0xC4D280 Offset: 0xC4C680 VA: 0x180C4D280
	public static TMP_FontAsset CreateFontAsset(Font font) { }

	// RVA: 0xC4D300 Offset: 0xC4C700 VA: 0x180C4D300
	public static TMP_FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = 1) { }

	// RVA: 0xC4CB70 Offset: 0xC4BF70 VA: 0x180C4CB70
	private void Awake() { }

	// RVA: 0xC4E4B0 Offset: 0xC4D8B0 VA: 0x180C4E4B0
	internal void InitializeDictionaryLookupTables() { }

	// RVA: 0xC4E8F0 Offset: 0xC4DCF0 VA: 0x180C4E8F0
	public void ReadFontAssetDefinition() { }

	// RVA: 0xC4F2E0 Offset: 0xC4E6E0 VA: 0x180C4F2E0
	internal void SortCharacterTable() { }

	// RVA: 0xC4F670 Offset: 0xC4EA70 VA: 0x180C4F670
	internal void SortGlyphTable() { }

	// RVA: 0xC4F420 Offset: 0xC4E820 VA: 0x180C4F420
	internal void SortGlyphAndCharacterTables() { }

	// RVA: 0xC4E260 Offset: 0xC4D660 VA: 0x180C4E260
	public bool HasCharacter(int character) { }

	// RVA: 0xC4DDE0 Offset: 0xC4D1E0 VA: 0x180C4DDE0
	public bool HasCharacter(char character) { }

	// RVA: 0xC4DE50 Offset: 0xC4D250 VA: 0x180C4DE50
	public bool HasCharacter(char character, bool searchFallbacks) { }

	// RVA: 0xC4DC60 Offset: 0xC4D060 VA: 0x180C4DC60
	private bool HasCharacter_Internal(char character, bool searchFallbacks) { }

	// RVA: 0xC4E380 Offset: 0xC4D780 VA: 0x180C4E380
	public bool HasCharacters(string text, out List<char> missingCharacters) { }

	// RVA: 0xC4E2D0 Offset: 0xC4D6D0 VA: 0x180C4E2D0
	public bool HasCharacters(string text) { }

	// RVA: 0xC4DAD0 Offset: 0xC4CED0 VA: 0x180C4DAD0
	public static string GetCharacters(TMP_FontAsset fontAsset) { }

	// RVA: 0xC4D9E0 Offset: 0xC4CDE0 VA: 0x180C4D9E0
	public static int[] GetCharactersArray(TMP_FontAsset fontAsset) { }

	// RVA: 0xC50420 Offset: 0xC4F820 VA: 0x180C50420
	public bool TryAddCharacters(uint[] unicodes) { }

	// RVA: 0xC50440 Offset: 0xC4F840 VA: 0x180C50440
	public bool TryAddCharacters(uint[] unicodes, out uint[] missingUnicodes) { }

	// RVA: 0xC50400 Offset: 0xC4F800 VA: 0x180C50400
	public bool TryAddCharacters(string characters) { }

	// RVA: 0xC50C80 Offset: 0xC50080 VA: 0x180C50C80
	public bool TryAddCharacters(string characters, out string missingCharacters) { }

	// RVA: 0xC4FFF0 Offset: 0xC4F3F0 VA: 0x180C4FFF0
	internal bool TryAddCharacter_Internal(uint unicode) { }

	// RVA: 0xC4C770 Offset: 0xC4BB70 VA: 0x180C4C770
	internal TMP_Character AddCharacter_Internal(uint unicode, Glyph glyph) { }

	// RVA: 0xC4F7B0 Offset: 0xC4EBB0 VA: 0x180C4F7B0
	internal bool TryAddCharacterInternal(uint unicode, out TMP_Character character) { }

	// RVA: 0xC4DBA0 Offset: 0xC4CFA0 VA: 0x180C4DBA0
	internal uint GetGlyphIndex(uint unicode) { }

	// RVA: 0xC51400 Offset: 0xC50800 VA: 0x180C51400
	internal void UpdateAtlasTexture() { }

	// RVA: 0xC517B0 Offset: 0xC50BB0 VA: 0x180C517B0
	internal void UpdateGlyphAdjustmentRecords(uint unicode, uint glyphIndex) { }

	// RVA: 0xC4CBF0 Offset: 0xC4BFF0 VA: 0x180C4CBF0
	public void ClearFontAssetData(bool setAtlasSizeToZero = False) { }

	// RVA: 0xC51C60 Offset: 0xC51060 VA: 0x180C51C60
	private void UpgradeFontAsset() { }

	// RVA: 0xC529A0 Offset: 0xC51DA0 VA: 0x180C529A0
	private void UpgradeGlyphAdjustmentTableToFontFeatureTable() { }

	// RVA: 0xC52DD0 Offset: 0xC521D0 VA: 0x180C52DD0
	public void .ctor() { }

	// RVA: 0xC52D40 Offset: 0xC52140 VA: 0x180C52D40
	private static void .cctor() { }

}

private sealed class TMP_FontAsset.<>c // TypeDefIndex: 6761
{	// Fields
	public static readonly TMP_FontAsset.<>c <>9; // 0x0
	public static Func<TMP_Character, uint> <>9__100_0; // 0x8
	public static Func<Glyph, uint> <>9__101_0; // 0x10

	// Methods

	// RVA: 0xC64520 Offset: 0xC63920 VA: 0x180C64520
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x96C250 Offset: 0x96B650 VA: 0x18096C250
	internal uint <SortCharacterTable>b__100_0(TMP_Character c) { }

	// RVA: 0xC64490 Offset: 0xC63890 VA: 0x180C64490
	internal uint <SortGlyphTable>b__101_0(Glyph c) { }

}

public class TMP_Glyph : TMP_TextElement_Legacy // TypeDefIndex: 6763
{	// Methods

	// RVA: 0xC54010 Offset: 0xC53410 VA: 0x180C54010
	public static TMP_Glyph Clone(TMP_Glyph source) { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

}

public struct TMP_FontWeightPair // TypeDefIndex: 6765
{	// Fields
	public TMP_FontAsset regularTypeface; // 0x0
	public TMP_FontAsset italicTypeface; // 0x8

}

public static class TMP_FontUtilities // TypeDefIndex: 6774
{	// Fields
	private static List<int> k_searchedFontAssets; // 0x2B0AACC

	// Methods

	// RVA: 0xC53AE0 Offset: 0xC52EE0 VA: 0x180C53AE0
	public static TMP_FontAsset SearchForCharacter(TMP_FontAsset font, uint unicode, out TMP_Character character) { }

	// RVA: 0xC53BB0 Offset: 0xC52FB0 VA: 0x180C53BB0
	public static TMP_FontAsset SearchForCharacter(List<TMP_FontAsset> fonts, uint unicode, out TMP_Character character) { }

	// RVA: 0xC53890 Offset: 0xC52C90 VA: 0x180C53890
	private static TMP_FontAsset SearchForCharacterInternal(TMP_FontAsset font, uint unicode, out TMP_Character character) { }

	// RVA: 0xC537A0 Offset: 0xC52BA0 VA: 0x180C537A0
	private static TMP_FontAsset SearchForCharacterInternal(List<TMP_FontAsset> fonts, uint unicode, out TMP_Character character) { }

}

public class TMP_FontAssetUtilities // TypeDefIndex: 6775
{	// Fields
	private static readonly TMP_FontAssetUtilities s_Instance; // 0x0
	private static List<int> k_SearchedFontAssets; // 0x8
	private static bool k_IsFontEngineInitialized; // 0x10

	// Properties
	public static TMP_FontAssetUtilities instance { get; }

	// Methods

	// RVA: 0xC4C6B0 Offset: 0xC4BAB0 VA: 0x180C4C6B0
	private static void .cctor() { }

	// RVA: 0xC4C710 Offset: 0xC4BB10 VA: 0x180C4C710
	public static TMP_FontAssetUtilities get_instance() { }

	// RVA: 0xC4B730 Offset: 0xC4AB30 VA: 0x180C4B730
	public static TMP_Character GetCharacterFromFontAsset(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface, out TMP_FontAsset fontAsset) { }

	// RVA: 0xC4B270 Offset: 0xC4A670 VA: 0x180C4B270
	private static TMP_Character GetCharacterFromFontAsset_Internal(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface, out TMP_FontAsset fontAsset) { }

	// RVA: 0xC4B8B0 Offset: 0xC4ACB0 VA: 0x180C4B8B0
	public static TMP_Character GetCharacterFromFontAssets(uint unicode, List<TMP_FontAsset> fontAssets, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface, out TMP_FontAsset fontAsset) { }

	// RVA: 0xC4BB30 Offset: 0xC4AF30 VA: 0x180C4BB30
	private static bool TryGetCharacterFromFontFile(uint unicode, TMP_FontAsset fontAsset, out TMP_Character character) { }

	// RVA: 0xC4C4D0 Offset: 0xC4B8D0 VA: 0x180C4C4D0
	public static bool TryGetGlyphFromFontFile(uint glyphIndex, TMP_FontAsset fontAsset, out Glyph glyph) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class TMP_FontFeatureTable // TypeDefIndex: 6776
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal List<TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords; // 0x10
	internal Dictionary<long, TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookupDictionary; // 0x18

	// Properties
	internal List<TMP_GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords { get; set; }

	// Methods

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	internal List<TMP_GlyphPairAdjustmentRecord> get_glyphPairAdjustmentRecords() { }

	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	internal void set_glyphPairAdjustmentRecords(List<TMP_GlyphPairAdjustmentRecord> value) { }

	// RVA: 0xC53550 Offset: 0xC52950 VA: 0x180C53550
	public void .ctor() { }

	// RVA: 0xC53350 Offset: 0xC52750 VA: 0x180C53350
	public void SortGlyphPairAdjustmentRecords() { }

}

private sealed class TMP_FontFeatureTable.<>c // TypeDefIndex: 6777
{	// Fields
	public static readonly TMP_FontFeatureTable.<>c <>9; // 0x0
	public static Func<TMP_GlyphPairAdjustmentRecord, uint> <>9__6_0; // 0x8
	public static Func<TMP_GlyphPairAdjustmentRecord, uint> <>9__6_1; // 0x10

	// Methods

	// RVA: 0xC645E0 Offset: 0xC639E0 VA: 0x180C645E0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xC64450 Offset: 0xC63850 VA: 0x180C64450
	internal uint <SortGlyphPairAdjustmentRecords>b__6_0(TMP_GlyphPairAdjustmentRecord s) { }

	// RVA: 0xC64470 Offset: 0xC63870 VA: 0x180C64470
	internal uint <SortGlyphPairAdjustmentRecords>b__6_1(TMP_GlyphPairAdjustmentRecord s) { }

}

public struct TMP_GlyphValueRecord // TypeDefIndex: 6779
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_XPlacement; // 0x0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_YPlacement; // 0x4
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_XAdvance; // 0x8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_YAdvance; // 0xC

	// Properties
	public float xPlacement { get; set; }
	public float yPlacement { get; set; }
	public float xAdvance { get; set; }
	public float yAdvance { get; set; }

	// Methods

	// RVA: 0xF2270 Offset: 0xF1670 VA: 0x1800F2270
	public float get_xPlacement() { }

	// RVA: 0xF2280 Offset: 0xF1680 VA: 0x1800F2280
	public void set_xPlacement(float value) { }

	// RVA: 0x117750 Offset: 0x116B50 VA: 0x180117750
	public float get_yPlacement() { }

	// RVA: 0x117760 Offset: 0x116B60 VA: 0x180117760
	public void set_yPlacement(float value) { }

	// RVA: 0x116F40 Offset: 0x116340 VA: 0x180116F40
	public float get_xAdvance() { }

	// RVA: 0x116F80 Offset: 0x116380 VA: 0x180116F80
	public void set_xAdvance(float value) { }

	// RVA: 0x116F50 Offset: 0x116350 VA: 0x180116F50
	public float get_yAdvance() { }

	// RVA: 0x116F90 Offset: 0x116390 VA: 0x180116F90
	public void set_yAdvance(float value) { }

	// RVA: 0xF2CA0 Offset: 0xF20A0 VA: 0x1800F2CA0
	public void .ctor(float xPlacement, float yPlacement, float xAdvance, float yAdvance) { }

	// RVA: 0x117720 Offset: 0x116B20 VA: 0x180117720
	internal void .ctor(GlyphValueRecord_Legacy valueRecord) { }

	// RVA: 0x117310 Offset: 0x116710 VA: 0x180117310
	internal void .ctor(GlyphValueRecord valueRecord) { }

	// RVA: 0xC53FF0 Offset: 0xC533F0 VA: 0x180C53FF0
	public static TMP_GlyphValueRecord op_Addition(TMP_GlyphValueRecord a, TMP_GlyphValueRecord b) { }

}

public struct TMP_GlyphAdjustmentRecord // TypeDefIndex: 6780
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private uint m_GlyphIndex; // 0x0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TMP_GlyphValueRecord m_GlyphValueRecord; // 0x4

	// Properties
	public uint glyphIndex { get; set; }
	public TMP_GlyphValueRecord glyphValueRecord { get; set; }

	// Methods

	// RVA: 0xF3850 Offset: 0xF2C50 VA: 0x1800F3850
	public uint get_glyphIndex() { }

	// RVA: 0xF3A80 Offset: 0xF2E80 VA: 0x1800F3A80
	public void set_glyphIndex(uint value) { }

	// RVA: 0x117700 Offset: 0x116B00 VA: 0x180117700
	public TMP_GlyphValueRecord get_glyphValueRecord() { }

	// RVA: 0x117710 Offset: 0x116B10 VA: 0x180117710
	public void set_glyphValueRecord(TMP_GlyphValueRecord value) { }

	// RVA: 0x1176C0 Offset: 0x116AC0 VA: 0x1801176C0
	public void .ctor(uint glyphIndex, TMP_GlyphValueRecord glyphValueRecord) { }

	// RVA: 0x1176D0 Offset: 0x116AD0 VA: 0x1801176D0
	internal void .ctor(GlyphAdjustmentRecord adjustmentRecord) { }

}

public class TMP_GlyphPairAdjustmentRecord // TypeDefIndex: 6781
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TMP_GlyphAdjustmentRecord m_FirstAdjustmentRecord; // 0x10
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TMP_GlyphAdjustmentRecord m_SecondAdjustmentRecord; // 0x24
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private FontFeatureLookupFlags m_FeatureLookupFlags; // 0x38

	// Properties
	public TMP_GlyphAdjustmentRecord firstAdjustmentRecord { get; set; }
	public TMP_GlyphAdjustmentRecord secondAdjustmentRecord { get; set; }
	public FontFeatureLookupFlags featureLookupFlags { get; set; }

	// Methods

	// RVA: 0xC53F80 Offset: 0xC53380 VA: 0x180C53F80
	public TMP_GlyphAdjustmentRecord get_firstAdjustmentRecord() { }

	// RVA: 0xC53FD0 Offset: 0xC533D0 VA: 0x180C53FD0
	public void set_firstAdjustmentRecord(TMP_GlyphAdjustmentRecord value) { }

	// RVA: 0xC53FA0 Offset: 0xC533A0 VA: 0x180C53FA0
	public TMP_GlyphAdjustmentRecord get_secondAdjustmentRecord() { }

	// RVA: 0xC53FE0 Offset: 0xC533E0 VA: 0x180C53FE0
	public void set_secondAdjustmentRecord(TMP_GlyphAdjustmentRecord value) { }

	// RVA: 0x516B70 Offset: 0x515F70 VA: 0x180516B70
	public FontFeatureLookupFlags get_featureLookupFlags() { }

	// RVA: 0xC53FC0 Offset: 0xC533C0 VA: 0x180C53FC0
	public void set_featureLookupFlags(FontFeatureLookupFlags value) { }

	// RVA: 0xC53D70 Offset: 0xC53170 VA: 0x180C53D70
	public void .ctor(TMP_GlyphAdjustmentRecord firstAdjustmentRecord, TMP_GlyphAdjustmentRecord secondAdjustmentRecord) { }

	// RVA: 0xC53DC0 Offset: 0xC531C0 VA: 0x180C53DC0
	internal void .ctor(GlyphPairAdjustmentRecord glyphPairAdjustmentRecord) { }

}

public class TMP_InputField : Selectable, IUpdateSelectedHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, ILayoutElement, IScrollHandler // TypeDefIndex: 6783
{	// Fields
	protected TouchScreenKeyboard m_SoftKeyboard; // 0xE8
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

	// Properties
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

	// Methods

	// RVA: 0xC625D0 Offset: 0xC619D0 VA: 0x180C625D0
	private BaseInput get_inputSystem() { }

	// RVA: 0xC62470 Offset: 0xC61870 VA: 0x180C62470
	private string get_compositionString() { }

	// RVA: 0xC62030 Offset: 0xC61430 VA: 0x180C62030
	protected void .ctor() { }

	// RVA: 0xC62750 Offset: 0xC61B50 VA: 0x180C62750
	protected Mesh get_mesh() { }

	// RVA: 0xC62A90 Offset: 0xC61E90 VA: 0x180C62A90
	public bool get_shouldHideMobileInput() { }

	// RVA: 0xC63F10 Offset: 0xC63310 VA: 0x180C63F10
	public void set_shouldHideMobileInput(bool value) { }

	// RVA: 0xC62AC0 Offset: 0xC61EC0 VA: 0x180C62AC0
	public bool get_shouldHideSoftKeyboard() { }

	// RVA: 0xC63F90 Offset: 0xC63390 VA: 0x180C63F90
	public void set_shouldHideSoftKeyboard(bool value) { }

	// RVA: 0xC62B20 Offset: 0xC61F20 VA: 0x180C62B20
	private bool isKeyboardUsingEvents() { }

	// RVA: 0xC62B10 Offset: 0xC61F10 VA: 0x180C62B10
	public string get_text() { }

	// RVA: 0xC642B0 Offset: 0xC636B0 VA: 0x180C642B0
	public void set_text(string value) { }

	// RVA: 0xC60D80 Offset: 0xC60180 VA: 0x180C60D80
	public void SetTextWithoutNotify(string input) { }

	// RVA: 0xC60D90 Offset: 0xC60190 VA: 0x180C60D90
	private void SetText(string value, bool sendCallback = True) { }

	// RVA: 0xC62710 Offset: 0xC61B10 VA: 0x180C62710
	public bool get_isFocused() { }

	// RVA: 0x75F2D0 Offset: 0x75E6D0 VA: 0x18075F2D0
	public float get_caretBlinkRate() { }

	// RVA: 0xC62BB0 Offset: 0xC61FB0 VA: 0x180C62BB0
	public void set_caretBlinkRate(float value) { }

	// RVA: 0xC62430 Offset: 0xC61830 VA: 0x180C62430
	public int get_caretWidth() { }

	// RVA: 0xC62E80 Offset: 0xC62280 VA: 0x180C62E80
	public void set_caretWidth(int value) { }

	// RVA: 0xC53210 Offset: 0xC52610 VA: 0x180C53210
	public RectTransform get_textViewport() { }

	// RVA: 0xC64260 Offset: 0xC63660 VA: 0x180C64260
	public void set_textViewport(RectTransform value) { }

	// RVA: 0xB0A550 Offset: 0xB09950 VA: 0x180B0A550
	public TMP_Text get_textComponent() { }

	// RVA: 0xC64200 Offset: 0xC63600 VA: 0x180C64200
	public void set_textComponent(TMP_Text value) { }

	// RVA: 0xC62850 Offset: 0xC61C50 VA: 0x180C62850
	public Graphic get_placeholder() { }

	// RVA: 0xC63930 Offset: 0xC62D30 VA: 0x180C63930
	public void set_placeholder(Graphic value) { }

	// RVA: 0x94E420 Offset: 0x94D820 VA: 0x18094E420
	public Scrollbar get_verticalScrollbar() { }

	// RVA: 0xC642C0 Offset: 0xC636C0 VA: 0x180C642C0
	public void set_verticalScrollbar(Scrollbar value) { }

	// RVA: 0xC62A10 Offset: 0xC61E10 VA: 0x180C62A10
	public float get_scrollSensitivity() { }

	// RVA: 0xC63BA0 Offset: 0xC62FA0 VA: 0x180C63BA0
	public void set_scrollSensitivity(float value) { }

	// RVA: 0xC62370 Offset: 0xC61770 VA: 0x180C62370
	public Color get_caretColor() { }

	// RVA: 0xC62C20 Offset: 0xC62020 VA: 0x180C62C20
	public void set_caretColor(Color value) { }

	// RVA: 0xC62530 Offset: 0xC61930 VA: 0x180C62530
	public bool get_customCaretColor() { }

	// RVA: 0xC63200 Offset: 0xC62600 VA: 0x180C63200
	public void set_customCaretColor(bool value) { }

	// RVA: 0xC62A20 Offset: 0xC61E20 VA: 0x180C62A20
	public Color get_selectionColor() { }

	// RVA: 0xC63CD0 Offset: 0xC630D0 VA: 0x180C63CD0
	public void set_selectionColor(Color value) { }

	// RVA: 0xC62810 Offset: 0xC61C10 VA: 0x180C62810
	public TMP_InputField.SubmitEvent get_onEndEdit() { }

	// RVA: 0xC636A0 Offset: 0xC62AA0 VA: 0x180C636A0
	public void set_onEndEdit(TMP_InputField.SubmitEvent value) { }

	// RVA: 0x7FEF40 Offset: 0x7FE340 VA: 0x1807FEF40
	public TMP_InputField.SubmitEvent get_onSubmit() { }

	// RVA: 0xC637A0 Offset: 0xC62BA0 VA: 0x180C637A0
	public void set_onSubmit(TMP_InputField.SubmitEvent value) { }

	// RVA: 0xA1B2D0 Offset: 0xA1A6D0 VA: 0x180A1B2D0
	public TMP_InputField.SelectionEvent get_onSelect() { }

	// RVA: 0xC63750 Offset: 0xC62B50 VA: 0x180C63750
	public void set_onSelect(TMP_InputField.SelectionEvent value) { }

	// RVA: 0x8A99E0 Offset: 0x8A8DE0 VA: 0x1808A99E0
	public TMP_InputField.SelectionEvent get_onDeselect() { }

	// RVA: 0xC63650 Offset: 0xC62A50 VA: 0x180C63650
	public void set_onDeselect(TMP_InputField.SelectionEvent value) { }

	// RVA: 0xC62840 Offset: 0xC61C40 VA: 0x180C62840
	public TMP_InputField.TextSelectionEvent get_onTextSelection() { }

	// RVA: 0xC637F0 Offset: 0xC62BF0 VA: 0x180C637F0
	public void set_onTextSelection(TMP_InputField.TextSelectionEvent value) { }

	// RVA: 0xC62820 Offset: 0xC61C20 VA: 0x180C62820
	public TMP_InputField.TextSelectionEvent get_onEndTextSelection() { }

	// RVA: 0xC636F0 Offset: 0xC62AF0 VA: 0x180C636F0
	public void set_onEndTextSelection(TMP_InputField.TextSelectionEvent value) { }

	// RVA: 0xB09E20 Offset: 0xB09220 VA: 0x180B09E20
	public TMP_InputField.OnChangeEvent get_onValueChanged() { }

	// RVA: 0xC638E0 Offset: 0xC62CE0 VA: 0x180C638E0
	public void set_onValueChanged(TMP_InputField.OnChangeEvent value) { }

	// RVA: 0xC53220 Offset: 0xC52620 VA: 0x180C53220
	public TMP_InputField.TouchScreenKeyboardEvent get_onTouchScreenKeyboardStatusChanged() { }

	// RVA: 0xC63840 Offset: 0xC62C40 VA: 0x180C63840
	public void set_onTouchScreenKeyboardStatusChanged(TMP_InputField.TouchScreenKeyboardEvent value) { }

	// RVA: 0xAD42C0 Offset: 0xAD36C0 VA: 0x180AD42C0
	public TMP_InputField.OnValidateInput get_onValidateInput() { }

	// RVA: 0xC63890 Offset: 0xC62C90 VA: 0x180C63890
	public void set_onValidateInput(TMP_InputField.OnValidateInput value) { }

	// RVA: 0xC62440 Offset: 0xC61840 VA: 0x180C62440
	public int get_characterLimit() { }

	// RVA: 0xC62F20 Offset: 0xC62320 VA: 0x180C62F20
	public void set_characterLimit(int value) { }

	// RVA: 0xC62860 Offset: 0xC61C60 VA: 0x180C62860
	public float get_pointSize() { }

	// RVA: 0xC63980 Offset: 0xC62D80 VA: 0x180C63980
	public void set_pointSize(float value) { }

	// RVA: 0xC62550 Offset: 0xC61950 VA: 0x180C62550
	public TMP_FontAsset get_fontAsset() { }

	// RVA: 0xC63270 Offset: 0xC62670 VA: 0x180C63270
	public void set_fontAsset(TMP_FontAsset value) { }

	// RVA: 0xC62830 Offset: 0xC61C30 VA: 0x180C62830
	public bool get_onFocusSelectAll() { }

	// RVA: 0xC63740 Offset: 0xC62B40 VA: 0x180C63740
	public void set_onFocusSelectAll(bool value) { }

	// RVA: 0xC629F0 Offset: 0xC61DF0 VA: 0x180C629F0
	public bool get_resetOnDeActivation() { }

	// RVA: 0xC63AF0 Offset: 0xC62EF0 VA: 0x180C63AF0
	public void set_resetOnDeActivation(bool value) { }

	// RVA: 0xC62A00 Offset: 0xC61E00 VA: 0x180C62A00
	public bool get_restoreOriginalTextOnEscape() { }

	// RVA: 0xC63B00 Offset: 0xC62F00 VA: 0x180C63B00
	public void set_restoreOriginalTextOnEscape(bool value) { }

	// RVA: 0xC62720 Offset: 0xC61B20 VA: 0x180C62720
	public bool get_isRichTextEditingAllowed() { }

	// RVA: 0xC63480 Offset: 0xC62880 VA: 0x180C63480
	public void set_isRichTextEditingAllowed(bool value) { }

	// RVA: 0xC62520 Offset: 0xC61920 VA: 0x180C62520
	public TMP_InputField.ContentType get_contentType() { }

	// RVA: 0xC63050 Offset: 0xC62450 VA: 0x180C63050
	public void set_contentType(TMP_InputField.ContentType value) { }

	// RVA: 0x94E410 Offset: 0x94D810 VA: 0x18094E410
	public TMP_InputField.LineType get_lineType() { }

	// RVA: 0xC63570 Offset: 0xC62970 VA: 0x180C63570
	public void set_lineType(TMP_InputField.LineType value) { }

	// RVA: 0xC62740 Offset: 0xC61B40 VA: 0x180C62740
	public int get_lineLimit() { }

	// RVA: 0xC63500 Offset: 0xC62900 VA: 0x180C63500
	public void set_lineLimit(int value) { }

	// RVA: 0xC626F0 Offset: 0xC61AF0 VA: 0x180C626F0
	public TMP_InputField.InputType get_inputType() { }

	// RVA: 0xC633A0 Offset: 0xC627A0 VA: 0x180C633A0
	public void set_inputType(TMP_InputField.InputType value) { }

	// RVA: 0xC62730 Offset: 0xC61B30 VA: 0x180C62730
	public TouchScreenKeyboardType get_keyboardType() { }

	// RVA: 0xC63490 Offset: 0xC62890 VA: 0x180C63490
	public void set_keyboardType(TouchScreenKeyboardType value) { }

	// RVA: 0xC62450 Offset: 0xC61850 VA: 0x180C62450
	public TMP_InputField.CharacterValidation get_characterValidation() { }

	// RVA: 0xC62FD0 Offset: 0xC623D0 VA: 0x180C62FD0
	public void set_characterValidation(TMP_InputField.CharacterValidation value) { }

	// RVA: 0xC62700 Offset: 0xC61B00 VA: 0x180C62700
	public TMP_InputValidator get_inputValidator() { }

	// RVA: 0xC63410 Offset: 0xC62810 VA: 0x180C63410
	public void set_inputValidator(TMP_InputValidator value) { }

	// RVA: 0xC629E0 Offset: 0xC61DE0 VA: 0x180C629E0
	public bool get_readOnly() { }

	// RVA: 0xC63AE0 Offset: 0xC62EE0 VA: 0x180C63AE0
	public void set_readOnly(bool value) { }

	// RVA: 0xBC3110 Offset: 0xBC2510 VA: 0x180BC3110
	public bool get_richText() { }

	// RVA: 0xC63B10 Offset: 0xC62F10 VA: 0x180C63B10
	public void set_richText(bool value) { }

	// RVA: 0xC627F0 Offset: 0xC61BF0 VA: 0x180C627F0
	public bool get_multiLine() { }

	// RVA: 0xC62360 Offset: 0xC61760 VA: 0x180C62360
	public char get_asteriskChar() { }

	// RVA: 0xC62B50 Offset: 0xC61F50 VA: 0x180C62B50
	public void set_asteriskChar(char value) { }

	// RVA: 0x8A3970 Offset: 0x8A2D70 VA: 0x1808A3970
	public bool get_wasCanceled() { }

	// RVA: 0xC56280 Offset: 0xC55680 VA: 0x180C56280
	protected void ClampStringPos(ref int pos) { }

	// RVA: 0xC56230 Offset: 0xC55630 VA: 0x180C56230
	protected void ClampCaretPos(ref int pos) { }

	// RVA: 0xC623D0 Offset: 0xC617D0 VA: 0x180C623D0
	protected int get_caretPositionInternal() { }

	// RVA: 0xC62CD0 Offset: 0xC620D0 VA: 0x180C62CD0
	protected void set_caretPositionInternal(int value) { }

	// RVA: 0xC62A30 Offset: 0xC61E30 VA: 0x180C62A30
	protected int get_stringPositionInternal() { }

	// RVA: 0xC64090 Offset: 0xC63490 VA: 0x180C64090
	protected void set_stringPositionInternal(int value) { }

	// RVA: 0xC62400 Offset: 0xC61800 VA: 0x180C62400
	protected int get_caretSelectPositionInternal() { }

	// RVA: 0xC62E20 Offset: 0xC62220 VA: 0x180C62E20
	protected void set_caretSelectPositionInternal(int value) { }

	// RVA: 0xC62A60 Offset: 0xC61E60 VA: 0x180C62A60
	protected int get_stringSelectPositionInternal() { }

	// RVA: 0xC641B0 Offset: 0xC635B0 VA: 0x180C641B0
	protected void set_stringSelectPositionInternal(int value) { }

	// RVA: 0xC62560 Offset: 0xC61960 VA: 0x180C62560
	private bool get_hasSelection() { }

	// RVA: 0xC62400 Offset: 0xC61800 VA: 0x180C62400
	public int get_caretPosition() { }

	// RVA: 0xC62D30 Offset: 0xC62130 VA: 0x180C62D30
	public void set_caretPosition(int value) { }

	// RVA: 0xC623D0 Offset: 0xC617D0 VA: 0x180C623D0
	public int get_selectionAnchorPosition() { }

	// RVA: 0xC63C40 Offset: 0xC63040 VA: 0x180C63C40
	public void set_selectionAnchorPosition(int value) { }

	// RVA: 0xC62400 Offset: 0xC61800 VA: 0x180C62400
	public int get_selectionFocusPosition() { }

	// RVA: 0xC63D80 Offset: 0xC63180 VA: 0x180C63D80
	public void set_selectionFocusPosition(int value) { }

	// RVA: 0xC62A60 Offset: 0xC61E60 VA: 0x180C62A60
	public int get_stringPosition() { }

	// RVA: 0xC640E0 Offset: 0xC634E0 VA: 0x180C640E0
	public void set_stringPosition(int value) { }

	// RVA: 0xC62A30 Offset: 0xC61E30 VA: 0x180C62A30
	public int get_selectionStringAnchorPosition() { }

	// RVA: 0xC63E10 Offset: 0xC63210 VA: 0x180C63E10
	public void set_selectionStringAnchorPosition(int value) { }

	// RVA: 0xC62A60 Offset: 0xC61E60 VA: 0x180C62A60
	public int get_selectionStringFocusPosition() { }

	// RVA: 0xC63E90 Offset: 0xC63290 VA: 0x180C63E90
	public void set_selectionStringFocusPosition(int value) { }

	// RVA: 0xC5DFB0 Offset: 0xC5D3B0 VA: 0x180C5DFB0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0xC5D6C0 Offset: 0xC5CAC0 VA: 0x180C5D6C0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0xC5D440 Offset: 0xC5C840 VA: 0x180C5D440
	private void ON_TEXT_CHANGED(Object obj) { }

	[IteratorStateMachineAttribute] // RVA: 0xD1020 Offset: 0xD0420 VA: 0x1800D1020
	// RVA: 0xC561C0 Offset: 0xC555C0 VA: 0x180C561C0
	private IEnumerator CaretBlink() { }

	// RVA: 0xC60A10 Offset: 0xC5FE10 VA: 0x180C60A10
	private void SetCaretVisible() { }

	// RVA: 0xC60940 Offset: 0xC5FD40 VA: 0x180C60940
	private void SetCaretActive() { }

	// RVA: 0xC5EBD0 Offset: 0xC5DFD0 VA: 0x180C5EBD0
	protected void OnFocus() { }

	// RVA: 0xC604D0 Offset: 0xC5F8D0 VA: 0x180C604D0
	protected void SelectAll() { }

	// RVA: 0xC5C6E0 Offset: 0xC5BAE0 VA: 0x180C5C6E0
	public void MoveTextEnd(bool shift) { }

	// RVA: 0xC5C930 Offset: 0xC5BD30 VA: 0x180C5C930
	public void MoveTextStart(bool shift) { }

	// RVA: 0xC5CB60 Offset: 0xC5BF60 VA: 0x180C5CB60
	public void MoveToEndOfLine(bool shift, bool ctrl) { }

	// RVA: 0xC5CE10 Offset: 0xC5C210 VA: 0x180C5CE10
	public void MoveToStartOfLine(bool shift, bool ctrl) { }

	// RVA: 0xC62460 Offset: 0xC61860 VA: 0x180C62460
	private static string get_clipboard() { }

	// RVA: 0xC63040 Offset: 0xC62440 VA: 0x180C63040
	private static void set_clipboard(string value) { }

	// RVA: 0xC59090 Offset: 0xC58490 VA: 0x180C59090
	private bool InPlaceEditing() { }

	// RVA: 0xC61590 Offset: 0xC60990 VA: 0x180C61590
	private void UpdateStringPositionFromKeyboard() { }

	// RVA: 0xC59870 Offset: 0xC58C70 VA: 0x180C59870 Slot: 60
	protected virtual void LateUpdate() { }

	// RVA: 0xC5A580 Offset: 0xC59980 VA: 0x180C5A580
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0xC5D620 Offset: 0xC5CA20 VA: 0x180C5D620 Slot: 61
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0xC5D9F0 Offset: 0xC5CDF0 VA: 0x180C5D9F0 Slot: 62
	public virtual void OnDrag(PointerEventData eventData) { }

	[IteratorStateMachineAttribute] // RVA: 0xD1160 Offset: 0xD0560 VA: 0x1800D1160
	// RVA: 0xC5A690 Offset: 0xC59A90 VA: 0x180C5A690
	private IEnumerator MouseDragOutsideRect(PointerEventData eventData) { }

	// RVA: 0xC5E610 Offset: 0xC5DA10 VA: 0x180C5E610 Slot: 63
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0xC5EC70 Offset: 0xC5E070 VA: 0x180C5EC70 Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0xC59410 Offset: 0xC58810 VA: 0x180C59410
	protected TMP_InputField.EditState KeyPressed(Event evt) { }

	// RVA: 0xC59400 Offset: 0xC58800 VA: 0x180C59400 Slot: 64
	protected virtual bool IsValidChar(char c) { }

	// RVA: 0xC60390 Offset: 0xC5F790 VA: 0x180C60390
	public void ProcessEvent(Event e) { }

	// RVA: 0xC5FA90 Offset: 0xC5EE90 VA: 0x180C5FA90 Slot: 65
	public virtual void OnUpdateSelected(BaseEventData eventData) { }

	// RVA: 0xC5F790 Offset: 0xC5EB90 VA: 0x180C5F790 Slot: 66
	public virtual void OnScroll(PointerEventData eventData) { }

	// RVA: 0xC58F10 Offset: 0xC58310 VA: 0x180C58F10
	private string GetSelectedString() { }

	// RVA: 0xC57380 Offset: 0xC56780 VA: 0x180C57380
	private int FindNextWordBegin() { }

	// RVA: 0xC5BE80 Offset: 0xC5B280 VA: 0x180C5BE80
	private void MoveRight(bool shift, bool ctrl) { }

	// RVA: 0xC57490 Offset: 0xC56890 VA: 0x180C57490
	private int FindPrevWordBegin() { }

	// RVA: 0xC5AAD0 Offset: 0xC59ED0 VA: 0x180C5AAD0
	private void MoveLeft(bool shift, bool ctrl) { }

	// RVA: 0xC5A220 Offset: 0xC59620 VA: 0x180C5A220
	private int LineUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	// RVA: 0xC59F20 Offset: 0xC59320 VA: 0x180C59F20
	private int LineDownCharacterPosition(int originalPos, bool goToLastChar) { }

	// RVA: 0xC5FFD0 Offset: 0xC5F3D0 VA: 0x180C5FFD0
	private int PageUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	// RVA: 0xC5FBF0 Offset: 0xC5EFF0 VA: 0x180C5FBF0
	private int PageDownCharacterPosition(int originalPos, bool goToLastChar) { }

	// RVA: 0xC5AAC0 Offset: 0xC59EC0 VA: 0x180C5AAC0
	private void MoveDown(bool shift) { }

	// RVA: 0xC5A720 Offset: 0xC59B20 VA: 0x180C5A720
	private void MoveDown(bool shift, bool goToLastChar) { }

	// RVA: 0xC5D430 Offset: 0xC5C830 VA: 0x180C5D430
	private void MoveUp(bool shift) { }

	// RVA: 0xC5D0B0 Offset: 0xC5C4B0 VA: 0x180C5D0B0
	private void MoveUp(bool shift, bool goToFirstChar) { }

	// RVA: 0xC5BE70 Offset: 0xC5B270 VA: 0x180C5BE70
	private void MovePageUp(bool shift) { }

	// RVA: 0xC5B8D0 Offset: 0xC5ACD0 VA: 0x180C5B8D0
	private void MovePageUp(bool shift, bool goToFirstChar) { }

	// RVA: 0xC5B8C0 Offset: 0xC5ACC0 VA: 0x180C5B8C0
	private void MovePageDown(bool shift) { }

	// RVA: 0xC5B300 Offset: 0xC5A700 VA: 0x180C5B300
	private void MovePageDown(bool shift, bool goToLastChar) { }

	// RVA: 0xC56A20 Offset: 0xC55E20 VA: 0x180C56A20
	private void Delete() { }

	// RVA: 0xC566B0 Offset: 0xC55AB0 VA: 0x180C566B0
	private void DeleteKey() { }

	// RVA: 0xC55C10 Offset: 0xC55010 VA: 0x180C55C10
	private void Backspace() { }

	// RVA: 0xC553C0 Offset: 0xC547C0 VA: 0x180C553C0 Slot: 67
	protected virtual void Append(string input) { }

	// RVA: 0xC55250 Offset: 0xC54650 VA: 0x180C55250 Slot: 68
	protected virtual void Append(char input) { }

	// RVA: 0xC59180 Offset: 0xC58580 VA: 0x180C59180
	private void Insert(char c) { }

	// RVA: 0xC61870 Offset: 0xC60C70 VA: 0x180C61870
	private void UpdateTouchKeyboardFromEditChanges() { }

	// RVA: 0xC60820 Offset: 0xC5FC20 VA: 0x180C60820
	private void SendOnValueChangedAndUpdateLabel() { }

	// RVA: 0xC60880 Offset: 0xC5FC80 VA: 0x180C60880
	private void SendOnValueChanged() { }

	// RVA: 0xC60530 Offset: 0xC5F930 VA: 0x180C60530
	protected void SendOnEndEdit() { }

	// RVA: 0xC60700 Offset: 0xC5FB00 VA: 0x180C60700
	protected void SendOnSubmit() { }

	// RVA: 0xC606B0 Offset: 0xC5FAB0 VA: 0x180C606B0
	protected void SendOnFocus() { }

	// RVA: 0xC60660 Offset: 0xC5FA60 VA: 0x180C60660
	protected void SendOnFocusLost() { }

	// RVA: 0xC60750 Offset: 0xC5FB50 VA: 0x180C60750
	protected void SendOnTextSelection() { }

	// RVA: 0xC60580 Offset: 0xC5F980 VA: 0x180C60580
	protected void SendOnEndTextSelection() { }

	// RVA: 0xC608D0 Offset: 0xC5FCD0 VA: 0x180C608D0
	protected void SendTouchScreenKeyboardStatusChanged() { }

	// RVA: 0xC61040 Offset: 0xC60440 VA: 0x180C61040
	protected void UpdateLabel() { }

	// RVA: 0xC613E0 Offset: 0xC607E0 VA: 0x180C613E0
	private void UpdateScrollbar() { }

	// RVA: 0xC5F940 Offset: 0xC5ED40 VA: 0x180C5F940
	private void OnScrollbarValueChange(float value) { }

	// RVA: 0xC550A0 Offset: 0xC544A0 VA: 0x180C550A0
	private void AdjustTextPositionRelativeToViewport(float relativePosition) { }

	// RVA: 0xC58E10 Offset: 0xC58210 VA: 0x180C58E10
	private int GetCaretPositionFromStringIndex(int stringIndex) { }

	// RVA: 0xC58E90 Offset: 0xC58290 VA: 0x180C58E90
	private int GetMinCaretPositionFromStringIndex(int stringIndex) { }

	// RVA: 0xC58E10 Offset: 0xC58210 VA: 0x180C58E10
	private int GetMaxCaretPositionFromStringIndex(int stringIndex) { }

	// RVA: 0xC59010 Offset: 0xC58410 VA: 0x180C59010
	private int GetStringIndexFromCaretPosition(int caretPosition) { }

	// RVA: 0xC57580 Offset: 0xC56980 VA: 0x180C57580
	public void ForceLabelUpdate() { }

	// RVA: 0xC5A520 Offset: 0xC59920 VA: 0x180C5A520
	private void MarkGeometryAsDirty() { }

	// RVA: 0xC603A0 Offset: 0xC5F7A0 VA: 0x180C603A0 Slot: 69
	public virtual void Rebuild(CanvasUpdate update) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 70
	public virtual void LayoutComplete() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 71
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0xC60F80 Offset: 0xC60380 VA: 0x180C60F80
	private void UpdateGeometry() { }

	// RVA: 0xC55470 Offset: 0xC54870 VA: 0x180C55470
	private void AssignPositioningIfNeeded() { }

	// RVA: 0xC5E640 Offset: 0xC5DA40 VA: 0x180C5E640
	private void OnFillVBO(Mesh vbo) { }

	// RVA: 0xC57590 Offset: 0xC56990 VA: 0x180C57590
	private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0xC562C0 Offset: 0xC556C0 VA: 0x180C562C0
	private void CreateCursorVerts() { }

	// RVA: 0xC58020 Offset: 0xC57420 VA: 0x180C58020
	private void GenerateHightlight(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0xC547A0 Offset: 0xC53BA0 VA: 0x180C547A0
	private void AdjustRectTransformRelativeToViewport(Vector2 startPosition, float height, bool isCharVisible) { }

	// RVA: 0xC618C0 Offset: 0xC60CC0 VA: 0x180C618C0
	protected char Validate(string text, int pos, char ch) { }

	// RVA: 0xC54650 Offset: 0xC53A50 VA: 0x180C54650
	public void ActivateInputField() { }

	// RVA: 0xC540B0 Offset: 0xC534B0 VA: 0x180C540B0
	private void ActivateInputFieldInternal() { }

	// RVA: 0xC5F9A0 Offset: 0xC5EDA0 VA: 0x180C5F9A0 Slot: 36
	public override void OnSelect(BaseEventData eventData) { }

	// RVA: 0xC5EC40 Offset: 0xC5E040 VA: 0x180C5EC40 Slot: 72
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void OnControlClick() { }

	// RVA: 0xC60470 Offset: 0xC5F870 VA: 0x180C60470
	public void ReleaseSelection() { }

	// RVA: 0xC56460 Offset: 0xC55860 VA: 0x180C56460
	public void DeactivateInputField(bool clearSelection = False) { }

	// RVA: 0xC5D650 Offset: 0xC5CA50 VA: 0x180C5D650 Slot: 37
	public override void OnDeselect(BaseEventData eventData) { }

	// RVA: 0xC5FA00 Offset: 0xC5EE00 VA: 0x180C5FA00 Slot: 73
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0xC57210 Offset: 0xC56610 VA: 0x180C57210
	private void EnforceContentType() { }

	// RVA: 0xC60CC0 Offset: 0xC600C0 VA: 0x180C60CC0
	private void SetTextComponentWrapMode() { }

	// RVA: 0xC60C30 Offset: 0xC60030 VA: 0x180C60C30
	private void SetTextComponentRichTextMode() { }

	// RVA: 0xC60EF0 Offset: 0xC602F0 VA: 0x180C60EF0
	private void SetToCustomIfContentTypeIsNot(TMP_InputField.ContentType[] allowedContentTypes) { }

	// RVA: 0xC60F60 Offset: 0xC60360 VA: 0x180C60F60
	private void SetToCustom() { }

	// RVA: 0xC60F60 Offset: 0xC60360 VA: 0x180C60F60
	private void SetToCustom(TMP_InputField.CharacterValidation characterValidation) { }

	// RVA: 0xC571E0 Offset: 0xC565E0 VA: 0x180C571E0 Slot: 26
	protected override void DoStateTransition(Selectable.SelectionState state, bool instant) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 74
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 75
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x581F40 Offset: 0x581340 VA: 0x180581F40 Slot: 76
	public virtual float get_minWidth() { }

	// RVA: 0xC62920 Offset: 0xC61D20 VA: 0x180C62920 Slot: 77
	public virtual float get_preferredWidth() { }

	// RVA: 0xC62540 Offset: 0xC61940 VA: 0x180C62540 Slot: 78
	public virtual float get_flexibleWidth() { }

	// RVA: 0x581F40 Offset: 0x581340 VA: 0x180581F40 Slot: 79
	public virtual float get_minHeight() { }

	// RVA: 0xC62870 Offset: 0xC61C70 VA: 0x180C62870 Slot: 80
	public virtual float get_preferredHeight() { }

	// RVA: 0xC62540 Offset: 0xC61940 VA: 0x180C62540 Slot: 81
	public virtual float get_flexibleHeight() { }

	// RVA: 0x5CB140 Offset: 0x5CA540 VA: 0x1805CB140 Slot: 82
	public virtual int get_layoutPriority() { }

	// RVA: 0xC60B40 Offset: 0xC5FF40 VA: 0x180C60B40
	public void SetGlobalPointSize(float pointSize) { }

	// RVA: 0xC60A50 Offset: 0xC5FE50 VA: 0x180C60A50
	public void SetGlobalFontAsset(TMP_FontAsset fontAsset) { }

	// RVA: 0xC61FC0 Offset: 0xC613C0 VA: 0x180C61FC0
	private static void .cctor() { }

	// RVA: 0xAB8650 Offset: 0xAB7A50 VA: 0x180AB8650 Slot: 46
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }

}

public enum TMP_InputField.ContentType // TypeDefIndex: 6784
{	// Fields
	public int value__; // 0x0
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
{	// Fields
	public int value__; // 0x0
	public const TMP_InputField.InputType Standard = 0;
	public const TMP_InputField.InputType AutoCorrect = 1;
	public const TMP_InputField.InputType Password = 2;

}

public enum TMP_InputField.CharacterValidation // TypeDefIndex: 6786
{	// Fields
	public int value__; // 0x0
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
{	// Fields
	public int value__; // 0x0
	public const TMP_InputField.LineType SingleLine = 0;
	public const TMP_InputField.LineType MultiLineSubmit = 1;
	public const TMP_InputField.LineType MultiLineNewline = 2;

}

public sealed class TMP_InputField.OnValidateInput : MulticastDelegate // TypeDefIndex: 6788
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xD928B0 Offset: 0xD91CB0 VA: 0x180D928B0 Slot: 12
	public virtual char Invoke(string text, int charIndex, char addedChar) { }

	// RVA: 0xD927E0 Offset: 0xD91BE0 VA: 0x180D927E0 Slot: 13
	public virtual IAsyncResult BeginInvoke(string text, int charIndex, char addedChar, AsyncCallback callback, object object) { }

	// RVA: 0xD92880 Offset: 0xD91C80 VA: 0x180D92880 Slot: 14
	public virtual char EndInvoke(IAsyncResult result) { }

}

public class TMP_InputField.SubmitEvent : UnityEvent<string> // TypeDefIndex: 6789
{	// Methods

	// RVA: 0xD92E90 Offset: 0xD92290 VA: 0x180D92E90
	public void .ctor() { }

}

public class TMP_InputField.OnChangeEvent : UnityEvent<string> // TypeDefIndex: 6790
{	// Methods

	// RVA: 0xD927A0 Offset: 0xD91BA0 VA: 0x180D927A0
	public void .ctor() { }

}

public class TMP_InputField.SelectionEvent : UnityEvent<string> // TypeDefIndex: 6791
{	// Methods

	// RVA: 0xD92E50 Offset: 0xD92250 VA: 0x180D92E50
	public void .ctor() { }

}

public class TMP_InputField.TextSelectionEvent : UnityEvent<string, int, int> // TypeDefIndex: 6792
{	// Methods

	// RVA: 0xDB0950 Offset: 0xDAFD50 VA: 0x180DB0950
	public void .ctor() { }

}

public class TMP_InputField.TouchScreenKeyboardEvent : UnityEvent<TouchScreenKeyboard.Status> // TypeDefIndex: 6793
{	// Methods

	// RVA: 0xDB0990 Offset: 0xDAFD90 VA: 0x180DB0990
	public void .ctor() { }

}

private sealed class TMP_InputField.<CaretBlink>d__267 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 6795
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public TMP_InputField <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xDB09D0 Offset: 0xDAFDD0 VA: 0x180DB09D0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xDB0B20 Offset: 0xDAFF20 VA: 0x180DB0B20 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class TMP_InputField.<MouseDragOutsideRect>d__285 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 6796
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public TMP_InputField <>4__this; // 0x20
	public PointerEventData eventData; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xDB0B70 Offset: 0xDAFF70 VA: 0x180DB0B70 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xDB0E20 Offset: 0xDB0220 VA: 0x180DB0E20 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

public abstract class TMP_InputValidator : ScriptableObject // TypeDefIndex: 6798
{	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract char Validate(ref string text, ref int pos, char ch);

	// RVA: 0x4C0870 Offset: 0x4BFC70 VA: 0x1804C0870
	protected void .ctor() { }

}

public struct TMP_LineInfo // TypeDefIndex: 6799
{	// Fields
	internal int controlCharacterCount; // 0x0
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
{	// Fields
	private static readonly TMP_ObjectPool<List<T>> s_ListPool; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static List<T> Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17A8880 Offset: 0x17A7C80 VA: 0x1817A8880
	|-TMP_ListPool<object>.Get
	|-TMP_ListPool<Canvas>.Get
	|-TMP_ListPool<IMaterialModifier>.Get
	|-TMP_ListPool<Mask>.Get
	*/

	// RVA: -1 Offset: -1
	public static void Release(List<T> toRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17A89F0 Offset: 0x17A7DF0 VA: 0x1817A89F0
	|-TMP_ListPool<object>.Release
	|-TMP_ListPool<Canvas>.Release
	|-TMP_ListPool<IMaterialModifier>.Release
	|-TMP_ListPool<Mask>.Release
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17A8B70 Offset: 0x17A7F70 VA: 0x1817A8B70
	|-TMP_ListPool<object>..cctor
	*/

}

private sealed class TMP_ListPool.<>c<T> // TypeDefIndex: 6801
{	// Fields
	public static readonly TMP_ListPool.<>c<T> <>9; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD602E0 Offset: 0xD5F6E0 VA: 0x180D602E0
	|-TMP_ListPool.<>c<object>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55DC0 Offset: 0xD551C0 VA: 0x180D55DC0
	|-TMP_ListPool.<>c<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <.cctor>b__3_0(List<T> l) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E3C40 Offset: 0x15E3040 VA: 0x1815E3C40
	|-TMP_ListPool.<>c<object>.<.cctor>b__3_0
	*/

}

public static class TMP_MaterialManager // TypeDefIndex: 6802
{	// Fields
	private static List<TMP_MaterialManager.MaskingMaterial> m_materialList; // 0x0
	private static Dictionary<long, TMP_MaterialManager.FallbackMaterial> m_fallbackMaterials; // 0x8
	private static Dictionary<int, long> m_fallbackMaterialLookup; // 0x10
	private static List<TMP_MaterialManager.FallbackMaterial> m_fallbackCleanupList; // 0x18
	private static bool isFallbackListDirty; // 0x20

	// Methods

	// RVA: 0xD95BD0 Offset: 0xD94FD0 VA: 0x180D95BD0
	private static void .cctor() { }

	// RVA: 0xD94B40 Offset: 0xD93F40 VA: 0x180D94B40
	private static void OnPreRender(Camera cam) { }

	// RVA: 0xD94AB0 Offset: 0xD93EB0 VA: 0x180D94AB0
	private static void OnPreRenderCanvas() { }

	// RVA: 0xD946E0 Offset: 0xD93AE0 VA: 0x180D946E0
	public static Material GetStencilMaterial(Material baseMaterial, int stencilID) { }

	// RVA: 0xD95590 Offset: 0xD94990 VA: 0x180D95590
	public static void ReleaseStencilMaterial(Material stencilMaterial) { }

	// RVA: 0xD93B50 Offset: 0xD92F50 VA: 0x180D93B50
	public static Material GetBaseMaterial(Material stencilMaterial) { }

	// RVA: 0xD95AC0 Offset: 0xD94EC0 VA: 0x180D95AC0
	public static Material SetStencil(Material material, int stencilID) { }

	// RVA: 0xD930E0 Offset: 0xD924E0 VA: 0x180D930E0
	public static void AddMaskingMaterial(Material baseMaterial, Material stencilMaterial, int stencilID) { }

	// RVA: 0xD95980 Offset: 0xD94D80 VA: 0x180D95980
	public static void RemoveStencilMaterial(Material stencilMaterial) { }

	// RVA: 0xD94BD0 Offset: 0xD93FD0 VA: 0x180D94BD0
	public static void ReleaseBaseMaterial(Material baseMaterial) { }

	// RVA: 0xD93560 Offset: 0xD92960 VA: 0x180D93560
	public static void ClearMaterials() { }

	// RVA: 0xD942F0 Offset: 0xD936F0 VA: 0x180D942F0
	public static int GetStencilID(GameObject obj) { }

	// RVA: 0xD94120 Offset: 0xD93520 VA: 0x180D94120
	public static Material GetMaterialForRendering(MaskableGraphic graphic, Material baseMaterial) { }

	// RVA: 0xD939F0 Offset: 0xD92DF0 VA: 0x180D939F0
	private static Transform FindRootSortOverrideCanvas(Transform start) { }

	// RVA: 0xD93CB0 Offset: 0xD930B0 VA: 0x180D93CB0
	public static Material GetFallbackMaterial(Material sourceMaterial, Material targetMaterial) { }

	// RVA: 0xD92FB0 Offset: 0xD923B0 VA: 0x180D92FB0
	public static void AddFallbackMaterialReference(Material targetMaterial) { }

	// RVA: 0xD957E0 Offset: 0xD94BE0 VA: 0x180D957E0
	public static void RemoveFallbackMaterialReference(Material targetMaterial) { }

	// RVA: 0xD93330 Offset: 0xD92730 VA: 0x180D93330
	public static void CleanupFallbackMaterials() { }

	// RVA: 0xD953C0 Offset: 0xD947C0 VA: 0x180D953C0
	public static void ReleaseFallbackMaterial(Material fallackMaterial) { }

	// RVA: 0xD93700 Offset: 0xD92B00 VA: 0x180D93700
	public static void CopyMaterialPresetProperties(Material source, Material destination) { }

}

private class TMP_MaterialManager.FallbackMaterial // TypeDefIndex: 6803
{	// Fields
	public int baseID; // 0x10
	public Material baseMaterial; // 0x18
	public long fallbackID; // 0x20
	public Material fallbackMaterial; // 0x28
	public int count; // 0x30

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private class TMP_MaterialManager.MaskingMaterial // TypeDefIndex: 6804
{	// Fields
	public Material baseMaterial; // 0x10
	public Material stencilMaterial; // 0x18
	public int count; // 0x20
	public int stencilID; // 0x24

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private sealed class TMP_MaterialManager.<>c__DisplayClass10_0 // TypeDefIndex: 6805
{	// Fields
	public Material stencilMaterial; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xDB0E70 Offset: 0xDB0270 VA: 0x180DB0E70
	internal bool <GetBaseMaterial>b__0(TMP_MaterialManager.MaskingMaterial item) { }

}

private sealed class TMP_MaterialManager.<>c__DisplayClass12_0 // TypeDefIndex: 6806
{	// Fields
	public Material stencilMaterial; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xDB0EF0 Offset: 0xDB02F0 VA: 0x180DB0EF0
	internal bool <AddMaskingMaterial>b__0(TMP_MaterialManager.MaskingMaterial item) { }

}

private sealed class TMP_MaterialManager.<>c__DisplayClass13_0 // TypeDefIndex: 6807
{	// Fields
	public Material stencilMaterial; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xDB0F70 Offset: 0xDB0370 VA: 0x180DB0F70
	internal bool <RemoveStencilMaterial>b__0(TMP_MaterialManager.MaskingMaterial item) { }

}

private sealed class TMP_MaterialManager.<>c__DisplayClass14_0 // TypeDefIndex: 6808
{	// Fields
	public Material baseMaterial; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xDB0FF0 Offset: 0xDB03F0 VA: 0x180DB0FF0
	internal bool <ReleaseBaseMaterial>b__0(TMP_MaterialManager.MaskingMaterial item) { }

}

public struct TMP_MeshInfo // TypeDefIndex: 6810
{	// Fields
	private static readonly Color32 s_DefaultColor; // 0x0
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

	// Methods

	// RVA: 0x122510 Offset: 0x121910 VA: 0x180122510
	public void .ctor(Mesh mesh, int size) { }

	// RVA: 0x122520 Offset: 0x121920 VA: 0x180122520
	public void .ctor(Mesh mesh, int size, bool isVolumetric) { }

	// RVA: 0x122310 Offset: 0x121710 VA: 0x180122310
	public void ResizeMeshInfo(int size) { }

	// RVA: 0x122320 Offset: 0x121720 VA: 0x180122320
	public void ResizeMeshInfo(int size, bool isVolumetric) { }

	// RVA: 0x122260 Offset: 0x121660 VA: 0x180122260
	public void Clear() { }

	// RVA: 0x122120 Offset: 0x121520 VA: 0x180122120
	public void Clear(bool uploadChanges) { }

	// RVA: 0x1220E0 Offset: 0x1214E0 VA: 0x1801220E0
	public void ClearUnusedVertices() { }

	// RVA: 0x121FF0 Offset: 0x1213F0 VA: 0x180121FF0
	public void ClearUnusedVertices(int startIndex) { }

	// RVA: 0x122020 Offset: 0x121420 VA: 0x180122020
	public void ClearUnusedVertices(int startIndex, bool updateMesh) { }

	// RVA: 0x122330 Offset: 0x121730 VA: 0x180122330
	public void SortGeometry(VertexSortingOrder order) { }

	// RVA: 0x1223B0 Offset: 0x1217B0 VA: 0x1801223B0
	public void SortGeometry(IList<int> sortingOrder) { }

	// RVA: 0x122500 Offset: 0x121900 VA: 0x180122500
	public void SwapVertexData(int src, int dst) { }

	// RVA: 0xD97F10 Offset: 0xD97310 VA: 0x180D97F10
	private static void .cctor() { }

}

internal class TMP_ObjectPool<T> // TypeDefIndex: 6811
{	// Fields
	private readonly Stack<T> m_Stack; // 0x0
	private readonly UnityAction<T> m_ActionOnGet; // 0x0
	private readonly UnityAction<T> m_ActionOnRelease; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <countAll>k__BackingField; // 0x0

	// Properties
	public int countAll { get; set; }
	public int countActive { get; }
	public int countInactive { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public int get_countAll() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4BB390 Offset: 0x4BA790 VA: 0x1804BB390
	|-TMP_ObjectPool<object>.get_countAll
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	private void set_countAll(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7E8DF0 Offset: 0x7E81F0 VA: 0x1807E8DF0
	|-TMP_ObjectPool<object>.set_countAll
	*/

	// RVA: -1 Offset: -1
	public int get_countActive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17A90C0 Offset: 0x17A84C0 VA: 0x1817A90C0
	|-TMP_ObjectPool<object>.get_countActive
	*/

	// RVA: -1 Offset: -1
	public int get_countInactive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE02AD0 Offset: 0xE01ED0 VA: 0x180E02AD0
	|-TMP_ObjectPool<object>.get_countInactive
	*/

	// RVA: -1 Offset: -1
	public void .ctor(UnityAction<T> actionOnGet, UnityAction<T> actionOnRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17A9000 Offset: 0x17A8400 VA: 0x1817A9000
	|-TMP_ObjectPool<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public T Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17A8E10 Offset: 0x17A8210 VA: 0x1817A8E10
	|-TMP_ObjectPool<object>.Get
	*/

	// RVA: -1 Offset: -1
	public void Release(T element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17A8F00 Offset: 0x17A8300 VA: 0x1817A8F00
	|-TMP_ObjectPool<object>.Release
	*/

}

public struct TMP_FontStyleStack // TypeDefIndex: 6812
{	// Fields
	public byte bold; // 0x0
	public byte italic; // 0x1
	public byte underline; // 0x2
	public byte strikethrough; // 0x3
	public byte highlight; // 0x4
	public byte superscript; // 0x5
	public byte subscript; // 0x6
	public byte uppercase; // 0x7
	public byte lowercase; // 0x8
	public byte smallcaps; // 0x9

	// Methods

	// RVA: 0x117580 Offset: 0x116980 VA: 0x180117580
	public void Clear() { }

	// RVA: 0x117500 Offset: 0x116900 VA: 0x180117500
	public byte Add(FontStyles style) { }

	// RVA: 0x117590 Offset: 0x116990 VA: 0x180117590
	public byte Remove(FontStyles style) { }

}

public struct TMP_RichTextTagStack<T> // TypeDefIndex: 6813
{	// Fields
	public T[] m_ItemStack; // 0x0
	public int m_Index; // 0x0
	private int m_Capacity; // 0x0
	private T m_DefaultItem; // 0x0
	private const int k_DefaultCapacity = 4;

	// Methods

	// RVA: -1 Offset: -1
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

	// RVA: -1 Offset: -1
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

	// RVA: -1 Offset: -1
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

	// RVA: -1 Offset: -1
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

	// RVA: -1 Offset: -1
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

	// RVA: -1 Offset: -1
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

	// RVA: -1 Offset: -1
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

	// RVA: -1 Offset: -1
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

	// RVA: -1 Offset: -1
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

	// RVA: -1 Offset: -1
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

	// RVA: -1 Offset: -1
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
{	// Fields
	public bool isSelected; // 0x18

	// Methods

	// RVA: 0xD99360 Offset: 0xD98760 VA: 0x180D99360 Slot: 4
	public void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0xD993B0 Offset: 0xD987B0 VA: 0x180D993B0 Slot: 5
	public void OnSelect(BaseEventData eventData) { }

	// RVA: 0xD99300 Offset: 0xD98700 VA: 0x180D99300 Slot: 6
	public void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class TMP_SelectionCaret : MaskableGraphic // TypeDefIndex: 6819
{	// Methods

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 58
	public override void Cull(Rect clipRect, bool validRect) { }

	// RVA: 0xD99410 Offset: 0xD98810 VA: 0x180D99410
	public void .ctor() { }

}

public class TMP_Settings : ScriptableObject // TypeDefIndex: 6820
{	// Fields
	private static TMP_Settings s_Instance; // 0x0
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

	// Properties
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

	// Methods

	// RVA: 0xD99D20 Offset: 0xD99120 VA: 0x180D99D20
	public static string get_version() { }

	// RVA: 0xD99A00 Offset: 0xD98E00 VA: 0x180D99A00
	public static bool get_enableWordWrapping() { }

	// RVA: 0xD999A0 Offset: 0xD98DA0 VA: 0x180D999A0
	public static bool get_enableKerning() { }

	// RVA: 0xD99980 Offset: 0xD98D80 VA: 0x180D99980
	public static bool get_enableExtraPadding() { }

	// RVA: 0xD999E0 Offset: 0xD98DE0 VA: 0x180D999E0
	public static bool get_enableTintAllSprites() { }

	// RVA: 0xD999C0 Offset: 0xD98DC0 VA: 0x180D999C0
	public static bool get_enableRaycastTarget() { }

	// RVA: 0xD99A70 Offset: 0xD98E70 VA: 0x180D99A70
	public static bool get_getFontFeaturesAtRuntime() { }

	// RVA: 0xD99D00 Offset: 0xD99100 VA: 0x180D99D00
	public static int get_missingGlyphCharacter() { }

	// RVA: 0xD99DA0 Offset: 0xD991A0 VA: 0x180D99DA0
	public static void set_missingGlyphCharacter(int value) { }

	// RVA: 0xD99D50 Offset: 0xD99150 VA: 0x180D99D50
	public static bool get_warningsDisabled() { }

	// RVA: 0xD99880 Offset: 0xD98C80 VA: 0x180D99880
	public static TMP_FontAsset get_defaultFontAsset() { }

	// RVA: 0xD99860 Offset: 0xD98C60 VA: 0x180D99860
	public static string get_defaultFontAssetPath() { }

	// RVA: 0xD998A0 Offset: 0xD98CA0 VA: 0x180D998A0
	public static float get_defaultFontSize() { }

	// RVA: 0xD998E0 Offset: 0xD98CE0 VA: 0x180D998E0
	public static float get_defaultTextAutoSizingMinRatio() { }

	// RVA: 0xD998C0 Offset: 0xD98CC0 VA: 0x180D998C0
	public static float get_defaultTextAutoSizingMaxRatio() { }

	// RVA: 0xD99900 Offset: 0xD98D00 VA: 0x180D99900
	public static Vector2 get_defaultTextMeshProTextContainerSize() { }

	// RVA: 0xD99930 Offset: 0xD98D30 VA: 0x180D99930
	public static Vector2 get_defaultTextMeshProUITextContainerSize() { }

	// RVA: 0xD99820 Offset: 0xD98C20 VA: 0x180D99820
	public static bool get_autoSizeTextContainer() { }

	// RVA: 0xD99A20 Offset: 0xD98E20 VA: 0x180D99A20
	public static List<TMP_FontAsset> get_fallbackFontAssets() { }

	// RVA: 0xD99CE0 Offset: 0xD990E0 VA: 0x180D99CE0
	public static bool get_matchMaterialPreset() { }

	// RVA: 0xD99840 Offset: 0xD98C40 VA: 0x180D99840
	public static string get_defaultColorGradientPresetsPath() { }

	// RVA: 0xD99960 Offset: 0xD98D60 VA: 0x180D99960
	public static bool get_enableEmojiSupport() { }

	// RVA: 0xD99D70 Offset: 0xD99170 VA: 0x180D99D70
	public static void set_enableEmojiSupport(bool value) { }

	// RVA: 0xD99B40 Offset: 0xD98F40 VA: 0x180D99B40
	public static TextAsset get_leadingCharacters() { }

	// RVA: 0xD99A40 Offset: 0xD98E40 VA: 0x180D99A40
	public static TextAsset get_followingCharacters() { }

	// RVA: 0xD99B60 Offset: 0xD98F60 VA: 0x180D99B60
	public static TMP_Settings.LineBreakingTable get_linebreakingRules() { }

	// RVA: 0xD99A90 Offset: 0xD98E90 VA: 0x180D99A90
	public static TMP_Settings get_instance() { }

	// RVA: 0xD995F0 Offset: 0xD989F0 VA: 0x180D995F0
	public static TMP_Settings LoadDefaultSettings() { }

	// RVA: 0xD99580 Offset: 0xD98980 VA: 0x180D99580
	public static TMP_Settings GetSettings() { }

	// RVA: 0xD99500 Offset: 0xD98900 VA: 0x180D99500
	public static TMP_FontAsset GetFontAsset() { }

	// RVA: 0xD996D0 Offset: 0xD98AD0 VA: 0x180D996D0
	public static void LoadLinebreakingRules() { }

	// RVA: 0xD99420 Offset: 0xD98820 VA: 0x180D99420
	private static Dictionary<int, char> GetCharacters(TextAsset file) { }

	// RVA: 0xD99810 Offset: 0xD98C10 VA: 0x180D99810
	public void .ctor() { }

}

public class TMP_Settings.LineBreakingTable // TypeDefIndex: 6821
{	// Fields
	public Dictionary<int, char> leadingCharacters; // 0x10
	public Dictionary<int, char> followingCharacters; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class TMP_SubMesh : MonoBehaviour // TypeDefIndex: 6823
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	// Properties
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

	// Methods

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public TMP_FontAsset get_fontAsset() { }

	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	public void set_fontAsset(TMP_FontAsset value) { }

	// RVA: 0xD9C490 Offset: 0xD9B890 VA: 0x180D9C490
	public Material get_material() { }

	// RVA: 0xD9C840 Offset: 0xD9BC40 VA: 0x180D9C840
	public void set_material(Material value) { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public Material get_sharedMaterial() { }

	// RVA: 0xD9C2F0 Offset: 0xD9B6F0 VA: 0x180D9C2F0
	public void set_sharedMaterial(Material value) { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public Material get_fallbackMaterial() { }

	// RVA: 0xD9C6C0 Offset: 0xD9BAC0 VA: 0x180D9C6C0
	public void set_fallbackMaterial(Material value) { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public Material get_fallbackSourceMaterial() { }

	// RVA: 0x5089D0 Offset: 0x507DD0 VA: 0x1805089D0
	public void set_fallbackSourceMaterial(Material value) { }

	// RVA: 0x7E53F0 Offset: 0x7E47F0 VA: 0x1807E53F0
	public bool get_isDefaultMaterial() { }

	// RVA: 0x80DB50 Offset: 0x80CF50 VA: 0x18080DB50
	public void set_isDefaultMaterial(bool value) { }

	// RVA: 0x7E53E0 Offset: 0x7E47E0 VA: 0x1807E53E0
	public float get_padding() { }

	// RVA: 0x84F290 Offset: 0x84E690 VA: 0x18084F290
	public void set_padding(float value) { }

	// RVA: 0xD9C620 Offset: 0xD9BA20 VA: 0x180D9C620
	public Renderer get_renderer() { }

	// RVA: 0xD9C4A0 Offset: 0xD9B8A0 VA: 0x180D9C4A0
	public MeshFilter get_meshFilter() { }

	// RVA: 0xD9C540 Offset: 0xD9B940 VA: 0x180D9C540
	public Mesh get_mesh() { }

	// RVA: 0x4CC360 Offset: 0x4CB760 VA: 0x1804CC360
	public void set_mesh(Mesh value) { }

	// RVA: 0xD9BFE0 Offset: 0xD9B3E0 VA: 0x180D9BFE0
	private void OnEnable() { }

	// RVA: 0xD9BF10 Offset: 0xD9B310 VA: 0x180D9BF10
	private void OnDisable() { }

	// RVA: 0xD9BDF0 Offset: 0xD9B1F0 VA: 0x180D9BDF0
	private void OnDestroy() { }

	// RVA: 0xD9B5D0 Offset: 0xD9A9D0 VA: 0x180D9B5D0
	public static TMP_SubMesh AddSubTextObject(TextMeshPro textComponent, MaterialReference materialReference) { }

	// RVA: 0xD9BA60 Offset: 0xD9AE60 VA: 0x180D9BA60
	public void DestroySelf() { }

	// RVA: 0xD9BAD0 Offset: 0xD9AED0 VA: 0x180D9BAD0
	private Material GetMaterial(Material mat) { }

	// RVA: 0xD9B9B0 Offset: 0xD9ADB0 VA: 0x180D9B9B0
	private Material CreateMaterialInstance(Material source) { }

	// RVA: 0xD9BD40 Offset: 0xD9B140 VA: 0x180D9BD40
	private Material GetSharedMaterial() { }

	// RVA: 0xD9C2F0 Offset: 0xD9B6F0 VA: 0x180D9C2F0
	private void SetSharedMaterial(Material mat) { }

	// RVA: 0xD9BCB0 Offset: 0xD9B0B0 VA: 0x180D9BCB0
	public float GetPaddingForMaterial() { }

	// RVA: 0xD9C400 Offset: 0xD9B800 VA: 0x180D9C400
	public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold) { }

	// RVA: 0xD9C330 Offset: 0xD9B730 VA: 0x180D9C330
	public void SetVerticesDirty() { }

	// RVA: 0xD9C1E0 Offset: 0xD9B5E0 VA: 0x180D9C1E0
	public void SetMaterialDirty() { }

	// RVA: 0xD9C1E0 Offset: 0xD9B5E0 VA: 0x180D9C1E0
	protected void UpdateMaterial() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class TMP_SubMeshUI : MaskableGraphic, IClippable, IMaskable, IMaterialModifier // TypeDefIndex: 6824
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	// Properties
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

	// Methods

	// RVA: 0xD9B0A0 Offset: 0xD9A4A0 VA: 0x180D9B0A0
	public TMP_FontAsset get_fontAsset() { }

	// RVA: 0xD9B480 Offset: 0xD9A880 VA: 0x180D9B480
	public void set_fontAsset(TMP_FontAsset value) { }

	// RVA: 0xD9B0C0 Offset: 0xD9A4C0 VA: 0x180D9B0C0 Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0xD9B200 Offset: 0xD9A600 VA: 0x180D9B200 Slot: 32
	public override Material get_material() { }

	// RVA: 0xD9B4A0 Offset: 0xD9A8A0 VA: 0x180D9B4A0 Slot: 33
	public override void set_material(Material value) { }

	// RVA: 0xD9A430 Offset: 0xD99830 VA: 0x180D9A430
	public Material get_sharedMaterial() { }

	// RVA: 0xD9AC70 Offset: 0xD9A070 VA: 0x180D9AC70
	public void set_sharedMaterial(Material value) { }

	// RVA: 0x4EBD40 Offset: 0x4EB140 VA: 0x1804EBD40
	public Material get_fallbackMaterial() { }

	// RVA: 0xD9B2E0 Offset: 0xD9A6E0 VA: 0x180D9B2E0
	public void set_fallbackMaterial(Material value) { }

	// RVA: 0x94E830 Offset: 0x94DC30 VA: 0x18094E830
	public Material get_fallbackSourceMaterial() { }

	// RVA: 0x94E8B0 Offset: 0x94DCB0 VA: 0x18094E8B0
	public void set_fallbackSourceMaterial(Material value) { }

	// RVA: 0xD9B190 Offset: 0xD9A590 VA: 0x180D9B190 Slot: 34
	public override Material get_materialForRendering() { }

	// RVA: 0xD9B0B0 Offset: 0xD9A4B0 VA: 0x180D9B0B0
	public bool get_isDefaultMaterial() { }

	// RVA: 0xD9B490 Offset: 0xD9A890 VA: 0x180D9B490
	public void set_isDefaultMaterial(bool value) { }

	// RVA: 0xD9B2D0 Offset: 0xD9A6D0 VA: 0x180D9B2D0
	public float get_padding() { }

	// RVA: 0xD9B5C0 Offset: 0xD9A9C0 VA: 0x180D9B5C0
	public void set_padding(float value) { }

	// RVA: 0xD9B000 Offset: 0xD9A400 VA: 0x180D9B000
	public CanvasRenderer get_canvasRenderer() { }

	// RVA: 0xD9B210 Offset: 0xD9A610 VA: 0x180D9B210
	public Mesh get_mesh() { }

	// RVA: 0xA09800 Offset: 0xA08C00 VA: 0x180A09800
	public void set_mesh(Mesh value) { }

	// RVA: 0xD99DD0 Offset: 0xD991D0 VA: 0x180D99DD0
	public static TMP_SubMeshUI AddSubTextObject(TextMeshProUGUI textComponent, MaterialReference materialReference) { }

	// RVA: 0xD9AA70 Offset: 0xD99E70 VA: 0x180D9AA70 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0xD9A920 Offset: 0xD99D20 VA: 0x180D9A920 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0xD9A780 Offset: 0xD99B80 VA: 0x180D9A780 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0xD9AAC0 Offset: 0xD99EC0 VA: 0x180D9AAC0 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0xD9A440 Offset: 0xD99840 VA: 0x180D9A440 Slot: 57
	public override Material GetModifiedMaterial(Material baseMaterial) { }

	// RVA: 0xD9A5A0 Offset: 0xD999A0 VA: 0x180D9A5A0
	public float GetPaddingForMaterial() { }

	// RVA: 0xD9A640 Offset: 0xD99A40 VA: 0x180D9A640
	public float GetPaddingForMaterial(Material mat) { }

	// RVA: 0xD9AF70 Offset: 0xD9A370 VA: 0x180D9AF70
	public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 26
	public override void SetAllDirty() { }

	// RVA: 0xD9ACE0 Offset: 0xD9A0E0 VA: 0x180D9ACE0 Slot: 28
	public override void SetVerticesDirty() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 27
	public override void SetLayoutDirty() { }

	// RVA: 0xD9ABB0 Offset: 0xD99FB0 VA: 0x180D9ABB0 Slot: 29
	public override void SetMaterialDirty() { }

	// RVA: 0xD9ABF0 Offset: 0xD99FF0 VA: 0x180D9ABF0
	public void SetPivotDirty() { }

	// RVA: 0xD9A230 Offset: 0xD99630 VA: 0x180D9A230 Slot: 58
	public override void Cull(Rect clipRect, bool validRect) { }

	// RVA: 0xD9ADC0 Offset: 0xD9A1C0 VA: 0x180D9ADC0 Slot: 41
	protected override void UpdateGeometry() { }

	// RVA: 0xD9AB20 Offset: 0xD99F20 VA: 0x180D9AB20 Slot: 37
	public override void Rebuild(CanvasUpdate update) { }

	// RVA: 0xD9AB90 Offset: 0xD99F90 VA: 0x180D9AB90
	public void RefreshMaterial() { }

	// RVA: 0xD9AE10 Offset: 0xD9A210 VA: 0x180D9AE10 Slot: 40
	protected override void UpdateMaterial() { }

	// RVA: 0xD9AB60 Offset: 0xD99F60 VA: 0x180D9AB60 Slot: 61
	public override void RecalculateClipping() { }

	// RVA: 0xD9AB70 Offset: 0xD99F70 VA: 0x180D9AB70 Slot: 62
	public override void RecalculateMasking() { }

	// RVA: 0xD9A430 Offset: 0xD99830 VA: 0x180D9A430
	private Material GetMaterial() { }

	// RVA: 0xD9A270 Offset: 0xD99670 VA: 0x180D9A270
	private Material GetMaterial(Material mat) { }

	// RVA: 0xD9A180 Offset: 0xD99580 VA: 0x180D9A180
	private Material CreateMaterialInstance(Material source) { }

	// RVA: 0xD9A6D0 Offset: 0xD99AD0 VA: 0x180D9A6D0
	private Material GetSharedMaterial() { }

	// RVA: 0xD9AC70 Offset: 0xD9A070 VA: 0x180D9AC70
	private void SetSharedMaterial(Material mat) { }

	// RVA: 0xD99410 Offset: 0xD98810 VA: 0x180D99410
	public void .ctor() { }

}

public enum TMP_TextElementType // TypeDefIndex: 6830
{	// Fields
	public int value__; // 0x0
	public const TMP_TextElementType Character = 0;
	public const TMP_TextElementType Unused = 1;

}

public abstract class TMP_Text : MaskableGraphic // TypeDefIndex: 6837
{	// Fields
	[SerializeField] // RVA: 0xD0640 Offset: 0xCFA40 VA: 0x1800D0640
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

	// Properties
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

	// Methods

	// RVA: 0xD9B0A0 Offset: 0xD9A4A0 VA: 0x180D9B0A0
	public string get_text() { }

	// RVA: 0xDB0770 Offset: 0xDAFB70 VA: 0x180DB0770
	public void set_text(string value) { }

	// RVA: 0xDAEC30 Offset: 0xDAE030 VA: 0x180DAEC30
	public bool get_isRightToLeftText() { }

	// RVA: 0xDAFFA0 Offset: 0xDAF3A0 VA: 0x180DAFFA0
	public void set_isRightToLeftText(bool value) { }

	// RVA: 0xD9A430 Offset: 0xD99830 VA: 0x180D9A430
	public TMP_FontAsset get_font() { }

	// RVA: 0xDAFD10 Offset: 0xDAF110 VA: 0x180DAFD10
	public void set_font(TMP_FontAsset value) { }

	// RVA: 0xC53210 Offset: 0xC52610 VA: 0x180C53210 Slot: 63
	public virtual Material get_fontSharedMaterial() { }

	// RVA: 0xDAFA70 Offset: 0xDAEE70 VA: 0x180DAFA70 Slot: 64
	public virtual void set_fontSharedMaterial(Material value) { }

	// RVA: 0xDAEB60 Offset: 0xDADF60 VA: 0x180DAEB60 Slot: 65
	public virtual Material[] get_fontSharedMaterials() { }

	// RVA: 0xDAFA10 Offset: 0xDAEE10 VA: 0x180DAFA10 Slot: 66
	public virtual void set_fontSharedMaterials(Material[] value) { }

	// RVA: 0xDAEB10 Offset: 0xDADF10 VA: 0x180DAEB10
	public Material get_fontMaterial() { }

	// RVA: 0xDAF8F0 Offset: 0xDAECF0 VA: 0x180DAF8F0
	public void set_fontMaterial(Material value) { }

	// RVA: 0xDAEB30 Offset: 0xDADF30 VA: 0x180DAEB30 Slot: 67
	public virtual Material[] get_fontMaterials() { }

	// RVA: 0xDAFA10 Offset: 0xDAEE10 VA: 0x180DAFA10 Slot: 68
	public virtual void set_fontMaterials(Material[] value) { }

	// RVA: 0xDAE970 Offset: 0xDADD70 VA: 0x180DAE970 Slot: 22
	public override Color get_color() { }

	// RVA: 0xDAF600 Offset: 0xDAEA00 VA: 0x180DAF600 Slot: 23
	public override void set_color(Color value) { }

	// RVA: 0xDAE820 Offset: 0xDADC20 VA: 0x180DAE820
	public float get_alpha() { }

	// RVA: 0xDAF470 Offset: 0xDAE870 VA: 0x180DAF470
	public void set_alpha(float value) { }

	// RVA: 0xDAE9B0 Offset: 0xDADDB0 VA: 0x180DAE9B0
	public bool get_enableVertexGradient() { }

	// RVA: 0xDAF760 Offset: 0xDAEB60 VA: 0x180DAF760
	public void set_enableVertexGradient(bool value) { }

	// RVA: 0xDAE940 Offset: 0xDADD40 VA: 0x180DAE940
	public VertexGradient get_colorGradient() { }

	// RVA: 0xDAF5B0 Offset: 0xDAE9B0 VA: 0x180DAF5B0
	public void set_colorGradient(VertexGradient value) { }

	// RVA: 0xDAE930 Offset: 0xDADD30 VA: 0x180DAE930
	public TMP_ColorGradient get_colorGradientPreset() { }

	// RVA: 0xDAF570 Offset: 0xDAE970 VA: 0x180DAF570
	public void set_colorGradientPreset(TMP_ColorGradient value) { }

	// RVA: 0xDAEF80 Offset: 0xDAE380 VA: 0x180DAEF80
	public bool get_overrideColorTags() { }

	// RVA: 0xDB0630 Offset: 0xDAFA30 VA: 0x180DB0630
	public void set_overrideColorTags(bool value) { }

	// RVA: 0xDAE9E0 Offset: 0xDADDE0 VA: 0x180DAE9E0
	public Color32 get_faceColor() { }

	// RVA: 0xDAF840 Offset: 0xDAEC40 VA: 0x180DAF840
	public void set_faceColor(Color32 value) { }

	// RVA: 0xDAEDA0 Offset: 0xDAE1A0 VA: 0x180DAEDA0
	public Color32 get_outlineColor() { }

	// RVA: 0xDB0500 Offset: 0xDAF900 VA: 0x180DB0500
	public void set_outlineColor(Color32 value) { }

	// RVA: 0xDAEE90 Offset: 0xDAE290 VA: 0x180DAEE90
	public float get_outlineWidth() { }

	// RVA: 0xDB0570 Offset: 0xDAF970 VA: 0x180DB0570
	public void set_outlineWidth(float value) { }

	// RVA: 0xDAEB90 Offset: 0xDADF90 VA: 0x180DAEB90
	public float get_fontSize() { }

	// RVA: 0xDAFBE0 Offset: 0xDAEFE0 VA: 0x180DAFBE0
	public void set_fontSize(float value) { }

	// RVA: 0xDAEB50 Offset: 0xDADF50 VA: 0x180DAEB50
	public float get_fontScale() { }

	// RVA: 0xDAEBB0 Offset: 0xDADFB0 VA: 0x180DAEBB0
	public FontWeight get_fontWeight() { }

	// RVA: 0xDAFCB0 Offset: 0xDAF0B0 VA: 0x180DAFCB0
	public void set_fontWeight(FontWeight value) { }

	// RVA: 0xDAEFB0 Offset: 0xDAE3B0 VA: 0x180DAEFB0
	public float get_pixelsPerUnit() { }

	// RVA: 0xDAE980 Offset: 0xDADD80 VA: 0x180DAE980
	public bool get_enableAutoSizing() { }

	// RVA: 0xDAF670 Offset: 0xDAEA70 VA: 0x180DAF670
	public void set_enableAutoSizing(bool value) { }

	// RVA: 0xDAEB80 Offset: 0xDADF80 VA: 0x180DAEB80
	public float get_fontSizeMin() { }

	// RVA: 0xDAFB90 Offset: 0xDAEF90 VA: 0x180DAFB90
	public void set_fontSizeMin(float value) { }

	// RVA: 0x8A2FB0 Offset: 0x8A23B0 VA: 0x1808A2FB0
	public float get_fontSizeMax() { }

	// RVA: 0xDAFB40 Offset: 0xDAEF40 VA: 0x180DAFB40
	public void set_fontSizeMax(float value) { }

	// RVA: 0xDAEBA0 Offset: 0xDADFA0 VA: 0x180DAEBA0
	public FontStyles get_fontStyle() { }

	// RVA: 0xDAFC50 Offset: 0xDAF050 VA: 0x180DAFC50
	public void set_fontStyle(FontStyles value) { }

	// RVA: 0xDAEC60 Offset: 0xDAE060 VA: 0x180DAEC60
	public bool get_isUsingBold() { }

	// RVA: 0xDAE810 Offset: 0xDADC10 VA: 0x180DAE810
	public TextAlignmentOptions get_alignment() { }

	// RVA: 0xDAF440 Offset: 0xDAE840 VA: 0x180DAF440
	public void set_alignment(TextAlignmentOptions value) { }

	// RVA: 0xDAE910 Offset: 0xDADD10 VA: 0x180DAE910
	public float get_characterSpacing() { }

	// RVA: 0xDAF4B0 Offset: 0xDAE8B0 VA: 0x180DAF4B0
	public void set_characterSpacing(float value) { }

	// RVA: 0xDAF420 Offset: 0xDAE820 VA: 0x180DAF420
	public float get_wordSpacing() { }

	// RVA: 0xDB0890 Offset: 0xDAFC90 VA: 0x180DB0890
	public void set_wordSpacing(float value) { }

	// RVA: 0xDAED50 Offset: 0xDAE150 VA: 0x180DAED50
	public float get_lineSpacing() { }

	// RVA: 0xDB00E0 Offset: 0xDAF4E0 VA: 0x180DB00E0
	public void set_lineSpacing(float value) { }

	// RVA: 0xDAED40 Offset: 0xDAE140 VA: 0x180DAED40
	public float get_lineSpacingAdjustment() { }

	// RVA: 0xDB0080 Offset: 0xDAF480 VA: 0x180DB0080
	public void set_lineSpacingAdjustment(float value) { }

	// RVA: 0xDAEFA0 Offset: 0xDAE3A0 VA: 0x180DAEFA0
	public float get_paragraphSpacing() { }

	// RVA: 0xDB0690 Offset: 0xDAFA90 VA: 0x180DB0690
	public void set_paragraphSpacing(float value) { }

	// RVA: 0xDAE920 Offset: 0xDADD20 VA: 0x180DAE920
	public float get_characterWidthAdjustment() { }

	// RVA: 0xDAF510 Offset: 0xDAE910 VA: 0x180DAF510
	public void set_characterWidthAdjustment(float value) { }

	// RVA: 0xDAE9C0 Offset: 0xDADDC0 VA: 0x180DAE9C0
	public bool get_enableWordWrapping() { }

	// RVA: 0xDAF790 Offset: 0xDAEB90 VA: 0x180DAF790
	public void set_enableWordWrapping(bool value) { }

	// RVA: 0xDAF430 Offset: 0xDAE830 VA: 0x180DAF430
	public float get_wordWrappingRatios() { }

	// RVA: 0xDB08F0 Offset: 0xDAFCF0 VA: 0x180DB08F0
	public void set_wordWrappingRatios(float value) { }

	// RVA: 0xDAEF70 Offset: 0xDAE370 VA: 0x180DAEF70
	public TextOverflowModes get_overflowMode() { }

	// RVA: 0xDB05D0 Offset: 0xDAF9D0 VA: 0x180DB05D0
	public void set_overflowMode(TextOverflowModes value) { }

	// RVA: 0xDAEC40 Offset: 0xDAE040 VA: 0x180DAEC40
	public bool get_isTextOverflowing() { }

	// RVA: 0xDAEAD0 Offset: 0xDADED0 VA: 0x180DAEAD0
	public int get_firstOverflowCharacterIndex() { }

	// RVA: 0x9800E0 Offset: 0x97F4E0 VA: 0x1809800E0
	public TMP_Text get_linkedTextComponent() { }

	// RVA: 0xDB0140 Offset: 0xDAF540 VA: 0x180DB0140
	public void set_linkedTextComponent(TMP_Text value) { }

	// RVA: 0xDAEC00 Offset: 0xDAE000 VA: 0x180DAEC00
	public bool get_isLinkedTextComponent() { }

	// RVA: 0xDAFEC0 Offset: 0xDAF2C0 VA: 0x180DAFEC0
	public void set_isLinkedTextComponent(bool value) { }

	// RVA: 0xDAEC50 Offset: 0xDAE050 VA: 0x180DAEC50
	public bool get_isTextTruncated() { }

	// RVA: 0xDAE9A0 Offset: 0xDADDA0 VA: 0x180DAE9A0
	public bool get_enableKerning() { }

	// RVA: 0xDAF700 Offset: 0xDAEB00 VA: 0x180DAF700
	public void set_enableKerning(bool value) { }

	// RVA: 0xDAE9D0 Offset: 0xDADDD0 VA: 0x180DAE9D0
	public bool get_extraPadding() { }

	// RVA: 0xDAF7F0 Offset: 0xDAEBF0 VA: 0x180DAF7F0
	public void set_extraPadding(bool value) { }

	// RVA: 0xDAF2E0 Offset: 0xDAE6E0 VA: 0x180DAF2E0
	public bool get_richText() { }

	// RVA: 0xDB0710 Offset: 0xDAFB10 VA: 0x180DB0710
	public void set_richText(bool value) { }

	// RVA: 0xDAEC20 Offset: 0xDAE020 VA: 0x180DAEC20
	public bool get_isOverlay() { }

	// RVA: 0xDAFF50 Offset: 0xDAF350 VA: 0x180DAFF50
	public void set_isOverlay(bool value) { }

	// RVA: 0xDAEC10 Offset: 0xDAE010 VA: 0x180DAEC10
	public bool get_isOrthographic() { }

	// RVA: 0xDAFF20 Offset: 0xDAF320 VA: 0x180DAFF20
	public void set_isOrthographic(bool value) { }

	// RVA: 0xDAE990 Offset: 0xDADD90 VA: 0x180DAE990
	public bool get_enableCulling() { }

	// RVA: 0xDAF6C0 Offset: 0xDAEAC0 VA: 0x180DAF6C0
	public void set_enableCulling(bool value) { }

	// RVA: 0xDAEBE0 Offset: 0xDADFE0 VA: 0x180DAEBE0
	public bool get_ignoreRectMaskCulling() { }

	// RVA: 0xDAFE80 Offset: 0xDAF280 VA: 0x180DAFE80
	public void set_ignoreRectMaskCulling(bool value) { }

	// RVA: 0xDAEBF0 Offset: 0xDADFF0 VA: 0x180DAEBF0
	public bool get_ignoreVisibility() { }

	// RVA: 0xDAFEA0 Offset: 0xDAF2A0 VA: 0x180DAFEA0
	public void set_ignoreVisibility(bool value) { }

	// RVA: 0x836000 Offset: 0x835400 VA: 0x180836000
	public TextureMappingOptions get_horizontalMapping() { }

	// RVA: 0xDAFE50 Offset: 0xDAF250 VA: 0x180DAFE50
	public void set_horizontalMapping(TextureMappingOptions value) { }

	// RVA: 0x835FF0 Offset: 0x8353F0 VA: 0x180835FF0
	public TextureMappingOptions get_verticalMapping() { }

	// RVA: 0xDB0860 Offset: 0xDAFC60 VA: 0x180DB0860
	public void set_verticalMapping(TextureMappingOptions value) { }

	// RVA: 0xDAED60 Offset: 0xDAE160 VA: 0x180DAED60
	public float get_mappingUvLineOffset() { }

	// RVA: 0xDB0380 Offset: 0xDAF780 VA: 0x180DB0380
	public void set_mappingUvLineOffset(float value) { }

	// RVA: 0xAC09B0 Offset: 0xABFDB0 VA: 0x180AC09B0
	public TextRenderFlags get_renderMode() { }

	// RVA: 0xDB06F0 Offset: 0xDAFAF0 VA: 0x180DB06F0
	public void set_renderMode(TextRenderFlags value) { }

	// RVA: 0xDAEBC0 Offset: 0xDADFC0 VA: 0x180DAEBC0
	public VertexSortingOrder get_geometrySortingOrder() { }

	// RVA: 0xDAFE00 Offset: 0xDAF200 VA: 0x180DAFE00
	public void set_geometrySortingOrder(VertexSortingOrder value) { }

	// RVA: 0xDAF410 Offset: 0xDAE810 VA: 0x180DAF410
	public bool get_vertexBufferAutoSizeReduction() { }

	// RVA: 0xDB0840 Offset: 0xDAFC40 VA: 0x180DB0840
	public void set_vertexBufferAutoSizeReduction(bool value) { }

	// RVA: 0xDAEAE0 Offset: 0xDADEE0 VA: 0x180DAEAE0
	public int get_firstVisibleCharacter() { }

	// RVA: 0xDAF8C0 Offset: 0xDAECC0 VA: 0x180DAF8C0
	public void set_firstVisibleCharacter(int value) { }

	// RVA: 0xDAED80 Offset: 0xDAE180 VA: 0x180DAED80
	public int get_maxVisibleCharacters() { }

	// RVA: 0xDB0470 Offset: 0xDAF870 VA: 0x180DB0470
	public void set_maxVisibleCharacters(int value) { }

	// RVA: 0xA29AB0 Offset: 0xA28EB0 VA: 0x180A29AB0
	public int get_maxVisibleWords() { }

	// RVA: 0xDB04D0 Offset: 0xDAF8D0 VA: 0x180DB04D0
	public void set_maxVisibleWords(int value) { }

	// RVA: 0xDAED90 Offset: 0xDAE190 VA: 0x180DAED90
	public int get_maxVisibleLines() { }

	// RVA: 0xDB04A0 Offset: 0xDAF8A0 VA: 0x180DB04A0
	public void set_maxVisibleLines(int value) { }

	// RVA: 0xDAF400 Offset: 0xDAE800 VA: 0x180DAF400
	public bool get_useMaxVisibleDescender() { }

	// RVA: 0xDB0810 Offset: 0xDAFC10 VA: 0x180DB0810
	public void set_useMaxVisibleDescender(bool value) { }

	// RVA: 0xDAEF90 Offset: 0xDAE390 VA: 0x180DAEF90
	public int get_pageToDisplay() { }

	// RVA: 0xDB0660 Offset: 0xDAFA60 VA: 0x180DB0660
	public void set_pageToDisplay(int value) { }

	// RVA: 0xDAED70 Offset: 0xDAE170 VA: 0x180DAED70 Slot: 69
	public virtual Vector4 get_margin() { }

	// RVA: 0xDB03B0 Offset: 0xDAF7B0 VA: 0x180DB03B0 Slot: 70
	public virtual void set_margin(Vector4 value) { }

	// RVA: 0xDAF350 Offset: 0xDAE750 VA: 0x180DAF350
	public TMP_TextInfo get_textInfo() { }

	// RVA: 0xDAEBD0 Offset: 0xDADFD0 VA: 0x180DAEBD0
	public bool get_havePropertiesChanged() { }

	// RVA: 0xDAFE20 Offset: 0xDAF220 VA: 0x180DAFE20
	public void set_havePropertiesChanged(bool value) { }

	// RVA: 0xDAEC70 Offset: 0xDAE070 VA: 0x180DAEC70
	public bool get_isUsingLegacyAnimationComponent() { }

	// RVA: 0xDB0000 Offset: 0xDAF400 VA: 0x180DB0000
	public void set_isUsingLegacyAnimationComponent(bool value) { }

	// RVA: 0xDAF360 Offset: 0xDAE760 VA: 0x180DAF360
	public Transform get_transform() { }

	// RVA: 0xDAF240 Offset: 0xDAE640 VA: 0x180DAF240
	public RectTransform get_rectTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xDAE830 Offset: 0xDADC30 VA: 0x180DAE830 Slot: 71
	public virtual bool get_autoSizeTextContainer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xDAF4A0 Offset: 0xDAE8A0 VA: 0x180DAF4A0 Slot: 72
	public virtual void set_autoSizeTextContainer(bool value) { }

	// RVA: 0x79B690 Offset: 0x79AA90 VA: 0x18079B690 Slot: 73
	public virtual Mesh get_mesh() { }

	// RVA: 0xDAEC80 Offset: 0xDAE080 VA: 0x180DAEC80
	public bool get_isVolumetricText() { }

	// RVA: 0xDB0010 Offset: 0xDAF410 VA: 0x180DB0010
	public void set_isVolumetricText(bool value) { }

	// RVA: 0xDAE840 Offset: 0xDADC40 VA: 0x180DAE840
	public Bounds get_bounds() { }

	// RVA: 0xDAF2F0 Offset: 0xDAE6F0 VA: 0x180DAF2F0
	public Bounds get_textBounds() { }

	// RVA: 0xDAEAF0 Offset: 0xDADEF0 VA: 0x180DAEAF0 Slot: 74
	public float get_flexibleHeight() { }

	// RVA: 0xDAEB00 Offset: 0xDADF00 VA: 0x180DAEB00 Slot: 75
	public float get_flexibleWidth() { }

	// RVA: 0x749680 Offset: 0x748A80 VA: 0x180749680 Slot: 76
	public float get_minWidth() { }

	// RVA: 0x7499A0 Offset: 0x748DA0 VA: 0x1807499A0 Slot: 77
	public float get_minHeight() { }

	// RVA: 0x7497D0 Offset: 0x748BD0 VA: 0x1807497D0
	public float get_maxWidth() { }

	// RVA: 0x749AE0 Offset: 0x748EE0 VA: 0x180749AE0
	public float get_maxHeight() { }

	// RVA: 0xDAEC90 Offset: 0xDAE090 VA: 0x180DAEC90
	protected LayoutElement get_layoutElement() { }

	// RVA: 0xDAF200 Offset: 0xDAE600 VA: 0x180DAF200 Slot: 78
	public virtual float get_preferredWidth() { }

	// RVA: 0xDAF1C0 Offset: 0xDAE5C0 VA: 0x180DAF1C0 Slot: 79
	public virtual float get_preferredHeight() { }

	// RVA: 0xDA3EF0 Offset: 0xDA32F0 VA: 0x180DA3EF0 Slot: 80
	public virtual float get_renderedWidth() { }

	// RVA: 0xDA3D60 Offset: 0xDA3160 VA: 0x180DA3D60 Slot: 81
	public virtual float get_renderedHeight() { }

	// RVA: 0xDAED30 Offset: 0xDAE130 VA: 0x180DAED30 Slot: 82
	public int get_layoutPriority() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 83
	protected virtual void LoadFontAsset() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 84
	protected virtual void SetSharedMaterial(Material mat) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 85
	protected virtual Material GetMaterial(Material mat) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 86
	protected virtual void SetFontBaseMaterial(Material mat) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 87
	protected virtual Material[] GetSharedMaterials() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 88
	protected virtual void SetSharedMaterials(Material[] materials) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 89
	protected virtual Material[] GetMaterials(Material[] mats) { }

	// RVA: 0xD9F0D0 Offset: 0xD9E4D0 VA: 0x180D9F0D0 Slot: 90
	protected virtual Material CreateMaterialInstance(Material source) { }

	// RVA: 0xDA8360 Offset: 0xDA7760 VA: 0x180DA8360
	protected void SetVertexColorGradient(TMP_ColorGradient gradient) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	protected void SetTextSortingOrder(VertexSortingOrder order) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	protected void SetTextSortingOrder(int[] order) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 91
	protected virtual void SetFaceColor(Color32 color) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 92
	protected virtual void SetOutlineColor(Color32 color) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 93
	protected virtual void SetOutlineThickness(float thickness) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 94
	protected virtual void SetShaderDepth() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 95
	protected virtual void SetCulling() { }

	// RVA: 0x581F40 Offset: 0x581340 VA: 0x180581F40 Slot: 96
	protected virtual float GetPaddingForMaterial() { }

	// RVA: 0x581F40 Offset: 0x581340 VA: 0x180581F40 Slot: 97
	protected virtual float GetPaddingForMaterial(Material mat) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 98
	protected virtual Vector3[] GetTextContainerLocalCorners() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 99
	public virtual void ForceMeshUpdate() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 100
	public virtual void ForceMeshUpdate(bool ignoreActiveState) { }

	// RVA: 0xDA8310 Offset: 0xDA7710 VA: 0x180DA8310
	internal void SetTextInternal(string text) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 101
	public virtual void UpdateGeometry(Mesh mesh, int index) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 102
	public virtual void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 103
	public virtual void UpdateVertexData() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 104
	public virtual void SetVertices(Vector3[] vertices) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 105
	public virtual void UpdateMeshPadding() { }

	// RVA: 0xD9F1F0 Offset: 0xD9E5F0 VA: 0x180D9F1F0 Slot: 47
	public override void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0xD9F180 Offset: 0xD9E580 VA: 0x180D9F180 Slot: 49
	public override void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 106
	protected virtual void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 107
	protected virtual void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0xDA6700 Offset: 0xDA5B00 VA: 0x180DA6700
	protected void ParseInputText() { }

	// RVA: 0xDA87A0 Offset: 0xDA7BA0 VA: 0x180DA87A0
	protected void StringToCharArray(string sourceText, ref TMP_Text.UnicodeChar[] charBuffer) { }

	// RVA: 0xDA8410 Offset: 0xDA7810 VA: 0x180DA8410
	protected void StringBuilderToIntArray(StringBuilder sourceText, ref TMP_Text.UnicodeChar[] charBuffer) { }

	// RVA: 0xDA6250 Offset: 0xDA5650 VA: 0x180DA6250
	private bool IsTagName(ref string text, string tag, int index) { }

	// RVA: 0xDA6050 Offset: 0xDA5450 VA: 0x180DA6050
	private bool IsTagName(ref char[] text, string tag, int index) { }

	// RVA: 0xDA6150 Offset: 0xDA5550 VA: 0x180DA6150
	private bool IsTagName(ref int[] text, string tag, int index) { }

	// RVA: 0xDA6340 Offset: 0xDA5740 VA: 0x180DA6340
	private bool IsTagName(ref StringBuilder text, string tag, int index) { }

	// RVA: 0xDA42C0 Offset: 0xDA36C0 VA: 0x180DA42C0
	private int GetTagHashCode(ref string text, int index, out int closeIndex) { }

	// RVA: 0xDA4370 Offset: 0xDA3770 VA: 0x180DA4370
	private int GetTagHashCode(ref char[] text, int index, out int closeIndex) { }

	// RVA: 0xDA43E0 Offset: 0xDA37E0 VA: 0x180DA43E0
	private int GetTagHashCode(ref int[] text, int index, out int closeIndex) { }

	// RVA: 0xDA41F0 Offset: 0xDA35F0 VA: 0x180DA41F0
	private int GetTagHashCode(ref StringBuilder text, int index, out int closeIndex) { }

	// RVA: -1 Offset: -1
	private void ResizeInternalArray<T>(ref T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5EDAA0 Offset: 0x5ECEA0 VA: 0x1805EDAA0
	|-TMP_Text.ResizeInternalArray<object>
	|
	|-RVA: 0x5EDB30 Offset: 0x5ECF30 VA: 0x1805EDB30
	|-TMP_Text.ResizeInternalArray<TMP_Text.UnicodeChar>
	*/

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 108
	protected virtual int SetArraySizes(TMP_Text.UnicodeChar[] chars) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 109
	protected virtual void GenerateTextMesh() { }

	// RVA: 0xDA3860 Offset: 0xDA2C60 VA: 0x180DA3860
	public Vector2 GetPreferredValues() { }

	// RVA: 0xDA3A20 Offset: 0xDA2E20 VA: 0x180DA3A20
	public Vector2 GetPreferredValues(float width, float height) { }

	// RVA: 0xDA3910 Offset: 0xDA2D10 VA: 0x180DA3910
	public Vector2 GetPreferredValues(string text) { }

	// RVA: 0xDA3790 Offset: 0xDA2B90 VA: 0x180DA3790
	public Vector2 GetPreferredValues(string text, float width, float height) { }

	// RVA: 0xDA3B90 Offset: 0xDA2F90 VA: 0x180DA3B90
	protected float GetPreferredWidth() { }

	// RVA: 0xDA3B10 Offset: 0xDA2F10 VA: 0x180DA3B10
	protected float GetPreferredWidth(Vector2 margin) { }

	// RVA: 0xDA3510 Offset: 0xDA2910 VA: 0x180DA3510
	protected float GetPreferredHeight() { }

	// RVA: 0xDA3710 Offset: 0xDA2B10 VA: 0x180DA3710
	protected float GetPreferredHeight(Vector2 margin) { }

	// RVA: 0xDA3E40 Offset: 0xDA3240 VA: 0x180DA3E40
	public Vector2 GetRenderedValues() { }

	// RVA: 0xDA3D80 Offset: 0xDA3180 VA: 0x180DA3D80
	public Vector2 GetRenderedValues(bool onlyVisibleCharacters) { }

	// RVA: 0xDA3EF0 Offset: 0xDA32F0 VA: 0x180DA3EF0
	protected float GetRenderedWidth() { }

	// RVA: 0xDA3F10 Offset: 0xDA3310 VA: 0x180DA3F10
	protected float GetRenderedWidth(bool onlyVisibleCharacters) { }

	// RVA: 0xDA3D60 Offset: 0xDA3160 VA: 0x180DA3D60
	protected float GetRenderedHeight() { }

	// RVA: 0xDA3D40 Offset: 0xDA3140 VA: 0x180DA3D40
	protected float GetRenderedHeight(bool onlyVisibleCharacters) { }

	// RVA: 0xD9C8E0 Offset: 0xD9BCE0 VA: 0x180D9C8E0 Slot: 110
	protected virtual Vector2 CalculatePreferredValues(float defaultFontSize, Vector2 marginSize, bool ignoreTextAutoSizing) { }

	// RVA: 0xDA3350 Offset: 0xDA2750 VA: 0x180DA3350 Slot: 111
	protected virtual Bounds GetCompoundBounds() { }

	// RVA: 0xDA4450 Offset: 0xDA3850 VA: 0x180DA4450
	protected Bounds GetTextBounds() { }

	// RVA: 0xDA4860 Offset: 0xDA3C60 VA: 0x180DA4860
	protected Bounds GetTextBounds(bool onlyVisibleCharacters) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 112
	protected virtual void AdjustLineOffset(int startIndex, int endIndex, float offset) { }

	// RVA: 0xDA67D0 Offset: 0xDA5BD0 VA: 0x180DA67D0
	protected void ResizeLineExtents(int size) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 113
	public virtual TMP_TextInfo GetTextInfo(string text) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 114
	public virtual void ComputeMarginSize() { }

	// RVA: 0xDA7EC0 Offset: 0xDA72C0 VA: 0x180DA7EC0
	protected void SaveWordWrappingState(ref WordWrapState state, int index, int count) { }

	// RVA: 0xDA6A60 Offset: 0xDA5E60 VA: 0x180DA6A60
	protected int RestoreWordWrappingState(ref WordWrapState state) { }

	// RVA: 0xDA6EB0 Offset: 0xDA62B0 VA: 0x180DA6EB0 Slot: 115
	protected virtual void SaveGlyphVertexInfo(float padding, float style_padding, Color32 vertexColor) { }

	// RVA: 0xDA2860 Offset: 0xDA1C60 VA: 0x180DA2860 Slot: 116
	protected virtual void FillCharacterVertexBuffers(int i, int index_X4) { }

	// RVA: 0xDA1350 Offset: 0xDA0750 VA: 0x180DA1350 Slot: 117
	protected virtual void FillCharacterVertexBuffers(int i, int index_X4, bool isVolumetric) { }

	// RVA: 0xD9FA20 Offset: 0xD9EE20 VA: 0x180D9FA20 Slot: 118
	protected virtual void DrawUnderlineMesh(Vector3 start, Vector3 end, ref int index, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor) { }

	// RVA: 0xD9F290 Offset: 0xD9E690 VA: 0x180D9F290 Slot: 119
	protected virtual void DrawTextHighlight(Vector3 start, Vector3 end, ref int index, Color32 highlightColor) { }

	// RVA: 0xDA6430 Offset: 0xDA5830 VA: 0x180DA6430
	protected void LoadDefaultSettings() { }

	// RVA: 0xDA3F30 Offset: 0xDA3330 VA: 0x180DA3F30
	protected void GetSpecialCharacters(TMP_FontAsset fontAsset) { }

	// RVA: 0xDA6750 Offset: 0xDA5B50 VA: 0x180DA6750
	protected void ReplaceTagWithCharacter(int[] chars, int insertionIndex, int tagLength, char c) { }

	// RVA: 0xDA3360 Offset: 0xDA2760 VA: 0x180DA3360
	protected TMP_FontAsset GetFontAssetForWeight(int fontWeight) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 120
	protected virtual void SetActiveSubMeshes(bool state) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 121
	protected virtual void ClearSubMeshObjects() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 122
	public virtual void ClearMesh() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 123
	public virtual void ClearMesh(bool uploadGeometry) { }

	// RVA: 0xDA3420 Offset: 0xDA2820 VA: 0x180DA3420 Slot: 124
	public virtual string GetParsedText() { }

	// RVA: 0xDA66C0 Offset: 0xDA5AC0 VA: 0x180DA66C0
	protected Vector2 PackUV(float x, float y, float scale) { }

	// RVA: 0xDA6680 Offset: 0xDA5A80 VA: 0x180DA6680
	protected float PackUV(float x, float y) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 125
	internal virtual void InternalUpdate() { }

	// RVA: 0xDA5F40 Offset: 0xDA5340 VA: 0x180DA5F40
	protected int HexToInt(char hex) { }

	// RVA: 0xDA4D00 Offset: 0xDA4100 VA: 0x180DA4D00
	protected int GetUTF16(string text, int i) { }

	// RVA: 0xDA4DE0 Offset: 0xDA41E0 VA: 0x180DA4DE0
	protected int GetUTF16(StringBuilder text, int i) { }

	// RVA: 0xDA5050 Offset: 0xDA4450 VA: 0x180DA5050
	protected int GetUTF32(string text, int i) { }

	// RVA: 0xDA4EC0 Offset: 0xDA42C0 VA: 0x180DA4EC0
	protected int GetUTF32(StringBuilder text, int i) { }

	// RVA: 0xDA51E0 Offset: 0xDA45E0 VA: 0x180DA51E0
	protected Color32 HexCharsToColor(char[] hexChars, int tagCount) { }

	// RVA: 0xDA5B50 Offset: 0xDA4F50 VA: 0x180DA5B50
	protected Color32 HexCharsToColor(char[] hexChars, int startIndex, int length) { }

	// RVA: 0xDA3270 Offset: 0xDA2670 VA: 0x180DA3270
	private int GetAttributeParameters(char[] chars, int startIndex, int length, ref float[] parameters) { }

	// RVA: 0xD9F0A0 Offset: 0xD9E4A0 VA: 0x180D9F0A0
	protected float ConvertToFloat(char[] chars, int startIndex, int length) { }

	// RVA: 0xD9EEF0 Offset: 0xD9E2F0 VA: 0x180D9EEF0
	protected float ConvertToFloat(char[] chars, int startIndex, int length, out int lastIndex) { }

	// RVA: 0xDA8C80 Offset: 0xDA8080 VA: 0x180DA8C80
	protected bool ValidateHtmlTag(TMP_Text.UnicodeChar[] chars, int startIndex, out int endIndex) { }

	// RVA: 0xDADFE0 Offset: 0xDAD3E0 VA: 0x180DADFE0
	protected void .ctor() { }

	// RVA: 0xDADEA0 Offset: 0xDAD2A0 VA: 0x180DADEA0
	private static void .cctor() { }

}

public class TMP_TextElement // TypeDefIndex: 6840
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected TextElementType m_ElementType; // 0x10
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private uint m_Unicode; // 0x14
	private Glyph m_Glyph; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private uint m_GlyphIndex; // 0x20
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_Scale; // 0x24

	// Properties
	public TextElementType elementType { get; }
	public uint unicode { get; set; }
	public Glyph glyph { get; set; }
	public uint glyphIndex { get; set; }
	public float scale { get; set; }

	// Methods

	// RVA: 0x497E20 Offset: 0x497220 VA: 0x180497E20
	public TextElementType get_elementType() { }

	// RVA: 0x596230 Offset: 0x595630 VA: 0x180596230
	public uint get_unicode() { }

	// RVA: 0x596250 Offset: 0x595650 VA: 0x180596250
	public void set_unicode(uint value) { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public Glyph get_glyph() { }

	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	public void set_glyph(Glyph value) { }

	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170
	public uint get_glyphIndex() { }

	// RVA: 0x69CC40 Offset: 0x69C040 VA: 0x18069CC40
	public void set_glyphIndex(uint value) { }

	// RVA: 0x7E8600 Offset: 0x7E7A00 VA: 0x1807E8600
	public float get_scale() { }

	// RVA: 0x49D420 Offset: 0x49C820 VA: 0x18049D420
	public void set_scale(float value) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class TMP_TextElement_Legacy // TypeDefIndex: 6841
{	// Fields
	public int id; // 0x10
	public float x; // 0x14
	public float y; // 0x18
	public float width; // 0x1C
	public float height; // 0x20
	public float xOffset; // 0x24
	public float yOffset; // 0x28
	public float xAdvance; // 0x2C
	public float scale; // 0x30

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class TMP_TextInfo // TypeDefIndex: 6842
{	// Fields
	private static Vector2 k_InfinityVectorPositive; // 0x0
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

	// Methods

	// RVA: 0x11514D0 Offset: 0x11508D0 VA: 0x1811514D0
	public void .ctor() { }

	// RVA: 0x1151360 Offset: 0x1150760 VA: 0x181151360
	public void .ctor(TMP_Text textComponent) { }

	// RVA: 0x1150C20 Offset: 0x1150020 VA: 0x181150C20
	public void Clear() { }

	// RVA: 0x1150B10 Offset: 0x114FF10 VA: 0x181150B10
	public void ClearMeshInfo(bool updateMesh) { }

	// RVA: 0x11507B0 Offset: 0x114FBB0 VA: 0x1811507B0
	public void ClearAllMeshInfo() { }

	// RVA: 0x1151220 Offset: 0x1150620 VA: 0x181151220
	public void ResetVertexLayout(bool isVolumetric) { }

	// RVA: 0x1150BA0 Offset: 0x114FFA0 VA: 0x181150BA0
	public void ClearUnusedVertices(MaterialReference[] materials) { }

	// RVA: 0x1150830 Offset: 0x114FC30 VA: 0x181150830
	public void ClearLineInfo() { }

	// RVA: 0x1150CA0 Offset: 0x11500A0 VA: 0x181150CA0
	public TMP_MeshInfo[] CopyMeshInfoVertexData() { }

	// RVA: -1 Offset: -1
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

	// RVA: -1 Offset: -1
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

	// RVA: 0x11512B0 Offset: 0x11506B0 VA: 0x1811512B0
	private static void .cctor() { }

}

public class TMP_TextParsingUtilities // TypeDefIndex: 6843
{	// Fields
	private static readonly TMP_TextParsingUtilities s_Instance; // 0x2B40
	private const string k_LookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-";
	private const string k_LookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-";

	// Properties
	public static TMP_TextParsingUtilities instance { get; }

	// Methods

	// RVA: 0x1151890 Offset: 0x1150C90 VA: 0x181151890
	private static void .cctor() { }

	// RVA: 0x11518F0 Offset: 0x1150CF0 VA: 0x1811518F0
	public static TMP_TextParsingUtilities get_instance() { }

	// RVA: 0x1151620 Offset: 0x1150A20 VA: 0x181151620
	public static uint GetHashCode(string s) { }

	// RVA: 0x11515C0 Offset: 0x11509C0 VA: 0x1811515C0
	public static int GetHashCodeCaseSensitive(string s) { }

	// RVA: 0x1151770 Offset: 0x1150B70 VA: 0x181151770
	public static char ToLowerASCIIFast(char c) { }

	// RVA: 0x11517D0 Offset: 0x1150BD0 VA: 0x1811517D0
	public static char ToUpperASCIIFast(char c) { }

	// RVA: 0x1151830 Offset: 0x1150C30 VA: 0x181151830
	public static uint ToUpperASCIIFast(uint c) { }

	// RVA: 0x1151710 Offset: 0x1150B10 VA: 0x181151710
	public static uint ToLowerASCIIFast(uint c) { }

	// RVA: 0x11516D0 Offset: 0x1150AD0 VA: 0x1811516D0
	public static bool IsHighSurrogate(uint c) { }

	// RVA: 0x11516F0 Offset: 0x1150AF0 VA: 0x1811516F0
	public static bool IsLowSurrogate(uint c) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public static class TMP_TextUtilities // TypeDefIndex: 6846
{	// Fields
	private static Vector3[] m_rectWorldCorners; // 0x2BCE
	private const string k_lookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-";
	private const string k_lookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-";

	// Methods

	// RVA: 0x1156180 Offset: 0x1155580 VA: 0x181156180
	public static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera) { }

	// RVA: 0x1156380 Offset: 0x1155780 VA: 0x181156380
	public static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera, out CaretPosition cursor) { }

	// RVA: 0x11543B0 Offset: 0x11537B0 VA: 0x1811543B0
	public static int FindNearestLine(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x11538F0 Offset: 0x1152CF0 VA: 0x1811538F0
	public static int FindNearestCharacterOnLine(TMP_Text text, Vector3 position, int line, Camera camera, bool visibleOnly) { }

	// RVA: 0x1156A80 Offset: 0x1155E80 VA: 0x181156A80
	public static bool IsIntersectingRectTransform(RectTransform rectTransform, Vector3 position, Camera camera) { }

	// RVA: 0x1151C50 Offset: 0x1151050 VA: 0x181151C50
	public static int FindIntersectingCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly) { }

	// RVA: 0x1153E70 Offset: 0x1153270 VA: 0x181153E70
	public static int FindNearestCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly) { }

	// RVA: 0x1152A80 Offset: 0x1151E80 VA: 0x181152A80
	public static int FindIntersectingWord(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x1155420 Offset: 0x1154820 VA: 0x181155420
	public static int FindNearestWord(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x1151FC0 Offset: 0x11513C0 VA: 0x181151FC0
	public static int FindIntersectingLine(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x1152220 Offset: 0x1151620 VA: 0x181152220
	public static int FindIntersectingLink(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x11546D0 Offset: 0x1153AD0 VA: 0x1811546D0
	public static int FindNearestLink(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x1156C90 Offset: 0x1156090 VA: 0x181156C90
	private static bool PointIntersectRectangle(Vector3 m, Vector3 a, Vector3 b, Vector3 c, Vector3 d) { }

	// RVA: 0x1156F20 Offset: 0x1156320 VA: 0x181156F20
	public static bool ScreenPointToWorldPointInRectangle(Transform transform, Vector2 screenPoint, Camera cam, out Vector3 worldPoint) { }

	// RVA: 0x11567E0 Offset: 0x1155BE0 VA: 0x1811567E0
	private static bool IntersectLinePlane(TMP_TextUtilities.LineSegment line, Vector3 point, Vector3 normal, out Vector3 intersectingPoint) { }

	// RVA: 0x1151950 Offset: 0x1150D50 VA: 0x181151950
	public static float DistanceToLine(Vector3 a, Vector3 b, Vector3 point) { }

	// RVA: 0x1157270 Offset: 0x1156670 VA: 0x181157270
	public static char ToLowerFast(char c) { }

	// RVA: 0x11572D0 Offset: 0x11566D0 VA: 0x1811572D0
	public static char ToUpperFast(char c) { }

	// RVA: 0x11515C0 Offset: 0x11509C0 VA: 0x1811515C0
	public static int GetSimpleHashCode(string s) { }

	// RVA: 0x1156620 Offset: 0x1155A20 VA: 0x181156620
	public static uint GetSimpleHashCodeLowercase(string s) { }

	// RVA: 0x11566D0 Offset: 0x1155AD0 VA: 0x1811566D0
	public static int HexToInt(char hex) { }

	// RVA: 0x1157160 Offset: 0x1156560 VA: 0x181157160
	public static int StringHexToInt(string s) { }

	// RVA: 0x1157330 Offset: 0x1156730 VA: 0x181157330
	private static void .cctor() { }

}

private struct TMP_TextUtilities.LineSegment // TypeDefIndex: 6847
{	// Fields
	public Vector3 Point1; // 0x0
	public Vector3 Point2; // 0xC

	// Methods

	// RVA: 0x1BD4F0 Offset: 0x1BC8F0 VA: 0x1801BD4F0
	public void .ctor(Vector3 p1, Vector3 p2) { }

}

public class TMP_UpdateManager // TypeDefIndex: 6848
{	// Fields
	private static TMP_UpdateManager s_Instance; // 0x0
	private readonly List<TMP_Text> m_LayoutRebuildQueue; // 0x10
	private Dictionary<int, int> m_LayoutQueueLookup; // 0x18
	private readonly List<TMP_Text> m_GraphicRebuildQueue; // 0x20
	private Dictionary<int, int> m_GraphicQueueLookup; // 0x28
	private readonly List<TMP_Text> m_InternalUpdateQueue; // 0x30
	private Dictionary<int, int> m_InternalUpdateLookup; // 0x38

	// Properties
	public static TMP_UpdateManager instance { get; }

	// Methods

	// RVA: 0x1158060 Offset: 0x1157460 VA: 0x181158060
	public static TMP_UpdateManager get_instance() { }

	// RVA: 0x1157E30 Offset: 0x1157230 VA: 0x181157E30
	protected void .ctor() { }

	// RVA: 0x1157B20 Offset: 0x1156F20 VA: 0x181157B20
	internal static void RegisterTextObjectForUpdate(TMP_Text textObject) { }

	// RVA: 0x1157700 Offset: 0x1156B00 VA: 0x181157700
	private void InternalRegisterTextObjectForUpdate(TMP_Text textObject) { }

	// RVA: 0x1157A60 Offset: 0x1156E60 VA: 0x181157A60
	public static void RegisterTextElementForLayoutRebuild(TMP_Text element) { }

	// RVA: 0x1157640 Offset: 0x1156A40 VA: 0x181157640
	private bool InternalRegisterTextElementForLayoutRebuild(TMP_Text element) { }

	// RVA: 0x11579A0 Offset: 0x1156DA0 VA: 0x1811579A0
	public static void RegisterTextElementForGraphicRebuild(TMP_Text element) { }

	// RVA: 0x1157580 Offset: 0x1156980 VA: 0x181157580
	private bool InternalRegisterTextElementForGraphicRebuild(TMP_Text element) { }

	// RVA: 0x1157990 Offset: 0x1156D90 VA: 0x181157990
	private void OnBeginFrameRendering(ScriptableRenderContext renderContext, Camera[] cameras) { }

	// RVA: 0x1157990 Offset: 0x1156D90 VA: 0x181157990
	private void OnCameraPreCull(Camera cam) { }

	// RVA: 0x1157380 Offset: 0x1156780 VA: 0x181157380
	private void DoRebuilds() { }

	// RVA: 0x1157D90 Offset: 0x1157190 VA: 0x181157D90
	internal static void UnRegisterTextObjectForUpdate(TMP_Text textObject) { }

	// RVA: 0x1157BE0 Offset: 0x1156FE0 VA: 0x181157BE0
	public static void UnRegisterTextElementForRebuild(TMP_Text element) { }

	// RVA: 0x11577B0 Offset: 0x1156BB0 VA: 0x1811577B0
	private void InternalUnRegisterTextElementForGraphicRebuild(TMP_Text element) { }

	// RVA: 0x1157850 Offset: 0x1156C50 VA: 0x181157850
	private void InternalUnRegisterTextElementForLayoutRebuild(TMP_Text element) { }

	// RVA: 0x11578F0 Offset: 0x1156CF0 VA: 0x1811578F0
	private void InternalUnRegisterTextObjectForUpdate(TMP_Text textObject) { }

}

public class TMP_UpdateRegistry // TypeDefIndex: 6849
{	// Fields
	private static TMP_UpdateRegistry s_Instance; // 0x0
	private readonly List<ICanvasElement> m_LayoutRebuildQueue; // 0x10
	private Dictionary<int, int> m_LayoutQueueLookup; // 0x18
	private readonly List<ICanvasElement> m_GraphicRebuildQueue; // 0x20
	private Dictionary<int, int> m_GraphicQueueLookup; // 0x28

	// Properties
	public static TMP_UpdateRegistry instance { get; }

	// Methods

	// RVA: 0x1158DC0 Offset: 0x11581C0 VA: 0x181158DC0
	public static TMP_UpdateRegistry get_instance() { }

	// RVA: 0x1158CA0 Offset: 0x11580A0 VA: 0x181158CA0
	protected void .ctor() { }

	// RVA: 0x1158960 Offset: 0x1157D60 VA: 0x181158960
	public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x1158210 Offset: 0x1157610 VA: 0x181158210
	private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x1158830 Offset: 0x1157C30 VA: 0x181158830
	public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x11580E0 Offset: 0x11574E0 VA: 0x1811580E0
	private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x1158540 Offset: 0x1157940 VA: 0x181158540
	private void PerformUpdateForCanvasRendererObjects() { }

	// RVA: 0x11587E0 Offset: 0x1157BE0 VA: 0x1811587E0
	private void PerformUpdateForMeshRendererObjects() { }

	// RVA: 0x1158A90 Offset: 0x1157E90 VA: 0x181158A90
	public static void UnRegisterCanvasElementForRebuild(ICanvasElement element) { }

	// RVA: 0x1158440 Offset: 0x1157840 VA: 0x181158440
	private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x1158340 Offset: 0x1157740 VA: 0x181158340
	private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

}

public static class TMP_Math // TypeDefIndex: 6854
{	// Fields
	public const float FLOAT_MAX = 32767;
	public const float FLOAT_MIN = -32767;
	public const int INT_MAX = 2147483647;
	public const int INT_MIN = -2147483647;
	public const float FLOAT_UNSET = -32767;
	public const int INT_UNSET = -32767;
	public static Vector2 MAX_16BIT; // 0x0
	public static Vector2 MIN_16BIT; // 0x8

	// Methods

	// RVA: 0xD95DA0 Offset: 0xD951A0 VA: 0x180D95DA0
	public static bool Approximately(float a, float b) { }

	// RVA: 0xD95DD0 Offset: 0xD951D0 VA: 0x180D95DD0
	private static void .cctor() { }

}

public enum TMP_VertexDataUpdateFlags // TypeDefIndex: 6855
{	// Fields
	public int value__; // 0x0
	public const TMP_VertexDataUpdateFlags None = 0;
	public const TMP_VertexDataUpdateFlags Vertices = 1;
	public const TMP_VertexDataUpdateFlags Uv0 = 2;
	public const TMP_VertexDataUpdateFlags Uv2 = 4;
	public const TMP_VertexDataUpdateFlags Uv4 = 8;
	public const TMP_VertexDataUpdateFlags Colors32 = 16;
	public const TMP_VertexDataUpdateFlags All = 255;

}

public struct TMP_PageInfo // TypeDefIndex: 6857
{	// Fields
	public int firstCharacterIndex; // 0x0
	public int lastCharacterIndex; // 0x4
	public float ascender; // 0x8
	public float baseLine; // 0xC
	public float descender; // 0x10

}

public struct TMP_LinkInfo // TypeDefIndex: 6858
{	// Fields
	public TMP_Text textComponent; // 0x0
	public int hashCode; // 0x8
	public int linkIdFirstCharacterIndex; // 0xC
	public int linkIdLength; // 0x10
	public int linkTextfirstCharacterIndex; // 0x14
	public int linkTextLength; // 0x18
	internal char[] linkID; // 0x20

	// Methods

	// RVA: 0x121EF0 Offset: 0x1212F0 VA: 0x180121EF0
	internal void SetLinkID(char[] text, int startIndex, int length) { }

	// RVA: 0x121E10 Offset: 0x121210 VA: 0x180121E10
	public string GetLinkText() { }

	// RVA: 0x121D70 Offset: 0x121170 VA: 0x180121D70
	public string GetLinkID() { }

}

public struct TMP_WordInfo // TypeDefIndex: 6859
{	// Fields
	public TMP_Text textComponent; // 0x0
	public int firstCharacterIndex; // 0x8
	public int lastCharacterIndex; // 0xC
	public int characterCount; // 0x10

	// Methods

	// RVA: 0x1BD520 Offset: 0x1BC920 VA: 0x1801BD520
	public string GetWord() { }

}

public struct TMP_SpriteInfo // TypeDefIndex: 6860
{	// Fields
	public int spriteIndex; // 0x0
	public int characterIndex; // 0x4
	public int vertexIndex; // 0x8

}

