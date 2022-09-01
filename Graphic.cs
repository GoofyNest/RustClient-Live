public abstract class Graphic : UIBehaviour, ICanvasElement // TypeDefIndex: 4931
{
	protected static Material s_DefaultUI; 
	protected static Texture2D s_WhiteTexture; 
	[FormerlySerializedAsAttribute] 
	[SerializeField] 
	protected Material m_Material; 
	[SerializeField] 
	private Color m_Color; 
	protected bool m_SkipLayoutUpdate; 
	protected bool m_SkipMaterialUpdate; 
	[SerializeField] 
	private bool m_RaycastTarget; 
	private RectTransform m_RectTransform; 
	private CanvasRenderer m_CanvasRenderer; 
	private Canvas m_Canvas; 
	private bool m_VertsDirty; 
	private bool m_MaterialDirty; 
	protected UnityAction m_OnDirtyLayoutCallback; 
	protected UnityAction m_OnDirtyVertsCallback; 
	protected UnityAction m_OnDirtyMaterialCallback; 
	protected static Mesh s_Mesh; 
	private static readonly VertexHelper s_VertexHelper; 
	protected Mesh m_CachedMesh; 
	protected Vector2[] m_CachedUvs; 
	private readonly TweenRunner<ColorTween> m_ColorTweenRunner; 
	[CompilerGeneratedAttribute] 
	private bool <useLegacyMeshGeneration>k__BackingField; 

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

	[CompilerGeneratedAttribute] 
	protected bool get_useLegacyMeshGeneration() { }

	[CompilerGeneratedAttribute] 
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

	[EditorBrowsableAttribute] 
	[ObsoleteAttribute] 
	protected virtual void OnFillVBO(List<UIVertex> vbo) { }

	[ObsoleteAttribute] 
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

