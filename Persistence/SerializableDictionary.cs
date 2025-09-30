using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Persistence
{
	// Token: 0x020003AB RID: 939
	[Token(Token = "0x20003AB")]
	[Serializable]
	public class SerializableDictionary<TKey, TValue> : ISerializationCallbackReceiver, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
	{
		// Token: 0x06001522 RID: 5410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001522")]
		public void OnBeforeSerialize()
		{
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001523")]
		public void OnAfterDeserialize()
		{
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001524")]
		public void Add(TKey key, TValue value)
		{
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x000087A8 File Offset: 0x000069A8
		[Token(Token = "0x6001525")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x000087C0 File Offset: 0x000069C0
		[Token(Token = "0x6001526")]
		public bool Remove(TKey key)
		{
			return default(bool);
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x000087D8 File Offset: 0x000069D8
		[Token(Token = "0x6001527")]
		public bool TryGetValue(TKey key, out TValue value)
		{
			return default(bool);
		}

		// Token: 0x170003FB RID: 1019
		[Token(Token = "0x170003FB")]
		public TValue this[TKey key]
		{
			[Token(Token = "0x6001528")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001529")]
			set
			{
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x0600152A RID: 5418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003FC")]
		public ICollection<TKey> Keys
		{
			[Token(Token = "0x600152A")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x0600152B RID: 5419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003FD")]
		public ICollection<TValue> Values
		{
			[Token(Token = "0x600152B")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x0600152C RID: 5420 RVA: 0x000087F0 File Offset: 0x000069F0
		[Token(Token = "0x170003FE")]
		public int Count
		{
			[Token(Token = "0x600152C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x0600152D RID: 5421 RVA: 0x00008808 File Offset: 0x00006A08
		[Token(Token = "0x170003FF")]
		public bool IsReadOnly
		{
			[Token(Token = "0x600152D")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600152E")]
		public void Add(KeyValuePair<TKey, TValue> item)
		{
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600152F")]
		public void Clear()
		{
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x00008820 File Offset: 0x00006A20
		[Token(Token = "0x6001530")]
		public bool Contains(KeyValuePair<TKey, TValue> item)
		{
			return default(bool);
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001531")]
		public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x00008838 File Offset: 0x00006A38
		[Token(Token = "0x6001532")]
		public bool Remove(KeyValuePair<TKey, TValue> item)
		{
			return default(bool);
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001533")]
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001534")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001535")]
		public SerializableDictionary()
		{
		}

		// Token: 0x0400139B RID: 5019
		[Token(Token = "0x400139B")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<TKey> keys;

		// Token: 0x0400139C RID: 5020
		[Token(Token = "0x400139C")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<TValue> values;

		// Token: 0x0400139D RID: 5021
		[Token(Token = "0x400139D")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<TKey, TValue> dictionary;
	}
}
