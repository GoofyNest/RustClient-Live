public class TextMeshProUGUI : TMP_Text, ILayoutElement // TypeDefIndex: 6868
{
	[SerializeField] 
	private bool m_hasFontAssetChanged; 
	[SerializeField] 
	protected TMP_SubMeshUI[] m_subTextObjects; 
	private float m_previousLossyScaleY; 
	private Vector3[] m_RectTransformCorners; 
	private CanvasRenderer m_canvasRenderer; 
	private Canvas m_canvas; 
	private bool m_isFirstAllocation; 
	private int m_max_characters; 
	private bool m_isMaskingEnabled; 
	[SerializeField] 
	private Material m_baseMaterial; 
	private bool m_isScrollRegionSet; 
	private int m_stencilID; 
	[SerializeField] 
	private Vector4 m_maskOffset; 
	private Matrix4x4 m_EnvMapMatrix; 
	private bool m_isRegisteredForEvents; 
	private int m_recursiveCountA; 
	private int loopCountA; 
	[CompilerGeneratedAttribute] 
	private bool <blockRectTransformChange>k__BackingField; 
	private bool m_isRebuildingLayout; 

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

	[CompilerGeneratedAttribute] 
	public bool get_blockRectTransformChange() { }

	[CompilerGeneratedAttribute] 
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

