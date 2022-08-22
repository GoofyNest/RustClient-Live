public abstract class KeyedHashAlgorithm : HashAlgorithm // TypeDefIndex: 968
{	protected byte[] KeyValue; // 0x28

	public virtual byte[] Key { get; set; }


	protected void .ctor() { }

	protected override void Dispose(bool disposing) { }

	public virtual byte[] get_Key() { }

	public virtual void set_Key(byte[] value) { }

}

