public class Type2Message : MessageBase // TypeDefIndex: 1732
{	private byte[] _nonce; // 0x18
	private string _targetName; // 0x20
	private byte[] _targetInfo; // 0x28

	public byte[] Nonce { get; }
	public string TargetName { get; }
	public byte[] TargetInfo { get; }


	public void .ctor(byte[] message) { }

	protected override void Finalize() { }

	public byte[] get_Nonce() { }

	public string get_TargetName() { }

	public byte[] get_TargetInfo() { }

	protected override void Decode(byte[] message) { }

	public override byte[] GetBytes() { }

}

