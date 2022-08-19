public class FlasherLight : IOEntity // TypeDefIndex: 8714
{	// Fields
	public EmissionToggle toggler; // 0x288
	public Light myLight; // 0x290
	public float flashSpacing; // 0x298
	public float flashBurstSpacing; // 0x29C
	public float flashOnTime; // 0x2A0
	public int numFlashesPerBurst; // 0x2A4
	private int flashBurstCount; // 0x2A8

	// Methods

	// RVA: 0x790170 Offset: 0x78F570 VA: 0x180790170 Slot: 27
	public override void ResetState() { }

	// RVA: 0x790020 Offset: 0x78F420 VA: 0x180790020 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x78FEC0 Offset: 0x78F2C0 VA: 0x18078FEC0
	public void Flash() { }

	// RVA: 0x78FE20 Offset: 0x78F220 VA: 0x18078FE20
	public void FlashOn() { }

	// RVA: 0x790230 Offset: 0x78F630 VA: 0x180790230
	public void SetOff() { }

	// RVA: 0x790270 Offset: 0x78F670 VA: 0x180790270
	public void .ctor() { }

}

