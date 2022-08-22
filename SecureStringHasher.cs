internal class SecureStringHasher : IEqualityComparer<string> // TypeDefIndex: 1866
{	private static SecureStringHasher.HashCodeOfStringDelegate hashCodeDelegate; // 0x0
	private int hashCodeRandomizer; // 0x10


	public void .ctor() { }

	public bool Equals(string x, string y) { }

	public int GetHashCode(string key) { }

	private static int GetHashCodeOfString(string key, int sLen, long additionalEntropy) { }

	private static SecureStringHasher.HashCodeOfStringDelegate GetHashCodeDelegate() { }

}

private sealed class SecureStringHasher.HashCodeOfStringDelegate : MulticastDelegate // TypeDefIndex: 1867
{
	public void .ctor(object object, IntPtr method) { }

	public virtual int Invoke(string s, int sLen, long additionalEntropy) { }

	public virtual IAsyncResult BeginInvoke(string s, int sLen, long additionalEntropy, AsyncCallback callback, object object) { }

	public virtual int EndInvoke(IAsyncResult result) { }

}

