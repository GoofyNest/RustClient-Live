public static class Pool // TypeDefIndex: 4839
{
	public static Dictionary<Type, Pool.ICollection> directory; 


	public static void FreeList<T>(ref List<T> obj) { }
	/* GenericInstMethod :
	|
	|-Pool.FreeList<BaseEntity.PendingFileRequest>
	|
	|-Pool.FreeList<BaseEntity>
	|-Pool.FreeList<BaseNetworkable>
	|-Pool.FreeList<BasePlayer>
	|-Pool.FreeList<BaseVehicle>
	|-Pool.FreeList<BaseVehicleModule>
	|-Pool.FreeList<BuildingBlock>
	|-Pool.FreeList<CollectableEasterEgg>
	|-Pool.FreeList<DecalRecycle>
	|-Pool.FreeList<DroppedItem>
	|-Pool.FreeList<EffectRecycle>
	|-Pool.FreeList<EnvironmentVolume>
	|-Pool.FreeList<PlayingCard>
	|-Pool.FreeList<Input.Button>
	|-Pool.FreeList<FoliageCell>
	|-Pool.FreeList<Gib>
	|-Pool.FreeList<GraveyardFence>
	|-Pool.FreeList<HitboxDefinition>
	|-Pool.FreeList<IBlueprintsChanged>
	|-Pool.FreeList<IClothingChanged>
	|-Pool.FreeList<IEffect>
	|-Pool.FreeList<IInventoryChanged>
	|-Pool.FreeList<IItemAmountChanged>
	|-Pool.FreeList<IItemIconChanged>
	|-Pool.FreeList<IItemSetup>
	|-Pool.FreeList<IItemUpdate>
	|-Pool.FreeList<IOEntity>
	|-Pool.FreeList<IOnParentDestroying>
	|-Pool.FreeList<IOnParentSpawning>
	|-Pool.FreeList<IOnPostNetworkUpdate>
	|-Pool.FreeList<IOnSendNetworkUpdate>
	|-Pool.FreeList<IRagdollInhert>
	|-Pool.FreeList<IViewModeChanged>
	|-Pool.FreeList<IViewModelUpdated>
	|-Pool.FreeList<Item>
	|-Pool.FreeList<ItemAmount>
	|-Pool.FreeList<ItemBlueprint>
	|-Pool.FreeList<LODComponent>
	|-Pool.FreeList<LightOccludee>
	|-Pool.FreeList<MapMarker>
	|-Pool.FreeList<MaterialReplacement>
	|-Pool.FreeList<MissionEntity>
	|-Pool.FreeList<MorphCache>
	|-Pool.FreeList<Connection>
	|-Pool.FreeList<Group>
	|-Pool.FreeList<Prefab>
	|-Pool.FreeList<AIEventData>
	|-Pool.FreeList<AIStateContainer>
	|-Pool.FreeList<AppChatMessage>
	|-Pool.FreeList<AppEntityPayload.Item>
	|-Pool.FreeList<AppMap.Monument>
	|-Pool.FreeList<AppMarker.SellOrder>
	|-Pool.FreeList<AppMarker>
	|-Pool.FreeList<AppTeamInfo.Member>
	|-Pool.FreeList<AppTeamInfo.Note>
	|-Pool.FreeList<ArcadeGame.arcadeEnt>
	|-Pool.FreeList<ArcadeMachine.ScoreEntry>
	|-Pool.FreeList<BaseVehicle.MountPoint>
	|-Pool.FreeList<CardTable.CardPlayer>
	|-Pool.FreeList<CardTable.WinnerBreakdown.Winner>
	|-Pool.FreeList<ClientReady.ClientInfo>
	|-Pool.FreeList<EggHunt.EggHunter>
	|-Pool.FreeList<Entity>
	|-Pool.FreeList<FileStorageCacheData>
	|-Pool.FreeList<GameMode.PlayerScore>
	|-Pool.FreeList<GameMode.ScoreColumn>
	|-Pool.FreeList<GameMode.TeamInfo>
	|-Pool.FreeList<GenericSpawner.SpawnedEnt>
	|-Pool.FreeList<IOEntity.IOConnection.LineVec>
	|-Pool.FreeList<IOEntity.IOConnection>
	|-Pool.FreeList<InstrumentMidiBinding>
	|-Pool.FreeList<InstrumentRecordingNote>
	|-Pool.FreeList<Item>
	|-Pool.FreeList<ItemContainer>
	|-Pool.FreeList<LightString.StringPoint>
	|-Pool.FreeList<LinePoint>
	|-Pool.FreeList<MapData>
	|-Pool.FreeList<MapNote>
	|-Pool.FreeList<MarketTerminal.PendingOrder>
	|-Pool.FreeList<MissionInstance>
	|-Pool.FreeList<MissionPoint>
	|-Pool.FreeList<MissionReward>
	|-Pool.FreeList<Modifier>
	|-Pool.FreeList<NeonSign.Lights>
	|-Pool.FreeList<ObjectiveStatus>
	|-Pool.FreeList<PathData>
	|-Pool.FreeList<PatternFirework.Star>
	|-Pool.FreeList<PhoneDirectory.DirectoryEntry>
	|-Pool.FreeList<PlayerLifeStory.GenericStat>
	|-Pool.FreeList<PlayerLifeStory.WeaponStats>
	|-Pool.FreeList<PlayerNameID>
	|-Pool.FreeList<PlayerTeam.TeamMember>
	|-Pool.FreeList<PlayerTeam>
	|-Pool.FreeList<PrefabData>
	|-Pool.FreeList<ProjectileShoot.Projectile>
	|-Pool.FreeList<ReclaimManager.ReclaimInfo>
	|-Pool.FreeList<RelationshipManager.PlayerRelationshipInfo>
	|-Pool.FreeList<RelationshipManager.PlayerRelationships>
	|-Pool.FreeList<RespawnInformation.SpawnOptions>
	|-Pool.FreeList<Tree>
	|-Pool.FreeList<VehicleVendor.PlayerStorage.PlayerStoredVehicle>
	|-Pool.FreeList<VehicleVendor.PlayerStorage>
	|-Pool.FreeList<VendingMachine.SellOrder>
	|-Pool.FreeList<VendingMachine>
	|-Pool.FreeList<VoicemailEntry>
	|-Pool.FreeList<RelationshipManager.PlayerRelationshipInfo>
	|-Pool.FreeList<RendererBatch>
	|-Pool.FreeList<ItemModEngineItem>
	|-Pool.FreeList<RustButton>
	|-Pool.FreeList<ServerAdminUGCEntry>
	|-Pool.FreeList<ServerAdminUGCEntryPattern>
	|-Pool.FreeList<ShoutcastStreamer>
	|-Pool.FreeList<SleepingBag>
	|-Pool.FreeList<Socket_Base>
	|-Pool.FreeList<IEnumerator>
	|-Pool.FreeList<object>
	|-Pool.FreeList<string>
	|-Pool.FreeList<TechTreeData.NodeInstance>
	|-Pool.FreeList<TriggerBase>
	|-Pool.FreeList<AudioSource>
	|-Pool.FreeList<Collider>
	|-Pool.FreeList<GameObject>
	|-Pool.FreeList<LODGroup>
	|-Pool.FreeList<Material>
	|-Pool.FreeList<MeshRenderer>
	|-Pool.FreeList<ParticleSystem>
	|-Pool.FreeList<Renderer>
	|-Pool.FreeList<Rigidbody>
	|-Pool.FreeList<SkinnedMeshRenderer>
	|-Pool.FreeList<TrailRenderer>
	|-Pool.FreeList<Transform>
	|-Pool.FreeList<VendingMachineMapMarker>
	|-Pool.FreeList<WaterVolume>
	|-Pool.FreeList<Wearable>
	|-Pool.FreeList<WearableHairCap>
	|
	|-Pool.FreeList<FoliageGridMeshData.FoliageVertex>
	|
	|-Pool.FreeList<Option>
	|
	|-Pool.FreeList<IconSkinPicker.SkinButtonSetup>
	|
	|-Pool.FreeList<ImageStorageEntity.ImageRequest>
	|
	|-Pool.FreeList<InvokeAction>
	|
	|-Pool.FreeList<MapView.MapMarkerCluster>
	|
	|-Pool.FreeList<MapView.SleepingBagCluster>
	|
	|-Pool.FreeList<MeshColliderInstance>
	|
	|-Pool.FreeList<MeshInstance>
	|
	|-Pool.FreeList<MeshRendererInstance>
	|
	|-Pool.FreeList<DemoShotFloatKeyframe>
	|
	|-Pool.FreeList<DemoShotParentKeyframe>
	|
	|-Pool.FreeList<DemoShotQuaternionKeyframe>
	|
	|-Pool.FreeList<DemoShotVectorKeyframe>
	|
	|-Pool.FreeList<VectorData>
	|
	|-Pool.FreeList<SubmarineSonar.SonarBlip>
	|
	|-Pool.FreeList<bool>
	|
	|-Pool.FreeList<KeyValuePair<HairCapMask, Renderer>>
	|-Pool.FreeList<KeyValuePair<Int32Enum, object>>
	|
	|-Pool.FreeList<int>
	|
	|-Pool.FreeList<float>
	|
	|-Pool.FreeList<uint>
	|
	|-Pool.FreeList<ulong>
	|
	|-Pool.FreeList<ValueTuple<object, object>>
	|-Pool.FreeList<ValueTuple<string, AssetBundleRequest>>
	|
	|-Pool.FreeList<TraceInfo>
	|
	|-Pool.FreeList<Color32>
	|
	|-Pool.FreeList<RaycastHit>
	|
	|-Pool.FreeList<Vector2>
	|
	|-Pool.FreeList<Vector3>
	|
	|-Pool.FreeList<Vector4>
	|
	|-Pool.FreeList<Vector2i>
	*/

	public static void FreeMemoryStream(ref MemoryStream obj) { }

	public static void Free<T>(ref T obj) { }
	/* GenericInstMethod :
	|
	|-Pool.Free<BaseMission.MissionInstance>
	|-Pool.Free<BaseVehicle.Enumerator.Box>
	|-Pool.Free<BuildingManager.Building>
	|-Pool.Free<EffectData>
	|-Pool.Free<EngineAudioClip.Grain>
	|-Pool.Free<EntityLink>
	|-Pool.Free<FoliageGroup>
	|-Pool.Free<GranularAudioClip.Grain>
	|-Pool.Free<ImpostorBatch>
	|-Pool.Free<InputMessage>
	|-Pool.Free<LODCell>
	|-Pool.Free<ListDictionary<FoliageKey, FoliageGroup>>
	|-Pool.Free<ModelState>
	|-Pool.Free<MusicClipLoader.LoadedAudioClip>
	|-Pool.Free<MusicManager.ClipPlaybackData>
	|-Pool.Free<NativeList<uint>>
	|-Pool.Free<NativeList<Vector4>>
	|-Pool.Free<Message>
	|-Pool.Free<Networkable>
	|-Pool.Free<Stats.Node>
	|-Pool.Free<Subscriber>
	|-Pool.Free<PlayerTick>
	|-Pool.Free<PositionLerp>
	|-Pool.Free<AIDesign>
	|-Pool.Free<AIEventData>
	|-Pool.Free<AIStateContainer>
	|-Pool.Free<AggressionTimerAIEventData>
	|-Pool.Free<AmmoBelowAIEventData>
	|-Pool.Free<AppBroadcast>
	|-Pool.Free<AppChatMessage>
	|-Pool.Free<AppEmpty>
	|-Pool.Free<AppEntityChanged>
	|-Pool.Free<AppEntityInfo>
	|-Pool.Free<AppEntityPayload.Item>
	|-Pool.Free<AppEntityPayload>
	|-Pool.Free<AppError>
	|-Pool.Free<AppFlag>
	|-Pool.Free<AppInfo>
	|-Pool.Free<AppMap.Monument>
	|-Pool.Free<AppMap>
	|-Pool.Free<AppMapMarkers>
	|-Pool.Free<AppMarker.SellOrder>
	|-Pool.Free<AppMarker>
	|-Pool.Free<AppMessage>
	|-Pool.Free<AppPromoteToLeader>
	|-Pool.Free<AppRequest>
	|-Pool.Free<AppResponse>
	|-Pool.Free<AppSendMessage>
	|-Pool.Free<AppSetEntityValue>
	|-Pool.Free<AppSuccess>
	|-Pool.Free<AppTeamChanged>
	|-Pool.Free<AppTeamChat>
	|-Pool.Free<AppTeamInfo.Member>
	|-Pool.Free<AppTeamInfo.Note>
	|-Pool.Free<AppTeamInfo>
	|-Pool.Free<AppTeamMessage>
	|-Pool.Free<AppTime>
	|-Pool.Free<Approval>
	|-Pool.Free<ArcadeGame.arcadeEnt>
	|-Pool.Free<ArcadeGame>
	|-Pool.Free<ArcadeMachine.ScoreEntry>
	|-Pool.Free<ArcadeMachine>
	|-Pool.Free<Attack>
	|-Pool.Free<AudioEntity>
	|-Pool.Free<AutoTurret>
	|-Pool.Free<BaseCombat>
	|-Pool.Free<BaseEntity>
	|-Pool.Free<BaseNPC>
	|-Pool.Free<BaseNetworkable>
	|-Pool.Free<BaseOven>
	|-Pool.Free<BasePlayer>
	|-Pool.Free<BaseProjectile>
	|-Pool.Free<BaseResource>
	|-Pool.Free<BaseTrain>
	|-Pool.Free<BaseVehicle.MountPoint>
	|-Pool.Free<BaseVehicle>
	|-Pool.Free<BoomBox>
	|-Pool.Free<BradleyAPC>
	|-Pool.Free<BuildingBlock>
	|-Pool.Free<BuildingPrivilege>
	|-Pool.Free<CamperModule>
	|-Pool.Free<CardTable.CardList>
	|-Pool.Free<CardTable.CardPlayer>
	|-Pool.Free<CardTable.TexasHoldEm>
	|-Pool.Free<CardTable.WinnerBreakdown.Winner>
	|-Pool.Free<CardTable.WinnerBreakdown>
	|-Pool.Free<CardTable>
	|-Pool.Free<CargoPlane>
	|-Pool.Free<Cassette>
	|-Pool.Free<ChanceAIEventData>
	|-Pool.Free<ClientReady.ClientInfo>
	|-Pool.Free<ClientReady>
	|-Pool.Free<CoalingTower>
	|-Pool.Free<CodeLock.Private>
	|-Pool.Free<CodeLock>
	|-Pool.Free<Composter>
	|-Pool.Free<ComputerStation>
	|-Pool.Free<ConnectedSpeaker>
	|-Pool.Free<Corpse>
	|-Pool.Free<Crane>
	|-Pool.Free<CreateBuilding>
	|-Pool.Free<DecayEntity>
	|-Pool.Free<DeliveryDrone>
	|-Pool.Free<DemoHeader>
	|-Pool.Free<DemoShot>
	|-Pool.Free<DemoShotFloatTrack>
	|-Pool.Free<DemoShotParentTrack>
	|-Pool.Free<DemoShotQuaternionTrack>
	|-Pool.Free<DemoShotVectorTrack>
	|-Pool.Free<DudExplosive>
	|-Pool.Free<EggHunt.EggHunter>
	|-Pool.Free<EggHunt>
	|-Pool.Free<Elevator>
	|-Pool.Free<EngineStorage>
	|-Pool.Free<Entity>
	|-Pool.Free<EntityIdList>
	|-Pool.Free<EntityList>
	|-Pool.Free<EntitySlots>
	|-Pool.Free<Environment>
	|-Pool.Free<FileStorageCacheData>
	|-Pool.Free<FrankensteinTable>
	|-Pool.Free<GameMode.PlayerScore>
	|-Pool.Free<GameMode.ScoreColumn>
	|-Pool.Free<GameMode.TeamInfo>
	|-Pool.Free<GameMode>
	|-Pool.Free<GenericSpawner.SpawnedEnt>
	|-Pool.Free<GenericSpawner>
	|-Pool.Free<GrowableEntity>
	|-Pool.Free<HealthBelowAIEventData>
	|-Pool.Free<HeldEntity>
	|-Pool.Free<Helicopter>
	|-Pool.Free<Horse>
	|-Pool.Free<HotAirBalloon>
	|-Pool.Free<HungerAboveAIEventData>
	|-Pool.Free<IOEntity.IOConnection.LinePointList>
	|-Pool.Free<IOEntity.IOConnection.LineVec>
	|-Pool.Free<IOEntity.IOConnection>
	|-Pool.Free<IOEntity>
	|-Pool.Free<InRangeAIEventData>
	|-Pool.Free<InRangeOfHomeAIEventData>
	|-Pool.Free<InstrumentMidiBinding>
	|-Pool.Free<InstrumentMidiBindings>
	|-Pool.Free<InstrumentRecording>
	|-Pool.Free<InstrumentRecordingNote>
	|-Pool.Free<Item.ConditionData>
	|-Pool.Free<Item.InstanceData>
	|-Pool.Free<Item>
	|-Pool.Free<ItemAmountList>
	|-Pool.Free<ItemContainer>
	|-Pool.Free<KeyLock>
	|-Pool.Free<Landmine>
	|-Pool.Free<Lift>
	|-Pool.Free<LightDeployer>
	|-Pool.Free<LightString.StringPoint>
	|-Pool.Free<LightString>
	|-Pool.Free<LinePoint>
	|-Pool.Free<Loot>
	|-Pool.Free<LootableCorpse.Private>
	|-Pool.Free<LootableCorpse>
	|-Pool.Free<MLRS>
	|-Pool.Free<Magazine>
	|-Pool.Free<MapData>
	|-Pool.Free<MapEntity>
	|-Pool.Free<MapNote>
	|-Pool.Free<MapNoteList>
	|-Pool.Free<MarketTerminal.PendingOrder>
	|-Pool.Free<MarketTerminal>
	|-Pool.Free<MemoryBank>
	|-Pool.Free<MicrophoneStand>
	|-Pool.Free<Minicopter>
	|-Pool.Free<MiningQuarry>
	|-Pool.Free<MissionInstance>
	|-Pool.Free<MissionPoint>
	|-Pool.Free<MissionReward>
	|-Pool.Free<Missions>
	|-Pool.Free<MixingTable>
	|-Pool.Free<Modifier>
	|-Pool.Free<ModularCar>
	|-Pool.Free<ModularVehicle>
	|-Pool.Free<ModuleMessage>
	|-Pool.Free<Motorboat>
	|-Pool.Free<NeonSign.Lights>
	|-Pool.Free<NeonSign>
	|-Pool.Free<ObjectiveStatus>
	|-Pool.Free<OwnerInfo>
	|-Pool.Free<PaintableSign>
	|-Pool.Free<PaintedItem>
	|-Pool.Free<ParentInfo>
	|-Pool.Free<PathData>
	|-Pool.Free<PatternFirework.Design>
	|-Pool.Free<PatternFirework.SavedDesign>
	|-Pool.Free<PatternFirework.Star>
	|-Pool.Free<PatternFirework>
	|-Pool.Free<PersistantPlayer>
	|-Pool.Free<PhoneDirectory.DirectoryEntry>
	|-Pool.Free<PhoneDirectory>
	|-Pool.Free<Photo>
	|-Pool.Free<PhotoFrame>
	|-Pool.Free<PlayerAttack>
	|-Pool.Free<PlayerDetectedAIEventData>
	|-Pool.Free<PlayerInventory>
	|-Pool.Free<PlayerLifeStory.DeathInfo>
	|-Pool.Free<PlayerLifeStory.GenericStat>
	|-Pool.Free<PlayerLifeStory.WeaponStats>
	|-Pool.Free<PlayerLifeStory>
	|-Pool.Free<PlayerMetabolism>
	|-Pool.Free<PlayerModifiers>
	|-Pool.Free<PlayerNameID>
	|-Pool.Free<PlayerProjectileAttack>
	|-Pool.Free<PlayerProjectileRicochet>
	|-Pool.Free<PlayerProjectileUpdate>
	|-Pool.Free<PlayerState>
	|-Pool.Free<PlayerTeam.TeamMember>
	|-Pool.Free<PlayerTeam>
	|-Pool.Free<PlayerUpdateLoot>
	|-Pool.Free<PrefabData>
	|-Pool.Free<ProjectileShoot.Projectile>
	|-Pool.Free<ProjectileShoot>
	|-Pool.Free<PuzzleReset>
	|-Pool.Free<RCEntity>
	|-Pool.Free<RadioList>
	|-Pool.Free<ReclaimManager.ReclaimInfo>
	|-Pool.Free<ReclaimManager>
	|-Pool.Free<ReclaimTerminal>
	|-Pool.Free<RelationshipManager.PlayerRelationshipInfo>
	|-Pool.Free<RelationshipManager.PlayerRelationships>
	|-Pool.Free<RelationshipManager>
	|-Pool.Free<ResearchTable>
	|-Pool.Free<ResourceExtractor>
	|-Pool.Free<RespawnInformation.SpawnOptions>
	|-Pool.Free<RespawnInformation>
	|-Pool.Free<SAMSite>
	|-Pool.Free<ServerGib>
	|-Pool.Free<ShopKeeper>
	|-Pool.Free<Sign>
	|-Pool.Free<SimpleFloat>
	|-Pool.Free<SimpleUID>
	|-Pool.Free<SkullTrophy>
	|-Pool.Free<SleepingBag>
	|-Pool.Free<SleepingBagCamper>
	|-Pool.Free<SlotMachine>
	|-Pool.Free<SmartAlarm>
	|-Pool.Free<Snowmobile>
	|-Pool.Free<Spawnable>
	|-Pool.Free<SphereEntity>
	|-Pool.Free<SpinnerWheel>
	|-Pool.Free<Spray>
	|-Pool.Free<SprayLine>
	|-Pool.Free<SprayList>
	|-Pool.Free<StabilityEntity>
	|-Pool.Free<StorageBox>
	|-Pool.Free<SubEntityList>
	|-Pool.Free<Submarine>
	|-Pool.Free<TakeDamage>
	|-Pool.Free<TargetDetectedAIEventData>
	|-Pool.Free<Telephone>
	|-Pool.Free<ThreatDetectedAIEventData>
	|-Pool.Free<TimeSinceThreatAIEventData>
	|-Pool.Free<TimerAIEventData>
	|-Pool.Free<TirednessAboveAIEventData>
	|-Pool.Free<TrainEngine>
	|-Pool.Free<Tree>
	|-Pool.Free<TreeList>
	|-Pool.Free<UpdateItem>
	|-Pool.Free<UpdateItemContainer>
	|-Pool.Free<VehicleLift>
	|-Pool.Free<VehicleModule>
	|-Pool.Free<VehicleVendor.PlayerStorage.PlayerStoredVehicle>
	|-Pool.Free<VehicleVendor.PlayerStorage>
	|-Pool.Free<VehicleVendor>
	|-Pool.Free<VendingMachine.SellOrder>
	|-Pool.Free<VendingMachine.SellOrderContainer>
	|-Pool.Free<VendingMachine>
	|-Pool.Free<VoicemailEntry>
	|-Pool.Free<WaterPool>
	|-Pool.Free<WaterWell>
	|-Pool.Free<Whitelist>
	|-Pool.Free<WorldData>
	|-Pool.Free<WorldItem>
	|-Pool.Free<WorldMessage>
	|-Pool.Free<Zipline>
	|-Pool.Free<ZiplineArrivalPoint>
	|-Pool.Free<ZiplineMountable>
	|-Pool.Free<RelationshipManager.PlayerRelationshipInfo>
	|-Pool.Free<RendererCell>
	|-Pool.Free<RendererGroup>
	|-Pool.Free<SimpleList<Matrix4x4>>
	|-Pool.Free<SimpleList<WaterDynamics.InstanceData>>
	|-Pool.Free<SlicedGranularAudioClip.Grain>
	|-Pool.Free<SoundModulation.Modulator>
	|-Pool.Free<Dictionary<ulong, RelationshipManager.PlayerRelationshipInfo>>
	|-Pool.Free<Dictionary<ulong, RelationshipManager.PlayerRelationshipInfo>>
	|-Pool.Free<HashSet<int>>
	|-Pool.Free<HashSet<ulong>>
	|-Pool.Free<List<int>>
	|-Pool.Free<Stopwatch>
	|-Pool.Free<object>
	|-Pool.Free<StringBuilder>
	|-Pool.Free<WaitForSecondsRealtimeEx>
	|-Pool.Free<WaterDynamics.InstanceBatch>
	*/

	public static void FreeDynamic<T>(ref T obj) { }
	/* GenericInstMethod :
	|
	|-Pool.FreeDynamic<object>
	*/

	private static void FreeInternal<T>(ref T obj) { }
	/* GenericInstMethod :
	|
	|-Pool.FreeInternal<MemoryStream>
	|-Pool.FreeInternal<object>
	*/

	public static T Get<T>() { }
	/* GenericInstMethod :
	|
	|-Pool.Get<BaseMission.MissionInstance>
	|-Pool.Get<BaseVehicle.Enumerator.Box>
	|-Pool.Get<BuildingManager.Building>
	|-Pool.Get<EffectData>
	|-Pool.Get<EngineAudioClip.Grain>
	|-Pool.Get<EntityLink>
	|-Pool.Get<FoliageGroup>
	|-Pool.Get<GranularAudioClip.Grain>
	|-Pool.Get<ImpostorBatch>
	|-Pool.Get<InputMessage>
	|-Pool.Get<LODCell>
	|-Pool.Get<ListDictionary<FoliageKey, FoliageGroup>>
	|-Pool.Get<ModelState>
	|-Pool.Get<MusicClipLoader.LoadedAudioClip>
	|-Pool.Get<MusicManager.ClipPlaybackData>
	|-Pool.Get<NativeList<uint>>
	|-Pool.Get<NativeList<Vector4>>
	|-Pool.Get<Message>
	|-Pool.Get<Networkable>
	|-Pool.Get<Subscriber>
	|-Pool.Get<PlayerTick>
	|-Pool.Get<PositionLerp>
	|-Pool.Get<AIDesign>
	|-Pool.Get<AIEventData>
	|-Pool.Get<AIStateContainer>
	|-Pool.Get<AggressionTimerAIEventData>
	|-Pool.Get<AmmoBelowAIEventData>
	|-Pool.Get<AppBroadcast>
	|-Pool.Get<AppChatMessage>
	|-Pool.Get<AppEmpty>
	|-Pool.Get<AppEntityChanged>
	|-Pool.Get<AppEntityInfo>
	|-Pool.Get<AppEntityPayload.Item>
	|-Pool.Get<AppEntityPayload>
	|-Pool.Get<AppError>
	|-Pool.Get<AppFlag>
	|-Pool.Get<AppInfo>
	|-Pool.Get<AppMap.Monument>
	|-Pool.Get<AppMap>
	|-Pool.Get<AppMapMarkers>
	|-Pool.Get<AppMarker.SellOrder>
	|-Pool.Get<AppMarker>
	|-Pool.Get<AppMessage>
	|-Pool.Get<AppPromoteToLeader>
	|-Pool.Get<AppRequest>
	|-Pool.Get<AppResponse>
	|-Pool.Get<AppSendMessage>
	|-Pool.Get<AppSetEntityValue>
	|-Pool.Get<AppSuccess>
	|-Pool.Get<AppTeamChanged>
	|-Pool.Get<AppTeamChat>
	|-Pool.Get<AppTeamInfo.Member>
	|-Pool.Get<AppTeamInfo.Note>
	|-Pool.Get<AppTeamInfo>
	|-Pool.Get<AppTeamMessage>
	|-Pool.Get<AppTime>
	|-Pool.Get<Approval>
	|-Pool.Get<ArcadeGame.arcadeEnt>
	|-Pool.Get<ArcadeGame>
	|-Pool.Get<ArcadeMachine.ScoreEntry>
	|-Pool.Get<ArcadeMachine>
	|-Pool.Get<Attack>
	|-Pool.Get<AudioEntity>
	|-Pool.Get<AutoTurret>
	|-Pool.Get<BaseCombat>
	|-Pool.Get<BaseEntity>
	|-Pool.Get<BaseNPC>
	|-Pool.Get<BaseNetworkable>
	|-Pool.Get<BaseOven>
	|-Pool.Get<BasePlayer>
	|-Pool.Get<BaseProjectile>
	|-Pool.Get<BaseResource>
	|-Pool.Get<BaseTrain>
	|-Pool.Get<BaseVehicle.MountPoint>
	|-Pool.Get<BaseVehicle>
	|-Pool.Get<BoomBox>
	|-Pool.Get<BradleyAPC>
	|-Pool.Get<BuildingBlock>
	|-Pool.Get<BuildingPrivilege>
	|-Pool.Get<CamperModule>
	|-Pool.Get<CardTable.CardList>
	|-Pool.Get<CardTable.CardPlayer>
	|-Pool.Get<CardTable.TexasHoldEm>
	|-Pool.Get<CardTable.WinnerBreakdown.Winner>
	|-Pool.Get<CardTable.WinnerBreakdown>
	|-Pool.Get<CardTable>
	|-Pool.Get<CargoPlane>
	|-Pool.Get<Cassette>
	|-Pool.Get<ChanceAIEventData>
	|-Pool.Get<ClientReady.ClientInfo>
	|-Pool.Get<ClientReady>
	|-Pool.Get<CoalingTower>
	|-Pool.Get<CodeLock.Private>
	|-Pool.Get<CodeLock>
	|-Pool.Get<Composter>
	|-Pool.Get<ComputerStation>
	|-Pool.Get<ConnectedSpeaker>
	|-Pool.Get<Corpse>
	|-Pool.Get<Crane>
	|-Pool.Get<CreateBuilding>
	|-Pool.Get<DecayEntity>
	|-Pool.Get<DeliveryDrone>
	|-Pool.Get<DemoHeader>
	|-Pool.Get<DemoShot>
	|-Pool.Get<DemoShotFloatTrack>
	|-Pool.Get<DemoShotParentTrack>
	|-Pool.Get<DemoShotQuaternionTrack>
	|-Pool.Get<DemoShotVectorTrack>
	|-Pool.Get<DudExplosive>
	|-Pool.Get<EggHunt.EggHunter>
	|-Pool.Get<EggHunt>
	|-Pool.Get<Elevator>
	|-Pool.Get<EngineStorage>
	|-Pool.Get<Entity>
	|-Pool.Get<EntityIdList>
	|-Pool.Get<EntityList>
	|-Pool.Get<EntitySlots>
	|-Pool.Get<Environment>
	|-Pool.Get<FileStorageCacheData>
	|-Pool.Get<FrankensteinTable>
	|-Pool.Get<GameMode.PlayerScore>
	|-Pool.Get<GameMode.ScoreColumn>
	|-Pool.Get<GameMode.TeamInfo>
	|-Pool.Get<GameMode>
	|-Pool.Get<GenericSpawner.SpawnedEnt>
	|-Pool.Get<GenericSpawner>
	|-Pool.Get<GrowableEntity>
	|-Pool.Get<HealthBelowAIEventData>
	|-Pool.Get<HeldEntity>
	|-Pool.Get<Helicopter>
	|-Pool.Get<Horse>
	|-Pool.Get<HotAirBalloon>
	|-Pool.Get<HungerAboveAIEventData>
	|-Pool.Get<IOEntity.IOConnection.LinePointList>
	|-Pool.Get<IOEntity.IOConnection.LineVec>
	|-Pool.Get<IOEntity.IOConnection>
	|-Pool.Get<IOEntity>
	|-Pool.Get<InRangeAIEventData>
	|-Pool.Get<InRangeOfHomeAIEventData>
	|-Pool.Get<InstrumentMidiBinding>
	|-Pool.Get<InstrumentMidiBindings>
	|-Pool.Get<InstrumentRecording>
	|-Pool.Get<InstrumentRecordingNote>
	|-Pool.Get<Item.ConditionData>
	|-Pool.Get<Item.InstanceData>
	|-Pool.Get<Item>
	|-Pool.Get<ItemAmountList>
	|-Pool.Get<ItemContainer>
	|-Pool.Get<KeyLock>
	|-Pool.Get<Landmine>
	|-Pool.Get<Lift>
	|-Pool.Get<LightDeployer>
	|-Pool.Get<LightString.StringPoint>
	|-Pool.Get<LightString>
	|-Pool.Get<LinePoint>
	|-Pool.Get<Loot>
	|-Pool.Get<LootableCorpse.Private>
	|-Pool.Get<LootableCorpse>
	|-Pool.Get<MLRS>
	|-Pool.Get<Magazine>
	|-Pool.Get<MapData>
	|-Pool.Get<MapEntity>
	|-Pool.Get<MapNote>
	|-Pool.Get<MapNoteList>
	|-Pool.Get<MarketTerminal.PendingOrder>
	|-Pool.Get<MarketTerminal>
	|-Pool.Get<MemoryBank>
	|-Pool.Get<MicrophoneStand>
	|-Pool.Get<Minicopter>
	|-Pool.Get<MiningQuarry>
	|-Pool.Get<MissionInstance>
	|-Pool.Get<MissionPoint>
	|-Pool.Get<MissionReward>
	|-Pool.Get<Missions>
	|-Pool.Get<MixingTable>
	|-Pool.Get<Modifier>
	|-Pool.Get<ModularCar>
	|-Pool.Get<ModularVehicle>
	|-Pool.Get<ModuleMessage>
	|-Pool.Get<Motorboat>
	|-Pool.Get<NeonSign.Lights>
	|-Pool.Get<NeonSign>
	|-Pool.Get<ObjectiveStatus>
	|-Pool.Get<OwnerInfo>
	|-Pool.Get<PaintableSign>
	|-Pool.Get<PaintedItem>
	|-Pool.Get<ParentInfo>
	|-Pool.Get<PathData>
	|-Pool.Get<PatternFirework.Design>
	|-Pool.Get<PatternFirework.SavedDesign>
	|-Pool.Get<PatternFirework.Star>
	|-Pool.Get<PatternFirework>
	|-Pool.Get<PersistantPlayer>
	|-Pool.Get<PhoneDirectory.DirectoryEntry>
	|-Pool.Get<PhoneDirectory>
	|-Pool.Get<Photo>
	|-Pool.Get<PhotoFrame>
	|-Pool.Get<PlayerAttack>
	|-Pool.Get<PlayerDetectedAIEventData>
	|-Pool.Get<PlayerInventory>
	|-Pool.Get<PlayerLifeStory.DeathInfo>
	|-Pool.Get<PlayerLifeStory.GenericStat>
	|-Pool.Get<PlayerLifeStory.WeaponStats>
	|-Pool.Get<PlayerLifeStory>
	|-Pool.Get<PlayerMetabolism>
	|-Pool.Get<PlayerModifiers>
	|-Pool.Get<PlayerNameID>
	|-Pool.Get<PlayerProjectileAttack>
	|-Pool.Get<PlayerProjectileRicochet>
	|-Pool.Get<PlayerProjectileUpdate>
	|-Pool.Get<PlayerState>
	|-Pool.Get<PlayerTeam.TeamMember>
	|-Pool.Get<PlayerTeam>
	|-Pool.Get<PlayerUpdateLoot>
	|-Pool.Get<PrefabData>
	|-Pool.Get<ProjectileShoot.Projectile>
	|-Pool.Get<ProjectileShoot>
	|-Pool.Get<PuzzleReset>
	|-Pool.Get<RCEntity>
	|-Pool.Get<RadioList>
	|-Pool.Get<ReclaimManager.ReclaimInfo>
	|-Pool.Get<ReclaimManager>
	|-Pool.Get<ReclaimTerminal>
	|-Pool.Get<RelationshipManager.PlayerRelationshipInfo>
	|-Pool.Get<RelationshipManager.PlayerRelationships>
	|-Pool.Get<RelationshipManager>
	|-Pool.Get<ResearchTable>
	|-Pool.Get<ResourceExtractor>
	|-Pool.Get<RespawnInformation.SpawnOptions>
	|-Pool.Get<RespawnInformation>
	|-Pool.Get<SAMSite>
	|-Pool.Get<ServerGib>
	|-Pool.Get<ShopKeeper>
	|-Pool.Get<Sign>
	|-Pool.Get<SimpleFloat>
	|-Pool.Get<SimpleUID>
	|-Pool.Get<SkullTrophy>
	|-Pool.Get<SleepingBag>
	|-Pool.Get<SleepingBagCamper>
	|-Pool.Get<SlotMachine>
	|-Pool.Get<SmartAlarm>
	|-Pool.Get<Snowmobile>
	|-Pool.Get<Spawnable>
	|-Pool.Get<SphereEntity>
	|-Pool.Get<SpinnerWheel>
	|-Pool.Get<Spray>
	|-Pool.Get<SprayLine>
	|-Pool.Get<SprayList>
	|-Pool.Get<StabilityEntity>
	|-Pool.Get<StorageBox>
	|-Pool.Get<SubEntityList>
	|-Pool.Get<Submarine>
	|-Pool.Get<TakeDamage>
	|-Pool.Get<TargetDetectedAIEventData>
	|-Pool.Get<Telephone>
	|-Pool.Get<ThreatDetectedAIEventData>
	|-Pool.Get<TimeSinceThreatAIEventData>
	|-Pool.Get<TimerAIEventData>
	|-Pool.Get<TirednessAboveAIEventData>
	|-Pool.Get<TrainEngine>
	|-Pool.Get<Tree>
	|-Pool.Get<TreeList>
	|-Pool.Get<UpdateItem>
	|-Pool.Get<UpdateItemContainer>
	|-Pool.Get<VehicleLift>
	|-Pool.Get<VehicleModule>
	|-Pool.Get<VehicleVendor.PlayerStorage.PlayerStoredVehicle>
	|-Pool.Get<VehicleVendor.PlayerStorage>
	|-Pool.Get<VehicleVendor>
	|-Pool.Get<VendingMachine.SellOrder>
	|-Pool.Get<VendingMachine.SellOrderContainer>
	|-Pool.Get<VendingMachine>
	|-Pool.Get<VoicemailEntry>
	|-Pool.Get<WaterPool>
	|-Pool.Get<WaterWell>
	|-Pool.Get<Whitelist>
	|-Pool.Get<WorldData>
	|-Pool.Get<WorldItem>
	|-Pool.Get<WorldMessage>
	|-Pool.Get<Zipline>
	|-Pool.Get<ZiplineArrivalPoint>
	|-Pool.Get<ZiplineMountable>
	|-Pool.Get<RelationshipManager.PlayerRelationshipInfo>
	|-Pool.Get<RelationshipManager.PlayerRelationships>
	|-Pool.Get<RendererCell>
	|-Pool.Get<RendererGroup>
	|-Pool.Get<SimpleList<Matrix4x4>>
	|-Pool.Get<SimpleList<WaterDynamics.InstanceData>>
	|-Pool.Get<SlicedGranularAudioClip.Grain>
	|-Pool.Get<SoundModulation.Modulator>
	|-Pool.Get<Dictionary<string, Stats.Node>>
	|-Pool.Get<Dictionary<ulong, RelationshipManager.PlayerRelationshipInfo>>
	|-Pool.Get<Dictionary<ulong, RelationshipManager.PlayerRelationshipInfo>>
	|-Pool.Get<HashSet<int>>
	|-Pool.Get<HashSet<ulong>>
	|-Pool.Get<List<AIEventData>>
	|-Pool.Get<List<AIStateContainer>>
	|-Pool.Get<List<AppChatMessage>>
	|-Pool.Get<List<AppEntityPayload.Item>>
	|-Pool.Get<List<AppMap.Monument>>
	|-Pool.Get<List<AppMarker.SellOrder>>
	|-Pool.Get<List<AppMarker>>
	|-Pool.Get<List<AppTeamInfo.Member>>
	|-Pool.Get<List<AppTeamInfo.Note>>
	|-Pool.Get<List<ArcadeGame.arcadeEnt>>
	|-Pool.Get<List<ArcadeMachine.ScoreEntry>>
	|-Pool.Get<List<BaseVehicle.MountPoint>>
	|-Pool.Get<List<CardTable.CardPlayer>>
	|-Pool.Get<List<CardTable.WinnerBreakdown.Winner>>
	|-Pool.Get<List<ClientReady.ClientInfo>>
	|-Pool.Get<List<DemoShotFloatKeyframe>>
	|-Pool.Get<List<DemoShotParentKeyframe>>
	|-Pool.Get<List<DemoShotQuaternionKeyframe>>
	|-Pool.Get<List<DemoShotVectorKeyframe>>
	|-Pool.Get<List<EggHunt.EggHunter>>
	|-Pool.Get<List<Entity>>
	|-Pool.Get<List<FileStorageCacheData>>
	|-Pool.Get<List<GameMode.PlayerScore>>
	|-Pool.Get<List<GameMode.ScoreColumn>>
	|-Pool.Get<List<GameMode.TeamInfo>>
	|-Pool.Get<List<GenericSpawner.SpawnedEnt>>
	|-Pool.Get<List<IOEntity.IOConnection.LineVec>>
	|-Pool.Get<List<IOEntity.IOConnection>>
	|-Pool.Get<List<InstrumentMidiBinding>>
	|-Pool.Get<List<InstrumentRecordingNote>>
	|-Pool.Get<List<Item>>
	|-Pool.Get<List<ItemContainer>>
	|-Pool.Get<List<LightString.StringPoint>>
	|-Pool.Get<List<LinePoint>>
	|-Pool.Get<List<MapData>>
	|-Pool.Get<List<MapNote>>
	|-Pool.Get<List<MarketTerminal.PendingOrder>>
	|-Pool.Get<List<MissionInstance>>
	|-Pool.Get<List<MissionPoint>>
	|-Pool.Get<List<MissionReward>>
	|-Pool.Get<List<Modifier>>
	|-Pool.Get<List<NeonSign.Lights>>
	|-Pool.Get<List<ObjectiveStatus>>
	|-Pool.Get<List<PathData>>
	|-Pool.Get<List<PatternFirework.Star>>
	|-Pool.Get<List<PhoneDirectory.DirectoryEntry>>
	|-Pool.Get<List<PlayerLifeStory.GenericStat>>
	|-Pool.Get<List<PlayerLifeStory.WeaponStats>>
	|-Pool.Get<List<PlayerNameID>>
	|-Pool.Get<List<PlayerTeam.TeamMember>>
	|-Pool.Get<List<PlayerTeam>>
	|-Pool.Get<List<PrefabData>>
	|-Pool.Get<List<ProjectileShoot.Projectile>>
	|-Pool.Get<List<ReclaimManager.ReclaimInfo>>
	|-Pool.Get<List<RelationshipManager.PlayerRelationshipInfo>>
	|-Pool.Get<List<RelationshipManager.PlayerRelationships>>
	|-Pool.Get<List<RespawnInformation.SpawnOptions>>
	|-Pool.Get<List<Tree>>
	|-Pool.Get<List<VectorData>>
	|-Pool.Get<List<VehicleVendor.PlayerStorage.PlayerStoredVehicle>>
	|-Pool.Get<List<VehicleVendor.PlayerStorage>>
	|-Pool.Get<List<VendingMachine.SellOrder>>
	|-Pool.Get<List<VoicemailEntry>>
	|-Pool.Get<List<int>>
	|-Pool.Get<List<float>>
	|-Pool.Get<List<string>>
	|-Pool.Get<List<uint>>
	|-Pool.Get<List<ulong>>
	|-Pool.Get<List<TriggerBase>>
	|-Pool.Get<Stopwatch>
	|-Pool.Get<MemoryStream>
	|-Pool.Get<StringBuilder>
	|-Pool.Get<WaitForSecondsRealtimeEx>
	|-Pool.Get<WaterDynamics.InstanceBatch>
	|-Pool.Get<object>
	*/

	public static List<T> GetList<T>() { }
	/* GenericInstMethod :
	|
	|-Pool.GetList<BaseEntity.PendingFileRequest>
	|
	|-Pool.GetList<BaseEntity>
	|-Pool.GetList<BaseNetworkable>
	|-Pool.GetList<BasePlayer>
	|-Pool.GetList<BaseVehicle>
	|-Pool.GetList<BaseVehicleModule>
	|-Pool.GetList<BuildingBlock>
	|-Pool.GetList<CollectableEasterEgg>
	|-Pool.GetList<DecalRecycle>
	|-Pool.GetList<DroppedItem>
	|-Pool.GetList<EffectRecycle>
	|-Pool.GetList<EnvironmentVolume>
	|-Pool.GetList<PlayingCard>
	|-Pool.GetList<Input.Button>
	|-Pool.GetList<FoliageCell>
	|-Pool.GetList<Gib>
	|-Pool.GetList<GraveyardFence>
	|-Pool.GetList<HitboxDefinition>
	|-Pool.GetList<IBlueprintsChanged>
	|-Pool.GetList<IClothingChanged>
	|-Pool.GetList<IEffect>
	|-Pool.GetList<IInventoryChanged>
	|-Pool.GetList<IItemAmountChanged>
	|-Pool.GetList<IItemIconChanged>
	|-Pool.GetList<IItemSetup>
	|-Pool.GetList<IItemUpdate>
	|-Pool.GetList<IOEntity>
	|-Pool.GetList<IOnParentDestroying>
	|-Pool.GetList<IOnParentSpawning>
	|-Pool.GetList<IOnPostNetworkUpdate>
	|-Pool.GetList<IOnSendNetworkUpdate>
	|-Pool.GetList<IRagdollInhert>
	|-Pool.GetList<IViewModeChanged>
	|-Pool.GetList<IViewModelUpdated>
	|-Pool.GetList<Item>
	|-Pool.GetList<ItemAmount>
	|-Pool.GetList<ItemBlueprint>
	|-Pool.GetList<LODComponent>
	|-Pool.GetList<LightOccludee>
	|-Pool.GetList<MapMarker>
	|-Pool.GetList<MaterialReplacement>
	|-Pool.GetList<MissionEntity>
	|-Pool.GetList<MorphCache>
	|-Pool.GetList<Connection>
	|-Pool.GetList<Group>
	|-Pool.GetList<Prefab>
	|-Pool.GetList<AIEventData>
	|-Pool.GetList<AIStateContainer>
	|-Pool.GetList<AppChatMessage>
	|-Pool.GetList<AppEntityPayload.Item>
	|-Pool.GetList<AppMap.Monument>
	|-Pool.GetList<AppMarker.SellOrder>
	|-Pool.GetList<AppMarker>
	|-Pool.GetList<AppTeamInfo.Member>
	|-Pool.GetList<AppTeamInfo.Note>
	|-Pool.GetList<ArcadeGame.arcadeEnt>
	|-Pool.GetList<ArcadeMachine.ScoreEntry>
	|-Pool.GetList<BaseVehicle.MountPoint>
	|-Pool.GetList<CardTable.CardPlayer>
	|-Pool.GetList<CardTable.WinnerBreakdown.Winner>
	|-Pool.GetList<ClientReady.ClientInfo>
	|-Pool.GetList<EggHunt.EggHunter>
	|-Pool.GetList<Entity>
	|-Pool.GetList<FileStorageCacheData>
	|-Pool.GetList<GameMode.PlayerScore>
	|-Pool.GetList<GameMode.ScoreColumn>
	|-Pool.GetList<GameMode.TeamInfo>
	|-Pool.GetList<GenericSpawner.SpawnedEnt>
	|-Pool.GetList<IOEntity.IOConnection.LineVec>
	|-Pool.GetList<IOEntity.IOConnection>
	|-Pool.GetList<InstrumentMidiBinding>
	|-Pool.GetList<InstrumentRecordingNote>
	|-Pool.GetList<Item>
	|-Pool.GetList<ItemContainer>
	|-Pool.GetList<LightString.StringPoint>
	|-Pool.GetList<LinePoint>
	|-Pool.GetList<MapData>
	|-Pool.GetList<MapNote>
	|-Pool.GetList<MarketTerminal.PendingOrder>
	|-Pool.GetList<MissionInstance>
	|-Pool.GetList<MissionPoint>
	|-Pool.GetList<MissionReward>
	|-Pool.GetList<Modifier>
	|-Pool.GetList<NeonSign.Lights>
	|-Pool.GetList<ObjectiveStatus>
	|-Pool.GetList<PathData>
	|-Pool.GetList<PatternFirework.Star>
	|-Pool.GetList<PhoneDirectory.DirectoryEntry>
	|-Pool.GetList<PlayerLifeStory.GenericStat>
	|-Pool.GetList<PlayerLifeStory.WeaponStats>
	|-Pool.GetList<PlayerNameID>
	|-Pool.GetList<PlayerTeam.TeamMember>
	|-Pool.GetList<PlayerTeam>
	|-Pool.GetList<PrefabData>
	|-Pool.GetList<ProjectileShoot.Projectile>
	|-Pool.GetList<ReclaimManager.ReclaimInfo>
	|-Pool.GetList<RelationshipManager.PlayerRelationshipInfo>
	|-Pool.GetList<RelationshipManager.PlayerRelationships>
	|-Pool.GetList<RespawnInformation.SpawnOptions>
	|-Pool.GetList<Tree>
	|-Pool.GetList<VehicleVendor.PlayerStorage.PlayerStoredVehicle>
	|-Pool.GetList<VehicleVendor.PlayerStorage>
	|-Pool.GetList<VendingMachine.SellOrder>
	|-Pool.GetList<VendingMachine>
	|-Pool.GetList<VoicemailEntry>
	|-Pool.GetList<RelationshipManager.PlayerRelationshipInfo>
	|-Pool.GetList<RendererBatch>
	|-Pool.GetList<ItemModEngineItem>
	|-Pool.GetList<RustButton>
	|-Pool.GetList<ServerAdminUGCEntry>
	|-Pool.GetList<ServerAdminUGCEntryPattern>
	|-Pool.GetList<ShoutcastStreamer>
	|-Pool.GetList<SleepingBag>
	|-Pool.GetList<Socket_Base>
	|-Pool.GetList<IEnumerator>
	|-Pool.GetList<string>
	|-Pool.GetList<TechTreeData.NodeInstance>
	|-Pool.GetList<TriggerBase>
	|-Pool.GetList<AudioSource>
	|-Pool.GetList<Collider>
	|-Pool.GetList<GameObject>
	|-Pool.GetList<LODGroup>
	|-Pool.GetList<Material>
	|-Pool.GetList<MeshRenderer>
	|-Pool.GetList<ParticleSystem>
	|-Pool.GetList<Renderer>
	|-Pool.GetList<Rigidbody>
	|-Pool.GetList<SkinnedMeshRenderer>
	|-Pool.GetList<TrailRenderer>
	|-Pool.GetList<Transform>
	|-Pool.GetList<VendingMachineMapMarker>
	|-Pool.GetList<WaterVolume>
	|-Pool.GetList<Wearable>
	|-Pool.GetList<WearableHairCap>
	|-Pool.GetList<object>
	|
	|-Pool.GetList<FoliageGridMeshData.FoliageVertex>
	|
	|-Pool.GetList<Option>
	|
	|-Pool.GetList<IconSkinPicker.SkinButtonSetup>
	|
	|-Pool.GetList<ImageStorageEntity.ImageRequest>
	|
	|-Pool.GetList<InvokeAction>
	|
	|-Pool.GetList<MapView.MapMarkerCluster>
	|
	|-Pool.GetList<MapView.SleepingBagCluster>
	|
	|-Pool.GetList<DemoShotFloatKeyframe>
	|
	|-Pool.GetList<DemoShotParentKeyframe>
	|
	|-Pool.GetList<DemoShotQuaternionKeyframe>
	|
	|-Pool.GetList<DemoShotVectorKeyframe>
	|
	|-Pool.GetList<VectorData>
	|
	|-Pool.GetList<SubmarineSonar.SonarBlip>
	|
	|-Pool.GetList<bool>
	|
	|-Pool.GetList<KeyValuePair<HairCapMask, Renderer>>
	|-Pool.GetList<KeyValuePair<Int32Enum, object>>
	|
	|-Pool.GetList<int>
	|
	|-Pool.GetList<float>
	|
	|-Pool.GetList<uint>
	|
	|-Pool.GetList<ulong>
	|
	|-Pool.GetList<ValueTuple<string, AssetBundleRequest>>
	|-Pool.GetList<ValueTuple<object, object>>
	|
	|-Pool.GetList<TraceInfo>
	|
	|-Pool.GetList<Color32>
	|
	|-Pool.GetList<RaycastHit>
	|
	|-Pool.GetList<Vector2>
	|
	|-Pool.GetList<Vector3>
	|
	|-Pool.GetList<Vector4>
	|
	|-Pool.GetList<Vector2i>
	|
	|-Pool.GetList<MeshColliderInstance>
	|
	|-Pool.GetList<MeshInstance>
	|
	|-Pool.GetList<MeshRendererInstance>
	*/

	public static void ResizeBuffer<T>(int size) { }
	/* GenericInstMethod :
	|
	|-Pool.ResizeBuffer<EntityLink>
	|-Pool.ResizeBuffer<LODCell>
	|-Pool.ResizeBuffer<Networkable>
	|-Pool.ResizeBuffer<RendererCell>
	|-Pool.ResizeBuffer<RendererGroup>
	|-Pool.ResizeBuffer<object>
	*/

	public static void FillBuffer<T>(int count = 2147483647) { }
	/* GenericInstMethod :
	|
	|-Pool.FillBuffer<EntityLink>
	|-Pool.FillBuffer<LODCell>
	|-Pool.FillBuffer<Networkable>
	|-Pool.FillBuffer<RendererCell>
	|-Pool.FillBuffer<RendererGroup>
	|-Pool.FillBuffer<object>
	*/

	public static Pool.PoolCollection<T> FindCollection<T>() { }
	/* GenericInstMethod :
	|
	|-Pool.FindCollection<object>
	*/

	public static void Clear() { }

	private static void .cctor() { }

}

