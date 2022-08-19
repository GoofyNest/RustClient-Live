public abstract class Graphic : UIBehaviour, ICanvasElement // TypeDefIndex: 4930
{	// Fields
	protected static Material s_DefaultUI; // 0x0
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

	// Properties
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

	// Methods

	// RVA: 0x15EA800 Offset: 0x15E9C00 VA: 0x1815EA800
	public static Material get_defaultGraphicMaterial() { }

	// RVA: 0xD623A0 Offset: 0xD617A0 VA: 0x180D623A0 Slot: 22
	public virtual Color get_color() { }

	// RVA: 0x15EAE80 Offset: 0x15EA280 VA: 0x1815EAE80 Slot: 23
	public virtual void set_color(Color value) { }

	// RVA: 0x15EACA0 Offset: 0x15EA0A0 VA: 0x1815EACA0 Slot: 24
	public virtual bool get_raycastTarget() { }

	// RVA: 0x15EAF80 Offset: 0x15EA380 VA: 0x1815EAF80 Slot: 25
	public virtual void set_raycastTarget(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x69CC20 Offset: 0x69C020 VA: 0x18069CC20
	protected bool get_useLegacyMeshGeneration() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x69CC30 Offset: 0x69C030 VA: 0x18069CC30
	protected void set_useLegacyMeshGeneration(bool value) { }

	// RVA: 0x15EA650 Offset: 0x15E9A50 VA: 0x1815EA650
	protected void .ctor() { }

	// RVA: 0x15EA030 Offset: 0x15E9430 VA: 0x1815EA030 Slot: 26
	public virtual void SetAllDirty() { }

	// RVA: 0x15EA090 Offset: 0x15E9490 VA: 0x1815EA090 Slot: 27
	public virtual void SetLayoutDirty() { }

	// RVA: 0x15EA200 Offset: 0x15E9600 VA: 0x1815EA200 Slot: 28
	public virtual void SetVerticesDirty() { }

	// RVA: 0x15EA170 Offset: 0x15E9570 VA: 0x1815EA170 Slot: 29
	public virtual void SetMaterialDirty() { }

	// RVA: 0x15E9770 Offset: 0x15E8B70 VA: 0x1815E9770 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x15E8CE0 Offset: 0x15E80E0 VA: 0x1815E8CE0 Slot: 11
	protected override void OnBeforeTransformParentChanged() { }

	// RVA: 0x15E9820 Offset: 0x15E8C20 VA: 0x1815E9820 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x15EA950 Offset: 0x15E9D50 VA: 0x1815EA950
	public int get_depth() { }

	// RVA: 0x15EACB0 Offset: 0x15EA0B0 VA: 0x1815EACB0 Slot: 30
	public RectTransform get_rectTransform() { }

	// RVA: 0x15EA780 Offset: 0x15E9B80 VA: 0x1815EA780
	public Canvas get_canvas() { }

	// RVA: 0x15E7D40 Offset: 0x15E7140 VA: 0x1815E7D40
	private void CacheCanvas() { }

	// RVA: 0x15EA720 Offset: 0x15E9B20 VA: 0x1815EA720
	public CanvasRenderer get_canvasRenderer() { }

	// RVA: 0x15EA900 Offset: 0x15E9D00 VA: 0x1815EA900 Slot: 31
	public virtual Material get_defaultMaterial() { }

	// RVA: 0x15EAC10 Offset: 0x15EA010 VA: 0x1815EAC10 Slot: 32
	public virtual Material get_material() { }

	// RVA: 0x15EAED0 Offset: 0x15EA2D0 VA: 0x1815EAED0 Slot: 33
	public virtual void set_material(Material value) { }

	// RVA: 0x15EAA20 Offset: 0x15E9E20 VA: 0x1815EAA20 Slot: 34
	public virtual Material get_materialForRendering() { }

	// RVA: 0x15EA9C0 Offset: 0x15E9DC0 VA: 0x1815EA9C0 Slot: 35
	public virtual Texture get_mainTexture() { }

	// RVA: 0x15E9280 Offset: 0x15E8680 VA: 0x1815E9280 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x15E9090 Offset: 0x15E8490 VA: 0x1815E9090 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x15E8FD0 Offset: 0x15E83D0 VA: 0x1815E8FD0 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x15E8DD0 Offset: 0x15E81D0 VA: 0x1815E8DD0 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x15E8F00 Offset: 0x15E8300 VA: 0x1815E8F00 Slot: 36
	public virtual void OnCullingChanged() { }

	// RVA: 0x15E9D50 Offset: 0x15E9150 VA: 0x1815E9D50 Slot: 37
	public virtual void Rebuild(CanvasUpdate update) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 38
	public virtual void LayoutComplete() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 39
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x15EA430 Offset: 0x15E9830 VA: 0x1815EA430 Slot: 40
	protected virtual void UpdateMaterial() { }

	// RVA: 0x15EA410 Offset: 0x15E9810 VA: 0x1815EA410 Slot: 41
	protected virtual void UpdateGeometry() { }

	// RVA: 0x15E86C0 Offset: 0x15E7AC0 VA: 0x1815E86C0
	private void DoMeshGeneration() { }

	// RVA: 0x15E82A0 Offset: 0x15E76A0 VA: 0x1815E82A0
	private void DoLegacyMeshGeneration() { }

	// RVA: 0x15EAD10 Offset: 0x15EA110 VA: 0x1815EAD10
	protected static Mesh get_workerMesh() { }

	[EditorBrowsableAttribute] // RVA: 0xEA870 Offset: 0xE9C70 VA: 0x1800EA870
	[ObsoleteAttribute] // RVA: 0xEA870 Offset: 0xE9C70 VA: 0x1800EA870
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 42
	protected virtual void OnFillVBO(List<UIVertex> vbo) { }

	[ObsoleteAttribute] // RVA: 0xEA9C0 Offset: 0xE9DC0 VA: 0x1800EA9C0
	// RVA: 0x15E93C0 Offset: 0x15E87C0 VA: 0x1815E93C0 Slot: 43
	protected virtual void OnPopulateMesh(Mesh m) { }

	// RVA: 0x15E9470 Offset: 0x15E8870 VA: 0x1815E9470 Slot: 44
	protected virtual void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0xFC61D0 Offset: 0xFC55D0 VA: 0x180FC61D0 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 45
	public virtual void SetNativeSize() { }

	// RVA: 0x15E9A30 Offset: 0x15E8E30 VA: 0x1815E9A30 Slot: 46
	public virtual bool Raycast(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x15E98E0 Offset: 0x15E8CE0 VA: 0x1815E98E0
	public Vector2 PixelAdjustPoint(Vector2 point) { }

	// RVA: 0x15E8B30 Offset: 0x15E7F30 VA: 0x1815E8B30
	public Rect GetPixelAdjustedRect() { }

	// RVA: 0x15E7FA0 Offset: 0x15E73A0 VA: 0x1815E7FA0 Slot: 47
	public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x15E7FE0 Offset: 0x15E73E0 VA: 0x1815E7FE0 Slot: 48
	public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB) { }

	// RVA: 0x15E7E90 Offset: 0x15E7290 VA: 0x1815E7E90
	private static Color CreateColorFromAlpha(float alpha) { }

	// RVA: 0x15E7ED0 Offset: 0x15E72D0 VA: 0x1815E7ED0 Slot: 49
	public virtual void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x15E9EB0 Offset: 0x15E92B0 VA: 0x1815E9EB0
	public void RegisterDirtyLayoutCallback(UnityAction action) { }

	// RVA: 0x15EA290 Offset: 0x15E9690 VA: 0x1815EA290
	public void UnregisterDirtyLayoutCallback(UnityAction action) { }

	// RVA: 0x15E9FB0 Offset: 0x15E93B0 VA: 0x1815E9FB0
	public void RegisterDirtyVerticesCallback(UnityAction action) { }

	// RVA: 0x15EA390 Offset: 0x15E9790 VA: 0x1815EA390
	public void UnregisterDirtyVerticesCallback(UnityAction action) { }

	// RVA: 0x15E9F30 Offset: 0x15E9330 VA: 0x1815E9F30
	public void RegisterDirtyMaterialCallback(UnityAction action) { }

	// RVA: 0x15EA310 Offset: 0x15E9710 VA: 0x1815EA310
	public void UnregisterDirtyMaterialCallback(UnityAction action) { }

	// RVA: 0x15EA5B0 Offset: 0x15E99B0 VA: 0x1815EA5B0
	private static void .cctor() { }

	// RVA: 0xAB8650 Offset: 0xAB7A50 VA: 0x180AB8650 Slot: 18
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }

}

