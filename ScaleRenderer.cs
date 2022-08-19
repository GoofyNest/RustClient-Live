public class ScaleRenderer : MonoBehaviour // TypeDefIndex: 9361
{	// Fields
	public bool useRandomScale; // 0x18
	public float scaleMin; // 0x1C
	public float scaleMax; // 0x20
	private float lastScale; // 0x24
	protected bool hasInitialValues; // 0x28
	public Renderer myRenderer; // 0x30

	// Methods

	// RVA: 0x49D370 Offset: 0x49C770 VA: 0x18049D370
	private bool ScaleDifferent(float newScale) { }

	// RVA: 0x49D4D0 Offset: 0x49C8D0 VA: 0x18049D4D0
	public void Start() { }

	// RVA: 0x49D430 Offset: 0x49C830 VA: 0x18049D430
	public void SetScale(float scale) { }

	// RVA: 0x49D420 Offset: 0x49C820 VA: 0x18049D420 Slot: 4
	public virtual void SetScale_Internal(float scale) { }

	// RVA: 0x49D380 Offset: 0x49C780 VA: 0x18049D380 Slot: 5
	public virtual void SetRendererEnabled(bool isEnabled) { }

	// RVA: 0x49D360 Offset: 0x49C760 VA: 0x18049D360 Slot: 6
	public virtual void GatherInitialValues() { }

	// RVA: 0x49D340 Offset: 0x49C740 VA: 0x18049D340
	public void .ctor() { }

}

