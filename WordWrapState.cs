public struct WordWrapState // TypeDefIndex: 6863
{	public int previous_WordBreak; // 0x0
	public int total_CharacterCount; // 0x4
	public int visible_CharacterCount; // 0x8
	public int visible_SpriteCount; // 0xC
	public int visible_LinkCount; // 0x10
	public int firstCharacterIndex; // 0x14
	public int firstVisibleCharacterIndex; // 0x18
	public int lastCharacterIndex; // 0x1C
	public int lastVisibleCharIndex; // 0x20
	public int lineNumber; // 0x24
	public float maxCapHeight; // 0x28
	public float maxAscender; // 0x2C
	public float maxDescender; // 0x30
	public float maxLineAscender; // 0x34
	public float maxLineDescender; // 0x38
	public float previousLineAscender; // 0x3C
	public float xAdvance; // 0x40
	public float preferredWidth; // 0x44
	public float preferredHeight; // 0x48
	public float previousLineScale; // 0x4C
	public int wordCount; // 0x50
	public FontStyles fontStyle; // 0x54
	public float fontScale; // 0x58
	public float fontScaleMultiplier; // 0x5C
	public float currentFontSize; // 0x60
	public float baselineOffset; // 0x64
	public float lineOffset; // 0x68
	public TMP_TextInfo textInfo; // 0x70
	public TMP_LineInfo lineInfo; // 0x78
	public Color32 vertexColor; // 0xD4
	public Color32 underlineColor; // 0xD8
	public Color32 strikethroughColor; // 0xDC
	public Color32 highlightColor; // 0xE0
	public TMP_FontStyleStack basicStyleStack; // 0xE4
	public TMP_RichTextTagStack<Color32> colorStack; // 0xF0
	public TMP_RichTextTagStack<Color32> underlineColorStack; // 0x108
	public TMP_RichTextTagStack<Color32> strikethroughColorStack; // 0x120
	public TMP_RichTextTagStack<Color32> highlightColorStack; // 0x138
	public TMP_RichTextTagStack<TMP_ColorGradient> colorGradientStack; // 0x150
	public TMP_RichTextTagStack<float> sizeStack; // 0x168
	public TMP_RichTextTagStack<float> indentStack; // 0x180
	public TMP_RichTextTagStack<FontWeight> fontWeightStack; // 0x198
	public TMP_RichTextTagStack<int> styleStack; // 0x1B0
	public TMP_RichTextTagStack<float> baselineStack; // 0x1C8
	public TMP_RichTextTagStack<int> actionStack; // 0x1E0
	public TMP_RichTextTagStack<MaterialReference> materialReferenceStack; // 0x1F8
	public TMP_RichTextTagStack<TextAlignmentOptions> lineJustificationStack; // 0x238
	public int spriteAnimationID; // 0x250
	public TMP_FontAsset currentFontAsset; // 0x258
	public Material currentMaterial; // 0x260
	public int currentMaterialIndex; // 0x268
	public Extents meshExtents; // 0x26C
	public bool tagNoParsing; // 0x27C
	public bool isNonBreakingSpace; // 0x27D

}

