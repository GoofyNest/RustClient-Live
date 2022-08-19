public class CanvasScaler : UIBehaviour // TypeDefIndex: 4959
{	// Fields
	[TooltipAttribute] // RVA: 0xF02A0 Offset: 0xEF6A0 VA: 0x1800F02A0
	[SerializeField] // RVA: 0xF02A0 Offset: 0xEF6A0 VA: 0x1800F02A0
	private CanvasScaler.ScaleMode m_UiScaleMode; // 0x18
	[TooltipAttribute] // RVA: 0xF0490 Offset: 0xEF890 VA: 0x1800F0490
	[SerializeField] // RVA: 0xF0490 Offset: 0xEF890 VA: 0x1800F0490
	protected float m_ReferencePixelsPerUnit; // 0x1C
	[TooltipAttribute] // RVA: 0xF0620 Offset: 0xEFA20 VA: 0x1800F0620
	[SerializeField] // RVA: 0xF0620 Offset: 0xEFA20 VA: 0x1800F0620
	protected float m_ScaleFactor; // 0x20
	[TooltipAttribute] // RVA: 0xF0790 Offset: 0xEFB90 VA: 0x1800F0790
	[SerializeField] // RVA: 0xF0790 Offset: 0xEFB90 VA: 0x1800F0790
	protected Vector2 m_ReferenceResolution; // 0x24
	[TooltipAttribute] // RVA: 0xF09C0 Offset: 0xEFDC0 VA: 0x1800F09C0
	[SerializeField] // RVA: 0xF09C0 Offset: 0xEFDC0 VA: 0x1800F09C0
	protected CanvasScaler.ScreenMatchMode m_ScreenMatchMode; // 0x2C
	[TooltipAttribute] // RVA: 0xF0C70 Offset: 0xF0070 VA: 0x1800F0C70
	[RangeAttribute] // RVA: 0xF0C70 Offset: 0xF0070 VA: 0x1800F0C70
	[SerializeField] // RVA: 0xF0C70 Offset: 0xF0070 VA: 0x1800F0C70
	protected float m_MatchWidthOrHeight; // 0x30
	private const float kLogBase = 2;
	[TooltipAttribute] // RVA: 0xF0DD0 Offset: 0xF01D0 VA: 0x1800F0DD0
	[SerializeField] // RVA: 0xF0DD0 Offset: 0xF01D0 VA: 0x1800F0DD0
	protected CanvasScaler.Unit m_PhysicalUnit; // 0x34
	[TooltipAttribute] // RVA: 0x6F4D0 Offset: 0x6E8D0 VA: 0x18006F4D0
	[SerializeField] // RVA: 0x6F4D0 Offset: 0x6E8D0 VA: 0x18006F4D0
	protected float m_FallbackScreenDPI; // 0x38
	[TooltipAttribute] // RVA: 0x6F740 Offset: 0x6EB40 VA: 0x18006F740
	[SerializeField] // RVA: 0x6F740 Offset: 0x6EB40 VA: 0x18006F740
	protected float m_DefaultSpriteDPI; // 0x3C
	[TooltipAttribute] // RVA: 0x6FC30 Offset: 0x6F030 VA: 0x18006FC30
	[SerializeField] // RVA: 0x6FC30 Offset: 0x6F030 VA: 0x18006FC30
	protected float m_DynamicPixelsPerUnit; // 0x40
	private Canvas m_Canvas; // 0x48
	private float m_PrevScaleFactor; // 0x50
	private float m_PrevReferencePixelsPerUnit; // 0x54

	// Properties
	public CanvasScaler.ScaleMode uiScaleMode { get; set; }
	public float referencePixelsPerUnit { get; set; }
	public float scaleFactor { get; set; }
	public Vector2 referenceResolution { get; set; }
	public CanvasScaler.ScreenMatchMode screenMatchMode { get; set; }
	public float matchWidthOrHeight { get; set; }
	public CanvasScaler.Unit physicalUnit { get; set; }
	public float fallbackScreenDPI { get; set; }
	public float defaultSpriteDPI { get; set; }
	public float dynamicPixelsPerUnit { get; set; }

	// Methods

	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200
	public CanvasScaler.ScaleMode get_uiScaleMode() { }

	// RVA: 0x7E8E20 Offset: 0x7E8220 VA: 0x1807E8E20
	public void set_uiScaleMode(CanvasScaler.ScaleMode value) { }

	// RVA: 0x7723E0 Offset: 0x7717E0 VA: 0x1807723E0
	public float get_referencePixelsPerUnit() { }

	// RVA: 0x772420 Offset: 0x771820 VA: 0x180772420
	public void set_referencePixelsPerUnit(float value) { }

	// RVA: 0x772400 Offset: 0x771800 VA: 0x180772400
	public float get_scaleFactor() { }

	// RVA: 0x10B2E60 Offset: 0x10B2260 VA: 0x1810B2E60
	public void set_scaleFactor(float value) { }

	// RVA: 0x10B2CE0 Offset: 0x10B20E0 VA: 0x1810B2CE0
	public Vector2 get_referenceResolution() { }

	// RVA: 0x10B2D80 Offset: 0x10B2180 VA: 0x1810B2D80
	public void set_referenceResolution(Vector2 value) { }

	// RVA: 0x5F7BF0 Offset: 0x5F6FF0 VA: 0x1805F7BF0
	public CanvasScaler.ScreenMatchMode get_screenMatchMode() { }

	// RVA: 0x10B2ED0 Offset: 0x10B22D0 VA: 0x1810B2ED0
	public void set_screenMatchMode(CanvasScaler.ScreenMatchMode value) { }

	// RVA: 0x516B60 Offset: 0x515F60 VA: 0x180516B60
	public float get_matchWidthOrHeight() { }

	// RVA: 0x4E2D80 Offset: 0x4E2180 VA: 0x1804E2D80
	public void set_matchWidthOrHeight(float value) { }

	// RVA: 0x5FC780 Offset: 0x5FBB80 VA: 0x1805FC780
	public CanvasScaler.Unit get_physicalUnit() { }

	// RVA: 0xD6ED70 Offset: 0xD6E170 VA: 0x180D6ED70
	public void set_physicalUnit(CanvasScaler.Unit value) { }

	// RVA: 0x10B2CD0 Offset: 0x10B20D0 VA: 0x1810B2CD0
	public float get_fallbackScreenDPI() { }

	// RVA: 0x10B2D70 Offset: 0x10B2170 VA: 0x1810B2D70
	public void set_fallbackScreenDPI(float value) { }

	// RVA: 0xA004A0 Offset: 0x9FF8A0 VA: 0x180A004A0
	public float get_defaultSpriteDPI() { }

	// RVA: 0x10B2D00 Offset: 0x10B2100 VA: 0x1810B2D00
	public void set_defaultSpriteDPI(float value) { }

	// RVA: 0x54D6A0 Offset: 0x54CAA0 VA: 0x18054D6A0
	public float get_dynamicPixelsPerUnit() { }

	// RVA: 0x54D6B0 Offset: 0x54CAB0 VA: 0x18054D6B0
	public void set_dynamicPixelsPerUnit(float value) { }

	// RVA: 0x10B2C40 Offset: 0x10B2040 VA: 0x1810B2C40
	protected void .ctor() { }

	// RVA: 0x10B2B40 Offset: 0x10B1F40 VA: 0x1810B2B40 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x10B2AD0 Offset: 0x10B1ED0 VA: 0x1810B2AD0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x10B2C20 Offset: 0x10B2020 VA: 0x1810B2C20 Slot: 17
	protected virtual void Update() { }

	// RVA: 0x10B29B0 Offset: 0x10B1DB0 VA: 0x1810B29B0 Slot: 18
	protected virtual void Handle() { }

	// RVA: 0x10B2940 Offset: 0x10B1D40 VA: 0x1810B2940 Slot: 19
	protected virtual void HandleWorldCanvas() { }

	// RVA: 0x10B25C0 Offset: 0x10B19C0 VA: 0x1810B25C0 Slot: 20
	protected virtual void HandleConstantPixelSize() { }

	// RVA: 0x10B2630 Offset: 0x10B1A30 VA: 0x1810B2630 Slot: 21
	protected virtual void HandleScaleWithScreenSize() { }

	// RVA: 0x10B24E0 Offset: 0x10B18E0 VA: 0x1810B24E0 Slot: 22
	protected virtual void HandleConstantPhysicalSize() { }

	// RVA: 0x10B2BE0 Offset: 0x10B1FE0 VA: 0x1810B2BE0
	protected void SetScaleFactor(float scaleFactor) { }

	// RVA: 0x10B2BA0 Offset: 0x10B1FA0 VA: 0x1810B2BA0
	protected void SetReferencePixelsPerUnit(float referencePixelsPerUnit) { }

}

public enum CanvasScaler.ScaleMode // TypeDefIndex: 4960
{	// Fields
	public int value__; // 0x0
	public const CanvasScaler.ScaleMode ConstantPixelSize = 0;
	public const CanvasScaler.ScaleMode ScaleWithScreenSize = 1;
	public const CanvasScaler.ScaleMode ConstantPhysicalSize = 2;

}

public enum CanvasScaler.ScreenMatchMode // TypeDefIndex: 4961
{	// Fields
	public int value__; // 0x0
	public const CanvasScaler.ScreenMatchMode MatchWidthOrHeight = 0;
	public const CanvasScaler.ScreenMatchMode Expand = 1;
	public const CanvasScaler.ScreenMatchMode Shrink = 2;

}

public enum CanvasScaler.Unit // TypeDefIndex: 4962
{	// Fields
	public int value__; // 0x0
	public const CanvasScaler.Unit Centimeters = 0;
	public const CanvasScaler.Unit Millimeters = 1;
	public const CanvasScaler.Unit Inches = 2;
	public const CanvasScaler.Unit Points = 3;
	public const CanvasScaler.Unit Picas = 4;

}

