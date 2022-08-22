public class FlasherLight : IOEntity // TypeDefIndex: 8714
{	public EmissionToggle toggler; // 0x288
	public Light myLight; // 0x290
	public float flashSpacing; // 0x298
	public float flashBurstSpacing; // 0x29C
	public float flashOnTime; // 0x2A0
	public int numFlashesPerBurst; // 0x2A4
	private int flashBurstCount; // 0x2A8


	public override void ResetState() { }

	public override void PostNetworkUpdate() { }

	public void Flash() { }

	public void FlashOn() { }

	public void SetOff() { }

	public void .ctor() { }

}

