using System;
using System.Runtime.CompilerServices;
using FishNet.Serializing.Helping;
using Il2CppDummyDll;
using ScheduleOne.Map;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.UI;
using ScheduleOne.UI.Compass;
using ScheduleOne.Variables;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Quests
{
	// Token: 0x020002EB RID: 747
	[Token(Token = "0x20002EB")]
	[Serializable]
	public class QuestEntry : MonoBehaviour
	{
		// Token: 0x17000366 RID: 870
		// (get) Token: 0x0600107F RID: 4223 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001080 RID: 4224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000366")]
		[CodegenExclude]
		public Quest ParentQuest
		{
			[Token(Token = "0x600107F")]
			[Address(RVA = "0x42FFC0", Offset = "0x42E9C0", VA = "0x18042FFC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001080")]
			[Address(RVA = "0x42FFF0", Offset = "0x42E9F0", VA = "0x18042FFF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06001081 RID: 4225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000367")]
		[CodegenExclude]
		public string Title
		{
			[Token(Token = "0x6001081")]
			[Address(RVA = "0x4423C0", Offset = "0x440DC0", VA = "0x1804423C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06001082 RID: 4226 RVA: 0x00007C38 File Offset: 0x00005E38
		[Token(Token = "0x17000368")]
		[CodegenExclude]
		public EQuestState State
		{
			[Token(Token = "0x6001082")]
			[Address(RVA = "0x486270", Offset = "0x484C70", VA = "0x180486270")]
			get
			{
				return EQuestState.Inactive;
			}
		}

		// Token: 0x06001083 RID: 4227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001083")]
		[Address(RVA = "0xAD41D0", Offset = "0xAD2BD0", VA = "0x180AD41D0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06001084 RID: 4228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001084")]
		[Address(RVA = "0xAD55F0", Offset = "0xAD3FF0", VA = "0x180AD55F0", Slot = "5")]
		protected virtual void Start()
		{
		}

		// Token: 0x06001085 RID: 4229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001085")]
		[Address(RVA = "0xAD4D80", Offset = "0xAD3780", VA = "0x180AD4D80")]
		private void OnValidate()
		{
		}

		// Token: 0x06001086 RID: 4230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001086")]
		[Address(RVA = "0xAD4CA0", Offset = "0xAD36A0", VA = "0x180AD4CA0", Slot = "6")]
		public virtual void MinPass()
		{
		}

		// Token: 0x06001087 RID: 4231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001087")]
		[Address(RVA = "0xAD4E70", Offset = "0xAD3870", VA = "0x180AD4E70")]
		public void SetData(QuestEntryData data)
		{
		}

		// Token: 0x06001088 RID: 4232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001088")]
		[Address(RVA = "0xAD4420", Offset = "0xAD2E20", VA = "0x180AD4420")]
		public void Begin()
		{
		}

		// Token: 0x06001089 RID: 4233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001089")]
		[Address(RVA = "0xAD4440", Offset = "0xAD2E40", VA = "0x180AD4440")]
		public void Complete()
		{
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600108A")]
		[Address(RVA = "0xAD4E50", Offset = "0xAD3850", VA = "0x180AD4E50")]
		public void SetActive(bool network = true)
		{
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600108B")]
		[Address(RVA = "0xAD5070", Offset = "0xAD3A70", VA = "0x180AD5070", Slot = "7")]
		public virtual void SetState(EQuestState newState, bool network = true)
		{
		}

		// Token: 0x0600108C RID: 4236 RVA: 0x00007C50 File Offset: 0x00005E50
		[Token(Token = "0x600108C")]
		[Address(RVA = "0xAD55C0", Offset = "0xAD3FC0", VA = "0x180AD55C0", Slot = "8")]
		protected virtual bool ShouldShowPoI()
		{
			return default(bool);
		}

		// Token: 0x0600108D RID: 4237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600108D")]
		[Address(RVA = "0xAD5FB0", Offset = "0xAD49B0", VA = "0x180AD5FB0", Slot = "9")]
		protected virtual void UpdatePoI()
		{
		}

		// Token: 0x0600108E RID: 4238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600108E")]
		[Address(RVA = "0xAD4F80", Offset = "0xAD3980", VA = "0x180AD4F80")]
		public void SetPoILocation(Vector3 location)
		{
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600108F")]
		[Address(RVA = "0xAD47D0", Offset = "0xAD31D0", VA = "0x180AD47D0")]
		public void CreatePoI()
		{
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001090")]
		[Address(RVA = "0xAD4B20", Offset = "0xAD3520", VA = "0x180AD4B20")]
		public void DestroyPoI()
		{
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001091")]
		[Address(RVA = "0xAD4460", Offset = "0xAD2E60", VA = "0x180AD4460")]
		public void CreateCompassElement()
		{
		}

		// Token: 0x06001092 RID: 4242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001092")]
		[Address(RVA = "0xAD5C80", Offset = "0xAD4680", VA = "0x180AD5C80")]
		public void UpdateCompassElement()
		{
		}

		// Token: 0x06001093 RID: 4243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001093")]
		[Address(RVA = "0xAD4C30", Offset = "0xAD3630", VA = "0x180AD4C30")]
		public QuestEntryData GetSaveData()
		{
			return null;
		}

		// Token: 0x06001094 RID: 4244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001094")]
		[Address(RVA = "0xAD5D70", Offset = "0xAD4770", VA = "0x180AD5D70")]
		private void UpdateName()
		{
		}

		// Token: 0x06001095 RID: 4245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001095")]
		[Address(RVA = "0xAD4BD0", Offset = "0xAD35D0", VA = "0x180AD4BD0")]
		private void EvaluateConditions()
		{
		}

		// Token: 0x06001096 RID: 4246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001096")]
		[Address(RVA = "0xAD4ED0", Offset = "0xAD38D0", VA = "0x180AD4ED0")]
		public void SetEntryTitle(string newTitle)
		{
		}

		// Token: 0x06001097 RID: 4247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001097")]
		[Address(RVA = "0xAD4590", Offset = "0xAD2F90", VA = "0x180AD4590", Slot = "10")]
		protected virtual void CreateEntryUI()
		{
		}

		// Token: 0x06001098 RID: 4248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001098")]
		[Address(RVA = "0xAD5D40", Offset = "0xAD4740", VA = "0x180AD5D40", Slot = "11")]
		public virtual void UpdateEntryUI()
		{
		}

		// Token: 0x06001099 RID: 4249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001099")]
		[Address(RVA = "0xAD6060", Offset = "0xAD4A60", VA = "0x180AD6060")]
		public QuestEntry()
		{
		}

		// Token: 0x0600109C RID: 4252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600109C")]
		[Address(RVA = "0xAD5A60", Offset = "0xAD4460", VA = "0x180AD5A60")]
		[CompilerGenerated]
		private void <CreatePoI>g__CreateUI|37_0()
		{
		}

		// Token: 0x040010A8 RID: 4264
		[Token(Token = "0x40010A8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Header("Naming")]
		protected string EntryTitle;

		// Token: 0x040010A9 RID: 4265
		[Token(Token = "0x40010A9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected EQuestState state;

		// Token: 0x040010AA RID: 4266
		[Token(Token = "0x40010AA")]
		[FieldOffset(Offset = "0x34")]
		[Header("Settings")]
		public bool AutoComplete;

		// Token: 0x040010AB RID: 4267
		[Token(Token = "0x40010AB")]
		[FieldOffset(Offset = "0x38")]
		public Conditions AutoCompleteConditions;

		// Token: 0x040010AC RID: 4268
		[Token(Token = "0x40010AC")]
		[FieldOffset(Offset = "0x40")]
		public bool CompleteParentQuest;

		// Token: 0x040010AD RID: 4269
		[Token(Token = "0x40010AD")]
		[FieldOffset(Offset = "0x48")]
		public string EntryAddedIn;

		// Token: 0x040010AE RID: 4270
		[Token(Token = "0x40010AE")]
		[FieldOffset(Offset = "0x50")]
		[Header("PoI Settings")]
		public bool AutoCreatePoI;

		// Token: 0x040010AF RID: 4271
		[Token(Token = "0x40010AF")]
		[FieldOffset(Offset = "0x58")]
		public Transform PoILocation;

		// Token: 0x040010B0 RID: 4272
		[Token(Token = "0x40010B0")]
		[FieldOffset(Offset = "0x60")]
		public bool AutoUpdatePoILocation;

		// Token: 0x040010B1 RID: 4273
		[Token(Token = "0x40010B1")]
		[FieldOffset(Offset = "0x68")]
		public POI PoI;

		// Token: 0x040010B2 RID: 4274
		[Token(Token = "0x40010B2")]
		[FieldOffset(Offset = "0x70")]
		public UnityEvent onStart;

		// Token: 0x040010B3 RID: 4275
		[Token(Token = "0x40010B3")]
		[FieldOffset(Offset = "0x78")]
		public UnityEvent onEnd;

		// Token: 0x040010B4 RID: 4276
		[Token(Token = "0x40010B4")]
		[FieldOffset(Offset = "0x80")]
		public UnityEvent onComplete;

		// Token: 0x040010B5 RID: 4277
		[Token(Token = "0x40010B5")]
		[FieldOffset(Offset = "0x88")]
		public UnityEvent onInitialComplete;

		// Token: 0x040010B6 RID: 4278
		[Token(Token = "0x40010B6")]
		[FieldOffset(Offset = "0x90")]
		private CompassManager.Element compassElement;

		// Token: 0x040010B7 RID: 4279
		[Token(Token = "0x40010B7")]
		[FieldOffset(Offset = "0x98")]
		private QuestEntryHUDUI entryUI;

		// Token: 0x040010B8 RID: 4280
		[Token(Token = "0x40010B8")]
		[FieldOffset(Offset = "0xA0")]
		private RectTransform PoIIcon;
	}
}
