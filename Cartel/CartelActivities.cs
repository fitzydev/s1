using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Map;
using UnityEngine;

namespace ScheduleOne.Cartel
{
	// Token: 0x02000805 RID: 2053
	[Token(Token = "0x2000805")]
	public class CartelActivities : NetworkBehaviour
	{
		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x06003852 RID: 14418 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003853 RID: 14419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700080A")]
		public CartelActivity CurrentGlobalActivity
		{
			[Token(Token = "0x6003852")]
			[Address(RVA = "0x66EF30", Offset = "0x66D930", VA = "0x18066EF30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003853")]
			[Address(RVA = "0x66F090", Offset = "0x66DA90", VA = "0x18066F090")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x06003854 RID: 14420 RVA: 0x0000F378 File Offset: 0x0000D578
		// (set) Token: 0x06003855 RID: 14421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700080B")]
		public int HoursUntilNextGlobalActivity
		{
			[Token(Token = "0x6003854")]
			[Address(RVA = "0x548860", Offset = "0x547260", VA = "0x180548860")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003855")]
			[Address(RVA = "0x63DAA0", Offset = "0x63C4A0", VA = "0x18063DAA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003856 RID: 14422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003856")]
		[Address(RVA = "0x7DD990", Offset = "0x7DC390", VA = "0x1807DD990")]
		private void Start()
		{
		}

		// Token: 0x06003857 RID: 14423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003857")]
		[Address(RVA = "0x7DD030", Offset = "0x7DBA30", VA = "0x1807DD030", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06003858 RID: 14424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003858")]
		[Address(RVA = "0x7DCA10", Offset = "0x7DB410", VA = "0x1807DCA10")]
		public CartelRegionActivities GetRegionalActivities(EMapRegion region)
		{
			return null;
		}

		// Token: 0x06003859 RID: 14425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003859")]
		[Address(RVA = "0x7DCE60", Offset = "0x7DB860", VA = "0x1807DCE60")]
		private void HourPass()
		{
		}

		// Token: 0x0600385A RID: 14426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600385A")]
		[Address(RVA = "0x7DDAE0", Offset = "0x7DC4E0", VA = "0x1807DDAE0")]
		private void TryStartActivity()
		{
		}

		// Token: 0x0600385B RID: 14427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600385B")]
		[Address(RVA = "0x7DD6E0", Offset = "0x7DC0E0", VA = "0x1807DD6E0")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void StartGlobalActivity(NetworkConnection conn, EMapRegion region, int activityIndex)
		{
		}

		// Token: 0x0600385C RID: 14428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600385C")]
		[Address(RVA = "0x7DBF00", Offset = "0x7DA900", VA = "0x1807DBF00")]
		private void ActivityEnded()
		{
		}

		// Token: 0x0600385D RID: 14429 RVA: 0x0000F390 File Offset: 0x0000D590
		[Token(Token = "0x600385D")]
		[Address(RVA = "0x7DC020", Offset = "0x7DAA20", VA = "0x1807DC020")]
		private bool CanNewActivityBegin()
		{
			return default(bool);
		}

		// Token: 0x0600385E RID: 14430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600385E")]
		[Address(RVA = "0x7DC1C0", Offset = "0x7DABC0", VA = "0x1807DC1C0")]
		private List<CartelActivity> GetActivitiesReadyToStart()
		{
			return null;
		}

		// Token: 0x0600385F RID: 14431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600385F")]
		[Address(RVA = "0x7DCB10", Offset = "0x7DB510", VA = "0x1807DCB10")]
		private List<EMapRegion> GetValidRegionsForActivity()
		{
			return null;
		}

		// Token: 0x06003860 RID: 14432 RVA: 0x0000F3A8 File Offset: 0x0000D5A8
		[Token(Token = "0x6003860")]
		[Address(RVA = "0x7DC5C0", Offset = "0x7DAFC0", VA = "0x1807DC5C0")]
		public static int GetNewCooldown()
		{
			return 0;
		}

		// Token: 0x06003861 RID: 14433 RVA: 0x0000F3C0 File Offset: 0x0000D5C0
		[Token(Token = "0x6003861")]
		[Address(RVA = "0x7DC320", Offset = "0x7DAD20", VA = "0x1807DC320")]
		private static float GetInfluenceFraction()
		{
			return 0f;
		}

		// Token: 0x06003862 RID: 14434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003862")]
		[Address(RVA = "0x7DE070", Offset = "0x7DCA70", VA = "0x1807DE070")]
		public CartelActivities()
		{
		}

		// Token: 0x06003863 RID: 14435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003863")]
		[Address(RVA = "0x7DCF60", Offset = "0x7DB960", VA = "0x1807DCF60", Slot = "19")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06003864 RID: 14436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003864")]
		[Address(RVA = "0x651F60", Offset = "0x650960", VA = "0x180651F60", Slot = "20")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06003865 RID: 14437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003865")]
		[Address(RVA = "0x601B00", Offset = "0x600500", VA = "0x180601B00", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06003866 RID: 14438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003866")]
		[Address(RVA = "0x7DD400", Offset = "0x7DBE00", VA = "0x1807DD400")]
		private void RpcWriter___Observers_StartGlobalActivity_1796582335(NetworkConnection conn, EMapRegion region, int activityIndex)
		{
		}

		// Token: 0x06003867 RID: 14439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003867")]
		[Address(RVA = "0x7DD120", Offset = "0x7DBB20", VA = "0x1807DD120")]
		private void RpcLogic___StartGlobalActivity_1796582335(NetworkConnection conn, EMapRegion region, int activityIndex)
		{
		}

		// Token: 0x06003868 RID: 14440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003868")]
		[Address(RVA = "0x7DD2E0", Offset = "0x7DBCE0", VA = "0x1807DD2E0")]
		private void RpcReader___Observers_StartGlobalActivity_1796582335(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003869 RID: 14441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003869")]
		[Address(RVA = "0x7DD570", Offset = "0x7DBF70", VA = "0x1807DD570")]
		private void RpcWriter___Target_StartGlobalActivity_1796582335(NetworkConnection conn, EMapRegion region, int activityIndex)
		{
		}

		// Token: 0x0600386A RID: 14442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600386A")]
		[Address(RVA = "0x7DD370", Offset = "0x7DBD70", VA = "0x1807DD370")]
		private void RpcReader___Target_StartGlobalActivity_1796582335(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600386B RID: 14443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600386B")]
		[Address(RVA = "0x601B00", Offset = "0x600500", VA = "0x180601B00", Slot = "21")]
		public virtual void Awake()
		{
		}

		// Token: 0x0400272F RID: 10031
		[Token(Token = "0x400272F")]
		public const int MAX_COOLDOWN_HOURS = 24;

		// Token: 0x04002730 RID: 10032
		[Token(Token = "0x4002730")]
		public const int MIN_COOLDOWN_HOURS = 6;

		// Token: 0x04002733 RID: 10035
		[Token(Token = "0x4002733")]
		[FieldOffset(Offset = "0x128")]
		[Header("References")]
		public List<CartelActivity> GlobalActivities;

		// Token: 0x04002734 RID: 10036
		[Token(Token = "0x4002734")]
		[FieldOffset(Offset = "0x130")]
		public CartelRegionActivities[] RegionalActivities;

		// Token: 0x04002735 RID: 10037
		[Token(Token = "0x4002735")]
		[FieldOffset(Offset = "0x138")]
		private bool NetworkInitialize___EarlyScheduleOne.Cartel.CartelActivitiesAssembly-CSharp.dll_Excuted;

		// Token: 0x04002736 RID: 10038
		[Token(Token = "0x4002736")]
		[FieldOffset(Offset = "0x139")]
		private bool NetworkInitialize__LateScheduleOne.Cartel.CartelActivitiesAssembly-CSharp.dll_Excuted;
	}
}
