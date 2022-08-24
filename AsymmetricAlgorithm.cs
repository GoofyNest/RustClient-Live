public abstract class AsymmetricAlgorithm : IDisposable // TypeDefIndex: 938
{
	protected int KeySizeValue; 
	protected KeySizes[] LegalKeySizesValue; 

	public virtual int KeySize { get; set; }


	protected void .ctor() { }

	public void Dispose() { }

	public void Clear() { }

	protected virtual void Dispose(bool disposing) { }

	public virtual int get_KeySize() { }

	public virtual void set_KeySize(int value) { }

	public virtual void FromXmlString(string xmlString) { }

	public virtual string ToXmlString(bool includePrivateParameters) { }

}

