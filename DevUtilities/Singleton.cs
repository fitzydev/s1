using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x0200076A RID: 1898
	[Token(Token = "0x200076A")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x0600335E RID: 13150 RVA: 0x0000E280 File Offset: 0x0000C480
		[Token(Token = "0x17000776")]
		public static bool InstanceExists
		{
			[Token(Token = "0x600335E")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x0600335F RID: 13151 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003360 RID: 13152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000777")]
		public static T Instance
		{
			[Token(Token = "0x600335F")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003360")]
			protected set
			{
			}
		}

		// Token: 0x06003361 RID: 13153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003361")]
		protected virtual void Start()
		{
		}

		// Token: 0x06003362 RID: 13154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003362")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06003363 RID: 13155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003363")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06003364 RID: 13156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003364")]
		protected Singleton()
		{
		}

		// Token: 0x040023A7 RID: 9127
		[Token(Token = "0x40023A7")]
		[FieldOffset(Offset = "0x0")]
		private static T instance;

		// Token: 0x040023A8 RID: 9128
		[Token(Token = "0x40023A8")]
		[FieldOffset(Offset = "0x0")]
		protected bool Destroyed;
	}
}
