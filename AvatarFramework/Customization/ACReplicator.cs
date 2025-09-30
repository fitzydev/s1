using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Customization
{
	// Token: 0x02000A66 RID: 2662
	[Token(Token = "0x2000A66")]
	public class ACReplicator : MonoBehaviour
	{
		// Token: 0x06004891 RID: 18577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004891")]
		[Address(RVA = "0x8FBDE0", Offset = "0x8FA7E0", VA = "0x1808FBDE0")]
		private void Start()
		{
		}

		// Token: 0x06004892 RID: 18578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004892")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "4")]
		protected virtual void AvatarSettingsChanged(AvatarSettings newSettings)
		{
		}

		// Token: 0x06004893 RID: 18579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004893")]
		[Address(RVA = "0x8FB9F0", Offset = "0x8FA3F0", VA = "0x1808FB9F0")]
		public ACReplicator()
		{
		}

		// Token: 0x04003384 RID: 13188
		[Token(Token = "0x4003384")]
		[FieldOffset(Offset = "0x20")]
		public string propertyName;
	}
}
