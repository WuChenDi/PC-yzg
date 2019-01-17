using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

using MyBookShop.DataAccessHelper;
using MyBookShop.BusinessLogicLayer;
namespace MyBookShop.Web
{
	
	public partial class Register : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox TextBox1;
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
		}
		protected void ButtonCheck_Click(object sender, System.EventArgs e)//检查用户名
		{
			string loginName=TextBoxLoginName.Text;
			if(MyBookShop.BusinessLogicLayer.User.HasUser(loginName))
			{
				Response.Write("<Script Language=JavaScript>alert(\"对不起，已经存在同名用户！\")</Script>");
				TextBoxLoginName.Text="";
			}
			else
			{
				Response.Write("<Script Language=JavaScript>alert(\"恭喜你，不存在同名用户！\")</Script>");
			}
		}

		
		protected void ButtonOK_Click(object sender, System.EventArgs e)//提交用户注册信息
		{
			Hashtable ht=new Hashtable();
			ht.Add("LoginName",SqlStringConstructor.GetQuotedString(TextBoxLoginName.Text));
			ht.Add("UserName",SqlStringConstructor.GetQuotedString(TextBoxUserName.Text));
			ht.Add("Password",SqlStringConstructor.GetQuotedString(TextBoxPassword.Text));
			ht.Add("Address",SqlStringConstructor.GetQuotedString(TextBoxAddress.Text));
			ht.Add("Zip",SqlStringConstructor.GetQuotedString(TextBoxZip.Text));

			User user=new User();
			user.Add(ht);

			user.LoadData(TextBoxLoginName.Text);
			Session.Add("user_id",user.UserID);

			Response.Redirect("BookList.aspx");
		}
	}
}
