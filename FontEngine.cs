public sealed class FontEngine // TypeDefIndex: 4120
{	// Fields
	private static Glyph[] s_Glyphs; // 0x0
	private static uint[] s_GlyphIndexes_MarshallingArray_A; // 0x8
	private static GlyphMarshallingStruct[] s_GlyphMarshallingStruct_IN; // 0x10
	private static GlyphMarshallingStruct[] s_GlyphMarshallingStruct_OUT; // 0x18
	private static GlyphRect[] s_FreeGlyphRects; // 0x20
	private static GlyphRect[] s_UsedGlyphRects; // 0x28
	private static GlyphPairAdjustmentRecord[] s_PairAdjustmentRecords_MarshallingArray; // 0x30
	private static Dictionary<uint, Glyph> s_GlyphLookupDictionary; // 0x38

	// Methods

	// RVA: 0x22E96A0 Offset: 0x22E8AA0 VA: 0x1822E96A0
	public static FontEngineError InitializeFontEngine() { }

	[NativeMethodAttribute] // RVA: 0x8A980 Offset: 0x89D80 VA: 0x18008A980
	// RVA: 0x22E9670 Offset: 0x22E8A70 VA: 0x1822E9670
	private static int InitializeFontEngine_Internal() { }

	// RVA: 0x22E9750 Offset: 0x22E8B50 VA: 0x1822E9750
	public static FontEngineError LoadFontFace(Font font, int pointSize) { }

	[NativeMethodAttribute] // RVA: 0x8AA40 Offset: 0x89E40 VA: 0x18008AA40
	// RVA: 0x22E9710 Offset: 0x22E8B10 VA: 0x1822E9710
	private static int LoadFontFace_With_Size_FromFont_Internal(Font font, int pointSize) { }

	// RVA: 0x22E9390 Offset: 0x22E8790 VA: 0x1822E9390
	public static FaceInfo GetFaceInfo() { }

	[NativeMethodAttribute] // RVA: 0x8AAE0 Offset: 0x89EE0 VA: 0x18008AAE0
	// RVA: 0x22E9350 Offset: 0x22E8750 VA: 0x1822E9350
	private static int GetFaceInfo_Internal(ref FaceInfo faceInfo) { }

	[NativeMethodAttribute] // RVA: 0x8ABF0 Offset: 0x89FF0 VA: 0x18008ABF0
	// RVA: 0x22E9480 Offset: 0x22E8880 VA: 0x1822E9480
	internal static uint GetGlyphIndex(uint unicode) { }

	// RVA: 0x22EAE50 Offset: 0x22EA250 VA: 0x1822EAE50
	public static bool TryGetGlyphWithUnicodeValue(uint unicode, GlyphLoadFlags flags, out Glyph glyph) { }

	[NativeMethodAttribute] // RVA: 0x8AC90 Offset: 0x8A090 VA: 0x18008AC90
	// RVA: 0x22EAE00 Offset: 0x22EA200 VA: 0x1822EAE00
	private static bool TryGetGlyphWithUnicodeValue_Internal(uint unicode, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct) { }

	// RVA: 0x22EAC90 Offset: 0x22EA090 VA: 0x1822EAC90
	public static bool TryGetGlyphWithIndexValue(uint glyphIndex, GlyphLoadFlags flags, out Glyph glyph) { }

	[NativeMethodAttribute] // RVA: 0x8AD80 Offset: 0x8A180 VA: 0x18008AD80
	// RVA: 0x22EAC40 Offset: 0x22EA040 VA: 0x1822EAC40
	private static bool TryGetGlyphWithIndexValue_Internal(uint glyphIndex, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct) { }

	// RVA: 0x22EB020 Offset: 0x22EA420 VA: 0x1822EB020
	internal static bool TryPackGlyphInAtlas(Glyph glyph, int padding, GlyphPackingMode packingMode, GlyphRenderMode renderMode, int width, int height, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects) { }

	[NativeMethodAttribute] // RVA: 0x8ADF0 Offset: 0x8A1F0 VA: 0x18008ADF0
	// RVA: 0x22EAFC0 Offset: 0x22EA3C0 VA: 0x1822EAFC0
	private static bool TryPackGlyphInAtlas_Internal(ref GlyphMarshallingStruct glyph, int padding, GlyphPackingMode packingMode, GlyphRenderMode renderMode, int width, int height, [Out] GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, [Out] GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount) { }

	// RVA: 0x22E9880 Offset: 0x22E8C80 VA: 0x1822E9880
	internal static FontEngineError RenderGlyphsToTexture(List<Glyph> glyphs, int padding, GlyphRenderMode renderMode, Texture2D texture) { }

	[NativeMethodAttribute] // RVA: 0x8AE60 Offset: 0x8A260 VA: 0x18008AE60
	// RVA: 0x22E9820 Offset: 0x22E8C20 VA: 0x1822E9820
	private static int RenderGlyphsToTexture_Internal(GlyphMarshallingStruct[] glyphs, int glyphCount, int padding, GlyphRenderMode renderMode, Texture2D texture) { }

	// RVA: 0x22E9BA0 Offset: 0x22E8FA0 VA: 0x1822E9BA0
	internal static bool TryAddGlyphToTexture(uint glyphIndex, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, out Glyph glyph) { }

	[NativeMethodAttribute] // RVA: 0x8AED0 Offset: 0x8A2D0 VA: 0x18008AED0
	// RVA: 0x22E9B40 Offset: 0x22E8F40 VA: 0x1822E9B40
	private static bool TryAddGlyphToTexture_Internal(uint glyphIndex, int padding, GlyphPackingMode packingMode, [Out] GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, [Out] GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, out GlyphMarshallingStruct glyph) { }

	// RVA: 0x22EA230 Offset: 0x22E9630 VA: 0x1822EA230
	internal static bool TryAddGlyphsToTexture(List<uint> glyphIndexes, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, out Glyph[] glyphs) { }

	[NativeMethodAttribute] // RVA: 0x8AF40 Offset: 0x8A340 VA: 0x18008AF40
	// RVA: 0x22EA1C0 Offset: 0x22E95C0 VA: 0x1822EA1C0
	private static bool TryAddGlyphsToTexture_Internal(uint[] glyphIndex, int padding, GlyphPackingMode packingMode, [Out] GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, [Out] GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, [Out] GlyphMarshallingStruct[] glyphs, ref int glyphCount) { }

	// RVA: 0x22E9500 Offset: 0x22E8900 VA: 0x1822E9500
	internal static GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentTable(uint[] glyphIndexes) { }

	[NativeMethodAttribute] // RVA: 0x8B020 Offset: 0x8A420 VA: 0x18008B020
	// RVA: 0x22E97D0 Offset: 0x22E8BD0 VA: 0x1822E97D0
	private static int PopulatePairAdjustmentRecordMarshallingArray_from_GlyphIndexes(uint[] glyphIndexes, out int recordCount) { }

	[NativeMethodAttribute] // RVA: 0x8B0D0 Offset: 0x8A4D0 VA: 0x18008B0D0
	// RVA: 0x22E94C0 Offset: 0x22E88C0 VA: 0x1822E94C0
	private static int GetGlyphPairAdjustmentRecordsFromMarshallingArray([Out] GlyphPairAdjustmentRecord[] glyphPairAdjustmentRecords) { }

	// RVA: -1 Offset: -1
	private static void SetMarshallingArraySize<T>(ref T[] marshallingArray, int recordCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E7670 Offset: 0x5E6A70 VA: 0x1805E7670
	|-FontEngine.SetMarshallingArraySize<object>
	|
	|-RVA: 0x5E75A0 Offset: 0x5E69A0 VA: 0x1805E75A0
	|-FontEngine.SetMarshallingArraySize<GlyphPairAdjustmentRecord>
	*/

	[NativeMethodAttribute] // RVA: 0x8B1F0 Offset: 0x8A5F0 VA: 0x18008B1F0
	// RVA: 0x22E9B00 Offset: 0x22E8F00 VA: 0x1822E9B00
	internal static void ResetAtlasTexture(Texture2D texture) { }

	// RVA: 0x22EB5B0 Offset: 0x22EA9B0 VA: 0x1822EB5B0
	private static void .cctor() { }

}

