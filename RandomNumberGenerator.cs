public abstract class RandomNumberGenerator : IDisposable // TypeDefIndex: 972
{
	protected void .ctor() { }

	public static RandomNumberGenerator Create() { }

	public void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	public abstract void GetBytes(byte[] data);

}

