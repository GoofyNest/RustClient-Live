public class Image : MaskableGraphic, ISerializationCallbackReceiver, ILayoutElement, ICanvasRaycastFilter // TypeDefIndex: 4938
{	protected static Material s_ETC1DefaultUI; // 0x0
	[FormerlySerializedAsAttribute] // RVA: 0xEC3F0 Offset: 0xEB7F0 VA: 0x1800EC3F0
	[SerializeField] // RVA: 0xEC3F0 Offset: 0xEB7F0 VA: 0x1800EC3F0
	private Sprite m_Sprite; // 0xC8
	private Sprite m_OverrideSprite; // 0xD0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Image.Type m_Type; // 0xD8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_PreserveAspect; // 0xDC
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_FillCenter; // 0xDD
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Image.FillMethod m_FillMethod; // 0xE0
	[RangeAttribute] // RVA: 0x799F0 Offset: 0x78DF0 VA: 0x1800799F0
	[SerializeField] // RVA: 0x799F0 Offset: 0x78DF0 VA: 0x1800799F0
	private float m_FillAmount; // 0xE4
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_FillClockwise; // 0xE8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int m_FillOrigin; // 0xEC
	private float m_AlphaHitTestMinimumThreshold; // 0xF0
	private bool m_Tracked; // 0xF4
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_UseSpriteMesh; // 0xF5
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_PixelsPerUnitMultiplier; // 0xF8
	private float m_CachedReferencePixelsPerUnit; // 0xFC
	private static readonly Vector2[] s_VertScratch; // 0x8
	private static readonly Vector2[] s_UVScratch; // 0x10
	private static readonly Vector3[] s_Xy; // 0x18
	private static readonly Vector3[] s_Uv; // 0x20
	private static List<Image> m_TrackedTexturelessImages; // 0x28
	private static bool s_Initialized; // 0x30

	public Sprite sprite { get; set; }
	public Sprite overrideSprite { get; set; }
	private Sprite activeSprite { get; }
	public Image.Type type { get; set; }
	public bool preserveAspect { get; set; }
	public bool fillCenter { get; set; }
	public Image.FillMethod fillMethod { get; set; }
	public float fillAmount { get; set; }
	public bool fillClockwise { get; set; }
	public int fillOrigin { get; set; }
	[ObsoleteAttribute] // RVA: 0xEC8F0 Offset: 0xEBCF0 VA: 0x1800EC8F0
	public float eventAlphaThreshold { get; set; }
	public float alphaHitTestMinimumThreshold { get; set; }
	public bool useSpriteMesh { get; set; }
	public static Material defaultETC1GraphicMaterial { get; }
	public override Texture mainTexture { get; }
	public bool hasBorder { get; }
	public float pixelsPerUnitMultiplier { get; set; }
	public float pixelsPerUnit { get; }
	protected float multipliedPixelsPerUnit { get; }
	public override Material material { get; set; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }


	public Sprite get_sprite() { }

	public void set_sprite(Sprite value) { }

	public void DisableSpriteOptimizations() { }

	public Sprite get_overrideSprite() { }

	public void set_overrideSprite(Sprite value) { }

	private Sprite get_activeSprite() { }

	public Image.Type get_type() { }

	public void set_type(Image.Type value) { }

	public bool get_preserveAspect() { }

	public void set_preserveAspect(bool value) { }

	public bool get_fillCenter() { }

	public void set_fillCenter(bool value) { }

	public Image.FillMethod get_fillMethod() { }

	public void set_fillMethod(Image.FillMethod value) { }

	public float get_fillAmount() { }

	public void set_fillAmount(float value) { }

	public bool get_fillClockwise() { }

	public void set_fillClockwise(bool value) { }

	public int get_fillOrigin() { }

	public void set_fillOrigin(int value) { }

	public float get_eventAlphaThreshold() { }

	public void set_eventAlphaThreshold(float value) { }

	public float get_alphaHitTestMinimumThreshold() { }

	public void set_alphaHitTestMinimumThreshold(float value) { }

	public bool get_useSpriteMesh() { }

	public void set_useSpriteMesh(bool value) { }

	protected void .ctor() { }

	public static Material get_defaultETC1GraphicMaterial() { }

	public override Texture get_mainTexture() { }

	public bool get_hasBorder() { }

	public float get_pixelsPerUnitMultiplier() { }

	public void set_pixelsPerUnitMultiplier(float value) { }

	public float get_pixelsPerUnit() { }

	protected float get_multipliedPixelsPerUnit() { }

	public override Material get_material() { }

	public override void set_material(Material value) { }

	public virtual void OnBeforeSerialize() { }

	public virtual void OnAfterDeserialize() { }

	private void PreserveSpriteAspectRatio(ref Rect rect, Vector2 spriteSize) { }

	private Vector4 GetDrawingDimensions(bool shouldPreserveAspect) { }

	public override void SetNativeSize() { }

	protected override void OnRectTransformDimensionsChange() { }

	protected override void OnTransformParentChanged() { }

	protected override void OnPopulateMesh(VertexHelper toFill) { }

	private void TrackSprite() { }

	protected override void OnEnable() { }

	protected override void OnDisable() { }

	protected override void UpdateMaterial() { }

	protected override void OnCanvasHierarchyChanged() { }

	private void GenerateSimpleSprite(VertexHelper vh, bool lPreserveAspect) { }

	private void GenerateSprite(VertexHelper vh, bool lPreserveAspect) { }

	private void GenerateSlicedSprite(VertexHelper toFill) { }

	private void GenerateTiledSprite(VertexHelper toFill) { }

	private static void AddQuad(VertexHelper vertexHelper, Vector3[] quadPositions, Color32 color, Vector3[] quadUVs) { }

	private static void AddQuad(VertexHelper vertexHelper, Vector2 posMin, Vector2 posMax, Color32 color, Vector2 uvMin, Vector2 uvMax) { }

	private Vector4 GetAdjustedBorders(Vector4 border, Rect adjustedRect) { }

	private void GenerateFilledSprite(VertexHelper toFill, bool preserveAspect) { }

	private static bool RadialCut(Vector3[] xy, Vector3[] uv, float fill, bool invert, int corner) { }

	private static void RadialCut(Vector3[] xy, float cos, float sin, bool invert, int corner) { }

	public virtual void CalculateLayoutInputHorizontal() { }

	public virtual void CalculateLayoutInputVertical() { }

	public virtual float get_minWidth() { }

	public virtual float get_preferredWidth() { }

	public virtual float get_flexibleWidth() { }

	public virtual float get_minHeight() { }

	public virtual float get_preferredHeight() { }

	public virtual float get_flexibleHeight() { }

	public virtual int get_layoutPriority() { }

	public virtual bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera) { }

	private Vector2 MapCoordinate(Vector2 local, Rect rect) { }

	private static void RebuildImage(SpriteAtlas spriteAtlas) { }

	private static void TrackImage(Image g) { }

	private static void UnTrackImage(Image g) { }

	private static void .cctor() { }

}

