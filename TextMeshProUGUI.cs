public class TextMeshProUGUI : TMP_Text, ILayoutElement // TypeDefIndex: 6867
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_hasFontAssetChanged; // 0xAD0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected TMP_SubMeshUI[] m_subTextObjects; // 0xAD8
	private float m_previousLossyScaleY; // 0xAE0
	private Vector3[] m_RectTransformCorners; // 0xAE8
	private CanvasRenderer m_canvasRenderer; // 0xAF0
	private Canvas m_canvas; // 0xAF8
	private bool m_isFirstAllocation; // 0xB00
	private int m_max_characters; // 0xB04
	private bool m_isMaskingEnabled; // 0xB08
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Material m_baseMaterial; // 0xB10
	private bool m_isScrollRegionSet; // 0xB18
	private int m_stencilID; // 0xB1C
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector4 m_maskOffset; // 0xB20
	private Matrix4x4 m_EnvMapMatrix; // 0xB30
	private bool m_isRegisteredForEvents; // 0xB70
	private int m_recursiveCountA; // 0xB74
	private int loopCountA; // 0xB78
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <blockRectTransformChange>k__BackingField; // 0xB7C
	private bool m_isRebuildingLayout; // 0xB7D

	// Properties
	public bool blockRectTransformChange { get; set; }
	public override Material materialForRendering { get; }
	public override bool autoSizeTextContainer { get; set; }
	public override Mesh mesh { get; }
	public CanvasRenderer canvasRenderer { get; }
	public Vector4 maskOffset { get; set; }

	// Methods

	// RVA: 0x19FEBD0 Offset: 0x19FDFD0 VA: 0x1819FEBD0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1A0C780 Offset: 0x1A0BB80 VA: 0x181A0C780 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1A0C5A0 Offset: 0x1A0B9A0 VA: 0x181A0C5A0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1A0C3F0 Offset: 0x1A0B7F0 VA: 0x181A0C3F0 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x1A0BC90 Offset: 0x1A0B090 VA: 0x181A0BC90 Slot: 83
	protected override void LoadFontAsset() { }

	// RVA: 0x1A0A9B0 Offset: 0x1A09DB0 VA: 0x181A0A9B0
	private Canvas GetCanvas() { }

	// RVA: 0x19FF540 Offset: 0x19FE940 VA: 0x1819FF540
	private void EnableMasking() { }

	// RVA: 0x19FF3F0 Offset: 0x19FE7F0 VA: 0x1819FF3F0
	private void DisableMasking() { }

	// RVA: 0x1A101C0 Offset: 0x1A0F5C0 VA: 0x181A101C0
	private void UpdateMask() { }

	// RVA: 0x1A0AFE0 Offset: 0x1A0A3E0 VA: 0x181A0AFE0 Slot: 85
	protected override Material GetMaterial(Material mat) { }

	// RVA: 0x1A0B160 Offset: 0x1A0A560 VA: 0x181A0B160 Slot: 89
	protected override Material[] GetMaterials(Material[] mats) { }

	// RVA: 0x116CAD0 Offset: 0x116BED0 VA: 0x18116CAD0 Slot: 84
	protected override void SetSharedMaterial(Material mat) { }

	// RVA: 0x1A0B660 Offset: 0x1A0AA60 VA: 0x181A0B660 Slot: 87
	protected override Material[] GetSharedMaterials() { }

	// RVA: 0x1A0FAC0 Offset: 0x1A0EEC0 VA: 0x181A0FAC0 Slot: 88
	protected override void SetSharedMaterials(Material[] materials) { }

	// RVA: 0x1A0F640 Offset: 0x1A0EA40 VA: 0x181A0F640 Slot: 93
	protected override void SetOutlineThickness(float thickness) { }

	// RVA: 0x1A0F120 Offset: 0x1A0E520 VA: 0x181A0F120 Slot: 91
	protected override void SetFaceColor(Color32 color) { }

	// RVA: 0x1A0F4E0 Offset: 0x1A0E8E0 VA: 0x181A0F4E0 Slot: 92
	protected override void SetOutlineColor(Color32 color) { }

	// RVA: 0x1A0F950 Offset: 0x1A0ED50 VA: 0x181A0F950 Slot: 94
	protected override void SetShaderDepth() { }

	// RVA: 0x1A0ED30 Offset: 0x1A0E130 VA: 0x181A0ED30 Slot: 95
	protected override void SetCulling() { }

	// RVA: 0x1A0F880 Offset: 0x1A0EC80 VA: 0x181A0F880
	private void SetPerspectiveCorrection() { }

	// RVA: 0x1A0B4B0 Offset: 0x1A0A8B0 VA: 0x181A0B4B0 Slot: 97
	protected override float GetPaddingForMaterial(Material mat) { }

	// RVA: 0x1A0B590 Offset: 0x1A0A990 VA: 0x181A0B590 Slot: 96
	protected override float GetPaddingForMaterial() { }

	// RVA: 0x1A0F450 Offset: 0x1A0E850 VA: 0x181A0F450
	private void SetMeshArrays(int size) { }

	// RVA: 0x1A0D040 Offset: 0x1A0C440 VA: 0x181A0D040 Slot: 108
	protected override int SetArraySizes(TMP_Text.UnicodeChar[] chars) { }

	// RVA: 0x19FF290 Offset: 0x19FE690 VA: 0x1819FF290 Slot: 114
	public override void ComputeMarginSize() { }

	// RVA: 0x1A0C560 Offset: 0x1A0B960 VA: 0x181A0C560 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x1A0C3B0 Offset: 0x1A0B7B0 VA: 0x181A0C3B0 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x1A0CD90 Offset: 0x1A0C190 VA: 0x181A0CD90 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x1A0CBF0 Offset: 0x1A0BFF0 VA: 0x181A0CBF0 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1A11560 Offset: 0x1A10960 VA: 0x181A11560
	public bool get_blockRectTransformChange() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1A11720 Offset: 0x1A10B20 VA: 0x181A11720
	public void set_blockRectTransformChange(bool value) { }

	// RVA: 0x1A0BBA0 Offset: 0x1A0AFA0 VA: 0x181A0BBA0 Slot: 125
	internal override void InternalUpdate() { }

	// RVA: 0x1A0C9C0 Offset: 0x1A0BDC0 VA: 0x181A0C9C0
	private void OnPreRenderCanvas() { }

	// RVA: 0x19FF7C0 Offset: 0x19FEBC0 VA: 0x1819FF7C0 Slot: 109
	protected override void GenerateTextMesh() { }

	// RVA: 0x1A0B830 Offset: 0x1A0AC30 VA: 0x181A0B830 Slot: 98
	protected override Vector3[] GetTextContainerLocalCorners() { }

	// RVA: 0x1A0CED0 Offset: 0x1A0C2D0 VA: 0x181A0CED0 Slot: 120
	protected override void SetActiveSubMeshes(bool state) { }

	// RVA: 0x1A0AAF0 Offset: 0x1A09EF0 VA: 0x181A0AAF0 Slot: 111
	protected override Bounds GetCompoundBounds() { }

	// RVA: 0x1A10AA0 Offset: 0x1A0FEA0 VA: 0x181A10AA0
	private void UpdateSDFScale(float scaleDelta) { }

	// RVA: 0x19FE530 Offset: 0x19FD930 VA: 0x1819FE530 Slot: 112
	protected override void AdjustLineOffset(int startIndex, int endIndex, float offset) { }

	// RVA: 0x1A11620 Offset: 0x1A10A20 VA: 0x181A11620 Slot: 34
	public override Material get_materialForRendering() { }

	// RVA: 0x116E070 Offset: 0x116D470 VA: 0x18116E070 Slot: 71
	public override bool get_autoSizeTextContainer() { }

	// RVA: 0x1A11690 Offset: 0x1A10A90 VA: 0x181A11690 Slot: 72
	public override void set_autoSizeTextContainer(bool value) { }

	// RVA: 0x79B690 Offset: 0x79AA90 VA: 0x18079B690 Slot: 73
	public override Mesh get_mesh() { }

	// RVA: 0x1A11570 Offset: 0x1A10970 VA: 0x181A11570
	public CanvasRenderer get_canvasRenderer() { }

	// RVA: 0x19FF040 Offset: 0x19FE440 VA: 0x1819FF040 Slot: 126
	public void CalculateLayoutInputHorizontal() { }

	// RVA: 0x19FF0C0 Offset: 0x19FE4C0 VA: 0x1819FF0C0 Slot: 127
	public void CalculateLayoutInputVertical() { }

	// RVA: 0x1A10030 Offset: 0x1A0F430 VA: 0x181A10030 Slot: 28
	public override void SetVerticesDirty() { }

	// RVA: 0x1A0F280 Offset: 0x1A0E680 VA: 0x181A0F280 Slot: 27
	public override void SetLayoutDirty() { }

	// RVA: 0x1A0F370 Offset: 0x1A0E770 VA: 0x181A0F370 Slot: 29
	public override void SetMaterialDirty() { }

	// RVA: 0x1169B60 Offset: 0x1168F60 VA: 0x181169B60 Slot: 26
	public override void SetAllDirty() { }

	// RVA: 0x1A0CDE0 Offset: 0x1A0C1E0 VA: 0x181A0CDE0 Slot: 37
	public override void Rebuild(CanvasUpdate update) { }

	// RVA: 0x1A10E50 Offset: 0x1A10250 VA: 0x181A10E50
	private void UpdateSubObjectPivot() { }

	// RVA: 0x1A0B350 Offset: 0x1A0A750 VA: 0x181A0B350 Slot: 57
	public override Material GetModifiedMaterial(Material baseMaterial) { }

	// RVA: 0x1A10800 Offset: 0x1A0FC00 VA: 0x181A10800 Slot: 40
	protected override void UpdateMaterial() { }

	// RVA: 0x1A11610 Offset: 0x1A10A10 VA: 0x181A11610
	public Vector4 get_maskOffset() { }

	// RVA: 0x1A11730 Offset: 0x1A10B30 VA: 0x181A11730
	public void set_maskOffset(Vector4 value) { }

	// RVA: 0xD9AB60 Offset: 0xD99F60 VA: 0x180D9AB60 Slot: 61
	public override void RecalculateClipping() { }

	// RVA: 0xD9AB70 Offset: 0xD99F70 VA: 0x180D9AB70 Slot: 62
	public override void RecalculateMasking() { }

	// RVA: 0x19FF3C0 Offset: 0x19FE7C0 VA: 0x1819FF3C0 Slot: 58
	public override void Cull(Rect clipRect, bool validRect) { }

	// RVA: 0x1A10970 Offset: 0x1A0FD70 VA: 0x181A10970 Slot: 105
	public override void UpdateMeshPadding() { }

	// RVA: 0x1A0BAC0 Offset: 0x1A0AEC0 VA: 0x181A0BAC0 Slot: 106
	protected override void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x1A0BA00 Offset: 0x1A0AE00 VA: 0x181A0BA00 Slot: 107
	protected override void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x19FF7B0 Offset: 0x19FEBB0 VA: 0x1819FF7B0 Slot: 99
	public override void ForceMeshUpdate() { }

	// RVA: 0x19FF790 Offset: 0x19FEB90 VA: 0x1819FF790 Slot: 100
	public override void ForceMeshUpdate(bool ignoreInactive) { }

	// RVA: 0x1A0B8F0 Offset: 0x1A0ACF0 VA: 0x181A0B8F0 Slot: 113
	public override TMP_TextInfo GetTextInfo(string text) { }

	// RVA: 0x19FF150 Offset: 0x19FE550 VA: 0x1819FF150 Slot: 122
	public override void ClearMesh() { }

	// RVA: 0x1A10120 Offset: 0x1A0F520 VA: 0x181A10120 Slot: 101
	public override void UpdateGeometry(Mesh mesh, int index) { }

	// RVA: 0x1A10F80 Offset: 0x1A10380 VA: 0x181A10F80 Slot: 102
	public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	// RVA: 0x1A11210 Offset: 0x1A10610 VA: 0x181A11210 Slot: 103
	public override void UpdateVertexData() { }

	// RVA: 0x116D420 Offset: 0x116C820 VA: 0x18116D420
	public void UpdateFontAsset() { }

	// RVA: 0x1A114B0 Offset: 0x1A108B0 VA: 0x181A114B0
	public void .ctor() { }

}

