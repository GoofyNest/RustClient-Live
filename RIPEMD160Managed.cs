public class RIPEMD160Managed : RIPEMD160 // TypeDefIndex: 980
{
	private byte[] _buffer;
	private long _count;
	private uint[] _stateMD160;
	private uint[] _blockDWords;


	public void .ctor() { }

	public override void Initialize() { }

	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	protected override byte[] HashFinal() { }

	private void InitializeState() { }

	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	private byte[] _EndHash() { }

	private static void MDTransform(uint* blockDWords, uint* state, byte* block) { }

	private static uint F(uint x, uint y, uint z) { }

	private static uint G(uint x, uint y, uint z) { }

	private static uint H(uint x, uint y, uint z) { }

	private static uint I(uint x, uint y, uint z) { }

	private static uint J(uint x, uint y, uint z) { }

}

