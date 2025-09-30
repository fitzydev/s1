using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Properties;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x02000984 RID: 2436
	[Token(Token = "0x2000984")]
	[CreateAssetMenu(fileName = "CocaineDefinition", menuName = "ScriptableObjects/Item Definitions/CocaineDefinition", order = 1)]
	[Serializable]
	public class CocaineDefinition : ProductDefinition
	{
		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x0600429F RID: 17055 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060042A0 RID: 17056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000954")]
		public CocaineAppearanceSettings AppearanceSettings
		{
			[Token(Token = "0x600429F")]
			[Address(RVA = "0x66EF30", Offset = "0x66D930", VA = "0x18066EF30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60042A0")]
			[Address(RVA = "0x66F090", Offset = "0x66DA90", VA = "0x18066F090")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060042A1 RID: 17057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042A1")]
		[Address(RVA = "0x87A3F0", Offset = "0x878DF0", VA = "0x18087A3F0", Slot = "4")]
		public override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return null;
		}

		// Token: 0x060042A2 RID: 17058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042A2")]
		[Address(RVA = "0x87A690", Offset = "0x879090", VA = "0x18087A690")]
		public void Initialize(List<Property> properties, List<EDrugType> drugTypes, CocaineAppearanceSettings _appearance)
		{
		}

		// Token: 0x060042A3 RID: 17059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042A3")]
		[Address(RVA = "0x87A4E0", Offset = "0x878EE0", VA = "0x18087A4E0", Slot = "30")]
		public override ProductData GetSaveData()
		{
			return null;
		}

		// Token: 0x060042A4 RID: 17060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042A4")]
		[Address(RVA = "0x879E20", Offset = "0x878820", VA = "0x180879E20")]
		public static CocaineAppearanceSettings GetAppearanceSettings(List<Property> properties)
		{
			return null;
		}

		// Token: 0x060042A5 RID: 17061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042A5")]
		[Address(RVA = "0x87A870", Offset = "0x879270", VA = "0x18087A870")]
		public CocaineDefinition()
		{
		}

		// Token: 0x04002EC4 RID: 11972
		[Token(Token = "0x4002EC4")]
		[FieldOffset(Offset = "0x110")]
		[Header("Materials")]
		public Material RockMaterial;
	}
}
