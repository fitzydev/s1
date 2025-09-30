using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Loaders;
using UnityEngine.Events;

namespace ScheduleOne.GameTime
{
	// Token: 0x020002BC RID: 700
	[Token(Token = "0x20002BC")]
	public class TimeManager : NetworkSingleton<TimeManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000EAE RID: 3758 RVA: 0x00007350 File Offset: 0x00005550
		[Token(Token = "0x1700031E")]
		public bool IsEndOfDay
		{
			[Token(Token = "0x6000EAE")]
			[Address(RVA = "0xACE3F0", Offset = "0xACCDF0", VA = "0x180ACE3F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000EAF RID: 3759 RVA: 0x00007368 File Offset: 0x00005568
		// (set) Token: 0x06000EB0 RID: 3760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700031F")]
		public bool SleepInProgress
		{
			[Token(Token = "0x6000EAF")]
			[Address(RVA = "0x538700", Offset = "0x537100", VA = "0x180538700")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000EB0")]
			[Address(RVA = "0x633830", Offset = "0x632230", VA = "0x180633830")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000EB1 RID: 3761 RVA: 0x00007380 File Offset: 0x00005580
		// (set) Token: 0x06000EB2 RID: 3762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000320")]
		public int ElapsedDays
		{
			[Token(Token = "0x6000EB1")]
			[Address(RVA = "0x703460", Offset = "0x701E60", VA = "0x180703460")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000EB2")]
			[Address(RVA = "0x703500", Offset = "0x701F00", VA = "0x180703500")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000EB3 RID: 3763 RVA: 0x00007398 File Offset: 0x00005598
		// (set) Token: 0x06000EB4 RID: 3764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000321")]
		public int CurrentTime
		{
			[Token(Token = "0x6000EB3")]
			[Address(RVA = "0x542EE0", Offset = "0x5418E0", VA = "0x180542EE0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000EB4")]
			[Address(RVA = "0x63DAB0", Offset = "0x63C4B0", VA = "0x18063DAB0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000EB5 RID: 3765 RVA: 0x000073B0 File Offset: 0x000055B0
		// (set) Token: 0x06000EB6 RID: 3766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000322")]
		public float TimeOnCurrentMinute
		{
			[Token(Token = "0x6000EB5")]
			[Address(RVA = "0x538610", Offset = "0x537010", VA = "0x180538610")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000EB6")]
			[Address(RVA = "0xACE4D0", Offset = "0xACCED0", VA = "0x180ACE4D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000EB7 RID: 3767 RVA: 0x000073C8 File Offset: 0x000055C8
		// (set) Token: 0x06000EB8 RID: 3768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000323")]
		public int DailyMinTotal
		{
			[Token(Token = "0x6000EB7")]
			[Address(RVA = "0x6CAE50", Offset = "0x6C9850", VA = "0x1806CAE50")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000EB8")]
			[Address(RVA = "0x6CB050", Offset = "0x6C9A50", VA = "0x1806CB050")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000EB9 RID: 3769 RVA: 0x000073E0 File Offset: 0x000055E0
		[Token(Token = "0x17000324")]
		public bool IsNight
		{
			[Token(Token = "0x6000EB9")]
			[Address(RVA = "0xACE400", Offset = "0xACCE00", VA = "0x180ACE400")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000EBA RID: 3770 RVA: 0x000073F8 File Offset: 0x000055F8
		[Token(Token = "0x17000325")]
		public int DayIndex
		{
			[Token(Token = "0x6000EBA")]
			[Address(RVA = "0xACE3A0", Offset = "0xACCDA0", VA = "0x180ACE3A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000EBB RID: 3771 RVA: 0x00007410 File Offset: 0x00005610
		[Token(Token = "0x17000326")]
		public float NormalizedTime
		{
			[Token(Token = "0x6000EBB")]
			[Address(RVA = "0xACE430", Offset = "0xACCE30", VA = "0x180ACE430")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000EBC RID: 3772 RVA: 0x00007428 File Offset: 0x00005628
		// (set) Token: 0x06000EBD RID: 3773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000327")]
		public float Playtime
		{
			[Token(Token = "0x6000EBC")]
			[Address(RVA = "0x8D7B50", Offset = "0x8D6550", VA = "0x1808D7B50")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000EBD")]
			[Address(RVA = "0xACD510", Offset = "0xACBF10", VA = "0x180ACD510")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000EBE RID: 3774 RVA: 0x00007440 File Offset: 0x00005640
		[Token(Token = "0x17000328")]
		public EDay CurrentDay
		{
			[Token(Token = "0x6000EBE")]
			[Address(RVA = "0xACE3A0", Offset = "0xACCDA0", VA = "0x180ACE3A0")]
			get
			{
				return EDay.Monday;
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000EBF RID: 3775 RVA: 0x00007458 File Offset: 0x00005658
		// (set) Token: 0x06000EC0 RID: 3776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000329")]
		public bool TimeOverridden
		{
			[Token(Token = "0x6000EBF")]
			[Address(RVA = "0x8397C0", Offset = "0x8381C0", VA = "0x1808397C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000EC0")]
			[Address(RVA = "0x679F50", Offset = "0x678950", VA = "0x180679F50")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000EC1 RID: 3777 RVA: 0x00007470 File Offset: 0x00005670
		// (set) Token: 0x06000EC2 RID: 3778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700032A")]
		public bool HostDailySummaryDone
		{
			[Token(Token = "0x6000EC1")]
			[Address(RVA = "0xACE3E0", Offset = "0xACCDE0", VA = "0x180ACE3E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000EC2")]
			[Address(RVA = "0xACE4C0", Offset = "0xACCEC0", VA = "0x180ACE4C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000EC3 RID: 3779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700032B")]
		public string SaveFolderName
		{
			[Token(Token = "0x6000EC3")]
			[Address(RVA = "0xACE480", Offset = "0xACCE80", VA = "0x180ACE480", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000EC4 RID: 3780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700032C")]
		public string SaveFileName
		{
			[Token(Token = "0x6000EC4")]
			[Address(RVA = "0xACE450", Offset = "0xACCE50", VA = "0x180ACE450", Slot = "27")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000EC5 RID: 3781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700032D")]
		public Loader Loader
		{
			[Token(Token = "0x6000EC5")]
			[Address(RVA = "0x567030", Offset = "0x565A30", VA = "0x180567030", Slot = "28")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000EC6 RID: 3782 RVA: 0x00007488 File Offset: 0x00005688
		[Token(Token = "0x1700032E")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x6000EC6")]
			[Address(RVA = "0x4B7AD0", Offset = "0x4B64D0", VA = "0x1804B7AD0", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000EC7 RID: 3783 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000EC8 RID: 3784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700032F")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x6000EC7")]
			[Address(RVA = "0x69CBD0", Offset = "0x69B5D0", VA = "0x18069CBD0", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000EC8")]
			[Address(RVA = "0x69CBF0", Offset = "0x69B5F0", VA = "0x18069CBF0", Slot = "31")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000EC9 RID: 3785 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000ECA RID: 3786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000330")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x6000EC9")]
			[Address(RVA = "0x716B50", Offset = "0x715550", VA = "0x180716B50", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000ECA")]
			[Address(RVA = "0x716E50", Offset = "0x715850", VA = "0x180716E50", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000ECB RID: 3787 RVA: 0x000074A0 File Offset: 0x000056A0
		// (set) Token: 0x06000ECC RID: 3788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000331")]
		public bool HasChanged
		{
			[Token(Token = "0x6000ECB")]
			[Address(RVA = "0xACE3D0", Offset = "0xACCDD0", VA = "0x180ACE3D0", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000ECC")]
			[Address(RVA = "0xACE4B0", Offset = "0xACCEB0", VA = "0x180ACE4B0", Slot = "35")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000ECD RID: 3789 RVA: 0x000074B8 File Offset: 0x000056B8
		[Token(Token = "0x17000332")]
		public int LoadOrder
		{
			[Token(Token = "0x6000ECD")]
			[Address(RVA = "0xACE420", Offset = "0xACCE20", VA = "0x180ACE420", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ECE")]
		[Address(RVA = "0xACA2F0", Offset = "0xAC8CF0", VA = "0x180ACA2F0", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ECF")]
		[Address(RVA = "0xACAFE0", Offset = "0xAC99E0", VA = "0x180ACAFE0", Slot = "49")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ED0")]
		[Address(RVA = "0xACB850", Offset = "0xACA250", VA = "0x180ACB850", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06000ED1 RID: 3793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ED1")]
		[Address(RVA = "0xACB8A0", Offset = "0xACA2A0", VA = "0x180ACB8A0", Slot = "11")]
		public override void OnStartClient()
		{
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ED2")]
		[Address(RVA = "0xACA340", Offset = "0xAC8D40", VA = "0x180ACA340")]
		private void Clean()
		{
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ED3")]
		[Address(RVA = "0xACCE70", Offset = "0xACB870", VA = "0x180ACCE70")]
		public void SendTimeData(NetworkConnection connection)
		{
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ED4")]
		[Address(RVA = "0xACCF60", Offset = "0xACB960", VA = "0x180ACCF60")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true, ExcludeServer = true)]
		private void SetData(NetworkConnection conn, int _elapsedDays, int _time, float sendTime)
		{
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ED5")]
		[Address(RVA = "0xACDFF0", Offset = "0xACC9F0", VA = "0x180ACDFF0", Slot = "50")]
		protected virtual void Update()
		{
		}

		// Token: 0x06000ED6 RID: 3798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ED6")]
		[Address(RVA = "0x680300", Offset = "0x67ED00", VA = "0x180680300", Slot = "51")]
		protected virtual void FixedUpdate()
		{
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ED7")]
		[Address(RVA = "0xACB980", Offset = "0xACA380", VA = "0x180ACB980")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void ResetHostSleepDone()
		{
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ED8")]
		[Address(RVA = "0xACB3E0", Offset = "0xAC9DE0", VA = "0x180ACB3E0")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void MarkHostSleepDone()
		{
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ED9")]
		[Address(RVA = "0xACD3D0", Offset = "0xACBDD0", VA = "0x180ACD3D0")]
		[ObserversRpc(RunLocally = true)]
		private void SetHostSleepDone(bool done)
		{
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EDA")]
		[Address(RVA = "0xACDA00", Offset = "0xACC400", VA = "0x180ACDA00")]
		private IEnumerator TickLoop()
		{
			return null;
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EDB")]
		[Address(RVA = "0xACDF60", Offset = "0xACC960", VA = "0x180ACDF60")]
		private IEnumerator TimeLoop()
		{
			return null;
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EDC")]
		[Address(RVA = "0xACD860", Offset = "0xACC260", VA = "0x180ACD860")]
		private IEnumerator StaggeredMinPass(float staggerTime)
		{
			return null;
		}

		// Token: 0x06000EDD RID: 3805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EDD")]
		[Address(RVA = "0xACDA70", Offset = "0xACC470", VA = "0x180ACDA70")]
		private void Tick()
		{
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EDE")]
		[Address(RVA = "0xACD680", Offset = "0xACC080", VA = "0x180ACD680")]
		public void SetTime(int _time, bool local = false)
		{
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EDF")]
		[Address(RVA = "0xACD270", Offset = "0xACBC70", VA = "0x180ACD270")]
		public void SetElapsedDays(int days)
		{
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EE0")]
		[Address(RVA = "0xACAB30", Offset = "0xAC9530", VA = "0x180ACAB30")]
		public static string Get12HourTime(float _time, bool appendDesignator = true)
		{
			return null;
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x000074D0 File Offset: 0x000056D0
		[Token(Token = "0x6000EE1")]
		[Address(RVA = "0xACACF0", Offset = "0xAC96F0", VA = "0x180ACACF0")]
		public static int Get24HourTimeFromMinSum(int minSum)
		{
			return 0;
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x000074E8 File Offset: 0x000056E8
		[Token(Token = "0x6000EE2")]
		[Address(RVA = "0xACAEE0", Offset = "0xAC98E0", VA = "0x180ACAEE0")]
		public static int GetMinSumFrom24HourTime(int _time)
		{
			return 0;
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x00007500 File Offset: 0x00005700
		[Token(Token = "0x6000EE3")]
		[Address(RVA = "0xACB330", Offset = "0xAC9D30", VA = "0x180ACB330")]
		public bool IsCurrentTimeWithinRange(int min, int max)
		{
			return default(bool);
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x00007518 File Offset: 0x00005718
		[Token(Token = "0x6000EE4")]
		[Address(RVA = "0xACB350", Offset = "0xAC9D50", VA = "0x180ACB350")]
		public static bool IsGivenTimeWithinRange(int givenTime, int min, int max)
		{
			return default(bool);
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x00007530 File Offset: 0x00005730
		[Token(Token = "0x6000EE5")]
		[Address(RVA = "0xACB370", Offset = "0xAC9D70", VA = "0x180ACB370")]
		public static bool IsValid24HourTime(string input)
		{
			return default(bool);
		}

		// Token: 0x06000EE6 RID: 3814 RVA: 0x00007548 File Offset: 0x00005748
		[Token(Token = "0x6000EE6")]
		[Address(RVA = "0xACB2B0", Offset = "0xAC9CB0", VA = "0x180ACB2B0")]
		public bool IsCurrentDateWithinRange(GameDateTime start, GameDateTime end)
		{
			return default(bool);
		}

		// Token: 0x06000EE7 RID: 3815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EE7")]
		[Address(RVA = "0xACB070", Offset = "0xAC9A70", VA = "0x180ACB070")]
		[ObserversRpc]
		private void InvokeDayPassClientSide()
		{
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EE8")]
		[Address(RVA = "0xACB190", Offset = "0xAC9B90", VA = "0x180ACB190")]
		[ObserversRpc]
		private void InvokeWeekPassClientSide()
		{
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EE9")]
		[Address(RVA = "0xACA540", Offset = "0xAC8F40", VA = "0x180ACA540")]
		public void FastForwardToWakeTime()
		{
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x00007560 File Offset: 0x00005760
		[Token(Token = "0x6000EEA")]
		[Address(RVA = "0xACAEC0", Offset = "0xAC98C0", VA = "0x180ACAEC0")]
		public GameDateTime GetDateTime()
		{
			return default(GameDateTime);
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x00007578 File Offset: 0x00005778
		[Token(Token = "0x6000EEB")]
		[Address(RVA = "0xACAFC0", Offset = "0xAC99C0", VA = "0x180ACAFC0")]
		public int GetTotalMinSum()
		{
			return 0;
		}

		// Token: 0x06000EEC RID: 3820 RVA: 0x00007590 File Offset: 0x00005790
		[Token(Token = "0x6000EEC")]
		[Address(RVA = "0xAC9F30", Offset = "0xAC8930", VA = "0x180AC9F30")]
		public static int AddMinutesTo24HourTime(int time, int minsToAdd)
		{
			return 0;
		}

		// Token: 0x06000EED RID: 3821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EED")]
		[Address(RVA = "0xACAD40", Offset = "0xAC9740", VA = "0x180ACAD40")]
		public static List<int> GetAllTimeInRange(int min, int max)
		{
			return null;
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EEE")]
		[Address(RVA = "0xACCBA0", Offset = "0xACB5A0", VA = "0x180ACCBA0")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetWakeTime(int amount)
		{
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EEF")]
		[Address(RVA = "0xACAB00", Offset = "0xAC9500", VA = "0x180ACAB00")]
		public void ForceSleep()
		{
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EF0")]
		[Address(RVA = "0xACD8E0", Offset = "0xACC2E0", VA = "0x180ACD8E0")]
		[ObserversRpc(RunLocally = true)]
		private void StartSleep()
		{
		}

		// Token: 0x06000EF1 RID: 3825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EF1")]
		[Address(RVA = "0xACA420", Offset = "0xAC8E20", VA = "0x180ACA420")]
		[ObserversRpc(RunLocally = true)]
		private void EndSleep()
		{
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EF2")]
		[Address(RVA = "0xACAF00", Offset = "0xAC9900", VA = "0x180ACAF00", Slot = "52")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EF3")]
		[Address(RVA = "0xACD510", Offset = "0xACBF10", VA = "0x180ACD510")]
		public void SetPlaytime(float time)
		{
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EF4")]
		[Address(RVA = "0xACD5A0", Offset = "0xACBFA0", VA = "0x180ACD5A0")]
		public void SetTimeOverridden(bool overridden, int time = 1200)
		{
		}

		// Token: 0x06000EF5 RID: 3829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EF5")]
		[Address(RVA = "0xACD520", Offset = "0xACBF20", VA = "0x180ACD520")]
		private void SetRandomTime()
		{
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EF6")]
		[Address(RVA = "0xACE250", Offset = "0xACCC50", VA = "0x180ACE250")]
		public TimeManager()
		{
		}

		// Token: 0x06000EF8 RID: 3832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EF8")]
		[Address(RVA = "0xACB540", Offset = "0xAC9F40", VA = "0x180ACB540", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06000EF9 RID: 3833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EF9")]
		[Address(RVA = "0xACB4F0", Offset = "0xAC9EF0", VA = "0x180ACB4F0", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EFA")]
		[Address(RVA = "0x5B3020", Offset = "0x5B1A20", VA = "0x1805B3020", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EFB")]
		[Address(RVA = "0xACC580", Offset = "0xACAF80", VA = "0x180ACC580")]
		private void RpcWriter___Observers_SetData_2661156041(NetworkConnection conn, int _elapsedDays, int _time, float sendTime)
		{
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EFC")]
		[Address(RVA = "0xACBD10", Offset = "0xACA710", VA = "0x180ACBD10")]
		private void RpcLogic___SetData_2661156041(NetworkConnection conn, int _elapsedDays, int _time, float sendTime)
		{
		}

		// Token: 0x06000EFD RID: 3837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EFD")]
		[Address(RVA = "0xACC110", Offset = "0xACAB10", VA = "0x180ACC110")]
		private void RpcReader___Observers_SetData_2661156041(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06000EFE RID: 3838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EFE")]
		[Address(RVA = "0xACCCE0", Offset = "0xACB6E0", VA = "0x180ACCCE0")]
		private void RpcWriter___Target_SetData_2661156041(NetworkConnection conn, int _elapsedDays, int _time, float sendTime)
		{
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EFF")]
		[Address(RVA = "0xACC3A0", Offset = "0xACADA0", VA = "0x180ACC3A0")]
		private void RpcReader___Target_SetData_2661156041(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06000F00 RID: 3840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F00")]
		[Address(RVA = "0xACCA90", Offset = "0xACB490", VA = "0x180ACCA90")]
		private void RpcWriter___Server_ResetHostSleepDone_2166136261()
		{
		}

		// Token: 0x06000F01 RID: 3841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F01")]
		[Address(RVA = "0xACBD00", Offset = "0xACA700", VA = "0x180ACBD00")]
		public void RpcLogic___ResetHostSleepDone_2166136261()
		{
		}

		// Token: 0x06000F02 RID: 3842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F02")]
		[Address(RVA = "0xACC2E0", Offset = "0xACACE0", VA = "0x180ACC2E0")]
		private void RpcReader___Server_ResetHostSleepDone_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06000F03 RID: 3843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F03")]
		[Address(RVA = "0xACC980", Offset = "0xACB380", VA = "0x180ACC980")]
		private void RpcWriter___Server_MarkHostSleepDone_2166136261()
		{
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F04")]
		[Address(RVA = "0xACBCF0", Offset = "0xACA6F0", VA = "0x180ACBCF0")]
		public void RpcLogic___MarkHostSleepDone_2166136261()
		{
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F05")]
		[Address(RVA = "0xACC290", Offset = "0xACAC90", VA = "0x180ACC290")]
		private void RpcReader___Server_MarkHostSleepDone_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06000F06 RID: 3846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F06")]
		[Address(RVA = "0xACC720", Offset = "0xACB120", VA = "0x180ACC720")]
		private void RpcWriter___Observers_SetHostSleepDone_1140765316(bool done)
		{
		}

		// Token: 0x06000F07 RID: 3847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F07")]
		[Address(RVA = "0xACBE40", Offset = "0xACA840", VA = "0x180ACBE40")]
		private void RpcLogic___SetHostSleepDone_1140765316(bool done)
		{
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F08")]
		[Address(RVA = "0xACC1D0", Offset = "0xACABD0", VA = "0x180ACC1D0")]
		private void RpcReader___Observers_SetHostSleepDone_1140765316(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F09")]
		[Address(RVA = "0xACB070", Offset = "0xAC9A70", VA = "0x180ACB070")]
		private void RpcWriter___Observers_InvokeDayPassClientSide_2166136261()
		{
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F0A")]
		[Address(RVA = "0xACBC70", Offset = "0xACA670", VA = "0x180ACBC70")]
		private void RpcLogic___InvokeDayPassClientSide_2166136261()
		{
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F0B")]
		[Address(RVA = "0xACC070", Offset = "0xACAA70", VA = "0x180ACC070")]
		private void RpcReader___Observers_InvokeDayPassClientSide_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F0C")]
		[Address(RVA = "0xACB190", Offset = "0xAC9B90", VA = "0x180ACB190")]
		private void RpcWriter___Observers_InvokeWeekPassClientSide_2166136261()
		{
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F0D")]
		[Address(RVA = "0xACBCB0", Offset = "0xACA6B0", VA = "0x180ACBCB0")]
		private void RpcLogic___InvokeWeekPassClientSide_2166136261()
		{
		}

		// Token: 0x06000F0E RID: 3854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F0E")]
		[Address(RVA = "0xACC0C0", Offset = "0xACAAC0", VA = "0x180ACC0C0")]
		private void RpcReader___Observers_InvokeWeekPassClientSide_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F0F")]
		[Address(RVA = "0xACCBA0", Offset = "0xACB5A0", VA = "0x180ACCBA0")]
		private void RpcWriter___Server_SetWakeTime_3316948804(int amount)
		{
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F10")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80")]
		public void RpcLogic___SetWakeTime_3316948804(int amount)
		{
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F11")]
		[Address(RVA = "0xACC330", Offset = "0xACAD30", VA = "0x180ACC330")]
		private void RpcReader___Server_SetWakeTime_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F12")]
		[Address(RVA = "0xACC860", Offset = "0xACB260", VA = "0x180ACC860")]
		private void RpcWriter___Observers_StartSleep_2166136261()
		{
		}

		// Token: 0x06000F13 RID: 3859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F13")]
		[Address(RVA = "0xACBEF0", Offset = "0xACA8F0", VA = "0x180ACBEF0")]
		private void RpcLogic___StartSleep_2166136261()
		{
		}

		// Token: 0x06000F14 RID: 3860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F14")]
		[Address(RVA = "0xACC250", Offset = "0xACAC50", VA = "0x180ACC250")]
		private void RpcReader___Observers_StartSleep_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06000F15 RID: 3861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F15")]
		[Address(RVA = "0xACC460", Offset = "0xACAE60", VA = "0x180ACC460")]
		private void RpcWriter___Observers_EndSleep_2166136261()
		{
		}

		// Token: 0x06000F16 RID: 3862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F16")]
		[Address(RVA = "0xACBA90", Offset = "0xACA490", VA = "0x180ACBA90")]
		private void RpcLogic___EndSleep_2166136261()
		{
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F17")]
		[Address(RVA = "0xACC030", Offset = "0xACAA30", VA = "0x180ACC030")]
		private void RpcReader___Observers_EndSleep_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06000F18 RID: 3864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F18")]
		[Address(RVA = "0xAC9FB0", Offset = "0xAC89B0", VA = "0x180AC9FB0", Slot = "53")]
		protected virtual void Awake_UserLogic_ScheduleOne.GameTime.TimeManager_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04000EFE RID: 3838
		[Token(Token = "0x4000EFE")]
		public const float CYCLE_DURATION_MINS = 24f;

		// Token: 0x04000EFF RID: 3839
		[Token(Token = "0x4000EFF")]
		public const float MINUTE_TIME = 1f;

		// Token: 0x04000F00 RID: 3840
		[Token(Token = "0x4000F00")]
		public const int DEFAULT_WAKE_TIME = 700;

		// Token: 0x04000F01 RID: 3841
		[Token(Token = "0x4000F01")]
		public const int END_OF_DAY = 400;

		// Token: 0x04000F06 RID: 3846
		[Token(Token = "0x4000F06")]
		[FieldOffset(Offset = "0x130")]
		public int DefaultTime;

		// Token: 0x04000F07 RID: 3847
		[Token(Token = "0x4000F07")]
		[FieldOffset(Offset = "0x134")]
		public EDay DefaultDay;

		// Token: 0x04000F08 RID: 3848
		[Token(Token = "0x4000F08")]
		[FieldOffset(Offset = "0x138")]
		public float TimeProgressionMultiplier;

		// Token: 0x04000F0B RID: 3851
		[Token(Token = "0x4000F0B")]
		[FieldOffset(Offset = "0x144")]
		private int savedTime;

		// Token: 0x04000F0D RID: 3853
		[Token(Token = "0x4000F0D")]
		[FieldOffset(Offset = "0x150")]
		public ActionList onMinutePass;

		// Token: 0x04000F0E RID: 3854
		[Token(Token = "0x4000F0E")]
		[FieldOffset(Offset = "0x158")]
		public Action onHourPass;

		// Token: 0x04000F0F RID: 3855
		[Token(Token = "0x4000F0F")]
		[FieldOffset(Offset = "0x160")]
		public Action onDayPass;

		// Token: 0x04000F10 RID: 3856
		[Token(Token = "0x4000F10")]
		[FieldOffset(Offset = "0x168")]
		public Action onWeekPass;

		// Token: 0x04000F11 RID: 3857
		[Token(Token = "0x4000F11")]
		[FieldOffset(Offset = "0x170")]
		public Action onUpdate;

		// Token: 0x04000F12 RID: 3858
		[Token(Token = "0x4000F12")]
		[FieldOffset(Offset = "0x178")]
		public Action onFixedUpdate;

		// Token: 0x04000F13 RID: 3859
		[Token(Token = "0x4000F13")]
		[FieldOffset(Offset = "0x180")]
		public Action<int> onTimeSkip;

		// Token: 0x04000F14 RID: 3860
		[Token(Token = "0x4000F14")]
		[FieldOffset(Offset = "0x188")]
		public Action onTick;

		// Token: 0x04000F15 RID: 3861
		[Token(Token = "0x4000F15")]
		[FieldOffset(Offset = "0x190")]
		public Action onTimeChanged;

		// Token: 0x04000F16 RID: 3862
		[Token(Token = "0x4000F16")]
		[FieldOffset(Offset = "0x198")]
		public Action onSleepStart;

		// Token: 0x04000F17 RID: 3863
		[Token(Token = "0x4000F17")]
		[FieldOffset(Offset = "0x1A0")]
		public Action onSleepEnd;

		// Token: 0x04000F18 RID: 3864
		[Token(Token = "0x4000F18")]
		[FieldOffset(Offset = "0x1A8")]
		public UnityEvent onFirstNight;

		// Token: 0x04000F19 RID: 3865
		[Token(Token = "0x4000F19")]
		public const int SelectedWakeTime = 700;

		// Token: 0x04000F1A RID: 3866
		[Token(Token = "0x4000F1A")]
		[FieldOffset(Offset = "0x1B0")]
		private GameDateTime sleepStartTime;

		// Token: 0x04000F1B RID: 3867
		[Token(Token = "0x4000F1B")]
		[FieldOffset(Offset = "0x1B8")]
		private int sleepEndTime;

		// Token: 0x04000F1D RID: 3869
		[Token(Token = "0x4000F1D")]
		[FieldOffset(Offset = "0x1C0")]
		private float defaultFixedTimeScale;

		// Token: 0x04000F1E RID: 3870
		[Token(Token = "0x4000F1E")]
		[FieldOffset(Offset = "0x1C8")]
		private TimeLoader loader;

		// Token: 0x04000F23 RID: 3875
		[Token(Token = "0x4000F23")]
		[FieldOffset(Offset = "0x1E8")]
		private bool NetworkInitialize___EarlyScheduleOne.GameTime.TimeManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x04000F24 RID: 3876
		[Token(Token = "0x4000F24")]
		[FieldOffset(Offset = "0x1E9")]
		private bool NetworkInitialize__LateScheduleOne.GameTime.TimeManagerAssembly-CSharp.dll_Excuted;
	}
}
