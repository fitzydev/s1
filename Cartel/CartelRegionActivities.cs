using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Map;
using ScheduleOne.Persistence;
using UnityEngine;

namespace ScheduleOne.Cartel
{
	// Token: 0x02000815 RID: 2069
	[Token(Token = "0x2000815")]
	public class CartelRegionActivities : NetworkBehaviour
	{
		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x060038F8 RID: 14584 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060038F9 RID: 14585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000814")]
		public CartelActivity CurrentActivity
		{
			[Token(Token = "0x60038F8")]
			[Address(RVA = "0x62FD10", Offset = "0x62E710", VA = "0x18062FD10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60038F9")]
			[Address(RVA = "0x630490", Offset = "0x62EE90", VA = "0x180630490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x060038FA RID: 14586 RVA: 0x0000F4F8 File Offset: 0x0000D6F8
		// (set) Token: 0x060038FB RID: 14587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000815")]
		public int HoursUntilNextActivity
		{
			[Token(Token = "0x60038FA")]
			[Address(RVA = "0x542EE0", Offset = "0x5418E0", VA = "0x180542EE0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60038FB")]
			[Address(RVA = "0x63DAB0", Offset = "0x63C4B0", VA = "0x18063DAB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060038FC RID: 14588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038FC")]
		[Address(RVA = "0x807B90", Offset = "0x806590", VA = "0x180807B90", Slot = "16")]
		protected override void OnValidate()
		{
		}

		// Token: 0x060038FD RID: 14589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038FD")]
		[Address(RVA = "0x8085D0", Offset = "0x806FD0", VA = "0x1808085D0")]
		private void Start()
		{
		}

		// Token: 0x060038FE RID: 14590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038FE")]
		[Address(RVA = "0x807AB0", Offset = "0x8064B0", VA = "0x180807AB0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x060038FF RID: 14591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038FF")]
		[Address(RVA = "0x807810", Offset = "0x806210", VA = "0x180807810")]
		public void HourPass()
		{
		}

		// Token: 0x06003900 RID: 14592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003900")]
		[Address(RVA = "0x8088F0", Offset = "0x8072F0", VA = "0x1808088F0")]
		private void TryStartActivity()
		{
		}

		// Token: 0x06003901 RID: 14593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003901")]
		[Address(RVA = "0x808350", Offset = "0x806D50", VA = "0x180808350")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void StartActivity(NetworkConnection conn, int activityIndex)
		{
		}

		// Token: 0x06003902 RID: 14594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003902")]
		[Address(RVA = "0x807080", Offset = "0x805A80", VA = "0x180807080")]
		private void ActivityEnded()
		{
		}

		// Token: 0x06003903 RID: 14595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003903")]
		[Address(RVA = "0x807200", Offset = "0x805C00", VA = "0x180807200")]
		public CartelRegionalActivityData GetData()
		{
			return null;
		}

		// Token: 0x06003904 RID: 14596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003904")]
		[Address(RVA = "0x807920", Offset = "0x806320", VA = "0x180807920")]
		public void Load(CartelRegionalActivityData data)
		{
		}

		// Token: 0x06003905 RID: 14597 RVA: 0x0000F510 File Offset: 0x0000D710
		[Token(Token = "0x6003905")]
		[Address(RVA = "0x8072F0", Offset = "0x805CF0", VA = "0x1808072F0")]
		public static int GetNewCooldown(EMapRegion region)
		{
			return 0;
		}

		// Token: 0x06003906 RID: 14598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003906")]
		[Address(RVA = "0x8071D0", Offset = "0x805BD0", VA = "0x1808071D0")]
		private void CartelStatusChange(ECartelStatus oldStatus, ECartelStatus newStatus)
		{
		}

		// Token: 0x06003907 RID: 14599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003907")]
		[Address(RVA = "0x808C30", Offset = "0x807630", VA = "0x180808C30")]
		public CartelRegionActivities()
		{
		}

		// Token: 0x06003908 RID: 14600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003908")]
		[Address(RVA = "0x8079E0", Offset = "0x8063E0", VA = "0x1808079E0", Slot = "19")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06003909 RID: 14601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003909")]
		[Address(RVA = "0x8079C0", Offset = "0x8063C0", VA = "0x1808079C0", Slot = "20")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600390A RID: 14602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600390A")]
		[Address(RVA = "0x601B00", Offset = "0x600500", VA = "0x180601B00", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600390B RID: 14603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600390B")]
		[Address(RVA = "0x808090", Offset = "0x806A90", VA = "0x180808090")]
		private void RpcWriter___Observers_StartActivity_2681120339(NetworkConnection conn, int activityIndex)
		{
		}

		// Token: 0x0600390C RID: 14604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600390C")]
		[Address(RVA = "0x807C30", Offset = "0x806630", VA = "0x180807C30")]
		private void RpcLogic___StartActivity_2681120339(NetworkConnection conn, int activityIndex)
		{
		}

		// Token: 0x0600390D RID: 14605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600390D")]
		[Address(RVA = "0x807FB0", Offset = "0x8069B0", VA = "0x180807FB0")]
		private void RpcReader___Observers_StartActivity_2681120339(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600390E RID: 14606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600390E")]
		[Address(RVA = "0x8081E0", Offset = "0x806BE0", VA = "0x1808081E0")]
		private void RpcWriter___Target_StartActivity_2681120339(NetworkConnection conn, int activityIndex)
		{
		}

		// Token: 0x0600390F RID: 14607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600390F")]
		[Address(RVA = "0x808020", Offset = "0x806A20", VA = "0x180808020")]
		private void RpcReader___Target_StartActivity_2681120339(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003910 RID: 14608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003910")]
		[Address(RVA = "0x601B00", Offset = "0x600500", VA = "0x180601B00", Slot = "21")]
		public virtual void Awake()
		{
		}

		// Token: 0x04002783 RID: 10115
		[Token(Token = "0x4002783")]
		public const int MIN_COOLDOWN = 12;

		// Token: 0x04002784 RID: 10116
		[Token(Token = "0x4002784")]
		public const int MAX_COOLDOWN = 48;

		// Token: 0x04002785 RID: 10117
		[Token(Token = "0x4002785")]
		[FieldOffset(Offset = "0x118")]
		public bool TEST_MODE;

		// Token: 0x04002788 RID: 10120
		[Token(Token = "0x4002788")]
		[FieldOffset(Offset = "0x12C")]
		[Header("Settings")]
		public bool Active;

		// Token: 0x04002789 RID: 10121
		[Token(Token = "0x4002789")]
		[FieldOffset(Offset = "0x130")]
		public EMapRegion Region;

		// Token: 0x0400278A RID: 10122
		[Token(Token = "0x400278A")]
		[FieldOffset(Offset = "0x138")]
		public List<CartelActivity> Activities;

		// Token: 0x0400278B RID: 10123
		[Token(Token = "0x400278B")]
		[FieldOffset(Offset = "0x140")]
		[Header("References")]
		public CartelAmbushLocation[] AmbushLocations;

		// Token: 0x0400278C RID: 10124
		[Token(Token = "0x400278C")]
		[FieldOffset(Offset = "0x148")]
		public CartelDealer CartelDealer;

		// Token: 0x0400278D RID: 10125
		[Token(Token = "0x400278D")]
		[FieldOffset(Offset = "0x150")]
		private bool NetworkInitialize___EarlyScheduleOne.Cartel.CartelRegionActivitiesAssembly-CSharp.dll_Excuted;

		// Token: 0x0400278E RID: 10126
		[Token(Token = "0x400278E")]
		[FieldOffset(Offset = "0x151")]
		private bool NetworkInitialize__LateScheduleOne.Cartel.CartelRegionActivitiesAssembly-CSharp.dll_Excuted;
	}
}
