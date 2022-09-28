public class Equalizer // TypeDefIndex: 7364
{
	private const int BANDS = 32;
	internal const float BAND_NOT_PRESENT = -∞;
	internal static readonly Equalizer PassThruEq; 
	private float[] _Settings; 

	internal float[] FromFloatArray { set; }
	internal virtual Equalizer FromEqualizer { set; }
	internal virtual float[] BandFactors { get; }


	internal void .ctor() { }

	internal void set_FromFloatArray(float[] value) { }

	internal virtual void set_FromEqualizer(Equalizer value) { }

	internal virtual float[] get_BandFactors() { }

	private void InitBlock() { }

	internal void Reset() { }

	private float Limit(float eq) { }

	internal float GetBandFactor(float eq) { }

	private static void .cctor() { }

}

