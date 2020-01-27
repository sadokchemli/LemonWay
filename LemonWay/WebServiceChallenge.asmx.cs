using log4net;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml;

namespace LemonWay
{
	/// <summary>
	/// Description résumée de WebServiceChallenge
	/// </summary>
	[WebService(Namespace = "http://tempuri.org/")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[System.ComponentModel.ToolboxItem(false)]

	public class WebServiceChallenge : System.Web.Services.WebService
	{

		ILog logger = log4net.LogManager.GetLogger("ErrorLog");
		[WebMethod]
		public int Fibonacci(int n)
		{
			try
			{
				int a = 0;
				int b = 1;
				if (n == 0) return 0;
				else if (n == 1) return 1;

				else if (n < 1 || n > 100) return -1;

				for (int i = 0; i < n; i++)
				{
					int temp = a;
					a = b;
					b = temp + b;
				}
				return a;
			}
			catch (Exception e)
			{
				logger.Error(e.Message);
				return -1;
			}
		}

		[WebMethod]
		public string XmlToJson(string xml)
		{
			XmlDocument doc = new XmlDocument();
			string json = String.Empty;

			try
			{
				doc.LoadXml(xml);
				json = JsonConvert.SerializeXmlNode(doc);
			}
			catch (Exception e)
			{
				logger.Error(e.Message);
				return "Bad Xml format";
			}
			return json;
		}
	}
}
