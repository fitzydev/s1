using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Datas;
using UnityEngine.Events;

namespace ScheduleOne.Management
{
	// Token: 0x020004E9 RID: 1257
	[Token(Token = "0x20004E9")]
	public class RouteListField : ConfigField
	{
		// Token: 0x0600197A RID: 6522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600197A")]
		[Address(RVA = "0x64D3D0", Offset = "0x64BDD0", VA = "0x18064D3D0")]
		public RouteListField(EntityConfiguration parentConfig)
		{
		}

		// Token: 0x0600197B RID: 6523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600197B")]
		[Address(RVA = "0x64D2B0", Offset = "0x64BCB0", VA = "0x18064D2B0")]
		public void SetList(List<AdvancedTransitRoute> list, bool network, bool bypassSequenceCheck = false)
		{
		}

		// Token: 0x0600197C RID: 6524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600197C")]
		[Address(RVA = "0x64D230", Offset = "0x64BC30", VA = "0x18064D230")]
		public void Replicate()
		{
		}

		// Token: 0x0600197D RID: 6525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600197D")]
		[Address(RVA = "0x64C7B0", Offset = "0x64B1B0", VA = "0x18064C7B0")]
		public void AddItem(AdvancedTransitRoute item)
		{
		}

		// Token: 0x0600197E RID: 6526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600197E")]
		[Address(RVA = "0x64D140", Offset = "0x64BB40", VA = "0x18064D140")]
		public void RemoveItem(AdvancedTransitRoute item)
		{
		}

		// Token: 0x0600197F RID: 6527 RVA: 0x00009150 File Offset: 0x00007350
		[Token(Token = "0x600197F")]
		[Address(RVA = "0x64CAF0", Offset = "0x64B4F0", VA = "0x18064CAF0", Slot = "4")]
		public override bool IsValueDefault()
		{
			return default(bool);
		}

		// Token: 0x06001980 RID: 6528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001980")]
		[Address(RVA = "0x64C960", Offset = "0x64B360", VA = "0x18064C960")]
		public RouteListData GetData()
		{
			return null;
		}

		// Token: 0x06001981 RID: 6529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001981")]
		[Address(RVA = "0x64CB40", Offset = "0x64B540", VA = "0x18064CB40")]
		public void Load(RouteListData data)
		{
		}

		// Token: 0x04001654 RID: 5716
		[Token(Token = "0x4001654")]
		[FieldOffset(Offset = "0x18")]
		public List<AdvancedTransitRoute> Routes;

		// Token: 0x04001655 RID: 5717
		[Token(Token = "0x4001655")]
		[FieldOffset(Offset = "0x20")]
		public int MaxRoutes;

		// Token: 0x04001656 RID: 5718
		[Token(Token = "0x4001656")]
		[FieldOffset(Offset = "0x28")]
		public UnityEvent<List<AdvancedTransitRoute>> onListChanged;
	}
}
