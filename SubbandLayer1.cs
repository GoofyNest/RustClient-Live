public class SubbandLayer1 : ASubband // TypeDefIndex: 7403
{	internal static readonly float[] TableFactor; // 0x0
	internal static readonly float[] TableOffset; // 0x8
	protected int Allocation; // 0x10
	protected float Factor; // 0x14
	protected float Offset; // 0x18
	protected float Sample; // 0x1C
	protected int Samplelength; // 0x20
	protected int Samplenumber; // 0x24
	protected float Scalefactor; // 0x28
	protected readonly int Subbandnumber; // 0x2C


	internal void .ctor(int subbandnumber) { }

	internal override void ReadAllocation(Bitstream stream, Header header, Crc16 crc) { }

	internal override void ReadScaleFactor(Bitstream stream, Header header) { }

	internal override bool ReadSampleData(Bitstream stream) { }

	internal override bool PutNextSample(int channels, SynthesisFilter filter1, SynthesisFilter filter2) { }

	private static void .cctor() { }

}

