using System;
using System.Collections.Specialized;
using System.Net;

namespace WebHook
{
	// Token: 0x02000002 RID: 2
	internal class Https
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public static byte[] Post(string uri, NameValueCollection pairs)
		{
			byte[] result;
			using (WebClient webClient = new WebClient())
			{
				result = webClient.UploadValues(uri, pairs);
			}
			return result;
		}
	}
}