public abstract class Graphic : UIBehaviour, ICanvasElement // TypeDefIndex: 4930
{	protected static Material s_DefaultUI; // 0x0
	protected static Texture2D s_WhiteTexture; // 0x8
	[FormerlySerializedAsAttribute] // RVA: 0xEA3B0 Offset: 0xE97B0 VA: 0x1800EA3B0
	[SerializeField] // RVA: 0xEA3B0 Offset: 0xE97B0 VA: 0x1800EA3B0
	protected Material m_Material; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color m_Color; // 0x20
	protected bool m_SkipLayoutUpdate; // 0x30
	protected bool m_SkipMaterialUpdate; // 0x31
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_RaycastTarget; // 0x32
	private RectTransform m_RectTransform; // 0x38
	private CanvasRenderer m_CanvasRenderer; // 0x40
	private Canvas m_Canvas; // 0x48
	private bool m_VertsDirty; // 0x50
	private bool m_MaterialDirty; // 0x51
	protected UnityAction m_OnDirtyLayoutCallback; // 0x58
	protected UnityAction m_OnDirtyVertsCallback; // 0x60
	protected UnityAction m_OnDirtyMaterialCallback; // 0x68
	protected static Mesh s_Mesh; // 0x10
	private static readonly VertexHelper s_VertexHelper; // 0x18
	protected Mesh m_CachedMesh; // 0x70
	protected Vector2[] m_CachedUvs; // 0x78
	private readonly TweenRunner<ColorTween> m_ColorTweenRunner; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <useLegacyMeshGeneration>k__BackingField; // 0x88

	public static Material defaultGraphicMaterial { get; }
	public virtual Color color { get; set; }
	public virtual bool raycastTarget { get; set; }
	protected bool useLegacyMeshGeneration { get; set; }
	public int depth { get; }
	public RectTransform rectTransform { get; }
	public Canvas canvas { get; }
	public CanvasRenderer canvasRenderer { get; }
	public virtual Material defaultMaterial { get; }
	public virtual Material material { get; set; }
	public virtual Material materialForRendering { get; }
	public virtual Texture mainTexture { get; }
	protected static Mesh workerMesh { get; }


	public static Material get_defaultGraphicMaterial() { }

	public virtual Color get_color() { }

	public virtual void set_color(Color value) { }

	public virtual bool get_raycastTarget() { }

	public virtual void set_raycastTarget(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected bool get_useLegacyMeshGeneration() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected void set_useLegacyMeshGeneration(bool value) { }

	protected void .ctor() { }

	public virtual void SetAllDirty() { }

	public virtual void SetLayoutDirty() { }

	public virtual void SetVerticesDirty() { }

	public virtual void SetMaterialDirty() { }

	protected override void OnRectTransformDimensionsChange() { }

	protected override void OnBeforeTransformParentChanged() { }

	protected override void OnTransformParentChanged() { }

	public int get_depth() { }

	public RectTransform get_rectTransform() { }

	public Canvas get_canvas() { }

	private void CacheCanvas() { }

	public CanvasRenderer get_canvasRenderer() { }

	public virtual Material get_defaultMaterial() { }

	public virtual Material get_material() { }

	public virtual void set_material(Material value) { }

	public virtual Material get_materialForRendering() { }

	public virtual Texture get_mainTexture() { }

	protected override void OnEnable() { }

	protected override void OnDisable() { }

	protected override void OnDestroy() { }

	protected override void OnCanvasHierarchyChanged() { }

	public virtual void OnCullingChanged() { }

	public virtual void Rebuild(CanvasUpdate update) { }

	public virtual void LayoutComplete() { }

	public virtual void GraphicUpdateComplete() { }

	protected virtual void UpdateMaterial() { }

	protected virtual void UpdateGeometry() { }

	private void DoMeshGeneration() { }

	private void DoLegacyMeshGeneration() { }

	protected static Mesh get_workerMesh() { }

	[EditorBrowsableAttribute] // RVA: 0xEA870 Offset: 0xE9C70 VA: 0x1800EA870
	[ObsoleteAttribute] // RVA: 0xEA870 Offset: 0xE9C70 VA: 0x1800EA870
	protected virtual void OnFillVBO(List<UIVertex> vbo) { }

	[ObsoleteAttribute] // RVA: 0xEA9C0 Offset: 0xE9DC0 VA: 0x1800EA9C0
	protected virtual void OnPopulateMesh(Mesh m) { }

	protected virtual void OnPopulateMesh(VertexHelper vh) { }

	protected override void OnDidApplyAnimationProperties() { }

	public virtual void SetNativeSize() { }

	public virtual bool Raycast(Vector2 sp, Camera eventCamera) { }

	public Vector2 PixelAdjustPoint(Vector2 point) { }

	public Rect GetPixelAdjustedRect() { }

	public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB) { }

	private static Color CreateColorFromAlpha(float alpha) { }

	public virtual void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	public void RegisterDirtyLayoutCallback(UnityAction action) { }

	public void UnregisterDirtyLayoutCallback(UnityAction action) { }

	public void RegisterDirtyVerticesCallback(UnityAction action) { }

	public void UnregisterDirtyVerticesCallback(UnityAction action) { }

	public void RegisterDirtyMaterialCallback(UnityAction action) { }

	public void UnregisterDirtyMaterialCallback(UnityAction action) { }

	private static void .cctor() { }

	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }

}