public enum Image.Type // TypeDefIndex: 4939
{	public int value__; // 0x0
	public const Image.Type Simple = 0;
	public const Image.Type Sliced = 1;
	public const Image.Type Tiled = 2;
	public const Image.Type Filled = 3;

}

public enum Image.FillMethod // TypeDefIndex: 4940
{	public int value__; // 0x0
	public const Image.FillMethod Horizontal = 0;
	public const Image.FillMethod Vertical = 1;
	public const Image.FillMethod Radial90 = 2;
	public const Image.FillMethod Radial180 = 3;
	public const Image.FillMethod Radial360 = 4;

}

public enum Image.OriginHorizontal // TypeDefIndex: 4941
{	public int value__; // 0x0
	public const Image.OriginHorizontal Left = 0;
	public const Image.OriginHorizontal Right = 1;

}

public enum Image.OriginVertical // TypeDefIndex: 4942
{	public int value__; // 0x0
	public const Image.OriginVertical Bottom = 0;
	public const Image.OriginVertical Top = 1;

}

public enum Image.Origin90 // TypeDefIndex: 4943
{	public int value__; // 0x0
	public const Image.Origin90 BottomLeft = 0;
	public const Image.Origin90 TopLeft = 1;
	public const Image.Origin90 TopRight = 2;
	public const Image.Origin90 BottomRight = 3;

}

public enum Image.Origin180 // TypeDefIndex: 4944
{	public int value__; // 0x0
	public const Image.Origin180 Bottom = 0;
	public const Image.Origin180 Left = 1;
	public const Image.Origin180 Top = 2;
	public const Image.Origin180 Right = 3;

}

public enum Image.Origin360 // TypeDefIndex: 4945
{	public int value__; // 0x0
	public const Image.Origin360 Bottom = 0;
	public const Image.Origin360 Right = 1;
	public const Image.Origin360 Top = 2;
	public const Image.Origin360 Left = 3;

}

public struct Image // TypeDefIndex: 5551
{	public uint Width; // 0x0
	public uint Height; // 0x4
	public byte[] Data; // 0x8


	public Color GetPixel(int x, int y) { }

	public override string ToString() { }

}

