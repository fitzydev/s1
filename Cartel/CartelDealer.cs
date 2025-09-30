using System;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Economy;
using ScheduleOne.ItemFramework;
using ScheduleOne.Product;
using ScheduleOne.Product.Packaging;
using UnityEngine;

namespace ScheduleOne.Cartel
{
	// Token: 0x02000809 RID: 2057
	[Token(Token = "0x2000809")]
	public class CartelDealer : Dealer
	{
		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x06003876 RID: 14454 RVA: 0x0000F420 File Offset: 0x0000D620
		// (set) Token: 0x06003877 RID: 14455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700080C")]
		public bool IsAcceptingDeals
		{
			[Token(Token = "0x6003876")]
			[Address(RVA = "0x7E29C0", Offset = "0x7E13C0", VA = "0x1807E29C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003877")]
			[Address(RVA = "0x7E29D0", Offset = "0x7E13D0", VA = "0x1807E29D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x06003878 RID: 14456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700080D")]
		private GoonPool GoonPool
		{
			[Token(Token = "0x6003878")]
			[Address(RVA = "0x7E2940", Offset = "0x7E1340", VA = "0x1807E2940")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003879 RID: 14457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003879")]
		[Address(RVA = "0x7E2840", Offset = "0x7E1240", VA = "0x1807E2840", Slot = "70")]
		protected override void Start()
		{
		}

		// Token: 0x0600387A RID: 14458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600387A")]
		[Address(RVA = "0x7E1A20", Offset = "0x7E0420", VA = "0x1807E1A20", Slot = "6")]
		public override void OnStartServer()
		{
		}

		// Token: 0x0600387B RID: 14459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600387B")]
		[Address(RVA = "0x7E19B0", Offset = "0x7E03B0", VA = "0x1807E19B0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x0600387C RID: 14460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600387C")]
		[Address(RVA = "0x7E1F00", Offset = "0x7E0900", VA = "0x1807E1F00")]
		private void RandomizeInventory()
		{
		}

		// Token: 0x0600387D RID: 14461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600387D")]
		[Address(RVA = "0x7E1E60", Offset = "0x7E0860", VA = "0x1807E1E60")]
		private void RandomizeAppearance()
		{
		}

		// Token: 0x0600387E RID: 14462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600387E")]
		[Address(RVA = "0x7E1530", Offset = "0x7DFF30", VA = "0x1807E1530")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void ConfigureGoonSettings(NetworkConnection conn, CartelGoonAppearance appearance, float moveSpeed)
		{
		}

		// Token: 0x0600387F RID: 14463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600387F")]
		[Address(RVA = "0x7E26B0", Offset = "0x7E10B0", VA = "0x1807E26B0")]
		public void SetIsAcceptingDeals(bool accepting)
		{
		}

		// Token: 0x06003880 RID: 14464 RVA: 0x0000F438 File Offset: 0x0000D638
		[Token(Token = "0x6003880")]
		[Address(RVA = "0x7E1500", Offset = "0x7DFF00", VA = "0x1807E1500")]
		public bool CanCurrentlyAcceptDeal()
		{
			return default(bool);
		}

		// Token: 0x06003881 RID: 14465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003881")]
		[Address(RVA = "0x7E17E0", Offset = "0x7E01E0", VA = "0x1807E17E0")]
		private void DiedOrKnockedOut()
		{
		}

		// Token: 0x06003882 RID: 14466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003882")]
		[Address(RVA = "0x7E28F0", Offset = "0x7E12F0", VA = "0x1807E28F0")]
		public CartelDealer()
		{
		}

		// Token: 0x06003883 RID: 14467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003883")]
		[Address(RVA = "0x7E18D0", Offset = "0x7E02D0", VA = "0x1807E18D0", Slot = "99")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06003884 RID: 14468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003884")]
		[Address(RVA = "0x7E18B0", Offset = "0x7E02B0", VA = "0x1807E18B0", Slot = "100")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06003885 RID: 14469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003885")]
		[Address(RVA = "0x687D80", Offset = "0x686780", VA = "0x180687D80", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06003886 RID: 14470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003886")]
		[Address(RVA = "0x7E23E0", Offset = "0x7E0DE0", VA = "0x1807E23E0")]
		private void RpcWriter___Observers_ConfigureGoonSettings_3427656873(NetworkConnection conn, CartelGoonAppearance appearance, float moveSpeed)
		{
		}

		// Token: 0x06003887 RID: 14471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003887")]
		[Address(RVA = "0x7E2090", Offset = "0x7E0A90", VA = "0x1807E2090")]
		private void RpcLogic___ConfigureGoonSettings_3427656873(NetworkConnection conn, CartelGoonAppearance appearance, float moveSpeed)
		{
		}

		// Token: 0x06003888 RID: 14472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003888")]
		[Address(RVA = "0x7E22D0", Offset = "0x7E0CD0", VA = "0x1807E22D0")]
		private void RpcReader___Observers_ConfigureGoonSettings_3427656873(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003889 RID: 14473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003889")]
		[Address(RVA = "0x7E2550", Offset = "0x7E0F50", VA = "0x1807E2550")]
		private void RpcWriter___Target_ConfigureGoonSettings_3427656873(NetworkConnection conn, CartelGoonAppearance appearance, float moveSpeed)
		{
		}

		// Token: 0x0600388A RID: 14474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600388A")]
		[Address(RVA = "0x7E2360", Offset = "0x7E0D60", VA = "0x1807E2360")]
		private void RpcReader___Target_ConfigureGoonSettings_3427656873(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600388B RID: 14475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600388B")]
		[Address(RVA = "0x717E70", Offset = "0x716870", VA = "0x180717E70", Slot = "64")]
		public override void Awake()
		{
		}

		// Token: 0x0400273F RID: 10047
		[Token(Token = "0x400273F")]
		public const float DEALER_DEFEATED_INFLUENCE_CHANGE = -0.05f;

		// Token: 0x04002740 RID: 10048
		[Token(Token = "0x4002740")]
		public const int PRODUCT_COUNT_MIN = 2;

		// Token: 0x04002741 RID: 10049
		[Token(Token = "0x4002741")]
		public const int PRODUCT_COUNT_MAX = 4;

		// Token: 0x04002742 RID: 10050
		[Token(Token = "0x4002742")]
		public const int PRODUCT_QUANTITY_MIN = 1;

		// Token: 0x04002743 RID: 10051
		[Token(Token = "0x4002743")]
		public const int PRODUCT_QUANTITY_MAX = 10;

		// Token: 0x04002745 RID: 10053
		[Token(Token = "0x4002745")]
		[FieldOffset(Offset = "0x3E8")]
		[Header("Cartel Dealer Inventory Settings")]
		public ProductDefinition[] RandomProducts;

		// Token: 0x04002746 RID: 10054
		[Token(Token = "0x4002746")]
		[FieldOffset(Offset = "0x3F0")]
		public EQuality ProductQuality;

		// Token: 0x04002747 RID: 10055
		[Token(Token = "0x4002747")]
		[FieldOffset(Offset = "0x3F8")]
		public PackagingDefinition DefaultPackaging;

		// Token: 0x04002748 RID: 10056
		[Token(Token = "0x4002748")]
		[FieldOffset(Offset = "0x400")]
		private CartelGoonAppearance appearance;

		// Token: 0x04002749 RID: 10057
		[Token(Token = "0x4002749")]
		[FieldOffset(Offset = "0x408")]
		private bool NetworkInitialize___EarlyScheduleOne.Cartel.CartelDealerAssembly-CSharp.dll_Excuted;

		// Token: 0x0400274A RID: 10058
		[Token(Token = "0x400274A")]
		[FieldOffset(Offset = "0x409")]
		private bool NetworkInitialize__LateScheduleOne.Cartel.CartelDealerAssembly-CSharp.dll_Excuted;
	}
}
