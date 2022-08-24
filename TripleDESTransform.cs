internal class TripleDESTransform : SymmetricTransform // TypeDefIndex: 1013
{
	private DESTransform E1; 
	private DESTransform D2; 
	private DESTransform E3; 
	private DESTransform D1; 
	private DESTransform E2; 
	private DESTransform D3; 


	public void .ctor(TripleDES algo, bool encryption, byte[] key, byte[] iv) { }

	protected override void ECB(byte[] input, byte[] output) { }

	internal static byte[] GetStrongKey() { }

}

