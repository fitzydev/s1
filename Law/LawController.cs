using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using UnityEngine;

namespace ScheduleOne.Law
{
	// Token: 0x0200053B RID: 1339
	[Token(Token = "0x200053B")]
	public class LawController : Singleton<LawController>, IBaseSaveable, ISaveable
	{
		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06001B53 RID: 6995 RVA: 0x00009708 File Offset: 0x00007908
		// (set) Token: 0x06001B54 RID: 6996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004CC")]
		public bool OverrideSettings
		{
			[Token(Token = "0x6001B53")]
			[Address(RVA = "0x639DA0", Offset = "0x6387A0", VA = "0x180639DA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001B54")]
			[Address(RVA = "0x639E70", Offset = "0x638870", VA = "0x180639E70")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06001B55 RID: 6997 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001B56 RID: 6998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004CD")]
		public LawActivitySettings OverriddenSettings
		{
			[Token(Token = "0x6001B55")]
			[Address(RVA = "0x4573C0", Offset = "0x455DC0", VA = "0x1804573C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B56")]
			[Address(RVA = "0x6009E0", Offset = "0x5FF3E0", VA = "0x1806009E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06001B57 RID: 6999 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001B58 RID: 7000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004CE")]
		public LawActivitySettings CurrentSettings
		{
			[Token(Token = "0x6001B57")]
			[Address(RVA = "0x4F2140", Offset = "0x4F0B40", VA = "0x1804F2140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B58")]
			[Address(RVA = "0x639E10", Offset = "0x638810", VA = "0x180639E10")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06001B59 RID: 7001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004CF")]
		public string SaveFolderName
		{
			[Token(Token = "0x6001B59")]
			[Address(RVA = "0x639DE0", Offset = "0x6387E0", VA = "0x180639DE0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06001B5A RID: 7002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004D0")]
		public string SaveFileName
		{
			[Token(Token = "0x6001B5A")]
			[Address(RVA = "0x639DB0", Offset = "0x6387B0", VA = "0x180639DB0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06001B5B RID: 7003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004D1")]
		public Loader Loader
		{
			[Token(Token = "0x6001B5B")]
			[Address(RVA = "0x506BA0", Offset = "0x5055A0", VA = "0x180506BA0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06001B5C RID: 7004 RVA: 0x00009720 File Offset: 0x00007920
		[Token(Token = "0x170004D2")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x6001B5C")]
			[Address(RVA = "0x4B7AD0", Offset = "0x4B64D0", VA = "0x1804B7AD0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06001B5D RID: 7005 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001B5E RID: 7006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D3")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x6001B5D")]
			[Address(RVA = "0x4F1FB0", Offset = "0x4F09B0", VA = "0x1804F1FB0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B5E")]
			[Address(RVA = "0x639E30", Offset = "0x638830", VA = "0x180639E30", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06001B5F RID: 7007 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001B60 RID: 7008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D4")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x6001B5F")]
			[Address(RVA = "0x4ACC40", Offset = "0x4AB640", VA = "0x1804ACC40", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B60")]
			[Address(RVA = "0x639E50", Offset = "0x638850", VA = "0x180639E50", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06001B61 RID: 7009 RVA: 0x00009738 File Offset: 0x00007938
		// (set) Token: 0x06001B62 RID: 7010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D5")]
		public bool HasChanged
		{
			[Token(Token = "0x6001B61")]
			[Address(RVA = "0x639D80", Offset = "0x638780", VA = "0x180639D80", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001B62")]
			[Address(RVA = "0x639E20", Offset = "0x638820", VA = "0x180639E20", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06001B63 RID: 7011 RVA: 0x00009750 File Offset: 0x00007950
		[Token(Token = "0x170004D6")]
		public int LoadOrder
		{
			[Token(Token = "0x6001B63")]
			[Address(RVA = "0x639D90", Offset = "0x638790", VA = "0x180639D90", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001B64 RID: 7012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B64")]
		[Address(RVA = "0x638EC0", Offset = "0x6378C0", VA = "0x180638EC0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B65")]
		[Address(RVA = "0x639220", Offset = "0x637C20", VA = "0x180639220", Slot = "31")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x06001B66 RID: 7014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B66")]
		[Address(RVA = "0x6398A0", Offset = "0x6382A0", VA = "0x1806398A0", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06001B67 RID: 7015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B67")]
		[Address(RVA = "0x6393F0", Offset = "0x637DF0", VA = "0x1806393F0", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06001B68 RID: 7016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B68")]
		[Address(RVA = "0x639730", Offset = "0x638130", VA = "0x180639730")]
		private void OnLoadComplete()
		{
		}

		// Token: 0x06001B69 RID: 7017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B69")]
		[Address(RVA = "0x639320", Offset = "0x637D20", VA = "0x180639320")]
		private void MinPass()
		{
		}

		// Token: 0x06001B6A RID: 7018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B6A")]
		[Address(RVA = "0x5DC7D0", Offset = "0x5DB1D0", VA = "0x1805DC7D0")]
		private void HourPass()
		{
		}

		// Token: 0x06001B6B RID: 7019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B6B")]
		[Address(RVA = "0x638F80", Offset = "0x637980", VA = "0x180638F80")]
		private void DayPass()
		{
		}

		// Token: 0x06001B6C RID: 7020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B6C")]
		[Address(RVA = "0x639100", Offset = "0x637B00", VA = "0x180639100")]
		public LawActivitySettings GetSettings()
		{
			return null;
		}

		// Token: 0x06001B6D RID: 7021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B6D")]
		[Address(RVA = "0x6390A0", Offset = "0x637AA0", VA = "0x1806390A0")]
		public LawActivitySettings GetSettings(EDay day)
		{
			return null;
		}

		// Token: 0x06001B6E RID: 7022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B6E")]
		[Address(RVA = "0x639810", Offset = "0x638210", VA = "0x180639810")]
		public void OverrideSetings(LawActivitySettings settings)
		{
		}

		// Token: 0x06001B6F RID: 7023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B6F")]
		[Address(RVA = "0x639000", Offset = "0x637A00", VA = "0x180639000")]
		public void EndOverride()
		{
		}

		// Token: 0x06001B70 RID: 7024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B70")]
		[Address(RVA = "0x638F10", Offset = "0x637910", VA = "0x180638F10")]
		public void ChangeInternalIntensity(float change)
		{
		}

		// Token: 0x06001B71 RID: 7025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B71")]
		[Address(RVA = "0x639830", Offset = "0x638230", VA = "0x180639830")]
		public void SetInternalIntensity(float intensity)
		{
		}

		// Token: 0x06001B72 RID: 7026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B72")]
		[Address(RVA = "0x639020", Offset = "0x637A20", VA = "0x180639020", Slot = "32")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x06001B73 RID: 7027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B73")]
		[Address(RVA = "0x6392B0", Offset = "0x637CB0", VA = "0x1806392B0")]
		public void Load(LawData data)
		{
		}

		// Token: 0x06001B74 RID: 7028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B74")]
		[Address(RVA = "0x639C70", Offset = "0x638670", VA = "0x180639C70")]
		public LawController()
		{
		}

		// Token: 0x0400175C RID: 5980
		[Token(Token = "0x400175C")]
		public const float DAILY_INTENSITY_DRAIN = 0.05f;

		// Token: 0x0400175D RID: 5981
		[Token(Token = "0x400175D")]
		[FieldOffset(Offset = "0x28")]
		[Range(1f, 10f)]
		public int LE_Intensity;

		// Token: 0x0400175E RID: 5982
		[Token(Token = "0x400175E")]
		[FieldOffset(Offset = "0x2C")]
		private float internalLawIntensity;

		// Token: 0x0400175F RID: 5983
		[Token(Token = "0x400175F")]
		[FieldOffset(Offset = "0x30")]
		[Header("Settings")]
		public LawActivitySettings MondaySettings;

		// Token: 0x04001760 RID: 5984
		[Token(Token = "0x4001760")]
		[FieldOffset(Offset = "0x38")]
		public LawActivitySettings TuesdaySettings;

		// Token: 0x04001761 RID: 5985
		[Token(Token = "0x4001761")]
		[FieldOffset(Offset = "0x40")]
		public LawActivitySettings WednesdaySettings;

		// Token: 0x04001762 RID: 5986
		[Token(Token = "0x4001762")]
		[FieldOffset(Offset = "0x48")]
		public LawActivitySettings ThursdaySettings;

		// Token: 0x04001763 RID: 5987
		[Token(Token = "0x4001763")]
		[FieldOffset(Offset = "0x50")]
		public LawActivitySettings FridaySettings;

		// Token: 0x04001764 RID: 5988
		[Token(Token = "0x4001764")]
		[FieldOffset(Offset = "0x58")]
		public LawActivitySettings SaturdaySettings;

		// Token: 0x04001765 RID: 5989
		[Token(Token = "0x4001765")]
		[FieldOffset(Offset = "0x60")]
		public LawActivitySettings SundaySettings;

		// Token: 0x04001766 RID: 5990
		[Token(Token = "0x4001766")]
		[FieldOffset(Offset = "0x68")]
		[Header("Demo Settings")]
		public float IntensityIncreasePerDay;

		// Token: 0x0400176A RID: 5994
		[Token(Token = "0x400176A")]
		[FieldOffset(Offset = "0x80")]
		private LawLoader loader;
	}
}
