public class TextMeshPro : TMP_Text, ILayoutElement // TypeDefIndex: 6866
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_hasFontAssetChanged; // 0xAD0
	private float m_previousLossyScaleY; // 0xAD4
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Renderer m_renderer; // 0xAD8
	private MeshFilter m_meshFilter; // 0xAE0
	private bool m_isFirstAllocation; // 0xAE8
	private int m_max_characters; // 0xAEC
	private int m_max_numberOfLines; // 0xAF0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected TMP_SubMesh[] m_subTextObjects; // 0xAF8
	private bool m_isMaskingEnabled; // 0xB00
	private bool isMaskUpdateRequired; // 0xB01
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private MaskingTypes m_maskType; // 0xB04
	private Matrix4x4 m_EnvMapMatrix; // 0xB08
	private Vector3[] m_RectTransformCorners; // 0xB48
	private bool m_isRegisteredForEvents; // 0xB50
	private int loopCountA; // 0xB54
	private bool m_currentAutoSizeMode; // 0xB58

	// Properties
	public int sortingLayerID { get; set; }
	public int sortingOrder { get; set; }
	public override bool autoSizeTextContainer { get; set; }
	[ObsoleteAttribute] // RVA: 0xDD830 Offset: 0xDCC30 VA: 0x1800DD830
	public TextContainer textContainer { get; }
	public Transform transform { get; }
	public Renderer renderer { get; }
	public override Mesh mesh { get; }
	public MeshFilter meshFilter { get; }
	public MaskingTypes maskType { get; set; }

	// Methods

	// RVA: 0x115BE40 Offset: 0x115B240 VA: 0x18115BE40 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1169560 Offset: 0x1168960 VA: 0x181169560 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1169500 Offset: 0x1168900 VA: 0x181169500 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x11693B0 Offset: 0x11687B0 VA: 0x1811693B0 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x1168DF0 Offset: 0x11681F0 VA: 0x181168DF0 Slot: 83
	protected override void LoadFontAsset() { }

	// RVA: 0x116D0C0 Offset: 0x116C4C0 VA: 0x18116D0C0
	private void UpdateEnvMapMatrix() { }

	// RVA: 0x116BFB0 Offset: 0x116B3B0 VA: 0x18116BFB0
	private void SetMask(MaskingTypes maskType) { }

	// RVA: 0x116BF10 Offset: 0x116B310 VA: 0x18116BF10
	private void SetMaskCoordinates(Vector4 coords) { }

	// RVA: 0x116BDF0 Offset: 0x116B1F0 VA: 0x18116BDF0
	private void SetMaskCoordinates(Vector4 coords, float softX, float softY) { }

	// RVA: 0x115CD60 Offset: 0x115C160 VA: 0x18115CD60
	private void EnableMasking() { }

	// RVA: 0x115CC10 Offset: 0x115C010 VA: 0x18115CC10
	private void DisableMasking() { }

	// RVA: 0x116D460 Offset: 0x116C860 VA: 0x18116D460
	private void UpdateMask() { }

	// RVA: 0x1168490 Offset: 0x1167890 VA: 0x181168490 Slot: 85
	protected override Material GetMaterial(Material mat) { }

	// RVA: 0x11685E0 Offset: 0x11679E0 VA: 0x1811685E0 Slot: 89
	protected override Material[] GetMaterials(Material[] mats) { }

	// RVA: 0x116CAD0 Offset: 0x116BED0 VA: 0x18116CAD0 Slot: 84
	protected override void SetSharedMaterial(Material mat) { }

	// RVA: 0x11689F0 Offset: 0x1167DF0 VA: 0x1811689F0 Slot: 87
	protected override Material[] GetSharedMaterials() { }

	// RVA: 0x116CB20 Offset: 0x116BF20 VA: 0x18116CB20 Slot: 88
	protected override void SetSharedMaterials(Material[] materials) { }

	// RVA: 0x116C710 Offset: 0x116BB10 VA: 0x18116C710 Slot: 93
	protected override void SetOutlineThickness(float thickness) { }

	// RVA: 0x116BC10 Offset: 0x116B010 VA: 0x18116BC10 Slot: 91
	protected override void SetFaceColor(Color32 color) { }

	// RVA: 0x116C5D0 Offset: 0x116B9D0 VA: 0x18116C5D0 Slot: 92
	protected override void SetOutlineColor(Color32 color) { }

	// RVA: 0x115CB40 Offset: 0x115BF40 VA: 0x18115CB40
	private void CreateMaterialInstance() { }

	// RVA: 0x116C970 Offset: 0x116BD70 VA: 0x18116C970 Slot: 94
	protected override void SetShaderDepth() { }

	// RVA: 0x116B860 Offset: 0x116AC60 VA: 0x18116B860 Slot: 95
	protected override void SetCulling() { }

	// RVA: 0x116C8A0 Offset: 0x116BCA0 VA: 0x18116C8A0
	private void SetPerspectiveCorrection() { }

	// RVA: 0x1168910 Offset: 0x1167D10 VA: 0x181168910 Slot: 97
	protected override float GetPaddingForMaterial(Material mat) { }

	// RVA: 0x11687C0 Offset: 0x1167BC0 VA: 0x1811687C0 Slot: 96
	protected override float GetPaddingForMaterial() { }

	// RVA: 0x1169BB0 Offset: 0x1168FB0 VA: 0x181169BB0 Slot: 108
	protected override int SetArraySizes(TMP_Text.UnicodeChar[] chars) { }

	// RVA: 0x115CA10 Offset: 0x115BE10 VA: 0x18115CA10 Slot: 114
	public override void ComputeMarginSize() { }

	// RVA: 0x11694E0 Offset: 0x11688E0 VA: 0x1811694E0 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x11698C0 Offset: 0x1168CC0 VA: 0x1811698C0 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x1169870 Offset: 0x1168C70 VA: 0x181169870 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x1168D00 Offset: 0x1168100 VA: 0x181168D00 Slot: 125
	internal override void InternalUpdate() { }

	// RVA: 0x11696C0 Offset: 0x1168AC0 VA: 0x1811696C0
	private void OnPreRenderObject() { }

	// RVA: 0x115CEE0 Offset: 0x115C2E0 VA: 0x18115CEE0 Slot: 109
	protected override void GenerateTextMesh() { }

	// RVA: 0x1168BB0 Offset: 0x1167FB0 VA: 0x181168BB0 Slot: 98
	protected override Vector3[] GetTextContainerLocalCorners() { }

	// RVA: 0x116C320 Offset: 0x116B720 VA: 0x18116C320
	private void SetMeshFilters(bool state) { }

	// RVA: 0x11699F0 Offset: 0x1168DF0 VA: 0x1811699F0 Slot: 120
	protected override void SetActiveSubMeshes(bool state) { }

	// RVA: 0x115C870 Offset: 0x115BC70 VA: 0x18115C870 Slot: 121
	protected override void ClearSubMeshObjects() { }

	// RVA: 0x1167FA0 Offset: 0x11673A0 VA: 0x181167FA0 Slot: 111
	protected override Bounds GetCompoundBounds() { }

	// RVA: 0x116D850 Offset: 0x116CC50 VA: 0x18116D850
	private void UpdateSDFScale(float scaleDelta) { }

	// RVA: 0x115B7A0 Offset: 0x115ABA0 VA: 0x18115B7A0 Slot: 112
	protected override void AdjustLineOffset(int startIndex, int endIndex, float offset) { }

	// RVA: 0x116E2B0 Offset: 0x116D6B0 VA: 0x18116E2B0
	public int get_sortingLayerID() { }

	// RVA: 0x116E4A0 Offset: 0x116D8A0 VA: 0x18116E4A0
	public void set_sortingLayerID(int value) { }

	// RVA: 0x116E2E0 Offset: 0x116D6E0 VA: 0x18116E2E0
	public int get_sortingOrder() { }

	// RVA: 0x116E4D0 Offset: 0x116D8D0 VA: 0x18116E4D0
	public void set_sortingOrder(int value) { }

	// RVA: 0x116E070 Offset: 0x116D470 VA: 0x18116E070 Slot: 71
	public override bool get_autoSizeTextContainer() { }

	// RVA: 0x116E3B0 Offset: 0x116D7B0 VA: 0x18116E3B0 Slot: 72
	public override void set_autoSizeTextContainer(bool value) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80
	public TextContainer get_textContainer() { }

	// RVA: 0x116E310 Offset: 0x116D710 VA: 0x18116E310
	public Transform get_transform() { }

	// RVA: 0x116E210 Offset: 0x116D610 VA: 0x18116E210
	public Renderer get_renderer() { }

	// RVA: 0x116E130 Offset: 0x116D530 VA: 0x18116E130 Slot: 73
	public override Mesh get_mesh() { }

	// RVA: 0x116E090 Offset: 0x116D490 VA: 0x18116E090
	public MeshFilter get_meshFilter() { }

	// RVA: 0x116E080 Offset: 0x116D480 VA: 0x18116E080
	public MaskingTypes get_maskType() { }

	// RVA: 0x116E490 Offset: 0x116D890 VA: 0x18116E490
	public void set_maskType(MaskingTypes value) { }

	// RVA: 0x116C170 Offset: 0x116B570 VA: 0x18116C170
	public void SetMask(MaskingTypes type, Vector4 maskCoords) { }

	// RVA: 0x116C210 Offset: 0x116B610 VA: 0x18116C210
	public void SetMask(MaskingTypes type, Vector4 maskCoords, float softnessX, float softnessY) { }

	// RVA: 0x116CF90 Offset: 0x116C390 VA: 0x18116CF90 Slot: 28
	public override void SetVerticesDirty() { }

	// RVA: 0x116BD50 Offset: 0x116B150 VA: 0x18116BD50 Slot: 27
	public override void SetLayoutDirty() { }

	// RVA: 0xD9AB90 Offset: 0xD99F90 VA: 0x180D9AB90 Slot: 29
	public override void SetMaterialDirty() { }

	// RVA: 0x1169B60 Offset: 0x1168F60 VA: 0x181169B60 Slot: 26
	public override void SetAllDirty() { }

	// RVA: 0x1169900 Offset: 0x1168D00 VA: 0x181169900 Slot: 37
	public override void Rebuild(CanvasUpdate update) { }

	// RVA: 0x116D5A0 Offset: 0x116C9A0 VA: 0x18116D5A0 Slot: 40
	protected override void UpdateMaterial() { }

	// RVA: 0x116D720 Offset: 0x116CB20 VA: 0x18116D720 Slot: 105
	public override void UpdateMeshPadding() { }

	// RVA: 0x115CEB0 Offset: 0x115C2B0 VA: 0x18115CEB0 Slot: 99
	public override void ForceMeshUpdate() { }

	// RVA: 0x115CEC0 Offset: 0x115C2C0 VA: 0x18115CEC0 Slot: 100
	public override void ForceMeshUpdate(bool ignoreInactive) { }

	// RVA: 0x1168C70 Offset: 0x1168070 VA: 0x181168C70 Slot: 113
	public override TMP_TextInfo GetTextInfo(string text) { }

	// RVA: 0x115C700 Offset: 0x115BB00 VA: 0x18115C700 Slot: 123
	public override void ClearMesh(bool updateMesh) { }

	// RVA: 0x116D440 Offset: 0x116C840 VA: 0x18116D440 Slot: 101
	public override void UpdateGeometry(Mesh mesh, int index) { }

	// RVA: 0x116DB50 Offset: 0x116CF50 VA: 0x18116DB50 Slot: 102
	public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	// RVA: 0x116DD80 Offset: 0x116D180 VA: 0x18116DD80 Slot: 103
	public override void UpdateVertexData() { }

	// RVA: 0x116D420 Offset: 0x116C820 VA: 0x18116D420
	public void UpdateFontAsset() { }

	// RVA: 0x115C480 Offset: 0x115B880 VA: 0x18115C480 Slot: 126
	public void CalculateLayoutInputHorizontal() { }

	// RVA: 0x115C5D0 Offset: 0x115B9D0 VA: 0x18115C5D0 Slot: 127
	public void CalculateLayoutInputVertical() { }

	// RVA: 0x116DFB0 Offset: 0x116D3B0 VA: 0x18116DFB0
	public void .ctor() { }

}

