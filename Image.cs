public class Image : MaskableGraphic, ISerializationCallbackReceiver, ILayoutElement, ICanvasRaycastFilter // TypeDefIndex: 4938
{	// Fields
	protected static Material s_ETC1DefaultUI; // 0x0
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

	// Properties
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

	// Methods

	// RVA: 0xD9B0A0 Offset: 0xD9A4A0 VA: 0x180D9B0A0
	public Sprite get_sprite() { }

	// RVA: 0x15F4BD0 Offset: 0x15F3FD0 VA: 0x1815F4BD0
	public void set_sprite(Sprite value) { }

	// RVA: 0x15ED230 Offset: 0x15EC630 VA: 0x1815ED230
	public void DisableSpriteOptimizations() { }

	// RVA: 0x15F44B0 Offset: 0x15F38B0 VA: 0x1815F44B0
	public Sprite get_overrideSprite() { }

	// RVA: 0x15F4A80 Offset: 0x15F3E80 VA: 0x1815F4A80
	public void set_overrideSprite(Sprite value) { }

	// RVA: 0x15F3E20 Offset: 0x15F3220 VA: 0x1815F3E20
	private Sprite get_activeSprite() { }

	// RVA: 0x104B320 Offset: 0x104A720 VA: 0x18104B320
	public Image.Type get_type() { }

	// RVA: 0x15F4EE0 Offset: 0x15F42E0 VA: 0x1815F4EE0
	public void set_type(Image.Type value) { }

	// RVA: 0x15F47E0 Offset: 0x15F3BE0 VA: 0x1815F47E0
	public bool get_preserveAspect() { }

	// RVA: 0x15F4B60 Offset: 0x15F3F60 VA: 0x1815F4B60
	public void set_preserveAspect(bool value) { }

	// RVA: 0x15F3FD0 Offset: 0x15F33D0 VA: 0x1815F3FD0
	public bool get_fillCenter() { }

	// RVA: 0x15F48C0 Offset: 0x15F3CC0 VA: 0x1815F48C0
	public void set_fillCenter(bool value) { }

	// RVA: 0x94E820 Offset: 0x94DC20 VA: 0x18094E820
	public Image.FillMethod get_fillMethod() { }

	// RVA: 0x15F49A0 Offset: 0x15F3DA0 VA: 0x1815F49A0
	public void set_fillMethod(Image.FillMethod value) { }

	// RVA: 0x12D54E0 Offset: 0x12D48E0 VA: 0x1812D54E0
	public float get_fillAmount() { }

	// RVA: 0x15F4820 Offset: 0x15F3C20 VA: 0x1815F4820
	public void set_fillAmount(float value) { }

	// RVA: 0xB09820 Offset: 0xB08C20 VA: 0x180B09820
	public bool get_fillClockwise() { }

	// RVA: 0x15F4930 Offset: 0x15F3D30 VA: 0x1815F4930
	public void set_fillClockwise(bool value) { }

	// RVA: 0x1074CA0 Offset: 0x10740A0 VA: 0x181074CA0
	public int get_fillOrigin() { }

	// RVA: 0x15F4A10 Offset: 0x15F3E10 VA: 0x1815F4A10
	public void set_fillOrigin(int value) { }

	// RVA: 0x15F3FB0 Offset: 0x15F33B0 VA: 0x1815F3FB0
	public float get_eventAlphaThreshold() { }

	// RVA: 0x15F4800 Offset: 0x15F3C00 VA: 0x1815F4800
	public void set_eventAlphaThreshold(float value) { }

	// RVA: 0x11D0290 Offset: 0x11CF690 VA: 0x1811D0290
	public float get_alphaHitTestMinimumThreshold() { }

	// RVA: 0x11D02B0 Offset: 0x11CF6B0 VA: 0x1811D02B0
	public void set_alphaHitTestMinimumThreshold(float value) { }

	// RVA: 0x15F47F0 Offset: 0x15F3BF0 VA: 0x1815F47F0
	public bool get_useSpriteMesh() { }

	// RVA: 0x15F4F50 Offset: 0x15F4350 VA: 0x1815F4F50
	public void set_useSpriteMesh(bool value) { }

	// RVA: 0x15F3DC0 Offset: 0x15F31C0 VA: 0x1815F3DC0
	protected void .ctor() { }

	// RVA: 0x15F3EB0 Offset: 0x15F32B0 VA: 0x1815F3EB0
	public static Material get_defaultETC1GraphicMaterial() { }

	// RVA: 0x15F40A0 Offset: 0x15F34A0 VA: 0x1815F40A0 Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0x15F3FE0 Offset: 0x15F33E0 VA: 0x1815F3FE0
	public bool get_hasBorder() { }

	// RVA: 0x1126D60 Offset: 0x1126160 VA: 0x181126D60
	public float get_pixelsPerUnitMultiplier() { }

	// RVA: 0x15F4AF0 Offset: 0x15F3EF0 VA: 0x1815F4AF0
	public void set_pixelsPerUnitMultiplier(float value) { }

	// RVA: 0x15F44C0 Offset: 0x15F38C0 VA: 0x1815F44C0
	public float get_pixelsPerUnit() { }

	// RVA: 0x15F4490 Offset: 0x15F3890 VA: 0x1815F4490
	protected float get_multipliedPixelsPerUnit() { }

	// RVA: 0x15F4240 Offset: 0x15F3640 VA: 0x1815F4240 Slot: 32
	public override Material get_material() { }

	// RVA: 0x15EAED0 Offset: 0x15EA2D0 VA: 0x1815EAED0 Slot: 33
	public override void set_material(Material value) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 75
	public virtual void OnBeforeSerialize() { }

	// RVA: 0x15F22F0 Offset: 0x15F16F0 VA: 0x1815F22F0 Slot: 76
	public virtual void OnAfterDeserialize() { }

	// RVA: 0x15F27F0 Offset: 0x15F1BF0 VA: 0x1815F27F0
	private void PreserveSpriteAspectRatio(ref Rect rect, Vector2 spriteSize) { }

	// RVA: 0x15F15B0 Offset: 0x15F09B0 VA: 0x1815F15B0
	private Vector4 GetDrawingDimensions(bool shouldPreserveAspect) { }

	// RVA: 0x15F34E0 Offset: 0x15F28E0 VA: 0x1815F34E0 Slot: 45
	public override void SetNativeSize() { }

	// RVA: 0x15F2710 Offset: 0x15F1B10 VA: 0x1815F2710 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x15F27D0 Offset: 0x15F1BD0 VA: 0x1815F27D0 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x15F25C0 Offset: 0x15F19C0 VA: 0x1815F25C0 Slot: 44
	protected override void OnPopulateMesh(VertexHelper toFill) { }

	// RVA: 0x15F38A0 Offset: 0x15F2CA0 VA: 0x1815F38A0
	private void TrackSprite() { }

	// RVA: 0x15F25A0 Offset: 0x15F19A0 VA: 0x1815F25A0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x15F24C0 Offset: 0x15F18C0 VA: 0x1815F24C0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x15F3B30 Offset: 0x15F2F30 VA: 0x1815F3B30 Slot: 40
	protected override void UpdateMaterial() { }

	// RVA: 0x15F23A0 Offset: 0x15F17A0 VA: 0x1815F23A0 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x15EE8F0 Offset: 0x15EDCF0 VA: 0x1815EE8F0
	private void GenerateSimpleSprite(VertexHelper vh, bool lPreserveAspect) { }

	// RVA: 0x15EF660 Offset: 0x15EEA60 VA: 0x1815EF660
	private void GenerateSprite(VertexHelper vh, bool lPreserveAspect) { }

	// RVA: 0x15EEC20 Offset: 0x15EE020 VA: 0x1815EEC20
	private void GenerateSlicedSprite(VertexHelper toFill) { }

	// RVA: 0x15EFC40 Offset: 0x15EF040 VA: 0x1815EFC40
	private void GenerateTiledSprite(VertexHelper toFill) { }

	// RVA: 0x15ED080 Offset: 0x15EC480 VA: 0x1815ED080
	private static void AddQuad(VertexHelper vertexHelper, Vector3[] quadPositions, Color32 color, Vector3[] quadUVs) { }

	// RVA: 0x15ECE50 Offset: 0x15EC250 VA: 0x1815ECE50
	private static void AddQuad(VertexHelper vertexHelper, Vector2 posMin, Vector2 posMax, Color32 color, Vector2 uvMin, Vector2 uvMax) { }

	// RVA: 0x15F1330 Offset: 0x15F0730 VA: 0x1815F1330
	private Vector4 GetAdjustedBorders(Vector4 border, Rect adjustedRect) { }

	// RVA: 0x15ED240 Offset: 0x15EC640 VA: 0x1815ED240
	private void GenerateFilledSprite(VertexHelper toFill, bool preserveAspect) { }

	// RVA: 0x15F29F0 Offset: 0x15F1DF0 VA: 0x1815F29F0
	private static bool RadialCut(Vector3[] xy, Vector3[] uv, float fill, bool invert, int corner) { }

	// RVA: 0x15F2B80 Offset: 0x15F1F80 VA: 0x1815F2B80
	private static void RadialCut(Vector3[] xy, float cos, float sin, bool invert, int corner) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 77
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 78
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x581F40 Offset: 0x581340 VA: 0x180581F40 Slot: 79
	public virtual float get_minWidth() { }

	// RVA: 0x15F46C0 Offset: 0x15F3AC0 VA: 0x1815F46C0 Slot: 80
	public virtual float get_preferredWidth() { }

	// RVA: 0xC62540 Offset: 0xC61940 VA: 0x180C62540 Slot: 81
	public virtual float get_flexibleWidth() { }

	// RVA: 0x581F40 Offset: 0x581340 VA: 0x180581F40 Slot: 82
	public virtual float get_minHeight() { }

	// RVA: 0x15F45D0 Offset: 0x15F39D0 VA: 0x1815F45D0 Slot: 83
	public virtual float get_preferredHeight() { }

	// RVA: 0xC62540 Offset: 0xC61940 VA: 0x180C62540 Slot: 84
	public virtual float get_flexibleHeight() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 85
	public virtual int get_layoutPriority() { }

	// RVA: 0x15F1A20 Offset: 0x15F0E20 VA: 0x1815F1A20 Slot: 86
	public virtual bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera) { }

	// RVA: 0x15F1E00 Offset: 0x15F1200 VA: 0x1815F1E00
	private Vector2 MapCoordinate(Vector2 local, Rect rect) { }

	// RVA: 0x15F3370 Offset: 0x15F2770 VA: 0x1815F3370
	private static void RebuildImage(SpriteAtlas spriteAtlas) { }

	// RVA: 0x15F3760 Offset: 0x15F2B60 VA: 0x1815F3760
	private static void TrackImage(Image g) { }

	// RVA: 0x15F3AB0 Offset: 0x15F2EB0 VA: 0x1815F3AB0
	private static void UnTrackImage(Image g) { }

	// RVA: 0x15F3C80 Offset: 0x15F3080 VA: 0x1815F3C80
	private static void .cctor() { }

}

