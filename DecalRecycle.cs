public class DecalRecycle : BasePrefab, IClientComponent, IEffectRecycle, IOnParentDestroying // TypeDefIndex: 9174
{	// Fields
	public float LifeTime; // 0x20
	private Action recycleAction; // 0x28

	// Methods

	// RVA: 0x8E60F0 Offset: 0x8E54F0 VA: 0x1808E60F0
	protected void Awake() { }

	// RVA: 0x8E6170 Offset: 0x8E5570 VA: 0x1808E6170 Slot: 10
	protected virtual void OnEnable() { }

	// RVA: 0x8E63D0 Offset: 0x8E57D0 VA: 0x1808E63D0 Slot: 8
	public void Recycle() { }

	// RVA: 0x8E63A0 Offset: 0x8E57A0 VA: 0x1808E63A0 Slot: 9
	public void OnParentDestroying() { }

	// RVA: 0x8E5A00 Offset: 0x8E4E00 VA: 0x1808E5A00
	public void .ctor() { }

}

