using System;
using Il2CppDummyDll;

namespace ScheduleOne.Vision
{
	// Token: 0x0200037B RID: 891
	[Token(Token = "0x200037B")]
	[Serializable]
	public class UniqueVisibilityAttribute : VisibilityAttribute
	{
		// Token: 0x060013DE RID: 5086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013DE")]
		[Address(RVA = "0x5B9770", Offset = "0x5B8170", VA = "0x1805B9770")]
		public UniqueVisibilityAttribute(string _name, float _pointsChange, string _uniquenessCode, float _multiplier = 1f, int attributeIndex = -1)
		{
		}

		// Token: 0x040012C0 RID: 4800
		[Token(Token = "0x40012C0")]
		[FieldOffset(Offset = "0x20")]
		public string uniquenessCode;
	}
}
