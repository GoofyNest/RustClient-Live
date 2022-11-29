internal abstract class SqlStreamChars // TypeDefIndex: 4363
{
	public abstract long Length { get; }
	public abstract long Position { get; }


	public abstract long get_Length();

	public abstract long get_Position();

	public abstract int Read(char[] buffer, int offset, int count);

	public abstract long Seek(long offset, SeekOrigin origin);

}

