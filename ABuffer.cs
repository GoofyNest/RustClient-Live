public abstract class ABuffer // TypeDefIndex: 7355
{
	internal const int OBUFFERSIZE = 2304;
	internal const int MAXCHANNELS = 2;


	protected abstract void Append(int channel, short sampleValue);

	internal virtual void AppendSamples(int channel, float[] samples) { }

	private static short Clip(float sample) { }

	internal abstract void WriteBuffer(int val);

	internal abstract void ClearBuffer();

	protected void .ctor() { }

}

