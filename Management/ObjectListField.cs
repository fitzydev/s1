using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.UI.Management;
using UnityEngine.Events;

namespace ScheduleOne.Management
{
	// Token: 0x020004E7 RID: 1255
	[Token(Token = "0x20004E7")]
	public class ObjectListField : ConfigField
	{
		// Token: 0x0600196B RID: 6507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600196B")]
		[Address(RVA = "0x6421A0", Offset = "0x640BA0", VA = "0x1806421A0")]
		public ObjectListField(EntityConfiguration parentConfig)
		{
		}

		// Token: 0x0600196C RID: 6508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600196C")]
		[Address(RVA = "0x641D80", Offset = "0x640780", VA = "0x180641D80")]
		public void SetList(List<BuildableItem> list, bool network)
		{
		}

		// Token: 0x0600196D RID: 6509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600196D")]
		[Address(RVA = "0x641540", Offset = "0x63FF40", VA = "0x180641540")]
		public void AddItem(BuildableItem item)
		{
		}

		// Token: 0x0600196E RID: 6510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600196E")]
		[Address(RVA = "0x641AF0", Offset = "0x6404F0", VA = "0x180641AF0")]
		public void RemoveItem(BuildableItem item)
		{
		}

		// Token: 0x0600196F RID: 6511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600196F")]
		[Address(RVA = "0x641BD0", Offset = "0x6405D0", VA = "0x180641BD0")]
		private void SelectedObjectDestroyed(BuildableItem item)
		{
		}

		// Token: 0x06001970 RID: 6512 RVA: 0x00009108 File Offset: 0x00007308
		[Token(Token = "0x6001970")]
		[Address(RVA = "0x6418C0", Offset = "0x6402C0", VA = "0x1806418C0", Slot = "4")]
		public override bool IsValueDefault()
		{
			return default(bool);
		}

		// Token: 0x06001971 RID: 6513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001971")]
		[Address(RVA = "0x641720", Offset = "0x640120", VA = "0x180641720")]
		public ObjectListFieldData GetData()
		{
			return null;
		}

		// Token: 0x06001972 RID: 6514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001972")]
		[Address(RVA = "0x641910", Offset = "0x640310", VA = "0x180641910")]
		public void Load(ObjectListFieldData data)
		{
		}

		// Token: 0x0400164D RID: 5709
		[Token(Token = "0x400164D")]
		[FieldOffset(Offset = "0x18")]
		public List<BuildableItem> SelectedObjects;

		// Token: 0x0400164E RID: 5710
		[Token(Token = "0x400164E")]
		[FieldOffset(Offset = "0x20")]
		public int MaxItems;

		// Token: 0x0400164F RID: 5711
		[Token(Token = "0x400164F")]
		[FieldOffset(Offset = "0x28")]
		public ObjectSelector.ObjectFilter objectFilter;

		// Token: 0x04001650 RID: 5712
		[Token(Token = "0x4001650")]
		[FieldOffset(Offset = "0x30")]
		public List<Type> TypeRequirements;

		// Token: 0x04001651 RID: 5713
		[Token(Token = "0x4001651")]
		[FieldOffset(Offset = "0x38")]
		public UnityEvent<List<BuildableItem>> onListChanged;
	}
}