public class Pool.PoolCollection<T> : Pool.ICollection // TypeDefIndex: 4842
{
	public T[] buffer; 
	[CompilerGeneratedAttribute] 
	private long <ItemsInStack>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private long <ItemsInUse>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private long <ItemsCreated>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private long <ItemsTaken>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private long <ItemsSpilled>k__BackingField; 

	public long ItemsInStack { get; set; }
	public long ItemsInUse { get; set; }
	public long ItemsCreated { get; set; }
	public long ItemsTaken { get; set; }
	public long ItemsSpilled { get; set; }


	[CompilerGeneratedAttribute] 
	public long get_ItemsInStack() { }
	/* GenericInstMethod :
	|
	|-Pool.PoolCollection<object>.get_ItemsInStack
	*/

	[CompilerGeneratedAttribute] 
	public void set_ItemsInStack(long value) { }
	/* GenericInstMethod :
	|
	|-Pool.PoolCollection<object>.set_ItemsInStack
	*/

	[CompilerGeneratedAttribute] 
	public long get_ItemsInUse() { }
	/* GenericInstMethod :
	|
	|-Pool.PoolCollection<object>.get_ItemsInUse
	*/

	[CompilerGeneratedAttribute] 
	public void set_ItemsInUse(long value) { }
	/* GenericInstMethod :
	|
	|-Pool.PoolCollection<object>.set_ItemsInUse
	*/

