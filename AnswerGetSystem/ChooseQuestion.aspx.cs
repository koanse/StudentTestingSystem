using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Configuration;

namespace AnswerGetSystem
{
    public partial class ChooseQuestion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XmlDocument answer_doc = new XmlDocument();
            string question_file = ConfigurationManager.AppSettings["question_file"].ToString();
            answer_doc.Load(question_file);
            foreach (XmlNode cur_answer in answer_doc.DocumentElement.ChildNodes)
            {
                DDL_Quests.Items.Add(cur_answer["question"].InnerText);
            }
        }

        protected void B_Answer_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Add("quest_num", DDL_Quests.SelectedIndex);
            Server.Transfer("~/AnswerPage.aspx");
        }
    }
}
