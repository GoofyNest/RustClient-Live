internal abstract class SqlStreamChars // TypeDefIndex: 4358
{	// Properties
	public abstract long Length { get; }
	public abstract long Position { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract long get_Length();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract long get_Position();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int Read(char[] buffer, int offset, int count);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract long Seek(long offset, SeekOrigin origin);

}

