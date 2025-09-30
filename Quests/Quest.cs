using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.GameTime;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.UI;
using ScheduleOne.UI.Compass;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.Quests
{
	// Token: 0x020002E8 RID: 744
	[Token(Token = "0x20002E8")]
	[Serializable]
	public class Quest : MonoBehaviour, IGUIDRegisterable, ISaveable
	{
		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06001032 RID: 4146 RVA: 0x00007AD0 File Offset: 0x00005CD0
		// (set) Token: 0x06001033 RID: 4147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000356")]
		public EQuestState State
		{
			[Token(Token = "0x6001032")]
			[Address(RVA = "0x47D5C0", Offset = "0x47BFC0", VA = "0x18047D5C0")]
			[CompilerGenerated]
			get
			{
				return EQuestState.Inactive;
			}
			[Token(Token = "0x6001033")]
			[Address(RVA = "0x47D790", Offset = "0x47C190", VA = "0x18047D790")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06001034 RID: 4148 RVA: 0x00007AE8 File Offset: 0x00005CE8
		// (set) Token: 0x06001035 RID: 4149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000357")]
		public Guid GUID
		{
			[Token(Token = "0x6001034")]
			[Address(RVA = "0x85EFF0", Offset = "0x85D9F0", VA = "0x18085EFF0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Token(Token = "0x6001035")]
			[Address(RVA = "0x87D370", Offset = "0x87BD70", VA = "0x18087D370")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06001036 RID: 4150 RVA: 0x00007B00 File Offset: 0x00005D00
		// (set) Token: 0x06001037 RID: 4151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000358")]
		public bool IsTracked
		{
			[Token(Token = "0x6001036")]
			[Address(RVA = "0x7B8CB0", Offset = "0x7B76B0", VA = "0x1807B8CB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001037")]
			[Address(RVA = "0xAE28E0", Offset = "0xAE12E0", VA = "0x180AE28E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06001038 RID: 4152 RVA: 0x00007B18 File Offset: 0x00005D18
		[Token(Token = "0x17000359")]
		public int ActiveEntryCount
		{
			[Token(Token = "0x6001038")]
			[Address(RVA = "0xAE2600", Offset = "0xAE1000", VA = "0x180AE2600")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06001039 RID: 4153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700035A")]
		public string Title
		{
			[Token(Token = "0x6001039")]
			[Address(RVA = "0xAE2830", Offset = "0xAE1230", VA = "0x180AE2830")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x0600103A RID: 4154 RVA: 0x00007B30 File Offset: 0x00005D30
		// (set) Token: 0x0600103B RID: 4155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700035B")]
		public bool Expires
		{
			[Token(Token = "0x600103A")]
			[Address(RVA = "0xAE2720", Offset = "0xAE1120", VA = "0x180AE2720")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600103B")]
			[Address(RVA = "0xAE28B0", Offset = "0xAE12B0", VA = "0x180AE28B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x0600103C RID: 4156 RVA: 0x00007B48 File Offset: 0x00005D48
		// (set) Token: 0x0600103D RID: 4157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700035C")]
		public GameDateTime Expiry
		{
			[Token(Token = "0x600103C")]
			[Address(RVA = "0xAE2730", Offset = "0xAE1130", VA = "0x180AE2730")]
			[CompilerGenerated]
			get
			{
				return default(GameDateTime);
			}
			[Token(Token = "0x600103D")]
			[Address(RVA = "0xAE28C0", Offset = "0xAE12C0", VA = "0x180AE28C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x0600103E RID: 4158 RVA: 0x00007B60 File Offset: 0x00005D60
		[Token(Token = "0x1700035D")]
		public bool hudUIExists
		{
			[Token(Token = "0x600103E")]
			[Address(RVA = "0xAE2850", Offset = "0xAE1250", VA = "0x180AE2850")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x0600103F RID: 4159 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001040 RID: 4160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700035E")]
		public QuestHUDUI hudUI
		{
			[Token(Token = "0x600103F")]
			[Address(RVA = "0x53B7E0", Offset = "0x53A1E0", VA = "0x18053B7E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001040")]
			[Address(RVA = "0x5432B0", Offset = "0x541CB0", VA = "0x1805432B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06001041 RID: 4161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700035F")]
		public string SaveFolderName
		{
			[Token(Token = "0x6001041")]
			[Address(RVA = "0xAE27C0", Offset = "0xAE11C0", VA = "0x180AE27C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06001042 RID: 4162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000360")]
		public string SaveFileName
		{
			[Token(Token = "0x6001042")]
			[Address(RVA = "0xAE2750", Offset = "0xAE1150", VA = "0x180AE2750", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06001043 RID: 4163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000361")]
		public Loader Loader
		{
			[Token(Token = "0x6001043")]
			[Address(RVA = "0x4AAD70", Offset = "0x4A9770", VA = "0x1804AAD70", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06001044 RID: 4164 RVA: 0x00007B78 File Offset: 0x00005D78
		[Token(Token = "0x17000362")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x6001044")]
			[Address(RVA = "0x4B7AD0", Offset = "0x4B64D0", VA = "0x1804B7AD0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06001045 RID: 4165 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001046 RID: 4166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000363")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x6001045")]
			[Address(RVA = "0x62FD10", Offset = "0x62E710", VA = "0x18062FD10", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001046")]
			[Address(RVA = "0x630490", Offset = "0x62EE90", VA = "0x180630490", Slot = "14")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06001047 RID: 4167 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001048 RID: 4168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000364")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x6001047")]
			[Address(RVA = "0x548950", Offset = "0x547350", VA = "0x180548950", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001048")]
			[Address(RVA = "0x5ADF40", Offset = "0x5AC940", VA = "0x1805ADF40", Slot = "12")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06001049 RID: 4169 RVA: 0x00007B90 File Offset: 0x00005D90
		// (set) Token: 0x0600104A RID: 4170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000365")]
		public bool HasChanged
		{
			[Token(Token = "0x6001049")]
			[Address(RVA = "0xAE2740", Offset = "0xAE1140", VA = "0x180AE2740", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600104A")]
			[Address(RVA = "0xAE28D0", Offset = "0xAE12D0", VA = "0x180AE28D0", Slot = "16")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600104B RID: 4171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600104B")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "30")]
		protected virtual void Awake()
		{
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600104C")]
		[Address(RVA = "0xAE1BF0", Offset = "0xAE05F0", VA = "0x180AE1BF0", Slot = "31")]
		protected virtual void Start()
		{
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600104D")]
		[Address(RVA = "0xADFEA0", Offset = "0xADE8A0", VA = "0x180ADFEA0", Slot = "32")]
		public virtual void InitializeQuest(string title, string description, QuestEntryData[] entries, string guid)
		{
		}

		// Token: 0x0600104E RID: 4174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600104E")]
		[Address(RVA = "0xAE03C0", Offset = "0xADEDC0", VA = "0x180AE03C0", Slot = "33")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600104F")]
		[Address(RVA = "0xADDD40", Offset = "0xADC740", VA = "0x180ADDD40")]
		public void ConfigureExpiry(bool expires, GameDateTime expiry)
		{
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001050")]
		[Address(RVA = "0xADC3B0", Offset = "0xADADB0", VA = "0x180ADC3B0", Slot = "34")]
		public virtual void Begin(bool network = true)
		{
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001051")]
		[Address(RVA = "0xADDAD0", Offset = "0xADC4D0", VA = "0x180ADDAD0", Slot = "35")]
		public virtual void Complete(bool network = true)
		{
		}

		// Token: 0x06001052 RID: 4178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001052")]
		[Address(RVA = "0xADF6A0", Offset = "0xADE0A0", VA = "0x180ADF6A0", Slot = "36")]
		public virtual void Fail(bool network = true)
		{
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001053")]
		[Address(RVA = "0xADF5B0", Offset = "0xADDFB0", VA = "0x180ADF5B0", Slot = "37")]
		public virtual void Expire(bool network = true)
		{
		}

		// Token: 0x06001054 RID: 4180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001054")]
		[Address(RVA = "0xADCF40", Offset = "0xADB940", VA = "0x180ADCF40", Slot = "38")]
		public virtual void Cancel(bool network = true)
		{
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001055")]
		[Address(RVA = "0xADF300", Offset = "0xADDD00", VA = "0x180ADF300", Slot = "39")]
		public virtual void End()
		{
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001056")]
		[Address(RVA = "0xAE0F90", Offset = "0xADF990", VA = "0x180AE0F90", Slot = "40")]
		public virtual void SetQuestState(EQuestState state, bool network = true)
		{
		}

		// Token: 0x06001057 RID: 4183 RVA: 0x00007BA8 File Offset: 0x00005DA8
		[Token(Token = "0x6001057")]
		[Address(RVA = "0xAD40E0", Offset = "0xAD2AE0", VA = "0x180AD40E0", Slot = "41")]
		protected virtual bool ShouldShowJournalEntry()
		{
			return default(bool);
		}

		// Token: 0x06001058 RID: 4184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001058")]
		[Address(RVA = "0xAE0DF0", Offset = "0xADF7F0", VA = "0x180AE0DF0", Slot = "42")]
		public virtual void SetQuestEntryState(int entryIndex, EQuestState state, bool network = true)
		{
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001059")]
		[Address(RVA = "0xAE0750", Offset = "0xADF150", VA = "0x180AE0750", Slot = "43")]
		protected virtual void MinPass()
		{
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600105A")]
		[Address(RVA = "0xADD0E0", Offset = "0xADBAE0", VA = "0x180ADD0E0", Slot = "44")]
		protected virtual void CheckExpiry()
		{
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600105B")]
		[Address(RVA = "0xADD030", Offset = "0xADBA30", VA = "0x180ADD030")]
		private void CheckAutoComplete()
		{
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x00007BC0 File Offset: 0x00005DC0
		[Token(Token = "0x600105C")]
		[Address(RVA = "0x48DCC0", Offset = "0x48C6C0", VA = "0x18048DCC0", Slot = "45")]
		protected virtual bool CanExpire()
		{
			return default(bool);
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600105D")]
		[Address(RVA = "0xAE09D0", Offset = "0xADF3D0", VA = "0x180AE09D0", Slot = "46")]
		protected virtual void SendExpiryReminder()
		{
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600105E")]
		[Address(RVA = "0xAE08B0", Offset = "0xADF2B0", VA = "0x180AE08B0", Slot = "47")]
		protected virtual void SendExpiredNotification()
		{
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600105F")]
		[Address(RVA = "0xAE0AF0", Offset = "0xADF4F0", VA = "0x180AE0AF0", Slot = "6")]
		public void SetGUID(Guid guid)
		{
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001060")]
		[Address(RVA = "0x4F8890", Offset = "0x4F7290", VA = "0x1804F8890")]
		public void SetSubtitle(string subtitle)
		{
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001061")]
		[Address(RVA = "0xAE0B50", Offset = "0xADF550", VA = "0x180AE0B50", Slot = "48")]
		public virtual void SetIsTracked(bool tracked)
		{
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001062")]
		[Address(RVA = "0xAE1550", Offset = "0xADFF50", VA = "0x180AE1550", Slot = "49")]
		public virtual void SetupJournalEntry()
		{
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001063")]
		[Address(RVA = "0xADF240", Offset = "0xADDC40", VA = "0x180ADF240")]
		private void DestroyJournalEntry()
		{
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001064")]
		[Address(RVA = "0xAE0450", Offset = "0xADEE50", VA = "0x180AE0450")]
		private void JournalEntryClicked()
		{
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001065")]
		[Address(RVA = "0xAE0470", Offset = "0xADEE70", VA = "0x180AE0470")]
		private void JournalEntryHoverStart()
		{
		}

		// Token: 0x06001066 RID: 4198 RVA: 0x00007BD8 File Offset: 0x00005DD8
		[Token(Token = "0x6001066")]
		[Address(RVA = "0xADF9C0", Offset = "0xADE3C0", VA = "0x180ADF9C0")]
		public int GetMinsUntilExpiry()
		{
			return 0;
		}

		// Token: 0x06001067 RID: 4199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001067")]
		[Address(RVA = "0xADF790", Offset = "0xADE190", VA = "0x180ADF790")]
		public string GetExpiryText()
		{
			return null;
		}

		// Token: 0x06001068 RID: 4200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001068")]
		[Address(RVA = "0xAE1320", Offset = "0xADFD20", VA = "0x180AE1320", Slot = "50")]
		public virtual QuestHUDUI SetupHudUI()
		{
			return null;
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001069")]
		[Address(RVA = "0xAE2340", Offset = "0xAE0D40", VA = "0x180AE2340")]
		public void UpdateHUDUI()
		{
		}

		// Token: 0x0600106A RID: 4202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600106A")]
		[Address(RVA = "0xADC520", Offset = "0xADAF20", VA = "0x180ADC520")]
		public void BopHUDUI()
		{
		}

		// Token: 0x0600106B RID: 4203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600106B")]
		[Address(RVA = "0x4423B0", Offset = "0x440DB0", VA = "0x1804423B0", Slot = "51")]
		public virtual string GetQuestTitle()
		{
			return null;
		}

		// Token: 0x0600106C RID: 4204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600106C")]
		[Address(RVA = "0xADF900", Offset = "0xADE300", VA = "0x180ADF900")]
		public QuestEntry GetFirstActiveEntry()
		{
			return null;
		}

		// Token: 0x0600106D RID: 4205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600106D")]
		[Address(RVA = "0xADF1A0", Offset = "0xADDBA0", VA = "0x180ADF1A0")]
		private void DestroyHudUI()
		{
		}

		// Token: 0x0600106E RID: 4206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600106E")]
		[Address(RVA = "0xADDF40", Offset = "0xADC940", VA = "0x180ADDF40", Slot = "52")]
		public virtual RectTransform CreateDetailDisplay(RectTransform parent)
		{
			return null;
		}

		// Token: 0x0600106F RID: 4207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600106F")]
		[Address(RVA = "0xADF0E0", Offset = "0xADDAE0", VA = "0x180ADF0E0")]
		public void DestroyDetailDisplay()
		{
		}

		// Token: 0x06001070 RID: 4208 RVA: 0x00007BF0 File Offset: 0x00005DF0
		[Token(Token = "0x6001070")]
		[Address(RVA = "0x48DCC0", Offset = "0x48C6C0", VA = "0x18048DCC0", Slot = "53")]
		public virtual bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x06001071 RID: 4209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001071")]
		[Address(RVA = "0xADFB80", Offset = "0xADE580", VA = "0x180ADFB80", Slot = "54")]
		public virtual SaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x06001072 RID: 4210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001072")]
		[Address(RVA = "0xADFE60", Offset = "0xADE860", VA = "0x180ADFE60", Slot = "18")]
		public string GetSaveString()
		{
			return null;
		}

		// Token: 0x06001073 RID: 4211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001073")]
		[Address(RVA = "0xAE04E0", Offset = "0xADEEE0", VA = "0x180AE04E0", Slot = "55")]
		public virtual void Load(QuestData data)
		{
		}

		// Token: 0x06001074 RID: 4212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001074")]
		[Address(RVA = "0xADFA70", Offset = "0xADE470", VA = "0x180ADFA70")]
		public static Quest GetQuest(string questName)
		{
			return null;
		}

		// Token: 0x06001075 RID: 4213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001075")]
		[Address(RVA = "0xAE2460", Offset = "0xAE0E60", VA = "0x180AE2460")]
		public Quest()
		{
		}

		// Token: 0x06001077 RID: 4215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001077")]
		[Address(RVA = "0xAE20D0", Offset = "0xAE0AD0", VA = "0x180AE20D0")]
		[CompilerGenerated]
		private void <Start>g__Initialize|88_0()
		{
		}

		// Token: 0x06001079 RID: 4217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001079")]
		[Address(RVA = "0xAE1E80", Offset = "0xAE0880", VA = "0x180AE1E80")]
		[CompilerGenerated]
		private void <CreateDetailDisplay>g__ShowOnMap|122_0()
		{
		}

		// Token: 0x04001076 RID: 4214
		[Token(Token = "0x4001076")]
		public const int MAX_HUD_ENTRY_LABELS = 10;

		// Token: 0x04001077 RID: 4215
		[Token(Token = "0x4001077")]
		public const int CriticalExpiryThreshold = 120;

		// Token: 0x04001078 RID: 4216
		[Token(Token = "0x4001078")]
		[FieldOffset(Offset = "0x0")]
		public static List<Quest> Quests;

		// Token: 0x04001079 RID: 4217
		[Token(Token = "0x4001079")]
		[FieldOffset(Offset = "0x8")]
		public static Quest HoveredQuest;

		// Token: 0x0400107A RID: 4218
		[Token(Token = "0x400107A")]
		[FieldOffset(Offset = "0x10")]
		public static List<Quest> ActiveQuests;

		// Token: 0x0400107E RID: 4222
		[Token(Token = "0x400107E")]
		[FieldOffset(Offset = "0x38")]
		[Header("Basic Settings")]
		[SerializeField]
		protected string title;

		// Token: 0x0400107F RID: 4223
		[Token(Token = "0x400107F")]
		[FieldOffset(Offset = "0x40")]
		public string Subtitle;

		// Token: 0x04001080 RID: 4224
		[Token(Token = "0x4001080")]
		[FieldOffset(Offset = "0x48")]
		public Action onSubtitleChanged;

		// Token: 0x04001081 RID: 4225
		[Token(Token = "0x4001081")]
		[FieldOffset(Offset = "0x50")]
		[TextArea(3, 10)]
		public string Description;

		// Token: 0x04001082 RID: 4226
		[Token(Token = "0x4001082")]
		[FieldOffset(Offset = "0x58")]
		public string StaticGUID;

		// Token: 0x04001083 RID: 4227
		[Token(Token = "0x4001083")]
		[FieldOffset(Offset = "0x60")]
		public bool TrackOnBegin;

		// Token: 0x04001084 RID: 4228
		[Token(Token = "0x4001084")]
		[FieldOffset(Offset = "0x64")]
		public EExpiryVisibility ExpiryVisibility;

		// Token: 0x04001085 RID: 4229
		[Token(Token = "0x4001085")]
		[FieldOffset(Offset = "0x68")]
		public bool AutoCompleteOnAllEntriesComplete;

		// Token: 0x04001086 RID: 4230
		[Token(Token = "0x4001086")]
		[FieldOffset(Offset = "0x69")]
		public bool PlayQuestCompleteSound;

		// Token: 0x04001087 RID: 4231
		[Token(Token = "0x4001087")]
		[FieldOffset(Offset = "0x6C")]
		public int CompletionXP;

		// Token: 0x0400108A RID: 4234
		[Token(Token = "0x400108A")]
		[FieldOffset(Offset = "0x7C")]
		[Header("Entries")]
		public bool AutoStartFirstEntry;

		// Token: 0x0400108B RID: 4235
		[Token(Token = "0x400108B")]
		[FieldOffset(Offset = "0x80")]
		public List<QuestEntry> Entries;

		// Token: 0x0400108C RID: 4236
		[Token(Token = "0x400108C")]
		[FieldOffset(Offset = "0x88")]
		[Header("UI")]
		public RectTransform IconPrefab;

		// Token: 0x0400108D RID: 4237
		[Token(Token = "0x400108D")]
		[FieldOffset(Offset = "0x90")]
		[Header("PoI Settings")]
		public GameObject PoIPrefab;

		// Token: 0x0400108E RID: 4238
		[Token(Token = "0x400108E")]
		[FieldOffset(Offset = "0x98")]
		[Header("Events")]
		public UnityEvent onQuestBegin;

		// Token: 0x0400108F RID: 4239
		[Token(Token = "0x400108F")]
		[FieldOffset(Offset = "0xA0")]
		public UnityEvent<EQuestState> onQuestEnd;

		// Token: 0x04001090 RID: 4240
		[Token(Token = "0x4001090")]
		[FieldOffset(Offset = "0xA8")]
		public UnityEvent onActiveState;

		// Token: 0x04001091 RID: 4241
		[Token(Token = "0x4001091")]
		[FieldOffset(Offset = "0xB0")]
		public UnityEvent<bool> onTrackChange;

		// Token: 0x04001092 RID: 4242
		[Token(Token = "0x4001092")]
		[FieldOffset(Offset = "0xB8")]
		public UnityEvent onComplete;

		// Token: 0x04001093 RID: 4243
		[Token(Token = "0x4001093")]
		[FieldOffset(Offset = "0xC0")]
		public UnityEvent onInitialComplete;

		// Token: 0x04001094 RID: 4244
		[Token(Token = "0x4001094")]
		[FieldOffset(Offset = "0xC8")]
		[Header("Reminders")]
		public bool ShouldSendExpiryReminder;

		// Token: 0x04001095 RID: 4245
		[Token(Token = "0x4001095")]
		[FieldOffset(Offset = "0xC9")]
		public bool ShouldSendExpiredNotification;

		// Token: 0x04001096 RID: 4246
		[Token(Token = "0x4001096")]
		[FieldOffset(Offset = "0xD0")]
		protected RectTransform journalEntry;

		// Token: 0x04001097 RID: 4247
		[Token(Token = "0x4001097")]
		[FieldOffset(Offset = "0xD8")]
		protected RectTransform entryTitleRect;

		// Token: 0x04001098 RID: 4248
		[Token(Token = "0x4001098")]
		[FieldOffset(Offset = "0xE0")]
		protected RectTransform trackedRect;

		// Token: 0x04001099 RID: 4249
		[Token(Token = "0x4001099")]
		[FieldOffset(Offset = "0xE8")]
		protected Text entryTimeLabel;

		// Token: 0x0400109A RID: 4250
		[Token(Token = "0x400109A")]
		[FieldOffset(Offset = "0xF0")]
		protected Image criticalTimeBackground;

		// Token: 0x0400109B RID: 4251
		[Token(Token = "0x400109B")]
		[FieldOffset(Offset = "0xF8")]
		protected RectTransform detailPanel;

		// Token: 0x0400109D RID: 4253
		[Token(Token = "0x400109D")]
		[FieldOffset(Offset = "0x108")]
		public Action onHudUICreated;

		// Token: 0x0400109E RID: 4254
		[Token(Token = "0x400109E")]
		[FieldOffset(Offset = "0x110")]
		private bool expiryReminderSent;

		// Token: 0x0400109F RID: 4255
		[Token(Token = "0x400109F")]
		[FieldOffset(Offset = "0x118")]
		private CompassManager.Element compassElement;

		// Token: 0x040010A3 RID: 4259
		[Token(Token = "0x40010A3")]
		[FieldOffset(Offset = "0x131")]
		protected bool autoInitialize;
	}
}
