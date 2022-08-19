public abstract class SingletonComponent : FacepunchBehaviour // TypeDefIndex: 5594
{	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void SingletonSetup();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void SingletonClear();

	// RVA: 0x4D0950 Offset: 0x4CFD50 VA: 0x1804D0950 Slot: 6
	protected virtual void Awake() { }

	// RVA: 0x95B120 Offset: 0x95A520 VA: 0x18095B120 Slot: 7
	protected virtual void OnDestroy() { }

	// RVA: 0x21B7B10 Offset: 0x21B6F10 VA: 0x1821B7B10
	public static void InitializeSingletons(GameObject go) { }

	// RVA: 0x4B7D40 Offset: 0x4B7140 VA: 0x1804B7D40
	protected void .ctor() { }

}

