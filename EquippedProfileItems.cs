internal struct EquippedProfileItems_t : ICallbackData // TypeDefIndex: 5334
{
	internal Result Result;
	internal ulong SteamID;
	internal bool HasAnimatedAvatar;
	internal bool HasAvatarFrame;
	internal bool HasProfileModifier;
	internal bool HasProfileBackground;
	internal bool HasMiniProfileBackground;
	public static int _datasize;

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

