using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace kTesterLib.Service
{
    public static class Helper
    {
        public static string GetDescription(this UserRights userRight)
        {
			Type type = userRight.GetType();

			MemberInfo[] memInfo = type.GetMember(userRight.ToString());
			if (memInfo != null && memInfo.Length > 0)
			{
				object[] attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
				if (attrs != null && attrs.Length > 0)
					return ((DescriptionAttribute)attrs[0]).Description;
			}

			return userRight.ToString();
		}

		public static string GetCryptPass(string password)
		{
			//потом сделать зашифровку пароля
			return password;
		}
	}
}