	[CompilerGeneratedAttribute] 
	public long get_ItemsCreated() { }
	/* GenericInstMethod :
	|
	|-Pool.PoolCollection<object>.get_ItemsCreated
	*/

	[CompilerGeneratedAttribute] 
	public void set_ItemsCreated(long value) { }
	/* GenericInstMethod :
	|
	|-Pool.PoolCollection<object>.set_ItemsCreated
	*/

	[CompilerGeneratedAttribute] 
	public long get_ItemsTaken() { }
	/* GenericInstMethod :
	|
	|-Pool.PoolCollection<object>.get_ItemsTaken
	*/

	[CompilerGeneratedAttribute] 
	public void set_ItemsTaken(long value) { }
	/* GenericInstMethod :
	|
	|-Pool.PoolCollection<object>.set_ItemsTaken
	*/

	[CompilerGeneratedAttribute] 
	public long get_ItemsSpilled() { }
	/* GenericInstMethod :
	|
	|-Pool.PoolCollection<object>.get_ItemsSpilled
	*/

	[CompilerGeneratedAttribute] 
	public void set_ItemsSpilled(long value) { }
	/* GenericInstMethod :
	|
	|-Pool.PoolCollection<object>.set_ItemsSpilled
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-Pool.PoolCollection<object>..ctor
	*/

