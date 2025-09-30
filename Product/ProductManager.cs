using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Economy;
using ScheduleOne.Map;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.Properties;
using ScheduleOne.Properties.MixMaps;
using ScheduleOne.StationFramework;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Product
{
	// Token: 0x0200099F RID: 2463
	[Token(Token = "0x200099F")]
	public class ProductManager : NetworkSingleton<ProductManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x06004326 RID: 17190 RVA: 0x00011AF0 File Offset: 0x0000FCF0
		[Token(Token = "0x17000966")]
		public static bool MethDiscovered
		{
			[Token(Token = "0x6004326")]
			[Address(RVA = "0x8A6B50", Offset = "0x8A5550", VA = "0x1808A6B50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x06004327 RID: 17191 RVA: 0x00011B08 File Offset: 0x0000FD08
		[Token(Token = "0x17000967")]
		public static bool CocaineDiscovered
		{
			[Token(Token = "0x6004327")]
			[Address(RVA = "0x8A6980", Offset = "0x8A5380", VA = "0x1808A6980")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x06004328 RID: 17192 RVA: 0x00011B20 File Offset: 0x0000FD20
		// (set) Token: 0x06004329 RID: 17193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000968")]
		public static bool IsAcceptingOrders
		{
			[Token(Token = "0x6004328")]
			[Address(RVA = "0x8A6AD0", Offset = "0x8A54D0", VA = "0x1808A6AD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004329")]
			[Address(RVA = "0x8A6D10", Offset = "0x8A5710", VA = "0x1808A6D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x0600432A RID: 17194 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600432B RID: 17195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000969")]
		public NewMixOperation CurrentMixOperation
		{
			[Token(Token = "0x600432A")]
			[Address(RVA = "0x892D80", Offset = "0x891780", VA = "0x180892D80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600432B")]
			[Address(RVA = "0x892ED0", Offset = "0x8918D0", VA = "0x180892ED0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x0600432C RID: 17196 RVA: 0x00011B38 File Offset: 0x0000FD38
		[Token(Token = "0x1700096A")]
		public bool IsMixingInProgress
		{
			[Token(Token = "0x600432C")]
			[Address(RVA = "0x8A6B20", Offset = "0x8A5520", VA = "0x1808A6B20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x0600432D RID: 17197 RVA: 0x00011B50 File Offset: 0x0000FD50
		// (set) Token: 0x0600432E RID: 17198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700096B")]
		public bool IsMixComplete
		{
			[Token(Token = "0x600432D")]
			[Address(RVA = "0x892D70", Offset = "0x891770", VA = "0x180892D70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600432E")]
			[Address(RVA = "0x892EA0", Offset = "0x8918A0", VA = "0x180892EA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x0600432F RID: 17199 RVA: 0x00011B68 File Offset: 0x0000FD68
		// (set) Token: 0x06004330 RID: 17200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700096C")]
		public float TimeSinceProductListingChanged
		{
			[Token(Token = "0x600432F")]
			[Address(RVA = "0x8A6CF0", Offset = "0x8A56F0", VA = "0x1808A6CF0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004330")]
			[Address(RVA = "0x8A6D90", Offset = "0x8A5790", VA = "0x1808A6D90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x06004331 RID: 17201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700096D")]
		public string SaveFolderName
		{
			[Token(Token = "0x6004331")]
			[Address(RVA = "0x8A6CC0", Offset = "0x8A56C0", VA = "0x1808A6CC0", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x06004332 RID: 17202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700096E")]
		public string SaveFileName
		{
			[Token(Token = "0x6004332")]
			[Address(RVA = "0x8A6C90", Offset = "0x8A5690", VA = "0x1808A6C90", Slot = "27")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x06004333 RID: 17203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700096F")]
		public Loader Loader
		{
			[Token(Token = "0x6004333")]
			[Address(RVA = "0x62FCC0", Offset = "0x62E6C0", VA = "0x18062FCC0", Slot = "28")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x06004334 RID: 17204 RVA: 0x00011B80 File Offset: 0x0000FD80
		[Token(Token = "0x17000970")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x6004334")]
			[Address(RVA = "0x4B7AD0", Offset = "0x4B64D0", VA = "0x1804B7AD0", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x06004335 RID: 17205 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004336 RID: 17206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000971")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x6004335")]
			[Address(RVA = "0x62FCB0", Offset = "0x62E6B0", VA = "0x18062FCB0", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004336")]
			[Address(RVA = "0x6302A0", Offset = "0x62ECA0", VA = "0x1806302A0", Slot = "31")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x06004337 RID: 17207 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004338 RID: 17208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000972")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x6004337")]
			[Address(RVA = "0x8A6B40", Offset = "0x8A5540", VA = "0x1808A6B40", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004338")]
			[Address(RVA = "0x8A6D70", Offset = "0x8A5770", VA = "0x1808A6D70", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x06004339 RID: 17209 RVA: 0x00011B98 File Offset: 0x0000FD98
		// (set) Token: 0x0600433A RID: 17210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000973")]
		public bool HasChanged
		{
			[Token(Token = "0x6004339")]
			[Address(RVA = "0x8A6AC0", Offset = "0x8A54C0", VA = "0x1808A6AC0", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600433A")]
			[Address(RVA = "0x8A6D00", Offset = "0x8A5700", VA = "0x1808A6D00", Slot = "35")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x0600433B RID: 17211 RVA: 0x00011BB0 File Offset: 0x0000FDB0
		[Token(Token = "0x17000974")]
		public int LoadOrder
		{
			[Token(Token = "0x600433B")]
			[Address(RVA = "0x8A6B30", Offset = "0x8A5530", VA = "0x1808A6B30", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600433C RID: 17212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600433C")]
		[Address(RVA = "0x8970F0", Offset = "0x895AF0", VA = "0x1808970F0", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x0600433D RID: 17213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600433D")]
		[Address(RVA = "0x8A5B50", Offset = "0x8A4550", VA = "0x1808A5B50", Slot = "19")]
		protected override void Start()
		{
		}

		// Token: 0x0600433E RID: 17214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600433E")]
		[Address(RVA = "0x89CE10", Offset = "0x89B810", VA = "0x18089CE10", Slot = "6")]
		public override void OnStartServer()
		{
		}

		// Token: 0x0600433F RID: 17215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600433F")]
		[Address(RVA = "0x89CDF0", Offset = "0x89B7F0", VA = "0x18089CDF0", Slot = "11")]
		public override void OnStartClient()
		{
		}

		// Token: 0x06004340 RID: 17216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004340")]
		[Address(RVA = "0x8A64F0", Offset = "0x8A4EF0", VA = "0x1808A64F0")]
		private void Update()
		{
		}

		// Token: 0x06004341 RID: 17217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004341")]
		[Address(RVA = "0x8974B0", Offset = "0x895EB0", VA = "0x1808974B0")]
		private void Clean()
		{
		}

		// Token: 0x06004342 RID: 17218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004342")]
		[Address(RVA = "0x8A3800", Offset = "0x8A2200", VA = "0x1808A3800")]
		[ServerRpc(RequireOwnership = false)]
		public void SetMethDiscovered()
		{
		}

		// Token: 0x06004343 RID: 17219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004343")]
		[Address(RVA = "0x8A36F0", Offset = "0x8A20F0", VA = "0x1808A36F0")]
		[ServerRpc(RequireOwnership = false)]
		public void SetCocaineDiscovered()
		{
		}

		// Token: 0x06004344 RID: 17220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004344")]
		[Address(RVA = "0x89D010", Offset = "0x89BA10", VA = "0x18089D010")]
		[ObserversRpc(RunLocally = true)]
		public void RecordContractReceipt(ContractReceipt receipt)
		{
		}

		// Token: 0x06004345 RID: 17221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004345")]
		[Address(RVA = "0x899000", Offset = "0x897A00", VA = "0x180899000")]
		public List<ContractReceipt> GetContractReceipts(EMapRegion region, List<EContractParty> dealCompleterTypes, int maxMinsAgo)
		{
			return null;
		}

		// Token: 0x06004346 RID: 17222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004346")]
		[Address(RVA = "0x89B120", Offset = "0x899B20", VA = "0x18089B120", Slot = "49")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x06004347 RID: 17223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004347")]
		[Address(RVA = "0x8994F0", Offset = "0x897EF0", VA = "0x1808994F0")]
		public MixerMap GetMixerMap(EDrugType type)
		{
			return null;
		}

		// Token: 0x06004348 RID: 17224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004348")]
		[Address(RVA = "0x89BFE0", Offset = "0x89A9E0", VA = "0x18089BFE0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06004349 RID: 17225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004349")]
		[Address(RVA = "0x89BDD0", Offset = "0x89A7D0", VA = "0x18089BDD0")]
		private void OnMinPass()
		{
		}

		// Token: 0x0600434A RID: 17226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600434A")]
		[Address(RVA = "0x89BF90", Offset = "0x89A990", VA = "0x18089BF90")]
		private void OnNewDay()
		{
		}

		// Token: 0x0600434B RID: 17227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600434B")]
		[Address(RVA = "0x8A59F0", Offset = "0x8A43F0", VA = "0x1808A59F0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetProductListed(string productID, bool listed)
		{
		}

		// Token: 0x0600434C RID: 17228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600434C")]
		[Address(RVA = "0x8A5750", Offset = "0x8A4150", VA = "0x1808A5750")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetProductListed(NetworkConnection conn, string productID, bool listed)
		{
		}

		// Token: 0x0600434D RID: 17229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600434D")]
		[Address(RVA = "0x8A55F0", Offset = "0x8A3FF0", VA = "0x1808A55F0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetProductFavourited(string productID, bool listed)
		{
		}

		// Token: 0x0600434E RID: 17230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600434E")]
		[Address(RVA = "0x8A5350", Offset = "0x8A3D50", VA = "0x1808A5350")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public void SetProductFavourited(NetworkConnection conn, string productID, bool fav)
		{
		}

		// Token: 0x0600434F RID: 17231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600434F")]
		[Address(RVA = "0x8987A0", Offset = "0x8971A0", VA = "0x1808987A0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void DiscoverProduct(string productID)
		{
		}

		// Token: 0x06004350 RID: 17232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004350")]
		[Address(RVA = "0x8A50B0", Offset = "0x8A3AB0", VA = "0x1808A50B0")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetProductDiscovered(NetworkConnection conn, string productID, bool autoList)
		{
		}

		// Token: 0x06004351 RID: 17233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004351")]
		[Address(RVA = "0x8A4BD0", Offset = "0x8A35D0", VA = "0x1808A4BD0")]
		public void SetIsAcceptingOrder(bool accepting)
		{
		}

		// Token: 0x06004352 RID: 17234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004352")]
		[Address(RVA = "0x8982B0", Offset = "0x896CB0", VA = "0x1808982B0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void CreateWeed_Server(string name, string id, EDrugType type, List<string> properties, WeedAppearanceSettings appearance)
		{
		}

		// Token: 0x06004353 RID: 17235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004353")]
		[Address(RVA = "0x898470", Offset = "0x896E70", VA = "0x180898470")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void CreateWeed(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, WeedAppearanceSettings appearance)
		{
		}

		// Token: 0x06004354 RID: 17236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004354")]
		[Address(RVA = "0x897600", Offset = "0x896000", VA = "0x180897600")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void CreateCocaine_Server(string name, string id, EDrugType type, List<string> properties, CocaineAppearanceSettings appearance)
		{
		}

		// Token: 0x06004355 RID: 17237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004355")]
		[Address(RVA = "0x8977C0", Offset = "0x8961C0", VA = "0x1808977C0")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void CreateCocaine(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, CocaineAppearanceSettings appearance)
		{
		}

		// Token: 0x06004356 RID: 17238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004356")]
		[Address(RVA = "0x897AF0", Offset = "0x8964F0", VA = "0x180897AF0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void CreateMeth_Server(string name, string id, EDrugType type, List<string> properties, MethAppearanceSettings appearance)
		{
		}

		// Token: 0x06004357 RID: 17239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004357")]
		[Address(RVA = "0x897CB0", Offset = "0x8966B0", VA = "0x180897CB0")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void CreateMeth(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, MethAppearanceSettings appearance)
		{
		}

		// Token: 0x06004358 RID: 17240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004358")]
		[Address(RVA = "0x89D150", Offset = "0x89BB50", VA = "0x18089D150")]
		private void RefreshHighestValueProduct()
		{
		}

		// Token: 0x06004359 RID: 17241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004359")]
		[Address(RVA = "0x8A48F0", Offset = "0x8A32F0", VA = "0x1808A48F0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendMixRecipe(string product, string mixer, string output)
		{
		}

		// Token: 0x0600435A RID: 17242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600435A")]
		[Address(RVA = "0x897FE0", Offset = "0x8969E0", VA = "0x180897FE0")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public void CreateMixRecipe(NetworkConnection conn, string product, string mixer, string output)
		{
		}

		// Token: 0x0600435B RID: 17243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600435B")]
		[Address(RVA = "0x899C00", Offset = "0x898600", VA = "0x180899C00")]
		public StationRecipe GetRecipe(string product, string mixer)
		{
			return null;
		}

		// Token: 0x0600435C RID: 17244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600435C")]
		[Address(RVA = "0x899790", Offset = "0x898190", VA = "0x180899790")]
		public StationRecipe GetRecipe(List<Property> productProperties, Property mixerProperty)
		{
			return null;
		}

		// Token: 0x0600435D RID: 17245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600435D")]
		[Address(RVA = "0x89AFC0", Offset = "0x8999C0", VA = "0x18089AFC0")]
		[TargetRpc]
		private void GiveItem(NetworkConnection conn, string id)
		{
		}

		// Token: 0x0600435E RID: 17246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600435E")]
		[Address(RVA = "0x8992C0", Offset = "0x897CC0", VA = "0x1808992C0")]
		public ProductDefinition GetKnownProduct(EDrugType type, List<Property> properties)
		{
			return null;
		}

		// Token: 0x0600435F RID: 17247 RVA: 0x00011BC8 File Offset: 0x0000FDC8
		[Token(Token = "0x600435F")]
		[Address(RVA = "0x8995F0", Offset = "0x897FF0", VA = "0x1808995F0")]
		public float GetPrice(ProductDefinition product)
		{
			return 0f;
		}

		// Token: 0x06004360 RID: 17248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004360")]
		[Address(RVA = "0x8A4A70", Offset = "0x8A3470", VA = "0x1808A4A70")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendPrice(string productID, float value)
		{
		}

		// Token: 0x06004361 RID: 17249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004361")]
		[Address(RVA = "0x8A4E00", Offset = "0x8A3800", VA = "0x1808A4E00")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetPrice(NetworkConnection conn, string productID, float value)
		{
		}

		// Token: 0x06004362 RID: 17250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004362")]
		[Address(RVA = "0x8A47A0", Offset = "0x8A31A0", VA = "0x1808A47A0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendMixOperation(NewMixOperation operation, bool complete)
		{
		}

		// Token: 0x06004363 RID: 17251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004363")]
		[Address(RVA = "0x8A4C60", Offset = "0x8A3660", VA = "0x1808A4C60")]
		[ObserversRpc(RunLocally = true)]
		private void SetMixOperation(NewMixOperation operation, bool complete)
		{
		}

		// Token: 0x06004364 RID: 17252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004364")]
		[Address(RVA = "0x898A90", Offset = "0x897490", VA = "0x180898A90")]
		public string FinishAndNameMix(string productID, string ingredientID, string mixName)
		{
			return null;
		}

		// Token: 0x06004365 RID: 17253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004365")]
		[Address(RVA = "0x89B1F0", Offset = "0x899BF0", VA = "0x18089B1F0")]
		public static string MakeIDFileSafe(string id)
		{
			return null;
		}

		// Token: 0x06004366 RID: 17254 RVA: 0x00011BE0 File Offset: 0x0000FDE0
		[Token(Token = "0x6004366")]
		[Address(RVA = "0x89B1B0", Offset = "0x899BB0", VA = "0x18089B1B0")]
		public static bool IsMixNameValid(string mixName)
		{
			return default(bool);
		}

		// Token: 0x06004367 RID: 17255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004367")]
		[Address(RVA = "0x8988E0", Offset = "0x8972E0", VA = "0x1808988E0")]
		[ObserversRpc(RunLocally = true)]
		private void FinishAndNameMix(string productID, string ingredientID, string mixName, string mixID)
		{
		}

		// Token: 0x06004368 RID: 17256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004368")]
		[Address(RVA = "0x8A3160", Offset = "0x8A1B60", VA = "0x1808A3160")]
		[ServerRpc(RequireOwnership = false)]
		private void SendFinishAndNameMix(string productID, string ingredientID, string mixName, string mixID)
		{
		}

		// Token: 0x06004369 RID: 17257 RVA: 0x00011BF8 File Offset: 0x0000FDF8
		[Token(Token = "0x6004369")]
		[Address(RVA = "0x897170", Offset = "0x895B70", VA = "0x180897170")]
		public static float CalculateProductValue(ProductDefinition product, float baseValue)
		{
			return 0f;
		}

		// Token: 0x0600436A RID: 17258 RVA: 0x00011C10 File Offset: 0x0000FE10
		[Token(Token = "0x600436A")]
		[Address(RVA = "0x897330", Offset = "0x895D30", VA = "0x180897330")]
		public static float CalculateProductValue(float baseValue, List<Property> properties)
		{
			return 0f;
		}

		// Token: 0x0600436B RID: 17259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600436B")]
		[Address(RVA = "0x899D00", Offset = "0x898700", VA = "0x180899D00", Slot = "50")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x0600436C RID: 17260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600436C")]
		[Address(RVA = "0x8A6660", Offset = "0x8A5060", VA = "0x1808A6660")]
		public ProductManager()
		{
		}

		// Token: 0x0600436E RID: 17262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600436E")]
		[Address(RVA = "0x89B4F0", Offset = "0x899EF0", VA = "0x18089B4F0", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600436F RID: 17263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600436F")]
		[Address(RVA = "0x89B4A0", Offset = "0x899EA0", VA = "0x18089B4A0", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06004370 RID: 17264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004370")]
		[Address(RVA = "0x5B3020", Offset = "0x5B1A20", VA = "0x1805B3020", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06004371 RID: 17265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004371")]
		[Address(RVA = "0x8A3800", Offset = "0x8A2200", VA = "0x1808A3800")]
		private void RpcWriter___Server_SetMethDiscovered_2166136261()
		{
		}

		// Token: 0x06004372 RID: 17266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004372")]
		[Address(RVA = "0x89F690", Offset = "0x89E090", VA = "0x18089F690")]
		public void RpcLogic___SetMethDiscovered_2166136261()
		{
		}

		// Token: 0x06004373 RID: 17267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004373")]
		[Address(RVA = "0x8A1320", Offset = "0x89FD20", VA = "0x1808A1320")]
		private void RpcReader___Server_SetMethDiscovered_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004374 RID: 17268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004374")]
		[Address(RVA = "0x8A36F0", Offset = "0x8A20F0", VA = "0x1808A36F0")]
		private void RpcWriter___Server_SetCocaineDiscovered_2166136261()
		{
		}

		// Token: 0x06004375 RID: 17269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004375")]
		[Address(RVA = "0x89F640", Offset = "0x89E040", VA = "0x18089F640")]
		public void RpcLogic___SetCocaineDiscovered_2166136261()
		{
		}

		// Token: 0x06004376 RID: 17270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004376")]
		[Address(RVA = "0x8A12C0", Offset = "0x89FCC0", VA = "0x1808A12C0")]
		private void RpcReader___Server_SetCocaineDiscovered_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004377 RID: 17271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004377")]
		[Address(RVA = "0x8A2340", Offset = "0x8A0D40", VA = "0x1808A2340")]
		private void RpcWriter___Observers_RecordContractReceipt_1401448548(ContractReceipt receipt)
		{
		}

		// Token: 0x06004378 RID: 17272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004378")]
		[Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0")]
		public void RpcLogic___RecordContractReceipt_1401448548(ContractReceipt receipt)
		{
		}

		// Token: 0x06004379 RID: 17273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004379")]
		[Address(RVA = "0x8A0920", Offset = "0x89F320", VA = "0x1808A0920")]
		private void RpcReader___Observers_RecordContractReceipt_1401448548(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600437A RID: 17274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600437A")]
		[Address(RVA = "0x8A3A70", Offset = "0x8A2470", VA = "0x1808A3A70")]
		private void RpcWriter___Server_SetProductListed_310431262(string productID, bool listed)
		{
		}

		// Token: 0x0600437B RID: 17275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600437B")]
		[Address(RVA = "0x89FF10", Offset = "0x89E910", VA = "0x18089FF10")]
		public void RpcLogic___SetProductListed_310431262(string productID, bool listed)
		{
		}

		// Token: 0x0600437C RID: 17276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600437C")]
		[Address(RVA = "0x8A1440", Offset = "0x89FE40", VA = "0x1808A1440")]
		private void RpcReader___Server_SetProductListed_310431262(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600437D RID: 17277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600437D")]
		[Address(RVA = "0x8A2A40", Offset = "0x8A1440", VA = "0x1808A2A40")]
		private void RpcWriter___Observers_SetProductListed_619441887(NetworkConnection conn, string productID, bool listed)
		{
		}

		// Token: 0x0600437E RID: 17278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600437E")]
		[Address(RVA = "0x89FF30", Offset = "0x89E930", VA = "0x18089FF30")]
		public void RpcLogic___SetProductListed_619441887(NetworkConnection conn, string productID, bool listed)
		{
		}

		// Token: 0x0600437F RID: 17279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600437F")]
		[Address(RVA = "0x8A0C10", Offset = "0x89F610", VA = "0x1808A0C10")]
		private void RpcReader___Observers_SetProductListed_619441887(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004380 RID: 17280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004380")]
		[Address(RVA = "0x8A4640", Offset = "0x8A3040", VA = "0x1808A4640")]
		private void RpcWriter___Target_SetProductListed_619441887(NetworkConnection conn, string productID, bool listed)
		{
		}

		// Token: 0x06004381 RID: 17281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004381")]
		[Address(RVA = "0x8A1AC0", Offset = "0x8A04C0", VA = "0x1808A1AC0")]
		private void RpcReader___Target_SetProductListed_619441887(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004382 RID: 17282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004382")]
		[Address(RVA = "0x8A3910", Offset = "0x8A2310", VA = "0x1808A3910")]
		private void RpcWriter___Server_SetProductFavourited_310431262(string productID, bool listed)
		{
		}

		// Token: 0x06004383 RID: 17283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004383")]
		[Address(RVA = "0x89FB40", Offset = "0x89E540", VA = "0x18089FB40")]
		public void RpcLogic___SetProductFavourited_310431262(string productID, bool listed)
		{
		}

		// Token: 0x06004384 RID: 17284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004384")]
		[Address(RVA = "0x8A1380", Offset = "0x89FD80", VA = "0x1808A1380")]
		private void RpcReader___Server_SetProductFavourited_310431262(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004385 RID: 17285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004385")]
		[Address(RVA = "0x8A28D0", Offset = "0x8A12D0", VA = "0x1808A28D0")]
		private void RpcWriter___Observers_SetProductFavourited_619441887(NetworkConnection conn, string productID, bool fav)
		{
		}

		// Token: 0x06004386 RID: 17286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004386")]
		[Address(RVA = "0x89FB60", Offset = "0x89E560", VA = "0x18089FB60")]
		public void RpcLogic___SetProductFavourited_619441887(NetworkConnection conn, string productID, bool fav)
		{
		}

		// Token: 0x06004387 RID: 17287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004387")]
		[Address(RVA = "0x8A0B60", Offset = "0x89F560", VA = "0x1808A0B60")]
		private void RpcReader___Observers_SetProductFavourited_619441887(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004388 RID: 17288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004388")]
		[Address(RVA = "0x8A44E0", Offset = "0x8A2EE0", VA = "0x1808A44E0")]
		private void RpcWriter___Target_SetProductFavourited_619441887(NetworkConnection conn, string productID, bool fav)
		{
		}

		// Token: 0x06004389 RID: 17289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004389")]
		[Address(RVA = "0x8A1A20", Offset = "0x8A0420", VA = "0x1808A1A20")]
		private void RpcReader___Target_SetProductFavourited_619441887(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600438A RID: 17290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600438A")]
		[Address(RVA = "0x8A3030", Offset = "0x8A1A30", VA = "0x1808A3030")]
		private void RpcWriter___Server_DiscoverProduct_3615296227(string productID)
		{
		}

		// Token: 0x0600438B RID: 17291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600438B")]
		[Address(RVA = "0x89ED20", Offset = "0x89D720", VA = "0x18089ED20")]
		public void RpcLogic___DiscoverProduct_3615296227(string productID)
		{
		}

		// Token: 0x0600438C RID: 17292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600438C")]
		[Address(RVA = "0x8A0F60", Offset = "0x89F960", VA = "0x1808A0F60")]
		private void RpcReader___Server_DiscoverProduct_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600438D RID: 17293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600438D")]
		[Address(RVA = "0x8A2760", Offset = "0x8A1160", VA = "0x1808A2760")]
		private void RpcWriter___Observers_SetProductDiscovered_619441887(NetworkConnection conn, string productID, bool autoList)
		{
		}

		// Token: 0x0600438E RID: 17294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600438E")]
		[Address(RVA = "0x89F8E0", Offset = "0x89E2E0", VA = "0x18089F8E0")]
		public void RpcLogic___SetProductDiscovered_619441887(NetworkConnection conn, string productID, bool autoList)
		{
		}

		// Token: 0x0600438F RID: 17295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600438F")]
		[Address(RVA = "0x8A0AB0", Offset = "0x89F4B0", VA = "0x1808A0AB0")]
		private void RpcReader___Observers_SetProductDiscovered_619441887(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004390 RID: 17296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004390")]
		[Address(RVA = "0x8A4380", Offset = "0x8A2D80", VA = "0x1808A4380")]
		private void RpcWriter___Target_SetProductDiscovered_619441887(NetworkConnection conn, string productID, bool autoList)
		{
		}

		// Token: 0x06004391 RID: 17297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004391")]
		[Address(RVA = "0x8A1980", Offset = "0x8A0380", VA = "0x1808A1980")]
		private void RpcReader___Target_SetProductDiscovered_619441887(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004392 RID: 17298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004392")]
		[Address(RVA = "0x8A2EB0", Offset = "0x8A18B0", VA = "0x1808A2EB0")]
		private void RpcWriter___Server_CreateWeed_Server_2331775230(string name, string id, EDrugType type, List<string> properties, WeedAppearanceSettings appearance)
		{
		}

		// Token: 0x06004393 RID: 17299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004393")]
		[Address(RVA = "0x89ECE0", Offset = "0x89D6E0", VA = "0x18089ECE0")]
		public void RpcLogic___CreateWeed_Server_2331775230(string name, string id, EDrugType type, List<string> properties, WeedAppearanceSettings appearance)
		{
		}

		// Token: 0x06004394 RID: 17300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004394")]
		[Address(RVA = "0x8A0E80", Offset = "0x89F880", VA = "0x1808A0E80")]
		private void RpcReader___Server_CreateWeed_Server_2331775230(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004395 RID: 17301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004395")]
		[Address(RVA = "0x8A4080", Offset = "0x8A2A80", VA = "0x1808A4080")]
		private void RpcWriter___Target_CreateWeed_1777266891(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, WeedAppearanceSettings appearance)
		{
		}

		// Token: 0x06004396 RID: 17302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004396")]
		[Address(RVA = "0x89E880", Offset = "0x89D280", VA = "0x18089E880")]
		private void RpcLogic___CreateWeed_1777266891(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, WeedAppearanceSettings appearance)
		{
		}

		// Token: 0x06004397 RID: 17303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004397")]
		[Address(RVA = "0x8A1740", Offset = "0x8A0140", VA = "0x1808A1740")]
		private void RpcReader___Target_CreateWeed_1777266891(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004398 RID: 17304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004398")]
		[Address(RVA = "0x8A2020", Offset = "0x8A0A20", VA = "0x1808A2020")]
		private void RpcWriter___Observers_CreateWeed_1777266891(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, WeedAppearanceSettings appearance)
		{
		}

		// Token: 0x06004399 RID: 17305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004399")]
		[Address(RVA = "0x8A0790", Offset = "0x89F190", VA = "0x1808A0790")]
		private void RpcReader___Observers_CreateWeed_1777266891(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600439A RID: 17306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600439A")]
		[Address(RVA = "0x8A2BB0", Offset = "0x8A15B0", VA = "0x1808A2BB0")]
		private void RpcWriter___Server_CreateCocaine_Server_891166717(string name, string id, EDrugType type, List<string> properties, CocaineAppearanceSettings appearance)
		{
		}

		// Token: 0x0600439B RID: 17307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600439B")]
		[Address(RVA = "0x89D8F0", Offset = "0x89C2F0", VA = "0x18089D8F0")]
		public void RpcLogic___CreateCocaine_Server_891166717(string name, string id, EDrugType type, List<string> properties, CocaineAppearanceSettings appearance)
		{
		}

		// Token: 0x0600439C RID: 17308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600439C")]
		[Address(RVA = "0x8A0CC0", Offset = "0x89F6C0", VA = "0x1808A0CC0")]
		private void RpcReader___Server_CreateCocaine_Server_891166717(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600439D RID: 17309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600439D")]
		[Address(RVA = "0x8A3BD0", Offset = "0x8A25D0", VA = "0x1808A3BD0")]
		private void RpcWriter___Target_CreateCocaine_1327282946(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, CocaineAppearanceSettings appearance)
		{
		}

		// Token: 0x0600439E RID: 17310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600439E")]
		[Address(RVA = "0x89D410", Offset = "0x89BE10", VA = "0x18089D410")]
		private void RpcLogic___CreateCocaine_1327282946(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, CocaineAppearanceSettings appearance)
		{
		}

		// Token: 0x0600439F RID: 17311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600439F")]
		[Address(RVA = "0x8A1500", Offset = "0x89FF00", VA = "0x1808A1500")]
		private void RpcReader___Target_CreateCocaine_1327282946(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060043A0 RID: 17312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043A0")]
		[Address(RVA = "0x8A1B60", Offset = "0x8A0560", VA = "0x1808A1B60")]
		private void RpcWriter___Observers_CreateCocaine_1327282946(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, CocaineAppearanceSettings appearance)
		{
		}

		// Token: 0x060043A1 RID: 17313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043A1")]
		[Address(RVA = "0x8A0550", Offset = "0x89EF50", VA = "0x1808A0550")]
		private void RpcReader___Observers_CreateCocaine_1327282946(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060043A2 RID: 17314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043A2")]
		[Address(RVA = "0x8A2D30", Offset = "0x8A1730", VA = "0x1808A2D30")]
		private void RpcWriter___Server_CreateMeth_Server_4251728555(string name, string id, EDrugType type, List<string> properties, MethAppearanceSettings appearance)
		{
		}

		// Token: 0x060043A3 RID: 17315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043A3")]
		[Address(RVA = "0x89DE10", Offset = "0x89C810", VA = "0x18089DE10")]
		public void RpcLogic___CreateMeth_Server_4251728555(string name, string id, EDrugType type, List<string> properties, MethAppearanceSettings appearance)
		{
		}

		// Token: 0x060043A4 RID: 17316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043A4")]
		[Address(RVA = "0x8A0DA0", Offset = "0x89F7A0", VA = "0x1808A0DA0")]
		private void RpcReader___Server_CreateMeth_Server_4251728555(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060043A5 RID: 17317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043A5")]
		[Address(RVA = "0x8A3D70", Offset = "0x8A2770", VA = "0x1808A3D70")]
		private void RpcWriter___Target_CreateMeth_1869045686(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, MethAppearanceSettings appearance)
		{
		}

		// Token: 0x060043A6 RID: 17318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043A6")]
		[Address(RVA = "0x89D930", Offset = "0x89C330", VA = "0x18089D930")]
		private void RpcLogic___CreateMeth_1869045686(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, MethAppearanceSettings appearance)
		{
		}

		// Token: 0x060043A7 RID: 17319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043A7")]
		[Address(RVA = "0x8A15D0", Offset = "0x89FFD0", VA = "0x1808A15D0")]
		private void RpcReader___Target_CreateMeth_1869045686(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060043A8 RID: 17320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043A8")]
		[Address(RVA = "0x8A1D00", Offset = "0x8A0700", VA = "0x1808A1D00")]
		private void RpcWriter___Observers_CreateMeth_1869045686(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, MethAppearanceSettings appearance)
		{
		}

		// Token: 0x060043A9 RID: 17321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043A9")]
		[Address(RVA = "0x8A0620", Offset = "0x89F020", VA = "0x1808A0620")]
		private void RpcReader___Observers_CreateMeth_1869045686(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060043AA RID: 17322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043AA")]
		[Address(RVA = "0x8A3430", Offset = "0x8A1E30", VA = "0x1808A3430")]
		private void RpcWriter___Server_SendMixRecipe_852232071(string product, string mixer, string output)
		{
		}

		// Token: 0x060043AB RID: 17323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043AB")]
		[Address(RVA = "0x89F5F0", Offset = "0x89DFF0", VA = "0x18089F5F0")]
		public void RpcLogic___SendMixRecipe_852232071(string product, string mixer, string output)
		{
		}

		// Token: 0x060043AC RID: 17324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043AC")]
		[Address(RVA = "0x8A1160", Offset = "0x89FB60", VA = "0x1808A1160")]
		private void RpcReader___Server_SendMixRecipe_852232071(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060043AD RID: 17325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043AD")]
		[Address(RVA = "0x8A3F10", Offset = "0x8A2910", VA = "0x1808A3F10")]
		private void RpcWriter___Target_CreateMixRecipe_1410895574(NetworkConnection conn, string product, string mixer, string output)
		{
		}

		// Token: 0x060043AE RID: 17326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043AE")]
		[Address(RVA = "0x89DE50", Offset = "0x89C850", VA = "0x18089DE50")]
		public void RpcLogic___CreateMixRecipe_1410895574(NetworkConnection conn, string product, string mixer, string output)
		{
		}

		// Token: 0x060043AF RID: 17327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043AF")]
		[Address(RVA = "0x8A16A0", Offset = "0x8A00A0", VA = "0x1808A16A0")]
		private void RpcReader___Target_CreateMixRecipe_1410895574(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060043B0 RID: 17328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043B0")]
		[Address(RVA = "0x8A1EA0", Offset = "0x8A08A0", VA = "0x1808A1EA0")]
		private void RpcWriter___Observers_CreateMixRecipe_1410895574(NetworkConnection conn, string product, string mixer, string output)
		{
		}

		// Token: 0x060043B1 RID: 17329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043B1")]
		[Address(RVA = "0x8A06F0", Offset = "0x89F0F0", VA = "0x1808A06F0")]
		private void RpcReader___Observers_CreateMixRecipe_1410895574(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060043B2 RID: 17330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043B2")]
		[Address(RVA = "0x89AFC0", Offset = "0x8999C0", VA = "0x18089AFC0")]
		private void RpcWriter___Target_GiveItem_2971853958(NetworkConnection conn, string id)
		{
		}

		// Token: 0x060043B3 RID: 17331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043B3")]
		[Address(RVA = "0x89F330", Offset = "0x89DD30", VA = "0x18089F330")]
		private void RpcLogic___GiveItem_2971853958(NetworkConnection conn, string id)
		{
		}

		// Token: 0x060043B4 RID: 17332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043B4")]
		[Address(RVA = "0x8A1810", Offset = "0x8A0210", VA = "0x1808A1810")]
		private void RpcReader___Target_GiveItem_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060043B5 RID: 17333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043B5")]
		[Address(RVA = "0x8A3590", Offset = "0x8A1F90", VA = "0x1808A3590")]
		private void RpcWriter___Server_SendPrice_606697822(string productID, float value)
		{
		}

		// Token: 0x060043B6 RID: 17334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043B6")]
		[Address(RVA = "0x89F620", Offset = "0x89E020", VA = "0x18089F620")]
		public void RpcLogic___SendPrice_606697822(string productID, float value)
		{
		}

		// Token: 0x060043B7 RID: 17335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043B7")]
		[Address(RVA = "0x8A1220", Offset = "0x89FC20", VA = "0x1808A1220")]
		private void RpcReader___Server_SendPrice_606697822(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060043B8 RID: 17336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043B8")]
		[Address(RVA = "0x8A25F0", Offset = "0x8A0FF0", VA = "0x1808A25F0")]
		private void RpcWriter___Observers_SetPrice_4077118173(NetworkConnection conn, string productID, float value)
		{
		}

		// Token: 0x060043B9 RID: 17337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043B9")]
		[Address(RVA = "0x89F750", Offset = "0x89E150", VA = "0x18089F750")]
		public void RpcLogic___SetPrice_4077118173(NetworkConnection conn, string productID, float value)
		{
		}

		// Token: 0x060043BA RID: 17338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043BA")]
		[Address(RVA = "0x8A0A20", Offset = "0x89F420", VA = "0x1808A0A20")]
		private void RpcReader___Observers_SetPrice_4077118173(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060043BB RID: 17339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043BB")]
		[Address(RVA = "0x8A4220", Offset = "0x8A2C20", VA = "0x1808A4220")]
		private void RpcWriter___Target_SetPrice_4077118173(NetworkConnection conn, string productID, float value)
		{
		}

		// Token: 0x060043BC RID: 17340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043BC")]
		[Address(RVA = "0x8A1900", Offset = "0x8A0300", VA = "0x1808A1900")]
		private void RpcReader___Target_SetPrice_4077118173(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060043BD RID: 17341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043BD")]
		[Address(RVA = "0x8A32D0", Offset = "0x8A1CD0", VA = "0x1808A32D0")]
		private void RpcWriter___Server_SendMixOperation_3670976965(NewMixOperation operation, bool complete)
		{
		}

		// Token: 0x060043BE RID: 17342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043BE")]
		[Address(RVA = "0x89F5E0", Offset = "0x89DFE0", VA = "0x18089F5E0")]
		public void RpcLogic___SendMixOperation_3670976965(NewMixOperation operation, bool complete)
		{
		}

		// Token: 0x060043BF RID: 17343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043BF")]
		[Address(RVA = "0x8A10B0", Offset = "0x89FAB0", VA = "0x1808A10B0")]
		private void RpcReader___Server_SendMixOperation_3670976965(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060043C0 RID: 17344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043C0")]
		[Address(RVA = "0x8A2480", Offset = "0x8A0E80", VA = "0x1808A2480")]
		private void RpcWriter___Observers_SetMixOperation_3670976965(NewMixOperation operation, bool complete)
		{
		}

		// Token: 0x060043C1 RID: 17345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043C1")]
		[Address(RVA = "0x89F6E0", Offset = "0x89E0E0", VA = "0x18089F6E0")]
		private void RpcLogic___SetMixOperation_3670976965(NewMixOperation operation, bool complete)
		{
		}

		// Token: 0x060043C2 RID: 17346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043C2")]
		[Address(RVA = "0x8A0980", Offset = "0x89F380", VA = "0x1808A0980")]
		private void RpcReader___Observers_SetMixOperation_3670976965(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060043C3 RID: 17347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043C3")]
		[Address(RVA = "0x8A21C0", Offset = "0x8A0BC0", VA = "0x1808A21C0")]
		private void RpcWriter___Observers_FinishAndNameMix_4237212381(string productID, string ingredientID, string mixName, string mixID)
		{
		}

		// Token: 0x060043C4 RID: 17348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043C4")]
		[Address(RVA = "0x89ED40", Offset = "0x89D740", VA = "0x18089ED40")]
		private void RpcLogic___FinishAndNameMix_4237212381(string productID, string ingredientID, string mixName, string mixID)
		{
		}

		// Token: 0x060043C5 RID: 17349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043C5")]
		[Address(RVA = "0x8A0860", Offset = "0x89F260", VA = "0x1808A0860")]
		private void RpcReader___Observers_FinishAndNameMix_4237212381(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060043C6 RID: 17350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043C6")]
		[Address(RVA = "0x8A3160", Offset = "0x8A1B60", VA = "0x1808A3160")]
		private void RpcWriter___Server_SendFinishAndNameMix_4237212381(string productID, string ingredientID, string mixName, string mixID)
		{
		}

		// Token: 0x060043C7 RID: 17351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043C7")]
		[Address(RVA = "0x89F570", Offset = "0x89DF70", VA = "0x18089F570")]
		private void RpcLogic___SendFinishAndNameMix_4237212381(string productID, string ingredientID, string mixName, string mixID)
		{
		}

		// Token: 0x060043C8 RID: 17352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043C8")]
		[Address(RVA = "0x8A0FE0", Offset = "0x89F9E0", VA = "0x1808A0FE0")]
		private void RpcReader___Server_SendFinishAndNameMix_4237212381(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060043C9 RID: 17353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043C9")]
		[Address(RVA = "0x8970A0", Offset = "0x895AA0", VA = "0x1808970A0", Slot = "51")]
		protected virtual void Awake_UserLogic_ScheduleOne.Product.ProductManager_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04002F23 RID: 12067
		[Token(Token = "0x4002F23")]
		public const int MIN_PRICE = 1;

		// Token: 0x04002F24 RID: 12068
		[Token(Token = "0x4002F24")]
		public const int MAX_PRICE = 999;

		// Token: 0x04002F25 RID: 12069
		[Token(Token = "0x4002F25")]
		public const int CONTRACT_RECEIPT_MAX_COUNT = 50;

		// Token: 0x04002F26 RID: 12070
		[Token(Token = "0x4002F26")]
		[FieldOffset(Offset = "0x120")]
		public Action<ProductDefinition> onProductDiscovered;

		// Token: 0x04002F27 RID: 12071
		[Token(Token = "0x4002F27")]
		[FieldOffset(Offset = "0x0")]
		public static List<ProductDefinition> DiscoveredProducts;

		// Token: 0x04002F28 RID: 12072
		[Token(Token = "0x4002F28")]
		[FieldOffset(Offset = "0x8")]
		public static List<ProductDefinition> ListedProducts;

		// Token: 0x04002F29 RID: 12073
		[Token(Token = "0x4002F29")]
		[FieldOffset(Offset = "0x10")]
		public static List<ProductDefinition> FavouritedProducts;

		// Token: 0x04002F2B RID: 12075
		[Token(Token = "0x4002F2B")]
		[FieldOffset(Offset = "0x128")]
		public List<ProductDefinition> AllProducts;

		// Token: 0x04002F2C RID: 12076
		[Token(Token = "0x4002F2C")]
		[FieldOffset(Offset = "0x130")]
		public List<ProductDefinition> DefaultKnownProducts;

		// Token: 0x04002F2D RID: 12077
		[Token(Token = "0x4002F2D")]
		[FieldOffset(Offset = "0x138")]
		public List<PropertyItemDefinition> ValidMixIngredients;

		// Token: 0x04002F2E RID: 12078
		[Token(Token = "0x4002F2E")]
		[FieldOffset(Offset = "0x140")]
		public List<ContractReceipt> ContractReceipts;

		// Token: 0x04002F2F RID: 12079
		[Token(Token = "0x4002F2F")]
		[FieldOffset(Offset = "0x148")]
		public AnimationCurve SampleSuccessCurve;

		// Token: 0x04002F30 RID: 12080
		[Token(Token = "0x4002F30")]
		[FieldOffset(Offset = "0x150")]
		public ProductDefinition[] ListForSaleOnStart;

		// Token: 0x04002F31 RID: 12081
		[Token(Token = "0x4002F31")]
		[FieldOffset(Offset = "0x158")]
		[Header("Default Products")]
		public WeedDefinition DefaultWeed;

		// Token: 0x04002F32 RID: 12082
		[Token(Token = "0x4002F32")]
		[FieldOffset(Offset = "0x160")]
		public CocaineDefinition DefaultCocaine;

		// Token: 0x04002F33 RID: 12083
		[Token(Token = "0x4002F33")]
		[FieldOffset(Offset = "0x168")]
		public MethDefinition DefaultMeth;

		// Token: 0x04002F34 RID: 12084
		[Token(Token = "0x4002F34")]
		[FieldOffset(Offset = "0x170")]
		[Header("Mix Maps")]
		public MixerMap WeedMixMap;

		// Token: 0x04002F35 RID: 12085
		[Token(Token = "0x4002F35")]
		[FieldOffset(Offset = "0x178")]
		public MixerMap MethMixMap;

		// Token: 0x04002F36 RID: 12086
		[Token(Token = "0x4002F36")]
		[FieldOffset(Offset = "0x180")]
		public MixerMap CokeMixMap;

		// Token: 0x04002F37 RID: 12087
		[Token(Token = "0x4002F37")]
		[FieldOffset(Offset = "0x188")]
		private List<ProductDefinition> createdProducts;

		// Token: 0x04002F3B RID: 12091
		[Token(Token = "0x4002F3B")]
		[FieldOffset(Offset = "0x1A0")]
		public Action<NewMixOperation> onMixCompleted;

		// Token: 0x04002F3C RID: 12092
		[Token(Token = "0x4002F3C")]
		[FieldOffset(Offset = "0x1A8")]
		public Action<ProductDefinition> onNewProductCreated;

		// Token: 0x04002F3D RID: 12093
		[Token(Token = "0x4002F3D")]
		[FieldOffset(Offset = "0x1B0")]
		public Action<ProductDefinition> onProductListed;

		// Token: 0x04002F3E RID: 12094
		[Token(Token = "0x4002F3E")]
		[FieldOffset(Offset = "0x1B8")]
		public Action<ProductDefinition> onProductDelisted;

		// Token: 0x04002F3F RID: 12095
		[Token(Token = "0x4002F3F")]
		[FieldOffset(Offset = "0x1C0")]
		public Action<ProductDefinition> onProductFavourited;

		// Token: 0x04002F40 RID: 12096
		[Token(Token = "0x4002F40")]
		[FieldOffset(Offset = "0x1C8")]
		public Action<ProductDefinition> onProductUnfavourited;

		// Token: 0x04002F41 RID: 12097
		[Token(Token = "0x4002F41")]
		[FieldOffset(Offset = "0x1D0")]
		public Action<ContractReceipt> onContractReceiptRecorded;

		// Token: 0x04002F42 RID: 12098
		[Token(Token = "0x4002F42")]
		[FieldOffset(Offset = "0x1D8")]
		public UnityEvent onFirstSampleRejection;

		// Token: 0x04002F43 RID: 12099
		[Token(Token = "0x4002F43")]
		[FieldOffset(Offset = "0x1E0")]
		public UnityEvent onSecondUniqueProductCreated;

		// Token: 0x04002F44 RID: 12100
		[Token(Token = "0x4002F44")]
		[FieldOffset(Offset = "0x1E8")]
		public List<string> ProductNames;

		// Token: 0x04002F45 RID: 12101
		[Token(Token = "0x4002F45")]
		[FieldOffset(Offset = "0x1F0")]
		private List<StationRecipe> mixRecipes;

		// Token: 0x04002F46 RID: 12102
		[Token(Token = "0x4002F46")]
		[FieldOffset(Offset = "0x1F8")]
		public Action<StationRecipe> onMixRecipeAdded;

		// Token: 0x04002F47 RID: 12103
		[Token(Token = "0x4002F47")]
		[FieldOffset(Offset = "0x200")]
		private Dictionary<ProductDefinition, float> ProductPrices;

		// Token: 0x04002F48 RID: 12104
		[Token(Token = "0x4002F48")]
		[FieldOffset(Offset = "0x208")]
		private ProductDefinition highestValueProduct;

		// Token: 0x04002F49 RID: 12105
		[Token(Token = "0x4002F49")]
		[FieldOffset(Offset = "0x210")]
		private ProductManagerLoader loader;

		// Token: 0x04002F4E RID: 12110
		[Token(Token = "0x4002F4E")]
		[FieldOffset(Offset = "0x230")]
		private bool NetworkInitialize___EarlyScheduleOne.Product.ProductManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x04002F4F RID: 12111
		[Token(Token = "0x4002F4F")]
		[FieldOffset(Offset = "0x231")]
		private bool NetworkInitialize__LateScheduleOne.Product.ProductManagerAssembly-CSharp.dll_Excuted;
	}
}
