public abstract class UpdateBehaviour : MonoBehaviour // TypeDefIndex: 11335
{	// Fields
	internal float lastUpdate; // 0x18
	internal float nextUpdate; // 0x1C

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void DeltaUpdate(float deltaTime);

	// RVA: 0x112F1F0 Offset: 0x112E5F0 VA: 0x18112F1F0
	protected void Sleep(float seconds) { }

	// RVA: 0x112F1E0 Offset: 0x112E5E0 VA: 0x18112F1E0
	protected void SleepAccumulative(float seconds) { }

	// RVA: 0x112F040 Offset: 0x112E440 VA: 0x18112F040 Slot: 5
	protected virtual void OnEnable() { }

	// RVA: 0x112EF00 Offset: 0x112E300 VA: 0x18112EF00 Slot: 6
	protected virtual void OnDisable() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	protected void .ctor() { }

}

