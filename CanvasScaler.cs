public class CanvasScaler : UIBehaviour // TypeDefIndex: 4960
{
	[TooltipAttribute] 
	[SerializeField] 
	private CanvasScaler.ScaleMode m_UiScaleMode; 
	[TooltipAttribute] 
	[SerializeField] 
	protected float m_ReferencePixelsPerUnit; 
	[TooltipAttribute] 
	[SerializeField] 
	protected float m_ScaleFactor; 
	[TooltipAttribute] 
	[SerializeField] 
	protected Vector2 m_ReferenceResolution; 
	[TooltipAttribute] 
	[SerializeField] 
	protected CanvasScaler.ScreenMatchMode m_ScreenMatchMode; 
	[TooltipAttribute] 
	[RangeAttribute] 
	[SerializeField] 
	protected float m_MatchWidthOrHeight; 
	private const float kLogBase = 2;
	[TooltipAttribute] 
	[SerializeField] 
	protected CanvasScaler.Unit m_PhysicalUnit; 
	[TooltipAttribute] 
	[SerializeField] 
	protected float m_FallbackScreenDPI; 
	[TooltipAttribute] 
	[SerializeField] 
	protected float m_DefaultSpriteDPI; 
	[TooltipAttribute] 
	[SerializeField] 
	protected float m_DynamicPixelsPerUnit; 
	private Canvas m_Canvas; 
	private float m_PrevScaleFactor; 
	private float m_PrevReferencePixelsPerUnit; 

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


	public CanvasScaler.ScaleMode get_uiScaleMode() { }

	public void set_uiScaleMode(CanvasScaler.ScaleMode value) { }

	public float get_referencePixelsPerUnit() { }

	public void set_referencePixelsPerUnit(float value) { }

	public float get_scaleFactor() { }

	public void set_scaleFactor(float value) { }

	public Vector2 get_referenceResolution() { }

	public void set_referenceResolution(Vector2 value) { }

	public CanvasScaler.ScreenMatchMode get_screenMatchMode() { }

	public void set_screenMatchMode(CanvasScaler.ScreenMatchMode value) { }

	public float get_matchWidthOrHeight() { }

	public void set_matchWidthOrHeight(float value) { }

	public CanvasScaler.Unit get_physicalUnit() { }

	public void set_physicalUnit(CanvasScaler.Unit value) { }

	public float get_fallbackScreenDPI() { }

	public void set_fallbackScreenDPI(float value) { }

	public float get_defaultSpriteDPI() { }

	public void set_defaultSpriteDPI(float value) { }

	public float get_dynamicPixelsPerUnit() { }

	public void set_dynamicPixelsPerUnit(float value) { }

	protected void .ctor() { }

	protected override void OnEnable() { }

	protected override void OnDisable() { }

	protected virtual void Update() { }

	protected virtual void Handle() { }

	protected virtual void HandleWorldCanvas() { }

	protected virtual void HandleConstantPixelSize() { }

	protected virtual void HandleScaleWithScreenSize() { }

	protected virtual void HandleConstantPhysicalSize() { }

	protected void SetScaleFactor(float scaleFactor) { }

	protected void SetReferencePixelsPerUnit(float referencePixelsPerUnit) { }

}

public enum CanvasScaler.ScaleMode // TypeDefIndex: 4961
{
	public int value__; 
	public const CanvasScaler.ScaleMode ConstantPixelSize = 0;
	public const CanvasScaler.ScaleMode ScaleWithScreenSize = 1;
	public const CanvasScaler.ScaleMode ConstantPhysicalSize = 2;

}

public enum CanvasScaler.ScreenMatchMode // TypeDefIndex: 4962
{
	public int value__; 
	public const CanvasScaler.ScreenMatchMode MatchWidthOrHeight = 0;
	public const CanvasScaler.ScreenMatchMode Expand = 1;
	public const CanvasScaler.ScreenMatchMode Shrink = 2;

}

public enum CanvasScaler.Unit // TypeDefIndex: 4963
{
	public int value__; 
	public const CanvasScaler.Unit Centimeters = 0;
	public const CanvasScaler.Unit Millimeters = 1;
	public const CanvasScaler.Unit Inches = 2;
	public const CanvasScaler.Unit Points = 3;
	public const CanvasScaler.Unit Picas = 4;

}

