using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000A03 RID: 2563
	[Token(Token = "0x2000A03")]
	[CreateAssetMenu(fileName = "StorableItemDefinition", menuName = "ScriptableObjects/QualityItemDefinition", order = 1)]
	[Serializable]
	public class QualityItemDefinition : StorableItemDefinition
	{
		// Token: 0x06004621 RID: 17953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004621")]
		[Address(RVA = "0x8C8830", Offset = "0x8C7230", VA = "0x1808C8830", Slot = "4")]
		public override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return null;
		}

		// Token: 0x06004622 RID: 17954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004622")]
		[Address(RVA = "0x8C88E0", Offset = "0x8C72E0", VA = "0x1808C88E0")]
		public QualityItemDefinition()
		{
		}

		// Token: 0x04003106 RID: 12550
		[Token(Token = "0x4003106")]
		[FieldOffset(Offset = "0xB8")]
		[Header("Quality")]
		public EQuality DefaultQuality;
	}
}