	public void Reset() { }
	/* GenericInstMethod :
	|
	|-Pool.PoolCollection<object>.Reset
	*/

	public void Add(T obj) { }
	/* GenericInstMethod :
	|
	|-Pool.PoolCollection<object>.Add
	*/

	private void Facepunch.Pool.ICollection.Add(object obj) { }
	/* GenericInstMethod :
	|
	|-Pool.PoolCollection<object>.Facepunch.Pool.ICollection.Add
	*/

}

public class Pool : ConsoleSystem // TypeDefIndex: 13690
{
	[ServerVar] 
	[ClientVar] 
	public static int mode; 
	[ServerVar] 
	[ClientVar] 
	public static bool prewarm; 
	[ServerVar] 
	[ClientVar] 
	public static bool enabled; 
	[ServerVar] 
	[ClientVar] 
	public static bool debug; 


	[ServerVar] 
	[ClientVar] 
	public static void print_memory(ConsoleSystem.Arg arg) { }

	[ServerVar] 
	[ClientVar] 
	public static void print_prefabs(ConsoleSystem.Arg arg) { }

	[ServerVar] 
	[ClientVar] 
	public static void print_assets(ConsoleSystem.Arg arg) { }

	[ServerVar] 
	[ClientVar] 
	public static void clear_memory(ConsoleSystem.Arg arg) { }

	[ServerVar] 
	[ClientVar] 
	public static void clear_prefabs(ConsoleSystem.Arg arg) { }

	[ServerVar] 
	[ClientVar] 
	public static void clear_assets(ConsoleSystem.Arg arg) { }

	[ServerVar] 
	[ClientVar] 
	public static void export_prefabs(ConsoleSystem.Arg arg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class Pool.<>c // TypeDefIndex: 13691
{
	public static readonly Pool.<>c <>9; 
	public static Func<KeyValuePair<Type, Pool.ICollection>, long> <>9__4_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal long <print_memory>b__4_0(KeyValuePair<Type, Pool.ICollection> x) { }

}

