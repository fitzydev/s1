using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.UI.Management;
using UnityEngine.Events;

namespace ScheduleOne.Management
{
	// Token: 0x020004E6 RID: 1254
	[Token(Token = "0x20004E6")]
	public class ObjectField : ConfigField
	{
		// Token: 0x06001965 RID: 6501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001965")]
		[Address(RVA = "0x641470", Offset = "0x63FE70", VA = "0x180641470")]
		public ObjectField(EntityConfiguration parentConfig)
		{
		}

		// Token: 0x06001966 RID: 6502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001966")]
		[Address(RVA = "0x641280", Offset = "0x63FC80", VA = "0x180641280")]
		public void SetObject(BuildableItem obj, bool network)
		{
		}

		// Token: 0x06001967 RID: 6503 RVA: 0x000090F0 File Offset: 0x000072F0
		[Token(Token = "0x6001967")]
		[Address(RVA = "0x641130", Offset = "0x63FB30", VA = "0x180641130", Slot = "4")]
		public override bool IsValueDefault()
		{
			return default(bool);
		}

		// Token: 0x06001968 RID: 6504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001968")]
		[Address(RVA = "0x641270", Offset = "0x63FC70", VA = "0x180641270")]
		private void SelectedObjectDestroyed()
		{
		}

		// Token: 0x06001969 RID: 6505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001969")]
		[Address(RVA = "0x641180", Offset = "0x63FB80", VA = "0x180641180")]
		public void Load(ObjectFieldData data)
		{
		}

		// Token: 0x0600196A RID: 6506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600196A")]
		[Address(RVA = "0x641050", Offset = "0x63FA50", VA = "0x180641050")]
		public ObjectFieldData GetData()
		{
			return null;
		}

		// Token: 0x04001648 RID: 5704
		[Token(Token = "0x4001648")]
		[FieldOffset(Offset = "0x18")]
		public BuildableItem SelectedObject;

		// Token: 0x04001649 RID: 5705
		[Token(Token = "0x4001649")]
		[FieldOffset(Offset = "0x20")]
		public UnityEvent<BuildableItem> onObjectChanged;

		// Token: 0x0400164A RID: 5706
		[Token(Token = "0x400164A")]
		[FieldOffset(Offset = "0x28")]
		public ObjectSelector.ObjectFilter objectFilter;

		// Token: 0x0400164B RID: 5707
		[Token(Token = "0x400164B")]
		[FieldOffset(Offset = "0x30")]
		public List<Type> TypeRequirements;

		// Token: 0x0400164C RID: 5708
		[Token(Token = "0x400164C")]
		[FieldOffset(Offset = "0x38")]
		public bool DrawTransitLine;
	}
}
