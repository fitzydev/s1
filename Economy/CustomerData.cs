using System;
using System.Collections.Generic;
using EasyButtons;
using Il2CppDummyDll;
using ScheduleOne.GameTime;
using ScheduleOne.ItemFramework;
using ScheduleOne.Properties;
using UnityEngine;

namespace ScheduleOne.Economy
{
	// Token: 0x020005DF RID: 1503
	[Token(Token = "0x20005DF")]
	[CreateAssetMenu(fileName = "CustomerData", menuName = "ScriptableObjects/CustomerData", order = 1)]
	[Serializable]
	public class CustomerData : ScriptableObject
	{
		// Token: 0x0600246C RID: 9324 RVA: 0x0000B670 File Offset: 0x00009870
		[Token(Token = "0x600246C")]
		[Address(RVA = "0x6D0DA0", Offset = "0x6CF7A0", VA = "0x1806D0DA0")]
		public static float GetQualityScalar(EQuality quality)
		{
			return 0f;
		}

		// Token: 0x0600246D RID: 9325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600246D")]
		[Address(RVA = "0x6D0C00", Offset = "0x6CF600", VA = "0x1806D0C00")]
		public List<EDay> GetOrderDays(float dependence, float normalizedRelationship)
		{
			return null;
		}

		// Token: 0x0600246E RID: 9326 RVA: 0x0000B688 File Offset: 0x00009888
		[Token(Token = "0x600246E")]
		[Address(RVA = "0x6D0B20", Offset = "0x6CF520", VA = "0x1806D0B20")]
		public float GetAdjustedWeeklySpend(float normalizedRelationship)
		{
			return 0f;
		}

		// Token: 0x0600246F RID: 9327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600246F")]
		[Address(RVA = "0x6D0DE0", Offset = "0x6CF7E0", VA = "0x1806D0DE0")]
		[Button]
		public void RandomizeAffinities()
		{
		}

		// Token: 0x06002470 RID: 9328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002470")]
		[Address(RVA = "0x6D1120", Offset = "0x6CFB20", VA = "0x1806D1120")]
		[Button]
		public void RandomizeProperties()
		{
		}

		// Token: 0x06002471 RID: 9329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002471")]
		[Address(RVA = "0x6D1430", Offset = "0x6CFE30", VA = "0x1806D1430")]
		[Button]
		public void RandomizeTiming()
		{
		}

		// Token: 0x06002472 RID: 9330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002472")]
		[Address(RVA = "0x6D0A90", Offset = "0x6CF490", VA = "0x1806D0A90")]
		[Button]
		public void ClearInvalid()
		{
		}

		// Token: 0x06002473 RID: 9331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002473")]
		[Address(RVA = "0x6D1490", Offset = "0x6CFE90", VA = "0x1806D1490")]
		public CustomerData()
		{
		}

		// Token: 0x04001C48 RID: 7240
		[Token(Token = "0x4001C48")]
		[FieldOffset(Offset = "0x18")]
		public CustomerAffinityData DefaultAffinityData;

		// Token: 0x04001C49 RID: 7241
		[Token(Token = "0x4001C49")]
		[FieldOffset(Offset = "0x20")]
		[Header("Preferred Properties - Properties the customer prefers in a product.")]
		public List<Property> PreferredProperties;

		// Token: 0x04001C4A RID: 7242
		[Token(Token = "0x4001C4A")]
		[FieldOffset(Offset = "0x28")]
		[Header("Spending Behaviour")]
		public float MinWeeklySpend;

		// Token: 0x04001C4B RID: 7243
		[Token(Token = "0x4001C4B")]
		[FieldOffset(Offset = "0x2C")]
		public float MaxWeeklySpend;

		// Token: 0x04001C4C RID: 7244
		[Token(Token = "0x4001C4C")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 7f)]
		public int MinOrdersPerWeek;

		// Token: 0x04001C4D RID: 7245
		[Token(Token = "0x4001C4D")]
		[FieldOffset(Offset = "0x34")]
		[Range(0f, 7f)]
		public int MaxOrdersPerWeek;

		// Token: 0x04001C4E RID: 7246
		[Token(Token = "0x4001C4E")]
		[FieldOffset(Offset = "0x38")]
		[Header("Timing Settings")]
		public int OrderTime;

		// Token: 0x04001C4F RID: 7247
		[Token(Token = "0x4001C4F")]
		[FieldOffset(Offset = "0x3C")]
		public EDay PreferredOrderDay;

		// Token: 0x04001C50 RID: 7248
		[Token(Token = "0x4001C50")]
		[FieldOffset(Offset = "0x40")]
		[Header("Standards")]
		public ECustomerStandard Standards;

		// Token: 0x04001C51 RID: 7249
		[Token(Token = "0x4001C51")]
		[FieldOffset(Offset = "0x44")]
		[Header("Direct approaching")]
		public bool CanBeDirectlyApproached;

		// Token: 0x04001C52 RID: 7250
		[Token(Token = "0x4001C52")]
		[FieldOffset(Offset = "0x45")]
		public bool GuaranteeFirstSampleSuccess;

		// Token: 0x04001C53 RID: 7251
		[Token(Token = "0x4001C53")]
		[FieldOffset(Offset = "0x48")]
		[Range(0f, 5f)]
		[Tooltip("The average relationship of mutual customers to provide a 50% chance of success")]
		public float MinMutualRelationRequirement;

		// Token: 0x04001C54 RID: 7252
		[Token(Token = "0x4001C54")]
		[FieldOffset(Offset = "0x4C")]
		[Tooltip("The average relationship of mutual customers to provide a 100% chance of success")]
		[Range(0f, 5f)]
		public float MaxMutualRelationRequirement;

		// Token: 0x04001C55 RID: 7253
		[Token(Token = "0x4001C55")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("If direct approach fails, whats the chance the police will be called?")]
		[Range(0f, 1f)]
		public float CallPoliceChance;

		// Token: 0x04001C56 RID: 7254
		[Token(Token = "0x4001C56")]
		[FieldOffset(Offset = "0x54")]
		[Header("Dependence")]
		[Tooltip("How quickly the customer builds dependence")]
		[Range(0f, 2f)]
		public float DependenceMultiplier;

		// Token: 0x04001C57 RID: 7255
		[Token(Token = "0x4001C57")]
		[FieldOffset(Offset = "0x58")]
		[Tooltip("The customer's starting (and lowest possible) dependence level")]
		[Range(0f, 1f)]
		public float BaseAddiction;

		// Token: 0x04001C58 RID: 7256
		[Token(Token = "0x4001C58")]
		[FieldOffset(Offset = "0x60")]
		public Action onChanged;
	}
}
