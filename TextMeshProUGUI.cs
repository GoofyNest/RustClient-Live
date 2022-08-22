public class TextMeshProUGUI : TMP_Text, ILayoutElement // TypeDefIndex: 6867
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	public bool blockRectTransformChange { get; set; }
	public override Material materialForRendering { get; }
	public override bool autoSizeTextContainer { get; set; }
	public override Mesh mesh { get; }
	public CanvasRenderer canvasRenderer { get; }
	public Vector4 maskOffset { get; set; }


	protected override void Awake() { }

	protected override void OnEnable() { }

	protected override void OnDisable() { }

	protected override void OnDestroy() { }

	protected override void LoadFontAsset() { }

	private Canvas GetCanvas() { }

	private void EnableMasking() { }

	private void DisableMasking() { }

	private void UpdateMask() { }

	protected override Material GetMaterial(Material mat) { }

	protected override Material[] GetMaterials(Material[] mats) { }

	protected override void SetSharedMaterial(Material mat) { }

	protected override Material[] GetSharedMaterials() { }

	protected override void SetSharedMaterials(Material[] materials) { }

	protected override void SetOutlineThickness(float thickness) { }

	protected override void SetFaceColor(Color32 color) { }

	protected override void SetOutlineColor(Color32 color) { }

	protected override void SetShaderDepth() { }

	protected override void SetCulling() { }

	private void SetPerspectiveCorrection() { }

	protected override float GetPaddingForMaterial(Material mat) { }

	protected override float GetPaddingForMaterial() { }

	private void SetMeshArrays(int size) { }

	protected override int SetArraySizes(TMP_Text.UnicodeChar[] chars) { }

	public override void ComputeMarginSize() { }

	protected override void OnDidApplyAnimationProperties() { }

	protected override void OnCanvasHierarchyChanged() { }

	protected override void OnTransformParentChanged() { }

	protected override void OnRectTransformDimensionsChange() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_blockRectTransformChange() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_blockRectTransformChange(bool value) { }

	internal override void InternalUpdate() { }

	private void OnPreRenderCanvas() { }

	protected override void GenerateTextMesh() { }

	protected override Vector3[] GetTextContainerLocalCorners() { }

	protected override void SetActiveSubMeshes(bool state) { }

	protected override Bounds GetCompoundBounds() { }

	private void UpdateSDFScale(float scaleDelta) { }

	protected override void AdjustLineOffset(int startIndex, int endIndex, float offset) { }

	public override Material get_materialForRendering() { }

	public override bool get_autoSizeTextContainer() { }

	public override void set_autoSizeTextContainer(bool value) { }

	public override Mesh get_mesh() { }

	public CanvasRenderer get_canvasRenderer() { }

	public void CalculateLayoutInputHorizontal() { }

	public void CalculateLayoutInputVertical() { }

	public override void SetVerticesDirty() { }

	public override void SetLayoutDirty() { }

	public override void SetMaterialDirty() { }

	public override void SetAllDirty() { }

	public override void Rebuild(CanvasUpdate update) { }

	private void UpdateSubObjectPivot() { }

	public override Material GetModifiedMaterial(Material baseMaterial) { }

	protected override void UpdateMaterial() { }

	public Vector4 get_maskOffset() { }

	public void set_maskOffset(Vector4 value) { }

	public override void RecalculateClipping() { }

	public override void RecalculateMasking() { }

	public override void Cull(Rect clipRect, bool validRect) { }

	public override void UpdateMeshPadding() { }

	protected override void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	protected override void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	public override void ForceMeshUpdate() { }

	public override void ForceMeshUpdate(bool ignoreInactive) { }

	public override TMP_TextInfo GetTextInfo(string text) { }

	public override void ClearMesh() { }

	public override void UpdateGeometry(Mesh mesh, int index) { }

	public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	public override void UpdateVertexData() { }

	public void UpdateFontAsset() { }

	public void .ctor() { }

}

