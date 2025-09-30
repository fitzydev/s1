using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000766 RID: 1894
	[Token(Token = "0x2000766")]
	public abstract class PlayerSingleton<T> : MonoBehaviour where T : PlayerSingleton<T>
	{
		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x06003348 RID: 13128 RVA: 0x0000E238 File Offset: 0x0000C438
		[Token(Token = "0x17000773")]
		public static bool InstanceExists
		{
			[Token(Token = "0x6003348")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x06003349 RID: 13129 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600334A RID: 13130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000774")]
		public static T Instance
		{
			[Token(Token = "0x6003349")]
			get
			{
				return null;
			}
			[Token(Token = "0x600334A")]
			protected set
			{
			}
		}

		// Token: 0x0600334B RID: 13131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600334B")]
		protected virtual void Awake()
		{
		}

		// Token: 0x0600334C RID: 13132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600334C")]
		protected virtual void Start()
		{
		}

		// Token: 0x0600334D RID: 13133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600334D")]
		public virtual void OnStartClient(bool IsOwner)
		{
		}

		// Token: 0x0600334E RID: 13134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600334E")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x0600334F RID: 13135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600334F")]
		protected PlayerSingleton()
		{
		}

		// Token: 0x04002399 RID: 9113
		[Token(Token = "0x4002399")]
		[FieldOffset(Offset = "0x0")]
		private static T instance;
	}
}
