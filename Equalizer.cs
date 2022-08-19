public class Equalizer // TypeDefIndex: 7391
{	// Fields
	private const int BANDS = 32;
	internal const float BAND_NOT_PRESENT = -∞;
	internal static readonly Equalizer PassThruEq; // 0x0
	private float[] _Settings; // 0x10

	// Properties
	internal float[] FromFloatArray { set; }
	internal virtual Equalizer FromEqualizer { set; }
	internal virtual float[] BandFactors { get; }

	// Methods

	// RVA: 0x5F7260 Offset: 0x5F6660 VA: 0x1805F7260
	internal void .ctor() { }

	// RVA: 0x5F7510 Offset: 0x5F6910 VA: 0x1805F7510
	internal void set_FromFloatArray(float[] value) { }

	// RVA: 0x5F7400 Offset: 0x5F6800 VA: 0x1805F7400 Slot: 4
	internal virtual void set_FromEqualizer(Equalizer value) { }

	// RVA: 0x5F72B0 Offset: 0x5F66B0 VA: 0x1805F72B0 Slot: 5
	internal virtual float[] get_BandFactors() { }

	// RVA: 0x5F70F0 Offset: 0x5F64F0 VA: 0x1805F70F0
	private void InitBlock() { }

	// RVA: 0x5F7170 Offset: 0x5F6570 VA: 0x1805F7170
	internal void Reset() { }

	// RVA: 0x5F7140 Offset: 0x5F6540 VA: 0x1805F7140
	private float Limit(float eq) { }

	// RVA: 0x5F7060 Offset: 0x5F6460 VA: 0x1805F7060
	internal float GetBandFactor(float eq) { }

	// RVA: 0x5F71C0 Offset: 0x5F65C0 VA: 0x1805F71C0
	private static void .cctor() { }

}

