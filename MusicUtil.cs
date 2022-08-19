public class MusicUtil // TypeDefIndex: 9011
{	// Fields
	public const float OneSixteenth = 0,0625;

	// Methods

	// RVA: 0x7C0A10 Offset: 0x7BFE10 VA: 0x1807C0A10
	public static double BeatsToSeconds(float tempo, float beats) { }

	// RVA: 0x7C0980 Offset: 0x7BFD80 VA: 0x1807C0980
	public static double BarsToSeconds(float tempo, float bars) { }

	// RVA: 0x7C0C20 Offset: 0x7C0020 VA: 0x1807C0C20
	public static int SecondsToSamples(double seconds) { }

	// RVA: 0x7C0C80 Offset: 0x7C0080 VA: 0x1807C0C80
	public static int SecondsToSamples(double seconds, int sampleRate) { }

	// RVA: 0x7C0C50 Offset: 0x7C0050 VA: 0x1807C0C50
	public static int SecondsToSamples(float seconds) { }

	// RVA: 0x7C0C10 Offset: 0x7C0010 VA: 0x1807C0C10
	public static int SecondsToSamples(float seconds, int sampleRate) { }

	// RVA: 0x7C08E0 Offset: 0x7BFCE0 VA: 0x1807C08E0
	public static int BarsToSamples(float tempo, float bars, int sampleRate) { }

	// RVA: 0x7C0920 Offset: 0x7BFD20 VA: 0x1807C0920
	public static int BarsToSamples(float tempo, float bars) { }

	// RVA: 0x7C09B0 Offset: 0x7BFDB0 VA: 0x1807C09B0
	public static int BeatsToSamples(float tempo, float beats) { }

	// RVA: 0x7C0BF0 Offset: 0x7BFFF0 VA: 0x1807C0BF0
	public static float SecondsToBeats(float tempo, double seconds) { }

	// RVA: 0x7C0BD0 Offset: 0x7BFFD0 VA: 0x1807C0BD0
	public static float SecondsToBars(float tempo, double seconds) { }

	// RVA: 0x7C0AA0 Offset: 0x7BFEA0 VA: 0x1807C0AA0
	public static float Quantize(float position, float gridSize) { }

	// RVA: 0x7C0A30 Offset: 0x7BFE30 VA: 0x1807C0A30
	public static float FlooredQuantize(float position, float gridSize) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