public enum Image.Type // TypeDefIndex: 4939
{	// Fields
	public int value__; // 0x0
	public const Image.Type Simple = 0;
	public const Image.Type Sliced = 1;
	public const Image.Type Tiled = 2;
	public const Image.Type Filled = 3;

}

public enum Image.FillMethod // TypeDefIndex: 4940
{	// Fields
	public int value__; // 0x0
	public const Image.FillMethod Horizontal = 0;
	public const Image.FillMethod Vertical = 1;
	public const Image.FillMethod Radial90 = 2;
	public const Image.FillMethod Radial180 = 3;
	public const Image.FillMethod Radial360 = 4;

}

public enum Image.OriginHorizontal // TypeDefIndex: 4941
{	// Fields
	public int value__; // 0x0
	public const Image.OriginHorizontal Left = 0;
	public const Image.OriginHorizontal Right = 1;

}

public enum Image.OriginVertical // TypeDefIndex: 4942
{	// Fields
	public int value__; // 0x0
	public const Image.OriginVertical Bottom = 0;
	public const Image.OriginVertical Top = 1;

}

public enum Image.Origin90 // TypeDefIndex: 4943
{	// Fields
	public int value__; // 0x0
	public const Image.Origin90 BottomLeft = 0;
	public const Image.Origin90 TopLeft = 1;
	public const Image.Origin90 TopRight = 2;
	public const Image.Origin90 BottomRight = 3;

}

public enum Image.Origin180 // TypeDefIndex: 4944
{	// Fields
	public int value__; // 0x0
	public const Image.Origin180 Bottom = 0;
	public const Image.Origin180 Left = 1;
	public const Image.Origin180 Top = 2;
	public const Image.Origin180 Right = 3;

}

public enum Image.Origin360 // TypeDefIndex: 4945
{	// Fields
	public int value__; // 0x0
	public const Image.Origin360 Bottom = 0;
	public const Image.Origin360 Right = 1;
	public const Image.Origin360 Top = 2;
	public const Image.Origin360 Left = 3;

}

public struct Image // TypeDefIndex: 5551
{	// Fields
	public uint Width; // 0x0
	public uint Height; // 0x4
	public byte[] Data; // 0x8

	// Methods

	// RVA: 0x1EA7F0 Offset: 0x1E9BF0 VA: 0x1801EA7F0
	public Color GetPixel(int x, int y) { }

	// RVA: 0x1EA980 Offset: 0x1E9D80 VA: 0x1801EA980 Slot: 3
	public override string ToString() { }

}

