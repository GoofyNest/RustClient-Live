public class PercentFullStorageContainer : StorageContainer // TypeDefIndex: 9514
{	// Fields
	private float _clientPercentFull; // 0x3D0

	// Properties
	protected float ClientPercentFull { get; set; }

	// Methods

	// RVA: 0x949C40 Offset: 0x949040 VA: 0x180949C40
	public bool IsFull() { }

	// RVA: 0x949C00 Offset: 0x949000 VA: 0x180949C00
	public bool IsEmpty() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 155
	protected virtual void OnPercentFullChanged(float newPercentFull) { }

	// RVA: 0x949BD0 Offset: 0x948FD0 VA: 0x180949BD0
	public float GetPercentFull() { }

	// RVA: 0x949C80 Offset: 0x949080 VA: 0x180949C80 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x949D70 Offset: 0x949170 VA: 0x180949D70
	protected float get_ClientPercentFull() { }

	// RVA: 0x949D80 Offset: 0x949180 VA: 0x180949D80
	protected void set_ClientPercentFull(float value) { }

	// RVA: 0x949D10 Offset: 0x949110 VA: 0x180949D10
	public void .ctor() { }

}

