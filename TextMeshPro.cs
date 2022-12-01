public class TextMeshPro : TMP_Text, ILayoutElement // TypeDefIndex: 6808
{
	[SerializeField]
	private bool m_hasFontAssetChanged;
	private float m_previousLossyScaleY;
	[SerializeField]
	private Renderer m_renderer;
	private MeshFilter m_meshFilter;
	private bool m_isFirstAllocation;
	private int m_max_characters;
	private int m_max_numberOfLines;
	[SerializeField]
	protected TMP_SubMesh[] m_subTextObjects;
	private bool m_isMaskingEnabled;
	private bool isMaskUpdateRequired;
	[SerializeField]
	private MaskingTypes m_maskType;
	private Matrix4x4 m_EnvMapMatrix;
	private Vector3[] m_RectTransformCorners;
	private bool m_isRegisteredForEvents;
	private int loopCountA;
	private bool m_currentAutoSizeMode;

	public int sortingLayerID { get; set; }
	public int sortingOrder { get; set; }
	public override bool autoSizeTextContainer { get; set; }
	[ObsoleteAttribute]
	public TextContainer textContainer { get; }
	public Transform transform { get; }
	public Renderer renderer { get; }
	public override Mesh mesh { get; }
	public MeshFilter meshFilter { get; }
	public MaskingTypes maskType { get; set; }


	protected override void Awake() { }

	protected override void OnEnable() { }

	protected override void OnDisable() { }

	protected override void OnDestroy() { }

	protected override void LoadFontAsset() { }

	private void UpdateEnvMapMatrix() { }

	private void SetMask(MaskingTypes maskType) { }

	private void SetMaskCoordinates(Vector4 coords) { }

	private void SetMaskCoordinates(Vector4 coords, float softX, float softY) { }

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

	private void CreateMaterialInstance() { }

	protected override void SetShaderDepth() { }

	protected override void SetCulling() { }

	private void SetPerspectiveCorrection() { }

	protected override float GetPaddingForMaterial(Material mat) { }

	protected override float GetPaddingForMaterial() { }

	protected override int SetArraySizes(TMP_Text.UnicodeChar[] chars) { }

	public override void ComputeMarginSize() { }

	protected override void OnDidApplyAnimationProperties() { }

	protected override void OnTransformParentChanged() { }

	protected override void OnRectTransformDimensionsChange() { }

	internal override void InternalUpdate() { }

	private void OnPreRenderObject() { }

	protected override void GenerateTextMesh() { }

	protected override Vector3[] GetTextContainerLocalCorners() { }

	private void SetMeshFilters(bool state) { }

	protected override void SetActiveSubMeshes(bool state) { }

	protected override void ClearSubMeshObjects() { }

	protected override Bounds GetCompoundBounds() { }

	private void UpdateSDFScale(float scaleDelta) { }

	protected override void AdjustLineOffset(int startIndex, int endIndex, float offset) { }

	public int get_sortingLayerID() { }

	public void set_sortingLayerID(int value) { }

	public int get_sortingOrder() { }

	public void set_sortingOrder(int value) { }

	public override bool get_autoSizeTextContainer() { }

	public override void set_autoSizeTextContainer(bool value) { }

	public TextContainer get_textContainer() { }

	public Transform get_transform() { }

	public Renderer get_renderer() { }

	public override Mesh get_mesh() { }

	public MeshFilter get_meshFilter() { }

	public MaskingTypes get_maskType() { }

	public void set_maskType(MaskingTypes value) { }

	public void SetMask(MaskingTypes type, Vector4 maskCoords) { }

	public void SetMask(MaskingTypes type, Vector4 maskCoords, float softnessX, float softnessY) { }

	public override void SetVerticesDirty() { }

	public override void SetLayoutDirty() { }

	public override void SetMaterialDirty() { }

	public override void SetAllDirty() { }

	public override void Rebuild(CanvasUpdate update) { }

	protected override void UpdateMaterial() { }

	public override void UpdateMeshPadding() { }

	public override void ForceMeshUpdate() { }

	public override void ForceMeshUpdate(bool ignoreInactive) { }

	public override TMP_TextInfo GetTextInfo(string text) { }

	public override void ClearMesh(bool updateMesh) { }

	public override void UpdateGeometry(Mesh mesh, int index) { }

	public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	public override void UpdateVertexData() { }

	public void UpdateFontAsset() { }

	public void CalculateLayoutInputHorizontal() { }

	public void CalculateLayoutInputVertical() { }

	public void .ctor() { }

}

