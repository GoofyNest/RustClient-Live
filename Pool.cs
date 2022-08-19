public static class Pool // TypeDefIndex: 4835
{	// Fields
	public static Dictionary<Type, Pool.ICollection> directory; // 0x12840

	// Methods

	// RVA: -1 Offset: -1
	public static void FreeList<T>(ref List<T> obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1547420 Offset: 0x1546820 VA: 0x181547420
	|-Pool.FreeList<BaseEntity.ServerFileRequest>
	|
	|-RVA: 0x1547340 Offset: 0x1546740 VA: 0x181547340
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
	|-RVA: 0x15469A0 Offset: 0x1545DA0 VA: 0x1815469A0
	|-Pool.FreeList<FoliageGridMeshData.FoliageVertex>
	|
	|-RVA: 0x1547180 Offset: 0x1546580 VA: 0x181547180
	|-Pool.FreeList<Option>
	|
	|-RVA: 0x15475E0 Offset: 0x15469E0 VA: 0x1815475E0
	|-Pool.FreeList<IconSkinPicker.SkinButtonSetup>
	|
	|-RVA: 0x1546A80 Offset: 0x1545E80 VA: 0x181546A80
	|-Pool.FreeList<ImageStorageEntity.ImageRequest>
	|
	|-RVA: 0x1546C40 Offset: 0x1546040 VA: 0x181546C40
	|-Pool.FreeList<InvokeAction>
	|
	|-RVA: 0x1546E00 Offset: 0x1546200 VA: 0x181546E00
	|-Pool.FreeList<MapView.MapMarkerCluster>
	|
	|-RVA: 0x15476C0 Offset: 0x1546AC0 VA: 0x1815476C0
	|-Pool.FreeList<MapView.SleepingBagCluster>
	|
	|-RVA: 0x1546EE0 Offset: 0x15462E0 VA: 0x181546EE0
	|-Pool.FreeList<MeshColliderInstance>
	|
	|-RVA: 0x1546FC0 Offset: 0x15463C0 VA: 0x181546FC0
	|-Pool.FreeList<MeshInstance>
	|
	|-RVA: 0x15470A0 Offset: 0x15464A0 VA: 0x1815470A0
	|-Pool.FreeList<MeshRendererInstance>
	|
	|-RVA: 0x1546620 Offset: 0x1545A20 VA: 0x181546620
	|-Pool.FreeList<DemoShotFloatKeyframe>
	|
	|-RVA: 0x1546700 Offset: 0x1545B00 VA: 0x181546700
	|-Pool.FreeList<DemoShotParentKeyframe>
	|
	|-RVA: 0x15467E0 Offset: 0x1545BE0 VA: 0x1815467E0
	|-Pool.FreeList<DemoShotQuaternionKeyframe>
	|
	|-RVA: 0x15468C0 Offset: 0x1545CC0 VA: 0x1815468C0
	|-Pool.FreeList<DemoShotVectorKeyframe>
	|
	|-RVA: 0x1547F80 Offset: 0x1547380 VA: 0x181547F80
	|-Pool.FreeList<VectorData>
	|
	|-RVA: 0x15477A0 Offset: 0x1546BA0 VA: 0x1815477A0
	|-Pool.FreeList<SubmarineSonar.SonarBlip>
	|
	|-RVA: 0x1546460 Offset: 0x1545860 VA: 0x181546460
	|-Pool.FreeList<bool>
	|
	|-RVA: 0x1546D20 Offset: 0x1546120 VA: 0x181546D20
	|-Pool.FreeList<KeyValuePair<HairCapMask, Renderer>>
	|-Pool.FreeList<KeyValuePair<Int32Enum, object>>
	|
	|-RVA: 0x1546B60 Offset: 0x1545F60 VA: 0x181546B60
	|-Pool.FreeList<int>
	|
	|-RVA: 0x1547500 Offset: 0x1546900 VA: 0x181547500
	|-Pool.FreeList<float>
	|
	|-RVA: 0x1547960 Offset: 0x1546D60 VA: 0x181547960
	|-Pool.FreeList<uint>
	|
	|-RVA: 0x1547A40 Offset: 0x1546E40 VA: 0x181547A40
	|-Pool.FreeList<ulong>
	|
	|-RVA: 0x1547B20 Offset: 0x1546F20 VA: 0x181547B20
	|-Pool.FreeList<ValueTuple<object, object>>
	|-Pool.FreeList<ValueTuple<string, AssetBundleRequest>>
	|
	|-RVA: 0x1547880 Offset: 0x1546C80 VA: 0x181547880
	|-Pool.FreeList<TraceInfo>
	|
	|-RVA: 0x1546540 Offset: 0x1545940 VA: 0x181546540
	|-Pool.FreeList<Color32>
	|
	|-RVA: 0x1547260 Offset: 0x1546660 VA: 0x181547260
	|-Pool.FreeList<RaycastHit>
	|
	|-RVA: 0x1547C00 Offset: 0x1547000 VA: 0x181547C00
	|-Pool.FreeList<Vector2>
	|
	|-RVA: 0x1547DC0 Offset: 0x15471C0 VA: 0x181547DC0
	|-Pool.FreeList<Vector3>
	|
	|-RVA: 0x1547EA0 Offset: 0x15472A0 VA: 0x181547EA0
	|-Pool.FreeList<Vector4>
	|
	|-RVA: 0x1547CE0 Offset: 0x15470E0 VA: 0x181547CE0
	|-Pool.FreeList<Vector2i>
	*/

	// RVA: 0x226B1D0 Offset: 0x226A5D0 VA: 0x18226B1D0
	public static void FreeMemoryStream(ref MemoryStream obj) { }

	// RVA: -1 Offset: -1
	public static void Free<T>(ref T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1548060 Offset: 0x1547460 VA: 0x181548060
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
	|-Pool.Free<WaitForSecondsRealtimeEx>
	|-Pool.Free<WaterDynamics.InstanceBatch>
	*/

	// RVA: -1 Offset: -1
	public static void FreeDynamic<T>(ref T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1546200 Offset: 0x1545600 VA: 0x181546200
	|-Pool.FreeDynamic<object>
	*/

	// RVA: -1 Offset: -1
	private static void FreeInternal<T>(ref T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15463D0 Offset: 0x15457D0 VA: 0x1815463D0
	|-Pool.FreeInternal<MemoryStream>
	|-Pool.FreeInternal<object>
	*/

	// RVA: -1 Offset: -1
	public static T Get<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5ECF20 Offset: 0x5EC320 VA: 0x1805ECF20
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
	|-Pool.Get<WaitForSecondsRealtimeEx>
	|-Pool.Get<WaterDynamics.InstanceBatch>
	|-Pool.Get<object>
	*/

	// RVA: -1 Offset: -1
	public static List<T> GetList<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A9B70 Offset: 0x12A8F70 VA: 0x1812A9B70
	|-Pool.GetList<BaseEntity.ServerFileRequest>
	|
	|-RVA: 0x12A9B10 Offset: 0x12A8F10 VA: 0x1812A9B10
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
	|-RVA: 0x12A96F0 Offset: 0x12A8AF0 VA: 0x1812A96F0
	|-Pool.GetList<FoliageGridMeshData.FoliageVertex>
	|
	|-RVA: 0x12A9A50 Offset: 0x12A8E50 VA: 0x1812A9A50
	|-Pool.GetList<Option>
	|
	|-RVA: 0x12A9C30 Offset: 0x12A9030 VA: 0x1812A9C30
	|-Pool.GetList<IconSkinPicker.SkinButtonSetup>
	|
	|-RVA: 0x12A9750 Offset: 0x12A8B50 VA: 0x1812A9750
	|-Pool.GetList<ImageStorageEntity.ImageRequest>
	|
	|-RVA: 0x12A9810 Offset: 0x12A8C10 VA: 0x1812A9810
	|-Pool.GetList<InvokeAction>
	|
	|-RVA: 0x12A98D0 Offset: 0x12A8CD0 VA: 0x1812A98D0
	|-Pool.GetList<MapView.MapMarkerCluster>
	|
	|-RVA: 0x12A9C90 Offset: 0x12A9090 VA: 0x1812A9C90
	|-Pool.GetList<MapView.SleepingBagCluster>
	|
	|-RVA: 0x12A9570 Offset: 0x12A8970 VA: 0x1812A9570
	|-Pool.GetList<DemoShotFloatKeyframe>
	|
	|-RVA: 0x12A95D0 Offset: 0x12A89D0 VA: 0x1812A95D0
	|-Pool.GetList<DemoShotParentKeyframe>
	|
	|-RVA: 0x12A9630 Offset: 0x12A8A30 VA: 0x1812A9630
	|-Pool.GetList<DemoShotQuaternionKeyframe>
	|
	|-RVA: 0x12A9690 Offset: 0x12A8A90 VA: 0x1812A9690
	|-Pool.GetList<DemoShotVectorKeyframe>
	|
	|-RVA: 0x12AA050 Offset: 0x12A9450 VA: 0x1812AA050
	|-Pool.GetList<VectorData>
	|
	|-RVA: 0x12A9CF0 Offset: 0x12A90F0 VA: 0x1812A9CF0
	|-Pool.GetList<SubmarineSonar.SonarBlip>
	|
	|-RVA: 0x12A94B0 Offset: 0x12A88B0 VA: 0x1812A94B0
	|-Pool.GetList<bool>
	|
	|-RVA: 0x12A9870 Offset: 0x12A8C70 VA: 0x1812A9870
	|-Pool.GetList<KeyValuePair<HairCapMask, Renderer>>
	|-Pool.GetList<KeyValuePair<Int32Enum, object>>
	|
	|-RVA: 0x12A97B0 Offset: 0x12A8BB0 VA: 0x1812A97B0
	|-Pool.GetList<int>
	|
	|-RVA: 0x12A9BD0 Offset: 0x12A8FD0 VA: 0x1812A9BD0
	|-Pool.GetList<float>
	|
	|-RVA: 0x12A9DB0 Offset: 0x12A91B0 VA: 0x1812A9DB0
	|-Pool.GetList<uint>
	|
	|-RVA: 0x12A9E10 Offset: 0x12A9210 VA: 0x1812A9E10
	|-Pool.GetList<ulong>
	|
	|-RVA: 0x12A9E70 Offset: 0x12A9270 VA: 0x1812A9E70
	|-Pool.GetList<ValueTuple<string, AssetBundleRequest>>
	|-Pool.GetList<ValueTuple<object, object>>
	|
	|-RVA: 0x12A9D50 Offset: 0x12A9150 VA: 0x1812A9D50
	|-Pool.GetList<TraceInfo>
	|
	|-RVA: 0x12A9510 Offset: 0x12A8910 VA: 0x1812A9510
	|-Pool.GetList<Color32>
	|
	|-RVA: 0x12A9AB0 Offset: 0x12A8EB0 VA: 0x1812A9AB0
	|-Pool.GetList<RaycastHit>
	|
	|-RVA: 0x12A9ED0 Offset: 0x12A92D0 VA: 0x1812A9ED0
	|-Pool.GetList<Vector2>
	|
	|-RVA: 0x12A9F90 Offset: 0x12A9390 VA: 0x1812A9F90
	|-Pool.GetList<Vector3>
	|
	|-RVA: 0x12A9FF0 Offset: 0x12A93F0 VA: 0x1812A9FF0
	|-Pool.GetList<Vector4>
	|
	|-RVA: 0x12A9F30 Offset: 0x12A9330 VA: 0x1812A9F30
	|-Pool.GetList<Vector2i>
	|
	|-RVA: 0x12A9930 Offset: 0x12A8D30 VA: 0x1812A9930
	|-Pool.GetList<MeshColliderInstance>
	|
	|-RVA: 0x12A9990 Offset: 0x12A8D90 VA: 0x1812A9990
	|-Pool.GetList<MeshInstance>
	|
	|-RVA: 0x12A99F0 Offset: 0x12A8DF0 VA: 0x1812A99F0
	|-Pool.GetList<MeshRendererInstance>
	*/

	// RVA: -1 Offset: -1
	public static void ResizeBuffer<T>(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1548160 Offset: 0x1547560 VA: 0x181548160
	|-Pool.ResizeBuffer<EntityLink>
	|-Pool.ResizeBuffer<LODCell>
	|-Pool.ResizeBuffer<Networkable>
	|-Pool.ResizeBuffer<RendererCell>
	|-Pool.ResizeBuffer<RendererGroup>
	|-Pool.ResizeBuffer<object>
	*/

	// RVA: -1 Offset: -1
	public static void FillBuffer<T>(int count = 2147483647) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15460D0 Offset: 0x15454D0 VA: 0x1815460D0
	|-Pool.FillBuffer<EntityLink>
	|-Pool.FillBuffer<LODCell>
	|-Pool.FillBuffer<Networkable>
	|-Pool.FillBuffer<RendererCell>
	|-Pool.FillBuffer<RendererGroup>
	|-Pool.FillBuffer<object>
	*/

	// RVA: -1 Offset: -1
	public static Pool.PoolCollection<T> FindCollection<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1258BA0 Offset: 0x1257FA0 VA: 0x181258BA0
	|-Pool.FindCollection<object>
	*/

	// RVA: 0x226B000 Offset: 0x226A400 VA: 0x18226B000
	public static void Clear() { }

	// RVA: 0x226B2D0 Offset: 0x226A6D0 VA: 0x18226B2D0
	private static void .cctor() { }

}

public class Pool.PoolCollection<T> : Pool.ICollection // TypeDefIndex: 4838
{	// Fields
	public T[] buffer; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private long <ItemsInStack>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private long <ItemsInUse>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private long <ItemsCreated>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private long <ItemsTaken>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private long <ItemsSpilled>k__BackingField; // 0x0

	// Properties
	public long ItemsInStack { get; set; }
	public long ItemsInUse { get; set; }
	public long ItemsCreated { get; set; }
	public long ItemsTaken { get; set; }
	public long ItemsSpilled { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 4
	public long get_ItemsInStack() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	|-Pool.PoolCollection<object>.get_ItemsInStack
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public void set_ItemsInStack(long value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497E60 Offset: 0x497260 VA: 0x180497E60
	|-Pool.PoolCollection<object>.set_ItemsInStack
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 5
	public long get_ItemsInUse() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	|-Pool.PoolCollection<object>.get_ItemsInUse
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public void set_ItemsInUse(long value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE87960 Offset: 0xE86D60 VA: 0x180E87960
	|-Pool.PoolCollection<object>.set_ItemsInUse
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 6
	public long get_ItemsCreated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	|-Pool.PoolCollection<object>.get_ItemsCreated
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public void set_ItemsCreated(long value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE86650 Offset: 0xE85A50 VA: 0x180E86650
	|-Pool.PoolCollection<object>.set_ItemsCreated
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 7
	public long get_ItemsTaken() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	|-Pool.PoolCollection<object>.get_ItemsTaken
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public void set_ItemsTaken(long value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC107C0 Offset: 0xC0FBC0 VA: 0x180C107C0
	|-Pool.PoolCollection<object>.set_ItemsTaken
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 8
	public long get_ItemsSpilled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	|-Pool.PoolCollection<object>.get_ItemsSpilled
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public void set_ItemsSpilled(long value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC107D0 Offset: 0xC0FBD0 VA: 0x180C107D0
	|-Pool.PoolCollection<object>.set_ItemsSpilled
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E2F90 Offset: 0x15E2390 VA: 0x1815E2F90
	|-Pool.PoolCollection<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E2EB0 Offset: 0x15E22B0 VA: 0x1815E2EB0
	|-Pool.PoolCollection<object>.Reset
	*/

	// RVA: -1 Offset: -1
	public void Add(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E2C50 Offset: 0x15E2050 VA: 0x1815E2C50
	|-Pool.PoolCollection<object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private void Facepunch.Pool.ICollection.Add(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E2E10 Offset: 0x15E2210 VA: 0x1815E2E10
	|-Pool.PoolCollection<object>.Facepunch.Pool.ICollection.Add
	*/

}

public class Pool : ConsoleSystem // TypeDefIndex: 11951
{	// Fields
	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	public static int mode; // 0x0
	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	public static bool prewarm; // 0x4
	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	public static bool enabled; // 0x5
	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	public static bool debug; // 0x6

	// Methods

	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	// RVA: 0x368170 Offset: 0x367570 VA: 0x180368170
	public static void print_memory(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	// RVA: 0x368A60 Offset: 0x367E60 VA: 0x180368A60
	public static void print_prefabs(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	// RVA: 0x367CE0 Offset: 0x3670E0 VA: 0x180367CE0
	public static void print_assets(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	// RVA: 0x3678D0 Offset: 0x366CD0 VA: 0x1803678D0
	public static void clear_memory(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	// RVA: 0x367920 Offset: 0x366D20 VA: 0x180367920
	public static void clear_prefabs(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	// RVA: 0x367880 Offset: 0x366C80 VA: 0x180367880
	public static void clear_assets(ConsoleSystem.Arg arg) { }

	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	// RVA: 0x367990 Offset: 0x366D90 VA: 0x180367990
	public static void export_prefabs(ConsoleSystem.Arg arg) { }

	// RVA: 0x367820 Offset: 0x366C20 VA: 0x180367820
	public void .ctor() { }

	// RVA: 0x3677B0 Offset: 0x366BB0 VA: 0x1803677B0
	private static void .cctor() { }

}

private sealed class Pool.<>c // TypeDefIndex: 11952
{	// Fields
	public static readonly Pool.<>c <>9; // 0x0
	public static Func<KeyValuePair<Type, Pool.ICollection>, long> <>9__4_0; // 0x8

	// Methods

	// RVA: 0x36C040 Offset: 0x36B440 VA: 0x18036C040
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x36BF00 Offset: 0x36B300 VA: 0x18036BF00
	internal long <print_memory>b__4_0(KeyValuePair<Type, Pool.ICollection> x) { }

}

