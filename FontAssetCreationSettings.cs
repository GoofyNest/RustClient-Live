public struct FontAssetCreationSettings // TypeDefIndex: 6706
{
	public string sourceFontFileName;
	public string sourceFontFileGUID;
	public int pointSizeSamplingMode;
	public int pointSize;
	public int padding;
	public int packingMode;
	public int atlasWidth;
	public int atlasHeight;
	public int characterSetSelectionMode;
	public string characterSequence;
	public string referencedFontAssetGUID;
	public string referencedTextAssetGUID;
	public int fontStyle;
	public float fontStyleModifier;
	public int renderMode;
	public bool includeFontFeatures;


	internal void .ctor(string sourceFontFileGUID, int pointSize, int pointSizeSamplingMode, int padding, int packingMode, int atlasWidth, int atlasHeight, int characterSelectionMode, string characterSet, int renderMode) { }

}

